using AtomicTorch.CBND.CoreMod.Characters;
using AtomicTorch.CBND.GameApi.Data.Characters;
using AtomicTorch.GameEngine.Common.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using static sccspathfindstructs;
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
using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;
using AtomicTorch.CBND.CoreMod.Characters.Mobs;

namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    // CharacterMobPublicState,
    //CharacterMobClientState
    public class sccspathfindmovement: MobWolf//ServerCharacterAiHelper //IProtoCharacterMob// MobWolf
    {
        private static readonly IWorldServerService ServerWorldService
            = Api.IsServer
                  ? Api.Server.World
                  : null;

        public sccspathfindactionstruct engagepathfindmovementornot(CharacterMobPublicState theobjstate, sccspathfindactionstruct sccspathfindactionstruct, object thetypeofmobscriptclass)
        {
            //thetypeofmobscriptclass

            //MobWolf mobwolfscript = (MobWolf)thetypeofmobscriptclass;

            sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray] = sccspathfindaction.engagepathfindaction(theobjstate, sccspathfindactionstruct.thenpccharacter, sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray]);
            if (sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray].movementoptiontype == 0)
            {
                retreatthecharacter(theobjstate, sccspathfindactionstruct.thenpccharacter, sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray]);
            }
            else if (sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray].movementoptiontype == 1)
            {
                chasethecharacter(theobjstate, sccspathfindactionstruct.thenpccharacter);
            }
            else if (sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray].movementoptiontype == 2)
            {
                movetopathfindnode(theobjstate, sccspathfindactionstruct.thenpccharacter, sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray]);
            }
            else if (sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray].movementoptiontype == 3)
            {
                stopstabilizethecharacter(theobjstate, sccspathfindactionstruct.thenpccharacter, sccspathfindarrays.pathfindpermobdatalight[theobjstate.CurrentStats.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray]);
            }
            return sccspathfindactionstruct;
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


            if (sccspathfindactionstruct.stopatpathfindendswtc == 1)
            {
                float anglerad = Vector2F.AngleDeg(new Vector2F(sccspathfindactionstruct.direction.X, sccspathfindactionstruct.direction.Y), new Vector2F(dirright.x, dirright.y));

                ServerCharacterAiHelper.ProcessRetreatingAi(thegameobject, 0.25f, out var movementDirection0, out var rotationAngleRad0); //distnpctoplayersqrt

                this.ServerSetMobInput(thegameobject, movementDirection0, rotationAngleRad);// sccspathfindactionstruct.anglerad);
            }

            //sccspathfindactionstruct.movementoptiontype = 3;
            //sccspathfindactionstruct.anglerad = anglerad;
            //sccspathfindactionstruct.direction = currentnpcglobaldata.directionnpctopathfindnodef;



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
