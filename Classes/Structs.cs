﻿using System.Runtime.InteropServices;

namespace Lerawin.Classes
{
	[StructLayout(LayoutKind.Explicit)]
	public struct GlowStruct
	{
		[FieldOffset(0x00)]
		public int EntityPointer;
		[FieldOffset(0x4)]
		public float r;
		[FieldOffset(0x8)]
		public float g;
		[FieldOffset(0xC)]
		public float b;
		[FieldOffset(0x10)]
		public float a;
		[FieldOffset(0x14)]
		public int jnk1;
		[FieldOffset(0x18)]
		public int jnk2;
		[FieldOffset(0x1C)]
		public float BloomAmount;
		[FieldOffset(0x20)]
		public int jnk3;

		[FieldOffset(0x24)]
		public bool m_bRenderWhenOccluded;
		[FieldOffset(0x25)]
		public bool m_bRenderWhenUnoccluded;
		[FieldOffset(0x2C)]
		public bool m_bFullBloom;
	};

	public struct RECT
	{
		public int left, top, right, bottom;
	}

	public enum Ranks
	{
		Unranked,
		Silver_I,
		Silver_II,
		Silver_III,
		Silver_IV,
		Silver_Elite,
		Silver_Elite_Master,
		Gold_Nova_I,
		Gold_Nova_II,
		Gold_Nova_III,
		Gold_Nova_Master,
		Master_Guardian_I,
		Master_Guardian_II,
		Master_Guardian_Elite,
		Distinguished_Master_Guardian,
		Legendary_Eagle,
		Legendary_Eagle_Master,
		Supreme_Master_First_Class,
		The_Global_Elite,
	}

	public enum enumWeaponID
	{
		DEAGLE = 1,
		BERETTAS = 2,
		FIVESEVEN = 3,
		GLOCK = 4,
		AK47 = 7,
		AUG = 8,
		AWP = 9,
		FAMAS = 10,
		G3SG1 = 11,
		GALIL = 13,
		M249 = 14,
		M4A4 = 16,
		MAC10 = 17,
		P90 = 19,
		MP5SD = 23,
		UMP45 = 24,
		XM1014 = 25,
		BIZON = 26,
		MAG7 = 27,
		NEGEV = 28,
		SAWEDOFF = 29,
		TEC9 = 30,
		TASER = 31,
		P2000 = 32,
		MP7 = 33,
		MP9 = 34,
		NOVA = 35,
		P250 = 36,
		SCAR20 = 38,
		SG556 = 39,
		SSG08 = 40,
		KNIFE = 42,
		FLASHBANG = 43,
		HEGRENADE = 44,
		SMOKEGRENADE = 45,
		MOLOTOV = 46,
		DECOY = 47,
		INCGRENADE = 48,
		C4 = 49,
		M4A1S = 60,
		USPS = 61,
		CZ75A = 63,
		REVOLVER = 64,
	}

	public enum Weapons
	{
		ALL,
		GLOCK,
		P2000,
		USPS,
		BERETTAS,
		P250,
		TEC9,
		FIVESEVEN,
		CZ75A,
		REVOLVER,
		DEAGLE,
		NOVA,
		XM1014,
		SAWEDOFF,
		MAG7,
		NEGEV,
		M249,
		MAC10,
		MP9,
		MP7,
		MP5SD,
		UMP45,
		P90,
		BIZON,
		GALIL,
		FAMAS,
		AK47,
		M4A1S,
		M4A4,
		SG553,
		AUG,
		SSG08,
		AWP,
		G3SG1,
		SCAR20,
	}

	public enum WeaponCategory
	{
		ALL,
		Rifles,
		Pistols,
		SMGs,
		Heavy,
		AWP,
		Scout,
		Auto,
	}

