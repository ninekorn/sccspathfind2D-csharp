namespace AtomicTorch.CBND.CoreMod.Characters.Mobs
{
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.Items.Devices;
    using AtomicTorch.CBND.CoreMod.Items.Food;
    using AtomicTorch.CBND.CoreMod.Items.Generic;
    using AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons;
    using AtomicTorch.CBND.CoreMod.Skills;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.CoreMod.Stats;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;


    using AtomicTorch.CBND.CoreMod.Characters;
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;
    using AtomicTorch.CBND.CoreMod.Items.Generic;
    using AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;
    using AtomicTorch.CBND.GameApi.Data.Characters;
    using AtomicTorch.CBND.GameApi.Data.Physics;
    using AtomicTorch.CBND.GameApi.Scripting;
    using AtomicTorch.CBND.GameApi.ServicesServer;
    using AtomicTorch.GameEngine.Common.DataStructures;
    using AtomicTorch.GameEngine.Common.Primitives;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static sccspathfindstructs;
    using sccsvec2int = sccspathfindstructs.sccsvec2int;
    using AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind;

    public class MobBlackBeetle : ProtoCharacterMob
    {
        public override bool AiIsRunAwayFromHeavyVehicles => false;

        public override float CharacterWorldHeight => 1f;

        public override double MobKillExperienceMultiplier => 1.5;

        public override string Name => "Black beetle";

        public override ObjectMaterial ObjectMaterial => ObjectMaterial.HardTissues;

        public override double StatDefaultHealthMax => 120;

        public override double StatMoveSpeed => 2.7;

        protected override void FillDefaultEffects(Effects effects)
        {
            base.FillDefaultEffects(effects);

            effects.AddValue(this, StatName.DefenseImpact, 0.2)
                   .AddValue(this, StatName.DefenseKinetic,  0.2)
                   .AddValue(this, StatName.DefenseHeat,     0.2)
                   .AddValue(this, StatName.DefenseChemical, 0.4);
        }

        protected override void PrepareProtoCharacterMob(
            out ProtoCharacterSkeleton skeleton,
            ref double scale,
            DropItemsList lootDroplist)
        {
            skeleton = GetProtoEntity<SkeletonBlackBeetle>();

            // primary loot
            lootDroplist
                .Add<ItemInsectMeatRaw>(count: 1, countRandom: 1)
                .Add<ItemSlime>(count: 2,         countRandom: 1)
                // requires device
                .Add<ItemKeiniteRaw>(count: 1, countRandom: 1,
                                     condition: ItemKeiniteCollector.ConditionHasDeviceEquipped);

            // extra loot
            lootDroplist.Add(condition: SkillHunting.ServerRollExtraLoot,
                             nestedList: new DropItemsList(outputs: 1)
                                         .Add<ItemInsectMeatRaw>(count: 1)
                                         .Add<ItemSlime>(count: 1));
        }

        protected override void ServerInitializeCharacterMob(ServerInitializeData data)
        {
            base.ServerInitializeCharacterMob(data);

            var weaponProto = GetProtoEntity<ItemWeaponMobBurrowerClaws>();
            data.PrivateState.WeaponState.SharedSetWeaponProtoOnly(weaponProto);
            data.PublicState.SharedSetCurrentWeaponProtoOnly(weaponProto);
        }
        /*
        protected override void ServerUpdateMob(ServerUpdateData data)
        {
            var character = data.GameObject;
            var currentStats = data.PublicState.CurrentStats;

            ServerCharacterAiHelper.ProcessAggressiveAi(
                character,
                targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character),
                isRetreating: currentStats.HealthCurrent < currentStats.HealthMax / 4,
                isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                distanceRetreat: 7,
                distanceEnemyTooClose: 1,
                distanceEnemyTooFar: 6,
                movementDirection: out var movementDirection,
                rotationAngleRad: out var rotationAngleRad);

            this.ServerSetMobInput(character, movementDirection, rotationAngleRad);
        }*/




        //sccspathfindaction pathfindaction = new sccspathfindaction();
        protected override void ServerUpdateMob(ServerUpdateData data)
        {
            //pathfindaction.engagepathfindaction(data);
            //CharacterMobPublicState theobjstate = data.PublicState;
            //ICharacter thegameobject = data.GameObject;

            if (data.PublicState.CurrentStats.indexswtc == -1)
            {
                data.PublicState.CurrentStats.indexinmainarray = sccspathfindarrays.ProcessAddToMainList(data.GameObject);
                data.PublicState.CurrentStats.indexswtc = 1;
            }

            //sccspathfindactionstruct thedata = sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.indexinmainarray];

            sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.indexinmainarray] = sccspathfindaction.engagepathfindaction(data.PublicState, data.GameObject, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.indexinmainarray]);

            if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 0)
            {
                retreatthecharacter(data.PublicState, data.GameObject, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.indexinmainarray]);
            }
            else if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 1)
            {
                chasethecharacter(data.PublicState, data.GameObject);
            }
            else if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 2)
            {
                movetopathfindnode(data.PublicState, data.GameObject, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.indexinmainarray]);
            }
            else if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 3)
            {
                stopstabilizethecharacter(data.PublicState, data.GameObject, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.indexinmainarray]);
            }
            //pathfindpermobdatalight

        }
        private void stopstabilizethecharacter(CharacterMobPublicState theobjstate, ICharacter thegameobject, sccspathfindactionstruct sccspathfindactionstruct)//ServerUpdateData data)
        {
            sccsvec2float dirright = new sccsvec2float();
            dirright.x = 1.0f;
            dirright.y = 0.0f;

            /*sccsvec2float dirnpctoplayer = new sccsvec2float();
            dirnpctoplayer.x = currentnpcglobaldata.playerpos.x - currentnpcglobaldata.npcpos.x;
            dirnpctoplayer.y = currentnpcglobaldata.playerpos.y - currentnpcglobaldata.npcpos.y;

            dirnpctoplayer.x /= currentnpcglobaldata.distnpctoplayersqrt;
            dirnpctoplayer.y /= currentnpcglobaldata.distnpctoplayersqrt;*/

            float anglerad = Vector2F.AngleDeg(new Vector2F(sccspathfindactionstruct.direction.X, sccspathfindactionstruct.direction.Y), new Vector2F(dirright.x, dirright.y));

            ServerCharacterAiHelper.ProcessRetreatingAi(thegameobject, 0.25f, out var movementDirection0, out var rotationAngleRad0); //distnpctoplayersqrt

            this.ServerSetMobInput(thegameobject, movementDirection0, sccspathfindactionstruct.anglerad);


            //sccspathfindactionstruct.movementoptiontype = 3;
            //sccspathfindactionstruct.anglerad = anglerad;
            //sccspathfindactionstruct.direction = currentnpcglobaldata.directionnpctopathfindnodef;

            var character1 = thegameobject;
            var currentStats1 = theobjstate.CurrentStats;

            ServerCharacterAiHelper.ProcessAggressiveAi(
                character1,
                targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character1),
                isRetreating: currentStats1.HealthCurrent < currentStats1.HealthMax / 3,
                isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                distanceRetreat: 7,
                distanceEnemyTooClose: 1,
                distanceEnemyTooFar: 3.5,
                movementDirection: out var movementDirection,
                rotationAngleRad: out var rotationAngleRad);

            this.ServerSetMobInput(character1, movementDirection, rotationAngleRad);
        }

        private void movetopathfindnode(CharacterMobPublicState theobjstate, ICharacter thegameobject, sccspathfindactionstruct sccspathfindactionstruct)//ServerUpdateData data)
        {

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

            this.ServerSetMobInput(thegameobject, sccspathfindactionstruct.direction, rotationAngleRad);//sccspathfindactionstruct.anglerad);
        }



        private void chasethecharacter(CharacterMobPublicState theobjstate, ICharacter thegameobject)//ServerUpdateData data)
        {
            var character1 = thegameobject;
            var currentStats1 = theobjstate.CurrentStats;

            ServerCharacterAiHelper.ProcessAggressiveAi(
                character1,
                targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character1),
                isRetreating: currentStats1.HealthCurrent < currentStats1.HealthMax / 3,
                isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                distanceRetreat: 7,
                distanceEnemyTooClose: 1,
                distanceEnemyTooFar: 3.5,
                movementDirection: out var movementDirection,
                rotationAngleRad: out var rotationAngleRad);

            this.ServerSetMobInput(character1, movementDirection, rotationAngleRad);
        }


        private void retreatthecharacter(CharacterMobPublicState theobjstate, ICharacter thegameobject, sccspathfindactionstruct sccspathfindactionstruct)//ServerUpdateData data)
        {
            sccsvec2float dirright = new sccsvec2float();
            dirright.x = 1.0f;
            dirright.y = 0.0f;

            /*sccsvec2float dirnpctoplayer = new sccsvec2float();
            dirnpctoplayer.x = currentnpcglobaldata.playerpos.x - currentnpcglobaldata.npcpos.x;
            dirnpctoplayer.y = currentnpcglobaldata.playerpos.y - currentnpcglobaldata.npcpos.y;

            dirnpctoplayer.x /= currentnpcglobaldata.distnpctoplayersqrt;
            dirnpctoplayer.y /= currentnpcglobaldata.distnpctoplayersqrt;*/

            float anglerad = Vector2F.AngleDeg(new Vector2F(sccspathfindactionstruct.direction.X, sccspathfindactionstruct.direction.Y), new Vector2F(dirright.x, dirright.y));

            ServerCharacterAiHelper.ProcessRetreatingAi(thegameobject, 0.25f, out var movementDirection0, out var rotationAngleRad); //distnpctoplayersqrt

            this.ServerSetMobInput(thegameobject, movementDirection0, rotationAngleRad);// sccspathfindactionstruct.anglerad);
            //sccspathfindactionstruct.movementoptiontype = 3;
            //sccspathfindactionstruct.anglerad = anglerad;
            //sccspathfindactionstruct.direction = currentnpcglobaldata.directionnpctopathfindnodef;

        }



    }
}