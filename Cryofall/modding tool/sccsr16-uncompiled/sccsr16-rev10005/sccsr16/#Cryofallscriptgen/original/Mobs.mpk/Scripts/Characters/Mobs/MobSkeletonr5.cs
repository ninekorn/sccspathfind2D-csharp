namespace AtomicTorch.CBND.CoreMod.Characters.Mobs
{
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.Items.Generic;
    using AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons;
    using AtomicTorch.CBND.CoreMod.Skills;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.CoreMod.Stats;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;

    using AtomicTorch.CBND.CoreMod.Characters;

    using static sccspathfindstructs;

    using AtomicTorch.CBND.GameApi.Scripting;
    using AtomicTorch.CBND.GameApi.ServicesServer;
    using AtomicTorch.GameEngine.Common.Primitives;
    using AtomicTorch.CBND.GameApi.Data.Characters;
    using AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind;
    using AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons;
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.Items.Food;
    using AtomicTorch.CBND.CoreMod.Items.Generic;
    using AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons;
    using AtomicTorch.CBND.CoreMod.Objects;
    using AtomicTorch.CBND.CoreMod.Skills;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.CoreMod.Stats;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;
    using AtomicTorch.CBND.GameApi.Data.World;
    using AtomicTorch.CBND.CoreMod.Items.Weapons.Melee;
    using System;

    public class MobSkeletonr5 : ProtoCharacterMob//, IProtoObjectPsiSource
    // public class MobWolf : ProtoCharacterMob
    {

        public static MobSkeletonr5 currentMobSkeletonClassr5;


        private static readonly IWorldServerService ServerWorldService
            = Api.IsServer
                  ? Api.Server.World
                  : null;
        public override bool AiIsRunAwayFromHeavyVehicles => false;

        public override float CharacterWorldWeaponOffsetRanged => 0.4f;

        public override double MobKillExperienceMultiplier => 1.0;

        public override string Name => "Skeleton";

        public override ObjectMaterial ObjectMaterial => ObjectMaterial.SoftTissues;



        public override float CharacterWorldHeight => 0000000000000001.6500000000000000f;

        public override double StatDefaultHealthMax => 00000000000000000000000000000095.00000000000000000000000000000000;

        public override double StatMoveSpeed => 00000000000000000000000000000001.9900000000000000000000000000000;







        protected override void FillDefaultEffects(Effects effects)
        {
            base.FillDefaultEffects(effects);

            effects.AddValue(this, StatName.DefenseImpact, 0.4);
        }

        protected override void PrepareProtoCharacterMob(
            out ProtoCharacterSkeleton skeleton,
            ref double scale,
            DropItemsList lootDroplist)
        {



            skeleton = GetProtoEntity<SkeletonSkeletonr5>();

            // primary loot
            lootDroplist
                .Add<ItemFur>(count: 1, countRandom: 1)
                .Add<ItemBones>(count: 1, countRandom: 2)
                .Add<ItemAnimalFat>(count: 1, probability: 1 / 3.0);

            // extra loot
            lootDroplist.Add(condition: SkillHunting.ServerRollExtraLoot,
                             nestedList: new DropItemsList(outputs: 2)
                                         .Add<ItemFur>(count: 1)
                                         .Add<ItemBones>(count: 1)
                                         .Add<ItemAnimalFat>(count: 1, weight: 1 / 2.0));


        }

        protected override void ServerInitializeCharacterMob(ServerInitializeData data)
        {
            currentMobSkeletonClassr5 = this;

            base.ServerInitializeCharacterMob(data);

            var weaponProto = GetProtoEntity<ItemWeaponMobSwordSkeletonr5>();// ItemWeaponMobSkeletonSwordr5 //ItemWeaponMobSandTyrantMelee
            data.PrivateState.WeaponState.SharedSetWeaponProtoOnly(weaponProto);
            data.PublicState.SharedSetCurrentWeaponProtoOnly(weaponProto);
        }
        /*
        protected override void ServerUpdateMob(ServerUpdateData data)
        {
            var npccharacter = data.GameObject;

            ServerCharacterAiHelper.ProcessAggressiveAi(
            npccharacter,
            targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(npccharacter),
            isRetreating: false,
            isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
            distanceRetreat: 0,
            distanceEnemyTooClose: 1,
            distanceEnemyTooFar: 5,
            movementDirection: out var movementDirection,
            rotationAngleRad: out var rotationAngleRad);

            this.ServerSetMobInput(npccharacter, movementDirection, rotationAngleRad);

        }*/

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

                //Console.WriteLine("skeleton created:" + data.PublicState.CurrentStats.indexinmainarray);

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
    }
}