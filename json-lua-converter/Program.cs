﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace json_lua_converter
{
    class Program
    {
        // TODO: Read source json
        static void Main(string[] args)
        {
						var raid_drop_data = @"[
        {
            ""name"": ""Aged Core Leather Gloves"",
            ""price"": 50,
            ""id"": 18823,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18823""
        },
        {
            ""name"": ""Ancient Cornerstone Grimoire"",
            ""price"": 2,
            ""id"": 17067,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=17067""
        },
        {
            ""name"": ""Ancient Petrified Leaf"",
            ""price"": 40,
            ""id"": 18703,
            ""fortank"": ""No"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18703""
        },
        {
            ""name"": ""Arcanist Belt"",
            ""price"": 20,
            ""id"": 16802,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16802""
        },
        {
            ""name"": ""Arcanist Bindings"",
            ""price"": 20,
            ""id"": 16799,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16799""
        },
        {
            ""name"": ""Arcanist Boots"",
            ""price"": 20,
            ""id"": 16800,
            ""fortank"": ""No"",
            ""bosses"": ""Lucifron"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16800""
        },
        {
            ""name"": ""Arcanist Crown"",
            ""price"": 2,
            ""id"": 16795,
            ""fortank"": ""No"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16795""
        },
        {
            ""name"": ""Arcanist Gloves"",
            ""price"": 20,
            ""id"": 16801,
            ""fortank"": ""No"",
            ""bosses"": ""Shazzrah"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16801""
        },
        {
            ""name"": ""Arcanist Leggings"",
            ""price"": 2,
            ""id"": 16796,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16796""
        },
        {
            ""name"": ""Arcanist Mantle"",
            ""price"": 20,
            ""id"": 16797,
            ""fortank"": ""No"",
            ""bosses"": ""Baron Geddon"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16797""
        },
        {
            ""name"": ""Arcanist Robes"",
            ""price"": 20,
            ""id"": 16798,
            ""fortank"": ""No"",
            ""bosses"": ""Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16798""
        },
        {
            ""name"": ""Aurastone Hammer"",
            ""price"": 40,
            ""id"": 17105,
            ""fortank"": ""No"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17105""
        },
        {
            ""name"": ""Azuresong Mageblade"",
            ""price"": 60,
            ""id"": 17103,
            ""fortank"": ""No"",
            ""bosses"": ""Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17103""
        },
        {
            ""name"": ""Band of Accuria"",
            ""price"": 50,
            ""id"": 17063,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17063""
        },
        {
            ""name"": ""Band of Sulfuras"",
            ""price"": 20,
            ""id"": 19138,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=19138""
        },
        {
            ""name"": ""Belt of Might"",
            ""price"": 20,
            ""id"": 16864,
            ""fortank"": ""Yes"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16864""
        },
        {
            ""name"": ""Bindings of the Windseeker"",
            ""price"": 120,
            ""id"": 18564,
            ""fortank"": ""Yes"",
            ""bosses"": ""Baron Geddon"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18564""
        },
        {
            ""name"": ""Blastershot Launcher"",
            ""price"": 2,
            ""id"": 17072,
            ""fortank"": ""No"",
            ""bosses"": ""Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17072""
        },
        {
            ""name"": ""Bloodfang Hood"",
            ""price"": 30,
            ""id"": 16908,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=16908""
        },
        {
            ""name"": ""Bloodfang Pants"",
            ""price"": 30,
            ""id"": 16909,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16909""
        },
        {
            ""name"": ""Bonereaver's Edge"",
            ""price"": 80,
            ""id"": 17076,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17076""
        },
        {
            ""name"": ""Boots of Prophecy"",
            ""price"": 20,
            ""id"": 16811,
            ""fortank"": ""No"",
            ""bosses"": ""Shazzrah"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16811""
        },
        {
            ""name"": ""Bracers of Might"",
            ""price"": 20,
            ""id"": 16861,
            ""fortank"": ""Yes"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16861""
        },
        {
            ""name"": ""Breatplate of Might"",
            ""price"": 20,
            ""id"": 16865,
            ""fortank"": ""Yes"",
            ""bosses"": ""Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16865""
        },
        {
            ""name"": ""Brutality Blade"",
            ""price"": 40,
            ""id"": 18832,
            ""fortank"": ""No"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18832""
        },
        {
            ""name"": ""Cauterizing Band"",
            ""price"": 50,
            ""id"": 19140,
            ""fortank"": ""No"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=19140""
        },
        {
            ""name"": ""Cenarion Belt"",
            ""price"": 20,
            ""id"": 16828,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16828""
        },
        {
            ""name"": ""Cenarion Boots"",
            ""price"": 20,
            ""id"": 16829,
            ""fortank"": ""No"",
            ""bosses"": ""Lucifron"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16829""
        },
        {
            ""name"": ""Cenarion Bracers"",
            ""price"": 20,
            ""id"": 16830,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16830""
        },
        {
            ""name"": ""Cenarion Gloves"",
            ""price"": 20,
            ""id"": 16831,
            ""fortank"": ""No"",
            ""bosses"": ""Shazzrah"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16831""
        },
        {
            ""name"": ""Cenarion Helm"",
            ""price"": 2,
            ""id"": 16834,
            ""fortank"": ""No"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16834""
        },
        {
            ""name"": ""Cenarion Leggings"",
            ""price"": 2,
            ""id"": 16835,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16835""
        },
        {
            ""name"": ""Cenarion Spaulders"",
            ""price"": 20,
            ""id"": 16836,
            ""fortank"": ""No"",
            ""bosses"": ""Baron Geddon"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16836""
        },
        {
            ""name"": ""Cenarion Vestments"",
            ""price"": 20,
            ""id"": 16833,
            ""fortank"": ""No"",
            ""bosses"": ""Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16833""
        },
        {
            ""name"": ""Choker of Enlightenment"",
            ""price"": 5,
            ""id"": 17109,
            ""fortank"": ""No"",
            ""bosses"": ""Lucifron"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17109""
        },
        {
            ""name"": ""Choker of the Fire Lord"",
            ""price"": 55,
            ""id"": 18814,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18814""
        },
        {
            ""name"": ""Circlet of Prophecy"",
            ""price"": 2,
            ""id"": 16813,
            ""fortank"": ""No"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16813""
        },
        {
            ""name"": ""Cloak of the Shrouded Mists"",
            ""price"": 25,
            ""id"": 17102,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17102""
        },
        {
            ""name"": ""Core Forged Greaves"",
            ""price"": 0,
            ""id"": 18806,
            ""fortank"": ""Yes"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18806""
        },
        {
            ""name"": ""Core Hound Tooth"",
            ""price"": 40,
            ""id"": 18805,
            ""fortank"": ""No"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18805""
        },
        {
            ""name"": ""Crimson Shocker"",
            ""price"": 0,
            ""id"": 17077,
            ""fortank"": ""No"",
            ""bosses"": ""Gehennas, Shazzrah, Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17077""
        },
        {
            ""name"": ""Crown of Destruction"",
            ""price"": 30,
            ""id"": 18817,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18817""
        },
        {
            ""name"": ""Deathbringer"",
            ""price"": 20,
            ""id"": 17068,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=17068""
        },
        {
            ""name"": ""Dragon's Blood Cape"",
            ""price"": 0,
            ""id"": 17107,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17107""
        },
        {
            ""name"": ""Dragonstalker's Helm"",
            ""price"": 30,
            ""id"": 16939,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=16939""
        },
        {
            ""name"": ""Dragonstalker's Legguards"",
            ""price"": 30,
            ""id"": 16938,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16938""
        },
        {
            ""name"": ""Drillborer Disk"",
            ""price"": 40,
            ""id"": 17066,
            ""fortank"": ""Yes"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17066""
        },
        {
            ""name"": ""Earthshaker"",
            ""price"": 2,
            ""id"": 17073,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17073""
        },
        {
            ""name"": ""Eskhandar's Collar"",
            ""price"": 20,
            ""id"": 18205,
            ""fortank"": ""Yes"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=18205""
        },
        {
            ""name"": ""Eskhandar's Right Claw"",
            ""price"": 40,
            ""id"": 18203,
            ""fortank"": ""Yes"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18203""
        },
        {
            ""name"": ""Essence of the Pure Flame"",
            ""price"": 2,
            ""id"": 18815,
            ""fortank"": ""Yes"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18815""
        },
        {
            ""name"": ""Eye of Sulfuras"",
            ""price"": 120,
            ""id"": 17204,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17204""
        },
        {
            ""name"": ""Felheart Belt"",
            ""price"": 20,
            ""id"": 16806,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16806""
        },
        {
            ""name"": ""Felheart Bracers"",
            ""price"": 20,
            ""id"": 16804,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16804""
        },
        {
            ""name"": ""Felheart Gloves"",
            ""price"": 20,
            ""id"": 16805,
            ""fortank"": ""No"",
            ""bosses"": ""Lucifron"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16805""
        },
        {
            ""name"": ""Felheart Horns"",
            ""price"": 2,
            ""id"": 16808,
            ""fortank"": ""No"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16808""
        },
        {
            ""name"": ""Felheart Pants"",
            ""price"": 2,
            ""id"": 16810,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16810""
        },
        {
            ""name"": ""Felheart Robes"",
            ""price"": 20,
            ""id"": 16809,
            ""fortank"": ""No"",
            ""bosses"": ""Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16809""
        },
        {
            ""name"": ""Felheart Shoulder Pads"",
            ""price"": 20,
            ""id"": 16807,
            ""fortank"": ""No"",
            ""bosses"": ""Baron Geddon"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16807""
        },
        {
            ""name"": ""Felheart Slippers"",
            ""price"": 20,
            ""id"": 16803,
            ""fortank"": ""No"",
            ""bosses"": ""Shazzrah"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16803""
        },
        {
            ""name"": ""Finkle's Lava Dredger"",
            ""price"": 25,
            ""id"": 18803,
            ""fortank"": ""No"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18803""
        },
        {
            ""name"": ""Fire Runed Grimoire"",
            ""price"": 15,
            ""id"": 19142,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=19142""
        },
        {
            ""name"": ""Fireguard Shoulders"",
            ""price"": 0,
            ""id"": 19139,
            ""fortank"": ""No"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=19139""
        },
        {
            ""name"": ""Fireproof Cloak"",
            ""price"": 0,
            ""id"": 18811,
            ""fortank"": ""No"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18811""
        },
        {
            ""name"": ""Flameguard Gauntlets"",
            ""price"": 40,
            ""id"": 19143,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=19143""
        },
        {
            ""name"": ""Flamewaker Legplates"",
            ""price"": 5,
            ""id"": 18861,
            ""fortank"": ""Yes"",
            ""bosses"": ""Lucifron, Magmadar, Gehennas, Garr, Baron Geddon, Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18861""
        },
        {
            ""name"": ""Gauntlets of Might"",
            ""price"": 20,
            ""id"": 16863,
            ""fortank"": ""Yes"",
            ""bosses"": ""Lucifron"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16863""
        },
        {
            ""name"": ""Giantstalker's Belt"",
            ""price"": 20,
            ""id"": 16851,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16851""
        },
        {
            ""name"": ""Giantstalker's Boots"",
            ""price"": 20,
            ""id"": 16849,
            ""fortank"": ""No"",
            ""bosses"": ""Gehennas"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16849""
        },
        {
            ""name"": ""Giantstalker's Bracers"",
            ""price"": 20,
            ""id"": 16850,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16850""
        },
        {
            ""name"": ""Giantstalker's Breastplate"",
            ""price"": 20,
            ""id"": 16845,
            ""fortank"": ""No"",
            ""bosses"": ""Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16845""
        },
        {
            ""name"": ""Giantstalker's Epaulets"",
            ""price"": 20,
            ""id"": 16848,
            ""fortank"": ""No"",
            ""bosses"": ""Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16848""
        },
        {
            ""name"": ""Giantstalker's Gloves"",
            ""price"": 20,
            ""id"": 16852,
            ""fortank"": ""No"",
            ""bosses"": ""Shazzrah"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16852""
        },
        {
            ""name"": ""Giantstalker's Helmet"",
            ""price"": 2,
            ""id"": 16846,
            ""fortank"": ""No"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16846""
        },
        {
            ""name"": ""Giantstalker's Leggings"",
            ""price"": 2,
            ""id"": 16847,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16847""
        },
        {
            ""name"": ""Girdle of Prophecy"",
            ""price"": 20,
            ""id"": 16817,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16817""
        },
        {
            ""name"": ""Gloves of Prophecy"",
            ""price"": 20,
            ""id"": 16812,
            ""fortank"": ""No"",
            ""bosses"": ""Gehennas"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16812""
        },
        {
            ""name"": ""Gloves of the Hypnotic Flame"",
            ""price"": 15,
            ""id"": 18808,
            ""fortank"": ""No"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18808""
        },
        {
            ""name"": ""Gutgore Ripper"",
            ""price"": 5,
            ""id"": 17071,
            ""fortank"": ""No"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17071""
        },
        {
            ""name"": ""Halo of Transcendence"",
            ""price"": 30,
            ""id"": 16921,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=16921""
        },
        {
            ""name"": ""Head of Onyxia"",
            ""price"": 50,
            ""id"": 18422,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=18422""
        },
        {
            ""name"": ""Heavy Dark Iron Ring"",
            ""price"": 45,
            ""id"": 18879,
            ""fortank"": ""Yes"",
            ""bosses"": ""Lucifron, Gehennas, Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18879""
        },
        {
            ""name"": ""Helm of Might"",
            ""price"": 2,
            ""id"": 16866,
            ""fortank"": ""Yes"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16866""
        },
        {
            ""name"": ""Helm of the Lifegiver"",
            ""price"": 20,
            ""id"": 18870,
            ""fortank"": ""No"",
            ""bosses"": ""Lucifron"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18870""
        },
        {
            ""name"": ""Helm of Wrath"",
            ""price"": 30,
            ""id"": 16963,
            ""fortank"": ""Yes"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=16963""
        },
        {
            ""name"": ""Judgement Crown"",
            ""price"": 30,
            ""id"": 16955,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=16955""
        },
        {
            ""name"": ""Judgement Legplates"",
            ""price"": 30,
            ""id"": 16954,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16954""
        },
        {
            ""name"": ""Lawbringer Belt"",
            ""price"": 20,
            ""id"": 16858,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16858""
        },
        {
            ""name"": ""Lawbringer Boots"",
            ""price"": 20,
            ""id"": 16859,
            ""fortank"": ""No"",
            ""bosses"": ""Lucifron"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16859""
        },
        {
            ""name"": ""Lawbringer Bracers"",
            ""price"": 20,
            ""id"": 16857,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16857""
        },
        {
            ""name"": ""Lawbringer Chestguard"",
            ""price"": 20,
            ""id"": 16853,
            ""fortank"": ""No"",
            ""bosses"": ""Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16853""
        },
        {
            ""name"": ""Lawbringer Gauntlets"",
            ""price"": 20,
            ""id"": 16860,
            ""fortank"": ""No"",
            ""bosses"": ""Gehennas"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16860""
        },
        {
            ""name"": ""Lawbringer Helm"",
            ""price"": 2,
            ""id"": 16854,
            ""fortank"": ""No"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16854""
        },
        {
            ""name"": ""Lawbringer Legplates"",
            ""price"": 2,
            ""id"": 16855,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16855""
        },
        {
            ""name"": ""Lawbringer Spaulders"",
            ""price"": 20,
            ""id"": 16856,
            ""fortank"": ""No"",
            ""bosses"": ""Baron Geddon"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16856""
        },
        {
            ""name"": ""Leggings of Transcendence"",
            ""price"": 30,
            ""id"": 16922,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16922""
        },
        {
            ""name"": ""Legplates of Might"",
            ""price"": 2,
            ""id"": 16867,
            ""fortank"": ""Yes"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16867""
        },
        {
            ""name"": ""Legplates of Wrath"",
            ""price"": 30,
            ""id"": 16962,
            ""fortank"": ""Yes"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16962""
        },
        {
            ""name"": ""Magma Tempered Boots"",
            ""price"": 2,
            ""id"": 18824,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar, Garr, Baron Geddon"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18824""
        },
        {
            ""name"": ""Malistar's Defender"",
            ""price"": 40,
            ""id"": 17106,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17106""
        },
        {
            ""name"": ""Mana Igniting Cord"",
            ""price"": 50,
            ""id"": 19136,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=19136""
        },
        {
            ""name"": ""Manastorm Leggings"",
            ""price"": 2,
            ""id"": 18872,
            ""fortank"": ""No"",
            ""bosses"": ""Lucifron, Gehennas, Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18872""
        },
        {
            ""name"": ""Mantle of Prophecy"",
            ""price"": 20,
            ""id"": 16816,
            ""fortank"": ""No"",
            ""bosses"": ""Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16816""
        },
        {
            ""name"": ""Mature Black Dragon Sinew"",
            ""price"": 5,
            ""id"": 18705,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=18705""
        },
        {
            ""name"": ""Medallion of Steadfast Might"",
            ""price"": 40,
            ""id"": 17065,
            ""fortank"": ""Yes"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17065""
        },
        {
            ""name"": ""Nemesis Leggings"",
            ""price"": 30,
            ""id"": 16930,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16930""
        },
        {
            ""name"": ""Nemesis Skullcap"",
            ""price"": 30,
            ""id"": 16929,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=16929""
        },
        {
            ""name"": ""Netherwind Crown"",
            ""price"": 30,
            ""id"": 16914,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=16914""
        },
        {
            ""name"": ""Netherwind Pants"",
            ""price"": 30,
            ""id"": 16915,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16915""
        },
        {
            ""name"": ""Nightslayer Belt"",
            ""price"": 20,
            ""id"": 16827,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16827""
        },
        {
            ""name"": ""Nightslayer Boots"",
            ""price"": 20,
            ""id"": 16824,
            ""fortank"": ""No"",
            ""bosses"": ""Shazzrah"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16824""
        },
        {
            ""name"": ""Nightslayer Bracelets"",
            ""price"": 20,
            ""id"": 16825,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16825""
        },
        {
            ""name"": ""Nightslayer Chestpiece"",
            ""price"": 20,
            ""id"": 16820,
            ""fortank"": ""No"",
            ""bosses"": ""Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16820""
        },
        {
            ""name"": ""Nightslayer Cover"",
            ""price"": 2,
            ""id"": 16821,
            ""fortank"": ""No"",
            ""bosses"": ""Garr"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16821""
        },
        {
            ""name"": ""Nightslayer Gloves"",
            ""price"": 20,
            ""id"": 16826,
            ""fortank"": ""No"",
            ""bosses"": ""Gehennas"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16826""
        },
        {
            ""name"": ""Nightslayer Pants"",
            ""price"": 2,
            ""id"": 16822,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16822""
        },
        {
            ""name"": ""Nightslayer Shoulder Pads"",
            ""price"": 20,
            ""id"": 16823,
            ""fortank"": ""No"",
            ""bosses"": ""Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16823""
        },
        {
            ""name"": ""Obsidian Edged Blade"",
            ""price"": 55,
            ""id"": 18822,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18822""
        },
        {
            ""name"": ""Onslaught Girdle"",
            ""price"": 60,
            ""id"": 19137,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=19137""
        },
        {
            ""name"": ""Pants of Prophecy"",
            ""price"": 2,
            ""id"": 16814,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16814""
        },
        {
            ""name"": ""Pauldrons of Might"",
            ""price"": 20,
            ""id"": 16868,
            ""fortank"": ""Yes"",
            ""bosses"": ""Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16868""
        },
        {
            ""name"": ""Perditions Blade"",
            ""price"": 50,
            ""id"": 18816,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18816""
        },
        {
            ""name"": ""Quick Strike Ring"",
            ""price"": 50,
            ""id"": 18821,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18821""
        },
        {
            ""name"": ""Ring of Binding"",
            ""price"": 0,
            ""id"": 18813,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=18813""
        },
        {
            ""name"": ""Ring of Spell Power"",
            ""price"": 45,
            ""id"": 19147,
            ""fortank"": ""No"",
            ""bosses"": ""Lucifron, Gehennas, Shazzrah, Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=19147""
        },
        {
            ""name"": ""Robe of Volatile Power"",
            ""price"": 50,
            ""id"": 19145,
            ""fortank"": ""No"",
            ""bosses"": ""Lucifron, Gehennas, Shazzrah"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=19145""
        },
        {
            ""name"": ""Robes of Prophecy"",
            ""price"": 20,
            ""id"": 16815,
            ""fortank"": ""No"",
            ""bosses"": ""Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16815""
        },
        {
            ""name"": ""Sabatons of Might"",
            ""price"": 20,
            ""id"": 16862,
            ""fortank"": ""Yes"",
            ""bosses"": ""Gehennas"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16862""
        },
        {
            ""name"": ""Sabatons of the Flamewalker"",
            ""price"": 2,
            ""id"": 19144,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=19144""
        },
        {
            ""name"": ""Salamander Scale Pants"",
            ""price"": 40,
            ""id"": 18875,
            ""fortank"": ""No"",
            ""bosses"": ""Gehennas, Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18875""
        },
        {
            ""name"": ""Sapphiron Drape"",
            ""price"": 20,
            ""id"": 17078,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=17078""
        },
        {
            ""name"": ""Sash of Whispered Secrets"",
            ""price"": 40,
            ""id"": 18809,
            ""fortank"": ""No"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18809""
        },
        {
            ""name"": ""Seal of the Archmagus"",
            ""price"": 0,
            ""id"": 17110,
            ""fortank"": ""No"",
            ""bosses"": ""Baron Geddon"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17110""
        },
        {
            ""name"": ""Shadowstrike"",
            ""price"": 2,
            ""id"": 17074,
            ""fortank"": ""No"",
            ""bosses"": ""Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17074""
        },
        {
            ""name"": ""Shard of Flame"",
            ""price"": 0,
            ""id"": 17082,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17082""
        },
        {
            ""name"": ""Shard of Scale"",
            ""price"": 55,
            ""id"": 17064,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=17064""
        },
        {
            ""name"": ""Sorcerous Dagger"",
            ""price"": 20,
            ""id"": 18878,
            ""fortank"": ""No"",
            ""bosses"": ""Gehennas, Shazzrah, Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18878""
        },
        {
            ""name"": ""Spinal Reaper"",
            ""price"": 45,
            ""id"": 17104,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17104""
        },
        {
            ""name"": ""Staff of Dominance"",
            ""price"": 60,
            ""id"": 18842,
            ""fortank"": ""No"",
            ""bosses"": ""Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18842""
        },
        {
            ""name"": ""Stormrage Cover"",
            ""price"": 30,
            ""id"": 16900,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=16900""
        },
        {
            ""name"": ""Stormrage Legguards"",
            ""price"": 30,
            ""id"": 16901,
            ""fortank"": ""No"",
            ""bosses"": ""Ragnaros"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16901""
        },
        {
            ""name"": ""Strikers Mark"",
            ""price"": 50,
            ""id"": 17069,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=17069""
        },
        {
            ""name"": ""Talisman of Ephemeral Power"",
            ""price"": 50,
            ""id"": 18820,
            ""fortank"": ""No"",
            ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18820""
        },
        {
            ""name"": ""The Eye of Divinity"",
            ""price"": 45,
            ""id"": 18646,
            ""fortank"": ""No"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18646""
        },
        {
            ""name"": ""Vambraces of Prophecy"",
            ""price"": 20,
            ""id"": 16819,
            ""fortank"": ""No"",
            ""bosses"": ""Trash"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=16819""
        },
        {
            ""name"": ""Vis'kag the Bloodletter"",
            ""price"": 50,
            ""id"": 17075,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=17075""
        },
        {
            ""name"": ""Wild Growth Spaulders"",
            ""price"": 55,
            ""id"": 18810,
            ""fortank"": ""No"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18810""
        },
        {
            ""name"": ""Wristguards of Stability"",
            ""price"": 50,
            ""id"": 19146,
            ""fortank"": ""No"",
            ""bosses"": ""Gehennas, Sulfuron Harbinger"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=19146""
        },
        {
            ""name"": ""Wristguards of True Flight"",
            ""price"": 10,
            ""id"": 18812,
            ""fortank"": ""No"",
            ""bosses"": ""Major Domo"",
            ""raid"": ""Molten Core"",
            ""url"": ""https://classic.wowhead.com/item=18812""
        },
        {
            ""name"": ""Onyxia Hide Backpack"",
            ""price"": 0,
            ""id"": 17966,
            ""fortank"": ""No"",
            ""bosses"": ""Onyxia"",
            ""raid"": ""Onyxia"",
            ""url"": ""https://classic.wowhead.com/item=17966""
        },
        {
            ""name"": ""Aegis of Preservation"",
            ""price"": 0,
            ""id"": 19345,
            ""fortank"": ""No"",
            ""bosses"": ""Ebonroc"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19345"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Amulet of Shadow Shielding"",
            ""price"": 0,
            ""id"": 21529,
            ""fortank"": ""Yes"",
            ""bosses"": ""Nefarius's Corruption"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=21529"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Angelista's Grasp"",
            ""price"": 5,
            ""id"": 19388,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19388"",
            ""type"": ""Cloth Waist""
        },
        {
            ""name"": ""Arcane Infused Gem"",
            ""price"": 0,
            ""id"": 19336,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19336"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Archimtiros' Ring of Reckoning"",
            ""price"": 5,
            ""id"": 19376,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19376"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Ashjre'thul, Crossbow of Smiting"",
            ""price"": 65,
            ""id"": 19361,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19361"",
            ""type"": ""Ranged Crossbow""
        },
        {
            ""name"": ""Ashkandi, Greatsword of the Brotherhood"",
            ""price"": 45,
            ""id"": 19364,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19364"",
            ""type"": ""Two-hand Sword""
        },
        {
            ""name"": ""Band of Dark Dominion"",
            ""price"": 20,
            ""id"": 19434,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19434"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Band of Forced Concentration"",
            ""price"": 30,
            ""id"": 19403,
            ""fortank"": ""No"",
            ""bosses"": ""Ebonroc"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19403"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Belt of Transcendence"",
            ""price"": 15,
            ""id"": 16925,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16925"",
            ""type"": ""Cloth Waist""
        },
        {
            ""name"": ""Bindings of Transcendence"",
            ""price"": 15,
            ""id"": 16926,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16926"",
            ""type"": ""Cloth Wrists""
        },
        {
            ""name"": ""Black Ash Robe"",
            ""price"": 0,
            ""id"": 19399,
            ""fortank"": ""No"",
            ""bosses"": ""Firemaw"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19399"",
            ""type"": ""Cloth Chest""
        },
        {
            ""name"": ""Black Brood Pauldrons"",
            ""price"": 2,
            ""id"": 19373,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19373"",
            ""type"": ""Mail Shoulders""
        },
        {
            ""name"": ""Bloodfang Belt"",
            ""price"": 15,
            ""id"": 16910,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16910"",
            ""type"": ""Leather Waist""
        },
        {
            ""name"": ""Bloodfang Boots"",
            ""price"": 20,
            ""id"": 16906,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16906"",
            ""type"": ""Leather Feet""
        },
        {
            ""name"": ""Bloodfang Bracers"",
            ""price"": 15,
            ""id"": 16911,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16911"",
            ""type"": ""Leather Wrists""
        },
        {
            ""name"": ""Bloodfang Chestpiece"",
            ""price"": 25,
            ""id"": 16905,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16905"",
            ""type"": ""Leather Chest""
        },
        {
            ""name"": ""Bloodfang Gloves"",
            ""price"": 5,
            ""id"": 16907,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16907"",
            ""type"": ""Leather Hands""
        },
        {
            ""name"": ""Bloodfang Spaulders"",
            ""price"": 5,
            ""id"": 16832,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16832"",
            ""type"": ""Leather Shoulders""
        },
        {
            ""name"": ""Boots of Pure Thought"",
            ""price"": 20,
            ""id"": 19437,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19437"",
            ""type"": ""Cloth Feet""
        },
        {
            ""name"": ""Boots of the Shadow Flame"",
            ""price"": 40,
            ""id"": 19381,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19381"",
            ""type"": ""Leather Feet""
        },
        {
            ""name"": ""Boots of Transcendence"",
            ""price"": 20,
            ""id"": 16919,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16919"",
            ""type"": ""Cloth Feet""
        },
        {
            ""name"": ""Bracelets of Wrath"",
            ""price"": 15,
            ""id"": 16959,
            ""fortank"": ""Yes"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16959"",
            ""type"": ""Plate Wrists""
        },
        {
            ""name"": ""Bracers of Arcane Accuracy"",
            ""price"": 25,
            ""id"": 19374,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19374"",
            ""type"": ""Cloth Wrists""
        },
        {
            ""name"": ""Breastplate of Wrath"",
            ""price"": 25,
            ""id"": 16966,
            ""fortank"": ""Yes"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16966"",
            ""type"": ""Plate Chest""
        },
        {
            ""name"": ""Chromatic Boots"",
            ""price"": 65,
            ""id"": 19387,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19387"",
            ""type"": ""Plate Feet""
        },
        {
            ""name"": ""Chromatically Tempered Sword"",
            ""price"": 50,
            ""id"": 19352,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19352"",
            ""type"": ""One-hand Sword""
        },
        {
            ""name"": ""Circle of Applied Force"",
            ""price"": 10,
            ""id"": 19432,
            ""fortank"": ""No"",
            ""bosses"": ""Flamegor"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19432"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Claw of Chromaggus"",
            ""price"": 40,
            ""id"": 19347,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19347"",
            ""type"": ""One-hand Dagger""
        },
        {
            ""name"": ""Claw of the Black Drake"",
            ""price"": 5,
            ""id"": 19365,
            ""fortank"": ""No"",
            ""bosses"": ""Firemaw"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19365"",
            ""type"": ""Main Hand Fist""
        },
        {
            ""name"": ""Cloak of Draconic Might"",
            ""price"": 30,
            ""id"": 19436,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19436"",
            ""type"": ""Cloth Back""
        },
        {
            ""name"": ""Cloak of Firemaw"",
            ""price"": 15,
            ""id"": 19398,
            ""fortank"": ""No"",
            ""bosses"": ""Firemaw"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19398"",
            ""type"": ""Cloth Back""
        },
        {
            ""name"": ""Cloak of the Brood Lord"",
            ""price"": 20,
            ""id"": 19378,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19378"",
            ""type"": ""Cloth Back""
        },
        {
            ""name"": ""Crul'shorukh, Edge of Chaos"",
            ""price"": 20,
            ""id"": 19363,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19363"",
            ""type"": ""One-hand Axe""
        },
        {
            ""name"": ""Doom's Edge"",
            ""price"": 10,
            ""id"": 19362,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19362"",
            ""type"": ""One-hand Axe""
        },
        {
            ""name"": ""Draconic Avenger"",
            ""price"": 5,
            ""id"": 19354,
            ""fortank"": ""No"",
            ""bosses"": ""Death Talon Wyrmguard"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19354"",
            ""type"": ""Two-hand Axe""
        },
        {
            ""name"": ""Draconic Maul"",
            ""price"": 10,
            ""id"": 19358,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19358"",
            ""type"": ""Two-hand Mace""
        },
        {
            ""name"": ""Dragon's Touch"",
            ""price"": 5,
            ""id"": 19367,
            ""fortank"": ""No"",
            ""bosses"": ""Flamegor"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19367"",
            ""type"": ""Ranged Wand""
        },
        {
            ""name"": ""Dragonbreath Hand Cannon"",
            ""price"": 10,
            ""id"": 19368,
            ""fortank"": ""Yes"",
            ""bosses"": ""Ebonroc"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19368"",
            ""type"": ""Ranged Gun""
        },
        {
            ""name"": ""Dragonfang Blade"",
            ""price"": 10,
            ""id"": 19346,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19346"",
            ""type"": ""One-hand Dagger""
        },
        {
            ""name"": ""Dragonstalker's Belt"",
            ""price"": 15,
            ""id"": 16936,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16936"",
            ""type"": ""Mail Waist""
        },
        {
            ""name"": ""Dragonstalker's Bracers"",
            ""price"": 15,
            ""id"": 16935,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16935"",
            ""type"": ""Mail Wrists""
        },
        {
            ""name"": ""Dragonstalker's Breastplate"",
            ""price"": 25,
            ""id"": 16942,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16942"",
            ""type"": ""Mail Chest""
        },
        {
            ""name"": ""Dragonstalker's Gauntlets"",
            ""price"": 20,
            ""id"": 16940,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16940"",
            ""type"": ""Mail Hands""
        },
        {
            ""name"": ""Dragonstalker's Greaves"",
            ""price"": 20,
            ""id"": 16941,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16941"",
            ""type"": ""Mail Feet""
        },
        {
            ""name"": ""Dragonstalker's Spaulders"",
            ""price"": 40,
            ""id"": 16937,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16937"",
            ""type"": ""Mail Shoulders""
        },
        {
            ""name"": ""Drake Fang Talisman"",
            ""price"": 60,
            ""id"": 19406,
            ""fortank"": ""No"",
            ""bosses"": ""Ebonroc"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19406"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Drake Talon Cleaver"",
            ""price"": 30,
            ""id"": 19353,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19353"",
            ""type"": ""Two-hand Axe""
        },
        {
            ""name"": ""Drake Talon Pauldrons"",
            ""price"": 40,
            ""id"": 19394,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19394"",
            ""type"": ""Plate Shoulders""
        },
        {
            ""name"": ""Ebony Flame Gloves"",
            ""price"": 20,
            ""id"": 19407,
            ""fortank"": ""No"",
            ""bosses"": ""Ebonroc"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19407"",
            ""type"": ""Cloth Hands""
        },
        {
            ""name"": ""Elementium Reinforced Bulwark"",
            ""price"": 40,
            ""id"": 19349,
            ""fortank"": ""Yes"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19349"",
            ""type"": ""Shield""
        },
        {
            ""name"": ""Elementium Threaded Cloak"",
            ""price"": 20,
            ""id"": 19386,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19386"",
            ""type"": ""Cloth Back""
        },
        {
            ""name"": ""Emberweave Leggings"",
            ""price"": 0,
            ""id"": 19433,
            ""fortank"": ""No"",
            ""bosses"": ""Flamegor"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19433"",
            ""type"": ""Mail Legs""
        },
        {
            ""name"": ""Empowered Leggings"",
            ""price"": 30,
            ""id"": 19385,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19385"",
            ""type"": ""Cloth Legs""
        },
        {
            ""name"": ""Essence Gatherer"",
            ""price"": 10,
            ""id"": 19435,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19435"",
            ""type"": ""Ranged Wand""
        },
        {
            ""name"": ""Firemaw's Clutch"",
            ""price"": 15,
            ""id"": 19400,
            ""fortank"": ""No"",
            ""bosses"": ""Firemaw"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19400"",
            ""type"": ""Cloth Waist""
        },
        {
            ""name"": ""Gauntlets of Wrath"",
            ""price"": 20,
            ""id"": 16964,
            ""fortank"": ""Yes"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16964"",
            ""type"": ""Plate Hands""
        },
        {
            ""name"": ""Girdle of the Fallen Crusader"",
            ""price"": 2,
            ""id"": 19392,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19392"",
            ""type"": ""Plate Waist""
        },
        {
            ""name"": ""Gloves of Rapid Evolution"",
            ""price"": 2,
            ""id"": 19369,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19369"",
            ""type"": ""Cloth Hands""
        },
        {
            ""name"": ""Handguards of Transcendence"",
            ""price"": 20,
            ""id"": 16920,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16920"",
            ""type"": ""Cloth Hands""
        },
        {
            ""name"": ""Head of Nefarian"",
            ""price"": 30,
            ""id"": 19002,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19002"",
            ""type"": ""Bloody Head""
        },
        {
            ""name"": ""Heartstriker"",
            ""price"": 2,
            ""id"": 19350,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19350"",
            ""type"": ""Ranged Bow""
        },
        {
            ""name"": ""Helm of Endless Rage"",
            ""price"": 10,
            ""id"": 19372,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19372"",
            ""type"": ""Plate Head""
        },
        {
            ""name"": ""Herald of Woe"",
            ""price"": 20,
            ""id"": 19357,
            ""fortank"": ""No"",
            ""bosses"": ""Flamegor"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19357"",
            ""type"": ""Two-hand Mace""
        },
        {
            ""name"": ""Interlaced Shadow Jerkin"",
            ""price"": 2,
            ""id"": 19439,
            ""fortank"": ""No"",
            ""bosses"": ""Death Talon Wyrmguard"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19439"",
            ""type"": ""Leather Chest""
        },
        {
            ""name"": ""Judgement Belt"",
            ""price"": 5,
            ""id"": 16952,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16952"",
            ""type"": ""Plate Waist""
        },
        {
            ""name"": ""Judgement Bindings"",
            ""price"": 5,
            ""id"": 16951,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16951"",
            ""type"": ""Plate Wrists""
        },
        {
            ""name"": ""Judgement Breastplate"",
            ""price"": 15,
            ""id"": 16958,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16958"",
            ""type"": ""Plate Chest""
        },
        {
            ""name"": ""Judgement Gauntlets"",
            ""price"": 10,
            ""id"": 16956,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16956"",
            ""type"": ""Plate Hands""
        },
        {
            ""name"": ""Judgement Sabatons"",
            ""price"": 10,
            ""id"": 16957,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16957"",
            ""type"": ""Plate Feet""
        },
        {
            ""name"": ""Judgement Spaulders"",
            ""price"": 10,
            ""id"": 16953,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16953"",
            ""type"": ""Plate Shoulders""
        },
        {
            ""name"": ""Legguards of the Fallen Crusader"",
            ""price"": 50,
            ""id"": 19402,
            ""fortank"": ""No"",
            ""bosses"": ""Firemaw"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19402"",
            ""type"": ""Plate Legs""
        },
        {
            ""name"": ""Lifegiving Gem"",
            ""price"": 0,
            ""id"": 19341,
            ""fortank"": ""Yes"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19341"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Lok'amir il Romathis"",
            ""price"": 45,
            ""id"": 19360,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19360"",
            ""type"": ""Main Hand Mace""
        },
        {
            ""name"": ""Maladath, Runed Blade of the Black Flight"",
            ""price"": 40,
            ""id"": 19351,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19351"",
            ""type"": ""One-hand Sword""
        },
        {
            ""name"": ""Malfurion's Blessed Bulwark"",
            ""price"": 40,
            ""id"": 19405,
            ""fortank"": ""No"",
            ""bosses"": ""Ebonroc"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19405"",
            ""type"": ""Leather Chest""
        },
        {
            ""name"": ""Mantle of the Blackwing Cabal"",
            ""price"": 30,
            ""id"": 19370,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19370"",
            ""type"": ""Cloth Shoulders""
        },
        {
            ""name"": ""Mind Quickening Gem"",
            ""price"": 10,
            ""id"": 19339,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19339"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Mish'undare, Circlet of the Mind Flayer"",
            ""price"": 40,
            ""id"": 19375,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19375"",
            ""type"": ""Cloth Head""
        },
        {
            ""name"": ""Neltharion's Tear"",
            ""price"": 60,
            ""id"": 19379,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19379"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Nemesis Belt"",
            ""price"": 5,
            ""id"": 16933,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16933"",
            ""type"": ""Cloth Waist""
        },
        {
            ""name"": ""Nemesis Boots"",
            ""price"": 10,
            ""id"": 16927,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16927"",
            ""type"": ""Cloth Feet""
        },
        {
            ""name"": ""Nemesis Bracers"",
            ""price"": 5,
            ""id"": 16934,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16934"",
            ""type"": ""Cloth Wrists""
        },
        {
            ""name"": ""Nemesis Gloves"",
            ""price"": 10,
            ""id"": 16928,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16928"",
            ""type"": ""Cloth Hands""
        },
        {
            ""name"": ""Nemesis Robes"",
            ""price"": 15,
            ""id"": 16931,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16931"",
            ""type"": ""Cloth Chest""
        },
        {
            ""name"": ""Nemesis Spaulders"",
            ""price"": 10,
            ""id"": 16932,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16932"",
            ""type"": ""Cloth Shoulders""
        },
        {
            ""name"": ""Netherwind Belt"",
            ""price"": 5,
            ""id"": 16818,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16818"",
            ""type"": ""Cloth Waist""
        },
        {
            ""name"": ""Netherwind Bindings"",
            ""price"": 10,
            ""id"": 16918,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16918"",
            ""type"": ""Cloth Wrists""
        },
        {
            ""name"": ""Netherwind Boots"",
            ""price"": 10,
            ""id"": 16912,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16912"",
            ""type"": ""Cloth Feet""
        },
        {
            ""name"": ""Netherwind Gloves"",
            ""price"": 20,
            ""id"": 16913,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16913"",
            ""type"": ""Cloth Hands""
        },
        {
            ""name"": ""Netherwind Mantle"",
            ""price"": 10,
            ""id"": 16917,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16917"",
            ""type"": ""Cloth Shoulders""
        },
        {
            ""name"": ""Netherwind Robes"",
            ""price"": 15,
            ""id"": 16916,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16916"",
            ""type"": ""Cloth Chest""
        },
        {
            ""name"": ""Pauldrons of Transcendence"",
            ""price"": 40,
            ""id"": 16924,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16924"",
            ""type"": ""Cloth Shoulders""
        },
        {
            ""name"": ""Pauldrons of Wrath"",
            ""price"": 20,
            ""id"": 16961,
            ""fortank"": ""Yes"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16961"",
            ""type"": ""Plate Shoulders""
        },
        {
            ""name"": ""Pendant of the Fallen Dragon"",
            ""price"": 2,
            ""id"": 19371,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19371"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Prestor's Talisman of Connivery"",
            ""price"": 10,
            ""id"": 19377,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19377"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Primalist's Linked Legguards"",
            ""price"": 0,
            ""id"": 19401,
            ""fortank"": ""No"",
            ""bosses"": ""Firemaw"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19401"",
            ""type"": ""Mail Legs""
        },
        {
            ""name"": ""Primalist's Linked Waistguard"",
            ""price"": 0,
            ""id"": 19393,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19393"",
            ""type"": ""Mail Waist""
        },
        {
            ""name"": ""Pure Elementium Band"",
            ""price"": 40,
            ""id"": 19382,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19382"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Red Dragonscale Protector"",
            ""price"": 15,
            ""id"": 19348,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19348"",
            ""type"": ""Shield""
        },
        {
            ""name"": ""Rejuvenating Gem"",
            ""price"": 60,
            ""id"": 19395,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19395"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Ring of Blackrock"",
            ""price"": 10,
            ""id"": 19397,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19397"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Ringo's Blizzard Boots"",
            ""price"": 30,
            ""id"": 19438,
            ""fortank"": ""No"",
            ""bosses"": ""Death Talon Wyrmguard"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19438"",
            ""type"": ""Cloth Feet""
        },
        {
            ""name"": ""Robes of Transcendence"",
            ""price"": 25,
            ""id"": 16923,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16923"",
            ""type"": ""Cloth Chest""
        },
        {
            ""name"": ""Rune of Metamorphosis"",
            ""price"": 0,
            ""id"": 19340,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19340"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Sabatons of Wrath"",
            ""price"": 20,
            ""id"": 16965,
            ""fortank"": ""Yes"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16965"",
            ""type"": ""Plate Feet""
        },
        {
            ""name"": ""Scrolls of Blinding Light"",
            ""price"": 0,
            ""id"": 19343,
            ""fortank"": ""No"",
            ""bosses"": ""Firemaw"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19343"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Shadow Wing Focus Staff"",
            ""price"": 10,
            ""id"": 19355,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19355"",
            ""type"": ""Two-hand Staff""
        },
        {
            ""name"": ""Shimmering Geta"",
            ""price"": 2,
            ""id"": 19391,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19391"",
            ""type"": ""Cloth Feet""
        },
        {
            ""name"": ""Shroud of Pure Thought"",
            ""price"": 10,
            ""id"": 19430,
            ""fortank"": ""No"",
            ""bosses"": ""Flamegor"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19430"",
            ""type"": ""Cloth Back""
        },
        {
            ""name"": ""Spineshatter"",
            ""price"": 50,
            ""id"": 19335,
            ""fortank"": ""Yes"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19335"",
            ""type"": ""Main Hand Mace""
        },
        {
            ""name"": ""Staff of the Shadow Flame"",
            ""price"": 65,
            ""id"": 19356,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19356"",
            ""type"": ""Two-hand Staff""
        },
        {
            ""name"": ""Stormrage Belt"",
            ""price"": 15,
            ""id"": 16903,
            ""fortank"": ""No"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16903"",
            ""type"": ""Leather Waist""
        },
        {
            ""name"": ""Stormrage Boots"",
            ""price"": 20,
            ""id"": 16898,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16898"",
            ""type"": ""Leather Feet""
        },
        {
            ""name"": ""Stormrage Bracers"",
            ""price"": 15,
            ""id"": 16904,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16904"",
            ""type"": ""Leather Wrists""
        },
        {
            ""name"": ""Stormrage Chestguard"",
            ""price"": 25,
            ""id"": 16897,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16897"",
            ""type"": ""Leather Chest""
        },
        {
            ""name"": ""Stormrage Handguards"",
            ""price"": 30,
            ""id"": 16899,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16899"",
            ""type"": ""Leather Hands""
        },
        {
            ""name"": ""Stormrage Pauldrons"",
            ""price"": 20,
            ""id"": 16902,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16902"",
            ""type"": ""Leather Shoulders""
        },
        {
            ""name"": ""Styleen's Impeding Scarab"",
            ""price"": 60,
            ""id"": 19431,
            ""fortank"": ""Yes"",
            ""bosses"": ""Flamegor"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19431"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Taut Dragonhide Belt"",
            ""price"": 2,
            ""id"": 19396,
            ""fortank"": ""No"",
            ""bosses"": ""Zone Drop"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19396"",
            ""type"": ""Leather Waist""
        },
        {
            ""name"": ""Taut Dragonhide Gloves"",
            ""price"": 10,
            ""id"": 19390,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19390"",
            ""type"": ""Leather Hands""
        },
        {
            ""name"": ""Taut Dragonhide Shoulderpads"",
            ""price"": 30,
            ""id"": 19389,
            ""fortank"": ""No"",
            ""bosses"": ""Chromaggus"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19389"",
            ""type"": ""Leather Shoulders""
        },
        {
            ""name"": ""The Black Book"",
            ""price"": 0,
            ""id"": 19337,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19337"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""The Untamed Blade"",
            ""price"": 50,
            ""id"": 19334,
            ""fortank"": ""No"",
            ""bosses"": ""Razorgore the Untamed"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19334"",
            ""type"": ""Two-hand Sword""
        },
        {
            ""name"": ""Therazane's Link"",
            ""price"": 2,
            ""id"": 19380,
            ""fortank"": ""No"",
            ""bosses"": ""Nefarian"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19380"",
            ""type"": ""Mail Waist""
        },
        {
            ""name"": ""Venomous Totem"",
            ""price"": 0,
            ""id"": 19342,
            ""fortank"": ""No"",
            ""bosses"": ""Broodlord Lashlayer"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=19342"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Waistband of Wrath"",
            ""price"": 15,
            ""id"": 16960,
            ""fortank"": ""Yes"",
            ""bosses"": ""Vaelastrasz the Corrupt"",
            ""raid"": ""Blackwing Lair"",
            ""url"": ""https://classic.wowhead.com/item=16960"",
            ""type"": ""Plate Waist""
        },
        {
            ""name"": ""Badge of the Swarmguard"",
            ""price"": 75,
            ""id"": 21670,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21670"",
            ""type"": ""Trinket"",
            ""furyBis"": 1
        },
        {
            ""name"": ""Creeping Vine Helm"",
            ""price"": 10,
            ""id"": 21669,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21669"",
            ""type"": ""Head""
        },
        {
            ""name"": ""Gauntlets of Steadfast Determination"",
            ""price"": 15,
            ""id"": 21674,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21674"",
            ""type"": ""Hands""
        },
        {
            ""name"": ""Gloves of Enforcement"",
            ""price"": 25,
            ""id"": 21672,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21672"",
            ""type"": ""Hands"",
            ""comment2"": ""[Mattyg]-updated from 20->25 to help even out sword/dagger rogue"",
            ""rogueSword"": 1
        },
        {
            ""name"": ""Leggings of the Festering Swarm"",
            ""price"": 20,
            ""id"": 21676,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21676"",
            ""type"": ""Legs""
        },
        {
            ""name"": ""Legplates of Blazing Light"",
            ""price"": 10,
            ""id"": 21667,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21667"",
            ""type"": ""Legs""
        },
        {
            ""name"": ""Necklace of Purity"",
            ""price"": 0,
            ""id"": 21678,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21678"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Recomposed Boots"",
            ""price"": 0,
            ""id"": 21648,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21648"",
            ""type"": ""Feet""
        },
        {
            ""name"": ""Robes of the Battleguard"",
            ""price"": 10,
            ""id"": 21671,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21671"",
            ""type"": ""Chest""
        },
        {
            ""name"": ""Sartura's Might"",
            ""price"": 15,
            ""id"": 21666,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21666"",
            ""type"": ""Off-Hand""
        },
        {
            ""name"": ""Scaled Leggings of Qiraji Fury"",
            ""price"": 0,
            ""id"": 21668,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21668"",
            ""type"": ""Legs""
        },
        {
            ""name"": ""Silithid Claw"",
            ""price"": 10,
            ""id"": 21673,
            ""fortank"": ""NO"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21673"",
            ""type"": ""Main Hand""
        },
        {
            ""name"": ""Thick Qirajihide Belt"",
            ""price"": 15,
            ""id"": 21675,
            ""fortank"": ""BEAR"",
            ""bosses"": ""Battleguard Sartura"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21675"",
            ""type"": ""Waist""
        },
        {
            ""name"": ""Belt of Never-ending Agony"",
            ""price"": 30,
            ""id"": 21586,
            ""fortank"": ""NO"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21586"",
            ""type"": ""Waist"",
            ""comment"": ""26-34 weighted upgrade to rogue"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Cloak of Clarity"",
            ""price"": 20,
            ""id"": 21583,
            ""fortank"": ""NO"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21583"",
            ""type"": ""Back""
        },
        {
            ""name"": ""Cloak of the Devoured"",
            ""price"": 20,
            ""id"": 22731,
            ""fortank"": ""NO"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=22731"",
            ""type"": ""Back""
        },
        {
            ""name"": ""Dark Edge of Insanity"",
            ""price"": 10,
            ""id"": 21134,
            ""fortank"": ""NO"",
            ""forPvp"": ""Yes"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21134"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Dark Storm Gauntlets"",
            ""price"": 50,
            ""id"": 21585,
            ""fortank"": ""NO"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21585"",
            ""type"": ""Hands""
        },
        {
            ""name"": ""Death's Sting"",
            ""price"": 80,
            ""id"": 21126,
            ""fortank"": ""NO"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21126"",
            ""type"": ""One-Hand"",
            ""comment"": ""198 weighted value"",
            ""comment2"": ""[Mattyg]-updated from 100->80 to help sword/dagger rogue pricing"",
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Eye of C'Thun"",
            ""price"": 20,
            ""id"": 21221,
            ""fortank"": ""NO"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21221"",
            ""type"": "" "",
            ""comment"": ""20, the middle of fury and caster. also guaranteed drop. no prio on this item.""
        },
        {
            ""name"": ""Eyestalk Waist Cord"",
            ""price"": 45,
            ""id"": 22730,
            ""fortank"": ""NO"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=22730"",
            ""type"": ""Waist""
        },
        {
            ""name"": ""Gauntlets of Annihilation"",
            ""price"": 50,
            ""id"": 21581,
            ""fortank"": ""NO"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21581"",
            ""type"": ""Hands"",
            ""furyBis"": 1
        },
        {
            ""name"": ""Grasp of the Old God"",
            ""price"": 40,
            ""id"": 21582,
            ""fortank"": ""NO"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21582"",
            ""type"": ""Waist""
        },
        {
            ""name"": ""Mark of C'Thun"",
            ""price"": 15,
            ""id"": 22732,
            ""fortank"": ""BEAR"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=22732"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Ring of the Godslayer"",
            ""price"": 10,
            ""id"": 21596,
            ""fortank"": ""NO"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21596"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Scepter of the False Prophet"",
            ""price"": 90,
            ""id"": 21839,
            ""fortank"": ""No"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21839"",
            ""type"": ""Main Hand"",
            ""comment"": ""scaled down from 100 to 90""
        },
        {
            ""name"": ""Vanquished Tentacle of C'Thun"",
            ""price"": 1,
            ""id"": 21579,
            ""fortank"": ""NO"",
            ""forPvp"": ""Yes"",
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21579"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Boots of Epiphany"",
            ""price"": 10,
            ""id"": 21600,
            ""fortank"": ""NO"",
            ""bosses"": ""Emperor Vek'lor"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21600"",
            ""type"": ""Feet""
        },
        {
            ""name"": ""Qiraji Execution Bracers"",
            ""lootCounciled"": ""Terralee"",
            ""price"": 10,
            ""id"": 21602,
            ""fortank"": ""BEAR"",
            ""bosses"": ""Emperor Vek'lor"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21602"",
            ""type"": ""Wrist"",
            ""comment"": ""2 weighted upgrade over BF rogue without set consideration, otherwise negative"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Ring of Emperor Vek'lor"",
            ""price"": 20,
            ""id"": 21601,
            ""fortank"": ""BEAR"",
            ""bosses"": ""Emperor Vek'lor"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21601"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Royal Qiraji Belt"",
            ""price"": 15,
            ""id"": 21598,
            ""fortank"": ""YES"",
            ""bosses"": ""Emperor Vek'lor"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21598"",
            ""type"": ""Waist""
        },
        {
            ""name"": ""Royal Scepter of Vek'lor"",
            ""price"": 15,
            ""id"": 21597,
            ""fortank"": ""NO"",
            ""bosses"": ""Emperor Vek'lor"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21597"",
            ""type"": ""Off-Hand""
        },
        {
            ""name"": ""Vek'lor's Gloves of Devastation"",
            ""price"": 5,
            ""id"": 21599,
            ""fortank"": ""NO"",
            ""bosses"": ""Emperor Vek'lor"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21599"",
            ""type"": ""Hands""
        },
        {
            ""name"": ""Amulet of Vek'nilash"",
            ""price"": 25,
            ""id"": 21608,
            ""fortank"": ""NO"",
            ""bosses"": ""Emperor Vek'nilash"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21608"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Belt of the Fallen Emperor"",
            ""price"": 2,
            ""id"": 21606,
            ""fortank"": ""NO"",
            ""forPvp"": ""Yes"",
            ""bosses"": ""Emperor Vek'nilash"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21606"",
            ""type"": ""Waist""
        },
        {
            ""name"": ""Bracelets of Royal Redemption"",
            ""price"": 20,
            ""id"": 21604,
            ""fortank"": ""NO"",
            ""bosses"": ""Emperor Vek'nilash"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21604"",
            ""type"": ""Wrist""
        },
        {
            ""name"": ""Gloves of the Hidden Temple"",
            ""price"": 25,
            ""id"": 21605,
            ""fortank"": ""BEAR"",
            ""bosses"": ""Emperor Vek'nilash"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21605"",
            ""type"": ""Hands""
        },
        {
            ""name"": ""Grasp of the Fallen Emperor"",
            ""price"": 0,
            ""id"": 21607,
            ""fortank"": ""NO"",
            ""bosses"": ""Emperor Vek'nilash"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21607"",
            ""type"": ""Waist""
        },
        {
            ""name"": ""Kalimdor's Revenge"",
            ""price"": 5,
            ""id"": 21679,
            ""fortank"": ""NO"",
            ""forPvp"": ""Yes"",
            ""bosses"": ""Emperor Vek'nilash"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21679"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Regenerating Belt of Vek'nilash"",
            ""price"": 10,
            ""id"": 21609,
            ""fortank"": ""NO"",
            ""bosses"": ""Emperor Vek'nilash"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21609"",
            ""type"": ""Waist""
        },
        {
            ""name"": ""Ancient Qiraji Ripper"",
            ""price"": 70,
            ""id"": 21650,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21650"",
            ""type"": ""One-Hand"",
            ""comment"": ""52 weighted for rogue over cts/98 over viskag"",
            ""furyBis"": 1,
            ""rogueSword"": 1
        },
        {
            ""name"": ""Barb of the Sand Reaver"",
            ""price"": 15,
            ""id"": 21635,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21635"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Barbed Choker"",
            ""price"": 10,
            ""id"": 21664,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21664"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Cloak of Untold Secrets"",
            ""price"": 0,
            ""id"": 21627,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21627"",
            ""type"": ""Back""
        },
        {
            ""name"": ""Fetish of the Sand Reaver"",
            ""price"": 1,
            ""id"": 21647,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21647"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Hive Tunneler's Boots"",
            ""price"": 5,
            ""id"": 21645,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21645"",
            ""type"": ""Feet""
        },
        {
            ""name"": ""Libram of Grace"",
            ""price"": 5,
            ""id"": 22402,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=22402"",
            ""type"": ""Relic""
        },
        {
            ""name"": ""Mantle of Wicked Revenge"",
            ""price"": 20,
            ""id"": 21665,
            ""fortank"": ""BEAR"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21665"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Pauldrons of the Unrelenting"",
            ""price"": 2,
            ""id"": 21639,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21639"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Robes of the Guardian Saint"",
            ""price"": 30,
            ""id"": 21663,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21663"",
            ""type"": ""Chest""
        },
        {
            ""name"": ""Scaled Sand Reaver Leggings"",
            ""price"": 5,
            ""id"": 21651,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21651"",
            ""type"": ""Legs""
        },
        {
            ""name"": ""Silithid Carapace Chestguard"",
            ""price"": 0,
            ""id"": 21652,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21652"",
            ""type"": ""Chest""
        },
        {
            ""name"": ""Totem of Life"",
            ""price"": 0,
            ""id"": 22396,
            ""fortank"": ""NO"",
            ""bosses"": ""Fankriss the Unyielding"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=22396"",
            ""type"": ""Relic""
        },
        {
            ""name"": ""Petrified Scarab"",
            ""price"": 1,
            ""id"": 21685,
            ""fortank"": ""NO"",
            ""forPvp"": ""Yes"",
            ""bosses"": ""Lord Kri"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21685"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Ring of the Devoured"",
            ""price"": 2,
            ""id"": 21681,
            ""fortank"": ""NO"",
            ""bosses"": ""Lord Kri"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21681"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Vest of Swift Execution"",
            ""price"": 15,
            ""id"": 21680,
            ""fortank"": ""NO"",
            ""bosses"": ""Lord Kri"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21680"",
            ""type"": ""Chest""
        },
        {
            ""name"": ""Wand of Qiraji Nobility"",
            ""price"": 10,
            ""id"": 21603,
            ""fortank"": ""NO"",
            ""bosses"": ""Lord Kri"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21603"",
            ""type"": ""Ranged""
        },
        {
            ""name"": ""Burrower Bracers"",
            ""price"": 10,
            ""id"": 21611,
            ""fortank"": ""NO"",
            ""bosses"": ""Ouro"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21611"",
            ""type"": ""Wrist"",
            ""comment"": ""scaled up from 5-15 for Spriest""
        },
        {
            ""name"": ""Don Rigoberto's Lost Hat"",
            ""price"": 45,
            ""id"": 21615,
            ""fortank"": ""NO"",
            ""bosses"": ""Ouro"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21615"",
            ""type"": ""Head""
        },
        {
            ""name"": ""Jom Gabbar"",
            ""price"": 25,
            ""id"": 23570,
            ""fortank"": ""NO"",
            ""bosses"": ""Ouro"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=23570"",
            ""type"": ""Trinket"",
            ""comment"": ""14 weighted for rogue over multiple upgrades"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Larvae of the Great Worm"",
            ""price"": 10,
            ""id"": 23557,
            ""fortank"": ""NO"",
            ""bosses"": ""Ouro"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=23557"",
            ""type"": ""Ranged"",
            ""comment"": ""Good item, marginal upgrade over previous tiers (suggest 2-10) (possible 15 for nileen)""
        },
        {
            ""name"": ""The Burrower's Shell"",
            ""price"": 1,
            ""id"": 23558,
            ""fortank"": ""NO"",
            ""bosses"": ""Ouro"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=23558"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Wormscale Blocker"",
            ""price"": 10,
            ""id"": 21610,
            ""fortank"": ""NO"",
            ""bosses"": ""Ouro"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21610"",
            ""type"": ""Off-Hand""
        },
        {
            ""name"": ""Cloak of the Golden Hive"",
            ""price"": 15,
            ""id"": 21621,
            ""fortank"": ""NO"",
            ""bosses"": ""Princess Huhuran"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21621"",
            ""type"": ""Back""
        },
        {
            ""name"": ""Gloves of the Messiah"",
            ""price"": 5,
            ""id"": 21619,
            ""fortank"": ""NO"",
            ""bosses"": ""Princess Huhuran"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21619"",
            ""type"": ""Hands""
        },
        {
            ""name"": ""Hive Defiler Wristguards"",
            ""price"": 15,
            ""id"": 21618,
            ""fortank"": ""NO"",
            ""bosses"": ""Princess Huhuran"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21618"",
            ""type"": ""Wrist"",
            ""furyBis"": 1
        },
        {
            ""name"": ""Huhuran's Stinger"",
            ""price"": 5,
            ""id"": 21616,
            ""fortank"": ""NO"",
            ""bosses"": ""Princess Huhuran"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21616"",
            ""type"": ""Ranged""
        },
        {
            ""name"": ""Ring of the Martyr"",
            ""price"": 15,
            ""id"": 21620,
            ""fortank"": ""NO"",
            ""bosses"": ""Princess Huhuran"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21620"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Wasphide Gauntlets"",
            ""price"": 10,
            ""id"": 21617,
            ""fortank"": ""NO"",
            ""bosses"": ""Princess Huhuran"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21617"",
            ""type"": ""Hands""
        },
        {
            ""name"": ""Bile-Covered Gauntlets"",
            ""lootCounciled"": ""Terralee (If no Twin Emp Gloves)"",
            ""price"": 0,
            ""id"": 21682,
            ""fortank"": ""NO"",
            ""bosses"": ""Princess Yauj"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21682"",
            ""type"": ""Hands""
        },
        {
            ""name"": ""Mantle of Phrenic Power"",
            ""price"": 5,
            ""id"": 21686,
            ""fortank"": ""NO"",
            ""bosses"": ""Princess Yauj"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21686"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Mantle of the Desert Crusade"",
            ""price"": 2,
            ""id"": 21683,
            ""fortank"": ""NO"",
            ""forPvp"": ""Yes"",
            ""bosses"": ""Princess Yauj"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21683"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Mantle of the Desert's Fury"",
            ""price"": 0,
            ""id"": 21684,
            ""fortank"": ""NO"",
            ""bosses"": ""Princess Yauj"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21684"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Ukko's Ring of Darkness"",
            ""price"": 0,
            ""id"": 21687,
            ""fortank"": ""NO"",
            ""bosses"": ""Princess Yauj"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21687"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Anubisath Warhammer"",
            ""price"": 10,
            ""id"": 21837,
            ""fortank"": ""NO"",
            ""bosses"": ""Random Mobs"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21837"",
            ""type"": ""One-Hand""
        },
        {
            ""name"": ""Garb of Royal Ascension"",
            ""price"": 0,
            ""id"": 21838,
            ""fortank"": ""NO"",
            ""bosses"": ""Random Mobs"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21838"",
            ""type"": ""Chest""
        },
        {
            ""name"": ""Neretzek, The Blood Drinker"",
            ""price"": 2,
            ""id"": 21856,
            ""fortank"": ""NO"",
            ""forPvp"": ""Yes"",
            ""bosses"": ""Random Mobs"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21856"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Ritssyn's Ring of Chaos"",
            ""price"": 10,
            ""id"": 21836,
            ""fortank"": ""NO"",
            ""bosses"": ""Random Mobs"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21836"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Shard of the Fallen Star"",
            ""price"": 1,
            ""id"": 21891,
            ""fortank"": ""NO"",
            ""forPvp"": ""Yes"",
            ""bosses"": ""Random Mobs"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21891"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Amulet of Foul Warding"",
            ""price"": 0,
            ""id"": 21702,
            ""fortank"": ""NO"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21702"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Barrage Shoulders"",
            ""price"": 2,
            ""id"": 21699,
            ""fortank"": ""NO"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21699"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Beetle Scaled Wristguards"",
            ""price"": 0,
            ""id"": 21708,
            ""fortank"": ""NO"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21708"",
            ""type"": ""Wrist"",
            ""comment"": ""Rogue/Feral""
        },
        {
            ""name"": ""Boots of the Fallen Prophet"",
            ""price"": 0,
            ""id"": 21705,
            ""fortank"": ""NO"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21705"",
            ""type"": ""Feet""
        },
        {
            ""name"": ""Boots of the Redeemed Prophecy"",
            ""price"": 2,
            ""id"": 21704,
            ""fortank"": ""NO"",
            ""forPvp"": ""Yes"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21704"",
            ""type"": ""Feet""
        },
        {
            ""name"": ""Boots of the Unwavering Will"",
            ""price"": 2,
            ""id"": 21706,
            ""fortank"": ""NO"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21706"",
            ""type"": ""Feet""
        },
        {
            ""name"": ""Breastplate of Annihilation"",
            ""price"": 35,
            ""id"": 21814,
            ""fortank"": ""NO"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21814"",
            ""type"": ""Chest"",
            ""furyBis"": 1
        },
        {
            ""name"": ""Cloak of Concentrated Hatred"",
            ""price"": 10,
            ""id"": 21701,
            ""fortank"": ""BEAR"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21701"",
            ""type"": ""Back"",
            ""furyBis"": 1,
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Hammer of Ji'zhi"",
            ""price"": 1,
            ""id"": 21703,
            ""fortank"": ""NO"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21703"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Leggings of Immersion"",
            ""price"": 2,
            ""id"": 21698,
            ""fortank"": ""NO"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21698"",
            ""type"": ""Legs""
        },
        {
            ""name"": ""Pendant of the Qiraji Guardian"",
            ""price"": 2,
            ""id"": 21700,
            ""fortank"": ""YES"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21700"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Ring of Swarming Thought"",
            ""price"": 2,
            ""id"": 21707,
            ""fortank"": ""NO"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21707"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Staff of the Qiraji Prophets"",
            ""price"": 0,
            ""id"": 21128,
            ""fortank"": ""NO"",
            ""bosses"": ""The Prophet Skeram"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21128"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Angelista's Touch"",
            ""price"": 2,
            ""id"": 21695,
            ""fortank"": ""NO"",
            ""bosses"": ""Triumvirate"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21695"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Cape of the Trinity"",
            ""price"": 2,
            ""id"": 21697,
            ""fortank"": ""NO"",
            ""bosses"": ""Triumvirate"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21697"",
            ""type"": ""Back""
        },
        {
            ""name"": ""Guise of the Devourer"",
            ""price"": 50,
            ""id"": 21693,
            ""fortank"": ""BEAR"",
            ""bosses"": ""Triumvirate"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21693"",
            ""type"": ""Head"",
            ""comment"": ""25-50""
        },
        {
            ""name"": ""Robes of the Triumvirate"",
            ""price"": 0,
            ""id"": 21696,
            ""fortank"": ""NO"",
            ""bosses"": ""Triumvirate"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21696"",
            ""type"": ""Chest"",
            ""comment"": ""Rogue/Feral""
        },
        {
            ""name"": ""Ternary Mantle"",
            ""price"": 5,
            ""id"": 21694,
            ""fortank"": ""NO"",
            ""bosses"": ""Triumvirate"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21694"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Triad Girdle"",
            ""price"": 1,
            ""id"": 21692,
            ""fortank"": ""NO"",
            ""bosses"": ""Triumvirate"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21692"",
            ""type"": ""Waist""
        },
        {
            ""name"": ""Angelista's Charm"",
            ""price"": 10,
            ""id"": 21690,
            ""fortank"": ""NO"",
            ""bosses"": ""Vem"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21690"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Boots of the Fallen Hero"",
            ""price"": 10,
            ""id"": 21688,
            ""fortank"": ""NO"",
            ""bosses"": ""Vem"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21688"",
            ""type"": ""Feet""
        },
        {
            ""name"": ""Gloves of Ebru"",
            ""price"": 1,
            ""id"": 21689,
            ""fortank"": ""NO"",
            ""bosses"": ""Vem"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21689"",
            ""type"": ""Hands""
        },
        {
            ""name"": ""Ooze-ridden Gauntlets"",
            ""price"": 0,
            ""id"": 21691,
            ""fortank"": ""NO"",
            ""bosses"": ""Vem"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21691"",
            ""type"": ""Hands""
        },
        {
            ""name"": ""Gauntlets of Kalimdor"",
            ""price"": 0,
            ""id"": 21624,
            ""fortank"": ""NO"",
            ""bosses"": ""Viscidus"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21624"",
            ""type"": ""Hands""
        },
        {
            ""name"": ""Gauntlets of the Righteous Champion"",
            ""price"": 1,
            ""id"": 21623,
            ""fortank"": ""NO"",
            ""bosses"": ""Viscidus"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21623"",
            ""type"": ""Hands""
        },
        {
            ""name"": ""Idol of Health"",
            ""price"": 5,
            ""id"": 22399,
            ""fortank"": ""NO"",
            ""bosses"": ""Viscidus"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=22399"",
            ""type"": ""Relic""
        },
        {
            ""name"": ""Ring of the Qiraji Fury"",
            ""price"": 5,
            ""id"": 21677,
            ""fortank"": ""NO"",
            ""bosses"": ""Viscidus"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21677"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Scarab Brooch"",
            ""price"": 10,
            ""id"": 21625,
            ""fortank"": ""NO"",
            ""bosses"": ""Viscidus"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21625"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Sharpened Silithid Femur"",
            ""price"": 50,
            ""id"": 21622,
            ""fortank"": ""NO"",
            ""bosses"": ""Viscidus"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21622"",
            ""type"": ""Main Hand""
        },
        {
            ""name"": ""Slime-coated Leggings"",
            ""price"": 0,
            ""id"": 21626,
            ""fortank"": ""NO"",
            ""bosses"": ""Viscidus"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21626"",
            ""type"": ""Legs""
        },
        {
            ""name"": ""Vek'nilash's Circlet"",
            ""price"": 30,
            ""id"": 20926,
            ""bosses"": ""Emperor Vek'nilash"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=20926"",
            ""type"": ""Head"",
            ""comment"": ""Recheck price"",
            ""comment2"": ""Warrior, Priest, Mage, Warlock"",
            ""comment3"": ""FuryProt/Warlock""
        },
        {
            ""name"": ""Vek'lor's Daidem"",
            ""price"": 30,
            ""id"": 20930,
            ""bosses"": ""Emperor Vek'lor"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=20930"",
            ""type"": ""Head"",
            ""comment"": ""30ish rogue value"",
            ""comment2"": ""Paladin, Hunter, Rogue, Druid"",
            ""comment3"": ""Rogue"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Ouro's Intact Hide"",
            ""lootCounciled"": ""Nileen"",
            ""price"": 15,
            ""id"": 20927,
            ""bosses"": ""Ouro"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=20927"",
            ""type"": ""Legs"",
            ""comment"": ""8ish rogue value"",
            ""comment2"": ""Warrior, Rogue, Priest, Mage"",
            ""comment3"": ""FuryProt/Rogue"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Skin of the Great Sandworm"",
            ""price"": 15,
            ""id"": 20931,
            ""bosses"": ""Ouro"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=20931"",
            ""type"": ""Legs"",
            ""comment"": ""Offspec/PVP item"",
            ""comment2"": ""Paladin, Hunter, Warlock, Druid""
        },
        {
            ""name"": ""Qiraji Bindings of Command"",
            ""price"": 30,
            ""id"": 20928,
            ""bosses"": ""Viscidus/Princess Huhuran"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=20928"",
            ""type"": ""Shoulder/Feet"",
            ""comment"": ""30ish rogue value, 30ish warrior value"",
            ""comment2"": ""Warrior, Hunter, Rogue, Priest"",
            ""comment3"": ""FuryProt/Rogue"",
            ""furyBis"": 1,
            ""rogueSword"": 2,
            ""rogueDagger"": 2
        },
        {
            ""name"": ""Qiraji Bindings of Dominance"",
            ""price"": 25,
            ""id"": 20932,
            ""bosses"": ""Viscidus/Princess Huhuran"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=20932"",
            ""type"": ""Shoulder/Feet"",
            ""comment2"": ""Paladin, Mage, Warlock, Druid"",
            ""comment3"": ""Mage/Warlock""
        },
        {
            ""name"": ""Carapace of the Old God"",
            ""lootCounciled"": ""Nileen"",
            ""price"": 15,
            ""id"": 20929,
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=20929"",
            ""type"": ""Chest"",
            ""comment"": ""10ish rogue value"",
            ""comment2"": ""Warrior, Paladin, Hunter, Rogue"",
            ""comment3"": ""FuryProt/Rogue"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Husk of the Old God"",
            ""price"": 15,
            ""id"": 20933,
            ""bosses"": ""C'Thun"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=20933"",
            ""type"": ""Chest"",
            ""comment2"": ""Priest, Mage, Warlock, Druid"",
            ""comment3"": ""Mage?""
        },
        {
            ""name"": ""Imperial Qiraji Armaments"",
            ""price"": 25,
            ""id"": 21232,
            ""bosses"": ""Bosses"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21232"",
            ""type"": "" "",
            ""comment"": ""64 dagger rogue value scaled down to 45"",
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Imperial Qiraji Regalia"",
            ""lootCounciled"": ""Terralee - First or Second"",
            ""price"": 50,
            ""id"": 21237,
            ""bosses"": ""Bosses"",
            ""raid"": ""Ahn'Qiraj (Temple)"",
            ""url"": ""https://classic.wowhead.com/item=21237"",
            ""type"": "" "",
            ""comment"": ""Very good warlock staff, BIS Game Feral Mace""
        },
        {
            ""name"": ""Cryptfiend Silk Cloak"",
            ""price"": 20,
            ""id"": 22938,
            ""bosses"": ""Anub'Rekhan"",
            ""raid"": ""Naxxramas"",
            ""type"": ""Back"",
            ""feralDruid"": 1,
            ""warriorProt"": 1
        },
        {
            ""name"": ""Band of Unanswered Prayers"",
            ""price"": 15,
            ""id"": 22939,
            ""bosses"": ""Anub'Rekhan"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22939/band-of-unanswered-prayers"",
            ""type"": ""Finger"",
            ""holyPriest"": 1,
            ""restoDruid"": 1
        },
        {
            ""name"": ""Gem of Nerubis"",
            ""price"": 2,
            ""id"": 22937,
            ""forPvp"": ""X"",
            ""bosses"": ""Anub'Rekhan"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22937/gem-of-nerubis"",
            ""type"": ""Held In Off-hand"",
            ""detail"": ""Caster""
        },
        {
            ""name"": ""Touch of Frost"",
            ""price"": 0,
            ""id"": 22935,
            ""bosses"": ""Anub'Rekhan"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22935/touch-of-frost"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Wristguards of Vengeance"",
            ""price"": 20,
            ""id"": 22936,
            ""bosses"": ""Anub'Rekhan"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22936/wristguards-of-vengeance"",
            ""type"": ""Wrist"",
            ""comment"": ""5-10 warrior aep"",
            ""warriorFury"": 1,
            ""warriorFuryprot"": 1
        },
        {
            ""name"": ""Corrupted Ashbringer"",
            ""price"": 20,
            ""id"": 22691,
            ""forPvp"": ""X"",
            ""bosses"": ""Four Horsemen"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22691/corrupted-ashbringer"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Desecrated Breastplate"",
            ""price"": 15,
            ""id"": 22349,
            ""bosses"": ""Four Horsemen"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22349/desecrated-breastplate"",
            ""type"": ""Chest"",
            ""warriorProt"": 1
        },
        {
            ""name"": ""Desecrated Robe"",
            ""price"": 15,
            ""id"": 22351,
            ""bosses"": ""Four Horsemen"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22351/desecrated-robe."",
            ""type"": ""Chest"",
            ""holyPriest"": 1
        },
        {
            ""name"": ""Desecrated Tunic"",
            ""price"": 15,
            ""id"": 22350,
            ""bosses"": ""Four Horsemen"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22350/desecrated-tunic"",
            ""type"": ""Chest"",
            ""restoDruid"": 1,
            ""holyPaladin"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""Leggings of Apocalypse"",
            ""price"": 25,
            ""id"": 23071,
            ""bosses"": ""Four Horsemen"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23071/leggings-of-apocalypse"",
            ""type"": ""Legs"",
            ""feralDruid"": 1
        },
        {
            ""name"": ""Maul of the Redeemed Crusader"",
            ""price"": 1,
            ""id"": 22809,
            ""forPvp"": ""X"",
            ""bosses"": ""Four Horsemen"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22809/maul-of-the-redeemed-crusader#comments"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Seal of the Damned"",
            ""price"": 10,
            ""id"": 23025,
            ""bosses"": ""Four Horsemen"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23025/seal-of-the-damned"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Soulstring"",
            ""price"": 5,
            ""id"": 22811,
            ""bosses"": ""Four Horsemen"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22811/soulstring#comments"",
            ""type"": ""Ranged""
        },
        {
            ""name"": ""Warmth of Forgiveness"",
            ""price"": 2,
            ""id"": 23027,
            ""bosses"": ""Four Horsemen"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23027/warmth-of-forgiveness"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Digested Hand of Power"",
            ""price"": 1,
            ""id"": 22994,
            ""bosses"": ""Gluth"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22994/digested-hand-of-power"",
            ""type"": ""Held In Off-hand"",
            ""detail"": ""Healer""
        },
        {
            ""name"": ""Gluth's Missing Collar"",
            ""price"": 2,
            ""id"": 22981,
            ""bosses"": ""Gluth"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22981/gluths-missing-collar"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Death's Bargain"",
            ""price"": 5,
            ""id"": 23075,
            ""bosses"": ""Gluth"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23075/deaths-bargain"",
            ""type"": ""Shield""
        },
        {
            ""name"": ""Rime Covered Mantle"",
            ""price"": 20,
            ""id"": 22983,
            ""bosses"": ""Gluth"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22983/rime-covered-mantle"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Claymore of Unholy Might"",
            ""price"": 2,
            ""id"": 22813,
            ""forPvp"": ""X"",
            ""bosses"": ""Gluth"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22813/claymore-of-unholy-might"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Boots of Displacement"",
            ""price"": 1,
            ""id"": 23073,
            ""forPvp"": ""X"",
            ""bosses"": ""Gothik the Harvester"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23073/boots-of-displacement"",
            ""type"": ""Boots""
        },
        {
            ""name"": ""Glacial Headdress"",
            ""price"": 0,
            ""id"": 23032,
            ""bosses"": ""Gothik the Harvester"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23032/glacial-headdress"",
            ""type"": ""Head""
        },
        {
            ""name"": ""Polar Helmet"",
            ""price"": 0,
            ""id"": 23020,
            ""bosses"": ""Gothik the Harvester"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23020/polar-helmet"",
            ""type"": ""Head""
        },
        {
            ""name"": ""Sadist's Collar"",
            ""price"": 2,
            ""id"": 23023,
            ""bosses"": ""Gothik the Harvester"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23023/sadists-collar"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""The Soul Harvester's Bindings"",
            ""price"": 5,
            ""id"": 23021,
            ""bosses"": ""Gothik the Harvester"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23021/the-soul-harvesters-bindings"",
            ""type"": ""Wrist""
        },
        {
            ""name"": ""Malice Stone Pendant"",
            ""price"": 2,
            ""id"": 22943,
            ""forPvp"": ""X"",
            ""bosses"": ""Grand Widow Faerlina"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22943/malice-stone-pendant"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""The Widow's Embrace"",
            ""price"": 40,
            ""id"": 22942,
            ""bosses"": ""Grand Widow Faerlina"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22942/the-widows-embrace"",
            ""type"": ""One-Hand"",
            ""detail"": ""Healing""
        },
        {
            ""name"": ""Widow's Remorse"",
            ""price"": 10,
            ""id"": 22806,
            ""bosses"": ""Grand Widow Faerlina"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22806/widows-remorse"",
            ""type"": ""One-Hand"",
            ""detail"": ""Sword""
        },
        {
            ""name"": ""Icebane Pauldrons"",
            ""price"": 0,
            ""id"": 22940,
            ""bosses"": ""Grand Widow Faerlina"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22940/icebane-pauldrons"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Polar Shoulder Pads"",
            ""price"": 0,
            ""id"": 22941,
            ""bosses"": ""Grand Widow Faerlina"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22941/polar-shoulder-pads"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Midnight Haze"",
            ""price"": 10,
            ""id"": 22803,
            ""bosses"": ""Grobbulus"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22803/midnight-haze"",
            ""type"": ""One-Hand"",
            ""detail"": ""Caster""
        },
        {
            ""name"": ""The End of Dreams"",
            ""price"": 20,
            ""id"": 22988,
            ""bosses"": ""Grobbulus"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22988/the-end-of-dreams"",
            ""type"": ""One-Hand"",
            ""detail"": ""Caster/Druid""
        },
        {
            ""name"": ""Toxin Injector"",
            ""price"": 1,
            ""id"": 22810,
            ""bosses"": ""Grobbulus"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22810/toxin-injector"",
            ""type"": ""Ranged""
        },
        {
            ""name"": ""Glacial Mantle"",
            ""price"": 0,
            ""id"": 22968,
            ""bosses"": ""Grobbulus"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22968/glacial-mantle"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Icy Scale Spaulders"",
            ""price"": 0,
            ""id"": 22967,
            ""bosses"": ""Grobbulus"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22967/icy-scale-spaulders"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Icebane Helmet"",
            ""price"": 0,
            ""id"": 23019,
            ""bosses"": ""Heigan the Unclean"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23019/icebane-helmet"",
            ""type"": ""Head""
        },
        {
            ""name"": ""Icy Scale Coif"",
            ""price"": 0,
            ""id"": 23033,
            ""bosses"": ""Heigan the Unclean"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23033/icy-scale-coif"",
            ""type"": ""Head""
        },
        {
            ""name"": ""Preceptor's Hat"",
            ""price"": 5,
            ""id"": 23035,
            ""bosses"": ""Heigan the Unclean"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23035/preceptors-hat"",
            ""type"": ""Head"",
            ""detail"": ""Shadowpriest BIS"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Legplates of Carnage"",
            ""price"": 20,
            ""id"": 23068,
            ""bosses"": ""Heigan the Unclean"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23068/legplates-of-carnage"",
            ""type"": ""Legs"",
            ""warriorFuryprot"": 1
        },
        {
            ""name"": ""Necklace of Necropsy"",
            ""price"": 10,
            ""id"": 23036,
            ""bosses"": ""Heigan the Unclean"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23036/necklace-of-necropsy"",
            ""type"": ""Neck"",
            ""holyPriest"": 1,
            ""restoDruid"": 1
        },
        {
            ""name"": ""Veil of Eclipse"",
            ""price"": 1,
            ""id"": 23017,
            ""forPvp"": ""X"",
            ""bosses"": ""Instructor Razuvious"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23017/veil-of-eclipse"",
            ""type"": ""Back""
        },
        {
            ""name"": ""Signet of the Fallen Defender"",
            ""price"": 15,
            ""id"": 23018,
            ""bosses"": ""Instructor Razuvious"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23018/signet-of-the-fallen-defender"",
            ""type"": ""Finger"",
            ""feralDruid"": 1
        },
        {
            ""name"": ""Iblis, Blade of the Fallen Seraph"",
            ""price"": 15,
            ""id"": 23014,
            ""bosses"": ""Instructor Razuvious"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23014/iblis-blade-of-the-fallen-seraph"",
            ""type"": ""One-Hand"",
            ""detail"": ""Sword"",
            ""comment"": ""20-30 rogue aep""
        },
        {
            ""name"": ""Wand of the Whispering Dead"",
            ""price"": 10,
            ""id"": 23009,
            ""bosses"": ""Instructor Razuvious"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23009/wand-of-the-whispering-dead"",
            ""type"": ""Ranged"",
            ""holyPriest"": 1
        },
        {
            ""name"": ""Idol of Longevity"",
            ""price"": 2,
            ""id"": 23004,
            ""bosses"": ""Instructor Razuvious"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23004/idol-of-longevity"",
            ""type"": ""Relic"",
            ""restoDruid"": 1
        },
        {
            ""name"": ""Girdle of the Mentor"",
            ""price"": 15,
            ""id"": 23219,
            ""bosses"": ""Instructor Razuvious"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23219/girdle-of-the-mentor"",
            ""type"": ""Waist"",
            ""warriorFuryprot"": 1
        },
        {
            ""name"": ""Bonescythe Ring"",
            ""price"": 5,
            ""id"": 23060,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23060/bonescythe-ring"",
            ""type"": ""Finger"",
            ""comment"": ""8 rogue aep""
        },
        {
            ""name"": ""Frostfire Ring"",
            ""price"": 5,
            ""id"": 23062,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23062/frostfire-ring"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Plagueheart Ring"",
            ""price"": 5,
            ""id"": 23063,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23063/plagueheart-ring"",
            ""type"": ""Finger"",
            ""rogueSword"": 1
        },
        {
            ""name"": ""Ring of Faith"",
            ""price"": 5,
            ""id"": 23061,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23061/ring-of-faith"",
            ""type"": ""Finger"",
            ""holyPriest"": 1
        },
        {
            ""name"": ""Ring of Redemption"",
            ""price"": 5,
            ""id"": 23066,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23066/ring-of-redemption"",
            ""type"": ""Finger"",
            ""rogueDagger"": 1,
            ""holyPaladin"": 1
        },
        {
            ""name"": ""Ring of the Cryptstalker"",
            ""price"": 5,
            ""id"": 23067,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23067/ring-of-the-cryptstalker"",
            ""type"": ""Finger"",
            ""rogueSword"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""Ring of the Dreadnaught"",
            ""price"": 5,
            ""id"": 23059,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23059/ring-of-the-dreadnaught"",
            ""type"": ""Finger"",
            ""warriorProt"": 1
        },
        {
            ""name"": ""Ring of the Dreamwalker"",
            ""price"": 5,
            ""id"": 23064,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23064/ring-of-the-dreamwalker"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""The Phylactery of Kel'Thuzad"",
            ""price"": 20,
            ""id"": 22520,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22520/the-phylactery-of-kelthuzad"",
            ""type"": ""Legs""
        },
        {
            ""name"": ""Gem of Trapped Innocents"",
            ""price"": 15,
            ""id"": 23057,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23057/gem-of-trapped-innocents"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Stormrage's Talisman of Seething"",
            ""price"": 10,
            ""id"": 23053,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23053/stormrages-talisman-of-seething"",
            ""type"": ""Neck"",
            ""comment"": ""2 warrior aep"",
            ""warriorFury"": 1,
            ""warriorFuryprot"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""Gressil, Dawn of Ruin"",
            ""price"": 80,
            ""id"": 23054,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23054/gressil-dawn-of-ruin"",
            ""type"": ""One-Hand"",
            ""detail"": ""Sword"",
            ""comment"": ""80 rogue aep, 200 warrior aep"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1,
            ""warriorFury"": 1,
            ""warriorFuryprot"": 1
        },
        {
            ""name"": ""Hammer of the Twisting Nether"",
            ""price"": 70,
            ""id"": 23056,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23056/hammer-of-the-twisting-nether"",
            ""type"": ""One-Hand"",
            ""detail"": ""Healing"",
            ""holyPriest"": 1,
            ""restoDruid"": 1,
            ""holyPaladin"": 1
        },
        {
            ""name"": ""Kingsfall"",
            ""price"": 80,
            ""id"": 22802,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22802/kingsfall"",
            ""type"": ""One-Hand"",
            ""detail"": ""Dagger"",
            ""comment"": ""60 rogue aep""
        },
        {
            ""name"": ""The Hungering Cold"",
            ""price"": 65,
            ""id"": 23577,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23577/the-hungering-cold"",
            ""type"": ""One-Hand"",
            ""detail"": ""Sword"",
            ""comment"": ""40 rogue aep, 200 warrior aep"",
            ""warriorFury"": 1,
            ""warriorFuryprot"": 1
        },
        {
            ""name"": ""Doomfinger"",
            ""price"": 10,
            ""id"": 22821,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22821/doomfinger"",
            ""type"": ""Ranged"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Nerubian Slavemaker"",
            ""price"": 80,
            ""id"": 22812,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22812/nerubian-slavemaker"",
            ""type"": ""Ranged"",
            ""hunter"": 1
        },
        {
            ""name"": ""Shield of Condemnation"",
            ""price"": 15,
            ""id"": 22819,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22819/shield-of-condemnation"",
            ""type"": ""Shield"",
            ""holyPaladin"": 1
        },
        {
            ""name"": ""Might of Menethil"",
            ""price"": 10,
            ""id"": 22798,
            ""forPvp"": ""X"",
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22798/might-of-menethil"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Soulseeker"",
            ""price"": 40,
            ""id"": 22799,
            ""bosses"": ""Kel'Thuzad"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22799/soulseeker"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Band of Unnatural Forces"",
            ""price"": 15,
            ""id"": 23038,
            ""bosses"": ""Loatheb"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23038/band-of-unnatural-forces"",
            ""type"": ""Finger"",
            ""comment"": ""15 rogue aep"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1,
            ""warriorFury"": 1,
            ""warriorFuryprot"": 1
        },
        {
            ""name"": ""Ring of Spiritual Fervor"",
            ""price"": 1,
            ""id"": 23037,
            ""bosses"": ""Loatheb"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23037/ring-of-spiritual-fervor"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Desecrated Leggings"",
            ""price"": 10,
            ""id"": 22366,
            ""bosses"": ""Loatheb"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22366/desecrated-leggings"",
            ""type"": ""Legs"",
            ""holyPriest"": 1
        },
        {
            ""name"": ""Desecrated Legguards"",
            ""price"": 10,
            ""id"": 22359,
            ""bosses"": ""Loatheb"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22359/desecrated-legguards"",
            ""type"": ""Legs"",
            ""restoDruid"": 1,
            ""holyPaladin"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""Desecrated Legplates"",
            ""price"": 10,
            ""id"": 22352,
            ""bosses"": ""Loatheb"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22352/desecrated-legplates"",
            ""type"": ""Legs"",
            ""comment"": ""15 rogue aep"",
            ""warriorProt"": 1
        },
        {
            ""name"": ""Loatheb's Reflection"",
            ""price"": 0,
            ""id"": 23042,
            ""bosses"": ""Loatheb"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23042/loathebs-reflection"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Brimstone Staff"",
            ""price"": 40,
            ""id"": 22800,
            ""bosses"": ""Loatheb"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22800/brimstone-staff"",
            ""type"": ""Two-Hand"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""The Eye of Nerub"",
            ""price"": 5,
            ""id"": 23039,
            ""bosses"": ""Loatheb"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23039/the-eye-of-nerub"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Crystal Webbed Robe"",
            ""price"": 10,
            ""id"": 23220,
            ""bosses"": ""Maexxna"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23220/crystal-webbed-robe"",
            ""type"": ""Chest"",
            ""detail"": ""Shadowpriest BIS""
        },
        {
            ""name"": ""Desecrated Gauntlets"",
            ""price"": 5,
            ""id"": 22357,
            ""bosses"": ""Maexxna"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22357/desecrated-gauntlets"",
            ""type"": ""Hands"",
            ""comment"": "" 17 rogue aep"",
            ""warriorProt"": 1
        },
        {
            ""name"": ""Desecrated Gloves"",
            ""price"": 5,
            ""id"": 22371,
            ""bosses"": ""Maexxna"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22371/desecrated-gloves"",
            ""type"": ""Hands"",
            ""holyPriest"": 1
        },
        {
            ""name"": ""Desecrated Handguards"",
            ""price"": 5,
            ""id"": 22364,
            ""bosses"": ""Maexxna"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22364/desecrated-handguards"",
            ""type"": ""Hands"",
            ""restoDruid"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""Pendant of Forgotten Names"",
            ""price"": 1,
            ""id"": 22947,
            ""bosses"": ""Maexxna"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22947/pendant-of-forgotten-names"",
            ""type"": ""Neck""
        },
        {
            ""name"": ""Maexxna's Fang"",
            ""price"": 5,
            ""id"": 22804,
            ""bosses"": ""Maexxna"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22804/maexxnas-fang"",
            ""type"": ""One-Hand"",
            ""detail"": ""Dagger"",
            ""comment"": ""6-30 rogue aep oh vs mh no ds""
        },
        {
            ""name"": ""Wraith Blade"",
            ""price"": 65,
            ""id"": 22807,
            ""bosses"": ""Maexxna"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22807/wraith-blade"",
            ""type"": ""One-Hand"",
            ""detail"": ""Caster""
        },
        {
            ""name"": ""Kiss of the Spider"",
            ""price"": 35,
            ""id"": 22954,
            ""bosses"": ""Maexxna"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22954/kiss-of-the-spider"",
            ""type"": ""Trinket"",
            ""comment"": ""20 rogue"",
            ""feralDruid"": 1,
            ""warriorFuryprot"": 1
        },
        {
            ""name"": ""Cloak of the Scourge"",
            ""price"": 2,
            ""id"": 23030,
            ""bosses"": ""Noth the Plaguebringer"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23030/cloak-of-the-scourge"",
            ""type"": ""Back""
        },
        {
            ""name"": ""Band of the Inevitable"",
            ""price"": 15,
            ""id"": 23031,
            ""bosses"": ""Noth the Plaguebringer"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23031/band-of-the-inevitable"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Hailstone Band"",
            ""price"": 0,
            ""id"": 23028,
            ""bosses"": ""Noth the Plaguebringer"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23028/hailstone-band"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Noth's Frigid Heart"",
            ""price"": 5,
            ""id"": 23029,
            ""bosses"": ""Noth the Plaguebringer"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23029/noths-frigid-heart"",
            ""type"": ""Held In Off-hand"",
            ""detail"": ""Healer"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Hatchet of Sundered Bone"",
            ""price"": 30,
            ""id"": 22816,
            ""bosses"": ""Noth the Plaguebringer"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22816/hatchet-of-sundered-bone"",
            ""type"": ""One-Hand"",
            ""detail"": ""Axe"",
            ""hunter"": 1
        },
        {
            ""name"": ""Libram of Light"",
            ""price"": 10,
            ""id"": 23006,
            ""bosses"": ""Noth the Plaguebringer"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23006/libram-of-light"",
            ""type"": ""Relic"",
            ""holyPaladin"": 1
        },
        {
            ""name"": ""Cloak of Suturing"",
            ""price"": 15,
            ""id"": 22960,
            ""bosses"": ""Patchwerk"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22960/cloak-of-suturing"",
            ""type"": ""Back"",
            ""holyPriest"": 1,
            ""restoDruid"": 1
        },
        {
            ""name"": ""Band of Reanimation"",
            ""price"": 10,
            ""id"": 22961,
            ""bosses"": ""Patchwerk"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22961/band-of-reanimation"",
            ""type"": ""Finger"",
            ""hunter"": 1
        },
        {
            ""name"": ""Wand of Fates"",
            ""price"": 10,
            ""id"": 22820,
            ""bosses"": ""Patchwerk"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22820/wand-of-fates"",
            ""type"": ""Ranged""
        },
        {
            ""name"": ""The Plague Bearer"",
            ""price"": 0,
            ""id"": 22818,
            ""bosses"": ""Patchwerk"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22818/the-plague-bearer"",
            ""type"": ""Shield""
        },
        {
            ""name"": ""Severance"",
            ""price"": 2,
            ""id"": 22815,
            ""forPvp"": ""X"",
            ""bosses"": ""Patchwerk"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22815/severance"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Cloak of the Necropolis"",
            ""price"": 15,
            ""id"": 23050,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23050/cloak-of-the-necropolis"",
            ""type"": ""Back""
        },
        {
            ""name"": ""Shroud of Dominion"",
            ""price"": 15,
            ""id"": 23045,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23045/shroud-of-dominion"",
            ""type"": ""Back"",
            ""comment"": ""6 rogue aep, 10 warrior aep"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1,
            ""warriorFury"": 1,
            ""warriorFuryprot"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""Resilience of the Scourge"",
            ""price"": 5,
            ""id"": 23547,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23547/resilience-of-the-scourge"",
            ""type"": ""Enchant""
        },
        {
            ""name"": ""Fortitude of the Scourge"",
            ""price"": 5,
            ""id"": 23549,
            ""fortank"": ""X"",
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23549/fortitude-of-the-scourge"",
            ""type"": ""Enchant"",
            ""warriorProt"": 1
        },
        {
            ""name"": ""Might of the Scourge"",
            ""price"": 5,
            ""id"": 23548,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23548/might-of-the-scourge"",
            ""type"": ""Enchant"",
            ""warriorFury"": 1
        },
        {
            ""name"": ""Power of the Scourge"",
            ""price"": 5,
            ""id"": 23545,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23545/power-of-the-scourge"",
            ""type"": ""Enchant""
        },
        {
            ""name"": ""Sapphiron's Left Eye"",
            ""price"": 15,
            ""id"": 23049,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23049/sapphirons-left-eye"",
            ""type"": ""Held In Off-hand"",
            ""detail"": ""Caster"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Sapphiron's Right Eye"",
            ""price"": 15,
            ""id"": 23048,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23048/sapphirons-right-eye"",
            ""type"": ""Held In Off-hand"",
            ""detail"": ""Healer"",
            ""holyPriest"": 1,
            ""restoDruid"": 1
        },
        {
            ""name"": ""Claw of the Frost Wyrm"",
            ""price"": 10,
            ""id"": 23242,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23242/claw-of-the-frost-wyrm"",
            ""type"": ""Off Hand"",
            ""comment"": ""40-50 rogue OH"",
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""The Face of Death"",
            ""price"": 15,
            ""id"": 23043,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23043/the-face-of-death"",
            ""type"": ""Shield"",
            ""warriorProt"": 1
        },
        {
            ""name"": ""Eye of the Dead"",
            ""price"": 30,
            ""id"": 23047,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23047/eye-of-the-dead"",
            ""type"": ""Trinket"",
            ""holyPriest"": 1,
            ""restoDruid"": 1,
            ""holyPaladin"": 1
        },
        {
            ""name"": ""Glyph of Deflection"",
            ""price"": 30,
            ""id"": 23040,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23040/glyph-of-deflection"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Slayer's Crest"",
            ""price"": 30,
            ""id"": 23041,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23041/slayers-crest"",
            ""type"": ""Trinket"",
            ""comment"": ""25 rogue"",
            ""warriorFury"": 1,
            ""warriorFuryprot"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""The Restrained Essence of Sapphiron"",
            ""price"": 30,
            ""id"": 23046,
            ""bosses"": ""Sapphiron"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23046/the-restrained-essence-of-sapphiron"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Desecrated Boots"",
            ""price"": 5,
            ""id"": 22365,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22365/desecrated-boots"",
            ""type"": ""Boots"",
            ""restoDruid"": 1,
            ""holyPaladin"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""Desecrated Sabatons"",
            ""price"": 5,
            ""id"": 22358,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22358/desecrated-sabatons"",
            ""type"": ""Boots"",
            ""comment"": ""18 rogue aep"",
            ""warriorProt"": 1
        },
        {
            ""name"": ""Desecrated Sandals"",
            ""price"": 5,
            ""id"": 22372,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22372/desecrated-sandals"",
            ""type"": ""Boots"",
            ""holyPriest"": 1,
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Desecrated Pauldrons"",
            ""price"": 15,
            ""id"": 22354,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22354/desecrated-pauldrons"",
            ""type"": ""Shoulders"",
            ""comment"": ""13 rogue aep"",
            ""warriorProt"": 1
        },
        {
            ""name"": ""Desecrated Shoulderpads"",
            ""price"": 15,
            ""id"": 22368,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22368/desecrated-shoulderpads"",
            ""type"": ""Shoulders"",
            ""holyPriest"": 1
        },
        {
            ""name"": ""Desecrated Spaulders"",
            ""price"": 15,
            ""id"": 22361,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22361/desecrated-spaulders"",
            ""type"": ""Shoulders"",
            ""restoDruid"": 1,
            ""holyPaladin"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""Splinter of Atiesh"",
            ""price"": 1,
            ""id"": 22726,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22726/splinter-of-atiesh"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Desecrated Belt"",
            ""price"": 5,
            ""id"": 22370,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22370/desecrated-belt"",
            ""type"": ""Waist"",
            ""holyPriest"": 1,
            ""rogueSword"": 1,
            ""rogueDagger"": 1
        },
        {
            ""name"": ""Desecrated Girdle"",
            ""price"": 5,
            ""id"": 22363,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22363/desecrated-girdle"",
            ""type"": ""Waist"",
            ""restoDruid"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""Desecrated Waistguard"",
            ""price"": 5,
            ""id"": 22356,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22356/desecrated-waistguard"",
            ""type"": ""Waist"",
            ""comment"": ""0 rogue aep"",
            ""warriorProt"": 1
        },
        {
            ""name"": ""Desecrated Bindings"",
            ""price"": 5,
            ""id"": 22369,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22369/desecrated-bindings"",
            ""type"": ""Wrist"",
            ""holyPriest"": 1
        },
        {
            ""name"": ""Desecrated Bracers"",
            ""price"": 5,
            ""id"": 22355,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22355/desecrated-bracers"",
            ""type"": ""Wrist"",
            ""comment"": ""8 rogue aep"",
            ""warriorProt"": 1
        },
        {
            ""name"": ""Desecrated Wristguards"",
            ""price"": 5,
            ""id"": 22362,
            ""bosses"": ""Shared"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22362/desecrated-wristguards"",
            ""type"": ""Wrist"",
            ""restoDruid"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""Plated Abomination Ribcage"",
            ""price"": 20,
            ""id"": 23000,
            ""bosses"": ""Thaddius"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23000/plated-abomination-ribcage"",
            ""type"": ""Chest"",
            ""comment"": ""15-40 warrior aep"",
            ""warriorFury"": 1
        },
        {
            ""name"": ""Desecrated Circlet"",
            ""price"": 15,
            ""id"": 22367,
            ""bosses"": ""Thaddius"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22367/desecrated-circlet"",
            ""type"": ""Head"",
            ""holyPriest"": 1
        },
        {
            ""name"": ""Desecrated Headpiece"",
            ""price"": 15,
            ""id"": 22360,
            ""bosses"": ""Thaddius"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22360/desecrated-headpiece"",
            ""type"": ""Head"",
            ""restoDruid"": 1,
            ""holyPaladin"": 1,
            ""hunter"": 1
        },
        {
            ""name"": ""Desecrated Helmet"",
            ""price"": 15,
            ""id"": 22353,
            ""bosses"": ""Thaddius"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22353/desecrated-helmet"",
            ""type"": ""Head"",
            ""comment"": ""13 rogue aep"",
            ""warriorProt"": 1
        },
        {
            ""name"": ""Leggings of Polarity"",
            ""price"": 20,
            ""id"": 23070,
            ""bosses"": ""Thaddius"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23070/leggings-of-polarity"",
            ""type"": ""Legs""
        },
        {
            ""name"": ""The Castigator"",
            ""price"": 30,
            ""id"": 22808,
            ""bosses"": ""Thaddius"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22808/the-castigator"",
            ""type"": ""One-Hand"",
            ""detail"": ""Mace"",
            ""comment"": ""27 rogue aep""
        },
        {
            ""name"": ""Eye of Diminution"",
            ""price"": 5,
            ""id"": 23001,
            ""bosses"": ""Thaddius"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23001/eye-of-diminution"",
            ""type"": ""Trinket""
        },
        {
            ""name"": ""Spire of Twilight"",
            ""price"": 10,
            ""id"": 22801,
            ""bosses"": ""Thaddius"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=22801/spire-of-twilight"",
            ""type"": ""Two-Hand""
        },
        {
            ""name"": ""Ghoul Skin Tunic"",
            ""price"": 20,
            ""id"": 23226,
            ""bosses"": ""Trash"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23226/ghoul-skin-tunic"",
            ""type"": ""Chest"",
            ""feralDruid"": 1
        },
        {
            ""name"": ""Necro-Knight's Garb"",
            ""price"": 1,
            ""id"": 23069,
            ""forPvp"": ""X"",
            ""bosses"": ""Trash"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23069/necro-knights-garb"",
            ""type"": ""Chest""
        },
        {
            ""name"": ""Ring of the Eternal Flame"",
            ""price"": 10,
            ""id"": 23237,
            ""bosses"": ""Trash"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23237/ring-of-the-eternal-flame"",
            ""type"": ""Finger""
        },
        {
            ""name"": ""Leggings of the Grand Crusader"",
            ""price"": 1,
            ""id"": 23668,
            ""forPvp"": ""X"",
            ""bosses"": ""Trash"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23668/leggings-of-the-grand-crusader"",
            ""type"": ""Legs""
        },
        {
            ""name"": ""Harbinger of Doom"",
            ""price"": 15,
            ""id"": 23044,
            ""bosses"": ""Trash"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23044/harbinger-of-doom"",
            ""type"": ""One-Hand"",
            ""detail"": ""Dagger"",
            ""comment"": ""5 rogue aep""
        },
        {
            ""name"": ""Misplaced Servo Arm"",
            ""price"": 30,
            ""id"": 23221,
            ""bosses"": ""Trash"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23221/misplaced-servo-arm"",
            ""type"": ""One-Hand"",
            ""detail"": ""Mace"",
            ""comment"": ""31 rogue aep""
        },
        {
            ""name"": ""Stygian Buckler"",
            ""price"": 1,
            ""id"": 23238,
            ""forPvp"": ""X"",
            ""bosses"": ""Trash"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23238/stygian-buckler"",
            ""type"": ""Shield""
        },
        {
            ""name"": ""Spaulders of the Grand Crusader"",
            ""price"": 1,
            ""id"": 23667,
            ""forPvp"": ""X"",
            ""bosses"": ""Trash"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23667/spaulders-of-the-grand-crusader"",
            ""type"": ""Shoulder""
        },
        {
            ""name"": ""Belt of the Grand Crusader"",
            ""price"": 1,
            ""id"": 23666,
            ""forPvp"": ""X"",
            ""bosses"": ""Trash"",
            ""raid"": ""Naxxramas"",
            ""url"": ""https://classic.wowhead.com/item=23666/belt-of-the-grand-crusader"",
            ""type"": ""Waist""
        }
]";
            var data = JsonConvert.DeserializeObject<object[]>(raid_drop_data);

            var lines = new List<string>(128);
            lines.Add("local raid_drop_data = {");


            foreach(dynamic datum in data)
            {
                var pvp = datum.forPvp == "Yes" || datum.forPvp == "X" ? "true" : "false";
                lines.Add($"[{datum.id}] =  {{ [\"dkp\"] = {datum.price}, [\"forpvp\"] = {pvp} }},");
            }

            lines.Add("}");
            
            var outputDirectory = new DirectoryInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);

            while(!string.Equals(outputDirectory.Name, "json-lua-converter", StringComparison.InvariantCultureIgnoreCase))
            {
                outputDirectory = outputDirectory.Parent;
            }
            
            using(var output = new StreamWriter(Path.Combine(outputDirectory.FullName, "raid_drop_data.lua")))
            {
                foreach(var line in lines)
                {
                    output.WriteLine(line);
                }
            }
        }
    }
}
