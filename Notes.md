# IMPORTANT
### Naming Scheme - Subtype IDs
DSV-<Faction>-<Sector>-<Ship>-<Sub-Behavior>-<TypeOfProfile>-<DescriptionOfProfile>

Examples:
`DSV-TCOTM-InnerCore-Battleship-Patrol-Target-LongRangeEngagement`
`DSV-LNTRI-FarReaches-CargoHauler-Cargo-Autopilot-SlowboatTransit`

### Naming Scheme - File Structure
<`Data`>
> <Faction>
> > <`Behavior`>
> > > <`Autopilot`>
> > > > <Ship>
> > > > > [1-InnerCore.sbc]
> > > > > [2-OuterCore.sbc]
> > > > > [3-InnerTerritory.sbc]
> > > > > [4-OuterTerritory.sbc]
> > > > > [5-FarReaches.sbc]
> > > <`Command`>
> > > > <Ship>
> > > > > [1-InnerCore.sbc]
> > > > > [2-OuterCore.sbc]
> > > > > [3-InnerTerritory.sbc]
> > > > > [4-OuterTerritory.sbc]
> > > > > [5-FarReaches.sbc]
> > > <`CoreBehavior`>
> > > > <Ship>
> > > > > [1-InnerCore.sbc]
> > > > > [2-OuterCore.sbc]
> > > > > [3-InnerTerritory.sbc]
> > > > > [4-OuterTerritory.sbc]
> > > > > [5-FarReaches.sbc]
> > > <`Target`>
> > > > <Ship>
> > > > > [1-InnerCore.sbc]
> > > > > [2-OuterCore.sbc]
> > > > > [3-InnerTerritory.sbc]
> > > > > [4-OuterTerritory.sbc]
> > > > > [5-FarReaches.sbc]
> > > <`Triggers`>
> > > > <Ship>
> > > > > [1-InnerCore.sbc]
> > > > > [2-OuterCore.sbc]
> > > > > [3-InnerTerritory.sbc]
> > > > > [4-OuterTerritory.sbc]
> > > > > [5-FarReaches.sbc]
> > > > > <Action>
> > > > > > [1-InnerCore.sbc]
> > > > > > [2-OuterCore.sbc]
> > > > > > [3-InnerTerritory.sbc]
> > > > > > [4-OuterTerritory.sbc]
> > > > > > [5-FarReaches.sbc]
> > > <`Weapons`>
> > > > <Ship>
> > > > > [1-InnerCore.sbc]
> > > > > [2-OuterCore.sbc]
> > > > > [3-InnerTerritory.sbc]
> > > > > [4-OuterTerritory.sbc]
> > > > > [5-FarReaches.sbc]
> >  <`Spawning`>
> > > <`Manipulation`>
> > > > <Sector>
> > > > > <Ship>
> > > > > > [Manipulation.sbc]
> > > > > > [LootProfiles.sbc]
> > > > > > <`LootTables`>
> > > > > > > [1-Common.sbc]
> > > > > > > [2-Uncommon.sbc]
> > > > > > > [3-Rare.sbc]
> > > > > > > [4-Exotic.sbc]
> > > <`Prefabs`>
> > > > ['''Grid Prefabs Here''']
> > > <`SpawnGroups`>
> > > > <Sector>
> > > > > ['''Individual Spawn Groups Here''']
> > > <`SpawningConditions`>
> > > > [ZoningSpawnConditions.sbc]
> > > > <`ZoneConditions`>
> > > > > [ZoneDistanceConditions.sbc]



## Troubleshooting in game:
/MES.Info.GetAllProfiles
/MES.Info.GetGridBehavior


## MES Offset
MES Offset:
X = Right (+) / Left (-)
Y = Up (+) / Down (-)
Z = Backwards (+) / Forwards (-)



## Used Mods:
- Aryx Weapon Enterprises (Modified)
- Deflector Shields
- Defense Shields
- Jump Drive Inhibitor
- AQD Conveyor Expansion


## Other Notes
Don't forget to spawn in all NPCs and BP again so they start with full shields



## Ideas for "Smart" Actions
- Call For reinforcements when taking too much damage (threshold, could be multi-layered and/or set up on a delay)
- Switch between strafe and orbiting attack patterns


## Fight Style
- Attempt to disable ships rather than destroy