//DEVELOPPED BY STEVE CHASSÉ AKA NINEKORN AKA NINE AKA 9 dob13may1983. 2023 JUNE 06TH REVISION

using AtomicTorch.CBND.GameApi.Data.Characters;
using AtomicTorch.CBND.GameApi.Data.Physics;
using AtomicTorch.GameEngine.Common.Primitives;
using System;
using System.Collections.Generic;
using static sccspathfindstructs;
using sccsvec2int = sccspathfindstructs.sccsvec2int;

namespace AtomicTorch.CBND.CoreMod.Scripts.sccsPathfind
{
    public static class sccspathfindobstaclecheck
    {

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

                if (currentnpcglobaldata.listofobstaclesontheway != null)
                {
                    currentnpcglobaldata.listofobstaclesontheway.Clear();
                }
                else
                {
                    currentnpcglobaldata.listofobstaclesontheway = new List<sccspathfindobstaclestruct>();
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

                                /*if (body.AssociatedProtoTile.Name == "Forest (Temperate)" || body.AssociatedProtoTile.Name == "Forest (temperate)")
                                {
                                    isTraversableTile = true;
                                }
                                else
                                {
                                    isTraversableTile = false;
                                }*/
                                // untraversable tile - a cliff or water
                                //break;

                                isTraversableTile = false;
                            }

                            if (body.AssociatedWorldObject is not null)
                            {

                                /*if (body.AssociatedWorldObject.GameObjectType == GameApi.Data.GameObjectType.Character)
                                {
                                    isTraversableTile = true;

                                }
                                else
                                {
                                    isTraversableTile = false;
                                }*/
                                //currentnpcglobaldata.adminnotify.Execute(currentnpcglobaldata.playercharacter, "/1obstacle:" + body.AssociatedWorldObject.GameObjectType);

                                // an obstacle - a world object

                                //break;

                                isTraversableTile = false;
                            }


                            if (isTraversableTile == false)
                            {
                                Vector2Ushort vec = body.Position.ToVector2Ushort();// + new Vector2Ushort(testPhysicsBody.CenterOffset.X, testPhysicsBody.CenterOffset.Y);

                                sccsvec2int posofobstacle = new sccsvec2int();
                                posofobstacle.x = (int)Math.Round((decimal)vec.X) + (int)Math.Round((decimal)body.CenterOffset.X);
                                posofobstacle.y = (int)Math.Round((decimal)vec.Y) + (int)Math.Round((decimal)body.CenterOffset.Y);



                                sccspathfindobstaclestruct theobstaclestruct = new sccspathfindobstaclestruct();
                                theobstaclestruct.theobstacleposition = new sccsvec2int();
                                theobstaclestruct.theobstacleposition.x = posofobstacle.x;
                                theobstaclestruct.theobstacleposition.y = posofobstacle.y;
                                theobstaclestruct.obstaclenodeswtc = 1;

                                currentnpcglobaldata.listofobstaclesontheway.Add(theobstaclestruct);
                            }
                        }



                        for (int i = 0; i < currentnpcglobaldata.listofobstaclesontheway.Count; i++)
                        {
                            for (int j = 0; j < currentnpcglobaldata.listofobstaclesinit.Count; j++)
                            {

                                if (currentnpcglobaldata.listofobstaclesontheway[i].theobstacleposition.x != currentnpcglobaldata.listofobstaclesinit[j].theobstacleposition.x &&
                                    currentnpcglobaldata.listofobstaclesontheway[i].theobstacleposition.y != currentnpcglobaldata.listofobstaclesinit[j].theobstacleposition.y)
                                {
                                    if (currentnpcglobaldata.listofobstaclesontheway[i].theobstacleposition.x != (int)Math.Round((double)currentnpcglobaldata.playerpos.x) && currentnpcglobaldata.listofobstaclesontheway[i].theobstacleposition.x != (int)Math.Round((double)currentnpcglobaldata.npcpos.x) &&
                                       currentnpcglobaldata.listofobstaclesontheway[i].theobstacleposition.y != (int)Math.Round((double)currentnpcglobaldata.playerpos.y) && currentnpcglobaldata.listofobstaclesontheway[i].theobstacleposition.y != (int)Math.Round((double)currentnpcglobaldata.npcpos.y))
                                    //if (listofobstaclesontheway[i].x != listofobstaclesinit[j].x && listofobstaclesontheway[i].x != (int)Math.Round((double)playerpos.x) && listofobstaclesontheway[i].x != (int)Math.Round((double)npcpos.x) || 
                                    //    listofobstaclesontheway[i].y != listofobstaclesinit[j].y && listofobstaclesontheway[i].y != (int)Math.Round((double)playerpos.y) && listofobstaclesontheway[i].y != (int)Math.Round((double)npcpos.y))
                                    {

                                        sccsvec2float dirnpctoobstacle = new sccsvec2float();
                                        dirnpctoobstacle.x = currentnpcglobaldata.listofobstaclesontheway[i].theobstacleposition.x - currentnpcglobaldata.npcpos.x;
                                        dirnpctoobstacle.y = currentnpcglobaldata.listofobstaclesontheway[i].theobstacleposition.y - currentnpcglobaldata.npcpos.y;

                                        sccsvec2float obstacleposition = new sccsvec2float();
                                        obstacleposition.x = currentnpcglobaldata.listofobstaclesontheway[i].theobstacleposition.x;
                                        obstacleposition.y = currentnpcglobaldata.listofobstaclesontheway[i].theobstacleposition.y;

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
                currentnpcglobaldata.swtcobstaclesontheway = 1;

            }
        }
    }
}
