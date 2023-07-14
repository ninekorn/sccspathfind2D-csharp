namespace AtomicTorch.CBND.CoreMod.Characters.Mobs
{
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.CoreMod.Stats;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;
    using AtomicTorch.CBND.CoreMod.Systems.ServerTimers;
    using AtomicTorch.CBND.CoreMod.Systems.Weapons;
    using AtomicTorch.CBND.GameApi.Data.Characters;
    using AtomicTorch.CBND.GameApi.Data.State;
    using AtomicTorch.CBND.GameApi.Data.World;
    using AtomicTorch.CBND.GameApi.Scripting;

    using AtomicTorch.CBND.CoreMod.Characters;
    using static sccspathfindstructs;
    using AtomicTorch.GameEngine.Common.Primitives;
    using AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind;

    public class MobPragmiumBeetleMinion
        : ProtoCharacterMob
            <MobPragmiumBeetleMinion.PrivateState,
                CharacterMobPublicState,
                CharacterMobClientState>
    {
        public override bool AiIsRunAwayFromHeavyVehicles => false;

        public override float CharacterWorldWeaponOffsetRanged => 0.2f;

        public override bool IsAvailableInCompletionist => false;

        public override double MobKillExperienceMultiplier => 1.5;

        public override string Name => Api.GetProtoEntity<MobPragmiumBeetle>().Name;

        public override ObjectMaterial ObjectMaterial => ObjectMaterial.Glass;



        public override float CharacterWorldHeight => 0000000000000000.800000000000000f;

        public override double StatDefaultHealthMax => 00000000000000000000000000000120.00000000000000000000000000000000;

        public override double StatMoveSpeed => 00000000000000000000000000000002.90000000000000000000000000000000;









        public override void ServerOnDeath(ICharacter character)
        {
            this.ServerSendDeathSoundEvent(character);

            // remove by timer
            ServerTimersSystem.AddAction(
                delaySeconds: 5,
                () => this.ServerSetSpawnState(character, MobSpawnState.Despawning));
        }

        public override bool SharedOnDamage(
            WeaponFinalCache weaponCache,
            IWorldObject targetObject,
            double damagePreMultiplier,
            double damagePostMultiplier,
            out double obstacleBlockDamageCoef,
            out double damageApplied)
        {
            var byCharacter = weaponCache.Character;
            var result = base.SharedOnDamage(weaponCache,
                                             targetObject,
                                             damagePreMultiplier,
                                             damagePostMultiplier,
                                             out obstacleBlockDamageCoef,
                                             out damageApplied);

            if (IsServer
                && result
                && byCharacter is not null
                && !byCharacter.IsNpc)
            {
                // record the damage dealt by player
                var targetCharacter = (ICharacter)targetObject;
                var privateState = GetPrivateState(targetCharacter);
                privateState.DamageTracker?.RegisterDamage(byCharacter, targetCharacter, damageApplied);
            }

            return result;
        }

        protected override void FillDefaultEffects(Effects effects)
        {
            base.FillDefaultEffects(effects);

            effects.AddValue(this, StatName.DefenseImpact, 0.4)
                   .AddValue(this, StatName.DefenseKinetic, 0.4)
                   .AddValue(this, StatName.DefenseExplosion, 0.4)
                   .AddValue(this, StatName.DefenseHeat, 0.3) // lower, to make energy weapons more useful
                   .AddValue(this, StatName.DefenseChemical, 0.25)
                   .AddValue(this, StatName.DefenseCold, 0.2)
                   .AddValue(this, StatName.DefensePsi, 1.0)
                   .AddValue(this, StatName.DefenseRadiation, 1.0);
        }

        protected override void PrepareProtoCharacterMob(
            out ProtoCharacterSkeleton skeleton,
            ref double scale,
            DropItemsList lootDroplist)
        {
            skeleton = GetProtoEntity<SkeletonPragmiumBeetle>();

            // no loot
            lootDroplist.Clear();
        }

        protected override void ServerInitializeCharacterMob(ServerInitializeData data)
        {
            base.ServerInitializeCharacterMob(data);

            var weaponProto = GetProtoEntity<ItemWeaponMobPragmiumBeetleClaws>();
            data.PrivateState.WeaponState.SharedSetWeaponProtoOnly(weaponProto);
            data.PublicState.SharedSetCurrentWeaponProtoOnly(weaponProto);
        }

        /* protected override void ServerUpdateMob(ServerUpdateData data)
         {
             if (data.PublicState.IsDead)
             {
                 return;
             }

             var character = data.GameObject;

             ServerCharacterAiHelper.ProcessAggressiveAi(
                 character,
                 targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character),
                 isRetreating: false,
                 isRetreatingForHeavyVehicles: false,
                 distanceRetreat: 0,
                 distanceEnemyTooClose: 1,
                 distanceEnemyTooFar: 19,
                 movementDirection: out var movementDirection,
                 rotationAngleRad: out var rotationAngleRad);

             this.ServerSetMobInput(character, movementDirection, rotationAngleRad);
         }

         */





        protected override void ServerUpdateMob(ServerUpdateData data)
        {
            if (data.PublicState.CurrentStats.indexswtc == 1)
            {
                if (data.PublicState.CurrentStats.themobidlesleepcounter >= data.PublicState.CurrentStats.themobidlesleepcountermax)
                {
                    sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray] = sccspathfindaction.engagepathfindaction(data.PublicState, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].thenpccharacter, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray]);

                    if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 0)
                    {
                        retreatthecharacter(data.PublicState, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].thenpccharacter, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray]);
                    }
                    else if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 1)
                    {
                        chasethecharacter(data.PublicState, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].thenpccharacter);
                    }
                    else if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 2)
                    {
                        movetopathfindnode(data.PublicState, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].thenpccharacter, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray]);
                    }
                    else if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 3)
                    {
                        stopstabilizethecharacter(data.PublicState, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].thenpccharacter, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray]);
                    }

                    data.PublicState.CurrentStats.themobidlesleepcounter = 0;
                }
                data.PublicState.CurrentStats.themobidlesleepcounter++;
            }
            else if (data.PublicState.CurrentStats.indexswtc == -1)
            {
                var npcchar = data.GameObject;

                //var playercharacter = ServerCharacterAiHelper.GetClosestTargetPlayer(npcchar);

                int indexofmobtype = 0;
                data.PublicState.CurrentStats.indexinmainarray = sccspathfindarrays.ProcessAddToMainList(data.GameObject, out indexofmobtype);
                data.PublicState.CurrentStats.mobtypeofindex = indexofmobtype;


                var pathfindpermobdata = sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray];
                pathfindpermobdata.stopatpathfindendswtc = sccspathfindglobals.stopatpathfindendswtc;

                pathfindpermobdata.thenpccharacter = npcchar;
                //pathfindpermobdata.theplayercharacter = playercharacter;


                sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray] = pathfindpermobdata;

                data.PublicState.CurrentStats.indexswtc = 1;
            }
        }

        private void stopstabilizethecharacter(CharacterMobPublicState theobjstate, ICharacter thegameobject, sccspathfindactionstruct sccspathfindactionstruct)
        {
            sccsvec2float dirright = new sccsvec2float();
            dirright.x = 1.0f;
            dirright.y = 0.0f;

            ServerCharacterAiHelper.ProcessAggressiveAi(
                thegameobject,
                targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(thegameobject),
                isRetreating: theobjstate.CurrentStats.HealthCurrent < theobjstate.CurrentStats.HealthMax / 3,
                isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                distanceRetreat: 7,
                distanceEnemyTooClose: 1,
                distanceEnemyTooFar: 3.5,
                movementDirection: out var movementDirection,
                rotationAngleRad: out var rotationAngleRad);

            if (sccspathfindactionstruct.stopatpathfindendswtc == 1)
            {
                float anglerad = Vector2F.AngleDeg(new Vector2F(sccspathfindactionstruct.direction.X, sccspathfindactionstruct.direction.Y), new Vector2F(dirright.x, dirright.y));

                ServerCharacterAiHelper.ProcessRetreatingAi(thegameobject, 0.25f, out var movementDirection0, out var rotationAngleRad0); //distnpctoplayersqrt

                this.ServerSetMobInput(thegameobject, movementDirection0, rotationAngleRad);// sccspathfindactionstruct.anglerad);
            }

            this.ServerSetMobInput(thegameobject, movementDirection, rotationAngleRad);
        }

        private void movetopathfindnode(CharacterMobPublicState theobjstate, ICharacter thegameobject, sccspathfindactionstruct sccspathfindactionstruct)
        {

            ServerCharacterAiHelper.ProcessAggressiveAi(
                thegameobject,
                targetCharacter: sccspathfindactionstruct.theplayercharacter, //ServerCharacterAiHelper.GetClosestTargetPlayer(thegameobject),
                isRetreating: theobjstate.CurrentStats.HealthCurrent < theobjstate.CurrentStats.HealthMax / 3,
                isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                distanceRetreat: 7,
                distanceEnemyTooClose: 1,
                distanceEnemyTooFar: 3.5,
                movementDirection: out var movementDirection,
                rotationAngleRad: out var rotationAngleRad);

            this.ServerSetMobInput(thegameobject, sccspathfindactionstruct.direction, rotationAngleRad);// sccspathfindactionstruct.anglerad);
        }

        private void chasethecharacter(CharacterMobPublicState theobjstate, ICharacter thegameobject)
        {
            var playercharacter = ServerCharacterAiHelper.GetClosestTargetPlayer(thegameobject);

            ServerCharacterAiHelper.ProcessAggressiveAi(
                thegameobject,
                targetCharacter: playercharacter,
                isRetreating: theobjstate.CurrentStats.HealthCurrent < theobjstate.CurrentStats.HealthMax / 3,
                isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                distanceRetreat: 7,
                distanceEnemyTooClose: 1,
                distanceEnemyTooFar: 3.5,
                movementDirection: out var movementDirection,
                rotationAngleRad: out var rotationAngleRad);

            this.ServerSetMobInput(thegameobject, movementDirection, rotationAngleRad);

            if (playercharacter != null)
            {

                if (sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray].theplayercharacter == null)
                {
                    var themobdata = sccspathfindarrays.pathfindpermobdata[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray];
                    themobdata.startpathfindmainswtc = 0;
                    themobdata.playercharacter = playercharacter;

                    sccspathfindarrays.pathfindpermobdata[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray] = themobdata;

                    var datalight = sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray];
                    datalight.theplayercharacter = playercharacter;// ServerCharacterAiHelper.GetClosestTargetPlayer(thegameobject);
                    sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray] = datalight;
                }
            }

            /*
            //IF THE MOB IS EVEN TRYING TO LOOK AT THE CHARACTER, I THINK THE MOVEMENT DIRECTION IS BECOMING GREATER THAN 0 FOR THE X OR Y AND I TRY AND USE THAT OPPORTUNITY TO REACTIVATE THE PATHFIND.
            if (movementDirection.X != 0 || movementDirection.Y != 0)
            {
                          
            }*/
        }


        private void retreatthecharacter(CharacterMobPublicState theobjstate, ICharacter thegameobject, sccspathfindactionstruct sccspathfindactionstruct)
        {
            ServerCharacterAiHelper.ProcessAggressiveAi(
                thegameobject,
                targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(thegameobject),
                isRetreating: theobjstate.CurrentStats.HealthCurrent < theobjstate.CurrentStats.HealthMax / 3,
                isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                distanceRetreat: 7,
                distanceEnemyTooClose: 1,
                distanceEnemyTooFar: 3.5,
                movementDirection: out var movementDirection0,
                rotationAngleRad: out var rotationAngleRad0);



            sccsvec2float dirright = new sccsvec2float();
            dirright.x = 1.0f;
            dirright.y = 0.0f;

            float anglerad = Vector2F.AngleDeg(new Vector2F(sccspathfindactionstruct.direction.X, sccspathfindactionstruct.direction.Y), new Vector2F(dirright.x, dirright.y));

            ServerCharacterAiHelper.ProcessRetreatingAi(thegameobject, 0.25f, out var movementDirection1, out var rotationAngleRad1); //distnpctoplayersqrt

            this.ServerSetMobInput(thegameobject, movementDirection0, rotationAngleRad0);// sccspathfindactionstruct.anglerad);
        }









        public class PrivateState : CharacterMobPrivateState, ICharacterPrivateStateWithBossDamageTracker
        {
            [TempOnly]
            public ServerBossDamageTracker DamageTracker { get; set; }
        }
    }
}