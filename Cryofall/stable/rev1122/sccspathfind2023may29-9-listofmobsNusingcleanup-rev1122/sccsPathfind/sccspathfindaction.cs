﻿
using AtomicTorch.CBND.CoreMod.CharacterSkeletons;
using AtomicTorch.CBND.CoreMod.Items.Generic;
using AtomicTorch.CBND.CoreMod.Items.Weapons.MobWeapons;
using AtomicTorch.CBND.CoreMod.Skills;
using AtomicTorch.CBND.CoreMod.SoundPresets;
using AtomicTorch.CBND.CoreMod.Stats;
using AtomicTorch.CBND.CoreMod.Systems.Droplists;

using AtomicTorch.CBND.CoreMod.Characters;
using AtomicTorch.CBND.CoreMod.ConsoleCommands.Admin;

using sccspathfindnode = sccspathfindstructs.sccspathfindnode;
using sccspathfindcombineddata = sccspathfindstructs.sccspathfindcombineddata;
using sccspathfindgriddatafinal = sccspathfindstructs.sccspathfindgriddatafinal;
using sccspathfindgridworldindex = sccspathfindstructs.sccspathfindgridworldindex;
using sccspathfindgridWorldSize = sccspathfindstructs.sccspathfindgridWorldSize;
using sccspathfindcheckallsidesdata = sccspathfindstructs.sccspathfindcheckallsidesdata;
using sccspathfindneighboortile = sccspathfindstructs.sccspathfindneighboortile;
using sccspathfindextraTiles = sccspathfindstructs.sccspathfindextraTiles;
using sccspathfindobstacledata = sccspathfindstructs.sccspathfindobstacledata;
using sccsvec2int = sccspathfindstructs.sccsvec2int;
using static sccspathfindstructs;
//using static sccsvestationoutpost;

using AtomicTorch.CBND.GameApi.Data.Physics;
using System.Windows.Documents;
using AtomicTorch.CBND.GameApi.Scripting;
using AtomicTorch.CBND.GameApi.ServicesServer;

using System.Collections.Generic;
using System.Collections;
using System;
using AtomicTorch.GameEngine.Common.Primitives;
using AtomicTorch.CBND.GameApi.Data.Characters;
using AtomicTorch.GameEngine.Common.DataStructures;
using AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind;


using sccsPathfind = AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind;
using AtomicTorch.CBND.CoreMod.Characters.Player;


namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    
    //ServerUpdateData data needs main switch and needs index variables. or inside of GameObject. or

    public static class sccspathfindaction //: ProtoCharacterMob
    {
        public static ConsoleAdminNotifyPlayer adminnotify = new ConsoleAdminNotifyPlayer();

        /*private static readonly IWorldServerService ServerWorldService
           = Api.IsServer
                 ? Api.Server.World
                 : null;
        public override bool AiIsRunAwayFromHeavyVehicles => true;

        public override float CharacterWorldHeight => 1.1f;

        public override float CharacterWorldWeaponOffsetRanged => 0.4f;

        public override double MobKillExperienceMultiplier => 1.0;

        public override string Name => "";

        public override ObjectMaterial ObjectMaterial => ObjectMaterial.SoftTissues;

        public override double StatDefaultHealthMax => 80;

        public override double StatMoveSpeed => 1.7;


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
            skeleton = GetProtoEntity<SkeletonWolf>();

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
        */






        /*
        protected override void ServerUpdateMob(ServerUpdateData data)
        {
            engagepathfindaction(data);
        }*/

        public static sccspathfindactionstruct engagepathfindaction(CharacterMobPublicState theobjstate, ICharacter thegameobject, sccspathfindactionstruct sccspathfindactionstruct)//ServerUpdateData data)
        {
            /*if (theobjstate.CurrentStats.indexswtc == -1)
            {
                theobjstate.CurrentStats.indexinmainarray = sccspathfindarrays.ProcessAddToMainList(thegameobject);
                theobjstate.CurrentStats.indexswtc = 1;
            }*/

            //var theplayercharacter = ServerCharacterAiHelper.GetClosestTargetPlayer(thegameobject);
            /*
            if (theplayercharacter!= null)
            {
                adminnotify.Execute(theplayercharacter, "/pathfindpermobdata.count:" + sccspathfindarrays.pathfindpermobdata.Count);

            }*/


            if (sccspathfindarrays.pathfindpermobdata != null)
            {
                //if (theobjstate.CurrentStats.indexinmainarray <= sccspathfindarrays.pathfindpermobdata.Count)
                {
                    var currentnpcglobaldata = sccspathfindarrays.pathfindpermobdata[sccspathfindactionstruct.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray];

                    //currentnpcglobaldata.adminnotify.Execute(currentnpcglobaldata.playercharacter, "/startpathfind:" + currentnpcglobaldata.pathfindscript.startpathfind);


                    //theobjstate.CurrentStats.HealthCurrent

                    currentnpcglobaldata.npcmovementtype = 0;
                    //haspopped = false;

                    if (currentnpcglobaldata.startpathfindmainswtc == 0)
                    {
                        currentnpcglobaldata.npccharacter = thegameobject;

                        currentnpcglobaldata.pathfindscript = new sccspathfinddata();
                        currentnpcglobaldata.pathfindscript.hasinitswtc = 1;

                        currentnpcglobaldata.pathfindscript.pathfindoptionhgf = sccspathfindactionstruct.pathfindarraysorttypeoption;//0FCOST//1HCOST//2MISCFCOSTISH

                        currentnpcglobaldata.pathfindscript.debugtoconsolemsg = 0; // debugs messages to the console.
                        currentnpcglobaldata.pathfindscript.pathfindimax = 2; //loops the pathfind 3 times per frame. //9. //PUT AT 1 MINIMUM
                        currentnpcglobaldata.pathfindscript.hasstartedpathfindcountermax = 75;//IF THE PATHFIND ITERATOR PATHFINDIMAX GOES OVER 75 SEEKER NODE ATTEMPT TO FIND THE TARGET. RESTART THE PATHFIND AUTOMATICALLY
                        currentnpcglobaldata.pathfindscript.framecounterpathfindmax = 0;//LEAVE AT 0 TO HAVE 1 ITERATION PER FRAME. INCREASE TO LET MULTIPLE FRAMES PASS BEFORE LETTING 1 PASS OF PATHFIND THROUGH.
                        currentnpcglobaldata.pathfindscript.createpathfindvisuals = 0;//NOTHING WORKING HERE FOR THE MOMENT.
                        currentnpcglobaldata.pathfindscript.startpathfind = 1;//LEAVE AT 1 SO THAT THE MOMENT THAT THE LOOPPATHFIND FUNCTION IS CALLED, IT WILL AUTOMATICALLY ENGAGE THE REST OF THE PATHFIND LOGIC.
                        currentnpcglobaldata.pathfindscript.maxRetracePath = 75;//IF THE RETRACE PATH IS HIGHER THAN x INTEGER, the path is too long... don't retrace.
                        currentnpcglobaldata.pathfindscript.retracedpathlistcountermaxloop = 6;//retrace only 1 reseeker node per frame. or x integer per frame to loop the retrace path faster otherwise it is 1 retrace per frame.

                        currentnpcglobaldata.pathfindscript.adminnotify = new ConsoleAdminNotifyPlayer();
                        currentnpcglobaldata.pathfindscript.mainSwitch = 1;
                        currentnpcglobaldata.pathfindscript.lastnode = new sccspathfindnode();
                        currentnpcglobaldata.pathfindscript.retracedpathlist = new Stack<sccspathfindnode>();

                        currentnpcglobaldata.pathfindscript.theseekernode = new sccspathfindnode();
                        currentnpcglobaldata.pathfindscript.initialpathfindnpcpos = new sccsvec2int();
                        currentnpcglobaldata.pathfindscript.targetobjingridpos = new sccsvec2int();
                        currentnpcglobaldata.pathfindscript.initialpathfindstartpos = new sccsvec2int();
                        currentnpcglobaldata.pathfindscript.tempttargetobjingridpospos = new sccsvec2int();
                        currentnpcglobaldata.pathfindscript.lasttransformposition = new sccsvec2int();
                        currentnpcglobaldata.pathfindscript.targetobjingridposposlast = new sccsvec2int();


                        currentnpcglobaldata.pathfindscript.gridworldsize = new sccspathfindgridWorldSize();

                        currentnpcglobaldata.pathfindscript.sccspathfindcombineddatavar = new sccspathfindcombineddata();


                        currentnpcglobaldata.pathfindscript.retracedpathlistcountermax = 75;


                        currentnpcglobaldata.pathfindscript.noderadius = 1;

                        currentnpcglobaldata.pathfindscript.gridxl = 1;
                        currentnpcglobaldata.pathfindscript.gridxr = 0;
                        currentnpcglobaldata.pathfindscript.gridyb = 1;
                        currentnpcglobaldata.pathfindscript.gridyt = 0;


                        if (currentnpcglobaldata.npccharacter != null)
                        {
                            if (currentnpcglobaldata.npccharacter.PhysicsBody != null)
                            {
                                currentnpcglobaldata.npcCharacterCenter = currentnpcglobaldata.npccharacter.Position + currentnpcglobaldata.npccharacter.PhysicsBody.CenterOffset;

                                currentnpcglobaldata.playercharacter = ServerCharacterAiHelper.GetClosestTargetPlayer(currentnpcglobaldata.npccharacter);

                                if (currentnpcglobaldata.playercharacter != null)
                                {
                                    if (currentnpcglobaldata.pathfindmaincountermax < 0)
                                    {
                                        currentnpcglobaldata.pathfindmaincountermax = 0;
                                    }

                                    if (currentnpcglobaldata.playercharacter.PhysicsBody != null)
                                    {
                                        currentnpcglobaldata.playercharactercenter = currentnpcglobaldata.playercharacter.Position + currentnpcglobaldata.playercharacter.PhysicsBody.CenterOffset;

                                        currentnpcglobaldata.playerpos = new sccsvec2float();
                                        currentnpcglobaldata.playerpos.x = (float)currentnpcglobaldata.playercharactercenter.X;
                                        currentnpcglobaldata.playerpos.y = (float)currentnpcglobaldata.playercharactercenter.Y;

                                        currentnpcglobaldata.npcpos = new sccsvec2float();
                                        currentnpcglobaldata.npcpos.x = (float)currentnpcglobaldata.npcCharacterCenter.X;
                                        currentnpcglobaldata.npcpos.y = (float)currentnpcglobaldata.npcCharacterCenter.Y;

                                        if (currentnpcglobaldata.pathfindscript.hasinitswtc == 1)
                                        {
                                            currentnpcglobaldata.distsquared = sccsmaths.GetDistancefloat2d(currentnpcglobaldata.playerpos, currentnpcglobaldata.npcpos);

                                            currentnpcglobaldata.lastdistsquared = currentnpcglobaldata.distsquared;
                                        }

                                    }

                                    currentnpcglobaldata.startpathfindmainswtc = 1;

                                }
                            }
                        }
                    }


                    if (currentnpcglobaldata.pathfindmaincounter >= currentnpcglobaldata.pathfindmaincountermax)
                    {
                        if (currentnpcglobaldata.npccharacter != null)
                        {
                            if (currentnpcglobaldata.npccharacter.PhysicsBody != null)
                            {
                                currentnpcglobaldata.npcCharacterCenter = currentnpcglobaldata.npccharacter.Position + currentnpcglobaldata.npccharacter.PhysicsBody.CenterOffset;

                                currentnpcglobaldata.playercharacter = ServerCharacterAiHelper.GetClosestTargetPlayer(currentnpcglobaldata.npccharacter);

                                if (currentnpcglobaldata.playercharacter != null)
                                {
                                    if (currentnpcglobaldata.playercharacter.PhysicsBody != null)
                                    {
                                        currentnpcglobaldata.playercharactercenter = currentnpcglobaldata.playercharacter.Position + currentnpcglobaldata.playercharacter.PhysicsBody.CenterOffset;

                                        currentnpcglobaldata.playerpos = new sccsvec2float();
                                        currentnpcglobaldata.playerpos.x = (float)currentnpcglobaldata.playercharactercenter.X;
                                        currentnpcglobaldata.playerpos.y = (float)currentnpcglobaldata.playercharactercenter.Y;

                                        currentnpcglobaldata.npcpos = new sccsvec2float();
                                        currentnpcglobaldata.npcpos.x = (float)currentnpcglobaldata.npcCharacterCenter.X;
                                        currentnpcglobaldata.npcpos.y = (float)currentnpcglobaldata.npcCharacterCenter.Y;

                                        if (currentnpcglobaldata.pathfindscript.hasinitswtc == 1)
                                        {
                                            currentnpcglobaldata.distsquared = sccsmaths.GetDistancefloat2d(currentnpcglobaldata.playerpos, currentnpcglobaldata.npcpos);
                                            //lastdistsquared = distsquared;

                                            if (currentnpcglobaldata.distsquared < currentnpcglobaldata.sccspathfinddistsquaredaggrodistancemax)
                                            {
                                                currentnpcglobaldata.distnpctoplayersqrt = sccsmaths.GetDistancefloat2dsqrt(currentnpcglobaldata.playerpos, currentnpcglobaldata.npcpos);

                                                //GETTING THE CURRENT DIRECTION OF THE NPC BASED ON THE LASTFRAME NPC POSITION AND CURRENT NPC POSITION
                                                if (currentnpcglobaldata.npcposlast.x != float.NaN && currentnpcglobaldata.npcposlast.y != float.NaN)
                                                {
                                                    currentnpcglobaldata.currentnpcdirection = new sccsvec2float();
                                                    currentnpcglobaldata.currentnpcdirection.x = currentnpcglobaldata.npcpos.x - currentnpcglobaldata.npcposlast.x;
                                                    currentnpcglobaldata.currentnpcdirection.y = currentnpcglobaldata.npcpos.y - currentnpcglobaldata.npcposlast.y;

                                                    float distnpcposcurrenttonpcposlast = sccsmaths.GetDistancefloat2dsqrt(currentnpcglobaldata.npcposlast, currentnpcglobaldata.npcpos);

                                                    currentnpcglobaldata.currentnpcdirection.x /= distnpcposcurrenttonpcposlast;
                                                    currentnpcglobaldata.currentnpcdirection.y /= distnpcposcurrenttonpcposlast;

                                                    //sccsvec2float posinfront = new sccsvec2float();
                                                    //posinfront.x = npcpos.x + currentnpcdirection.x;
                                                    //posinfront.y = npcpos.y + currentnpcdirection.y;

                                                    //float disttofrontpoint = pathfindscript.GetDistancefloat2dsqrt(posinfront, npcpos);

                                                    currentnpcglobaldata.frontdirectionposition = new Vector2D(currentnpcglobaldata.npcpos.x + currentnpcglobaldata.currentnpcdirection.x, currentnpcglobaldata.npcpos.y + currentnpcglobaldata.currentnpcdirection.y); // - new Vector2D(npcpos.x, npcpos.y)

                                                    Vector2D posnpctoposfrontnpc = new Vector2D(currentnpcglobaldata.npcpos.x + currentnpcglobaldata.currentnpcdirection.x, currentnpcglobaldata.npcpos.y + currentnpcglobaldata.currentnpcdirection.y) - new Vector2D(currentnpcglobaldata.npcpos.x, currentnpcglobaldata.npcpos.y);

                                                    Vector2D dirforlength = new Vector2D(currentnpcglobaldata.currentnpcdirection.x, currentnpcglobaldata.currentnpcdirection.y);

                                                    currentnpcglobaldata.frontdirectionpositionnotnormalized = dirforlength.Length;
                                                    //frontdirectionposition = frontdirectionposition.Normalized;
                                                }
                                                //GETTING THE CURRENT DIRECTION OF THE NPC BASED ON THE LASTFRAME NPC POSITION AND CURRENT NPC POSITION


                                                //currentnpcglobaldata.adminnotify.Execute(currentnpcglobaldata.playercharacter, "/startpathfind:" + currentnpcglobaldata.pathfindscript.startpathfind + "/counter:" + currentnpcglobaldata.pathfindscript.hasstartedpathfindcounter);


                                                if (currentnpcglobaldata.distnpctoplayersqrt > 1.5f)
                                                {
                                                    sccsvec2float dirnpctoplayer0 = new sccsvec2float();
                                                    dirnpctoplayer0.x = currentnpcglobaldata.playerpos.x - currentnpcglobaldata.npcpos.x;
                                                    dirnpctoplayer0.y = currentnpcglobaldata.playerpos.y - currentnpcglobaldata.npcpos.y;

                                                    dirnpctoplayer0.x /= currentnpcglobaldata.distnpctoplayersqrt;
                                                    dirnpctoplayer0.y /= currentnpcglobaldata.distnpctoplayersqrt;


                                                    sccsvec2float dirright0 = new sccsvec2float();
                                                    dirright0.x = 1.0f;
                                                    dirright0.y = 0.0f;

                                                    float anglerad0 = Vector2F.AngleDeg(new Vector2F(dirnpctoplayer0.x, dirnpctoplayer0.y), new Vector2F(dirright0.x, dirright0.y));

                                                    //pathfindscript.startpathfind = 1;


                                                    Vector2F dirtoplayer = new Vector2F(dirnpctoplayer0.x, dirnpctoplayer0.y);

                                                    float thedotnpcdirtoplayerdirandnpcdirtonode = sccsmaths.Dot(dirnpctoplayer0.x, dirnpctoplayer0.y, currentnpcglobaldata.currentnpcdirection.x, currentnpcglobaldata.currentnpcdirection.y);


                                                    if (currentnpcglobaldata.frontdirectionpositionnotnormalized > 0.0)
                                                    {
                                                        if (thedotnpcdirtoplayerdirandnpcdirtonode != float.NaN)
                                                        {
                                                            if (thedotnpcdirtoplayerdirandnpcdirtonode < 0.45f)
                                                            {
                                                                currentnpcglobaldata.pathfindscript.startpathfind = 1;
                                                            }
                                                        }
                                                    }



                                                    //INITIALIZING PATHFIND UNWALKABLE TILES... ONLY WHEN THE PATHFIND IS IN STATUS #1
                                                    //INITIALIZING PATHFIND UNWALKABLE TILES... ONLY WHEN THE PATHFIND IS IN STATUS #1
                                                    if (currentnpcglobaldata.pathfindscript.startpathfind == 1)
                                                    {
                                                       

                                                        var character0 = thegameobject;
                                                        var currentStats0 = theobjstate.CurrentStats;

                                                        if (thedotnpcdirtoplayerdirandnpcdirtonode < 0.25f)
                                                        {
                                                            sccsvec2float dirright = new sccsvec2float();
                                                            dirright.x = 1.0f;
                                                            dirright.y = 0.0f;

                                                            sccsvec2float dirnpctoplayer = new sccsvec2float();
                                                            dirnpctoplayer.x = currentnpcglobaldata.playerpos.x - currentnpcglobaldata.npcpos.x;
                                                            dirnpctoplayer.y = currentnpcglobaldata.playerpos.y - currentnpcglobaldata.npcpos.y;

                                                            dirnpctoplayer.x /= currentnpcglobaldata.distnpctoplayersqrt;
                                                            dirnpctoplayer.y /= currentnpcglobaldata.distnpctoplayersqrt;

                                                            float anglerad = Vector2F.AngleDeg(new Vector2F(dirnpctoplayer.x, dirnpctoplayer.y), new Vector2F(dirright.x, dirright.y));

                                                            /*ServerCharacterAiHelper.ProcessRetreatingAi(character0, 0.25f, out var movementDirection0, out var rotationAngleRad0); //distnpctoplayersqrt

                                                            this.ServerSetMobInput(character0, movementDirection0, anglerad);
                                                            */

                                                            sccspathfindactionstruct.movementoptiontype = 3;
                                                            sccspathfindactionstruct.anglerad = anglerad;
                                                            sccspathfindactionstruct.direction = new Vector2F(dirnpctoplayer.x, dirnpctoplayer.y);

                                                        }
                                                        /*
                                                        ServerCharacterAiHelper.ProcessAggressiveAi(
                                                          character0,
                                                          targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character0),
                                                          isRetreating: currentStats0.HealthCurrent < currentStats0.HealthMax / 3,
                                                          isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                                                          distanceRetreat: 7,
                                                          distanceEnemyTooClose: 1,
                                                          distanceEnemyTooFar: 3.5,
                                                          movementDirection: out var movementDirection,
                                                          rotationAngleRad: out var rotationAngleRad);

                                                        this.ServerSetMobInput(character0, movementDirection, rotationAngleRad);*/






                                                        currentnpcglobaldata.hasreachingnodestuckframecounter = 0;
                                                        currentnpcglobaldata.haschasedcharacter = 0;
                                                        currentnpcglobaldata.hasreachedpathend = 0;
                                                        currentnpcglobaldata.decrementcounterforpath = 0;
                                                        currentnpcglobaldata.haspopped = false;
                                                        currentnpcglobaldata.firstnodeofpathfindpoppedswtc = 0;
                                                        currentnpcglobaldata.swtcobstaclesontheway = 0;
                                                        currentnpcglobaldata.pathfindretracedpathswtc = 0;
                                                        currentnpcglobaldata.haspoppedcounter = 0;

                                                        var physicsSpace = currentnpcglobaldata.npccharacter.PhysicsBody.PhysicsSpace;

                                                        currentnpcglobaldata.obstacles = physicsSpace.TestLine(
                                                            currentnpcglobaldata.npcCharacterCenter,
                                                              currentnpcglobaldata.frontdirectionposition,
                                                              CollisionGroup.Default,
                                                              sendDebugEvent: true);

                                                        if (currentnpcglobaldata.listofobstaclesinit != null)
                                                        {
                                                            currentnpcglobaldata.listofobstaclesinit.Clear();
                                                        }
                                                        else
                                                        {
                                                            currentnpcglobaldata.listofobstaclesinit = new List<sccsvec2int>();
                                                        }

                                                        if (currentnpcglobaldata.obstacles != null)
                                                        {
                                                            if (currentnpcglobaldata.obstacles.Count > 0)
                                                            {
                                                                var isTraversableTile = true;
                                                                foreach (var result in currentnpcglobaldata.obstacles.AsList())
                                                                {
                                                                    var body = result.PhysicsBody;
                                                                    if (body.AssociatedProtoTile is not null)
                                                                    {
                                                                        //currentnpcglobaldata.adminnotify.Execute(currentnpcglobaldata.playercharacter, "/0obstacle:" + body.AssociatedProtoTile.Name);

                                                                        if (body.AssociatedProtoTile.Name == "Forest (Temperate)" || body.AssociatedProtoTile.Name == "Forest (temperate)")
                                                                        {
                                                                            isTraversableTile = true;
                                                                        }
                                                                        else
                                                                        {
                                                                            isTraversableTile = true;
                                                                        }
                                                                        // untraversable tile - a cliff or water
                                                                        //break;
                                                                    }

                                                                    if (body.AssociatedWorldObject is not null)
                                                                    {

                                                                        if (body.AssociatedWorldObject.GameObjectType == GameApi.Data.GameObjectType.Character)
                                                                        {
                                                                            isTraversableTile = true;

                                                                        }
                                                                        else
                                                                        {
                                                                            isTraversableTile = true;
                                                                        }
                                                                        //currentnpcglobaldata.adminnotify.Execute(currentnpcglobaldata.playercharacter, "/1obstacle:" + body.AssociatedWorldObject.GameObjectType);

                                                                        // an obstacle - a world object
                                                                    
                                                                        //break;



                                                                    }
                                                                    if (isTraversableTile == false)
                                                                    {
                                                                        Vector2Ushort vec = body.Position.ToVector2Ushort();// + new Vector2Ushort(testPhysicsBody.CenterOffset.X, testPhysicsBody.CenterOffset.Y);

                                                                        sccsvec2int posofobstacle = new sccsvec2int();
                                                                        posofobstacle.x = (int)Math.Round((decimal)vec.X) + (int)Math.Round((decimal)body.CenterOffset.X);
                                                                        posofobstacle.y = (int)Math.Round((decimal)vec.Y) + (int)Math.Round((decimal)body.CenterOffset.Y);

                                                                        currentnpcglobaldata.listofobstaclesinit.Add(posofobstacle);
                                                                    }
                                                                }
                                                            }
                                                        }

                                                        currentnpcglobaldata.initialpathfindstartpos = currentnpcglobaldata.npcpos;
                                                        currentnpcglobaldata.initialpathfindtargetpos = currentnpcglobaldata.playerpos;

                                                        //INITILIASES THE PATHFIND. THE STARTPATHFIND VARIABLE BECOMES 2 INSIDE THE PATHFIND SCRIPT AFTER ONE PASS
                                                        currentnpcglobaldata.pathfindscript = AtomicTorch.CBND.CoreMod.Characters.sccsPathfind.sccspathfind.LoopPathfind(currentnpcglobaldata.initialpathfindstartpos, currentnpcglobaldata.initialpathfindtargetpos, currentnpcglobaldata.listofobstaclesinit, currentnpcglobaldata.npccharacter, currentnpcglobaldata.playercharacter, currentnpcglobaldata.pathfindscript);
                                                        //INITILIASES THE PATHFIND. THE STARTPATHFIND VARIABLE BECOMES 2 INSIDE THE PATHFIND SCRIPT AFTER ONE PASS

                                                    }
                                                    //INITIALIZING PATHFIND UNWALKABLE TILES... ONLY WHEN THE PATHFIND IS IN STATUS #1
                                                    //INITIALIZING PATHFIND UNWALKABLE TILES... ONLY WHEN THE PATHFIND IS IN STATUS #1

                                                    //WHILE THE PATHFIND IS NOT IN STATUS #4, LOOP PATHFIND. STATUS 4 IS TARGET POS FOUND AND PATH RETRACED.
                                                    //WHILE THE PATHFIND IS NOT IN STATUS #4, LOOP PATHFIND. STATUS 4 IS TARGET POS FOUND AND PATH RETRACED.
                                                    else if (currentnpcglobaldata.pathfindscript.startpathfind == 2 || currentnpcglobaldata.pathfindscript.startpathfind == 3)
                                                    {
                                                        currentnpcglobaldata.pathfindscript = AtomicTorch.CBND.CoreMod.Characters.sccsPathfind.sccspathfind.LoopPathfind(currentnpcglobaldata.initialpathfindstartpos, currentnpcglobaldata.initialpathfindtargetpos, currentnpcglobaldata.listofobstaclesinit, currentnpcglobaldata.npccharacter, currentnpcglobaldata.playercharacter, currentnpcglobaldata.pathfindscript);
                                                    }
                                                    //WHILE THE PATHFIND IS NOT IN STATUS #4, LOOP PATHFIND. STATUS 4 IS TARGET POS FOUND AND PATH RETRACED.
                                                    //WHILE THE PATHFIND IS NOT IN STATUS #4, LOOP PATHFIND. STATUS 4 IS TARGET POS FOUND AND PATH RETRACED.

                                                    else if (currentnpcglobaldata.pathfindscript.startpathfind == 4)
                                                    {
                                                        //distnpctoplayersqrt = pathfindscript.GetDistancefloat2dsqrt(playerpos, npcpos);

                                                        //TRYING TO REMOVE A FIRST NODE
                                                        if (currentnpcglobaldata.pathfindretracedpathswtc == 0)
                                                        {
                                                            if (currentnpcglobaldata.pathfindscript.retracedpathlist != null)
                                                            {
                                                                if (currentnpcglobaldata.pathfindscript.retracedpathlist.Count > 1)
                                                                {
                                                                    if (currentnpcglobaldata.firstnodeofpathfindpoppedswtc == 0)
                                                                    {
                                                                        currentnpcglobaldata.decrementcounterforpath = currentnpcglobaldata.pathfindscript.retracedpathlist.Count;

                                                                        currentnpcglobaldata.firstnodeofpathfindpoppedswtc = 1;
                                                                    }

                                                                    currentnpcglobaldata.haspopped = currentnpcglobaldata.pathfindscript.retracedpathlist.TryPop(out currentnpcglobaldata.poppednode);
                                                                    currentnpcglobaldata.hasreachingnodestuckframecounter = 0;

                                                                    currentnpcglobaldata.haspoppedcounter++;
                                                                    currentnpcglobaldata.decrementcounterforpath--;


                                                                    currentnpcglobaldata.pathfindretracedpathswtc = 1;
                                                                }
                                                                else
                                                                {
                                                                    if (currentnpcglobaldata.distnpctoplayersqrt <= 1.5f)
                                                                    {
                                                                        currentnpcglobaldata.hasreachingnodestuckframecounter = 0;


                                                                        currentnpcglobaldata.hasreachedandattackedplayer = 1;
                                                                        /*var character1 = thegameobject;
                                                                        var currentStats1 = theobjstate.CurrentStats;

                                                                        ServerCharacterAiHelper.ProcessAggressiveAi(
                                                                            character1,
                                                                            targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character1),
                                                                            isRetreating: currentStats1.HealthCurrent < currentStats1.HealthMax / 3,
                                                                            isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                                                                            distanceRetreat: 7,
                                                                            distanceEnemyTooClose: 1,
                                                                            distanceEnemyTooFar: 3.5,
                                                                            movementDirection: out var movementDirection1,
                                                                            rotationAngleRad: out var rotationAngleRad1);

                                                                        this.ServerSetMobInput(character1, movementDirection1, rotationAngleRad1);*/


                                                                        sccspathfindactionstruct.movementoptiontype = 1;
                                                                        //sccspathfindactionstruct.anglerad = anglerad;
                                                                        //sccspathfindactionstruct.direction = currentnpcglobaldata.directionnpctopathfindnodef;

                                                                    }
                                                                    else
                                                                    {
                                                                        currentnpcglobaldata.pathfindscript.startpathfind = 1;
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (currentnpcglobaldata.distnpctoplayersqrt <= 1.5f)
                                                                {
                                                                    currentnpcglobaldata.hasreachingnodestuckframecounter = 0;

                                                                    currentnpcglobaldata.hasreachedandattackedplayer = 1;
                                                                    /*var character1 = thegameobject;
                                                                    var currentStats1 = theobjstate.CurrentStats;

                                                                    ServerCharacterAiHelper.ProcessAggressiveAi(
                                                                        character1,
                                                                        targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character1),
                                                                        isRetreating: currentStats1.HealthCurrent < currentStats1.HealthMax / 3,
                                                                        isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                                                                        distanceRetreat: 7,
                                                                        distanceEnemyTooClose: 1,
                                                                        distanceEnemyTooFar: 3.5,
                                                                        movementDirection: out var movementDirection1,
                                                                        rotationAngleRad: out var rotationAngleRad1);

                                                                    this.ServerSetMobInput(character1, movementDirection1, rotationAngleRad1);*/


                                                                    sccspathfindactionstruct.movementoptiontype = 1;
                                                                    //sccspathfindactionstruct.anglerad = anglerad;
                                                                    //sccspathfindactionstruct.direction = currentnpcglobaldata.directionnpctopathfindnodef;

                                                                }
                                                                else
                                                                {
                                                                    currentnpcglobaldata.pathfindscript.startpathfind = 1;
                                                                }
                                                            }
                                                        }
                                                        //TRYING TO REMOVE A FIRST NODE
                                                    }
                                                    else
                                                    {

                                                    }


                                                    if (currentnpcglobaldata.decrementcounterforpath <= 0 && currentnpcglobaldata.firstnodeofpathfindpoppedswtc == 1)
                                                    {
                                                        currentnpcglobaldata.hasreachedandattackedplayer = 1;


                                                        if (currentnpcglobaldata.distnpctoplayersqrt <= 1.5f)
                                                        {
                                                            currentnpcglobaldata.hasreachingnodestuckframecounter = 0;


                                                            /*var character1 = thegameobject;
                                                            var currentStats1 = theobjstate.CurrentStats;

                                                            ServerCharacterAiHelper.ProcessAggressiveAi(
                                                                character1,
                                                                targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character1),
                                                                isRetreating: currentStats1.HealthCurrent < currentStats1.HealthMax / 3,
                                                                isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                                                                distanceRetreat: 7,
                                                                distanceEnemyTooClose: 1,
                                                                distanceEnemyTooFar: 3.5,
                                                                movementDirection: out var movementDirection1,
                                                                rotationAngleRad: out var rotationAngleRad1);

                                                            this.ServerSetMobInput(character1, movementDirection1, rotationAngleRad1);*/

                                                            sccspathfindactionstruct.movementoptiontype = 1;
                                                            //sccspathfindactionstruct.anglerad = anglerad;
                                                            //sccspathfindactionstruct.direction = currentnpcglobaldata.directionnpctopathfindnodef;

                                                            currentnpcglobaldata.pathfindretracedpathswtc = 0;
                                                            currentnpcglobaldata.hasreachedandattackedplayer = 1;
                                                            currentnpcglobaldata.firstnodeofpathfindpoppedswtc = -2;

                                                        }
                                                        else
                                                        {

                                                            currentnpcglobaldata.pathfindscript.startpathfind = 1;

                                                        }
                                                    }
                                                    else
                                                    {

                                                    }



                                                    if (currentnpcglobaldata.firstnodeofpathfindpoppedswtc == 1)
                                                    {

                                                        if (currentnpcglobaldata.hasreachingnodestuckframecounter >= currentnpcglobaldata.hasreachingnodestuckframecountermax)
                                                        {

                                                            if (sccspathfindglobals.checkforobstaclesonthewayswtc == 1)
                                                            {
                                                                checkforobstaclesontheway(currentnpcglobaldata.npccharacter, currentnpcglobaldata.frontdirectionposition, currentnpcglobaldata.playercharacter, currentnpcglobaldata);
                                                            }





                                                            currentnpcglobaldata.pathfindscript.startpathfind = 1;
                                                            currentnpcglobaldata.firstnodeofpathfindpoppedswtc = 0;
                                                            currentnpcglobaldata.hasreachingnodestuckframecounter = 0;
                                                        }


                                                        if (currentnpcglobaldata.haspopped)
                                                        {

                                                            sccsvec2float thenodepos = new sccsvec2float();
                                                            thenodepos.x = currentnpcglobaldata.poppednode.worldpositionx;
                                                            thenodepos.y = currentnpcglobaldata.poppednode.worldpositiony;

                                                            sccsvec2float npctoinitnpcdiff = new sccsvec2float();
                                                            npctoinitnpcdiff.x = (int)Math.Round((double)currentnpcglobaldata.npcpos.x) - (int)Math.Round((double)currentnpcglobaldata.initialpathfindstartpos.x);
                                                            npctoinitnpcdiff.y = (int)Math.Round((double)currentnpcglobaldata.npcpos.y) - (int)Math.Round((double)currentnpcglobaldata.initialpathfindstartpos.y);

                                                            currentnpcglobaldata.disttonode = sccsmaths.GetDistancefloat2dsqrt(npctoinitnpcdiff, thenodepos);

                                                            sccsvec2float dirnodetoinitpos = new sccsvec2float();
                                                            dirnodetoinitpos.x = thenodepos.x - npctoinitnpcdiff.x; //-thenodepos.x;//
                                                            dirnodetoinitpos.y = thenodepos.y - npctoinitnpcdiff.y; //-thenodepos.y;//

                                                            //float hypothenuse = disttonode;
                                                            //float opposite = dirnodetoinitpos.y;
                                                            //float adjacent = dirnodetoinitpos.x;
                                                            //float rotationangledeg = 0;

                                                            if (currentnpcglobaldata.disttonode == 0 || currentnpcglobaldata.disttonode < 0.75f)
                                                            {
                                                                if (currentnpcglobaldata.distnpctoplayersqrt <= 1.5f)
                                                                {
                                                                    currentnpcglobaldata.hasreachingnodestuckframecounter = 0;
                                                                    currentnpcglobaldata.hasreachedandattackedplayer = 1;
                                                                    /*var character1 = thegameobject;
                                                                    var currentStats1 = theobjstate.CurrentStats;

                                                                    ServerCharacterAiHelper.ProcessAggressiveAi(
                                                                        character1,
                                                                        targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character1),
                                                                        isRetreating: currentStats1.HealthCurrent < currentStats1.HealthMax / 3,
                                                                        isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                                                                        distanceRetreat: 7,
                                                                        distanceEnemyTooClose: 1,
                                                                        distanceEnemyTooFar: 3.5,
                                                                        movementDirection: out var movementDirection1,
                                                                        rotationAngleRad: out var rotationAngleRad1);

                                                                    this.ServerSetMobInput(character1, movementDirection1, rotationAngleRad1);*/



                                                                    sccspathfindactionstruct.movementoptiontype = 1;
                                                                    //sccspathfindactionstruct.anglerad = anglerad;
                                                                    //sccspathfindactionstruct.direction = currentnpcglobaldata.directionnpctopathfindnodef;
                                                                }
                                                                else
                                                                {

                                                                }

                                                                currentnpcglobaldata.pathfindretracedpathswtc = 0;
                                                            }
                                                            else
                                                            {

                                                                if (currentnpcglobaldata.disttonode != float.NaN && currentnpcglobaldata.disttonode != 0)
                                                                {
                                                                    dirnodetoinitpos.x /= currentnpcglobaldata.disttonode;
                                                                    dirnodetoinitpos.y /= currentnpcglobaldata.disttonode;

                                                                    currentnpcglobaldata.directionnpctopathfindnodef = new Vector2F(dirnodetoinitpos.x, dirnodetoinitpos.y);

                                                                    if (currentnpcglobaldata.directionnpctopathfindnodef.X != float.NaN && currentnpcglobaldata.directionnpctopathfindnodef.Y != float.NaN)
                                                                    {

                                                                        if (currentnpcglobaldata.directionnpctopathfindnodef.X == 0 && currentnpcglobaldata.directionnpctopathfindnodef.Y == 0)
                                                                        {
                                                                            currentnpcglobaldata.pathfindretracedpathswtc = 0;
                                                                            currentnpcglobaldata.pathfindscript.startpathfind = 1;
                                                                        }
                                                                        else
                                                                        {
                                                                            sccsvec2float dirnpctoplayer = new sccsvec2float();
                                                                            dirnpctoplayer.x = currentnpcglobaldata.playerpos.x - currentnpcglobaldata.npcpos.x;
                                                                            dirnpctoplayer.y = currentnpcglobaldata.playerpos.y - currentnpcglobaldata.npcpos.y;

                                                                            dirnpctoplayer.x /= currentnpcglobaldata.distnpctoplayersqrt;
                                                                            dirnpctoplayer.y /= currentnpcglobaldata.distnpctoplayersqrt;


                                                                            sccsvec2float dirright = new sccsvec2float();
                                                                            dirright.x = 1.0f;
                                                                            dirright.y = 0.0f;

                                                                            float anglerad = Vector2F.AngleDeg(new Vector2F(currentnpcglobaldata.directionnpctopathfindnodef.X, currentnpcglobaldata.directionnpctopathfindnodef.Y), new Vector2F(dirright.x, dirright.y));

                                                                            //pathfindscript.startpathfind = 1;

                                                                            /*var character = thegameobject;
                                                                            var currentStats = theobjstate.CurrentStats;

                                                                            ServerCharacterAiHelper.ProcessAggressiveAi(
                                                                            character,
                                                                            targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character),
                                                                            isRetreating: currentStats.HealthCurrent < currentStats.HealthMax / 3,
                                                                            isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                                                                            distanceRetreat: 7,
                                                                            distanceEnemyTooClose: 1,
                                                                            distanceEnemyTooFar: 3.5, //distnpctoplayersqrt + 1.0f
                                                                            movementDirection: out var movementDirection,
                                                                            rotationAngleRad: out var rotationAngleRad);


                                                                            this.ServerSetMobInput(character, currentnpcglobaldata.directionnpctopathfindnodef, anglerad);*/



                                                                            sccspathfindactionstruct.movementoptiontype = 2;
                                                                            sccspathfindactionstruct.anglerad = anglerad;
                                                                            sccspathfindactionstruct.direction = currentnpcglobaldata.directionnpctopathfindnodef;

                                                                            //float thedotnpcdirtoplayerdirandnpcdirtonode = Dot(dirnpctoplayer.x, dirnpctoplayer.y, directionnpctopathfindnodef.X, directionnpctopathfindnodef.Y);


                                                                            if (((int)npctoinitnpcdiff.x == currentnpcglobaldata.poppednode.worldpositionx && (int)npctoinitnpcdiff.y == currentnpcglobaldata.poppednode.worldpositiony) ||
                                                                           (int)Math.Round((decimal)currentnpcglobaldata.npcpos.x) == currentnpcglobaldata.poppednode.worldpositionx + (int)Math.Round((decimal)currentnpcglobaldata.initialpathfindstartpos.x) &&
                                                                           (int)Math.Round((decimal)currentnpcglobaldata.npcpos.y) == currentnpcglobaldata.poppednode.worldpositiony + (int)Math.Round((decimal)currentnpcglobaldata.initialpathfindstartpos.y))
                                                                            {
                                                                                currentnpcglobaldata.pathfindretracedpathswtc = 0;
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        currentnpcglobaldata.pathfindretracedpathswtc = 0;
                                                                        currentnpcglobaldata.pathfindscript.startpathfind = 1;

                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    currentnpcglobaldata.pathfindretracedpathswtc = 0;
                                                                    currentnpcglobaldata.pathfindscript.startpathfind = 1;
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {

                                                        }

                                                        currentnpcglobaldata.hasreachingnodestuckframecounter++;
                                                    }
                                                    else
                                                    {

                                                    }
                                                }
                                                else if (currentnpcglobaldata.distnpctoplayersqrt <= 1.5f)
                                                {
                                                    currentnpcglobaldata.hasreachedandattackedplayer = 1;
                                                    currentnpcglobaldata.hasreachingnodestuckframecounter = 0;


                                                    /*var character1 = thegameobject;
                                                    var currentStats1 = theobjstate.CurrentStats;

                                                    ServerCharacterAiHelper.ProcessAggressiveAi(
                                                        character1,
                                                        targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character1),
                                                        isRetreating: currentStats1.HealthCurrent < currentStats1.HealthMax / 3,
                                                        isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                                                        distanceRetreat: 7,
                                                        distanceEnemyTooClose: 1,
                                                        distanceEnemyTooFar: 3.5,
                                                        movementDirection: out var movementDirection1,
                                                        rotationAngleRad: out var rotationAngleRad1);

                                                    this.ServerSetMobInput(character1, movementDirection1, rotationAngleRad1);*/

                                                    sccspathfindactionstruct.movementoptiontype = 1;
                                                }

                                            }
                                            else
                                            {
                                                currentnpcglobaldata.hasreachedandattackedplayer = 1;

                                                currentnpcglobaldata.hasreachingnodestuckframecounter = 0;
                                                var character0 = thegameobject;
                                                var currentStats0 = theobjstate.CurrentStats;

                                                /*ServerCharacterAiHelper.ProcessAggressiveAi(
                                                    character0,
                                                    targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character0),
                                                    isRetreating: currentStats0.HealthCurrent < currentStats0.HealthMax / 3,
                                                    isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                                                    distanceRetreat: 7,
                                                    distanceEnemyTooClose: 1,
                                                    distanceEnemyTooFar: 3.5, //distnpctoplayersqrt + 1.0f
                                                    movementDirection: out var movementDirection,
                                                    rotationAngleRad: out var rotationAngleRad);

                                                this.ServerSetMobInput(character0, movementDirection, rotationAngleRad);
                                                //pathfindscript.startpathfind = 1;*/

                                                sccsvec2float dirright = new sccsvec2float();
                                                dirright.x = 1.0f;
                                                dirright.y = 0.0f;

                                                sccsvec2float dirnpctoplayer = new sccsvec2float();
                                                dirnpctoplayer.x = currentnpcglobaldata.playerpos.x - currentnpcglobaldata.npcpos.x;
                                                dirnpctoplayer.y = currentnpcglobaldata.playerpos.y - currentnpcglobaldata.npcpos.y;

                                                dirnpctoplayer.x /= currentnpcglobaldata.distnpctoplayersqrt;
                                                dirnpctoplayer.y /= currentnpcglobaldata.distnpctoplayersqrt;

                                                float anglerad = Vector2F.AngleDeg(new Vector2F(dirnpctoplayer.x, dirnpctoplayer.y), new Vector2F(dirright.x, dirright.y));

                                                /*ServerCharacterAiHelper.ProcessRetreatingAi(character0, 0.25f, out var movementDirection0, out var rotationAngleRad0); //distnpctoplayersqrt

                                                this.ServerSetMobInput(character0, movementDirection0, anglerad);
                                                */

                                                sccspathfindactionstruct.movementoptiontype = 3;
                                                sccspathfindactionstruct.anglerad = anglerad;
                                                sccspathfindactionstruct.direction = new Vector2F(dirnpctoplayer.x, dirnpctoplayer.y);


                                            }

                                        }
                                        else
                                        {
                                            var character0 = thegameobject;
                                            var currentStats = theobjstate.CurrentStats;

                                            /* ServerCharacterAiHelper.ProcessAggressiveAi(
                                                 character,
                                                 targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character),
                                                 isRetreating: currentStats.HealthCurrent < currentStats.HealthMax / 3,
                                                 isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                                                 distanceRetreat: 7,
                                                 distanceEnemyTooClose: 1,
                                                 distanceEnemyTooFar: 3.5,
                                                 movementDirection: out var movementDirection,
                                                 rotationAngleRad: out var rotationAngleRad);

                                             this.ServerSetMobInput(character, movementDirection, rotationAngleRad);*/
                                            //pathfindscript.startpathfind = 1;

                                            //npcmovementtype = 1;

                                            sccsvec2float dirright = new sccsvec2float();
                                            dirright.x = 1.0f;
                                            dirright.y = 0.0f;

                                            sccsvec2float dirnpctoplayer = new sccsvec2float();
                                            dirnpctoplayer.x = currentnpcglobaldata.playerpos.x - currentnpcglobaldata.npcpos.x;
                                            dirnpctoplayer.y = currentnpcglobaldata.playerpos.y - currentnpcglobaldata.npcpos.y;

                                            dirnpctoplayer.x /= currentnpcglobaldata.distnpctoplayersqrt;
                                            dirnpctoplayer.y /= currentnpcglobaldata.distnpctoplayersqrt;

                                            float anglerad = Vector2F.AngleDeg(new Vector2F(dirnpctoplayer.x, dirnpctoplayer.y), new Vector2F(dirright.x, dirright.y));

                                            /*ServerCharacterAiHelper.ProcessRetreatingAi(character0, 0.25f, out var movementDirection0, out var rotationAngleRad0); //distnpctoplayersqrt

                                            this.ServerSetMobInput(character0, movementDirection0, anglerad);*/

                                            sccspathfindactionstruct.movementoptiontype = 3;
                                            sccspathfindactionstruct.anglerad = anglerad;
                                            sccspathfindactionstruct.direction = new Vector2F(dirnpctoplayer.x, dirnpctoplayer.y);
                                        }

                                        currentnpcglobaldata.npcposlast = currentnpcglobaldata.npcpos;
                                    }

                                    if (currentnpcglobaldata.playercharacter.IsDestroyed)
                                    {
                                        var character0 = thegameobject;
                                        var currentStats0 = theobjstate.CurrentStats;

                                        /*ServerCharacterAiHelper.ProcessAggressiveAi(
                                            character0,
                                            targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character0),
                                            isRetreating: currentStats0.HealthCurrent < currentStats0.HealthMax / 3,
                                            isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                                            distanceRetreat: 7,
                                            distanceEnemyTooClose: 1,
                                            distanceEnemyTooFar: 3.5,
                                            movementDirection: out var movementDirection,
                                            rotationAngleRad: out var rotationAngleRad);

                                        this.ServerSetMobInput(character0, movementDirection, rotationAngleRad);*/

                                        sccsvec2float dirright = new sccsvec2float();
                                        dirright.x = 1.0f;
                                        dirright.y = 0.0f;

                                        sccsvec2float dirnpctoplayer = new sccsvec2float();
                                        dirnpctoplayer.x = currentnpcglobaldata.playerpos.x - currentnpcglobaldata.npcpos.x;
                                        dirnpctoplayer.y = currentnpcglobaldata.playerpos.y - currentnpcglobaldata.npcpos.y;

                                        dirnpctoplayer.x /= currentnpcglobaldata.distnpctoplayersqrt;
                                        dirnpctoplayer.y /= currentnpcglobaldata.distnpctoplayersqrt;

                                        float anglerad = Vector2F.AngleDeg(new Vector2F(dirnpctoplayer.x, dirnpctoplayer.y), new Vector2F(dirright.x, dirright.y));

                                        /*ServerCharacterAiHelper.ProcessRetreatingAi(character0, 0.25f, out var movementDirection0, out var rotationAngleRad0); //distnpctoplayersqrt

                                        this.ServerSetMobInput(character0, movementDirection0, anglerad);*/

                                        sccspathfindactionstruct.movementoptiontype = 3;
                                        sccspathfindactionstruct.anglerad = anglerad;
                                        sccspathfindactionstruct.direction = new Vector2F(dirnpctoplayer.x, dirnpctoplayer.y);
                                    }

                                }
                                else
                                {
                                    /*var character0 = thegameobject;
                                    var currentStats0 = theobjstate.CurrentStats;

                                    ServerCharacterAiHelper.ProcessAggressiveAi(
                                        character0,
                                        targetCharacter: ServerCharacterAiHelper.GetClosestTargetPlayer(character0),
                                        isRetreating: currentStats0.HealthCurrent < currentStats0.HealthMax / 3,
                                        isRetreatingForHeavyVehicles: this.AiIsRunAwayFromHeavyVehicles,
                                        distanceRetreat: 7,
                                        distanceEnemyTooClose: 1,
                                        distanceEnemyTooFar: 3.5,
                                        movementDirection: out var movementDirection,
                                        rotationAngleRad: out var rotationAngleRad);

                                    this.ServerSetMobInput(character0, movementDirection, rotationAngleRad);*/

                                    sccspathfindactionstruct.movementoptiontype = 1;

                                    /*sccsvec2float dirright = new sccsvec2float();
                                    dirright.x = 1.0f;
                                    dirright.y = 0.0f;

                                    sccsvec2float dirnpctoplayer = new sccsvec2float();
                                    dirnpctoplayer.x = playerpos.x - npcpos.x;
                                    dirnpctoplayer.y = playerpos.y - npcpos.y;

                                    dirnpctoplayer.x /= distnpctoplayersqrt;
                                    dirnpctoplayer.y /= distnpctoplayersqrt;

                                    float anglerad = Vector2F.AngleDeg(new Vector2F(dirnpctoplayer.x, dirnpctoplayer.y), new Vector2F(dirright.x, dirright.y));

                                    ServerCharacterAiHelper.ProcessRetreatingAi(character0, 0.25f, out var movementDirection0, out var rotationAngleRad0); //distnpctoplayersqrt

                                    this.ServerSetMobInput(character0, movementDirection0, anglerad);*/
                                }
                            }
                        }

                        currentnpcglobaldata.distnpctoplayersqrtlast = currentnpcglobaldata.distnpctoplayersqrt;
                        currentnpcglobaldata.lasthaspopped = currentnpcglobaldata.haspopped;
                        currentnpcglobaldata.lasthaspoppedcounter = currentnpcglobaldata.haspoppedcounter;
                        currentnpcglobaldata.lastdistnpctoplayersqrt = currentnpcglobaldata.distnpctoplayersqrt;


                        currentnpcglobaldata.pathfindmaincounter = 0;
                    }
                    currentnpcglobaldata.pathfindmaincounter++;

                    currentnpcglobaldata.lasthasreachedandattackedplayer = currentnpcglobaldata.hasreachedandattackedplayer;

                    sccspathfindarrays.pathfindpermobdata[sccspathfindactionstruct.mobtypeofindex][theobjstate.CurrentStats.indexinmainarray] = currentnpcglobaldata;

                }
            }

            return sccspathfindactionstruct;
        }



        public static void checkforobstaclesontheway(ICharacter npccharacter, Vector2D frontdirectionposition, ICharacter playercharacter, sccspathfindperscriptmobdatastruct currentnpcglobaldata)
        {

            if (currentnpcglobaldata.swtcobstaclesontheway == 0 && currentnpcglobaldata.haspoppedcounter >= currentnpcglobaldata.haspoppedcountermax) // && haspoppedcounter >= haspoppedcountermax
            {




                var physicsSpace0 = npccharacter.PhysicsBody.PhysicsSpace;

                currentnpcglobaldata.obstaclesontheway = physicsSpace0.TestLine(
                    currentnpcglobaldata.npcCharacterCenter,
                      frontdirectionposition,//playercharactercenter,
                      CollisionGroup.Default,
                      sendDebugEvent: true);

                /*currentnpcglobaldata.obstaclesonthewaytwo = physicsSpace0.TestLine(
                  currentnpcglobaldata.npcCharacterCenter,
                   currentnpcglobaldata.playercharactercenter,//,
                   CollisionGroup.Default,
                   sendDebugEvent: true);*/


                if (currentnpcglobaldata.listofobstaclesontheway != null)
                {
                    currentnpcglobaldata.listofobstaclesontheway.Clear();
                }
                else
                {
                    currentnpcglobaldata.listofobstaclesontheway = new List<sccsvec2int>();
                }


                if (currentnpcglobaldata.obstaclesontheway != null)// && directionnpctopathfindnodef.X != float.NaN && directionnpctopathfindnodef.Y != float.NaN)
                {
                    if (currentnpcglobaldata.obstaclesontheway.Count > 0)
                    {
                        var isTraversableTile = true;
                        foreach (var result in currentnpcglobaldata.obstaclesontheway.AsList())
                        {
                            var body = result.PhysicsBody;
                            if (body.AssociatedProtoTile is not null)
                            {
                                //currentnpcglobaldata.adminnotify.Execute(currentnpcglobaldata.playercharacter, "/0obstacle:" + body.AssociatedProtoTile.Name);

                                if (body.AssociatedProtoTile.Name == "Forest (Temperate)" || body.AssociatedProtoTile.Name == "Forest (temperate)")
                                {
                                    isTraversableTile = true;
                                }
                                else
                                {
                                    isTraversableTile = false;
                                }
                                // untraversable tile - a cliff or water
                                //break;
                            }

                            if (body.AssociatedWorldObject is not null)
                            {

                                if (body.AssociatedWorldObject.GameObjectType == GameApi.Data.GameObjectType.Character)
                                {
                                    isTraversableTile = true;

                                }
                                else
                                {
                                    isTraversableTile = false;
                                }
                                //currentnpcglobaldata.adminnotify.Execute(currentnpcglobaldata.playercharacter, "/1obstacle:" + body.AssociatedWorldObject.GameObjectType);

                                // an obstacle - a world object

                                //break;
                            }


                            if (isTraversableTile == false)
                            {
                                Vector2Ushort vec = body.Position.ToVector2Ushort();// + new Vector2Ushort(testPhysicsBody.CenterOffset.X, testPhysicsBody.CenterOffset.Y);

                                sccsvec2int posofobstacle = new sccsvec2int();
                                posofobstacle.x = (int)Math.Round((decimal)vec.X) + (int)Math.Round((decimal)body.CenterOffset.X);
                                posofobstacle.y = (int)Math.Round((decimal)vec.Y) + (int)Math.Round((decimal)body.CenterOffset.Y);

                                currentnpcglobaldata.listofobstaclesontheway.Add(posofobstacle);
                            }
                        }



                        for (int i = 0; i < currentnpcglobaldata.listofobstaclesontheway.Count; i++)
                        {
                            for (int j = 0; j < currentnpcglobaldata.listofobstaclesinit.Count; j++)
                            {

                                if (currentnpcglobaldata.listofobstaclesontheway[i].x != currentnpcglobaldata.listofobstaclesinit[j].x &&
                                    currentnpcglobaldata.listofobstaclesontheway[i].y != currentnpcglobaldata.listofobstaclesinit[j].y)
                                {
                                    if (currentnpcglobaldata.listofobstaclesontheway[i].x != (int)Math.Round((double)currentnpcglobaldata.playerpos.x) && currentnpcglobaldata.listofobstaclesontheway[i].x != (int)Math.Round((double)currentnpcglobaldata.npcpos.x) &&
                                       currentnpcglobaldata.listofobstaclesontheway[i].y != (int)Math.Round((double)currentnpcglobaldata.playerpos.y) && currentnpcglobaldata.listofobstaclesontheway[i].y != (int)Math.Round((double)currentnpcglobaldata.npcpos.y))
                                    //if (listofobstaclesontheway[i].x != listofobstaclesinit[j].x && listofobstaclesontheway[i].x != (int)Math.Round((double)playerpos.x) && listofobstaclesontheway[i].x != (int)Math.Round((double)npcpos.x) || 
                                    //    listofobstaclesontheway[i].y != listofobstaclesinit[j].y && listofobstaclesontheway[i].y != (int)Math.Round((double)playerpos.y) && listofobstaclesontheway[i].y != (int)Math.Round((double)npcpos.y))
                                    {

                                        sccsvec2float dirnpctoobstacle = new sccsvec2float();
                                        dirnpctoobstacle.x = currentnpcglobaldata.listofobstaclesontheway[i].x - currentnpcglobaldata.npcpos.x;
                                        dirnpctoobstacle.y = currentnpcglobaldata.listofobstaclesontheway[i].y - currentnpcglobaldata.npcpos.y;

                                        sccsvec2float obstacleposition = new sccsvec2float();
                                        obstacleposition.x = currentnpcglobaldata.listofobstaclesontheway[i].x;
                                        obstacleposition.y = currentnpcglobaldata.listofobstaclesontheway[i].y;

                                        float distnpctoobstacle = sccsmaths.GetDistancefloat2dsqrt(obstacleposition, currentnpcglobaldata.npcpos);

                                        dirnpctoobstacle.x /= distnpctoobstacle;
                                        dirnpctoobstacle.y /= distnpctoobstacle;


                                        if (currentnpcglobaldata.currentnpcdirection.x != float.NaN && currentnpcglobaldata.currentnpcdirection.y != float.NaN)
                                        {
                                            if (currentnpcglobaldata.currentnpcdirection.x != 0 && currentnpcglobaldata.currentnpcdirection.y != 0)
                                            {
                                                float thedotnpcdirtonodevsnpctoobstacle = sccsmaths.Dot(dirnpctoobstacle.x, dirnpctoobstacle.y, currentnpcglobaldata.currentnpcdirection.x, currentnpcglobaldata.currentnpcdirection.y);



                                                //currentnpcglobaldata.adminnotify.Execute(playercharacter, "/dotobstaclea:" + thedotnpcdirtonodevsnpctoobstacle);

                                                if (thedotnpcdirtonodevsnpctoobstacle > 0.85f && distnpctoobstacle < 1.5f * 1.25f)
                                                {
                                                    currentnpcglobaldata.pathfindscript.startpathfind = 1;
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }









                /*

                if (currentnpcglobaldata.obstaclesonthewaytwo != null)// && directionnpctopathfindnodef.X != float.NaN && directionnpctopathfindnodef.Y != float.NaN)
                {
                    if (currentnpcglobaldata.obstaclesonthewaytwo.Count > 0)
                    {
                        var isTraversableTile = true;
                        foreach (var result in currentnpcglobaldata.obstaclesonthewaytwo.AsList())
                        {
                            var body = result.PhysicsBody;
                            if (body.AssociatedProtoTile is not null)
                            {
                                // untraversable tile - a cliff or water
                                isTraversableTile = false;
                                //break;
                            }

                            if (body.AssociatedWorldObject is not null)
                            {
                                // an obstacle - a world object
                                isTraversableTile = false;
                                //break;
                            }

                            if (isTraversableTile == false)
                            {
                                Vector2Ushort vec = body.Position.ToVector2Ushort();// + new Vector2Ushort(testPhysicsBody.CenterOffset.X, testPhysicsBody.CenterOffset.Y);

                                sccsvec2int posofobstacle = new sccsvec2int();
                                posofobstacle.x = (int)Math.Round((decimal)vec.X) + (int)Math.Round((decimal)body.CenterOffset.X);
                                posofobstacle.y = (int)Math.Round((decimal)vec.Y) + (int)Math.Round((decimal)body.CenterOffset.Y);

                                currentnpcglobaldata.listofobstaclesonthewaytwo.Add(posofobstacle);
                            }
                        }



                        for (int i = 0; i < currentnpcglobaldata.listofobstaclesonthewaytwo.Count; i++)
                        {
                            for (int j = 0; j < currentnpcglobaldata.listofobstaclesinit.Count; j++)
                            {

                                if (currentnpcglobaldata.listofobstaclesonthewaytwo[i].x != currentnpcglobaldata.listofobstaclesinit[j].x &&
                                    currentnpcglobaldata.listofobstaclesonthewaytwo[i].y != currentnpcglobaldata.listofobstaclesinit[j].y)
                                {
                                    if (currentnpcglobaldata.listofobstaclesonthewaytwo[i].x != (int)Math.Round((double)currentnpcglobaldata.playerpos.x) && currentnpcglobaldata.listofobstaclesonthewaytwo[i].x != (int)Math.Round((double)currentnpcglobaldata.npcpos.x) &&
                                       currentnpcglobaldata.listofobstaclesonthewaytwo[i].y != (int)Math.Round((double)currentnpcglobaldata.playerpos.y) && currentnpcglobaldata.listofobstaclesonthewaytwo[i].y != (int)Math.Round((double)currentnpcglobaldata.npcpos.y))
                                    //if (listofobstaclesonthewaytwo[i].x != listofobstaclesinit[j].x && listofobstaclesonthewaytwo[i].x != (int)Math.Round((double)playerpos.x) && listofobstaclesonthewaytwo[i].x != (int)Math.Round((double)npcpos.x) || 
                                    //    listofobstaclesonthewaytwo[i].y != listofobstaclesinit[j].y && listofobstaclesonthewaytwo[i].y != (int)Math.Round((double)playerpos.y) && listofobstaclesonthewaytwo[i].y != (int)Math.Round((double)npcpos.y))
                                    {

                                        sccsvec2float dirnpctoobstacle = new sccsvec2float();
                                        dirnpctoobstacle.x = currentnpcglobaldata.listofobstaclesonthewaytwo[i].x - currentnpcglobaldata.npcpos.x;
                                        dirnpctoobstacle.y = currentnpcglobaldata.listofobstaclesonthewaytwo[i].y - currentnpcglobaldata.npcpos.y;

                                        sccsvec2float obstacleposition = new sccsvec2float();
                                        obstacleposition.x = currentnpcglobaldata.listofobstaclesonthewaytwo[i].x;
                                        obstacleposition.y = currentnpcglobaldata.listofobstaclesonthewaytwo[i].y;

                                        float distnpctoobstacle = sccsmaths.GetDistancefloat2dsqrt(obstacleposition, currentnpcglobaldata.npcpos);

                                        dirnpctoobstacle.x /= distnpctoobstacle;
                                        dirnpctoobstacle.y /= distnpctoobstacle;


                                        if (currentnpcglobaldata.currentnpcdirection.x != float.NaN && currentnpcglobaldata.currentnpcdirection.y != float.NaN)
                                        {
                                            if (currentnpcglobaldata.currentnpcdirection.x != 0 && currentnpcglobaldata.currentnpcdirection.y != 0)
                                            {
                                                float thedotdirnpctoobstaclevsdirnpc = sccsmaths.Dot(dirnpctoobstacle.x, dirnpctoobstacle.y, currentnpcglobaldata.currentnpcdirection.x, currentnpcglobaldata.currentnpcdirection.y);

                                                currentnpcglobaldata.adminnotify.Execute(playercharacter, "/dotobstacleb:" + thedotdirnpctoobstaclevsdirnpc);

                                                if (thedotdirnpctoobstaclevsdirnpc > 0.85f && distnpctoobstacle < 1.5f * 1.25f)
                                                {
                                                    currentnpcglobaldata.pathfindscript.startpathfind = 1;
                                                }
                                                else
                                                {
                                                    continue;

                                                }
                                            }


                                            //break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                */
                currentnpcglobaldata.swtcobstaclesontheway = 1;

            }
        }


        /*
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
        }*/
    }
}