	// Credits to michel-pi for PaintKit and EntityQuality enums.
	// https://github.com/michel-pi/csgo-items-parser
	public enum PaintKit
	{
		Default = 0,
		Groundwater = 2,
		CandyApple = 3,
		ForestDDPAT = 5,
		ArcticCamo = 6,
		DesertStorm = 8,
		BengalTiger = 9,
		Copperhead = 10,
		Skulls = 11,
		CrimsonWeb = 12,
		BlueStreak = 13,
		RedLaminate = 14,
		Gunsmoke = 15,
		JungleTiger = 16,
		UrbanDDPAT = 17,
		Virus = 20,
		GraniteMarbleized = 21,
		ContrastSpray = 22,
		ForestLeaves = 25,
		LichenDashed = 26,
		BoneMask = 27,
		AnodizedNavy = 28,
		SnakeCamo = 30,
		Silver = 32,
		HotRod = 33,
		MetallicDDPAT = 34,
		Ossified = 36,
		Blaze = 37,
		Fade = 38,
		Bulldozer = 39,
		Night = 40,
		Copper = 41,
		BlueSteel = 42,
		Stained = 43,
		CaseHardened = 44,
		Contractor = 46,
		Colony = 47,
		DragonTattoo = 48,
		LightningStrike = 51,
		Slaughter = 59,
		DarkWater = 60,
		Hypnotic = 61,
		Bloomstick = 62,
		ColdBlooded = 67,
		CarbonFiber = 70,
		Scorpion = 71,
		SafariMesh = 72,
		Wings = 73,
		PolarCamo = 74,
		BlizzardMarbleized = 75,
		WinterForest = 76,
		BorealForest = 77,
		ForestNight = 78,
		OrangeDDPAT = 83,
		PinkDDPAT = 84,
		Mudder = 90,
		Cyanospatter = 92,
		Caramel = 93,
		Grassland = 95,
		BlueSpruce = 96,
		Ultraviolet = 98,
		SandDune = 99,
		Storm = 100,
		Tornado = 101,
		Whiteout = 102,
		GrasslandLeaves = 104,
		PolarMesh = 107,
		Condemned = 110,
		GlacierMesh = 111,
		SandMesh = 116,
		SageSpray = 119,
		JungleSpray = 122,
		SandSpray = 124,
		UrbanPerforated = 135,
		WavesPerforated = 136,
		OrangePeel = 141,
		UrbanMasked = 143,
		JungleDashed = 147,
		SandDashed = 148,
		UrbanDashed = 149,
		Jungle = 151,
		Demolition = 153,
		Afterimage = 154,
		BulletRain = 155,
		DeathByKitty = 156,
		Palm = 157,
		Walnut = 158,
		Brass = 159,
		Splash = 162,
		ModernHunter = 164,
		SplashJam = 165,
		BlazeOrange = 166,
		RadiationHazard = 167,
		NuclearThreat = 168,
		FalloutWarning = 169,
		Predator = 170,
		IrradiatedAlert = 171,
		BlackLaminate = 172,
		BOOM = 174,
		Scorched = 175,
		FadedZebra = 176,
		Memento = 177,
		Doomkitty = 178,
		NuclearThreat2 = 179,
		FireSerpent = 180,
		Corticera = 181,
		EmeraldDragon = 182,
		Overgrowth = 183,
		Corticera2 = 184,
		GoldenKoi = 185,
		WaveSpray = 186,
		Zirka = 187,
		Graven = 188,
		BrightWater = 189,
		BlackLimba = 190,
		Tempest = 191,
		Shattered = 192,
		BonePile = 193,
		Spitfire = 194,
		Demeter = 195,
		Emerald = 196,
		AnodizedNavy2 = 197,
		Hazard = 198,
		DrySeason = 199,
		MayanDreams = 200,
		Palm2 = 201,
		JungleDDPAT = 202,
		RustCoat = 203,
		Mosaico = 204,
		Jungle2 = 205,
		Tornado2 = 206,
		Facets = 207,
		SandDune2 = 208,
		Groundwater2 = 209,
		AnodizedGunmetal = 210,
		OceanFoam = 211,
		Graphite = 212,
		OceanFoam2 = 213,
		Graphite2 = 214,
		XRay = 215,
		BlueTitanium = 216,
		BloodTiger = 217,
		Hexane = 218,
		Hive = 219,
		Hemoglobin = 220,
		Serum = 221,
		BloodInTheWater = 222,
		Nightshade = 223,
		WaterSigil = 224,
		GhostCamo = 225,
		BlueLaminate = 226,
		ElectricHive = 227,
		BlindSpot = 228,
		AzureZebra = 229,
		SteelDisruption = 230,
		CobaltDisruption = 231,
		CrimsonWeb2 = 232,
		TropicalStorm = 233,
		AshWood = 234,
		Varicamo = 235,
		NightOps = 236,
		UrbanRubble = 237,
		VaricamoBlue = 238,
		Calicamo = 240,
		HuntingBlind = 241,
		ArmyMesh = 242,
		GatorMesh = 243,
		Teardown = 244,
		ArmyRecon = 245,
		AmberFade = 246,
		DamascusSteel = 247,
		RedQuartz = 248,
		CobaltQuartz = 249,
		FullStop = 250,
		PitViper = 251,
		SilverQuartz = 252,
		AcidFade = 253,
		Nitro = 254,
		Asiimov = 255,
		TheKraken = 256,
		Guardian = 257,
		Mehndi = 258,
		Redline = 259,
		Pulse = 260,
		Marina = 261,
		RoseIron = 262,
		RisingSkull = 263,
		Sandstorm = 264,
		Kami = 265,
		Magma = 266,
		CobaltHalftone = 267,
		TreadPlate = 268,
		TheFuschiaIsNow = 269,
		Victoria = 270,
		Undertow = 271,
		TitaniumBit = 272,
		Heirloom = 273,
		CopperGalaxy = 274,
		RedFragcam = 275,
		Panther = 276,
		Stainless = 277,
		BlueFissure = 278,
		Asiimov2 = 279,
		Chameleon = 280,
		Corporal = 281,
		Redline2 = 282,
		Trigon = 283,
		Heat = 284,
		Terrain = 285,
		Antique = 286,
		Pulse2 = 287,
		Sergeant = 288,
		Sandstorm2 = 289,
		Guardian2 = 290,
		HeavenGuard = 291,
		DeathRattle = 293,
		GreenApple = 294,
		Franklin = 295,
		Meteorite = 296,
		Tuxedo = 297,
		ArmySheen = 298,
		CagedSteel = 299,
		EmeraldPinstripe = 300,
		AtomicAlloy = 301,
		Vulcan = 302,
		Isaac = 303,
		Slashed = 304,
		Torque = 305,
		Antique2 = 306,
		Retribution = 307,
		Kami2 = 308,
		Howl = 309,
		Curse = 310,
		DesertWarfare = 311,
		Cyrex = 312,
		Orion = 313,
		HeavenGuard2 = 314,
		PoisonDart = 315,
		Jaguar = 316,
		Bratatat = 317,
		RoadRash = 318,
		Detour = 319,
		RedPython = 320,
		MasterPiece = 321,
		Nitro2 = 322,
		RustCoat2 = 323,
		Chalice = 325,
		Knight = 326,
		Chainmail = 327,
		HandCannon = 328,
		DarkAge = 329,
		Briar = 330,
		RoyalBlue = 332,
		Indigo = 333,
		Twist = 334,
		Module = 335,
		DesertStrike = 336,
		Tatter = 337,
		Pulse3 = 338,
		Caiman = 339,
		JetSet = 340,
		FirstClass = 341,
		Leather = 342,
		Commuter = 343,
		DragonLore = 344,
		FirstClass2 = 345,
		CoachClass = 346,
		Pilot = 347,
		RedLeather = 348,
		Osiris = 349,
		Tigris = 350,
		Conspiracy = 351,
		FowlPlay = 352,
		WaterElemental = 353,
		UrbanHazard = 354,
		DesertStrike2 = 355,
		Koi = 356,
		Ivory = 357,
		Supernova = 358,
		Asiimov3 = 359,
		Cyrex2 = 360,
		Abyss = 361,
		Labyrinth = 362,
		Traveler = 363,
		BusinessClass = 364,
		OlivePlaid = 365,
		GreenPlaid = 366,
		Reactor = 367,
		SettingSun = 368,
		NuclearWaste = 369,
		BoneMachine = 370,
		Styx = 371,
		NuclearGarden = 372,
		Contamination = 373,
		Toxic = 374,
		RadiationHazard2 = 375,
		ChemicalGreen = 376,
		HotShot = 377,
		FalloutWarning2 = 378,
		Cerberus = 379,
		WastelandRebel = 380,
		Grinder = 381,
		Murky = 382,
		Basilisk = 383,
		Griffin = 384,
		Firestarter = 385,
		Dart = 386,
		UrbanHazard2 = 387,
		Cartel = 388,
		FireElemental = 389,
		Highwayman = 390,
		Cardiac = 391,
		Delusion = 392,
		Tranquility = 393,
		Cartel2 = 394,
		ManOWar = 395,
		UrbanShock = 396,
		Naga = 397,
		Chatterbox = 398,
		Catacombs = 399,
		DragonKing = 400,
		SystemLock = 401,
		Malachite = 402,
		DeadlyPoison = 403,
		Muertos = 404,
		Serenity = 405,
		Grotto = 406,
		Quicksilver = 407,
		TigerTooth = 409,
		DamascusSteel2 = 410,
		DamascusSteel3 = 411,
		MarbleFade = 413,
		RustCoat3 = 414,
		Doppler = 415,
		Doppler2 = 416,
		Doppler3 = 417,
		Doppler4 = 418,
		Doppler5 = 419,
		Doppler6 = 420,
		Doppler7 = 421,
		EliteBuild = 422,
		ArmorCore = 423,
		WormGod = 424,
		BronzeDeco = 425,
		Valence = 426,
		MonkeyBusiness = 427,
		Eco = 428,
		Djinn = 429,
		HyperBeast = 430,
		Heat2 = 431,
		ManOWar2 = 432,
		NeonRider = 433,
		Origami = 434,
		PolePosition = 435,
		GrandPrix = 436,
		TwilightGalaxy = 437,
		Chronos = 438,
		Hades = 439,
		IcarusFell = 440,
		MinotaursLabyrinth = 441,
		Asterion = 442,
		Pathfinder = 443,
		Daedalus = 444,
		HotRod2 = 445,
		Medusa = 446,
		Duelist = 447,
		PandorasBox = 448,
		Poseidon = 449,
		MoonInLibra = 450,
		SunInLeo = 451,
		ShippingForecast = 452,
		Emerald2 = 453,
		ParaGreen = 454,
		AkihabaraAccept = 455,
		Hydroponic = 456,
		BambooPrint = 457,
		BambooShadow = 458,
		BambooForest = 459,
		AquaTerrace = 460,
		CounterTerrace = 462,
		Terrace = 463,
		NeonKimono = 464,
		OrangeKimono = 465,
		CrimsonKimono = 466,
		MintKimono = 467,
		MidnightStorm = 468,
		SunsetStorm壱 = 469,
		SunsetStorm弐 = 470,
		Daybreak = 471,
		ImpactDrill = 472,
		Seabird = 473,
		AquamarineRevenge = 474,
		HyperBeast2 = 475,
		YellowJacket = 476,
		NeuralNet = 477,
		RocketPop = 478,
		BunsenBurner = 479,
		EvilDaimyo = 480,
		Nemesis = 481,
		RubyPoisonDart = 482,
		Loudmouth = 483,
		Ranger = 484,
		Handgun = 485,
		EliteBuild2 = 486,
		Cyrex3 = 487,
		Riot = 488,
		Torque2 = 489,
		FrontsideMisty = 490,
		DualingDragons = 491,
		SurvivorZ = 492,
		Flux = 493,
		StoneCold = 494,
		Wraiths = 495,
		NebulaCrusader = 496,
		GoldenCoil = 497,
		Rangeen = 498,
		CobaltCore = 499,
		SpecialDelivery = 500,
		Wingshot = 501,
		GreenMarine = 502,
		BigIron = 503,
		KillConfirmed = 504,
		Scumbria = 505,
		PointDisarray = 506,
		Ricochet = 507,
		FuelRod = 508,
		Corinthian = 509,
		Retrobution = 510,
		TheExecutioner = 511,
		RoyalPaladin = 512,
		PowerLoader = 514,
		Imperial = 515,
		Shapewood = 516,
		Yorick = 517,
		Outbreak = 518,
		TigerMoth = 519,
		Avalanche = 520,
		TecluBurner = 521,
		Fade2 = 522,
		AmberFade2 = 523,
		FuelInjector = 524,
		EliteBuild3 = 525,
		PhoticZone = 526,
		KumichoDragon = 527,
		Cartel3 = 528,
		Valence2 = 529,
		Triumvirate = 530,
		RoyalLegion = 532,
		TheBattlestar = 533,
		LapisGator = 534,
		Praetorian = 535,
		Impire = 536,
		HyperBeast3 = 537,
		Necropos = 538,
		Jambiya = 539,
		LeadConduit = 540,
		Doppler8 = 617,
		Doppler9 = 618,
		Doppler10 = 619,
		Ultraviolet2 = 620,
		Ultraviolet3 = 621,
		Charred = 10006,
		Snakebite = 10007,
		Bronzed = 10008,
		Leather2 = 10009,
		SpruceDDPAT = 10010,
		LunarWeave = 10013,
		Convoy = 10015,
		CrimsonWeave = 10016,
		Superconductor = 10018,
		Arid = 10019,
		Slaughter2 = 10021,
		Eclipse = 10024,
		Spearmint = 10026,
		Boom = 10027,
		CoolMint = 10028,
		ForestDDPAT2 = 10030,
		CrimsonKimono2 = 10033,
		EmeraldWeb = 10034,
		Foundation = 10035,
		Badlands = 10036,
		PandorasBox2 = 10037,
		HedgeMaze = 10038,
		Guerrilla = 10039,
		Diamondback = 10040,
		KingSnake = 10041,
		ImperialPlaid = 10042,
		Overtake = 10043,
		RacingGreen = 10044,
		Amphibious = 10045,
		BronzeMorph = 10046,
		Omega = 10047,
		Vice = 10048,
		POW = 10049,
		Turtle = 10050,
		Transport = 10051,
		Polygon = 10052,
		CobaltSkulls = 10053,
		Overprint = 10054,
		DuctTape = 10055,
		Arboreal = 10056,
		Emerald3 = 10057,
		Mangrove = 10058,
		Rattler = 10059,
		CaseHardened2 = 10060,
		CrimsonWeb3 = 10061,
		Buckshot = 10062,
		Fade3 = 10063,
		Mogul = 10064,
		MarbleFade2 = 10065,
		LtCommander = 10066,
		TigerStrike = 10067,
		FieldAgent = 10068,
		RezanTheRed = 10069,
		SnowLeopard = 10070,
		QueenJaguar = 10071,
		BlackTie = 10072,
		Slingshot = 10073,
		BigGame = 10074,
		ScarletShamagh = 10075,
		Nocts = 10076,
		FinishLine = 10077,
		SmokeOut = 10078,
		BloodPressure = 10079,
		ThirdCommandoCompany = 10080,
		DesertShamagh = 10081,
		Giraffe = 10082,
		Constrictor = 10083,
		CAUTION = 10084,
		Jade = 10085,
		YellowBanded = 10086,
		NeedlePoint = 10087,
		Unhinged = 10088,
		FacilitySketch = 775,
		FacilityNegative = 776,
		FacilityDraft = 777,
		FacilityDark = 778,
		RandomAccess = 779,
		Mainframe = 780,
		CoProcessor = 781,
		Motherboard = 782,
		Bulkhead = 783,
		Coolant = 784,
		Mandrel = 785,
		Exchanger = 786,
		CoreBreach = 787,
		Acheron = 788,
		NuclearGarden2 = 789,
		ColdFusion = 790,
		RemoteControl = 791,
		ControlPanel = 792,
		TwinTurbo = 747,
		CalfSkin = 748,
		VinoPrimo = 749,
		Integrale = 750,
		HandBrake = 751,
		Fade4 = 752,
		DirtDrop = 753,
		RustCoat4 = 754,
		Slide = 755,
		Converter = 793,
		Sweeper = 794,
		SafetyNet = 795,
		CheckEngine = 796,
		BrakeLight = 797,
		Nitro3 = 798,
		HighBeam = 799,
		XRay2 = 125,
		FleetFlock = 541,
		JudgementOfAnubis = 542,
		RedAstor = 543,
		Ventilators = 544,
		OrangeCrash = 545,
		Firefight = 546,
		Spectre = 547,
		ChanticosFire = 548,
		Bioleak = 549,
		Oceanic = 550,
		Asiimov4 = 551,
		Fubar = 552,
		Atlas = 553,
		GhostCrusader = 554,
		ReEntry = 555,
		PrimalSaber = 556,
		BlackTie2 = 557,
		Lore = 558,
		Lore2 = 559,
		Lore3 = 560,
		Lore4 = 561,
		Lore5 = 562,
		BlackLaminate2 = 563,
		BlackLaminate3 = 564,
		BlackLaminate4 = 565,
		BlackLaminate5 = 566,
		BlackLaminate6 = 567,
		GammaDoppler = 568,
		GammaDoppler2 = 569,
		GammaDoppler3 = 570,
		GammaDoppler4 = 571,
		GammaDoppler5 = 572,
		Autotronic = 573,
		Autotronic2 = 574,
		Autotronic3 = 575,
		Autotronic4 = 576,
		Autotronic5 = 577,
		BrightWater2 = 578,
		BrightWater3 = 579,
		Freehand = 580,
		Freehand2 = 581,
		Freehand3 = 582,
		Aristocrat = 583,
		Phobos = 584,
		ViolentDaimyo = 585,
		WastelandRebel2 = 586,
		MechaIndustries = 587,
		DesolateSpace = 588,
		Carnivore = 589,
		Exo = 590,
		ImperialDragon = 591,
		IronClad = 592,
		Chopper = 593,
		Harvester = 594,
		Reboot = 595,
		Limelight = 596,
		Bloodsport = 597,
		Aerial = 598,
		IceCap = 599,
		NeonRevolution = 600,
		SydMead = 601,
		Imprint = 602,
		Directive = 603,
		RollCage = 604,
		Scumbria2 = 605,
		Ventilator = 606,
		Weasel = 607,
		Petroglyph = 608,
		Airlock = 609,
		Dazzle = 610,
		Grim = 611,
		Powercore = 612,
		Triarch = 613,
		FuelInjector2 = 614,
		Briefing = 615,
		Slipstream = 616,
		Polymer = 622,
		Ironwork = 623,
		Dragonfire = 624,
		RoyalConsorts = 625,
		MechaIndustries2 = 626,
		Cirrus = 627,
		Stinger = 628,
		BlackSand = 629,
		SandScale = 630,
		Flashback = 631,
		BuzzKill = 632,
		Sonar = 633,
		Gila = 634,
		Turf = 635,
		ShallowGrave = 636,
		Cyrex4 = 637,
		WastelandPrincess = 638,
		Bloodsport2 = 639,
		FeverDream = 640,
		JungleSlipstream = 641,
		Blueprint = 642,
		Xiangliu = 643,
		Decimator = 644,
		OxideBlaze = 645,
		Capillary = 646,
		CrimsonTsunami = 647,
		EmeraldPoisonDart = 648,
		Akoben = 649,
		Ripple = 650,
		LastDive = 651,
		Scaffold = 652,
		NeoNoir = 653,
		Seasons = 654,
		Zander = 655,
		OrbitMk01 = 656,
		Blueprint2 = 657,
		CobraStrike = 658,
		Macabre = 659,
		HyperBeast4 = 660,
		SugarRush = 661,
		OniTaiji = 662,
		Briefing2 = 663,
		Hellfire = 664,
		Aloha = 665,
		HardWater = 666,
		Woodsman = 667,
		RedRock = 668,
		DeathGrip = 669,
		DeathsHead = 670,
		CutOut = 671,
		MetalFlowers = 672,
		Morris = 673,
		Triqua = 674,
		TheEmpress = 675,
		HighRoller = 676,
		Hunter = 677,
		SeeYaLater = 678,
		Goo = 679,
		OffWorld = 680,
		LeadedGlass = 681,
		Oceanic2 = 682,
		LlamaCannon = 683,
		CrackedOpal = 684,
		JungleSlipstream2 = 685,
		Phantom = 686,
		Tacticat = 687,
		Exposure = 688,
		Ziggy = 689,
		LabRats = 800,
		Stymphalian = 690,
		Mortis = 691,
		NightRiot = 692,
		FlameTest = 693,
		Moonrise = 694,
		NeoNoir2 = 695,
		Bloodsport3 = 696,
		BlackSand2 = 697,
		Lionfish = 698,
		WildSix = 699,
		UrbanHazard3 = 700,
		Grip = 701,
		Aloha2 = 702,
		SWAG7 = 703,
		ArcticWolf = 704,
		Cortex = 705,
		OxideBlaze2 = 706,
		NeonRider2 = 707,
		AmberSlipstream = 708,
		Eco2 = 709,
		Shred = 710,
		CodeRed = 711,
		HighSeas = 712,
		Warhawk = 713,
		Nightmare = 714,
		Capillary2 = 715,
		ToySoldier = 716,
		Traction = 717,
		PAW = 718,
		Powercore2 = 719,
		Devourer = 720,
		Survivalist = 721,
		Snek9 = 722,
		EyeOfAthena = 723,
		NightStripe = 735,
		WildLotus = 724,
		DayLily = 725,
		SunsetLily = 726,
		MidnightLily = 727,
		TealBlossom = 728,
		CrimsonBlossom = 729,
		DarkBlossom = 730,
		BananaLeaf = 731,
		SynthLeaf = 732,
		RustLeaf = 733,
		WildLily = 734,
		SeaCalico = 868,
		Sundown = 869,
		JungleThicket = 870,
		Surfwood = 871,
		BambooGarden = 872,
		Seabird2 = 873,
		ThePrince = 736,
		Cinquedea = 737,
		OrangeMurano = 738,
		VioletMurano = 739,
		NavyMurano = 740,
		DarkFiligree = 741,
		RedFiligree = 742,
		OrangeFiligree = 743,
		BaroqueRed = 744,
		BaroquePurple = 745,
		BaroqueOrange = 746,
		CandyApple2 = 864,
		StoneMosaico = 865,
		CanalSpray = 866,
		StainedGlass = 867,
		BoroqueSand = 920,
		Gungnir = 756,
		EmeraldJörmungandr = 757,
		FlameJörmungandr = 758,
		AstralJörmungandr = 759,
		FrostBorre = 760,
		CopperBorre = 761,
		RedStone = 762,
		Mjölnir = 763,
		EmeraldQuartz = 859,
		Pyre = 860,
		Barricade = 861,
		MossQuartz = 862,
		NightBorre = 863,
		Asiimov5 = 801,
		Momentum = 802,
		NeoNoir3 = 803,
		ModestThreat = 804,
		MechaIndustries3 = 805,
		Scavenger = 806,
		Signal = 807,
		OxideBlaze3 = 808,
		WoodFired = 809,
		Phosphor = 810,
		Magnesium = 811,
		PipeDown = 812,
		Nevermore = 813,
		BlackSand3 = 814,
		DangerClose = 815,
		Fubar2 = 816,
		Flashback2 = 817,
		Crypsis = 835,
		Uncharted = 836,
		AngryMob = 837,
		Atheris = 838,
		Bamboozle = 839,
		Whitefish = 840,
		LightRail = 841,
		Akoben2 = 842,
		SkullCrusher = 843,
		TheEmperor = 844,
		Momentum2 = 845,
		Gauss = 846,
		Mischief = 847,
		Verdigris = 848,
		OffWorld2 = 849,
		Incinegator = 850,
		Moonrise2 = 851,
		Doppler11 = 852,
		Doppler12 = 853,
		Doppler13 = 854,
		Doppler14 = 855,
		MarbleFade3 = 856,
		DamascusSteel4 = 857,
		DamascusSteel5 = 858,
		Embargo = 884,
		RatRod = 885,
		ArcticWolf2 = 886,
		ContainmentBreach = 887,
		AcidWash = 888,
		Decimator2 = 889,
		Plume = 890,
		BlackSand4 = 891,
		Memento2 = 892,
		NeonPly = 893,
		Obsidian = 894,
		Balance = 895,
		Torn = 896,
		ColonyIV = 897,
		Stalker = 898,
		Bloodshot = 899,
		Warbird = 900,
		Aztec = 902,
		Elite16 = 903,
		Decommissioned = 904,
		FlashOut = 905,
		Buddy = 906,
		Inferno = 907,
		ClassicCrate = 908,
		Popdog = 909,
		Hydra = 910,
		Nostalgia = 911,
		DeathByPuppy = 913,
		Assault = 914,
		Agent = 915,
		Plastique = 916,
		Wildfire = 917,
		Sacrifice = 918,
		Commemoration = 919,
		Fade5 = 879,
		Parched = 880,
		GoldArabesque = 921,
		OrangeAnolis = 922,
		DesertBrush = 924,
		DesertDDPAT = 925,
		RedDDPAT = 926,
		SpaltedWood = 927,
		BlackTan = 928,
		QuickSand = 929,
		NewRoots = 930,
		OldRoots = 931,
		WitheredVine = 932,
		MidnightPalm = 933,
		Bleached = 934,
		Prey = 935,
		DeathStrike = 1052,
		PurpleDDPAT = 818,
		DesertHydra = 819,
		MusicBox = 820,
		ElegantVines = 821,
		NavySheen = 822,
		SandStorm = 823,
		DriftWood = 824,
		Drought = 825,
		SiennaDamask = 826,
		Humidor = 827,
		VerdantGrowth = 828,
		Anolis = 829,
		FennecFox = 764,
		DesertBlossom = 765,
		OxideOasis = 923,
		PhantomDisruptor = 941,
		TomCat = 942,
		Capillary3 = 943,
		Distressed = 944,
		BluePly = 945,
		PlayerTwo = 946,
		DiscoTech = 947,
		Justice = 948,
		DesertStrike3 = 949,
		Prototype = 950,
		AcidEtched = 951,
		BoneForged = 952,
		Apocalypto = 953,
		Enforcer = 954,
		Darkwing = 955,
		FeverDream2 = 956,
		BulletQueen = 957,
		Ultralight = 958,
		LegionOfAnubis = 959,
		Gnarled = 960,
		MonsterCall = 961,
		Printstream = 962,
		Vogue = 963,
		Brother = 964,
		Allure = 965,
		OlRusty = 966,
		Mainframe001 = 967,
		Cassette = 968,
		Freight = 969,
		Entombed = 970,
		ToothFairy = 971,
		Connexion = 972,
		Runic = 973,
		Kitbash = 974,
		Exoskeleton = 975,
		Vendetta = 976,
		CocoaRampage = 977,
		Dezastre = 978,
		FairyTale = 979,
		DigitalMesh = 980,
		Vandal = 981,
		Contaminant = 982,
		DeepRelief = 983,
		Printstream2 = 984,
		CyberSecurity = 985,
		ConditionZero = 986,
		ClearPolymer = 987,
		NeoNoir4 = 988,
		Parallax = 989,
		GoldBismuth = 990,
		MonsterMashup = 991,
		TheBronze = 992,
		GlobalOffensive = 993,
		Charter = 994,
		Surveillance = 995,
		ThreatDetected = 996,
		Dispatch = 997,
		SwitchBoard = 998,
		PrimeConspiracy = 999,
		BerriesAndCherries = 1002,
		CrimeScene = 1003,
		Fade6 = 1026,
		TargetAcquired = 1027,
		MagnaCarta = 1028,
		BluePhosphor = 1017,
		XRay3 = 1004,
		Heist = 1005,
		NightHeist = 1006,
		VaultHeist = 1007,
		Houndstooth = 1008,
		HotSnakes = 1009,
		PhoenixChalk = 1010,
		PhoenixMarker = 1011,
		PhoenixStencil = 1012,
		PhoenixBlacklight = 1013,
		ClayAmbush = 1014,
		TigerPit = 1015,
		Franklin2 = 1016,
		SilkTiger = 1029,
		BengalTiger2 = 1030,
		RunAndHide = 1000,
		WelcomeToTheJungle = 1001,
		PantheraOnca = 1018,
		PantherCamo = 1019,
		AncientEarth = 1020,
		AncientLore = 1021,
		LushRuins = 1022,
		TallGrass = 1023,
		BlastFromThePast = 1024,
		GoldBrick = 1025,
		AncientVisions = 1031,
		DuskRuins = 1032,
		CarvedJade = 1033,
		AncientRitual = 1034,
		Slate = 1035,
		Circaetus = 1036,
		FoodChain = 1037,
		ChromaticAberration = 1038,
		ClearPolymer2 = 1039,
		TheTraitor = 1040,
		InLivingColor = 1041,
		OSIPR = 1042,
		DevTexture = 1043,
		CyberShell = 1044,
		ButtonMasher = 1045,
		XOXO = 1046,
		JunkYard = 1047,
		HeavyMetal = 1048,
		Oscillator = 1049,
		TriggerDiscipline = 1050,
		Windblown = 1051,
		Meltdown = 1053,
		SpaceRace = 1055,
		Sputnik = 1056,
		POPAWP = 1058,
		FizzyPOP = 1059,
		SpringTwilly = 1060,
		AutumnTwilly = 1061,
		TheCoalition = 1063,
		Syndicate = 1064,
		Whiteout2 = 1065,
		Propaganda = 1067,
		GammaDoppler6 = 1119,
		GammaDoppler7 = 1120,
		GammaDoppler8 = 1121,
		GammaDoppler9 = 1122,
		GammaDoppler10 = 1123,
		GreenLaminate = 1070,
		CAUTION2 = 1071,
		PrismTerrace = 1072,
		ImminentDanger = 1073,
		Schematic = 1074,
		Strats = 1075,
		Framework = 1076,
		Interlock = 1077,
		BlueTire = 1078,
		RedTire = 1079,
		Infrastructure = 1080,
		DigitalArchitect = 1081,
		FallHazard = 1082,
		BreakerBox = 1083,
		HazardPay = 1084,
		Mechanism = 1085,
		OilChange = 1086,
		FaultyWiring = 1066,
		Lore6 = 1104,
		Lore7 = 1105,
		Lore8 = 1106,
		Lore9 = 1107,
		Lore10 = 1108,
		BlackLaminate7 = 1109,
		BlackLaminate8 = 1110,
		BlackLaminate9 = 1111,
		BlackLaminate10 = 1112,
		BlackLaminate11 = 1113,
		Autotronic6 = 1114,
		Autotronic7 = 1115,
		Autotronic8 = 1116,
		Autotronic9 = 1117,
		Autotronic10 = 1118,
		LeetMuseo = 1087,
		Plague = 1088,
		BI83Spectrum = 1089,
		OceanDrive = 1090,
		Tread = 1091,
		ZXSpectron = 1092,
		BoostProtocol = 1093,
		MountFuji = 1094,
		KeepingTabs = 1095,
		Guerrilla2 = 1096,
		SpiderLily = 1097,
		Toybox = 1098,
		Lumen = 1099,
		SnackAttack = 1100,
		TurboPeek = 1101,
		BlackLotus = 1102,
		Watchdog = 1103,
	}

