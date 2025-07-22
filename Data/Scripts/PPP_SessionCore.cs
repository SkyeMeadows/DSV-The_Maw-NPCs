using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Common.ObjectBuilders.Definitions;
using Sandbox.Definitions;
using Sandbox.Game;
using Sandbox.Game.Entities;
using Sandbox.Game.EntityComponents;
using Sandbox.Game.GameSystems;
using Sandbox.ModAPI;
using Sandbox.ModAPI.Interfaces;
using Sandbox.ModAPI.Weapons;
using SpaceEngineers.Game.ModAPI;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.Entity;
using VRage.Game.ModAPI;
using VRage.ModAPI;
using VRage.ObjectBuilders;
using VRage.Utils;
using VRageMath;

namespace PerpetuallyPerturbedPirates {

    [MySessionComponentDescriptor(MyUpdateOrder.BeforeSimulation)]

    public class PPP_SessionCore : MySessionComponentBase {

        public List<IMyIdentity> IdList = new List<IMyIdentity>();
        public List<long> ReduceRep = new List<long>();
        public IMyFaction PirateFaction = null;
        public int Counter = 0;

        public override void UpdateBeforeSimulation() {

            Counter++;

            if (Counter < 300)
                return;

            Counter = 0;

            if (!MyAPIGateway.Multiplayer.IsServer)
                return;

            MyAPIGateway.Parallel.Start(() => {

                if (PirateFaction == null) {

                    PirateFaction = MyAPIGateway.Session.Factions.TryGetFactionByTag("TCOTM");

                    if (PirateFaction == null)
                        return;
                
                }

                IdList.Clear();
                MyAPIGateway.Players.GetAllIdentites(IdList);

                foreach (var id in IdList) {

                    if (MyAPIGateway.Players.TryGetSteamId(id.IdentityId) > 0) {

                        var playerRep = MyAPIGateway.Session.Factions.GetReputationBetweenPlayerAndFaction(id.IdentityId, PirateFaction.FactionId);

                        if (playerRep <= -600)
                            continue;

                        ReduceRep.Add(id.IdentityId);
                    
                    }
                
                }
                
            
            },() => {

                if (PirateFaction == null)
                    return;

                foreach (var id in ReduceRep) {

                    MyAPIGateway.Session.Factions.SetReputationBetweenPlayerAndFaction(id, PirateFaction.FactionId, -600);

                }

                ReduceRep.Clear();

            });

        }


    }

}