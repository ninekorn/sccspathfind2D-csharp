﻿namespace AtomicTorch.CBND.CoreMod.Characters.Mobs
{
    using AtomicTorch.CBND.CoreMod.Characters.Player;
    using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
    using AtomicTorch.CBND.CoreMod.Events;
    using AtomicTorch.CBND.CoreMod.Items.Food;
    using AtomicTorch.CBND.CoreMod.Items.Generic;
    using AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons;
    using AtomicTorch.CBND.CoreMod.Skills;
    using AtomicTorch.CBND.CoreMod.SoundPresets;
    using AtomicTorch.CBND.CoreMod.Stats;
    using AtomicTorch.CBND.CoreMod.Systems.CharacterDeath;
    using AtomicTorch.CBND.CoreMod.Systems.Droplists;
    using AtomicTorch.CBND.GameApi.Data.Characters;
    using AtomicTorch.CBND.GameApi.Scripting;


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

    public class MobFloater : ProtoCharacterMob
    {
        public override bool AiIsRunAwayFromHeavyVehicles => false;

        public override double BiomaterialValueMultiplier => 2.0;

        public override float CharacterWorldHeight => 2.4f;

        public override float CharacterWorldWeaponOffsetRanged => 1.1f;

        public override double MobKillExperienceMultiplier => 5.0;

        public override string Name => "Floater";

        public override ObjectMaterial ObjectMaterial => ObjectMaterial.SoftTissues;

        public override double PhysicsBodyAccelerationCoef => 1;

        public override double PhysicsBodyFriction => 0.5;

        public override double StatDefaultHealthMax => 300;

        public override double StatMoveSpeed => 2.5;

        protected override void FillDefaultEffects(Effects effects)
        {
            base.FillDefaultEffects(effects);

            // easy to kill by normal means, but have very tough protection against certain types of damage
            effects.AddValue(this, StatName.DefenseImpact, 1.0)
                   .AddValue(this, StatName.DefenseKinetic,   0.2)
                   .AddValue(this, StatName.DefenseHeat,      0.1)
                   .AddValue(this, StatName.DefenseChemical,  1.0)
                   .AddValue(this, StatName.DefensePsi,       1.0)
                   .AddValue(this, StatName.DefenseRadiation, 1.0);
        }

        protected override void PrepareProtoCharacterMob(
            out ProtoCharacterSkeleton skeleton,
            ref double scale,
            DropItemsList lootDroplist)
        {
            skeleton = GetProtoEntity<SkeletonFloater>();

            // primary loot
            lootDroplist
                .Add<ItemInsectMeatRaw>(count: 1, countRandom: 1)
                .Add<ItemSlime>(count: 10,        countRandom: 10)
                .Add<ItemToxin>(count: 5,         countRandom: 5)
                .Add<ItemSalt>(count: 5,          countRandom: 5)
                .Add<ItemRubberRaw>(count: 8,     countRandom: 4)
                .Add<ItemKeinite>(count: 2,       countRandom: 2);

            // extra loot
            lootDroplist.Add(condition: SkillHunting.ServerRollExtraLoot,
                             nestedList: new DropItemsList(outputs: 2)
                                         .Add<ItemInsectMeatRaw>(count: 1)
                                         .Add<ItemSlime>(count: 5)
                                         .Add<ItemToxin>(count: 2)
                                         .Add<ItemSalt>(count: 2));

            if (!IsServer)
            {
                return;
            }

            ServerCharacterDeathMechanic.CharacterKilled += ServerCharacterKilledHandler;

            static void ServerCharacterKilledHandler(
                ICharacter attackerCharacter,
                ICharacter targetCharacter)
            {
                if (!attackerCharacter.IsNpc
                    && targetCharacter.ProtoCharacter.GetType() == typeof(MobFloater)
                    && (SharedEventHelper.SharedIsInsideEventArea<EventMigrationFloater>(attackerCharacter.Position)
                        || SharedEventHelper.SharedIsInsideEventArea<EventMigrationFloater>(targetCharacter.Position)))
                {
                    PlayerCharacter.GetPrivateState(attackerCharacter)
                                   .CompletionistData
                                   .ServerOnParticipatedInEvent(Api.GetProtoEntity<EventMigrationFloater>());
                }
            }
        }

        protected override void ServerInitializeCharacterMob(ServerInitializeData data)
        {
            base.ServerInitializeCharacterMob(data);

            var weaponProto = GetProtoEntity<ItemWeaponMobFloaterNova>();
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
                distanceEnemyTooFar: 15,
                movementDirection: out var movementDirection,
                rotationAngleRad: out var rotationAngleRad);

            this.ServerSetMobInput(character, movementDirection, rotationAngleRad);
        }*/



        protected override void ServerUpdateMob(ServerUpdateData data)
        {
            //pathfindaction.engagepathfindaction(data);
            //CharacterMobPublicState theobjstate = data.PublicState;
            //ICharacter thegameobject = data.GameObject;


            if (data.PublicState.CurrentStats.indexswtc == 1)
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








                /*
                if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].theplayercharacter != null)
                {

                    //sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray] = sccspathfindmovement.engagepathfindmovementornot(data.PublicState, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray], currentMobWolfClass);
                    //sccspathfindactionstruct thedata = sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray] ;

                    



                    //pathfindpermobdatalight
                }
                else
                {
                    //check the aggro distance. and if the movement.x == 0 and movement.y == 0 then ProcessAgressiveAI hasn't been engaged yet for the npc to chase the character, i think.
                    //so if using the core movement direction of how it's built in ServerCharacterAiHelper is the way to go in order to not have to check for null in the array.
                    //i am unsure, maybe it's better this way. i didn't benchmark

                    //var pathfindpermobdata = sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray];

                    chasethecharacter(data.PublicState, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].thenpccharacter);

                    if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].theplayercharacter != null)
                    {
                        var mobdatalight = sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray];
                        mobdatalight.theplayercharacterlast = sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].theplayercharacter;

                        sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray] = mobdatalight;
                    }
                    else
                    {
                        if (sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray].hasclearedarrays == 0)
                        {
                            var pathfindpermobdata = sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray];

                            sccspathfindaction.cleararrays(data.PublicState, data.GameObject, sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray]);
                            pathfindpermobdata.theplayercharacter = null;
                            pathfindpermobdata.hasclearedarrays = 1;
                            sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray] = pathfindpermobdata;
                        }

                    }

                }*/
            }
            else if (data.PublicState.CurrentStats.indexswtc == -1)
            {
                var npcchar = data.GameObject;

                var playercharacter = ServerCharacterAiHelper.GetClosestTargetPlayer(npcchar);

                int indexofmobtype = 0;
                data.PublicState.CurrentStats.indexinmainarray = sccspathfindarrays.ProcessAddToMainList(data.GameObject, out indexofmobtype);
                data.PublicState.CurrentStats.mobtypeofindex = indexofmobtype;


                var pathfindpermobdata = sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray];
                pathfindpermobdata.stopatpathfindendswtc = sccspathfindglobals.stopatpathfindendswtc;

                pathfindpermobdata.thenpccharacter = npcchar;
                pathfindpermobdata.theplayercharacter = playercharacter;


                sccspathfindarrays.pathfindpermobdatalight[data.PublicState.CurrentStats.mobtypeofindex][data.PublicState.CurrentStats.indexinmainarray] = pathfindpermobdata;

                data.PublicState.CurrentStats.indexswtc = 1;
            }

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

            //var character1 = thegameobject;
            //var currentStats1 = theobjstate.CurrentStats;

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

            //sccspathfindactionstruct.movementoptiontype = 3;
            //sccspathfindactionstruct.anglerad = anglerad;
            //sccspathfindactionstruct.direction = currentnpcglobaldata.directionnpctopathfindnodef;



            this.ServerSetMobInput(thegameobject, movementDirection, rotationAngleRad);
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
            //var character1 = thegameobject;
            //var currentStats1 = theobjstate.CurrentStats;

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

            this.ServerSetMobInput(thegameobject, movementDirection, rotationAngleRad);

            if (movementDirection.X != 0 || movementDirection.Y != 0)
            {
                if (sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray].theplayercharacter == null)
                {
                    var playercharacter = ServerCharacterAiHelper.GetClosestTargetPlayer(thegameobject);
                    var themobdata = sccspathfindarrays.pathfindpermobdata[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray];
                    themobdata.startpathfindmainswtc = 0;
                    themobdata.playercharacter = playercharacter;

                    sccspathfindarrays.pathfindpermobdata[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray] = themobdata;

                    var datalight = sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray];
                    datalight.theplayercharacter = playercharacter;// ServerCharacterAiHelper.GetClosestTargetPlayer(thegameobject);
                    sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray] = datalight;
                }
            }
        }


        private void retreatthecharacter(CharacterMobPublicState theobjstate, ICharacter thegameobject, sccspathfindactionstruct sccspathfindactionstruct)//ServerUpdateData data)
        {
            // var character1 = thegameobject;
            //var currentStats1 = theobjstate.CurrentStats;

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

            /*sccsvec2float dirnpctoplayer = new sccsvec2float();
            dirnpctoplayer.x = currentnpcglobaldata.playerpos.x - currentnpcglobaldata.npcpos.x;
            dirnpctoplayer.y = currentnpcglobaldata.playerpos.y - currentnpcglobaldata.npcpos.y;

            dirnpctoplayer.x /= currentnpcglobaldata.distnpctoplayersqrt;
            dirnpctoplayer.y /= currentnpcglobaldata.distnpctoplayersqrt;*/

            float anglerad = Vector2F.AngleDeg(new Vector2F(sccspathfindactionstruct.direction.X, sccspathfindactionstruct.direction.Y), new Vector2F(dirright.x, dirright.y));

            ServerCharacterAiHelper.ProcessRetreatingAi(thegameobject, 0.25f, out var movementDirection1, out var rotationAngleRad1); //distnpctoplayersqrt

            this.ServerSetMobInput(thegameobject, movementDirection0, rotationAngleRad0);// sccspathfindactionstruct.anglerad);


            //sccspathfindactionstruct.movementoptiontype = 3;
            //sccspathfindactionstruct.anglerad = anglerad;
            //sccspathfindactionstruct.direction = currentnpcglobaldata.directionnpctopathfindnodef;

        }




    }
}