	enum EntityQuality
	{
		NORMAL = 0,
		GENUINE = 1,
		VINTAGE = 2,
		UNUSUAL = 3,
		UNIQUE = 4,
		COMMUNITY = 5,
		DEVELOPER = 6,
		SELFMADE = 7,
		CUSTOMIZED = 8,
		STRANGE = 9,
		COMPLETED = 10,
		HAUNTED = 11,
		TOURNAMENT = 12,
	};


	//public enum WeaponMaxAmmo
	//{
	//    DEAGLE = 7,
	//    BERETTAS = 2,
	//    FIVESEVEN = 3,
	//    GLOCK = 4,
	//    AK47 = 30,
	//    AUG = 8,
	//    AWP = 9,
	//    FAMAS = 10,
	//    G3SG1 = 11,
	//    galil = 13,
	//    M249 = 14,
	//    M4A4 = 16,
	//    MAC10 = 17,
	//    P90 = 19,
	//    MP5SD = 23,
	//    UMP45 = 24,
	//    XM1014 = 25,
	//    BIZON = 26,
	//    MAG7 = 27,
	//    NEGEV = 28,
	//    SAWEDOFF = 29,
	//    TEC9 = 30,
	//    TASER = 31,
	//    P2000 = 32,
	//    MP7 = 33,
	//    MP9 = 34,
	//    NOVA = 35,
	//    P250 = 36,
	//    SCAR20 = 38,
	//    SG556 = 39,
	//    SSG08 = 40,
	//    KNIFE = 42,
	//    FLASHBANG = 43,
	//    HEGRENADE = 44,
	//    SMOKEGRENADE = 45,
	//    MOLOTOV = 46,
	//    DECOY = 47,
	//    INCGRENADE = 48,
	//    C4 = 49,
	//    M4A1S = 60,
	//    USPS = 61,
	//    CZ75A = 63,
	//    REVOLVER = 64,
	//}

