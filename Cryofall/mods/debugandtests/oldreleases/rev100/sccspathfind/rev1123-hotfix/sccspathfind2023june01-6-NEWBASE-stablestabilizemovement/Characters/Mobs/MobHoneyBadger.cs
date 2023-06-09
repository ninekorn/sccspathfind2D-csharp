﻿namespace AtomicTorch.CBND.CoreMod.Characters.Mobs
{
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.Items.Devices;
    using AtomicTorch.CBND.CoreMod.Items.Food;
    using AtomicTorch.CBND.CoreMod.Items.Generic;
    using AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons;
    using AtomicTorch.CBND.CoreMod.Objects;
    using AtomicTorch.CBND.CoreMod.Skills;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.CoreMod.Stats;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;
    using AtomicTorch.CBND.GameApi.Data.World;


    using AtomicTorch.CBND.CoreMod.Characters;
    using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;
    using AtomicTorch.CBND.GameApi.Data.Characters;
    using AtomicTorch.GameEngine.Common.Primitives;
    using static sccspathfindstructs;
    using AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind;


    public class MobHoneyBadger : ProtoCharacterMob
    {
        public override bool AiIsRunAwayFromHeavyVehicles => true;

        public override float CharacterWorldHeight => 1f;

        public override double MobKillExperienceMultiplier => 1.5;

        public override string Name => "Honey badger";

        public override ObjectMaterial ObjectMaterial => ObjectMaterial.SoftTissues;

        public override double StatDefaultHealthMax => 120;

        public override double StatMoveSpeed => 2.5;//2.3

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
            skeleton = GetProtoEntity<SkeletonHoneyBadger>();

            // primary loot
            lootDroplist
                .Add<ItemMeatRaw>(count: 1)
                .Add<ItemLeather>(count: 1, countRandom: 1)
                .Add<ItemBones>(count: 1,   countRandom: 1);

            // random loot
            lootDroplist.Add(probability: 1 / 2.0,
                             nestedList: new DropItemsList(outputs: 1)
                                         .Add<ItemAnimalFat>(count: 1, countRandom: 1)
                                         .Add<ItemBones>(count: 1,     countRandom: 1));

            // extra loot
            lootDroplist.Add(condition: SkillHunting.ServerRollExtraLoot,
                             nestedList: new DropItemsList(outputs: 2)
                                         .Add<ItemMeatRaw>(count: 1, weight: 1 / 2.0)
                                         .Add<ItemLeather>(count: 1)
                                         .Add<ItemBones>(count: 1)
                                         .Add<ItemAnimalFat>(count: 1));
        }

        protected override void ServerInitializeCharacterMob(ServerInitializeData data)
        {
            base.ServerInitializeCharacterMob(data);

            var weaponProto = GetProtoEntity<ItemWeaponMobGenericMedium>();
            data.PrivateState.WeaponState.SharedSetWeaponProtoOnly(weaponProto);
            data.PublicState.SharedSetCurrentWeaponProtoOnly(weaponProto);
        }
        /*
        protected override void ServerUpdateMob(ServerUpdateData data)
        {
            var character = data.GameObject;

            ServerCharacterAiHelper.ProcessAggressiveAi(
                character,
                targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character),
                isRetreating: false,
                isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                distanceRetreat: 0,
                distanceEnemyTooClose: 1,
                distanceEnemyTooFar: 10,
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

                int indexofmobtype = 0;
                data.PublicState.CurrentStats.indexinmainarray = sccspathfindarrays.ProcessAddToMainList(data.GameObject, out indexofmobtype);
                data.PublicState.CurrentStats.mobtypeofindex = indexofmobtype;


                var pathfindpermobdata = sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray];
                pathfindpermobdata.stopatpathfindendswtc = sccspathfindglobals.stopatpathfindendswtc;

                sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray] = pathfindpermobdata;

                data.PublicState.CurrentStats.indexswtc = 1;
            }


            //sccspathfindactionstruct thedata = sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray] ;

            sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray] = sccspathfindaction.engagepathfindaction(data.PublicState, data.GameObject, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray]);

            if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 0)
            {
                retreatthecharacter(data.PublicState, data.GameObject, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray]);
            }
            else if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 1)
            {
                chasethecharacter(data.PublicState, data.GameObject);
            }
            else if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 2)
            {
                movetopathfindnode(data.PublicState, data.GameObject, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray]);
            }
            else if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].movementoptiontype == 3)
            {
                stopstabilizethecharacter(data.PublicState, data.GameObject, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray]);
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


            if (sccspathfindactionstruct.stopatpathfindendswtc == 1)
            {
                float anglerad = Vector2F.AngleDeg(new Vector2F(sccspathfindactionstruct.direction.X, sccspathfindactionstruct.direction.Y), new Vector2F(dirright.x, dirright.y));

                ServerCharacterAiHelper.ProcessRetreatingAi(thegameobject, 0.25f, out var movementDirection0, out var rotationAngleRad0); //distnpctoplayersqrt

                this.ServerSetMobInput(thegameobject, movementDirection0, sccspathfindactionstruct.anglerad);
            }

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

            this.ServerSetMobInput(thegameobject, sccspathfindactionstruct.direction, rotationAngleRad);// sccspathfindactionstruct.anglerad);
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