	public enum WeaponsReloadTimes
	{
		DEAGLE = 220,
		BERETTAS = 378,
		FIVESEVEN = 223,
		GLOCK = 223,
		AK47 = 244,
		AUG = 380,
		AWP = 367,
		FAMAS = 328,
		G3SG1 = 467,
		galil = 299,
		M249 = 571,
		M4A4 = 308,
		MAC10 = 258,
		P90 = 337,
		MP5SD = 297,
		UMP45 = 344,
		XM1014 = 53,
		BIZON = 244,
		MAG7 = 27,
		NEGEV = 570,
		SAWEDOFF = 55,
		TEC9 = 258,
		P2000 = 224,
		MP7 = 315,
		MP9 = 214,
		NOVA = 474,
		P250 = 223,
		SCAR20 = 308,
		SG556 = 278,
		SSG08 = 368,
		M4A1S = 308,
		USPS = 217,
		CZ75A = 273,
		REVOLVER = 228,
	}

	public enum WeaponsMaxAmmo
	{
		DEAGLE = 7,
		BERETTAS = 30,
		FIVESEVEN = 20,
		GLOCK = 20,
		AK47 = 30,
		AUG = 30,
		AWP = 10,
		FAMAS = 25,
		G3SG1 = 20,
		galil = 35,
		M249 = 100,
		M4A4 = 30,
		MAC10 = 30,
		P90 = 50,
		MP5SD = 30,
		UMP45 = 25,
		XM1014 = 7,
		BIZON = 64,
		MAG7 = 5,
		NEGEV = 150,
		SAWEDOFF = 7,
		TEC9 = 32,
		P2000 = 13,
		MP7 = 30,
		MP9 = 30,
		NOVA = 8,
		P250 = 13,
		SCAR20 = 20,
		SG556 = 30,
		SSG08 = 10,
		M4A1S = 25,
		USPS = 12,
		CZ75A = 12,
		REVOLVER = 8,
	}

	public enum Bones
	{
		Head,
		Neck,
		Chest,
		LowerChest,
		Stomach,
		Legs,
	}
}