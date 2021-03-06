using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalamityFR.JSON
{
    public class TranslationElement
    {
        public string id { get; set; }
        public string type { get; set; }
		public string? englishName { get; set; }
		public string[]? englishTooltip { get; set; }
		public string? name { get; set; }
		public string[]? tooltip { get; set; }
		public string? englishDesc { get; set; }
		public string? desc { get; set; }
		public string? state { get; set; }

		public string transformTooltip() {
            string finaltt = "";
            foreach (string tt in tooltip)
            {
                finaltt = finaltt + tt + "\n";
            }
            finaltt = finaltt.Substring(0, finaltt.Length - 1);
            return finaltt;
        }

        public static string getRaw()
        {
            return @"[
	{
		""id"": ""AbyssalWeapon"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Weapon"",
		""englishDesc"": ""Melee and rogue weapons inflict brimstone flames, 5% increased movement speed"",
		""name"": ""Arme Abyssale"",
		""desc"": ""Les armes de mêlée infligent les flammes abyssales, +5% de vitesse de mouvement"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""SnapClamDebuff"",
		""type"": ""BUFF"",
		""englishName"": ""Clammed"",
		""englishDesc"": ""Clapped by Snap Clams"",
		""name"": ""Clammé"",
		""desc"": ""Clap de Palourde"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""EvergreenGinBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Evergreen Gin"",
		""englishDesc"": ""Sickness and water debuff damage boosted, life regen reduced"",
		""name"": ""Gin Evergreen"",
		""desc"": ""La maladie, dégats et réduction des dégâts de l'altération d'eau augmentés et régénération de vie réduite"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""MarkedforDeath"",
		""type"": ""BUFF"",
		""englishName"": ""Marked for Death"",
		""englishDesc"": ""Damage reduction reduced"",
		""name"": ""Marqué"",
		""desc"": ""Réduction de dégâts réduite"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""AnechoicCoatingBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Anechoic Coating"",
		""englishDesc"": ""Abyssal creatures' detection ranges reduced"",
		""name"": ""Revêtement Anechoïque"",
		""desc"": ""Rayon de détection des créatures des abysses réduit"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""DiamondCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Diamond Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Rampant de Diamant""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""TrilobiteBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Trilobite""
		],
		""name"": ""Bannière du Rampant de Diamant"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Trilobite""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""SeaboundStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Seabound Staff"",
		""englishTooltip"": [
			""Summons a brittle star to fight for you""
		],
		""name"": ""Bâton des Mers"",
		""tooltip"": [
			""Summons a brittle star to fight for you""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""AbyssalCrate"",
		""type"": ""ITEM"",
		""englishName"": ""Abyssal Crate"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Caisse Abyssale"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""AstralCrate"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Crate"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Caisse Astrale"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""SunkenCrate"",
		""type"": ""ITEM"",
		""englishName"": ""Sunken Crate"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Caisse Coulée"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""BrimstoneCrate"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Crate"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Caisse de soufre"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""MangroveChakram"",
		""type"": ""ITEM"",
		""englishName"": ""Mangrove Chakram"",
		""englishTooltip"": [
			""Stealth strikes leave a trail of lingering flowers""
		],
		""name"": ""Chakram de la Mangrove"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""DevilsSunrise"",
		""type"": ""ITEM"",
		""englishName"": ""Devil's Sunrise"",
		""englishTooltip"": [
			""Balls? Smalls.""
		],
		""name"": ""Lever du Soleil du Diable"",
		""tooltip"": [
			""Balls? Smalls.""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""ShadowspecBar"",
		""type"": ""ITEM"",
		""englishName"": ""Shadowspec Bar"",
		""englishTooltip"": [
			""A vile, black metal, so horrendous and powerful as to defy explanation""
		],
		""name"": ""Lingot d'Ombrespec"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""AuricOre"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Ore"",
		""englishTooltip"": [
			""Laced with the dormant power of a deity""
		],
		""name"": ""Minerai Aurique"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""Phantoplasm"",
		""type"": ""ITEM"",
		""englishName"": ""Phantoplasm"",
		""englishTooltip"": [
			""It churns and seethes with ghastly malice""
		],
		""name"": ""Phantoplasme"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""StarterBag"",
		""type"": ""ITEM"",
		""englishName"": ""Starter Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac du Débutant"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""AstrumDeusBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Astrum Deus)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""HiveMindBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (The Hive Mind)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""SlimeGodBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (The Slime God)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""YharonBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Jungle Dragon, Yharon)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""RavagerBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Ravager)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""DesertScourgeBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Desert Scourge)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""CryogenBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Cryogen)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""PlaguebringerGoliathBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (The Plaguebringer Goliath)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""ProvidenceBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Providence, the Profaned Goddess)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""BrimstoneWaifuBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Brimstone Elemental)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""DevourerofGodsBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (The Devourer of Gods)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""PerforatorBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (The Perforators)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""PolterghastBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Polterghast)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""AquaticScourgeBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Aquatic Scourge)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""CrabulonBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Crabulon)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""OldDukeBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (The Old Duke)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""CalamitasBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Calamitas)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""LeviathanBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Leviathan and Anahita)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""EidolonTablet"",
		""type"": ""ITEM"",
		""englishName"": ""Eidolon Tablet"",
		""englishTooltip"": [
			""Summons the Lunatic Cultist"",
			""Not consumable""
		],
		""name"": ""Tablette Eidolon"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""ConferenceCall"",
		""type"": ""ITEM"",
		""englishName"": ""Conference Call"",
		""englishTooltip"": [
			""@everyone"",
			""50% chance to not consume ammo""
		],
		""name"": ""Tir Croisé du Conclave"",
		""tooltip"": [
			""50% de chances de ne pas consommer de munitions"",
			""Tire deux volées de balles, une depuis l'arme et l'autre depuis le ciel""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""AbyssalTreasure"",
		""type"": ""ITEM"",
		""englishName"": ""Abyssal Treasure"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Trésor Abyssal"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""SulphuricTreasure"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphuric Treasure"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Trésor Sulfurique"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A retraduire""
	},
	{
		""id"": ""BloodwormItem"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodworm"",
		""englishTooltip"": [
			""Summons The Old Duke if used as bait in the sulphur sea""
		],
		""name"": ""Ver de Sang"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""ClothiersWrath"",
		""type"": ""ITEM"",
		""englishName"": ""Clothier's Wrath"",
		""englishTooltip"": [
			""Shoots 3 shadowflame skulls""
		],
		""name"": ""Îre du Tailleur"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""EdgyBossText12"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You are no god... but I shall feast upon your essence regardless!"",
		""name"": """",
		""desc"": ""Tu n'es pas un dieu...mais peu importe, je devorerais ton essence!"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""DeathText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Death is active; enjoy the fun."",
		""name"": """",
		""desc"": ""La Mort est activée, profites bien du fun."",
		""state"": ""A retraduire""
	},
	{
		""id"": ""DeathText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Death is not active; not fun enough for you?"",
		""name"": """",
		""desc"": ""La Mort est désactivée, pas assez fun pour toi?"",
		""state"": ""A retraduire""
	},
	{
		""id"": ""AkatoBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Akato"",
		""englishDesc"": ""Looks like you'll have to take care of it now"",
		""name"": ""Akato"",
		""desc"": ""Looks like you'll have to take care of it now"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AncientMineralSharkBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Ancient Mineral Shark"",
		""englishDesc"": ""Ancient yet so dangerous"",
		""name"": ""Ancient Mineral Shark"",
		""desc"": ""Ancient yet so dangerous"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ArcherofLunamoon"",
		""type"": ""BUFF"",
		""englishName"": ""Archer of Lunamoon"",
		""englishDesc"": ""You have a personal spotter"",
		""name"": ""Archer of Lunamoon"",
		""desc"": ""You have a personal spotter"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AbandonedSlimeBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Astral Jelly"",
		""englishDesc"": ""The mini astrageldon slime will protect you"",
		""name"": ""Astral Jelly"",
		""desc"": ""The mini astrageldon slime will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BabyBloodCrawlerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Baby Blood Crawler"",
		""englishDesc"": ""The baby blood crawler will protect you"",
		""name"": ""Baby Blood Crawler"",
		""desc"": ""The baby blood crawler will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BabySlimeGodBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Baby Slime God"",
		""englishDesc"": ""The slime god will protect you"",
		""name"": ""Baby Slime God"",
		""desc"": ""The slime god will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BabyStormlionBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Baby Stormlion"",
		""englishDesc"": ""The baby stormlion will protect you"",
		""name"": ""Baby Stormlion"",
		""desc"": ""The baby stormlion will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BossEffects"",
		""type"": ""BUFF"",
		""englishName"": ""Boss Effects"",
		""englishDesc"": ""This tooltip is edited in the function below"",
		""name"": ""Boss Effects"",
		""desc"": ""This tooltip is edited in the function below"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BrimroseMount"",
		""type"": ""BUFF"",
		""englishName"": ""Brimrose Mount"",
		""englishDesc"": ""The seat is toasty.  That is all"",
		""name"": ""Brimrose Mount"",
		""desc"": ""The seat is toasty.  That is all"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BrimseekerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Brimseeker"",
		""englishDesc"": ""Does it want something from you?"",
		""name"": ""Brimseeker"",
		""desc"": ""Does it want something from you?"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CadancesGrace"",
		""type"": ""BUFF"",
		""englishName"": ""Cadance's Grace"",
		""englishDesc"": ""Your heart is pure"",
		""name"": ""Cadance's Grace"",
		""desc"": ""Your heart is pure"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ChibiiDoGBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Chibii Devourer"",
		""englishDesc"": ""What? Were you expecting someone else?"",
		""name"": ""Chibii Devourer"",
		""desc"": ""What? Were you expecting someone else?"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ClassicSCalPetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Classic Supreme Calamitas"",
		""englishDesc"": ""Her supreme powers will never be forgotten"",
		""name"": ""Classic Supreme Calamitas"",
		""desc"": ""Her supreme powers will never be forgotten"",
		""state"": ""A traduire""
	},
	{
		""id"": ""DaedalusCrystalBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Daedalus Crystal"",
		""englishDesc"": ""The daedalus crystal will protect you"",
		""name"": ""Daedalus Crystal"",
		""desc"": ""The daedalus crystal will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Dragonfire"",
		""type"": ""BUFF"",
		""englishName"": ""Dragonfire"",
		""englishDesc"": ""Losing life, reduced movement speed"",
		""name"": ""Dragonfire"",
		""desc"": ""Losing life, reduced movement speed"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Dreamfog"",
		""type"": ""BUFF"",
		""englishName"": ""Dreamfog"",
		""englishDesc"": ""Xi believes in Yuu"",
		""name"": ""Dreamfog"",
		""desc"": ""Xi believes in Yuu"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ElectricTroublemaker"",
		""type"": ""BUFF"",
		""englishName"": ""Electric Troublemaker"",
		""englishDesc"": ""Lightning never strikes the same place twice"",
		""name"": ""Electric Troublemaker"",
		""desc"": ""Lightning never strikes the same place twice"",
		""state"": ""A traduire""
	},
	{
		""id"": ""EmpyreanRage"",
		""type"": ""BUFF"",
		""englishName"": ""Empyrean Rage"",
		""englishDesc"": ""Rage of the cosmos"",
		""name"": ""Empyrean Rage"",
		""desc"": ""Rage of the cosmos"",
		""state"": ""A traduire""
	},
	{
		""id"": ""EmpyreanWrath"",
		""type"": ""BUFF"",
		""englishName"": ""Empyrean Wrath"",
		""englishDesc"": ""Wrath of the cosmos"",
		""name"": ""Empyrean Wrath"",
		""desc"": ""Wrath of the cosmos"",
		""state"": ""A traduire""
	},
	{
		""id"": ""EntropysVigilBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Entropy's Vigil"",
		""englishDesc"": ""The necromantic clones protect you with undying vigilance"",
		""name"": ""Entropy's Vigil"",
		""desc"": ""The necromantic clones protect you with undying vigilance"",
		""state"": ""A traduire""
	},
	{
		""id"": ""DoGExtremeGravity"",
		""type"": ""BUFF"",
		""englishName"": ""Extreme Gravity"",
		""englishDesc"": ""Your wing time is reduced by 25%, infinite flight is disabled"",
		""name"": ""Extreme Gravity"",
		""desc"": ""Your wing time is reduced by 25%, infinite flight is disabled"",
		""state"": ""A traduire""
	},
	{
		""id"": ""FieryDraconidBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Fiery Draconid"",
		""englishDesc"": ""The fiery draconid will protect you"",
		""name"": ""Fiery Draconid"",
		""desc"": ""The fiery draconid will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""FlakHermitBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Flak Hermit"",
		""englishDesc"": ""Little acid buggy"",
		""name"": ""Flak Hermit"",
		""desc"": ""Little acid buggy"",
		""state"": ""A traduire""
	},
	{
		""id"": ""FleshBallBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Flesh Ball"",
		""englishDesc"": ""Why is it following you?"",
		""name"": ""Flesh Ball"",
		""desc"": ""Why is it following you?"",
		""state"": ""A traduire""
	},
	{
		""id"": ""FoxPetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Fox Pet"",
		""englishDesc"": ""Fox Pet? FOX PET"",
		""name"": ""Fox Pet"",
		""desc"": ""Fox Pet? FOX PET"",
		""state"": ""A traduire""
	},
	{
		""id"": ""GammaHydraBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Gamma Hydra"",
		""englishDesc"": ""..."",
		""name"": ""Gamma Hydra"",
		""desc"": ""..."",
		""state"": ""A traduire""
	},
	{
		""id"": ""GastricAberrationBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Gastric Aberration"",
		""englishDesc"": ""The aquatic aberration will protect you"",
		""name"": ""Gastric Aberration"",
		""desc"": ""The aquatic aberration will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""GraxBoost"",
		""type"": ""BUFF"",
		""englishName"": ""Grax Boost"",
		""englishDesc"": ""Your defenses and muscles are strong"",
		""name"": ""Grax Boost"",
		""desc"": ""Your defenses and muscles are strong"",
		""state"": ""A traduire""
	},
	{
		""id"": ""HallowedRuneDefense"",
		""type"": ""BUFF"",
		""englishName"": ""Hallowed Defense"",
		""englishDesc"": ""Defense boosted by 8 and damage reduction boosted by 4%"",
		""name"": ""Hallowed Defense"",
		""desc"": ""Defense boosted by 8 and damage reduction boosted by 4%"",
		""state"": ""A traduire""
	},
	{
		""id"": ""HallowedRunePower"",
		""type"": ""BUFF"",
		""englishName"": ""Hallowed Power"",
		""englishDesc"": ""Minion damage boosted by 10%"",
		""name"": ""Hallowed Power"",
		""desc"": ""Minion damage boosted by 10%"",
		""state"": ""A traduire""
	},
	{
		""id"": ""HallowedRuneRegeneration"",
		""type"": ""BUFF"",
		""englishName"": ""Hallowed Regen"",
		""englishDesc"": ""Regenerating life"",
		""name"": ""Hallowed Regen"",
		""desc"": ""Regenerating life"",
		""state"": ""A traduire""
	},
	{
		""id"": ""HydrothermicVentBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Hydrothermic Vent"",
		""englishDesc"": ""The hydrothermic vent will protect you"",
		""name"": ""Hydrothermic Vent"",
		""desc"": ""The hydrothermic vent will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""IcarusFolly"",
		""type"": ""BUFF"",
		""englishName"": ""Icarus' Folly"",
		""englishDesc"": ""Your wing time is reduced by 33%, infinite flight is disabled"",
		""name"": ""Icarus' Folly"",
		""desc"": ""Your wing time is reduced by 33%, infinite flight is disabled"",
		""state"": ""A traduire""
	},
	{
		""id"": ""KamiFlu"",
		""type"": ""BUFF"",
		""englishName"": ""Kami Flu"",
		""englishDesc"": ""Defenseless and dying"",
		""name"": ""Kami Flu"",
		""desc"": ""Defenseless and dying"",
		""state"": ""A traduire""
	},
	{
		""id"": ""LilPlaguebringerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Lil' Plaguebringer"",
		""englishDesc"": ""The plaguebringer will protect you"",
		""name"": ""Lil' Plaguebringer"",
		""desc"": ""The plaguebringer will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CirrusBlueCandleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Limber"",
		""englishDesc"": ""The floating flame seems to uplift your very spirit"",
		""name"": ""Limber"",
		""desc"": ""The floating flame seems to uplift your very spirit"",
		""state"": ""A traduire""
	},
	{
		""id"": ""MiniMindBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Mini Mind"",
		""englishDesc"": ""It knows everything"",
		""name"": ""Mini Mind"",
		""desc"": ""It knows everything"",
		""state"": ""A traduire""
	},
	{
		""id"": ""MiniOldDukeBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Mini Old Duke"",
		""englishDesc"": ""The young duke will protect you"",
		""name"": ""Mini Old Duke"",
		""desc"": ""The young duke will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""MiniPlaguebringerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Mini Plaguebringer"",
		""englishDesc"": ""A small plague bee is following you"",
		""name"": ""Mini Plaguebringer"",
		""desc"": ""A small plague bee is following you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""MiniatureEyeofCthulhu"",
		""type"": ""BUFF"",
		""englishName"": ""Miniature Eye of Cthulhu"",
		""englishDesc"": ""It's watching you"",
		""name"": ""Miniature Eye of Cthulhu"",
		""desc"": ""It's watching you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""OceanSpiritBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Ocean Spirit"",
		""englishDesc"": ""Small and cute"",
		""name"": ""Ocean Spirit"",
		""desc"": ""Small and cute"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AquaticHeartWaterSpeed"",
		""type"": ""BUFF"",
		""englishName"": ""Ocean's Blessing"",
		""englishDesc"": ""15% increased max speed and acceleration"",
		""name"": ""Ocean's Blessing"",
		""desc"": ""15% increased max speed and acceleration"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PhantomicEmpowerment"",
		""type"": ""BUFF"",
		""englishName"": ""Phantomic Empowerment"",
		""englishDesc"": ""Empowering minion damage by 10%"",
		""name"": ""Phantomic Empowerment"",
		""desc"": ""Empowering minion damage by 10%"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PhantomicRegen"",
		""type"": ""BUFF"",
		""englishName"": ""Phantomic Regen"",
		""englishDesc"": ""Regenerating life"",
		""name"": ""Phantomic Regen"",
		""desc"": ""Regenerating life"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PhantomicShield"",
		""type"": ""BUFF"",
		""englishName"": ""Phantomic Shield"",
		""englishDesc"": ""Defense boosted by 10 and damage reduction boosted by 5%\\nAn ephemeral bulwark protects you"",
		""name"": ""Phantomic Shield"",
		""desc"": ""Defense boosted by 10 and damage reduction boosted by 5%\\nAn ephemeral bulwark protects you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CirrusPurpleCandleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Resilience"",
		""englishDesc"": ""Neither rain nor wind can snuff its undying flame"",
		""name"": ""Resilience"",
		""desc"": ""Neither rain nor wind can snuff its undying flame"",
		""state"": ""A traduire""
	},
	{
		""id"": ""RimehoundBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Rimehound"",
		""englishDesc"": ""You are riding an angry dog"",
		""name"": ""Rimehound"",
		""desc"": ""You are riding an angry dog"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SarosPossessionBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Saros Possession"",
		""englishDesc"": ""A radiant aura protects you"",
		""name"": ""Saros Possession"",
		""desc"": ""A radiant aura protects you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SeaSnailBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Sea Snail"",
		""englishDesc"": ""Meow?"",
		""name"": ""Sea Snail"",
		""desc"": ""Meow?"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SearingLava"",
		""type"": ""BUFF"",
		""englishName"": ""Searing Lava"",
		""englishDesc"": ""The brimstone lava sears your flesh"",
		""name"": ""Searing Lava"",
		""desc"": ""The brimstone lava sears your flesh"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ShellfishClaps"",
		""type"": ""BUFF"",
		""englishName"": ""Shellfish Claps"",
		""englishDesc"": ""Clamfest"",
		""name"": ""Shellfish Claps"",
		""desc"": ""Clamfest"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SilvaCrystalBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Silva Crystal"",
		""englishDesc"": ""The crystal will protect you"",
		""name"": ""Silva Crystal"",
		""desc"": ""The crystal will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SkeletalDragonsBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Skeletal Dragons"",
		""englishDesc"": ""Big happy family"",
		""name"": ""Skeletal Dragons"",
		""desc"": ""Big happy family"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SmallSkeletonBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Small Skeleton"",
		""englishDesc"": ""A skeleton is observing you"",
		""name"": ""Small Skeleton"",
		""desc"": ""A skeleton is observing you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SolarGodSpiritBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Solar God Spirit"",
		""englishDesc"": ""The solar god spirit will protect you"",
		""name"": ""Solar God Spirit"",
		""desc"": ""The solar god spirit will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SpiritDefense"",
		""type"": ""BUFF"",
		""englishName"": ""Spirit Defense"",
		""englishDesc"": ""Defense boosted by 6 and damage reduction boosted by 3%"",
		""name"": ""Spirit Defense"",
		""desc"": ""Defense boosted by 6 and damage reduction boosted by 3%"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SpiritPower"",
		""type"": ""BUFF"",
		""englishName"": ""Spirit Power"",
		""englishDesc"": ""Minion damage boosted by 10%"",
		""name"": ""Spirit Power"",
		""desc"": ""Minion damage boosted by 10%"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SpiritRegen"",
		""type"": ""BUFF"",
		""englishName"": ""Spirit Regen"",
		""englishDesc"": ""Regenerating life"",
		""name"": ""Spirit Regen"",
		""desc"": ""Regenerating life"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CirrusYellowCandleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Spite"",
		""englishDesc"": ""Its hateful glow flickers with ire"",
		""name"": ""Spite"",
		""desc"": ""Its hateful glow flickers with ire"",
		""state"": ""A traduire""
	},
	{
		""id"": ""TheCartofGodsBuff"",
		""type"": ""BUFF"",
		""englishName"": ""The Cart of Gods"",
		""englishDesc"": ""Riding a cosmic terror"",
		""name"": ""The Cart of Gods"",
		""desc"": ""Riding a cosmic terror"",
		""state"": ""A traduire""
	},
	{
		""id"": ""TimeDistortion"",
		""type"": ""BUFF"",
		""englishName"": ""Time Distortion"",
		""englishDesc"": ""Time is slowed"",
		""name"": ""Time Distortion"",
		""desc"": ""Time is slowed"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ValkyrieBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Valkyrie"",
		""englishDesc"": ""The valkyrie will protect you"",
		""name"": ""Valkyrie"",
		""desc"": ""The valkyrie will protect you"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CirrusPinkCandleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Vigor"",
		""englishDesc"": ""Its brilliant light suffuses those nearby with hope"",
		""name"": ""Vigor"",
		""desc"": ""Its brilliant light suffuses those nearby with hope"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ViriliBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Virili"",
		""englishDesc"": ""Unfortunately for you, she's quite contagious"",
		""name"": ""Virili"",
		""desc"": ""Unfortunately for you, she's quite contagious"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AquaticHeartBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Water Elemental"",
		""englishDesc"": ""You are a water elemental now"",
		""name"": ""Water Elemental"",
		""desc"": ""You are a water elemental now"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AquaticUrchinBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Urchin""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Urchin""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PhantomSpiritBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Phantom Spirit""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Phantom Spirit""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""LuminousCorvinaBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Luminous Corvina""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Luminous Corvina""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AstralSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astral Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astral Slime""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EbonianBlightSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ebonian Blight Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ebonian Blight Slime""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ShockstormShuttleBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Shockstorm Shuttle""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Shockstorm Shuttle""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AtlasBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Atlas Banner""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Atlas Banner""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WulfrumRoverBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Rover""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Rover""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ScryllarBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Scryllar""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Scryllar""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""IrradiatedSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Irradiated Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Irradiated Slime""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""OarfishBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Oarfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Oarfish""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BelchingCoralBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Belching Coral""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Belching Coral""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CrystalCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Crystal Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Crystal Crawler""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PlagueChargerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plague Charger""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plague Charger""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FearlessGoldfishWarriorBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Fearless Goldfish Warrior""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Fearless Goldfish Warrior""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SeaUrchinBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Urchin""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Urchin""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ClamBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Clam""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Clam""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""NuclearToadBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Nuclear Toad""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Nuclear Toad""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DespairStoneBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Despair Stone""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Despair Stone""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ViperfishBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Viperfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Viperfish""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ArmoredDiggerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Armored Digger""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Armored Digger""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water, honey, and lava source""
		],
		""name"": """",
		""tooltip"": [
			""Counts as a water, honey, and lava source""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""OtherworldlySink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": """",
		""tooltip"": [
			""Counts as a water source""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FlakCrabBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Flak Crab""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Flak Crab""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ProfanedCrucible"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": """",
		""tooltip"": [
			""Used for special crafting""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ImpiousImmolatorBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Impious Immolator""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Impious Immolator""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ToxicMinnowBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Toxic Minnow""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Toxic Minnow""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CrimulanBlightSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Crimulan Blight Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Crimulan Blight Slime""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AcidEelBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Acid Eel""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Acid Eel""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AstralProbeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astral Probe""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astral Probe""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TopazCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Topaz Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Topaz Crawler""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CryonBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cryon""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cryon""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MorayEelBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Moray Eel""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Moray Eel""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StormlionBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Stormlion""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Stormlion""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AeroSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aero Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aero Slime""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GiantSquidBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Giant Squid""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Giant Squid""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PiggyBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Piggy""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Piggy""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""LaserfishBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Laserfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Laserfish""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MantisShrimpBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mantis Shrimp""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mantis Shrimp""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GulperEelBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gulper Eel""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gulper Eel""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SoulSlurperBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Soul Slurper""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Soul Slurper""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BlindedAnglerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Blinded Angler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Blinded Angler""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EidolistBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Eidolist""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Eidolist""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MelterBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Melter""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Melter""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MonolithAmalgam"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": """",
		""tooltip"": [
			""Used for special crafting""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ScornEaterBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Scorn Eater""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Scorn Eater""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BobbitWormBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bobbit Worm""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bobbit Worm""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PlaguebringerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plaguebringer""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plaguebringer""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EutrophicRayBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Eutrophic Ray""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Eutrophic Ray""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WaterLeechBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Water Leech""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Water Leech""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AstralachneaBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astralachnea""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astralachnea""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PlagueshellBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plagueshell""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plagueshell""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FlounderBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Flounder""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Flounder""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""OrthoceraBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Orthocera""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Orthocera""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SunskaterBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sunskater""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sunskater""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MirageJellyBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mirage Jelly""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mirage Jelly""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CultistAssassinBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cultist Assassin""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cultist Assassin""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CharredSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Charred Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Charred Slime""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MantisBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mantis""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mantis""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SeaMinnowBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Minnow""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Minnow""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EutrophicShelf"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": """",
		""tooltip"": [
			""Used for special crafting""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RadiatorBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Radiator""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Radiator""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PestilentSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Pestilent Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Pestilent Slime""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SmallSightseerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Small Sightseer""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Small Sightseer""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CloudElementalBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cloud Elemental""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cloud Elemental""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SeaFloatyBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Floaty""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Floaty""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StellarCulexBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Stellar Culex""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Stellar Culex""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BigSightseerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Big Sightseer""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Big Sightseer""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GreatSandSharkBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Great Sand Shark""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Great Sand Shark""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AmethystCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus} Amethyst Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus} Amethyst Crawler""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TrasherBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Trasher""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Trasher""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HiveBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Hive""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Hive""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WulfrumGyratorBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Gyrator""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Gyrator""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ReaperSharkBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Reaper Shark""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Reaper Shark""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BloatfishBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bloatfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bloatfish""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VirulingBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Viruling""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Viruling""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ProfanedEnergyBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Profaned Energy""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Profaned Energy""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CalamityEyeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Calamity Eye""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Calamity Eye""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GammaSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gamma Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gamma Slime""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CatfishBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Catfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Catfish""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CryoSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cryo Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cryo Slime""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AquaticAberrationBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Aberration""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Aberration""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CosmicElementalBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cosmic Elemental""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cosmic Elemental""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EarthElementalBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Earth Elemental""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Earth Elemental""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CnidrionBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cnidrion""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cnidrion""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BoxJellyfishBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Box Jellyfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Box Jellyfish""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EmeraldCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Emerald Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Emerald Crawler""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GnasherBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gnasher""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gnasher""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AriesBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aries""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aries""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ChaoticPufferBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Chaotic Puffer""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Chaotic Puffer""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WulfrumDroneBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Drone""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Drone""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WulfrumHovercraftBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Hovercraft""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Hovercraft""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ColossalSquidBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Colossal Squid""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Colossal Squid""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FrogfishBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Frogfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Frogfish""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SapphireCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sapphire Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sapphire Crawler""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MaulerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mauler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mauler""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AnthozoanCrabBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Anthozoan Crab""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Anthozoan Crab""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""OverloadedSoldierBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Overloaded Soldier""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Overloaded Soldier""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FusionFeederBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Fusion Feeder""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Fusion Feeder""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""NovaBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Nova""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Nova""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EidolonWyrmJuvenileBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Juvenile Eidolon Wyrm""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Juvenile Eidolon Wyrm""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WulfrumPylonBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Pylon""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Pylon""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""IceClasperBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ice Clasper""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ice Clasper""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PerennialSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Perennial Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Perennial Slime""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HeatSpiritBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Heat Spirit""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Heat Spirit""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RubyCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ruby Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ruby Crawler""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SeaSerpentBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Serpent""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Serpent""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GiantClamBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Giant Clam""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Giant Clam""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SkyfinBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Skyfin""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Skyfin""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CuttlefishBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cuttlefish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cuttlefish""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BloomSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bloom Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bloom Slime""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Abombination"",
		""type"": ""ITEM"",
		""englishName"": ""Abombination"",
		""englishTooltip"": [
			""Calls in the airborne abomination"",
			""Summons the Plaguebringer Goliath when used in the jungle"",
			""Not consumable""
		],
		""name"": ""Abombination"",
		""tooltip"": [
			""Calls in the airborne abomination"",
			""Summons the Plaguebringer Goliath when used in the jungle"",
			""Not consumable""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AccelerationRound"",
		""type"": ""ITEM"",
		""englishName"": ""Acceleration Round"",
		""englishTooltip"": [
			""Gains speed over time""
		],
		""name"": ""Acceleration Round"",
		""tooltip"": [
			""Gains speed over time""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AcesApronOfAffection"",
		""type"": ""ITEM"",
		""englishName"": ""Ace's Apron of Affection"",
		""englishTooltip"": [
			""Great for hugging people""
		],
		""name"": ""Ace's Apron of Affection"",
		""tooltip"": [
			""Great for hugging people""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AcidRound"",
		""type"": ""ITEM"",
		""englishName"": ""Acid Round"",
		""englishTooltip"": [
			""Explodes into acid that inflicts the plague"",
			""Does more damage the higher the target's defense""
		],
		""name"": ""Acid Round"",
		""tooltip"": [
			""Explodes into acid that inflicts the plague"",
			""Does more damage the higher the target's defense""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AdamantiteParticleAccelerator"",
		""type"": ""ITEM"",
		""englishName"": ""Adamantite Particle Accelerator"",
		""englishTooltip"": [
			""Charges and fires 2 beams of opposite polarities. Hitting with the opposite polarity increases the damage""
		],
		""name"": ""Adamantite Particle Accelerator"",
		""tooltip"": [
			""Charges and fires 2 beams of opposite polarities. Hitting with the opposite polarity increases the damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AetherfluxCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Aetherflux Cannon"",
		""englishTooltip"": [
			""Fires a barrage of phased god rays that pass through terrain""
		],
		""name"": ""Aetherflux Cannon"",
		""tooltip"": [
			""Fires a barrage of phased god rays that pass through terrain""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AltarOfTheAccursedItem"",
		""type"": ""ITEM"",
		""englishName"": ""Altar of the Accursed"",
		""englishTooltip"": [
			""Offer Ashes of Calamity at this altar to summon the Witch"",
			""Doing so will create a square arena of blocks, with the altar at its center"",
			""During the battle, heart pickups only heal for half as much""
		],
		""name"": ""Altar of the Accursed"",
		""tooltip"": [
			""Offer Ashes of Calamity at this altar to summon the Witch"",
			""Doing so will create a square arena of blocks, with the altar at its center"",
			""During the battle, heart pickups only heal for half as much""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AnahitasArpeggio"",
		""type"": ""ITEM"",
		""englishName"": ""Anahita's Arpeggio"",
		""englishTooltip"": [
			""Casts slow-moving treble clefs that confuse enemies""
		],
		""name"": ""Anahita's Arpeggio"",
		""tooltip"": [
			""Casts slow-moving treble clefs that confuse enemies""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AntiMaterielRifle"",
		""type"": ""ITEM"",
		""englishName"": ""Anti-materiel Rifle"",
		""englishTooltip"": [
			""Converts musket balls into .50 caliber sniper rounds that rip apart enemy defense and DR"",
			""If you crit the target a second swarm of bullets will fire""
		],
		""name"": ""Anti-materiel Rifle"",
		""tooltip"": [
			""Converts musket balls into .50 caliber sniper rounds that rip apart enemy defense and DR"",
			""If you crit the target a second swarm of bullets will fire""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AquaticHeart"",
		""type"": ""ITEM"",
		""englishName"": ""Aquatic Heart"",
		""englishTooltip"": [
			""Transforms the holder into a water elemental"",
			""Going underwater gives you a buff"",
			""Greatly reduces breath loss and provides a small amount of light in the abyss"",
			""Enemies become frozen when they touch you"",
			""You have a layer of ice around you that absorbs 20% damage but breaks after one hit"",
			""After 30 seconds the ice shield will regenerate"",
			""Wow, you can swim now!"",
			""Most of these effects are only active after Skeletron has been defeated""
		],
		""name"": ""Aquatic Heart"",
		""tooltip"": [
			""Transforms the holder into a water elemental"",
			""Going underwater gives you a buff"",
			""Greatly reduces breath loss and provides a small amount of light in the abyss"",
			""Enemies become frozen when they touch you"",
			""You have a layer of ice around you that absorbs 20% damage but breaks after one hit"",
			""After 30 seconds the ice shield will regenerate"",
			""Wow, you can swim now!"",
			""Most of these effects are only active after Skeletron has been defeated""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AquaticScourgeRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Aquatic Scourge Relic"",
		""name"": ""Aquatic Scourge Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AshesofAnnihilation"",
		""type"": ""ITEM"",
		""englishName"": ""Ashes of Annihilation"",
		""englishTooltip"": [
			""The smoldering essence of the Witch's wrath""
		],
		""name"": ""Ashes of Annihilation"",
		""tooltip"": [
			""The smoldering essence of the Witch's wrath""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AshesofCalamity"",
		""type"": ""ITEM"",
		""englishName"": ""Ashes of Calamity"",
		""name"": ""Ashes of Calamity"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AstrumAureusMask"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Aureus Mask"",
		""name"": ""Astrum Aureus Mask"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AstrumAureusRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Aureus Relic"",
		""name"": ""Astrum Aureus Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AstrumAureusTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Aureus Trophy"",
		""name"": ""Astrum Aureus Trophy"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AstrumDeusRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Deus Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Astrum Deus Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AureateBooster"",
		""type"": ""ITEM"",
		""englishName"": ""Aureate Booster"",
		""englishTooltip"": [
			""Mach speed with style!"",
			""Horizontal speed: 8.00"",
			""Acceleration multiplier: 1.5"",
			""Good vertical speed"",
			""Flight time: 120""
		],
		""name"": ""Aureate Booster"",
		""tooltip"": [
			""Mach speed with style!"",
			""Horizontal speed: 8.00"",
			""Acceleration multiplier: 1.5"",
			""Good vertical speed"",
			""Flight time: 120""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AureusCell"",
		""type"": ""ITEM"",
		""englishName"": ""Aureus Cell"",
		""englishTooltip"": [
			""Grants increased mana regeneration and magic power""
		],
		""name"": ""Aureus Cell"",
		""tooltip"": [
			""Grants increased mana regeneration and magic power""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AuricTeslaRoyalHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Royal Helm"",
		""englishTooltip"": [
			""20% increased melee damage and critical strike chance""
		],
		""name"": ""Auric Tesla Royal Helm"",
		""tooltip"": [
			""20% increased melee damage and critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AxeofPurity"",
		""type"": ""ITEM"",
		""englishName"": ""Axe of Purity"",
		""englishTooltip"": [
			""Left click to use as a tool"",
			""Right click to cleanse evil""
		],
		""name"": ""Axe of Purity"",
		""tooltip"": [
			""Left click to use as a tool"",
			""Right click to cleanse evil""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BabyFlakCrabItem"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Flak Crab"",
		""name"": ""Baby Flak Crab"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BabyFlakCrabBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Flak Crab Banner"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Baby Flak Crab""
		],
		""name"": ""Baby Flak Crab Banner"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Baby Flak Crab""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BabyFlakCrabCage"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Flak Crab Cage"",
		""name"": ""Baby Flak Crab Cage"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BabyGhostBellBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Ghost Bell Banner"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Baby Ghost Bell""
		],
		""name"": ""Baby Ghost Bell Banner"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Baby Ghost Bell""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BearsEye"",
		""type"": ""ITEM"",
		""englishName"": ""Bear's Eye"",
		""englishTooltip"": [
			""Summons a pet guardian angel""
		],
		""name"": ""Bear's Eye"",
		""tooltip"": [
			""Summons a pet guardian angel""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Biofusillade"",
		""type"": ""ITEM"",
		""englishName"": ""Biofusillade"",
		""englishTooltip"": [
			""Unleashes a concentrated beam of life energy""
		],
		""name"": ""Biofusillade"",
		""tooltip"": [
			""Unleashes a concentrated beam of life energy""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BlightSpewer"",
		""type"": ""ITEM"",
		""englishName"": ""Blight Spewer"",
		""name"": ""Blight Spewer"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BlightedGel"",
		""type"": ""ITEM"",
		""englishName"": ""Blighted Gel"",
		""name"": ""Blighted Gel"",
		""state"": ""A traduire""
	},
	{
		""id"": ""RevengeanceModeItem"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Fountain of Revengeance"",
		""englishTooltip"": [
			""Enables/disables Revengeance Mode, can only be used in Expert Mode."",
			""RAGE TOOLTIP LINE HERE"",
			""You gain Rage when in proximity of enemies or by using special items."",
			""ADRENALINE TOOLTIP LINE HERE"",
			""You gain Adrenaline whenever a boss is alive. Getting hit drops Adrenaline back to 0."",
			""Getting hit while Adrenaline is maxed will reduce damage taken by a massive amount."",
			""All enemies spawn 15% more frequently."",
			""Certain non-boss enemies and projectiles deal between 10% and 25% more damage."",
			""Makes certain enemies block life steal and nerfs the effectiveness of life steal."",
			""Nerfs the effectiveness of the Hallowed Armor set bonus."",
			""All boss minions no longer drop hearts."",
			""Changes all boss AIs and some enemy AIs."",
			""Increases the health and damage of all bosses.""
		],
		""name"": ""Blood Fountain of Revengeance"",
		""tooltip"": [
			""Enables/disables Revengeance Mode, can only be used in Expert Mode."",
			""RAGE TOOLTIP LINE HERE"",
			""You gain Rage when in proximity of enemies or by using special items."",
			""ADRENALINE TOOLTIP LINE HERE"",
			""You gain Adrenaline whenever a boss is alive. Getting hit drops Adrenaline back to 0."",
			""Getting hit while Adrenaline is maxed will reduce damage taken by a massive amount."",
			""All enemies spawn 15% more frequently."",
			""Certain non-boss enemies and projectiles deal between 10% and 25% more damage."",
			""Makes certain enemies block life steal and nerfs the effectiveness of life steal."",
			""Nerfs the effectiveness of the Hallowed Armor set bonus."",
			""All boss minions no longer drop hearts."",
			""Changes all boss AIs and some enemy AIs."",
			""Increases the health and damage of all bosses.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BloodflareHeadRanged"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Horned Helm"",
		""englishTooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""10% increased ranged damage and critical strike chance""
		],
		""name"": ""Bloodflare Horned Helm"",
		""tooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""10% increased ranged damage and critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BloodflareHeadMagic"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Hydra Hood"",
		""englishTooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""20% increased magic damage, 10% increased magic critical strike chance, +100 max mana and 17% reduced mana usage""
		],
		""name"": ""Bloodflare Hydra Hood"",
		""tooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""20% increased magic damage, 10% increased magic critical strike chance, +100 max mana and 17% reduced mana usage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BloodflareHeadRogue"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Imp Mask"",
		""englishTooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""10% increased rogue damage and critical strike chance, 5% increased movement speed""
		],
		""name"": ""Bloodflare Imp Mask"",
		""tooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""10% increased rogue damage and critical strike chance, 5% increased movement speed""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BloodflareHeadMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Ram Mask"",
		""englishTooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""10% increased melee damage and critical strike chance""
		],
		""name"": ""Bloodflare Ram Mask"",
		""tooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""10% increased melee damage and critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BloodflareHeadSummon"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Wyvern Helm"",
		""englishTooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""5% increased minion damage""
		],
		""name"": ""Bloodflare Wyvern Helm"",
		""tooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""5% increased minion damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BohldohrBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Bohldohr Banner"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bohldohr""
		],
		""name"": ""Bohldohr Banner"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bohldohr""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BrimstoneElementalRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Elemental Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Brimstone Elemental Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BrimstoneSword"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Sword"",
		""englishTooltip"": [
			""Summons brimstone geysers on hit"",
			""Right click to throw like a javelin that explodes on hit""
		],
		""name"": ""Brimstone Sword"",
		""tooltip"": [
			""Summons brimstone geysers on hit"",
			""Right click to throw like a javelin that explodes on hit""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BrokenBiomeBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Broken Biome Blade"",
		""englishTooltip"": [
			""FUNCTION_DESC"",
			""Hold down RMB while standing still on flat ground to attune the weapon to the powers of the surrounding biome"",
			""Using RMB otherwise switches between the current attunement and an extra stored one"",
			""Main Attunement : [None]"",
			""Secondary Attunement: [None]""
		],
		""name"": ""Broken Biome Blade"",
		""tooltip"": [
			""FUNCTION_DESC"",
			""Hold down RMB while standing still on flat ground to attune the weapon to the powers of the surrounding biome"",
			""Using RMB otherwise switches between the current attunement and an extra stored one"",
			""Main Attunement : [None]"",
			""Secondary Attunement: [None]""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""BrokenPlaguedBed"",
		""type"": ""ITEM"",
		""englishName"": ""Broken Plagued 'Bed'"",
		""name"": ""Broken Plagued 'Bed'"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CadancePotion"",
		""type"": ""ITEM"",
		""englishName"": ""Cadance Potion"",
		""englishTooltip"": [
			""Grants Cadance's Grace, which increases life regeneration and heart pickup range"",
			""Increases max life by 25%"",
			""While this potion's buff is active, Regeneration Potion and Lifeforce Potion buffs are disabled""
		],
		""name"": ""Cadance Potion"",
		""tooltip"": [
			""Grants Cadance's Grace, which increases life regeneration and heart pickup range"",
			""Increases max life by 25%"",
			""While this potion's buff is active, Regeneration Potion and Lifeforce Potion buffs are disabled""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CalamitasCloneRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitas Clone Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Calamitas Clone Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CalamitasRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitas Relic"",
		""name"": ""Calamitas Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CeaselessVoidRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Ceaseless Void Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Ceaseless Void Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CelestialOnion"",
		""type"": ""ITEM"",
		""englishName"": ""Celestial Onion"",
		""englishTooltip"": [
			""Alien power pulses inside its layers"",
			""Consuming it does something that cannot be reversed"",
			""This item does nothing in Master Mode""
		],
		""name"": ""Celestial Onion"",
		""tooltip"": [
			""Alien power pulses inside its layers"",
			""Consuming it does something that cannot be reversed"",
			""This item does nothing in Master Mode""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CelestialRemains"",
		""type"": ""ITEM"",
		""englishName"": ""Celestial Remains"",
		""name"": ""Celestial Remains"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CelestialRemainsWall"",
		""type"": ""ITEM"",
		""englishName"": ""Celestial Remains Wall"",
		""name"": ""Celestial Remains Wall"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CeremonialUrn"",
		""type"": ""ITEM"",
		""englishName"": ""Ceremonial Urn"",
		""englishTooltip"": [
			""Use at the Altar of the Accursed to summon Supreme Calamitas"",
			""Not consumable""
		],
		""name"": ""Ceremonial Urn"",
		""tooltip"": [
			""Use at the Altar of the Accursed to summon Supreme Calamitas"",
			""Not consumable""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Condemnation"",
		""type"": ""ITEM"",
		""englishName"": ""Condemnation"",
		""englishTooltip"": [
			""Fires powerful scarlet bolts suffused with hateful magics"",
			""Hold left click to load up to eight bolts for powerful burst fire"",
			""Hold right click to use the repeater full auto""
		],
		""name"": ""Condemnation"",
		""tooltip"": [
			""Fires powerful scarlet bolts suffused with hateful magics TOTRANSLATE"",
			""Hold left click to load up to eight bolts for powerful burst fire"",
			""Hold right click to use the repeater full auto""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ContinentalGreatbow"",
		""type"": ""ITEM"",
		""englishName"": ""Continental Greatbow"",
		""englishTooltip"": [
			""Wooden arrows are set alight with fire"",
			""Fires 3 arrows at once"",
			""Fires 2 additional cursed, hellfire, or ichor arrows""
		],
		""name"": ""Continental Greatbow"",
		""tooltip"": [
			""Wooden arrows are set alight with fire"",
			""Fires 3 arrows at once"",
			""Fires 2 additional cursed, hellfire, or ichor arrows""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CoreofSunlight"",
		""type"": ""ITEM"",
		""englishName"": ""Core of Sunlight"",
		""name"": ""Core of Sunlight"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CosmicAnvilItem"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmic Anvil"",
		""englishTooltip"": [
			""An otherworldly anvil capable of withstanding the pressures of stellar collapse"",
			""Also functions as every previous tier of anvil""
		],
		""name"": ""Cosmic Anvil"",
		""tooltip"": [
			""An otherworldly anvil capable of withstanding the pressures of stellar collapse TOTRANSLATE"",
			""Also functions as every previous tier of anvil""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CosmiliteDye"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmilite Dye"",
		""name"": ""Cosmilite Dye"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CrabulonRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Crabulon Relic"",
		""name"": ""Crabulon Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CragmawMireRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Cragmaw Mire Relic"",
		""name"": ""Cragmaw Mire Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CryogenRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Cryogen Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Cryogen Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CryonicBar"",
		""type"": ""ITEM"",
		""englishName"": ""Cryonic Bar"",
		""name"": ""Cryonic Bar"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CryonicDye"",
		""type"": ""ITEM"",
		""englishName"": ""Cryonic Dye"",
		""name"": ""Cryonic Dye"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CyanSeekingMechanism"",
		""type"": ""ITEM"",
		""englishName"": ""Cyan Seeking Mechanism"",
		""englishTooltip"": [
			""Moves swiftly towards a lab deep below the desert""
		],
		""name"": ""Cyan Seeking Mechanism"",
		""tooltip"": [
			""Moves swiftly towards a lab deep below the desert TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DaawnlightSpiritOrigin"",
		""type"": ""ITEM"",
		""englishName"": ""Daawnlight Spirit Origin"",
		""englishTooltip"": [
			""All nearby enemies and bosses are marked with bullseyes"",
			""Ranged attacks that strike a bullseye always critically strike and deal massive damage"",
			""When a bullseye is struck, it vanishes and a new one appears elsewhere"",
			""Explosions or large projectiles cannot strike bullseyes"",
			""Converts all ranged critical strike chance boosts into extra critical strike damage"",
			""All ranged weapons will deal even more critical strike damage the slower they are"",
			""Summons a heroic spirit from another world if accessory visibility is enabled"",
			""The heroic spirit is also summoned when this accessory is placed in vanity slots"",
			""'A strand of a lost cosmos remains, waiting for its master'""
		],
		""name"": ""Daawnlight Spirit Origin"",
		""tooltip"": [
			""All nearby enemies and bosses are marked with bullseyes TOTRANSLATE"",
			""Ranged attacks that strike a bullseye always critically strike and deal massive damage"",
			""When a bullseye is struck, it vanishes and a new one appears elsewhere"",
			""Explosions or large projectiles cannot strike bullseyes"",
			""Converts all ranged critical strike chance boosts into extra critical strike damage"",
			""All ranged weapons will deal even more critical strike damage the slower they are"",
			""Summons a heroic spirit from another world if accessory visibility is enabled"",
			""'A strand of a lost cosmos remains, waiting for its master'""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DaedalusHeadRogue"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Facemask"",
		""englishTooltip"": [
			""13% increased rogue damage and 7% increased rogue critical strike chance, increases rogue velocity by 15%"",
			""5% increased movement speed""
		],
		""name"": ""Daedalus Facemask"",
		""tooltip"": [
			""13% increased rogue damage and 7% increased rogue critical strike chance, increases rogue velocity by 15%"",
			""5% increased movement speed""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DaedalusGolemStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Golem Staff"",
		""englishTooltip"": [
			""Summons a Daedalus Golem soldier that fires pellets and electricity"",
			""Shining god of greed""
		],
		""name"": ""Daedalus Golem Staff"",
		""tooltip"": [
			""Summons a Daedalus Golem soldier that fires pellets and electricity TOTRANSLATE"",
			""Shining god of greed""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DaedalusHeadRanged"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Headgear"",
		""englishTooltip"": [
			""13% increased ranged damage and 7% increased ranged critical strike chance"",
			""Reduces ammo usage by 20%""
		],
		""name"": ""Daedalus Headgear"",
		""tooltip"": [
			""13% increased ranged damage and 7% increased ranged critical strike chance"",
			""Reduces ammo usage by 20%""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DaedalusHeadMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Helm"",
		""englishTooltip"": [
			""10% increased melee damage and critical strike chance"",
			""15% increased melee speed""
		],
		""name"": ""Daedalus Helm"",
		""tooltip"": [
			""10% increased melee damage and critical strike chance"",
			""15% increased melee speed""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DaedalusHeadMagic"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Hood"",
		""englishTooltip"": [
			""13% increased magic damage and 7% increased magic critical strike chance"",
			""10% decreased mana usage and +60 max mana""
		],
		""name"": ""Daedalus Hood"",
		""tooltip"": [
			""13% increased magic damage and 7% increased magic critical strike chance"",
			""10% decreased mana usage and +60 max mana""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DaedalusHeadSummon"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Mask"",
		""englishTooltip"": [
			""5% increased minion damage""
		],
		""name"": ""Daedalus Mask"",
		""tooltip"": [
			""5% increased minion damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DeadshotBrooch"",
		""type"": ""ITEM"",
		""englishName"": ""Deadshot Brooch"",
		""englishTooltip"": [
			""10% increased ranged damage, 5% increased ranged critical strike chance and 20% reduced ammo usage"",
			""Greatly increases all ranged projectile velocity""
		],
		""name"": ""Deadshot Brooch"",
		""tooltip"": [
			""10% increased ranged damage, 5% increased ranged critical strike chance and 20% reduced ammo usage"",
			""Greatly increases all ranged projectile velocity""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DeathValleyDuster"",
		""type"": ""ITEM"",
		""englishName"": ""Death Valley Duster"",
		""englishTooltip"": [
			""Casts a large blast of dust""
		],
		""name"": ""Death Valley Duster"",
		""tooltip"": [
			""Casts a large blast of dust""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DeathWhistle"",
		""type"": ""ITEM"",
		""englishName"": ""Death Whistle"",
		""englishTooltip"": [
			""A very old temple whistle"",
			""Summons the Ravager"",
			""Not consumable""
		],
		""name"": ""Death Whistle"",
		""tooltip"": [
			""A very old temple whistle"",
			""Summons the Ravager"",
			""Not consumable""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DeathstareRod"",
		""type"": ""ITEM"",
		""englishName"": ""Deathstare Rod"",
		""englishTooltip"": [
			""Summons an eye above your head that watches you and shoots at enemies"",
			""There can only be one eye""
		],
		""name"": ""Deathstare Rod"",
		""tooltip"": [
			""Summons an eye above your head that watches you and shoots at enemies TOTRANSLATE"",
			""There can only be one eye""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DecryptionComputer"",
		""type"": ""ITEM"",
		""englishName"": ""Decryption Computer"",
		""englishTooltip"": [
			""Can be placed on the Codebreaker"",
			""Allows you to decrypt advanced schematics"",
			""Doing so allows you to learn how to craft new things""
		],
		""name"": ""Decryption Computer"",
		""tooltip"": [
			""Can be placed on the Codebreaker TOTRANSLATE"",
			""Allows you to decrypt advanced schematics"",
			""Doing so allows you to learn how to craft new things""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DepthCrusher"",
		""type"": ""ITEM"",
		""englishName"": ""Depth Crusher"",
		""englishTooltip"": [
			""Hitting enemies will inflict the crush depth debuff"",
			""The lower the enemies' defense, the more damage they take from this debuff"",
			""Right click to use without hammering down walls""
		],
		""name"": ""Depth Crusher"",
		""tooltip"": [
			""Hitting enemies will inflict the crush depth debuff"",
			""The lower the enemies' defense, the more damage they take from this debuff"",
			""Right click to use without hammering down walls""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DesertMedallion"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Medallion"",
		""englishTooltip"": [
			""Summons the Desert Scourge when used in the desert"",
			""Not consumable""
		],
		""name"": ""Desert Medallion"",
		""tooltip"": [
			""Summons the Desert Scourge when used in the desert"",
			""Not consumable""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DesertScourgeRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Scourge Relic"",
		""name"": ""Desert Scourge Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""DevourerOfGodsRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Devourer of Gods Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Devourer of Gods Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Disseminator"",
		""type"": ""ITEM"",
		""englishName"": ""Disseminator"",
		""englishTooltip"": [
			""@everyone"",
			""50% chance to not consume ammo""
		],
		""name"": ""Disseminator"",
		""tooltip"": [
			""@everyone"",
			""50% chance to not consume ammo""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonMask"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon Mask"",
		""name"": ""Draedon Mask"",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonPowerCell"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon Power Cell"",
		""englishTooltip"": [
			""Used to charge Draedon's weaponry at a Charging Station"",
			""Also can be processed by the Extractinator for spare parts""
		],
		""name"": ""Draedon Power Cell"",
		""tooltip"": [
			""Used to charge Draedon's weaponry at a Charging Station"",
			""Also can be processed by the Extractinator for spare parts""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon Relic"",
		""name"": ""Draedon Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""DragonfollyRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Dragonfolly Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Dragonfolly Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DragonfollyTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Dragonfolly Trophy"",
		""name"": ""Dragonfolly Trophy"",
		""state"": ""A traduire""
	},
	{
		""id"": ""EidolonStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Eidolon Staff"",
		""englishTooltip"": [
			""The power of an ancient cultist resonates within this staff"",
			""Fires a spread of ancient light and has a chance to fire a spinning ice cluster""
		],
		""name"": ""Eidolon Staff"",
		""tooltip"": [
			""The power of an ancient cultist resonates within this staff"",
			""Fires a spread of ancient light and has a chance to fire a spinning ice cluster""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ElementalDisk"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Disk"",
		""englishTooltip"": [
			""Throws a disk that has a chance to generate several disks if enemies are near it"",
			""Stealth strikes fly slower but travel farther, pierce through enemies, and spawn extra disks more frequently""
		],
		""name"": ""Elemental Disk"",
		""tooltip"": [
			""Throws a disk that has a chance to generate several disks if enemies are near it"",
			""Stealth strikes fly slower but travel farther, pierce through enemies, and spawn extra disks more frequently""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ElementalLance"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Lance"",
		""englishTooltip"": [
			""Rend the cosmos asunder!"",
			""Fires a lance beam that splits multiple times as it travels""
		],
		""name"": ""Elemental Lance"",
		""tooltip"": [
			""Rend the cosmos asunder!"",
			""Fires a lance beam that splits multiple times as it travels""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ElementalShiv"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Shiv"",
		""englishTooltip"": [
			""Don't underestimate the power of shivs"",
			""Shoots a rainbow shiv that spawns additional shivs on hit""
		],
		""name"": ""Elemental Shiv"",
		""tooltip"": [
			""Don't underestimate the power of shivs"",
			""Shoots a rainbow shiv that spawns additional shivs on hit""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EmpyreanCloak"",
		""type"": ""ITEM"",
		""englishName"": ""Empyrean Cloak"",
		""englishTooltip"": [
			""Armor of the cosmos"",
			""+20 max life"",
			""7% increased rogue damage and critical strike chance""
		],
		""name"": ""Empyrean Cloak"",
		""tooltip"": [
			""Armor of the cosmos"",
			""+20 max life"",
			""7% increased rogue damage and critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EmpyreanCuisses"",
		""type"": ""ITEM"",
		""englishName"": ""Empyrean Cuisses"",
		""englishTooltip"": [
			""5% increased rogue damage and critical strike chance"",
			""15% increased movement speed""
		],
		""name"": ""Empyrean Cuisses"",
		""tooltip"": [
			""5% increased rogue damage and critical strike chance"",
			""15% increased movement speed""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EmpyreanMask"",
		""type"": ""ITEM"",
		""englishName"": ""Empyrean Mask"",
		""englishTooltip"": [
			""11% increased rogue damage and critical strike chance, 5% increased movement speed"",
			""Temporary immunity to lava""
		],
		""name"": ""Empyrean Mask"",
		""tooltip"": [
			""11% increased rogue damage and critical strike chance, 5% increased movement speed"",
			""Temporary immunity to lava""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EnchantedButterfly"",
		""type"": ""ITEM"",
		""englishName"": ""Enchanted Butterfly"",
		""englishTooltip"": [
			""Feed him butterflies to keep him strong!"",
			""Summons a mysterious dragonfly light pet"",
			""Provides a small amount of light in the abyss""
		],
		""name"": ""Enchanted Butterfly"",
		""tooltip"": [
			""Feed him butterflies to keep him strong!"",
			""Summons a mysterious dragonfly light pet"",
			""Provides a small amount of light in the abyss""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EncryptedSchematicIce"",
		""type"": ""ITEM"",
		""englishName"": ""Encrypted Schematic"",
		""englishTooltip"": [
			""Requires a Codebreaker with a complex voltage regulation system to decrypt""
		],
		""name"": ""Encrypted Schematic"",
		""tooltip"": [
			""Requires a Codebreaker with a complex voltage regulation system to decrypt TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EncryptedSchematicJungle"",
		""type"": ""ITEM"",
		""englishName"": ""Encrypted Schematic"",
		""englishTooltip"": [
			""Requires a Codebreaker with a fine tuned, long range sensor to decrypt""
		],
		""name"": ""Encrypted Schematic"",
		""tooltip"": [
			""Requires a Codebreaker with a fine tuned, long range sensor to decrypt TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EncryptedSchematicHell"",
		""type"": ""ITEM"",
		""englishName"": ""Encrypted Schematic"",
		""englishTooltip"": [
			""Requires a Codebreaker with a sophisticated display to decrypt""
		],
		""name"": ""Encrypted Schematic"",
		""tooltip"": [
			""Requires a Codebreaker with a sophisticated display to decrypt TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EncryptedSchematicPlanetoid"",
		""type"": ""ITEM"",
		""englishName"": ""Encrypted Schematic"",
		""englishTooltip"": [
			""Requires a Codebreaker with a basic decryption computer to decrypt""
		],
		""name"": ""Encrypted Schematic"",
		""tooltip"": [
			""Requires a Codebreaker with a basic decryption computer to decrypt TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EntropicClaymore"",
		""type"": ""ITEM"",
		""englishName"": ""Entropic Claymore"",
		""englishTooltip"": [
			""Fires a spread of homing plasma balls""
		],
		""name"": ""Entropic Claymore"",
		""tooltip"": [
			""Fires a spread of homing plasma balls""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EntropysVigil"",
		""type"": ""ITEM"",
		""englishName"": ""Entropy's Vigil"",
		""englishTooltip"": [
			""Summons Calamitas and her brothers to protect you"",
			""One minion trio takes two minion slots""
		],
		""name"": ""Entropy's Vigil"",
		""tooltip"": [
			""Summons Calamitas and her brothers to protect you"",
			""One minion trio takes two minion slots""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EssenceofSunlight"",
		""type"": ""ITEM"",
		""englishName"": ""Essence of Sunlight"",
		""englishTooltip"": [
			""The essence of sky, light, and storm creatures""
		],
		""name"": ""Essence of Sunlight"",
		""tooltip"": [
			""The essence of sky, light, and storm creatures""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoThrone"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Box"",
		""englishTooltip"": [
			""Materializes a quite cozy and extremely nimble flying Exo throne"",
			""Replaced"",
			""Also replaced"",
			""A comfortable gamer is a dangerous gamer""
		],
		""name"": ""Exo Box"",
		""tooltip"": [
			""Materializes a quite cozy and extremely nimble flying Exo throne TOTRANSLATE"",
			""Replaced"",
			""Also replaced"",
			""A comfortable gamer is a dangerous gamer""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoConsole"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Console"",
		""name"": ""Exo Console"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoDisplay"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Display"",
		""name"": ""Exo Display"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoDye"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Dye"",
		""name"": ""Exo Dye"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoPlatingWallItem"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Plating Wall"",
		""name"": ""Exo Plating Wall"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoPrism"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Prism"",
		""englishTooltip"": [
			""Fractal energies shimmer across its surface""
		],
		""name"": ""Exo Prism"",
		""tooltip"": [
			""Fractal energies shimmer across its surface TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoPrismPanelWallItem"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Prism Panel Wall"",
		""name"": ""Exo Prism Panel Wall"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoScreen"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Screen"",
		""name"": ""Exo Screen"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoServer"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Server"",
		""name"": ""Exo Server"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoTerminal"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Terminal"",
		""name"": ""Exo Terminal"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Exoblade"",
		""type"": ""ITEM"",
		""englishName"": ""Exoblade"",
		""englishTooltip"": [
			""Ancient blade of Yharim's weapons and armors expert, Draedon"",
			""Fires an exo beam that homes in on the player and explodes"",
			""Striking an enemy with the blade causes several comets to fire"",
			""All attacks briefly freeze enemies hit"",
			""Enemies hit at very low HP explode into frost energy and freeze nearby enemies""
		],
		""name"": ""Exoblade"",
		""tooltip"": [
			""Ancient blade of Yharim's weapons and armors expert, Draedon"",
			""Fires an exo beam that homes in on the player and explodes"",
			""Striking an enemy with the blade causes several comets to fire"",
			""All attacks briefly freeze enemies hit"",
			""Enemies hit at very low HP explode into frost energy and freeze nearby enemies""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ExodiumCluster"",
		""type"": ""ITEM"",
		""englishName"": ""Exodium Cluster"",
		""englishTooltip"": [
			""A cold cluster from the great unknown.""
		],
		""name"": ""Exodium Cluster"",
		""tooltip"": [
			""A cold cluster from the great unknown.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ExodusWings"",
		""type"": ""ITEM"",
		""englishName"": ""Exodus Wings"",
		""englishTooltip"": [
			""Pulsing with an alien heartbeat"",
			""Horizontal speed: 9.00"",
			""Acceleration multiplier: 2.5"",
			""Great vertical speed"",
			""Flight time: 180"",
			""5% increased rogue damage and critical strike chance while wearing the Empyrean Armor""
		],
		""name"": ""Exodus Wings"",
		""tooltip"": [
			""Pulsing with an alien heartbeat"",
			""Horizontal speed: 9.00"",
			""Acceleration multiplier: 2.5"",
			""Great vertical speed"",
			""Flight time: 180"",
			""5% increased rogue damage and critical strike chance while wearing the Empyrean Armor""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ExoticPheromones"",
		""type"": ""ITEM"",
		""englishName"": ""Exotic Pheromones"",
		""englishTooltip"": [
			""Attracts the failed draconic experiment"",
			""Summons The Dragonfolly when used in the jungle"",
			""Not consumable""
		],
		""name"": ""Exotic Pheromones"",
		""tooltip"": [
			""Attracts the failed draconic experiment"",
			""Summons The Dragonfolly when used in the jungle"",
			""Not consumable""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EyeofDesolation"",
		""type"": ""ITEM"",
		""englishName"": ""Eye of Desolation"",
		""englishTooltip"": [
			""Tonight is going to be a horrific night..."",
			""Summons Calamitas when used during nighttime"",
			""Not consumable""
		],
		""name"": ""Eye of Desolation"",
		""tooltip"": [
			""Tonight is going to be a horrific night..."",
			""Summons Calamitas when used during nighttime"",
			""Not consumable""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EyeOfNight"",
		""type"": ""ITEM"",
		""englishName"": ""Eye of Night"",
		""englishTooltip"": [
			""Summons a diseased eyeball that fires cells which attach to enemies and inflict cursed flames""
		],
		""name"": ""Eye of Night"",
		""tooltip"": [
			""Summons a diseased eyeball that fires cells which attach to enemies and inflict cursed flames TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FallenPaladinsHammer"",
		""type"": ""ITEM"",
		""englishName"": ""Fallen Paladin's Hammer"",
		""englishTooltip"": [
			""Explodes on enemy hits""
		],
		""name"": ""Fallen Paladin's Hammer"",
		""tooltip"": [
			""Explodes on enemy hits""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FaultLine"",
		""type"": ""ITEM"",
		""englishName"": ""Fault Line"",
		""englishTooltip"": [
			""Explodes on enemy hits"",
			""A very agile yoyo""
		],
		""name"": ""Fault Line"",
		""tooltip"": [
			""Explodes on enemy hits"",
			""A very agile yoyo""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FishboneBoomerang"",
		""type"": ""ITEM"",
		""englishName"": ""Fishbone Boomerang"",
		""englishTooltip"": [
			""Stealth strikes make the boomerang ricochet between enemies"",
			""[c/5C95A1:Though the evaporating Sea Kingdom fought a losing battle, its proud inhabitants did not go down easily.]"",
			""[c/5C95A1:As a last resort, they had to fashion weapons from the skeletons of dead animals.]""
		],
		""name"": ""Fishbone Boomerang"",
		""tooltip"": [
			""Stealth strikes make the boomerang ricochet between enemies"",
			""[c/5C95A1:Though the evaporating Sea Kingdom fought a losing battle, its proud inhabitants did not go down easily.]"",
			""[c/5C95A1:As a last resort, they had to fashion weapons from the skeletons of dead animals.]""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FlameLickedShell"",
		""type"": ""ITEM"",
		""englishName"": ""Flame-Licked Shell"",
		""englishTooltip"": [
			""35% decreased movement speed"",
			""Enemies take damage when they hit you"",
			""You move faster and lose 18 defense for 3 seconds if you take damage"",
			""Temporary immunity to lava"",
			""Grants immunity to Armor Crunch""
		],
		""name"": ""Flame-Licked Shell"",
		""tooltip"": [
			""35% decreased movement speed"",
			""Enemies take damage when they hit you"",
			""You move faster and lose 18 defense for 3 seconds if you take damage"",
			""Temporary immunity to lava"",
			""Grants immunity to Armor Crunch""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FlamsteedRing"",
		""type"": ""ITEM"",
		""englishName"": ""Flamsteed Ring"",
		""englishTooltip"": [
			""Summons a colossal controllable mech"",
			""Right click to display the mech's control panel"",
			""The panel has 3 configurations, selected using the brackets on the edges of the UI"",
			""Each bracket powers 2 out of 3 possible functions, represented by the circular icons."",
			""The bottom left icon miniaturizes the mech to the size of a player, but weakens its weapons."",
			""The bottom right icon is a powerful jet booster which greatly enhances movement."",
			""The top icon is the mech's weaponry. It must be powered in order to attack."",
			""Click the top icon to switch between Regicide, an enormous energy blade, and a powerful Gauss rifle."",
			""Exiting the mount while a boss is alive will temporarily hinder your movement"",
			""\"" + CalamityUtils.ColorMessage(\""Now, make them pay.""
		],
		""name"": ""Flamsteed Ring"",
		""tooltip"": [
			""Summons a colossal controllable mech"",
			""Right click to display the mech's control panel"",
			""The panel has 3 configurations, selected using the brackets on the edges of the UI"",
			""Each bracket powers 2 out of 3 possible functions, represented by the circular icons."",
			""The bottom left icon miniaturizes the mech to the size of a player, but weakens its weapons."",
			""The bottom right icon is a powerful jet booster which greatly enhances movement."",
			""The top icon is the mech's weaponry. It must be powered in order to attack."",
			""Click the top icon to switch between Regicide, an enormous energy blade, and a powerful Gauss rifle."",
			""Exiting the mount while a boss is alive will temporarily hinder your movement"",
			""\"" + CalamityUtils.ColorMessage(\""Now, make them pay.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FlashRound"",
		""type"": ""ITEM"",
		""englishName"": ""Flash Round"",
		""englishTooltip"": [
			""Gives off a concussive blast that confuses enemies in a large area for a short time""
		],
		""name"": ""Flash Round"",
		""tooltip"": [
			""Gives off a concussive blast that confuses enemies in a large area for a short time""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FleshOfInfidelity"",
		""type"": ""ITEM"",
		""englishName"": ""Flesh of Infidelity"",
		""englishTooltip"": [
			""Summons a tentacled ball of flesh that splashes blood onto enemies""
		],
		""name"": ""Flesh of Infidelity"",
		""tooltip"": [
			""Summons a tentacled ball of flesh that splashes blood onto enemies TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FleshyGeode"",
		""type"": ""ITEM"",
		""englishName"": ""Fleshy Geode"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Fleshy Geode"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FlowersOfMortality"",
		""type"": ""ITEM"",
		""englishName"": ""Flowers of Mortality"",
		""englishTooltip"": [
			""Summons five rainbow flowers over your head"",
			""The combined flowers consume two and a half minion slots""
		],
		""name"": ""Flowers of Mortality"",
		""tooltip"": [
			""Summons five rainbow flowers over your head TOTRANSLATE"",
			""The combined flowers consume two and a half minion slots""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FollyFeed"",
		""type"": ""ITEM"",
		""englishName"": ""Folly Feed"",
		""englishTooltip"": [
			""Summons a monstrosity""
		],
		""name"": ""Folly Feed"",
		""tooltip"": [
			""Summons a monstrosity""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""FracturedArk"",
		""type"": ""ITEM"",
		""englishName"": ""Fractured Ark"",
		""englishTooltip"": [
			""This line gets set in ModifyTooltips"",
			""A worn down and rusty blade once wielded against the evil of this world, ready to be of use once more""
		],
		""name"": ""Fractured Ark"",
		""tooltip"": [
			""This line gets set in ModifyTooltips"",
			""A worn down and rusty blade once wielded against the evil of this world, ready to be of use once more""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GalactusBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Galactus Blade"",
		""englishTooltip"": [
			""Forged with the fury of nuclear chaos"",
			""Launches a barrage of comets from the sky""
		],
		""name"": ""Galactus Blade"",
		""tooltip"": [
			""Forged with the fury of nuclear chaos"",
			""Launches a barrage of comets from the sky""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GalaxySmasher"",
		""type"": ""ITEM"",
		""englishName"": ""Galaxy Smasher"",
		""englishTooltip"": [
			""Explodes and summons death lasers on enemy hits""
		],
		""name"": ""Galaxy Smasher"",
		""tooltip"": [
			""Explodes and summons death lasers on enemy hits""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GemTechBodyArmor"",
		""type"": ""ITEM"",
		""englishName"": ""Gem Tech Body Armor"",
		""englishTooltip"": [
			""You sunk low enough for me to reach.""
		],
		""name"": ""Gem Tech Body Armor"",
		""tooltip"": [
			""You sunk low enough for me to reach.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GemTechHeadgear"",
		""type"": ""ITEM"",
		""englishName"": ""Gem Tech Headgear"",
		""englishTooltip"": [
			""The Devil said: Revel in your victory; You've earned your damning. Pack your things and leave.""
		],
		""name"": ""Gem Tech Headgear"",
		""tooltip"": [
			""The Devil said: Revel in your victory; You've earned your damning. Pack your things and leave.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GemTechSchynbaulds"",
		""type"": ""ITEM"",
		""englishName"": ""Gem Tech Schynbaulds"",
		""englishTooltip"": [
			""If they hurt you, kick them down.""
		],
		""name"": ""Gem Tech Schynbaulds"",
		""tooltip"": [
			""If they hurt you, kick them down.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GenesisPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Genesis Pickaxe"",
		""englishTooltip"": [
			""Can mine Uelibloom Ore""
		],
		""name"": ""Genesis Pickaxe"",
		""tooltip"": [
			""Can mine Uelibloom Ore""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GiantClamRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Giant Clam Relic"",
		""name"": ""Giant Clam Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""GloriousEnd"",
		""type"": ""ITEM"",
		""englishName"": ""Glorious End"",
		""englishTooltip"": [
			""Casts a meteor star for the player to ride in the direction of the cursor"",
			""The meteor star explodes after hitting an enemy, crashing into a wall, or after 6 seconds"",
			""This explosion hurts both enemies and the player"",
			""Releasing the cursor before the star explodes will cause it to explode prematurely for less damage"",
			""Mounts are disabled while this weapon is in use""
		],
		""name"": ""Glorious End"",
		""tooltip"": [
			""Casts a meteor star for the player to ride in the direction of the cursor"",
			""The meteor star explodes after hitting an enemy, crashing into a wall, or after 6 seconds"",
			""This explosion hurts both enemies and the player"",
			""Releasing the cursor before the star explodes will cause it to explode prematurely for less damage"",
			""Mounts are disabled while this weapon is in use""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GodSlayerHeadRanged"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Helmet"",
		""englishTooltip"": [
			""14% increased ranged damage and critical strike chance""
		],
		""name"": ""God Slayer Helmet"",
		""tooltip"": [
			""14% increased ranged damage and critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GodSlayerHeadMelee"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Horned Greathelm"",
		""englishTooltip"": [
			""14% increased melee damage and critical strike chance""
		],
		""name"": ""God Slayer Horned Greathelm"",
		""tooltip"": [
			""14% increased melee damage and critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GodSlayerHeadRogue"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Mask"",
		""englishTooltip"": [
			""14% increased rogue damage and critical strike chance, 5% increased movement speed""
		],
		""name"": ""God Slayer Mask"",
		""tooltip"": [
			""14% increased rogue damage and critical strike chance, 5% increased movement speed""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GodsBellows"",
		""type"": ""ITEM"",
		""englishName"": ""God's Bellows"",
		""englishTooltip"": [
			""70% chance to not consume gel""
		],
		""name"": ""God's Bellows"",
		""tooltip"": [
			""70% chance to not consume gel""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GreatSandSharkRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Great Sand Shark Relic"",
		""name"": ""Great Sand Shark Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""GreenSeekingMechanism"",
		""type"": ""ITEM"",
		""englishName"": ""Green Seeking Mechanism"",
		""englishTooltip"": [
			""Moves swiftly towards a lab within the jungle""
		],
		""name"": ""Green Seeking Mechanism"",
		""tooltip"": [
			""Moves swiftly towards a lab within the jungle TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GruesomeEminence"",
		""type"": ""ITEM"",
		""englishName"": ""Gruesome Eminence"",
		""englishTooltip"": [
			""Summons a gaseous conglomeration of spirits near the cursor"",
			""At first, the spirits will fly wildly. This can hurt enemies and players"",
			""However, over time they will begin to accumulate to create a single, controllable monstrosity"",
			""\"" + CalamityUtils.ColorMessage(\""The spirits of the amalgam could never pass on to their desired afterlife,"",
			""Tainted and melded by rage as they were.""
		],
		""name"": ""Gruesome Eminence"",
		""tooltip"": [
			""Summons a gaseous conglomeration of spirits near the cursor TOTRANSLATE"",
			""At first, the spirits will fly wildly. This can hurt enemies and players"",
			""However, over time they will begin to accumulate to create a single, controllable monstrosity"",
			""\"" + CalamityUtils.ColorMessage(\""The spirits of the amalgam could never pass on to their desired afterlife\"", CalamityGlobalItem.ExhumedTooltipColor)"",
			""Tainted and melded by rage as they were.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""GuidelightofOblivion"",
		""type"": ""ITEM"",
		""englishName"": ""Guidelight of Oblivion"",
		""englishTooltip"": [
			""Shadows dream of endless fire, flames devour and embers swoop"",
			""Summons a lantern turret to fight for you""
		],
		""name"": ""Guidelight of Oblivion"",
		""tooltip"": [
			""Shadows dream of endless fire, flames devour and embers swoop"",
			""Summons a lantern turret to fight for you""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HadalMantle"",
		""type"": ""ITEM"",
		""englishName"": ""Hadal Mantle"",
		""englishTooltip"": [
			""Fueled by the fury of the depths"",
			""Horizontal speed: 7.75"",
			""Acceleration multiplier: 1.5"",
			""Average vertical speed"",
			""Flight time: 180"",
			""5% increased damage while wearing the Hydrothermic Armor""
		],
		""name"": ""Hadal Mantle"",
		""tooltip"": [
			""Fueled by the fury of the depths"",
			""Horizontal speed: 7.75"",
			""Acceleration multiplier: 1.5"",
			""Average vertical speed"",
			""Flight time: 180"",
			""5% increased damage while wearing the Hydrothermic Armor""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HadalStew"",
		""type"": ""ITEM"",
		""englishName"": ""Hadal Stew"",
		""englishTooltip"": [
			""Only gives 50 seconds of Potion Sickness"",
			""{$CommonItemTooltip.MediumStats}"",
			""60 minute duration""
		],
		""name"": ""Hadal Stew"",
		""tooltip"": [
			""Only gives 50 seconds of Potion Sickness"",
			""{$CommonItemTooltip.MediumStats}"",
			""60 minute duration""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HallowedOre"",
		""type"": ""ITEM"",
		""englishName"": ""Hallowed Ore"",
		""name"": ""Hallowed Ore"",
		""state"": ""A traduire""
	},
	{
		""id"": ""HavocsBreath"",
		""type"": ""ITEM"",
		""englishName"": ""Havoc's Breath"",
		""name"": ""Havoc's Breath"",
		""state"": ""A traduire""
	},
	{
		""id"": ""HeavyLaserRifle"",
		""type"": ""ITEM"",
		""englishName"": ""Heavy Laser Rifle"",
		""englishTooltip"": [
			""Laser weapon used by heavy infantry units in Yharim's army""
		],
		""name"": ""Heavy Laser Rifle"",
		""tooltip"": [
			""Laser weapon used by heavy infantry units in Yharim's army""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Heresy"",
		""type"": ""ITEM"",
		""englishName"": ""Heresy"",
		""englishTooltip"": [
			""Releases fire and souls upward from a held book"",
			""As the book is held the power of both increases""
		],
		""name"": ""Heresy"",
		""tooltip"": [
			""Releases fire and souls upward from a held book TOTRANSLATE"",
			""As the book is held the power of both increases""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HermitsBoxofOneHundredMedicines"",
		""type"": ""ITEM"",
		""englishName"": ""Hermit's Box of One Hundred Medicines"",
		""englishTooltip"": [
			""As the ice melts in the springs"",
			""And waves wash the old moss’ hair..."",
			""Thank you, Goodbye."",
			""Summons the Third Sage"",
			""Use the item with right click in the hotbar to toggle the Third Sage's blessing."",
			""With the blessing, the player will spawn with full health rather than half.""
		],
		""name"": ""Hermit's Box of One Hundred Medicines"",
		""tooltip"": [
			""As the ice melts in the springs"",
			""And waves wash the old moss’ hair..."",
			""Thank you, Goodbye."",
			""Summons the Third Sage"",
			""Use the item with right click in the hotbar to toggle the Third Sage's blessing."",
			""With the blessing, the player will spawn with full health rather than half.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HiveMindRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Hive Mind Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Hive Mind Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HoodOfCalamity"",
		""type"": ""ITEM"",
		""englishName"": ""Hood of Calamity"",
		""name"": ""Hood of Calamity"",
		""state"": ""A traduire""
	},
	{
		""id"": ""HydrothermicArmor"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Armor"",
		""englishTooltip"": [
			""+20 max life"",
			""8% increased damage and 4% increased critical strike chance""
		],
		""name"": ""Hydrothermic Armor"",
		""tooltip"": [
			""+20 max life"",
			""8% increased damage and 4% increased critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HydrothermicHeadRanged"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Headgear"",
		""englishTooltip"": [
			""12% increased ranged damage and 10% increased ranged critical strike chance"",
			""Reduces ammo usage by 25%, temporary immunity to lava, and immunity to fire damage""
		],
		""name"": ""Hydrothermic Headgear"",
		""tooltip"": [
			""12% increased ranged damage and 10% increased ranged critical strike chance"",
			""Reduces ammo usage by 25%, temporary immunity to lava, and immunity to fire damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HydrothermicHeadMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Helm"",
		""englishTooltip"": [
			""12% increased melee damage and 10% increased melee critical strike chance"",
			""18% increased melee speed"",
			""Melee attacks and melee projectiles inflict on fire"",
			""Temporary immunity to lava and immunity to fire damage""
		],
		""name"": ""Hydrothermic Helm"",
		""tooltip"": [
			""12% increased melee damage and 10% increased melee critical strike chance"",
			""18% increased melee speed"",
			""Melee attacks and melee projectiles inflict on fire"",
			""Temporary immunity to lava and immunity to fire damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HydrothermicHeadSummon"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Helmet"",
		""englishTooltip"": [
			""5% increased minion damage and increased minion knockback"",
			""Temporary immunity to lava and immunity to fire damage""
		],
		""name"": ""Hydrothermic Helmet"",
		""tooltip"": [
			""5% increased minion damage and increased minion knockback"",
			""Temporary immunity to lava and immunity to fire damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HydrothermicHeadRogue"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Hood"",
		""englishTooltip"": [
			""12% increased rogue damage and 10% increased rogue critical strike chance"",
			""50% chance to not consume rogue items and 5% increased movement speed"",
			""Temporary immunity to lava and immunity to fire damage""
		],
		""name"": ""Hydrothermic Hood"",
		""tooltip"": [
			""12% increased rogue damage and 10% increased rogue critical strike chance"",
			""50% chance to not consume rogue items and 5% increased movement speed"",
			""Temporary immunity to lava and immunity to fire damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HydrothermicHeadMagic"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Mask"",
		""englishTooltip"": [
			""12% increased magic damage, +100 max mana, and 10% increased magic critical strike chance"",
			""Temporary immunity to lava, and immunity to fire damage""
		],
		""name"": ""Hydrothermic Mask"",
		""tooltip"": [
			""12% increased magic damage, +100 max mana, and 10% increased magic critical strike chance"",
			""Temporary immunity to lava, and immunity to fire damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""HydrothermicSubligar"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Subligar"",
		""englishTooltip"": [
			""5% increased critical strike chance"",
			""10% increased movement speed""
		],
		""name"": ""Hydrothermic Subligar"",
		""tooltip"": [
			""5% increased critical strike chance"",
			""10% increased movement speed""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""IllustriousKnives"",
		""type"": ""ITEM"",
		""englishName"": ""Illustrious Knives"",
		""englishTooltip"": [
			""Throws a flurry of homing knives that can heal the user""
		],
		""name"": ""Illustrious Knives"",
		""tooltip"": [
			""Throws a flurry of homing knives that can heal the user""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""InfestedClawmerang"",
		""type"": ""ITEM"",
		""englishName"": ""Infested Clawmerang"",
		""englishTooltip"": [
			""Fires a slow, long-ranged boomerang"",
			""Stealth strikes grant the Mushy buff to the user on enemy hits and summon homing spores""
		],
		""name"": ""Infested Clawmerang"",
		""tooltip"": [
			""Fires a slow, long-ranged boomerang"",
			""Stealth strikes grant the Mushy buff to the user on enemy hits and summon homing spores""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""JungleDragonEgg"",
		""type"": ""ITEM"",
		""englishName"": ""Jungle Dragon Egg"",
		""englishTooltip"": [
			""An imitation of the egg that bore the loyal guardian of the tyrant king"",
			""Summons Jungle Dragon, Yharon when used in the jungle"",
			""Not consumable""
		],
		""name"": ""Jungle Dragon Egg"",
		""tooltip"": [
			""An imitation of the egg that bore the loyal guardian of the tyrant king"",
			""Summons Jungle Dragon, Yharon when used in the jungle"",
			""Not consumable""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""LabSeekingMechanism"",
		""type"": ""ITEM"",
		""englishName"": ""Lab Seeking Mechanism"",
		""englishTooltip"": [
			""A receptacle for technology which pinpoints the power cores of Draedon's Labs""
		],
		""name"": ""Lab Seeking Mechanism"",
		""tooltip"": [
			""A receptacle for technology which pinpoints the power cores of Draedon's Labs""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""LashesofChaos"",
		""type"": ""ITEM"",
		""englishName"": ""Lashes of Chaos"",
		""englishTooltip"": [
			""Watch the world burn...""
		],
		""name"": ""Lashes of Chaos"",
		""tooltip"": [
			""Watch the world burn...""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""KnowledgeLeviathanAnahita"",
		""type"": ""ITEM"",
		""englishName"": ""Leviathan and Anahita"",
		""englishTooltip"": [
			""An odd pair of creatures; one seeking companionship and the other seeking sustenance."",
			""Perhaps two genetic misfits outcast from their homes that found comfort in assisting one another.""
		],
		""name"": ""Leviathan and Anahita"",
		""tooltip"": [
			""An odd pair of creatures; one seeking companionship and the other seeking sustenance."",
			""Perhaps two genetic misfits outcast from their homes that found comfort in assisting one another.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""LeviathanAnahitaRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Leviathan and Anahita Relic"",
		""name"": ""Leviathan and Anahita Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""LifeAlloy"",
		""type"": ""ITEM"",
		""englishName"": ""Life Alloy"",
		""name"": ""Life Alloy"",
		""state"": ""A traduire""
	},
	{
		""id"": ""LittleLight"",
		""type"": ""ITEM"",
		""englishName"": ""Little Light"",
		""englishTooltip"": [
			""It's been looking for you for a long time."",
			""Summons a small construct that follows you and provides a great amount of light"",
			""Provides a large amount of light in the abyss""
		],
		""name"": ""Little Light"",
		""tooltip"": [
			""It's been looking for you for a long time. TOTRANSLATE"",
			""Summons a small construct that follows you and provides a great amount of light"",
			""Provides a large amount of light in the abyss""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""LongRangedSensorArray"",
		""type"": ""ITEM"",
		""englishName"": ""Long Ranged Sensor Array"",
		""englishTooltip"": [
			""Can be placed on the Codebreaker""
		],
		""name"": ""Long Ranged Sensor Array"",
		""tooltip"": [
			""Can be placed on the Codebreaker TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Lumenyl"",
		""type"": ""ITEM"",
		""englishName"": ""Lumenyl"",
		""englishTooltip"": [
			""A shard of lumenous energy""
		],
		""name"": ""Lumenyl"",
		""tooltip"": [
			""A shard of lumenous energy""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ManaPolarizer"",
		""type"": ""ITEM"",
		""englishName"": ""Mana Polarizer"",
		""englishTooltip"": [
			""Increases max mana by 50 and magic damage by 6%"",
			""Life regen lowered by 3 if mana is above 50% of its maximum"",
			""Grants spectre healing, the amount healed scales with your mana"",
			""The healing only works while holding a magic weapon"",
			""The more mana you have, the more you heal""
		],
		""name"": ""Mana Polarizer"",
		""tooltip"": [
			""Increases max mana by 50 and magic damage by 6%"",
			""Life regen lowered by 3 if mana is above 50% of its maximum"",
			""Grants spectre healing, the amount healed scales with your mana"",
			""The healing only works while holding a magic weapon"",
			""The more mana you have, the more you heal""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MarniteBayonet"",
		""type"": ""ITEM"",
		""englishName"": ""Marnite Bayonet"",
		""englishTooltip"": [
			""The gun damages enemies that touch it""
		],
		""name"": ""Marnite Bayonet"",
		""tooltip"": [
			""The gun damages enemies that touch it""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MaulerRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Mauler Relic"",
		""name"": ""Mauler Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""McNuggets"",
		""type"": ""ITEM"",
		""englishName"": ""McNuggets"",
		""englishTooltip"": [
			""These chicken nuggets aren't for you to eat!""
		],
		""name"": ""McNuggets"",
		""tooltip"": [
			""These chicken nuggets aren't for you to eat!""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MeldConstruct"",
		""type"": ""ITEM"",
		""englishName"": ""Meld Construct"",
		""name"": ""Meld Construct"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Metastasis"",
		""type"": ""ITEM"",
		""englishName"": ""Metastasis"",
		""englishTooltip"": [
			""Summons a sepulcher to fight for you"",
			""While the sepulcher is active brimstone hearts will begin to appear and orbit you"",
			""It will attempt to attack you more and more frequently depending on how many hearts are present"",
			""It takes up 4 minion slots and it can only be summoned once"",
			""\"" + CalamityUtils.ColorMessage(\""A contemplated possible future of the cosmic serpent,"",
			""A gruesome warning for those blinded by the hunger for power.""
		],
		""name"": ""Metastasis"",
		""tooltip"": [
			""Summons a sepulcher to fight for you TOTRANSLATE"",
			""While the sepulcher is active brimstone hearts will begin to appear and orbit you"",
			""It will attempt to attack you more and more frequently depending on how many hearts are present"",
			""It takes up 4 minion slots and it can only be summoned once"",
			""\"" + CalamityUtils.ColorMessage(\""A contemplated possible future of the cosmic serpent\"", CalamityGlobalItem.ExhumedTooltipColor)"",
			""A gruesome warning for those blinded by the hunger for power.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MiracleMatter"",
		""type"": ""ITEM"",
		""englishName"": ""Miracle Matter"",
		""englishTooltip"": [
			""Its amorphous form contains untold potential"",
			""One is required for every Exo Weapon""
		],
		""name"": ""Miracle Matter"",
		""tooltip"": [
			""Its amorphous form contains untold potential TOTRANSLATE"",
			""One is required for every Exo Weapon""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""NanoPurge"",
		""type"": ""ITEM"",
		""englishName"": ""Nano Purge"",
		""englishTooltip"": [
			""Fires a barrage of nano lasers""
		],
		""name"": ""Nano Purge"",
		""tooltip"": [
			""Fires a barrage of nano lasers""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""NanoblackReaper"",
		""type"": ""ITEM"",
		""englishName"": ""Nanoblack Reaper"",
		""englishTooltip"": [
			""Unleashes a storm of nanoblack energy blades"",
			""Blades target bosses whenever possible"",
			""Stealth strikes cause the scythe to create a large amount of homing afterimages instead of energy blades"",
			""'She smothered them in Her hatred'""
		],
		""name"": ""Nanoblack Reaper"",
		""tooltip"": [
			""Unleashes a storm of nanoblack energy blades"",
			""Blades target bosses whenever possible"",
			""Stealth strikes cause the scythe to create a large amount of homing afterimages instead of energy blades"",
			""'She smothered them in Her hatred'""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""NavystoneWallSafe"",
		""type"": ""ITEM"",
		""englishName"": ""Navystone Wall"",
		""name"": ""Navystone Wall"",
		""state"": ""A traduire""
	},
	{
		""id"": ""NecromanticGeode"",
		""type"": ""ITEM"",
		""englishName"": ""Necromantic Geode"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Necromantic Geode"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""NettlevineGreatbow"",
		""type"": ""ITEM"",
		""englishName"": ""Nettlevine Greatbow"",
		""englishTooltip"": [
			""Shoots 4 arrows at once"",
			""Fires 2 additional venom or chlorophyte arrows""
		],
		""name"": ""Nettlevine Greatbow"",
		""tooltip"": [
			""Shoots 4 arrows at once"",
			""Fires 2 additional venom or chlorophyte arrows""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Norfleet"",
		""type"": ""ITEM"",
		""englishName"": ""Norfleet"",
		""englishTooltip"": [
			""Fire everything!""
		],
		""name"": ""Norfleet"",
		""tooltip"": [
			""Fire everything!""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""NovaeSlag"",
		""type"": ""ITEM"",
		""englishName"": ""Novae Slag"",
		""name"": ""Novae Slag"",
		""state"": ""A traduire""
	},
	{
		""id"": ""NuclearTerrorRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Nuclear Terror Relic"",
		""name"": ""Nuclear Terror Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Oblivion"",
		""type"": ""ITEM"",
		""englishName"": ""Oblivion"",
		""englishTooltip"": [
			""Fires brimstone lasers when enemies are near"",
			""A very agile yoyo""
		],
		""name"": ""Oblivion"",
		""tooltip"": [
			""Fires brimstone lasers when enemies are near"",
			""A very agile yoyo""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""OccultSkullCrown"",
		""type"": ""ITEM"",
		""englishName"": ""Occult Skull Crown"",
		""englishTooltip"": [
			""Only a fool would ever wear this..."",
			""You constantly gain rage over time and rage does not fade away when out of combat"",
			""Converts certain debuffs into buffs and extends their durations"",
			""Debuffs affected: Darkness, Blackout, Confused, Slow, Weak, Broken Armor,"",
			""Armor Crunch, War Cleave, Chilled, Ichor and Obstructed"",
			""Adrenaline charges 20% faster"",
			""Increases your max movement speed and acceleration by 5%"",
			""Can also be worn as a helmet"",
			""Revengeance item""
		],
		""name"": ""Occult Skull Crown"",
		""tooltip"": [
			""Only a fool would ever wear this..."",
			""You constantly gain rage over time and rage does not fade away when out of combat"",
			""Converts certain debuffs into buffs and extends their durations"",
			""Debuffs affected: Darkness, Blackout, Confused, Slow, Weak, Broken Armor,"",
			""Armor Crunch, War Cleave, Chilled, Ichor and Obstructed"",
			""Adrenaline charges 20% faster"",
			""Increases your max movement speed and acceleration by 5%"",
			""Can also be worn as a helmet"",
			""Revengeance item""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""OldDukeRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Old Duke Relic"",
		""name"": ""Old Duke Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""OldDukeScales"",
		""type"": ""ITEM"",
		""englishName"": ""Old Duke's Scales"",
		""englishTooltip"": [
			""While under the effects of a damaging debuff, you gain 10% increased damage and 5% crit"",
			""For every 25% of lost life, you gain 6% increased damage and 3% crit"",
			""This will max out at 18% increased damage and 9% crit when under 25% life"",
			""Provides immunity to poisoned, venom, and sulphuric poisoning""
		],
		""name"": ""Old Duke's Scales"",
		""tooltip"": [
			""While under the effects of a damaging debuff, you gain 10% increased damage and 5% crit"",
			""For every 25% of lost life, you gain 6% increased damage and 3% crit"",
			""This will max out at 18% increased damage and 9% crit when under 25% life"",
			""Provides immunity to poisoned, venom, and sulphuric poisoning""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""OmegaBlueTentacles"",
		""type"": ""ITEM"",
		""englishName"": ""Omega Blue Tentacles"",
		""englishTooltip"": [
			""12% increased movement speed"",
			""12% increased damage and critical strike chance""
		],
		""name"": ""Omega Blue Tentacles"",
		""tooltip"": [
			""12% increased movement speed"",
			""12% increased damage and critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Pandemic"",
		""type"": ""ITEM"",
		""englishName"": ""Pandemic"",
		""englishTooltip"": [
			""Fires plague seekers when enemies are near"",
			""A very agile yoyo""
		],
		""name"": ""Pandemic"",
		""tooltip"": [
			""Fires plague seekers when enemies are near"",
			""A very agile yoyo""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PearlofEnthrallment"",
		""type"": ""ITEM"",
		""englishName"": ""Pearl of Enthrallment"",
		""englishTooltip"": [
			""Summons a water elemental to fight for you"",
			""The elemental stays above you, shooting water spears, ice mist, and treble clefs at nearby enemies""
		],
		""name"": ""Pearl of Enthrallment"",
		""tooltip"": [
			""Summons a water elemental to fight for you"",
			""The elemental stays above you, shooting water spears, ice mist, and treble clefs at nearby enemies""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Perdition"",
		""type"": ""ITEM"",
		""englishName"": ""Perdition"",
		""englishTooltip"": [
			""Summons a beacon at the position of the mouse"",
			""When a target is manually selected via right click it releases torrents of souls from below onto the target"",
			""Only one beacon may exist at a time""
		],
		""name"": ""Perdition"",
		""tooltip"": [
			""Summons a beacon at the position of the mouse TOTRANSLATE"",
			""When a target is manually selected via right click it releases torrents of souls from below onto the target"",
			""Only one beacon may exist at a time""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PerennialBar"",
		""type"": ""ITEM"",
		""englishName"": ""Perennial Bar"",
		""name"": ""Perennial Bar"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PerforatorsRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Perforators Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Perforators Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PhantomicArtifact"",
		""type"": ""ITEM"",
		""englishName"": ""Phantomic Artifact"",
		""englishTooltip"": [
			""Whenever your minions hit an enemy you will gain a random phantomic buff, does not stack with downgrades"",
			""These buffs will either boost your defense, summon damage, or life regen for a while"",
			""If you have the offensive boost, enemies hit by minions will sometimes be hit by phantomic knives"",
			""If you have the regenerative boost, a phantomic heart will occasionally materialise granting massive health regen"",
			""If you have the defensive boost, a phantomic bulwark will absorb 20% of the next projectile's damage that hits the bulwark, shattering it""
		],
		""name"": ""Phantomic Artifact"",
		""tooltip"": [
			""Whenever your minions hit an enemy you will gain a random phantomic buff, does not stack with downgrades TOTRANSLATE"",
			""These buffs will either boost your defense, summon damage, or life regen for a while"",
			""If you have the offensive boost, enemies hit by minions will sometimes be hit by phantomic knives"",
			""If you have the regenerative boost, a phantomic heart will occasionally materialise granting massive health regen"",
			""If you have the defensive boost, a phantomic bulwark will absorb 20% of the next projectile's damage that hits the bulwark, shattering it""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PhantoplasmDye"",
		""type"": ""ITEM"",
		""englishName"": ""Phantoplasm Dye"",
		""name"": ""Phantoplasm Dye"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PhosphorescentGauntlet"",
		""type"": ""ITEM"",
		""englishName"": ""Phosphorescent Gauntlet"",
		""englishTooltip"": [
			""Releases rapid sulphurous punches"",
			""On use, you lunge in the direction of the mouse"",
			""On collision, you are knocked back""
		],
		""name"": ""Phosphorescent Gauntlet"",
		""tooltip"": [
			""Releases rapid sulphurous punches TOTRANSLATE"",
			""On use, you lunge in the direction of the mouse"",
			""On collision, you are knocked back""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PhotonRipper"",
		""type"": ""ITEM"",
		""englishName"": ""Photon Ripper"",
		""englishTooltip"": [
			""Projects a directed stream of hardlight teeth at ultra high velocity"",
			""This weapon and its projectiles function as a chainsaw""
		],
		""name"": ""Photon Ripper"",
		""tooltip"": [
			""Projects a directed stream of hardlight teeth at ultra high velocity TOTRANSLATE"",
			""This weapon and its projectiles function as a chainsaw""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PiggyItem"",
		""type"": ""ITEM"",
		""englishName"": ""Piggy"",
		""name"": ""Piggy"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PineapplePet"",
		""type"": ""ITEM"",
		""englishName"": ""Pineapple"",
		""englishTooltip"": [
			""Summons a pineapple""
		],
		""name"": ""Pineapple"",
		""tooltip"": [
			""Summons a pineapple TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PinkCosmicFlameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Pink Cosmic Flame Dye"",
		""name"": ""Pink Cosmic Flame Dye"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PinkStatigelDye"",
		""type"": ""ITEM"",
		""englishName"": ""Pink Statigel Dye"",
		""name"": ""Pink Statigel Dye"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PlagueCellCanister"",
		""type"": ""ITEM"",
		""englishName"": ""Plague Cell Canister"",
		""name"": ""Plague Cell Canister"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PlaguebringerGoliathRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Plaguebringer Goliath Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Plaguebringer Goliath Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PlaguedContainmentBrick"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Containment Brick"",
		""name"": ""Plagued Containment Brick"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PlaguedWorkBench"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Work Bench"",
		""name"": ""Plagued Work Bench"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Plagueplate"",
		""type"": ""ITEM"",
		""englishName"": ""Plagueplate"",
		""englishTooltip"": [
			""It resonates with otherworldly energy.""
		],
		""name"": ""Plagueplate"",
		""tooltip"": [
			""It resonates with otherworldly energy.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PolterghastRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Polterghast Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Polterghast Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PolypLauncher"",
		""type"": ""ITEM"",
		""englishName"": ""Polyp Launcher"",
		""englishTooltip"": [
			""Summons a polyp bunch that launches coral chunks at nearby enemies""
		],
		""name"": ""Polyp Launcher"",
		""tooltip"": [
			""Summons a polyp bunch that launches coral chunks at nearby enemies TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Portabulb"",
		""type"": ""ITEM"",
		""englishName"": ""Portabulb"",
		""englishTooltip"": [
			""Summons Plantera when used in the jungle"",
			""Not consumable""
		],
		""name"": ""Portabulb"",
		""tooltip"": [
			""Summons Plantera when used in the jungle"",
			""Not consumable""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PridefulHuntersPlanarRipper"",
		""type"": ""ITEM"",
		""englishName"": ""Prideful Hunter's Planar Ripper"",
		""englishTooltip"": [
			""Every fourth shot deals 135% damage"",
			""Converts musket balls into lightning bolts"",
			""Lightning bolts travel extremely fast and explode on enemy kills"",
			""Lightning bolt crits grant a stacking speed boost to the player"",
			""This stacks up to 20 percent bonus movement speed and acceleration"",
			""The boost will reset if the player holds a different item"",
			""33% chance to not consume ammo""
		],
		""name"": ""Prideful Hunter's Planar Ripper"",
		""tooltip"": [
			""Every fourth shot deals 135% damage"",
			""Converts musket balls into lightning bolts"",
			""Lightning bolts travel extremely fast and explode on enemy kills"",
			""Lightning bolt crits grant a stacking speed boost to the player"",
			""This stacks up to 20 percent bonus movement speed and acceleration"",
			""The boost will reset if the player holds a different item"",
			""33% chance to not consume ammo""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PrismBackBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Prism-Back Banner"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Prism-Back""
		],
		""name"": ""Prism-Back Banner"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Prism-Back""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ProfanedGuardiansRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Guardians Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Profaned Guardians Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""PlasmaDriveCore"",
		""type"": ""ITEM"",
		""englishName"": ""Prototype Plasma Drive Core"",
		""englishTooltip"": [
			""Despite all the time it spent in storage, its furnace still burns strong""
		],
		""name"": ""Prototype Plasma Drive Core"",
		""tooltip"": [
			""Despite all the time it spent in storage, its furnace still burns strong""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ProvidenceRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Providence Relic"",
		""name"": ""Providence Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PurpleSeekingMechanism"",
		""type"": ""ITEM"",
		""englishName"": ""Purple Seeking Mechanism"",
		""englishTooltip"": [
			""Moves swiftly towards a lab within the sky""
		],
		""name"": ""Purple Seeking Mechanism"",
		""tooltip"": [
			""Moves swiftly towards a lab within the sky TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RainbowPartyCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Rainbow Party Cannon"",
		""englishTooltip"": [
			""Let the rainbow remind you that together we will always shine...""
		],
		""name"": ""Rainbow Party Cannon"",
		""tooltip"": [
			""Let the rainbow remind you that together we will always shine... TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Rancor"",
		""type"": ""ITEM"",
		""englishName"": ""Rancor"",
		""englishTooltip"": [
			""Casts a magic circle that charges energy and eventually releases a powerful laser burst of controlled maleficent magic"",
			""The laser causes arms and searing lava to appear on surfaces it touches which harm both you and enemies"",
			""\"" + CalamityUtils.ColorMessage(\""Forgiveness can only heal so much,"",
			""If the recipient has not yet forgiven themselves.""
		],
		""name"": ""Rancor"",
		""tooltip"": [
			""Casts a magic circle that charges energy and eventually releases a powerful laser burst of controlled maleficent magic TOTRANSLATE"",
			""The laser causes arms and searing lava to appear on surfaces it touches which harm both you and enemies"",
			""\"" + CalamityUtils.ColorMessage(\""Forgiveness can only heal so much\"", CalamityGlobalItem.ExhumedTooltipColor)"",
			""If the recipient has not yet forgiven themselves.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RavagerRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Ravager Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Ravager Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ReaverHeadExplore"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Headgear"",
		""englishTooltip"": [
			""10% increased pick speed and 20% increased block/wall placement speed"",
			""Temporary immunity to lava and can move freely through liquids""
		],
		""name"": ""Reaver Headgear"",
		""tooltip"": [
			""10% increased pick speed and 20% increased block/wall placement speed"",
			""Temporary immunity to lava and can move freely through liquids""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ReaverHeadTank"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Helm"",
		""englishTooltip"": [
			""15% increased damage reduction but 30% decreased damage"",
			""+50 max life"",
			""Passively regenerates one health point every second""
		],
		""name"": ""Reaver Helm"",
		""tooltip"": [
			""15% increased damage reduction but 30% decreased damage"",
			""+50 max life"",
			""Passively regenerates one health point every second""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ReaverHeadMobility"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Visage"",
		""englishTooltip"": [
			""10% increased jump speed and 15% increased movement speed""
		],
		""name"": ""Reaver Visage"",
		""tooltip"": [
			""10% increased jump speed and 15% increased movement speed""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RedtideSpear"",
		""type"": ""ITEM"",
		""englishName"": ""Redtide Spear"",
		""englishTooltip"": [
			""Poisons enemies on hit"",
			""Aiming the spear in front of you while running holds it down with increased knockback"",
			""Releasing the attack button after the charge makes an upwards slash, sending enemies flying into the air"",
			""[c/5C95A1:The people of the sea were adept hunters, but they abhorred unnecessary violence.]"",
			""[c/5C95A1:Unfortunately, neighboring nations were brutish, so they fashioned their tools for war.]""
		],
		""name"": ""Redtide Spear"",
		""tooltip"": [
			""Poisons enemies on hit"",
			""Aiming the spear in front of you while running holds it down with increased knockback"",
			""Releasing the attack button after the charge makes an upwards slash, sending enemies flying into the air"",
			""[c/5C95A1:The people of the sea were adept hunters, but they abhorred unnecessary violence.]"",
			""[c/5C95A1:Unfortunately, neighboring nations were brutish, so they fashioned their tools for war.]""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ReedBlowgun"",
		""type"": ""ITEM"",
		""englishName"": ""Reed Blowgun"",
		""englishTooltip"": [
			""Fires a high-pressure stream of bubbles"",
			""[c/5C95A1:The Old Sea Kingdom never truly sought to expand beyond its initial borders.]"",
			""[c/5C95A1:However, they had a perfect track record of repelling any invasions, thanks to their insurmountable advantage in the water.]""
		],
		""name"": ""Reed Blowgun"",
		""tooltip"": [
			""Fires a high-pressure stream of bubbles"",
			""[c/5C95A1:The Old Sea Kingdom never truly sought to expand beyond its initial borders.]"",
			""[c/5C95A1:However, they had a perfect track record of repelling any invasions, thanks to their insurmountable advantage in the water.]""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RefractionRotor"",
		""type"": ""ITEM"",
		""englishName"": ""Refraction Rotor"",
		""englishTooltip"": [
			""Fires a huge prismatic disk shuriken"",
			""The shuriken shatters moments after impact into homing rockets"",
			""Stealth strikes shatter into many more rockets""
		],
		""name"": ""Refraction Rotor"",
		""tooltip"": [
			""Fires a huge prismatic disk shuriken TOTRANSLATE"",
			""The shuriken shatters moments after impact into homing rockets"",
			""Stealth strikes shatter into many more rockets""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RemsRevenge"",
		""type"": ""ITEM"",
		""englishName"": ""Rem's Revenge"",
		""englishTooltip"": [
			""Wielded by the most powerful fighter."",
			""Summons blood explosions and lowers enemy defense on hit""
		],
		""name"": ""Rem's Revenge"",
		""tooltip"": [
			""Wielded by the most powerful fighter. TOTRANSLATE"",
			""Summons blood explosions and lowers enemy defense on hit""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ResilientCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Resilient Candle"",
		""englishTooltip"": [
			""When placed, nearby players' defense blocks 5% more damage"",
			""'Neither rain nor wind can snuff its undying flame'""
		],
		""name"": ""Resilient Candle"",
		""tooltip"": [
			""When placed, nearby players' defense blocks 5% more damage"",
			""'Neither rain nor wind can snuff its undying flame'""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RiftReeler"",
		""type"": ""ITEM"",
		""englishName"": ""Rift Reeler"",
		""englishTooltip"": [
			""Fires three to five lines at once. Can fish in lava."",
			""The battlefield is a scene of constant chaos."",
			""The winner will be the one who controls that chaos, both the pole and the fish.""
		],
		""name"": ""Rift Reeler"",
		""tooltip"": [
			""Fires three to five lines at once. Can fish in lava."",
			""The battlefield is a scene of constant chaos."",
			""The winner will be the one who controls that chaos, both the pole and the fish.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RimehoundBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Rimehound Banner"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Rimehound""
		],
		""name"": ""Rimehound Banner"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Rimehound""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Riptide"",
		""type"": ""ITEM"",
		""englishName"": ""Riptide"",
		""englishTooltip"": [
			""Sprays a spiral of aqua streams in random directions"",
			""A very agile yoyo""
		],
		""name"": ""Riptide"",
		""tooltip"": [
			""Sprays a spiral of aqua streams in random directions"",
			""A very agile yoyo""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RobesOfCalamity"",
		""type"": ""ITEM"",
		""englishName"": ""Robes of Calamity"",
		""name"": ""Robes of Calamity"",
		""state"": ""A traduire""
	},
	{
		""id"": ""RotdogBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Rotdog Banner"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Rotdog""
		],
		""name"": ""Rotdog Banner"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Rotdog""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RottenDogtooth"",
		""type"": ""ITEM"",
		""englishName"": ""Rotten Dogtooth"",
		""englishTooltip"": [
			""DO NOT TRAD""
		],
		""name"": ""Rotten Dogtooth"",
		""tooltip"": [
			""Makes Stealth strikes inflict Armor Crunch, deal {10}% more damage and cost 1 less unit of stealth. TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RottenMatter"",
		""type"": ""ITEM"",
		""englishName"": ""Rotten Matter"",
		""name"": ""Rotten Matter"",
		""state"": ""A traduire""
	},
	{
		""id"": ""RottingEyeball"",
		""type"": ""ITEM"",
		""englishName"": ""Rotting Eyeball"",
		""englishTooltip"": [
			""Summons a corrupted conglomeration""
		],
		""name"": ""Rotting Eyeball"",
		""tooltip"": [
			""Summons a corrupted conglomeration TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""RuneofKos"",
		""type"": ""ITEM"",
		""englishName"": ""Rune of Kos"",
		""englishTooltip"": [
			""A relic of the profaned flame"",
			""Contains the power hunted relentlessly by the sentinels of the cosmic devourer"",
			""When used in certain areas of the world, it will unleash them"",
			""Not consumable""
		],
		""name"": ""Rune of Kos"",
		""tooltip"": [
			""A relic of the profaned flame"",
			""Contains the power hunted relentlessly by the sentinels of the cosmic devourer"",
			""When used in certain areas of the world, it will unleash them"",
			""Not consumable""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Sacrifice"",
		""type"": ""ITEM"",
		""englishName"": ""Sacrifice"",
		""englishTooltip"": [
			""Throws sacrificial daggers that lodge themselves in enemies"",
			""Right click causes all stuck daggers to fly back at you and give you life"",
			""Daggers stuck to enemies release bloodsplosions over time"",
			""Stealth strikes provide much more life when returning to you""
		],
		""name"": ""Sacrifice"",
		""tooltip"": [
			""Throws sacrificial daggers that lodge themselves in enemies TOTRANSLATE"",
			""Right click causes all stuck daggers to fly back at you and give you life"",
			""Daggers stuck to enemies release bloodsplosions over time"",
			""Stealth strikes provide much more life when returning to you""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SandSharkToothNecklace"",
		""type"": ""ITEM"",
		""englishName"": ""Sand Shark Tooth Necklace"",
		""englishTooltip"": [
			""Increases armor penetration by 10"",
			""6% increased damage""
		],
		""name"": ""Sand Shark Tooth Necklace"",
		""tooltip"": [
			""Increases armor penetration by 10 TOTRANSLATE"",
			""6% increased damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DeathModeItem"",
		""type"": ""ITEM"",
		""englishName"": ""Satanic Scepter of Death"",
		""englishTooltip"": [
			""Enables/disables Death Mode, can only be used in Revengeance Mode."",
			""All effects from Revengeance Mode are enabled, including the following:"",
			""Greatly boosts enemy spawn rates during the Blood Moon."",
			""Makes the Abyss more treacherous to navigate."",
			""Certain non-boss enemies and projectiles deal between 6% and 15% more damage."",
			""Nerfs the effectiveness of life steal a bit more."",
			""The Nurse no longer heals you while a boss is alive."",
			""Increases damage done by 50% for several debuffs and all alcohols that reduce life regen."",
			""Changes all boss AIs and most enemy AIs."",
			""Increases the damage of all bosses a bit more.""
		],
		""name"": ""Satanic Scepter of Death"",
		""tooltip"": [
			""Enables/disables Death Mode, can only be used in Revengeance Mode."",
			""All effects from Revengeance Mode are enabled, including the following:"",
			""Greatly boosts enemy spawn rates during the Blood Moon."",
			""Makes the Abyss more treacherous to navigate."",
			""Certain non-boss enemies and projectiles deal between 6% and 15% more damage."",
			""Nerfs the effectiveness of life steal a bit more."",
			""The Nurse no longer heals you while a boss is alive."",
			""Increases damage done by 50% for several debuffs and all alcohols that reduce life regen."",
			""Changes all boss AIs and most enemy AIs."",
			""Increases the damage of all bosses a bit more.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EncryptedSchematicSunkenSea"",
		""type"": ""ITEM"",
		""englishName"": ""Schematic"",
		""englishTooltip"": [
			""Finely detailed diagrams of numerous devices and weaponry dance across the holographic screen."",
			""The weaponry I supply to the workers of the laboratories is weak. Hardly suited for battle."",
			""However, they suffice for self defense against any lab mechanisms or creations which may have gone rogue."",
			""Addendum: For those who think themselves powerful, search the upper bounds of this planet’s atmosphere for a structure similar to that of the Sunken Seas."",
			""I will know by the end if you are worthy of battling my creations."",
			""Picking up this item or holding it in your inventory permanently unlocks new recipes""
		],
		""name"": ""Schematic"",
		""tooltip"": [
			""Finely detailed diagrams of numerous devices and weaponry dance across the holographic screen. TOTRANSLATE"",
			""The weaponry I supply to the workers of the laboratories is weak. Hardly suited for battle."",
			""However, they suffice for self defense against any lab mechanisms or creations which may have gone rogue."",
			""Addendum: For those who think themselves powerful, search the upper bounds of this planet’s atmosphere for a structure similar to that of the Sunken Seas."",
			""I will know by the end if you are worthy of battling my creations."",
			""Picking up this item or holding it in your inventory permanently unlocks new recipes""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ScorchedEarth"",
		""type"": ""ITEM"",
		""englishName"": ""Scorched Earth"",
		""englishTooltip"": [
			""Fires a burst of four fuel-air rockets which explode into cluster bombs"",
			""Each burst consumes two rockets each"",
			""Burns your targets to a fine crisp""
		],
		""name"": ""Scorched Earth"",
		""tooltip"": [
			""Fires a burst of four fuel-air rockets which explode into cluster bombs"",
			""Each burst consumes two rockets each"",
			""Burns your targets to a fine crisp""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ScoriaBar"",
		""type"": ""ITEM"",
		""englishName"": ""Scoria Bar"",
		""englishTooltip"": [
			""The smoke feels warm""
		],
		""name"": ""Scoria Bar"",
		""tooltip"": [
			""The smoke feels warm""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ScoriaOre"",
		""type"": ""ITEM"",
		""englishName"": ""Scoria Ore"",
		""name"": ""Scoria Ore"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Scorpio"",
		""type"": ""ITEM"",
		""englishName"": ""Scorpio"",
		""englishTooltip"": [
			""BOOM"",
			""Right click to fire a nuke"",
			""Rockets will destroy tiles with tile-destroying ammo""
		],
		""name"": ""Scorpio"",
		""tooltip"": [
			""BOOM"",
			""Right click to fire a nuke"",
			""Rockets will destroy tiles with tile-destroying ammo""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SeaRemains"",
		""type"": ""ITEM"",
		""englishName"": ""Sea Remains"",
		""name"": ""Sea Remains"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SearedPan"",
		""type"": ""ITEM"",
		""englishName"": ""Seared Pan"",
		""englishTooltip"": [
			""dAMaGe iS rAthEr cOnSisTeNT"",
			""Fires a frying pan at high velocity"",
			""Enemy hits summon fireballs that linger around the target"",
			""Landing three consecutive hits grants will launch a golden pan"",
			""Golden pans cause all fireballs to aggressively home in on their target"",
			""Stealth strikes act similar to golden pans but also explode into golden sparks"",
			""Stealth strikes also summon additional fireballs on hit""
		],
		""name"": ""Seared Pan"",
		""tooltip"": [
			""dAMaGe iS rAthEr cOnSisTeNT"",
			""Fires a frying pan at high velocity"",
			""Enemy hits summon fireballs that linger around the target"",
			""Landing three consecutive hits grants will launch a golden pan"",
			""Golden pans cause all fireballs to aggressively home in on their target"",
			""Stealth strikes act similar to golden pans but also explode into golden sparks"",
			""Stealth strikes also summon additional fireballs on hit""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SeekingScorcher"",
		""type"": ""ITEM"",
		""englishName"": ""Seeking Scorcher"",
		""englishTooltip"": [
			""May your enemies burn in hell for the sins they have committed"",
			""Throws a holy boomerang that seeks out up to four enemies before returning to the player""
		],
		""name"": ""Seeking Scorcher"",
		""tooltip"": [
			""May your enemies burn in hell for the sins they have committed"",
			""Throws a holy boomerang that seeks out up to four enemies before returning to the player""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SeismicHampick"",
		""type"": ""ITEM"",
		""englishName"": ""Seismic Hampick"",
		""englishTooltip"": [
			""Capable of mining Lihzahrd Bricks"",
			""Left click to use as a pickaxe"",
			""Right click to use as a hammer""
		],
		""name"": ""Seismic Hampick"",
		""tooltip"": [
			""Capable of mining Lihzahrd Bricks"",
			""Left click to use as a pickaxe"",
			""Right click to use as a hammer""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SeraphTracers"",
		""type"": ""ITEM"",
		""englishName"": ""Seraph Tracers"",
		""englishTooltip"": [
			""Ludicrous speed!"",
			""Counts as wings"",
			""Horizontal speed: 9.00"",
			""Acceleration multiplier: 2.5"",
			""Good vertical speed"",
			""Flight time: 140"",
			""24% increased running acceleration"",
			""Greater mobility on ice"",
			""Water and lava walking"",
			""Immunity to the On Fire! debuff"",
			""Temporary immunity to lava""
		],
		""name"": ""Seraph Tracers"",
		""tooltip"": [
			""Ludicrous speed!"",
			""Counts as wings"",
			""Horizontal speed: 9.00"",
			""Acceleration multiplier: 2.5"",
			""Good vertical speed"",
			""Flight time: 140"",
			""24% increased running acceleration"",
			""Greater mobility on ice"",
			""Water and lava walking"",
			""Immunity to the On Fire! debuff"",
			""Temporary immunity to lava""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Seraphim"",
		""type"": ""ITEM"",
		""englishName"": ""Seraphim"",
		""englishTooltip"": [
			""\""DO NOT TRAD""
		],
		""name"": ""Seraphim"",
		""tooltip"": [
			""\""DO NOT TRAD""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ShardofAntumbra"",
		""type"": ""ITEM"",
		""englishName"": ""Shard of Antumbra"",
		""englishTooltip"": [
			""Stealth strikes leave homing stars in their wake""
		],
		""name"": ""Shard of Antumbra"",
		""tooltip"": [
			""Stealth strikes leave homing stars in their wake""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ShatteredCommunity"",
		""type"": ""ITEM"",
		""englishName"": ""Shattered Community"",
		""englishTooltip"": [
			""Ruined by unknowable hatred, it still contains (most of) the power of The Community..."",
			""You generate rage over time and rage does not fade away out of combat"",
			""Taking damage gives rage, this effect is not hindered by your defensive stats"",
			""While Rage Mode is active, taking damage gives only half as much rage"",
			""Deal damage with Rage Mode to further empower your wrath""
		],
		""name"": ""Shattered Community"",
		""tooltip"": [
			""Ruined by unknowable hatred, it still contains (most of) the power of The Community... TOTRANSLATE"",
			""You generate rage over time and rage does not fade away out of combat"",
			""Taking damage gives rage, this effect is not hindered by your defensive stats"",
			""While Rage Mode is active, taking damage gives only half as much rage"",
			""Deal damage with Rage Mode to further empower your wrath""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SignusRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Signus Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Signus Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SilvaHeadSummon"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Horned Hood"",
		""englishTooltip"": [
			""10% increased minion damage""
		],
		""name"": ""Silva Horned Hood"",
		""tooltip"": [
			""10% increased minion damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SilvaMask"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Mask"",
		""name"": ""Silva Mask"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SilvaHeadMagic"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Masked Cap"",
		""englishTooltip"": [
			""23% increased magic damage and 13% increased magic critical strike chance"",
			""+100 max mana and 19% reduced mana usage""
		],
		""name"": ""Silva Masked Cap"",
		""tooltip"": [
			""23% increased magic damage and 13% increased magic critical strike chance"",
			""+100 max mana and 19% reduced mana usage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SirenproofEarMuffs"",
		""type"": ""ITEM"",
		""englishName"": ""Sirenproof Earmuffs"",
		""englishTooltip"": [
			""Favorite this item to prevent Anahita from spawning near you""
		],
		""name"": ""Sirenproof Earmuffs"",
		""tooltip"": [
			""Favorite this item to prevent Anahita from spawning near you TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Skynamite"",
		""type"": ""ITEM"",
		""englishName"": ""Skynamite"",
		""englishTooltip"": [
			""You don't need an aerodynamics major to use this"",
			""Throws a floaty explosive that defies gravity""
		],
		""name"": ""Skynamite"",
		""tooltip"": [
			""You don't need an aerodynamics major to use this"",
			""Throws a floaty explosive that defies gravity""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SlimeGodDye"",
		""type"": ""ITEM"",
		""englishName"": ""Slime God Dye"",
		""name"": ""Slime God Dye"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SlimeGodRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Slime God Relic"",
		""name"": ""Slime God Relic"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SlimePuppetStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Slime Puppet Staff"",
		""englishTooltip"": [
			""Summons a slime ball that follows you"",
			""The ball flies toward nearby enemies and explodes into slime on enemy hits"",
			""Does not consume minion slots""
		],
		""name"": ""Slime Puppet Staff"",
		""tooltip"": [
			""Summons a slime ball that follows you TOTRANSLATE"",
			""The ball flies toward nearby enemies and explodes into slime on enemy hits"",
			""Does not consume minion slots""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SpeedBlaster"",
		""type"": ""ITEM"",
		""englishName"": ""Speed Blaster"",
		""englishTooltip"": [
			""Shoots a string of paint blasts""
		],
		""name"": ""Speed Blaster"",
		""tooltip"": [
			""Shoots a string of paint blasts""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SpelunkersAmulet"",
		""type"": ""ITEM"",
		""englishName"": ""Spelunker's Amulet"",
		""englishTooltip"": [
			""Spelunker effect and 15% increased mining speed""
		],
		""name"": ""Spelunker's Amulet"",
		""tooltip"": [
			""Spelunker effect and 15% increased mining speed""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SpineOfThanatos"",
		""type"": ""ITEM"",
		""englishName"": ""Spine of Thanatos"",
		""englishTooltip"": [
			""Releases 3 fast metallic whips outward"",
			""Once all three collide, a prism of light is shot outward"",
			""If an enemy is within the line of sight of the whips on collision, the light will fire towards it""
		],
		""name"": ""Spine of Thanatos"",
		""tooltip"": [
			""Releases 3 fast metallic whips outward TOTRANSLATE"",
			""Once all three collide, a prism of light is shot outward"",
			""If an enemy is within the line of sight of the whips on collision, the light will fire towards it""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SpiritGlyph"",
		""type"": ""ITEM"",
		""englishName"": ""Spirit Glyph"",
		""englishTooltip"": [
			""Whenever your minions hit an enemy you will gain a random buff"",
			""These buffs will either boost your defense, summon damage, or life regen for a while""
		],
		""name"": ""Spirit Glyph"",
		""tooltip"": [
			""Whenever your minions hit an enemy you will gain a random buff"",
			""These buffs will either boost your defense, summon damage, or life regen for a while""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SpitefulCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Spiteful Candle"",
		""englishTooltip"": [
			""When placed, nearby enemies take 5% more damage."",
			""This extra damage bypasses enemy damage reduction and defense"",
			""'Its hateful glow flickers with ire'""
		],
		""name"": ""Spiteful Candle"",
		""tooltip"": [
			""When placed, nearby enemies take 5% more damage."",
			""This extra damage bypasses enemy damage reduction and defense"",
			""'Its hateful glow flickers with ire'""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StaffofBlushie"",
		""type"": ""ITEM"",
		""englishName"": ""Staff of Blushie"",
		""englishTooltip"": [
			""Hold your mouse, wait, wait, wait, and put your trust in the power of blue magic""
		],
		""name"": ""Staff of Blushie"",
		""tooltip"": [
			""Hold your mouse, wait, wait, wait, and put your trust in the power of blue magic""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Starmada"",
		""type"": ""ITEM"",
		""englishName"": ""Starmada"",
		""englishTooltip"": [
			""Fires a barrage of stars and plasma blasts""
		],
		""name"": ""Starmada"",
		""tooltip"": [
			""Fires a barrage of stars and plasma blasts""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StatigelHeadMagic"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Cap"",
		""englishTooltip"": [
			""10% increased magic damage and 10% decreased mana cost"",
			""7% increased magic critical strike chance and +30 max mana""
		],
		""name"": ""Statigel Cap"",
		""tooltip"": [
			""10% increased magic damage and 10% decreased mana cost"",
			""7% increased magic critical strike chance and +30 max mana""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StatigelHeadRanged"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Headgear"",
		""englishTooltip"": [
			""10% increased ranged damage"",
			""7% increased ranged critical strike chance""
		],
		""name"": ""Statigel Headgear"",
		""tooltip"": [
			""10% increased ranged damage"",
			""7% increased ranged critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StatigelHeadMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Helm"",
		""englishTooltip"": [
			""10% increased melee damage and melee speed"",
			""7% increased melee critical strike chance""
		],
		""name"": ""Statigel Helm"",
		""tooltip"": [
			""10% increased melee damage and melee speed"",
			""7% increased melee critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StatigelHeadSummon"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Hood"",
		""englishTooltip"": [
			""Increased minion knockback""
		],
		""name"": ""Statigel Hood"",
		""tooltip"": [
			""Increased minion knockback""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StatigelHeadRogue"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Mask"",
		""englishTooltip"": [
			""10% increased rogue damage and 34% chance to not consume rogue items"",
			""7% increased rogue critical strike chance and 5% increased movement speed""
		],
		""name"": ""Statigel Mask"",
		""tooltip"": [
			""10% increased rogue damage and 34% chance to not consume rogue items"",
			""7% increased rogue critical strike chance and 5% increased movement speed""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StatisVoidSash"",
		""type"": ""ITEM"",
		""englishName"": ""Statis' Void Sash"",
		""englishTooltip"": [
			""12% increased jump speed and allows constant jumping"",
			""Grants immunity to fall damage"",
			""Can climb walls, dash, and dodge attacks"",
			""The dodge has a 90 second cooldown"",
			""This cooldown is shared with all other dodges and reflects"",
			""Dashes leave homing scythes in your wake""
		],
		""name"": ""Statis' Void Sash"",
		""tooltip"": [
			""12% increased jump speed and allows constant jumping"",
			""Grants immunity to fall damage"",
			""Can climb walls, dash, and dodge attacks"",
			""The dodge has a 90 second cooldown"",
			""This cooldown is shared with all other dodges and reflects"",
			""Dashes leave homing scythes in your wake""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StellarContempt"",
		""type"": ""ITEM"",
		""englishName"": ""Stellar Contempt"",
		""englishTooltip"": [
			""Lunar flares rain down on enemy hits""
		],
		""name"": ""Stellar Contempt"",
		""tooltip"": [
			""Lunar flares rain down on enemy hits""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StormWeaverRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Storm Weaver Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Storm Weaver Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StratusStarPlatformItem"",
		""type"": ""ITEM"",
		""englishName"": ""Stratus Star Platform"",
		""name"": ""Stratus Star Platform"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SubductionSlicer"",
		""type"": ""ITEM"",
		""englishName"": ""Subduction Slicer"",
		""englishTooltip"": [
			""Throws a scythe that explodes on enemy hits"",
			""Stealth strikes also summon an orange pillar of fire on enemy hits""
		],
		""name"": ""Subduction Slicer"",
		""tooltip"": [
			""Throws a scythe that explodes on enemy hits"",
			""Stealth strikes also summon an orange pillar of fire on enemy hits""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SulphuricScale"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphuric Scale"",
		""name"": ""Sulphuric Scale"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SulphurousBreastplate"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Breastplate"",
		""englishTooltip"": [
			""8% increased rogue damage and 5% increased rogue critical strike chance""
		],
		""name"": ""Sulphurous Breastplate"",
		""tooltip"": [
			""8% increased rogue damage and 5% increased rogue critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SulphurousHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Helmet"",
		""englishTooltip"": [
			""4% increased rogue damage"",
			""2% increased rogue critical strike chance"",
			""Grants underwater breathing""
		],
		""name"": ""Sulphurous Helmet"",
		""tooltip"": [
			""4% increased rogue damage"",
			""2% increased rogue critical strike chance"",
			""Grants underwater breathing""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SulphurousLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Leggings"",
		""englishTooltip"": [
			""Movement speed increased by 10%"",
			""Movement speed increased by 35% while submerged in liquid""
		],
		""name"": ""Sulphurous Leggings"",
		""tooltip"": [
			""Movement speed increased by 10%"",
			""Movement speed increased by 35% while submerged in liquid""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SulphurousSkaterBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Skater Banner"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sulphurous Skater""
		],
		""name"": ""Sulphurous Skater Banner"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sulphurous Skater""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SupremeCataclysmTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Supreme Cataclysm Trophy"",
		""name"": ""Supreme Cataclysm Trophy"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SupremeCatastropheTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Supreme Catastrophe Trophy"",
		""name"": ""Supreme Catastrophe Trophy"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SurgeDriver"",
		""type"": ""ITEM"",
		""englishName"": ""Surge Driver"",
		""englishTooltip"": [
			""Left clicks release a laser ray that explodes on collision"",
			""Right clicks release a barrage of laser beams that release homing energy on enemy hits""
		],
		""name"": ""Surge Driver"",
		""tooltip"": [
			""Left clicks release a laser ray that explodes on collision TOTRANSLATE"",
			""Right clicks release a barrage of laser beams that release homing energy on enemy hits""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SuspiciousLookingJellyBean"",
		""type"": ""ITEM"",
		""englishName"": ""Suspicious Looking Jelly Bean"",
		""englishTooltip"": [
			""JELLY BEAN""
		],
		""name"": ""Suspicious Looking Jelly Bean"",
		""tooltip"": [
			""JELLY BEAN""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SuspiciousScrap"",
		""type"": ""ITEM"",
		""englishName"": ""Suspicious Scrap"",
		""englishTooltip"": [
			""Looks like it may be part of a greater whole...""
		],
		""name"": ""Suspicious Scrap"",
		""tooltip"": [
			""Looks like it may be part of a greater whole...""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SwirlingCosmicFlameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Swirling Cosmic Flame Dye"",
		""name"": ""Swirling Cosmic Flame Dye"",
		""state"": ""A traduire""
	},
	{
		""id"": ""TacticiansTrumpCard"",
		""type"": ""ITEM"",
		""englishName"": ""Tactician's Trump Card"",
		""englishTooltip"": [
			""Faint memories of a Princess from the future cross your mind..."",
			""Fires a sword beam that electrifies enemies on hit""
		],
		""name"": ""Tactician's Trump Card"",
		""tooltip"": [
			""Faint memories of a Princess from the future cross your mind..."",
			""Fires a sword beam that electrifies enemies on hit""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TarragonHeadMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Helm"",
		""englishTooltip"": [
			""Helm of the disciple of ancients"",
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""5% increased damage reduction"",
			""10% increased melee damage and critical strike chance""
		],
		""name"": ""Tarragon Helm"",
		""tooltip"": [
			""Helm of the disciple of ancients"",
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""5% increased damage reduction"",
			""10% increased melee damage and critical strike chance""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TarragonHeadRogue"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Helmet"",
		""englishTooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids, 5% increased movement speed"",
			""10% increased rogue damage and critical strike chance"",
			""5% increased damage reduction""
		],
		""name"": ""Tarragon Helmet"",
		""tooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids, 5% increased movement speed"",
			""10% increased rogue damage and critical strike chance"",
			""5% increased damage reduction""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TarragonHeadSummon"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Horned Helm"",
		""englishTooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""5% increased damage reduction and minion damage""
		],
		""name"": ""Tarragon Horned Helm"",
		""tooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""5% increased damage reduction and minion damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TarragonHeadMagic"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Mask"",
		""englishTooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""20% increased magic damage and 10% increased magic critical strike chance"",
			""5% increased damage reduction, +100 max mana, and 15% reduced mana usage""
		],
		""name"": ""Tarragon Mask"",
		""tooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""20% increased magic damage and 10% increased magic critical strike chance"",
			""5% increased damage reduction, +100 max mana, and 15% reduced mana usage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TarragonHeadRanged"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Visage"",
		""englishTooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""10% increased ranged damage and critical strike chance"",
			""5% increased damage reduction""
		],
		""name"": ""Tarragon Visage"",
		""tooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""10% increased ranged damage and critical strike chance"",
			""5% increased damage reduction""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TectonicTruncator"",
		""type"": ""ITEM"",
		""englishName"": ""Tectonic Truncator"",
		""name"": ""Tectonic Truncator"",
		""state"": ""A traduire""
	},
	{
		""id"": ""TemporalUmbrella"",
		""type"": ""ITEM"",
		""englishName"": ""Temporal Umbrella"",
		""englishTooltip"": [
			""Surprisingly sturdy, I reckon this could defeat the Mafia in a single blow"",
			""Summons a magic hat to hover above your head"",
			""The hat will release a variety of objects to assault your foes"",
			""Requires 5 minion slots to use and there can only be one hat""
		],
		""name"": ""Temporal Umbrella"",
		""tooltip"": [
			""Surprisingly sturdy, I reckon this could defeat the Mafia in a single blow"",
			""Summons a magic hat to hover above your head"",
			""The hat will release a variety of objects to assault your foes"",
			""Requires 5 minion slots to use and there can only be one hat""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TenebreusTides"",
		""type"": ""ITEM"",
		""englishName"": ""Tenebreus Tides"",
		""englishTooltip"": [
			""Inundatio ex Laminis"",
			""Shoots a water spear that pierces enemies and terrain"",
			""Striking enemies summon liquid blades and spears to assault the struck foe""
		],
		""name"": ""Tenebreus Tides"",
		""tooltip"": [
			""Inundatio ex Laminis TOTRANSLATE"",
			""Shoots a water spear that pierces enemies and terrain"",
			""Striking enemies summon liquid blades and spears to assault the struck foe""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Terminus"",
		""type"": ""ITEM"",
		""englishName"": ""Terminus"",
		""englishTooltip"": [
			""A ritualistic artifact, thought to have brought upon The End many millennia ago"",
			""Sealed away in the abyss, far from those that would seek to misuse it"",
			""Activates Boss Rush Mode, using it again will deactivate Boss Rush Mode"",
			""During the Boss Rush, all wires and wired devices will be disabled""
		],
		""name"": ""Terminus"",
		""tooltip"": [
			""A ritualistic artifact, thought to have brought upon The End many millennia ago"",
			""Sealed away in the abyss, far from those that would seek to misuse it"",
			""Activates Boss Rush Mode, using it again will deactivate Boss Rush Mode"",
			""During the Boss Rush, all wires and wired devices will be disabled""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ThanatosMask"",
		""type"": ""ITEM"",
		""englishName"": ""Thanatos Mask"",
		""name"": ""Thanatos Mask"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ThanatosTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Thanatos Trophy"",
		""name"": ""Thanatos Trophy"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ThaumaticChair"",
		""type"": ""ITEM"",
		""englishName"": ""Thaumatic Chair"",
		""englishTooltip"": [
			""One of Chloe's finest creations""
		],
		""name"": ""Thaumatic Chair"",
		""tooltip"": [
			""One of Chloe's finest creations TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TheAtomSplitter"",
		""type"": ""ITEM"",
		""englishName"": ""The Atom Splitter"",
		""englishTooltip"": [
			""Throws a quantum-superimposed javelin that strikes from numerous timelines at once"",
			""Stealth strikes perform far more simultaneous strikes""
		],
		""name"": ""The Atom Splitter"",
		""tooltip"": [
			""Throws a quantum-superimposed javelin that strikes from numerous timelines at once TOTRANSLATE"",
			""Stealth strikes perform far more simultaneous strikes""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TheCartofGods"",
		""type"": ""ITEM"",
		""englishName"": ""The Cart of Gods"",
		""name"": ""The Cart of Gods"",
		""state"": ""A traduire""
	},
	{
		""id"": ""TheDanceofLight"",
		""type"": ""ITEM"",
		""englishName"": ""The Dance of Light"",
		""englishTooltip"": [
			""Barrages enemies with a hailstorm of Light Blades"",
			""'And in a flash of light, nothing remains'""
		],
		""name"": ""The Dance of Light"",
		""tooltip"": [
			""Barrages enemies with a hailstorm of Light Blades"",
			""'And in a flash of light, nothing remains'""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""KnowledgeDragonfolly"",
		""type"": ""ITEM"",
		""englishName"": ""The Dragonfolly"",
		""englishTooltip"": [
			""A failure of twisted scientific ambition; it appears our faulted arrogance over life has shown once more in the results."",
			""Originally intended to be a clone of the Jungle Dragon, these were left to roam about the jungle, attacking anything in their path.""
		],
		""name"": ""The Dragonfolly"",
		""tooltip"": [
			""A failure of twisted scientific ambition; it appears our faulted arrogance over life has shown once more in the results."",
			""Originally intended to be a clone of the Jungle Dragon, these were left to roam about the jungle, attacking anything in their path.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TheEtomer"",
		""type"": ""ITEM"",
		""englishName"": ""The Etomer"",
		""englishTooltip"": [
			""Summons an electric troublemaker"",
			""A little note is attached:"",
			""Thank you, Aloe! Very much appreciated from Ben""
		],
		""name"": ""The Etomer"",
		""tooltip"": [
			""Summons an electric troublemaker"",
			""A little note is attached:"",
			""Thank you, Aloe! Very much appreciated from Ben""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""KnowledgeExoMechs"",
		""type"": ""ITEM"",
		""englishName"": ""The Exo Mechanical Trio"",
		""englishTooltip"": [
			""The fruits of masterful craftsmanship and optimization, created only with the objective to destroy."",
			""Yet in the end, they achieved little more than the original designs they were derived from.""
		],
		""name"": ""The Exo Mechanical Trio"",
		""tooltip"": [
			""The fruits of masterful craftsmanship and optimization, created only with the objective to destroy. TOTRANSLATE"",
			""Yet in the end, they achieved little more than the original designs they were derived from.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TheJailor"",
		""type"": ""ITEM"",
		""englishName"": ""The Jailor"",
		""englishTooltip"": [
			""Releases electric mines outward that connect to each-other via arcs""
		],
		""name"": ""The Jailor"",
		""tooltip"": [
			""Releases electric mines outward that connect to each-other via arcs TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TheMaelstrom"",
		""type"": ""ITEM"",
		""englishName"": ""The Maelstrom"",
		""englishTooltip"": [
			""Fires charged Reaper Sharks that explode into water""
		],
		""name"": ""The Maelstrom"",
		""tooltip"": [
			""Fires charged Reaper Sharks that explode into water""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ThePrince"",
		""type"": ""ITEM"",
		""englishName"": ""The Prince"",
		""englishTooltip"": [
			""DO NOT TRAD""
		],
		""name"": ""The Prince"",
		""tooltip"": [
			""DO NOT TRAD""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""TheSponge"",
		""type"": ""ITEM"",
		""englishName"": ""The Sponge"",
		""englishTooltip"": [
			""10% increased damage reduction"",
			""+30 max life and mana"",
			""5% increased movement and jump speed"",
			""Standing still boosts life and mana regen"",
			""Enemies take damage when they touch you"",
			""You emit a cloud of mushroom spores when you are hit"",
			""6.25% of the damage from enemy attacks is absorbed and converted into healing"",
			""Grants immunity to Armor Crunch""
		],
		""name"": ""The Sponge"",
		""tooltip"": [
			""10% increased damage reduction"",
			""+30 max life and mana"",
			""5% increased movement and jump speed"",
			""Standing still boosts life and mana regen"",
			""Enemies take damage when they touch you"",
			""You emit a cloud of mushroom spores when you are hit"",
			""6.25% of the damage from enemy attacks is absorbed and converted into healing"",
			""Grants immunity to Armor Crunch""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""MaliceModeItem"",
		""type"": ""ITEM"",
		""englishName"": ""Tormented Mind of Malice"",
		""englishTooltip"": [
			""Enables/disables Malice Mode, can only be used in Death Mode."",
			""[c/c01818:This mode is subjective, play how you want, don't expect to live.]"",
			""All effects from Death Mode are enabled, including the following:"",
			""Nerfs the effectiveness of life steal a bit more."",
			""Enrages all bosses and gives them far more aggressive AI.""
		],
		""name"": ""Tormented Mind of Malice"",
		""tooltip"": [
			""Enables/disables Malice Mode, can only be used in Death Mode."",
			""[c/c01818:This mode is subjective, play how you want, don't expect to live.]"",
			""All effects from Death Mode are enabled, including the following:"",
			""Nerfs the effectiveness of life steal a bit more."",
			""Enrages all bosses and gives them far more aggressive AI.""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SignusBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Signus, Envoy of the Devourer)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Bag"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen} TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""CeaselessVoidBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Ceaseless Void)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Bag"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen} TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""StormWeaverBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Storm Weaver)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Bag"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen} TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""AstrumAureusBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Astrum Aureus)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Bag (Astrum Aureus)"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (Exo Mechs)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Bag (Exo Mechs)"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""DragonfollyBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag (The Dragonfolly)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Bag (The Dragonfolly)"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""SupremeCalamitasCoffer"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Coffer (Supreme Calamitas)"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Coffer (Supreme Calamitas)"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""UelibloomBar"",
		""type"": ""ITEM"",
		""englishName"": ""Uelibloom Bar"",
		""name"": ""Uelibloom Bar"",
		""state"": ""A traduire""
	},
	{
		""id"": ""UniversalGenesis"",
		""type"": ""ITEM"",
		""englishName"": ""Universal Genesis"",
		""englishTooltip"": [
			""Let the starry sky fall upon your enemies"",
			""Fires a spread of bullets from the gun and a flurry of stars to rain down on the cursor"",
			""Converts musket balls into starcaller shots that summon additional stars on enemy hits"",
			""50% chance to not consume ammo""
		],
		""name"": ""Universal Genesis"",
		""tooltip"": [
			""Let the starry sky fall upon your enemies"",
			""Fires a spread of bullets from the gun and a flurry of stars to rain down on the cursor"",
			""Converts musket balls into starcaller shots that summon additional stars on enemy hits"",
			""50% chance to not consume ammo""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""UniverseSplitter"",
		""type"": ""ITEM"",
		""englishName"": ""Universe Splitter"",
		""englishTooltip"": [
			""Summons an energy field at the mouse cursor"",
			""After the field has been deployed, it begins to summon multiple small beams"",
			""After several seconds have passed, an enormous laser beam appears at the field's position"",
			""This effect has a cooldown"",
			""Attempting to use this item during the cooldown will cause it to short circuit and do damage to you."",
			""An ancient artifact from a previous age, it waits for your command..."",
			""This is a terrible idea, but it isn't yours anyways... right?""
		],
		""name"": ""Universe Splitter"",
		""tooltip"": [
			""Summons an energy field at the mouse cursor TOTRANSLATE"",
			""After the field has been deployed, it begins to summon multiple small beams"",
			""After several seconds have passed, an enormous laser beam appears at the field's position"",
			""This effect has a cooldown"",
			""Attempting to use this item during the cooldown will cause it to short circuit and do damage to you."",
			""An ancient artifact from a previous age, it waits for your command..."",
			""This is a terrible idea, but it isn't yours anyways... right?""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""EutrophicSandWall"",
		""type"": ""ITEM"",
		""englishName"": ""Unsafe Eutrophic Sand Wall"",
		""name"": ""Unsafe Eutrophic Sand Wall"",
		""state"": ""A traduire""
	},
	{
		""id"": ""NavystoneWall"",
		""type"": ""ITEM"",
		""englishName"": ""Unsafe Navystone Wall"",
		""name"": ""Unsafe Navystone Wall"",
		""state"": ""A traduire""
	},
	{
		""id"": ""UnstableGraniteCore"",
		""type"": ""ITEM"",
		""englishName"": ""Unstable Granite Core"",
		""englishTooltip"": [
			""Three sparks are released on critical hits""
		],
		""name"": ""Unstable Granite Core"",
		""tooltip"": [
			""Three sparks are released on critical hits""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""UrchinMace"",
		""type"": ""ITEM"",
		""englishName"": ""Urchin Mace"",
		""englishTooltip"": [
			""Throws out a whirlpool when released at full charge""
		],
		""name"": ""Urchin Mace"",
		""tooltip"": [
			""Throws out a whirlpool when released at full charge""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Vehemence"",
		""type"": ""ITEM"",
		""englishName"": ""Vehemence"",
		""englishTooltip"": [
			""Casts intense bolts of hellish power that explode into skulls"",
			""Direct hits inflict Demon Flames for an extended period of time""
		],
		""name"": ""Vehemence"",
		""tooltip"": [
			""Casts intense bolts of hellish power that explode into skulls"",
			""Direct hits inflict Demon Flames for an extended period of time""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VictideHeadRanged"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Coral Turban"",
		""englishTooltip"": [
			""5% increased ranged damage""
		],
		""name"": ""Victide Coral Turban"",
		""tooltip"": [
			""5% increased ranged damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VictideGreaves"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Greaves"",
		""englishTooltip"": [
			""Movement speed increased by 8%"",
			""Movement speed increased by 30% while submerged in liquid""
		],
		""name"": ""Victide Greaves"",
		""tooltip"": [
			""Movement speed increased by 8%"",
			""Movement speed increased by 30% while submerged in liquid""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VictideHeadRogue"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Headcrab"",
		""englishTooltip"": [
			""5% increased rogue damage""
		],
		""name"": ""Victide Headcrab"",
		""tooltip"": [
			""5% increased rogue damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VictideHeadMagic"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Hermit Helmet"",
		""englishTooltip"": [
			""5% increased magic damage""
		],
		""name"": ""Victide Hermit Helmet"",
		""tooltip"": [
			""5% increased magic damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VictideHeadSummon"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Mask"",
		""englishTooltip"": [
			""10% increased minion damage""
		],
		""name"": ""Victide Mask"",
		""tooltip"": [
			""10% increased minion damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VictideHeadMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Shellmet"",
		""englishTooltip"": [
			""5% increased melee damage""
		],
		""name"": ""Victide Shellmet"",
		""tooltip"": [
			""5% increased melee damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Vigilance"",
		""type"": ""ITEM"",
		""englishName"": ""Vigilance"",
		""englishTooltip"": [
			""Summons a soul seeker to fight for you""
		],
		""name"": ""Vigilance"",
		""tooltip"": [
			""Summons a soul seeker to fight for you TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VigorousCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Vigorous Candle"",
		""englishTooltip"": [
			""When placed, nearby players regenerate 0.4% of their maximum health per second"",
			""This regeneration is at full power even while moving and bypasses Revengeance Mode caps"",
			""'Its brilliant light suffuses those nearby with hope'""
		],
		""name"": ""Vigorous Candle"",
		""tooltip"": [
			""When placed, nearby players regenerate 0.4% of their maximum health per second"",
			""This regeneration is at full power even while moving and bypasses Revengeance Mode caps"",
			""'Its brilliant light suffuses those nearby with hope'""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Violence"",
		""type"": ""ITEM"",
		""englishName"": ""Violence"",
		""englishTooltip"": [
			""Releases a blazing fork which stays near the mouse and shreds enemies""
		],
		""name"": ""Violence"",
		""tooltip"": [
			""Releases a blazing fork which stays near the mouse and shreds enemies TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""ViralSprout"",
		""type"": ""ITEM"",
		""englishName"": ""Viral Sprout"",
		""englishTooltip"": [
			""Summons a sage spirit to fight for you"",
			""Inflicts Sage Poison, a debuff that becomes stronger the more spirits you own""
		],
		""name"": ""Viral Sprout"",
		""tooltip"": [
			""Summons a sage spirit to fight for you TOTRANSLATE"",
			""Inflicts Sage Poison, a debuff that becomes stronger the more spirits you own""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Virulence"",
		""type"": ""ITEM"",
		""englishName"": ""Virulence"",
		""englishTooltip"": [
			""Fires a plague cloud""
		],
		""name"": ""Virulence"",
		""tooltip"": [
			""Fires a plague cloud""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VoidConcentrationStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Void Concentration Staff"",
		""englishTooltip"": [
			""Summons a foreboding aura that attacks by firing void orbs"",
			""Minion damage is increased by 5% while the aura is active"",
			""Requires three minion slots to use"",
			""Only one may exist"",
			""Right click to launch a black hole that grows in size""
		],
		""name"": ""Void Concentration Staff"",
		""tooltip"": [
			""Summons a foreboding aura that attacks by firing void orbs TOTRANSLATE"",
			""Minion damage is increased by 5% while the aura is active"",
			""Requires three minion slots to use"",
			""Only one may exist"",
			""Right click to launch a black hole that grows in size""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VoidofCalamity"",
		""type"": ""ITEM"",
		""englishName"": ""Void of Calamity"",
		""englishTooltip"": [
			""12% increase to all damage"",
			""Brimstone fire rains down after getting hit""
		],
		""name"": ""Void of Calamity"",
		""tooltip"": [
			""12% increase to all damage"",
			""Brimstone fire rains down after getting hit""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Voidragon"",
		""type"": ""ITEM"",
		""englishName"": ""Voidragon"",
		""englishTooltip"": [
			""75% chance to not consume ammo"",
			""Fires void blasts that explode every other shot"",
			""Shoots demon flame tentacles alongside every shot""
		],
		""name"": ""Voidragon"",
		""tooltip"": [
			""75% chance to not consume ammo"",
			""Fires void blasts that explode every other shot"",
			""Shoots demon flame tentacles alongside every shot""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VoltageRegulationSystem"",
		""type"": ""ITEM"",
		""englishName"": ""Voltage Regulation System"",
		""englishTooltip"": [
			""Can be placed on the Codebreaker""
		],
		""name"": ""Voltage Regulation System"",
		""tooltip"": [
			""Can be placed on the Codebreaker TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VoltaicClimax"",
		""type"": ""ITEM"",
		""englishName"": ""Voltaic Climax"",
		""englishTooltip"": [
			""Conjures an octagon of supercharged magnet spheres around the cursor""
		],
		""name"": ""Voltaic Climax"",
		""tooltip"": [
			""Conjures an octagon of supercharged magnet spheres around the cursor""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VoodooDemonVoodooDoll"",
		""type"": ""ITEM"",
		""englishName"": ""Voodoo Demon Voodoo Doll"",
		""englishTooltip"": [
			""Favorite this item to prevent voodoo demons from spawning near you""
		],
		""name"": ""Voodoo Demon Voodoo Doll"",
		""tooltip"": [
			""Favorite this item to prevent voodoo demons from spawning near you TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""VulcaniteLance"",
		""type"": ""ITEM"",
		""englishName"": ""Vulcanite Lance"",
		""englishTooltip"": [
			""Explodes on enemy hits and summons homing flares on critical hits""
		],
		""name"": ""Vulcanite Lance"",
		""tooltip"": [
			""Explodes on enemy hits and summons homing flares on critical hits""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WarbanneroftheSun"",
		""type"": ""ITEM"",
		""englishName"": ""Warbanner of the Sun"",
		""englishTooltip"": [
			""Increases melee damage, true melee damage and melee speed the closer you are to enemies"",
			""Max boost is 20% increased melee damage, true melee damage and melee speed""
		],
		""name"": ""Warbanner of the Sun"",
		""tooltip"": [
			""Increases melee damage, true melee damage and melee speed the closer you are to enemies"",
			""Max boost is 20% increased melee damage, true melee damage and melee speed""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WaveSkipper"",
		""type"": ""ITEM"",
		""englishName"": ""Wave Skipper"",
		""englishTooltip"": [
			""Throws a spear that bounces a lot"",
			""Stealth strikes throw three high speed spears""
		],
		""name"": ""Wave Skipper"",
		""tooltip"": [
			""Throws a spear that bounces a lot"",
			""Stealth strikes throw three high speed spears""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WeightlessCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Weightless Candle"",
		""englishTooltip"": [
			""When placed, nearby players gain 10% movement speed, 10% wing time and 5% acceleration"",
			""'The floating flame seems to uplift your very spirit'""
		],
		""name"": ""Weightless Candle"",
		""tooltip"": [
			""When placed, nearby players gain 10% movement speed, 10% wing time and 5% acceleration"",
			""'The floating flame seems to uplift your very spirit'""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WitherBlossomsStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Wither Blossoms Staff"",
		""englishTooltip"": [
			""Summons four decaying flowers over your head"",
			""The combined flowers consume two minion slots""
		],
		""name"": ""Wither Blossoms Staff"",
		""tooltip"": [
			""Summons four decaying flowers over your head TOTRANSLATE"",
			""The combined flowers consume two minion slots""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""Wrathwing"",
		""type"": ""ITEM"",
		""englishName"": ""Wrathwing"",
		""englishTooltip"": [
			""Throws an agile, homing winged spear that constantly spits fire"",
			""Stealth strikes create an eruption of cinders on hit""
		],
		""name"": ""Wrathwing"",
		""tooltip"": [
			""Throws an agile, homing winged spear that constantly spits fire"",
			""Stealth strikes create an eruption of cinders on hit""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WulfrumHeadRanged"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Headgear"",
		""englishTooltip"": [
			""10% increased ranged damage""
		],
		""name"": ""Wulfrum Headgear"",
		""tooltip"": [
			""10% increased ranged damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WulfrumHeadMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Helm"",
		""englishTooltip"": [
			""10% increased melee damage""
		],
		""name"": ""Wulfrum Helm"",
		""tooltip"": [
			""10% increased melee damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WulfrumHeadSummon"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Helmet"",
		""englishTooltip"": [
			""10% increased minion damage""
		],
		""name"": ""Wulfrum Helmet"",
		""tooltip"": [
			""10% increased minion damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WulfrumHeadRogue"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Mask"",
		""englishTooltip"": [
			""10% increased rogue damage""
		],
		""name"": ""Wulfrum Mask"",
		""tooltip"": [
			""10% increased rogue damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""WulfrumHeadMagic"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Visage"",
		""englishTooltip"": [
			""10% increased magic damage""
		],
		""name"": ""Wulfrum Visage"",
		""tooltip"": [
			""10% increased magic damage""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""YellowSeekingMechanism"",
		""type"": ""ITEM"",
		""englishName"": ""Yellow Seeking Mechanism"",
		""englishTooltip"": [
			""Moves swiftly towards a lab within the frozen caverns""
		],
		""name"": ""Yellow Seeking Mechanism"",
		""tooltip"": [
			""Moves swiftly towards a lab within the frozen caverns TOTRANSLATE""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""YharonRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Yharon Relic"",
		""englishTooltip"": [
			""A glimpse into what will be..""
		],
		""name"": ""Yharon Relic"",
		""tooltip"": [
			""A glimpse into what will be..""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""YharonsKindleStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Yharon's Kindle Staff"",
		""englishTooltip"": [
			""Summons a fiery draconid to fight for you"",
			""Requires 5 minion slots to use""
		],
		""name"": ""Yharon's Kindle Staff"",
		""tooltip"": [
			""Summons a fiery draconid to fight for you"",
			""Requires 5 minion slots to use""
		],
		""state"": ""A traduire""
	},
	{
		""id"": ""LeviathanStart"",
		""type"": ""NPC"",
		""englishName"": ""???"",
		""name"": ""???"",
		""state"": ""A traduire""
	},
	{
		""id"": ""DesertNuisanceBody"",
		""type"": ""NPC"",
		""englishName"": ""A Desert Nuisance"",
		""name"": ""A Desert Nuisance"",
		""state"": ""A traduire""
	},
	{
		""id"": ""DesertNuisanceHead"",
		""type"": ""NPC"",
		""englishName"": ""A Desert Nuisance"",
		""name"": ""A Desert Nuisance"",
		""state"": ""A traduire""
	},
	{
		""id"": ""DesertNuisanceTail"",
		""type"": ""NPC"",
		""englishName"": ""A Desert Nuisance"",
		""name"": ""A Desert Nuisance"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AdultEidolonWyrmTail"",
		""type"": ""NPC"",
		""englishName"": ""Adult Eidolon Wyrm"",
		""name"": ""Adult Eidolon Wyrm"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AdultEidolonWyrmBody"",
		""type"": ""NPC"",
		""englishName"": ""Adult Eidolon Wyrm"",
		""name"": ""Adult Eidolon Wyrm"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AdultEidolonWyrmHead"",
		""type"": ""NPC"",
		""englishName"": ""Adult Eidolon Wyrm"",
		""name"": ""Adult Eidolon Wyrm"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AdultEidolonWyrmBodyAlt"",
		""type"": ""NPC"",
		""englishName"": ""Adult Eidolon Wyrm"",
		""name"": ""Adult Eidolon Wyrm"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Anahita"",
		""type"": ""NPC"",
		""englishName"": ""Anahita"",
		""name"": ""Anahita"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Aries"",
		""type"": ""NPC"",
		""englishName"": ""Aries"",
		""name"": ""Aries"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AstrumAureus"",
		""type"": ""NPC"",
		""englishName"": ""Astrum Aureus"",
		""name"": ""Astrum Aureus"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AstrumDeusTail"",
		""type"": ""NPC"",
		""englishName"": ""Astrum Deus"",
		""name"": ""Astrum Deus"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AstrumDeusBody"",
		""type"": ""NPC"",
		""englishName"": ""Astrum Deus"",
		""name"": ""Astrum Deus"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AstrumDeusHead"",
		""type"": ""NPC"",
		""englishName"": ""Astrum Deus"",
		""name"": ""Astrum Deus"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Atlas"",
		""type"": ""NPC"",
		""englishName"": ""Atlas"",
		""name"": ""Atlas"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AuroraSpirit"",
		""type"": ""NPC"",
		""englishName"": ""Aurora Spirit"",
		""name"": ""Aurora Spirit"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BabyFlakCrab"",
		""type"": ""NPC"",
		""englishName"": ""Baby Flak Crab"",
		""name"": ""Baby Flak Crab"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BabyGhostBell"",
		""type"": ""NPC"",
		""englishName"": ""Baby Ghost Bell"",
		""name"": ""Baby Ghost Bell"",
		""state"": ""A traduire""
	},
	{
		""id"": ""THIEF"",
		""type"": ""NPC"",
		""englishName"": ""Bandit"",
		""name"": ""Bandit"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Bohldohr"",
		""type"": ""NPC"",
		""englishName"": ""Bohldohr"",
		""name"": ""Bohldohr"",
		""state"": ""A traduire""
	},
	{
		""id"": ""BrimstoneHeart"",
		""type"": ""NPC"",
		""englishName"": ""Brimstone Heart"",
		""name"": ""Brimstone Heart"",
		""state"": ""A traduire""
	},
	{
		""id"": ""WITCH"",
		""type"": ""NPC"",
		""englishName"": ""Brimstone Witch"",
		""name"": ""Brimstone Witch"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CalamitasClone"",
		""type"": ""NPC"",
		""englishName"": ""Calamitas"",
		""name"": ""Calamitas"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Cataclysm"",
		""type"": ""NPC"",
		""englishName"": ""Cataclysm"",
		""name"": ""Cataclysm"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Catastrophe"",
		""type"": ""NPC"",
		""englishName"": ""Catastrophe"",
		""name"": ""Catastrophe"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SupremeCatastrophe"",
		""type"": ""NPC"",
		""englishName"": ""Catastrophe"",
		""name"": ""Catastrophe"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Cnidrion"",
		""type"": ""NPC"",
		""englishName"": ""Cnidrion"",
		""name"": ""Cnidrion"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CorruptSlimeSpawn2"",
		""type"": ""NPC"",
		""englishName"": ""Corrupt Slime Spawn"",
		""name"": ""Corrupt Slime Spawn"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CorruptSlimeSpawn"",
		""type"": ""NPC"",
		""englishName"": ""Corrupt Slime Spawn"",
		""name"": ""Corrupt Slime Spawn"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CosmicGuardianBody"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Guardian"",
		""name"": ""Cosmic Guardian"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CosmicGuardianHead"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Guardian"",
		""name"": ""Cosmic Guardian"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CosmicGuardianTail"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Guardian"",
		""name"": ""Cosmic Guardian"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CosmicMine"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Mine"",
		""name"": ""Cosmic Mine"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Crabulon"",
		""type"": ""NPC"",
		""englishName"": ""Crabulon"",
		""name"": ""Crabulon"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CrimsonSlimeSpawn2"",
		""type"": ""NPC"",
		""englishName"": ""Crimson Slime Spawn"",
		""name"": ""Crimson Slime Spawn"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CrimsonSlimeSpawn"",
		""type"": ""NPC"",
		""englishName"": ""Crimson Slime Spawn"",
		""name"": ""Crimson Slime Spawn"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SplitCrimulanSlimeGod"",
		""type"": ""NPC"",
		""englishName"": ""Crimulan Slime God"",
		""name"": ""Crimulan Slime God"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CrimulanSlimeGod"",
		""type"": ""NPC"",
		""englishName"": ""Crimulan Slime God"",
		""name"": ""Crimulan Slime God"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CryogenShield"",
		""type"": ""NPC"",
		""englishName"": ""Cryogen's Shield"",
		""name"": ""Cryogen's Shield"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Cryon"",
		""type"": ""NPC"",
		""englishName"": ""Cryon"",
		""name"": ""Cryon"",
		""state"": ""A traduire""
	},
	{
		""id"": ""CalamitasEnchantDemon"",
		""type"": ""NPC"",
		""englishName"": ""Demon"",
		""name"": ""Demon"",
		""state"": ""A traduire""
	},
	{
		""id"": ""WildBumblefuck"",
		""type"": ""NPC"",
		""englishName"": ""Draconic Swarmer"",
		""name"": ""Draconic Swarmer"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Draedon"",
		""type"": ""NPC"",
		""englishName"": ""Draedon"",
		""name"": ""Draedon"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SplitEbonianSlimeGod"",
		""type"": ""NPC"",
		""englishName"": ""Ebonian Slime God"",
		""name"": ""Ebonian Slime God"",
		""state"": ""A traduire""
	},
	{
		""id"": ""EbonianSlimeGod"",
		""type"": ""NPC"",
		""englishName"": ""Ebonian Slime God"",
		""name"": ""Ebonian Slime God"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ExhumedHeart"",
		""type"": ""NPC"",
		""englishName"": ""Exhumed Brimstone Heart"",
		""name"": ""Exhumed Brimstone Heart"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ProfanedGuardianCommander"",
		""type"": ""NPC"",
		""englishName"": ""Guardian Commander"",
		""name"": ""Guardian Commander"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ProfanedGuardianDefender"",
		""type"": ""NPC"",
		""englishName"": ""Guardian Defender"",
		""name"": ""Guardian Defender"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ProfanedGuardianHealer"",
		""type"": ""NPC"",
		""englishName"": ""Guardian Healer"",
		""name"": ""Guardian Healer"",
		""state"": ""A traduire""
	},
	{
		""id"": ""IceClasper"",
		""type"": ""NPC"",
		""englishName"": ""Ice Clasper"",
		""name"": ""Ice Clasper"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AnahitasIceShield"",
		""type"": ""NPC"",
		""englishName"": ""Ice Shield"",
		""name"": ""Ice Shield"",
		""state"": ""A traduire""
	},
	{
		""id"": ""LecherousOrb"",
		""type"": ""NPC"",
		""englishName"": ""Lecherous Orb"",
		""name"": ""Lecherous Orb"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Melter"",
		""type"": ""NPC"",
		""englishName"": ""Melter"",
		""name"": ""Melter"",
		""state"": ""A traduire""
	},
	{
		""id"": ""DemonPortal"",
		""type"": ""NPC"",
		""englishName"": ""Mysterious Portal"",
		""name"": ""Mysterious Portal"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Nova"",
		""type"": ""NPC"",
		""englishName"": ""Nova"",
		""name"": ""Nova"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Orthocera"",
		""type"": ""NPC"",
		""englishName"": ""Orthocera"",
		""name"": ""Orthocera"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PestilentSlime"",
		""type"": ""NPC"",
		""englishName"": ""Pestilent Slime"",
		""name"": ""Pestilent Slime"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PlagueChargerLarge"",
		""type"": ""NPC"",
		""englishName"": ""Plague Charger"",
		""name"": ""Plague Charger"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PlagueCharger"",
		""type"": ""NPC"",
		""englishName"": ""Plague Charger"",
		""name"": ""Plague Charger"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PlaguebringerMiniboss"",
		""type"": ""NPC"",
		""englishName"": ""Plaguebringer"",
		""name"": ""Plaguebringer"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Plagueshell"",
		""type"": ""NPC"",
		""englishName"": ""Plagueshell"",
		""name"": ""Plagueshell"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PrismBack"",
		""type"": ""NPC"",
		""englishName"": ""Prism-Back"",
		""name"": ""Prism-Back"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ReaperShark"",
		""type"": ""NPC"",
		""englishName"": ""Reaper Shark"",
		""name"": ""Reaper Shark"",
		""state"": ""A traduire""
	},
	{
		""id"": ""RepairUnitCritter"",
		""type"": ""NPC"",
		""englishName"": ""Repair Unit"",
		""name"": ""Repair Unit"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Rimehound"",
		""type"": ""NPC"",
		""englishName"": ""Rimehound"",
		""name"": ""Rimehound"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Rotdog"",
		""type"": ""NPC"",
		""englishName"": ""Rotdog"",
		""name"": ""Rotdog"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ScryllarRage"",
		""type"": ""NPC"",
		""englishName"": ""Scryllar"",
		""name"": ""Scryllar"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Scryllar"",
		""type"": ""NPC"",
		""englishName"": ""Scryllar"",
		""name"": ""Scryllar"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SepulcherBodyEnergyBall"",
		""type"": ""NPC"",
		""englishName"": ""Sepulcher"",
		""name"": ""Sepulcher"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SepulcherHead"",
		""type"": ""NPC"",
		""englishName"": ""Sepulcher"",
		""name"": ""Sepulcher"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SepulcherTail"",
		""type"": ""NPC"",
		""englishName"": ""Sepulcher"",
		""name"": ""Sepulcher"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SepulcherBody"",
		""type"": ""NPC"",
		""englishName"": ""Sepulcher"",
		""name"": ""Sepulcher"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SepulcherArm"",
		""type"": ""NPC"",
		""englishName"": ""Sepulcher"",
		""name"": ""Sepulcher"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Stormlion"",
		""type"": ""NPC"",
		""englishName"": ""Stormlion"",
		""name"": ""Stormlion"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SulphurousSharkron"",
		""type"": ""NPC"",
		""englishName"": ""Sulphurous Sharkron"",
		""name"": ""Sulphurous Sharkron"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SulphurousSkater"",
		""type"": ""NPC"",
		""englishName"": ""Sulphurous Skater"",
		""name"": ""Sulphurous Skater"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Trilobite"",
		""type"": ""NPC"",
		""englishName"": ""Trilobite"",
		""name"": ""Trilobite"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Viruling"",
		""type"": ""NPC"",
		""englishName"": ""Viruling"",
		""name"": ""Viruling"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AresBody"",
		""type"": ""NPC"",
		""englishName"": ""XF-09 Ares"",
		""name"": ""XF-09 Ares"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AresGaussNuke"",
		""type"": ""NPC"",
		""englishName"": ""XF-09 Ares Gauss Nuke"",
		""name"": ""XF-09 Ares Gauss Nuke"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AresLaserCannon"",
		""type"": ""NPC"",
		""englishName"": ""XF-09 Ares Laser Cannon"",
		""name"": ""XF-09 Ares Laser Cannon"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AresPlasmaFlamethrower"",
		""type"": ""NPC"",
		""englishName"": ""XF-09 Ares Plasma Cannon"",
		""name"": ""XF-09 Ares Plasma Cannon"",
		""state"": ""A traduire""
	},
	{
		""id"": ""AresTeslaCannon"",
		""type"": ""NPC"",
		""englishName"": ""XF-09 Ares Tesla Cannon"",
		""name"": ""XF-09 Ares Tesla Cannon"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ThanatosHead"",
		""type"": ""NPC"",
		""englishName"": ""XM-05 Thanatos"",
		""name"": ""XM-05 Thanatos"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ThanatosBody2"",
		""type"": ""NPC"",
		""englishName"": ""XM-05 Thanatos"",
		""name"": ""XM-05 Thanatos"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ThanatosBody1"",
		""type"": ""NPC"",
		""englishName"": ""XM-05 Thanatos"",
		""name"": ""XM-05 Thanatos"",
		""state"": ""A traduire""
	},
	{
		""id"": ""ThanatosTail"",
		""type"": ""NPC"",
		""englishName"": ""XM-05 Thanatos"",
		""name"": ""XM-05 Thanatos"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Artemis"",
		""type"": ""NPC"",
		""englishName"": ""XS-01 Artemis"",
		""name"": ""XS-01 Artemis"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Apollo"",
		""type"": ""NPC"",
		""englishName"": ""XS-03 Apollo"",
		""name"": ""XS-03 Apollo"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalSummonText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Do you enjoy going through hell?"",
		""name"": """",
		""desc"": ""Do you enjoy going through hell?"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalStartText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You should have just died..."",
		""name"": """",
		""desc"": ""You should have just died..."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalBH2Text"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""It wasn't too long ago you barely managed to defeat my doppelganger. Quite the failure, wasn't it?"",
		""name"": """",
		""desc"": ""It wasn't too long ago you barely managed to defeat my doppelganger. Quite the failure, wasn't it?"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalBH3Text"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You've harnessed great power, but you wield it for no one but yourself."",
		""name"": """",
		""desc"": ""You've harnessed great power, but you wield it for no one but yourself."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalBrothersText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Would you like to meet my family? Horrible, isn't it?"",
		""name"": """",
		""desc"": ""Would you like to meet my family? Horrible, isn't it?"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalPhase2Text"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You will suffer greatly."",
		""name"": """",
		""desc"": ""You will suffer greatly."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalBH4Text"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""It's absurd to even think of trying to get away. As long as you live, you will suffer."",
		""name"": """",
		""desc"": ""It's absurd to even think of trying to get away. As long as you live, you will suffer."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalSeekerRingText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""An upstart who recklessly stole and killed their way to power. I wonder, who does that remind me of...?"",
		""name"": """",
		""desc"": ""An upstart who recklessly stole and killed their way to power. I wonder, who does that remind me of...?"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalBH5Text"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You have no stake in this battle. No one gave you any say in this matter!"",
		""name"": """",
		""desc"": ""You have no stake in this battle. No one gave you any say in this matter!"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalSepulcher2Text"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Once the dust has settled and only one remains, if it is you, what value will this have had?!"",
		""name"": """",
		""desc"": ""Once the dust has settled and only one remains, if it is you, what value will this have had?!"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalDesparationText1"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Just stop!"",
		""name"": """",
		""desc"": ""Just stop!"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalDesparationText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""I have no future if I lose here."",
		""name"": """",
		""desc"": ""I have no future if I lose here."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalDesparationText3"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Once you have bested me, you will only have one path forward."",
		""name"": """",
		""desc"": ""Once you have bested me, you will only have one path forward."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalDesparationText4"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""And that path... also has no future."",
		""name"": """",
		""desc"": ""And that path... also has no future."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalAcceptanceText1"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Even if he has thrown all else away, his power remains."",
		""name"": """",
		""desc"": ""Even if he has thrown all else away, his power remains."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalAcceptanceText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""I have no more energy left to resent him, or you..."",
		""name"": """",
		""desc"": ""I have no more energy left to resent him, or you..."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalAcceptanceText3"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""It will all be in your hands now."",
		""name"": """",
		""desc"": ""It will all be in your hands now."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalSummonTextRematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""If you’re looking for some fourth-degree burns, you’ve got the right person."",
		""name"": """",
		""desc"": ""If you’re looking for some fourth-degree burns, you’ve got the right person."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalStartTextRematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""When the time comes, would you like to join my creation?"",
		""name"": """",
		""desc"": ""When the time comes, would you like to join my creation?"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalBH2TextRematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You’ll still have to work hard for this victory."",
		""name"": """",
		""desc"": ""You’ll still have to work hard for this victory."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalBH3TextRematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""I haven’t had such an interesting target dummy to test my magic on in a long time."",
		""name"": """",
		""desc"": ""I haven’t had such an interesting target dummy to test my magic on in a long time."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalBrothersTextRematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Empty shells of their former selves. I doubt even a scrap of their spirits remain."",
		""name"": """",
		""desc"": ""Empty shells of their former selves. I doubt even a scrap of their spirits remain."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalPhase2TextRematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Here we go again."",
		""name"": """",
		""desc"": ""Here we go again."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalBH4TextRematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""I wonder if you’ve seen these in your nightmares since our first battle?"",
		""name"": """",
		""desc"": ""I wonder if you’ve seen these in your nightmares since our first battle?"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalSeekerRingTextRematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Your skill hasn't faltered in the least."",
		""name"": """",
		""desc"": ""Your skill hasn't faltered in the least."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalBH5TextRematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Isn't this exciting?"",
		""name"": """",
		""desc"": ""Isn't this exciting?"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalSepulcher2TextRematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Here comes the crawling tomb, one last time."",
		""name"": """",
		""desc"": ""Here comes the crawling tomb, one last time."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalDesparationText1Rematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A terrific display, I concede this match to you."",
		""name"": """",
		""desc"": ""A terrific display, I concede this match to you."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalDesparationText2Rematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""No doubt you will face enemies stronger than I."",
		""name"": """",
		""desc"": ""No doubt you will face enemies stronger than I."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalDesparationText3Rematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""I trust you will not make the same mistakes he did."",
		""name"": """",
		""desc"": ""I trust you will not make the same mistakes he did."",
		""state"": ""A traduire""
	},
	{
		""id"": ""SCalDesparationText4Rematch"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""I can’t imagine what your future holds now."",
		""name"": """",
		""desc"": ""I can’t imagine what your future holds now."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonIntroductionText1"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""I have waited long for this moment."",
		""name"": """",
		""desc"": ""I have waited long for this moment."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonIntroductionText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Your nature fascinates me, for I do not understand it."",
		""name"": """",
		""desc"": ""Your nature fascinates me, for I do not understand it."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonIntroductionText3"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You will face my creations which have surpassed gods."",
		""name"": """",
		""desc"": ""You will face my creations which have surpassed gods."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonIntroductionText4"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""And you will show me your disposition through battle."",
		""name"": """",
		""desc"": ""And you will show me your disposition through battle."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonIntroductionText5"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Now, choose."",
		""name"": """",
		""desc"": ""Now, choose."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase1Text1"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Designs improved with time and knowledge are the essence of my work."",
		""name"": """",
		""desc"": ""Designs improved with time and knowledge are the essence of my work."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase1Text2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Through no other method can I approach perfection."",
		""name"": """",
		""desc"": ""Through no other method can I approach perfection."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase2Text1"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Your performance falls neatly within the margins of error."",
		""name"": """",
		""desc"": ""Your performance falls neatly within the margins of error."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase2Text2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""That is quite satisfactory. We will proceed to the next phase of testing."",
		""name"": """",
		""desc"": ""That is quite satisfactory. We will proceed to the next phase of testing."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase3Text1"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Ever since I was alerted to your presence, I have processed your battles in order to make my machines stronger."",
		""name"": """",
		""desc"": ""Ever since I was alerted to your presence, I have processed your battles in order to make my machines stronger."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase3Text2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Even now, I monitor your actions. Nothing should escape the bounds of my calculations."",
		""name"": """",
		""desc"": ""Even now, I monitor your actions. Nothing should escape the bounds of my calculations."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase4Text1"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Curious. Very curious."",
		""name"": """",
		""desc"": ""Curious. Very curious."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase4Text2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You progress steadily against more difficult challenges."",
		""name"": """",
		""desc"": ""You progress steadily against more difficult challenges."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase5Text1"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Your nature remains unknown to me. This will not do."",
		""name"": """",
		""desc"": ""Your nature remains unknown to me. This will not do."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase5Text2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""...I sought perfection. Fate must favor irony, for that must have been my first mistake."",
		""name"": """",
		""desc"": ""...I sought perfection. Fate must favor irony, for that must have been my first mistake."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase6Text1"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Absurd."",
		""name"": """",
		""desc"": ""Absurd."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase6Text2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""I will no longer let my calculations impede my observation of this battle."",
		""name"": """",
		""desc"": ""I will no longer let my calculations impede my observation of this battle."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonExoPhase6Text3"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""I shall show you the full fury of my final machine."",
		""name"": """",
		""desc"": ""I shall show you the full fury of my final machine."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonAresEnrageText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""How foolish. You cannot escape."",
		""name"": """",
		""desc"": ""How foolish. You cannot escape."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonResummonText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Make your choice."",
		""name"": """",
		""desc"": ""Make your choice."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonEndText1"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""An unknown factor-a catalyst is what you are."",
		""name"": """",
		""desc"": ""An unknown factor-a catalyst is what you are."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonEndText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Nearly as alien as I, to this land and its history."",
		""name"": """",
		""desc"": ""Nearly as alien as I, to this land and its history."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonEndText3"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""...Excuse my introspection. I must gather my thoughts after that display."",
		""name"": """",
		""desc"": ""...Excuse my introspection. I must gather my thoughts after that display."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonEndText4"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""This land has become stale and stiff with blood that has been spilled until now."",
		""name"": """",
		""desc"": ""This land has become stale and stiff with blood that has been spilled until now."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonEndText5"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You have also spilled blood, but it may be enough to usher a new age... Of what, I do not know. But it is something I am eager to see."",
		""name"": """",
		""desc"": ""You have also spilled blood, but it may be enough to usher a new age... Of what, I do not know. But it is something I am eager to see."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonEndText6"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Now. You wish to reach the Tyrant. I cannot assist you in that."",
		""name"": """",
		""desc"": ""Now. You wish to reach the Tyrant. I cannot assist you in that."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonEndText7"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""It is not a matter of spite, for I would wish nothing more than to observe such a conflict."",
		""name"": """",
		""desc"": ""It is not a matter of spite, for I would wish nothing more than to observe such a conflict."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonEndText8"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""But you have managed before. You will find a way eventually."",
		""name"": """",
		""desc"": ""But you have managed before. You will find a way eventually."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonEndText9"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""I must acknowledge your triumph, but I will return now to my machinery."",
		""name"": """",
		""desc"": ""I must acknowledge your triumph, but I will return now to my machinery."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DraedonEndKillAttemptText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""...Quite unnecessary."",
		""name"": """",
		""desc"": ""...Quite unnecessary."",
		""state"": ""A traduire""
	},
	{
		""id"": ""HardmodeOreTier1Text"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Your world has been blessed with Cobalt and Palladium!"",
		""name"": """",
		""desc"": ""Your world has been blessed with Cobalt and Palladium!"",
		""state"": ""A traduire""
	},
	{
		""id"": ""HardmodeOreTier2Text"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Your world has been blessed with Mythril and Orichalcum!"",
		""name"": """",
		""desc"": ""Your world has been blessed with Mythril and Orichalcum!"",
		""state"": ""A traduire""
	},
	{
		""id"": ""HardmodeOreTier3Text"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Your world has been blessed with Adamantite and Titanium!"",
		""name"": """",
		""desc"": ""Your world has been blessed with Adamantite and Titanium!"",
		""state"": ""A traduire""
	},
	{
		""id"": ""HardmodeOreTier4Text"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The hallow has been blessed with consecrated stone!"",
		""name"": """",
		""desc"": ""The hallow has been blessed with consecrated stone!"",
		""state"": ""A traduire""
	},
	{
		""id"": ""MaliceText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Malice is active; witness the horror!"",
		""name"": """",
		""desc"": ""Malice is active; witness the horror!"",
		""state"": ""A traduire""
	},
	{
		""id"": ""MaliceText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Malice is not active."",
		""name"": """",
		""desc"": ""Malice is not active."",
		""state"": ""A traduire""
	},
	{
		""id"": ""ArmageddonDodgeDisable"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""All of your dodges are now disabled."",
		""name"": """",
		""desc"": ""All of your dodges are now disabled."",
		""state"": ""A traduire""
	},
	{
		""id"": ""ArmageddonDodgeEnable"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""All of your dodges are now re-enabled."",
		""name"": """",
		""desc"": ""All of your dodges are now re-enabled."",
		""state"": ""A traduire""
	},
	{
		""id"": ""DefenseDamage"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Defense Damage"",
		""name"": """",
		""desc"": ""Defense Damage"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Tier1ArsenalRecipeCondition"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""View an unencrypted schematic from the lab near the Sunken Sea"",
		""name"": """",
		""desc"": ""View an unencrypted schematic from the lab near the Sunken Sea"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Tier2ArsenalRecipeCondition"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Decrypt a schematic from the lab in the large planetoid in the sky"",
		""name"": """",
		""desc"": ""Decrypt a schematic from the lab in the large planetoid in the sky"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Tier3ArsenalRecipeCondition"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Decrypt a schematic from the lab deep within the jungle"",
		""name"": """",
		""desc"": ""Decrypt a schematic from the lab deep within the jungle"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Tier4ArsenalRecipeCondition"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Decrypt a schematic from the lab near the edges of the underworld"",
		""name"": """",
		""desc"": ""Decrypt a schematic from the lab near the edges of the underworld"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Tier5ArsenalRecipeCondition"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Decrypt a schematic from the lab deep within the frozen caverns"",
		""name"": """",
		""desc"": ""Decrypt a schematic from the lab deep within the frozen caverns"",
		""state"": ""A traduire""
	},
	{
		""id"": ""SunkenSeaSchematicRecipeCondition"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Place a schematic from the lab near the Sunken Sea in your inventory at least once"",
		""name"": """",
		""desc"": ""Place a schematic from the lab near the Sunken Sea in your inventory at least once"",
		""state"": ""A traduire""
	},
	{
		""id"": ""PlanetoidSchematicRecipeCondition"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Place a schematic from the lab in the large planetoid in your inventory at least once"",
		""name"": """",
		""desc"": ""Place a schematic from the lab in the large planetoid in your inventory at least once"",
		""state"": ""A traduire""
	},
	{
		""id"": ""JungleSchematicRecipeCondition"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Place a schematic from the lab deep within the jungle in your inventory at least once"",
		""name"": """",
		""desc"": ""Place a schematic from the lab deep within the jungle in your inventory at least once"",
		""state"": ""A traduire""
	},
	{
		""id"": ""UnderworldSchematicRecipeCondition"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Place a schematic from the lab near the edges of the underworld in your inventory at least once"",
		""name"": """",
		""desc"": ""Place a schematic from the lab near the edges of the underworld in your inventory at least once"",
		""state"": ""A traduire""
	},
	{
		""id"": ""IceSchematicRecipeCondition"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Place a schematic from the lab within the frozen caverns in your inventory at least once"",
		""name"": """",
		""desc"": ""Place a schematic from the lab within the frozen caverns in your inventory at least once"",
		""state"": ""A traduire""
	},
	{
		""id"": ""Afflicted"",
		""type"": ""BUFF"",
		""englishName"": ""Afflicted"",
		""englishDesc"": ""Empowered by otherworldly spirits"",
		""name"": ""Affligé"",
		""desc"": ""Renforcé par les esprits d'un autre monde"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DraconicSurgeBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Draconic Surge"",
		""englishDesc"": ""The power of a dragon courses through your veins"",
		""name"": ""Afflux Draconique"",
		""desc"": ""Le pouvoir d'un dragon circule dans vos veines"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AlicornBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Alicorn"",
		""englishDesc"": ""You beat DoG while drunk, you are truly fabulous!"",
		""name"": ""Alicorn"",
		""desc"": ""Vous avez battu le Dévoreur de Dieux en étant ivre, vous êtes vraiment fabuleux!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FungalClumpBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Fungal Clump"",
		""englishDesc"": ""The fungal clump will protect you"",
		""name"": ""Amas Fongique"",
		""desc"": ""L'amas fongique vous protégera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PolarisBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Polaris Boost"",
		""englishDesc"": ""The Northern Star empowers your weapon"",
		""name"": ""Amélioration Polaris"",
		""desc"": ""L'étoile du nord renforce votre arme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WaterWaifu"",
		""type"": ""BUFF"",
		""englishName"": ""Anahita"",
		""englishDesc"": ""Anahita will protect you"",
		""name"": ""Anahita"",
		""desc"": ""Anahita vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PineappleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Pineapple"",
		""englishDesc"": ""It smells like pizza..."",
		""name"": ""Ananas"",
		""desc"": ""Ca sens la pizza..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""AndromedaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Andromeda"",
		""englishDesc"": ""You're controlling a piece of history"",
		""name"": ""Andromeda"",
		""desc"": ""Vous controlez un morceau de l'histoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AndromedaSmallBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Andromeda"",
		""englishDesc"": ""You're controlling a small piece of history"",
		""name"": ""Andromède"",
		""desc"": ""Vous controlez un petit morceau de l'histoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ArmorCrunch"",
		""type"": ""BUFF"",
		""englishName"": ""Armor Crunch"",
		""englishDesc"": ""Your armor is shredded"",
		""name"": ""Armure Broyée"",
		""desc"": ""Votre armure est broyée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstrophageBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Astrophage"",
		""englishDesc"": ""Little astral buggy"",
		""name"": ""Astrophage"",
		""desc"": ""Petit compagnon astral"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodfinBoost"",
		""type"": ""BUFF"",
		""englishName"": ""Bloodfin Boost"",
		""englishDesc"": ""Don't let the blood get to your head"",
		""name"": ""Augmentation de Nageoire de Sang"",
		""desc"": ""Ne laisse pas le sang te monter à la tête"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ShellBoost"",
		""type"": ""BUFF"",
		""englishName"": ""Shell Speed Boost"",
		""englishDesc"": ""Speed is boosted"",
		""name"": ""Augmentation de Vitesse de Carapace"",
		""desc"": ""La vitesse est augmentée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PearlAura"",
		""type"": ""BUFF"",
		""englishName"": ""Pearl Aura"",
		""englishDesc"": ""Slowed down"",
		""name"": ""Aura de Perle"",
		""desc"": ""Ralenti"",
		""state"": ""Traduit""
	},
	{
		""id"": ""StarSwallowerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Star Swallower"",
		""englishDesc"": ""Mmmm myes"",
		""name"": ""Avaleur d'Étoiles"",
		""desc"": ""Mmmm moui"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ViridVanguardBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Virid Vanguard"",
		""englishDesc"": ""A perfect act of unity surrounds you"",
		""name"": ""Avant-Garde Viride"",
		""desc"": ""Une parfaite unisson vous entoure"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BaguetteBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Baguette"",
		""englishDesc"": ""If only I knew... ~Cirrus"",
		""name"": ""Baguette"",
		""desc"": ""Si seulement j'avais subi... ~Cirrus"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GrapeBeerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Grape Beer"",
		""englishDesc"": ""Defense and movement speed reduced"",
		""name"": ""Bière au Raisin"",
		""desc"": ""Défense et vitesse de mouvement réduites"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodyMaryBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Bloody Mary"",
		""englishDesc"": ""Damage, critical strike chance, movement speed, and melee speed boosted during a Blood Moon, life regen and defense reduced"",
		""name"": ""Bloody Mary"",
		""desc"": ""Dégâts, chances de coup critique, vitesse de déplacement et vitesse de corps à corps augmentée pendant une lune de sang, régénération de vie et défense réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AvertorBonus"",
		""type"": ""BUFF"",
		""englishName"": ""Avertor Bonus"",
		""englishDesc"": ""Boosted damage and life regeneration"",
		""name"": ""Bonus d'Avertor"",
		""desc"": ""Dégâts et régénration de vie augmentés"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodyBoost"",
		""type"": ""BUFF"",
		""englishName"": ""Bloody Boost"",
		""englishDesc"": ""Increased offensive and defensive stats\\nHealing potions grant more health"",
		""name"": ""Boost Sanguin"",
		""desc"": ""Augmente les statistiques d'attaque et de défense\\nLes potions de vie rendent plus de vie"",
		""state"": ""Traduit""
	},
	{
		""id"": ""IceShieldBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Ice Shield"",
		""englishDesc"": ""Absorbs 20% damage from the next hit you take, then shatters"",
		""name"": ""Bouclier de Glace"",
		""desc"": ""Absorbe 20% des dégats de la prochaine attaque, puis se brise"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TranquilityCandleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tranquility Candle"",
		""englishDesc"": ""Spawn rates around the candle are reduced!"",
		""name"": ""Bougie de Tranquillité"",
		""desc"": ""Le taux d'apparition des ennemis est réduit près de la bougie!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ChaosCandleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Chaos Candle"",
		""englishDesc"": ""Spawn rates around the candle are boosted!"",
		""name"": ""Bougie du Chaos"",
		""desc"": ""Le taux d'apparition des ennemis près de la bougie est augmenté!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ManaBurn"",
		""type"": ""BUFF"",
		""englishName"": ""Mana Burn"",
		""englishDesc"": ""The excess of mana sears your body and mind"",
		""name"": ""Brûlure de Mana"",
		""desc"": ""L'excès de mana brûle votre corps et votre esprit"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RancorBurn"",
		""type"": ""BUFF"",
		""englishName"": ""Rancor Burn"",
		""englishDesc"": ""Burning"",
		""name"": ""Brûlure de Rancoeur"",
		""desc"": ""Vous brûlez"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BumbledogeMount"",
		""type"": ""BUFF"",
		""englishName"": ""Bumbledoge"",
		""englishDesc"": ""Wait a second. That's not right..."",
		""name"": ""Bumbledoge"",
		""desc"": ""Attends une seconde. Y a un truc qui cloche..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""BabyGhostBellBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Baby Ghost Bell"",
		""englishDesc"": ""Be careful not to pop the bubble"",
		""name"": ""Bébé Cloche Fantôme"",
		""desc"": ""Attention de ne pas éclater la bulle"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguebringerBabBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Plaguebringer Bab"",
		""englishDesc"": ""The baby plaguebringer sees you as the queen"",
		""name"": ""Bébé Colporte-Peste"",
		""desc"": ""Le bébé colporte-peste vous considère comme sa mère"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DivineBless"",
		""type"": ""BUFF"",
		""englishName"": ""Divine Bless"",
		""englishDesc"": ""Increased health regen and minions inflict Banishing Fire"",
		""name"": ""Bénédiction Divine"",
		""desc"": ""Régénération de vie augmentée et les sbires infligent le feu bannissant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AmidiasBlessing"",
		""type"": ""BUFF"",
		""englishName"": ""Amidias' Blessing"",
		""englishDesc"": ""You are blessed by Amidias\\nLets you breathe underwater, even in the Abyss!\\nJust don't get hit..."",
		""name"": ""Bénédiction d'Amidias"",
		""desc"": ""Vous êtes béni par Amidias\\nVous permet de respirer sous l'eau, même dans les abysses!\\nEvite juste de te faire toucher..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodClot"",
		""type"": ""BUFF"",
		""englishName"": ""Blood Clot"",
		""englishDesc"": ""The blood clot will protect you"",
		""name"": ""Caillot Sanguin"",
		""desc"": ""Le caillot sanguin vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Calamari"",
		""type"": ""BUFF"",
		""englishName"": ""Calamari"",
		""englishDesc"": ""The squid will protect you"",
		""name"": ""Calamari"",
		""desc"": ""Le calamar vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CalciumBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Calcium"",
		""englishDesc"": ""You are immune to fall damage"",
		""name"": ""Calcium"",
		""desc"": ""Vous êtes immunisé aux dégâts de chute"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MagicHatBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Magic Hat"",
		""englishDesc"": ""The hat carries your soul, bound by a contract"",
		""name"": ""Chapeau Magique"",
		""desc"": ""Le chapeau transporte votre âme, lié par un contrat"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SoulSeekerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Soul Seeker"",
		""englishDesc"": ""It definitely wants something from you"",
		""name"": ""Cherche-Âme"",
		""desc"": ""Il veut définitivement quelque chose de vous"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ChiBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Chi"",
		""englishDesc"": ""Your next attack is boosted and you are more resilient"",
		""name"": ""Chi"",
		""desc"": ""Votre prochaine attaque est renforcée et vous êtes plus résilient"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Clamity"",
		""type"": ""BUFF"",
		""englishName"": ""Clamity"",
		""englishDesc"": ""The clams have been angered!"",
		""name"": ""Clamité"",
		""desc"": ""Les palourdes ont été provoquées!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""IceClasperBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Ice Clasper"",
		""englishDesc"": ""The ice clasper will protect you"",
		""name"": ""Claspeur de Glace"",
		""desc"": ""Le claspeur de glace vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HowlTrio"",
		""type"": ""BUFF"",
		""englishName"": ""Howl's Heart"",
		""englishDesc"": ""Howl protects you, Calcifer lights your way, Turnip-Head stalks you"",
		""name"": ""Coeur de Howl"",
		""desc"": ""Howl vous protège, Calcifer illumine la voir et tête de navet vous traque"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HotE"",
		""type"": ""BUFF"",
		""englishName"": ""Heart of the Elements"",
		""englishDesc"": ""All elementals will protect you"",
		""name"": ""Coeur des Éléments"",
		""desc"": ""Tous les élémentaires vous protégerons"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssalDivingSuitBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Diving Suit"",
		""englishDesc"": ""You are made of metal"",
		""name"": ""Combinaison de Plongée Abyssale"",
		""desc"": ""Vous êtes fait de métal"",
		""state"": ""Traduit""
	},
	{
		""id"": ""VoidConcentrationBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Concentrated Void"",
		""englishDesc"": ""The infinite void yearns for more..."",
		""name"": ""Concentrated Void"",
		""desc"": ""Le vide infini en désire plus..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""GlacialState"",
		""type"": ""BUFF"",
		""englishName"": ""Glacial State"",
		""englishDesc"": ""Cannot move"",
		""name"": ""Congelé"",
		""desc"": ""Vous ne pouvez pas bouger"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CorvidHarbringerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Raven"",
		""englishDesc"": ""The powerful raven will protect you"",
		""name"": ""Corbeau"",
		""desc"": ""Un puissant corbeau vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Corroslime"",
		""type"": ""BUFF"",
		""englishName"": ""Corroslime"",
		""englishDesc"": ""The corroslime will protect you"",
		""name"": ""Corrogelée"",
		""desc"": ""La corrogelée vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TeslaFreeze"",
		""type"": ""BUFF"",
		""englishName"": ""Galvanic Corrosion"",
		""englishDesc"": ""Your limbs have begun to corrode"",
		""name"": ""Corrosion Galvanique"",
		""desc"": ""Vous membres ont commencé à rouiller"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmilampBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Cosmilamp"",
		""englishDesc"": ""The cosmilamp will protect you"",
		""name"": ""Cosmolampe"",
		""desc"": ""La cosmolampe vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HermitCrab"",
		""type"": ""BUFF"",
		""englishName"": ""Hermit Crab"",
		""englishDesc"": ""The hermit crab will protect you"",
		""name"": ""Crabe Hermite"",
		""desc"": ""Le crabe hermite vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Crimslime"",
		""type"": ""BUFF"",
		""englishName"": ""Crimslime"",
		""englishDesc"": ""The crimslime will protect you"",
		""name"": ""Crimslime"",
		""desc"": ""La Gelée Carmine vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ShellfishBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Shellfish"",
		""englishDesc"": ""The shellfish will protect you"",
		""name"": ""Crustacé"",
		""desc"": ""Le crustacé vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DannyDevito"",
		""type"": ""BUFF"",
		""englishName"": ""Danny Devito"",
		""englishDesc"": ""The trash man is following you."",
		""name"": ""Danny Devito"",
		""desc"": ""Le responsable des poubelles vous suit."",
		""state"": ""Traduit""
	},
	{
		""id"": ""DemonshadeSetDevilBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Red Devil"",
		""englishDesc"": ""The red devil will protect you"",
		""name"": ""Diable Rouge"",
		""desc"": ""Le diable rouge vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Warped"",
		""type"": ""BUFF"",
		""englishName"": ""Warped"",
		""englishDesc"": ""Movement is being warped"",
		""name"": ""Distordu"",
		""desc"": ""Les mouvements sont distordus"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ColdDivinityBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Cold Divinity"",
		""englishDesc"": ""The magic of the ancient ice castle will aid you"",
		""name"": ""Divinité Froide"",
		""desc"": ""La magie de l'ancien château de glace vous aidera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CausticStaffBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Caustic Dragon"",
		""englishDesc"": ""A mini jungle dragon is following you"",
		""name"": ""Dragon Caustique"",
		""desc"": ""Un dragon de la jungle miniature vous suit"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RustyDroneBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Rusty Drone"",
		""englishDesc"": ""A pitifully fragile drone is observing you"",
		""name"": ""Drone Rouillé"",
		""desc"": ""Un drône pitoyablement fragile vous observe"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumDroidBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Wulfrum Droid"",
		""englishDesc"": ""The wulfrum droid will protect you"",
		""name"": ""Droïde Wulfrum"",
		""desc"": ""Le droïde wulfrum vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FurtasticDuoBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Furtastic Duo"",
		""englishDesc"": ""They just did! The Furtastic Duo will accompany you!"",
		""name"": ""Duo Furmidable"",
		""desc"": ""Ils l'ont fait! Le duo furmidable vous accompagnera!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Shred"",
		""type"": ""BUFF"",
		""englishName"": ""Shred"",
		""englishDesc"": ""Someone built ten Tri-Tip Daggers..."",
		""name"": ""Déchiré"",
		""desc"": ""Quelqu'un a fabriqué 10 dagues a trois pointes..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""PoleWarperBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Pole Warper"",
		""englishDesc"": ""Sentient magnets are attracted to you"",
		""name"": ""Déformeur de Pôles"",
		""desc"": ""Vous attirez des aimants conscients"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedCrystalBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Devotion"",
		""englishDesc"": """",
		""name"": ""Dévotion"",
		""desc"": ""L'âme profanée contenue a été corrompue par la puissante magie d'une sorcière suprême"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TitanScale"",
		""type"": ""BUFF"",
		""englishName"": ""Titan Scale"",
		""englishDesc"": ""You feel tanky"",
		""name"": ""Ecaille de Titan"",
		""desc"": ""Vous vous sentez résistant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrimsonEffigyBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Crimson Effigy"",
		""englishDesc"": ""The crimson empowers you"",
		""name"": ""Effigie de Carmin"",
		""desc"": ""Le carmin vous renforce"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CorruptionEffigyBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Corruption Effigy"",
		""englishDesc"": ""The corruption empowers you"",
		""name"": ""Effigie de Corruption"",
		""desc"": ""La corruption vous renforce"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EffigyOfDecayBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Effigy of Decay"",
		""englishDesc"": ""The sulphuric waters empower you"",
		""name"": ""Effigy of Décomposition"",
		""desc"": ""Les eaux sulfuriques vous renforcent"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ArmorCrumbling"",
		""type"": ""BUFF"",
		""englishName"": ""Armor Crumbling"",
		""englishDesc"": ""Melee and rogue attacks break enemy armor"",
		""name"": ""Effritement d'Armure"",
		""desc"": ""Les attaques de mêlée et de voleur brisent l'armure"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SulphuricPoisoning"",
		""type"": ""BUFF"",
		""englishName"": ""Sulphuric Poisoning"",
		""englishDesc"": ""The acidic water burns away your flesh"",
		""name"": ""Empoisonnement Sulfurique"",
		""desc"": ""L'eau acide dissout votre chair"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Encased"",
		""type"": ""BUFF"",
		""englishName"": ""Encased"",
		""englishDesc"": ""30 defense and +30% damage reduction, but..."",
		""name"": ""Encastré"",
		""desc"": ""+30 défense et +30% de réduction de dégats, mais..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""EndoCooperBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Endo Cooper"",
		""englishDesc"": ""The ascened Cooper will protect you"",
		""name"": ""Endo Cooper"",
		""desc"": ""Le Cooper ascendé vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EndoHydraBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Endo Hydra"",
		""englishDesc"": ""The endo hydra will protect you... for some reason"",
		""name"": ""Endo Hydre"",
		""desc"": ""L'endo hydre vous protègera... pour une raison ou une autre"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GodSlayerInferno"",
		""type"": ""BUFF"",
		""englishName"": ""God Slayer Inferno"",
		""englishDesc"": ""Your flesh is burning off"",
		""name"": ""Enfer Déicide"",
		""desc"": ""Votre chair brûle"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HolyInferno"",
		""type"": ""BUFF"",
		""englishName"": ""Holy Inferno"",
		""englishDesc"": ""You've gone too far from the Profaned Goddess!"",
		""name"": ""Enfer Sacré"",
		""desc"": ""Vous vous êtes trop éloigné de la déesse profanée!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Enraged"",
		""type"": ""BUFF"",
		""englishName"": ""Enraged"",
		""englishDesc"": ""All damage taken is increased by 25%"",
		""name"": ""Enragé"",
		""desc"": ""Tous les dégâts subis sont augmentés de 25%"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Soaring"",
		""type"": ""BUFF"",
		""englishName"": ""Soaring"",
		""englishDesc"": ""Increased wing flight time and speed\\nTrue melee hits restore wing flight time"",
		""name"": ""Envol"",
		""desc"": ""Temps et vitesse de vol augmentés\\nLes attaques de vraie mêlée rendent du temps de vol"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SolarSpirit"",
		""type"": ""BUFF"",
		""englishName"": ""Solar Spirit"",
		""englishDesc"": ""The solar spirit will protect you"",
		""name"": ""Esprit Solaire"",
		""desc"": ""L'esprit solaire vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BelladonnaSpiritBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Belladonna Spirit"",
		""englishDesc"": ""A cute forest spirit is following you"",
		""name"": ""Esprit de Belladonne"",
		""desc"": ""Un esprit mignon de la forêt vous suit"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SageSpiritBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Sage Spirit"",
		""englishDesc"": ""It's uncomfortably close"",
		""name"": ""Esprit de Sauge"",
		""desc"": ""Il est un peu trop près"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TarraLifeRegen"",
		""type"": ""BUFF"",
		""englishName"": ""Tarra Life"",
		""englishDesc"": ""Rapid healing"",
		""name"": ""Estra-Vie"",
		""desc"": ""Guérison rapide"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Eutrophication"",
		""type"": ""BUFF"",
		""englishName"": ""Eutrophication"",
		""englishDesc"": ""Excessive nutrients restrict your movement"",
		""name"": ""Eutrophisation"",
		""desc"": ""L'excès de nutriment restreint vos mouvements"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EverclearBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Everclear"",
		""englishDesc"": ""Damage boosted, life regen and defense reduced"",
		""name"": ""Everclear"",
		""desc"": ""Dégâts augmentés, régénération de vie et défense réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""OnyxExcavatorBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Onyx Excavator"",
		""englishDesc"": ""Drill"",
		""name"": ""Excavateur Onyx"",
		""desc"": ""Foreuse"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DraedonGamerChairBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Exo Chair"",
		""englishDesc"": ""Riding a physics defying gamer chair"",
		""name"": ""Exo Chaise"",
		""desc"": ""Assis sur une chaise de gamer defiant la physique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ExoFreeze"",
		""type"": ""BUFF"",
		""englishName"": ""Exo Freeze"",
		""englishDesc"": ""Cannot move"",
		""name"": ""Exo Gel"",
		""desc"": ""Mouvement Impossible"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FabsolVodkaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Fab"",
		""englishDesc"": ""You feel fabulous"",
		""name"": ""Fab"",
		""desc"": ""Tu te sens Fabuleux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WeakBrimstoneFlames"",
		""type"": ""BUFF"",
		""englishName"": ""Weak Brimstone Flames"",
		""englishDesc"": ""Health loss"",
		""name"": ""Faible Brûlure Soufrée"",
		""desc"": ""Perte de vie"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WeakPetrification"",
		""type"": ""BUFF"",
		""englishName"": ""Weak Petrification"",
		""englishDesc"": ""Your vertical movement is weakened"",
		""name"": ""Faible Pétrification"",
		""desc"": ""Votre mouvement vertical est affaibli"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedWeakness"",
		""type"": ""BUFF"",
		""englishName"": ""Profaned Weakness"",
		""englishDesc"": ""You do less damage"",
		""name"": ""Faiblesse Profanée"",
		""desc"": ""Vous faîtes moins de dégâts"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CeaselessHunger"",
		""type"": ""BUFF"",
		""englishName"": ""Ceaseless Hunger"",
		""englishDesc"": ""You are sucking up all the items"",
		""name"": ""Faim Incessante"",
		""desc"": ""Vous attirez tous les objets"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Phantom"",
		""type"": ""BUFF"",
		""englishName"": ""Phantom"",
		""englishDesc"": ""The phantom will protect you"",
		""name"": ""Fantôme"",
		""desc"": ""Le fantôme vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BlackHawkBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Black Hawk"",
		""englishDesc"": ""The fighter jet will protect you"",
		""name"": ""Faucon Noir"",
		""desc"": ""Le jet de combat vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BanishingFire"",
		""type"": ""BUFF"",
		""englishName"": ""Banishing Fire"",
		""englishDesc"": ""You shall not be forgiven for your sins"",
		""name"": ""Feu Banisseur"",
		""desc"": ""Vous ne serez pas absous de vos péchés"",
		""state"": ""Traduit""
	},
	{
		""id"": ""YharonSonBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Son of Yharon"",
		""englishDesc"": ""You better not eat his dinner"",
		""name"": ""Fils de Yharon"",
		""desc"": ""T'as intêret à pas manger son diner"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FireballBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Fireball"",
		""englishDesc"": ""Fire debuff damage boosted, life regen reduced"",
		""name"": ""Fireball"",
		""desc"": ""Dégâts des altérations de feu augmentés, régénération de vie réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DemonFlames"",
		""type"": ""BUFF"",
		""englishName"": ""Demon Flames"",
		""englishDesc"": ""Another burning debuff"",
		""name"": ""Flammes Démoniaques"",
		""desc"": ""Une autre brûlure"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimstoneFlames"",
		""type"": ""BUFF"",
		""englishName"": ""Brimstone Flames"",
		""englishDesc"": ""Rapid health loss"",
		""name"": ""Flammes de soufre"",
		""desc"": ""Perte de vie rapide"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HolyFlames"",
		""type"": ""BUFF"",
		""englishName"": ""Holy Flames"",
		""englishDesc"": ""Dissolving from holy light"",
		""name"": ""Flammes sacrées"",
		""desc"": ""Dissolution par les flammes sacrées"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Nightwither"",
		""type"": ""BUFF"",
		""englishName"": ""Nightwither"",
		""englishDesc"": ""Incinerated by lunar rays"",
		""name"": ""Fletrinuit"",
		""desc"": ""Incinéré par les rayons lunaires"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FlowersOfMortalityBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Flowers of Mortality"",
		""englishDesc"": ""Celestial blossoms surround you"",
		""name"": ""Fleur de Mortalité"",
		""desc"": ""Des floraisons célestes vous entourent"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CinderBlossomBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Cinder Blossom"",
		""englishDesc"": ""A hot, searing flower is floating uncomfortably close to you"",
		""name"": ""Floraison de Cendre"",
		""desc"": ""Une chaude et brûlante fleur flotte inconfortablement près de vous"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TundraFlameBlossomsBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tundra Flame Blossom"",
		""englishDesc"": ""A perfect unison of balance and beauty"",
		""name"": ""Floraison de Feu de la Toundra"",
		""desc"": ""L'unisson parfait entre l'équilibre et la beauté"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WitherBlossomsBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Wither Blossoms"",
		""englishDesc"": ""Pestilence surrounds you"",
		""name"": ""Floraisons Flétries"",
		""desc"": ""La pestilence vous entoure"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Withered"",
		""type"": ""BUFF"",
		""englishName"": ""Withered"",
		""englishDesc"": ""Holding withered weapons causes you to suffer but makes your weapons strong"",
		""name"": ""Flétri"",
		""desc"": ""Tenir des armes flétries vous fait souffrir mais renforce vous armes"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WitherDebuff"",
		""type"": ""BUFF"",
		""englishName"": ""Wither"",
		""englishDesc"": ""Withered...\\nDefense reduced by 20"",
		""name"": ""Flétrissement"",
		""desc"": ""Flétri...\\nDéfense reduite de 20"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssalMadness"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Madness"",
		""englishDesc"": ""Increased damage, critical strike chance, and tentacle aggression/range"",
		""name"": ""Folie Abyssale"",
		""desc"": ""Dégâts, chances de coup critique et aggression/portée des tentacules augmentés"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ArmorShattering"",
		""type"": ""BUFF"",
		""englishName"": ""Armor Shattering"",
		""englishDesc"": ""Melee and rogue attacks break enemy armor"",
		""name"": ""Fracassement d'Armure"",
		""desc"": ""Les attaques de mêlée et de voleur brisent l'armure"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HolyWrathBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Holy Wrath"",
		""englishDesc"": ""Increased damage and all attacks inflict holy fire"",
		""name"": ""Fureur Divine"",
		""desc"": ""Dégâts augmentés et toutes les attaques infligent le feu sacré"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimflameFrenzyBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Brimflame Frenzy"",
		""englishDesc"": ""Dark magic empowers your attacks at the cost of your life"",
		""name"": ""Fureur Flammesoufre"",
		""desc"": ""La magie sombre vous renforce au prix de votre vie"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodflareBloodFrenzy"",
		""type"": ""BUFF"",
		""englishName"": ""Blood Frenzy"",
		""englishDesc"": ""Contact damage is reduced and melee stats are greatly increased"",
		""name"": ""Fureur de Sang"",
		""desc"": ""Les dégâts de contact sont réduits et les caractéristiques de mêlée sont grandement augmentées"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TyrantsFury"",
		""type"": ""BUFF"",
		""englishName"": ""Tyrant's Fury"",
		""englishDesc"": ""30% increased melee damage and 10% increased melee crit chance"",
		""name"": ""Fureur du Tyran"",
		""desc"": ""+30% de dégâts de mêlée et +10% dez chances de coup critique en mêlée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Molten"",
		""type"": ""BUFF"",
		""englishName"": ""Molten"",
		""englishDesc"": ""Resistant to cold effects"",
		""name"": ""Fusion"",
		""desc"": ""Résistant au froid"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ElysianGuard"",
		""type"": ""BUFF"",
		""englishName"": ""Elysian Guard"",
		""englishDesc"": ""Movement speed reduced, other stats buffed"",
		""name"": ""Garde Élysienne"",
		""desc"": ""Vitesse de mouvement réduite, les autres statistiques sont renforcées"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicFreeze"",
		""type"": ""BUFF"",
		""englishName"": ""Cosmic Freeze"",
		""englishDesc"": ""You feel as cold as the empty expanse of outer space"",
		""name"": ""Gel Cosmique"",
		""desc"": ""Vous vous sentez froid comme l'expansion du vide de l'espace lointain"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CinnamonRollBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Cinnamon Roll"",
		""englishDesc"": ""Mana regen rate and fire debuff damage boosted, defense reduced"",
		""name"": ""Goldschläger"",
		""desc"": ""Régénération du mana et dégâts de l'altération de feu augmentés, défense réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DaedalusGolemBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Daedalus Golem"",
		""englishDesc"": ""A crystal golem is following you"",
		""name"": ""Golem de Dédale"",
		""desc"": ""Un golem de cristal vous suit"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GravityNormalizerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Gravity Normalizer"",
		""englishDesc"": ""Gravity is now normal in space, immunity to distorted"",
		""name"": ""Gravité Normalisé"",
		""desc"": ""La gravité est maintenant normale dans l'espace. Immunité à la distortion."",
		""state"": ""Traduit""
	},
	{
		""id"": ""ElementalAxeBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Elemental Axe"",
		""englishDesc"": ""The elemental axe will protect you"",
		""name"": ""Hache des Éléments"",
		""desc"": ""La hache des éléments vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AndromedaCripple"",
		""type"": ""BUFF"",
		""englishName"": ""Andromeda Cripple"",
		""englishDesc"": ""You're slow"",
		""name"": ""Handicap d'Andromède"",
		""desc"": ""Vous êtes lent"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Herring"",
		""type"": ""BUFF"",
		""englishName"": ""Herring"",
		""englishDesc"": ""The herring will protect you"",
		""name"": ""Harang"",
		""desc"": ""Le harang vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SquishyBeanBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Squishy Bean"",
		""englishDesc"": ""BEAN MAN. BEAN DO T H E  B EA N IS HER E"",
		""name"": ""Haricot Spongieux"",
		""desc"": ""HARICOT MAN. HARICOT FAIT L E  HAR ICO T EST L A"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SilvaRevival"",
		""type"": ""BUFF"",
		""englishName"": ""Silva Immunity"",
		""englishDesc"": ""You are unkillable and immune to most debuffs"",
		""name"": ""Immunité Sylva"",
		""desc"": ""Vous êtes immortel et immunisé à la plupart des débuffs"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TarragonImmunity"",
		""type"": ""BUFF"",
		""englishName"": ""Tarragon Immunity"",
		""englishDesc"": ""You are immune"",
		""name"": ""Immunité d'Estragon"",
		""desc"": ""Vous êtes invulnérable"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralInfectionDebuff"",
		""type"": ""BUFF"",
		""englishName"": ""Astral Infection"",
		""englishDesc"": ""Your flesh is melting off"",
		""name"": ""Infection Astrale"",
		""desc"": ""Votre chair fond"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralInjectionBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Astral Injection"",
		""englishDesc"": ""Extreme mana recovery"",
		""name"": ""Injection Astrale"",
		""desc"": ""Récupération de mana extrême"",
		""state"": ""Traduit""
	},
	{
		""id"": ""KamiBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Kami Injection"",
		""englishDesc"": ""Increased max movement speed, acceleration and damage"",
		""name"": ""Injection Kami"",
		""desc"": ""Augmentation des dégâts et de la vitesse d'accélération et de mouvement maximale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AlcoholPoisoning"",
		""type"": ""BUFF"",
		""englishName"": ""Alcohol Poisoning"",
		""englishDesc"": ""You drank too much and you are now dying"",
		""name"": ""Intoxication alcoolique"",
		""desc"": ""Tu as trop bu et maintenant tu es mourant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Irradiated"",
		""type"": ""BUFF"",
		""englishName"": ""Irradiated"",
		""englishDesc"": ""Your skin is burning off"",
		""name"": ""Irradié"",
		""desc"": ""Votre peau se détache"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Kendra"",
		""type"": ""BUFF"",
		""englishName"": ""Kendra"",
		""englishDesc"": ""A loyal friend accompanies you."",
		""name"": ""Kendra"",
		""desc"": ""Un ami fidèle vous accompagne"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedBabs"",
		""type"": ""BUFF"",
		""englishName"": ""The Profaned Soul"",
		""englishDesc"": ""The healer will heal your wounds!"",
		""name"": ""L'Âme Profanée"",
		""desc"": ""Le soigneur guérira vos blessures!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""IgneousExaltationBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Igneous Blade"",
		""englishDesc"": ""A blade is orbiting you"",
		""name"": ""Lame Ignée"",
		""desc"": ""Une lame orbite autour de vous"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LadBuff"",
		""type"": ""BUFF"",
		""englishName"": ""The Father"",
		""englishDesc"": ""A father of many floats around you"",
		""name"": ""Le Père"",
		""desc"": ""Le père d'une multitude flotte autour de vous"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LeviBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Levi"",
		""englishDesc"": ""Small and cute"",
		""name"": ""Levi"",
		""desc"": ""Petit et Mignon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodBound"",
		""type"": ""BUFF"",
		""englishName"": ""Blood Bound"",
		""englishDesc"": ""You must be desperate for company"",
		""name"": ""Lien de Sang"",
		""desc"": ""Vous devez vraiment être désespéré"",
		""state"": ""Traduit""
	},
	{
		""id"": ""VulnerabilityHex"",
		""type"": ""BUFF"",
		""englishName"": ""Vulnerability Hex"",
		""englishDesc"": ""You are weak"",
		""name"": ""Malédiction de Vulnérabilité"",
		""desc"": ""Vous êtes faible"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MargaritaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Margarita"",
		""englishDesc"": ""Reduced duration to most debuffs, defense and life regen reduced"",
		""name"": ""Margarita"",
		""desc"": ""Réduit la durée de la plupart des altérations d'état, défense et régénération de vie réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AdrenalineMode"",
		""type"": ""BUFF"",
		""englishName"": ""Adrenaline Mode"",
		""englishDesc"": ""200% damage boost. Can be boosted by other items up to 245%."",
		""name"": ""Mode Adrenaline"",
		""desc"": ""+200% de dégâts. Peut être augmenté jusqu'a 245% grace à d'autres objets."",
		""state"": ""Traduit""
	},
	{
		""id"": ""MoonshineBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Moonshine"",
		""englishDesc"": ""Defense and damage reduction boosted, life regen reduced"",
		""name"": ""Moonshine"",
		""desc"": ""Défense et réduction des dégâts augmentées, régénération de vie réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WhisperingDeath"",
		""type"": ""BUFF"",
		""englishName"": ""Whispering Death"",
		""englishDesc"": ""Death approaches; movement speed, attack power and life regen reduced"",
		""name"": ""Mort Susurrante"",
		""desc"": ""La mort approche; vitesse de mouvement, puissance d'attaque et régénération de vie réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TacticalPlagueEngineBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tactical Plague Engine"",
		""englishDesc"": ""A giant plague jet is following you"",
		""name"": ""Moteur Tactique de Peste"",
		""desc"": ""Un jet géant de peste vous suit"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Mushy"",
		""type"": ""BUFF"",
		""englishName"": ""Mushy"",
		""englishDesc"": ""Increased defense and life regen"",
		""name"": ""Mousseux"",
		""desc"": ""Défense et régénération de vie augmentée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MoscowMuleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Moscow Mule"",
		""englishDesc"": ""Damage, critical strike chance, and knockback boosted, life regen reduced"",
		""name"": ""Mule de Moscou"",
		""desc"": ""Dégâts, chances de coup critique et recul augmentés, régénération de vie réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Mechworm"",
		""type"": ""BUFF"",
		""englishName"": ""Mechworm"",
		""englishDesc"": ""The mechworm will protect you"",
		""name"": ""Mécaver"",
		""desc"": ""Le Mécaver vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MidnightSunBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Midnight Sun UFO"",
		""englishDesc"": ""A strange UFO is observing you, and it's making you very uncomfortable"",
		""name"": ""OVNI du Soleil de Minuit"",
		""desc"": ""Un étrange OVNI vous observe, et ça vous gène énormément"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EyeOfNightBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Eye of Night"",
		""englishDesc"": ""It eerily watches"",
		""name"": ""Oeil de Nuit"",
		""desc"": ""Il vous observe de manière inquiétante"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ShadowBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Shadow"",
		""englishDesc"": ""You're invisible, certain rogue weapons give and gain buffs, and stealth generation is boosted."",
		""name"": ""Ombre"",
		""desc"": ""Vous êtes invisible, certaines armes de voleurs sont améliorées et vous renforcent, et la génération de furtivité est augmentée."",
		""state"": ""Traduit""
	},
	{
		""id"": ""Shadowflame"",
		""type"": ""BUFF"",
		""englishName"": ""Shadowflame"",
		""englishDesc"": ""Losing life"",
		""name"": ""Ombreflamme"",
		""desc"": ""Votre vie diminue"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Omniscience"",
		""type"": ""BUFF"",
		""englishName"": ""Omniscience"",
		""englishDesc"": ""You can see everything"",
		""name"": ""Omniscience"",
		""desc"": ""Vous pouvez tout voir"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ReaverOrbBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Reaver Orb"",
		""englishDesc"": ""The reaver orb will light your way"",
		""name"": ""Orbe de Saccage"",
		""desc"": ""L'orbe de saccage éclairera votre voie"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BearBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Bear"",
		""englishDesc"": ""A guardian angel is following you."",
		""name"": ""Ours"",
		""desc"": ""Un ange gardien vous suit."",
		""state"": ""Traduit""
	},
	{
		""id"": ""ResurrectionButterflyBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Resurrection Butterfly"",
		""englishDesc"": ""Sleep beneath the Cherry Blossoms, Red-White Butterfly"",
		""name"": ""Papillon de Résurrection"",
		""desc"": ""Dors sous les fleurs de cerisier, papillon blanc-rouge"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SulphurskinBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Sulphurskin"",
		""englishDesc"": ""The sulphuric waters have a lesser effect on you"",
		""name"": ""Peau Sulfurique"",
		""desc"": ""Les eaux sulfuriques ont moins d'effet sur vous"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerditionBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Perdition"",
		""englishDesc"": ""How unfortunate"",
		""name"": ""Perdition"",
		""desc"": ""C'est malencontreux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Plague"",
		""type"": ""BUFF"",
		""englishName"": ""Plague"",
		""englishDesc"": ""Rotting from the inside"",
		""name"": ""Peste"",
		""desc"": ""Vous pourrissez de l'intérieur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LittleLightBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Little Light"",
		""englishDesc"": ""Endearing"",
		""name"": ""Petite Lumière"",
		""desc"": ""Attachant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PhotosynthesisBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Photosynthesis"",
		""englishDesc"": ""Life regen boosted, more during daytime, and hearts heal more HP"",
		""name"": ""Photosynthèse"",
		""desc"": ""Régénération de vie augmentée, plus encore la journée, et les coeurs rendent plus de vie"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlantationBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Plantation"",
		""englishDesc"": ""The miniature plantera will protect you"",
		""name"": ""Plantation"",
		""desc"": ""Une Plantera miniature vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssalDivingSuitPlates"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Diving Suit Plates"",
		""englishDesc"": ""The plates will absorb 15% damage"",
		""name"": ""Plaques de la Combinaison Abyssale"",
		""desc"": ""Les plaques absorberons 15% des dégâts"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HauntedDishesBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Haunted Dishes"",
		""englishDesc"": ""The haunted dishes will protect you"",
		""name"": ""Plâts Hantés"",
		""desc"": ""Les plâts hantés vous protégerons"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DazzlingStabberBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Dazzling Stabber"",
		""englishDesc"": ""En garde"",
		""name"": ""Poignard Éblouissant"",
		""desc"": ""En garde"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SagePoison"",
		""type"": ""BUFF"",
		""englishName"": ""Sage Poison"",
		""englishDesc"": ""Poisoned"",
		""name"": ""Poison de Sauge"",
		""desc"": ""Empoisonné"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FishAlert"",
		""type"": ""BUFF"",
		""englishName"": ""Fish Alert"",
		""englishDesc"": ""The abyssal creatures have spotted you!"",
		""name"": ""Poissons Alertés"",
		""desc"": ""Les créatures abyssales vous ont repérés!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PopoBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Popo"",
		""englishDesc"": ""You are a snowman now!"",
		""name"": ""Popo"",
		""desc"": ""Tu es un bonhomme de neige maintenant!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PopoNoselessBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Noseless Popo"",
		""englishDesc"": ""Your nose has been stolen!"",
		""name"": ""Popo sans nez"",
		""desc"": ""On t'as volé ton nez!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FrozenLungs"",
		""type"": ""BUFF"",
		""englishName"": ""Frozen Lungs"",
		""englishDesc"": ""The icy waters restrict your breathing"",
		""name"": ""Poumons Gelés"",
		""desc"": ""Les eaux glacées restraignent votre respiration"",
		""state"": ""Traduit""
	},
	{
		""id"": ""YharimPower"",
		""type"": ""BUFF"",
		""englishName"": ""Yharim's Power"",
		""englishDesc"": ""You feel like you can break the world in two... with your bare hands!"",
		""name"": ""Pouvoir de Yharim"",
		""desc"": ""Tu te sens comme si tu pouvais casser le monde en deux... a mains nues!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PenumbraBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Penumbra"",
		""englishDesc"": ""Stealth regenerates 15% faster while moving\\nAt night, stealth additionally regenerates 15% faster while standing still\\nBoth boosts increase to 20% during a solar eclipse"",
		""name"": ""Pénombre"",
		""desc"": ""La furtivité se régénère 15% plus vite quand vous bougez\\nLa nuit, +15% de génération de furtivité si vous êtes immobile\\nLes deux bonus sont portés à 20% lors d'une éclipse"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RadiatorBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Radiator"",
		""englishDesc"": ""Radioactive but adorable"",
		""name"": ""Radiateur Radioactif"",
		""desc"": ""Radioactif mais adorable"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RageMode"",
		""type"": ""BUFF"",
		""englishName"": ""Rage Mode"",
		""englishDesc"": ""35% damage boost."",
		""name"": ""Rage Mode"",
		""desc"": ""+35% de dégâts."",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedRageBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Profaned Rage"",
		""englishDesc"": ""Increased critical strike chance"",
		""name"": ""Rage Profanée"",
		""desc"": ""Chances de coup critique augmentées"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ReaverRage"",
		""type"": ""BUFF"",
		""englishName"": ""Reaver Rage"",
		""englishDesc"": ""You are angry"",
		""name"": ""Rage du Saccageur"",
		""desc"": ""Vous êtes en colère"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DankCreeperBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Dank Creeper"",
		""englishDesc"": ""The dank creeper will protect you"",
		""name"": ""Rampant Humide"",
		""desc"": ""Le rampant humide vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BoundingBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Bounding"",
		""englishDesc"": ""Increased jump height, jump speed, and fall damage resistance"",
		""name"": ""Rebondissant"",
		""desc"": ""Hauteur de saut, vitesse de saut et résistance aux dégâts de chute augmentés"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GazeOfCrysthamyrBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Gaze of Crysthamyr"",
		""englishDesc"": ""You are riding a shadow dragon"",
		""name"": ""Regard de Crysthamyr"",
		""desc"": ""Vous chevauchez un ombredragon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RumBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Rum"",
		""englishDesc"": ""Movement speed and life regen boosted, defense reduced"",
		""name"": ""Rhum"",
		""desc"": ""Vitesse de mouvement et régénération de vie augmentées, défense réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CaribbeanRumBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Caribbean Rum"",
		""englishDesc"": ""Life regen, movement speed, and wing flight time boosted, you are floaty and defense is reduced"",
		""name"": ""Rhum des Caraïbes"",
		""desc"": ""Régénération de vie, vitesse de déplacement et temps de vol augmentés, vous êtes flottant et votre défense est réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Sandnado"",
		""type"": ""BUFF"",
		""englishName"": ""Sandnado"",
		""englishDesc"": ""The sandnado will protect you"",
		""name"": ""Sablenade"",
		""desc"": ""La sablenade te protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HeavyBleeding"",
		""type"": ""BUFF"",
		""englishName"": ""Heavy Bleeding"",
		""englishDesc"": ""You're losing a lot of blood"",
		""name"": ""Saignement Lourd"",
		""desc"": ""Vous perdez beaucoup de sang"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BurningBlood"",
		""type"": ""BUFF"",
		""englishName"": ""Burning Blood"",
		""englishDesc"": ""Your blood is on fire"",
		""name"": ""Sang Bouillonnant"",
		""desc"": ""Votre sang est en ébullition"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MountedScannerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Mounted Scanner"",
		""englishDesc"": ""Powerful machinery surrounds you"",
		""name"": ""Scanner Monté"",
		""desc"": ""Une machinerie puissante vous entoure"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ScrewdriverBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Screwdriver"",
		""englishDesc"": ""Piercing projectile damage boosted, life regen reduced"",
		""name"": ""Screwdriver"",
		""desc"": ""Dégâts des projectiles percants augmentés, régénération de vie réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SiriusBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Sirius"",
		""englishDesc"": ""A bit too bright, but it helps you"",
		""name"": ""Sirius"",
		""desc"": ""Un peu trop brillante, mais cela vous aide"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralProbeBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Astral Probe"",
		""englishDesc"": ""The astral probe will protect you"",
		""name"": ""Sonde Astrale"",
		""desc"": ""La sonde astrale vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimlingBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Brimling"",
		""englishDesc"": ""Protect her or suffer in agony"",
		""name"": ""Soufrelin"",
		""desc"": ""Protège la ou souffre dans l'agonie"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SparksBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Sparks"",
		""englishDesc"": ""Eats butterflies"",
		""name"": ""Sparks"",
		""desc"": ""Manges les papillions"",
		""state"": ""Traduit""
	},
	{
		""id"": ""StarBeamRyeBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Star Beam Rye"",
		""englishDesc"": ""Max mana and magic damage increased. Defense, mana usage, and life regen reduced"",
		""name"": ""Star Beam Rye"",
		""desc"": ""Mana maximum et dégâts magiques augmentés. Défense, coût en mana et régénération de vie réduites"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SepulcherMinionBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Sepulcher"",
		""englishDesc"": ""It is not benevolent"",
		""name"": ""Sépulcre"",
		""desc"": ""Il n'est pas bienveillant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TequilaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tequila"",
		""englishDesc"": ""Damage, critical strike chance, damage reduction, defense, and knockback boosted during daytime, life regen reduced"",
		""name"": ""Tequila"",
		""desc"": ""Dégâts, chances de coup critique, réduction des dégâts, défense et recul augmentés la journée, régénération de vie réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TequilaSunriseBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tequila Sunrise"",
		""englishDesc"": ""Damage, critical strike chance, damage reduction, defense, and knockback boosted during daytime, life regen reduced"",
		""name"": ""Tequila Sunrise"",
		""desc"": ""Dégâts, chances de coup critique, réduction des dégâts, défense et recul augmenté durant la journée, régénération de vie réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TriumphBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Triumph"",
		""englishDesc"": ""Enemy contact damage is reduced, the lower their health the greater the reduction"",
		""name"": ""Triomphe"",
		""desc"": ""Les dégâts de contact des ennemis sont réduits, plus leur vie est faible, plus la réduction est grande"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Trippy"",
		""type"": ""BUFF"",
		""englishName"": ""Trippy"",
		""englishDesc"": ""You see the world for what it truly is... and you also have a 50% increase to all damage"",
		""name"": ""Trippant"",
		""desc"": ""Vous voyez le monde pour ce qu'il est vraiment... et vous avez aussi +50% à tous vos dégâts"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TemporalSadness"",
		""type"": ""BUFF"",
		""englishName"": ""Temporal Sadness"",
		""englishDesc"": ""You are crying"",
		""name"": ""Tristesse Temporaire"",
		""desc"": ""Vous pleurez"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ThirdSageBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Third Sage"",
		""englishDesc"": ""Eh? No way it's an oni."",
		""name"": ""Troisième Sage"",
		""desc"": ""Hein? Aucune chance que ce soit un oni."",
		""state"": ""Traduit""
	},
	{
		""id"": ""Vaporfied"",
		""type"": ""BUFF"",
		""englishName"": ""Vaporfied"",
		""englishDesc"": ""Vape"",
		""name"": ""Vapoté"",
		""desc"": ""Vapote"",
		""state"": ""Traduit""
	},
	{
		""id"": ""VileFeederBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Vile Feeder"",
		""englishDesc"": ""The baby eater of souls will protect you"",
		""name"": ""Vil Dévoreur"",
		""desc"": ""Le bébé dévoreur d'âmes vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WhiteWineBuff"",
		""type"": ""BUFF"",
		""englishName"": ""White Wine"",
		""englishDesc"": ""Magic damage boosted, life regen and defense reduced"",
		""name"": ""Vin Blanc"",
		""desc"": ""Dégâts magiques augmentés, régénération de vie et défense réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RedWineBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Red Wine"",
		""englishDesc"": ""Life regen reduced"",
		""name"": ""Vin Rouge"",
		""desc"": ""Régénération de vie réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicViperEngineBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Cosmic Viper"",
		""englishDesc"": ""The cosmic gunship will protect you"",
		""name"": ""Vipère Cosmique"",
		""desc"": ""Le vaisseau de combat cosmique vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""VodkaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Vodka"",
		""englishDesc"": ""Damage and critical stike chance boosted, defense and life regen reduced"",
		""name"": ""Vodka"",
		""desc"": ""Dégâts et chances de coup critique augmentés, défense et régénération de vie réduites"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TarragonCloak"",
		""type"": ""BUFF"",
		""englishName"": ""Tarragon Cloak"",
		""englishDesc"": ""Contact damage is reduced"",
		""name"": ""Voile d'Estragon"",
		""desc"": ""Les dégâts de contact sont réduits"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WhiskeyBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Whiskey"",
		""englishDesc"": ""Damage, critical strike chance, and knockback boosted, defense reduced"",
		""name"": ""Whisky"",
		""desc"": ""Dégâts, chances de coup critique et recul augmentés, défense réduite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SnakeEyesBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Snake Eyes"",
		""englishDesc"": ""Always watching..."",
		""name"": ""Yeux de Serpent"",
		""desc"": ""Toujours à l'affut..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""Zen"",
		""type"": ""BUFF"",
		""englishName"": ""Zen"",
		""englishDesc"": ""Spawn rates are reduced"",
		""name"": ""Zen"",
		""desc"": ""Le taux d'apparition des ennemis est réduit"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Zerg"",
		""type"": ""BUFF"",
		""englishName"": ""Zerg"",
		""englishDesc"": ""Spawn rates are boosted"",
		""name"": ""Zerg"",
		""desc"": ""Le taux d'apparition des ennemis est augmenté"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FrostBlossomBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Frost Blossom"",
		""englishDesc"": ""A cold, prickly flower is floating uncomfortably close to you"",
		""name"": ""Éclosion de Givre"",
		""desc"": ""Une froide, épineuse fleur flotte un peu trop près de vous"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrushDepth"",
		""type"": ""BUFF"",
		""englishName"": ""Crush Depth"",
		""englishDesc"": ""Aquatic pressure"",
		""name"": ""Écrasement des Profondeurs"",
		""desc"": ""Pression aquatique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TeslaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tesla's Electricity"",
		""englishDesc"": ""Summons an aura of electricity"",
		""name"": ""Électricité de Tesla"",
		""desc"": ""Invoque une aura d'électricité"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CloudyWaifu"",
		""type"": ""BUFF"",
		""englishName"": ""Cloud Elemental"",
		""englishDesc"": ""The cloud elemental will protect you"",
		""name"": ""Élémentaire de Nuage"",
		""desc"": ""L'élémentaire de nuage vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SandyWaifu"",
		""type"": ""BUFF"",
		""englishName"": ""Sand Elemental"",
		""englishDesc"": ""The sand elemental will protect you"",
		""name"": ""Élémentaire de Sable"",
		""desc"": ""L'élémentaire de sable te protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SandyHealingWaifu"",
		""type"": ""BUFF"",
		""englishName"": ""Rare Sand Elemental"",
		""englishDesc"": ""The sand elemental will heal you"",
		""name"": ""Élémentaire de Sable Précieux"",
		""desc"": ""L'élémentaire de sable vous soignera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimstoneWaifu"",
		""type"": ""BUFF"",
		""englishName"": ""Brimstone Elemental"",
		""englishDesc"": ""The brimstone elemental will protect you"",
		""name"": ""Élémentaire de soufre"",
		""desc"": ""L'élémentaire du soufre vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicEnergy"",
		""type"": ""BUFF"",
		""englishName"": ""Cosmic Energy"",
		""englishDesc"": ""The cosmic energy will protect you"",
		""name"": ""Énergie Cosmique"",
		""desc"": ""L'énergie cosmique vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GladiatorSwords"",
		""type"": ""BUFF"",
		""englishName"": ""Gladiator Swords"",
		""englishDesc"": ""The gladiator swords will protect you"",
		""name"": ""Épées de Gladiateur"",
		""desc"": ""Les épées de gladiateur vous protègerons"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AquaticStar"",
		""type"": ""BUFF"",
		""englishName"": ""Aquatic Star"",
		""englishDesc"": ""The aquatic star will protect you"",
		""name"": ""Étoile Aquatique"",
		""desc"": ""L'étoile aquatique vous protège"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrittleStar"",
		""type"": ""BUFF"",
		""englishName"": ""Brittle Star"",
		""englishDesc"": ""The brittle star will protect you"",
		""name"": ""Étoile Fragile"",
		""desc"": ""L'étoile fragile vous protègera"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateBed"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued 'Bed'"",
		""englishTooltip"": [
			""Counts as a bed""
		],
		""name"": ""'Lit' Pestiféré"",
		""tooltip"": [
			""Peut-être utilisé comme un lit""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Abaddon"",
		""type"": ""ITEM"",
		""englishName"": ""Abaddon"",
		""englishTooltip"": [
			""Grants immunity to Brimstone Flames and Searing Lava""
		],
		""name"": ""Abaddon"",
		""tooltip"": [
			""Réduit les dégâts infligés par les brûlures de soufre et immunise contre la lave brûlante""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AcesHigh"",
		""type"": ""ITEM"",
		""englishName"": ""Ace's High"",
		""englishTooltip"": [
			""Fires a string of cards with varying effects based on card type"",
			""Hearts grant lifesteal. Spades pierce and ignore immunity frames."",
			""Diamonds explode. Clubs split into three.""
		],
		""name"": ""Ace's High"",
		""tooltip"": [
			""Tire une rafale de cartes avec des effets variables en fonction du type des cartes"",
			""Les coeurs volent la vie. Les piques percent et ignore les périodes d'invulnérabilité."",
			""Les carreaux explosent. Les trèfles se divisent en trois.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeLunaticCultist"",
		""type"": ""ITEM"",
		""englishName"": ""Lunatic Cultist"",
		""englishTooltip"": [
			""The gifted one that terminated my grand summoning so long ago with his uncanny powers over the arcane."",
			""Someone I once held in such contempt for his actions is now... deceased, his sealing ritual undone... prepare for the end."",
			""Your impending doom approaches...""
		],
		""name"": ""Adepte Lunatique"",
		""tooltip"": [
			""Le doué qui a finalisé ma grande invocation il y a longtemps avec ses mystérieux pouvoirs sur les arcanes."",
			""Quelqu'un que j'ai autrefois détesté pour ses actions est maintenant... décédé, son rituel d'emprisonnement défait...prépare toi à la fin."",
			""L'apocalypse approche...""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Aestheticus"",
		""type"": ""ITEM"",
		""englishName"": ""Aestheticus"",
		""englishTooltip"": [
			""Fires crystals that explode and slow enemies down"",
			""This weapon scales with all your damage stats at once""
		],
		""name"": ""Aestheticus"",
		""tooltip"": [
			""Tire des cristaux qui explosent et ralentissent les ennemis"",
			""Cette arme profite de toutes vos statistiques en même temps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LaboratoryDisplayItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Display"",
		""name"": ""Affichage de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Affliction"",
		""type"": ""ITEM"",
		""englishName"": ""Affliction"",
		""englishTooltip"": [
			""Gives you and all other players on your team +1 life regen,"",
			""+10% max life, 7% damage reduction, 13 defense and 10% increased damage""
		],
		""name"": ""Affliction"",
		""tooltip"": [
			""Donne à vous et à votre équipe +1 régénération de vie,"",
			""+10% de vie maximum, 7% de réduction des dégâts, 13 défense, et 10% de dégâts supplémentaires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralClay"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Clay"",
		""name"": ""Agile Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GoldenEagle"",
		""type"": ""ITEM"",
		""englishName"": ""Golden Eagle"",
		""englishTooltip"": [
			""Fires 5 bullets at once""
		],
		""name"": ""Aigle Doré"",
		""tooltip"": [
			""Tire 5 balles à la fois""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElysianWings"",
		""type"": ""ITEM"",
		""englishName"": ""Elysian Wings"",
		""englishTooltip"": [
			""Blessed by the Profaned Flame"",
			""Horizontal speed: 9.75"",
			""Acceleration multiplier: 2.7"",
			""Great vertical speed"",
			""Flight time: 240"",
			""Temporary immunity to lava and 10% increased movement speed""
		],
		""name"": ""Ailes Elysiennes"",
		""tooltip"": [
			""Bénie par la flamme profanée"",
			""Vitesse Horizontale: 9.75"",
			""Multiplicateur d'accélération: 2.7"",
			""Très bonne vitesse verticale"",
			""Temps de vol: 240"",
			""Immunité temporaire à la lave et +10% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HadarianWings"",
		""type"": ""ITEM"",
		""englishName"": ""Hadarian Wings"",
		""englishTooltip"": [
			""Powered by the Astral Infection"",
			""Hold down to hover during flight, greatly extending flight duration"",
			""Horizontal speed: 9.00"",
			""Acceleration multiplier: 1.75"",
			""Good vertical speed"",
			""Flight time: 90""
		],
		""name"": ""Ailes Hadariennes"",
		""tooltip"": [
			""Alimenté par l'infection astrale"",
			""Restez appuyez sur bas durant le vol pour vous déplacer horizontalement, augmentant ainsi votre temps de vol"",
			""Vitesse Horizontale: 9"",
			""Multiplicateur d'accélération: 1.75"",
			""Bonne vitesse verticale"",
			""Temps de vol: 120"",
			""+10% de vitesse de mouvement et de saut si vous portez l'armure astrale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SilvaWings"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Wings"",
		""englishTooltip"": [
			""The purest of nature"",
			""Horizontal speed: 11.00"",
			""Acceleration multiplier: 2.8"",
			""Excellent vertical speed"",
			""Flight time: 270"",
			""The Silva revive heals you to half health while wearing the Silva armor""
		],
		""name"": ""Ailes Silva"",
		""tooltip"": [
			""Les plus pures de la nature"",
			""Vitesse Horizontale: 11"",
			""Multiplicateur d'accélération: 2.8"",
			""Excellente vitesse verticale"",
			""Temps de vol: 270"",
			""Vous ressusciterez avec la moitié de vos points de vie si vous portez l'armure Silva""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TarragonWings"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Wings"",
		""englishTooltip"": [
			""Born of the jungle"",
			""Horizontal speed: 9.50"",
			""Acceleration multiplier: 2.5"",
			""Great vertical speed"",
			""Flight time: 250"",
			""+15 defense and +2 life regen while wearing the Tarragon Armor""
		],
		""name"": ""Ailes d'Estragon"",
		""tooltip"": [
			""Née de la jungle"",
			""Vitesse Horizontale: 9.5"",
			""Multiplicateur d'accélération: 2.5"",
			""Très bonne vitesse verticale"",
			""Temps de vol: 250"",
			""+15 défense et +2 régénération de vie si vous portez l'armure d'estragon""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SkylineWings"",
		""type"": ""ITEM"",
		""englishName"": ""Skyline Wings"",
		""englishTooltip"": [
			""Horizontal speed: 6.25"",
			""Acceleration multiplier: 1.0"",
			""Average vertical speed"",
			""Flight time: 80""
		],
		""name"": ""Ailes d'Horizon"",
		""tooltip"": [
			""Vitesse Horizontale: 6.25"",
			""Multiplicateur d'accélération: 1"",
			""Average vitesse verticale"",
			""Temps de vol: 80"",
			""+10% de vitesse de saut quand vous portez l'armure Aérospec""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DrewsWings"",
		""type"": ""ITEM"",
		""englishName"": ""Drew's Wings"",
		""englishTooltip"": [
			""Absolutely Fabulous"",
			""Horizontal speed: 12.00"",
			""Acceleration multiplier: 3.0"",
			""Excellent vertical speed"",
			""Flight time: 361""
		],
		""name"": ""Ailes de Drew"",
		""tooltip"": [
			""Absolument Fabuleuses"",
			""Vitesse Horizontale: 12"",
			""Multiplicateur d'accélération: 3"",
			""Excellente vitesse verticale"",
			""Temps de vol: 361""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StarlightWings"",
		""type"": ""ITEM"",
		""englishName"": ""Starlight Wings"",
		""englishTooltip"": [
			""Wings of the Nightingale"",
			""Horizontal speed: 7.50"",
			""Acceleration multiplier: 1.0"",
			""Average vertical speed"",
			""Flight time: 150"",
			""5% increased damage and critical strike chance while wearing the Daedalus Armor""
		],
		""name"": ""Ailes de Lueur d'Etoile"",
		""tooltip"": [
			""Les ailes du rossignol"",
			""Vitesse Horizontale: 7.5"",
			""Multiplicateur d'accélération: 1"",
			""Vitesse verticale moyenne"",
			""Temps de vol: 150"",
			""+5% de dégâts et de chances de coup critique si vous portez l'armure de Dédale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Wingman"",
		""type"": ""ITEM"",
		""englishName"": ""Wingman"",
		""englishTooltip"": [
			""Fires a concentrated laser beam""
		],
		""name"": ""Ailier"",
		""tooltip"": [
			""Tire un rayon laser concentré""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Tradewinds"",
		""type"": ""ITEM"",
		""englishName"": ""Tradewinds"",
		""englishTooltip"": [
			""Casts fast moving sunlight feathers""
		],
		""name"": ""Alizés"",
		""tooltip"": [
			""Convoque des plumes rapides de lumière solaire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AngelicAlliance"",
		""type"": ""ITEM"",
		""englishName"": ""Angelic Alliance"",
		""englishTooltip"": [
			""Call upon the force of heaven to empower your attacks and minions"",
			""Courage, Enlightenment, Bliss. United in Judgement"",
			""+2 max minions, 15% increased summon damage, and 8% increased damage to all other classes"",
			""Life regeneration is boosted while jumping"",
			""This line is modified in the code below. If you can read this, someone probably did something wrong (It was Ben)"",
			""While under the effects of Divine Bless, for every minion you have, an archangel shall be summoned to aid you in combat"",
			""Each spawned angel will instantly heal you for two health"",
			""All minion attacks inflict Banishing Fire and you are granted a flat health boost of four health per second"",
			""This effect has a cooldown of 1 minute""
		],
		""name"": ""Alliance Angélique"",
		""tooltip"": [
			""Fait appel au pouvoir des cieux pour renforcer vos attaques et vos sbires"",
			""Courage, Éveil, Félicité. Uni dans le Jugement"",
			""+2 sbires max, +15% de dégâts d'invocation, et +8% de dégâts à toutes les autres classes"",
			""La régénération de vie est augmentée quand vous sautez"",
			""This line is modified in the code below. If you can read this, someone probably did something wrong (It was Ben)"",
			""Sous l'effet de la bénédiction divine, pour chaque sbire invoqué, un archange sera invoqué pour vous assister en combat"",
			""Chaque archange vous soignera instantanément de 2 points de vie"",
			""Toutes les attaques de sbires infligent le feu bannissant et votre régénération de vie augmente de 4 par seconde"",
			""Cet effet a un temps de recharge de 1 minute""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Alluvion"",
		""type"": ""ITEM"",
		""englishName"": ""Alluvion"",
		""englishTooltip"": [
			""Converts wooden arrows into sharks, torrential and typhoon arrows"",
			""Fires a torrent of six arrows at once""
		],
		""name"": ""Alluvion"",
		""tooltip"": [
			""Convertit les flèches en bois en requins, flèches torrentielles et flèches de typhon"",
			""Tire un torrent de 6 flèches à la fois""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AlulaAustralis"",
		""type"": ""ITEM"",
		""englishName"": ""Alula Australis"",
		""englishTooltip"": [
			""Fires a beautiful aurora trailed by a star shower""
		],
		""name"": ""Alula Australis"",
		""tooltip"": [
			""Tire une belle aurore suivie d'un pluie d'étoiles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FungalClump"",
		""type"": ""ITEM"",
		""englishName"": ""Fungal Clump"",
		""englishTooltip"": [
			""Summons a fungal clump to fight for you"",
			""The clump latches onto enemies and steals their life for you""
		],
		""name"": ""Amas Fongique"",
		""tooltip"": [
			""Invoque un amas fongique qui combat pour vous"",
			""L'amas s'accroche aux ennemis et vole leur vie pour vous""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MeldBlob"",
		""type"": ""ITEM"",
		""englishName"": ""Meld Blob"",
		""name"": ""Amas de Fusion"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LeviathanAmbergris"",
		""type"": ""ITEM"",
		""englishName"": ""Leviathan Ambergris"",
		""englishTooltip"": [
			""You leave behind poisonous seawater as you move"",
			""30% increased movement speed, 10% increase to all damage and plus 10 defense while submerged in liquid"",
			""If you are damaged while submerged in liquid you will gain a damaging aura for a short time"",
			""Being outside of liquid increases all damage by 5% and increases damage reduction by 5%""
		],
		""name"": ""Ambre Gris de Leviathan"",
		""tooltip"": [
			""Vous déversez de l'eau de mer empoisonnée quand vous vous déplacez"",
			""+30% de vitesse de mouvement, +10% à tous les dégâts et +10 défense quand vous êtes immergé"",
			""Si vous subissez des dégâts alors que vous êtes immergé, vous émettez une aura qui inflige des dégâts durant un court moment"",
			""Être en dehors d'un liquide augmente tous les dégâts et réduit les dégâts subis de 5%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AmbrosialAmpoule"",
		""type"": ""ITEM"",
		""englishName"": ""Ambrosial Ampoule"",
		""englishTooltip"": [
			""You emit light"",
			""5% increased damage reduction and increased life regen"",
			""Grants immunity to the Frozen, Chilled, Frostburn, Cursed Inferno and Burning Blood debuffs""
		],
		""name"": ""Ampoule d'ambrosie"",
		""tooltip"": [
			""YVous émettez de la lumière"",
			""7% de réduction des dégâts et régénération de vie augmentée"",
			""Immunité au gel, au froid et au brûlegivre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MoltenAmputator"",
		""type"": ""ITEM"",
		""englishName"": ""Molten Amputator"",
		""englishTooltip"": [
			""Throws a scythe that emits molten globs on enemy hits"",
			""Stealth strikes spawn molten globs periodically in flight and more on-hit""
		],
		""name"": ""Amputateur en Fusion"",
		""tooltip"": [
			""Lance une faux qui émet des globes en fusion quand elle touche"",
			""Les attaques furtives créent des globes périodiquement et en créent plus quand elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssalAmulet"",
		""type"": ""ITEM"",
		""englishName"": ""Abyssal Amulet"",
		""englishTooltip"": [
			""Attacks inflict the Crush Depth debuff"",
			""Grants immunity to the Crush Depth debuff"",
			""While in the abyss you gain 10% increased max life""
		],
		""name"": ""Amulette Abyssale"",
		""tooltip"": [
			""Les attaques infligent l'altération d'état d'écrasement"",
			""Immunise contre l'altération d'état écrasement"",
			""10% de vie supplémentaires dans les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LumenousAmulet"",
		""type"": ""ITEM"",
		""englishName"": ""Lumenous Amulet"",
		""englishTooltip"": [
			""Attacks inflict the Crush Depth debuff"",
			""Grants immunity to the Crush Depth debuff"",
			""While in the abyss you gain 25% increased max life"",
			""Provides a moderate amount of light in the abyss""
		],
		""name"": ""Amulette Lumineuse"",
		""tooltip"": [
			""Les attaques infligent l'écrasement"",
			""Immunise contre l'altération d'état écrasement"",
			""+25% de vie supplémentaire dans les abysses"",
			""Accorde une quantité de lumière modérée dans les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DeificAmulet"",
		""type"": ""ITEM"",
		""englishName"": ""Deific Amulet"",
		""englishTooltip"": [
			""Causes stars to fall and grants increased immune time when damaged"",
			""Provides life regeneration and reduces the cooldown of healing potions""
		],
		""name"": ""Amulette de Divinité"",
		""tooltip"": [
			""Fait tomber des étoiles et augmente la période d'invincibilité lorsque vous êtes touché"",
			""Accorde de la régénération de vie et réduit le temps de recharge des potions de soins""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BlunderBooster"",
		""type"": ""ITEM"",
		""englishName"": ""Blunder Booster"",
		""englishTooltip"": [
			""12% increased rogue damage and 15% increased rogue projectile velocity"",
			""Stealth generates 10% faster"",
			""Summons a red lightning aura to surround the player and electrify nearby enemies"",
			""TOOLTIP LINE HEREThis effect has a 1 second cooldown before it can be used again""
		],
		""name"": ""Améliorateur de Gaffe"",
		""tooltip"": [
			""12% d'augmentation des dégâts de voleur et 15% de vitesse supplémentaire pour les projectiles de voleur"",
			""La furtivité se génère 10% plus vite"",
			""Une aura d'éclairs rouges entoure le porteur et électrise les ennemis proches"",
			""TOOLTIP LINE HERECet effet à 1 seconde de temps de recharge""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AncientIceChunk"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient Ice Chunk"",
		""englishTooltip"": [
			""Summons an ice clasper to fight for you""
		],
		""name"": ""Ancien Morceau de Glace"",
		""tooltip"": [
			""Invoque un clasper de glace pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AncientGodSlayerLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient God Slayer Leggings"",
		""name"": ""Ancien Pantalon du Déicide"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PrimordialAncient"",
		""type"": ""ITEM"",
		""englishName"": ""Primordial Ancient"",
		""englishTooltip"": [
			""An ancient relic from an ancient land"",
			""Casts a gigantic blast of dust""
		],
		""name"": ""Ancien Primordial"",
		""tooltip"": [
			""Une ancienne relique d'une ancienne terre"",
			""Convoque une gigantesque déflagration de poussière""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OldPowerCell"",
		""type"": ""ITEM"",
		""englishName"": ""Old Power Cell"",
		""englishTooltip"": [
			""Summons the Golem when used in the temple"",
			""Not consumable""
		],
		""name"": ""Ancienne Cellule d'Alimentation"",
		""tooltip"": [
			""Invoque le golem quand utilisé dans le temple"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SlitheringEels"",
		""type"": ""ITEM"",
		""englishName"": ""Slithering Eels"",
		""englishTooltip"": [
			""Casts a magical acid eel that releases acid drops as it moves""
		],
		""name"": ""Anguilles Glissantes"",
		""tooltip"": [
			""Convoque une anguille magique d'acide qui relâche des gouttes d'acides quand elle bouge""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Animosity"",
		""type"": ""ITEM"",
		""englishName"": ""Animosity"",
		""englishTooltip"": [
			""50% chance to not consume ammo"",
			""Fires a powerful sniper round"",
			""Right click to fire a burst of bullets""
		],
		""name"": ""Animosité"",
		""tooltip"": [
			""50% de chances de ne pas consommer de munitions"",
			""Tire une puissante cartouche de sniper"",
			""Clic droit pour tirer une rafale de balles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HarpyRing"",
		""type"": ""ITEM"",
		""englishName"": ""Harpy Ring"",
		""englishTooltip"": [
			""10% increased movement speed"",
			""Boosts your maximum flight time by 20%""
		],
		""name"": ""Anneau de Harpie"",
		""tooltip"": [
			""+10% de vitesse de mouvement"",
			""Augmente votre temps de vol maximum de 20%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DarkSunRing"",
		""type"": ""ITEM"",
		""englishName"": ""Dark Sun Ring"",
		""englishTooltip"": [
			""Contains the power of the dark sun"",
			""12% increase to damage and melee speed"",
			""+1 life regen, 15% increased pick speed and +2 max minions"",
			""Increased minion knockback"",
			""During the day the player has +3 life regen"",
			""During the night the player has +15 defense"",
			""Both of these bonuses are granted during an eclipse""
		],
		""name"": ""Anneau du Sombresoleil"",
		""tooltip"": [
			""Contient le pouvoir du Sombresoleil"",
			""12% des dégâts supplémentaires et de vitesse de corps à corps"",
			""+1 régénération de vie, +15% de vitesse de minage, et augmente le nombre de sbires max de 2"",
			""Les sbires infligent plus de recul"",
			""+3 régénération de vie durant la journée"",
			""+15 défense durant la nuit"",
			""Ces deux bonus s'appliquent lors d'une éclipse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlanetaryAnnihilation"",
		""type"": ""ITEM"",
		""englishName"": ""Planetary Annihilation"",
		""englishTooltip"": [
			""Fires a storm of 7 arrows from the sky"",
			""Wooden arrows are converted into homing energy bolts""
		],
		""name"": ""Annihilation Planétaire"",
		""tooltip"": [
			""Tire une tempête de 7 flèches depuis les cieux"",
			""Les flèches en bois sont converties en décharges d'énergie à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BlackAnurian"",
		""type"": ""ITEM"",
		""englishName"": ""Black Anurian"",
		""englishTooltip"": [
			""Spews bubbles and homing plankton""
		],
		""name"": ""Anurian Noir"",
		""tooltip"": [
			""Crache des bulles et du plancton à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Aorta"",
		""type"": ""ITEM"",
		""englishName"": ""Aorta"",
		""englishTooltip"": [
			""Fires homing blood when enemies are near"",
			""An exceptionally agile yoyo""
		],
		""name"": ""Aorte"",
		""tooltip"": [
			""Tire du sang qui pourchassent les ennemis quand ils sont proches"",
			""Un yoyo exceptionnellement agile""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Apoctolith"",
		""type"": ""ITEM"",
		""englishName"": ""Apoctolith"",
		""englishTooltip"": [
			""Maybe catching bricks with your face isn't such a hot idea..."",
			""Critical hits tear away enemy defense"",
			""Stealth strikes shatter and briefly stun enemies""
		],
		""name"": ""Apoctolite"",
		""tooltip"": [
			""Peut-être qu'attraper des briques avec vos dents n'était pas une si bonne idée en fin de compte..."",
			""Les coups critiques réduisent la défense ennemie progressivement"",
			""Les attaques furtives se brisent et immobilisent brièvement les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Apotheosis"",
		""type"": ""ITEM"",
		""englishName"": ""Apotheosis"",
		""englishTooltip"": [
			""Eat worms"",
			""Unleashes interdimensional projection magic""
		],
		""name"": ""Apothéose"",
		""tooltip"": [
			""Mange tes vers"",
			""Libère une magie de projection interdimensionnelle""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WyvernsCall"",
		""type"": ""ITEM"",
		""englishName"": ""Wyvern's Call"",
		""englishTooltip"": [
			""I call upon the mythical Wyvern to shower the lands with its grace"",
			""Fires wyverns and colored feathers from the sky that stick to enemies and tiles and explode""
		],
		""name"": ""Appel de la Wyverne"",
		""tooltip"": [
			""Je fais appel à la mythique wyverne pour inonder les terres de sa grace"",
			""Tire des wyvernes et des plumes colorées depuis le ciel qui se collent aux ennemis et aux tuiles avant d'exploser""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueCaller"",
		""type"": ""ITEM"",
		""englishName"": ""Plague Caller"",
		""englishTooltip"": [
			""Summons a baby Plaguebringer pet""
		],
		""name"": ""Appeleur de Peste"",
		""tooltip"": [
			""Invoque un compagnon colporte-peste""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AlluringBait"",
		""type"": ""ITEM"",
		""englishName"": ""Alluring Bait"",
		""englishTooltip"": [
			""30 increased fishing power during the day"",
			""45 increased fishing power during the night"",
			""60 increased fishing power during a solar eclipse"",
			""Greatly increases chance of catching potion ingredient fish""
		],
		""name"": ""Appât attrayant"",
		""tooltip"": [
			""+30 puissance de pêche le jour"",
			""+45 puissance de pêche la nuit"",
			""+60 puissance de pêche lors d'une éclipse solaire"",
			""Augmente considérablement les chances d'attraper des poissons servant de matériau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Arbalest"",
		""type"": ""ITEM"",
		""englishName"": ""Arbalest"",
		""englishTooltip"": [
			""Fires a volley of 10 high-speed arrows"",
			""Arrows start off small and grow in size with continuous fire"",
			""Arrow damage, spread and knockback scale with arrow size""
		],
		""name"": ""Arbalest"",
		""tooltip"": [
			""Tire une volée de 10 flèches rapides"",
			""Les flèches sont petites initialement et gagnent en taille si vous tirez en continu"",
			""Le recul, les dégâts et l'étendue des flèches varient selon la taille des flèches""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralRepeater"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Bow"",
		""englishTooltip"": [
			""Fires a burst of three arrows""
		],
		""name"": ""Arc Astral"",
		""tooltip"": [
			""Tire une volée de 3 flèches""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CorrodedCaustibow"",
		""type"": ""ITEM"",
		""englishName"": ""Corroded Caustibow"",
		""englishTooltip"": [
			""Converts wooden arrows into slow, powerful shells that trail an irradiated aura""
		],
		""name"": ""Arc Caustique Corrodé"",
		""tooltip"": [
			""Convertit les flèches en bois en lents et puissants coquillages qui laissent dans leur sillage une aura irradiée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LunarianBow"",
		""type"": ""ITEM"",
		""englishName"": ""Lunarian Bow"",
		""englishTooltip"": [
			""Fires two arrows at once"",
			""Converts wooden arrows into sliding energy bolts""
		],
		""name"": ""Arc Lunaire"",
		""tooltip"": [
			""Tire deux flèches à la fois"",
			""Convertit les flèches en bois en deux décharges d'énergie glissantes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ClockworkBow"",
		""type"": ""ITEM"",
		""englishName"": ""Clockwork Bow"",
		""englishTooltip"": [
			""Hold left click to load up to six precision bolts"",
			""The more precision bolts are loaded, the harder they hit""
		],
		""name"": ""Arc Mécanique"",
		""tooltip"": [
			""Maintenez le clic gauche pour charger jusqu'a 6 carreaux de précision"",
			""Au plus vous chargez de carreaux, au plus ils infligent de dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumBow"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Bow"",
		""name"": ""Arc Wulfrum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EffluviumBow"",
		""type"": ""ITEM"",
		""englishName"": ""Effluvium Bow"",
		""englishTooltip"": [
			""Fires two arrows at once"",
			""Converts wooden arrows into mist arrows""
		],
		""name"": ""Arc d'Effluve"",
		""tooltip"": [
			""Tire deux flèches à la fois"",
			""Convertit les flèches en bois en flèches de brûme""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FlarewingBow"",
		""type"": ""ITEM"",
		""englishName"": ""Flarewing Bow"",
		""englishTooltip"": [
			""Shoots a spread of 5 arrows"",
			""Wooden arrows are converted into bouncing obsidian bats""
		],
		""name"": ""Arc d'Éclataile"",
		""tooltip"": [
			""Tire une volée de 5 flèches"",
			""Les flèches de bois deviennent des chauves-souris rebondissantes d'obsidienne""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MarksmanBow"",
		""type"": ""ITEM"",
		""englishName"": ""Marksman Bow"",
		""englishTooltip"": [
			""Fires three arrows at once"",
			""Wooden arrows are converted into Jester's arrows""
		],
		""name"": ""Arc du Tireur d'Élite"",
		""tooltip"": [
			""Tire trois flèches à la fois"",
			""Les flèches de bois sont converties en flèches du bouffon""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicRainbow"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmic Rainbow"",
		""englishTooltip"": [
			""Launches a barrage of rainbows""
		],
		""name"": ""Arc-en-Ciel Cosmique"",
		""tooltip"": [
			""Lance un barrage d'arcs-en-ciel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralArcanum"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Arcanum"",
		""englishTooltip"": [
			""Provides immunity to the astral infection debuff"",
			""Boosts life regen even while under the effects of a damaging debuff"",
			""While under the effects of a damaging debuff you will gain 15 defense"",
			""TOOLTIP LINE HERE""
		],
		""name"": ""Arcanum Astral"",
		""tooltip"": [
			""Immunité à l'infection astrale"",
			""Augmente la régénération de vie même si vous subissez des dégâts sur la durée"",
			""Quand vous subissez des dégâts sur la durée, vous gagnez 15 défense"",
			""TOOLTIP LINE HERE""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ArchAmaryllis"",
		""type"": ""ITEM"",
		""englishName"": ""Arch Amaryllis"",
		""englishTooltip"": [
			""Casts a beaming flower that explodes into homing petals""
		],
		""name"": ""Arche d'Amaryllis"",
		""tooltip"": [
			""Convoque une fleur rayonnante qui exposent en pétales qui pourchassent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TrueArkoftheAncients"",
		""type"": ""ITEM"",
		""englishName"": ""Ark of the Ancients"",
		""englishTooltip"": [
			""This line gets set in ModifyTooltips"",
			""A heavenly blade forged to vanquish all evil""
		],
		""name"": ""Arche des Anciens"",
		""tooltip"": [
			""This line gets set in ModifyTooltips"",
			""Une lame céleste forgée pour vaincre le mal""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ArkoftheElements"",
		""type"": ""ITEM"",
		""englishName"": ""Ark of the Elements"",
		""englishTooltip"": [
			""This line gets set in ModifyTooltips"",
			""This line also gets set in ModifyTooltips"",
			""This line also gets set in ModifyTooltips"",
			""A heavenly pair of blades infused with the essence of Terraria, powerful enough to cut through the fabric of reality""
		],
		""name"": ""Arche des Élements"",
		""tooltip"": [
			""This line gets set in ModifyTooltips"",
			""This line also gets set in ModifyTooltips"",
			""This line also gets set in ModifyTooltips"",
			""Une paire céleste de lames infusée avec l'essence de Terraria, suffisamment puissantes pour trancher le tissu de la réalité""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ArkoftheCosmos"",
		""type"": ""ITEM"",
		""englishName"": ""Ark of the Cosmos"",
		""englishTooltip"": [
			""This line gets set in ModifyTooltips"",
			""This line also gets set in ModifyTooltips"",
			""This line also gets set in ModifyTooltips"",
			""The physical culmination of your journey, capable of rending gods asunder""
		],
		""name"": ""Arche du Cosmos"",
		""tooltip"": [
			""This line gets set in ModifyTooltips"",
			""This line also gets set in ModifyTooltips"",
			""This line also gets set in ModifyTooltips"",
			""La manifestation physique du pinnacle de votre périple, capable de déchirer les dieux en pièces""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ArcturusAstroidean"",
		""type"": ""ITEM"",
		""englishName"": ""Arcturus Astroidean"",
		""englishTooltip"": [
			""Increases fishing power if used in the Astral Infection or Sulphurous Sea""
		],
		""name"": ""Arcturus Astéroïdien"",
		""tooltip"": [
			""Augmente la puissance de pêche dans l'infection astrale ou la mer sulfurique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SilvaArmor"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Armor"",
		""englishTooltip"": [
			""+80 max life"",
			""12% increased damage and 8% increased critical strike chance""
		],
		""name"": ""Armure Silva"",
		""tooltip"": [
			""+80 vie maximum"",
			""+12% de dégâts et +8% de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StatigelArmor"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Armor"",
		""englishTooltip"": [
			""5% increased critical strike chance""
		],
		""name"": ""Armure Statigel"",
		""tooltip"": [
			""+5% de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumArmor"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Armor"",
		""englishTooltip"": [
			""3% increased critical strike chance""
		],
		""name"": ""Armure Wulfrum"",
		""tooltip"": [
			""+3% de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FearmongerPlateMail"",
		""type"": ""ITEM"",
		""englishName"": ""Fearmonger Plate Mail"",
		""englishTooltip"": [
			""+100 max life and 8% increased damage reduction"",
			""5% increased damage and critical strike chance""
		],
		""name"": ""Armure de Plates du Sème-Peur"",
		""tooltip"": [
			""+100 vie maximum et +8% de réduction de dégâts"",
			""+5% des dégâts et de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ApoctosisArray"",
		""type"": ""ITEM"",
		""englishName"": ""Apoctosis Array"",
		""englishTooltip"": [
			""Fires ion blasts that speed up and then explode"",
			""Damage scales with how full your mana is"",
			""Using Astral Injection reduces the effectiveness of the mana boost""
		],
		""name"": ""Arsenal d'Apoctose"",
		""tooltip"": [
			""Tire des décharges ioniques qui accélèrent avant d'exploser"",
			""Au plus votre mana est élevé, au plus les dégâts sont élevés"",
			""Les stéroïdes astraux réduisent la puissance de cet effet""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ArtAttack"",
		""type"": ""ITEM"",
		""englishName"": ""Art Attack"",
		""englishTooltip"": [
			""Casts a star that follows the mouse that creates a rainbow trail as it moves"",
			""Once a full shape is created with the trail all enemies within it take damage proportional to how long it took to draw the shape"",
			""And the audience goes wild!""
		],
		""name"": ""Art Attack"",
		""tooltip"": [
			""Lance une étoile qui suit le curseur et crée une trainée irisée en se déplaçant"",
			""Une fois qu'une forme complète est créée avec la trainée, tous les ennemis prennent des dégâts proportionnels au temps qu'il a fallu pour créer la forme"",
			""Et la foule part en délire!""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EldritchSoulArtifact"",
		""type"": ""ITEM"",
		""englishName"": ""Eldritch Soul Artifact"",
		""englishTooltip"": [
			""Knowledge"",
			""Boosts melee speed by 10%, ranged velocity by 25%, rogue damage by 15%, max minions by 2 and reduces mana cost by 15%"",
			""Grants immunity to Whispering Death""
		],
		""name"": ""Artefact d'Âme d'Eldritch"",
		""tooltip"": [
			""Connaissance"",
			""Augmente la vitesse de corps à corps de 10%, la vitesse des projectiles à distance de 25%, les dégâts de voleurs de 15%, les emplacements de sbires max de 2 et réduit les coûts en mana de 15%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AridArtifact"",
		""type"": ""ITEM"",
		""englishName"": ""Arid Artifact"",
		""englishTooltip"": [
			""Summons a sandstorm"",
			""The sandstorm will happen shortly after the item is used"",
			""Not consumable""
		],
		""name"": ""Artéfact Aride"",
		""tooltip"": [
			""Invoque une tempête de sable"",
			""La tempête de sable arrivera peu après l'utilisation de l'objet"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GodlySoulArtifact"",
		""type"": ""ITEM"",
		""englishName"": ""Godly Soul Artifact"",
		""englishTooltip"": [
			""Loyalty"",
			""For each Fiery Draconid you have summoned, you gain 1 minion slot""
		],
		""name"": ""Artéfact d'Âme Divine"",
		""tooltip"": [
			""Loyauté"",
			""+1 emplacement de sbire par Draconide Ardent invoqué""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedSoulArtifact"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Soul Artifact"",
		""englishTooltip"": [
			""Purity"",
			""Summons a healer guardian which heals for a certain amount of health every few seconds"",
			""Summons a defensive guardian if you have at least 10 minion slots, which boosts your movement speed and your damage resistance"",
			""Summons an offensive guardian if you are wearing the tarragon summon set (or stronger), which boosts your summon damage and your minion slots"",
			""If you get hit, most of their effects will disappear for 5 seconds""
		],
		""name"": ""Artéfact d'Âme Profanée"",
		""tooltip"": [
			""Pureté"",
			""Invoque un gardien guérisseur qui vous soigne d'un certain montant à quelques secondes d'intervale"",
			""Invoque un gardien protecteur si vous avez au moins 10 sbires max, qui augmente votre vitesse de déplacement et votre résistance aux dégâts"",
			""Invoque un gardien offensif si vous portez l'armure d'estragon (ou supérieur), qui augmente vos dégâts d'invocation et votre nombre de sbires max"",
			""Si vous êtes touché, la plupart de ces effets sont annulés durant 5 secondes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DimensionalSoulArtifact"",
		""type"": ""ITEM"",
		""englishName"": ""Dimensional Soul Artifact"",
		""englishTooltip"": [
			""Power"",
			""Boosts all damage by 25%, but at what cost?"",
			""Increases all damage taken by 15%""
		],
		""name"": ""Artéfact de l'Âme Dimensionnelle"",
		""tooltip"": [
			""Pouvoir"",
			""Augmente tous les dégâts de 25%, mais à quel prix ?"",
			""Augmente tous les dégâts subis de 15%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ArterialAssault"",
		""type"": ""ITEM"",
		""englishName"": ""Arterial Assault"",
		""englishTooltip"": [
			""Fires a chain of 5 arrows from the sky"",
			""Wooden arrows are converted into homing bloodfire arrows""
		],
		""name"": ""Assaut Artériel"",
		""tooltip"": [
			""Tire une rafale de 5 flèches depuis le ciel"",
			""Les flèches de bois sont converties en flèches de brûlesang qui pourchassent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstrophageItem"",
		""type"": ""ITEM"",
		""englishName"": ""Astrophage"",
		""englishTooltip"": [
			""Summons an astrophage to follow you around""
		],
		""name"": ""Astrophage"",
		""tooltip"": [
			""Invoque un astrophage pour vous suivre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeAstrumAureus"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Aureus"",
		""englishTooltip"": [
			""A titanic cyborg infected by a star-borne disease expelled from the belly of an ancient god."",
			""The destruction of this creature will not prevent the spread of the disease.""
		],
		""name"": ""Astrum Aureus"",
		""tooltip"": [
			""Un cyborg titanesque infecté par une maladie stellaire expulsée du ventre d'un dieu ancien."",
			""La destruction de cette créature n'empêchera pas la propagation de la maladie.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeAstrumDeus"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Deus"",
		""englishTooltip"": [
			""God of the stars and largest vessel for the Astral Infection."",
			""Though struck down from its place among the stars its remnants have gathered strength, aiming to take its rightful place in the cosmos once more.""
		],
		""name"": ""Astrum Deus"",
		""tooltip"": [
			""Dieu des étoiles et le plus grand vaisseau de l'infection astrale."",
			""Bien qu'abattu et déchu de sa place parmi les étoiles, ses restes ont accumulé de la puissance et il cherchen à reprendre sa place légitime dans le cosmos.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Ataraxia"",
		""type"": ""ITEM"",
		""englishName"": ""Ataraxia"",
		""englishTooltip"": [
			""Equanimity""
		],
		""name"": ""Ataraxie"",
		""tooltip"": [
			""Équanimité""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Atlantis"",
		""type"": ""ITEM"",
		""englishName"": ""Atlantis"",
		""englishTooltip"": [
			""Casts aquatic spears that split as they travel""
		],
		""name"": ""Atlantide"",
		""tooltip"": [
			""Convoque des lances aquatiques qui se divisent en vol""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SulphurousGrabber"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Grabber"",
		""englishTooltip"": [
			""Occasionally releases a ring of colored bubbles"",
			""The yoyo powers up after touching a green bubble"",
			""A very agile yoyo""
		],
		""name"": ""Attrapeur Sulfureux"",
		""tooltip"": [
			""Relâche occasionnellement un anneau de bulle colorées"",
			""Le yoyo gagne en puissance après avoir touché une bulle verte"",
			""Un yoyo très agile""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AuguroftheElements"",
		""type"": ""ITEM"",
		""englishName"": ""Augur of the Elements"",
		""englishTooltip"": [
			""Casts a burst of elemental tentacles to spear your enemies""
		],
		""name"": ""Augure des Éléments"",
		""tooltip"": [
			""Convoque une déflagration de tentacules élémentaires pour empaler vos ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Auralis"",
		""type"": ""ITEM"",
		""englishName"": ""Auralis"",
		""englishTooltip"": [
			""Fires a high speed glowing bullet that inflicts debilitating debuffs"",
			""Right click to zoom out"",
			""Standing still provides increasing damage bonuses up to 25%"",
			""Standing still for 5 or more seconds while using the scope ability will summon an aurora"",
			""The aurora reduces the damage of the next projectile hit by a flat 100"",
			""This effect lasts up to 20 seconds and has a 30 second cooldown"",
			""50% chance to not consume bullets""
		],
		""name"": ""Auralis"",
		""tooltip"": [
			""Tire une balle luminescente ultra rapide qui inflige des altérations d'état débilitantes"",
			""Clic droit pour dézoomer"",
			""Rester immobile augmente vos bonus aux dégâts jusqu'a 25%"",
			""Rester immobile durant 5 secondes en utilisant la lunette invoquera une aurore"",
			""L'aurore réduit les dégâts subis du prochain projectile qui vous touche de 100"",
			""Cet effet dure 20s, et met 30s à se recharger"",
			""50% de chances de ne pas consommer de munitions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AncientAltar"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": ""Autel Ancien"",
		""tooltip"": [
			""Utilisé pour l'artisanat spécial""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AshenAltar"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": ""Autel de Cendre"",
		""tooltip"": [
			""Utilisé pour l'artisanat spécial""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Avalanche"",
		""type"": ""ITEM"",
		""englishName"": ""Avalanche"",
		""englishTooltip"": [
			""Spawns ice bombs that explode after 3 seconds into ice shards on hit""
		],
		""name"": ""Avalanche"",
		""tooltip"": [
			""Invoque des bombes de glace qui explosent après trois secondes, avec des éclats de glace si elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ViridVanguard"",
		""type"": ""ITEM"",
		""englishName"": ""Virid Vanguard"",
		""englishTooltip"": [
			""Summons 2 blades that rotate around you"",
			""Each pair of blades takes up three minion slots"",
			""Right clicking prompts all blades to fly upward and redirect towards the mouse""
		],
		""name"": ""Avant-Garde Viride"",
		""tooltip"": [
			""Invoque deux lames qui tournent autour de vous"",
			""Chaque paire de lame occupe trois emplacements de sbires"",
			""Clic droit pour ordonner aux lames de se diriger vers la souris""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TyphonsGreed"",
		""type"": ""ITEM"",
		""englishName"": ""Typhon's Greed"",
		""englishTooltip"": [
			""Summons water spirits while in use""
		],
		""name"": ""Avarice de Typhon"",
		""tooltip"": [
			""Invoque des esprits d'eau quand vous l'utilisez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Azathoth"",
		""type"": ""ITEM"",
		""englishName"": ""Azathoth"",
		""englishTooltip"": [
			""Fires cosmic orbs that blast nearby enemies with lasers"",
			""A very agile yoyo"",
			""Destroy the universe in the blink of an eye""
		],
		""name"": ""Azathoth"",
		""tooltip"": [
			""Tire des orbes cosmiques qui détruisent les ennemis proches avec des lasers"",
			""Un yoyo très agile"",
			""Détruit l'univers en un clin d'oeil""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AeroStone"",
		""type"": ""ITEM"",
		""englishName"": ""Aero Stone"",
		""englishTooltip"": [
			""One of the ancient relics"",
			""Increases flight time, movement speed and jump speed by 10%""
		],
		""name"": ""Aéropierre"",
		""tooltip"": [
			""Une des anciennes reliques"",
			""Augmente la vitesse de déplacement, la vitesse de saut et le temps de vol de 10%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BadgeofBravery"",
		""type"": ""ITEM"",
		""englishName"": ""Badge of Bravery"",
		""englishTooltip"": [
			""15% increased melee speed"",
			""Increases melee damage and melee crit by 5%"",
			""+5 armor penetration""
		],
		""name"": ""Badge de Bravoure"",
		""tooltip"": [
			""+15% de vitesse de corps à corps"",
			""Augmente les dégats et les chances de critique en mêlée de 5%"",
			""+5 pénétration d'armure""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Baguette"",
		""type"": ""ITEM"",
		""englishName"": ""Baguette"",
		""englishTooltip"": [
			""{$CommonItemTooltip.MinorStats}"",
			""Boosts the effects of Red Wine"",
			""[c/FCE391:je suis Monte]""
		],
		""name"": ""Baguette"",
		""tooltip"": [
			""Amélioration mineure de toutes les statistiques"",
			""Augmente les effets du Vin Rouge"",
			""[c/FCE391:je suis Monte]""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ForgottenApexWand"",
		""type"": ""ITEM"",
		""englishName"": ""Forgotten Apex Wand"",
		""englishTooltip"": [
			""Summons ancient mineral sharks to take on your foes. "",
			""Seems to have lost its jaw some time in the past""
		],
		""name"": ""Baguette Apex Oubliée"",
		""tooltip"": [
			""Invoque d'anciens requins minéraux pour s'occuper de vos ennemis."",
			""On dirait qu'il a perdu sa mâchoire depuis quelques temps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NuclearRod"",
		""type"": ""ITEM"",
		""englishName"": ""Nuclear Rod"",
		""englishTooltip"": [
			""Minions release an irradiated aura on enemy hits"",
			""+1 max minion"",
			""Grants immunity to Irradiated""
		],
		""name"": ""Baguette Nucléaire"",
		""tooltip"": [
			""Les sbires produisent une aura irradiante lorsqu'ils touchent les ennemis"",
			""+1 sbire max""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HyphaeRod"",
		""type"": ""ITEM"",
		""englishName"": ""Hyphae Rod"",
		""englishTooltip"": [
			""Creates mushroom spores near the player""
		],
		""name"": ""Baguette d'Hyphe"",
		""tooltip"": [
			""Crée des spores fongiques près du joueurs""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlasmaRod"",
		""type"": ""ITEM"",
		""englishName"": ""Plasma Rod"",
		""englishTooltip"": [
			""Casts a low-damage plasma bolt"",
			""Shooting a tile will cause several bolts with increased damage to fire"",
			""Shooting an enemy will inflict shadowflame for a long duration""
		],
		""name"": ""Baguette de Plasma"",
		""tooltip"": [
			""Tire un faible faisceau de plasma"",
			""Tirer sur une tuile fera se diviser le faisceau en plusieurs rayons plus puissants"",
			""Tirer sur un ennemi lui infligera la flamme sombre sur une longue période""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Elderberry"",
		""type"": ""ITEM"",
		""englishName"": ""Elderberry"",
		""englishTooltip"": [
			""A tangy, tart flavor with a somewhat earthen touch"",
			""Permanently increases maximum life by 25"",
			""Can only be used if the max amount of life fruit has been consumed""
		],
		""name"": ""Baie Ancienne"",
		""tooltip"": [
			""Une saveur piquante, acidulée avec une touche du terreau"",
			""Augmente la vie maximum de 25 de façon permanente"",
			""Peut seulement être utilisé si vous avez consommé le nombre maximum de fruits de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateBathtub"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Bathtub"",
		""name"": ""Baignoire Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodBath"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Bath"",
		""englishTooltip"": [
			""Drenches your foes in blood""
		],
		""name"": ""Bain de Sang"",
		""tooltip"": [
			""Trempe vos ennemis de sang""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralBeaconItem"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Beacon"",
		""englishTooltip"": [
			""Summons Astrum Deus in exchange for specific offerings""
		],
		""name"": ""Balise Astrale"",
		""tooltip"": [
			""Invoque Astrum Deus en échange de certaines offrandes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NecroplasmicBeacon"",
		""type"": ""ITEM"",
		""englishName"": ""Necroplasmic Beacon"",
		""englishTooltip"": [
			""It's spooky"",
			""Summons Polterghast when used in the dungeon"",
			""Not consumable""
		],
		""name"": ""Balise Nécroplasmique"",
		""tooltip"": [
			""Ca fait peur"",
			""Invoque l'Épouvantôme quand utilisé dans le donjon"",
			""Ne se consomme pas""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MartianDistressBeacon"",
		""type"": ""ITEM"",
		""englishName"": ""Martian Distress Beacon"",
		""englishTooltip"": [
			""Summons the Martian Madness"",
			""Not consumable""
		],
		""name"": ""Balise de Détresse Martienne"",
		""tooltip"": [
			""Invoque la folie martienne"",
			""Ne se consomme pas""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MidnightSunBeacon"",
		""type"": ""ITEM"",
		""englishName"": ""Midnight Sun Beacon"",
		""englishTooltip"": [
			""Summons a UFO to vaporize enemies""
		],
		""name"": ""Balise du Soleil de Minuit"",
		""tooltip"": [
			""Invoque un OVNI qui vaporise les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GodSlayerSlug"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Slug"",
		""englishTooltip"": [
			""Heavy ammunition with unlimited piercing that tears through spacetime"",
			""After a slug lands a hit, if it strikes a wall or runs out of targets to pierce,"",
			""it warps backwards through space and supercharges, exploding on impact""
		],
		""name"": ""Balle Déicide"",
		""tooltip"": [
			""Des munitions lourdes qui transpercent indéfiniment en déchirant l'espace-temps"",
			""Après avoir touché, si la balle touche un mur ou ne peut plus percer,"",
			""Elle se téléporte en arrière dans l'espace et se supercharge, explosant alors à l'impact""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""IcyBullet"",
		""type"": ""ITEM"",
		""englishName"": ""Icy Bullet"",
		""englishTooltip"": [
			""Can hit up to three times"",
			""Breaks into ice shards on last impact""
		],
		""name"": ""Balle Glacée"",
		""tooltip"": [
			""Peut toucher jusqu'à trois fois"",
			""Se brise en éclats de glace au dernier impact""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HyperiusBullet"",
		""type"": ""ITEM"",
		""englishName"": ""Hyperius Bullet"",
		""englishTooltip"": [
			""Your enemies might have a bad time"",
			""Spawns additional bullets on enemy hits""
		],
		""name"": ""Balle Hyperius"",
		""tooltip"": [
			""Vos ennemis risquent de passer un mauvais moment"",
			""Crée des balles supplémentaires quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RotBall"",
		""type"": ""ITEM"",
		""englishName"": ""Rot Ball"",
		""englishTooltip"": [
			""Stealth strikes spawn rain clouds on enemy hits""
		],
		""name"": ""Balle Pourrie"",
		""tooltip"": [
			""Les attaques furtives créent des nuages de pluie quand elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TerraBullet"",
		""type"": ""ITEM"",
		""englishName"": ""Terra Bullet"",
		""englishTooltip"": [
			""Explodes and splits into homing terra shards on death""
		],
		""name"": ""Balle Terra"",
		""tooltip"": [
			""Explose en éclats à tête chercheuse à l'impact""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ToothBall"",
		""type"": ""ITEM"",
		""englishName"": ""Tooth Ball"",
		""englishTooltip"": [
			""Stealth strikes spawn rain clouds on enemy hits""
		],
		""name"": ""Balle de Dents"",
		""tooltip"": [
			""Les attaques furtives créent des nuages de pluie quand elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HolyFireBullet"",
		""type"": ""ITEM"",
		""englishName"": ""Holy Fire Bullet"",
		""englishTooltip"": [
			""Explosive holy bullets""
		],
		""name"": ""Balle de Feu Sacré"",
		""tooltip"": [
			""Balles sacrées explosives""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BallOFugu"",
		""type"": ""ITEM"",
		""englishName"": ""Ball O' Fugu"",
		""englishTooltip"": [
			""Throws a fish that spews homing spikes""
		],
		""name"": ""Balle de Fugu"",
		""tooltip"": [
			""Lance un poisson qui crache des épines à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BleachBall"",
		""type"": ""ITEM"",
		""englishName"": ""Bleach Ball"",
		""englishTooltip"": [
			""Favorite this item to prevent the Aquatic Scourge from naturally spawning near you""
		],
		""name"": ""Balle de Javel"",
		""tooltip"": [
			""Favorisez cet objet pour empêcher le Fléau Aquatique d'apparaître""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodfireBullet"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodfire Bullet"",
		""englishTooltip"": [
			""Accelerates your life regeneration on hit"",
			""Deals bonus damage based on your current life regeneration""
		],
		""name"": ""Balle de Sang de Feu"",
		""tooltip"": [
			""Accélère la régénération de vie quand vous touchez"",
			""Inflige des dégâts additionnels en fonction de votre régénération de vie actuelle""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VeriumBullet"",
		""type"": ""ITEM"",
		""englishName"": ""Verium Bullet"",
		""englishTooltip"": [
			""There is no escape!"",
			""Homes in after striking an enemy""
		],
		""name"": ""Balle de Verium"",
		""tooltip"": [
			""Il n'y a pas d'échappatoire!"",
			""Pourchasse l'ennemi après l'avoir touché""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ForbiddenCirclet"",
		""type"": ""ITEM"",
		""englishName"": ""Forbidden Circlet"",
		""englishTooltip"": [
			""10% increased summon damage and 15% increased rogue velocity""
		],
		""name"": ""Bandeau Interdit"",
		""tooltip"": [
			""+10% de dégâts d'invocation et +15% de vitesse des projectiles de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HadarianBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Hadarian""
		],
		""name"": ""Bannière d'Hadarien"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Hadarien""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GhostBellBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ghost Bell""
		],
		""name"": ""Bannière de Cloche Fantôme"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cloche Fantôme""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DevilFishBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Devil Fish""
		],
		""name"": ""Bannière de Poisson Démoniaque"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Poisson Démoniaque""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AmberCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Amber Crawler""
		],
		""name"": ""Bannière de Rampant d'Ambre"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Rampant d'Ambre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CragBullhead"",
		""type"": ""ITEM"",
		""englishName"": ""Crag Bullhead"",
		""englishTooltip"": [
			""Its scales are scorching hot""
		],
		""name"": ""Barbotte des Vestiges"",
		""tooltip"": [
			""Ses écailles sont brûlantes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AcidicRainBarrel"",
		""type"": ""ITEM"",
		""englishName"": ""Acidic Rain Barrel"",
		""englishTooltip"": [
			""Throws a rolling barrel that explodes on wall collision"",
			""Stealth strikes make it rain on collision""
		],
		""name"": ""Baril de Pluie Acide"",
		""tooltip"": [
			""Lance un baril roulant qui explose contre les murs"",
			""Les attaques furtives font pleuvoir quand elles heurtent quelque chose""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Barinade"",
		""type"": ""ITEM"",
		""englishName"": ""Barinade"",
		""englishTooltip"": [
			""Converts wooden arrows into electric bolt arrows that explode""
		],
		""name"": ""Barinade"",
		""tooltip"": [
			""Convertit les flèches en bois en flèches électriques qui explosent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Barinautical"",
		""type"": ""ITEM"",
		""englishName"": ""Barinautical"",
		""englishTooltip"": [
			""Converts wooden arrows into strings of 3 electric bolt arrows that explode""
		],
		""name"": ""Barinautique"",
		""tooltip"": [
			""Convertit les flèches en bois en une chaîne de 3 carreaux électriques qui explosent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BrinyBaron"",
		""type"": ""ITEM"",
		""englishName"": ""Briny Baron"",
		""englishTooltip"": [
			""Striking an enemy with the blade causes a briny typhoon to appear"",
			""Right click to fire a razorwind aqua blade""
		],
		""name"": ""Baron Salé"",
		""tooltip"": [
			""Frapper un ennemi avec la lame fait apparaître un tourbillon salé"",
			""Clic droit pour tirer une roue acérée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ShadecrystalTome"",
		""type"": ""ITEM"",
		""englishName"": ""Shadecrystal Barrage"",
		""englishTooltip"": [
			""Summons rapid fire shadecrystals, can shoot two crystals at once""
		],
		""name"": ""Barrage de Cristalombre"",
		""tooltip"": [
			""Invoque des cristalombres en rafale, peut tirer deux cristaux à la fois""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PhoenixFlameBarrage"",
		""type"": ""ITEM"",
		""englishName"": ""Phoenix Flame Barrage"",
		""englishTooltip"": [
			""Baptism by holy fire"",
			""Casts a barrage of fire from the sky""
		],
		""name"": ""Barrage de Flamme de Phénix"",
		""tooltip"": [
			""Le baptème du feu sacré"",
			""Convoque un barrage de feu depuis les cieux""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""IceBarrage"",
		""type"": ""ITEM"",
		""englishName"": ""Ice Barrage"",
		""englishTooltip"": [
			""Oh dear, you are dead!"",
			""Casts a deadly and powerful ice spell in the location of the cursor"",
			""This ice spell locks itself to the position of nearby enemies"",
			""Consumes 2 Blood Runes every time it's used""
		],
		""name"": ""Barrage de Glace"",
		""tooltip"": [
			""Oh ciel, tu es mort!"",
			""Invoque un puissant et mortel sort de glace à l'emplacement du curseur"",
			""Ce sort de glace se bloque à la position des ennemis proches"",
			""Consomme 2 runes de sang à chaque fois que vous l'utilisez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AuricBar"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Bar"",
		""englishTooltip"": [
			""Godlike power emanates from the metal""
		],
		""name"": ""Barre Aurique"",
		""tooltip"": [
			""Un pouvoir divin émane de ce métal""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FrostBarrier"",
		""type"": ""ITEM"",
		""englishName"": ""Frost Barrier"",
		""englishTooltip"": [
			""You will freeze enemies near you when you are struck"",
			""You are immune to the chilled debuff""
		],
		""name"": ""Barrière Givrée"",
		""tooltip"": [
			""Vous gelez les ennemis autour de vous quand vous êtes touché"",
			""Immunité au refroidissement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CodebreakerBase"",
		""type"": ""ITEM"",
		""englishName"": ""Codebreaker Base"",
		""name"": ""Base du Décodeur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SilvaBasin"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": ""Bassin Silva"",
		""tooltip"": [
			""Utilisé pour l'artisanat spécial""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmiliteBasin"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmilite Basin"",
		""name"": ""Bassin en Cosmilite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumBattery"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Battery"",
		""englishTooltip"": [
			""7% increased summon damage""
		],
		""name"": ""Batterie Wulfrum"",
		""tooltip"": [
			""+7% de dégâts d'invocation""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""JellyChargedBattery"",
		""type"": ""ITEM"",
		""englishName"": ""Jelly-Charged Battery"",
		""englishTooltip"": [
			""+1 max minions and 7% minion damage"",
			""Minion attacks spawn orbs of energy and inflict Electrified""
		],
		""name"": ""Batterie de Gelée"",
		""tooltip"": [
			""+1 sbire max et +7% de dégâts d'invocation"",
			""Les attaques des sbires génèrent de petites orbes électriques et infligent électrisé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Bazooka"",
		""type"": ""ITEM"",
		""englishName"": ""Bazooka"",
		""englishTooltip"": [
			""Uses Grenade Shells"",
			""Can be used twice per boss battle""
		],
		""name"": ""Bazooka"",
		""tooltip"": [
			""Utilise des cartouches de grenade"",
			""Peut être utilisé deux fois par combat de boss""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TrinketofChi"",
		""type"": ""ITEM"",
		""englishName"": ""Trinket of Chi"",
		""englishTooltip"": [
			""After 1 second of standing still and not attacking you gain a buff"",
			""This buff boosts your damage by 50% and decreases damage taken by 15%"",
			""The buff deactivates after you move or attack once""
		],
		""name"": ""Bibelot de Chi"",
		""tooltip"": [
			""Après une seconde sans bouger et sans attaquer, vous recevez une amélioration"",
			""Cette amélioration augmente vos dégâts de 50% et diminue les dégâts subis de 15%"",
			""Cette amélioration est perdue une fois que vous bougez ou que vous attaquez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateBookcase"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Bookcase"",
		""name"": ""Bibliothèque Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ContaminatedBile"",
		""type"": ""ITEM"",
		""englishName"": ""Contaminated Bile"",
		""englishTooltip"": [
			""Throws a flask of sickly green, irradiated bile which explodes on collision"",
			""Stealth strikes make the explosion much more violent and powerful""
		],
		""name"": ""Bile Contaminée"",
		""tooltip"": [
			""Lance une flasque de bile verte irradiée et maladive, qui explose à l'impact"",
			""Les attaques furtives explosent bien plus violemment""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GrapeBeer"",
		""type"": ""ITEM"",
		""englishName"": ""Grape Beer"",
		""englishTooltip"": [
			""This crap is abhorrent but you might like it"",
			""Reduces defense by 3% and movement speed by 5%""
		],
		""name"": ""Bière au Raisin"",
		""tooltip"": [
			""Cette merde est exécrable mais tu pourrais aimer"",
			""Réduit la défense de 3% et la vitesse de mouvement de 5%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OceanCrest"",
		""type"": ""ITEM"",
		""englishName"": ""Ocean Crest"",
		""englishTooltip"": [
			""Most ocean enemies become friendly and provides waterbreathing""
		],
		""name"": ""Blason de l'Océan"",
		""tooltip"": [
			""La plupart des ennemis océaniques deviennent amicaux et permet de respirer sous l'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralBlaster"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Blaster"",
		""englishTooltip"": [
			""Converts musket balls into homing astral rounds""
		],
		""name"": ""Blaster Astral"",
		""tooltip"": [
			""Convertit les balles de mousquet en cartouches astrales à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OverloadedBlaster"",
		""type"": ""ITEM"",
		""englishName"": ""Overloaded Blaster"",
		""englishTooltip"": [
			""33% chance to not consume gel"",
			""Fires a large spread of bouncing slime""
		],
		""name"": ""Blaster Surchargé"",
		""tooltip"": [
			""33% de chances de ne pas consommer de gel"",
			""Tire une large étendue de gelée rebondissante""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FrostbiteBlaster"",
		""type"": ""ITEM"",
		""englishName"": ""Frostbite Blaster"",
		""englishTooltip"": [
			""Fires a spread of 6 bullets"",
			""Converts musket balls into icicles""
		],
		""name"": ""Blaster d'Engulure"",
		""tooltip"": [
			""Tire une étendue de 6 balles"",
			""Convertit les balles de mousquet en stalagtites de glace""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElementalBlaster"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Blaster"",
		""englishTooltip"": [
			""Does not consume ammo"",
			""Fires a storm of rainbow blasts""
		],
		""name"": ""Blaster des Élements"",
		""tooltip"": [
			""Ne consomme pas de munitions"",
			""Tire une tempête de déflagrations arc-en-ciel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""IonBlaster"",
		""type"": ""ITEM"",
		""englishName"": ""Ion Blaster"",
		""englishTooltip"": [
			""Fires ion blasts that speed up and then explode"",
			""Damage scales with how full your mana is"",
			""Using Astral Injection reduces the effectiveness of the mana boost""
		],
		""name"": ""Blaster à Ions"",
		""tooltip"": [
			""Tire des décharges d'ions qui accélèrent avant d'exploser"",
			""Plus votre mana est élevé, plus les dégâts sont élevés"",
			""Les stéroïdes astraux réduisent la puissance de cet effet""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Slurpfish"",
		""type"": ""ITEM"",
		""englishName"": ""Slurpfish"",
		""name"": ""Bleuvageon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EternalBlizzard"",
		""type"": ""ITEM"",
		""englishName"": ""Eternal Blizzard"",
		""englishTooltip"": [
			""Fires an additional icicle arrow that shatters on impact""
		],
		""name"": ""Blizzard Éternel"",
		""tooltip"": [
			""Tire une flèche de stalagtite additionnelle qui se brise à l'impact""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LivingGodSlayerFireBlock"",
		""type"": ""ITEM"",
		""englishName"": ""Living God Slayer Fire Block"",
		""name"": ""Bloc de Feu Déicide Vivant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LivingHolyFireBlock"",
		""type"": ""ITEM"",
		""englishName"": ""Living Holy Fire Block"",
		""name"": ""Bloc de Feu Sacré Vivant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LivingBrimstoneFireBlock"",
		""type"": ""ITEM"",
		""englishName"": ""Living Brimstone Fire Block"",
		""name"": ""Bloc de Feu de Soufre Vivant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodyMary"",
		""type"": ""ITEM"",
		""englishName"": ""Bloody Mary"",
		""englishTooltip"": [
			""Extra spicy and bloody!"",
			""Boosts damage by 15%, movement speed by 10%, melee speed by 15% and crit chance by 7% during a Blood Moon"",
			""Reduces life regen by 2 and defense by 4%""
		],
		""name"": ""Bloody Mary"",
		""tooltip"": [
			""Bien relevé et sanglant!"",
			""Augmente les dégâts, la vitesse de mouvement, la vitesse de mêlée de 15% et les chances de coup critique de 7% pendant une lune de sang"",
			""Réduit la régénération de vie de 2 et la défense de 4%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BobbitHook"",
		""type"": ""ITEM"",
		""englishName"": ""Bobbit Hook"",
		""englishTooltip"": [
			""DO NOT TRAD""
		],
		""name"": ""Bobbit Hook"",
		""tooltip"": [
			""Se rétracte extrêmement rapidement quand il s'attache à une tuile"",
			""Portée: 40"",
			""Vitesse de Lancer: 25"",
			""Vitesse de Rétractation: 28"",
			""Vitesse de Traction: 24""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Acidwood"",
		""type"": ""ITEM"",
		""englishName"": ""Acidwood"",
		""name"": ""Bois Acide"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BorealisBomber"",
		""type"": ""ITEM"",
		""englishName"": ""Borealis Bomber"",
		""englishTooltip"": [
			""Summons aureus bombers to fight for you"",
			""Aureus bombers explode on enemy impact"",
			""Does not consume minion slots""
		],
		""name"": ""Bombardeur Boréal"",
		""tooltip"": [
			""Invoque des bombardeurs d'Aureus pour combattre à vos côtés"",
			""Les bombardeurs explosent au contact des ennemis"",
			""N'utilise pas d'emplacement de sbires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BlissfulBombardier"",
		""type"": ""ITEM"",
		""englishName"": ""Blissful Bombardier"",
		""englishTooltip"": [
			""Fires flare rockets"",
			""Rockets will destroy tiles with tile-destroying ammo""
		],
		""name"": ""Bombardier Bienheureux"",
		""tooltip"": [
			""Tire des fusées éclairantes"",
			""Les fusées détruiront les tuiles avec les munitions adaptées""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SkyfinBombers"",
		""type"": ""ITEM"",
		""englishName"": ""Skyfin Bombers"",
		""englishTooltip"": [
			""Fishy bombers inbound!"",
			""Launches a skyfin nuke that homes in on enemies below it"",
			""Stealth strikes rapidly home in regardless of enemy position""
		],
		""name"": ""Bombardiers Nageciel"",
		""tooltip"": [
			""Bombardiers suspects en vue!"",
			""Lance une tête nucléaire nageciel qui pourchassent les ennemis sous elle"",
			""Les attaques furtives pourchassent l'ennemi peu importe sa position""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""InkBomb"",
		""type"": ""ITEM"",
		""englishName"": ""Ink Bomb"",
		""englishTooltip"": [
			""Throws several ink bombs when hit that explode in a confusing cloud of ink"",
			""Gain a lot of stealth when struck"",
			""This effect has a 20s cooldown before it can occur again""
		],
		""name"": ""Bombe d'Encre"",
		""tooltip"": [
			""Envoie plusieurs bombes d'encre quand vous êtes touché qui explosent dans un nuage d'encre qui inflige la confusion"",
			""Vous gagnez beaucoup de furtivité quand vous êtes touché"",
			""Cet effet à un temps de recharge de 20s""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SeafoamBomb"",
		""type"": ""ITEM"",
		""englishName"": ""Seafoam Bomb"",
		""englishTooltip"": [
			""Throws a bomb that explodes into a bubble which deals extra damage to enemies"",
			""Stealth strikes are faster and explode into 5 bubbles""
		],
		""name"": ""Bombe d'Écume"",
		""tooltip"": [
			""Jette une bombe qui explose en une bulle qui inflige des dégâts additionnels"",
			""Les attaques furtives sont plus rapides et explosent en 5 bulles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BallisticPoisonBomb"",
		""type"": ""ITEM"",
		""englishName"": ""Ballistic Poison Bomb"",
		""englishTooltip"": [
			""Throws a sticky bomb that explodes into spikes and poison clouds"",
			""Stealth strikes throw three at once""
		],
		""name"": ""Bombe de Poison Ballistique"",
		""tooltip"": [
			""Jette une bombe collante qui explosent en piques et en nuages de poison"",
			""Les attaques furtives en lancent trois à la fois""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SCalBoots"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitous Boots"",
		""name"": ""Bottes Calamiteuses"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimflameBoots"",
		""type"": ""ITEM"",
		""englishName"": ""Brimflame Boots"",
		""englishTooltip"": [
			""5% increased magic damage"",
			""5% increased movement speed""
		],
		""name"": ""Bottes Flamesoufre"",
		""tooltip"": [
			""+5% de dégâts magiques"",
			""+5% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""UmbraphileBoots"",
		""type"": ""ITEM"",
		""englishName"": ""Umbraphile Boots"",
		""englishTooltip"": [
			""9% increased rogue damage and 6% increased rogue crit"",
			""20% increased movement speed""
		],
		""name"": ""Bottes Umbraphiles"",
		""tooltip"": [
			""+9% de dégâts de voleur et +6% de chances de coup critique de voleur"",
			""+20% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""IronBoots"",
		""type"": ""ITEM"",
		""englishName"": ""Iron Boots"",
		""englishTooltip"": [
			""Allows you to fall faster while in liquids""
		],
		""name"": ""Bottes de Fer"",
		""tooltip"": [
			""Vous permet de chuter plus vite dans les liquides""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TitanHeartBoots"",
		""type"": ""ITEM"",
		""englishName"": ""Titan Heart Boots"",
		""englishTooltip"": [
			""4% increased rogue damage, 10% increased rogue velocity, and 5% increased rogue knockback""
		],
		""name"": ""Bottes du Coeur de Titan"",
		""tooltip"": [
			""+4% de dégâts de voleur, +10% vitesse des projectiles de voleur, et +5% de recul de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Butcher"",
		""type"": ""ITEM"",
		""englishName"": ""Butcher"",
		""englishTooltip"": [
			""Fires faster and more accurately the longer you hold the trigger""
		],
		""name"": ""Boucher"",
		""tooltip"": [
			""Tire plus vite et plus précisément au fur et à mesure que vous tirez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OrnateShield"",
		""type"": ""ITEM"",
		""englishName"": ""Ornate Shield"",
		""englishTooltip"": [
			""8% increased damage reduction and +20 health while wearing the Daedalus armor"",
			""Grants a frost dash""
		],
		""name"": ""Bouclier Orné"",
		""tooltip"": [
			""Augmente la réduction des dégâts et votre vie maximum quand vous portez l'armure de Dédale"",
			""Accorde une ruée gelée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ShieldoftheOcean"",
		""type"": ""ITEM"",
		""englishName"": ""Shield of the Ocean"",
		""englishTooltip"": [
			""Increased defense by 5 when submerged in liquid"",
			""Increases movement speed and life regen while wearing the Victide armor""
		],
		""name"": ""Bouclier de l'Océan"",
		""tooltip"": [
			""+5 défense lorsque vous êtes immergé"",
			""Augmente la vitesse de déplacement et la régénération de vie si vous portez l'armure victide""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ChaosCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Chaos Candle"",
		""englishTooltip"": [
			""The mere presence of this candle enrages surrounding enemies drastically""
		],
		""name"": ""Bougie Chaotique"",
		""tooltip"": [
			""La seule présence de cette bougie enrage drastiquement les ennemis alentour""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Candle"",
		""name"": ""Bougie Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TranquilityCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Tranquility Candle"",
		""englishTooltip"": [
			""The mere presence of this candle calms surrounding enemies drastically""
		],
		""name"": ""Bougie de Tranquillité"",
		""tooltip"": [
			""La seule présence de cette bougie calme drastiquement les ennemis environnants""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlantyMush"",
		""type"": ""ITEM"",
		""englishName"": ""Planty Mush"",
		""name"": ""Bouillie Végétale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WebBall"",
		""type"": ""ITEM"",
		""englishName"": ""Web Ball"",
		""englishTooltip"": [
			""Throws a web-covered ball that covers enemies in cobwebs to slow them down"",
			""Stealth strikes slow enemies down longer""
		],
		""name"": ""Boule de Toile"",
		""tooltip"": [
			""Lance une boule couverte de toile qui couvre les ennemis de toiles d'araignées pour les ralentir"",
			""Les attaques furtives ralentissent les ennemis plus longtemps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BallAndChain"",
		""type"": ""ITEM"",
		""englishName"": ""Ball and Chain"",
		""englishTooltip"": [
			""So heavy..."",
			""Favorite this item to disable any dashes granted by equipment.""
		],
		""name"": ""Boule en Chaîne"",
		""tooltip"": [
			""Tellement lourd..."",
			""Favoriser cet objet pour empêcher le joueur de foncer dans une direction.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BouncySpikyBall"",
		""type"": ""ITEM"",
		""englishName"": ""Bouncy Spiky Ball"",
		""englishTooltip"": [
			""Throws a very bouncy ball that ricochets off walls and enemies"",
			""Receives a small boost in damage and velocity after bouncing off an enemy"",
			""Stealth strikes provide a bigger boost after ricocheting""
		],
		""name"": ""Boule à Piques Rebondissante"",
		""tooltip"": [
			""Lance une boule rebondissante qui ricoche sur les murs et les ennemis"",
			""Gagne un petit bonus aux dégâts et en vitesse quand elle rebondit sur un ennemi"",
			""Les attaques furtives augmentent le bonus de ricochet""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StickySpikyBall"",
		""type"": ""ITEM"",
		""englishName"": ""Sticky Spiky Ball"",
		""englishTooltip"": [
			""Throws a spiky ball that sticks to everything"",
			""Stealth strikes throw seven at once and last a lot longer""
		],
		""name"": ""Boule à Pointes Collante"",
		""tooltip"": [
			""Lance une boule à pointes qui se collent à tout"",
			""Les attaques furtives en lancent sept d'un coup et durent plus longtemps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HeavenlyGale"",
		""type"": ""ITEM"",
		""englishName"": ""Heavenly Gale"",
		""englishTooltip"": [
			""DO NOT TRAD""
		],
		""name"": ""Bourrasque Céleste"",
		""tooltip"": [
			""Convertit les flèches en bois en un barrage de 5 exo flèches aléatoires"",
			""Les exo flèches vertes exposent en une tornade"",
			""Les exo flèches bleues provoquent le tir d'un second groupe de flèches quand elles touchent"",
			""Les exo flèches oranges provoquent des explosions"",
			""Les exo flèches cyan ignorent la période d'invincibilité des ennemis"",
			""Augmente les dégâts des flèches qui ne sont pas en bois de 25%"",
			""66% de chances de ne pas consommer de munitions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DeepWounder"",
		""type"": ""ITEM"",
		""englishName"": ""Deep Wounder"",
		""englishTooltip"": [
			""Throws an abyssal hatchet that inflicts Armor Crunch and Marked for Death to the enemies it hits"",
			""Stealth strikes cause the hatchet to be thrown faster and trail water, inflicting Crush Depth in addition to the other debuffs""
		],
		""name"": ""Bourreau des Profondeurs"",
		""tooltip"": [
			""Lance une hachette abyssale qui inflige Écrasement d'Armure et Désigné pour Mourir aux ennemis touchés"",
			""Les attaques furtives rendent la hachette plus rapide et laisse dans son sillage de l'eau, qui inflige Écrasement des Profondeurs en plus des autres altérations""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LaboratoryContainmentBoxItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Containment Box"",
		""name"": ""Boîte de Confinement de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TitanArm"",
		""type"": ""ITEM"",
		""englishName"": ""Titan Arm"",
		""englishTooltip"": [
			""Slap Hand but better"",
			""Sends enemies straight to the stars at the speed of light""
		],
		""name"": ""Bras de Titan"",
		""tooltip"": [
			""La main à claques mais en mieux"",
			""Envoie les ennemis directement dans les étoiles à la vitesse de la lumière""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AldebaranAlewife"",
		""type"": ""ITEM"",
		""englishName"": ""Aldebaran Alewife"",
		""englishTooltip"": [
			""A star-struck entity in the form of a fish""
		],
		""name"": ""Brasseuse Aldebaran"",
		""tooltip"": [
			""Une entité stellaire corrompue en forme de poisson""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StratusBricks"",
		""type"": ""ITEM"",
		""englishName"": ""Stratus Brick"",
		""name"": ""Brique Stratus"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ThrowingBrick"",
		""type"": ""ITEM"",
		""englishName"": ""Throwing Brick"",
		""englishTooltip"": [
			""Prove its resistance by throwing it upwards and catching it with your face"",
			""Throws a brick that shatters if stealth is full.""
		],
		""name"": ""Brique de Lancer"",
		""tooltip"": [
			""Prouver sa solidité en la lancant vers le haut puis en l'attrapant avec la tête"",
			""Jette une brique qui se brise si votre furtivité est pleine.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Icebreaker"",
		""type"": ""ITEM"",
		""englishName"": ""Icebreaker"",
		""englishTooltip"": [
			""Stealth strikes spawn a cosmic explosion and freeze nearby enemies on enemy hits""
		],
		""name"": ""Brise-Glace"",
		""tooltip"": [
			""Les attaques furtives créent une explosion cosmique et gèlent les ennemis quand elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Bonebreaker"",
		""type"": ""ITEM"",
		""englishName"": ""Bonebreaker"",
		""englishTooltip"": [
			""Fires javelins that stick to enemies before bursting into shrapnel""
		],
		""name"": ""Brise-Os"",
		""tooltip"": [
			""Tire des javelots qui se plantent dans les ennemis avant d'exploser en éclats""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PrismaticBreaker"",
		""type"": ""ITEM"",
		""englishName"": ""Prismatic Breaker"",
		""englishTooltip"": [
			""Seems to belong to a certain magical girl. Radiates with intense cosmic energy."",
			""Fire to charge for a powerful rainbow laser"",
			""Right click to instead swing the sword and fire rainbow colored waves"",
			""The sword is boosted by both melee and ranged damage""
		],
		""name"": ""Briseur Prismatique"",
		""tooltip"": [
			""Semble appartenir à une certaine magical girl. Irradie d'une intense énergie cosmique."",
			""Clic gauche pour charger un puissant rayon arc-en-ciel"",
			""Clic droit pour frapper à l'épée et tirer des vagues arc-en-ciel"",
			""Les dégâts de l'épée sont augmentés à la fois par les bonus de mêlée et de distance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TotalityBreakers"",
		""type"": ""ITEM"",
		""englishName"": ""Totality Breakers"",
		""englishTooltip"": [
			""Explodes into highly flammable black tar"",
			""Tar oils enemies and sets them alight"",
			""Stealth strikes leak tar as they fly""
		],
		""name"": ""Briseurs de Totalité"",
		""tooltip"": [
			""Exploses dans un goudron noir hautement inflammable"",
			""Le goudron huile les ennemis et les enflamment"",
			""Les attaques furtives déversent du goudron sur leur trajet""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TrapperBulb"",
		""type"": ""ITEM"",
		""englishName"": ""Trapper Bulb"",
		""name"": ""Bulbe de Trappeur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Staff"",
		""englishTooltip"": [
			""Summons a large crystal from the sky that has a large area of effect on impact.""
		],
		""name"": ""Bâton Astral"",
		""tooltip"": [
			""Invoque un grand cristal depuis le ciel qui à une grande zone d'effet à l'impact.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CausticStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Caustic Staff"",
		""englishTooltip"": [
			""Summons a mini dragon to fight for you"",
			""The dragon can inflict several debilitating debuffs if you hold a summon weapon or tool""
		],
		""name"": ""Bâton Caustique"",
		""tooltip"": [
			""Invoque un mini dragon pour combattre à vos côtés"",
			""Le dragon peut infliger plusieurs altérations d'état débilitantes si vous tenez une arme ou un outil d'invocation""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CryogenicStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Cryogenic Staff"",
		""englishTooltip"": [
			""Summons an animated ice construct to protect you"",
			""Fire rate and range increase the longer it targets an enemy""
		],
		""name"": ""Bâton Cryogénique"",
		""tooltip"": [
			""Invoque un construct de glace animé pour vous protéger"",
			""Portée et vitesse de tir augmentée au fur et à mesure qu'il vise un ennemi""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Staff"",
		""englishTooltip"": [
			""Casts a wulfrum bolt""
		],
		""name"": ""Bâton Wulfrum"",
		""tooltip"": [
			""Convoque une décharge Wulfrum""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GastricBelcherStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Gastric Belcher Staff"",
		""englishTooltip"": [
			""Summons aquatic aberrations to protect you"",
			""Aberrations fire vomit at nearby enemies with every third attack firing bubbles""
		],
		""name"": ""Bâton d'Aberration Gastrique"",
		""tooltip"": [
			""Invoque des aberrations aquatiques pour vous protéger"",
			""Les aberrations vomissent sur les ennemis proches et tirent des bulles toutes les 3 attaques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AquamarineStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Aquamarine Staff"",
		""englishTooltip"": [
			""Shoots two blue bolts""
		],
		""name"": ""Bâton d'Aquamarine"",
		""tooltip"": [
			""Tire deux éclairs magiques bleus""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralachneaStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Astralachnea Staff"",
		""englishTooltip"": [
			""Fires a spread of homing astral spider fangs""
		],
		""name"": ""Bâton d'Araignée Astrale"",
		""tooltip"": [
			""Tire une étendue de chélicère astrales à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AsteroidStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Asteroid Staff"",
		""englishTooltip"": [
			""Summons asteroids from the sky""
		],
		""name"": ""Bâton d'Astéroïde"",
		""tooltip"": [
			""Invoque des astéroïdes depuis le ciel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EndoHydraStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Endo Hydra Staff"",
		""englishTooltip"": [
			""Summons a frigid entity with a head"",
			""If the entity already exists, using this item again will cause it to gain more heads""
		],
		""name"": ""Bâton d'Endohydre"",
		""tooltip"": [
			""Invoque une entité frigide avec une tête"",
			""Si l'entité existe déjà, utiliser cet objet à nouveau lui fera gagner plus de têtes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GodspawnHelixStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Godspawn Helix Staff"",
		""englishTooltip"": [
			""Summons astral probes to protect you""
		],
		""name"": ""Bâton d'Hélice Divine"",
		""tooltip"": [
			""Invoque des sondes astrales pour vous protéger""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ShadowboltStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Shadowbolt Staff"",
		""englishTooltip"": [
			""The more tiles and enemies the beam bounces off of or travels through the more damage the beam does""
		],
		""name"": ""Bâton d'Ombreclair"",
		""tooltip"": [
			""Au plus le rayon rebondit et traverse les ennemis, au plus il inflige de dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SquirrelSquireStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Squirrel Squire Staff"",
		""englishTooltip"": [
			""Summons a squirrel squire to fight for you""
		],
		""name"": ""Bâton d'Écureuil Écuyer"",
		""tooltip"": [
			""Invoque un écureuil écuyer pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EnergyStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Energy Staff"",
		""englishTooltip"": [
			""Summons a profaned energy turret to fight for you""
		],
		""name"": ""Bâton d'Énergie"",
		""tooltip"": [
			""Invoque une tourelle d'énergie profanée pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CrimslimeStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Crimslime Staff"",
		""englishTooltip"": [
			""Summons a crim slime to fight for you""
		],
		""name"": ""Bâton de Carmigelée"",
		""tooltip"": [
			""Invoque une carmigelée pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HellwingStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Hellwing Staff"",
		""englishTooltip"": [
			""Casts flaming bats""
		],
		""name"": ""Bâton de Chauve-souris de l'Enfer"",
		""tooltip"": [
			""Invoque des chauves-souris enflammées""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CorroslimeStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Corroslime Staff"",
		""englishTooltip"": [
			""Summons a corro slime to fight for you""
		],
		""name"": ""Bâton de Corrogelée"",
		""tooltip"": [
			""Invoque une gelée corrosive pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ShellfishStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Shellfish Staff"",
		""englishTooltip"": [
			""Summons a shellfish to fight for you"",
			""Takes up 2 minion slots""
		],
		""name"": ""Bâton de Crustacé"",
		""tooltip"": [
			""Invoque un crustacé pour combattre à vos côtés"",
			""Occupe deux emplacements de sbires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Fabstaff"",
		""type"": ""ITEM"",
		""englishName"": ""Fabstaff"",
		""englishTooltip"": [
			""Casts a bouncing beam that splits when enemies are near it""
		],
		""name"": ""Bâton de Fab"",
		""tooltip"": [
			""Convoque un rayon rebondissant qui se divise quand les ennemis en sont proches""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FrostBlossomStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Frost Blossom Staff"",
		""englishTooltip"": [
			""Summons a frozen flower over your head"",
			""There can only be one flower""
		],
		""name"": ""Bâton de Floraison Glaciale"",
		""tooltip"": [
			""Invoque une fleur glacée au-dessus de votre tête"",
			""Il ne peut y avoir qu'une fleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CinderBlossomStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Cinder Blossom Staff"",
		""englishTooltip"": [
			""Summons a really hot flower over your head"",
			""There can only be one flower""
		],
		""name"": ""Bâton de Floraison de Cendre"",
		""tooltip"": [
			""Invoque une fleur très chaude au-dessus de votre tête"",
			""Il ne peut y avoir qu'une fleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StormjawStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Stormjaw Staff"",
		""englishTooltip"": [
			""Summons a baby stormlion to fight for you""
		],
		""name"": ""Bâton de Fourmi-Tonnerre"",
		""tooltip"": [
			""Invoque un bébé fourmi-tonnerre pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AbandonedSlimeStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Abandoned Slime Staff"",
		""englishTooltip"": [
			""Cast down from the heavens in disgust, this relic sings a song of quiet tragedy..."",
			""Consumes all of the remaining minion slots on use"",
			""Must be used from the hotbar"",
			""Increased power and size based on the number of minion slots used"",
			""Holding this weapon grants 10% increased jump speed""
		],
		""name"": ""Bâton de Gelée Abandonné"",
		""tooltip"": [
			""Exilé des cieux par dégoût; cette relique entonne le chant d'une tragédie silencieuse..."",
			""Occupe tous les emplacements de sbires restants à l'utilisation"",
			""Doit-être utilisé depuis la barre de raccourci"",
			""Puissance et taille augmentée en fonction du nombre d'emplacements occupés"",
			""Tenir cette arme augmente votre vitesse de saut de 10%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DeathhailStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Deathhail Staff"",
		""englishTooltip"": [
			""Rain death upon your foes!"",
			""Casts a storm of nebula lasers from the sky""
		],
		""name"": ""Bâton de Grêlemort"",
		""tooltip"": [
			""Faites pleuvoir la mort sur vos ennemis!"",
			""Convoque une tempête de lasers nébuleux depuis le ciel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DeepseaStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Deepsea Staff"",
		""englishTooltip"": [
			""Summons an aquatic star to fight for you""
		],
		""name"": ""Bâton de Mer Profonde"",
		""tooltip"": [
			""Invoque une étoile aquatique pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DreadmineStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Dreadmine Staff"",
		""englishTooltip"": [
			""Summons a dreadmine turret to fight for you""
		],
		""name"": ""Bâton de Mine Terrifiante"",
		""tooltip"": [
			""Invoque une tourelle de mine terrifiante pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HarvestStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Harvest Staff"",
		""englishTooltip"": [
			""Casts flaming pumpkins""
		],
		""name"": ""Bâton de Moisson"",
		""tooltip"": [
			""Invoque des citrouilles enflammées""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StaffOfNecrosteocytes"",
		""type"": ""ITEM"",
		""englishName"": ""Staff of Necrosteocytes"",
		""englishTooltip"": [
			""Summons small skeletons to fight for you"",
			""The skeletons leave behind bone cells as they move""
		],
		""name"": ""Bâton de Nécrostéocytes"",
		""tooltip"": [
			""Invoque des petits squelettes pour combattre à vos côtés"",
			""Les squelettes répandent des cellules osseuses en se déplaçant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Plague Staff"",
		""englishTooltip"": [
			""Fires a spread of plague fangs""
		],
		""name"": ""Bâton de Peste"",
		""tooltip"": [
			""Tire une étendue de crocs de peste""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlantationStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Plantation Staff"",
		""englishTooltip"": [
			""Summons a miniature plantera to protect you"",
			""Fires seeds, spiky balls, and spore clouds from afar to poison targets"",
			""Enrages when you get under 75% health and begins ramming enemies"",
			""Occupies 3 minion slots and there can only be one""
		],
		""name"": ""Bâton de Plantation"",
		""tooltip"": [
			""Invoque une Plantera miniature pour vous protéger"",
			""Tire des graines, des boules pointues et des nuages de spores de loin pour empoisonner les cibles"",
			""Enrage quand vous tombez en dessous de 75% de votre vie et commence à charger les ennemis"",
			""Occupe 3 emplacements de sbires et il ne peut n'y en avoir qu'une seule""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ShaderainStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Shaderain Staff"",
		""englishTooltip"": [
			""Fires a shade storm cloud that inflicts shadowflame""
		],
		""name"": ""Bâton de Pluie d'Ombre"",
		""tooltip"": [
			""Tire un nuage de tempête d'ombre qui inflige des brûlures d'ombres""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DazzlingStabberStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Dazzling Stabber Staff"",
		""englishTooltip"": [
			""Summons a holy blade to fight for you""
		],
		""name"": ""Bâton de Poignard Éblouissant"",
		""tooltip"": [
			""Invoque une lame sacrée pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SpikecragStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Spikecrag Staff"",
		""englishTooltip"": [
			""Summons a spikecrag to protect you""
		],
		""name"": ""Bâton de Pointe Rocheuse"",
		""tooltip"": [
			""Invoque une pointe rocheuse pour vous protéger""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SandSharknadoStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Sand Sharknado Staff"",
		""englishTooltip"": [
			""Summons a sandnado to fight for you""
		],
		""name"": ""Bâton de Requinade des Sables"",
		""tooltip"": [
			""Invoque une sablenade pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""IcicleStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Icicle Staff"",
		""englishTooltip"": [
			""Casts icicles from the sky""
		],
		""name"": ""Bâton de Stalactite"",
		""tooltip"": [
			""Convoque des stalactites depuis le ciel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SnowstormStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Snowstorm Staff"",
		""englishTooltip"": [
			""Fires a snowflake that follows the mouse cursor""
		],
		""name"": ""Bâton de Tempête de Neige"",
		""tooltip"": [
			""Tire une flocon de neige qui suit le curseur de la souris""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BelladonnaSpiritStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Belladonna Spirit Staff"",
		""englishTooltip"": [
			""Summons a cute forest spirit that scatters toxic petals""
		],
		""name"": ""Bâton de l'Esprit Beladonne"",
		""tooltip"": [
			""Invoque un esprit de la forêt mignon qui répand des pétales toxiques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SunSpiritStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Sun Spirit Staff"",
		""englishTooltip"": [
			""Summons a solar spirit to protect you"",
			""There can only be one spirit""
		],
		""name"": ""Bâton de l'Esprit Solaire"",
		""tooltip"": [
			""Invoque un esprit solaire pour vous protéger"",
			""Il ne peut y avoir qu'un esprit""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimroseStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Brimrose Staff"",
		""englishTooltip"": [
			""Fires a spread of brimstone beams""
		],
		""name"": ""Bâton de soufrerose"",
		""tooltip"": [
			""Tire une étendue de rayons de soufre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TundraFlameBlossomsStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Tundra Flame Blossoms Staff"",
		""englishTooltip"": [
			""Summons three unusual flowers over your head"",
			""Each flower consumes one minion slot""
		],
		""name"": ""Bâton des Floraisons de la Flamme de la Toundra"",
		""tooltip"": [
			""Invoque 3 fleurs inhabituelles au-dessus de votre tête"",
			""Chaque fleur consomme un emplacement de sbire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodClotStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Clot Staff"",
		""englishTooltip"": [
			""Summons a blood clot to fight for you""
		],
		""name"": ""Bâton du Caillot Sanguin"",
		""tooltip"": [
			""Invoque un Caillot sanguin pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CorvidHarbringerStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Corvid Harbinger Staff"",
		""englishTooltip"": [
			""Nevermore."",
			""Summons a powerful raven which teleports and dashes""
		],
		""name"": ""Bâton du Colporteur Corvidé"",
		""tooltip"": [
			""Plus jamais."",
			""Invoque un puissant corbeau qui se téléporte et se rue""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CausticCroakerStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Caustic Croaker Staff"",
		""englishTooltip"": [
			""Summons a toad that explodes if enemies are nearby""
		],
		""name"": ""Bâton du Croasseur Caustique"",
		""tooltip"": [
			""Invoque un crapaud qui explose si les ennemis s'en approchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SunGodStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Sun God Staff"",
		""englishTooltip"": [
			""Summons a solar god spirit to protect you"",
			""There can only be one spirit""
		],
		""name"": ""Bâton du Dieu Soleil"",
		""tooltip"": [
			""Invoque un esprit du dieu soleil pour vous protéger"",
			""Il ne peut y avoir qu'un esprit""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HerringStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Herring Staff"",
		""englishTooltip"": [
			""Summons a herring to fight for you"",
			""Each herring takes only half of a minion slot""
		],
		""name"": ""Bâton du Harang"",
		""tooltip"": [
			""Invoque un harang pour combattre à vos côtés"",
			""Chaque harang n'occupe que la moitié d'un emplacement de sbire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StaffoftheMechworm"",
		""type"": ""ITEM"",
		""englishName"": ""Staff of the Mechworm"",
		""englishTooltip"": [
			""Summons an aerial mechworm to fight for you""
		],
		""name"": ""Bâton du Ver Mécanique"",
		""tooltip"": [
			""Invoque un ver mécanique aérien pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BabyGhostBellItem"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Ghost Bell"",
		""name"": ""Bébé Cloche Fantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BabyGhostBellJar"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Ghost Bell Jar"",
		""name"": ""Bébé Cloche Fantôme en Pot"",
		""state"": ""Traduit""
	},
	{
		""id"": ""StatisBlessing"",
		""type"": ""ITEM"",
		""englishName"": ""Statis' Blessing"",
		""englishTooltip"": [
			""Increased max minions by 2 and 10% increased minion damage"",
			""Increased minion knockback"",
			""Minions inflict holy flames on hit""
		],
		""name"": ""Bénédiction de Statis"",
		""tooltip"": [
			""+2 sbires max et +10% dégâts d'invocation"",
			""Recul des sbires augmenté"",
			""Les sbires infligent la brûlure sacrée lorsqu'ils touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SHPC"",
		""type"": ""ITEM"",
		""englishName"": ""SHPC"",
		""englishTooltip"": [
			""Fires plasma orbs that linger and emit massive explosions"",
			""Right click to fire powerful energy beams""
		],
		""name"": ""CPUC"",
		""tooltip"": [
			""Tire des orbes de plasma qui perdurent et émettent des explosions massives"",
			""Clic droit pour tirer de puissants rayons d'énergie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LuxorsGift"",
		""type"": ""ITEM"",
		""englishName"": ""Luxor's Gift"",
		""englishTooltip"": [
			""Weapons fire unique projectiles based on the damage type they have"",
			""Some weapons are unable to receive this bonus""
		],
		""name"": ""Cadeau de Luxor"",
		""tooltip"": [
			""Les armes tirent des projectiles qui dépendent du type de dégâts qu'elle inflige"",
			""Ne fonctionne pas avec toutes les armes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""YharimsGift"",
		""type"": ""ITEM"",
		""englishName"": ""Yharim's Gift"",
		""englishTooltip"": [
			""The power of a god pulses from within this artifact"",
			""Flaming meteors rain down after getting hit"",
			""Exploding dragon dust is left behind as you move"",
			""Damage and movement speed increased by 15%""
		],
		""name"": ""Cadeau de Yharim"",
		""tooltip"": [
			""Le pouvoir d'un dieu parcours cet artéfact"",
			""Des météores enflammés pleuvent durant vos périodes d'invulnérabilité"",
			""Vous laissez de la poussière draconique explosive dans votre sillage"",
			""+15% de vitesse de déplacement et de dégâts infligés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PiggyCage"",
		""type"": ""ITEM"",
		""englishName"": ""Piggy Cage"",
		""name"": ""Cage à Piggy"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimflameScowl"",
		""type"": ""ITEM"",
		""englishName"": ""Brimflame Cowl"",
		""englishTooltip"": [
			""5% increased magic damage and critical strike chance"",
			""Increases maximum mana by 70 and reduces mana usage by 10%"",
			""Immunity to On Fire!, Brimstone Flames and Frostburn""
		],
		""name"": ""Cagoule Flammesoufre"",
		""tooltip"": [
			""+5% de dégâts et de chances de coup critique magique"",
			""Augmente le mana maximum de 70 et réduit les coûts en mana de 10%"",
			""Immunité à la brûlure, les flammes de soufres et le brûlegivre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Rock"",
		""type"": ""ITEM"",
		""englishName"": ""Rock"",
		""englishTooltip"": [
			""The first object Xeroc ever created""
		],
		""name"": ""Caillou"",
		""tooltip"": [
			""Le premier objet jamais crée par Xeroc!""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ReinforcedCrateItem"",
		""type"": ""ITEM"",
		""englishName"": ""Reinforced Crate"",
		""name"": ""Caisse Renforcée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeCalamitas"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitas"",
		""englishTooltip"": [
			""The witch unrivaled. Perhaps the only one amongst my cohorts to have ever given me cause for doubt."",
			""Now that you have defeated her your destiny is clear."",
			""Come now, face me.""
		],
		""name"": ""Calamitas"",
		""tooltip"": [
			""La sorcière sans pareille. Peut-être la seule de ma cohorte à m'avoir jamais fait douter."",
			""Maintenant que tu l'as vaincue, ton destin est clair."",
			""Viens, et affronte moi.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Calamity"",
		""type"": ""ITEM"",
		""englishName"": ""Calamity"",
		""englishTooltip"": [
			""Lights your cursor ablaze with the Witch's flames, engulfing it in a blazing aura"",
			""Enemies touching the blaze take immense damage and are inflicted with Vulnerability Hex"",
			""Equip in a vanity slot to change the cursor without dealing damage"",
			""These changes work in conjunction with the Rainbow Cursor""
		],
		""name"": ""Calamité"",
		""tooltip"": [
			""Enflamme votre curseur avec les flammes de la sorcière, invoquant une sigle brûlant autour"",
			""Les ennemis qui touchent le sigle prennent d'immenses dégâts et subissent la malédiction de vulnérabilité"",
			""Equipez dans une emplacement de vanité change la couleur du curseur sans infliger de dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateSofa"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Sofa"",
		""name"": ""Canapé Pestiféré"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateCandelabra"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Candelabra"",
		""name"": ""Candélabre Pestiféré"",
		""state"": ""Traduit""
	},
	{
		""id"": ""NavyFishingRod"",
		""type"": ""ITEM"",
		""englishName"": ""Navy Fishing Rod"",
		""englishTooltip"": [
			""While held, slowly electrifies nearby enemies."",
			""The sea is a city."",
			""Just below are highways, boulevards, streets and roundabouts bustling with submarine traffic.""
		],
		""name"": ""Canne Marine"",
		""tooltip"": [
			""Electrise lentement les ennemis proches quand elle est tenue."",
			""La mer est une ville."",
			""Il y a des autoroutes, des boulevards, des villes et des ronds-points grouillants de traffic sous-marin juste sous la surface.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SlickCane"",
		""type"": ""ITEM"",
		""englishName"": ""Slick Cane"",
		""englishTooltip"": [
			""Swipes a cane that steals money from enemies."",
			""Stealth strikes gives a 1 in 15 chance for enemies to drop 1-3 gold coins when hit"",
			""'Economy at its finest'""
		],
		""name"": ""Canne Rusée"",
		""tooltip"": [
			""Frappe avec une canne qui vole de l'argent aux ennemis."",
			""Les attaques furtives donnent 1 chance sur 15 de faire lâcher aux ennemis entre 1 et 3 pièces d'or quand vous les touchez"",
			""'L'Économie à son paroxysme'""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VerstaltiteFishingRod"",
		""type"": ""ITEM"",
		""englishName"": ""Verstaltite Fishing Rod"",
		""englishTooltip"": [
			""Increased fishing power when in the tundra"",
			""The ancient alloy's prismatic qualities are perfect for attracting fish""
		],
		""name"": ""Canne Verstaltile"",
		""tooltip"": [
			""Puissance de pêche augmentée dans la toundra"",
			""Les qualités de l'ancien alliage prismatique sont parfaites pour attirer les poissons.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SlurperPole"",
		""type"": ""ITEM"",
		""englishName"": ""Slurper Pole"",
		""englishTooltip"": [
			""Can fish in lava."",
			""It is the burning lava of the soul that has a furnace within--a very volcano of grief and sorrow.""
		],
		""name"": ""Canne d'Aspireur"",
		""tooltip"": [
			""Peut pêcher dans la lave."",
			""C'est la lave brûlante d'une âme abritant un fourneau en son sein--un véritable volcan de chagrin et de tristesse.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HeronRod"",
		""type"": ""ITEM"",
		""englishName"": ""Heron Rod"",
		""englishTooltip"": [
			""Increased fishing power in space."",
			""A silent head and beak lanced down and plucked it out by the head,"",
			""and the beak swallowed the little fish while its tail waved frantically.""
		],
		""name"": ""Canne de Héron"",
		""tooltip"": [
			""Puissance de pêche augmentée dans l'espace."",
			""Une tête et un bec s'élancèrent sans bruit et saisirent le poisson"",
			""et le bec l'avala par la tête, tandis que la queue s'agitait, éperdue...""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EarlyBloomRod"",
		""type"": ""ITEM"",
		""englishName"": ""Early Bloom Rod"",
		""englishTooltip"": [
			""Fires six lines at once. Line never snaps."",
			""The early bird catches the fish.""
		],
		""name"": ""Canne de l'Éclosion Précose"",
		""tooltip"": [
			""Lance six lignes à la fois. Les lignes ne casse jamais."",
			""Le poisson appartient à ceux qui se lèvent tôt.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumRod"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Fishing Pole"",
		""englishTooltip"": [
			""This barely works, but it's better than nothing.""
		],
		""name"": ""Canne à Pêche Wulfrum"",
		""tooltip"": [
			""Ca tient à peine, mais c'est mieux que rien.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ClaretCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Claret Cannon"",
		""englishTooltip"": [
			""Fires strings of 3 bullets"",
			""Converts musket balls into bloody tears that drain enemy health""
		],
		""name"": ""Canon Bordeaux"",
		""tooltip"": [
			""Tire une rafale de 3 balles"",
			""Convertit les balles de mousquet en larmes sanglantes qui drainent la santé ennemie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HalibutCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Halibut Cannon"",
		""englishTooltip"": [
			""Yes, it's still overpowered""
		],
		""name"": ""Canon Halibut"",
		""tooltip"": [
			""Oui, il est toujours trop puissant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MagnaCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Magna Cannon"",
		""englishTooltip"": [
			""Fires a concentrated blast of energy""
		],
		""name"": ""Canon Magna"",
		""tooltip"": [
			""Tire une décharge concentrée d'énergie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StellarCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Stellar Cannon"",
		""englishTooltip"": [
			""Launches an explosive astral crystal""
		],
		""name"": ""Canon Stellaire"",
		""tooltip"": [
			""Lance un cristal astral explosif""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TeslaCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Tesla Cannon"",
		""englishTooltip"": [
			""Lightweight energy cannon that blasts an intense electrical beam that explodes"",
			""Beams can arc to nearby targets""
		],
		""name"": ""Canon Tesla"",
		""tooltip"": [
			""Un canon d'énergie léger qui tire un rayon électrique explosif intense"",
			""Les rayons peuvent s'infléchir vers les cibles proches""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SulphuricAcidCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphuric Acid Cannon"",
		""englishTooltip"": [
			""Fires an acidic shot that sticks to enemies and dissolves them""
		],
		""name"": ""Canon d'Acide Sulfurique"",
		""tooltip"": [
			""Tire une bulle d'acide qui se fixe sur les ennemis et qui les dissout""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CoralCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Coral Cannon"",
		""englishTooltip"": [
			""Has a chance to shoot a big coral that stuns enemies""
		],
		""name"": ""Canon de Corail"",
		""tooltip"": [
			""Chances de tirer un gros corail qui stoppe les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MagnomalyCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Magnomaly Cannon"",
		""englishTooltip"": [
			""Launches a powerful exo rocket to nuke anything and everything"",
			""Rockets are surrounded by an invisible damaging aura and split into damaging beams on hit"",
			""66% chance to not consume rockets""
		],
		""name"": ""Canon de Magnomalie"",
		""tooltip"": [
			""Lance une puissante exo roquette pour tout atomiser"",
			""Les roquettes sont entourées d'une aura invisible que endommage les ennemis et se divise en rayon quand elle touche"",
			""66% de chances de ne pas consommer de fusée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FlurrystormCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Flurrystorm Cannon"",
		""englishTooltip"": [
			""Fires a chain of snowballs that become faster over time"",
			""Has a chance to also fire an ice chunk that shatters into shards"",
			""50% chance to not consume snowballs""
		],
		""name"": ""Canon de Rafale-Tempête"",
		""tooltip"": [
			""Tire des boules de neige en rafale de plus en plus vite"",
			""A une chance de tirer un morceau de glace qui se brise en éclats"",
			""50% de chances de ne pas consommer de boules de neige""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SpectralstormCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Spectralstorm Cannon"",
		""englishTooltip"": [
			""70% chance to not consume flares"",
			""Fires a storm of lost souls and flares""
		],
		""name"": ""Canon de Spectre-Tempête"",
		""tooltip"": [
			""70% de chances de ne pas consommer de fusées"",
			""Tire une tempête d'âmes perdues et de fusées""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FirestormCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Firestorm Cannon"",
		""englishTooltip"": [
			""70% chance to not consume flares"",
			""Right click to fire a spread of flares""
		],
		""name"": ""Canon de Tempête de Feu"",
		""tooltip"": [
			""70% de chances de ne pas consommer de fusée"",
			""Clic droit pour tirer une volée de fusées""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DodusHandcannon"",
		""type"": ""ITEM"",
		""englishName"": ""Dodu's Handcannon"",
		""englishTooltip"": [
			""The power of the nut rests in your hands"",
			""Fires high explosive peanut shells, literally""
		],
		""name"": ""Canon à Main de Dodu"",
		""tooltip"": [
			""Le pouvoir de la noix repose dans tes mains"",
			""Tire des coquilles de noix hautement explosives, pour de vrai""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ChickenCannon"",
		""type"": ""ITEM"",
		""englishName"": ""Chicken Cannon"",
		""englishTooltip"": [
			""Fires chicken flares which create enormous incendiary explosions"",
			""Right click to detonate all airborne rockets""
		],
		""name"": ""Canon à Poulets"",
		""tooltip"": [
			""Tire des roquettes-poulets qui créent d'énormes explosions incendiaires"",
			""Clic droit pour faire exploser toutes les roquettes en l'air""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TitaniumRailgun"",
		""type"": ""ITEM"",
		""englishName"": ""Titanium Railgun"",
		""englishTooltip"": [
			""Hold down to charge up a decimating titanium blast"",
			""Longer hold time increases power, leading to more damage, size, and knockback"",
			""Power is capped when the cannon's sights have fully converged""
		],
		""name"": ""Canon à Rail en Titane"",
		""tooltip"": [
			""Tire un laser""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HivePod"",
		""type"": ""ITEM"",
		""englishName"": ""Hive Pod"",
		""englishTooltip"": [
			""Summons an astral hive to protect you""
		],
		""name"": ""Capsule de Ruche"",
		""tooltip"": [
			""Invoque une ruche astrale pour vous protéger""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AerospecHood"",
		""type"": ""ITEM"",
		""englishName"": ""Aerospec Hood"",
		""englishTooltip"": [
			""8% increased ranged damage""
		],
		""name"": ""Capuche Aérospec"",
		""tooltip"": [
			""+8% de dégâts à distance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SCalMask"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitous Hood"",
		""name"": ""Capuche Calamiteuse"",
		""state"": ""Traduit""
	},
	{
		""id"": ""UmbraphileHood"",
		""type"": ""ITEM"",
		""englishName"": ""Umbraphile Hood"",
		""englishTooltip"": [
			""8% increased rogue damage and 10% increased rogue velocity""
		],
		""name"": ""Capuche Umbraphile"",
		""tooltip"": [
			""+8% de dégats de voleur et +10% de vitesse des projectiles de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ArmoredShell"",
		""type"": ""ITEM"",
		""englishName"": ""Armored Shell"",
		""name"": ""Carapace Blindée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FungalCarapace"",
		""type"": ""ITEM"",
		""englishName"": ""Fungal Carapace"",
		""englishTooltip"": [
			""You emit a cloud of mushroom spores when you are hit""
		],
		""name"": ""Carapace Fongique"",
		""tooltip"": [
			""Vous émettez un nuage de spores fongiques quand vous êtes touché""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GiantShell"",
		""type"": ""ITEM"",
		""englishName"": ""Giant Shell"",
		""englishTooltip"": [
			""15% reduced movement speed"",
			""Taking a hit will make you move very fast for a short time""
		],
		""name"": ""Carapace Géante"",
		""tooltip"": [
			""Vitesse de mouvement réduite de 15% et +5% de réduction de dégâts"",
			""Subir des dégâts vous fera vous déplacer très vite durant un court moment""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GeyserShell"",
		""type"": ""ITEM"",
		""englishName"": ""Geyser Shell"",
		""englishTooltip"": [
			""Summons a little flak hermit""
		],
		""name"": ""Carapace de Geyser"",
		""tooltip"": [
			""Invoque un petit ermite flak""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CrawCarapace"",
		""type"": ""ITEM"",
		""englishName"": ""Craw Carapace"",
		""englishTooltip"": [
			""Enemies take damage when they touch you""
		],
		""name"": ""Carapace de Jabot"",
		""tooltip"": [
			""5% de réduction de dégâts"",
			""Les ennemis subissent des dégâts quand ils vous touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GiantTortoiseShell"",
		""type"": ""ITEM"",
		""englishName"": ""Giant Tortoise Shell"",
		""englishTooltip"": [
			""10% decreased movement speed"",
			""Enemies take damage when they hit you"",
			""Grants immunity to Armor Crunch""
		],
		""name"": ""Carapace de Tortue Géante"",
		""tooltip"": [
			""Vitesse de mouvement réduite de 10%"",
			""Les ennemis subissent des dégâts lorsqu'ils vous touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguebringerCarapace"",
		""type"": ""ITEM"",
		""englishName"": ""Plaguebringer Carapace"",
		""englishTooltip"": [
			""Grants immunity to the Plague"",
			""12% increased minion damage"",
			""Friendly bees inflict the plague""
		],
		""name"": ""Carapace du Colporte-Peste"",
		""tooltip"": [
			""Réduit les dégâts que la peste vous inflige"",
			""+12% de dégâts des sbires"",
			""Les abeilles alliées infligent la peste""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Carnage"",
		""type"": ""ITEM"",
		""englishName"": ""Carnage"",
		""englishTooltip"": [
			""Enemies explode into homing blood on death""
		],
		""name"": ""Carnage"",
		""tooltip"": [
			""Les ennemis explosent en du sang à tête chercheuse quand ils meurent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElementalQuiver"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Quiver"",
		""englishTooltip"": [
			""15% increased ranged damage, 5% increased ranged critical strike chance and 20% reduced ammo usage"",
			""Grants a 20% chance to not consume arrows"",
			""Greatly increases all ranged projectile velocity""
		],
		""name"": ""Carquois des Eléments"",
		""tooltip"": [
			""+15% de dégâts à distance, +5% de critique à distance, et -20% de consommation de munitions"",
			""+5 défense, +2 régénération de vie et +15% de vitesse de minage"",
			""Augmente beaucoup la vitesse des flèches et donne 20% de chances de ne pas consommer de flèches""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ExplosiveShells"",
		""type"": ""ITEM"",
		""englishName"": ""Explosive Shotgun Shell"",
		""name"": ""Cartouche de Fusil Explosive"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GrenadeRounds"",
		""type"": ""ITEM"",
		""englishName"": ""Grenade Shell"",
		""name"": ""Cartouche de Grenade"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MagnumRounds"",
		""type"": ""ITEM"",
		""englishName"": ""Magnum Round"",
		""name"": ""Cartouche de Magnum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MortarRound"",
		""type"": ""ITEM"",
		""englishName"": ""Mortar Round"",
		""englishTooltip"": [
			""Large blast radius. Will destroy tiles"",
			""Used by normal guns""
		],
		""name"": ""Cartouche de Mortier"",
		""tooltip"": [
			""Grande zone d'effet, détruit les tuiles"",
			""Utilisé par les armes classiques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Helm"",
		""englishTooltip"": [
			""Danger detection""
		],
		""name"": ""Casque Astral"",
		""tooltip"": [
			""Affiche les sources de danger""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AerospecHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Aerospec Helmet"",
		""englishTooltip"": [
			""5% increased movement speed and minion damage""
		],
		""name"": ""Casque Aérospec"",
		""tooltip"": [
			""+5% de vitesse de mouvement et de dégâts des sbires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AerospecHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Aerospec Helm"",
		""englishTooltip"": [
			""8% increased melee damage""
		],
		""name"": ""Casque Aérospec"",
		""tooltip"": [
			""+8% de dégâts de mêlée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OmegaBlueHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Omega Blue Helmet"",
		""englishTooltip"": [
			""You can move freely through liquids"",
			""12% increased damage and 8% increased critical strike chance""
		],
		""name"": ""Casque Bleu Omega"",
		""tooltip"": [
			""Vous pouvez vous déplacer librement dans les liquides"",
			""+12% de dégâts et +8% de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SilvaHornedHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Horned Helm"",
		""name"": ""Casque Cornu Silva"",
		""tooltip"": [
			""+13% de dégâts et de chances de coup critique à distance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MolluskShellmet"",
		""type"": ""ITEM"",
		""englishName"": ""Mollusk Shellmet"",
		""englishTooltip"": [
			""5% increased damage and 4% increased critical strike chance"",
			""You can move freely through liquids""
		],
		""name"": ""Casque Mollusque"",
		""tooltip"": [
			""+5% de dégâts et +4% de chances de coup critique"",
			""Vous pouvez vous déplacer librement dans les liquides""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PrismaticHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Prismatic Helmet"",
		""englishTooltip"": [
			""18% increased magic damage and 12% increased magic crit"",
			""20% decreased non-magic damage"",
			""Enemies with less than 500 max health deal no contact damage"",
			""This does not occur while a boss is alive""
		],
		""name"": ""Casque Prismatique"",
		""tooltip"": [
			""+18% de dégâts magiques et +12% de chances de coup critique magique"",
			""-20% aux dégâts non magiques"",
			""Les ennemi avec moins de 500 points de vie maximum n'infligent plus de dégâts de contact"",
			""Cela ne fonctionne pas quand un boss est en vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AuricTeslaSpaceHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Space Helmet"",
		""englishTooltip"": [
			""15% increased minion damage""
		],
		""name"": ""Casque Spatial en Tesla Aurique"",
		""tooltip"": [
			""+15% de dégâts des sbires"",
			""Rester immobile augmente les dégâts et les chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CometQuasher"",
		""type"": ""ITEM"",
		""englishName"": ""Comet Quasher"",
		""englishTooltip"": [
			""Summons a swarm of meteors from the sky on enemy hits""
		],
		""name"": ""Casseur de Comète"",
		""tooltip"": [
			""Invoque une nuée de météores depuis les cieux quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KelvinCatalyst"",
		""type"": ""ITEM"",
		""englishName"": ""Kelvin Catalyst"",
		""englishTooltip"": [
			""Throws an icy blade that splits into multiple ice stars on enemy hits"",
			""Stealth strikes will briefly gain sentience and ram nearby enemies before returning to the player""
		],
		""name"": ""Catalyste Kelvin"",
		""tooltip"": [
			""Lance une lame glacée qui se divise en étoiles de glace quand vous touchez"",
			""Les attaques furtives prendront brièvement conscience et chargeront les ennemis proches avant de retourner vers le joueur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StatisNinjaBelt"",
		""type"": ""ITEM"",
		""englishName"": ""Statis' Ninja Belt"",
		""englishTooltip"": [
			""6% increased jump speed and allows constant jumping"",
			""Grants the ability to swim"",
			""Increased fall damage resistance by 35 blocks"",
			""Can climb walls, dash, and dodge attacks"",
			""The dodge has a 90 second cooldown"",
			""This cooldown is shared with all other dodges and reflects""
		],
		""name"": ""Ceinture de Ninja de Statis"",
		""tooltip"": [
			""+8% de vitesse de saut et permet le saut automatique"",
			""Augmente la distance de chute maximale de 35 blocs"",
			""Vous pouvez monter les murs, foncer et esquiver les attaques"",
			""L'esquive à un temps de recharge de 90s"",
			""Ce temps de recharge est partagé avec tous les autres effets de renvoi et d'esquive""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Celestus"",
		""type"": ""ITEM"",
		""englishName"": ""Celestus"",
		""englishTooltip"": [
			""Throws a scythe that splits into multiple scythes on enemy hits"",
			""Stealth strikes reverse direction and home in on enemies after returning to the player""
		],
		""name"": ""Celestus"",
		""tooltip"": [
			""Jette une faux qui se divise en de multiples faux quand elle touche"",
			""Les attaques furtives se retournent et pourchassent les ennemis après être revenues au joueur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StarlightFuelCell"",
		""type"": ""ITEM"",
		""englishName"": ""Starlight Fuel Cell"",
		""englishTooltip"": [
			""Permanently increases Adrenaline Mode damage by 15% and damage reduction by 5%"",
			""Revengeance drop""
		],
		""name"": ""Cellule d'Alimentation de Lueur Stellaire"",
		""tooltip"": [
			""Augmente de façon définitive les dégâts du mode Adrénaline de 15% et la réduction des dégâts quand la jauge est pleine de 5%"",
			""Revengeance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedFuelPack"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Fuel Pack"",
		""englishTooltip"": [
			""5% increased rogue damage and 15% increased rogue projectile velocity"",
			""Stealth generates 10% faster"",
			""TOOLTIP LINE HEREThis effect has a 1 second cooldown before it can be used again""
		],
		""name"": ""Cellule de Carburant Pestiférée"",
		""tooltip"": [
			""+5% de dégâts de voleur et +15% de vitesse des projectiles de voleur"",
			""Vitesse de génération de la furtivité +10%"",
			""TOOLTIP LINE HERECet effet a 1 secondes de temps de recharge""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AuricQuantumCoolingCell"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Quantum Cooling Cell"",
		""englishTooltip"": [
			""Can be placed in the Codebreaker, completing it"",
			""The completion of the Codebreaker allows you to make contact with its original creator"",
			""Attempting to do so may have dire consequences""
		],
		""name"": ""Cellule de Refroidissement Quantique Aurique"",
		""tooltip"": [
			""Peut-être placée sur le Décodeur pour le compléter"",
			""Terminer le Décodeur vous permet de contacter son créateur"",
			""Le faire pourra avoir des conséquences dramatiques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DepthCells"",
		""type"": ""ITEM"",
		""englishName"": ""Depth Cells"",
		""englishTooltip"": [
			""The cells of abyssal creatures""
		],
		""name"": ""Cellules des Profondeurs"",
		""tooltip"": [
			""Les cellules des créatures abyssales""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Cinderplate"",
		""type"": ""ITEM"",
		""englishName"": ""Cinderplate"",
		""englishTooltip"": [
			""It resonates with otherworldly energy.""
		],
		""name"": ""Cendreplaque"",
		""tooltip"": [
			""Elle résonne d'une énergie d'un autre monde.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CindersOfLament"",
		""type"": ""ITEM"",
		""englishName"": ""Cinders of Lament"",
		""englishTooltip"": [
			""Summons either Cataclysm or Catastrophe at the mouse position"",
			""They will look at you for a moment before charging at you"",
			""They can do damage to both you and enemies"",
			""\"" + CalamityUtils.ColorMessage(\""The Witch, a sinner of her own making,"",
			""Within her mind her demon lies, ever patient, until the end of time.""
		],
		""name"": ""Cendres de Lamentation"",
		""tooltip"": [
			""Invoque soit Catastrophe soit Cataclysme a l'emplacement du curseur"",
			""Ils vous regarderons pendant un moment avant de vous charger"",
			""Ils infligent des dégâts au joueur comme aux ennemis"",
			""\"" + CalamityUtils.ColorMessage(\""La sorcière, une pécheresse de sa création\"", CalamityGlobalItem.ExhumedTooltipColor)"",
			""Dans son esprit repose un démon, patient comme toujours, attendant la fin du temps.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AmalgamatedBrain"",
		""type"": ""ITEM"",
		""englishName"": ""Amalgamated Brain"",
		""englishTooltip"": [
			""10% increased damage"",
			""Shade rains down when you are hit"",
			""You will confuse nearby enemies when you are struck""
		],
		""name"": ""Cerveau Amalgamé"",
		""tooltip"": [
			""10% de dégâts supplémentaires"",
			""Des ombres pleuvent lorsque vous êtes touché"",
			""Peut rendre les ennemis à proximité confus après avoir reçu un coup""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RottenBrain"",
		""type"": ""ITEM"",
		""englishName"": ""Rotten Brain"",
		""englishTooltip"": [
			""10% increased damage when below 75% life"",
			""5% decreased movement speed when below 50% life"",
			""Shade rains down when you are hit""
		],
		""name"": ""Cerveau Décomposé"",
		""tooltip"": [
			""+10% de dégâts quand vous avez moins de 75% de votre vie"",
			""5% de réduction de vitesse de mouvement quand vous êtes en dessous de la moitié de votre vie"",
			""Des ombres pleuvent quand vous êtes touché""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateChair"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Chair"",
		""name"": ""Chaise Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""OddMushroom"",
		""type"": ""ITEM"",
		""englishName"": ""Odd Mushroom"",
		""englishTooltip"": [
			""Causes you to see many fake, vibrant copies of all nearby entities"",
			""These visual effects may be nauseating or otherwise bad for some"",
			""Trippy""
		],
		""name"": ""Champignon Étrange"",
		""tooltip"": [
			""Vous fait voir de nombreuses fausses copies vibrantes de toutes les entités proches"",
			""Ces effets visuels peuvent induire des nausées ou pire pour certains"",
			""Trippant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Shroomer"",
		""type"": ""ITEM"",
		""englishName"": ""Shroomer"",
		""englishTooltip"": [
			""Fires bullets and an extremely powerful homing mushroom""
		],
		""name"": ""Champignoneur"",
		""tooltip"": [
			""Tire des balles et un champignon extrêmement puissant à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateChandelier"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Chandelier"",
		""name"": ""Chandelier Pestiféré"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AerospecHat"",
		""type"": ""ITEM"",
		""englishName"": ""Aerospec Hat"",
		""englishTooltip"": [
			""8% increased magic damage and +20 max mana""
		],
		""name"": ""Chapeau Aérospec"",
		""tooltip"": [
			""+8% de dégâts magiques et +20 mana maximum""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DesertProwlerHat"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Prowler Hat"",
		""englishTooltip"": [
			""4% increased ranged critical strike chance and 20% chance to not consume ammo""
		],
		""name"": ""Chapeau du Rôdeur des Sables"",
		""tooltip"": [
			""+4% de chances de coup critique et 20% de chances de ne pas consommer de munitions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DepthCharm"",
		""type"": ""ITEM"",
		""englishName"": ""Depths Charm"",
		""englishTooltip"": [
			""Reduces the damage caused by the pressure of the abyss while out of breath"",
			""Removes the bleed effect caused by the upper layers of the abyss""
		],
		""name"": ""Charme des Profondeurs"",
		""tooltip"": [
			""Réduit les dégâts causés par la pression des abysses lorsque vous suffoquez"",
			""Annule l'effet de saignement provoqué par les couches supérieures des abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CadaverousCarrion"",
		""type"": ""ITEM"",
		""englishName"": ""Cadaverous Carrion"",
		""englishTooltip"": [
			""Summons a gross Old Duke head on the ground""
		],
		""name"": ""Charogne Cadavérique"",
		""tooltip"": [
			""Invoque une dégoutante tête du vieux duc sur le sol""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DormantBrimseeker"",
		""type"": ""ITEM"",
		""englishName"": ""Dormant Brimseeker"",
		""englishTooltip"": [
			""You could've sworn that they turned even scarier when you looked at their reflections in a mirror"",
			""Summons a brimseeker to keep you company"",
			""Firing another brimseeker when all minion slots are filled summons a brimstone aura"",
			""The aura empowers your brimseeker summons and produces damaging fireballs"",
			""Only one aura can persist at a time""
		],
		""name"": ""Cherche-soufre Dormant"",
		""tooltip"": [
			""Vous auriez juré qu'ils sont encore plus effrayants quand vous regardez leurs reflets dans un miroir"",
			""Invoque un cherche-soufre pour vous tenir compagnie"",
			""Se servir de l'arme alors que tous les emplacements de sbires sont occupés invoque une aura de soufre"",
			""L'aura renforce vos cherches-soufre et produit des boules de feu"",
			""Une seule aura peut exister à la fois""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NastyCholla"",
		""type"": ""ITEM"",
		""englishName"": ""Nasty Cholla"",
		""englishTooltip"": [
			""Throws a spiky ball that sticks to everything"",
			""Explodes into cactus spikes after roughly 3 seconds"",
			""Can hurt town NPCs"",
			""Stealth strikes throw five at once""
		],
		""name"": ""Cholla Nuisible"",
		""tooltip"": [
			""Lance une boule à piques qui se colle à tout"",
			""Explose en épines de cactus après environ 3 secondes"",
			""Peut blesser les PNJs de ville"",
			""Les attaques furtives en lancent 5 à la fois""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SubmarineShocker"",
		""type"": ""ITEM"",
		""englishName"": ""Submarine Shocker"",
		""englishTooltip"": [
			""Enemies release electric sparks on hit""
		],
		""name"": ""Choqueur Sous-marin"",
		""tooltip"": [
			""Les ennemis relâchent des étincelles électriques quand ils sont touchés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssShocker"",
		""type"": ""ITEM"",
		""englishName"": ""Abyss Shocker"",
		""englishTooltip"": [
			""Fires an erratic lightning bolt that arcs and bounces between enemies""
		],
		""name"": ""Choqueur des Abysses"",
		""tooltip"": [
			""Tire une décharge erratique qui se courbe et rebondit entre les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Starfall"",
		""type"": ""ITEM"",
		""englishName"": ""Starfall"",
		""englishTooltip"": [
			""Casts a spread of astral stars at the mouse cursor""
		],
		""name"": ""Chute Stellaire"",
		""tooltip"": [
			""Invoque une étendue d'étoiles astrales à l'emplacement du curseur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EclipsesFall"",
		""type"": ""ITEM"",
		""englishName"": ""Eclipse's Fall"",
		""englishTooltip"": [
			""When the sun goes dark, you will know judgment"",
			""Summons spears from the sky on hit"",
			""Stealth strikes impale enemies and summon a constant barrage of spears over time""
		],
		""name"": ""Chute de l'Éclipse"",
		""tooltip"": [
			""Quand le soleil s'assombrit, tu connaitras le jugement"",
			""Invoques des lances depuis le ciel quand vous touchez"",
			""Les attaques furtives empalent les ennemis et invoquent un barrage constant de lances durant un moment""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""UndinesRetribution"",
		""type"": ""ITEM"",
		""englishName"": ""Undine's Retribution"",
		""englishTooltip"": [
			""Casts a swarm of homing spears""
		],
		""name"": ""Châtiment d'Ondine"",
		""tooltip"": [
			""Convoque une nuée de lances à têtes chercheuses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CinnamonRoll"",
		""type"": ""ITEM"",
		""englishName"": ""Cinnamon Roll"",
		""englishTooltip"": [
			""A great-tasting cinnamon whiskey with a touch of cream soda"",
			""Boosts mana regeneration rate and multiplies all fire-based debuff damage by 1.5"",
			""Reduces defense by 10%""
		],
		""name"": ""Cinnamon Roll"",
		""tooltip"": [
			""Un succulent whisky à la canelle avec une touche de soda à la crème"",
			""Augmente la régénération du mana et augmente tous les dégâts d'altération de feu de 50%"",
			""Réduit la défense de 10%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Cinquedea"",
		""type"": ""ITEM"",
		""englishName"": ""Cinquedea"",
		""englishTooltip"": [
			""Stealth strikes home in after hitting an enemy""
		],
		""name"": ""Cinquedea"",
		""tooltip"": [
			""Les attaques furtives pourchassent les ennemis après les avoir touchés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MysteriousCircuitry"",
		""type"": ""ITEM"",
		""englishName"": ""Mysterious Circuitry"",
		""name"": ""Circuits mystérieux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Pumpler"",
		""type"": ""ITEM"",
		""englishName"": ""Pumpler"",
		""englishTooltip"": [
			""Hold left click to load up to five pumpkin grenades into the gun""
		],
		""name"": ""Citrouilleur"",
		""tooltip"": [
			""Maintenez le clic gauche pour charger jusqu'a 5 grenades citrouilles dans l'arme""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ClamorNoctus"",
		""type"": ""ITEM"",
		""englishName"": ""Clamor Noctus"",
		""englishTooltip"": [
			""Let the sky fall"",
			""Fires night wyverns and stars from the sky that stick to enemies and tiles and explode""
		],
		""name"": ""Clamor Noctus"",
		""tooltip"": [
			""Laisse le ciel tomber"",
			""Tire des wyvernes de nuit et des étoiles depuis les cieux qui se collent aux ennemis et aux tuiles et explosent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VividClarity"",
		""type"": ""ITEM"",
		""englishName"": ""Vivid Clarity"",
		""englishTooltip"": [
			""Fires five randomized beams of elemental energy at the cursor"",
			""On enemy and tile hits, beams either explode into a big flash,"",
			""summon an additonal laser from the sky,"",
			""or split into energy orbs"",
			""Its majesty inspires a stroke of unparalleled genius""
		],
		""name"": ""Clarté Vivace"",
		""tooltip"": [
			""Tire cinq rayons aléatoires d'énergie élémentaire sur le curseur"",
			""Quand les rayons touchent un ennemi ou une tuile, les rayons peuvent soit provoquer une explosion de lumière,"",
			""soit invoquer un laser de plus depuis le ciel,"",
			""soit se diviser en orbes d'énergie"",
			""Sa majesté inspire un afflux de génie sans pareil""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CelestialClaymore"",
		""type"": ""ITEM"",
		""englishName"": ""Celestial Claymore"",
		""englishTooltip"": [
			""Spawns cosmic energy flames near the player that generate large explosions""
		],
		""name"": ""Claymore Céleste"",
		""tooltip"": [
			""Fait apparaître des flammes d'énergie cosmique près du joueur qui génèrent de larges explosions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FeralthornClaymore"",
		""type"": ""ITEM"",
		""englishName"": ""Feralthorn Claymore"",
		""englishTooltip"": [
			""Summons thorns on enemy hits""
		],
		""name"": ""Claymore Féralépine"",
		""tooltip"": [
			""Invoque des épines quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CatastropheClaymore"",
		""type"": ""ITEM"",
		""englishName"": ""Catastrophe Claymore"",
		""englishTooltip"": [
			""Fires explosive energy bolts""
		],
		""name"": ""Claymore de Catastrophe"",
		""tooltip"": [
			""Tire des décharges d'énergie explosive""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SolsticeClaymore"",
		""type"": ""ITEM"",
		""englishName"": ""Solstice Claymore"",
		""englishTooltip"": [
			""Changes projectile color based on the time of year"",
			""Inflicts daybroken during the day and nightwither during the night""
		],
		""name"": ""Claymore du Solstice"",
		""tooltip"": [
			""Les porjectiles changent de couleur en fonction de la saison"",
			""Inflige Jour Perçant la journée et flétrinuit la nuit""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeCalamitasClone"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitas Clone"",
		""englishTooltip"": [
			""You are indeed stronger than I thought."",
			""Though the bloody inferno still lingers, observing your progress.""
		],
		""name"": ""Clone de Calamitas"",
		""tooltip"": [
			""Vous êtes plus fort que ce à quoi je m'attendais."",
			""Bien que l'enfet sanglant continue de perdurer, observant vos progrès.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SandDollar"",
		""type"": ""ITEM"",
		""englishName"": ""Sand Dollar"",
		""englishTooltip"": [
			""Stacks up to 2"",
			""Stealth strikes throw 2 long ranged sand dollars that explode into coral shards on enemy hits""
		],
		""name"": ""Clypéastéroïde"",
		""tooltip"": [
			""Se cumule jusqu'a 2"",
			""Les attaques furtives lancent deux clypéastéroïdes à longue portée qui explosent en éclats de corail quand elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CryoKey"",
		""type"": ""ITEM"",
		""englishName"": ""Cryo Key"",
		""englishTooltip"": [
			""Summons Cryogen when used in the tundra"",
			""Not consumable""
		],
		""name"": ""Clé Cryo"",
		""tooltip"": [
			""Invoque Cryogène quand utilisé dans la toundra"",
			""Ne se consomme pas""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OnyxExcavatorKey"",
		""type"": ""ITEM"",
		""englishName"": ""Onyx Excavator Key"",
		""englishTooltip"": [
			""Summons a drill to drill through the world so you can destroy all the neat world generation"",
			""with complete disregard for all the creatures that inhabit these lands. I am sure the EPA and PETA would like"",
			""to have a word with you afterwards."",
			""The power of the destruction scales with the highest powered pickaxe in your inventory""
		],
		""name"": ""Clé d'Excavateur Onyx"",
		""tooltip"": [
			""Invoque une foreuse pour forer à travers le monde, comme ça vous pouvez détruire tout le beau travail de génération de monde"",
			""En ignorant complètement toutes les créatures qui vivent en ces lieux. Je suis sur que la SPA et PETA vont vouloir"",
			""avoir une longue discussion avec toi après ça."",
			""Le pouvoir de destruction s'étalonne sur la pioche la plus puissante dans votre inventaire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Cnidarian"",
		""type"": ""ITEM"",
		""englishName"": ""Cnidarian"",
		""englishTooltip"": [
			""Fishes up an electric jellyfish"",
			""Periodically sends out sparks to electrocute nearby enemies."",
			""[c/5C95A1:From looking at their less sapient brethren, the Old Kingdom’s inhabitants adapted tools and weapons designed for underwater efficiency.]"",
			""[c/5C95A1:The electric properties of ghost bells remain useful even after death, having been commonly used as conduits.]""
		],
		""name"": ""Cnidarien"",
		""tooltip"": [
			""Tire un coquillage quand des ennemis sont près"",
			""Un yoyo très agile""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PhantomHeart"",
		""type"": ""ITEM"",
		""englishName"": ""Phantom Heart"",
		""englishTooltip"": [
			""Permanently increases maximum mana by 50""
		],
		""name"": ""Coeur Fantôme"",
		""tooltip"": [
			""Augmente définitivement le mana maximum de 50""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GammaHeart"",
		""type"": ""ITEM"",
		""englishName"": ""Gamma Heart"",
		""englishTooltip"": [
			""Summons radioactive heads that are bound by your body""
		],
		""name"": ""Coeur Gamma"",
		""tooltip"": [
			""Invoque des têtes radioactives rattachés à votre corps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""JoyfulHeart"",
		""type"": ""ITEM"",
		""englishName"": ""Joyful Heart"",
		""englishTooltip"": [
			""It's oddly warm. Attracts the forbidden one.""
		],
		""name"": ""Coeur Joyeux"",
		""tooltip"": [
			""Il est étrangement chaleureux. Attire l'interdit.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""UnholyCore"",
		""type"": ""ITEM"",
		""englishName"": ""Unholy Core"",
		""name"": ""Coeur Profane"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ToxicHeart"",
		""type"": ""ITEM"",
		""englishName"": ""Toxic Heart"",
		""englishTooltip"": [
			""Summons a plague aura around you that damages nearby enemies"",
			""Makes you immune to the Plague debuff ""
		],
		""name"": ""Coeur Toxique"",
		""tooltip"": [
			""Invoque une aura de peste nocive autour du joueur qui détruit les ennemis"",
			""Immunise contre la peste""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HowlsHeart"",
		""type"": ""ITEM"",
		""englishName"": ""Howl's Heart"",
		""englishTooltip"": [
			""Summons Howl to fight for you, Calcifer to light your way, and Turnip-Head to follow you around"",
			""Placing this accessory in vanity slots will summon the trio without the combat or exploration utilities""
		],
		""name"": ""Coeur d'Howl"",
		""tooltip"": [
			""Invoque Howl pour vous protéger, Calcifer pour éclairér votre voie, et Tête-de-Navet pour vous suivre"",
			""Placer cette accessoire dans un emplacement de vanité invoquera le trio sans leurs fonctions utilitaires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DraedonsHeart"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon's Heart"",
		""englishTooltip"": [
			""DO NOT TRAD""
		],
		""name"": ""Coeur de Draedon"",
		""tooltip"": [
			""Réduit les dégâts que vous subissez de 50%"",
			""Rester immobile régénére rapidement votre vie, réduit vos dégâts de 50% et augmente votre défense de 75%"",
			""Les nanomachines, mon grand""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodstoneCore"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodstone Core"",
		""name"": ""Coeur de Sang"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TitanHeart"",
		""type"": ""ITEM"",
		""englishName"": ""Titan Heart"",
		""englishTooltip"": [
			""Also used at the Astral Beacon""
		],
		""name"": ""Coeur de Titan"",
		""tooltip"": [
			""Aussi utilisable à la balise astrale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HeartofDarkness"",
		""type"": ""ITEM"",
		""englishName"": ""Heart of Darkness"",
		""englishTooltip"": [
			""You constantly gain rage over time"",
			""Rage does not fade away when out of combat"",
			""Revengeance drop""
		],
		""name"": ""Coeur des Ténèbres"",
		""tooltip"": [
			""La rage ne diminue pas en dehors des combats"",
			""Vous gagnez de la rage naturellement"",
			""Revengeance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HeartoftheElements"",
		""type"": ""ITEM"",
		""englishName"": ""Heart of the Elements"",
		""englishTooltip"": [
			""The heart of the world"",
			""Summons all elementals to protect you""
		],
		""name"": ""Coeur des Éléments"",
		""tooltip"": [
			""Le coeur du monde"",
			""Invoque tous les élémentaires pour vous protéger""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateChest"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Chest"",
		""name"": ""Coffre Pestiféré"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SecurityChest"",
		""type"": ""ITEM"",
		""englishName"": ""Security Chest"",
		""name"": ""Coffre Sécurisé"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ReaperToothNecklace"",
		""type"": ""ITEM"",
		""englishName"": ""Reaper Tooth Necklace"",
		""englishTooltip"": [
			""A grisly trophy from the ultimate predator"",
			""15% increased damage"",
			""Increases armor penetration by 15""
		],
		""name"": ""Collier de Dents de Faucheur"",
		""tooltip"": [
			""Un trophée macabre du prédateur ultime"",
			""+15% de dégâts supplémentaires"",
			""Augmente la pénétration d'armure de 15""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NecklaceofVexation"",
		""type"": ""ITEM"",
		""englishName"": ""Necklace of Vexation"",
		""englishTooltip"": [
			""Revenge"",
			""20% increased damage when under 50% life"",
			""All attacks inflict Cursed Inferno and Venom while wearing Reaver armor""
		],
		""name"": ""Collier de Vexation"",
		""tooltip"": [
			""Vengeance"",
			""+20% de dégâts quand vous avez moins de la moitié de vos points de vie"",
			""Toutes les attaques infligent le feu maudit et le venin si vous portez l'armure de saccageur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HolyCollider"",
		""type"": ""ITEM"",
		""englishName"": ""Holy Collider"",
		""englishTooltip"": [
			""Striking enemies will cause them to explode into holy fire""
		],
		""name"": ""Collisionneur Sacré"",
		""tooltip"": [
			""Frapper les ennemis les fera exploser d'un feu sacré""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CorrosiveSpine"",
		""type"": ""ITEM"",
		""englishName"": ""Corrosive Spine"",
		""englishTooltip"": [
			""10% increased movement speed"",
			""All rogue weapons inflict venom and spawn clouds on enemy hits"",
			""You release a ton of clouds everywhere on hit""
		],
		""name"": ""Colonne Vertébrale Corrosive"",
		""tooltip"": [
			""10% d'augmentation du déplacement"",
			""Toutes les armes de voleur infligent le venin et créent des nuages quand ils touchent les ennemis"",
			""Vous relâchez une tonne de nuage partout quand vous êtes touché""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AdrenalineHairDye"",
		""type"": ""ITEM"",
		""englishName"": ""Adrenaline Hair Dye"",
		""name"": ""Coloration d'Adrénaline"",
		""state"": ""Traduit""
	},
	{
		""id"": ""StealthHairDye"",
		""type"": ""ITEM"",
		""englishName"": ""Stealth Hair Dye"",
		""name"": ""Coloration de Furtivité"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RageHairDye"",
		""type"": ""ITEM"",
		""englishName"": ""Rage Hair Dye"",
		""name"": ""Coloration de Rage"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WingTimeHairDye"",
		""type"": ""ITEM"",
		""englishName"": ""Wing Time Hair Dye"",
		""name"": ""Coloration de Temps de Vol"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssalDivingSuit"",
		""type"": ""ITEM"",
		""englishName"": ""Abyssal Diving Suit"",
		""englishTooltip"": [
			""Transforms the holder into an armored diver"",
			""Increases max movement speed and acceleration while underwater but you move slowly outside of water"",
			""The suits' armored plates reduce damage taken by 15%"",
			""The plates will only take damage if the damage taken is over 50"",
			""After the suit has taken too much damage its armored plates will take 3 minutes to regenerate"",
			""Reduces the damage caused by the pressure of the abyss while out of breath"",
			""Removes the bleed effect caused by the abyss in all layers except the deepest one"",
			""Grants the ability to swim and greatly extends underwater breathing"",
			""Provides light underwater and extra mobility on ice"",
			""Provides a moderate amount of light in the abyss"",
			""Greatly reduces breath loss in the abyss"",
			""Reduces creature's ability to detect you in the abyss"",
			""Reduces the defense reduction that the abyss causes"",
			""Grants immunity to the sulphurous waters"",
			""Allows you to fall faster while in liquids""
		],
		""name"": ""Combinaison de plongée abyssale"",
		""tooltip"": [
			""Vous transforme en un plongeur en armure"",
			""Augmente la vitesse de déplacement maximum et l'accelération sous l'eau mais la réduit en dehors de l'eau"",
			""Les plaques d'armure de la combinaison réduisent les dégâts subis de 15%"",
			""Les plaques ne subiront des dégâts que si ces derniers dépassent 50"",
			""Après avoir subi trop de dégâts, les plaques de l'armure mettront 3 minutes avant de se régénérer"",
			""Réduit les dégâts infligés par la pression des abysses lorsque vous n'avez plus d'air"",
			""Annule l'effet de saignement causé par les abysses à tous les niveaux de profondeur à l'exception du plus profond"",
			""Vous permet de nager et augmente considérablement votre temps de respiration sous l'eau"",
			""Emet de la lumière sous l'eau et permet de mieux se déplacer sur la glace"",
			""Accorde un montant de lumière modéré dans les abysses"",
			""Réduit considérablement la perte de respiration dans les abysses"",
			""Réduit la capacité des ennemis abyssaux de vous détecter"",
			""Réduit la baisse de défense provoquée par les abysses"",
			""Vous permet de tomber plus vite dans les liquides""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateDresser"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Dresser"",
		""name"": ""Commode Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Valediction"",
		""type"": ""ITEM"",
		""englishName"": ""Valediction"",
		""englishTooltip"": [
			""Throws a homing reaper scythe"",
			""Stealth strikes spawn razorblade typhoons on enemy hits""
		],
		""name"": ""Conclusion"",
		""tooltip"": [
			""Jette une faux à tête chercheuse"",
			""Les attaques furtives invoquent des typhons rasoirs quand elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CalamitasBrew"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitas' Brew"",
		""englishTooltip"": [
			""Adds brimstone flames to your melee and rogue projectiles and melee attacks"",
			""Increases your movement speed by 5%""
		],
		""name"": ""Concoction de Calamitas"",
		""tooltip"": [
			""Ajoute des flammes abyssales à vos attaques et projectiles de mêlée"",
			""Augmente votre vitesse de mouvement de 5%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MomentumCapacitor"",
		""type"": ""ITEM"",
		""englishName"": ""Momentum Capacitor"",
		""englishTooltip"": [
			""TOOLTIP LINE HERE"",
			""Rogue projectiles that enter the field get a constant acceleration and 15% damage boost"",
			""These boosts can only happen to a projectile once"",
			""There can only be one field""
		],
		""name"": ""Condensateur de Dynamisme"",
		""tooltip"": [
			""TOOLTIP LINE HERE"",
			""Les projectiles qui entrent dans le champ crée accélèrent et infligent 15% de dégâts supplémentaires"",
			""Cette amélioration ne s'applique qu'une fois par projectile"",
			""Un seul champ peut exister à la fois""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VoidCondenser"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": ""Condenseur de Néant"",
		""tooltip"": [
			""Utilisé pour l'artisanat spécial""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BurningStrife"",
		""type"": ""ITEM"",
		""englishName"": ""Burning Strife"",
		""englishTooltip"": [
			""Throws a shadowflame spiky ball that bursts into flames"",
			""Stealth Strikes make the ball linger and explode more violently"",
			""'Definitely not pocket safe'""
		],
		""name"": ""Conflit Brûlant"",
		""tooltip"": [
			""Lance une boule à piques d'ombreflamme qui explose en émettant des flammes"",
			""Les attaques furtives font perdurer la boule et explosent plus violemment"",
			""'Définitivement pas sur à empocher'""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LaboratoryConsoleItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Console"",
		""name"": ""Console de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Contagion"",
		""type"": ""ITEM"",
		""englishName"": ""Contagion"",
		""englishTooltip"": [
			""Fires contagion arrows that leave exploding orbs behind as they travel""
		],
		""name"": ""Contagion"",
		""tooltip"": [
			""Tire des flèches de contagion qui laissent des orbes explosives dans leurs sillages""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RedLightningContainer"",
		""type"": ""ITEM"",
		""englishName"": ""Red Lightning Container"",
		""englishTooltip"": [
			""Permanently increases the duration of Rage Mode by 1 second"",
			""Revengeance drop""
		],
		""name"": ""Conteneur d'Électricité Rouge"",
		""tooltip"": [
			""Augmente de façon permanente la durée du mode Rage de 1 seconde"",
			""Revengeance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SpentFuelContainer"",
		""type"": ""ITEM"",
		""englishName"": ""Spent Fuel Container"",
		""englishTooltip"": [
			""War Never Changes"",
			""Throws a fuel container with trace amounts of plutonium that causes a nuclear explosion"",
			""The explosion does not occur if there are no tiles below it"",
			""Stealth strikes leave a lingering irradiated zone after the explosion dissipates""
		],
		""name"": ""Conteneur de Carburant Vidé"",
		""tooltip"": [
			""La guerre ne change jamais"",
			""Jette un conteneur de carburant contenant des traces de plutonium qui cause une explosion nucléaire"",
			""L'explosion n'arrive pas si il n'y a pas de tuile en dessous"",
			""Les attaques furtives laisse une zone de radiation persistante après l'explosion""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumController"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Controller"",
		""englishTooltip"": [
			""Summons a wulfrum droid to fight for you""
		],
		""name"": ""Controlleur Wulfrum"",
		""tooltip"": [
			""Invoque un droïde wulfrum pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MagicalConch"",
		""type"": ""ITEM"",
		""englishName"": ""Magical Conch"",
		""englishTooltip"": [
			""Summons a hermit crab to fight for you""
		],
		""name"": ""Coquillage Magique"",
		""tooltip"": [
			""Invoque un crabe hermite pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OrthoceraShell"",
		""type"": ""ITEM"",
		""englishName"": ""Orthocera Shell"",
		""englishTooltip"": [
			""Summons a flying orthocera sentry at the mouse position""
		],
		""name"": ""Coquillage Orthocera"",
		""tooltip"": [
			""Invoque une sentinelle orthocera à l'emplacement du curseur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AshenHorns"",
		""type"": ""ITEM"",
		""englishName"": ""Ashen Horns"",
		""name"": ""Cornes Cendrées"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CorpusAvertor"",
		""type"": ""ITEM"",
		""englishName"": ""Corpus Avertor"",
		""englishTooltip"": [
			""Seems like it has worn down over time"",
			""Attacks grant lifesteal based on damage dealt"",
			""The lower your HP the more damage this weapon does and heals the player on enemy hits"",
			""Stealth strikes throw a single rainbow outlined dagger"",
			""On enemy hits, this dagger boosts the damage and life regen of all members of your team"",
			""However, there is a small chance it will cut your health in half instead""
		],
		""name"": ""Corpus Avertor"",
		""tooltip"": [
			""On dirait qu'il s'est abimé avec le temps"",
			""Les attaques volent de la vie en fonction des dégâts effectués"",
			""Au plus il vous manque de la vie, au plus cette arme inflige des dégâts et soigne le joueur"",
			""Les attaques furtives lancent une unique dague irisée"",
			""Quand elle touche, cette dague augmente les dégâts et la régénération de vie de tous les membres de votre équipe"",
			""En revanche, il y a une petite chance qu'elle divise votre vie par deux à la place""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Cosmilamp"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmilamp"",
		""englishTooltip"": [
			""Summons a cosmic lantern to fight for you"",
			""Takes up 2 minion slots""
		],
		""name"": ""Cosmilampe"",
		""tooltip"": [
			""Invoque une lanterne cosmique pour combattre à vos côtés"",
			""Occupe 2 emplacements de sbires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Cosmolight"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmolight"",
		""englishTooltip"": [
			""Changes night to day and vice versa"",
			""Does not work while a boss is alive""
		],
		""name"": ""Cosmolueur"",
		""tooltip"": [
			""Change la nuit en jour et vice-versa"",
			""Ne fonctionne pas quand un boss est en vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MolluskHusk"",
		""type"": ""ITEM"",
		""englishName"": ""Mollusk Husk"",
		""englishTooltip"": [
			""The remains of a mollusk""
		],
		""name"": ""Cosse de Mollusque"",
		""tooltip"": [
			""Les restes d'un mollusque""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ReaverScaleMail"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Scale Mail"",
		""englishTooltip"": [
			""9% increased damage and 4% increased critical strike chance"",
			""+20 max life""
		],
		""name"": ""Cotte de Mailles du Saccageur"",
		""tooltip"": [
			""+9% de dégâts et +4% de chances de coup critique"",
			""+20 vie maximum""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MoonstoneCrown"",
		""type"": ""ITEM"",
		""englishName"": ""Moonstone Crown"",
		""englishTooltip"": [
			""15% increased rogue projectile velocity"",
			""Stealth strikes summon lunar flares on enemy hits"",
			""Rogue projectiles very occasionally summon moon sigils behind them""
		],
		""name"": ""Couronne de Pierre Lunaire"",
		""tooltip"": [
			""+15% de vitesse de projectile de voleur"",
			""Les attaques furtives créent des éruptions lunaires quand elles touchent les ennemis"",
			""De temps en temps, les projectiles de voleurs créent des sigles lunaires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FeatherCrown"",
		""type"": ""ITEM"",
		""englishName"": ""Feather Crown"",
		""englishTooltip"": [
			""15% increased rogue projectile velocity"",
			""Stealth strikes cause feathers to fall from the sky on enemy hits""
		],
		""name"": ""Couronne de Plumes"",
		""tooltip"": [
			""+15 de vitesse des projectiles de voleur"",
			""Les attaques furtives réussies font pleuvoir des plumes du ciel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StellarKnife"",
		""type"": ""ITEM"",
		""englishName"": ""Stellar Knife"",
		""englishTooltip"": [
			""Throws knives that stop middair and then home into enemies"",
			""Stealth strikes throw a volley of \"" + knifeCount.ToString() + \"" knives in a spread"",
			""Za Warudo""
		],
		""name"": ""Couteau Stellaire"",
		""tooltip"": [
			""Jette des couteaux qui s'arrêtent en l'air puis qui foncent sur les ennemis"",
			""Les attaques furtives jettent une étendue de couteaux"",
			""Za Warudo""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumKnife"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Knife"",
		""englishTooltip"": [
			""Stealth strikes make the knife fly further and hit several times at once""
		],
		""name"": ""Couteau Wulfrum"",
		""tooltip"": [
			""Les attaques furtives volent plus loin et infligent plusieurs coups""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FeatherKnife"",
		""type"": ""ITEM"",
		""englishName"": ""Feather Knife"",
		""englishTooltip"": [
			""Throws a knife which summons homing feathers"",
			""Stealth strike throws a volley of knives""
		],
		""name"": ""Couteau de Plume"",
		""tooltip"": [
			""Lance un couteau qui invoque des plumes à tête chercheuse"",
			""Les attaques furtives lancent une volée de couteaux""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""YanmeisKnife"",
		""type"": ""ITEM"",
		""englishName"": ""Yanmei's Knife"",
		""englishTooltip"": [
			""When hitting a boss, miniboss, or their minions, you gain various boosts and cripple the enemy hit"",
			""A knife from an unknown world"",
			""An owner whose heart is pure and free of taint"",
			""A heart of iron and valor""
		],
		""name"": ""Couteau de Yanmei"",
		""tooltip"": [
			""Quand vous frappez un boss, un miniboss ou leurs sbires, vous gagnez diverses améliorations et débilitez l'adversaire touché"",
			""Un couteau d'un autre monde"",
			""Un propriétaire au coeur pur et non entaché"",
			""Un coeur de fer et de valeur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MythrilKnife"",
		""type"": ""ITEM"",
		""englishName"": ""Mythril Knife"",
		""englishTooltip"": [
			""Stealth strikes inflict a wide assortment of debuffs""
		],
		""name"": ""Couteau en Mithril"",
		""tooltip"": [
			""Les attaques furtives infligent un large assortiment d'altérations d'état""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EmpyreanKnives"",
		""type"": ""ITEM"",
		""englishName"": ""Empyrean Knives"",
		""englishTooltip"": [
			""Throws a flurry of bouncing knives that can heal the user""
		],
		""name"": ""Couteaux Empyréens"",
		""tooltip"": [
			""Lance une myriade de couteaux rebondissants qui soignent l'utilisateur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MonstrousKnives"",
		""type"": ""ITEM"",
		""englishName"": ""Monstrous Knives"",
		""englishTooltip"": [
			""Throws a spread of knives that can heal the user""
		],
		""name"": ""Couteaux Monstrueux"",
		""tooltip"": [
			""Jette une volée de couteaux qui peuvent soigner l'utilisateur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AerospecHeadgear"",
		""type"": ""ITEM"",
		""englishName"": ""Aerospec Headgear"",
		""englishTooltip"": [
			""8% increased rogue damage and 5% increased movement speed""
		],
		""name"": ""Couvre-chef Aérospec"",
		""tooltip"": [
			""+8% de dégâts de voleur et +5% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeCrabulon"",
		""type"": ""ITEM"",
		""englishName"": ""Crabulon"",
		""englishTooltip"": [
			""A crab and its mushrooms, a love story."",
			""It's interesting how creatures can adapt given certain circumstances.""
		],
		""name"": ""Crabulon"",
		""tooltip"": [
			""Un crabe et ses champignons, une histoire d'amour."",
			""C'est intéressant de voir comment certaines créatures peuvent s'adapter selon certaines circonstances.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StarSputter"",
		""type"": ""ITEM"",
		""englishName"": ""Star Sputter"",
		""englishTooltip"": [
			""Fires a chain of comets"",
			""Fires a bigger, more powerful comet every four rounds"",
			""Look to the stars for a galaxy far, far away""
		],
		""name"": ""Cracheur d'Étoiles"",
		""tooltip"": [
			""Tire une chaîne de comètes"",
			""Tire une comète plus grosse et plus puissante tous les 4 tirs"",
			""Regarde les étoiles d'une lointaine, lointaine galaxie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ProcyonidPrawn"",
		""type"": ""ITEM"",
		""englishName"": ""Procyonid Prawn"",
		""name"": ""Crevette Procyonide"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RadiatingCrystal"",
		""type"": ""ITEM"",
		""englishName"": ""Radiating Crystal"",
		""englishTooltip"": [
			""The crystal contains traces of holothurin"",
			""Summons a radiator light pet"",
			""Provides a small amount of light in the abyss""
		],
		""name"": ""Cristal Irradiant"",
		""tooltip"": [
			""Le cristal contient des traces d'holothurines"",
			""Invoque un compagnon radiateur lumineux"",
			""Émet une petite quantité de lumière dans les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedSoulCrystal"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Soul Crystal"",
		""englishTooltip"": [
			""Transforms you into an emissary of the profaned goddess"",
			""This tooltip gets modified""
		],
		""name"": ""Cristal d'Âme Profanée"",
		""tooltip"": [
			""Vous transforme en un émissaire de la déesse profanée"",
			""Consomme 10 emplacements de sbires pour accorder les effets suivants"",
			""Toutes les armes qui ne sont pas d'invocation sont converties en puissantes variantes d'invocation"",
			""Tomber en dessous de la moitié de vos points de vie renforcera ces attaques"",
			""[c/f05a5a:Transforme les attaques de corps à corps en un barrage de lances]"",
			""[c/3a83e4:Transforme les attaques magiques en une puissante boule de feu qui se divise]"",
			""[c/85e092:Transforme les attaques à distance en une volée de boules de feu et de météores]"",
			""[c/e97451:Transforme les attaques de voleur en une spirale cristalline mortelle]"",
			""Invoque et renforce les sbires profanés pour combattre à vos côtés"",
			""Leur effets perdurent même si vous êtes touché"",
			""Accorde des améliorations en fonction du moment de la journée"",
			""Quand j'y pense, c'était une vie ennuyeuse"",
			""[c/FFBF49:Et c'est alors que nous brûlerons tout, au nom de la pureté]""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""YharimsCrystal"",
		""type"": ""ITEM"",
		""englishName"": ""Yharim's Crystal"",
		""englishTooltip"": [
			""Fires draconic beams of total annihilation""
		],
		""name"": ""Cristal de Yharim"",
		""tooltip"": [
			""Tire des rayons draconiques d'annihilation totale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BansheeHook"",
		""type"": ""ITEM"",
		""englishName"": ""Banshee Hook"",
		""englishTooltip"": [
			""Swings a banshee hook that fires blades and explodes on hit""
		],
		""name"": ""Crochet Banshee"",
		""tooltip"": [
			""Balance un crochet banshee qui tire des lames et explose au contact""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeCryogen"",
		""type"": ""ITEM"",
		""englishName"": ""Cryogen"",
		""englishTooltip"": [
			""The archmage's prison."",
			""I am unsure if it has grown weaker over the decades of imprisonment.""
		],
		""name"": ""Cryogène"",
		""tooltip"": [
			""La prison de l'archimage."",
			""Je ne suis pas sur qu'elle soit devenue plus faible après des décennies .""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Cryophobia"",
		""type"": ""ITEM"",
		""englishName"": ""Cryophobia"",
		""englishTooltip"": [
			""Chill"",
			""Fires an icy wave that splits multiple times and explodes into shards""
		],
		""name"": ""Cryophobie"",
		""tooltip"": [
			""Reste frais"",
			""Tire une vague gelée qui se divisent plusieurs fois en explose en éclats""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Crystalline"",
		""type"": ""ITEM"",
		""englishName"": ""Crystalline"",
		""englishTooltip"": [
			""Splits into several projectiles as it travels"",
			""Stealth strikes make the blade split more and create crystals when destroyed""
		],
		""name"": ""Crystalline"",
		""tooltip"": [
			""Se divise en plusieurs projectiles sur sa trajectoire"",
			""Les attaques furtives font se diviser les lames davantage et créent des cristaux à la destruction""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AuricTeslaBodyArmor"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Body Armor"",
		""englishTooltip"": [
			""+100 max life"",
			""8% increased damage and 5% increased critical strike chance"",
			""You will freeze enemies near you when you are struck""
		],
		""name"": ""Cuirasse Tesla Aurique"",
		""tooltip"": [
			""+100 vie maximum"",
			""+8% de dégâts et +5% de chances de coup critique"",
			""Vous gelez les ennemis proches quand vous êtes touché""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodflareBodyArmor"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Body Armor"",
		""englishTooltip"": [
			""12% increased damage and 8% increased critical strike chance"",
			""+40 max life""
		],
		""name"": ""Cuirasse de Brûlesang"",
		""tooltip"": [
			""+12% de dégâts et +8% de chances de coup critique"",
			""Vous régénérez rapidement de la vie et gagnez 30 défense quand vous êtes dans la lave"",
			""+40 vie maximum""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AuricTeslaCuisses"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Cuisses"",
		""englishTooltip"": [
			""10% increased movement speed"",
			""12% increased damage and 5% increased critical strike chance"",
			""Magic carpet effect""
		],
		""name"": ""Cuissarde Tesla Aurique"",
		""tooltip"": [
			""+10% de vitesse de mouvement"",
			""+12% de réduction de dégâts et +5% de chances de coup critique"",
			""Effet du Tapis Volant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodflareCuisses"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Cuisses"",
		""englishTooltip"": [
			""17% increased movement speed, 10% increased damage and 7% increased critical strike chance""
		],
		""name"": ""Cuissardes Brûlesang"",
		""tooltip"": [
			""+17% de vitesse de mouvement, +10% de dégâts et +7% de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ReaverCuisses"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Cuisses"",
		""englishTooltip"": [
			""5% increased critical strike chance"",
			""12% increased movement speed""
		],
		""name"": ""Cuissardes de Saccageur"",
		""tooltip"": [
			""+5% de chances de coup critique"",
			""+12% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""InfernaCutter"",
		""type"": ""ITEM"",
		""englishName"": ""Inferna Cutter"",
		""englishTooltip"": [
			""Critical hits with the blade cause small explosions"",
			""Generates a number of small sparks when swung""
		],
		""name"": ""Cutter Infernal"",
		""tooltip"": [
			""Les coups critiques avec la lame provoquent de petites explosions"",
			""Génère un nombre aléatoire d'étincelles quand utilisé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GildedDagger"",
		""type"": ""ITEM"",
		""englishName"": ""Gilded Dagger"",
		""englishTooltip"": [
			""Throws a shiny blade that ricochets towards another enemy on hit"",
			""Stealth strikes cause the blade to home in after ricocheting, with each ricochet dealing 20% more damage"",
			""Stealth strikes also have increased piercing""
		],
		""name"": ""Dague Dorée"",
		""tooltip"": [
			""Lance une lame brillante qui ricoche vers un autre ennemi quand elle touche"",
			""Les attaques furtives sont à tête chercheuse après un ricochet, et chaque ricochet augmente les dégâts de l'attaque de 20%"",
			""Les attaques furtives percent également davantage""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CursedDagger"",
		""type"": ""ITEM"",
		""englishName"": ""Cursed Dagger"",
		""englishTooltip"": [
			""Throws bouncing daggers"",
			""Stealth strikes are showered in cursed fireballs""
		],
		""name"": ""Dague Maudite"",
		""tooltip"": [
			""Lance des dagues rebondissantes"",
			""Les attaques furtives font tomber des flammes maudites""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TimeBolt"",
		""type"": ""ITEM"",
		""englishName"": ""Time Bolt"",
		""englishTooltip"": [
			""There should be no boundary to human endeavor."",
			""Stealth strikes can hit more enemies and create a larger time field""
		],
		""name"": ""Dague Temporelle"",
		""tooltip"": [
			""Il ne devrait pas y avoir de limites à l'entreprise humaine."",
			""Les attaques furtives peuvent toucher plus d'ennemis et créent une plus grand champ temporel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GaussDagger"",
		""type"": ""ITEM"",
		""englishName"": ""Gauss Dagger"",
		""englishTooltip"": [
			""Slicing foes, it causes a flux of energy to form on the area tearing at them with turbulent forces"",
			""Repeat strikes envelop foes in magnetic flux""
		],
		""name"": ""Dague de Gauss"",
		""tooltip"": [
			""En tranchant les ennemis, crée un flux d'énergie qui les déchirent à l'aide de forces turbulentes"",
			""Les frappes répétées enveloppent les ennemis dans un flux magnétique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GleamingDagger"",
		""type"": ""ITEM"",
		""englishName"": ""Gleaming Dagger"",
		""englishTooltip"": [
			""Throws a shiny blade that ricochets towards another enemy on hit"",
			""Stealth strikes cause the blade to home in after ricocheting, with each ricochet dealing 20% more damage"",
			""Stealth strikes also have increased piercing""
		],
		""name"": ""Dague Éclatante"",
		""tooltip"": [
			""Jette une dague brillante qui ricoche sur un autre ennemi quand vous touchez"",
			""Les attaques furtives pourchassent les ennemis après un ricochet, et chaque ricochet inflige 20% de dégâts supplémentaires"",
			""Les attaques furtives ont une meilleure capacité à percer les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ReaperTooth"",
		""type"": ""ITEM"",
		""englishName"": ""Reaper Tooth"",
		""englishTooltip"": [
			""Sharp enough to cut diamonds""
		],
		""name"": ""Dent de Faucheur"",
		""tooltip"": [
			""Suffisamment acéré pour trancher du diamant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodyWormTooth"",
		""type"": ""ITEM"",
		""englishName"": ""Bloody Worm Tooth"",
		""englishTooltip"": [
			""7% increased melee damage and speed""
		],
		""name"": ""Dent de Ver Sanglante"",
		""tooltip"": [
			""5% de réduction de dégâts et d'augmentation des statistiques de corps à corps"",
			""10% de réduction de dégâts et d'augmentation des statistiques de corps à corps si vous avez moins de la moitié de vos points de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LeviathanTeeth"",
		""type"": ""ITEM"",
		""englishName"": ""Leviathan Teeth"",
		""englishTooltip"": [
			""Rapidly throws a variety of poisonous fangs that stick to enemies"",
			""Stealth strikes cause 3 very fast teeth to be thrown, ignoring gravity and inflicting extreme knockback""
		],
		""name"": ""Dents de Leviathan"",
		""tooltip"": [
			""Jette rapidement une variété de crocs empoisonnés qui se plantent dans les ennemis"",
			""Les attaques furtives lancent 3 dents très rapides, qui ignorent la gravité et infligent un recul extrême""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CraniumSmasher"",
		""type"": ""ITEM"",
		""englishName"": ""Cranium Smasher"",
		""englishTooltip"": [
			""Throws disks that roll on the ground, occasionally launches an explosive disk"",
			""Stealth strikes launch an explosive disk that can pierce several enemies""
		],
		""name"": ""Destructeur de Crânes"",
		""tooltip"": [
			""Lance des disques qui roulent sur le sol, lancant occasionnellement un disque explosif"",
			""Les attaques furtives lancent un disque explosif qui peut traverser plusieurs ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EvilSmasher"",
		""type"": ""ITEM"",
		""englishName"": ""Evil Smasher"",
		""englishTooltip"": [
			""EViL! sMaSH eVIl! SmAsh... ER!"",
			""For every enemy you kill this hammer gains stat bonuses"",
			""These bonuses stack until a cap is reached"",
			""The bonus stacks will reset if you select a different item"",
			""The bonus stacks will be reduced by 1 every time you get hit""
		],
		""name"": ""Destructeur du Mal"",
		""tooltip"": [
			""MAl! dÉtUiRE lE mAL! Destruc...TION!"",
			""Pour chaque ennemi tué, ce marteau gagne des bonus de statistiques"",
			""Ces bonus se cumulent jusqu'a un certain cap"",
			""Ces bonus s'annulent si vous sélectionnez un objet différent"",
			""Ces bonus réduisent leur cumul de 1 a chaque fois que vous vous faîtes toucher""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DraconicDestruction"",
		""type"": ""ITEM"",
		""englishName"": ""Draconic Destruction"",
		""englishTooltip"": [
			""Fires a draconic sword beam that explodes into additional beams"",
			""Additional beams fly up and down to shred enemies""
		],
		""name"": ""Destruction Draconique"",
		""tooltip"": [
			""Tire une rayon d'épée draconique qui explose en plus de rayons"",
			""Les rayons additionnels volent en haut et en bas pour déchirer les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ScarletDevil"",
		""type"": ""ITEM"",
		""englishName"": ""Scarlet Devil"",
		""englishTooltip"": [
			""Throws an ultra high velocity spear, which creates more projectiles that home in"",
			""The spear creates a Scarlet Blast upon hitting an enemy"",
			""Stealth strikes grant you lifesteal and summon a star of projectiles upon hitting an enemy"",
			""'Divine Spear \\\""Spear the Gungnir\\\""'""
		],
		""name"": ""Diable Écarlate"",
		""tooltip"": [
			""Jette une lance ultra rapide, qui crée des projectiles à tête chercheuse"",
			""La lance crée une déflagration écarlate quand elle touche les ennemis"",
			""Les attaques furtives volent de la vie et invoquent une étoile de projectiles quand elles touchent"",
			""'Lance Divine \\\""Empale le Gungnir\\\""'""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PearlGod"",
		""type"": ""ITEM"",
		""englishName"": ""Pearl God"",
		""englishTooltip"": [
			""Your life is mine..."",
			""Fires shockblast rounds that emit massive explosions and steal enemy life as well as additional bullets"",
			""Every seventh shot fires a massive shockblast""
		],
		""name"": ""Dieu des Perles"",
		""tooltip"": [
			""Ta vie est à moi..."",
			""Tire des balles d'onde de choc qui émettent des explosions massives et vole la vie des ennemis en plus d'autres balles"",
			""Tire une onde de choc massive tous les 7 tirs""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EvergladeSpray"",
		""type"": ""ITEM"",
		""englishName"": ""Everglade Spray"",
		""englishTooltip"": [
			""Fires a stream of burning green ichor""
		],
		""name"": ""Diffuseur des marais"",
		""tooltip"": [
			""Tire un faisceau d'ichor vert brûlant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AdvancedDisplay"",
		""type"": ""ITEM"",
		""englishName"": ""Advanced Display"",
		""englishTooltip"": [
			""Can be placed on the Codebreaker""
		],
		""name"": ""Dispositif d'Affichage Avancé"",
		""tooltip"": [
			""Peut-être placé sur le décodeur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FoxDrive"",
		""type"": ""ITEM"",
		""englishName"": ""Fox Drive"",
		""englishTooltip"": [
			""'It contains 1 file on it'"",
			""'Fox.cs'""
		],
		""name"": ""Disque Fox"",
		""tooltip"": [
			""'Il y a un fichier dessus'"",
			""'Fox.cs'""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TerraDisk"",
		""type"": ""ITEM"",
		""englishName"": ""Terra Disk"",
		""englishTooltip"": [
			""Throws a disk that has a chance to generate several disks if enemies are near it"",
			""A max of three disks can be active at a time"",
			""Stealth strikes travel slower and are rapidly orbited by the smaller disks""
		],
		""name"": ""Disque Terra"",
		""tooltip"": [
			""Lance un disque qui à une chance de générer plusieurs disques si les ennemis en sont proches"",
			""Un maximum de 3 disques peuvent-être actifs à la fois"",
			""Les attaques furtives voyagent plus lentement et sont rapidement cerclées par les disques plus petits""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TrackingDisk"",
		""type"": ""ITEM"",
		""englishName"": ""Tracking Disk"",
		""englishTooltip"": [
			""A weapon that, as it flies, processes calculations and fires lasers"",
			""Releases a flying disk that fires lasers at nearby enemies"",
			""Stealth strikes allow the disk to fire multiple larger lasers at different targets""
		],
		""name"": ""Disque Traceur"",
		""tooltip"": [
			""Une arme qui effectue des calculs et tire des lasers en vol"",
			""Relâche un disque volant qui tire des lasers sur les ennemis proches"",
			""Les attaques furtives permet au disque de tirer de multiples lasers plus gros sur des cibles différentes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RoverDrive"",
		""type"": ""ITEM"",
		""englishName"": ""Rover Drive"",
		""englishTooltip"": [
			""Activates a protective shield that grants 15 defense for 10 seconds"",
			""The shield then dissipates and recharges for 20 seconds before being reactivated""
		],
		""name"": ""Disque Vagabond"",
		""tooltip"": [
			""Active un bouclier protecteur qui augmente la défense de 15 durant 10 secondes"",
			""Le bouclier se coupe ensuite 20 secondes avant de se réactiver""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HeavenfallenStardisk"",
		""type"": ""ITEM"",
		""englishName"": ""Heavenfallen Stardisk"",
		""englishTooltip"": [
			""Throws a stardisk upwards which then launches itself towards your mouse cursor,"",
			""explodes into several astral energy bolts if the thrower is moving vertically when throwing it and during its impact"",
			""Stealth strikes rain astral energy bolts from the sky""
		],
		""name"": ""Disquétoile Chu-des-cieux"",
		""tooltip"": [
			""Jette une disque stellaire en l'air qui se porpulse vers le curseur,"",
			""explose en plusieurs décharges d'énergie astrale si le lanceur effectue un mouvement vertical quand il le lance et à l'impact du disque"",
			""Les attaques furtives font pleuvoir des décharges d'énergie astrale depuis le ciel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ColdDivinity"",
		""type"": ""ITEM"",
		""englishName"": ""Cold Divinity"",
		""englishTooltip"": [
			""Summons the power of the ancient ice castle"",
			""For each minion slot used, you will gain an additional orbiting shield spike"",
			""These spikes accelerate rapidly towards a nearby enemy to inflict heavy damage"",
			""They take some time to regenerate after launching themselves at the target, however"",
			""On right click, summons a duplicate ring around the targeted enemy, which slowly converges before exploding""
		],
		""name"": ""Divinité du Froid"",
		""tooltip"": [
			""Invoque le pouvoir de l'ancien château de glace"",
			""Pour chaque emplacement de sbire occupé, vous obtiendrez une pique de bouclier en orbite additionnelle"",
			""Les piques accélèrent rapidement vers un ennemi proche pour lui infliger de lourds dégâts"",
			""Cependant, ils mettent un certain temps à se régénérer après une attaque"",
			""Clic droit pour invoquer une copie de l'anneau autour de l'ennemi visé, qui converge lentement avant d'exploser""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FeralDoubleRod"",
		""type"": ""ITEM"",
		""englishName"": ""Feral Double Rod"",
		""englishTooltip"": [
			""Fires two lines at once."",
			""Just as you have tamed the jungle monster, you can now tame the fish in the sea.""
		],
		""name"": ""Double Canne Férale"",
		""tooltip"": [
			""Lance deux lignes à la fois."",
			""Comme vous vous êtes occupé du monstre de la jungle, vous pouvez maintenant vous occuper des poissons dans la mer.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Dragonfruit"",
		""type"": ""ITEM"",
		""englishName"": ""Dragonfruit"",
		""englishTooltip"": [
			""Though somewhat bland, what taste can be described is unlike any other experienced"",
			""Permanently increases maximum life by 25"",
			""Can only be used if the max amount of life fruit has been consumed""
		],
		""name"": ""Dracofruit"",
		""tooltip"": [
			""Bien que peu goûtu, le goûter peut être décrit comme une expérience sans pareille"",
			""Augmente la vie maximum de 25 définitivement"",
			""Ne peut être utilisé que si vous avez consommé le maximum de fruits de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DragoonDrizzlefish"",
		""type"": ""ITEM"",
		""englishName"": ""Dragoon Drizzlefish"",
		""englishTooltip"": [
			""Fires an inaccurate spread of fireballs"",
			""The brimstone sac appears to contain fuel"",
			""Revenge is a dish best served flaming hot""
		],
		""name"": ""Dragon Poisson-Bruine"",
		""tooltip"": [
			""Tire une étendue imprécise de boules de feu"",
			""Le sac de soufre semble contenir du carburant"",
			""La revanche est un plat qui se mange brûlant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PulseDragon"",
		""type"": ""ITEM"",
		""englishName"": ""Pulse Dragon"",
		""englishTooltip"": [
			""Heavy duty flails, each containing a powerful generator which is activated upon launch"",
			""Throws two dragon heads that emit electrical fields""
		],
		""name"": ""Dragon d'Impulsion"",
		""tooltip"": [
			""Des fléaux d'armes pour les gros travaux, chacun contenant un puissant générateur qui s'active quand il est lancé"",
			""Lance deux têtes de dragon qui émettent des champs électriques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeYharon"",
		""type"": ""ITEM"",
		""englishName"": ""Jungle Dragon, Yharon"",
		""englishTooltip"": [
			""I would not be able to bear a world without my faithful companion by my side."",
			""Fortunately, fate will have it so that it is a world I shall never have to see, for better or for worse.""
		],
		""name"": ""Dragon de la Jungle, Yharon"",
		""tooltip"": [
			""Je ne serais pas capable de supporter un monde sans mon fidèle compagnon à mes côtés."",
			""Par chance, le destin a décidé que c'est un monde que je n'aurais jamais à voir, pour le meilleur ou pour le pire.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StormDragoon"",
		""type"": ""ITEM"",
		""englishName"": ""Storm Dragoon"",
		""englishTooltip"": [
			""Fires a spray of bullets"",
			""90% chance to not consume ammo""
		],
		""name"": ""Dragon des Tempêtes"",
		""tooltip"": [
			""Tire une étendue de balles"",
			""90% de chances de ne pas consommer de munitions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Seadragon"",
		""type"": ""ITEM"",
		""englishName"": ""Seadragon"",
		""englishTooltip"": [
			""50% chance to not consume ammo"",
			""Fires streams of water every other shot"",
			""Fires a homing rocket every 18 shots, which explodes into fire shards on death""
		],
		""name"": ""Dragon des mers"",
		""tooltip"": [
			""50% de chances de ne pas consommer de munitions"",
			""Tire des faisceaux d'eau tous les deux tirs"",
			""Tire un missile à tête chercheuse qui explose en éclats de flamme tous les 18 tirs""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Drataliornus"",
		""type"": ""ITEM"",
		""englishName"": ""Drataliornus"",
		""englishTooltip"": [
			""Fires an escalating stream of fireballs."",
			""Fireballs rain meteors, leave dragon dust trails, and launch additional bolts at max speed."",
			""Taking damage while firing the stream will interrupt it and reduce your wing flight time."",
			""Right click to fire two devastating barrages of five empowered fireballs."",
			""'Just don't get hit'""
		],
		""name"": ""Drataliornus"",
		""tooltip"": [
			""Tire un torrent croissant de boules de feu."",
			""Les boules de feu font pleuvoir des météores, laissent des traînées de poussière draconique, et lancent des déflagrations à vitesse maximale."",
			""Prendre des dégâts alors que vous tirez interrompra le torrent et réduira votre temps de vol."",
			""Clic droit pour tirer deux vollées dévastatrices de 5 boules de feu surpuissantes."",
			""'Evite juste de te faire toucher'""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeDukeFishron"",
		""type"": ""ITEM"",
		""englishName"": ""Duke Fishron"",
		""englishTooltip"": [
			""The mutant terror of the sea was once the trusted companion of an old king; he tamed it using its favorite treat."",
			""Long ago, the creature flew in desperation from the raging bloody inferno consuming its home, ultimately finding its way to the ocean.""
		],
		""name"": ""Duc Dracosson"",
		""tooltip"": [
			""Une terreur mutante de la mer qui fut autrefois le fidèle compagnon d'un vieux roi; Il l'apprivoisa en utilisant sa friandise favorite."",
			""Il y a longtemps, la créature fuya désespérément la rage sanglante infernale qui consuma son foyer, pour finalement trouver son chemin jusqu'à l'océan.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CoralSpout"",
		""type"": ""ITEM"",
		""englishName"": ""Coral Spout"",
		""englishTooltip"": [
			""Casts a shotgun-like blast of coral shards"",
			""Keep the attack button held down to narrow the spread"",
			""Fully charging the attack releases a single, bigger chunk of coral that sticks to enemies"",
			""Grabbing the chunk of coral after it falls from the enemy replenishes 100 mana"",
			""[c/5C95A1:Knowledge is important, and the Old Sea Kingdom’s many scribes knew it had to be preserved at any cost.]"",
			""[c/5C95A1:Their libraries were much larger than most, because of the water-proof stone tablets occupying them.]""
		],
		""name"": ""Débiteur de Corail"",
		""tooltip"": [
			""Convoque des éclats de corail qui se posent au sol et endommagent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DukesDecapitator"",
		""type"": ""ITEM"",
		""englishName"": ""Duke's Decapitator"",
		""englishTooltip"": [
			""Throws a hydro axe which shreds enemies when it comes into contact with them"",
			""The faster it\\ufffds spinning, the more times it hits before disappearing"",
			""Stealth Strikes make it emit short-ranged bubbles.""
		],
		""name"": ""Décapitateur du Duc"",
		""tooltip"": [
			""Lance une hydro-hache qui déchire les ennemis quand elle rentre en contact avec eux"",
			""Au plus elle tourne vite, au plus elle peut frapper avant de disparaître"",
			""Les attaques furtives émettent des bulles à courte portées.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AquaticDischarge"",
		""type"": ""ITEM"",
		""englishName"": ""Aquatic Discharge"",
		""englishTooltip"": [
			""Enemies release electric sparks on hit""
		],
		""name"": ""Décharge Aquatique"",
		""tooltip"": [
			""Les ennemis relâchent des étincelles électriques quand ils sont touchés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SeethingDischarge"",
		""type"": ""ITEM"",
		""englishName"": ""Seething Discharge"",
		""englishTooltip"": [
			""Fires a barrage of brimstone blasts""
		],
		""name"": ""Décharge Bouillonante"",
		""tooltip"": [
			""Tire un barrage de décharges de soufre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicDischarge"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmic Discharge"",
		""englishTooltip"": [
			""Striking an enemy with the whip causes glacial explosions and grants the player the cosmic freeze buff"",
			""This buff gives the player increased life regen while standing still and freezes enemies near the player""
		],
		""name"": ""Décharge Cosmique"",
		""tooltip"": [
			""Frapper un ennemi avec le fouet provoque des explosions glaciales et octroie l'amélioration de gel cosmique au joueur"",
			""Cette amélioration augmente la régénération de vie quand vous êtes immobile et gèle les ennemis proches du joueur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FlareBolt"",
		""type"": ""ITEM"",
		""englishName"": ""Flare Bolt"",
		""englishTooltip"": [
			""Casts a slow-moving ball of flame""
		],
		""name"": ""Décharge de Déflagration"",
		""tooltip"": [
			""Convoque une lente boule de feu""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FrigidflashBolt"",
		""type"": ""ITEM"",
		""englishName"": ""Frigidflash Bolt"",
		""englishTooltip"": [
			""Casts a slow-moving ball of flash-freezing magma""
		],
		""name"": ""Décharge de Lumière Frigide"",
		""tooltip"": [
			""Convoque une lente boule de magma glaçant lumineux""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicBolter"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmic Bolter"",
		""englishTooltip"": [
			""Fires three arrows at once"",
			""Converts wooden arrows into sliding energy bolts""
		],
		""name"": ""Déchargeur Cosmique"",
		""tooltip"": [
			""Tire 3 flèches à la fois"",
			""Convertit les flèches de bois en décharges d'énergie glissantes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Shredder"",
		""type"": ""ITEM"",
		""englishName"": ""Shredder"",
		""englishTooltip"": [
			""The myth, the legend, the weapon that drops more frames than any other"",
			""Fires a barrage of energy bolts that split and bounce"",
			""Right click to fire a barrage of normal bullets""
		],
		""name"": ""Déchireur"",
		""tooltip"": [
			""La seule, l'unique, l'arme qui fait chuter les fps comme aucune autre"",
			""Tire un barrage de décharges d'énergie qui se divisent et rebondissent"",
			""Clic droit pour tirer un barrage de balles normales""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EpidemicShredder"",
		""type"": ""ITEM"",
		""englishName"": ""Epidemic Shredder"",
		""englishTooltip"": [
			""Contrary to its name, it will probably cause an epidemic if used incorrectly"",
			""Throws a plagued boomerang that releases plague seekers when it hits tiles or enemies"",
			""Stealth strikes cause the boomerang to release plague seekers constantly as it travels""
		],
		""name"": ""Déchireur d'Épidémie"",
		""tooltip"": [
			""Contrairement à ce que son nom laisse entendre, il va probablement déclencher une épidémie si vous l'utilisez de manière incorrecte"",
			""Lance un boomerang pestiféré qui relâche des cherches-peste quand il touche des tuiles ou des ennemis"",
			""Les attaques furtives font constamment relâcher des cherches-peste sur son trajet""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ScabRipper"",
		""type"": ""ITEM"",
		""englishName"": ""Scab Ripper"",
		""englishTooltip"": [
			""Summons a baby blood crawler to protect you""
		],
		""name"": ""Déchireur de Croûte"",
		""tooltip"": [
			""Invoque un rampant de sang pour vous protéger""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstrealDefeat"",
		""type"": ""ITEM"",
		""englishName"": ""Astreal Defeat"",
		""englishTooltip"": [
			""Ethereal bow of the tyrant king's mother"",
			""The mother strongly discouraged acts of violence throughout her life"",
			""Though she kept this bow close, to protect her family in times of great disaster"",
			""All arrows are converted to Astreal Arrows that emit flames as they travel""
		],
		""name"": ""Défaite Astrale"",
		""tooltip"": [
			""L'arc éthéré de la mère du roi tyran"",
			""La mère a fortement découragé les actes de violence au cours de sa vie"",
			""Bien qu'elle ait conservé cet arc proche d'elle pour protéger sa famille des évènements désastreux"",
			""Toutes les flèches sont converties en flèches astrales qui émettent des flammes sur leurs trajectoires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SanguineFlare"",
		""type"": ""ITEM"",
		""englishName"": ""Sanguine Flare"",
		""englishTooltip"": [
			""Fires a blast of sanguine flares that drain enemy life""
		],
		""name"": ""Déflagration Sanguine"",
		""tooltip"": [
			""Tire une déflagration de décharges sanguines qui draine la vie ennemie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SolarFlare"",
		""type"": ""ITEM"",
		""englishName"": ""Solar Flare"",
		""englishTooltip"": [
			""Emits large holy explosions on hit"",
			""A very agile yoyo""
		],
		""name"": ""Déflagration Solaire"",
		""tooltip"": [
			""Émet de larges explosions sacrées quand vous touchez"",
			""Un yoyo très agile""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Basher"",
		""type"": ""ITEM"",
		""englishName"": ""Basher"",
		""englishTooltip"": [
			""Inflicts irradiated on enemy hits""
		],
		""name"": ""Défonceur"",
		""tooltip"": [
			""Inflige l'irradiation quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PoleWarper"",
		""type"": ""ITEM"",
		""englishName"": ""Pole Warper"",
		""englishTooltip"": [
			""Magnetic devices which tear at foes by propelling themselves off their opposite counterparts"",
			""Incredibly dangerous"",
			""Summons a pair of floating magnets that repel each other and relentlessly swarm enemies""
		],
		""name"": ""Déformeur Magnétique"",
		""tooltip"": [
			""Engins magnétiques qui déchirent les ennemis en se propulsant grace à leur contrepartie opposée."",
			""Incroyablement dangeureux"",
			""Invoque une paire d'aimants flottants qui se repoussent l'un l'autre et submergent l'ennemi sans relâche""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Downpour"",
		""type"": ""ITEM"",
		""englishName"": ""Downpour"",
		""englishTooltip"": [
			""Fires a spray of water that drips extra trails of water""
		],
		""name"": ""Déluge"",
		""tooltip"": [
			""Tire de l'eau qui laisse de l'eau additionnelle dans son sillage""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GhoulishGouger"",
		""type"": ""ITEM"",
		""englishName"": ""Ghoulish Gouger"",
		""englishTooltip"": [
			""Throws sets of four ghoulish scythes at ultra high velocity"",
			""Stealth strikes summon a flurry of tormented souls on hit""
		],
		""name"": ""Désengorgeur Macabre"",
		""tooltip"": [
			""Lance quatre faux macabres à ultra-haute vélocité"",
			""Les attaques furtives font apparaître un myriade d'âmes torturées quand elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DragonbloodDisgorger"",
		""type"": ""ITEM"",
		""englishName"": ""Dragonblood Disgorger"",
		""englishTooltip"": [
			""Summons a skeletal dragon and her two children"",
			""Requires 6 minion slots to be summoned"",
			""There can only be one family""
		],
		""name"": ""Désengorgeur de Sang Draconique"",
		""tooltip"": [
			""Invoque un dragon squelettique et ses deux enfants"",
			""Occupe 6 emplacements de sbires"",
			""il ne peut y avoir qu'une famille""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Devastation"",
		""type"": ""ITEM"",
		""englishName"": ""Devastation"",
		""englishTooltip"": [
			""Fires galaxy blasts that explode""
		],
		""name"": ""Dévastation"",
		""tooltip"": [
			""Tire des décharges de galaxie qui explosent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DevilsDevastation"",
		""type"": ""ITEM"",
		""englishName"": ""Devil's Devastation"",
		""englishTooltip"": [
			""Fires a spread of demonic scythes"",
			""Pitchforks rise from the underworld to skewer your foes"",
			""Critical hits cause shadowflame explosions""
		],
		""name"": ""Dévastation du Diable"",
		""tooltip"": [
			""Tire un éventail de faux démoniaques"",
			""Des fourches se soulèvent des enfers pour empaler vos ennemis"",
			""Les coups critiques déclenchent des explosions d'ombreflamme""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ThiefsDime"",
		""type"": ""ITEM"",
		""englishName"": ""Thief's Dime"",
		""englishTooltip"": [
			""Those scurvy dogs don’t know the first thing about making bank"",
			""Summons a coin that revolves around you and steals money from enemies""
		],
		""name"": ""Dîme du Voleur"",
		""tooltip"": [
			""Ces vils chiens n'y connaissent rien quand il s'agit de faire de l'argent"",
			""Invoque une pièce qui tourne autour de vous et vole de l'argent aux ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ConsecratedWater"",
		""type"": ""ITEM"",
		""englishName"": ""Consecrated Water"",
		""englishTooltip"": [
			""The bottle is surprisingly dusty"",
			""Throws a holy flask of water that explodes into a sacred flame pillar on death"",
			""The pillar is destroyed if there's no tiles below it"",
			""Stealth strikes create three flame pillars instead of one on impact""
		],
		""name"": ""Eau Consacrée"",
		""tooltip"": [
			""Cette bouteille est surprenamment"",
			""Jette une flasque d'eau sacrée qui explose en un pilier de flammes sacrées"",
			""Le pilier est détruit si il n'y a pas de tuiles en dessous"",
			""Les attaques furtives créent trois piliers""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DesecratedWater"",
		""type"": ""ITEM"",
		""englishName"": ""Desecrated Water"",
		""englishTooltip"": [
			""Throws an unholy flask of water that explodes into an explosion of bubbles on death"",
			""Stealth strikes spawn additional bubbles that inflict Ichor and Cursed Inferno""
		],
		""name"": ""Eau Désacralisée"",
		""tooltip"": [
			""Jette un fiole d'eau impie qui explose en une explosion de bulles"",
			""Les attaques furtives créent des bulles additionnelles qui infligent l'ichor et les flammes maudites""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StarStruckWater"",
		""type"": ""ITEM"",
		""englishName"": ""Star Struck Water"",
		""englishTooltip"": [
			""Spreads the astral infection to some blocks""
		],
		""name"": ""Eau Frappé par les Étoiles"",
		""tooltip"": [
			""Répand l'infection astrale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodBoiler"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Boiler"",
		""englishTooltip"": [
			""Fires a stream of lifestealing bloodfire"",
			""Uses your health as ammo"",
			""25% chance to not consume ammo""
		],
		""name"": ""Ebouillanteur de Sang"",
		""tooltip"": [
			""Tire un faisceau de feu sanglant qui vole de la vie"",
			""Utilise votre vie comme munitions"",
			""25% de chances de ne pas consommer de munitions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodSample"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Sample"",
		""name"": ""Echantillon de Sang"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EvasionScarf"",
		""type"": ""ITEM"",
		""englishName"": ""Evasion Scarf"",
		""englishTooltip"": [
			""True melee strikes deal 15% more damage"",
			""Grants the ability to dash; dashing into an attack will cause you to dodge it"",
			""After a successful dodge you must wait 30 seconds before you can dodge again""
		],
		""name"": ""Echarpe d'Evasion"",
		""tooltip"": [
			""Les attaques de vraie mêlée font 15% de dégâts supplémentaires"",
			""Donne la possibilité de foncer, foncer dans une attaque vous permettra de l'esquiver"",
			""Après une esquive réussie, vous devez attendre 13s avant de pouvoir esquiver de nouveau"",
			""Ce temps de recharge est doublé si vous subissez le Chaos"",
			""Durant le temps de recharge, le Chaos dure 50% plus longtemps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CounterScarf"",
		""type"": ""ITEM"",
		""englishName"": ""Counter Scarf"",
		""englishTooltip"": [
			""True melee strikes deal 10% more damage"",
			""Grants the ability to dash; dashing into an attack will cause you to dodge it"",
			""After a successful dodge you must wait 30 seconds before you can dodge again""
		],
		""name"": ""Echarpe de Contre"",
		""tooltip"": [
			""Les attaques de vraie mêlée font 10% de dégâts supplémentaires"",
			""Donne la possibilité de foncer, foncer dans une attaque vous permettra de l'esquiver"",
			""Après une esquive réussie, vous devez attendre 15s avant de pouvoir esquiver de nouveau"",
			""Ce temps de recharge est doublé si vous subissez le Chaos"",
			""Durant le temps de recharge, le Chaos dure deux fois plus longtemps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodyWormScarf"",
		""type"": ""ITEM"",
		""englishName"": ""Bloody Worm Scarf"",
		""englishTooltip"": [
			""7% increased damage reduction"",
			""7% increased melee damage and speed""
		],
		""name"": ""Echarpe de Ver Sanglant"",
		""tooltip"": [
			""10% de réduction de dégâts et d'augmentation des statistiques de corps à corps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Popo"",
		""type"": ""ITEM"",
		""englishName"": ""Magic Scarf and Hat"",
		""englishTooltip"": [
			""Don't let the demons steal your nose"",
			""Transforms the holder into a snowman""
		],
		""name"": ""Echarpe et Chapeau Magique"",
		""tooltip"": [
			""Ne laisse pas les démons te voler ton nez!"",
			""Vous transforme en bonhomme de neige""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Ectoheart"",
		""type"": ""ITEM"",
		""englishName"": ""Ectoheart"",
		""englishTooltip"": [
			""Permanently increases Adrenaline Mode damage by 15% and damage reduction by 5%"",
			""Revengeance drop""
		],
		""name"": ""Ectocoeur"",
		""tooltip"": [
			""Augmente de façon permanente les dégâts de 15% et la réduction de dégâts de 5% du mode Adrenaline"",
			""Revengeance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Effervescence"",
		""type"": ""ITEM"",
		""englishName"": ""Effervescence"",
		""englishTooltip"": [
			""Shoots a massive spread of bubbles""
		],
		""name"": ""Effervescence"",
		""tooltip"": [
			""Tire une étendue massive de bulles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CrimsonEffigy"",
		""type"": ""ITEM"",
		""englishName"": ""Crimson Effigy"",
		""englishTooltip"": [
			""When placed down nearby players have their damage increased by 15% and defense by 10"",
			""Nearby players also suffer a 10% decrease to their maximum health""
		],
		""name"": ""Effigie Carmin"",
		""tooltip"": [
			""Quand elle est placée, les joueurs proches voient leur dégâts augmenter de 15% et leur défense de 10"",
			""Les joueurs proches souffrent également d'une réduction de leur vie maximum de 10%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CorruptionEffigy"",
		""type"": ""ITEM"",
		""englishName"": ""Corruption Effigy"",
		""englishTooltip"": [
			""When placed down, nearby players have their movement speed and crit chance increased by 10%"",
			""Nearby players also suffer a 5% decrease to their damage reduction""
		],
		""name"": ""Effigie de Corruption"",
		""tooltip"": [
			""Quand elle est placée, les joueurs proches voient leur vitesse de mouvement et leurs chances de coup critique augmentées de 10%"",
			""Les joueurs proches soufrent également d'une diminution de 5% de leur réduction de dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EffigyOfDecay"",
		""type"": ""ITEM"",
		""englishName"": ""Effigy of Decay"",
		""englishTooltip"": [
			""When placed down, nearby players can breathe underwater"",
			""This effect does not work in the abyss"",
			""Nearby players are also immune to the sulphuric poisoning""
		],
		""name"": ""Effigie de Décomposition"",
		""tooltip"": [
			""Quand elle est placée, les joueurs proches peuvent respirer sous l'eau"",
			""Cet effet ne fonctionne pas dans les abysses"",
			""Les joueurs proches sont aussi immunisés à l'empoisonnement sulfurique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MagneticMeltdown"",
		""type"": ""ITEM"",
		""englishName"": ""Magnetic Meltdown"",
		""englishTooltip"": [
			""Launches a diamond cross of supercharged magnet spheres""
		],
		""name"": ""Effondrement Magnétique"",
		""tooltip"": [
			""Lance une croix diamentée de sphères magnétiques superchargées""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AsgardianAegis"",
		""type"": ""ITEM"",
		""englishName"": ""Asgardian Aegis"",
		""englishTooltip"": [
			""Grants immunity to knockback"",
			""Immune to most debuffs"",
			""+40 max life and increased life regeneration"",
			""Grants a supreme holy flame dash"",
			""Can be used to ram enemies"",
			""TOOLTIP LINE HERE"",
			""Activating this buff will reduce your movement speed and increase enemy aggro"",
			""+20 defense while submerged in liquid""
		],
		""name"": ""Egide Asgardienne"",
		""tooltip"": [
			""Immunisé contre le recul"",
			""Immunisé à la plupart des altérations"",
			""+40 vie maximum et régénération de vie augmentée"",
			""Accorde une ruée suprême de flammes sacrées"",
			""Vous pouvez foncer sur les ennemis"",
			""TOOLTIP LINE HERE"",
			""Activer cet effet réduira votre mouvement et augmentera l'aggressivité des ennemis"",
			""+20 défense quand vous êtes immergé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElysianAegis"",
		""type"": ""ITEM"",
		""englishName"": ""Elysian Aegis"",
		""englishTooltip"": [
			""Blessed by the Profaned Flame"",
			""Grants immunity to knockback and the Burning, On Fire!, and Holy Flames debuffs"",
			""+30 max life"",
			""Grants a supreme holy flame dash"",
			""Can be used to ram enemies"",
			""TOOLTIP LINE HERE"",
			""Activating this buff will reduce your movement speed and increase enemy aggro""
		],
		""name"": ""Egide Elysienne"",
		""tooltip"": [
			""Bénie par la flamme profanée"",
			""Immunise au feu, à la brûlure, au recul et au flammes sacrés"",
			""+30 vie maximum"",
			""Accorde une ruée de flamme sacrée suprême"",
			""Vous pouvez foncer sur les ennemis"",
			""TOOLTIP LINE HERE"",
			""Activer cet effet réduira votre vitesse de déplacement et augmentera l'aggressivité des ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DraconicElixir"",
		""type"": ""ITEM"",
		""englishName"": ""Draconic Elixir"",
		""englishTooltip"": [
			""Greatly increases wing flight time and speed and increases defense by 16"",
			""Silva invincibility heals you to half HP when triggered"",
			""If you trigger the above heal you cannot drink this potion again for 60 seconds and you gain 30 seconds of potion sickness""
		],
		""name"": ""Elixir Draconique"",
		""tooltip"": [
			""Augmente grandement le temps et la vitesse de vol et augmente la défense de 16"",
			""L'invincibilité Silva vous rends la moitié de vos points de vie lorsqu'elle est déclenchée"",
			""Si cet effet se déclenche, vous ne pouvez pas boire cette potion à nouveau durant 60s et inflige Potion affaiblie pendant 30s""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WifeinaBottlewithBoobs"",
		""type"": ""ITEM"",
		""englishName"": ""Rare Elemental in a Bottle"",
		""englishTooltip"": [
			""Summons a sand elemental to heal you"",
			"";D""
		],
		""name"": ""Elémentaire Précieux en Bouteille"",
		""tooltip"": [
			""Invoque un élémentaire de sable pour vous soigner"",
			"";D""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WifeinaBottle"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental in a Bottle"",
		""englishTooltip"": [
			""Summons a sand elemental to fight for you""
		],
		""name"": ""Elémentaire en Bouteille"",
		""tooltip"": [
			""Invoque un élémentaire de sable pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AquaticEmblem"",
		""type"": ""ITEM"",
		""englishName"": ""Aquatic Emblem"",
		""englishTooltip"": [
			""Most ocean enemies become friendly and provides waterbreathing"",
			""Being underwater slowly boosts your defense over time but also slows movement speed"",
			""The defense boost and movement speed reduction slowly vanish while outside of water"",
			""Maximum defense boost is 50, maximum movement speed reduction is 10%"",
			""Provides a small amount of light in the abyss"",
			""Moderately reduces breath loss in the abyss""
		],
		""name"": ""Emblème Aquatique"",
		""tooltip"": [
			""La plupart des ennemis aquatiques deviennent amicaux et vous permet de respirer sous l'eau"",
			""Être sous l'eau augmente petit à petit votre défense mais réduit vos mouvements"",
			""Cet effet disparaît progressivement une fois hors de l'eau"",
			""Au maximum, la défense est augmentée de 50 et le mouvement réduit de 10%"",
			""Donne un peu de lumière dans les abysses"",
			""Réduit modérément la perte de respiration dans les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RogueEmblem"",
		""type"": ""ITEM"",
		""englishName"": ""Rogue Emblem"",
		""englishTooltip"": [
			""15% increased rogue damage""
		],
		""name"": ""Emblème de voleur"",
		""tooltip"": [
			""+15% de dégâts de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""InsidiousImpaler"",
		""type"": ""ITEM"",
		""englishName"": ""Insidious Impaler"",
		""englishTooltip"": [
			""Fires a harpoon that sticks to enemies and explodes""
		],
		""name"": ""Empaleur Insidieux"",
		""tooltip"": [
			""Tire des harpons qui s'attachent aux ennemis et qui explosent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SepticSkewer"",
		""type"": ""ITEM"",
		""englishName"": ""Septic Skewer"",
		""englishTooltip"": [
			""Launches a spiky harpoon infested with toxins"",
			""Releases bacteria when returning to the player""
		],
		""name"": ""Empaleur Sceptique"",
		""tooltip"": [
			""Lance un harpon épineux infesté de toxines"",
			""Relâche des bactéries quand il revient au joueur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Endogenesis"",
		""type"": ""ITEM"",
		""englishName"": ""Endogenesis"",
		""englishTooltip"": [
			""Summons an ascended ice construct to protect you "",
			""Changes attack modes by resummoning or reusing the staff "",
			""The first mode makes it shoot sweeping lasers aimed at the enemy "",
			""The second mode sacrifices its limbs to shoot out homing projectiles "",
			""The third mode allows it to agressively tackle its enemies "",
			""The fourth mode makes the limbs function as endothermic flamethrowers "",
			""Requires 10 minion slots to be summoned "",
			""There can only be one "",
			""[c/B0FBFF:Ice puns not included]""
		],
		""name"": ""Endogénèse"",
		""tooltip"": [
			""Invoque un construct ascendant de glace pour vous protéger"",
			""Change de mode d'attaque quand il est réinvoqué ou que vous réutilisez le Bâton."",
			""Le premier mode tire un balayage de lasers vers les ennemis"",
			""Le deuxième mode sacrifie ses membres pour tirer des projectiles à tête chercheuse"",
			""Le troisième mode lui permet de charger agressivement ses ennemis"",
			""Le quatrième mode permet à ses membres de fonctionner comme des lances-flammes endothermiques"",
			""Nécessite 10 emplacements de sbires pour être invoqué"",
			""Il ne peut n'y en avoir qu'un seul"",
			""[c/B0FBFF:Blagues givrées non-incluses]""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EndothermicEnergy"",
		""type"": ""ITEM"",
		""englishName"": ""Endothermic Energy"",
		""englishTooltip"": [
			""Its deathly chill sucks the life from its surroundings""
		],
		""name"": ""Energie Endothermique"",
		""tooltip"": [
			""Son frisson macabre aspire la vie de ses environs""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HalleysInferno"",
		""type"": ""ITEM"",
		""englishName"": ""Halley's Inferno"",
		""englishTooltip"": [
			""Halley came sooner than expected"",
			""Fires a flaming comet"",
			""50% chance to not consume gel"",
			""Right click to zoom out""
		],
		""name"": ""Enfer de Halley"",
		""tooltip"": [
			""Halley est arrivée plus vite que prévu"",
			""Tire une comète enflamée"",
			""50% de chances de ne pas consommer de gel"",
			""Clic droit pour dézoomer""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Hellborn"",
		""type"": ""ITEM"",
		""englishName"": ""Hellborn"",
		""englishTooltip"": [
			""Fires a spread of 3 bullets"",
			""Converts musket balls into explosive bullets"",
			""Enemies that touch the gun while it's being fired trigger a massive explosion"",
			""After the explosion, this gun gains a massive boost to damage, fire rate and knockback for 10 seconds"",
			""These stat bonuses slowly decay over time""
		],
		""name"": ""Enfer-Né"",
		""tooltip"": [
			""Tire une étendue de 3 balles"",
			""Convertit les balles de mousquet en cartouches explosives"",
			""Les ennemis qui touchent l'arme alors qu'elle est en train de tirer déclenchent une explosion massive"",
			""Après cette explosion, cette arme gagne un bonus massif en dégâts, cadence de tir et en recul pendant 10s"",
			""Ces bonus se perdent au fur et à mesure""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AuroraBlazer"",
		""type"": ""ITEM"",
		""englishName"": ""Aurora Blazer"",
		""englishTooltip"": [
			""Spews astral flames that travel in a star-shaped patterns"",
			""60% chance to not consume gel""
		],
		""name"": ""Enflammeur d'Aurore"",
		""tooltip"": [
			""Crache des flammes astrales qui se répandent dans des formes d'étoiles"",
			""60% de chances de ne pas consommer de gel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SeashineSword"",
		""type"": ""ITEM"",
		""englishName"": ""Seashine Sword"",
		""englishTooltip"": [
			""Shoots an aqua sword beam""
		],
		""name"": ""Epée de Lueur Marine"",
		""tooltip"": [
			""Tire un rayon d'épée aquatique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Equanimity"",
		""type"": ""ITEM"",
		""englishName"": ""Equanimity"",
		""englishTooltip"": [
			""Throws a dark/light boomerang that confuses enemies"",
			""The boomerang will create light shards upon hitting enemies when thrown out, and will fire homing dark shards when returning"",
			""Stealth strikes cause the boomerang to create both dark and light shards whenever one type would be created""
		],
		""name"": ""Equanimité"",
		""tooltip"": [
			""Lance une boomerang de lumière/ténèbres qui rend les ennemis confus"",
			""Le boomerang créera des éclats de lumière quand il touchera les ennemis quand vous le lancez, et tirera des éclats de ténèbres quand il revient"",
			""Les attaques furtives créent les deux types d'éclats dans les deux circonstances""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DarklightGreatsword"",
		""type"": ""ITEM"",
		""englishName"": ""Darklight Greatsword"",
		""englishTooltip"": [
			""Fires darklight blades that split on death""
		],
		""name"": ""Espadon d'Ombrelumière"",
		""tooltip"": [
			""Tire des lames d'ombrelumière qui se divisent quand elles disparaîssent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GreatswordofBlah"",
		""type"": ""ITEM"",
		""englishName"": ""Greatsword of Blah"",
		""englishTooltip"": [
			""A pale white sword from a forgotten land"",
			""You can hear faint yet comforting whispers emanating from the blade"",
			""'No matter where you may be you are never alone"",
			""I shall always be at your side, my lord'"",
			""Fires a rainbow blade that emits rainbow rain on death for a time""
		],
		""name"": ""Espadon de Blah"",
		""tooltip"": [
			""Une épée blanc pâle d'une terre oubliée"",
			""Vous pouvez entendre des murmures faibles mais réconfortants qui émanent de la lame"",
			""'Peut importe ou vous puissiez être, vous ne serez jamais seul"",
			""Je serais toujours à vos côtés, mon seigneur'"",
			""Tire une lame arc-en-ciel qui émet une pluie arc-en-ciel à sa disparition pendant un moment""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GaelsGreatsword"",
		""type"": ""ITEM"",
		""englishName"": ""Gael's Greatsword"",
		""englishTooltip"": [
			""Hand it over, that thing. Your dark soul."",
			""First swing fires homing skulls"",
			""Second swing fires a giant, powerful skull"",
			""Third swing has no projectiles"",
			""Constantly generates rage when in use"",
			""Swings leave behind exploding blood trails when below 50% health"",
			""Replaces Rage Mode with an enormous barrage of skulls""
		],
		""name"": ""Espadon de Gaël"",
		""tooltip"": [
			""Donne moi la, cette chose, ton âme sombre."",
			""Le premier coup tire des crânes à tête chercheuse"",
			""Le deuxième tire un grand et puissant crâne"",
			""Le troisième coup inflige des dégâts massifs"",
			""Génère constamment de la rage quand tenu"",
			""Les coups laissent des trainées explosives de sang quand vous avez moins de 50% de vos points de vie"",
			""Remplace le mode Rage avec un énorme barrage de crânes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GreatswordofJudgement"",
		""type"": ""ITEM"",
		""englishName"": ""Greatsword of Judgement"",
		""englishTooltip"": [
			""A pale white sword from a forgotten land"",
			""You can hear faint yet comforting whispers emanating from the blade"",
			""'No matter where you may be you are never alone"",
			""I shall always be at your side, my lord'"",
			""Fires a white orb that emits white rain on death for a time""
		],
		""name"": ""Espadon du Jugement"",
		""tooltip"": [
			""Une épée blanc pâle d'une terre oubliée"",
			""Vous pouvez entendre des murmures faibles mais réconfortants qui émanent de la lame"",
			""'Peut importe ou vous puissiez être, vous ne serez jamais seul"",
			""Je serais toujours à vos côtés, mon seigneur'"",
			""Tire une orbe blanche qui émet de la pluie blanche quand elle disparaît pendant un moment""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Fabsol"",
		""type"": ""ITEM"",
		""englishName"": ""Princess Spirit in a Bottle"",
		""englishTooltip"": [
			""Summons the spirit of Cirrus, the Drunk Princess, in her alicorn form"",
			""Mounting will transform Cirrus, dismounting transforms her back""
		],
		""name"": ""Esprit de Princesse en Bouteille"",
		""tooltip"": [
			""Invoque l'esprit de Cirrus, La princesse îvre, dans sa forme d'Alicorn"",
			""Appeler la monture transformera Cirrus, la renvoyer la retransformera en son état initial""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""UnholyEssence"",
		""type"": ""ITEM"",
		""englishName"": ""Unholy Essence"",
		""englishTooltip"": [
			""The essence of profaned creatures""
		],
		""name"": ""Essence Profane"",
		""tooltip"": [
			""L'essence des créatures profanées""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AscendantSpiritEssence"",
		""type"": ""ITEM"",
		""englishName"": ""Ascendant Spirit Essence"",
		""englishTooltip"": [
			""A catalyst of the highest caliber formed by fusing powerful souls""
		],
		""name"": ""Essence d'Esprit Ascendant"",
		""tooltip"": [
			""Un catalyseur du plus haut calibre formé en fusionnant de puissantes âmes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EssenceofEleum"",
		""type"": ""ITEM"",
		""englishName"": ""Essence of Eleum"",
		""englishTooltip"": [
			""The essence of cold creatures""
		],
		""name"": ""Essence d'Éleum"",
		""tooltip"": [
			""L'essence des créatures du froid""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EssenceofChaos"",
		""type"": ""ITEM"",
		""englishName"": ""Essence of Chaos"",
		""englishTooltip"": [
			""The essence of chaotic creatures""
		],
		""name"": ""Essence de Chaos"",
		""tooltip"": [
			""L'essence des créatures chaotiques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NightmareFuel"",
		""type"": ""ITEM"",
		""englishName"": ""Nightmare Fuel"",
		""englishTooltip"": [
			""May drain your sanity""
		],
		""name"": ""Essence du Cauchemar"",
		""tooltip"": [
			""Peut drainer votre sanité""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Eternity"",
		""type"": ""ITEM"",
		""englishName"": ""Eternity"",
		""englishTooltip"": [
			""Hexes a possible nearby enemy, trapping them in a brilliant display of destruction"",
			""This line is modified in ModifyTooltips""
		],
		""name"": ""Eternité"",
		""tooltip"": [
			""Maudit les ennemis proches, les piégeant ainsi dans une brillante démonstration de destruction"",
			""This line is modified in ModifyTooltips""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AmidiasSpark"",
		""type"": ""ITEM"",
		""englishName"": ""Amidias' Spark"",
		""englishTooltip"": [
			""Taking damage releases a blast of sparks""
		],
		""name"": ""Etincelle d'Amidias"",
		""tooltip"": [
			""Prendre des dégâts provoque une décharge d'étincelles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Everclear"",
		""type"": ""ITEM"",
		""englishName"": ""Everclear"",
		""englishTooltip"": [
			""This is the most potent booze I have, be careful with it"",
			""Boosts damage by 25%"",
			""Reduces life regen by 10 and defense by 30%""
		],
		""name"": ""Everclear"",
		""tooltip"": [
			""Le plus puissant alcool que j'ai, fais attention avec ça"",
			""Augmente les dégâts de 25%"",
			""Réduit la régénération de vie de 10 et la défense de 30%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EvergreenGin"",
		""type"": ""ITEM"",
		""englishName"": ""Evergreen Gin"",
		""englishTooltip"": [
			""It tastes like a Christmas tree, if you can imagine that"",
			""Multiplies all sickness and water-related debuff damage by 1.25"",
			""Reduces life regen by 1""
		],
		""name"": ""Evergreen Gin"",
		""tooltip"": [
			""Ca a un goût de sapin de Noël, si tu arrives à imaginer quel goût ça a"",
			""Augmente les dégâts des altérations d'état liées à l'eau et à la maladie de 50% et la réduction des dégâts de 5%"",
			""Réduit la régénération de la vie de 1""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""IgneousExaltation"",
		""type"": ""ITEM"",
		""englishName"": ""Igneous Exaltation"",
		""englishTooltip"": [
			""Summons an orbiting blade"",
			""Right click to launch all blades towards the cursor""
		],
		""name"": ""Exaltation Ignée"",
		""tooltip"": [
			""Invoque une lame qui orbite autour de vous"",
			""Clic droit pour lancer toutes les lames en direction du curseur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElementalExcalibur"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Excalibur"",
		""englishTooltip"": [
			""Freezes enemies and heals the player on hit"",
			""Fires rainbow beams that change their behavior based on their color"",
			""Right click for true melee""
		],
		""name"": ""Excalibur Élémentaire"",
		""tooltip"": [
			""Gèle les ennemis et soigne le joueur quand elle touche"",
			""Tire des rayons arc-en-ciel qui changent de comportement en fonction de leur couleur"",
			""Clic droit pour attaquer en mêlée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Excelsus"",
		""type"": ""ITEM"",
		""englishName"": ""Excelsus"",
		""englishTooltip"": [
			""Fires a spread of spinning blades"",
			""Summons laser fountains on hit""
		],
		""name"": ""Excelsus"",
		""tooltip"": [
			""Tire une étendue de lames tournoyantes"",
			""Invoque des fontaines de lasers quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Exorcism"",
		""type"": ""ITEM"",
		""englishName"": ""Exorcism"",
		""englishTooltip"": [
			""Throws a hallowed cross which explodes into a flash of light that damages nearby enemies, closer enemies receiving more damage"",
			""As the cross travels downwards, the damage inflicted by both the cross and flash increases constantly"",
			""Stealth strikes cause the cross to be thrown with full damage immediately. Hallowed stars fall when the cross explodes""
		],
		""name"": ""Exorcisme"",
		""tooltip"": [
			""Jette une croix sacrée qui explose en un flash de lumière qui endommage les ennemis plus ils en sont proches"",
			""Quand la croix est en train de tomber, les dégâts infligés augmentent au fur et à mesure"",
			""Les attaques furtives maximisent les dégâts dès le lancer, et des étoiles sacrées tombent du ciel quand la croix explose""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EtherealExtorter"",
		""type"": ""ITEM"",
		""englishName"": ""Ethereal Extorter"",
		""englishTooltip"": [
			""Rogue projectiles explode into homing souls on death"",
			""10% increased rogue damage and +10 maximum stealth, however, life regen is reduced by 1""
		],
		""name"": ""Extorqueur Ethéré"",
		""tooltip"": [
			""Les projectiles de voleur explosent en âme à tête chercheuse"",
			""+10% de dégâts de voleur et +10 furtivité maximum mais régénération de vie réduite de 1""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""InfernalRift"",
		""type"": ""ITEM"",
		""englishName"": ""Infernal Rift"",
		""englishTooltip"": [
			""Summons infernal blades that spawn additional blades on enemy hits""
		],
		""name"": ""Faille Infernale"",
		""tooltip"": [
			""Invoque des lames infernales qui génèrent des lames supplémentaires quand vous touchez les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CelestialReaper"",
		""type"": ""ITEM"",
		""englishName"": ""Celestial Reaper"",
		""englishTooltip"": [
			""Throws a fast homing scythe"",
			""The scythe will bounce after hitting an enemy up to six times"",
			""Stealth strikes create damaging afterimages""
		],
		""name"": ""Faucheur Céleste"",
		""tooltip"": [
			""Lance une faux à tête chercheuse rapide"",
			""La faux rebondit après avoir touché un ennemi jusqu'a 6 fois"",
			""Les attaques furtives créent des images rémanentes qui infligent des dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralScythe"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Scythe"",
		""englishTooltip"": [
			""Shoots a scythe ring that accelerates over time""
		],
		""name"": ""Faux Astrale"",
		""tooltip"": [
			""Tire un anneau de faux qui accélère au fur et à mesure""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LifefruitScythe"",
		""type"": ""ITEM"",
		""englishName"": ""Lifehunt Scythe"",
		""englishTooltip"": [
			""Heals you on hit and shoots an energy scythe""
		],
		""name"": ""Faux Chasseuse de Vie"",
		""tooltip"": [
			""Vous soigne quand vous touchez les ennemis et tire une faux d'énergie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""UltimusCleaver"",
		""type"": ""ITEM"",
		""englishName"": ""Ultimus Cleaver"",
		""englishTooltip"": [
			""Launches damaging homing sparks and explodes on enemy hits""
		],
		""name"": ""Fendoir Ultimus"",
		""tooltip"": [
			""Lance des étincelles à tête chercheuse nocives et provoque une explosion quand il touche l'ennemi""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TeardropCleaver"",
		""type"": ""ITEM"",
		""englishName"": ""Teardrop Cleaver"",
		""englishTooltip"": [
			""Makes your enemies cry""
		],
		""name"": ""Fendoir de Larme"",
		""tooltip"": [
			""Fait pleurer vos ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StatMeter"",
		""type"": ""ITEM"",
		""englishName"": ""Stat Meter"",
		""englishTooltip"": [
			""Displays almost all player stats""
		],
		""name"": ""Fenètre de Statistiques"",
		""tooltip"": [
			""Montre presque toutes les statistiques du joueur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumShard"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Metal Scrap"",
		""name"": ""Ferraille de Wulfrum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrokenWaterFilter"",
		""type"": ""ITEM"",
		""englishName"": ""Broken Water Filter"",
		""englishTooltip"": [
			""Favorite this item to disable natural Acid Rain spawns""
		],
		""name"": ""Filtre à Eau Cassé"",
		""tooltip"": [
			""Favoriser cet objet pour empêcher la pluie acide d'arriver naturellement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TyrannysEnd"",
		""type"": ""ITEM"",
		""englishName"": ""Tyranny's End"",
		""englishTooltip"": [
			""Pierce the heart of even the most heavily-armored foe"",
			""Fires a .70 caliber sniper round that bypasses enemy defense and DR"",
			""Rounds mark enemies for death and summon a swarm of additional bullets on crits""
		],
		""name"": ""Fin de la Tyrannie"",
		""tooltip"": [
			""Transperce le coeur de même le plus blindé des ennemis"",
			""Tire une balle de sniper calibre .70 qui ignore la défense et la réduction des dégâts"",
			""Les balles désignent les ennemis pour mort et invoquent une nuée de balles additionnelles en cas de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Fireball"",
		""type"": ""ITEM"",
		""englishName"": ""Fireball"",
		""englishTooltip"": [
			""A great-tasting cinnamon whiskey"",
			""Multiplies all fire-based debuff damage by 1.25"",
			""Reduces life regen by 1""
		],
		""name"": ""Fireball"",
		""tooltip"": [
			""Un excellent whisky à la canelle"",
			""Augmente les dégâts des altérations liées au feu de 50%"",
			""Réduit la régénération de vie de 1""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HellfireFlamberge"",
		""type"": ""ITEM"",
		""englishName"": ""Hellfire Flamberge"",
		""englishTooltip"": [
			""Fires a spread of volcanic fireballs""
		],
		""name"": ""Flamberge de Feu Infernal"",
		""tooltip"": [
			""Tire une étendue de boules de feu volcanique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DaemonsFlame"",
		""type"": ""ITEM"",
		""englishName"": ""Daemon's Flame"",
		""englishTooltip"": [
			""Shoots daemon flame fireballs as well as 4 regular arrows""
		],
		""name"": ""Flame du Daemon"",
		""tooltip"": [
			""Tire des boules de feu du daemon en plus de 4 flèches normales""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FrostFlare"",
		""type"": ""ITEM"",
		""englishName"": ""Frost Flare"",
		""englishTooltip"": [
			""All melee attacks and projectiles inflict frostburn"",
			""Immunity to frostburn, chilled and frozen"",
			""Being above 75% life grants 10% increased damage"",
			""Being below 25% life grants 20 defense and 15% increased max movement speed and acceleration"",
			""Grants resistance against cold attacks""
		],
		""name"": ""Flamme Givrée"",
		""tooltip"": [
			""Toutes les attaques et les projectiles de corps à corps infligent brûlegivre"",
			""Immunité au brûlegivre, au refroidissement et au gel"",
			""Résistant aux attaques de gel"",
			""Être au dessus de 75% de vie augmente les dégâts de 10%"",
			""Être en dessous de 25% de vie augmente la défense de 20 et la vitesse de déplacement et d'accélération de 15%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CrimsonFlask"",
		""type"": ""ITEM"",
		""englishName"": ""Crimson Flask"",
		""englishTooltip"": [
			""4% increased damage reduction and +6 defense while in the crimson"",
			""Grants immunity to the Burning Blood debuff""
		],
		""name"": ""Flasque Carmin"",
		""tooltip"": [
			""7% de réduction des dégâts et +3 défense quand vous êtes dans le carmin""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BrackishFlask"",
		""type"": ""ITEM"",
		""englishName"": ""Brackish Flask"",
		""englishTooltip"": [
			""Explodes into poisonous seawater blasts"",
			""Stealth strikes summon a brackish spear spike""
		],
		""name"": ""Flasque Saumâtre"",
		""tooltip"": [
			""Explose en décharges d'eau de mer empoisonnée"",
			""Les attaques furtives invoquent un pique de lance saumâtre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AlchemicalFlask"",
		""type"": ""ITEM"",
		""englishName"": ""Alchemical Flask"",
		""englishTooltip"": [
			""All attacks inflict the Plague and grants immunity to the Plague"",
			""Projectiles spawn plague seekers on enemy hits""
		],
		""name"": ""Flasque alchémique"",
		""tooltip"": [
			""Toutes les attaques infligent la peste"",
			""Les projectiles génèrent des chercheurs de peste lorsque qu'ils touchent un ennemi""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CorruptFlask"",
		""type"": ""ITEM"",
		""englishName"": ""Corrupt Flask"",
		""englishTooltip"": [
			""4% increased damage reduction and +6 defense while in the corruption"",
			""Grants immunity to the Cursed Inferno debuff""
		],
		""name"": ""Flasque corrompue"",
		""tooltip"": [
			""7% de réduction des dégâts et +3 défense quand vous êtes dans la corruption""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ThornBlossom"",
		""type"": ""ITEM"",
		""englishName"": ""Thorn Blossom"",
		""englishTooltip"": [
			""Every rose has its thorn""
		],
		""name"": ""Floraison d'Épine"",
		""tooltip"": [
			""Chaque rose à ses épines""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BlossomFlux"",
		""type"": ""ITEM"",
		""englishName"": ""Blossom Flux"",
		""englishTooltip"": [
			""Fires a stream of leaves"",
			""Right click to fire a spore orb that explodes into a cloud of spore gas""
		],
		""name"": ""Flux Floral"",
		""tooltip"": [
			""Tire un torrent de feuilles"",
			""Clic droit pour tirer une orbe de spore qui explose en un nuage de spores""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ArcticArrow"",
		""type"": ""ITEM"",
		""englishName"": ""Arctic Arrow"",
		""englishTooltip"": [
			""Freezes enemies for a short time""
		],
		""name"": ""Flèche Arctique"",
		""tooltip"": [
			""Gèle les ennemis pour une courte durée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TerraArrow"",
		""type"": ""ITEM"",
		""englishName"": ""Terra Arrow"",
		""englishTooltip"": [
			""Travels incredibly quickly and explodes into more arrows when it hits a certain velocity""
		],
		""name"": ""Flèche Terra"",
		""tooltip"": [
			""Incroyablement rapide et explose en plus de flèche après avoir atteint une certaine vitesse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NapalmArrow"",
		""type"": ""ITEM"",
		""englishName"": ""Napalm Arrow"",
		""englishTooltip"": [
			""Explodes into fire shards""
		],
		""name"": ""Flèche de Napalm"",
		""tooltip"": [
			""Explose en éclats de feu""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodfireArrow"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodfire Arrow"",
		""englishTooltip"": [
			""Heals you a small amount on enemy hits""
		],
		""name"": ""Flèche de Sang de Feu"",
		""tooltip"": [
			""Vous soigne un peu quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""IcicleArrow"",
		""type"": ""ITEM"",
		""englishName"": ""Icicle Arrow"",
		""englishTooltip"": [
			""Shatters into shards on impact""
		],
		""name"": ""Flèche de Stalactite"",
		""tooltip"": [
			""Se brise en morceaux à l'impact""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VanquisherArrow"",
		""type"": ""ITEM"",
		""englishName"": ""Vanquisher Arrow"",
		""englishTooltip"": [
			""Pierces through tiles"",
			""Spawns extra homing arrows as it travels""
		],
		""name"": ""Flèche du Vainqueur"",
		""tooltip"": [
			""Traverse les tuiles"",
			""Crée des flèches à tête chercheuse sur sa trajectoire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElysianArrow"",
		""type"": ""ITEM"",
		""englishName"": ""Elysian Arrow"",
		""englishTooltip"": [
			""Summons meteors from the sky on death""
		],
		""name"": ""Flèche Élysienne"",
		""tooltip"": [
			""Invoque des météores depuis le ciel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeAquaticScourge"",
		""type"": ""ITEM"",
		""englishName"": ""Aquatic Scourge"",
		""englishTooltip"": [
			""A horror born of pollution and insatiable hunger; based on size alone this was merely a juvenile."",
			""These scourge creatures are the largest aquatic predators and very rarely do they frequent such shallow waters.""
		],
		""name"": ""Fléau Aquatique"",
		""tooltip"": [
			""Une horreur née de la pollution et d'une faim insatiable; Au vu de sa taille, on peut supposer qu'il ne s'agissait que d'un jeune spécimen."",
			""Ces fléaux sont les plus grands prédateurs aquatique et c'est très rare qu'ils fréquentent des eaux si peu profondes.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""UrchinFlail"",
		""type"": ""ITEM"",
		""englishName"": ""Urchin Flail"",
		""englishTooltip"": [
			""Launch an urchin ball, which shoots a spike on contact with an enemy""
		],
		""name"": ""Fléau Oursin"",
		""tooltip"": [
			""Lance une boule oursin, qui tire des pics au contact des ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ScourgeoftheSeas"",
		""type"": ""ITEM"",
		""englishName"": ""Scourge of the Seas"",
		""englishTooltip"": [
			""Snaps apart into a venomous cloud upon striking an enemy"",
			""Stealth strikes are coated with vile toxins, afflicting enemies with a powerful debuff""
		],
		""name"": ""Fléau des Mers"",
		""tooltip"": [
			""Se désagrège en un nuage de venin quand il touche un ennemi"",
			""Les attaques furtives sont enduites de toxines viles, qui infligera aux ennemis une puissante altération d'état""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ScourgeoftheCosmos"",
		""type"": ""ITEM"",
		""englishName"": ""Scourge of the Cosmos"",
		""englishTooltip"": [
			""Throws a bouncing cosmic scourge that emits tiny homing cosmic scourges on death and tile hits""
		],
		""name"": ""Fléau du Cosmos"",
		""tooltip"": [
			""Lance un fléau du cosmos rebondissant qui émet des fléaux miniatures à tête chercheuse quand il rebondit""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ScourgeoftheDesert"",
		""type"": ""ITEM"",
		""englishName"": ""Scourge of the Desert"",
		""englishTooltip"": [
			""Gains velocity over time"",
			""Stealth strikes gain damage as they damage enemies""
		],
		""name"": ""Fléau du Désert"",
		""tooltip"": [
			""Gagne en vitesse au fur et à mesure"",
			""Les attaques furtives augmentent leur dégâts à chaque fois qu'elles en infligent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SystemBane"",
		""type"": ""ITEM"",
		""englishName"": ""System Bane"",
		""englishTooltip"": [
			""Can be used to quickly send out an electromagnetic blast"",
			""Hurls an unstable device which sticks to the ground and shocks nearby enemies with lightning"",
			""Stealth strikes make the device emit a large, damaging EMP field""
		],
		""name"": ""Fléau du Système"",
		""tooltip"": [
			""Peut être utilisé pour rapidement envoyer une décharge électromagnétique"",
			""Envoie un appareil instable qui s'attache au sol et choque les ennemis proches avec de l'électricité"",
			""Les attaques furtives font émettre un champ électromagnétique a l'appareil, qui inflige des dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GelDart"",
		""type"": ""ITEM"",
		""englishName"": ""Gel Dart"",
		""englishTooltip"": [
			""Throws bouncing darts"",
			""Stealth strikes ignore gravity and bounce more vigorously"",
			""They additionally leak slime and cover enemies in dark sludge""
		],
		""name"": ""Fléchette de Gelée"",
		""tooltip"": [
			""Lance des fléchettes rebondissantes"",
			""Les attaques furtives ignorent la gravité et rebondissent plus vigoureusement"",
			""Elles font également fuiter de la gelée et couvrent les ennemis de boue sombre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TarragonThrowingDart"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Throwing Dart"",
		""englishTooltip"": [
			""Fires a piercing dart with reduced immunity frames"",
			""Stealth strikes erupt into thorns on enemy hits""
		],
		""name"": ""Fléchette de Lancer d'Estragon"",
		""tooltip"": [
			""Tire une fléchette d'Estragon qui ignore une partie de la période d'invulnérabilité"",
			""Les attaques furtives provoquent une éruption d'épines quand elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MonkeyDarts"",
		""type"": ""ITEM"",
		""englishName"": ""Monkey Darts"",
		""englishTooltip"": [
			""Stealth strikes throw 3 bouncing darts at high speed"",
			""'Perfect for popping'""
		],
		""name"": ""Fléchettes de Singe"",
		""tooltip"": [
			""Les attaques furtives jettent 3 fléchettes rebondissantes à haute vitesse"",
			""'Parfait pour faire caca'""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FaceMelter"",
		""type"": ""ITEM"",
		""englishName"": ""Face Melter"",
		""englishTooltip"": [
			""WOOO!! FAAAAAAANTASYY WORLDDDDD!"",
			""Fires music notes"",
			""Right click summons an amplifier that shoots towards your mouse""
		],
		""name"": ""Fondeur de Visage"",
		""tooltip"": [
			""WOOO!! LE MOOOOONDE DE LA FAAAANTAIIIIISIE!"",
			""Tire des notes de musique"",
			""Clic droit pour invoquer un amplifieur qui tire également des notes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Fungicide"",
		""type"": ""ITEM"",
		""englishName"": ""Fungicide"",
		""englishTooltip"": [
			""Converts musket balls into fungal rounds that split on death""
		],
		""name"": ""Fongicide"",
		""tooltip"": [
			""Convertit les balles de mousquet en cartouches fongiques qui se divisent à la disparition""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssFountainItem"",
		""type"": ""ITEM"",
		""englishName"": ""Abyss Water Fountain"",
		""name"": ""Fontaine d'Eau Abyssale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralFountainItem"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Water Fountain"",
		""name"": ""Fontaine d'Eau Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SunkenSeaFountain"",
		""type"": ""ITEM"",
		""englishName"": ""Sunken Water Fountain"",
		""name"": ""Fontaine d'Eau Coulée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SulphurousFountainItem"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphuric Water Fountain"",
		""name"": ""Fontaine d'Eau Sulfurique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Galeforce"",
		""type"": ""ITEM"",
		""englishName"": ""Galeforce"",
		""englishTooltip"": [
			""Fires a spread of low-damage feathers""
		],
		""name"": ""Force du Vent"",
		""tooltip"": [
			""Tire une volée de faibles plumes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DraedonsForge"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon's Forge"",
		""englishTooltip"": [
			""A plasma-lattice nanoforge powered by limitless Exo energies"",
			""Functions as every major crafting station simultaneously""
		],
		""name"": ""Forge de Draedon"",
		""tooltip"": [
			""Une nanoforge entrelacée de plasma alimentée par des exo-énergies sans limites"",
			""Rempli les fonctions de toutes les stations de fabrication majeures simultanément""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AncientFossil"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient Fossil"",
		""englishTooltip"": [
			""Increases pick speed by 15% while underground""
		],
		""name"": ""Fossile Ancien"",
		""tooltip"": [
			""Augmente la vitesse de pioche de 15% quand vous êtes sous terre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CorrodedFossil"",
		""type"": ""ITEM"",
		""englishName"": ""Corroded Fossil"",
		""englishTooltip"": [
			""It's very sturdy""
		],
		""name"": ""Fossile Corodé"",
		""tooltip"": [
			""C'est très solide!""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Brimlash"",
		""type"": ""ITEM"",
		""englishName"": ""Brimlash"",
		""englishTooltip"": [
			""Fires a brimstone bolt that explodes into more bolts on death""
		],
		""name"": ""Fouette-Soufre"",
		""tooltip"": [
			""Tire une décharge de soufre qui explose en plus de décharges""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CharredLasher"",
		""type"": ""ITEM"",
		""englishName"": ""Charred Lasher"",
		""englishTooltip"": [
			""This elusive fish is a prized commodity""
		],
		""name"": ""Fouetteur Calciné"",
		""tooltip"": [
			""Ce poisson insaisissable est une marchandise prisée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SilencingSheath"",
		""type"": ""ITEM"",
		""englishName"": ""Silencing Sheath"",
		""englishTooltip"": [
			""+20 maximum stealth"",
			""Stealth generates 15% faster""
		],
		""name"": ""Fourreau Silencieux"",
		""tooltip"": [
			""+20 furtivité maximum"",
			""La furtivité se génère 15% plus rapidement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DarkGodsSheath"",
		""type"": ""ITEM"",
		""englishName"": ""Dark God's Sheath"",
		""englishTooltip"": [
			""+20 maximum stealth"",
			""Mobile stealth generation accelerates while not attacking"",
			""Stealth strikes have a 100% critical hit chance"",
			""Stealth strikes only expend 50% of your max stealth"",
			""6% increased rogue damage, and 6% increased rogue crit chance""
		],
		""name"": ""Fourreau du Dieu Sombre"",
		""tooltip"": [
			""+20 de furtivité maximum"",
			""La génération de furtivité lorsque vous êtes en mouvement est augmentée"",
			""Les attaques furtives ont 100% de chances de coup critique"",
			""Les coups critiques ne consomment que la moitié de votre furtivité"",
			""6% des dégâts et de chances de coup critique supplémentaires pour les dégâts de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HellcasterFragment"",
		""type"": ""ITEM"",
		""englishName"": ""Yharon Soul Fragment"",
		""englishTooltip"": [
			""A shard of a godly soul""
		],
		""name"": ""Fragment d'Âme de Yharon"",
		""tooltip"": [
			""Un fragment d'âme divine""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DarksunFragment"",
		""type"": ""ITEM"",
		""englishName"": ""Darksun Fragment"",
		""englishTooltip"": [
			""An impacted crystal suffused with opposing celestial energies""
		],
		""name"": ""Fragment de Sombresoleil"",
		""tooltip"": [
			""Un fragment d'énergie infusé d'énergies célestes opposées""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VictoryShard"",
		""type"": ""ITEM"",
		""englishName"": ""Victory Shard"",
		""name"": ""Fragment de Victoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LivingShard"",
		""type"": ""ITEM"",
		""englishName"": ""Living Shard"",
		""name"": ""Fragment vivant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""IronFrancisca"",
		""type"": ""ITEM"",
		""englishName"": ""Iron Francisca"",
		""englishTooltip"": [
			""The franciscas do more damage for a short time when initially thrown"",
			""Stealth strikes pierce infinitely""
		],
		""name"": ""Francisque de Fer"",
		""tooltip"": [
			""Les francisques font plus de dégâts un court moment après leur lancer"",
			""Les attaques furtives percent indéfiniment""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LuminousStriker"",
		""type"": ""ITEM"",
		""englishName"": ""Luminous Striker"",
		""englishTooltip"": [
			""Send the stars back to where they belong"",
			""Throws a stardust javelin trailed by rising stardust shards"",
			""Explodes into additional stardust shards upon hitting enemies"",
			""Stealth strikes cause the stardust shards to fly alongside the javelin instead of rising""
		],
		""name"": ""Frappeur Lumineux"",
		""tooltip"": [
			""Renvoie les étoiles à leur place"",
			""Lance un javelot de poussière d'étoile suivi d'une trainée d'éclats de poussière d'étoile montant"",
			""Explose en davantage d'éclats de poussière d'étoile quand vous touchez"",
			""Les attaques furtives font en sorte que les éclats suivent le javelot au lieu de monter""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MagnaStriker"",
		""type"": ""ITEM"",
		""englishName"": ""Magna Striker"",
		""englishTooltip"": [
			""Fires a string of opal and magna strikes""
		],
		""name"": ""Frappeur Magna"",
		""tooltip"": [
			""Tire une chaîne d'opales et de frappes magna""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StellarStriker"",
		""type"": ""ITEM"",
		""englishName"": ""Stellar Striker"",
		""englishTooltip"": [
			""Summons a swarm of lunar flares from the sky on enemy hits""
		],
		""name"": ""Frappeur Stellaire"",
		""tooltip"": [
			""Invoque une nuée de lueurs stellaires depuis le ciel quand vous frappez les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WavePounder"",
		""type"": ""ITEM"",
		""englishName"": ""Wave Pounder"",
		""englishTooltip"": [
			""It utilizes its power to send heavy shockwaves throughout the area, causing agonizing internal damage"",
			""Throws a bomb which explodes into a forceful shockwave"",
			""Stealth strikes emit absurdly powerful shockwaves""
		],
		""name"": ""Frappeur d'Ondes"",
		""tooltip"": [
			""Il utilise son pouvoir pour envoyer de lourdes ondes de choc dans la zone, infligeant d'agonisant dégâts internes."",
			""Envoie une bombe qui explose en une onde de choc ultraforte"",
			""Les attaques furtives ont une puissance absurde""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OpalStriker"",
		""type"": ""ITEM"",
		""englishName"": ""Opal Striker"",
		""englishTooltip"": [
			""Fires a string of opal strikes""
		],
		""name"": ""Frappeur d'Opale"",
		""tooltip"": [
			""Tire une chaine de frappes d'opale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MiracleFruit"",
		""type"": ""ITEM"",
		""englishName"": ""Miracle Fruit"",
		""englishTooltip"": [
			""Refreshing and cool, perhaps even a bit minty"",
			""Permanently increases maximum life by 25"",
			""Can only be used if the max amount of life fruit has been consumed""
		],
		""name"": ""Fruit Miraculeux"",
		""tooltip"": [
			""Rafraîchissant et frais, avec une petite pointe de menthe"",
			""Augmente de 25 la vie maximum de façon définitive"",
			""Peut seulement être utilisée si le montant maximal de fruit de vie a été consommé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Seafood"",
		""type"": ""ITEM"",
		""englishName"": ""Seafood"",
		""englishTooltip"": [
			""Summons the Aquatic Scourge when used in the sulphur sea"",
			""Not consumable""
		],
		""name"": ""Fruit de Mer"",
		""tooltip"": [
			""Invoque le Fléau Aquatique quand utilisé dans la mer sulfurique"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SeasSearing"",
		""type"": ""ITEM"",
		""englishName"": ""Sea's Searing"",
		""englishTooltip"": [
			""Fires a string of bubbles summoning a shower of bubbles on hit"",
			""Right click to fire a slower, larger water blast that summons a water spout""
		],
		""name"": ""Fulgurance de la Mer"",
		""tooltip"": [
			""Tire une chaîne de bulles provoquant une pluie de bulles quand elles touchent"",
			""Clic droit pour tirer une plus grande et plus lente décharge d'eau qui invoque un jet d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NuclearFury"",
		""type"": ""ITEM"",
		""englishName"": ""Nuclear Fury"",
		""englishTooltip"": [
			""Casts a torrent of cosmic typhoons""
		],
		""name"": ""Fureur Nucléaire"",
		""tooltip"": [
			""Convoque un torrent de typhons cosmiques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PristineFury"",
		""type"": ""ITEM"",
		""englishName"": ""Pristine Fury"",
		""englishTooltip"": [
			""Fires an intense helix of flames that explode into a column of fire"",
			""Right click to fire a short ranged cloud of lingering flames""
		],
		""name"": ""Fureur Pristine"",
		""tooltip"": [
			""Tire une intense spirale de flammes qui explosent en colonnes de feu"",
			""Clic droit pour tirer un nuage de flammes rémanentes à courte portée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimstoneFury"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Fury"",
		""englishTooltip"": [
			""Converts wooden arrows into spreads of 3 brimstone bolts""
		],
		""name"": ""Fureur de Soufre"",
		""tooltip"": [
			""Convertit les flèches en bois en une volée de 3 décharges de soufre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PhantasmalFury"",
		""type"": ""ITEM"",
		""englishName"": ""Phantasmal Fury"",
		""englishTooltip"": [
			""Casts a phantasmal bolt that explodes into more bolts""
		],
		""name"": ""Furie Fantasmagorique"",
		""tooltip"": [
			""Tire une décharge fantasmagorique qui explose en plusieurs décharges""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WintersFury"",
		""type"": ""ITEM"",
		""englishName"": ""Winter's Fury"",
		""englishTooltip"": [
			""The pages are freezing to the touch""
		],
		""name"": ""Furie de l'Hiver"",
		""tooltip"": [
			""Les pages sont glaçantes au toucher""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BarracudaGun"",
		""type"": ""ITEM"",
		""englishName"": ""Barracuda Gun"",
		""englishTooltip"": [
			""Fires two barracudas that latch onto enemies""
		],
		""name"": ""Fusil Barracuda"",
		""tooltip"": [
			""Tire deux barracudas qui se fixent aux ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GaussRifle"",
		""type"": ""ITEM"",
		""englishName"": ""Gauss Rifle"",
		""englishTooltip"": [
			""A large and slow weapon, the concussive force of its projectiles do well in clearing large groups"",
			""Fires a devastating high velocity blast with absurd knockback""
		],
		""name"": ""Fusil Gauss"",
		""tooltip"": [
			""Une arme lente et encombrante, la force concussive de ses projectiles est efficace pour nettoyer les groupes nombreux"",
			""Tire une décharge à haute vélocité dévastatrice d'un recul absurde""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SpectreRifle"",
		""type"": ""ITEM"",
		""englishName"": ""Spectre Rifle"",
		""englishTooltip"": [
			""Converts musket balls into powerful homing souls""
		],
		""name"": ""Fusil Spectral"",
		""tooltip"": [
			""Convertit les balles de mousquet en puissantes âmes à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ClamorRifle"",
		""type"": ""ITEM"",
		""englishName"": ""Clamor Rifle"",
		""englishTooltip"": [
			""Converts musket balls into homing energy bolts""
		],
		""name"": ""Fusil de Clameur"",
		""tooltip"": [
			""Convertit les balles de mousquet en décharges d'énergie à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PulseRifle"",
		""type"": ""ITEM"",
		""englishName"": ""Pulse Rifle"",
		""englishTooltip"": [
			""Draedon's former pulse rifle, used in emergencies for creations which turned against him"",
			""When the pulse hits a target it will arc to another nearby target""
		],
		""name"": ""Fusil à Impulsion"",
		""tooltip"": [
			""L'ancien fusil à impulsion de Dreadon, utilisé en cas d'urgence quand ses créations se retournent contre lui"",
			""Quand l'impulsion touche une cible, elle s'infléchira vers une autre cible""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlasmaRifle"",
		""type"": ""ITEM"",
		""englishName"": ""Plasma Rifle"",
		""englishTooltip"": [
			""Fires a plasma blast that explodes"",
			""Right click to fire plasma bolts""
		],
		""name"": ""Fusil à Plasma"",
		""tooltip"": [
			""Tire une décharge de plasma explosive"",
			""Clic droit pour tirer des rafales de plasma""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AngelicShotgun"",
		""type"": ""ITEM"",
		""englishName"": ""Angelic Shotgun"",
		""englishTooltip"": [
			""Each shot casts a radiant beam of holy light from the sky"",
			""Converts musket balls into illuminated bullets"",
			""Fighting 'til the war's won""
		],
		""name"": ""Fusil à Pompe Angélique"",
		""tooltip"": [
			""Chaque tir convoque un rayon radieux de lumière sacrée depuis les cieux"",
			""Convertit les balles de mousquet en balles illuminées"",
			""Combattre jusqu'a que la guerre soit gagnée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BulletFilledShotgun"",
		""type"": ""ITEM"",
		""englishName"": ""Bullet-Filled Shotgun"",
		""englishTooltip"": [
			""Fires a massive spread of bouncing bullets"",
			""Consumes five bullets per-use"",
			""Aim? What's that?""
		],
		""name"": ""Fusil à Pompe Rempli de Balles"",
		""tooltip"": [
			""Tire une volée massive de balles rebondissantes"",
			""Consomme 5 balles par tir"",
			""Viser? Ca se mange?""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AquashardShotgun"",
		""type"": ""ITEM"",
		""englishName"": ""Aquashard Shotgun"",
		""englishTooltip"": [
			""Converts musket balls into aquashards that split upon hitting an enemy""
		],
		""name"": ""Fusil à Pompe d'Éclat Aquatique"",
		""tooltip"": [
			""Convertit les balles de mousquet en éclats aquatiques qui se divisent en touchant les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FrostyFlare"",
		""type"": ""ITEM"",
		""englishName"": ""Frosty Flare"",
		""englishTooltip"": [
			""Do not insert in flare gun"",
			""Sticks to enemies"",
			""Generates a localized hailstorm"",
			""Stealth strikes trail snowflakes and summon phantom copies instead of ice shards""
		],
		""name"": ""Fusée Glaciale"",
		""tooltip"": [
			""Ne pas insérer dans le pistolet à fusées"",
			""Se colle aux ennemis"",
			""Génère une tempête de grèle localement"",
			""Les attaques furtives laisse une trainée de neige et invoque des copies fantômatiques au lieu des éclats de glace""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OverloadedSludge"",
		""type"": ""ITEM"",
		""englishName"": ""Overloaded Sludge"",
		""englishTooltip"": [
			""It looks corrupted"",
			""Summons the Slime God"",
			""Not consumable""
		],
		""name"": ""Gadoue Surchargée"",
		""tooltip"": [
			""Elle à l'air corrompue"",
			""Invoque le Dieu des Gelées"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FourSeasonsGalaxia"",
		""type"": ""ITEM"",
		""englishName"": ""Galaxia"",
		""englishTooltip"": [
			""FUNCTION_DESC"",
			""FUNCTION_PASSIVE"",
			""Upgrading the sword let it break free from its earthly boundaries. You now have access to every single attunement at all times!"",
			""Use RMB to cycle the sword's attunement forward or backwards depending on the position of your cursor"",
			""Active Attunement : None"",
			""Passive Blessing : None""
		],
		""name"": ""Galaxia"",
		""tooltip"": [
			""FUNCTION_DESC"",
			""FUNCTION_PASSIVE"",
			""Améliorer l'épée lui a permis de briser ses limites terrestres. Vous avez maintenant accès a tous les alignements à n'importe quel moment!"",
			""Clic droit pour passer d'un alignement à l'autre en fonction de la position du curseur sur votre écran"",
			""Alignement actif : Aucun"",
			""Bénédiction passive : Aucune""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FilthyGlove"",
		""type"": ""ITEM"",
		""englishName"": ""Filthy Glove"",
		""englishTooltip"": [
			""Stealth strikes have +10 armor penetration and deal 10% more damage""
		],
		""name"": ""Gant Crasseux"",
		""tooltip"": [
			""Les attaques furtives ignorent 10 points d'armure et infligent 10% de dégâts supplémentaires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodstainedGlove"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodstained Glove"",
		""englishTooltip"": [
			""Stealth strikes have +10 armor penetration and heal for 1 HP""
		],
		""name"": ""Gant Maculé de Sang"",
		""tooltip"": [
			""Les attaques furtives pénètrent 10 points d'armure et soignent d'un point de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MadAlchemistsCocktailGlove"",
		""type"": ""ITEM"",
		""englishName"": ""Mad Alchemist's Cocktail Glove"",
		""englishTooltip"": [
			""Fires a variety of high-velocity flasks"",
			""Right click to throw a prismatic flask that inflicts many debuffs"",
			""Red flasks explode violently, blue flasks contain poison gas,"",
			""green flasks summon lunar flares and purple flasks explode into homing shrapnel""
		],
		""name"": ""Gant de Cocktail de l'Alchimiste Fou"",
		""tooltip"": [
			""Tire une variété de flasque ultra rapide qui ont des effets variés"",
			""Clic droit pour jeter une flasque qui inflige un panaché d'altérations d'état"",
			""Les flasques rouges explosent violemment, les bleues contiennent du gaz toxique,"",
			""les vertes invoques des décharges lunaires et les violettes exploses en éclats à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElementalGauntlet"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Gauntlet"",
		""englishTooltip"": [
			""Melee attacks and projectiles inflict on fire, frostburn and holy flames"",
			""15% increased melee speed, damage, and 5% increased melee critical strike chance"",
			""20% increased true melee damage"",
			""Temporary immunity to lava"",
			""Increased melee knockback"",
			""Enables auto swing for melee weapons"",
			""Increases the size of melee weapons""
		],
		""name"": ""Gant des Eléments"",
		""tooltip"": [
			""Les attaques et projectiles de corps à corps infligent la brûlure, le brûlegivre et les flammes sacrées"",
			""+15% de vitesse et de dégâts de corps à corps et +5% de chances de coup critique au corps à corps"",
			""+20% de dégâts de vraie mêlée"",
			""Immunité temporaire à la lave"",
			""Recul des attaques de corps à corps augmenté""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElectriciansGlove"",
		""type"": ""ITEM"",
		""englishName"": ""Electrician's Glove"",
		""englishTooltip"": [
			""Stealth strikes summon sparks on enemy hits"",
			""Stealth strikes also have +10 armor penetration, deal 10% more damage, and heal for 1 HP""
		],
		""name"": ""Gants d'Electricien"",
		""tooltip"": [
			""Les attaques furtives créent des étincelles lorsqu'elles touchent"",
			""Elles pénétrent également +10 armure, font 10% de dégâts supplémentaires et soignent d'un point de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GloveOfRecklessness"",
		""type"": ""ITEM"",
		""englishName"": ""Glove of Recklessness"",
		""englishTooltip"": [
			""Increases rogue attack speed by 12% but decreases damage by 10%"",
			""Adds inaccuracy to rogue weapons""
		],
		""name"": ""Gants d'Imprudence"",
		""tooltip"": [
			""Augmente la vitesse d'attaque de voleur de 12% mais réduit les dégâts de 10%"",
			""Ajoute de l'imprécision aux armes de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GloveOfPrecision"",
		""type"": ""ITEM"",
		""englishName"": ""Glove of Precision"",
		""englishTooltip"": [
			""Decreases rogue attack speed by 20% but increases damage and crit by 12% and velocity by 25%""
		],
		""name"": ""Gants de Précision"",
		""tooltip"": [
			""Réduit la vitesse d'attaque de voleur de 20% mais augmente les dégâts et les chances de coup critique de voleur de 12% et la vitesse des projectiles de 25%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MajesticGuard"",
		""type"": ""ITEM"",
		""englishName"": ""Majestic Guard"",
		""englishTooltip"": [
			""Lowers enemy defense by 1 with every strike"",
			""If enemy defense is 0 or below your attacks will heal you""
		],
		""name"": ""Garde Majestique"",
		""tooltip"": [
			""Baisse la défense ennemie de 1 à chaque coup"",
			""Si la défense ennemie est à 0 ou plus bas, vos attaques vous soigneront""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueKeeper"",
		""type"": ""ITEM"",
		""englishName"": ""Plague Keeper"",
		""englishTooltip"": [
			""Fires a plague and bee cloud""
		],
		""name"": ""Gardien de Peste"",
		""tooltip"": [
			""Tire un nuage d'abeilles et de peste""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ClockGatlignum"",
		""type"": ""ITEM"",
		""englishName"": ""Clock Gatlignum"",
		""englishTooltip"": [
			""33% chance to not consume ammo"",
			""Converts musket balls into strings of 3 high velocity bullets""
		],
		""name"": ""Gatlignum Mécanique"",
		""tooltip"": [
			""33% de chances de ne pas consommer de munitions"",
			""Convertit les balles de mousquet en une rafale de 3 balles ultra véloces""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GatlingLaser"",
		""type"": ""ITEM"",
		""englishName"": ""Gatling Laser"",
		""englishTooltip"": [
			""Large laser cannon used primarily by Yharim's fleet and base defense force""
		],
		""name"": ""Gatling Laser"",
		""tooltip"": [
			""Gros canon laser principalement utilisé par la flotte et les forces de défense de Yharim""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PurifiedGel"",
		""type"": ""ITEM"",
		""englishName"": ""Purified Gel"",
		""name"": ""Gel Purifié"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GrandGelatin"",
		""type"": ""ITEM"",
		""englishName"": ""Grand Gelatin"",
		""englishTooltip"": [
			""10% increased movement and jump speed"",
			""+20 max life and mana"",
			""Standing still boosts life and mana regen""
		],
		""name"": ""Gelée Grandiose"",
		""tooltip"": [
			""+10% de vitesse de mouvement et de saut"",
			""+20 de vie et de mana maximum"",
			""Rester immobile augmente la régénération de vie et de mana""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VitalJelly"",
		""type"": ""ITEM"",
		""englishName"": ""Vital Jelly"",
		""englishTooltip"": [
			""10% increased movement and jump speed""
		],
		""name"": ""Gelée Vitale"",
		""tooltip"": [
			""+10% de vitesse de déplacement et de saut""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VoltaicJelly"",
		""type"": ""ITEM"",
		""englishName"": ""Voltaic Jelly"",
		""englishTooltip"": [
			""+1 max minions"",
			""Minion attacks inflict Electrified""
		],
		""name"": ""Gelée Voltaïque"",
		""tooltip"": [
			""+1 sbire max"",
			""Les attaques des sbires infligent électrisé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ManaJelly"",
		""type"": ""ITEM"",
		""englishName"": ""Mana Jelly"",
		""englishTooltip"": [
			""+20 max mana"",
			""Standing still boosts mana regen""
		],
		""name"": ""Gelée de Mana"",
		""tooltip"": [
			""+20 de mana maximum"",
			""Rester immobile augmente votre régénération de mana""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LifeJelly"",
		""type"": ""ITEM"",
		""englishName"": ""Life Jelly"",
		""englishTooltip"": [
			""+20 max life"",
			""Standing still boosts life regen""
		],
		""name"": ""Gelée de Vie"",
		""tooltip"": [
			""+20 vie maximum"",
			""Rester immobile augmente la régénération de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CelestialJewel"",
		""type"": ""ITEM"",
		""englishName"": ""Celestial Jewel"",
		""englishTooltip"": [
			""Boosts life regen even while under the effects of a damaging debuff"",
			""While under the effects of a damaging debuff you will gain 11 defense"",
			""TOOLTIP LINE HERE""
		],
		""name"": ""Gemme Céleste"",
		""tooltip"": [
			""Augmente la régénération de vie même lorsque vous subissez des dégâts sur la durée"",
			""+11 défense lorsque vous subissez des dégâts sur la durée"",
			""TOOLTIP LINE HERE""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ScuttlersJewel"",
		""type"": ""ITEM"",
		""englishName"": ""Scuttler's Jewel"",
		""englishTooltip"": [
			""Stealth strike projectiles spawn a jewel spike when destroyed""
		],
		""name"": ""Gemme de Fuyard"",
		""tooltip"": [
			""Les projectiles de voleurs ont une chance de générer une pointe de gemme lorsqu'ils disparaissent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DecapoditaSprout"",
		""type"": ""ITEM"",
		""englishName"": ""Decapodita Sprout"",
		""englishTooltip"": [
			""Summons Crabulon when used in the mushroom biome"",
			""Not consumable""
		],
		""name"": ""Germe de Décapodite"",
		""tooltip"": [
			""Invoque Crabulon quand utilisé dans un biome champignon"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralIce"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Ice"",
		""name"": ""Glace Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GalileoGladius"",
		""type"": ""ITEM"",
		""englishName"": ""Galileo Gladius"",
		""englishTooltip"": [
			""Don't underestimate the power of small space swords"",
			""Shoots a homing crescent moon"",
			""Spawns planetoids on enemy hits""
		],
		""name"": ""Gladius de Galilée"",
		""tooltip"": [
			""Ne sous-estimez pas le pouvoir des petites épées de l'espace"",
			""Tire un croissant de lune à tête chercheuse"",
			""Créé des planétoïdes quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Glaive"",
		""type"": ""ITEM"",
		""englishName"": ""Glaive"",
		""englishTooltip"": [
			""Stacks up to 3"",
			""Stealth strikes are super fast and pierce infinitely""
		],
		""name"": ""Glaive"",
		""tooltip"": [
			""Jusqu'à 3 cumuls"",
			""Les attaques furtives sont super rapides et transperçent indéfiniment""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GalvanizingGlaive"",
		""type"": ""ITEM"",
		""englishName"": ""Galvanizing Glaive"",
		""englishTooltip"": [
			""Its use as a tool is to quickly separate a single object into two"",
			""That is also its use as a weapon"",
			""Swings a spear which envelops struck foes in an energy field"",
			""When done swinging, the spear discharges an extra pulse of energy""
		],
		""name"": ""Glaive Galvanisant"",
		""tooltip"": [
			""Utilisé pour rapidement séparer un objet en deux"",
			""C'est aussi son utilité en tant qu'arme"",
			""Frappe avec une lance qui enveloppe les ennemis touchés d'un champ d'énergie"",
			""Après une frappe, la lance décharge une pulsation d'énergie supplémentaire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BouncingEyeball"",
		""type"": ""ITEM"",
		""englishName"": ""Bouncing Eyeball"",
		""englishTooltip"": [
			""Throws an eyeball that bounces off of surfaces."",
			""Knockback is much stronger during a blood moon"",
			""Stealth strikes cause the eyeballs to move much faster and bounce more energetically""
		],
		""name"": ""Globe Oculaire Rebondissant"",
		""tooltip"": [
			""Tire un globe oculaire qui rebondit sur les surfaces."",
			""Le recul est bien plus fort durant la lune sanglante"",
			""Les attaques furtives rendent les globes oculaires bien plus rapides et rebondissent plus énergiquement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Goobow"",
		""type"": ""ITEM"",
		""englishName"": ""Goobow"",
		""englishTooltip"": [
			""Fires two streams of slime""
		],
		""name"": ""Gluarc"",
		""tooltip"": [
			""Tire deux faisceaux de gelée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeGolem"",
		""type"": ""ITEM"",
		""englishName"": ""Golem"",
		""englishTooltip"": [
			""A primitive construct."",
			""I admire the lihzahrd race for their ingenuity, though finding faith in such a flawed idol would invariably lead to their downfall.""
		],
		""name"": ""Golem"",
		""tooltip"": [
			""Une construction primitive."",
			""J'admire la race des Lizhard pour leur ingéniosité, bien que croire en une idole si imparfaite les menèra invariablement vers leur perte.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StreamGouge"",
		""type"": ""ITEM"",
		""englishName"": ""Stream Gouge"",
		""englishTooltip"": [
			""Summons a portal that the spear crosses through"",
			""Shortly after going through the portal, portals appear near the mouse that release copies of the spear's cutting edge"",
			""Enemies hit by the copies create lacerations in space, revealing a cosmic background""
		],
		""name"": ""Gouge Torrentielle"",
		""tooltip"": [
			""Tire un clone de lance d'essence"",
			""Ignore la période d'invulnérabilité""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DarkechoGreatbow"",
		""type"": ""ITEM"",
		""englishName"": ""Darkecho Greatbow"",
		""englishTooltip"": [
			""Fires two arrows at once"",
			""Fires an additional crystal dart""
		],
		""name"": ""Grand Arc de Sombre Écho"",
		""tooltip"": [
			""Tire deux flèches à la fois"",
			""Tire en plus une fléchette de cristal""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GrandGuardian"",
		""type"": ""ITEM"",
		""englishName"": ""Grand Guardian"",
		""englishTooltip"": [
			""Lowers enemy defense by 1 with every strike"",
			""If enemy defense is 0 or below your attacks will heal you"",
			""Striking enemies causes a large explosion"",
			""Striking enemies that are under half life will cause them to release rainbow bolts"",
			""Enemies spawn healing orbs on death""
		],
		""name"": ""Grand Gardien"",
		""tooltip"": [
			""Réduit la défense ennemie de 1 quand vous les frappez"",
			""Si la défense ennemie est de 0 ou moins, vos attaques vous soigneront"",
			""Frapper les ennemis provoque une large explosion"",
			""Frapper les ennemis ayant moins de la moitié de leur points de vie vous fait relâcher des décharges arc-en-ciel"",
			""Les ennemis créent des orbes de soins quand ils meurent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FearmongerGreathelm"",
		""type"": ""ITEM"",
		""englishName"": ""Fearmonger Greathelm"",
		""englishTooltip"": [
			""Pure terror radiates from your eyes"",
			""+60 max mana and 10% decreased mana usage"",
			""10% increased minion damage""
		],
		""name"": ""Grand Heaume du Sème-Peur"",
		""tooltip"": [
			""De la terreur pure irradie de vos yeux"",
			""+60 mana maximum et 10% de réduction du coût en mana"",
			""+10% de dégâts des sbires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GrandScale"",
		""type"": ""ITEM"",
		""englishName"": ""Grand Scale"",
		""englishTooltip"": [
			""Large scale of an apex predator""
		],
		""name"": ""Grande Ecaille"",
		""tooltip"": [
			""Large écaille d'un prédateur apex""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssGravel"",
		""type"": ""ITEM"",
		""englishName"": ""Abyss Gravel"",
		""name"": ""Gravier Abyssal"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GravistarSabaton"",
		""type"": ""ITEM"",
		""englishName"": ""Gravistar Sabaton"",
		""englishTooltip"": [
			""Tap the DOWN key to increase your fall speed for 5 seconds"",
			""This has an 8 second cooldown"",
			""Striking the ground with increased fall speed will cause an astral explosion""
		],
		""name"": ""Gravitoile Sabaton"",
		""tooltip"": [
			""Appuyez sur BAS pour augmenter votre vitesse de chute pendant 5 secondes"",
			""Cet effet à un temps de recharge de 8 secondes"",
			""Toucher le sol avec la vitesse de chute augmentée provoquera une explosion astrale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Grax"",
		""type"": ""ITEM"",
		""englishName"": ""Grax"",
		""englishTooltip"": [
			""Hitting an enemy will greatly boost your defense, melee damage and melee crit for a short time"",
			""Right click to use without hammering down walls or chopping down trees""
		],
		""name"": ""Grax"",
		""tooltip"": [
			""Frapper un ennemi augmentera grandement votre défense et vos statistiques de mêlée un court moment"",
			""Clic droit pour utiliser sans détruire les murs ou couper des arbres""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RustedJingleBell"",
		""type"": ""ITEM"",
		""englishName"": ""Rusted Jingle Bell"",
		""englishTooltip"": [
			""Summons a baby ghost bell light pet"",
			""Provides a moderate amount of light while underwater""
		],
		""name"": ""Grelot Rouillé"",
		""tooltip"": [
			""Invoque une bébé cloche fantôme pour vous éclairer"",
			""Donne une quantité modérée de lumière sous l'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlasmaGrenade"",
		""type"": ""ITEM"",
		""englishName"": ""Plasma Grenade"",
		""englishTooltip"": [
			""Each grenade contains a heavily condensed and heated unit of plasma. Use with care"",
			""Throws a grenade that explodes into plasma on collision"",
			""Stealth strikes explode violently on collision into a vaporizing blast""
		],
		""name"": ""Grenade de Plasma"",
		""tooltip"": [
			""Chaque grenade contient du plasma condensé et chaufée. A utiliser avec précaution."",
			""Jete une grenade qui provoque une explosion de plasma à l'impact"",
			""Les attaques furtives explosent violemment à l'impact dans un souffle vaporisant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ShockGrenade"",
		""type"": ""ITEM"",
		""englishName"": ""Shock Grenade"",
		""englishTooltip"": [
			""Throws a grenade that explodes into a burst of lightning"",
			""Stealth strikes cause the grenade to leave an electrifying aura when it explodes""
		],
		""name"": ""Grenade à Choc"",
		""tooltip"": [
			""Lance une grenade qui explose dans une déflagration d'électricité"",
			""Les attaques furtives créent une aura électrifiante rémanente après l'explosion""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MantisClaws"",
		""type"": ""ITEM"",
		""englishName"": ""Mantis Claws"",
		""englishTooltip"": [
			""Explodes on enemy hits""
		],
		""name"": ""Griffes Mantis"",
		""tooltip"": [
			""Explose en touchant les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MycelialClaws"",
		""type"": ""ITEM"",
		""englishName"": ""Mycelial Claws"",
		""name"": ""Griffes Mycéllaires"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralSandstone"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Sandstone"",
		""name"": ""Grès Astral"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SulphurousSandstone"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Sandstone"",
		""name"": ""Grès Sulfureux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PrismaticGreaves"",
		""type"": ""ITEM"",
		""englishName"": ""Prismatic Greaves"",
		""englishTooltip"": [
			""10% increased magic damage and 12% increased magic crit"",
			""20% decreased non-magic damage"",
			""10% increased flight time and 2% increased jump speed""
		],
		""name"": ""Grèves Prismatiques"",
		""tooltip"": [
			""+10% de dégâts magiques et +12% de chances de coup critique magique"",
			""-20% aux dégâts non magiques"",
			""+10% de temps de vol et +2% de vitesse de saut""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StatigelGreaves"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Greaves"",
		""englishTooltip"": [
			""5% increased damage and movement speed""
		],
		""name"": ""Grèves Statigel"",
		""tooltip"": [
			""+5% de dégâts et de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FathomSwarmerBoots"",
		""type"": ""ITEM"",
		""englishName"": ""Fathom Swarmer Greaves"",
		""englishTooltip"": [
			""4% increased minion damage"",
			""Grants the ability to swim"",
			""Movement speed increased by 40% while submerged in liquid""
		],
		""name"": ""Grèves d'Essaim de Brasse"",
		""tooltip"": [
			""+4% de dégâts des sbires"",
			""Permet de nager"",
			""+40% de vitesse quand vous êtes immergé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DemonshadeGreaves"",
		""type"": ""ITEM"",
		""englishName"": ""Demonshade Greaves"",
		""englishTooltip"": [
			""Shadow speed""
		],
		""name"": ""Grèves d'Ombredémon"",
		""tooltip"": [
			""Vitesse d'ombre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SnowRuffianGreaves"",
		""type"": ""ITEM"",
		""englishName"": ""Snow Ruffian Greaves"",
		""englishTooltip"": [
			""5% increased movement speed""
		],
		""name"": ""Grèves du Bandit des Neiges"",
		""tooltip"": [
			""+5% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FearmongerGreaves"",
		""type"": ""ITEM"",
		""englishName"": ""Fearmonger Greaves"",
		""englishTooltip"": [
			""6% increased damage"",
			""50% increased minion knockback"",
			""10% increased movement speed"",
			""Taking damage makes you move very fast for a short time""
		],
		""name"": ""Grèves du Sème-Peur"",
		""tooltip"": [
			""+6% de dégâts"",
			""+50% de recul des sbires"",
			""+10% de vitesse de mouvement"",
			""Subir des dégâts vous fait bouger très vite durant un court moment""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PrismaticGuppy"",
		""type"": ""ITEM"",
		""englishName"": ""Prismatic Guppy"",
		""englishTooltip"": [
			""Throwing these in an aquarium would be insanity""
		],
		""name"": ""Guppy Prismatique"",
		""tooltip"": [
			""Ca serait de la folie de le mettre dans un aquarium""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Gehenna"",
		""type"": ""ITEM"",
		""englishName"": ""Gehenna"",
		""englishTooltip"": [
			""Drops brimstone fireballs from the sky occasionally""
		],
		""name"": ""Géhenne"",
		""tooltip"": [
			""Fait pleuvoir des boules de feu de soufre du ciel occasionnellement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Genisis"",
		""type"": ""ITEM"",
		""englishName"": ""Genisis"",
		""englishTooltip"": [
			""Fires a Y-shaped beam of destructive energy and a spread of lasers""
		],
		""name"": ""Génisis"",
		""tooltip"": [
			""Tire un rayon d'énergie destructrice en Y et une étendue de lasers""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StarTaintedGenerator"",
		""type"": ""ITEM"",
		""englishName"": ""Star-Tainted Generator"",
		""englishTooltip"": [
			""+2 max minions, does not stack with downgrades"",
			""7% increased minion damage"",
			""Minion attacks spawn astral explosions and inflict several debuffs"",
			""Grants immunity to Irradiated""
		],
		""name"": ""Générateur Infecté par les Astres"",
		""tooltip"": [
			""+2 sbires max, ne se cumule pas avec ses matériaux"",
			""+7% de dégâts des sbires"",
			""Les attaques des sbires génèrent des explosions astrales et infligent plusieurs altérations d'état""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NeptunesBounty"",
		""type"": ""ITEM"",
		""englishName"": ""Neptune's Bounty"",
		""englishTooltip"": [
			""Fires a trident that rains additional tridents as it travels"",
			""Hitting enemies will inflict the crush depth debuff"",
			""The lower the enemies' defense, the more damage they take from this debuff""
		],
		""name"": ""Générosité de Neptune"",
		""tooltip"": [
			""Tire un trident qui fait pleuvoir des tridents sur sa trajectoire"",
			""Les ennemis touchés subiront l'écrasement des profondeurs"",
			""Au plus la défense des ennemis est faible, au plus ils subissent des dégâts de l'écrasement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DivineGeode"",
		""type"": ""ITEM"",
		""englishName"": ""Divine Geode"",
		""englishTooltip"": [
			""A chunk of crystallized holy energy""
		],
		""name"": ""Géode Divine"",
		""tooltip"": [
			""Un morceau cristallisé d'énergie sacrée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EnchantedAxe"",
		""type"": ""ITEM"",
		""englishName"": ""Enchanted Axe"",
		""englishTooltip"": [
			""Throws a high velocity axe that returns to you after travelling a short distance or hitting a wall"",
			""At the furthest point from the player, a magical axe that travels through walls will be cast towards the nearest enemy"",
			""Stealth strikes make the axe fly further, throwing out many other magical axes in all directions""
		],
		""name"": ""Hache Enchantée"",
		""tooltip"": [
			""Lance une hache rapide qui revient après une courte distance ou avoir percuté un mur"",
			""Au point culminant de sa trajectoire, une hache magique qui traverse les murs sera envoyée sur l'ennemi le plus proche"",
			""Les attaques furtives font aller la hache plus loin, tout en lancant une myriade des haches additionnelles dans toutes les directions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumAxe"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Axe"",
		""name"": ""Hache Wulfrum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BerserkerWaraxe"",
		""type"": ""ITEM"",
		""englishName"": ""Berserker Waraxe"",
		""name"": ""Hache de Guerre du Berserker"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AdamantiteThrowingAxe"",
		""type"": ""ITEM"",
		""englishName"": ""Adamantite Throwing Axe"",
		""englishTooltip"": [
			""Stealth strikes summon lightning bolts on enemy hits""
		],
		""name"": ""Hache de Lancer en Adamantite"",
		""tooltip"": [
			""Les attaques furtives invoquent des éclairs quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElementalAxe"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Axe"",
		""englishTooltip"": [
			""Summons an elemental axe to fight for you""
		],
		""name"": ""Hache des Élements"",
		""tooltip"": [
			""Invoque une hache des éléments pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DeepSeaDumbbell"",
		""type"": ""ITEM"",
		""englishName"": ""Deep Sea Dumbbell"",
		""englishTooltip"": [
			""Throws a dumbbell that bounces and flings weights with each bounce"",
			""Right click to flex, increasing the damage of your next attack up to 5 times damage"",
			""Flexes can hit enemies directly""
		],
		""name"": ""Haltère de la Mer Profonde"",
		""tooltip"": [
			""Lance une haltère qui rebondit et jette des poids à chaque rebond"",
			""Clic droit pour la soulever, augmentant la puissance de votre prochaine attaque"",
			""Peut augmenter les dégâts jusqu'a 5 fois les dégâts initiaux"",
			""Soulever l'haltère peut toucher les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GodSlayerHornedHelm"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Horned Helm"",
		""name"": ""Heaume Cornu du Déicide"",
		""tooltip"": [
			""+3 sbires max""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SilvaHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Helm"",
		""name"": ""Heaume Silva"",
		""tooltip"": [
			""+13% de dégâts et de chances de coup critique de mêlée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DemonshadeHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Demonshade Helm"",
		""englishTooltip"": [
			""30% increased damage and 15% increased critical strike chance""
		],
		""name"": ""Heaume d'Ombredémon"",
		""tooltip"": [
			""+30% de dégâts et +15% de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AncientGodSlayerHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient God Slayer Helm"",
		""name"": ""Heaume de l'Ancien Déicide"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AuricTeslaPlumedHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Plumed Helm"",
		""englishTooltip"": [
			""20% increased rogue damage, critical strike chance and 5% increased movement speed""
		],
		""name"": ""Heaume à Plumes Tesla Aurique"",
		""tooltip"": [
			""+20% aux dégâts et aux chances de coup critique de voleur, +5% à la vitesse de mouvement"",
			""Rester immobile augmente tous les dégâts et les chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HeliumFlash"",
		""type"": ""ITEM"",
		""englishName"": ""Helium Flash"",
		""englishTooltip"": [
			""The power of a galaxy, if only for mere moments"",
			""Launches volatile star cores which erupt into colossal fusion blasts""
		],
		""name"": ""Helium Flash"",
		""tooltip"": [
			""Le pouvoir d'une galaxie, ne serait-ce que pour un instant"",
			""Lance des coeurs d'étoiles volatils qui explosent en de colossales éruptions de fusion""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Hellkite"",
		""type"": ""ITEM"",
		""englishName"": ""Hellkite"",
		""englishTooltip"": [
			""Contains the power of an ancient drake"",
			""Summons flame geyser explosions on enemy hits""
		],
		""name"": ""Hellkite"",
		""tooltip"": [
			""Contient le pouvoir d'un ancien dragon"",
			""Invoque des explosions de geyser enflammé qunad vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateClock"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Clock"",
		""name"": ""Horloge Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Hydra"",
		""type"": ""ITEM"",
		""englishName"": ""Hydra"",
		""englishTooltip"": [
			""Uses Explosive Shotgun Shells"",
			""Can be used once per boss battle""
		],
		""name"": ""Hydra"",
		""tooltip"": [
			""Utilise des cartouches de pompe explosives"",
			""Peut être utilisé une fois par combat de boss""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Hypothermia"",
		""type"": ""ITEM"",
		""englishName"": ""Hypothermia"",
		""englishTooltip"": [
			""Throws a constant barrage of black ice shards"",
			""Stealth strikes hurl a set of razor sharp ice chunks that shatter on impact""
		],
		""name"": ""Hypothermie"",
		""tooltip"": [
			""Tire un barrage constant d'éclat de glace noire"",
			""Les attaques furtives envoient violemment des morceaux de glace tranchant comme des rasoirs qui se brisent à l'impact""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Hematemesis"",
		""type"": ""ITEM"",
		""englishName"": ""Hematemesis"",
		""englishTooltip"": [
			""Casts a barrage of blood geysers from below""
		],
		""name"": ""Hématémèse"",
		""tooltip"": [
			""Convoque un barrage de geysers de sang depuis le sol""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CharredIdol"",
		""type"": ""ITEM"",
		""englishName"": ""Charred Idol"",
		""englishTooltip"": [
			""Use at your own risk"",
			""Summons the Brimstone Elemental when used in the brimstone crags"",
			""Not consumable""
		],
		""name"": ""Idole Calcinée"",
		""tooltip"": [
			""Invoque l'Élémentaire de soufre quand utilisé dans les vestiges souffrés"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicImmaterializer"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmic Immaterializer"",
		""englishTooltip"": [
			""Summons a cosmic energy spiral to fight for you"",
			""The orb will fire swarms of homing energy bolts when enemies are detected by it"",
			""Requires 10 minion slots to use and there can only be one energy spiral"",
			""Without a summoner armor set bonus this minion will deal less damage""
		],
		""name"": ""Immaterialiseur Cosmique"",
		""tooltip"": [
			""Invoque une spirale d'énergie cosmique pour combattre a vos côtés"",
			""L'orbe tirera des nuées de décharges d'énergies à tête chercheuse quand elle détecte des ennemis"",
			""Occupe 10 emplacements de sbires"",
			""Vous ne pouvez avoir qu'une seule orbe"",
			""Sans une armure d'invocateur complète, ce sbire fera moins de dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DragonPow"",
		""type"": ""ITEM"",
		""englishName"": ""Dragon Pow"",
		""englishTooltip"": [
			""Fires a dragon head that releases draconic sparks"",
			""Summons a barrage of petals and waterfalls on enemy hits""
		],
		""name"": ""Impact Draconique"",
		""tooltip"": [
			""Tire une tête de dragon qui relâche des étincelles draconiques"",
			""Invoque un barrage de pétales et de cascades quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SparklingEmpress"",
		""type"": ""ITEM"",
		""englishName"": ""Sparkling Empress"",
		""englishTooltip"": [
			""Fires a concentrated laser to annihilate your foes"",
			""Defeated enemies explode into prism shards""
		],
		""name"": ""Impératrice Étincellante"",
		""tooltip"": [
			""Invoque un laser concentré pour annihiler vos ennemis"",
			""Les ennemis vaincus explosent en éclats de prisme""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CleansingBlaze"",
		""type"": ""ITEM"",
		""englishName"": ""Cleansing Blaze"",
		""englishTooltip"": [
			""90% chance to not consume gel""
		],
		""name"": ""Incendie Purificatrice"",
		""tooltip"": [
			""90% de chances de ne pas consommer de gel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeAstralInfection"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Infection"",
		""englishTooltip"": [
			""This twisted dreamscape, surrounded by unnatural pillars under a dark and hazy sky."",
			""Natural law has been upturned. What will you make of it?""
		],
		""name"": ""Infection Astrale"",
		""tooltip"": [
			""Ce paysage de rêve perverti, entouré par des pilliers contre nature sous un ciel sombre et brumeux."",
			""La loi de la nature a été renversée. Que vas-tu en faire?""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Helstorm"",
		""type"": ""ITEM"",
		""englishName"": ""Helstorm"",
		""englishTooltip"": [
			""Fires two bullets at once"",
			""The gun also deals damage to enemies that touch it""
		],
		""name"": ""Infertempête"",
		""tooltip"": [
			""Tire deux balles à la fois"",
			""L'amre fait également des dégâts aux ennemis qu'elle touche""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Infinity"",
		""type"": ""ITEM"",
		""englishName"": ""Infinity"",
		""englishTooltip"": [
			""Fires a barrage of energy bolts that split and bounce"",
			""Right click to fire a barrage of normal bullets"",
			""They say infinity is neverending, yet you hold it in your hands""
		],
		""name"": ""Infinité"",
		""tooltip"": [
			""Tire un barrage de traits d'énergie qui se divisent et ricochent"",
			""Clic droit pour tirer un barrage de balles normales"",
			""On dit que l'infinité est incessante, et pourtant tu la tiens dans tes mains""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueInfuser"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": ""Infuseur de Peste"",
		""tooltip"": [
			""Utilisé pour l'artisanat spécial""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralInjection"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Injection"",
		""englishTooltip"": [
			""Gives mana sickness and hurts you when used, but you regenerate mana extremely quickly even while moving or casting spells""
		],
		""name"": ""Injection Astrale"",
		""tooltip"": [
			""Inflige mana affaibli et des dégâts quand utilisé, mais vous régénérez du mana extrêmement rapidement même si vous bougez ou si vous utilisez des sorts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""YharimsInsignia"",
		""type"": ""ITEM"",
		""englishName"": ""Yharim's Insignia"",
		""englishTooltip"": [
			""10% increased damage when under 50% life"",
			""10% increased melee speed"",
			""10% increased melee and true melee damage"",
			""Melee attacks and melee projectiles inflict holy fire"",
			""Temporary immunity to lava"",
			""Increased melee knockback""
		],
		""name"": ""Insigne de Yharim"",
		""tooltip"": [
			""+10% de dégâts quand il vous manque plus de 50% de votre de vie"",
			""+10% de vitesse de corps à corps"",
			""+10% de dégâts de corps à corps et de vraie mêlée"",
			""Les attaques et projectiles de corps à corps infligent le feu sacrée"",
			""Immunité temporaire à la lave"",
			""Augmente le recul des attaques de corps à corps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DaedalusLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Leggings"",
		""englishTooltip"": [
			""3% increased critical strike chance"",
			""10% increased movement speed""
		],
		""name"": ""Jambières de Dédale"",
		""tooltip"": [
			""+3% de chances de coup critique"",
			""+10% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SeaMinnowJar"",
		""type"": ""ITEM"",
		""englishName"": ""Sea Minnow Jar"",
		""name"": ""Jarre du Vairon de Mer"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MagicLevelMeter"",
		""type"": ""ITEM"",
		""englishName"": ""Magic Level Meter"",
		""englishTooltip"": [
			""Tells you how high your magic proficiency is""
		],
		""name"": ""Jauge de Niveau Magique"",
		""tooltip"": [
			""Vous donne votre niveau de compétence magique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SummonLevelMeter"",
		""type"": ""ITEM"",
		""englishName"": ""Summon Level Meter"",
		""englishTooltip"": [
			""Tells you how high your summon proficiency is""
		],
		""name"": ""Jauge de Niveau d'Invocateur"",
		""tooltip"": [
			""Vous donne votre niveau de compétence d'invocateur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MeleeLevelMeter"",
		""type"": ""ITEM"",
		""englishName"": ""Melee Level Meter"",
		""englishTooltip"": [
			""Tells you how high your melee proficiency is""
		],
		""name"": ""Jauge de Niveau de Corps à Corps"",
		""tooltip"": [
			""Vous donne votre niveau de compétence au corps à corps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RangedLevelMeter"",
		""type"": ""ITEM"",
		""englishName"": ""Ranged Level Meter"",
		""englishTooltip"": [
			""Tells you how high your ranged proficiency is""
		],
		""name"": ""Jauge de Niveau de Distance"",
		""tooltip"": [
			""Vous donne votre niveau de compétence à distance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RogueLevelMeter"",
		""type"": ""ITEM"",
		""englishName"": ""Rogue Level Meter"",
		""englishTooltip"": [
			""Tells you how high your rogue proficiency is""
		],
		""name"": ""Jauge de Niveau de Voleur"",
		""tooltip"": [
			""Vous donne votre niveau de compétence de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PalladiumJavelin"",
		""type"": ""ITEM"",
		""englishName"": ""Palladium Javelin"",
		""englishTooltip"": [
			""Stealth strikes split into more javelins""
		],
		""name"": ""Javelot en Palladium"",
		""tooltip"": [
			""Les attaques furtives se divise en plus de javelots""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DraedonsLogHell"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon's Log - Hell"",
		""englishTooltip"": [
			""Click to view its contents""
		],
		""name"": ""Journal de Draedon - Enfer"",
		""tooltip"": [
			""Cliquez pour voir son contenu""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DraedonsLogJungle"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon's Log - The Jungle and Plague"",
		""englishTooltip"": [
			""Click to view its contents""
		],
		""name"": ""Journal de Draedon - La jungle et la peste"",
		""tooltip"": [
			""Cliquer pour voir son contenu""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DraedonsLogSnowBiome"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon's Log - The Frozen Wasteland"",
		""englishTooltip"": [
			""Click to view its contents""
		],
		""name"": ""Journal de Draedon - Les étendues gelées"",
		""tooltip"": [
			""Cliquez pour voir son contenu""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DraedonsLogPlanetoid"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon's Log - Space"",
		""englishTooltip"": [
			""Click to view its contents""
		],
		""name"": ""Journal de Draedon - l'Espace"",
		""tooltip"": [
			""Cliquez pour voir son contenu""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DraedonsLogSunkenSea"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon's Log - Study on Sunken Aquatic Life"",
		""englishTooltip"": [
			""Click to view its contents""
		],
		""name"": ""Journal de Draedon - Étude sur la Vie Aquatique Souterraine"",
		""tooltip"": [
			""Cliquez pour voir son contenu""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimstoneJewel"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Jewel"",
		""englishTooltip"": [
			""The ultimate reward for defeating such a beast..."",
			""Who knew she'd be so darn cute!""
		],
		""name"": ""Joyau de Soufre"",
		""tooltip"": [
			""L'ultime récompense pour avoir vaincu une telle bête..."",
			""Qui aurait pu savoir qu'elle est si mignonne!""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CrownJewel"",
		""type"": ""ITEM"",
		""englishName"": ""Crown Jewel"",
		""englishTooltip"": [
			""Boosts life regen even while under the effects of a damaging debuff"",
			""While under the effects of a damaging debuff you will gain 8 defense""
		],
		""name"": ""Joyau de la Couronne"",
		""tooltip"": [
			""Augmente la régénération de vie même lorsque vous subissez des dégâts sur la durée"",
			""+8 défense lorsque vous subissez des dégâts sur la durée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BeetleJuice"",
		""type"": ""ITEM"",
		""englishName"": ""Beetle Juice"",
		""name"": ""Jus de Scarabée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Karasawa"",
		""type"": ""ITEM"",
		""englishName"": ""Karasawa"",
		""englishTooltip"": [
			""...This is heavy... too heavy.""
		],
		""name"": ""Karasawa"",
		""tooltip"": [
			""...C'est lourd... trop lourd.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BleachedAnglingKit"",
		""type"": ""ITEM"",
		""englishName"": ""Bleached Angling Kit"",
		""englishTooltip"": [
			""Has a chance to contain various fishing gear"",
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Kit de Pêche Délavé"",
		""tooltip"": [
			""A une chance de contenir divers équipements de pêche"",
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SandyAnglingKit"",
		""type"": ""ITEM"",
		""englishName"": ""Sandy Angling Kit"",
		""englishTooltip"": [
			""Has a chance to contain various fishing gear"",
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Kit de Pêche Ensablé"",
		""tooltip"": [
			""A une chance de contenir divers équipements de pêche"",
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FlakKraken"",
		""type"": ""ITEM"",
		""englishName"": ""Flak Kraken"",
		""englishTooltip"": [
			""Fires an energy reticle that becomes more powerful over time""
		],
		""name"": ""Kraken Flak"",
		""tooltip"": [
			""Tire un réticule d'énergie qui devient de plus en plus puissant au fur et à mesure""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""InfernalKris"",
		""type"": ""ITEM"",
		""englishName"": ""Infernal Kris"",
		""englishTooltip"": [
			""Throws a burning dagger that starts spinning after travelling a short distance, inflicting additional damage while spinning"",
			""Stealth strikes cause the dagger to be engulfed in flames, exploding on contact with walls and enemies""
		],
		""name"": ""Kris Infernal"",
		""tooltip"": [
			""Jette une dague brûlante qui se met à tournoyer après avoir parcouru une courte distance, infligeant ainsi des dégâts supplémentaires"",
			""Les attaques furtives sont enveloppées de flammes et explosent au contact des murs et des ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicKunai"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmic Kunai"",
		""englishTooltip"": [
			""Fires a stream of short-range kunai"",
			""Stealth strikes spawn 5 Cosmic Scythes which home and explode""
		],
		""name"": ""Kunaï Cosmique"",
		""tooltip"": [
			""Lance un torrent de kunaïs à courte portée"",
			""Les attaques furtives font apparaître 5 Faux Cosmiques explosives à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LunarKunai"",
		""type"": ""ITEM"",
		""englishName"": ""Lunar Kunai"",
		""englishTooltip"": [
			""Throws out a set of three kunai that ignore gravity and slightly home in on enemies"",
			""After traveling enough distance, the kunai supercharge with lunar energy, homing in far more aggressively and exploding on impact"",
			""Stealth strikes instantly throw eight supercharged Kunai""
		],
		""name"": ""Kunaï Lunaire"",
		""tooltip"": [
			""Jette une triplette de kunaï qui ignore la gravité et possède un léger effet de tête chercheuse"",
			""Après une certaine distance, les kunaïs se surchargent d'énergie lunaire, ce qui augmente l'effet de tête chercheuse et les fait exploser à l'impact"",
			""Les attaques furtives lancent 8 kunaï surchargés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CobaltKunai"",
		""type"": ""ITEM"",
		""englishName"": ""Cobalt Kunai"",
		""englishTooltip"": [
			""Stealth strikes fire three homing cobalt energy bolts""
		],
		""name"": ""Kunaï de Cobalt"",
		""tooltip"": [
			""Les attaques furtives tirent trois eclairs d'énergie cobalt""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Kylie"",
		""type"": ""ITEM"",
		""englishName"": ""Kylie"",
		""englishTooltip"": [
			""Stealth strikes throws three short ranged kylies instead of a single long range one"",
			""'Also known as Dowak'""
		],
		""name"": ""Kylie"",
		""tooltip"": [
			""Les attaques furtives tirent trois kylies de courte portée au lieu d'une seule à longue portée"",
			""'Aussi connu sous le nom de Dowak'""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheBee"",
		""type"": ""ITEM"",
		""englishName"": ""The Bee"",
		""englishTooltip"": [
			""When at full HP, your damage is increased based on your damage reduction"",
			""Damage taken at full HP is halved"",
			""This has a 10 second cooldown""
		],
		""name"": ""L'Abeille"",
		""tooltip"": [
			""Quand vous avez toute votre vie, vos dégâts augmentent en fonction de votre réduction de dégâts"",
			""Les dégâts que vous subissez lorsque vous avez toute votre vie sont réduits de moitié"",
			""Cet effet a 10s de temps de recharge""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheAbsorber"",
		""type"": ""ITEM"",
		""englishName"": ""The Absorber"",
		""englishTooltip"": [
			""5% increased movement and jump speed"",
			""+20 max life and mana"",
			""Standing still boosts life and mana regen"",
			""Enemies take damage when they touch you"",
			""You emit a cloud of mushroom spores when you are hit"",
			""7% increased damage reduction"",
			""5% of the damage from enemy attacks is absorbed and converted into healing"",
			""Grants immunity to Armor Crunch""
		],
		""name"": ""L'Absorbeur"",
		""tooltip"": [
			""+5% de vitesse de mouvement et de saut"",
			""+20 vie et mana maximum"",
			""Rester immobile augmente la régénération de santé et de mana"",
			""Défense, vitesse de mouvement et réduction des dégâts augmentées lorsque vous êtes immergé"",
			""Les ennemis subissent des dégâts quand ils vous touchent"",
			""Vous émettez une explosion de spores et d'étincelles quand vous êtes touché"",
			""+10% de réduction des dégâts"",
			""5% des dégâts des attaques ennemies seront absorbées et rendus sous forme de points de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheAmalgam"",
		""type"": ""ITEM"",
		""englishName"": ""The Amalgam"",
		""englishTooltip"": [
			""Extends the duration of potion buffs by 100% and potion buffs remain active even after you die"",
			""15% increased damage"",
			""Shade rains down when you are hit"",
			""Nearby enemies receive a variety of debuffs when you are hit""
		],
		""name"": ""L'Amalgame"",
		""tooltip"": [
			""Augmente la durée des effets des potions de 100% et ces derniers restent actifs même lorsque vous mourrez"",
			""+15% de dégâts"",
			""De l'ombre pleut lorsque vous êtes touché"",
			""Les ennemis reçoivent une variété d'altérations d'état quand vous êtes touché""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeUnderworld"",
		""type"": ""ITEM"",
		""englishName"": ""The Underworld"",
		""englishTooltip"": [
			""These obsidian and hellstone towers were once home to thousands of... 'people'."",
			""Unfortunately for them, they were twisted by their inner demons until they were beyond saving.""
		],
		""name"": ""L'Enfer"",
		""tooltip"": [
			""Ces tours d'obsidienne et de pierre infernale étaient autrefois le foyer de milliers...de 'gens'."",
			""Malheureusement pour eux, il furent pervertis par leur démons intérieur jusqu'à devenir au delà de tout salut.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeHiveMind"",
		""type"": ""ITEM"",
		""englishName"": ""The Hive Mind"",
		""englishTooltip"": [
			""A hive of clustered microbial-infected flesh."",
			""I do not believe killing it will lessen the corruption here.""
		],
		""name"": ""L'Esprit de Ruche"",
		""tooltip"": [
			""Une ruche constituée d'un amas de chair infectée par un microbe."",
			""Je ne pense pas que la détruire amoindrira la corruption ici.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheSwarmer"",
		""type"": ""ITEM"",
		""englishName"": ""The Swarmer"",
		""englishTooltip"": [
			""Fires a swarm of bees and wasps""
		],
		""name"": ""L'Essaimmeur"",
		""tooltip"": [
			""Tire un essaim d'abeilles et de frelons""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheEvolution"",
		""type"": ""ITEM"",
		""englishName"": ""The Evolution"",
		""englishTooltip"": [
			""You reflect projectiles when they hit you"",
			""Reflected projectiles deal no damage to you"",
			""This reflect has a 120 second cooldown which is shared with all other dodges and reflects"",
			""If this effect triggers you get a health regeneration boost for 5 seconds"",
			""If the same enemy projectile type hits you again you will resist its damage by 15%""
		],
		""name"": ""L'Evolution"",
		""tooltip"": [
			""Vous renvoyez les projectiles quand ils vous touchent"",
			""Les projectiles renvoyés ne vous infligent pas de dégâts"",
			""Cet effet a un temps de recharge de 120s, qui est partagé avec toutes les autres esquives et effets de renvoi"",
			""Si cet effet s'active, votre régénération de vie sera améliorée un moment"",
			""Si le même type de projectile vous touche ensuite, ses dégâts seront réduits de 15%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheEnforcer"",
		""type"": ""ITEM"",
		""englishName"": ""The Enforcer"",
		""englishTooltip"": [
			""Spawns essence flames on hit""
		],
		""name"": ""L'Exécuteur"",
		""tooltip"": [
			""Créé des flammes d'essence quand elle touche""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EventHorizon"",
		""type"": ""ITEM"",
		""englishName"": ""Event Horizon"",
		""englishTooltip"": [
			""Nothing, not even light, can return."",
			""Fires a ring of stars to home in on nearby enemies"",
			""Stars spawn black holes on enemy hits""
		],
		""name"": ""L'Horizon des Évènements"",
		""tooltip"": [
			""Rien, pas même la lumière, ne peut en revenir."",
			""Tire un anneau d'étoiles qui se ruent sur les ennemis"",
			""Les étoiles créent des trous noir lorsqu'elles touchent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheObliterator"",
		""type"": ""ITEM"",
		""englishName"": ""The Obliterator"",
		""englishTooltip"": [
			""Ruins nearby enemies with death lasers"",
			""An exceptionally agile yoyo""
		],
		""name"": ""L'Oblitérateur"",
		""tooltip"": [
			""Ruine les ennemis proches avec des lasers mortels"",
			""Un yoyo exceptionnellement agile""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeOcean"",
		""type"": ""ITEM"",
		""englishName"": ""The Ocean"",
		""englishTooltip"": [
			""Take care to not disturb the deep waters of this world."",
			""You may awaken something more terrifying than death itself.""
		],
		""name"": ""L'Océan"",
		""tooltip"": [
			""Faites attention à ne pas déranger les eaux prfondes de ce monde."",
			""Vous risqueriez de réveiller quelque chose d'encore plus terrifiant que la mort elle même.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeEyeofCthulhu"",
		""type"": ""ITEM"",
		""englishName"": ""The Eye of Cthulhu"",
		""englishTooltip"": [
			""That eye... how peculiar."",
			""I sensed it watching you more intensely as you grew stronger.""
		],
		""name"": ""L'Oeil de Cthulhu"",
		""tooltip"": [
			""Cet oeil...intriguant."",
			""J'ai senti qu'il t'observait avec plus d'intensité alors que tu devenais plus fort.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Oracle"",
		""type"": ""ITEM"",
		""englishName"": ""The Oracle"",
		""englishTooltip"": [
			""Gaze into the past, the present, the future... and the circumstances of your inevitable demise"",
			""Emits an aura of red lightning which charges up when hitting enemies"",
			""Fires auric orbs when supercharged"",
			""An exceptionally agile yoyo""
		],
		""name"": ""L'Oracle"",
		""tooltip"": [
			""Observe le passé, le présent et le futur... et les circonstances de votre inévitable ruine"",
			""Émet une aura d'électricité rouge qui se charge en heurtant les ennemis"",
			""Tire des orbes auriques quand surchargé"",
			""Un yoyo exceptionnellement agile""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheWand"",
		""type"": ""ITEM"",
		""englishName"": ""The Wand"",
		""englishTooltip"": [
			""The ultimate wand""
		],
		""name"": ""La Baguette"",
		""tooltip"": [
			""La baguette ultime""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheBallista"",
		""type"": ""ITEM"",
		""englishName"": ""The Ballista"",
		""englishTooltip"": [
			""Converts wooden arrows into greatarrows that crush enemy armor and break into shards on death""
		],
		""name"": ""La Balliste"",
		""tooltip"": [
			""Convertit les flèches en bois en grandes flèches qui écrasent l'armure ennemie et se brise en éclats à leur disparition""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheCommunity"",
		""type"": ""ITEM"",
		""englishName"": ""The Community"",
		""englishTooltip"": [
			""The heart of (most of) the Terraria community"",
			""Starts off with weak buffs to all of your stats"",
			""The stat buffs become more powerful as you progress"",
			""Reduces the DoT effects of harmful debuffs inflicted on you"",
			""Thank you to all of my supporters who made this mod a reality""
		],
		""name"": ""La Communauté"",
		""tooltip"": [
			""Le coeur de (la plupart de) la communauté de Terraria"",
			""Au début, améliore faiblement toutes vos statistiques"",
			""L'amélioration devient de plus en plus importante au fur et à mesure que vous progressez dans le jeu"",
			""Réduit les dégâts sur la durée infligés par les altérations d'état"",
			""Merci à toutes les personnes qui m'ont aidé à faire de ce mod une réalité""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeCorruption"",
		""type"": ""ITEM"",
		""englishName"": ""The Corruption"",
		""englishTooltip"": [
			""The rotten and forever-deteriorating landscape of infected life, brought upon by a deadly microbe long ago."",
			""It is rumored that the microbe was created through experimentation by a long-dead race, predating the Terrarians.""
		],
		""name"": ""La Corruption"",
		""tooltip"": [
			""Un paysage putride et infecté en décomposition constante, provoqué par un microbe mortel il y a longtemps."",
			""La rumeur dit que le microbe fut créé par les expérimentations d'une race disparue depuis longtemps, antérieure aux Terrariens.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheGodsGambit"",
		""type"": ""ITEM"",
		""englishName"": ""The God's Gambit"",
		""englishTooltip"": [
			""Fires a stream of slime when enemies are near"",
			""A very agile yoyo""
		],
		""name"": ""La Manoeuvre de Dieu"",
		""tooltip"": [
			""Tire un torrent de gelée quand les ennemis sont proches"",
			""Un yoyo très agile""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeSulphurSea"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphur Sea"",
		""englishTooltip"": [
			""I remember the serene waves and the clear breeze."",
			""The bitterness of my youth has long since subsided, but it is far too late. I must never repeat a mistake like this again.""
		],
		""name"": ""La Mer de Sulfure"",
		""tooltip"": [
			""Je me souviens de ces vagues calmes et de cette douce brise."",
			""L'amertume de ma jeunesse à disparue depuis longtemps, mais il est beaucoup trop tard. Je ne dois jamais refaire une telle erreur à nouveau.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheFirstShadowflame"",
		""type"": ""ITEM"",
		""englishName"": ""The First Shadowflame"",
		""englishTooltip"": [
			""It is said that in the past, Prometheus descended from the heavens to grant man fire"",
			""If that were true, then it is surely the demons of hell that would have risen from below to do the same"",
			""Increases max minions by 1 and minions inflict the Shadowflame debuff on enemies"",
			""Grants immunity to Shadowflame""
		],
		""name"": ""La Première Flamme d'Ombre"",
		""tooltip"": [
			""Il est dit que dans le passé, Prometheus descendit des cieux pour donner le feu aux hommes."",
			""Si c'était vrai, alors les démons de l'enfer en aurait probablement surgi pour en faire de même."",
			""+1 sbire maximum"",
			""Les sbires infligent la flamme d'ombre quand ils touchent.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheHive"",
		""type"": ""ITEM"",
		""englishName"": ""The Hive"",
		""englishTooltip"": [
			""Launches a variety of rockets that explode into bees on death"",
			""Rockets will destroy tiles with tile-destroying ammo""
		],
		""name"": ""La Ruche"",
		""tooltip"": [
			""Lance une variété de missiles qui explosent en abeilles."",
			""Les missiles détruirons les tuiles en utilisant les munitions adaptées""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheSyringe"",
		""type"": ""ITEM"",
		""englishName"": ""The Syringe"",
		""englishTooltip"": [
			""Throws a high velocity syringe that increases damage as it travels"",
			""Shatters into glass and plague cinders on impact"",
			""Stealth strikes also shatter into plague bees"",
			""'I'm pretty sure this isn't healthy'""
		],
		""name"": ""La Seringue"",
		""tooltip"": [
			""Jette une seringue véloce qui gagne en dégâts au fur et à mesure de sa trajectoire"",
			""Se brise en verre et en cendres de peste à l'impact"",
			""Les attaques furtives libèrent également des abeilles pestiférées"",
			""'Je suis a peu près certain que ce n'est pas bon pour la santé'""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheStorm"",
		""type"": ""ITEM"",
		""englishName"": ""The Storm"",
		""englishTooltip"": [
			""Fires a spread of arrows from the sky"",
			""Converts wooden arrows into lightning bolts""
		],
		""name"": ""La Tempête"",
		""tooltip"": [
			""Tire une volée de flèches depuis les cieux"",
			""Les flèches de bois sont converties en foudre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeBloodMoon"",
		""type"": ""ITEM"",
		""englishName"": ""The Red Moon"",
		""englishTooltip"": [
			""We long ago feared the light of the red moon."",
			""Many went mad, others died, but a scant few became blessed with a wealth of cosmic understanding.""
		],
		""name"": ""La lune rouge"",
		""tooltip"": [
			""Il y a bien longtemps, nous craignîmes la lueur de la lune rouge."",
			""Beaucoup sont devenus fous, d'autres sont morts, mais quelques-uns furent bénis d'une compréhension cosmique riche.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Lacerator"",
		""type"": ""ITEM"",
		""englishName"": ""Lacerator"",
		""englishTooltip"": [
			""Enemies that are hit by the yoyo will have their life drained"",
			""A very agile yoyo"",
			""Someone thought this was a viable weapon against DoG at one point lol""
		],
		""name"": ""Lacérateur"",
		""tooltip"": [
			""Les ennemis qui sont touchés par le yo-yo se font drainer leur vie"",
			""Un yoyo très agile"",
			""Quelqu'un a pensé que c'était une arme viable pour vaincre le dévoreur à un moment, lol.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TundraLeash"",
		""type"": ""ITEM"",
		""englishName"": ""Tundra Leash"",
		""englishTooltip"": [
			""Summons a Rimehound mount""
		],
		""name"": ""Laisse de la Toundra"",
		""tooltip"": [
			""Invoque un chien en colère en tant que monture""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Abyss Blade"",
		""englishTooltip"": [
			""Fires short-range tridents"",
			""Hitting enemies will inflict the crush depth debuff"",
			""The lower the enemies' defense, the more damage they take from this debuff""
		],
		""name"": ""Lame Abyssale"",
		""tooltip"": [
			""Tire des tridents a courte portée"",
			""Toucher les ennemis leur infligera l'écrasement des profondeurs"",
			""Au plus la défense des ennemis est faible, au plus ils prennent des dégâts de l'écrasement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Blade"",
		""englishTooltip"": [
			""Deals more damage the more life an enemy has left""
		],
		""name"": ""Lame Astrale"",
		""tooltip"": [
			""Inflige plus de dégâts aux ennemis en fonction de leur vie"",
			""Moins les ennemis sont blessés, plus les dégâts sont augmentés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GeliticBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Gelitic Blade"",
		""englishTooltip"": [
			""Fires a gel wave that slows down on enemy hits""
		],
		""name"": ""Lame Gelitique"",
		""tooltip"": [
			""Tire une vague de gelée qui ralentit après avoir touché""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MirrorBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Mirror Blade"",
		""englishTooltip"": [
			""The amount of contact damage an enemy does is added to this weapons' damage"",
			""You must hit an enemy with the blade to trigger this effect""
		],
		""name"": ""Lame Miroir"",
		""tooltip"": [
			""La quantité de dégâts de contact qu'un ennemi inflige est ajoutée aux dégâts de cet arme"",
			""Vous devez frapper un ennemi avec cette arme pour que l'effet s'enclenche""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodyEdge"",
		""type"": ""ITEM"",
		""englishName"": ""Bloody Edge"",
		""englishTooltip"": [
			""Chance to heal the player on enemy hits"",
			""Inflicts Burning Blood""
		],
		""name"": ""Lame Sanglante"",
		""tooltip"": [
			""Chance de se soigner quand vous touchez les ennemis"",
			""Inflige le sang bouillonnant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Blade"",
		""name"": ""Lame Wulfrum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AnarchyBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Anarchy Blade"",
		""englishTooltip"": [
			""The lower your life the more damage this blade does"",
			""Your hits will generate a large explosion"",
			""If you're below 50% life your hits have a chance to instantly kill regular enemies""
		],
		""name"": ""Lame d'Anarchie"",
		""tooltip"": [
			""Au plus votre vie est faible, au plus cette arme inflige de dégâts"",
			""Vous générez une large explosion quand vous touchez"",
			""Si vous êtes en dessous de la moitié de votre vie, vous avez une chance de tuer instantanément les ennemis communs""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AegisBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Aegis Blade"",
		""englishTooltip"": [
			""Striking an enemy with the blade causes an earthen eruption"",
			""Right click to fire an aegis bolt""
		],
		""name"": ""Lame d'Égide"",
		""tooltip"": [
			""Frapper un ennemi avec la lame provoque une éruption terrestre"",
			""Clic droit pour tirer une décharge d'égide""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TrueBiomeBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Biome Blade"",
		""englishTooltip"": [
			""FUNCTION_DESC"",
			""Hold down RMB while standing still on flat ground to attune the weapon to the powers of the surrounding biome"",
			""Using RMB otherwise switches between the current attunement and an extra stored one"",
			""Main Attunement : [None]"",
			""Secondary Attunement: [None]""
		],
		""name"": ""Lame de Biome"",
		""tooltip"": [
			""FUNCTION_DESC"",
			""Maintenir le clic droit sans bouger sur une surface plate dans un biome aligne l'arme avec le biome environnant"",
			""Clic droit pour interchanger vos alignements actif et passif"",
			""Alignement actif : [Aucun]"",
			""Alignement passif : [Aucun]""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OmegaBiomeBlade"",
		""type"": ""ITEM"",
		""englishName"": ""True Biome Blade"",
		""englishTooltip"": [
			""FUNCTION_DESC"",
			""FUNCTION_PASSIVE"",
			""Holding down RMB for 2 seconds attunes the weapon to the powers of the surrounding biome"",
			""Using RMB for a shorter period of time switches your active and passive attunements around"",
			""Active Attunement : None"",
			""Passive Attunement: None""
		],
		""name"": ""Lame de Biome Omega"",
		""tooltip"": [
			""FUNCTION_DESC"",
			""FUNCTION_PASSIVE"",
			""Maintenir le clic droit dans un biome aligne l'arme avec le biome environnant"",
			""Clic droit pour interchanger vos alignements actif et passif"",
			""Alignement actif : Aucun"",
			""Alignement passif : Aucun""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FlarefrostBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Flarefrost Blade"",
		""englishTooltip"": [
			""Fires a homing flarefrost orb""
		],
		""name"": ""Lame de Givrefeu"",
		""tooltip"": [
			""Tire une orbe de givrefeu à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ShinobiBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Shinobi Blade"",
		""englishTooltip"": [
			""Throws a fast blade that spawns healing orbs when it kills an enemy"",
			""Stealth strikes cause 3 blades to be thrown at once""
		],
		""name"": ""Lame de Shinobi"",
		""tooltip"": [
			""Lance une lame rapide qui crée de orbe de soin quand vous tuez un ennemi"",
			""Les attaques furtives lancent 3 lames à la fois""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TerrorBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Terror Blade"",
		""englishTooltip"": [
			""Fires a terror beam that bounces off tiles"",
			""On every bounce it emits an explosion""
		],
		""name"": ""Lame de Terreur"",
		""tooltip"": [
			""Tire un rayon de terreur qui rebondit sur les tuiles"",
			""Émet une explosion à chaque rebond""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WindBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Wind Blade"",
		""englishTooltip"": [
			""Fires cyclones that suck enemies in""
		],
		""name"": ""Lame de Vent"",
		""tooltip"": [
			""Tire des cyclones qui aspirent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ExecutionersBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Executioner's Blade"",
		""englishTooltip"": [
			""Throws a stream of homing blades"",
			""Stealth strikes summon a guillotine of blades on hit""
		],
		""name"": ""Lame de l'Exécuteur"",
		""tooltip"": [
			""Lance un torrent de lames à tête chercheuse"",
			""Les attaques furtives invoquent une guillotine de lames au toucher""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ForbiddenOathblade"",
		""type"": ""ITEM"",
		""englishName"": ""Forbidden Oathblade"",
		""englishTooltip"": [
			""Fires a demonic scythe and critical hits cause shadowflame explosions""
		],
		""name"": ""Lame-Serment Interdite"",
		""tooltip"": [
			""Tire une faux démoniaque et les coups critiques créent des explosions d'ombreflamme""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EidolicWail"",
		""type"": ""ITEM"",
		""englishName"": ""Eidolic Wail"",
		""englishTooltip"": [
			""Earrape"",
			""Fires a string of bouncing sound waves that become stronger as they travel""
		],
		""name"": ""Lamentation Eidolique"",
		""tooltip"": [
			""Briseur de Tympan"",
			""Tire une chaine d'ondes sonores rebondissantes qui se renforcent au fur et à mesure qu'elles existent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CalamarisLament"",
		""type"": ""ITEM"",
		""englishName"": ""Calamari's Lament"",
		""englishTooltip"": [
			""Summons a squid to fight for you""
		],
		""name"": ""Lamentation de Calamari"",
		""tooltip"": [
			""Invoque un calamar qui combat à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateLamp"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Lamp"",
		""name"": ""Lampe Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PhantomLance"",
		""type"": ""ITEM"",
		""englishName"": ""Phantom Lance"",
		""englishTooltip"": [
			""Fires a spectral javelin that rapidly releases lost souls"",
			""Fades away and slows down over time"",
			""Lost souls released later deal less damage"",
			""Stealth strikes don't slow down and souls always deal full damage""
		],
		""name"": ""Lance Fantôme"",
		""tooltip"": [
			""Tire un javelot spectral qui relâchent rapidement des âmes perdues"",
			""Ralenti et disparaît au fur et à mesure"",
			""Les âmes perdues relâchés tardivement infligent moins de dégâts"",
			""Les attaques furtives ne ralentissent pas et infligent toujours les dégâts maximums""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""IchorSpear"",
		""type"": ""ITEM"",
		""englishName"": ""Ichor Spear"",
		""englishTooltip"": [
			""Throws an ichor tipped trident"",
			""Stealth strikes are showered in splashes of ichor""
		],
		""name"": ""Lance d'Ichor"",
		""tooltip"": [
			""Lance une lance dont la pointe est enduite d'ichor"",
			""Les attaques furtives envoient des faisceaux d'ichor""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StarnightLance"",
		""type"": ""ITEM"",
		""englishName"": ""Starnight Lance"",
		""englishTooltip"": [
			""Shoots a starnight beam""
		],
		""name"": ""Lance de Nuit Étoilée"",
		""tooltip"": [
			""Tire un rayon de nuit étoilée ""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GoldplumeSpear"",
		""type"": ""ITEM"",
		""englishName"": ""Goldplume Spear"",
		""englishTooltip"": [
			""Shoots falling feathers""
		],
		""name"": ""Lance de Plume d'Or"",
		""tooltip"": [
			""Tire des plumes tombantes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HellionFlowerSpear"",
		""type"": ""ITEM"",
		""englishName"": ""Hellion Flower Spear"",
		""englishTooltip"": [
			""Shoots a flower spear tip"",
			""Summons petals from the sky on critical hits""
		],
		""name"": ""Lance de la Fleur de Diablesse"",
		""tooltip"": [
			""Tire une pique de lance florale"",
			""Invoque des pétales depuis le ciel quand vous infligez un critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SpearofDestiny"",
		""type"": ""ITEM"",
		""englishName"": ""Spear of Destiny"",
		""englishTooltip"": [
			""Throws three spears with the outer two having homing capabilities"",
			""Stealth strikes cause all three spears to home in, ignore tiles, and pierce more""
		],
		""name"": ""Lance du Destin"",
		""tooltip"": [
			""Jette trois lances dont les deux sur le côté pourchassent les ennemis."",
			""Les attaques furtives font que toutes les lances pourchassent les ennemis, ignorent les tuiles et percent davantage""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SpearofPaleolith"",
		""type"": ""ITEM"",
		""englishName"": ""Spear of Paleolith"",
		""englishTooltip"": [
			""Throws an ancient spear that shatters enemy armor"",
			""Spears rain fossil shards as they travel"",
			""Stealth strikes travel slower but further, raining more fossil shards""
		],
		""name"": ""Lance du Paléolithe"",
		""tooltip"": [
			""Jette une lance ancienne qui brise l'armure ennemi"",
			""Les lances font pleuvoir des éclats fossiles sur leur trajectoire"",
			""Les attaques furtives sont plus lentes mais vont plus loin, et font pleuvoir plus d'éclats""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MarniteSpear"",
		""type"": ""ITEM"",
		""englishName"": ""Marnite Spear"",
		""name"": ""Lance en Marnite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Meowthrower"",
		""type"": ""ITEM"",
		""englishName"": ""Meowthrower"",
		""englishTooltip"": [
			""50% chance to not consume gel"",
			""Fires blue and pink flames that emit meows on enemy hits""
		],
		""name"": ""Lance-Miaou"",
		""tooltip"": [
			""50% de chances de ne pas consommer de gel"",
			""Tire des flammes bleues et roses qui miaulent quand elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Shadethrower"",
		""type"": ""ITEM"",
		""englishName"": ""Shadethrower"",
		""englishTooltip"": [
			""66% chance to not consume gel""
		],
		""name"": ""Lance-Ombre"",
		""tooltip"": [
			""66% de chances de ne pas consommer de gel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AuroradicalThrow"",
		""type"": ""ITEM"",
		""englishName"": ""Auroradical Throw"",
		""englishTooltip"": [
			""Launches a star that splits after a short period of time"",
			""Split stars home in on nearby enemies after a few seconds"",
			""Stealth strikes summon a meteor upon enemy impact""
		],
		""name"": ""Lancer Radicalaurore"",
		""tooltip"": [
			""Lance une étoile qui se divisent après un court moment"",
			""Les étoiles résultantes se dirigent vers les ennemis après un instant"",
			""Les attaques furtives invoquent un météore quand les ennemis sont touchés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateLantern"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Lantern"",
		""name"": ""Lanterne Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CausticTear"",
		""type"": ""ITEM"",
		""englishName"": ""Caustic Tear"",
		""englishTooltip"": [
			""Causes an acidic downpour in the Sulphurous Sea"",
			""Not consumable""
		],
		""name"": ""Larme Caustique"",
		""tooltip"": [
			""Provoque un déluge d'acide dans la mer du sulfure"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TearsofHeaven"",
		""type"": ""ITEM"",
		""englishName"": ""Tears of Heaven"",
		""englishTooltip"": [
			""Casts slow-moving homing balls of heavenly light""
		],
		""name"": ""Larme Céleste"",
		""tooltip"": [
			""Invoque de lentes balles de lumière céleste à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TorrentialTear"",
		""type"": ""ITEM"",
		""englishName"": ""Torrential Tear"",
		""englishTooltip"": [
			""Summons the rain."",
			""Rain will start some time after this item is used."",
			""If used while it's raining, the rain will stop some time afterward.""
		],
		""name"": ""Larme Torrentielle"",
		""tooltip"": [
			""Invoque la pluie."",
			""La pluie commencera peu après l'utilisation de cet objet."",
			""S'il pleut déja, la pluie s'arrêtera peu après l'utilisation de cet objet.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Laudanum"",
		""type"": ""ITEM"",
		""englishName"": ""Laudanum"",
		""englishTooltip"": [
			""Converts certain debuffs into buffs and extends their durations"",
			""Debuffs affected: Darkness, Blackout, Confused, Slow, Weak, Broken Armor,"",
			""Armor Crunch, War Cleave, Chilled, Ichor and Obstructed"",
			""Revengeance drop""
		],
		""name"": ""Laudanum"",
		""tooltip"": [
			""Convertit certaines altérations en améliorations et étend leur durée"",
			""Altérations concernées: Obscurité, Trou noir, Confusion, Ralenti, Faible, Armure brisée,"",
			""Armure abimée, Fendreguerre, Refroidissement, Ichor et Obstruction"",
			""Revengeance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Lazhar"",
		""type"": ""ITEM"",
		""englishName"": ""Lazhar"",
		""englishTooltip"": [
			""Fires a bouncing laser that explodes on enemy hits""
		],
		""name"": ""Lazher"",
		""tooltip"": [
			""Tire un rayon laser qui rebondit et explose quand il touche""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheCamper"",
		""type"": ""ITEM"",
		""englishName"": ""The Camper"",
		""englishTooltip"": [
			""In rest may we find victory."",
			""You deal 90% less damage unless stationary"",
			""Standing still grants buff(s) dependent on what weapon you're holding"",
			""Standing still provides a damaging aura around you"",
			""While moving, you regenerate health as if standing still"",
			""Provides a small amount of light in the Abyss""
		],
		""name"": ""Le Campeur"",
		""tooltip"": [
			""Puisse le repos nous apporter la victoire."",
			""Vous infligez 90% de dégâts en moins si vous n'êtes pas immobile"",
			""Rester immobile vous accorde une amélioration en fonction de l'arme que vous tenez"",
			""Vous émettez une aura qui inflige des dégâts quand vous êtes immobile"",
			""Quand vous vous déplacez, vous récupérez de la vie comme si vous étiez immobile"",
			""Émet une petite quantité de lumière dans les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeCrimson"",
		""type"": ""ITEM"",
		""englishName"": ""The Crimson"",
		""englishTooltip"": [
			""This bloody hell, spawned from a formless mass of flesh that fell from the stars eons ago."",
			""It is now home to many hideous creatures, spawned from the pumping blood and lurching organs deep within.""
		],
		""name"": ""Le Carmin"",
		""tooltip"": [
			""Cet enfer sanglant, apparu depuis qu'une masse de chair informe s'est abattue depuis les étoiles il a une éternité."",
			""C'est maintenant le foyer d'hideuses créatures, créées par le sang fluctuant et les organes chancelants profondéments enfouis.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeBrainofCthulhu"",
		""type"": ""ITEM"",
		""englishName"": ""The Brain of Cthulhu"",
		""englishTooltip"": [
			""An eye and now a brain."",
			""Most likely another abomination spawned from this inchoate mass of flesh.""
		],
		""name"": ""Le Cerveau de Cthulhu"",
		""tooltip"": [
			""Un oeil et maintenant un cerveau."",
			""Très probablement une autre abomination créée par cette imparfaite masse de chair.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheBurningSky"",
		""type"": ""ITEM"",
		""englishName"": ""The Burning Sky"",
		""englishTooltip"": [
			""Hold the blade to the sky, and witness Armageddon""
		],
		""name"": ""Le Ciel Brûlant"",
		""tooltip"": [
			""Pointez la lame vers le ciel, et soyez témoin de l'Armageddon""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FinalDawn"",
		""type"": ""ITEM"",
		""englishName"": ""The Final Dawn"",
		""englishTooltip"": [
			""We shall ride into the sunrise once more"",
			""Attack enemies with a giant scythe swing to replenish stealth"",
			""Press up and attack to throw the scythe "",
			""Stealth strikes perform a horizontal swing that leaves a lingering fire aura"",
			""Stealth strikes performed while pressing up fling yourself at the enemy and slice through them, causing homing fireballs to emerge""
		],
		""name"": ""Le Dernier Crépuscule"",
		""tooltip"": [
			""Nous chevaucherons vers le soleil levant à nouveau"",
			""Attaque les ennemis avec un coup de faux géante pour récupérer de la furtivité"",
			""Appuyez sur Haut et attaquez pour jeter la faux"",
			""Les attaques furtives effectue une attaque horizontale qui laisse une trainée de feu rémanente"",
			""Les attaques furtives de lancer vous envoient vers l'ennemi et les découpent, créant des boules de feu à tête chercheuse au passage""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheLastMourning"",
		""type"": ""ITEM"",
		""englishName"": ""The Last Mourning"",
		""englishTooltip"": [
			""Summons flaming pumpkins and mourning skulls that split into fire orbs on enemy hits""
		],
		""name"": ""Le Dernier Deuil"",
		""tooltip"": [
			""Invoque des citrouilles enflammées et des têtes de mort qui se séparent en orbe de feu quand elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeDestroyer"",
		""type"": ""ITEM"",
		""englishName"": ""The Destroyer"",
		""englishTooltip"": [
			""A machine brought to life by the mighty souls of warriors, and built to excavate massive tunnels in planets to gather resources."",
			""Could have proven useful if Draedon didn't have an obsession with turning everything into a tool of destruction.""
		],
		""name"": ""Le Destructeur"",
		""tooltip"": [
			""Une machine née de puissantes âmes de guerriers, créée pour creuser des galeries massives dans la planète pour récolter ses ressources."",
			""Elle aurait pu être utile si Draedon n'avait pas pour obsession de tout transformer en outil de destruction.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeSlimeGod"",
		""type"": ""ITEM"",
		""englishName"": ""The Slime God"",
		""englishTooltip"": [
			""It is a travesty, one of the most threatening biological terrors ever created."",
			""If this creature were allowed to combine every slime on the planet it would become nearly unstoppable.""
		],
		""name"": ""Le Dieu des Gelées"",
		""tooltip"": [
			""C'est une perversion, l'une des terreurs biologiques les plus menaçantes jamais créée."",
			""Si on laissait cete créature absorber toutes les gelées de la planète elle deviendrait presque inarrêtable.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeDevourerofGods"",
		""type"": ""ITEM"",
		""englishName"": ""The Devourer of Gods"",
		""englishTooltip"": [
			""This serpent’s power to assimilate the abilities and energy of those it consumed is unique in almost all the known cosmos, save for its lesser brethren."",
			""I would have soon had to eliminate it as a threat had it been given more time and creatures to feast upon.""
		],
		""name"": ""Le Dévoreur de Dieux"",
		""tooltip"": [
			""Le pouvoir d'assimiler les aptitudes et l'énergie de ceux qu'il a dévoré est unique dans tout le cosmos connu, si ce n'est celui de ses semblables inférieurs."",
			""J'aurais eu à l'éliminer sous peu telle la menace qu'il serait devenu s'il avait eu plus de temps et de proies desquelles se repaître.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheDevourerofCods"",
		""type"": ""ITEM"",
		""englishName"": ""The Devourer of Cods"",
		""englishTooltip"": [
			""Fires ten lines at once. Line never snaps and can fish from lava."",
			""The devourer was once just an Eater of Shoals.""
		],
		""name"": ""Le Dévoreur de Lieus"",
		""tooltip"": [
			""Lance dix lignes à la fois. La ligne ne se brise jamais et peut pêcher dans la lave."",
			""Le dévoreur n'était autrefois qu'un dévoreur de bancs.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeEaterofWorlds"",
		""type"": ""ITEM"",
		""englishName"": ""The Eater of Worlds"",
		""englishTooltip"": [
			""Perhaps it was just a giant worm infected by the microbe, given centuries to feed and grow its festering body."",
			""Seems likely, given the origins of this place.""
		],
		""name"": ""Le Dévoreur de Mondes"",
		""tooltip"": [
			""Peut-être que ce n'était qu'un ver géant infecté par le microbe, dévorant et grandissant dans ce corps pourrissant durant des siècles."",
			""Ca semble probable, vu les origines de cet endroit.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheReaper"",
		""type"": ""ITEM"",
		""englishName"": ""The Reaper"",
		""englishTooltip"": [
			""Slice 'n dice"",
			""Stealth strikes throw four at once""
		],
		""name"": ""Le Faucheur"",
		""tooltip"": [
			""Découpe en petits morceaux"",
			""Les attaques furtives en lancent 4 en même temps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeDesertScourge"",
		""type"": ""ITEM"",
		""englishName"": ""The Desert Scourge"",
		""englishTooltip"": [
			""The great sea worm appears to have survived the extreme heat and has even adapted to it."",
			""What used to be a majestic beast swimming through the water has now become a dried-up and"",
			""gluttonous husk, constantly on a voracious search for its next meal.""
		],
		""name"": ""Le Fléau du Désert"",
		""tooltip"": [
			""On dirait que le grand ver marin à survécu à la chaleur extreme, et s'y est même adapté."",
			""Ce qui était autrefois une bête majestueuse nageant dans les mers est maintenant une carcasse"",
			""desséchée, constamment à la recherche vorace de son prochain repas.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgePlaguebringerGoliath"",
		""type"": ""ITEM"",
		""englishName"": ""The Plaguebringer Goliath"",
		""englishTooltip"": [
			""A horrific amalgam of steel, flesh, and infection, capable of destroying an entire civilization in just one onslaught."",
			""Its plague nuke barrage can leave an entire area uninhabitable for months. A shame that it came to this but the plague must be contained.""
		],
		""name"": ""Le Goliath Colporte-Peste"",
		""tooltip"": [
			""Un horrible amalgame d'acier, de chair et d'infection, capable de détruire une civilisation entière en une seule offensive."",
			""Son bombardement de peste peut rendre une zone entière inhabitable durant des mois. C'est dommage qu'on en soit arrivé la, mais la peste doit être confinée.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheMicrowave"",
		""type"": ""ITEM"",
		""englishName"": ""The Microwave"",
		""englishTooltip"": [
			""Fries nearby enemies with radiation"",
			""A very agile yoyo"",
			""Cooking, Astral Infection style""
		],
		""name"": ""Le Micro-Onde"",
		""tooltip"": [
			""Fait cuire les ennemis proches avec des radiations"",
			""Un yoyo très agile"",
			""La cuisine, façon infection astrale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheMutilator"",
		""type"": ""ITEM"",
		""englishName"": ""The Mutilator"",
		""englishTooltip"": [
			""Striking an enemy below 20% life will trigger a bloodsplosion"",
			""Bloodsplosions cause hearts to drop that can be picked up to heal you""
		],
		""name"": ""Le Mutilateur"",
		""tooltip"": [
			""Frapper un ennemi en dessous de 20% de vie déclenchera une explosion de sang"",
			""Les explosions de sang font tomber des coeurs de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ThePack"",
		""type"": ""ITEM"",
		""englishName"": ""The Pack"",
		""englishTooltip"": [
			""Fires large homing rockets that explode into more homing mini rockets when in proximity to an enemy""
		],
		""name"": ""Le Pack"",
		""tooltip"": [
			""Tire de larges roquettes à tête chercheuse qui explosent en plus de mini-roquettes à tête chercheuse quand elles sont à proximité des ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeKingSlime"",
		""type"": ""ITEM"",
		""englishName"": ""King Slime"",
		""englishTooltip"": [
			""Only a fool could be caught by this pitiful excuse for a hunter."",
			""Unfortunately, our world has no shortage of those.""
		],
		""name"": ""Le Roi des Gelées"",
		""tooltip"": [
			""Seul un idiot peut se faire avoir par ce pitoyable simulacre de chasseur."",
			""Malheureusement, notre monde regorge d'idiots de ce genre.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TheTransformer"",
		""type"": ""ITEM"",
		""englishName"": ""The Transformer"",
		""englishTooltip"": [
			""Taking damage releases a blast of sparks"",
			""Immunity to Electrified and you resist all electrical projectile and enemy damage"",
			""Enemy bullets do half damage to you and are reflected back at the enemy for 800% their original damage""
		],
		""name"": ""Le Tranformateur"",
		""tooltip"": [
			""Prendre des dégâts vous fait émettre des étincelles"",
			""Immunité à électrisé et à tous les dégâts électriques"",
			""Les balles ennemis ne vous infligent que la moitié des dégâts et sont réfléchies pour 800% de leur dégâts initiaux""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeMechs"",
		""type"": ""ITEM"",
		""englishName"": ""The Mechanical Trio"",
		""englishTooltip"": [
			""I see you have awakened Draedon's old toys."",
			""Once useful tools turned into savage beasts when their AIs went rogue, a mistake that Draedon failed to rectify in time.""
		],
		""name"": ""Le Trio Mécanique"",
		""tooltip"": [
			""Je vois que vous avez réveillé les vieux jouets de Draedon."",
			""Ce qui fut autrefois d'utiles outils se sont transformés en bêtes sauvages une fois que leur IA se sont rebellées, une erreur que Draedon a échoué a rectifier à temps.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeProfanedGuardians"",
		""type"": ""ITEM"",
		""englishName"": ""The Profaned Guardians"",
		""englishTooltip"": [
			""The ever-rejuvenating guardians of the profaned flame."",
			""Much like a phoenix from the ashes their deaths are simply a part of their life cycle."",
			""Many times my forces have had to destroy these beings in search of the Profaned Goddess.""
		],
		""name"": ""Les Gardiens Profanés"",
		""tooltip"": [
			""Les éternels renaissants guardiens de la flamme profanée."",
			""Tout comme le phénix qui renaît de ses cendres, leurs morts fait simplement partie de leur cycle de vie."",
			""De nombreuses fois, mes forces ont du détruire ces êtres dans leur recherche de la déesse profanée.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeTwins"",
		""type"": ""ITEM"",
		""englishName"": ""The Twins"",
		""englishTooltip"": [
			""The bio-mechanical watchers of the night, originally created as security using the souls extracted from human eyes."",
			""These creatures did not belong in this world, it's best to be rid of them.""
		],
		""name"": ""Les Jumeaux"",
		""tooltip"": [
			""Les vigiles biomécaniques de la nuit, originellement crées à des fins de surveillance en utilisant les âmes extraites d'yeux humains."",
			""Ces créatures n'étaient pas de ce monde, c'est une bonne chose de s'en être débarassé.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgePerforators"",
		""type"": ""ITEM"",
		""englishName"": ""The Perforators and their Hive"",
		""englishTooltip"": [
			""An abomination of comingled flesh, bone, and organ, infested primarily by blood-slurping worms.""
		],
		""name"": ""Les Perforateurs et leur Nid"",
		""tooltip"": [
			""Une abomination mélée de sang, d'os et d'organes, principalement infestée par des vers suceurs de sang.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeSentinels"",
		""type"": ""ITEM"",
		""englishName"": ""The Sentinels of the Devourer"",
		""englishTooltip"": [
			""Signus. The Void. The Weaver."",
			""Each represent one of the Devourer’s largest spheres of influence."",
			""Dispatching them has most likely invoked its anger and marked you as a target for destruction.""
		],
		""name"": ""Les Sentinelles du Dévoreur"",
		""tooltip"": [
			""Signus. Le vide. Le tisseur."",
			""Chacun représente l'une des plus grandes sphères d'influence du dévoreur."",
			""S'en débarasser à très probablement provoqué sa colère et vous a désigné comme une cible à détruire.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Levi"",
		""type"": ""ITEM"",
		""englishName"": ""Levi"",
		""englishTooltip"": [
			""Summons a baby Leviathan pet""
		],
		""name"": ""Levi"",
		""tooltip"": [
			""Invoque un bébé Leviathan apprivoisé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Leviatitan"",
		""type"": ""ITEM"",
		""englishName"": ""Leviatitan"",
		""englishTooltip"": [
			""Converts musket balls into toxic and normal water blasts""
		],
		""name"": ""Leviatitan"",
		""tooltip"": [
			""Convertit les balles de mousquet en décharges d'eau normale et d'eau toxique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LightningHawk"",
		""type"": ""ITEM"",
		""englishName"": ""Lightning Hawk"",
		""englishTooltip"": [
			""Uses Magnum Rounds"",
			""Can be used thrice per boss battle""
		],
		""name"": ""Lightning Hawk"",
		""tooltip"": [
			""Utilise des balles de magnum"",
			""Peut être utilisé trois fois par combat de boss""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CursedCapper"",
		""type"": ""ITEM"",
		""englishName"": ""Cursed Capper"",
		""englishTooltip"": [
			""Fires cursed bullets""
		],
		""name"": ""Limiteur Maudit"",
		""tooltip"": [
			""Tire des balles maudites""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RadiantOoze"",
		""type"": ""ITEM"",
		""englishName"": ""Radiant Ooze"",
		""englishTooltip"": [
			""You emit light and regen life more quickly at night""
		],
		""name"": ""Limon Radieux"",
		""tooltip"": [
			""Vous émettez de la lumière et régénérez votre vie plus rapidement la nuit""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralBar"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Bar"",
		""name"": ""Lingot Astral"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AerialiteBar"",
		""type"": ""ITEM"",
		""englishName"": ""Aerialite Bar"",
		""name"": ""Lingot d'Aérialite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmiliteBar"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmilite Bar"",
		""englishTooltip"": [
			""A chunk of durable and highly resilient cosmic steel""
		],
		""name"": ""Lingot de Cosmilite"",
		""tooltip"": [
			""Un morceau d'acier cosmique hautement durable et résistant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LionHeart"",
		""type"": ""ITEM"",
		""englishName"": ""Lion Heart"",
		""englishTooltip"": [
			""Summons an energy explosion on enemy hits"",
			""Right click to summon an energy shell for a few seconds that halves all damage sources"",
			""This has a 45 second cooldown""
		],
		""name"": ""Lion Heart"",
		""tooltip"": [
			""Invoque une explosion d'énergie quand vous touchez"",
			""Clic droit pour invoquer une carapace d'énergie pendant quelques secondes qui divise par deux les dégâts"",
			""Cet effet a 45s de temps de recharge""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GreenwaveLoach"",
		""type"": ""ITEM"",
		""englishName"": ""Greenwave Loach"",
		""englishTooltip"": [
			""An endangered fish that is highly prized in the market""
		],
		""name"": ""Loche Vertevague"",
		""tooltip"": [
			""Une espèce en danger qui est hautement prisée sur le marché""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimstoneLocus"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Locus"",
		""englishTooltip"": [
			""Not only can I enhance your equipment with potent magic, I can also draw out the true strength and ascend"",
			""some of your weaponry to entirely new forms"",
			""Such items are revealed while this item is in your inventory""
		],
		""name"": ""Locus de Soufre"",
		""tooltip"": [
			""Je peux non seulement améliorer ton équipement avec une puissante magie, je peux aussi faire ressortir sa vraie force et transcender"",
			""certaines de tes armes dans de toutes nouvelles formes"",
			""Ces objets sont révélés quand cet objet est dans votre inventaire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Lucrecia"",
		""type"": ""ITEM"",
		""englishName"": ""Lucrecia"",
		""englishTooltip"": [
			""Finesse"",
			""Striking an enemy makes you immune for a short time"",
			""Fires a DNA chain""
		],
		""name"": ""Lucrecia"",
		""tooltip"": [
			""Finesse"",
			""Frapper un ennemi vous immunise un instant"",
			""Tire une séquence ADN""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CrescentMoon"",
		""type"": ""ITEM"",
		""englishName"": ""Crescent Moon"",
		""englishTooltip"": [
			""People wanted the moon, let's bring the moon to them."",
			""Fires a whip sword that summons homing crescent moons""
		],
		""name"": ""Lune en Croissant"",
		""tooltip"": [
			""Les gens voulaient la lune, amenons leur la lune."",
			""Tire une épée-fouet qui invoque des croissants de lune à têtes chercheuses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SDFMG"",
		""type"": ""ITEM"",
		""englishName"": ""SDFMG"",
		""englishTooltip"": [
			""It came from the edge of Terraria"",
			""50% chance to not consume ammo""
		],
		""name"": ""MDDS"",
		""tooltip"": [
			""Il vient d'Edge of Terraria"",
			""50% de chances de ne pas consommer de munitions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MOAB"",
		""type"": ""ITEM"",
		""englishName"": ""MOAB"",
		""englishTooltip"": [
			""The mother of all balloons"",
			""Counts as wings"",
			""Horizontal speed: 6.50"",
			""Acceleration multiplier: 1.0"",
			""Good vertical speed"",
			""Flight time: 75"",
			""10% increased jump speed and allows constant jumping"",
			""Grants the player cloud, blizzard, and sandstorm mid-air jumps""
		],
		""name"": ""MDTB"",
		""tooltip"": [
			""La mère de tous les ballons"",
			""Compte comme des ailes"",
			""Vitesse Horizontale: 6.5"",
			""Multiplicateur d'accélération: 1"",
			""Bonne vitesse verticale"",
			""Temps de vol: 75"",
			""+10% de vitesse de saut et permet le saut automatique"",
			""Donne au joueur les sauts de nuage, de blizzard et de tempête de sable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""JawsOfOblivion"",
		""type"": ""ITEM"",
		""englishName"": ""Jaws of Oblivion"",
		""englishTooltip"": [
			""Throws a tight spread of six venomous reaper fangs that stick in enemies"",
			""Stealth strikes cause the teeth to emit a crushing shockwave on impact"",
			""You're gonna need a bigger boat""
		],
		""name"": ""Machoires de l'Oubli"",
		""tooltip"": [
			""Jette une étendue resserrée de six dents venimeuses de faucheur qui se plantent dans les ennemis"",
			""Les attaques furtives provoquent une onde de choc écrasante à l'impact des dents"",
			""On va avoir besoin d'un plus gros bâteau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GleamingMagnolia"",
		""type"": ""ITEM"",
		""englishName"": ""Gleaming Magnolia"",
		""englishTooltip"": [
			""Casts a gleaming flower that explodes into petals""
		],
		""name"": ""Magnolia Étincellant"",
		""tooltip"": [
			""Convoque une fleur étincellante qui explose en pétales""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Magnum"",
		""type"": ""ITEM"",
		""englishName"": ""Magnum"",
		""englishTooltip"": [
			""Uses Magnum Rounds"",
			""Can be used thrice per boss battle""
		],
		""name"": ""Magnum"",
		""tooltip"": [
			""Utilise des balles de magnum"",
			""Peut être utilisé trois fois par combat de boss""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SlagMagnum"",
		""type"": ""ITEM"",
		""englishName"": ""Slag Magnum"",
		""englishTooltip"": [
			""Converts musket balls into fossil shards that split into additional shards on death""
		],
		""name"": ""Magnum de Scories"",
		""tooltip"": [
			""Convertit les balles de mousquet en éclats de fossiles qui se divisent en éclats additionnels""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Malachite"",
		""type"": ""ITEM"",
		""englishName"": ""Malachite"",
		""englishTooltip"": [
			""Throws a stream of kunai that stick to enemies and explode"",
			""Right click to throw a single kunai that pierces, after piercing an enemy it emits a massive explosion on the next enemy hit"",
			""Stealth strikes fire three kunai that home in, stick to enemies, and explode""
		],
		""name"": ""Malachite"",
		""tooltip"": [
			""Jette un torrent de kunaï qui se plantent dans les ennemis et explosent"",
			""Clic droit pour jeter un seul kunaï qui perce, et qui émet une explosion massive si il touche un ennemi après avoir percé"",
			""Les attaques furtives trois kunaïs explosifs à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Malevolence"",
		""type"": ""ITEM"",
		""englishName"": ""Malevolence"",
		""englishTooltip"": [
			""Fires two arrows at once"",
			""Converts wooden arrows into plague arrows that explode into bees on death""
		],
		""name"": ""Malveillance"",
		""tooltip"": [
			""Tire deux flèches à la fois"",
			""Convertit les flèches en bois en flèches de pestes qui explosent en abeilles à l'impact""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StatisCurse"",
		""type"": ""ITEM"",
		""englishName"": ""Statis' Curse"",
		""englishTooltip"": [
			""Increases max minions by 3, does not stack with downgrades"",
			""10% increased minion damage"",
			""Increased minion knockback"",
			""Minions inflict holy flames and shadowflames on hit"",
			""Grants immunity to Shadowflame""
		],
		""name"": ""Malédiction de Statis"",
		""tooltip"": [
			""+3 sbires max et +10% dégâts d'invocation, ne se cumule pas avec les accessoires le composant"",
			""+10% de dégâts des sbires"",
			""Recul des sbires augmenté"",
			""Les sbires infligent les flammes d'ombres et sacrées quand ils touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StormlionMandible"",
		""type"": ""ITEM"",
		""englishName"": ""Stormlion Mandible"",
		""name"": ""Mandibule de Fourmillon Tempête"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MolecularManipulator"",
		""type"": ""ITEM"",
		""englishName"": ""Molecular Manipulator"",
		""englishTooltip"": [
			""Is it nullable or not? Let's find out!"",
			""Fires a fast null bullet that distorts NPC stats""
		],
		""name"": ""Manipulateur Moléculaire"",
		""tooltip"": [
			""On peut le mettre à null ou pas? Et bien on va voir!"",
			""Tire une balle null qui dénature les statistiques des ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FrequencyManipulator"",
		""type"": ""ITEM"",
		""englishName"": ""Frequency Manipulator"",
		""englishTooltip"": [
			""A long device, used in the tuning of some rather... original machines"",
			""Swings a spear around and then throws it"",
			""On collision, the spear releases a burst of homing energy"",
			""Stealth strikes release more energy and explode on collision""
		],
		""name"": ""Manipulateur de Fréquence"",
		""tooltip"": [
			""Une machine élancée, utilisé pour le réglage de certaines machines ... originales."",
			""Agite une lance avant de la lancer"",
			""A l'impact, la lance relâche une vague d'énergie à tête chercheuse"",
			""Les attaques furtives relâchent plus d'énergie et explosent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SandCloak"",
		""type"": ""ITEM"",
		""englishName"": ""Sand Cloak"",
		""englishTooltip"": [
			""+1 defense and 5% increased movement speed"",
			""TOOLTIP LINE HERE"",
			""This effect has a 30 second cooldown before it can be used again""
		],
		""name"": ""Manteau des Sables"",
		""tooltip"": [
			""+1 défense et +5% vitesse de mouvement"",
			""TOOLTIP LINE HERE"",
			""Cet effet à un temps de recharge de 30s""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TitanHeartMantle"",
		""type"": ""ITEM"",
		""englishName"": ""Titan Heart Mantle"",
		""englishTooltip"": [
			""45% chance to not consume rogue items"",
			""5% boosted rogue knockback but 15% lowered rogue attack speed""
		],
		""name"": ""Manteau du Coeur de Titan"",
		""tooltip"": [
			""45% de chances de ne pas consommer les armes de voleur"",
			""+5% de recul de voleur mais la vitesse de tir de voleur est réduite de 15%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueReaperStriders"",
		""type"": ""ITEM"",
		""englishName"": ""Plague Reaper Striders"",
		""englishTooltip"": [
			""3% increased ranged critical strike chance"",
			""15% increased movement speed""
		],
		""name"": ""Marcheurs du Faucheur de Peste"",
		""tooltip"": [
			""+3% de chances de coup critique"",
			""+15% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Margarita"",
		""type"": ""ITEM"",
		""englishName"": ""Margarita"",
		""englishTooltip"": [
			""One of the best drinks ever created, enjoy it while it lasts"",
			""Reduces the duration of most debuffs"",
			""Reduces defense by 6% and life regen by 1"",
			""3 minute duration""
		],
		""name"": ""Margarita"",
		""tooltip"": [
			""Un des meilleurs alcools jamais crée, profite en pendant que ça dure"",
			""Réduit la durée de la plupart des altérations d'états"",
			""Réduit la défense de 6% et la régénération de vie de 1"",
			""Dure 3 minutes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralHamaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Hamaxe"",
		""name"": ""Martache Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AerialHamaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Aerial Hamaxe"",
		""name"": ""Martache Aérienne"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ReefclawHamaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Reefclaw Hamaxe"",
		""name"": ""Martache de Récigriffe"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumHammer"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Hammer"",
		""name"": ""Marteau Wulfrum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssalWarhammer"",
		""type"": ""ITEM"",
		""englishName"": ""Abyssal Warhammer"",
		""name"": ""Marteau de Guerre Abyssal"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Pwnagehammer"",
		""type"": ""ITEM"",
		""englishName"": ""Pwnagehammer"",
		""englishTooltip"": [
			""Throws a heavy, gravity-affected hammer that creates a loud blast of hallowed energy when it hits something"",
			""There is a 20 percent chance for the hammer to home in on a target"",
			""Homing hammers summon an additional spectral hammer on hit and are guaranteed to land a critical hit""
		],
		""name"": ""Marteau de Pwnage"",
		""tooltip"": [
			""Jette un lourd marteau affecté par la gravité qui crée une bruyante explosion d'énergie sacrée qui il heurte quelque chose"",
			""20% de chances que le marteau pourchasse sa cible"",
			""Ces marteaux invoquent un marteau spectral quand ils touchent qui inflige forcément un coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AuricTeslaHoodedFacemask"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Hooded Facemask"",
		""englishTooltip"": [
			""30% increased ranged damage and critical strike chance""
		],
		""name"": ""Masque Facial Voilé Tesla Aurique"",
		""tooltip"": [
			""+30% de dégâts et de chances de coup critique à distance"",
			""Rester immobile augmente tous les dégâts et les chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AnahitaMask"",
		""type"": ""ITEM"",
		""englishName"": ""Anahita Mask"",
		""name"": ""Masque d'Anahita"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ApolloMask"",
		""type"": ""ITEM"",
		""englishName"": ""Apollo Mask"",
		""name"": ""Masque d'Apollo"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ArtemisMask"",
		""type"": ""ITEM"",
		""englishName"": ""Artemis Mask"",
		""name"": ""Masque d'Artemis"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AresMask"",
		""type"": ""ITEM"",
		""englishName"": ""Ares Mask"",
		""name"": ""Masque d'Arès"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstrumDeusMask"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Deus Mask"",
		""name"": ""Masque d'Astrum Deus"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimstoneWaifuMask"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Elemental Mask"",
		""name"": ""Masque d'Élementaire de Soufre"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CalamitasMask"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitas Mask"",
		""name"": ""Masque de Calamitas"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrabulonMask"",
		""type"": ""ITEM"",
		""englishName"": ""Crabulon Mask"",
		""name"": ""Masque de Crabulon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CryogenMask"",
		""type"": ""ITEM"",
		""englishName"": ""Cryogen Mask"",
		""name"": ""Masque de Cryogène"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AquaticScourgeMask"",
		""type"": ""ITEM"",
		""englishName"": ""Aquatic Scourge Mask"",
		""name"": ""Masque de Fléau Aquatique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProvidenceMask"",
		""type"": ""ITEM"",
		""englishName"": ""Providence Mask"",
		""name"": ""Masque de Providence"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SignusMask"",
		""type"": ""ITEM"",
		""englishName"": ""Signus Mask"",
		""name"": ""Masque de Signus"",
		""state"": ""Traduit""
	},
	{
		""id"": ""YharonMask"",
		""type"": ""ITEM"",
		""englishName"": ""Yharon Mask"",
		""name"": ""Masque de Yharon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HiveMindMask"",
		""type"": ""ITEM"",
		""englishName"": ""Hive Mind Mask"",
		""name"": ""Masque de l'Esprit de Ruche"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PolterghastMask"",
		""type"": ""ITEM"",
		""englishName"": ""Polterghast Mask"",
		""name"": ""Masque de l'Épouvantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BumblefuckMask"",
		""type"": ""ITEM"",
		""englishName"": ""Dragonfolly Mask"",
		""name"": ""Masque de la Dracofolie"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TitanHeartMask"",
		""type"": ""ITEM"",
		""englishName"": ""Titan Heart Mask"",
		""englishTooltip"": [
			""5% increased rogue damage and knockback"",
			""Rogue weapons inflict the Astral Infection debuff""
		],
		""name"": ""Masque du Coeur de Titan"",
		""tooltip"": [
			""+5% de dégâts et de recul de voleur"",
			""Les armes de voleur infligent l'infection astrale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SlimeGodMask"",
		""type"": ""ITEM"",
		""englishName"": ""Slime God Mask"",
		""name"": ""Masque du Dieu des Gelées"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SlimeGodMask2"",
		""type"": ""ITEM"",
		""englishName"": ""Slime God Mask"",
		""name"": ""Masque du Dieu des Gelées"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DevourerofGodsMask"",
		""type"": ""ITEM"",
		""englishName"": ""Devourer of Gods Mask"",
		""name"": ""Masque du Dévoreur de Dieux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueReaperMask"",
		""type"": ""ITEM"",
		""englishName"": ""Plague Reaper Mask"",
		""englishTooltip"": [
			""10% increased ranged damage and 8% increased ranged critical strike chance""
		],
		""name"": ""Masque du Faucheur de Peste"",
		""tooltip"": [
			""+10% de dégâts à distance et +8% de chances de coup critique à distance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DesertScourgeMask"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Scourge Mask"",
		""name"": ""Masque du Fléau du Désert"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedGuardianMask"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Guardian Mask"",
		""name"": ""Masque du Gardien Profané"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguebringerGoliathMask"",
		""type"": ""ITEM"",
		""englishName"": ""Plaguebringer Goliath Mask"",
		""name"": ""Masque du Goliath Colporte-Peste"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LeviathanMask"",
		""type"": ""ITEM"",
		""englishName"": ""Leviathan Mask"",
		""name"": ""Masque du Leviathan"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CeaselessVoidMask"",
		""type"": ""ITEM"",
		""englishName"": ""Ceaseless Void Mask"",
		""name"": ""Masque du Néant Incessant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorMask"",
		""type"": ""ITEM"",
		""englishName"": ""Perforator Mask"",
		""name"": ""Masque du Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RavagerMask"",
		""type"": ""ITEM"",
		""englishName"": ""Ravager Mask"",
		""name"": ""Masque du Ravageur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""StormWeaverMask"",
		""type"": ""ITEM"",
		""englishName"": ""Storm Weaver Mask"",
		""name"": ""Masque du Tisse-Tempête"",
		""state"": ""Traduit""
	},
	{
		""id"": ""OldDukeMask"",
		""type"": ""ITEM"",
		""englishName"": ""Old Duke Mask"",
		""name"": ""Masque du Vieux Dic"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SnowRuffianMask"",
		""type"": ""ITEM"",
		""englishName"": ""Snow Ruffian Mask"",
		""englishTooltip"": [
			""2% increased rogue damage""
		],
		""name"": ""Masque du Voyou des Neiges"",
		""tooltip"": [
			""+2% de dégâts de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssalDivingGear"",
		""type"": ""ITEM"",
		""englishName"": ""Abyssal Diving Gear"",
		""englishTooltip"": [
			""Reduces the damage caused by the pressure of the abyss while out of breath"",
			""Removes the bleed effect caused by the abyss"",
			""Grants the ability to swim and greatly extends underwater breathing"",
			""Provides light underwater and extra mobility on ice"",
			""Provides a moderate amount of light in the abyss"",
			""Greatly reduces breath loss in the abyss""
		],
		""name"": ""Matériel de plongée abyssal"",
		""tooltip"": [
			""Réduit les dégâts infligés par la pression des abysses lorsque vous n'avez plus d'air"",
			""Annule l'effet de saignement provoqué par les abysses"",
			""Vous permet de nager et augmente considérablement votre temps de respiration sous l'eau"",
			""Emet de la lumière sous l'eau et permet de mieux se déplacer sur la glace"",
			""Accorde un montant de lumière modéré dans les abysses"",
			""Réduit considérablement la perte de respiration dans les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StormRuler"",
		""type"": ""ITEM"",
		""englishName"": ""Storm Ruler"",
		""englishTooltip"": [
			""Only a storm can fell a greatwood"",
			""Fires beams that generate tornadoes on death"",
			""Tornadoes suck enemies in""
		],
		""name"": ""Maître des Tempêtes"",
		""tooltip"": [
			""Seul une tempête peut mettre à genoux un grand bois"",
			""Tire des rayons qui génèrent des tornades"",
			""Les tornades attirent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BurningSea"",
		""type"": ""ITEM"",
		""englishName"": ""Burning Sea"",
		""englishTooltip"": [
			""Fires a bouncing brimstone fireball that splits into homing fireballs upon collision with water""
		],
		""name"": ""Mer Enflammée"",
		""tooltip"": [
			""Tire une boule de feu de soufre rebondissante qui se divise en boules de feu à tête chercheuse lors d'une collision avec l'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Miasma"",
		""type"": ""ITEM"",
		""englishName"": ""Miasma"",
		""englishTooltip"": [
			""Fires a spread of gas clouds that slow down after hitting an enemy""
		],
		""name"": ""Miasme"",
		""tooltip"": [
			""Relâche des nuages de gaz qui ralentissent après avoir touché un ennemi""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralOre"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Ore"",
		""name"": ""Minerai Astral"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CharredOre"",
		""type"": ""ITEM"",
		""englishName"": ""Charred Ore"",
		""name"": ""Minerai Calciné"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CryonicOre"",
		""type"": ""ITEM"",
		""englishName"": ""Cryonic Ore"",
		""name"": ""Minerai Cryonique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""UelibloomOre"",
		""type"": ""ITEM"",
		""englishName"": ""Uelibloom Ore"",
		""name"": ""Minerai D'Ueliclosion"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerennialOre"",
		""type"": ""ITEM"",
		""englishName"": ""Perennial Ore"",
		""name"": ""Minerai Vivace"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AerialiteOre"",
		""type"": ""ITEM"",
		""englishName"": ""Aerialite Ore"",
		""name"": ""Minerai d'Aérialite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Minigun"",
		""type"": ""ITEM"",
		""englishName"": ""Minigun"",
		""englishTooltip"": [
			""80% chance to not consume ammo""
		],
		""name"": ""Minigun"",
		""tooltip"": [
			""80% de chances de ne pas consommer de munitions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssalMirror"",
		""type"": ""ITEM"",
		""englishName"": ""Abyssal Mirror"",
		""englishTooltip"": [
			""Light does not reach the depths of the ocean"",
			""Significantly reduces enemy aggression, even in the abyss"",
			""Stealth generates 30% faster when standing still and 20% faster while moving"",
			""Grants the ability to evade attacks, releasing a cloud of lumenyl fluid which damages and stuns nearby enemies"",
			""Evading an attack grants a lot of stealth but has a 90 second cooldown"",
			""This cooldown is shared with all other dodges and reflects""
		],
		""name"": ""Miroir Abyssal"",
		""tooltip"": [
			""La lumière n'atteint pas les profondeurs des océans"",
			""Réduit considérablement l'agressivité des ennemis, même dans les abysses"",
			""La furtivité se génère 30% plus vite quand vous ne bougez pas et 20% plus vite quand vous bougez"",
			""Permet d'esquiver les attaques en relâchant un nuage de lumenyl liquide qui endommage et stoppe les ennemis proches"",
			""Esquiver une attaque augmente beaucoup votre furtivité mais à un temps de recharge de 90s"",
			""Ce temps de recharge est partagé avec le temps de recharge des autres effets d'esquive et de renvoi""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MirageMirror"",
		""type"": ""ITEM"",
		""englishName"": ""Mirage Mirror"",
		""englishTooltip"": [
			""Bend light around you"",
			""Reduces enemy aggression outside of the abyss"",
			""Stealth generates 30% faster when standing still and 20% faster while moving""
		],
		""name"": ""Miroir Mirage"",
		""tooltip"": [
			""Infléchit la lumière autour de vous"",
			""Réduit l'agressivité des ennemis en dehors des abysses"",
			""La furtivité se génére 30% plus vite quand vous êtes immobile et 20% plus vite lorsque vous vous déplacez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EclipseMirror"",
		""type"": ""ITEM"",
		""englishName"": ""Eclipse Mirror"",
		""englishTooltip"": [
			""Its reflection shows naught but darkness"",
			""+20 maximum stealth"",
			""6% increased rogue damage, and 6% increased rogue crit chance"",
			""Vastly reduces enemy aggression, even in the abyss"",
			""Stealth generates 20% faster when standing still"",
			""Mobile stealth generation exponentially accelerates while not attacking"",
			""Stealth strikes have a 100% critical hit chance"",
			""Stealth strikes only expend 50% of your max stealth"",
			""Grants the ability to evade attacks in a blast of darksun light, which inflicts extreme damage in a wide area"",
			""Evading an attack grants full stealth but has a 90 second cooldown"",
			""This cooldown is shared with all other dodges and reflects""
		],
		""name"": ""Miroir d'Éclipse"",
		""tooltip"": [
			""Son reflet ne montre rien que les ténèbres"",
			""+20 furtivité maximum"",
			""+6% des dégâts et de chance de critique de voleur"",
			""Réduit grandement l'agressivité des ennemis, même dans les abysses"",
			""La furtivité se génère 20% plus rapidement quand vous êtes immobile"",
			""La génération de furtivité quand vous vous déplacez accélère exponentiellement si vous n'attaquez pas"",
			""Les attaques furtives ont 100% de chances de coup critique"",
			""Les attaques furtives ne consomment que 50% de votre furtivité"",
			""Permet d'esquiver les attaques dans une explosion de lumière de sombresoleil, infligeant des dégâts extrêmes dans une large zone"",
			""Esquiver une attaque maximise votre furtivité mais à un temps de recharge de 90s"",
			""Ce temps de recharge est partagé avec le temps de recharge des autres effets d'esquive et de renvoi""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MatterModulator"",
		""type"": ""ITEM"",
		""englishName"": ""Matter Modulator"",
		""englishTooltip"": [
			""Using extra mass gained from collision with solid materials, it causes extra damage"",
			""Fires a burst of unstable matter that does significant damage after striking a tile"",
			""Before striking a tile, the matter pierces infinitely but deals little damage""
		],
		""name"": ""Modulateur de Matière"",
		""tooltip"": [
			""En utilisant la masse en surplus gagnée de la colision avec des matériaux solides, il inflige plus de dégâts."",
			""Tire une déflagration de matière instable qui fait des dégât significatifs après avoir touché une tuile."",
			""Avant d'avoir touché une tuile, la matière perce indéfiniment mais fait peu de dégâts.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GacruxianMollusk"",
		""type"": ""ITEM"",
		""englishName"": ""Gacruxian Mollusk"",
		""englishTooltip"": [
			""Releases homing sparks while traveling"",
			""Stealth strikes release homing snails that create even more sparks""
		],
		""name"": ""Mollusque Gacruxien"",
		""tooltip"": [
			""Relâche des étincelles à tête chercheuse sur sa trajectoire"",
			""Les attaques furtives relâchent des limaces à tête chercheuse qui créent encore plus d'étincelles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MetalMonstrosity"",
		""type"": ""ITEM"",
		""englishName"": ""Metal Monstrosity"",
		""englishTooltip"": [
			""This has to hurt"",
			""Hurls a heavy metal ball that shatters on impact"",
			""Stealth strikes cause the ball to release spikes as it travels""
		],
		""name"": ""Montruosité de Métal"",
		""tooltip"": [
			""Ca doit faire mal"",
			""Jete une lourde boule de métal qui se brise à l'impact"",
			""Les attaques furtives font libérer des piques à la boule sur sa trajectoire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Moonshine"",
		""type"": ""ITEM"",
		""englishName"": ""Moonshine"",
		""englishTooltip"": [
			""This stuff is pretty strong but I'm sure you can handle it"",
			""Increases defense by 10 and damage reduction by 3%"",
			""Reduces life regen by 1""
		],
		""name"": ""Moonshine"",
		""tooltip"": [
			""Ce truc est plutôt fort mais je suis sûr que tu peux l'encaisser"",
			""Augmente la défense de 10 et la réduction de dégâts de 5%"",
			""Réduit la régénération de vie de 1""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralChunk"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Chunk"",
		""englishTooltip"": [
			""Summons Astrum Aureus when used in the astral infection during nighttime"",
			""Not consumable""
		],
		""name"": ""Morceau Astral"",
		""tooltip"": [
			""Invoque Astrum Aureus quand utilisé dans l'infection astrale la nuit"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SerpentsBite"",
		""type"": ""ITEM"",
		""englishName"": ""Serpent's Bite"",
		""englishTooltip"": [
			""DO NOT TRAD""
		],
		""name"": ""Morsure du Serpent"",
		""tooltip"": [
			""Portée: 28.125"",
			""Vitesse de Lancer: 18"",
			""Vitesse de Rétractation: 14"",
			""Vitesse de Traction 12""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MineralMortar"",
		""type"": ""ITEM"",
		""englishName"": ""Mineral Mortar"",
		""englishTooltip"": [
			""Shoots an onyx bomb that explodes into sand sharks on death""
		],
		""name"": ""Mortier Minéral"",
		""tooltip"": [
			""Tire une bombe onyx qui explose en requins des sables""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicViperEngine"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmic Viper Engine"",
		""englishTooltip"": [
			""Summons a cosmic gunship to shoot down your foes""
		],
		""name"": ""Moteur Cosmique Vipère"",
		""tooltip"": [
			""Invoque un vaisseau de combat pour abattre vos ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TacticalPlagueEngine"",
		""type"": ""ITEM"",
		""englishName"": ""Tactical Plague Engine"",
		""englishTooltip"": [
			""Summons a plague jet to pummel your enemies into submission"",
			""Jets will fire ammo from your inventory, 66% chance to not consume ammo"",
			""Sometimes shoots a missile instead of a bullet""
		],
		""name"": ""Moteur de Peste Tactique"",
		""tooltip"": [
			""Invoque un jet de peste pour soumettre vos ennemis"",
			""Les jets consomment des balles depuis votre inventaire, 66% de chances de ne pas consommer de munitions"",
			""Tire parfois un missile à la place d'une balle""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Monsoon"",
		""type"": ""ITEM"",
		""englishName"": ""Monsoon"",
		""englishTooltip"": [
			""Fires a spread of 5 arrows"",
			""Wooden arrows are converted into typhoon arrows and sharks""
		],
		""name"": ""Mousson"",
		""tooltip"": [
			""Tire 5 flèches à la fois"",
			""Les flèches en bois sont converties en flèches typhon ou en requins""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MoscowMule"",
		""type"": ""ITEM"",
		""englishName"": ""Moscow Mule"",
		""englishTooltip"": [
			""I once heard the copper mug can be toxic and I told 'em 'listen dummy, I'm already poisoning myself'"",
			""Boosts damage by 9%, knockback by 50% and critical strike chance by 3%"",
			""Reduces life regen by 2""
		],
		""name"": ""Mule de Moscou"",
		""tooltip"": [
			""Un jour, on m'a dit que le mug en cuivre était peut-être toxique, et je lui ai répondu 'Écoute l'andouille, je suis déjà en train de m'empoisonner'"",
			""Augmente les dégâts et le recul de 9% et les chances de coup critique de 3%"",
			""Réduit la régénération de vie de 2""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralGrassWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Grass Wall"",
		""name"": ""Mur d'Herbe Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeWallofFlesh"",
		""type"": ""ITEM"",
		""englishName"": ""Wall of Flesh"",
		""englishTooltip"": [
			""I see the deed is done."",
			""The unholy amalgamation of flesh and hatred has been defeated."",
			""Prepare to face the terrors that lurk in the light and dark parts of this world.""
		],
		""name"": ""Mur de Chair"",
		""tooltip"": [
			""Je vois que l'acte est accompli."",
			""L'amalgame impie de haine et de chair a été défait."",
			""Soyez prêt à faire face aux terreurs qui se tapissent dans les parties sombres et lumineuses de ce monde.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateWall"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Containment Wall"",
		""name"": ""Mur de Confinement Pestiféré"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssGravelWallItem"",
		""type"": ""ITEM"",
		""englishName"": ""Abyss Gravel Wall"",
		""name"": ""Mur de Gravier des Abysses"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralSandstoneWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Sandstone Wall"",
		""name"": ""Mur de Grès Astral"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SulphurousSandstoneWall"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Sandstone Wall"",
		""name"": ""Mur de Grès Sulfureux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralSnowWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Snow Wall"",
		""name"": ""Mur de Neige Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralStoneWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Stone Wall"",
		""name"": ""Mur de Pierre Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueContainmentCellsWall"",
		""type"": ""ITEM"",
		""englishName"": ""Plagueplate Wall"",
		""name"": ""Mur de Plaque Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HardenedAstralSandWall"",
		""type"": ""ITEM"",
		""englishName"": ""Hardened Astral Sand Wall"",
		""name"": ""Mur de Sable Astral Durci"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EutrophicSandWallSafe"",
		""type"": ""ITEM"",
		""englishName"": ""Eutrophic Sand Wall"",
		""name"": ""Mur de Sable Eutrophique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SulphurousSandWall"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Sand Wall"",
		""name"": ""Mur de Sable Sulfureux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HardenedSulphurousSandstoneWall"",
		""type"": ""ITEM"",
		""englishName"": ""Hardened Sulphurous Sandstone Wall"",
		""name"": ""Mur de Sable Sulfureux Durci"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralDirtWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Dirt Wall"",
		""name"": ""Mur de Terre Astral"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralIceWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Ice Wall"",
		""name"": ""Mur de glace astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Murasama"",
		""type"": ""ITEM"",
		""englishName"": ""Murasama"",
		""englishTooltip"": [
			""There will be blood!"",
			""ID and power-level locked"",
			""Prove your strength or have the correct user ID to wield this sword""
		],
		""name"": ""Murasama"",
		""tooltip"": [
			""Il y aura du sang!"",
			""Verrouillé par ID et par niveau de puissance"",
			""Prouvez votre force ou ayez l'identifiant correct pour manier cette épée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AethersWhisper"",
		""type"": ""ITEM"",
		""englishName"": ""Aether's Whisper"",
		""englishTooltip"": [
			""Inflicts long-lasting shadowflame and splits on tile hits"",
			""Projectiles gain damage as they travel""
		],
		""name"": ""Murmure d'Aether"",
		""tooltip"": [
			""Inflige la flamme sombre sur une longue période et se divise au contact des tuiles"",
			""Les dégâts des projectiles augmentent en fonction de la distance parcourue"",
			""Clic droit pour effectuer une attaque à distance au lieu d'une attaque magique"",
			""Le clic droit ne consomme pas de mana""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Mycoroot"",
		""type"": ""ITEM"",
		""englishName"": ""Mycoroot"",
		""englishTooltip"": [
			""Fires a stream of short-range fungal roots"",
			""Stealth strikes spawn an explosion of fungi spores""
		],
		""name"": ""Mycoracine"",
		""tooltip"": [
			""Tire un faisceau de racine fongique à courte portée"",
			""Les attaques furtives une explosion de spores fongiques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimstoneSlag"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Slag"",
		""name"": ""Mâchefer de soufre"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RustyMedallion"",
		""type"": ""ITEM"",
		""englishName"": ""Rusty Medallion"",
		""englishTooltip"": [
			""Causes most ranged weapons to sometimes release acid droplets from the sky"",
			""Grants immunity to Irradiated""
		],
		""name"": ""Médaillon Rouillé"",
		""tooltip"": [
			""La plupart des armes à distance feront parfois pleuvoir de l'acide""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RuinMedallion"",
		""type"": ""ITEM"",
		""englishName"": ""Ruin Medallion"",
		""englishTooltip"": [
			""Stealth strikes only expend 50% of your max stealth"",
			""6% increased rogue damage, and 6% increased rogue crit chance""
		],
		""name"": ""Médaillon de Ruine"",
		""tooltip"": [
			""Les attaques furtives ne consomment que la moitié de votre furtivité"",
			""+6% de dégâts et de chances de coup critique de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Megalodon"",
		""type"": ""ITEM"",
		""englishName"": ""Megalodon"",
		""englishTooltip"": [
			""50% chance to not consume ammo"",
			""Fires streams of water every other shot""
		],
		""name"": ""Mégalodon"",
		""tooltip"": [
			""50% de chances de ne pas consommer de munitions"",
			""Tire des faisceaux d'eau tous les deux tirs""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Nadir"",
		""type"": ""ITEM"",
		""englishName"": ""Nadir"",
		""englishTooltip"": [
			""Fires void essences which flay nearby enemies with tentacles"",
			""Ignores immunity frames"",
			""'The abyss has stared back at you long enough. It now speaks, and it does not speak softly.'""
		],
		""name"": ""Nadir"",
		""tooltip"": [
			""Tire des essences de néant qui écorchent les ennemis proches avec des tentacules"",
			""Ignore la période d'invulnérabilité"",
			""'L'abysse t'as bien assez rendu ton regard. Maintenant elle parle, et elle ne parle pas avec légèreté.'""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Bloodfin"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodfin"",
		""englishTooltip"": [
			""The wonders of angiogenesis"",
			""Grants a buff that boosts life regen for 10 seconds"",
			""The life regen boost is stronger if below 75% health"",
			""10 second duration""
		],
		""name"": ""Nagesang"",
		""tooltip"": [
			""Les merveilles de l'angiogénèse"",
			""Accorde une amélioration qui augmente votre régénération de vie durant 10 secondes"",
			""Cette amélioration est plus puissante si vos points de vie sont inférieurs à 75%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EnhancedNanoRound"",
		""type"": ""ITEM"",
		""englishName"": ""Enhanced Nano Round"",
		""englishTooltip"": [
			""Confuses enemies and releases a cloud of nanites when enemies die""
		],
		""name"": ""Nanoballe Améliorée"",
		""tooltip"": [
			""Rends les ennemis confus et relâchent un nuage de nanites quand les ennemis meurent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Nanotech"",
		""type"": ""ITEM"",
		""englishName"": ""Nanotech"",
		""englishTooltip"": [
			""Rogue projectiles create nanoblades as they travel"",
			""Stealth strikes summon nanobeams and sparks on enemy hits"",
			""Stealth strikes have +20 armor penetration, deal 5% more damage, and heal for 1 HP"",
			""15% increased rogue damage and 15% increased rogue velocity"",
			""Whenever you crit an enemy with a rogue weapon your rogue damage increases"",
			""This effect can stack up to 150 times"",
			""Max rogue damage boost is 15%"",
			""This line is modified below""
		],
		""name"": ""Nanotech"",
		""tooltip"": [
			""Les projectiles de voleurs créent des nanolames sur leur trajectoire"",
			""Les attaques furtives créent des nanorayons et des étincelles quand elles touchent"",
			""Les attaques furtives ignorent 20 points d'armure, inflige 5% de dégâts supplémentaires et soigne d'un point de vie"",
			""+15% de dégâts de voleur et +15% de vitesse des projectiles de voleur"",
			""Quand vous infligez un coup critique avec une arme de voleur, vos dégâts de voleur augmentent"",
			""Cet effet peut se cumuler 150 fois"",
			""Pour un maximum de 15% de dégâts supplémentaires"",
			""This line is modified below""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Nebulash"",
		""type"": ""ITEM"",
		""englishName"": ""Nebulash"",
		""englishTooltip"": [
			""Fires a whip sword that emits particle explosions on hit""
		],
		""name"": ""Nebulash"",
		""tooltip"": [
			""Tire une épée fouet qui émet une explosion de particule quand elle touche""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralSnow"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Snow"",
		""name"": ""Neige Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Waywasher"",
		""type"": ""ITEM"",
		""englishName"": ""Waywasher"",
		""englishTooltip"": [
			""Casts inaccurate water bolts""
		],
		""name"": ""Nettoie-Voie"",
		""tooltip"": [
			""Convoque des décharges d'eau imprécises""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HardenedHoneycomb"",
		""type"": ""ITEM"",
		""englishName"": ""Hardened Honeycomb"",
		""englishTooltip"": [
			""Fires a honeycomb that shatters into fragments"",
			""Grants the honey buff to players it touches"",
			""Stealth strikes can bounce off walls and enemies""
		],
		""name"": ""Nid d'Abeilles Durci"",
		""tooltip"": [
			""Tire un nid d'abeille qui se brise en fragments"",
			""Accorde l'amélioration du miel aux joueurs qu'il touche"",
			""Les attaques furtives rebondissent sur les murs et les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OnyxChainBlaster"",
		""type"": ""ITEM"",
		""englishName"": ""Onyx Chain Blaster"",
		""englishTooltip"": [
			""50% chance to not consume ammo"",
			""Fires a spread of bullets and an onyx shard""
		],
		""name"": ""Nlaster Onyx à Répétition"",
		""tooltip"": [
			""50% de chances de ne pas consommer de munitions"",
			""Tire une étendue de balles et un éclat d'onyx""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodyWormFood"",
		""type"": ""ITEM"",
		""englishName"": ""Bloody Worm Food"",
		""englishTooltip"": [
			""Summons the Perforator Hive when used in the crimson"",
			""Not consumable""
		],
		""name"": ""Nourriture Sanglante pour Ver"",
		""tooltip"": [
			""Invoque la Ruche du Perforateur quand utilisé dans le carmin"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BlazingCore"",
		""type"": ""ITEM"",
		""englishName"": ""Blazing Core"",
		""englishTooltip"": [
			""The searing core of the profaned goddess"",
			""Being hit creates a miniature sun that lingers, dealing damage to nearby enemies"",
			""The sun will slowly drag enemies into it"",
			""Only one sun can be active at once"",
			""Provides a moderate amount of light in the Abyss""
		],
		""name"": ""Noyau Brûlant"",
		""tooltip"": [
			""Le noyau ardent de la déesse profanée"",
			""10% de réduction des dégâts"",
			""Être touché crée un soleil miniature persistant, qui inflige des dégâts aux ennemis proches"",
			""Le soleil attire lentement les ennemis vers lui"",
			""Un seul soleil ne peut exister simultanément"",
			""Donne une quantité modérée de lumière dans les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NebulousCore"",
		""type"": ""ITEM"",
		""englishName"": ""Nebulous Core"",
		""englishTooltip"": [
			""10% increased damage"",
			""Summons floating nebula stars to protect you"",
			""You will survive an attack that would have killed you and be healed 100 HP"",
			""This effect has a 90 second cooldown""
		],
		""name"": ""Noyau Nébuleux"",
		""tooltip"": [
			""+10% de dégâts"",
			""Invoque des étoiles nébuleuses flottantes pour vous protéger"",
			""Vous survivrez à une attaque mortelle"",
			""Si cet effet s'active, vous regagnez 100 points de vie"",
			""Cet effet à un temps de recharge de 90s""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedCore"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Core"",
		""englishTooltip"": [
			""The core of the unholy flame"",
			""Summons Providence when used in the hallow or underworld"",
			""Should be used during daytime"",
			""Not consumable""
		],
		""name"": ""Noyau Profané"",
		""tooltip"": [
			""Le noyau de la flamme impie"",
			""Invoque Providence"",
			""Devrait-être utilisé la journée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Starcore"",
		""type"": ""ITEM"",
		""englishName"": ""Starcore"",
		""englishTooltip"": [
			""May the stars guide your way"",
			""Summons Astrum Deus at the Astral Beacon, but is not consumed""
		],
		""name"": ""Noyau Stellaire"",
		""tooltip"": [
			""Puisse les étoiles vous guider"",
			""Invoque Astrum Deus à la balise astrale, mais ne se consomme pas.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CoreofEleum"",
		""type"": ""ITEM"",
		""englishName"": ""Core of Eleum"",
		""name"": ""Noyau d'Eleum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EnergyCore"",
		""type"": ""ITEM"",
		""englishName"": ""Energy Core"",
		""englishTooltip"": [
			""It pulses with energy""
		],
		""name"": ""Noyau d'Energie"",
		""tooltip"": [
			""Il émet de l'énergie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodflareCore"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Core"",
		""englishTooltip"": [
			""You lose up to half your defense after taking damage"",
			""Lost defense regenerates over time"",
			""You gain 1 health for every 1 defense gained as it regenerates""
		],
		""name"": ""Noyau de Brûlesang"",
		""tooltip"": [
			""Vous perdez jusqu'a la moitié de votre défense lorsque vous êtes touché"",
			""Le défense perdue se régénère au fur et à mesure"",
			""Vous gagnez un point de vie pour chaque point de défense régénéré""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CoreofCalamity"",
		""type"": ""ITEM"",
		""englishName"": ""Core of Calamity"",
		""name"": ""Noyau de Calamité"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CoreofChaos"",
		""type"": ""ITEM"",
		""englishName"": ""Core of Chaos"",
		""name"": ""Noyau de Chaos"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SandstormsCore"",
		""type"": ""ITEM"",
		""englishName"": ""Sandstorm's Core"",
		""englishTooltip"": [
			""Summons the Great Sand Shark when used in the desert"",
			""Not consumable""
		],
		""name"": ""Noyau de la Tempête des Sables"",
		""tooltip"": [
			""Invoque le grand requin des sables quand utilisé dans le désert"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StarbusterCore"",
		""type"": ""ITEM"",
		""englishName"": ""Starbuster Core"",
		""englishTooltip"": [
			""Summons release an astral explosion on enemy hits"",
			""+1 max minion""
		],
		""name"": ""Noyau du Brise-Etoile"",
		""tooltip"": [
			""Les invocations provoquent une explosion astrales lorsqu'ils touchent"",
			""+1 sbire max""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CoreOfTheBloodGod"",
		""type"": ""ITEM"",
		""englishName"": ""Core of the Blood God"",
		""englishTooltip"": [
			""Boosts your max HP by 15%"",
			""Healing Potions are 25% more effective"",
			""Halves enemy contact damage"",
			""When you take contact damage this effect has a 20 second cooldown""
		],
		""name"": ""Noyau du Dieu du Sang"",
		""tooltip"": [
			""+8% de dégâts et de réduction des dégâts supplémentaires"",
			""Augmente vos points de vie maximum de 10%"",
			""Les potions de soins rendent 15% de vie supplémentaires"",
			""Réduit les dégâts de contact de moitié"",
			""Quand vous prenez des dégâts de contact, cet effet à un temps de recharge de 20s""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EtherealCore"",
		""type"": ""ITEM"",
		""englishName"": ""Ethereal Core"",
		""englishTooltip"": [
			""Permanently increases maximum mana by 50""
		],
		""name"": ""Noyau Éthéré"",
		""tooltip"": [
			""Augmente définitivement votre mana maximum de 50""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Nucleogenesis"",
		""type"": ""ITEM"",
		""englishName"": ""Nucleogenesis"",
		""englishTooltip"": [
			""Increases max minions by 4, does not stack with downgrades"",
			""Grants immunity to Shadowflame and Irradiated"",
			""15% increased minion damage"",
			""Increased minion knockback"",
			""Minions inflict a variety of debuffs"",
			""Minions spawn damaging sparks on enemy hits""
		],
		""name"": ""Nucleogénèse"",
		""tooltip"": [
			""+4 sbires max, ne se cumule pas avec les accessoires le composant"",
			""+15% de dégâts d'invocation"",
			""Augmente le recul des sbires"",
			""Les sbires infligent une myriade d'altérations d'états"",
			""Les sbires produisent des étincelles lorsqu'ils touchent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Nychthemeron"",
		""type"": ""ITEM"",
		""englishName"": ""Nychthemeron"",
		""englishTooltip"": [
			""Throws a spiky ball that ignores gravity and summons a pair of dark and light orbs that orbit the player"",
			""Once the spiky ball disappears the orbs will home in on the nearest target"",
			""Stacks up to 10"",
			""Stealth strikes cause all spiky balls and orbs to be thrown at once"",
			""Right click to recall all existing spiky balls""
		],
		""name"": ""Nychthemeron"",
		""tooltip"": [
			""Lance une boule pointue qui ignore la gravité et invoque une paire d'orbe de lumière et de ténèbres qui orbitent autour du joueur"",
			""Une fois la boule pointue disparue, les orbes pourchassent la cible la plus proche"",
			""Se cumule 10 fois"",
			""Les attaques furtives lancent toutes les boules simultanément"",
			""Clic droit pour rappeler toutes les boules existantes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TwistingNether"",
		""type"": ""ITEM"",
		""englishName"": ""Twisting Nether"",
		""name"": ""Néant Tournoyant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""VoidofExtinction"",
		""type"": ""ITEM"",
		""englishName"": ""Void of Extinction"",
		""englishTooltip"": [
			""Drops brimstone fireballs from the sky occasionally"",
			""10% increase to all damage"",
			""Melee attacks inflict Hellfire"",
			""Brimstone fire rains down after getting hit"",
			""Reduces damage from touching lava"",
			""Grants immunity to Burning, On Fire!, Brimstone Flames and Searing Lava""
		],
		""name"": ""Néant de l'Extinction"",
		""tooltip"": [
			""La malédiction est levée"",
			""Fait tomber des boules de feu de soufre occasionnellement"",
			""+15% à tous les dégâts"",
			""Du feu de soufre pleut durant vos périodes d'invincibilité"",
			""Immunité temporaire à la lave, réduit grandement les dégâts de la brûlure de lave et augmente les dégâts de 25% quand vous êtes dans la lave""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MarniteObliterator"",
		""type"": ""ITEM"",
		""englishName"": ""Marnite Obliterator"",
		""name"": ""Oblitérateur de Marnite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RubberMortarRound"",
		""type"": ""ITEM"",
		""englishName"": ""Rubber Mortar Round"",
		""englishTooltip"": [
			""Large blast radius"",
			""Will destroy tiles on each bounce"",
			""Used by normal guns""
		],
		""name"": ""Obus de Mortier en Caoutchouc"",
		""tooltip"": [
			""Large rayon d'explosion"",
			""Detruit les tuiles à chaque rebond"",
			""Utilisable par les armes classiques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LunicEye"",
		""type"": ""ITEM"",
		""englishName"": ""Lunic Eye"",
		""englishTooltip"": [
			""Fires lunic beams that reduce enemy protection"",
			""This weapon scales with all your damage stats at once""
		],
		""name"": ""Oeil Lunique"",
		""tooltip"": [
			""Tire des rayons luniques qui réduisent les protections ennemies"",
			""Les dégâts de cette arme sont augmentés par tous vos bonus aux dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EyeofMagnus"",
		""type"": ""ITEM"",
		""englishName"": ""Eye of Magnus"",
		""englishTooltip"": [
			""Fires powerful beams that reduce enemy protection"",
			""This weapon scales with all your damage stats at once"",
			""Heals mana and health on hit""
		],
		""name"": ""Oeil de Magnus"",
		""tooltip"": [
			""Tire de puissants rayons qui réduisent la protection ennemie"",
			""Cette arme est améliorée par toutes les statistiques de dégâts"",
			""Rends du mana et de la vie quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EyeoftheStorm"",
		""type"": ""ITEM"",
		""englishName"": ""Eye of the Storm"",
		""englishTooltip"": [
			""Summons a cloud elemental to fight for you""
		],
		""name"": ""Oeil de la tempête"",
		""tooltip"": [
			""Invoque un élémentaire de nuage pour combattre pour vous""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ForgottenDragonEgg"",
		""type"": ""ITEM"",
		""englishName"": ""Forgotten Dragon Egg"",
		""englishTooltip"": [
			""Calls Akato, son of Yharon, to your side""
		],
		""name"": ""Oeuf de Dragon Oublié"",
		""tooltip"": [
			""Appelle Akato, fils de Yharon, à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Omniblade"",
		""type"": ""ITEM"",
		""englishName"": ""Omniblade"",
		""englishTooltip"": [
			""An ancient blade forged by the legendary Omnir""
		],
		""name"": ""Omnilame"",
		""tooltip"": [
			""Une lame ancienne forgée par le légendaire Omnir""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Onyxia"",
		""type"": ""ITEM"",
		""englishName"": ""Onyxia"",
		""englishTooltip"": [
			""% chance to not consume ammo"",
			""Fires a storm of bullets and onyx shards""
		],
		""name"": ""Onyxia"",
		""tooltip"": [
			""50% de chances de ne pas consommer de munitions"",
			""Tire une tempête de balles et d'éclats d'onyx""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodOrange"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Orange"",
		""englishTooltip"": [
			""It has a distinctly sweet flavor and a strong aroma"",
			""Permanently increases maximum life by 25"",
			""Can only be used if the max amount of life fruit has been consumed""
		],
		""name"": ""Orange Sanguine"",
		""tooltip"": [
			""Elle a une saveur particulièrement sucrée et un puissant arôme."",
			""Augmente la vie maximum de 25 de façon permanente"",
			""Peut seulement être utilisé si vous avez consommé le nombre maximum de fruits de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ChromaticOrb"",
		""type"": ""ITEM"",
		""englishName"": ""Chromatic Orb"",
		""englishTooltip"": [
			""It glows warmly in your hand"",
			""Summons an ancient dragon light pet that highlights nearby enemies and danger sources"",
			""Provides a small amount of light in the abyss""
		],
		""name"": ""Orbe Chromatique"",
		""tooltip"": [
			""Elle brille chaleureusement dans votre main"",
			""Invoque une ancien dragon lumineux qui affiche les ennemis proches et les sources de danger"",
			""Émet une petite quantité de lumière dans les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodOrb"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Orb"",
		""name"": ""Orbe de Sang"",
		""state"": ""Traduit""
	},
	{
		""id"": ""StrangeOrb"",
		""type"": ""ITEM"",
		""englishName"": ""Strange Orb"",
		""englishTooltip"": [
			""Summons a miniature Ocean Spirit light pet"",
			""Provides a large amount of light while underwater""
		],
		""name"": ""Orbe Étrange"",
		""tooltip"": [
			""Invoque un Esprit de l'Océan miniature lumineux"",
			""Émet une grande quantité de lumière sous l'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RomajedaOrchid"",
		""type"": ""ITEM"",
		""englishName"": ""Romajeda Orchid"",
		""englishTooltip"": [
			""Summons a never forgotten friend""
		],
		""name"": ""Orchidée de Romajeda"",
		""tooltip"": [
			""Invoque un ami inoubliable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""P90"",
		""type"": ""ITEM"",
		""englishName"": ""P90"",
		""englishTooltip"": [
			""50% chance to not consume ammo"",
			""It's a bullet hose""
		],
		""name"": ""P90"",
		""tooltip"": [
			""50% de chances de ne pas consommer de munitions"",
			""C'est un arrosoir à balles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodPact"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Pact"",
		""englishTooltip"": [
			""Doubles your max HP"",
			""Allows you to be critically hit 25% of the time"",
			""After a critical hit, you gain various buffs for ten seconds"",
			""Any healing potions consumed during this time period heal 50% more health""
		],
		""name"": ""Pacte de Sang"",
		""tooltip"": [
			""Double vos points de vie maximums"",
			""Vous avez 25% de chances de subir un coup critique"",
			""Après un coup critique, vous gagnez diverses améliorations durant 10s"",
			""Les potions de soins consommés durant ces 10s rendront 50% de vie supplémentaire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SnapClam"",
		""type"": ""ITEM"",
		""englishName"": ""Snap Clam"",
		""englishTooltip"": [
			""Can latch on enemies and deal damage over time"",
			""Stealth strikes throw five clams at once that cause increased damage over time""
		],
		""name"": ""Palourde Claquante"",
		""tooltip"": [
			""Peut s'accrocher aux ennemis et infliger des dégâts sur la durée"",
			""Les attaques furtives lancent 5 palourdes à la fois qui infligent plus de dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SurfClam"",
		""type"": ""ITEM"",
		""englishName"": ""Surf Clam"",
		""name"": ""Palourde de Surf"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LaboratoryElectricPanelItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Electric Panel"",
		""name"": ""Panneau Électrique de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Leggings"",
		""englishTooltip"": [
			""10% increased movement speed"",
			""Treasure and ore detection""
		],
		""name"": ""Pantalon Astral"",
		""tooltip"": [
			""+10% de vitesse de mouvement"",
			""Détection des trésors et des minerais""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AerospecLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Aerospec Leggings"",
		""englishTooltip"": [
			""12% increased movement speed""
		],
		""name"": ""Pantalon Aérospec"",
		""tooltip"": [
			""+12% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SilvaLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Leggings"",
		""englishTooltip"": [
			""10% increased movement speed"",
			""12% increased damage and critical strike chance""
		],
		""name"": ""Pantalon Silva"",
		""tooltip"": [
			""+10% de vitesse de mouvement"",
			""+12% de dégâts et de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Leggings"",
		""englishTooltip"": [
			""Movement speed increased by 5%""
		],
		""name"": ""Pantalon Wulfrum"",
		""tooltip"": [
			""+5% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TarragonLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Leggings"",
		""englishTooltip"": [
			""Leggings of a fabled explorer"",
			""10% increased movement speed"",
			""8% increased damage and critical strike chance""
		],
		""name"": ""Pantalon d'Estragon"",
		""tooltip"": [
			""Le pantalon d'un explorateur mythologique"",
			""+10% de vitesse de mouvement"",
			""+8% de dégâts et de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MolluskShelleggings"",
		""type"": ""ITEM"",
		""englishName"": ""Mollusk Shelleggings"",
		""englishTooltip"": [
			""12% increased damage and 4% increased critical strike chance"",
			""7% decreased movement speed""
		],
		""name"": ""Pantalon de Mollusque"",
		""tooltip"": [
			""+12% de dégâts et +4% de chances de coup critique"",
			""-7% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GodSlayerLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Leggings"",
		""englishTooltip"": [
			""5% increased movement speed"",
			""10% increased damage and critical strike chance""
		],
		""name"": ""Pantalon du Déicide"",
		""tooltip"": [
			""+5% vitesse de mouvement"",
			""+10% de dégâts et +6% de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DesertProwlerPants"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Prowler Pants"",
		""englishTooltip"": [
			""10% increased movement speed and immunity to the Mighty Wind debuff""
		],
		""name"": ""Pantalon du Rôdeur du Désert"",
		""tooltip"": [
			""+10% de vitesse de mouvement et immunité au vent du désert""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ResurrectionButterfly"",
		""type"": ""ITEM"",
		""englishName"": ""Resurrection Butterfly"",
		""englishTooltip"": [
			""Remembering the melancholy of human existence"",
			""Even ghosts stray from the path of righteousness"",
			""Summons a pair of butterflies to fight for you""
		],
		""name"": ""Papillon de Résurrection"",
		""tooltip"": [
			""Se remémore la mélancholie de l'existence humaine"",
			""Même les fantômes s'eloignent du chemin de la droiture"",
			""Invoque une paire de papillons pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FuelCellBundle"",
		""type"": ""ITEM"",
		""englishName"": ""Fuel Cell Bundle"",
		""englishTooltip"": [
			""Releases a small, special variant of the plaguebringers""
		],
		""name"": ""Paquet de Cellule de Carburant"",
		""tooltip"": [
			""Relâche une petite variante spéciale des Colportes-Peste""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElectrolyteGelPack"",
		""type"": ""ITEM"",
		""englishName"": ""Electrolyte Gel Pack"",
		""englishTooltip"": [
			""Permanently increases Adrenaline Mode damage by 15% and damage reduction by 5%"",
			""Revengeance drop""
		],
		""name"": ""Paquet de Gel Électrolyte"",
		""tooltip"": [
			""Augmente de façon définitive les dégâts du mode Adrénaline de 15% et la réduction des dégâts quand la jauge est pleine de 5%"",
			""Revengeance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PoisonPack"",
		""type"": ""ITEM"",
		""englishName"": ""Poison Pack"",
		""englishTooltip"": [
			""Throws a poisonous spiky ball. Stacks up to 3."",
			""Stealth strikes cause the balls to release spore clouds"",
			""Right click to delete all existing spiky balls""
		],
		""name"": ""Paquet de Poison"",
		""tooltip"": [
			""Lance une boules à piques empoisonnée. Se cumule 3 fois."",
			""Les attaques furtives font relâcher des nuages de spores aux boules"",
			""Clic droit pour supprimer les boules existantes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GodsParanoia"",
		""type"": ""ITEM"",
		""englishName"": ""God's Paranoia"",
		""englishTooltip"": [
			""Shoots a speedy homing spiky ball. Stacks up to 10."",
			""Attaches to enemies and summons a localized storm of god slayer kunai"",
			""Stealth strikes home in faster and summon kunai at a faster rate"",
			""Right click to delete all existing spiky balls""
		],
		""name"": ""Paranoïa de Dieu"",
		""tooltip"": [
			""Tire une boule pointue rapide à tête chercheuse. Se cumule 10 fois."",
			""S'attache aux ennemis et invoque une tornade localisée de kunaïs déicide"",
			""Les attaques furtives sont plus rapides et invoquent les kunaïs plus vite"",
			""Clic droit pour supprimer les boules existantes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HauntedScroll"",
		""type"": ""ITEM"",
		""englishName"": ""Haunted Scroll"",
		""englishTooltip"": [
			""Summons a stack of haunted dishes to fight for you""
		],
		""name"": ""Parchemin Hanté"",
		""tooltip"": [
			""Invoque une pile de plats hantés pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ArcticBearPaw"",
		""type"": ""ITEM"",
		""englishName"": ""Arctic Bear Paw"",
		""englishTooltip"": [
			""The savage mauling that fits in your pocket"",
			""Fires spiritual claws that ignore walls and confuse enemies""
		],
		""name"": ""Patte d'Ours Arctique"",
		""tooltip"": [
			""La mutilation sauvage qui rentre dans votre poche"",
			""Tires des griffes spirituelles qui ignorent les murs et rendent les ennemis confus""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HideofAstrumDeus"",
		""type"": ""ITEM"",
		""englishName"": ""Hide of Astrum Deus"",
		""englishTooltip"": [
			""Taking damage, or inflicting a true melee strike, drops an immense amount of astral stars from the sky"",
			""Taking damage boosts true melee damage by 50%"",
			""Boost duration is based on the amount of damage you took, the higher the damage the longer the boost"",
			""Provides immunity to the astral infection, cursed inferno, on fire, and frostburn debuffs"",
			""Enemies take damage when they hit you and are inflicted with the astral infection debuff""
		],
		""name"": ""Peau d'Astrum Deus"",
		""tooltip"": [
			""Subir des dégâts ou frapper en véritable mêlée fait tomber une gigantesque quantité d'étoiles astrales du ciel"",
			""Sbir des dégâts augmente les dégâts de vraie mêlée de 50% pendant un moment"",
			""La durée de l'amélioration dépend des dégâts subis, plus les dégâts sont élevés, plus l'amélioration est longue"",
			""Immunité à l'infection astrale, au feu maudit, au feu et au brûlegivre"",
			""Les ennemis subissent des dégâts quand ils vous touchent et contractent l'infection astrale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicPlushie"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmic Plushie"",
		""englishTooltip"": [
			""Summons the devourer of the cosmos...?"",
			""Sharp objects possibly included"",
			""Suppresses friendly red devils""
		],
		""name"": ""Peluche Cosmique"",
		""tooltip"": [
			""Invoque le dévoreur du cosmos...?"",
			""Objets tranchants possiblement inclus"",
			""Réprime les diables rouges amicaux""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VeneratedLocket"",
		""type"": ""ITEM"",
		""englishName"": ""Venerated Locket"",
		""englishTooltip"": [
			""10% increased rogue damage"",
			""Using a rogue weapon summons a copy of the projectile that falls from the sky"",
			""Stealth strikes cause a circular fan of seeking cosmilite knives to be thrown"",
			""You'll never be alone, no matter where you go""
		],
		""name"": ""Pendentif Vénéré"",
		""tooltip"": [
			""+10% de dégâts de voleur"",
			""Utilisez une arme de voleur invoque une copie du projectile qui tombe du ciel"",
			""Les attaques furtives créent un éventail circulaire de couteaux en cosmilite à tête chercheuse"",
			""Tu ne seras jamais seul, peu importe où tu te rends""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AmidiasPendant"",
		""type"": ""ITEM"",
		""englishName"": ""Amidias' Pendant"",
		""englishTooltip"": [
			""Periodically rains down prism shards that can briefly stun enemies""
		],
		""name"": ""Pendentif d'Amidias"",
		""tooltip"": [
			""Fait périodiquement pleuvoir des éclats de prisme qui peuvent brièvement stopper les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GladiatorsLocket"",
		""type"": ""ITEM"",
		""englishName"": ""Gladiator's Locket"",
		""englishTooltip"": [
			""Summons two spirit swords to protect you""
		],
		""name"": ""Pendentif du Gladiateur"",
		""tooltip"": [
			""Invoque deux épées spirituelles pour vous protéger""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EnchantedPearl"",
		""type"": ""ITEM"",
		""englishName"": ""Enchanted Pearl"",
		""englishTooltip"": [
			""Increases fishing skill"",
			""Increases chance to catch crates""
		],
		""name"": ""Perle Enchantée"",
		""tooltip"": [
			""Augmente la puissance de pêche"",
			""Augmente les chances de pêcher des caisses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GiantPearl"",
		""type"": ""ITEM"",
		""englishName"": ""Giant Pearl"",
		""englishTooltip"": [
			""You have a light aura around you"",
			""Enemies within the aura are slowed down"",
			""Does not work while a boss is alive"",
			""Provides a small amount of light in the abyss""
		],
		""name"": ""Perle Géante"",
		""tooltip"": [
			""Vous donne une aura de lumière"",
			""Les ennemis dans l'aura sont ralentis"",
			""Ne fonctionne pas quand un boss est présent"",
			""Donne une petite quantité de lumière dans les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedPartisan"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Partisan"",
		""englishTooltip"": [
			""Fires an unholy spear that explodes on death"",
			""Stealth strikes spawn smaller spears to fly along side it""
		],
		""name"": ""Pertuisane Profanée"",
		""tooltip"": [
			""Tire une lance impie qui explose"",
			""Les attaques furtives s'accompagnent de lances plus petites en plus de la lance principale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Plaguenade"",
		""type"": ""ITEM"",
		""englishName"": ""Plaguenade"",
		""englishTooltip"": [
			""Releases a swarm of angry plague bees"",
			""Stealth strikes spawn more bees and generate a larger explosion""
		],
		""name"": ""Pestenade"",
		""tooltip"": [
			""Relâche une nuée d'abeilles de peste enervées"",
			""Les attaques furtives contiennent plus d'abeilles et ont une plus grosse explosion""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Photoviscerator"",
		""type"": ""ITEM"",
		""englishName"": ""Photoviscerator"",
		""englishTooltip"": [
			""90% chance to not consume gel"",
			""Fires a stream of exo flames and light that explodes into homing sparks"",
			""Right click to fire homing flares which stick to enemies and incinerate them""
		],
		""name"": ""Photoviscerateur"",
		""tooltip"": [
			""90% de chances de ne pas consommer de gel"",
			""Tire un faisceau d'exo flammes et de lumière qui explosent en étincelles qui pourchassent les ennemis"",
			""Clic droit pour tirer des décharges à tête chercheuse qui se collent aux ennemis et les incinère""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlatePiano"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Piano"",
		""name"": ""Piano Pestiféré"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralStone"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Stone"",
		""name"": ""Pierre Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CryoStone"",
		""type"": ""ITEM"",
		""englishName"": ""Cryo Stone"",
		""englishTooltip"": [
			""One of the ancient relics"",
			""Creates a rotating ice shield around you that damages and slows down enemies on contact""
		],
		""name"": ""Pierre Cryo"",
		""tooltip"": [
			""L'une des anciennes reliques"",
			""Crée un bouclier de glace pivotant autour de vous qui ralentit et endommage les ennemis au toucher""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Navystone"",
		""type"": ""ITEM"",
		""englishName"": ""Navystone"",
		""name"": ""Pierre Marine"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RoseStone"",
		""type"": ""ITEM"",
		""englishName"": ""Rose Stone"",
		""englishTooltip"": [
			""One of the ancient relics"",
			""Summons a brimstone elemental to fight for you""
		],
		""name"": ""Pierre Rose"",
		""tooltip"": [
			""L'une des anciennes reliques"",
			""Invoque un élémentaire de soufre pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloomStone"",
		""type"": ""ITEM"",
		""englishName"": ""Bloom Stone"",
		""englishTooltip"": [
			""One of the ancient relics"",
			""You quickly regenerate life while on the ground"",
			""This effect works best during daytime"",
			""Flowers grow if you are standing on grass"",
			""Random dye plants will grow while standing on grassless dirt""
		],
		""name"": ""Pierre d'Eclosion"",
		""tooltip"": [
			""L'une des anciennes reliques"",
			""Vous régénérez rapidement de la vie quand vous êtes au sol"",
			""Cet effet fonctionne mieux la journée"",
			""Des fleurs poussent sur l'herbe quand vous marchez dessus"",
			""Des plantes à teinture ont une faible chance de pousser quand vous êtes sur de la terre sans herbe""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Bloodstone"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodstone"",
		""name"": ""Pierre de Sang"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ChaosStone"",
		""type"": ""ITEM"",
		""englishName"": ""Chaos Stone"",
		""englishTooltip"": [
			""One of the ancient relics"",
			""Mana Sickness from drinking mana potions is replaced by Mana Burn"",
			""Mana Burn deals damage over time relative to the intensity of the debuff"",
			""This debuff does not reduce your magic damage""
		],
		""name"": ""Pierre du Chaos"",
		""tooltip"": [
			""L'une des anciennes reliques"",
			""La maladie du mana provenant des potions de mana est remplacé par la brûlure de mana"",
			""La brûlure de mana inflige des dégâts sur la durée en fonction de son intensité"",
			""Cette altération d'état ne réduit pas vos dégâts magiques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StressPills"",
		""type"": ""ITEM"",
		""englishName"": ""Stress Pills"",
		""englishTooltip"": [
			""Adrenaline charges 20% faster"",
			""Increases your max movement speed and acceleration by 5%"",
			""Revengeance drop""
		],
		""name"": ""Pillules Anti-Stress"",
		""tooltip"": [
			""+4 défense et +5% de vitesse de mouvement et d'accélération"",
			""Recevoir un coup ne vous fait perdre que la moitié de votre adrénaline au lieu de la totalité"",
			""Revengeance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BlossomPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Blossom Pickaxe"",
		""englishTooltip"": [
			""Can mine Auric Ore""
		],
		""name"": ""Piochache de Floraison"",
		""tooltip"": [
			""Peut extraire le minerai aurique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Pickaxe"",
		""name"": ""Pioche Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Pickaxe"",
		""name"": ""Pioche Wulfrum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ShardlightPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Shardlight Pickaxe"",
		""name"": ""Pioche d'ÉclatLueur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SkyfringePickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Skyfringe Pickaxe"",
		""englishTooltip"": [
			""Able to mine Hellstone""
		],
		""name"": ""Pioche de Bordeciel"",
		""tooltip"": [
			""Peut extraire de la pierre infernale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GreatbayPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Greatbay Pickaxe"",
		""englishTooltip"": [
			""Can mine Demonite, Crimtane and Meteorite""
		],
		""name"": ""Pioche de la Grande Baie"",
		""tooltip"": [
			""Peut miner la carmitane, la démonite et la météorite""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Gelpick"",
		""type"": ""ITEM"",
		""englishName"": ""Gelpick"",
		""name"": ""Pioche-Gelée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BeastialPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Beastial Pickaxe"",
		""name"": ""Pioche-hache Bestiale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralPike"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Pike"",
		""englishTooltip"": [
			""Summons astral star swarms on critical hits""
		],
		""name"": ""Pique Astrale"",
		""tooltip"": [
			""Invoque des essaims d'étoiles astrales en cas de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DiseasedPike"",
		""type"": ""ITEM"",
		""englishName"": ""Diseased Pike"",
		""englishTooltip"": [
			""Fires plague seekers on hit""
		],
		""name"": ""Pique Malade"",
		""tooltip"": [
			""Tire des cherches-peste quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EarthenPike"",
		""type"": ""ITEM"",
		""englishName"": ""Earthen Pike"",
		""englishTooltip"": [
			""Crushes enemy defenses"",
			""Sprays fossil shards on use""
		],
		""name"": ""Pique Terrestre"",
		""tooltip"": [
			""Écrase les défenses ennemies"",
			""Disperse des éclats de fossile à l'utilisation""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AcidGun"",
		""type"": ""ITEM"",
		""englishName"": ""Acid Gun"",
		""englishTooltip"": [
			""Releases three streams of acid""
		],
		""name"": ""Pistolet Acide"",
		""tooltip"": [
			""Tire trois jets d'acide""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GaussPistol"",
		""type"": ""ITEM"",
		""englishName"": ""Gauss Pistol"",
		""englishTooltip"": [
			""A simple pistol that utilizes magic power; a weapon for the more magically adept"",
			""Fires a devastating high velocity blast with extreme knockback""
		],
		""name"": ""Pistolet Gauss"",
		""tooltip"": [
			""Un simple pistolet qui utilise le pouvoir de la magie; une arme adapté pour les mages."",
			""Tire une déflagration ultra rapide d'une puissance de recul extrême""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GoldenGun"",
		""type"": ""ITEM"",
		""englishName"": ""Golden Gun"",
		""englishTooltip"": [
			""Shoots a straight line of ichor""
		],
		""name"": ""Pistolet d'Or"",
		""tooltip"": [
			""Tire de l'ichor en ligne droite""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NullificationRifle"",
		""type"": ""ITEM"",
		""englishName"": ""Nullification Pistol"",
		""englishTooltip"": [
			""Is it nullable or not? Let's find out!"",
			""Fires a fast null bullet that distorts NPC stats""
		],
		""name"": ""Pistolet de Nullification"",
		""tooltip"": [
			""C'est nullable ou pas ? On va voir!"",
			""Tire une balle null rapide qui déforme les statistiques des PNJ""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PulsePistol"",
		""type"": ""ITEM"",
		""englishName"": ""Pulse Pistol"",
		""englishTooltip"": [
			""Fires a pulse that arcs to a new target on enemy hits""
		],
		""name"": ""Pistolet à Impulsion"",
		""tooltip"": [
			""Tire une impulsion qui se redirige vers un nouvel ennemi quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguebringerPistons"",
		""type"": ""ITEM"",
		""englishName"": ""Plaguebringer Pistons"",
		""englishTooltip"": [
			""13% increased minion damage and 15% increased movement speed"",
			""You grow flowers on the grass beneath you, chance to grow very random dye plants on grassless dirt"",
			""You spawn bees while sprinting or dashing""
		],
		""name"": ""Pistons du Colporte-Peste"",
		""tooltip"": [
			""+13% de dégâts des sbires et +15% de vitesse de mouvement"",
			""Vous faites pousser des fleurs sur l'herbe sous vos pieds, faible chances de faire pousser des plantes à teinture sur la terre sans herbe"",
			""Vous faites apparaître des abeilles quand vous sprintez ou que vous foncez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CoinofDeceit"",
		""type"": ""ITEM"",
		""englishName"": ""Coin of Deceit"",
		""englishTooltip"": [
			""Stealth strikes only expend 75% of your max stealth"",
			""6% increased rogue crit chance""
		],
		""name"": ""Pièce de Tromperie"",
		""tooltip"": [
			""Les attaques furtives ne consomment que 75% de votre furtivité"",
			""6% des coups critiques pour les dégâts de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgePlantera"",
		""type"": ""ITEM"",
		""englishName"": ""Plantera"",
		""englishTooltip"": [
			""Well done, you killed a plant."",
			""It was used as a vessel to house the spirits of those unfortunate enough to find their way down here."",
			""I wish you luck in dealing with the fallout.""
		],
		""name"": ""Plantera"",
		""tooltip"": [
			""Bien joué, vous avez tué une plante."",
			""Elle était utilisée comme réceptacle pour accueillir les esprits de ceux assez malchancheux pour trouver leur voie ici-bas."",
			""Bonne chance pour vous occuper des retombées.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BotanicPlanter"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": ""Planteur Botanique"",
		""tooltip"": [
			""Utilisé pour l'artisanat spécial""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DubiousPlating"",
		""type"": ""ITEM"",
		""englishName"": ""Dubious Plating"",
		""name"": ""Plaquage Douteux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""InfectedArmorPlating"",
		""type"": ""ITEM"",
		""englishName"": ""Infected Armor Plating"",
		""name"": ""Plaquage d'Armure Infecté"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Navyplate"",
		""type"": ""ITEM"",
		""englishName"": ""Navyplate"",
		""englishTooltip"": [
			""It resonates with otherworldly energy.""
		],
		""name"": ""Plaque Azur"",
		""tooltip"": [
			""Elle résonne d'une énergie d'un autre monde.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Chaosplate"",
		""type"": ""ITEM"",
		""englishName"": ""Chaosplate"",
		""englishTooltip"": [
			""It resonates with otherworldly energy.""
		],
		""name"": ""Plaque Chaotique"",
		""tooltip"": [
			""Elle résonne d'une énergie d'un autre monde.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Elumplate"",
		""type"": ""ITEM"",
		""englishName"": ""Elumplate"",
		""englishTooltip"": [
			""It resonates with otherworldly energy.""
		],
		""name"": ""Plaque d'Eleum"",
		""tooltip"": [
			""Elle résonne d'une énergie d'un autre monde.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AnechoicPlating"",
		""type"": ""ITEM"",
		""englishName"": ""Anechoic Plating"",
		""englishTooltip"": [
			""Reduces creature's ability to detect you in the abyss"",
			""Reduces the defense reduction that the abyss causes""
		],
		""name"": ""Plaques Anéchoiques"",
		""tooltip"": [
			""Réduit la capacité des ennemis des abysses de vous détecter"",
			""Réduit la baisse de défense causée par les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DarkPlasma"",
		""type"": ""ITEM"",
		""englishName"": ""Dark Plasma"",
		""name"": ""Plasma Sombre"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralBreastplate"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Breastplate"",
		""englishTooltip"": [
			""+80 max mana and +20 max life"",
			""Creature detection""
		],
		""name"": ""Plastron Astral"",
		""tooltip"": [
			""+80 mana maximum et +20 vie maximum"",
			""Détection des ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AerospecBreastplate"",
		""type"": ""ITEM"",
		""englishName"": ""Aerospec Breastplate"",
		""englishTooltip"": [
			""3% increased critical strike chance""
		],
		""name"": ""Plastron Aérospec"",
		""tooltip"": [
			""+3% de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OmegaBlueChestplate"",
		""type"": ""ITEM"",
		""englishName"": ""Omega Blue Chestplate"",
		""englishTooltip"": [
			""12% increased damage and 8% increased critical strike chance"",
			""Your attacks inflict Crush Depth"",
			""No positive life regen""
		],
		""name"": ""Plastron Bleu Omega"",
		""tooltip"": [
			""+12% de dégâts et +8% de chances de coup critique"",
			""Vos attaques infligent Écrasement des Profondeurs"",
			""Annule la régénération de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MolluskShellplate"",
		""type"": ""ITEM"",
		""englishName"": ""Mollusk Shellplate"",
		""englishTooltip"": [
			""10% increased damage and 6% increased critical strike chance"",
			""15% decreased movement speed""
		],
		""name"": ""Plastron Mollusque"",
		""tooltip"": [
			""+10% de dégâts et +6% de chances de coup critique"",
			""-15% de vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VictideBreastplate"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Breastplate"",
		""englishTooltip"": [
			""5% increased damage reduction and critical strike chance"",
			""+5 defense and 10% increased damage reduction while submerged in liquid""
		],
		""name"": ""Plastron Victide"",
		""tooltip"": [
			""+5% de réduction de dégâts et de chances de coup critique"",
			""+5 défense et +10% de réduction de dégâts quand vous êtes immergé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FathomSwarmerBreastplate"",
		""type"": ""ITEM"",
		""englishName"": ""Fathom Swarmer Breastplate"",
		""englishTooltip"": [
			""6% increased damage reduction"",
			""6% increased minion damage"",
			""Boosted defense and regen increased while submerged in liquid"",
			""Reduces defense loss within the Abyss""
		],
		""name"": ""Plastron d'Essaim de Brasse"",
		""tooltip"": [
			""+6% de réduction des dégâts"",
			""+6% de dégâts d'invocation"",
			""Défense et régénération de vie augmentées quand vous êtes immergé"",
			""Réduit la baisse de défense provoqué par les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TarragonBreastplate"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Breastplate"",
		""englishTooltip"": [
			""Breastplate of the exiler"",
			""10% increased damage and 5% increased critical strike chance"",
			""+2 life regen and +40 max life""
		],
		""name"": ""Plastron d'Estragon"",
		""tooltip"": [
			""Plastron de l'exileur"",
			""+10% de dégâts et +5% de chances de coup critique"",
			""+2 régénération de vie et +40 vie maximum""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DemonshadeBreastplate"",
		""type"": ""ITEM"",
		""englishName"": ""Demonshade Breastplate"",
		""englishTooltip"": [
			""20% increased melee speed, 15% increased damage and critical strike chance"",
			""Enemies take ungodly damage when they touch you"",
			""Increased max life and mana by 200"",
			""Standing still lets you absorb the shadows and boost your life regen""
		],
		""name"": ""Plastron d'Ombredémon"",
		""tooltip"": [
			""+20% de vitesse de mêlée, +15% de dégâts et de chances de coup critique"",
			""Les ennemis subissent des dégâts inimaginables quand ils vous touchent"",
			""Augmente la vie et le mana maximum de 200"",
			""Restez immobile vous permet d'absorber les ombres et augmente votre régénération de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DaedalusBreastplate"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Breastplate"",
		""englishTooltip"": [
			""3% increased damage and critical strike chance""
		],
		""name"": ""Plastron de Dédale"",
		""tooltip"": [
			""+3% de dégâts et de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AncientGodSlayerChestplate"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient God Slayer Chestplate"",
		""name"": ""Plastron de l'Ancien Déicide"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GodSlayerChestplate"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Chestplate"",
		""englishTooltip"": [
			""+60 max life"",
			""Enemies take damage when they hit you"",
			""11% increased damage and 6% increased critical strike chance""
		],
		""name"": ""Plastron du Déicide"",
		""tooltip"": [
			""+60 vie maximum"",
			""Les ennemis subissent des dégâts quand ils vous touchent"",
			""+11% de dégâts et +6% de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SnowRuffianChestplate"",
		""type"": ""ITEM"",
		""englishName"": ""Snow Ruffian Chestplate"",
		""englishTooltip"": [
			""3% increased rogue critical strike chance""
		],
		""name"": ""Plastron du Voyou des Neiges"",
		""tooltip"": [
			""+3% de chances de coup critique de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlatePlatform"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Shelf"",
		""name"": ""Plateforme Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DeepDiver"",
		""type"": ""ITEM"",
		""englishName"": ""Deep Diver"",
		""englishTooltip"": [
			""15% increased damage, movement speed and +15 defense while underwater"",
			""While underwater you gain the ability to dash great distances""
		],
		""name"": ""Plongeur profond"",
		""tooltip"": [
			""+15 défense et +15% de dégâts et de vitesse de déplacement supplémentaires lorsque vous êtes sous l'eau"",
			""Lorsque vous êtes sous l'eau, vous pouvez foncer sur de grandes distances""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EffulgentFeather"",
		""type"": ""ITEM"",
		""englishName"": ""Effulgent Feather"",
		""englishTooltip"": [
			""It vibrates with fluffy golden energy""
		],
		""name"": ""Plume Rayonnante"",
		""tooltip"": [
			""Elle vibre d'une énergie dorée duveteuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DesertFeather"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Feather"",
		""name"": ""Plumes du Désert"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SkyStabber"",
		""type"": ""ITEM"",
		""englishName"": ""Sky Stabber"",
		""englishTooltip"": [
			""Shoots a gravity-defying spiky ball. Stacks up to 4."",
			""Stealth strikes make the balls rain feathers onto enemies when they hit"",
			""Right click to delete all existing spiky balls""
		],
		""name"": ""Poignardeur Céleste"",
		""tooltip"": [
			""Tire une boule pointue qui ignore la gravité. Se cumule jusqu'à 4 fois."",
			""Les attaques furtives font libérer des plumes depuis les boules quand ils sont touchés"",
			""Clic droit pour supprimer les boules existantes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MeteorFist"",
		""type"": ""ITEM"",
		""englishName"": ""Meteor Fist"",
		""englishTooltip"": [
			""Fires a fist that explodes "",
			""Stealth strikes make the fist ricochet between enemies up to 4 times""
		],
		""name"": ""Poing Météore"",
		""tooltip"": [
			""Tire un poing qui explose"",
			""Les attaques furtives font ricocher le poing entre les ennemis jusqu'a 4 fois""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OrichalcumSpikedGemstone"",
		""type"": ""ITEM"",
		""englishName"": ""Orichalcum Spiked Gemstone"",
		""englishTooltip"": [
			""Stealth strikes last longer and summon petals on enemy hits""
		],
		""name"": ""Pointe de Gemme en Orichalque"",
		""tooltip"": [
			""LEs attaques furtives durent plus longtemps et invoquent des pétales quand vous touchez les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ChaoticFish"",
		""type"": ""ITEM"",
		""englishName"": ""Chaotic Fish"",
		""englishTooltip"": [
			""The horns lay a curse on those who touch it"",
			""Right click to extract essence""
		],
		""name"": ""Poisson Chaotique"",
		""tooltip"": [
			""Les cornes maudissent ceux qui les touchent"",
			""Clic droit pour en extraire l'essence""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StuffedFish"",
		""type"": ""ITEM"",
		""englishName"": ""Stuffed Fish"",
		""englishTooltip"": [
			""Right click to extract herbs and seeds""
		],
		""name"": ""Poisson Fourré"",
		""tooltip"": [
			""Clic droit pour extraire des herbes et des graines""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Shadowfish"",
		""type"": ""ITEM"",
		""englishName"": ""Shadowfish"",
		""englishTooltip"": [
			""Darkness spreads""
		],
		""name"": ""Poisson d'Ombre"",
		""tooltip"": [
			""Les ténèbres se répandent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FishofEleum"",
		""type"": ""ITEM"",
		""englishName"": ""Fish of Eleum"",
		""englishTooltip"": [
			""Right click to extract essence""
		],
		""name"": ""Poisson d'Éleum"",
		""tooltip"": [
			""Clic droit pour extraire l'essence""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FishofLight"",
		""type"": ""ITEM"",
		""englishName"": ""Fish of Light"",
		""englishTooltip"": [
			""Right click to extract souls""
		],
		""name"": ""Poisson de Lumière"",
		""tooltip"": [
			""Clic droit pour extraire les âmes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SunbeamFish"",
		""type"": ""ITEM"",
		""englishName"": ""Sunbeam Fish"",
		""englishTooltip"": [
			""Right click to extract essence""
		],
		""name"": ""Poisson de Rayon Solaire"",
		""tooltip"": [
			""Clic droit pour en extraire l'essence""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FishofFlight"",
		""type"": ""ITEM"",
		""englishName"": ""Fish of Flight"",
		""englishTooltip"": [
			""Right click to extract souls""
		],
		""name"": ""Poisson de Vol"",
		""tooltip"": [
			""Clic droit pour extraire des âmes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FishofNight"",
		""type"": ""ITEM"",
		""englishName"": ""Fish of Night"",
		""englishTooltip"": [
			""Right click to extract souls""
		],
		""name"": ""Poisson de la Nuit"",
		""tooltip"": [
			""Clic droit pour extraire les âmes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ScarredAngelfish"",
		""type"": ""ITEM"",
		""englishName"": ""Scarred Angelfish"",
		""englishTooltip"": [
			""The mark of a fallen angel""
		],
		""name"": ""Poisson-Ange Scarifié"",
		""tooltip"": [
			""La marque d'un ange déchu""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Archerfish"",
		""type"": ""ITEM"",
		""englishName"": ""Archerfish"",
		""englishTooltip"": [
			""Converts musket balls into streams of water""
		],
		""name"": ""Poisson-Archer"",
		""tooltip"": [
			""Convertit les balles de mousquet en faisceaux d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CoralskinFoolfish"",
		""type"": ""ITEM"",
		""englishName"": ""Coralskin Foolfish"",
		""englishTooltip"": [
			""Camouflage is one of nature's best defenses""
		],
		""name"": ""Poisson-Corail Trompeur"",
		""tooltip"": [
			""Le camouflage est l'une des meilleures défenses de la nature""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CoastalDemonfish"",
		""type"": ""ITEM"",
		""englishName"": ""Coastal Demonfish"",
		""englishTooltip"": [
			""The horns lay a curse on those who touch it""
		],
		""name"": ""Poisson-Démon Côtier"",
		""tooltip"": [
			""Ses cornes posent une malédiction sur ceux qui les touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GlimmeringGemfish"",
		""type"": ""ITEM"",
		""englishName"": ""Glimmering Gemfish"",
		""englishTooltip"": [
			""Right click to extract gems""
		],
		""name"": ""Poisson-Gemme Scintillant"",
		""tooltip"": [
			""Clic droit pour extraire des gemmes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Spadefish"",
		""type"": ""ITEM"",
		""englishName"": ""Spadefish"",
		""englishTooltip"": [
			""How can a fish be used to dig through the ground?"",
			""Some questions are best left unanswered.""
		],
		""name"": ""Poisson-Pelle"",
		""tooltip"": [
			""Comment est-ce qu'un poisson peut être utilisé pour creuser dans le sol?"",
			""Il vaut mieux que certaines questions restent sans réponses.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PolarisParrotfish"",
		""type"": ""ITEM"",
		""englishName"": ""Polaris Parrotfish"",
		""englishTooltip"": [
			""It carries the mark of the Northern Star"",
			""Projectile hits grant buffs to the weapon"",
			""Buffs are removed on hit""
		],
		""name"": ""Poisson-Perroquet Polaris"",
		""tooltip"": [
			""Il porte la marque de l'étoile du nord"",
			""Les projectiles qui touchent améliorent le joueur et l'arme"",
			""Les améliorations s'annulent si vous êtes touché""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SunkenSailfish"",
		""type"": ""ITEM"",
		""englishName"": ""Sunken Sailfish"",
		""englishTooltip"": [
			""Zooming at 60 miles per hour""
		],
		""name"": ""Poisson-Voile Coulé"",
		""tooltip"": [
			""Fonce à 60 noeuds/heure""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Lionfish"",
		""type"": ""ITEM"",
		""englishName"": ""Lionfish"",
		""englishTooltip"": [
			""Sticks to enemies and injects a potent toxin"",
			""Stealth strikes are trailed by homing urchin spikes""
		],
		""name"": ""Poisson-lion"",
		""tooltip"": [
			""Colle aux ennemis et leur injecte une puissante toxine"",
			""Les attaques furtives libèrent des épines d'oursin à tête chercheuse sur la trajectoire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EutrophicSandfish"",
		""type"": ""ITEM"",
		""englishName"": ""Eutrophic Sandfish"",
		""name"": ""Poisson-sable Eutrophique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimstoneFish"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Fish"",
		""englishTooltip"": [
			""Fire is a living being""
		],
		""name"": ""Poisson-soufre"",
		""tooltip"": [
			""Le feu est un être vivant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TwinklingPollox"",
		""type"": ""ITEM"",
		""englishName"": ""Twinkling Pollox"",
		""englishTooltip"": [
			""The scales gleam like crystals""
		],
		""name"": ""Pollox Clignotant"",
		""tooltip"": [
			""Les écailles brillent comme des cristaux""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AntiCystOintment"",
		""type"": ""ITEM"",
		""englishName"": ""Anti-Cyst Ointment"",
		""englishTooltip"": [
			""Favorite this item to prevent perforator cysts from spawning near you""
		],
		""name"": ""Pommade Anti-Kyste"",
		""tooltip"": [
			""Favorisez cet objet pour empêcher les kystes de perforateur d'apparaître""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AntiTumorOintment"",
		""type"": ""ITEM"",
		""englishName"": ""Anti-Tumor Ointment"",
		""englishTooltip"": [
			""Favorite this item to prevent hive cysts from spawning near you""
		],
		""name"": ""Pommade Anti-Tumeur"",
		""tooltip"": [
			""Favorisez cet objet pour empêcher les kystes de ruche d'apparaître""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateDoor"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Door"",
		""name"": ""Porte Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LaboratoryDoorItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Door"",
		""name"": ""Porte de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SarosPossession"",
		""type"": ""ITEM"",
		""englishName"": ""Saros Possession"",
		""englishTooltip"": [
			""Gain absolute control over light itself"",
			""Summons a radiant aura"",
			""Consumes all of the remaining minion slots on use"",
			""Must be used from the hotbar"",
			""Increased power based on the number of minion slots used""
		],
		""name"": ""Possession de Saros"",
		""tooltip"": [
			""Obtenez le contrôle absolu sur la lumière"",
			""Invoque une aura radieuse"",
			""Consomme tous les emplacements de sbires restants"",
			""Doit être utilisé depuis la barre de raccourcis"",
			""Sa puissance augmente en fonction du nombre d'emplacements de sbires occupés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Poseidon"",
		""type"": ""ITEM"",
		""englishName"": ""Poseidon"",
		""englishTooltip"": [
			""Casts a poseidon typhoon""
		],
		""name"": ""Poséidon"",
		""tooltip"": [
			""Convoque un typhon de Poséidon""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ShatteringPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Shattering Potion"",
		""englishTooltip"": [
			""Increases melee and rogue damage and critical strike chance by 8%"",
			""Melee and rogue attacks break enemy armor"",
			""While this potion's buff is active the Crumbling Potion's buff is disabled""
		],
		""name"": ""Potion Broyeuse"",
		""tooltip"": [
			""Augmente les dégâts de mêlée, de voleur et les chances de coup critique de 8%"",
			""Les attaques de mêlée et de voleur brisent l'armure ennemie"",
			""Quand cette potion est active, les effets de la potion d'effritement sont annulés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GravityNormalizerPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Gravity Normalizer Potion"",
		""englishTooltip"": [
			""Disables the low gravity of space and grants immunity to the distorted debuff""
		],
		""name"": ""Potion Normalisatrice de Gravité"",
		""tooltip"": [
			""Annule la faible gravité de l'espace et immunise a l'altération d'état Distortion""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BoundingPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Bounding Potion"",
		""englishTooltip"": [
			""Grants 5% increased jump speed, 25 extra blocks of fall damage resistance, and increased jump height""
		],
		""name"": ""Potion Rebondissante"",
		""tooltip"": [
			""Accorde 5% de vitesse de saut additionnelle, 25 blocs de hauteur de résistance à la chute, et augmente la hauteur de saut""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TeslaPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Tesla Potion"",
		""englishTooltip"": [
			""Summons an aura of electricity that electrifies and slows enemies"",
			""Aura damage is reduced on bosses"",
			""Reduces the duration of the Electrified debuff""
		],
		""name"": ""Potion Tesla"",
		""tooltip"": [
			""Invoque une aura d'électricité qui électrifie et ralentit les ennemis"",
			""Les dégâts sont réduits sur les boss"",
			""Réduit la durée de l'électrisation""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ZenPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Zen Potion"",
		""englishTooltip"": [
			""Vastly decreases enemy spawn rate""
		],
		""name"": ""Potion Zen"",
		""tooltip"": [
			""Reduit considérablement l'apparition des ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ZergPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Zerg Potion"",
		""englishTooltip"": [
			""Vastly increases enemy spawn rate""
		],
		""name"": ""Potion Zerg"",
		""tooltip"": [
			""Augmente énormément le taux d'apparition des ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CrumblingPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Crumbling Potion"",
		""englishTooltip"": [
			""Increases melee and rogue critical strike chance by 5%"",
			""Melee and rogue attacks break enemy armor""
		],
		""name"": ""Potion d'Effritement"",
		""tooltip"": [
			""Augmente les dégâts et les chances de coup critique de mêlée et de voleur de 5%"",
			""Les attaques de mêlée et de voleur brisent l'armure""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SoaringPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Soaring Potion"",
		""englishTooltip"": [
			""Increases flight time and horizontal flight speed by 10%"",
			""Restores a fraction of your wing flight time after a true melee strike"",
			""The amount of flight time restored scales with your melee stats and weapon swing speed""
		],
		""name"": ""Potion d'Envol"",
		""tooltip"": [
			""Augmente le temps et la vitesse horizontale de vol de 10%"",
			""Restaure une fraction de votre temps de vol après une frappe de vraie mêlée réussie"",
			""Le montant restauré varie en fonction de vos statistiques de mêlée et da la vitesse de frappe de votre arme""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ShadowPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Shadow Potion"",
		""englishTooltip"": [
			""Causes the player to disappear while not attacking"",
			""Holding different types of rogue weapons give the player boosts"",
			""Different types of rogue weapons spawn different projectiles on hit"",
			""Stealth generation is increased by 10%""
		],
		""name"": ""Potion d'Ombre"",
		""tooltip"": [
			""Vous fait disparaître quand vous n'attaquez pas"",
			""Porter différents types d'armes de voleur donne différentes améliorations"",
			""Les différents types d'armes de voleur créent des projectiles différents quand ils touchent"",
			""La génération de furtivité est augmentée de 10%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PotionofOmniscience"",
		""type"": ""ITEM"",
		""englishName"": ""Potion of Omniscience"",
		""englishTooltip"": [
			""Highlights nearby creatures, enemy projectiles,"",
			""danger sources, and treasure""
		],
		""name"": ""Potion d'Omniscience"",
		""tooltip"": [
			""Montre les créatures, les projectiles ennemis,"",
			""les pièges et les trésors""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TitanScalePotion"",
		""type"": ""ITEM"",
		""englishName"": ""Titan Scale Potion"",
		""englishTooltip"": [
			""Increases knockback, defense by 5 and damage reduction by 5%"",
			""Increases defense by an additional 20 and damage reduction by an additional 5% for 10 seconds after a true melee strike""
		],
		""name"": ""Potion d'Écaille de Titan"",
		""tooltip"": [
			""Augmente le recul, la défense de 5 et la réduction des dégâts de 5%"",
			""Augmente la défense de 25 et la réduction des dégâts de 10% pendant quelques secondes après un coup de vraie mêlée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HolyWrathPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Holy Wrath Potion"",
		""englishTooltip"": [
			""Increases damage by 12% and your attacks inflict holy fire"",
			""While this potion's buff is active the Wrath Potion's buff is disabled""
		],
		""name"": ""Potion d'Îre Divine"",
		""tooltip"": [
			""Augmente les dégâts de 12%"",
			""Vos attaques infligent le feu sacré"",
			""L'effet de la potion d'îre est désactivé quand cette potion est active""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CalciumPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Calcium Potion"",
		""englishTooltip"": [
			""Grants immunity to fall damage""
		],
		""name"": ""Potion de Calcium"",
		""tooltip"": [
			""Immunise contre les dégâts de chûte""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CeaselessHungerPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Ceaseless Hunger Potion"",
		""englishTooltip"": [
			""Causes you to suck up all items in the world""
		],
		""name"": ""Potion de Faim Incessante"",
		""tooltip"": [
			""Vous fait attirer tous les objets du monde""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SupremeManaPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Supreme Mana Potion"",
		""name"": ""Potion de Mana Suprême"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SulphurskinPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurskin Potion"",
		""englishTooltip"": [
			""Reduces the effects of the sulphuric waters""
		],
		""name"": ""Potion de Peau Sulfurique"",
		""tooltip"": [
			""Réduit les effets des eaux sulfuriques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PhotosynthesisPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Photosynthesis Potion"",
		""englishTooltip"": [
			""You regen life quickly while not moving, this effect is five times as strong during daytime"",
			""Dropped hearts heal more HP""
		],
		""name"": ""Potion de Photosynthèse"",
		""tooltip"": [
			""Vous récupérez de la vie rapidement quand vous êtes immobile, cet effet est cinq fois plus puissant la journée"",
			""Les coeurs de vie rendent plus de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PenumbraPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Penumbra Potion"",
		""englishTooltip"": [
			""Rogue stealth generates 15% faster while moving"",
			""At night, stealth also generates 15% faster while standing still"",
			""During an eclipse both boosts increase to 20%""
		],
		""name"": ""Potion de Pénombre"",
		""tooltip"": [
			""La furtivité se génère 15% plus rapidement quand vous vous déplacez"",
			""La nuit, la furtivité se génère également 15 % plus rapidement en restant immobile"",
			""Pendant une éclipse, les deux augmentations sont portées à 20%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedRagePotion"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Rage Potion"",
		""englishTooltip"": [
			""Increases critical strike chance by 12%"",
			""While this potion's buff is active the Rage Potion's buff is disabled""
		],
		""name"": ""Potion de Rage Profanée"",
		""tooltip"": [
			""Augmente les chances de coup critique de 12%"",
			""Quand cette potion est active, l'effet de la potion de rage est désactivé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OmegaHealingPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Omega Healing Potion"",
		""name"": ""Potion de Soin Omega"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SupremeHealingPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Supreme Healing Potion"",
		""name"": ""Potion de Soin Suprême"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TriumphPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Triumph Potion"",
		""englishTooltip"": [
			""Enemy contact damage is reduced, the lower their health the more it is reduced""
		],
		""name"": ""Potion de Triomphe"",
		""tooltip"": [
			""Les dégâts de contact des ennemis sont réduits, au plus leur vie est faible au plus les dégâts sont réduits""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TrashmanTrashcan"",
		""type"": ""ITEM"",
		""englishName"": ""Trash Can"",
		""englishTooltip"": [
			""Summons the trash man""
		],
		""name"": ""Poubelle"",
		""tooltip"": [
			""Invoque le responsable des poubelles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ArchaicPowder"",
		""type"": ""ITEM"",
		""englishName"": ""Archaic Powder"",
		""englishTooltip"": [
			""20% increased mining speed, 5% damage reduction and +10 defense while underground or in the underworld""
		],
		""name"": ""Poudre Archaïque"",
		""tooltip"": [
			""+20% de vitesse de minage, 5% de réduction des dégâts et +10 défense quand vous êtes sous terre ou en enfer""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralDirt"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Dirt"",
		""name"": ""Poussière Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AncientBoneDust"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient Bone Dust"",
		""name"": ""Poussière d'Os Ancienne"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DemonicBoneAsh"",
		""type"": ""ITEM"",
		""englishName"": ""Demonic Bone Ash"",
		""name"": ""Poussière d'Os Démoniaque"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Stardust"",
		""type"": ""ITEM"",
		""englishName"": ""Stardust"",
		""name"": ""Poussière d'Étoile"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SausageMaker"",
		""type"": ""ITEM"",
		""englishName"": ""Sausage Maker"",
		""englishTooltip"": [
			""Sprays homing blood on hit""
		],
		""name"": ""Poussoir à Saucisses"",
		""tooltip"": [
			""Arrose de sang à tête chercheuse quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StormSurge"",
		""type"": ""ITEM"",
		""englishName"": ""Storm Surge"",
		""englishTooltip"": [
			""Fear the storm"",
			""Does not consume ammo""
		],
		""name"": ""Poussée de Tempête"",
		""tooltip"": [
			""Crains la Tempête"",
			""Ne consomme pas de munitions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PrimroseKeepsake"",
		""type"": ""ITEM"",
		""englishName"": ""Primrose Keepsake"",
		""englishTooltip"": [
			""Did they just...""
		],
		""name"": ""Primevère Souvenir"",
		""tooltip"": [
			""Est-ce qu'ils viennent de...""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Prismalline"",
		""type"": ""ITEM"",
		""englishName"": ""Prismalline"",
		""englishTooltip"": [
			""Throws daggers that split after a while"",
			""Stealth strikes additionally explode into prism shards and briefly stun enemies""
		],
		""name"": ""Prismalline"",
		""tooltip"": [
			""Lance des dagues qui se divisent après un moment"",
			""Les attaques furtives explosent également en éclats de prisme et stoppent les ennemis brièvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SeaPrism"",
		""type"": ""ITEM"",
		""englishName"": ""Sea Prism"",
		""name"": ""Prisme Marin"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PestilentDefiler"",
		""type"": ""ITEM"",
		""englishName"": ""Pestilent Defiler"",
		""englishTooltip"": [
			""Converts musket balls into plague rounds that explode and split apart on death""
		],
		""name"": ""Profanateur Pestilentiel"",
		""tooltip"": [
			""Convertit les balles de mousquet en cartouches de peste qui explosent et se divisent à l'impact""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LeonidProgenitor"",
		""type"": ""ITEM"",
		""englishName"": ""Leonid Progenitor"",
		""englishTooltip"": [
			""Throws a bombshell that explodes, summoning a meteor to impact the site"",
			""Right click to throw a spread of gravity affected comets that explode, leaving behind a star"",
			""Stealth strikes lob a bombshell that additionally splits into comets on hit""
		],
		""name"": ""Progéniteur Léonide"",
		""tooltip"": [
			""Lance une bombe qui explose et invoque un météore à l'impact"",
			""Clic droit pour lancer une volée de comètes affectées par la gravité qui explose, laissant derrière elles une étoile"",
			""Les attaques furtives lobent une bombe qui se séparent en comètes quand elle touche""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LabHologramProjectorItem"",
		""type"": ""ITEM"",
		""englishName"": ""Lab Hologram Projector"",
		""name"": ""Projecteur d'Hologramme de Labo"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RustyBeaconPrototype"",
		""type"": ""ITEM"",
		""englishName"": ""Rusty Beacon Prototype"",
		""englishTooltip"": [
			""Summons a long-abandoned drone to support you"",
			""Clicking on an enemy gives them a tiny prick, causing them to become aggravated"",
			""The drone hovers above nearby enemies and inflicts irradiated""
		],
		""name"": ""Prototype de Balise Rouillée"",
		""tooltip"": [
			""Invoque un drone abandonné depuis longtemps pour vous aider"",
			""Cliquer sur un ennemi le piquera un peu, ce qui le rendra aggresif à votre égard"",
			""Le drone flotte au dessus des ennemis proches et inflige l'irradiation""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeProvidence"",
		""type"": ""ITEM"",
		""englishName"": ""Providence, the Profaned Goddess"",
		""englishTooltip"": [
			""A core surrounded by stone and flame, a simple origin and a simple goal."",
			""What would have become of us had she not been defeated is a frightening concept to consider.""
		],
		""name"": ""Providence, la Déesse Profanée"",
		""tooltip"": [
			""Un noyau entouré de pierre et de flammes, une origine simple et un but simple."",
			""Ce qui serait arrivé de nous si elle n'avait pas été vaincue est une pensée effrayante à s'imaginer.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PermafrostsConcoction"",
		""type"": ""ITEM"",
		""englishName"": ""Permafrost's Concoction"",
		""englishTooltip"": [
			""Increases maximum mana by 50 and reduces mana cost by 15%"",
			""Increases life regen as life decreases"",
			""Increases life regen when afflicted with Poison, On Fire, or Brimstone Flames"",
			""You will survive fatal damage and revive with 30% life on a 3 minute cooldown"",
			""You are encased in an ice barrier for 3 seconds when revived""
		],
		""name"": ""Préparation de Permafrost"",
		""tooltip"": [
			""Augmente le mana maximum de 50 et réduit les coûts en mana de 15%"",
			""Augmente la régénération de vie au fur et à mesure que votre vie diminiue"",
			""Augmente la régénération de vie lorsque vous subissez le poison, le feu ou la brûlure de soufre"",
			""Vous survivrez à une attaque mortelle et vous récupèrerez 30% de votre vie avec un temps de recharge de 3 minutes"",
			""Vous êtes prisonnier d'une barrière de glace pendant 3 secondes lorsque cet effet s'active""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StormSpray"",
		""type"": ""ITEM"",
		""englishName"": ""Storm Spray"",
		""englishTooltip"": [
			""Fires a spray of water that drips extra trails of water""
		],
		""name"": ""Pulvériseur de Tempête"",
		""tooltip"": [
			""Tire une pulvérisation d'eau qui laisse encore plus d'eau dans son sillage""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PurgeGuzzler"",
		""type"": ""ITEM"",
		""englishName"": ""Purge Guzzler"",
		""englishTooltip"": [
			""Emits three beams of holy energy in a tight spread""
		],
		""name"": ""Purge Gloutonne"",
		""tooltip"": [
			""Tire une volée sérée de trois rayons d'énergie sacrée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MurkyPaste"",
		""type"": ""ITEM"",
		""englishName"": ""Murky Paste"",
		""name"": ""Pâte Trouble"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Penumbra"",
		""type"": ""ITEM"",
		""englishName"": ""Penumbra"",
		""englishTooltip"": [
			""Throws a shadow bomb that explodes into homing souls"",
			""Stealth strikes make the bomb manifest on the cursor and explode into more souls""
		],
		""name"": ""Pénombre"",
		""tooltip"": [
			""Lance une bombe d'ombre qui explose en âmes à tête chercheuse"",
			""Les attaques furtives téléportent la bombe sur le curseur et libèrent un plus grand nombre d'âmes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Quagmire"",
		""type"": ""ITEM"",
		""englishName"": ""Quagmire"",
		""englishTooltip"": [
			""Fires spore clouds""
		],
		""name"": ""Quagmire"",
		""tooltip"": [
			""Tire des nuages de spores""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MushroomPlasmaRoot"",
		""type"": ""ITEM"",
		""englishName"": ""Mushroom Plasma Root"",
		""englishTooltip"": [
			""Permanently increases the duration of Rage Mode by 1 second"",
			""Revengeance drop""
		],
		""name"": ""Racine de Champignon Plasmique"",
		""tooltip"": [
			""Augmente de façon permanente la durée du mode Rage de 1 seconde"",
			""Revengeance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StaticRefiner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": ""Raffineur Statique"",
		""tooltip"": [
			""Utilisé pour l'artisanat spécial""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DragonRage"",
		""type"": ""ITEM"",
		""englishName"": ""Dragon Rage"",
		""englishTooltip"": [
			""Twirls a baton that causes explosions on enemy hits"",
			""Every ten hits will summon a ring of fireballs""
		],
		""name"": ""Rage du Dragon"",
		""tooltip"": [
			""Fait virevolter un bâton qui provoque des explosions en touchant les ennemis"",
			""Invoque un anneau de boule de feu tout les dix coups portés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BladedgeGreatbow"",
		""type"": ""ITEM"",
		""englishName"": ""Bladedge Railbow"",
		""englishTooltip"": [
			""Fires 4 arrows at once"",
			""Fires 2 additional leaves""
		],
		""name"": ""Railarc Tranchelame"",
		""tooltip"": [
			""Tire 4 flèches à la fois"",
			""Tire 2 feuilles en plus des flèches""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DankStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Dank Staff"",
		""englishTooltip"": [
			""Summons a dank creeper to fight for you""
		],
		""name"": ""Rampant Humide"",
		""tooltip"": [
			""Le rampant humide vous protègera""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StormfrontRazor"",
		""type"": ""ITEM"",
		""englishName"": ""Stormfront Razor"",
		""englishTooltip"": [
			""Throws a throwing knife that leaves sparks as it travels."",
			""Stealth strikes cause the knife to be faster and leave a huge shower of sparks as it travels""
		],
		""name"": ""Rasoir Face-Tempête"",
		""tooltip"": [
			""Jette un couteau de lancer qui laisse des étincelles sur sa trajectoire."",
			""Les attaques furtives rendent le couteau plus rapide et laissent une énorme pluie d'étincelles sur leur trajet""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeRavager"",
		""type"": ""ITEM"",
		""englishName"": ""Ravager"",
		""englishTooltip"": [
			""The flesh golem constructed using twisted necromancy during the time of my conquest to counter my unstoppable forces."",
			""Its creators were slaughtered by it moments after its conception. It is for the best that it has been destroyed.""
		],
		""name"": ""Ravageur"",
		""tooltip"": [
			""Le golem de chair construit en utilisant une nécromancie pervertie du temps de ma conquête pour contrer mes forces inarrêtables."",
			""Ses créateurs ont été massacrés par leur création un instant après sa création. Sa destruction est pour le mieux.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RealmRavager"",
		""type"": ""ITEM"",
		""englishName"": ""Realm Ravager"",
		""englishTooltip"": [
			""Shoots a burst of 3 to 4 bullets"",
			""Converts musket balls into explosive bullets""
		],
		""name"": ""Ravageur de Royaume"",
		""tooltip"": [
			""Tire une rafale de 3 à 4 balles"",
			""Convertit les balles de mousquet en balles explosives""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AlphaRay"",
		""type"": ""ITEM"",
		""englishName"": ""Alpha Ray"",
		""englishTooltip"": [
			""Disintegrates everything with a tri-beam of energy and lasers"",
			""Right click to fire a Y-shaped beam of destructive energy and a spread of lasers""
		],
		""name"": ""Rayon Alpha"",
		""tooltip"": [
			""Désintègre tout avec un tri-rayon d'énergie et des lasers"",
			""Clic droit pour tirer un rayon d'énergie destructrice en forme de Y et une volée de lasers""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TerraRay"",
		""type"": ""ITEM"",
		""englishName"": ""Terra Ray"",
		""englishTooltip"": [
			""Casts an energy ray that splits into energy on enemy hits"",
			""More energy is created the farther along the ray the hit enemy is""
		],
		""name"": ""Rayon Terra"",
		""tooltip"": [
			""Convoque un rayon d'énergie qui se divise si les ennemis en sont proches"",
			""Au plus le rayon touche l'ennemi de loin, au plus l'énergie créée sera importante""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CarnageRay"",
		""type"": ""ITEM"",
		""englishName"": ""Carnage Ray"",
		""englishTooltip"": [
			""Fires a blood ray"",
			""The farther along the ray hit enemies are, the more damage they take""
		],
		""name"": ""Rayon de Carnage"",
		""tooltip"": [
			""Tire un rayon sanglant"",
			""Au plus le rayon touche l'ennemi de loin, au plus les dégâts sont importants""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ValkyrieRay"",
		""type"": ""ITEM"",
		""englishName"": ""Valkyrie Ray"",
		""englishTooltip"": [
			""Casts a devastating ray of holy power""
		],
		""name"": ""Rayon de Valkyrie"",
		""tooltip"": [
			""Invoque un rayon dévastateur d'énergie sacrée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NightsRay"",
		""type"": ""ITEM"",
		""englishName"": ""Night's Ray"",
		""englishTooltip"": [
			""Fires a dark ray"",
			""When hitting enemies, they are hit by several new beams from their sides""
		],
		""name"": ""Rayon de la Nuit"",
		""tooltip"": [
			""Tire un rayon sombre"",
			""Quand il touche les ennemis, ils sont touchés par de nombreux nouveaux rayons sur leurs côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElementalRay"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Ray"",
		""englishTooltip"": [
			""Casts four celestial beams near the player"",
			""Solar beams explode into fire on enemy hits"",
			""Nebula beams sweep a little bit over time"",
			""Vortex beams act like fast lightning and electrify enemies on hit"",
			""Stardust beams release small stars that home on enemy hits""
		],
		""name"": ""Rayon des Éléments"",
		""tooltip"": [
			""Tire quatre rayons célèstes près du joueur"",
			""Les rayons solaires provoques des explosions de feu quand ils touchent"",
			""Les rayons nébuleux balayent un peu au fur et à mesure"",
			""Les rayons de vortex se comporte comme la foudre et électrifient les ennemis quand ils touchent"",
			""Les rayons de poussière d'étoile relâchent des petites étoiles à tête chercheuse quand ils touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RedSeekingMechanism"",
		""type"": ""ITEM"",
		""englishName"": ""Red Seeking Mechanism"",
		""englishTooltip"": [
			""Moves swiftly towards a lab within the underworld""
		],
		""name"": ""Red Seeking Mechanism"",
		""tooltip"": [
			""Se déplace prestement vers un laboratoire dans les enfers""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PrismaticRegalia"",
		""type"": ""ITEM"",
		""englishName"": ""Prismatic Regalia"",
		""englishTooltip"": [
			""12% increased magic damage and 15% increased magic crit"",
			""20% decreased non-magic damage"",
			""+20 max life and +40 max mana"",
			""Magic attacks occasionally fire a pair of homing rockets""
		],
		""name"": ""Regalia Prismatique"",
		""tooltip"": [
			""+12% de dégâts magiques et +15% de chances de coup critique magique"",
			""-20% aux dégâts non-magiques"",
			""+20 vie maximum et +40 mana maximum"",
			""Les attaques magiques relâchent occasionnellement une paire de missiles à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""UmbraphileRegalia"",
		""type"": ""ITEM"",
		""englishName"": ""Umbraphile Regalia"",
		""englishTooltip"": [
			""10% increased rogue damage and 10% increased rogue crit""
		],
		""name"": ""Regalia Umbraphile"",
		""tooltip"": [
			""+10% de dégâts et de chances de coup critique de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TelluricGlare"",
		""type"": ""ITEM"",
		""englishName"": ""Telluric Glare"",
		""englishTooltip"": [
			""Fires volleys of four colossal radiant arrows which can pass through walls""
		],
		""name"": ""Regard Tellurique"",
		""tooltip"": [
			""Tire une vollée de 4 flèches radieuses colossales qui traversent les murs""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GazeOfCrysthamyr"",
		""type"": ""ITEM"",
		""englishName"": ""Gaze of Crysthamyr"",
		""englishTooltip"": [
			""Summons a shadow dragon""
		],
		""name"": ""Regard de Crysthamyr"",
		""tooltip"": [
			""Invoque un dragon d'ombre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NightsGaze"",
		""type"": ""ITEM"",
		""englishName"": ""Night's Gaze"",
		""englishTooltip"": [
			""Strike your foes with this spear of the night"",
			""Throws a spear that shatters when it hits an enemy"",
			""Stealth strikes cause the spear to summon homing stars as it flies""
		],
		""name"": ""Regard de la Nuit"",
		""tooltip"": [
			""Frappez vos ennemis avec cette lance de la nuit"",
			""Jette une lance qui se brise quand elle touche un ennemi"",
			""Les attaques furtives créent des étoiles qui pourchassent les ennemis sur la trajectoire de la lance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeQueenBee"",
		""type"": ""ITEM"",
		""englishName"": ""Queen Bee"",
		""englishTooltip"": [
			""As crude as the giant insects are they can prove useful in certain situations... given the ability to control them.""
		],
		""name"": ""Reine des Abeilles"",
		""tooltip"": [
			""Aussi grossier que puissent-être les insectes géants, ils peuvent se montrer utiles dans certains situations...pourvu qu'on puisse les contrôler.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CharredRelic"",
		""type"": ""ITEM"",
		""englishName"": ""Charred Relic"",
		""englishTooltip"": [
			""Contains a small amount of brimstone""
		],
		""name"": ""Relique Calcinée"",
		""tooltip"": [
			""Contient une petite quantité de soufre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RelicOfConvergence"",
		""type"": ""ITEM"",
		""englishName"": ""Relic of Convergence"",
		""englishTooltip"": [
			""Creates a profaned crystal that charges power"",
			""Holding out the crystal slows the player down"",
			""At the end of its life, the crystal heals the player for 70 HP""
		],
		""name"": ""Relique de Convergence"",
		""tooltip"": [
			""Crée un cristal profané qui accumule du pouvoir"",
			""Tenir le cristal vous ralentit"",
			""En fin de charge, le cristal soigne l'utilisateur de 70 points de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RelicOfDeliverance"",
		""type"": ""ITEM"",
		""englishName"": ""Relic of Deliverance"",
		""englishTooltip"": [
			""Summons a spear that causes you to lunge towards the mouse position"",
			""The spear requires a charge-up. The longer the charge, the stronger the lunge"",
			""The spear disappears immediately if you are not holding this item while charging"",
			""If enough time has passed or the spear collides into a wall, the spear dies and the lunge ends""
		],
		""name"": ""Relique de Délivrance"",
		""tooltip"": [
			""Invoque une lance qui vous propulse vers le curseur de la souris"",
			""La lance doit être chargée. Plus longtemps vous la chargez, plus la propulsion est forte"",
			""La lance disparaît immédiatement si vous ne tenez pas cet objet durant la charge"",
			""Si trop de temps passe ou que la lance heurte un mur, la lance est détruite et la propulsion cesse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RelicofRuin"",
		""type"": ""ITEM"",
		""englishName"": ""Relic of Ruin"",
		""englishTooltip"": [
			""Casts a spread of sand blades""
		],
		""name"": ""Relique de Ruine"",
		""tooltip"": [
			""Convoque une étendue de lames de sable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RelicOfResilience"",
		""type"": ""ITEM"",
		""englishName"": ""Relic of Resilience"",
		""englishTooltip"": [
			""DO NOT TRAD""
		],
		""name"": ""Relique de Résilience"",
		""tooltip"": [
			""Invoque un rempart à la position du curseur"",
			""Le rempart est tué par les ennemis et tous les projectiles."",
			""Quand il est tué, le rempart explose dans un tourbillon d'éclats"",
			""Si un ennemi est dans la zone d'effet des éclats, sa prochaine attaque sera beaucoup plus faible. Cet effet à un temps de recharge"",
			""Après un peu de temps, les éclats se rejoignent pour reformer le rempart."",
			""\"" + $\""Cette reformation ne peut arriver que {3} fois."",
			""\"" + \""Vous avez un petit temps de recharge après avoir invoqué un nouveau rempart."",
			""Si un rempart est déjà présent, utiliser cet objet le déplacera""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""NormalityRelocator"",
		""type"": ""ITEM"",
		""englishName"": ""Normality Relocator"",
		""englishTooltip"": [
			""I'll be there in the blink of an eye"",
			""This line is modified below"",
			""Fall speed is doubled for 30 frames after teleporting"",
			""Teleportation is disabled while Chaos State is active"",
			""Works while in the inventory""
		],
		""name"": ""Relocalisateur de Normalité"",
		""tooltip"": [
			""Je serais la en un clin d'oeil"",
			""Appuyez sur le raccourci pour vous téléporter à l'emplacement du curseur"",
			""La téléportation est impossible quand vous êtes sous l'état chaos"",
			""Double la vitesse de chute pendant un court instant après une téléportation"",
			""Fonctionne depuis l'inventaire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RampartofDeities"",
		""type"": ""ITEM"",
		""englishName"": ""Rampart of Deities"",
		""englishTooltip"": [
			""Causes stars to fall and gives increased immune time when damaged"",
			""Provides life regeneration and reduces the cooldown of healing potions"",
			""Absorbs 25% of damage done to players on your team"",
			""This effect is only active above 25% life"",
			""Grants immunity to knockback"",
			""Puts a shell around the owner when below 50% life that reduces damage taken""
		],
		""name"": ""Rempart des Divinités"",
		""tooltip"": [
			""Vous faites tomber des étoiles et votre période d'invulnérabilité est augmentée lorsque vous êtes touché"",
			""Accorde de la régénération de vie et réduit le temps de recharge des potions"",
			""Absorbe 25% des dégâts infligés aux membres de votre équipe"",
			""Cet effet n'est actif que si vous possédez plus d'un quart de vos points de vie"",
			""Immunisé au recul"",
			""Crée une carapace autour de l'utilisateur quand ses points de vie descendent en dessous de la moitié, qui réduit les dégâts subis"",
			""La carapace devient plus résistance en dessous de 15% de vie et réduit encore plus les dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HandheldTank"",
		""type"": ""ITEM"",
		""englishName"": ""Handheld Tank"",
		""name"": ""Reservoir Portable"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AnechoicCoating"",
		""type"": ""ITEM"",
		""englishName"": ""Anechoic Coating"",
		""englishTooltip"": [
			""Reduces creatures' ability to detect you in the abyss""
		],
		""name"": ""Revêtement Anechoïque"",
		""tooltip"": [
			""Réduit la faculté des créatures à vous détecter dans les abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Rum"",
		""type"": ""ITEM"",
		""englishName"": ""Rum"",
		""englishTooltip"": [
			""Sweet and potent, just how I like it"",
			""Boosts life regen by 2 and movement speed by 10%"",
			""Reduces defense by 5%""
		],
		""name"": ""Rhum"",
		""tooltip"": [
			""Doux et fort, juste comme je l'aime"",
			""Augmente la régénération de vie de 2 et la vitesse de mouvement de 10%"",
			""Réduit la défense de 5%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CaribbeanRum"",
		""type"": ""ITEM"",
		""englishName"": ""Caribbean Rum"",
		""englishTooltip"": [
			""Why is the rum gone?"",
			""Boosts life regen by 2, movement speed by 10% and wing flight time by 20%"",
			""Makes you floaty and reduces defense by 10%""
		],
		""name"": ""Rhum des Caraïbes"",
		""tooltip"": [
			""Mais pourquoi y a plus de rhum?"",
			""Augmente la régénération de vie de 2, la vitesse de mouvement de 10% et le temps de vol de 20%"",
			""Vous rends flottant et réduit la défense de 10%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SCalRobes"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitous Robes"",
		""name"": ""Robe Calamiteuse"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CirrusDress"",
		""type"": ""ITEM"",
		""englishName"": ""Cirrus' Dress"",
		""englishTooltip"": [
			""Here, this should help you drink as much alcohol as you want!"",
			""5% increased magic damage and critical strike chance"",
			""You feel thick...""
		],
		""name"": ""Robe de Cirrus"",
		""tooltip"": [
			""Tiens, ca devrait t'aider a boire autant d'alcool que tu veux!"",
			""+5% de dégâts et de chances de coup critique magique"",
			""Vous vous sentez épais...""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimflameRobes"",
		""type"": ""ITEM"",
		""englishName"": ""Brimflame Robes"",
		""englishTooltip"": [
			""5% increased magic damage and critical strike chance"",
			""Reduces damage from touching lava""
		],
		""name"": ""Robes de Flammesoufre"",
		""tooltip"": [
			""+5% de dégâts et de chances de coup critique magique"",
			""Effet de la rose d'obsidienne""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ManaRose"",
		""type"": ""ITEM"",
		""englishName"": ""Mana Rose"",
		""englishTooltip"": [
			""Casts a mana flower that explodes into petals""
		],
		""name"": ""Rose de Mana"",
		""tooltip"": [
			""Convoque une fleur de mana qui explose en pétales""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GildedProboscis"",
		""type"": ""ITEM"",
		""englishName"": ""Gilded Proboscis"",
		""englishTooltip"": [
			""Heals the player on hit""
		],
		""name"": ""Rostre Doré"",
		""tooltip"": [
			""Soigne le joueur quand il touche""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LivingDew"",
		""type"": ""ITEM"",
		""englishName"": ""Living Dew"",
		""englishTooltip"": [
			""5% increased damage reduction, +5 defense, and increased life regen while in the Jungle"",
			""Immunity to Poison""
		],
		""name"": ""Rosée Vivante"",
		""tooltip"": [
			""5% de réduction des dégâts, +5 défense, et régénération de vie augmentée dans la jungle"",
			""Immunité au poison""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HoneyDew"",
		""type"": ""ITEM"",
		""englishName"": ""Honey Dew"",
		""englishTooltip"": [
			""5% increased damage reduction, +9 defense and increased life regen while in the Jungle"",
			""Poison and Venom immunity"",
			""Honey-like life regen with no speed penalty"",
			""Most bee/hornet enemies and projectiles do 75% damage to you""
		],
		""name"": ""Rosée de Miel"",
		""tooltip"": [
			""Réduit les dégâts subis de 5%, +9 défense et régénération de vie augmentée quand vous êtes dans la jungle"",
			""Immunité au poison et au venin"",
			""Régénération de vie apparentée au miel mais sans pénalité de vitesse"",
			""La plupart des abeilles/frelons et leur projectiles ne vous font plus que 75% des dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Roxcalibur"",
		""type"": ""ITEM"",
		""englishName"": ""Roxcalibur"",
		""englishTooltip"": [
			""You couldn’t get it out of the rock, so you just brought the rock instead"",
			""A hellish entity of flesh holds the key to this weapon’s power"",
			""Left click to shoot several rock shards"",
			""Right click to dive downwards and bounce off enemies"",
			""Diving into blocks creates a shockwave""
		],
		""name"": ""Roxcalibur"",
		""tooltip"": [
			""Tu n'as pas pu la sortir de la roche, alors tu as juste pris le rocher à la place"",
			""Une entité de chair infernale possède la clé du pouvoir de cette arme"",
			""Clic gauche pour tirer plusieurs éclats de roche"",
			""Clic droit pour plonger et rebondir sur les ennemis"",
			""Plonger sur les tuiles provoque une onde de choc""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RubicoPrime"",
		""type"": ""ITEM"",
		""englishName"": ""Rubico Prime"",
		""englishTooltip"": [
			""Semi-automatic sniper that fires in 5 second bursts"",
			""Fires impact rounds that have an increased crit multiplier""
		],
		""name"": ""Rubico Prime"",
		""tooltip"": [
			""Sniper semi-automatique qui tire en rafales de 5 secondes"",
			""Tire des cartouches à impact qui ont un multiplicateur critique plus élevé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueHive"",
		""type"": ""ITEM"",
		""englishName"": ""Plague Hive"",
		""englishTooltip"": [
			""All attacks inflict the Plague and grants immunity to the Plague"",
			""Releases bees when damaged that inflict the Plague"",
			""Projectiles spawn plague seekers on enemy hits""
		],
		""name"": ""Ruche de Peste"",
		""tooltip"": [
			""Relâche des abeilles qui infligent lorsque vous êtes endommagé"",
			""Toutes vos attaques infligent la peste"",
			""Les projectiles créent des cherche-peste lorsqu'ils touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PhantasmalRuin"",
		""type"": ""ITEM"",
		""englishName"": ""Phantasmal Ruin"",
		""englishTooltip"": [
			""Fires an enormous ghost lance that emits lost souls as it flies"",
			""Explodes into tormented souls on enemy hits"",
			""Stealth strikes continuously leave spectral clones in their wake""
		],
		""name"": ""Ruine Fantasmatique"",
		""tooltip"": [
			""Tire une énorme lance fantôme qui laisse des âmes perdues dans son sillage"",
			""Explose en esprits fantômes quand vous touchez"",
			""Les attaques furtives invoquent des clones fantomes dans leur sillage""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HallowedRune"",
		""type"": ""ITEM"",
		""englishName"": ""Hallowed Rune"",
		""englishTooltip"": [
			""Whenever your minions hit an enemy you will gain a random buff, does not stack with downgrades"",
			""These buffs will either boost your defense, summon damage, or life regen for a while"",
			""If you have the offensive boost, enemies hit by minions will sometimes be hit by stars""
		],
		""name"": ""Rune Sacrée"",
		""tooltip"": [
			""Quand vos sbires endommagent un ennemi, vous gagnez une amélioration aléatoire"",
			""Ne se cumule pas avec les accessoires la composant"",
			""Ces améliorations augmenteront votre défense, vos dégâts d'invocation ou votre régénération de vie durant un moment"",
			""Si vous avec l'amélioration de dégâts, les ennemis touchés par vos sbires seront parfois frappés par les étoiles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodRune"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Rune"",
		""englishTooltip"": [
			""Used with the Ice Barrage "",
			""Found in some sort of runic landscape""
		],
		""name"": ""Rune de Sang"",
		""tooltip"": [
			""Utilisé avec le barrage de glace"",
			""Trouvé dans une sorte de paysage runique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RegulusRiot"",
		""type"": ""ITEM"",
		""englishName"": ""Regulus Riot"",
		""englishTooltip"": [
			""Fires a swift homing disk"",
			""Stealth strikes explode into energy stars""
		],
		""name"": ""Rébellion de Régulus"",
		""tooltip"": [
			""Tire un disque à tête chercheuse rapide"",
			""Les attaques furtives explosent en étoiles d'énergie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RecitationoftheBeast"",
		""type"": ""ITEM"",
		""englishName"": ""Recitation of the Beast"",
		""englishTooltip"": [
			""A thousand years sealed in the demon's realm will teach you a thing or two"",
			""Summons beast scythes around the player in a small circle,"",
			""before firing toward the cursor and home in to nearby enemies""
		],
		""name"": ""Récitation de la Bête"",
		""tooltip"": [
			""Un millier d'années scellé dans le royaume démoniaque t'apprendras un truc ou deux"",
			""Invoque des faux bestiales autour du joueur dans un petit cercle,"",
			""avant de se propulser vers le curseur et de cibler les ennemis proches""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BalefulHarvester"",
		""type"": ""ITEM"",
		""englishName"": ""Baleful Harvester"",
		""englishTooltip"": [
			""Summons flaming pumpkins and skulls that split into homing fire orbs on enemy hits""
		],
		""name"": ""Récolteur Maléfique"",
		""tooltip"": [
			""Tire des crânes et des citrouilles enflammées qui se divisent en orbes de feu qui pourchassent les ennemis quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SoulHarvester"",
		""type"": ""ITEM"",
		""englishName"": ""Soul Harvester"",
		""englishTooltip"": [
			""Shoots a soul scythe"",
			""Enemies explode when on low health, spreading the plague""
		],
		""name"": ""Récolteur d'Âmes"",
		""tooltip"": [
			""Tire une faux d'âme"",
			""Les ennemis explosent quand ils n'ont plus beaucoup de vie, propageant la peste""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Regenator"",
		""type"": ""ITEM"",
		""englishName"": ""Regenator"",
		""englishTooltip"": [
			""Reduces max HP by 50% but greatly improves life regeneration""
		],
		""name"": ""Régénérateur"",
		""tooltip"": [
			""Réduit la vie maximum de 50% mais augmente grandement la régénération de vie""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Aftershock"",
		""type"": ""ITEM"",
		""englishName"": ""Aftershock"",
		""englishTooltip"": [
			""Summons boulders from the sky on enemy hits""
		],
		""name"": ""Réplique Sismique"",
		""tooltip"": [
			""Invoque des rochers depuis le ciel quand vous touchez les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Keelhaul"",
		""type"": ""ITEM"",
		""englishName"": ""Keelhaul"",
		""englishTooltip"": [
			""Summons a geyser upon hitting an enemy"",
			""Crumple 'em like paper""
		],
		""name"": ""Réprimande"",
		""tooltip"": [
			""Invoque un geyser quand vous touchez un ennemi"",
			""Froisses-les comme du papier""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DivineRetribution"",
		""type"": ""ITEM"",
		""englishName"": ""Divine Retribution"",
		""englishTooltip"": [
			""Mage is superior to rogue; look, we got a donor weapon to prove it!""
		],
		""name"": ""Rétribution Divine"",
		""tooltip"": [
			""Les mages sont supérieurs aux voleurs; regarde, on a une arme de donateur pour le prouver!""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FatesReveal"",
		""type"": ""ITEM"",
		""englishName"": ""Fate's Reveal"",
		""englishTooltip"": [
			""Spawns ghostly fireballs that follow the player""
		],
		""name"": ""Révélation du Destin"",
		""tooltip"": [
			""Crée des boules de feu fantômatiques qui suivent le joueur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralSand"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Sand"",
		""name"": ""Sable Astral"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HardenedAstralSand"",
		""type"": ""ITEM"",
		""englishName"": ""Hardened Astral Sand"",
		""name"": ""Sable Astral Durci"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EutrophicSand"",
		""type"": ""ITEM"",
		""englishName"": ""Eutrophic Sand"",
		""name"": ""Sable Eutrophique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SulphurousSand"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Sand"",
		""name"": ""Sable Sulfureux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HardenedSulphurousSandstone"",
		""type"": ""ITEM"",
		""englishName"": ""Hardened Sulphurous Sandstone"",
		""name"": ""Sable Sulfureux Durci"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ShiftingSands"",
		""type"": ""ITEM"",
		""englishName"": ""Shifting Sands"",
		""englishTooltip"": [
			""Casts a sand shard that follows the mouse cursor""
		],
		""name"": ""Sables Mouvants"",
		""tooltip"": [
			""Convoque un requin des sables qui suit le curseur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ForsakenSaber"",
		""type"": ""ITEM"",
		""englishName"": ""Forsaken Saber"",
		""englishTooltip"": [
			""Shoots three sand blades that alter their velocity as they travel""
		],
		""name"": ""Sabre Abandonné"",
		""tooltip"": [
			""Tire trois lames de sable qui altèrent leur vitesse sur leur trajet""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StormSaber"",
		""type"": ""ITEM"",
		""englishName"": ""Storm Saber"",
		""englishTooltip"": [
			""Fires two homing storm beams"",
			""One from blade and one from the sky""
		],
		""name"": ""Sabre Tempête"",
		""tooltip"": [
			""Tire deux rayons de tempête à tête chercheuse"",
			""Un depuis la lame et l'autre depuis le ciel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""InfernalBlood"",
		""type"": ""ITEM"",
		""englishName"": ""Infernal Blood"",
		""englishTooltip"": [
			""Permanently increases the duration of Rage Mode by 1 second"",
			""Revengeance drop""
		],
		""name"": ""Sang Infernal"",
		""tooltip"": [
			""Améliore de façon permanente la durée du mode Rage d'une seconde"",
			""Revengeance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BelchingSaxophone"",
		""type"": ""ITEM"",
		""englishName"": ""Belching Saxophone"",
		""englishTooltip"": [
			""Doot"",
			""Fires an array of dirty reeds, music notes, and sulphuric bubbles""
		],
		""name"": ""Saxophone Éructant"",
		""tooltip"": [
			""Doot"",
			""Tire un panaché d'anches sales, de notes de musiques et de bulles sulfuriques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MountedScanner"",
		""type"": ""ITEM"",
		""englishName"": ""Mounted Scanner"",
		""englishTooltip"": [
			""Laser technology used in this case for both targeting and defense"",
			""Summons a powerful weapon above your head that fires lasers at nearby enemies""
		],
		""name"": ""Scanner Monté"",
		""tooltip"": [
			""Technologie laser utilisée à la fois pour la visée et la défense dans ce cas précis."",
			""Invoque une puissante arme au-dessus de votre tête qui tire des lasers sur les ennemis proches""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ParasiticSceptor"",
		""type"": ""ITEM"",
		""englishName"": ""Parasitic Scepter"",
		""englishTooltip"": [
			""Fires a spread of water leeches that latch onto enemies, dealing a stacking damage over time""
		],
		""name"": ""Sceptre de Parasitage"",
		""tooltip"": [
			""Tire une volée de sangsue d'eau qui s'accrochent aux ennemis, effectuant des dégâts cumulables sur la durée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EutrophicScimitar"",
		""type"": ""ITEM"",
		""englishName"": ""Eutrophic Scimitar"",
		""englishTooltip"": [
			""Fires two beams that stun enemies""
		],
		""name"": ""Scimitar Eutrophique"",
		""tooltip"": [
			""Tire deux rayons qui stoppent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TwinklerItem"",
		""type"": ""ITEM"",
		""englishName"": ""Twinkler"",
		""name"": ""Scintilleur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Screwdriver"",
		""type"": ""ITEM"",
		""englishName"": ""Screwdriver"",
		""englishTooltip"": [
			""Do you have a screw loose?"",
			""Multiplies piercing projectile damage by 1.05"",
			""Reduces life regen by 1""
		],
		""name"": ""Screwdriver"",
		""tooltip"": [
			""T'as pété un boulon?"",
			""Augmente les dégâts des projectiles perforants de 5%"",
			""Réduit la régénération de la vie de 1""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeMoonLord"",
		""type"": ""ITEM"",
		""englishName"": ""Moon Lord"",
		""englishTooltip"": [
			""What a waste."",
			""Had it been fully restored it would have been a force to behold, but what you fought was an empty shell."",
			""However, that doesn't diminish the immense potential locked within it, released upon its death.""
		],
		""name"": ""Seigneur de la Lune"",
		""tooltip"": [
			""Quel gâchis."",
			""S'il avait été complètement remis, il aurait été un adversaire notoire, mais ce que vous avez combattu n'était qu'une coquille vide."",
			""Toutefois, ça ne diminue pas l'immense potentiel enfermé en lui, qu'il a libéré à sa mort.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AngelTreads"",
		""type"": ""ITEM"",
		""englishName"": ""Angel Treads"",
		""englishTooltip"": [
			""Extreme speed!"",
			""36% increased running acceleration"",
			""Increased flight time"",
			""Greater mobility on ice"",
			""Water and lava walking"",
			""Immunity to the On Fire! debuff"",
			""Temporary immunity to lava""
		],
		""name"": ""Semelles d'Ange"",
		""tooltip"": [
			""Vitesse extrême!"",
			""36% d'accélération supplémentaire en course"",
			""Temps de vol augmenté"",
			""Meilleure mobilité sur la glace"",
			""Vous pouvez marcher sur les liquides"",
			""Immunité à la brûlure"",
			""Immunité temporaire à la lave""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""UrsaSergeant"",
		""type"": ""ITEM"",
		""englishName"": ""Ursa Sergeant"",
		""englishTooltip"": [
			""15% decreased movement speed"",
			""Immune to Astral Infection and Feral Bite"",
			""Increased regeneration at lower health""
		],
		""name"": ""Sergent Ursa"",
		""tooltip"": [
			""-15% de vitesse de déplacement"",
			""Immunité à l'infection astrale et à la morsure sauvage"",
			""Régénération de vie augmentée quand votre vie est faible""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Serpentuna"",
		""type"": ""ITEM"",
		""englishName"": ""Serpentuna"",
		""name"": ""Serpenthon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Serpentine"",
		""type"": ""ITEM"",
		""englishName"": ""Serpentine"",
		""englishTooltip"": [
			""Casts a serpent that follows the mouse cursor""
		],
		""name"": ""Serpentine"",
		""tooltip"": [
			""Convoque un serpent qui suit le curseur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TerrorTalons"",
		""type"": ""ITEM"",
		""englishName"": ""Terror Talons"",
		""englishTooltip"": [
			""Fires small wavering claws"",
			""Stealth strikes launch a large, high speed claw which pierces""
		],
		""name"": ""Serres de Terreur"",
		""tooltip"": [
			""Tire des petites griffes ondulantes"",
			""Les attaques furtives lancent une énorme griffe rapide qui transperce""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LaboratoryServerItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Server"",
		""name"": ""Serveur de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AgedLaboratoryServerItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Server"",
		""name"": ""Serveur de Laboratoire Vieilli"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TitaniumShuriken"",
		""type"": ""ITEM"",
		""englishName"": ""Titanium Shuriken"",
		""englishTooltip"": [
			""Stealth strikes act like a boomerang that spawns clones on enemy hits""
		],
		""name"": ""Shuriken de Titane"",
		""tooltip"": [
			""Les attaques furtives se comportent comme un boomerang et créent des clones quand elles touchent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BurntSienna"",
		""type"": ""ITEM"",
		""englishName"": ""Burnt Sienna"",
		""englishTooltip"": [
			""Causes enemies to erupt into healing projectiles on death""
		],
		""name"": ""Sienne Brulée"",
		""tooltip"": [
			""Les ennemis explosent en orbes de vie quand ils meurent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SigilofCalamitas"",
		""type"": ""ITEM"",
		""englishName"": ""Sigil of Calamitas"",
		""englishTooltip"": [
			""15% increased magic damage and 10% decreased mana usage"",
			""+100 max mana"",
			""Increases pickup range for mana stars""
		],
		""name"": ""Sigle de Calamitas"",
		""tooltip"": [
			""+15% de dégâts magiques et coûts en mana réduits de 10%"",
			""Augmente la portée de collecte des étoiles de mana"",
			""+100 mana maximum""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GalacticaSingularity"",
		""type"": ""ITEM"",
		""englishName"": ""Galactica Singularity"",
		""englishTooltip"": [
			""A shard of the cosmos""
		],
		""name"": ""Singularité Galactique"",
		""tooltip"": [
			""Un fragment du cosmos""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SealedSingularity"",
		""type"": ""ITEM"",
		""englishName"": ""Sealed Singularity"",
		""englishTooltip"": [
			""Shatters on impact, summoning a black hole that sucks in nearby enemies"",
			""Stealth strikes summon a black hole that lasts longer and sucks enemies with stronger force""
		],
		""name"": ""Singularité Scellée"",
		""tooltip"": [
			""Se brise à l'impact et invoque un trou noir qui aspire les ennemis proches"",
			""Les attaques furtives invoquent un trou noir qui dure plus longtemps et qui attire mieux les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Sirius"",
		""type"": ""ITEM"",
		""englishName"": ""Sirius"",
		""englishTooltip"": [
			""Summons the brightest star in the night sky to shine upon your foes"",
			""Consumes all of the remaining minion slots on use"",
			""Must be used from the hotbar"",
			""Increased power based on the number of minion slots used""
		],
		""name"": ""Sirius"",
		""tooltip"": [
			""Invoque la plus brillante des étoiles du ciel nocturne pour luire sur vos ennemis"",
			""Consomme tous les emplacements de sbires restants"",
			""Doit être utilisé depuis la barre des raccourcis"",
			""La puissance augmente en fonction du nombre d'emplacements occupés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeSkeletron"",
		""type"": ""ITEM"",
		""englishName"": ""Skeletron"",
		""englishTooltip"": [
			""The curse is said to only affect the elderly."",
			""After they are afflicted they become an immortal vessel for an ancient demon of the underworld.""
		],
		""name"": ""Skeletron"",
		""tooltip"": [
			""Il est dit que la malédiction n'affecte que les personnes agées."",
			""Une fois contractée, ils deviennent le vaisseau immortel d'un ancien démon des enfers.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeSkeletronPrime"",
		""type"": ""ITEM"",
		""englishName"": ""Skeletron Prime"",
		""englishTooltip"": [
			""What a silly and pointless contraption for something created with the essence of pure terror."",
			""Draedon obviously took several liberties with its design... I am not impressed.""
		],
		""name"": ""Skeletron Prime"",
		""tooltip"": [
			""Un bidule idiot et inutile alors qu'il a été crée avec l'essence de terreur pure."",
			""Draedon a de toute évidence pris plusieurs libertés dans sa conception...Je ne suis pas impressionné.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ShatteredSun"",
		""type"": ""ITEM"",
		""englishName"": ""Shattered Sun"",
		""englishTooltip"": [
			""Throws daggers that split into scorching homing daggers"",
			""Stealth strikes fire volleys of homing daggers from the player on dagger hits that suck enemies in""
		],
		""name"": ""Soleil Brisé"",
		""tooltip"": [
			""Lance des dagues qui se divisent en dagues brûlantes à tête chercheuse"",
			""Les attaques furtives tirent des volées de dagues à têtes chercheuses qui attirent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ForbiddenSun"",
		""type"": ""ITEM"",
		""englishName"": ""Forbidden Sun"",
		""englishTooltip"": [
			""Casts a fire orb that emits a gigantic explosion on death""
		],
		""name"": ""Soleil Interdit"",
		""tooltip"": [
			""Tire une orbe de feu qui émet une gigantesque explosion quand elle disparaît""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RedSun"",
		""type"": ""ITEM"",
		""englishName"": ""Red Sun"",
		""englishTooltip"": [
			""Over paradise"",
			""Drops a barrage of solar flares from the sky""
		],
		""name"": ""Soleil Rouge"",
		""tooltip"": [
			""Au-delà du paradis"",
			""Fait tomber un barrage de déflagrations solaires depuis le ciel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HellsSun"",
		""type"": ""ITEM"",
		""englishName"": ""Hell's Sun"",
		""englishTooltip"": [
			""The Subterranean Sun in the palm of your hand."",
			""Shoots a gravity-defying spiky ball. Stacks up to 10."",
			""Once stationary, periodically emits small suns that explode on hit"",
			""Stealth strikes emit suns at a faster rate and last for a longer amount of time"",
			""Right click to delete all existing spiky balls""
		],
		""name"": ""Soleil de l'Enfer"",
		""tooltip"": [
			""Le soleil souterrain dans la paume de votre main."",
			""Tire une boule de piques défiant la gravité. Se cumule jusqu'à 10."",
			""Une fois stationnaire, émet périodiquement de petits soleils qui explosent quand ils touchent"",
			""Les attaques furtives émettent des soleils plus rapidement et durent plus longtemps"",
			""Clic droit pour effacer toutes les boules de piques existantes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralSolution"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Solution"",
		""englishTooltip"": [
			""Used by the Clentaminator"",
			""Spreads the Astral Infection""
		],
		""name"": ""Solution Astrale"",
		""tooltip"": [
			""Utilsée par le nettoyeur"",
			""Répand l'infection astrale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SomaPrime"",
		""type"": ""ITEM"",
		""englishName"": ""Soma Prime"",
		""englishTooltip"": [
			""This weapon can supercrit if its crit chance is over 100%"",
			""All bullets fired inflict Shred, a stacking bleed debuff"",
			""Shred deals 75 DPS per stack and scales with your ranged stats"",
			""Damage ticks of Shred can also critically strike or supercrit"",
			""Replaces standard bullets with High Velocity Bullets"",
			""80% chance to not consume ammo""
		],
		""name"": ""Soma Prime"",
		""tooltip"": [
			""Cette arme peut infliger des dégâts super critiques si vous avez plus de 100% de chances de coup critique"",
			""Toutes les balles infligent Déchirure, un saignement qui se cumule"",
			""Déchirure inflige 75 dégats par seconde et s'améliore avec vos statisques à distance"",
			""Déchirure peut également infliger des dégâts critiques ou super critiques"",
			""Convertit les balles en cartouches à haute vélocité"",
			""80% de chances de ne pas consommer de munitions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlasmaCaster"",
		""type"": ""ITEM"",
		""englishName"": ""Plasma Caster"",
		""englishTooltip"": [
			""Industrial tool used to fuse metal together with super-heated plasma"",
			""Right click for turbo mode""
		],
		""name"": ""Soudeuse à Plasma"",
		""tooltip"": [
			""Outil industriel utilisé pour souder le métal avec du plasma"",
			""Clic droit pour le mode turbo""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DragonsBreath"",
		""type"": ""ITEM"",
		""englishName"": ""Dragon's Breath"",
		""englishTooltip"": [
			""Left click fires in two-shot bursts"",
			""The first shot is a spread of 6 normal bullets"",
			""The second shot is a tight spread of 6 Dragon's Breath rounds"",
			""Right click fires full auto and mixes the bullets randomly, but does 20% less damage"",
			""This weapon has no randomness to its spread pattern"",
			""66% chance to not consume ammo""
		],
		""name"": ""Souffle de Dragon"",
		""tooltip"": [
			""Clic gauche pour tirer en rafale de 2 tirs"",
			""Le premier tir est une volée de 6 balles normales"",
			""Le deuxième tir est une volée serrée de 6 cartouches de souffle draconique"",
			""Clic droit pour tirer en rafale automatique et alterner entre les balles aléatoirement, mais inflige 20% des dégâts en moins"",
			""L'étendue des volées de cette arme n'est pas aléatoire"",
			""66% de chances de ne pas consommer de munitions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Brimblade"",
		""type"": ""ITEM"",
		""englishName"": ""Brimblade"",
		""englishTooltip"": [
			""Throws a blade that splits on enemy hits"",
			""Stealth strikes split further and cause the player to launch a barrage of brimstone darts""
		],
		""name"": ""Soufrelame"",
		""tooltip"": [
			""Jette une lame qui se divise en touchant les ennemis"",
			""Les attaques furtives se divisent davantage et provoquent un barrage de fléchettes de soufre depuis le joueur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Brimrose"",
		""type"": ""ITEM"",
		""englishName"": ""Brimrose"",
		""englishTooltip"": [
			""Summons a brimrose mount""
		],
		""name"": ""Soufrerose"",
		""tooltip"": [
			""Invoque une monture de soufrerose""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Brimlish"",
		""type"": ""ITEM"",
		""englishName"": ""Brimlish"",
		""name"": ""Soufresson"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SoulEdge"",
		""type"": ""ITEM"",
		""englishName"": ""Soul Edge"",
		""englishTooltip"": [
			""Fires the ghastly souls of long-deceased abyss dwellers""
		],
		""name"": ""Soul Edge"",
		""tooltip"": [
			""Tire les âmes fantômatiques des rôdeurs décédés des abysses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Phangasm"",
		""type"": ""ITEM"",
		""englishName"": ""Phangasm"",
		""englishTooltip"": [
			""Fires a spread of 5 arrows and emits phantom arrows on enemy hits""
		],
		""name"": ""Spectrôme"",
		""tooltip"": [
			""Tire une volée de 5 flèches et émet des flèches fantômatiques quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DefectiveSphere"",
		""type"": ""ITEM"",
		""englishName"": ""Defective Sphere"",
		""englishTooltip"": [
			""Fires a variety of deadly spheres with different effects"",
			""Stacks up to 5"",
			""Stealth strikes launch all 4 sphere types at once""
		],
		""name"": ""Sphère Défectueuse"",
		""tooltip"": [
			""Tire une variété de sphères mortelles avec des effets différents"",
			""Se cumule jusqu'a 5"",
			""Les attaques furtives lancent les 4 types de sphères simultanément""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AirSpinner"",
		""type"": ""ITEM"",
		""englishName"": ""Air Spinner"",
		""englishTooltip"": [
			""Fires feathers when enemies are near"",
			""A very agile yoyo""
		],
		""name"": ""Spinner Aérien"",
		""tooltip"": [
			""Tire des plumes à proximité des ennemis"",
			""Un yoyo très agile""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Spyker"",
		""type"": ""ITEM"",
		""englishName"": ""Spyker"",
		""englishTooltip"": [
			""Converts musket balls into spikes that stick to enemies, tiles and explode into shrapnel""
		],
		""name"": ""Spyker"",
		""tooltip"": [
			""Convertit les balles de mousquet en épines qui s'accrochent aux ennemis et au tuiles avant d'exploser en éclats""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AshenStalactite"",
		""type"": ""ITEM"",
		""englishName"": ""Ashen Stalactite"",
		""englishTooltip"": [
			""Throws a fast, small stalactite that crumbles to dust after travelling a short distance"",
			""Stealth strikes cause a larger, more damaging stalagmite to be thrown which travels slower and further before crumbling to damaging dust""
		],
		""name"": ""Stalactite Cendrée"",
		""tooltip"": [
			""Lance une petite stalactite rapide qui tombe en poussière après avoir parcouru une courte distance"",
			""Les attaques furtives créent une plus grande et puissante stalactite, qui se déplace plus lentement mais plus loin avant de de tomber en poussière qui endommage les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StarBeamRye"",
		""type"": ""ITEM"",
		""englishName"": ""Star Beam Rye"",
		""englishTooltip"": [
			""Made from some stuff I found near the Astral Meteor crash site, don't worry it's safe, trust me"",
			""Boosts max mana by 50, magic damage by 8%,"",
			""and reduces mana usage by 10%"",
			""Reduces defense by 6% and life regen by 1""
		],
		""name"": ""Star Beam Rye"",
		""tooltip"": [
			""Fait avec des trucs que j'ai trouvé près de la zone d'impact du météore astral, t'inquiètes pas ça craint rien, fais moi confiance"",
			""Augmente le mana maximum de 50, les dégâts magiques de 8%,"",
			""et réduit les coûts en mana de 10%"",
			""Réduit la défense de 6% et la régénération de vie de 1""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Starfleet"",
		""type"": ""ITEM"",
		""englishName"": ""Starfleet"",
		""englishTooltip"": [
			""Fires a spread of plasma blasts""
		],
		""name"": ""Starfleet"",
		""tooltip"": [
			""Tire une volée de décharges de plasma""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ChargingStationItem"",
		""type"": ""ITEM"",
		""englishName"": ""Charging Station"",
		""englishTooltip"": [
			""Charges Draedon's Arsenal items using Power Cells"",
			""Place both an item and Power Cells into the Charging Station to charge the item""
		],
		""name"": ""Station de Charge"",
		""tooltip"": [
			""Charge les objets de l'arsenal de Draedon en utilisant des cellules d'énergie"",
			""Placez à la fois un objet et des cellules d'énergie dans la station pour charger l'objet""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SupremeBaitTackleBoxFishingStation"",
		""type"": ""ITEM"",
		""englishName"": ""Supreme Bait Tackle Box Fishing Station"",
		""englishTooltip"": [
			""The ultimate fishing accessory"",
			""Increases fishing skill by 80"",
			""Fishing line will never break and decreases chance of bait consumption"",
			""Increases chance to catch crates"",
			""Sonar potion effect""
		],
		""name"": ""Station de Pêche Supreme"",
		""tooltip"": [
			""L'ultime accessoire de pêche"",
			""Augmente la puissance de pêche de 80"",
			""La ligne de pêche ne cassera pas et réduit les chances de consommer l'appât"",
			""Augmente les chances de pêcher des caisses"",
			""Effet de la potion de sonar""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""YharimsStimulants"",
		""type"": ""ITEM"",
		""englishName"": ""Yharim's Stimulants"",
		""englishTooltip"": [
			""Increases defense by 10, knockback by 25%, damage reduction by 4%,"",
			""mining speed by 10%, damage by 5%, critical strike chance by 2%, minion knockback by 100%,"",
			""movement and melee speed by 7.5%""
		],
		""name"": ""Stimulants de Yharim"",
		""tooltip"": [
			""Donne des améliorations décentes à TOUTES les statistiques offensives et défensives""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EtherealSubjugator"",
		""type"": ""ITEM"",
		""englishName"": ""Ethereal Subjugator"",
		""englishTooltip"": [
			""Summons a phantom to protect you"",
			""Each phantom takes only half of a minion slot""
		],
		""name"": ""Subjugateur Éthérée"",
		""tooltip"": [
			""Invoque un fantôme pour vous protéger"",
			""Chaque fantôme n'occupe que la moitié d'un emplacement de sbire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SuperDummy"",
		""type"": ""ITEM"",
		""englishName"": ""Super Dummy"",
		""englishTooltip"": [
			""Creates a super dummy"",
			""Regenerates 1 million life per second"",
			""Will not die when taking damage over time from debuffs"",
			""Right click to kill all super dummies""
		],
		""name"": ""Super Mannequin"",
		""tooltip"": [
			""Crée un super mannequin"",
			""Régénère 1 million de vie par seconde"",
			""Ne mourra pas des dégâts infligés par les altérations d'étât"",
			""Clic droit pour détruire tous les super mannequins""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SuperballBullet"",
		""type"": ""ITEM"",
		""englishName"": ""Superball Bullet"",
		""englishTooltip"": [
			""Bounces at extreme speeds""
		],
		""name"": ""Superballe"",
		""tooltip"": [
			""Rebondit à d'extrêmes vitesses""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Supernova"",
		""type"": ""ITEM"",
		""englishName"": ""Supernova"",
		""englishTooltip"": [
			""Creates a massive explosion on impact"",
			""Explodes into spikes and homing energy"",
			""Stealth strikes release energy as they fly""
		],
		""name"": ""Supernova"",
		""tooltip"": [
			""Crée une explosion massive à l'impact"",
			""Explose en piques et en énergie à tête chercheuse"",
			""Les attaques furtives relâchent de l'energie dans leur sillage""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicShiv"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmic Shiv"",
		""englishTooltip"": [
			""Definitely don't underestimate the power of shivs"",
			""Fires a cosmic beam that homes in on enemies"",
			""Upon hitting an enemy, a barrage of offscreen objects home in on the enemy as well as raining stars""
		],
		""name"": ""Surin Cosmique"",
		""tooltip"": [
			""Ne sous-estimez vraiment pas le pouvoir des surins"",
			""Tire un rayon cosmique qui pourchasse les ennemis"",
			""Quand vous touchez un ennemi, un barrage d'objets venant d'en dehors de l'écran pourchassent l'ennemi en plus de faire pleuvoir des étoiles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Svantechnical"",
		""type"": ""ITEM"",
		""englishName"": ""Svantechnical"",
		""englishTooltip"": [
			""Fires several barrages of bullets"",
			""Right click to zoom out""
		],
		""name"": ""Svantechnique"",
		""tooltip"": [
			""Tire une myriade de barrages de balles"",
			""Clic droit pour dézoomer""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FungalSymbiote"",
		""type"": ""ITEM"",
		""englishName"": ""Fungal Symbiote"",
		""englishTooltip"": [
			""Various melee weapons emit mushrooms in true melee range"",
			""True melee strikes deal 15% more damage""
		],
		""name"": ""Symbiote Fongique"",
		""tooltip"": [
			""La plupart des armes de corps à corps émettent des champignons"",
			""Les attaques de vraie mêlée font 15% de dégâts supplémentaires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateTable"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Table"",
		""name"": ""Table Pestiférée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EtherealTalisman"",
		""type"": ""ITEM"",
		""englishName"": ""Ethereal Talisman"",
		""englishTooltip"": [
			""15% increased magic damage, 5% increased magic critical strike chance and 10% decreased mana usage"",
			""+150 max mana"",
			""Increases pickup range for mana stars"",
			""You automatically use mana potions when needed if visibility is on""
		],
		""name"": ""Talisman Ethéré"",
		""tooltip"": [
			""+15% de dégâts magiques, +5% de chances de coup critiques magiques et -10% des coûts en mana"",
			""+150 de mana maximum"",
			""Augmente la portée de collecte des étoiles de mana"",
			""Vous utilisez automatiquement les potions de mana si la visibilité est activée""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VampiricTalisman"",
		""type"": ""ITEM"",
		""englishName"": ""Vampiric Talisman"",
		""englishTooltip"": [
			""Rogue projectiles give lifesteal on crits"",
			""12% increased rogue damage""
		],
		""name"": ""Talisman Vampirique"",
		""tooltip"": [
			""Les projectiles de voleur volent de la vie quand ils critiquent"",
			""+12% de dégâts de voleur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FantasyTalisman"",
		""type"": ""ITEM"",
		""englishName"": ""Fantasy Talisman"",
		""englishTooltip"": [
			""Fires high velocity talismans that ignore gravity"",
			""Talismans attach to enemies, causing them to release lost souls"",
			""Stealth strikes release more souls and leave behind souls as they travel""
		],
		""name"": ""Talisman de Fantaisie"",
		""tooltip"": [
			""Tire des talismans à haute vélocité qui ignorent la gravité"",
			""Les talismans s'attachent aux ennemis, les faisant relâcher des âmes perdues"",
			""Les attaques furtives relâchent plus d'âmes et laissent des âmes dans leur sillage""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RaidersTalisman"",
		""type"": ""ITEM"",
		""englishName"": ""Raider's Talisman"",
		""englishTooltip"": [
			""Whenever you crit an enemy with a rogue weapon your rogue damage increases"",
			""This effect can stack up to 150 times"",
			""Max rogue damage boost is 15%"",
			""This line is modified below""
		],
		""name"": ""Talisman du Pilleur"",
		""tooltip"": [
			""Quand vous infligez un coup critique avec une arme de voleur, vos dégâts de voleur augmentent"",
			""Cet effet peut se cumuler 150 fois"",
			""Les dégâts de voleur maximums accordés sont de 15%"",
			""This line is modified below""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Taser"",
		""type"": ""ITEM"",
		""englishName"": ""Taser"",
		""englishTooltip"": [
			""A slow, simple electric weapon, meant only for low ranking guards"",
			""Shoots a hook that attaches to enemies and electrocutes them before returning""
		],
		""name"": ""Taser"",
		""tooltip"": [
			""Une lente arme électrique simple, prévue pour les gardes de bas rang uniquement"",
			""Tire un crochet qui s'attache aux ennemis et les électrocutent avec de revenir""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralBlueDye"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Blue Dye"",
		""name"": ""Teinture Astrale Bleue"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralOrangeDye"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Orange Dye"",
		""name"": ""Teinture Astrale Orange"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AuricDye"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Dye"",
		""name"": ""Teinture Aurique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CalamitousDye"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitous Dye"",
		""name"": ""Teinture Calamiteuse"",
		""state"": ""Traduit""
	},
	{
		""id"": ""NightmareDye"",
		""type"": ""ITEM"",
		""englishName"": ""Nightmare Dye"",
		""name"": ""Teinture Cauchemardesque"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EndothermicDye"",
		""type"": ""ITEM"",
		""englishName"": ""Endothermic Dye"",
		""name"": ""Teinture Endothermique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CeaselessDye"",
		""type"": ""ITEM"",
		""englishName"": ""Ceaseless Dye"",
		""name"": ""Teinture Incessante"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ShadowspecDye"",
		""type"": ""ITEM"",
		""englishName"": ""Shadowspec Dye"",
		""name"": ""Teinture Ombrespec"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AerialiteDye"",
		""type"": ""ITEM"",
		""englishName"": ""Aerialite Dye"",
		""name"": ""Teinture d'Aerialite"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DragonSoulDye"",
		""type"": ""ITEM"",
		""englishName"": ""Dragon Soul Dye"",
		""name"": ""Teinture d'Âme Draconique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodflareDye"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Dye"",
		""name"": ""Teinture de Brûlesang"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralDye"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Flesh Dye"",
		""name"": ""Teinture de Chair Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BlueCosmicFlameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Blue Cosmic Flame Dye"",
		""name"": ""Teinture de Feu Cosmique Bleu"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DefiledFlameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Defiled Flame Dye"",
		""name"": ""Teinture de Flamme Corrompue"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimflameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Brimflame Dye"",
		""name"": ""Teinture de Flammesoufre"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BlueStatigelDye"",
		""type"": ""ITEM"",
		""englishName"": ""Blue Statigel Dye"",
		""name"": ""Teinture de Gel Statique Bleue"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedMoonlightDye"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Moonlight Dye"",
		""name"": ""Teinture de Lueur Sélène Profanée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""StratusDye"",
		""type"": ""ITEM"",
		""englishName"": ""Stratus Dye"",
		""name"": ""Teinture de Strate"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralSwirlDye"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Swirl Dye"",
		""name"": ""Teinture de Tourbillon Astral"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedFlameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Flame Dye"",
		""name"": ""Teinture de flamme profanée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ElementalDye"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Dye"",
		""name"": ""Teinture des Éléments"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ReaverDye"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Dye"",
		""name"": ""Teinture du Saccageur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Mistlestorm"",
		""type"": ""ITEM"",
		""englishName"": ""Mistlestorm"",
		""englishTooltip"": [
			""Casts a storm of pine needles and leaves""
		],
		""name"": ""Tempête de Gui"",
		""tooltip"": [
			""Envoie une tornade d'épines de pin et de feuilles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DuststormInABottle"",
		""type"": ""ITEM"",
		""englishName"": ""Duststorm in a Bottle"",
		""englishTooltip"": [
			""Explodes into a dust cloud"",
			""Stealth strikes form a more intense and longer lasting dust cloud""
		],
		""name"": ""Tempête de Poussière en Bouteille"",
		""tooltip"": [
			""Explose en un nuage de poussière"",
			""Les attaques furtives forment un nuage plus intense et plus persistant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SandstormGun"",
		""type"": ""ITEM"",
		""englishName"": ""Sandstorm"",
		""englishTooltip"": [
			""Fires sand bullets that explode and slow enemies on hit"",
			""50% chance to not consume sand""
		],
		""name"": ""Tempête de Sable"",
		""tooltip"": [
			""Tire des balles de sable qui explosent et ralentissent les ennemis"",
			""50% de chances de ne pas consommer de sable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DesertProwlerShirt"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Prowler Shirt"",
		""englishTooltip"": [
			""5% increased ranged critical strike chance""
		],
		""name"": ""Tenue du Rôdeur des Sables"",
		""tooltip"": [
			""+5% de chances de coup critique à distance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Tequila"",
		""type"": ""ITEM"",
		""englishName"": ""Tequila"",
		""englishTooltip"": [
			""Great for mixing up daytime drinks"",
			""Boosts damage and damage reduction by 3%, knockback by 10%, crit chance by 2% and defense by 5 during daytime"",
			""Reduces life regen by 1""
		],
		""name"": ""Tequila"",
		""tooltip"": [
			""Parfait pour les cocktails en journée"",
			""Augmente les dégâts, le recul et la réduction des dégâts de 3%, les chances de coup critiques de 2%, et la défense de 5 la journée"",
			""Réduit la régénération de la vie de 1""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TequilaSunrise"",
		""type"": ""ITEM"",
		""englishName"": ""Tequila Sunrise"",
		""englishTooltip"": [
			""The greatest daytime drink I've ever had"",
			""Boosts damage by 7%, knockback by 20%, crit chance and damage reduction by 3% and defense by 10 during daytime"",
			""Reduces life regen by 1""
		],
		""name"": ""Tequila Sunrise"",
		""tooltip"": [
			""Le meilleur alcool de jour que j'ai jamais bu"",
			""Augmente les dégâts, la réduction des dégâts et le recul de 7%, les chances de coup critique de 3% et la défense de 10 durant la journée"",
			""Réduit la régénération de vie de 1""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LaboratoryTerminalItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Terminal"",
		""name"": ""Terminal de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""TerraFlameburster"",
		""type"": ""ITEM"",
		""englishName"": ""Terra Flameburster"",
		""englishTooltip"": [
			""80% chance to not consume gel""
		],
		""name"": ""Terra Cracheflamme"",
		""tooltip"": [
			""80% de chances de ne pas consommer de gel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TerraLance"",
		""type"": ""ITEM"",
		""englishName"": ""Terra Lance"",
		""englishTooltip"": [
			""Fires a lance beam""
		],
		""name"": ""Terra Lance"",
		""tooltip"": [
			""Tire un rayon de lance""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TerraEdge"",
		""type"": ""ITEM"",
		""englishName"": ""Terra Edge"",
		""englishTooltip"": [
			""Heals the player on enemy hits"",
			""Fires a beam that inflicts ichor for a short time""
		],
		""name"": ""Terra Tranchant"",
		""tooltip"": [
			""Soigne le joueur sur les coups ennemis"",
			""Tire un laser qui inflige l'ichor pendant un court temps""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Terratomere"",
		""type"": ""ITEM"",
		""englishName"": ""Terratomere"",
		""englishTooltip"": [
			""Linked to the essence of Terraria"",
			""Heals the player on true melee hits"",
			""Fires a barrage of 4 homing beams that freeze enemies""
		],
		""name"": ""Terratomère"",
		""tooltip"": [
			""Lié à l'essence de Terraria"",
			""Soigne le joueur sur les attaques de vraie mêlée"",
			""Tire un barrage de 4 rayons à têtes chercheuses qui gèlent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Earth"",
		""type"": ""ITEM"",
		""englishName"": ""Earth"",
		""englishTooltip"": [
			""Lowers enemy defense by 1 with every strike"",
			""Your attacks will heal you a lot"",
			""Rains RGB meteors that explode into more meteors after a short time on enemy hits"",
			""Ice meteors freeze enemies"",
			""Flame meteors explode"",
			""Green meteors spawn healing orbs""
		],
		""name"": ""Terre"",
		""tooltip"": [
			""Réduit la défense des ennemis de 1 quand vous les frappez"",
			""Vos attaques vous soigneront énormément"",
			""Fait pleuvoir des météores RVB qui explosent en plus de météores après un court moment quand elles touchent les ennemis"",
			""Les météores de glace gèlent les ennemis"",
			""Les météores de feu explosent"",
			""Les météores verts créent des orbes de soin""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PrimordialEarth"",
		""type"": ""ITEM"",
		""englishName"": ""Primordial Earth"",
		""englishTooltip"": [
			""Casts a large blast of dust""
		],
		""name"": ""Terre Primordiale"",
		""tooltip"": [
			""Convoque une large déflagration de poussière""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GunkShot"",
		""type"": ""ITEM"",
		""englishName"": ""Gunk Shot"",
		""englishTooltip"": [
			""Shoots a spread of bullets""
		],
		""name"": ""Tire Crasse"",
		""tooltip"": [
			""Tire une volée de balles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Shellshooter"",
		""type"": ""ITEM"",
		""englishName"": ""Shellshooter"",
		""englishTooltip"": [
			""Converts wooden arrows into slow, powerful shells""
		],
		""name"": ""Tire-Coquille"",
		""tooltip"": [
			""Convertit les flèches de bois en lents et puissants coquillages""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AuricToilet"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Toilet"",
		""englishTooltip"": [
			""This was used by the gods "",
			""Sitting on such a throne would be a disgrace to all""
		],
		""name"": ""Toilette Aurique"",
		""tooltip"": [
			""A été utilisé par les dieux""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LeadTomahawk"",
		""type"": ""ITEM"",
		""englishName"": ""Lead Tomahawk"",
		""englishTooltip"": [
			""The tomahawks have more damage for a short time when initially thrown"",
			""Stealth strikes pierce infinitely""
		],
		""name"": ""Tomahawk de Plomb"",
		""tooltip"": [
			""Les Tomahawks font plus de dégâts quand ils sont lancés proches de l'ennemi"",
			""Les attaques furtives percent indéfiniment""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FellerofEvergreens"",
		""type"": ""ITEM"",
		""englishName"": ""Feller of Evergreens"",
		""name"": ""Tombeur des Verdures"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssalTome"",
		""type"": ""ITEM"",
		""englishName"": ""Abyssal Tome"",
		""englishTooltip"": [
			""Casts a slow-moving ball of dark energy""
		],
		""name"": ""Tome Abyssal"",
		""tooltip"": [
			""Convoque une lente boule d'énergie noire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EldritchTome"",
		""type"": ""ITEM"",
		""englishName"": ""Eldritch Tome"",
		""englishTooltip"": [
			""Casts eldritch tentacles to spear your enemies""
		],
		""name"": ""Tome d'Eldritch"",
		""tooltip"": [
			""Convoque des tentacules d'Eldritch pour empaler vos ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TomeofFates"",
		""type"": ""ITEM"",
		""englishName"": ""Tome of Fates"",
		""englishTooltip"": [
			""Casts cosmic tentacles to spear your enemies"",
			""Can randomly fire a brimstone tentacle for immense damage""
		],
		""name"": ""Tome des Destinées"",
		""tooltip"": [
			""Convoque des tentacules cosmiques pour empaler vos ennemis"",
			""Peut aléatoirement convoquer une tantacule de soufre qui inflige d'immenses dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BlastBarrel"",
		""type"": ""ITEM"",
		""englishName"": ""Blast Barrel"",
		""englishTooltip"": [
			""Throws a rolling barrel that explodes on wall collision"",
			""Stealth strikes makes the barrel bounce twice before disappearing with varied effects after each bounce"",
			""'Some people used to jump over these'""
		],
		""name"": ""Tonneau Explosif"",
		""tooltip"": [
			""Lance un tonneau roulant qui explose en heurtant un mur"",
			""Les attaque furtives font rebondir le baril deux fois avec qu'il explose, avec des effets variés à chaque rebond"",
			""'Y a des gens qui sautaient au-dessus, avant'""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Thunderstorm"",
		""type"": ""ITEM"",
		""englishName"": ""Thunderstorm"",
		""englishTooltip"": [
			""Make it rain""
		],
		""name"": ""Tonnerre"",
		""tooltip"": [
			""Qu'il pleuve""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DeificThunderbolt"",
		""type"": ""ITEM"",
		""englishName"": ""Deific Thunderbolt"",
		""englishTooltip"": [
			""Fires a lightning bolt to electrocute enemies"",
			""The lightning bolt travels faster while it is raining"",
			""Summons lightning from the sky on impact"",
			""Stealth strikes summon more lightning and travel faster""
		],
		""name"": ""Tonnerre Déifique"",
		""tooltip"": [
			""Tire un carreau électrique pour électrocuter les ennemis"",
			""Le carreau est plus rapide quand il pleut"",
			""Invoque des éclairs depuis le ciel à l'impact"",
			""Les attaques furtives invoquent plus d'éclairs et sont plus rapides""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssTorch"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Can be placed in water""
		],
		""name"": ""Torche Abyssale"",
		""tooltip"": [
			""Peut être placée sous l'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FleshTotem"",
		""type"": ""ITEM"",
		""englishName"": ""Flesh Totem"",
		""englishTooltip"": [
			""Halves enemy contact damage"",
			""When you take contact damage this effect has a 20 second cooldown""
		],
		""name"": ""Totem de Chair"",
		""tooltip"": [
			""Diminue de moitié les dégâts de contact"",
			""Cet effet à un temps de recharge de 20s""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ToxicantTwister"",
		""type"": ""ITEM"",
		""englishName"": ""Toxicant Twister"",
		""englishTooltip"": [
			""Throws a slow moving boomerang"",
			""After a few moments, the boomerang chooses a target and rapidly homes in"",
			""Stealth strikes home in faster and rapidly release sand""
		],
		""name"": ""Tourbillon Intoxicant"",
		""tooltip"": [
			""Lance un boomerang bougeant lentement"",
			""Après quelques instants, Le boomerang choisit une cible et la pourchasse rapidement"",
			""Les attaques furtives commencent à pourchasser plus rapidement et relâchent rapidement du sable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Toxibow"",
		""type"": ""ITEM"",
		""englishName"": ""Toxibow"",
		""englishTooltip"": [
			""Converts wooden arrows into slow arrows that inflict irradiated""
		],
		""name"": ""Toxiarc"",
		""tooltip"": [
			""Convertit les flèches en bois en flèches lentes qui infligent parfois l'empoisonnement sulfurique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FlakToxicannon"",
		""type"": ""ITEM"",
		""englishName"": ""Flak Toxicannon"",
		""englishTooltip"": [
			""Fires angled shots in the direction of the cursor"",
			""Can only be shot in a cone direction above the player"",
			""High IQ required""
		],
		""name"": ""Toxicannon Flak"",
		""tooltip"": [
			""Tire en angle dans la direction du curseur"",
			""Peut uniquement faire feu dans un cône au-dessus du joueur"",
			""QI élevé demandé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CelestialTracers"",
		""type"": ""ITEM"",
		""englishName"": ""Celestial Tracers"",
		""englishTooltip"": [
			""Taking speed EVEN FURTHER BEYOND!"",
			""Counts as wings"",
			""Horizontal speed: 12.00"",
			""Acceleration multiplier: 3.0"",
			""Excellent vertical speed"",
			""Flight time: 250"",
			""50% increased running acceleration"",
			""Greater mobility on ice"",
			""Water and lava walking"",
			""Immunity to the On Fire! debuff"",
			""Temporary immunity to lava"",
			""Being hit for over 200 damage will make you immune for an extended period of time""
		],
		""name"": ""Traceurs Célestes"",
		""tooltip"": [
			""Il faut aller TOUJOURS PLUS VITE!"",
			""Compte comme des ailes"",
			""Vitesse Horizontale: 12"",
			""Multiplicateur d'accélération: 3"",
			""Excellente vitesse verticale"",
			""Temps de vol: 250"",
			""+50% d'accélération en course"",
			""Meilleure mobilité sur la glace"",
			""Vous pouvez marcher sur les liquides"",
			""Immunité temporaire à la lave et a la brûlure"",
			""Subir plus de 200 dégâts prolongera grandement votre période d'invincibilité""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElysianTracers"",
		""type"": ""ITEM"",
		""englishName"": ""Elysian Tracers"",
		""englishTooltip"": [
			""Ludicrous speed!"",
			""Counts as wings"",
			""Horizontal speed: 10.50"",
			""Acceleration multiplier: 2.75"",
			""Great vertical speed"",
			""Flight time: 180"",
			""36% increased running acceleration"",
			""Greater mobility on ice"",
			""Water and lava walking"",
			""Immunity to the On Fire! debuff"",
			""Temporary immunity to lava""
		],
		""name"": ""Traceurs Elysiens"",
		""tooltip"": [
			""Vitesse absurde!"",
			""Compte comme des ailes"",
			""Vitesse Horizontale: 10.5"",
			""Multiplicateur d'accélération: 2.75"",
			""Très bonne vitesse verticale"",
			""Temps de vol: 180"",
			""+36% d'accélération en course"",
			""Meilleure mobilité sur la glace"",
			""Vous pouvez marcher sur les liquides"",
			""Immunité temporaire à la lave et à la brûlure""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FrostBolt"",
		""type"": ""ITEM"",
		""englishName"": ""Frost Bolt"",
		""englishTooltip"": [
			""Casts a slow-moving ball of frost""
		],
		""name"": ""Trait de Givre"",
		""tooltip"": [
			""Convoque une lente boule de givre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CausticEdge"",
		""type"": ""ITEM"",
		""englishName"": ""Caustic Edge"",
		""englishTooltip"": [
			""Inflicts poison and venom on enemy hits""
		],
		""name"": ""Tranchant Caustique"",
		""tooltip"": [
			""Inflige Poison et Venin quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RougeSlash"",
		""type"": ""ITEM"",
		""englishName"": ""Rouge Slash"",
		""englishTooltip"": [
			""Fires a wave of 3 rouge air slashes""
		],
		""name"": ""Tranchant Rouge"",
		""tooltip"": [
			""Tire une vague de trois tranchants d'air rouges""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Sandslasher"",
		""type"": ""ITEM"",
		""englishName"": ""Sandslasher"",
		""englishTooltip"": [
			""Throws a huge shuriken made out of fused sand unaffected by gravity which slowly accelerates horizontally"",
			""It does more damage depending on how fast it goes horizontally and how long it has been flying for"",
			""Stealth strikes periodically release sand clouds""
		],
		""name"": ""Tranche-Sable"",
		""tooltip"": [
			""Lance un énorme shuriken qui ignore la gravité fait de sable fusionné qui accélère lentement et horizontalement"",
			""Les dégâts augmentent en fonction de sa vitesse et du temps de présence"",
			""Les attaques furtives relâchent périodiquement des nuages""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Phaseslayer"",
		""type"": ""ITEM"",
		""englishName"": ""Phaseslayer"",
		""englishTooltip"": [
			""A rough prototype of the Murasama blade, it is formed entirely from laser energy"",
			""Wield a colossal laser blade which is controlled by the cursor"",
			""Faster swings deal more damage and release sword beams"",
			""When at low charge, the blade is smaller and weaker""
		],
		""name"": ""Tranchephase"",
		""tooltip"": [
			""Un prototype grossier de l'épée murasama, elle est entièrement constituée d'énergie laser."",
			""Maniez une épée laser colossale controlée avec votre curseur"",
			""Les frappes rapides infligent plus de dégats et génèrent des rayons d'épées"",
			""Quand la batterie est faible, l'épée est plus petite et plus faible""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DynamoStemCells"",
		""type"": ""ITEM"",
		""englishName"": ""Dynamo Stem Cells"",
		""englishTooltip"": [
			""10% increased movement speed"",
			""Ranged weapons have a chance to fire mini swarmers"",
			""Grants immunity to Dragon Fire and Electrified""
		],
		""name"": ""Transformateur de Cellules Souches"",
		""tooltip"": [
			""+10% de vitesse de mouvement"",
			""Les armes à distance ont une chance de tirer des petits essaimeurs""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SoulPiercer"",
		""type"": ""ITEM"",
		""englishName"": ""Soul Piercer"",
		""englishTooltip"": [
			""Casts a powerful ray that summons extra rays on enemy hits""
		],
		""name"": ""Transperce-Âme"",
		""tooltip"": [
			""Convoque un puissant rayon qui invoque d'autres rayons quand il touche""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CrystalPiercer"",
		""type"": ""ITEM"",
		""englishName"": ""Crystal Piercer"",
		""englishTooltip"": [
			""Throws a crystal javelin that pierces infinitely"",
			""Stealth strikes travel through blocks, ignore gravity, and summon crystal shards as they fly""
		],
		""name"": ""Transperceur de Cristal"",
		""tooltip"": [
			""Jette un javelot de cristal qui transperce indéfiniment"",
			""Les attaques furtives traversent les blocs, ignorent la gravité et invoquent des éclats de cristal sur leur trajectoire""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TriactisTruePaladinianMageHammerofMightMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Triactis' True Paladinian Mage-Hammer of Might"",
		""englishTooltip"": [
			""Explodes on enemy hits""
		],
		""name"": ""Triactis, le Marteau-Mage de Puissance du Vrai Paladinien"",
		""tooltip"": [
			""Explose en touchant les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VenusianTrident"",
		""type"": ""ITEM"",
		""englishName"": ""Venusian Trident"",
		""englishTooltip"": [
			""Casts an infernal trident that erupts into a gigantic explosion of fire and magma shards""
		],
		""name"": ""Trident Vénusien"",
		""tooltip"": [
			""Convoque un trident infernal qui explose en une gigantesque éruption de flammes et de magma""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AmidiasTrident"",
		""type"": ""ITEM"",
		""englishName"": ""Amidias' Trident"",
		""englishTooltip"": [
			""Shoots homing whirlpools""
		],
		""name"": ""Trident d'Amidias"",
		""tooltip"": [
			""Tire des tourbillons à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""IcicleTrident"",
		""type"": ""ITEM"",
		""englishName"": ""Icicle Trident"",
		""englishTooltip"": [
			""Shoots piercing icicles""
		],
		""name"": ""Trident de Stalagtite"",
		""tooltip"": [
			""Tire des stalagtites percantes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AnahitaTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Anahita Trophy"",
		""name"": ""Trophée d'Anahita"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ApolloTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Apollo Trophy"",
		""name"": ""Trophée d'Apollo"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ArtemisTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Artemis Trophy"",
		""name"": ""Trophée d'Artemis"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AresTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Ares Trophy"",
		""name"": ""Trophée d'Arès"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstrumDeusTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Deus Trophy"",
		""name"": ""Trophée d'Astrum Deus"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimstoneElementalTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Elemental Trophy"",
		""name"": ""Trophée d'Élémentaire de Soufre"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CalamitasTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitas Trophy"",
		""name"": ""Trophée de Calamitas"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SupremeCalamitasTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Supreme Calamitas Trophy"",
		""name"": ""Trophée de Calamitas Suprême"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CataclysmTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Cataclysm Trophy"",
		""name"": ""Trophée de Cataclysme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CatastropheTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Catastrophe Trophy"",
		""name"": ""Trophée de Catastrophe"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrabulonTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Crabulon Trophy"",
		""name"": ""Trophée de Crabulon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CryogenTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Cryogen Trophy"",
		""name"": ""Trophée de Cryogène"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProvidenceTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Providence Trophy"",
		""name"": ""Trophée de Providence"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RavagerTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Ravager Trophy"",
		""name"": ""Trophée de Ravageur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SignusTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Signus Trophy"",
		""name"": ""Trophée de Signus"",
		""state"": ""Traduit""
	},
	{
		""id"": ""YharonTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Yharon Trophy"",
		""name"": ""Trophée de Yharon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HiveMindTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Hive Mind Trophy"",
		""name"": ""Trophée de l'Esprit de Ruche"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PolterghastTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Polterghast Trophy"",
		""name"": ""Trophée de l'Épouvantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SlimeGodTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Slime God Trophy"",
		""name"": ""Trophée du Dieu des Gelées"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DevourerofGodsTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Devourer of Gods Trophy"",
		""name"": ""Trophée du Dévoreur de Dieux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AquaticScourgeTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Aquatic Scourge Trophy"",
		""name"": ""Trophée du Fléau Aquatique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DesertScourgeTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Scourge Trophy"",
		""name"": ""Trophée du Fléau du Désert"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedGuardianTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Guardian Trophy"",
		""name"": ""Trophée du Gardien Profané"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguebringerGoliathTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Plaguebringer Goliath Trophy"",
		""name"": ""Trophée du Goliath Colporte-Peste"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LeviathanTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Leviathan Trophy"",
		""name"": ""Trophée du Leviathan"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CeaselessVoidTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Ceaseless Void Trophy"",
		""name"": ""Trophée du Néant Incessant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Perforator Trophy"",
		""name"": ""Trophée du Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WeaverTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Storm Weaver Trophy"",
		""name"": ""Trophée du Tisse-Tempête"",
		""state"": ""Traduit""
	},
	{
		""id"": ""OldDukeTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Old Duke Trophy"",
		""name"": ""Trophée du Vieux Duc"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MutatedTruffle"",
		""type"": ""ITEM"",
		""englishName"": ""Mutated Truffle"",
		""englishTooltip"": [
			""Summons a small Old Duke to fight for you"",
			""When below 50% life, it moves much faster""
		],
		""name"": ""Truffe Mutée"",
		""tooltip"": [
			""Invoque un Vieux Duc miniature pour combattre à vos côtés"",
			""Quand vous avez moins de la moitié de votre vie, il devient bien plus rapide""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElephantKiller"",
		""type"": ""ITEM"",
		""englishName"": ""Elephant Killer"",
		""englishTooltip"": [
			""Uses Magnum Rounds"",
			""Can be used thrice per boss battle""
		],
		""name"": ""Tueur d'Éléphant"",
		""tooltip"": [
			""Utilise des balles de magnum"",
			""Peut être utilisé trois fois par combat de boss""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Turbulance"",
		""type"": ""ITEM"",
		""englishName"": ""Turbulance"",
		""englishTooltip"": [
			""Fires a cloudy javelin that bursts into wind slashes on hit"",
			""Wind slashes home if the javelin crits"",
			""Stealth strikes are trailed by homing wind slashes""
		],
		""name"": ""Turbulance"",
		""tooltip"": [
			""Tire des javelots nuageux qui explosent en rafales de vent quand ils touchent"",
			""Les rafales de vent pourchassent les ennemis en cas de coup critique"",
			""Les attaques furtives sont suivies de rafales de vent qui pourchassent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""InfectedRemote"",
		""type"": ""ITEM"",
		""englishName"": ""Infected Remote"",
		""englishTooltip"": [
			""There’s a faded note written on it in green"",
			""Only the first line is readable: 'She won’t afflict you, I promise!'"",
			""Summons the harbinger of the plague...?"",
			""Consumes all of the remaining minion slots on use"",
			""Must be used from the hotbar"",
			""Increased power based on the number of minion slots used""
		],
		""name"": ""Télécommande Infectée"",
		""tooltip"": [
			""Il y a une note presque estompée qui est marquée dessus en vert"",
			""Seul la première ligne est encore lisible: 'Elle ne te contaminera pas, je le promets!'"",
			""Invoque le précurseur de la peste...?"",
			""Consomme tous les emplacements de sbires restants à l'utilisation"",
			""Doit-être utilisé depuis la barre des raccourcis"",
			""La puissance augmente en fonction du nombre d'emplacements de sbires occupés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PulseTurretRemote"",
		""type"": ""ITEM"",
		""englishName"": ""Pulse Turret Remote"",
		""englishTooltip"": [
			""A device used to defend against the weaker, less cognizant rogue creations of Draedon"",
			""Summons a pulse turret which eradicates nearby foes with focused energy blasts"",
			""Only one pulse turret may exist at a time""
		],
		""name"": ""Télécommande de Tourelle à Impulsion"",
		""tooltip"": [
			""Un appareil utilisé se défendre des plus faibles, et moins conscientes créations rebelles de Draedon."",
			""Invoque une tourelle à impulsion qui éradique les ennemis proches avec des décharges d'énergie concentrée"",
			""Une seule tourelle à impulsion peut exister à la fois""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BlackHawkRemote"",
		""type"": ""ITEM"",
		""englishName"": ""Black Hawk Remote"",
		""englishTooltip"": [
			""Summons a Black Hawk jet to fight for you""
		],
		""name"": ""Télécommande du Faucon Noir"",
		""tooltip"": [
			""Invoque un jet du faucon noir pour combattre à vos côtés""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Tenebris"",
		""type"": ""ITEM"",
		""englishName"": ""Tenebris"",
		""name"": ""Ténebris"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerfectDark"",
		""type"": ""ITEM"",
		""englishName"": ""Perfect Dark"",
		""englishTooltip"": [
			""Fires a vile ball that sticks to tiles and explodes""
		],
		""name"": ""Ténèbres Parfaites"",
		""tooltip"": [
			""Tire une vile boule qui se colle aux tuiles et explose""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Teratoma"",
		""type"": ""ITEM"",
		""englishName"": ""Teratoma"",
		""englishTooltip"": [
			""Summons the Hive Mind when used in the corruption"",
			""Not consumable""
		],
		""name"": ""Tératome"",
		""tooltip"": [
			""Invoque l'Esprit de Ruche quand utilisé dans la corruption"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Ultima"",
		""type"": ""ITEM"",
		""englishName"": ""Ultima"",
		""englishTooltip"": [
			""Casts a continuous stream of plasma bolts"",
			""Over time the bolts are replaced with powerful lasers"",
			""Bolts power up into solid beams as you continue shooting"",
			""90% chance to not consume ammo""
		],
		""name"": ""Ultima"",
		""tooltip"": [
			""Tire une flot continu de décharges de plasma"",
			""Les décharges sont remplacées au fur et à mesure par de puissants lasers"",
			""Les décharges se renforcent en rayons solides quand vous tirez en continu"",
			""90% de chances de ne pas consommer de munitions""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TyrantYharimsUltisword"",
		""type"": ""ITEM"",
		""englishName"": ""Tyrant Yharim's Ultisword"",
		""englishTooltip"": [
			""Fires homing blazing blades"",
			""Gives the player the tyrant's fury buff on enemy hits"",
			""This buff increases melee damage by 30% and melee crit chance by 10%""
		],
		""name"": ""Ultimépée du Tyrant Yharim"",
		""tooltip"": [
			""Tire des lames embrasées à tête chercheuse"",
			""Accorde la fureur du tyrant quand vous touchez les ennemis"",
			""La fureur augmente les dégâts de mêlée de 30% et les chances de coup critique de mêlée de 10%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""UltraLiquidator"",
		""type"": ""ITEM"",
		""englishName"": ""Ultra Liquidator"",
		""englishTooltip"": [
			""Summons liquidation blades that summon more blades on enemy hits"",
			""The blades inflict ichor, cursed inferno and brimstone flames""
		],
		""name"": ""Ultra Liquidateur"",
		""tooltip"": [
			""Invoque des lames de liquidation qui invoquent plus de lames quand elles touchent"",
			""Les lames infligent l'ichor, les flammes maudites et les flammes de soufre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StarSwallowerContainmentUnit"",
		""type"": ""ITEM"",
		""englishName"": ""Star Swallower Containment Unit"",
		""englishTooltip"": [
			""Small novelties created to easily transport and fire plasma, strangely popular with humans"",
			""Summons a biomechanical frog that vomits plasma onto enemies""
		],
		""name"": ""Unité de Confinement d'Avaleur d'Étoile"",
		""tooltip"": [
			""Petite curiosité créée pour transporter et tirer facilement du plasma, étrangement populaire auprès des humains."",
			""Invoque une grenouille biomécanique qui vomit du plasma sur les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PowerCellFactoryItem"",
		""type"": ""ITEM"",
		""englishName"": ""Power Cell Factory"",
		""englishTooltip"": [
			""Produces Draedon Power Cells over time"",
			""One cell is produced every 15 seconds""
		],
		""name"": ""Usine de Cellule d'Énergie"",
		""tooltip"": [
			""Produit des cellules d'énergie de Draedon"",
			""Une cellule est produite toutes les 15 secondes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""UtensilPoker"",
		""type"": ""ITEM"",
		""englishName"": ""Utensil Poker"",
		""englishTooltip"": [
			""Space chickens, that is all."",
			""Fires random utensils in bursts of three"",
			""Grants Well Fed on enemy hits"",
			""Stealth strikes replace any utensil with a powerful butcher knife""
		],
		""name"": ""Ustensiles Troueurs"",
		""tooltip"": [
			""Des poulets de l'espace, je m'arrête la."",
			""Tire des ustensiles aléatoires par vague de 3"",
			""Accorde Bien Nourri quand vous touchez"",
			""Les attaques furtives remplacent les ustensiles par un puissant couteau de boucher""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Floodtide"",
		""type"": ""ITEM"",
		""englishName"": ""Floodtide"",
		""englishTooltip"": [
			""Launches sharks, because sharks are awesome!""
		],
		""name"": ""Vaguinondation"",
		""tooltip"": [
			""Lance des requins, parce que les requins c'est génial!""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SeaMinnowItem"",
		""type"": ""ITEM"",
		""englishName"": ""Sea Minnow"",
		""name"": ""Vairon de Mer"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FrostcrushValari"",
		""type"": ""ITEM"",
		""englishName"": ""Frostcrush Valari"",
		""englishTooltip"": [
			""Fires a long ranged boomerang that explodes into icicles on hit"",
			""Stealth strikes throw three short ranged boomerangs along with a spread of icicles""
		],
		""name"": ""Valari Écrase-Givre"",
		""tooltip"": [
			""Tire un boomerang à longue portée qui explose en stalactites quand il touche"",
			""Les attaques furtives lancent trois boomerangs à courte portée avec une volée de stalactites""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AsgardsValor"",
		""type"": ""ITEM"",
		""englishName"": ""Asgard's Valor"",
		""englishTooltip"": [
			""Grants immunity to knockback"",
			""Immune to most debuffs"",
			""+16 defense while submerged in liquid"",
			""+20 max life"",
			""Grants a holy dash which can be used to ram enemies""
		],
		""name"": ""Valeur d'Asgard"",
		""tooltip"": [
			""Immunisé contre le recul"",
			""Immunisé à la plupart des altérations et réduit les dégâts des brûlures de soufre"",
			""+16 défense quand vous êtes immergé"",
			""+20 vie maximum"",
			""Accorde une ruée sacrée qui permet de foncer sur les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodyVein"",
		""type"": ""ITEM"",
		""englishName"": ""Bloody Vein"",
		""englishTooltip"": [
			""Summons an amalgamated pile of flesh""
		],
		""name"": ""Veine Sanglante"",
		""tooltip"": [
			""Invoque un tas de chair amalgamé""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Deathwind"",
		""type"": ""ITEM"",
		""englishName"": ""Deathwind"",
		""englishTooltip"": [
			""Fires a spread of 4 arrows"",
			""Wooden arrows are converted into nebula arrows""
		],
		""name"": ""Vent de Mort"",
		""tooltip"": [
			""Tire une volée de 4 flèches"",
			""Les flèches de bois sont converties en flèches nébulaires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicWorm"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmic Worm"",
		""englishTooltip"": [
			""Summons the Devourer of Gods"",
			""Not consumable""
		],
		""name"": ""Ver Cosmique"",
		""tooltip"": [
			""Invoque le dévoreur de dieux"",
			""SENTINEL WARNING TOOLTIP LINE HERE"",
			""Ne se consomme pas""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Verdant"",
		""type"": ""ITEM"",
		""englishName"": ""Verdant"",
		""englishTooltip"": [
			""Fires crystal leaves when enemies are near"",
			""A very agile yoyo""
		],
		""name"": ""Verdant"",
		""tooltip"": [
			""Tire des feuilles en cristal quand les ennemis sont proches"",
			""Un yoyo très agile""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SkyGlaze"",
		""type"": ""ITEM"",
		""englishName"": ""Sky Glaze"",
		""englishTooltip"": [
			""Fires feathers from the sky that stick to enemies and tiles and explode""
		],
		""name"": ""Vernis Céleste"",
		""tooltip"": [
			""Tire des plumes depuis le ciel qui se collent aux ennemis et aux tuiles avant d'exploser""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Greentide"",
		""type"": ""ITEM"",
		""englishName"": ""Greentide"",
		""englishTooltip"": [
			""Summons teeth from the sky on hit""
		],
		""name"": ""Vertevague"",
		""tooltip"": [
			""Invoque des crocs depuis les cieux quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueReaperVest"",
		""type"": ""ITEM"",
		""englishName"": ""Plague Reaper Vest"",
		""englishTooltip"": [
			""Grants immunity to the Plague"",
			""15% increased ranged damage and 5% increased ranged critical strike chance""
		],
		""name"": ""Veste du Faucheur de Peste"",
		""tooltip"": [
			""Réduit les dégâts que vous inflige la peste"",
			""+15% de dégâts à distance et +5% de chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeBrimstoneCrag"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Crag"",
		""englishTooltip"": [
			""Ah... this place."",
			""The scent of broken promises, pain, and eventual death is heavy in the air...""
		],
		""name"": ""Vestiges de soufre"",
		""tooltip"": [
			""Ah...cet endroit."",
			""Son atmosphère est alourdie par l'odeur des promesses brisés, de la douleur et de l'inéluctable mort...""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Vesuvius"",
		""type"": ""ITEM"",
		""englishName"": ""Vesuvius"",
		""englishTooltip"": [
			""Asteroids give the Molten buff on enemy hits"",
			""Calls down a swarm of molten asteroids"",
			""Right click to fire a spread of molten asteroids from the staff""
		],
		""name"": ""Vesuvius"",
		""tooltip"": [
			""Les astéroides vous donne l'amélioration Fusion quand vous touchez"",
			""Fait pleuvoir une nuée d'astéroïdes en fusion"",
			""Clic droit pour tirer une étendue d'astéroïdes depuis le Bâton""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DeliciousMeat"",
		""type"": ""ITEM"",
		""englishName"": ""Delicious Meat"",
		""englishTooltip"": [
			""{$CommonItemTooltip.MediumStats}"",
			""'So very delicious'""
		],
		""name"": ""Viande Délicieuse"",
		""tooltip"": [
			""Petite amélioration à toutes les statistiques"",
			""'Tellement bon'""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AgedLaboratoryDisplayItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Display"",
		""name"": ""Vieil Affichage de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AgedLaboratoryScreenItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Screen"",
		""name"": ""Vieil Écran de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AgedLaboratoryContainmentBoxItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Containment Box"",
		""name"": ""Vieille Boîte de Confinement de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AgedReinforcedCrateItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Reinforced Crate"",
		""name"": ""Vieille Caisse Renforcée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AgedLaboratoryConsoleItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Console"",
		""name"": ""Vieille Console de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AgedLaboratoryDoorItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Door"",
		""name"": ""Vieille Porte de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AgedSecurityChest"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Security Chest"",
		""name"": ""Vieux Coffre Sécurisé"",
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeOldDuke"",
		""type"": ""ITEM"",
		""englishName"": ""Old Duke"",
		""englishTooltip"": [
			""Strange, to find out that the mutant terror of the seas was not alone in its unique biology."",
			""Perhaps I was mistaken to classify the creature from its relation to pigrons alone.""
		],
		""name"": ""Vieux Duc"",
		""tooltip"": [
			""C'est étrange, je ne pensais pas que la terreur mutante des mers n'était pas la seule représentante de son espèce."",
			""Peut-être m'étais-je trompé en ayant classé cette créature dans l'ordre des drachons.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OldDie"",
		""type"": ""ITEM"",
		""englishName"": ""Old Die"",
		""englishTooltip"": [
			""Lucky for you, the curse doesn't affect you. Mostly."",
			""Increases luck by 20%""
		],
		""name"": ""Vieux Dé"",
		""tooltip"": [
			""Vous avez de la veine, sa malédiction ne vous atteint pas, enfin presque."",
			""Rends les dégâts des attaques plus aléatoires""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AgedLaboratoryElectricPanelItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Electric Panel"",
		""name"": ""Vieux Panneau Électrique de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AgedLaboratoryTerminalItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Terminal"",
		""name"": ""Vieux Terminal de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""VileFeeder"",
		""type"": ""ITEM"",
		""englishName"": ""Vile Feeder"",
		""englishTooltip"": [
			""Summons a baby eater of souls to protect you""
		],
		""name"": ""Vil Dévoreur"",
		""tooltip"": [
			""Invoque un bébé dévoreur d'âmes pour vous protéger""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WhiteWine"",
		""type"": ""ITEM"",
		""englishName"": ""White Wine"",
		""englishTooltip"": [
			""I drank a full barrel of this stuff once in one night, I couldn't remember who I was the next day"",
			""Boosts magic damage by 10%"",
			""Reduces defense by 6% and life regen by 1""
		],
		""name"": ""Vin Blanc"",
		""tooltip"": [
			""J'ai bu un tonneau entier de ce truc une nuit, Je savais plus qui j'étais le lendemain"",
			""Augmente les dégâts magiques de 10%"",
			""Reduit la défense de 6% et la régénération de vie de 1""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RedWine"",
		""type"": ""ITEM"",
		""englishName"": ""Red Wine"",
		""englishTooltip"": [
			""Too dry for my taste"",
			""Reduces life regen by 1""
		],
		""name"": ""Vin Rouge"",
		""tooltip"": [
			""Un peu trop sec à mon goût"",
			""Réduit la régénration de vie de 1""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VitriolicViper"",
		""type"": ""ITEM"",
		""englishName"": ""Vitriolic Viper"",
		""englishTooltip"": [
			""Releases a volley of venomous fangs and spit""
		],
		""name"": ""Vipère de Vitriol"",
		""tooltip"": [
			""Libère une volée de crocs et de crachats venimeux""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Tumbleweed"",
		""type"": ""ITEM"",
		""englishName"": ""Tumbleweed"",
		""englishTooltip"": [
			""Releases a rolling tumbleweed on hit""
		],
		""name"": ""Virevoltant"",
		""tooltip"": [
			""Relâche un virevoltant roulant quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AlphaVirus"",
		""type"": ""ITEM"",
		""englishName"": ""Alpha Virus"",
		""englishTooltip"": [
			""Throws a giant plague cell with a lethal aura that splits into 6 plague seekers on death"",
			""Stealth strikes cause the plague cell to move slower, accumulating an aura of swirling plague seekers as it flies""
		],
		""name"": ""Virus Alpha"",
		""tooltip"": [
			""Jette une cellule de peste géante avec une aura létale qui se divise en 6 colportes-peste quand elle disparaît"",
			""Les attaques furtives font voyager la cellule plus lentement et la fait accumuler une aura de colportes-peste tourbillonants""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GodSlayerVisage"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Visage"",
		""name"": ""Visage Déicide"",
		""tooltip"": [
			""+14% de dégâts et de chances de coup critique magique"",
			""+100 mana maximum et 17% de réduction du coût en mana""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""GhastlyVisage"",
		""type"": ""ITEM"",
		""englishName"": ""Ghastly Visage"",
		""englishTooltip"": [
			""Fires homing ghast energy that explodes""
		],
		""name"": ""Visage Fantômatique"",
		""tooltip"": [
			""Tire de l'énergie fantômatique à tête chercheuse qui explose""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AuricTeslaWireHemmedVisage"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Wire-Hemmed Visage"",
		""englishTooltip"": [
			""30% increased magic damage, 20% increased magic critical strike chance, +100 max mana and 20% reduced mana usage""
		],
		""name"": ""Visage Ourlé de Fils Tesla Aurique"",
		""tooltip"": [
			""+30% de dégâts magiques et +20% de chances de coup critique magique, +100 mana maximum et 20% de réduction des coûts en mana"",
			""Rester immobile augmente les dégâts et les chances de coup critique""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FathomSwarmerVisage"",
		""type"": ""ITEM"",
		""englishName"": ""Fathom Swarmer Visage"",
		""englishTooltip"": [
			""5% increased minion damage"",
			""Provides breathing and light underwater""
		],
		""name"": ""Visage d'Essaim de Brasse"",
		""tooltip"": [
			""+5% de dégâts des sbires"",
			""Vous permet de respirer et émet de la lumière sous l'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ShroomiteVisage"",
		""type"": ""ITEM"",
		""englishName"": ""Shroomite Visage"",
		""englishTooltip"": [
			""25% increased ranged damage for flamethrowers""
		],
		""name"": ""Visage en Champignite"",
		""tooltip"": [
			""+25% de dégâts à distance pour les lances-flammes""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Viscera"",
		""type"": ""ITEM"",
		""englishName"": ""Viscera"",
		""englishTooltip"": [
			""Fires a blood beam that heals you on enemy hits"",
			""The more tiles and enemies the beam bounces off of or travels through the more healing the beam does""
		],
		""name"": ""Viscère"",
		""tooltip"": [
			""Tire un rayon sanglant qui vous soigne quand vous touchez les ennemis"",
			""Au plus le rayon traverse ou rebondit sur des ennemis ou des tuiles, au plus le soin est efficace""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguebringerVisor"",
		""type"": ""ITEM"",
		""englishName"": ""Plaguebringer Visor"",
		""englishTooltip"": [
			""15% increased minion damage"",
			""+20 max life""
		],
		""name"": ""Viseur du Colporte-Peste"",
		""tooltip"": [
			""+15% de dégâts des sbires"",
			""+20 vie maximum""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Vodka"",
		""type"": ""ITEM"",
		""englishName"": ""Vodka"",
		""englishTooltip"": [
			""The number one alcohol for creating great mixed drinks"",
			""Boosts damage by 6% and critical strike chance by 2%"",
			""Reduces life regen by 1 and defense by 5%""
		],
		""name"": ""Vodka"",
		""tooltip"": [
			""L'alcool numéro 1 pour créer des cocktails géniaux"",
			""Augmente les dégâts de 6% et les chances de coup critique de 2%"",
			""Réduit la régénération de vie de 1 et la défense de 5%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FabsolsVodka"",
		""type"": ""ITEM"",
		""englishName"": ""Fabsol's Vodka"",
		""englishTooltip"": [
			""Boosts all damage stats by 8% but lowers defense by 10%"",
			""Increases immune time after being struck"",
			""This magical liquor is highly sought by those with a refined palate""
		],
		""name"": ""Vodka de Fabsol"",
		""tooltip"": [
			""Augmente toute les statistiques de dégâts de 8% mais diminue la défense de 10%"",
			""Augmente la période d'invulnérabilité après vous être fait toucher"",
			""Cette liqueur magique est très recherchée par ceux qui ont un palais raffiné""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SolarVeil"",
		""type"": ""ITEM"",
		""englishName"": ""Solar Veil"",
		""englishTooltip"": [
			""Sunlight cannot penetrate the fabric of this cloth""
		],
		""name"": ""Voile Solaire"",
		""tooltip"": [
			""La lumière du soleil ne traverse pas ce tissu""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SpectralVeil"",
		""type"": ""ITEM"",
		""englishName"": ""Spectral Veil"",
		""englishTooltip"": [
			""The inside of the cloak is full of teeth..."",
			""TOOLTIP LINE HERE"",
			""If you dodge something while invulnerable, you instantly gain full stealth"",
			""Teleportation is disabled while Chaos State is active"",
			""Stealth generates 20% faster while moving""
		],
		""name"": ""Voile Spectral"",
		""tooltip"": [
			""L'intérieur du manteau est plein de dents..."",
			""TOOLTIP LINE HERE"",
			""La téléportation est impossible si vous subissez le chaos"",
			""Si vous esquivez une attaque alors que vous êtes invulnérable, votre furtivité est maximisée"",
			""La furtivité augmente 20% plus vite lorsque vous êtes en mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""FetidEmesis"",
		""type"": ""ITEM"",
		""englishName"": ""Fetid Emesis"",
		""englishTooltip"": [
			""40% chance to not consume ammo"",
			""Has a chance to release rotten chunks instead of bullets""
		],
		""name"": ""Vomissement Fétide"",
		""tooltip"": [
			""40% de chances de ne pas consommer de munitions"",
			""A une chance de libérer des morceaux pourris à la place des balles.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SubsumingVortex"",
		""type"": ""ITEM"",
		""englishName"": ""Subsuming Vortex"",
		""englishTooltip"": [
			""Releases a gigantic, slow-moving vortex"",
			""The vortex releases exo tentacles that thrash at nearby enemies"",
			""After a few seconds the vortex slows down, becomes unstable, and explodes""
		],
		""name"": ""Vortex Incorporant"",
		""tooltip"": [
			""Relâche un lent et gigantesque vortex"",
			""le vortex libère des exo tentacules qui fouettent les ennemis proches"",
			""Après quelques secondes, le vortex ralentit, devient instable puis explose""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VoidVortex"",
		""type"": ""ITEM"",
		""englishName"": ""Void Vortex"",
		""englishTooltip"": [
			""Conjures a swirling vortex of supercharged magnet spheres around the cursor""
		],
		""name"": ""Vortex de Néant"",
		""tooltip"": [
			""Tire une étendue circulaire d'orbes magnétiques superchargées autour du curseur""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TrueCausticEdge"",
		""type"": ""ITEM"",
		""englishName"": ""True Caustic Edge"",
		""englishTooltip"": [
			""Fires a bouncing caustic beam"",
			""Inflicts poison and venom""
		],
		""name"": ""Véritable Tranchant Caustique"",
		""tooltip"": [
			""Tire un rayon caustique rebondissant"",
			""Inflige le poison et le venin""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TrueBloodyEdge"",
		""type"": ""ITEM"",
		""englishName"": ""True Bloody Edge"",
		""englishTooltip"": [
			""Chance to heal the player on enemy hits"",
			""Inflicts Burning Blood"",
			""Fires a bloody blade""
		],
		""name"": ""Véritable Tranchant Sanglant"",
		""tooltip"": [
			""Peut soigner le joueur quand vous touchez"",
			""Inflige le sang bouillonant"",
			""Tire un tranchant sanglant""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TrueTyrantYharimsUltisword"",
		""type"": ""ITEM"",
		""englishName"": ""True Tyrant's Ultisword"",
		""englishTooltip"": [
			""Fires blazing, hyper, and sunlight blades"",
			""Gives the player the tyrant's fury buff on enemy hits"",
			""This buff increases melee damage by 30% and melee crit chance by 10%""
		],
		""name"": ""Véritable Ultimépée du Tyran"",
		""tooltip"": [
			""Tire des lames flamboyantes, des hyper lames et des lames de lueur solaire"",
			""Donne au joueur la fureur du tyran quand il touche les ennemis"",
			""Cette amélioration augmente les dégâts de mêlée de 30% et les chances de coup critique en mêlée de 10%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TrueForbiddenOathblade"",
		""type"": ""ITEM"",
		""englishName"": ""True Forbidden Oathblade"",
		""englishTooltip"": [
			""Fires a spread of demonic scythes and critical hits cause shadowflame explosions""
		],
		""name"": ""Véritable Épée du Serment Oubliée"",
		""tooltip"": [
			""Tire une étendue de faux démoniaques et les coups critiques causent des explosions d'ombreflamme""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Whiskey"",
		""type"": ""ITEM"",
		""englishName"": ""Whiskey"",
		""englishTooltip"": [
			""The burning sensation makes it tastier"",
			""Boosts damage by 4%, knockback by 20% and critical strike chance by 2%"",
			""Reduces defense by 5%""
		],
		""name"": ""Whisky"",
		""tooltip"": [
			""La sensation brûlante le rend plus goûtu"",
			""Augmente les dégâts et le recul de 4% et les chances de coup critique de 2%"",
			""Réduit la défense de 5%""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Xerocodile"",
		""type"": ""ITEM"",
		""englishName"": ""Xerocodile"",
		""englishTooltip"": [
			""Right click to extract blood orbs""
		],
		""name"": ""Xerocodile"",
		""tooltip"": [
			""Clic droit pour extraire des orbes de sang""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SnakeEyes"",
		""type"": ""ITEM"",
		""englishName"": ""Snake Eyes"",
		""englishTooltip"": [
			""Surveillance drones equipped with a strong electric field which can be directed at enemies"",
			""Summons a mechanical watcher that zaps and flies around enemies""
		],
		""name"": ""Yeux de Serpent"",
		""tooltip"": [
			""Des drones de surveillance équipés avec un puissant champ électrique qui peut être dirigé vers les ennemis."",
			""Invoque un surveillant mécanique qui choque et vole autour des ennemis.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""YinYo"",
		""type"": ""ITEM"",
		""englishName"": ""Yin-Yo"",
		""englishTooltip"": [
			""Fires light or dark shards when enemies are near"",
			""Shards fly back and forth"",
			""A very agile yoyo""
		],
		""name"": ""Yin-Yo"",
		""tooltip"": [
			""Tire des éclats de lumière et de ténèbres quand les ennemis en sont proches"",
			""Les éclats volent en avant puis en arrière"",
			""Un yoyo très agile""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AbsoluteZero"",
		""type"": ""ITEM"",
		""englishName"": ""Absolute Zero"",
		""englishTooltip"": [
			""Ancient blade imbued with the Archmage of Ice's magic"",
			""Shoots dark ice crystals"",
			""The blade creates frost explosions on direct hits""
		],
		""name"": ""Zéro Absolu "",
		""tooltip"": [
			""Une ancienne lame imprégnée par la magie de glace de l'Archimage"",
			""Tire des cristaux de glace noirs"",
			""La lame créée des explosions de givre quand vous portez un coup direct""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Brimlance"",
		""type"": ""ITEM"",
		""englishName"": ""Brimlance"",
		""englishTooltip"": [
			""Creates brimstone explosions on enemy hits""
		],
		""name"": ""soufrelance"",
		""tooltip"": [
			""Les ennemis tués par la lance explosent dans des flammes de soufre""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RuinousSoul"",
		""type"": ""ITEM"",
		""englishName"": ""Ruinous Soul"",
		""englishTooltip"": [
			""A shard of the distant past""
		],
		""name"": ""Âme Ruineuse"",
		""tooltip"": [
			""Un fragment d'un passé lointain""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SoulofCryogen"",
		""type"": ""ITEM"",
		""englishName"": ""Soul of Cryogen"",
		""englishTooltip"": [
			""The magic of the ancient ice castle is yours"",
			""Counts as wings"",
			""Horizontal speed: 6.25"",
			""Acceleration multiplier: 1.0"",
			""Average vertical speed"",
			""Flight time: 120"",
			""7% increase to all damage"",
			""All melee attacks and projectiles inflict frostburn"",
			""Icicles rain down as you fly""
		],
		""name"": ""Âme de Cryogène"",
		""tooltip"": [
			""La magie de l'ancienne château de glace est votre"",
			""Compte comme des ailes"",
			""Vitesse Horizontale: 6.25"",
			""Multiplicateur d'accélération: 1"",
			""Vitesse verticale moyenne"",
			""Temps de vol: 120"",
			""+7% à tous les dégâts"",
			""Toutes les attaques et les projectiles de corps à corps inflige brûlegivre"",
			""Des stalagtites pleuvent lorsque vous volez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DragonScales"",
		""type"": ""ITEM"",
		""englishName"": ""Dragon Scales"",
		""englishTooltip"": [
			""Only a living dragon holds true treasure"",
			""Rogue projectiles create slow fireballs as they travel"",
			""Stealth strikes create infernados on death"",
			""+10% max run speed and acceleration"",
			""Grants immunity to Dragon Fire""
		],
		""name"": ""Écailles de Dragon"",
		""tooltip"": [
			""Seul un dragon vivant possède un véritable trésor"",
			""Les projectiles de voleur créent de lentes boules de feu sur leur trajet"",
			""Les attaques furtives créent une infernade à la disparition du projectile"",
			""+10% à votre accélération et votre vitesse de mouvement""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SludgeSplotch"",
		""type"": ""ITEM"",
		""englishName"": ""Sludge Splotch"",
		""englishTooltip"": [
			""Slows non-boss enemies slightly"",
			""Stealth strikes cause the main ball of sludge to split on hit, inflicting more damage""
		],
		""name"": ""Éclaboussure Boueuse"",
		""tooltip"": [
			""Ralentit un peu les ennemis, sauf les boss"",
			""Les attaques furtives font se diviser la boule de boue principale, augmentant ainsi ses dégâts""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedShard"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Shard"",
		""englishTooltip"": [
			""A shard of the unholy flame"",
			""Summons the Profaned Guardians when used in the hallow or underworld during daytime"",
			""Not consumable""
		],
		""name"": ""Éclat Profané"",
		""tooltip"": [
			""Un éclat de la flamme impie"",
			""Invoque les Gardiens Profanés quand utilisé dans le sacré ou l'enfer la journée"",
			""Non consommable""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""DarkSpark"",
		""type"": ""ITEM"",
		""englishName"": ""Dark Spark"",
		""englishTooltip"": [
			""And everything under the sun is in tune,"",
			""But the sun is eclipsed by the moon.""
		],
		""name"": ""Éclat Sombre"",
		""tooltip"": [
			""Et tout ce qui est sous le soleil est en harmonie,"",
			""Mais le soleil est éclipsé par la lune.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CometShard"",
		""type"": ""ITEM"",
		""englishName"": ""Comet Shard"",
		""englishTooltip"": [
			""Permanently increases maximum mana by 50""
		],
		""name"": ""Éclat de Comète"",
		""tooltip"": [
			""Augmente de façon permanente votre mana maximum de 50""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PrismShard"",
		""type"": ""ITEM"",
		""englishName"": ""Prism Shard"",
		""name"": ""Éclat de Prisme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LightGodsBrilliance"",
		""type"": ""ITEM"",
		""englishName"": ""Light God's Brilliance"",
		""englishTooltip"": [
			""Casts small, homing light beads along with explosive light balls""
		],
		""name"": ""Éclat du Dieu de la Lumière"",
		""tooltip"": [
			""Convoque de petites perles de lumières à tête charcheuse et des boules explosives de lumière""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VeinBurster"",
		""type"": ""ITEM"",
		""englishName"": ""Vein Burster"",
		""englishTooltip"": [
			""Fires a blood ball that sticks to tiles and explodes""
		],
		""name"": ""Éclate-Veine"",
		""tooltip"": [
			""Tire une boule de sang qui se colle aux tuiles et explose""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Vortexpopper"",
		""type"": ""ITEM"",
		""englishName"": ""Vortexpopper"",
		""englishTooltip"": [
			""Fires bubbles everywhere that pop into bullets""
		],
		""name"": ""Éclateur de Vortex"",
		""tooltip"": [
			""Tire des bulles de partout qui éclatent en balles""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""YateveoBloom"",
		""type"": ""ITEM"",
		""englishName"": ""Yateveo Bloom"",
		""englishTooltip"": [
			""A synthesis of jungle flora"",
			""Throws a powerful rose flail"",
			""Right click to stab with a flower spear""
		],
		""name"": ""Éclosion de Yateveo"",
		""tooltip"": [
			""Une synthèse de la flore de la jungle"",
			""Lance un puissant fléau de roses"",
			""Clic droit pour empaler avec une lance florale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EssenceFlayer"",
		""type"": ""ITEM"",
		""englishName"": ""Essence Flayer"",
		""englishTooltip"": [
			""Shoots an essence scythe that generates healing spirits on enemy kills""
		],
		""name"": ""Écorcheur d'Essence"",
		""tooltip"": [
			""Tire une faux d'essence qui génère des esprits soigneurs quand vous tuez un ennemi""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""LaboratoryScreenItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Screen"",
		""name"": ""Écran de Laboratoire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrushsawCrasher"",
		""type"": ""ITEM"",
		""englishName"": ""Crushsaw Crasher"",
		""englishTooltip"": [
			""Throws bouncing axes"",
			""Stealth strikes throw five at once""
		],
		""name"": ""Écraseur Broie-scie"",
		""tooltip"": [
			""Jette des haches rebondissantes"",
			""Les attaques furtives en lancent 5 à la fois""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodsoakedCrasher"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodsoaked Crasher"",
		""englishTooltip"": [
			""Slows down when hitting an enemy. Speeds up otherwise"",
			""Heals on enemy hits"",
			""Stealth strikes spawn homing blood on enemy hits""
		],
		""name"": ""Écraseur Ensanglanté"",
		""tooltip"": [
			""Ralentit lorsqu'un ennemi est touché. Accélère sinon."",
			""Soigne le joueur lorsqu'un ennemi est touché"",
			""Les attaques furtives génerent du sang a tête chercheuse quand elles touchent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""HydraulicVoltCrasher"",
		""type"": ""ITEM"",
		""englishName"": ""Hydraulic Volt Crasher"",
		""englishTooltip"": [
			""Good for both stamping metal plates and instantly fusing them, as well as crushing enemies"",
			""An electrically charged jackhammer which shocks all nearby foes on hit""
		],
		""name"": ""Écraseur Volt Hydrolique"",
		""tooltip"": [
			""Parfait pour estampiler les plaques métaliques et les fusionner instantanément, en plus d'écraser les ennemis."",
			""Un marteau piqueur chargé électriquement qui électrifie les ennemis proches quand vous touchez""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CrystylCrusher"",
		""type"": ""ITEM"",
		""englishName"": ""Crystyl Crusher"",
		""englishTooltip"": [
			""Gotta dig faster, gotta go deeper"",
			""Right click to swing normally""
		],
		""name"": ""Écraseur de Crystyl"",
		""tooltip"": [
			""Faut creuser plus vite, et plus profond"",
			""Clic droit pour une utilisation normale""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ClamCrusher"",
		""type"": ""ITEM"",
		""englishName"": ""Clam Crusher"",
		""englishTooltip"": [
			""Launches a huge clam that stuns enemies for a short amount of time"",
			""Starts being affected by gravity and does much more damage after being airborne for a while""
		],
		""name"": ""Écraseur de Palourde"",
		""tooltip"": [
			""Lance une énorme palourde qui stoppe les ennemis un court moment"",
			""Commence a être affecté par la gravité et fait bien plus de dégâts après avoir été en l'air un moment""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgeBrimstoneElemental"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Elemental"",
		""englishTooltip"": [
			""The most powerful of the elementals, bent on exacting revenge upon the bloody inferno that demolished her home."",
			""Finally put to rest, she will suffer no longer from the grief caused by the deaths of her people.""
		],
		""name"": ""Élémentaire de soufre"",
		""tooltip"": [
			""La plus puissante des élémentaires, obsédée par l'accomplissement de sa vengeance contre l'enfer sanglant qui a démoli son foyer."",
			""Maintenant qu'elle n'est plus, elle ne souffrira plus de la peine causée par la mort de son peuple.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SparkSpreader"",
		""type"": ""ITEM"",
		""englishName"": ""Spark Spreader"",
		""englishTooltip"": [
			""70% chance to not consume gel""
		],
		""name"": ""Épandeur d'Étincelles"",
		""tooltip"": [
			""70% de chances de ne pas consommer de gel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Swordsplosion"",
		""type"": ""ITEM"",
		""englishName"": ""Swordsplosion"",
		""englishTooltip"": [
			""Sword swarm""
		],
		""name"": ""Épexplosion"",
		""tooltip"": [
			""Nuée d'épées""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""UrchinStinger"",
		""type"": ""ITEM"",
		""englishName"": ""Urchin Stinger"",
		""englishTooltip"": [
			""Stealth strikes stick to enemies while releasing sulfuric bubbles""
		],
		""name"": ""Épine d'Oursin"",
		""tooltip"": [
			""Les attaques furtives se fixent aux ennemis en relâchant des bulles sulfuriques""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Needler"",
		""type"": ""ITEM"",
		""englishName"": ""Needler"",
		""englishTooltip"": [
			""Converts musket balls into needles that stick to enemies and explode""
		],
		""name"": ""Épineur"",
		""tooltip"": [
			""Convertit les balles de mousquet en épines qui se plantent et qui explosent""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""KnowledgePolterghast"",
		""type"": ""ITEM"",
		""englishName"": ""Polterghast"",
		""englishTooltip"": [
			""A creature born of hatred and anger, formed by countless human souls with all of their energy entirely devoted to consuming others."",
			""It seems a waste to have had such a potent source of power ravage mindlessly through these empty halls.""
		],
		""name"": ""Épouvantôme"",
		""tooltip"": [
			""Une créature née de la haine et de la colère, constituée d'innombrables âmes humaines dont toute l'énergie est canalisé dans l'optique de dévorer."",
			""C'est du gâchis d'avoir eu une telle source de pouvoir pour la laisser errer et ravager sans but ces couloirs vides.""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""OldLordOathsword"",
		""type"": ""ITEM"",
		""englishName"": ""Old Lord Oathsword"",
		""englishTooltip"": [
			""A relic of the ancient underworld"",
			""Holding right click rapidly absorbs energy into the blade until it is sufficiently charged"",
			""Left clicking will either swing the blade as usual or cause you to fly in the direction of the cursor, depending on if the blade was fully charged"",
			""After flying the amount of charge the blade has is reduced to zero again""
		],
		""name"": ""Épée du Serment du Vieux Seigneur"",
		""tooltip"": [
			""Une relique de l'ancien enfer"",
			""Les coups critiques causent des explosions de lave""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BladecrestOathsword"",
		""type"": ""ITEM"",
		""englishName"": ""Bladecrest Oathsword"",
		""englishTooltip"": [
			""Fires bursts of demonic blades that exponentially decelerate and explode"",
			""Sword of an ancient demon lord""
		],
		""name"": ""Épée-Serment du Blason-Lame"",
		""tooltip"": [
			""Épée d'un ancien roi-démon"",
			""Tire une faux de sang""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Eradicator"",
		""type"": ""ITEM"",
		""englishName"": ""Eradicator"",
		""englishTooltip"": [
			""Throws a disk that fires lasers at nearby enemies"",
			""Stealth strikes stick to enemies and unleash a barrage of lasers in all directions""
		],
		""name"": ""Éradicateur"",
		""tooltip"": [
			""Lance un disque qui tire des lasers sur les ennemis proches"",
			""Les attaques furtivent se fixent aux ennemis et libèrent un barrage de lasers omnidirectionnel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ElementalEruption"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Eruption"",
		""englishTooltip"": [
			""90% chance to not consume gel"",
			""Fires a spread of rainbow flames""
		],
		""name"": ""Éruption des Éléments"",
		""tooltip"": [
			""90% de chances de ne pas consommer de gel"",
			""Tire une étendue de flammes arc-en-ciel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Shimmerspark"",
		""type"": ""ITEM"",
		""englishName"": ""Shimmerspark"",
		""englishTooltip"": [
			""Fires stars when enemies are near"",
			""A very agile yoyo""
		],
		""name"": ""Étincelle Scintillante"",
		""tooltip"": [
			""Tire des étoiles lorsque des ennemis sont proches"",
			""Un yoyo très agile""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""TwinklerInABottle"",
		""type"": ""ITEM"",
		""englishName"": ""Twinkler in a Bottle"",
		""name"": ""Étincelle en Bouteille"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BlazingStar"",
		""type"": ""ITEM"",
		""englishName"": ""Blazing Star"",
		""englishTooltip"": [
			""Stacks up to 4"",
			""Stealth strikes release all stars at once with infinite piercing""
		],
		""name"": ""Étoile Flamboyante"",
		""tooltip"": [
			""Se cumule 4 fois"",
			""Les attaques furtives libèrent toutes les étoiles simultanément et transperçent indéfiniment""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""RadiantStar"",
		""type"": ""ITEM"",
		""englishName"": ""Radiant Star"",
		""englishTooltip"": [
			""Throws daggers that explode and split after a while"",
			""Stealth strike splits more with a devastating explosion and sucks enemies in""
		],
		""name"": ""Étoile Radieuse"",
		""tooltip"": [
			""Lance des dagues qui explosent et se divisent après un moment"",
			""Les attaques furtives se divisent plus et provoquent une explosion dévastatrice qui attirent les ennemis""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""IceStar"",
		""type"": ""ITEM"",
		""englishName"": ""Ice Star"",
		""englishTooltip"": [
			""Throws homing ice stars"",
			""Stealth strikes pierce infinitely and spawn ice shards on hit"",
			""Ice Stars are too brittle to be recovered after being thrown""
		],
		""name"": ""Étoile de Glace"",
		""tooltip"": [
			""Jette des étoiles de glace à têtes chercheuses"",
			""Les attaques furtives percent indéfiniment et créent des éclats de glace quand elles touchent"",
			""Elles sont trop fragiles pour être récupérée après avoir été lancées""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EnchantedStarfish"",
		""type"": ""ITEM"",
		""englishName"": ""Enchanted Starfish"",
		""englishTooltip"": [
			""Permanently increases maximum mana by 20""
		],
		""name"": ""Étoile de Mer Enchantée"",
		""tooltip"": [
			""Augmente de façon permanente le mana maximum de 20""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StarofDestruction"",
		""type"": ""ITEM"",
		""englishName"": ""Star of Destruction"",
		""englishTooltip"": [
			""Fires a huge destructive mine that explodes into destruction bolts"",
			""Amount of bolts scales with enemies hit, up to 16"",
			""Stealth strikes always explode into the max amount of bolts""
		],
		""name"": ""Étoile de la Destruction"",
		""tooltip"": [
			""Tire une gigantesque mine destructive qui explose en des éclairs de destruction"",
			""La quantité d'éclairs dépendent du nombre de coups portés aux ennemis, jusqu'a un maximum de 16"",
			""Les attaques furtives émettent toujours le maximum d'éclairs""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Mourningstar"",
		""type"": ""ITEM"",
		""englishName"": ""Mourningstar"",
		""englishTooltip"": [
			""Launches two solar whip swords that explode on hit""
		],
		""name"": ""Étoile du Deuil"",
		""tooltip"": [
			""Lance deux fouets-lames qui explosent à l'impact""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AbyssSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": ""Évier Abyssal"",
		""tooltip"": [
			""Source d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AncientSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a lava source""
		],
		""name"": ""Évier Ancien"",
		""tooltip"": [
			""Source de Lave""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""BotanicSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a honey source""
		],
		""name"": ""Évier Botanique"",
		""tooltip"": [
			""Source de Miel""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""EutrophicSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": ""Évier Eutrophique"",
		""tooltip"": [
			""Source d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""MonolithSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": ""Évier Monolithique"",
		""tooltip"": [
			""Source d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguedPlateSink"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Sink"",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": ""Évier Pestiféré"",
		""tooltip"": [
			""Source d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a lava source""
		],
		""name"": ""Évier Profané"",
		""tooltip"": [
			""Source de lave""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""SilvaSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": ""Évier Silva"",
		""tooltip"": [
			""Source d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StratusSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": ""Évier Stratus"",
		""tooltip"": [
			""Source d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AcidwoodSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": ""Évier de Bois Acide"",
		""tooltip"": [
			""Compte comme une source d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AshenSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a lava source""
		],
		""name"": ""Évier de Cendre"",
		""tooltip"": [
			""Source de lave""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""VoidSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": ""Évier du Néant"",
		""tooltip"": [
			""Source d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmiliteSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": ""Évier en Cosmilite"",
		""tooltip"": [
			""Source d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""StatigelSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": ""Évier en Statigel"",
		""tooltip"": [
			""Source d'eau""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""Eviscerator"",
		""type"": ""ITEM"",
		""englishName"": ""Eviscerator"",
		""englishTooltip"": [
			""Converts musket balls into fast-moving blood clots""
		],
		""name"": ""Éviscerateur"",
		""tooltip"": [
			""Convertit les balles de mousquet en lents caillots sanguins""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""WrathoftheAncients"",
		""type"": ""ITEM"",
		""englishName"": ""Wrath of the Ancients"",
		""englishTooltip"": [
			""Summons an energy pulse at the cursor to periodically summon homing spirits""
		],
		""name"": ""Îre des Anciens"",
		""tooltip"": [
			""Invoque une impulsion d'énergie sur le curseurqui invoque régulièrement des esprits à tête chercheuse""
		],
		""state"": ""Traduit""
	},
	{
		""id"": ""AquaticAberration"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Aberration"",
		""name"": ""Abérattion Aquatique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MicrobialCluster"",
		""type"": ""NPC"",
		""englishName"": ""Microbial Cluster"",
		""name"": ""Amas Microbien"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AcidEel"",
		""type"": ""NPC"",
		""englishName"": ""Acid Eel"",
		""name"": ""Anguille Acide"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GulperEelTail"",
		""type"": ""NPC"",
		""englishName"": ""Gulper Eel"",
		""name"": ""Anguille Engloutisseuse"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GulperEelBody"",
		""type"": ""NPC"",
		""englishName"": ""Gulper Eel"",
		""name"": ""Anguille Engloutisseuse"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GulperEelBodyAlt"",
		""type"": ""NPC"",
		""englishName"": ""Gulper Eel"",
		""name"": ""Anguille Engloutisseuse"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GulperEelHead"",
		""type"": ""NPC"",
		""englishName"": ""Gulper Eel"",
		""name"": ""Anguille Engloutisseuse"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralachneaWall"",
		""type"": ""NPC"",
		""englishName"": ""Astralachnea"",
		""name"": ""Arachnée Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralachneaGround"",
		""type"": ""NPC"",
		""englishName"": ""Astralachnea"",
		""name"": ""Arachnée Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DILF"",
		""type"": ""NPC"",
		""englishName"": ""Archmage"",
		""name"": ""Archimage"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SoulSlurper"",
		""type"": ""NPC"",
		""englishName"": ""Soul Slurper"",
		""name"": ""Aspire-Âme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CultistAssassin"",
		""type"": ""NPC"",
		""englishName"": ""Cultist Assassin"",
		""name"": ""Assassin Cultiste"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProvSpawnOffense"",
		""type"": ""NPC"",
		""englishName"": ""Providence Offense"",
		""name"": ""Attaquant de Providence"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumHovercraft"",
		""type"": ""NPC"",
		""englishName"": ""Wulfrum Hovercraft"",
		""name"": ""Aéroglisseur Wulfrum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""OldDukeToothBall"",
		""type"": ""NPC"",
		""englishName"": ""Tooth Ball"",
		""name"": ""Balle Dentée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BlindedAngler"",
		""type"": ""NPC"",
		""englishName"": ""Blinded Angler"",
		""name"": ""Baudroie Aveuglée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ColossalSquid"",
		""type"": ""NPC"",
		""englishName"": ""Colossal Squid"",
		""name"": ""Calamar Colossal"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GiantSquid"",
		""type"": ""NPC"",
		""englishName"": ""Giant Squid"",
		""name"": ""Calamar Géant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SupremeCalamitas"",
		""type"": ""NPC"",
		""englishName"": ""Supreme Calamitas"",
		""name"": ""Calamitas Suprême"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SupremeCataclysm"",
		""type"": ""NPC"",
		""englishName"": ""Cataclysm"",
		""name"": ""Cataclysme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrabShroom"",
		""type"": ""NPC"",
		""englishName"": ""Crab Shroom"",
		""name"": ""Champicrabe"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SoulSeeker"",
		""type"": ""NPC"",
		""englishName"": ""Soul Seeker"",
		""name"": ""Cherche-Âme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SoulSeekerSupreme"",
		""type"": ""NPC"",
		""englishName"": ""Soul Seeker"",
		""name"": ""Cherche-âme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GhostBell"",
		""type"": ""NPC"",
		""englishName"": ""Ghost Bell"",
		""name"": ""Cloche Fantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DarkHeart"",
		""type"": ""NPC"",
		""englishName"": ""Dark Heart"",
		""name"": ""Coeur des Ténèbres"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BelchingCoral"",
		""type"": ""NPC"",
		""englishName"": ""Belching Coral"",
		""name"": ""Corail Cracheur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""LuminousCorvina"",
		""type"": ""NPC"",
		""englishName"": ""Luminous Corvina"",
		""name"": ""Corvina Lumineuse"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AnthozoanCrab"",
		""type"": ""NPC"",
		""englishName"": ""Anthozoan Crab"",
		""name"": ""Crabe Anthozoaire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FlakCrab"",
		""type"": ""NPC"",
		""englishName"": ""Flak Crab"",
		""name"": ""Crabe Flak"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralSeekerSpit"",
		""type"": ""NPC"",
		""englishName"": ""Seeker Spit"",
		""name"": ""Crachat de Chercheur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""NuclearToad"",
		""type"": ""NPC"",
		""englishName"": ""Nuclear Toad"",
		""name"": ""Crapaud Nucléaire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ArmoredDiggerBody"",
		""type"": ""NPC"",
		""englishName"": ""Armored Digger"",
		""name"": ""Creuseur Blindé"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ArmoredDiggerHead"",
		""type"": ""NPC"",
		""englishName"": ""Armored Digger"",
		""name"": ""Creuseur Blindé"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ArmoredDiggerTail"",
		""type"": ""NPC"",
		""englishName"": ""Armored Digger"",
		""name"": ""Creuseur Blindé"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PolterghastHook"",
		""type"": ""NPC"",
		""englishName"": ""Polterghast Hook"",
		""name"": ""Crochet d'Épouvantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Cryogen"",
		""type"": ""NPC"",
		""englishName"": ""Cryogen"",
		""name"": ""Cryogène"",
		""state"": ""Traduit""
	},
	{
		""id"": ""StellarCulex"",
		""type"": ""NPC"",
		""englishName"": ""Stellar Culex"",
		""name"": ""Culex Stellaire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProvSpawnDefense"",
		""type"": ""NPC"",
		""englishName"": ""Providence Defender"",
		""name"": ""Defenseur de Providence"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Yharon"",
		""type"": ""NPC"",
		""englishName"": ""Jungle Dragon, Yharon"",
		""name"": ""Dragon de la Jungle, Yharon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumDrone"",
		""type"": ""NPC"",
		""englishName"": ""Wulfrum Drone"",
		""name"": ""Drone Wulfrum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Trasher"",
		""type"": ""NPC"",
		""englishName"": ""Trasher"",
		""name"": ""Déchiqueteur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FusionFeeder"",
		""type"": ""NPC"",
		""englishName"": ""Fusion Feeder"",
		""name"": ""Dévoreur de Fusion"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ScornEater"",
		""type"": ""NPC"",
		""englishName"": ""Scorn Eater"",
		""name"": ""Dévoreur de Mépris"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Eidolist"",
		""type"": ""NPC"",
		""englishName"": ""Eidolist"",
		""name"": ""Eidoliste"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PhantomSpiritS"",
		""type"": ""NPC"",
		""englishName"": ""Phantom Spirit"",
		""name"": ""Esprit Fantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PhantomSpiritL"",
		""type"": ""NPC"",
		""englishName"": ""Phantom Spirit"",
		""name"": ""Esprit Fantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PhantomSpiritM"",
		""type"": ""NPC"",
		""englishName"": ""Phantom Spirit"",
		""name"": ""Esprit Fantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PhantomSpirit"",
		""type"": ""NPC"",
		""englishName"": ""Phantom Spirit"",
		""name"": ""Esprit Fantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HeatSpirit"",
		""type"": ""NPC"",
		""englishName"": ""Heat Spirit"",
		""name"": ""Esprit de Chaleur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HiveMind"",
		""type"": ""NPC"",
		""englishName"": ""The Hive Mind"",
		""name"": ""Esprit de Ruche"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Bumblefuck2"",
		""type"": ""NPC"",
		""englishName"": ""Draconic Swarmer"",
		""name"": ""Essaimeur Draconique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PhantomFuckYou"",
		""type"": ""NPC"",
		""englishName"": ""Phantom"",
		""name"": ""Fantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SeaFloaty"",
		""type"": ""NPC"",
		""englishName"": ""Sea Floaty"",
		""name"": ""Flotteur des Mers"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AquaticScourgeBody"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Scourge"",
		""name"": ""Fléau Aquatique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AquaticScourgeBodyAlt"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Scourge"",
		""name"": ""Fléau Aquatique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AquaticScourgeHead"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Scourge"",
		""name"": ""Fléau Aquatique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AquaticScourgeTail"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Scourge"",
		""name"": ""Fléau Aquatique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DesertScourgeTail"",
		""type"": ""NPC"",
		""englishName"": ""Desert Scourge"",
		""name"": ""Fléau du Désert"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DesertScourgeHead"",
		""type"": ""NPC"",
		""englishName"": ""Desert Scourge"",
		""name"": ""Fléau du Désert"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DesertScourgeBody"",
		""type"": ""NPC"",
		""englishName"": ""Desert Scourge"",
		""name"": ""Fléau du Désert"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ToxicMinnow"",
		""type"": ""NPC"",
		""englishName"": ""Toxic Minnow"",
		""name"": ""Fretin Toxique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralSlime"",
		""type"": ""NPC"",
		""englishName"": ""Astral Slime"",
		""name"": ""Gelée Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AeroSlime"",
		""type"": ""NPC"",
		""englishName"": ""Aero Slime"",
		""name"": ""Gelée Aérienne"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CharredSlime"",
		""type"": ""NPC"",
		""englishName"": ""Charred Slime"",
		""name"": ""Gelée Calcinée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrimulanBlightSlime"",
		""type"": ""NPC"",
		""englishName"": ""Crimulan Blight Slime"",
		""name"": ""Gelée Carminée Trouble"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CryoSlime"",
		""type"": ""NPC"",
		""englishName"": ""Cryo Slime"",
		""name"": ""Gelée Cryo"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GammaSlime"",
		""type"": ""NPC"",
		""englishName"": ""Gamma Slime"",
		""name"": ""Gelée Gamma"",
		""state"": ""Traduit""
	},
	{
		""id"": ""IrradiatedSlime"",
		""type"": ""NPC"",
		""englishName"": ""Irradiated Slime"",
		""name"": ""Gelée Irradiée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MirageJelly"",
		""type"": ""NPC"",
		""englishName"": ""Mirage Jelly"",
		""name"": ""Gelée Mirage"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerennialSlime"",
		""type"": ""NPC"",
		""englishName"": ""Perennial Slime"",
		""name"": ""Gelée Vivace"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloomSlime"",
		""type"": ""NPC"",
		""englishName"": ""Bloom Slime"",
		""name"": ""Gelée de Floraison"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EbonianBlightSlime"",
		""type"": ""NPC"",
		""englishName"": ""Ebonian Blight Slime"",
		""name"": ""Gelée de Fléau d'Ébène"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Sunskater"",
		""type"": ""NPC"",
		""englishName"": ""Sunskater"",
		""name"": ""Glisse-Soleil"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HiveBlob"",
		""type"": ""NPC"",
		""englishName"": ""Hive Blob"",
		""name"": ""Goutte de Ruche"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HiveBlob2"",
		""type"": ""NPC"",
		""englishName"": ""Hive Blob"",
		""name"": ""Goutte de Ruche"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GreatSandShark"",
		""type"": ""NPC"",
		""englishName"": ""Great Sand Shark"",
		""name"": ""Grand Requin des Sables"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Gnasher"",
		""type"": ""NPC"",
		""englishName"": ""Gnasher"",
		""name"": ""Grinceur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BigSightseer"",
		""type"": ""NPC"",
		""englishName"": ""Big Sightseer"",
		""name"": ""Gros Cherchevue"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FearlessGoldfishWarrior"",
		""type"": ""NPC"",
		""englishName"": ""Fearless Goldfish Warrior"",
		""name"": ""Guerrier Poisson Doré Sans Peur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumGyrator"",
		""type"": ""NPC"",
		""englishName"": ""Wulfrum Gyrator"",
		""name"": ""Gyrateur Wulfrum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Hadarian"",
		""type"": ""NPC"",
		""englishName"": ""Hadarian"",
		""name"": ""Hadarien"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ImpiousImmolator"",
		""type"": ""NPC"",
		""englishName"": ""Impious Immolator"",
		""name"": ""Immolateur Impie"",
		""state"": ""Traduit""
	},
	{
		""id"": ""KingSlimeJewel"",
		""type"": ""NPC"",
		""englishName"": ""Crown Jewel"",
		""name"": ""Joyau de la Couronne"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorCyst"",
		""type"": ""NPC"",
		""englishName"": ""Perforator Cyst"",
		""name"": ""Kyste de Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""HiveCyst"",
		""type"": ""NPC"",
		""englishName"": ""Hive Cyst"",
		""name"": ""Kyste de Ruche"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Bumblefuck"",
		""type"": ""NPC"",
		""englishName"": ""The Dragonfolly"",
		""name"": ""La Folie Draconique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorHive"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator Hive"",
		""name"": ""La Ruche du Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicLantern"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Lantern"",
		""name"": ""Lanterne Cosmique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SlimeGodCore"",
		""type"": ""NPC"",
		""englishName"": ""The Slime God"",
		""name"": ""Le Dieu des Gelées"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DevourerofGodsTail"",
		""type"": ""NPC"",
		""englishName"": ""The Devourer of Gods"",
		""name"": ""Le Dévoreur de Dieux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DevourerofGodsBody"",
		""type"": ""NPC"",
		""englishName"": ""The Devourer of Gods"",
		""name"": ""Le Dévoreur de Dieux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DevourerofGodsHead"",
		""type"": ""NPC"",
		""englishName"": ""The Devourer of Gods"",
		""name"": ""Le Dévoreur de Dieux"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlaguebringerGoliath"",
		""type"": ""NPC"",
		""englishName"": ""The Plaguebringer Goliath"",
		""name"": ""Le Goliath Colporte-Peste"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Leviathan"",
		""type"": ""NPC"",
		""englishName"": ""The Leviathan"",
		""name"": ""Le Leviathan"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorBodyLarge"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorTailMedium"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorTailSmall"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorBodySmall"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorHeadLarge"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorHeadMedium"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorBodyMedium"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorHeadSmall"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PerforatorTailLarge"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""OldDuke"",
		""type"": ""NPC"",
		""englishName"": ""The Old Duke"",
		""name"": ""Le Vieux Duc"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CragmawMire"",
		""type"": ""NPC"",
		""englishName"": ""Cragmaw Mire"",
		""name"": ""Machoire Rochefange"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Mantis"",
		""type"": ""NPC"",
		""englishName"": ""Mantis"",
		""name"": ""Mante"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MantisShrimp"",
		""type"": ""NPC"",
		""englishName"": ""Mantis Shrimp"",
		""name"": ""Mante Crevette"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueMine"",
		""type"": ""NPC"",
		""englishName"": ""Plague Mine"",
		""name"": ""Mine de Peste"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueHomingMissile"",
		""type"": ""NPC"",
		""englishName"": ""Plague Homing Missile"",
		""name"": ""Missile de Peste à Tête Chercheuse"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MorayEel"",
		""type"": ""NPC"",
		""englishName"": ""Moray Eel"",
		""name"": ""Murène"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Mauler"",
		""type"": ""NPC"",
		""englishName"": ""Mauler"",
		""name"": ""Mutilateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BoxJellyfish"",
		""type"": ""NPC"",
		""englishName"": ""Box Jellyfish"",
		""name"": ""Méduse-Boîte"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Skyfin"",
		""type"": ""NPC"",
		""englishName"": ""Skyfin"",
		""name"": ""Nageoire Céleste"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ShockstormShuttle"",
		""type"": ""NPC"",
		""englishName"": ""Shockstorm Shuttle"",
		""name"": ""Navette de Tempête de Choc"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CeaselessVoid"",
		""type"": ""NPC"",
		""englishName"": ""Ceaseless Void"",
		""name"": ""Néant Incessant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CalamityEye"",
		""type"": ""NPC"",
		""englishName"": ""Calamity Eye"",
		""name"": ""Oeil de Calamity"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AquaticUrchin"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Urchin"",
		""name"": ""Oursin Aquatique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SeaUrchin"",
		""type"": ""NPC"",
		""englishName"": ""Sea Urchin"",
		""name"": ""Oursin de Mer"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Clam"",
		""type"": ""NPC"",
		""englishName"": ""Clam"",
		""name"": ""Palourde"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GiantClam"",
		""type"": ""NPC"",
		""englishName"": ""Giant Clam"",
		""name"": ""Palourde Géante"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Piggy"",
		""type"": ""NPC"",
		""englishName"": ""Piggy"",
		""name"": ""Peggy"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Hiveling"",
		""type"": ""NPC"",
		""englishName"": ""Hiveling"",
		""name"": ""Pestelin"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SmallSightseer"",
		""type"": ""NPC"",
		""englishName"": ""Small Sightseer"",
		""name"": ""Petit Cherchevue"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DespairStone"",
		""type"": ""NPC"",
		""englishName"": ""Despair Stone"",
		""name"": ""Pierre de Désespoir"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FlamePillar"",
		""type"": ""NPC"",
		""englishName"": ""Flame Pillar"",
		""name"": ""Pilier de Flamme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RockPillar"",
		""type"": ""NPC"",
		""englishName"": ""Rock Pillar"",
		""name"": ""Pillier de Roche"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Bloatfish"",
		""type"": ""NPC"",
		""englishName"": ""Bloatfish"",
		""name"": ""Poisson Bouffi"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Catfish"",
		""type"": ""NPC"",
		""englishName"": ""Catfish"",
		""name"": ""Poisson-Chat"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DevilFish"",
		""type"": ""NPC"",
		""englishName"": ""Devil Fish"",
		""name"": ""Poisson-Diable"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DevilFishAlt"",
		""type"": ""NPC"",
		""englishName"": ""Devil Fish"",
		""name"": ""Poisson-Diable"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Frogfish"",
		""type"": ""NPC"",
		""englishName"": ""Frogfish"",
		""name"": ""Poisson-Grenouille"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Laserfish"",
		""type"": ""NPC"",
		""englishName"": ""Laserfish"",
		""name"": ""Poisson-Laser"",
		""state"": ""Traduit""
	},
	{
		""id"": ""OarfishBody"",
		""type"": ""NPC"",
		""englishName"": ""Oarfish"",
		""name"": ""Poisson-Ruban"",
		""state"": ""Traduit""
	},
	{
		""id"": ""OarfishHead"",
		""type"": ""NPC"",
		""englishName"": ""Oarfish"",
		""name"": ""Poisson-Ruban"",
		""state"": ""Traduit""
	},
	{
		""id"": ""OarfishTail"",
		""type"": ""NPC"",
		""englishName"": ""Oarfish"",
		""name"": ""Poisson-Ruban"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Viperfish"",
		""type"": ""NPC"",
		""englishName"": ""Viperfish"",
		""name"": ""Poisson-Vipère"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ChaoticPuffer"",
		""type"": ""NPC"",
		""englishName"": ""Chaotic Puffer"",
		""name"": ""Poisson-globe Chaotique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""FAP"",
		""type"": ""NPC"",
		""englishName"": ""Drunk Princess"",
		""name"": ""Princesse Ivre"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Providence"",
		""type"": ""NPC"",
		""englishName"": ""Providence, the Profaned Goddess"",
		""name"": ""Providence, la Déesse Profanée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumPylon"",
		""type"": ""NPC"",
		""englishName"": ""Wulfrum Pylon"",
		""name"": ""Pylône Wulfrum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Radiator"",
		""type"": ""NPC"",
		""englishName"": ""Radiator"",
		""name"": ""Radiateur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EutrophicRay"",
		""type"": ""NPC"",
		""englishName"": ""Eutrophic Ray"",
		""name"": ""Raie Eutrophique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrawlerAmber"",
		""type"": ""NPC"",
		""englishName"": ""Amber Crawler"",
		""name"": ""Rampant d'Ambre"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrawlerAmethyst"",
		""type"": ""NPC"",
		""englishName"": ""Amethyst Crawler"",
		""name"": ""Rampant d'Améthyste"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrawlerEmerald"",
		""type"": ""NPC"",
		""englishName"": ""Emerald Crawler"",
		""name"": ""Rampant d'Émeraude"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrawlerCrystal"",
		""type"": ""NPC"",
		""englishName"": ""Crystal Crawler"",
		""name"": ""Rampant de Cristal"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrawlerDiamond"",
		""type"": ""NPC"",
		""englishName"": ""Diamond Crawler"",
		""name"": ""Rampant de Diamant"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrawlerRuby"",
		""type"": ""NPC"",
		""englishName"": ""Ruby Crawler"",
		""name"": ""Rampant de Rubis"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrawlerSapphire"",
		""type"": ""NPC"",
		""englishName"": ""Sapphire Crawler"",
		""name"": ""Rampant de Saphir"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CrawlerTopaz"",
		""type"": ""NPC"",
		""englishName"": ""Topaz Crawler"",
		""name"": ""Rampant de Topaze"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EnchantedNightcrawler"",
		""type"": ""NPC"",
		""englishName"": ""Enchanted Nightcrawler"",
		""name"": ""Rampenuit Enchanté"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RavagerHead"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RavagerHead2"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RavagerLegLeft"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RavagerClawLeft"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RavagerClawRight"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RavagerBody"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RavagerLegRight"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SEAHOE"",
		""type"": ""NPC"",
		""englishName"": ""Sea King"",
		""name"": ""Roi des mers"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Hive"",
		""type"": ""NPC"",
		""englishName"": ""Hive"",
		""name"": ""Ruche"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AureusSpawn"",
		""type"": ""NPC"",
		""englishName"": ""Aureus Spawn"",
		""name"": ""Réjeton d'Aureus"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DankCreeper"",
		""type"": ""NPC"",
		""englishName"": ""Dank Creeper"",
		""name"": ""Rôdeur Humide"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WaterLeech"",
		""type"": ""NPC"",
		""englishName"": ""Water Leech"",
		""name"": ""Sangsue d'Eau"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Twinkler"",
		""type"": ""NPC"",
		""englishName"": ""Twinkler"",
		""name"": ""Scintilleur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Cuttlefish"",
		""type"": ""NPC"",
		""englishName"": ""Cuttlefish"",
		""name"": ""Seiche"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SeaSerpent2"",
		""type"": ""NPC"",
		""englishName"": ""Sea Serpent"",
		""name"": ""Serpent de Mer"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SeaSerpent3"",
		""type"": ""NPC"",
		""englishName"": ""Sea Serpent"",
		""name"": ""Serpent de Mer"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SeaSerpent1"",
		""type"": ""NPC"",
		""englishName"": ""Sea Serpent"",
		""name"": ""Serpent de Mer"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SeaSerpent4"",
		""type"": ""NPC"",
		""englishName"": ""Sea Serpent"",
		""name"": ""Serpent de Mer"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SeaSerpent5"",
		""type"": ""NPC"",
		""englishName"": ""Sea Serpent"",
		""name"": ""Serpent de Mer"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Signus"",
		""type"": ""NPC"",
		""englishName"": ""Signus, Envoy of the Devourer"",
		""name"": ""Signus, Émissaire du Dévoreur"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProvSpawnHealer"",
		""type"": ""NPC"",
		""englishName"": ""Providence Healer"",
		""name"": ""Soigneur de Providence"",
		""state"": ""Traduit""
	},
	{
		""id"": ""OverloadedSoldier"",
		""type"": ""NPC"",
		""englishName"": ""Overloaded Soldier"",
		""name"": ""Soldat Surchargé"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Flounder"",
		""type"": ""NPC"",
		""englishName"": ""Flounder"",
		""name"": ""Sole"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralProbe"",
		""type"": ""NPC"",
		""englishName"": ""Astral Probe"",
		""name"": ""Sonde Astrale"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SuperDummyNPC"",
		""type"": ""NPC"",
		""englishName"": ""Super Dummy"",
		""name"": ""Super Mannequin"",
		""state"": ""Traduit""
	},
	{
		""id"": ""NuclearTerror"",
		""type"": ""NPC"",
		""englishName"": ""Nuclear Terror"",
		""name"": ""Terreur Nucléaire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""StormWeaverHead"",
		""type"": ""NPC"",
		""englishName"": ""Storm Weaver"",
		""name"": ""Tisse-Tempête"",
		""state"": ""Traduit""
	},
	{
		""id"": ""StormWeaverBody"",
		""type"": ""NPC"",
		""englishName"": ""Storm Weaver"",
		""name"": ""Tisse-Tempête"",
		""state"": ""Traduit""
	},
	{
		""id"": ""StormWeaverTail"",
		""type"": ""NPC"",
		""englishName"": ""Storm Weaver"",
		""name"": ""Tisse-Tempête"",
		""state"": ""Traduit""
	},
	{
		""id"": ""WulfrumRover"",
		""type"": ""NPC"",
		""englishName"": ""Wulfrum Rover"",
		""name"": ""Vadrouilleur Wulfrum"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SeaMinnow"",
		""type"": ""NPC"",
		""englishName"": ""Sea Minnow"",
		""name"": ""Vairon de Mer"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BobbitWormSegment"",
		""type"": ""NPC"",
		""englishName"": ""Bobbit Worm"",
		""name"": ""Ver Bobbit"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BobbitWormHead"",
		""type"": ""NPC"",
		""englishName"": ""Bobbit Worm"",
		""name"": ""Ver Bobbit"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodwormNormal"",
		""type"": ""NPC"",
		""englishName"": ""Bloodworm"",
		""name"": ""Ver de Sang"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodwormFleeing"",
		""type"": ""NPC"",
		""englishName"": ""Bloodworm"",
		""name"": ""Ver de Sang"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EidolonWyrmBody"",
		""type"": ""NPC"",
		""englishName"": ""Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EidolonWyrmTail"",
		""type"": ""NPC"",
		""englishName"": ""Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EidolonWyrmBodyAlt"",
		""type"": ""NPC"",
		""englishName"": ""Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EidolonWyrmHead"",
		""type"": ""NPC"",
		""englishName"": ""Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Brimling"",
		""type"": ""NPC"",
		""englishName"": ""Brimling"",
		""name"": ""soufrelin"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CosmicElemental"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Elemental"",
		""name"": ""Élementaire Cosmique"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ThiccWaifu"",
		""type"": ""NPC"",
		""englishName"": ""Cloud Elemental"",
		""name"": ""Élémentaire de Nuage"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Horse"",
		""type"": ""NPC"",
		""englishName"": ""Earth Elemental"",
		""name"": ""Élémentaire de Terre"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BrimstoneElemental"",
		""type"": ""NPC"",
		""englishName"": ""Brimstone Elemental"",
		""name"": ""Élémentaire de soufre"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DarkEnergy"",
		""type"": ""NPC"",
		""englishName"": ""Dark Energy"",
		""name"": ""Énergie Noire"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedEnergyLantern"",
		""type"": ""NPC"",
		""englishName"": ""Profaned Energy"",
		""name"": ""Énergie Profanée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedEnergyBody"",
		""type"": ""NPC"",
		""englishName"": ""Profaned Energy"",
		""name"": ""Énergie Profanée"",
		""state"": ""Traduit""
	},
	{
		""id"": ""Polterghast"",
		""type"": ""NPC"",
		""englishName"": ""Polterghast"",
		""name"": ""Épouvantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PolterPhantom"",
		""type"": ""NPC"",
		""englishName"": ""Polterghast"",
		""name"": ""Épouvantôme"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SkyOreText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The ground is glittering with cyan light."",
		""name"": """",
		""desc"": ""Le sol brille d'une lumière cyan."",
		""state"": ""Traduit""
	},
	{
		""id"": ""IceOreText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The ice caves are crackling with frigid energy."",
		""name"": """",
		""desc"": ""Les cavernes de glace crépitent d'énergie frigide."",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlantOreText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Energized plant matter has formed in the underground."",
		""name"": """",
		""desc"": ""De la matière végétale énergisée s'est formée dans les souterrains."",
		""state"": ""Traduit""
	},
	{
		""id"": ""TreeOreText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Fossilized tree bark is bursting through the jungle's mud."",
		""name"": """",
		""desc"": ""De l'écorce d'arbre fossilisée surgit de la boue de la jungle."",
		""state"": ""Traduit""
	},
	{
		""id"": ""AuricOreText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A godly aura has blessed the world's caverns."",
		""name"": """",
		""desc"": ""Une aura divine a béni les cavernes du monde."",
		""state"": ""Traduit""
	},
	{
		""id"": ""FutureOreText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A cold and dark energy has materialized in space."",
		""name"": """",
		""desc"": ""Une énergie froide et sombre s'est matérialisée dans l'espace."",
		""state"": ""Traduit""
	},
	{
		""id"": ""UglyBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The Sunken Sea trembles..."",
		""name"": """",
		""desc"": ""La Mer Ensevelie tremble..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""SteelSkullBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A blood red inferno lingers in the night..."",
		""name"": """",
		""desc"": ""Un enfer rouge sang subsiste la nuit..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""WetWormBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The sulphuric sky darkens..."",
		""name"": """",
		""desc"": ""Le ciel sulfurique s'assombrit..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlantBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The ocean depths are trembling."",
		""name"": """",
		""desc"": ""Les profondeurs de l'océan tremblent."",
		""state"": ""Traduit""
	},
	{
		""id"": ""BabyBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A plague has befallen the Jungle."",
		""name"": """",
		""desc"": ""Une peste s'est répandue dans la jungle."",
		""state"": ""Traduit""
	},
	{
		""id"": ""MoonBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The profaned flame blazes fiercely!"",
		""name"": """",
		""desc"": ""La flame profanée flamboie férocement!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MoonBossText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Cosmic terrors are watching..."",
		""name"": """",
		""desc"": ""Les terreurs cosmiques vous observent..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""PLAGUE NUKE BARRAGE ARMED, PREPARING FOR LAUNCH!!!"",
		""name"": """",
		""desc"": ""BARRAGE CHIRURGICAL DE PESTE ARMÉ, PRÉPARATION AU LANCEMENT!!!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""PlagueBossText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""MISSILES LAUNCHED, TARGETING ROUTINE INITIATED!!!"",
		""name"": """",
		""desc"": ""MISSILES LANCÉS, ROUTINE DE CIBLAGE INITIÉE!!!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The air is burning..."",
		""name"": """",
		""desc"": ""L'air s'embrase..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedBossText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Shrieks are echoing from the dungeon."",
		""name"": """",
		""desc"": ""Des hurlements font écho depuis le donjon."",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedBossText3"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The calamitous beings have been inundated with bloodstone."",
		""name"": """",
		""desc"": ""Les êtres calamiteux ont été inondés de pierre de sang."",
		""state"": ""Traduit""
	},
	{
		""id"": ""ProfanedBossText4"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The Profaned Goddess has recognised your devotion to purity!"",
		""name"": """",
		""desc"": ""La Déesse Profanée a reconnu votre dévotion à la pureté!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""GhostBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The abyssal spirits have been disturbed."",
		""name"": """",
		""desc"": ""Les esprits abyssaux ont été dérangés."",
		""state"": ""Traduit""
	},
	{
		""id"": ""GhostBossText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Wails echo through the dilapidated dungeon halls..."",
		""name"": """",
		""desc"": ""Des échos de gémissents traversent les salles dilapidés du donjon..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""GhostBossText3"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Long-dead prisoners seek their zealous revenge..."",
		""name"": """",
		""desc"": ""Des prisonniers mort depuis longtemps réclament fervemment leur vengeance..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""GhostBossText4"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The souls released stir the acidic storms..."",
		""name"": """",
		""desc"": ""Les âmes relâchées agitent les tempêtes acides..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""EdgyBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Don't get cocky, kid!"",
		""name"": """",
		""desc"": ""Reste à ta place, gamin!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EdgyBossText3"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A fatal mistake!"",
		""name"": """",
		""desc"": ""Une erreur fatale!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EdgyBossText4"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Good luck recovering from that!"",
		""name"": """",
		""desc"": ""Bonne chance pour récupérer de ça!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EdgyBossText5"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Delicious..."",
		""name"": """",
		""desc"": ""Délicieux..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""EdgyBossText6"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Did that hurt?"",
		""name"": """",
		""desc"": ""Ca t'a fait mal?"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EdgyBossText7"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Nothing personal, kid."",
		""name"": """",
		""desc"": ""Rien de personnel, gamin."",
		""state"": ""Traduit""
	},
	{
		""id"": ""EdgyBossText8"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Are you honestly that bad at dodging?"",
		""name"": """",
		""desc"": ""T'es vraiment aussi mauvais à l'esquive?"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EdgyBossText9"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Of all my segments to get hit by..."",
		""name"": """",
		""desc"": ""De toutes mes parties, tu te fais toucher par celle-la..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""EdgyBossText10"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""It's not over yet, kid!"",
		""name"": """",
		""desc"": ""C'est pas terminé, gamin!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""EdgyBossText11"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A GOD DOES NOT FEAR DEATH!"",
		""name"": """",
		""desc"": ""UN DIEU NE CRAINT PAS LA MORT!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""DoGBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The frigid moon shimmers brightly."",
		""name"": """",
		""desc"": ""La lune frigide scintille brillament."",
		""state"": ""Traduit""
	},
	{
		""id"": ""DoGBossText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The harvest moon glows eerily."",
		""name"": """",
		""desc"": ""La lune des moissons brille de manière inquiétante."",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A star has fallen from the heavens!"",
		""name"": """",
		""desc"": ""Une étoile est tombée des cieux!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AureusBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The astral enemies have been empowered!"",
		""name"": """",
		""desc"": ""Les ennemis astraux ont été renforcés!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AureusBossText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A faint ethereal click can be heard from the dungeon."",
		""name"": """",
		""desc"": ""Un discret cliquetis éthéré peut-être entendu depuis le donjon."",
		""state"": ""Traduit""
	},
	{
		""id"": ""AstralBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The seal of the stars has been broken! You can now mine Astral Ore."",
		""name"": """",
		""desc"": ""Le sceau stellaire a été brisée! Vous pouvez miner le Minerai Astral."",
		""state"": ""Traduit""
	},
	{
		""id"": ""DeusText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A star-spawned horror tunnels through the astral infection."",
		""name"": """",
		""desc"": ""Une horreur née des étoiles creusent au travers de l'infection astrale."",
		""state"": ""Traduit""
	},
	{
		""id"": ""DeusAltarRejectNightText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The god of the stars rejects your offering. The ritual can only be performed at night."",
		""name"": """",
		""desc"": ""Le dieu stellaire rejette ton offrande. Le rituel ne peut être accompli que la nuit."",
		""state"": ""Traduit""
	},
	{
		""id"": ""CalamitasBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You underestimate my power..."",
		""name"": """",
		""desc"": ""Tu sous-estimes mes pouvoirs..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""CalamitasBossText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The brothers have been reborn!"",
		""name"": """",
		""desc"": ""Les frères ont été ramenés à la vie!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CalamitasBossText3"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Impressive child, most impressive..."",
		""name"": """",
		""desc"": ""Impressionnant mon enfant, très impressionnant..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""SandSharkText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Something stirs in the warm desert sands..."",
		""name"": """",
		""desc"": ""Quelque chose s'agite dans les sables chauds du désert..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""SandSharkText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""An enormous apex predator approaches..."",
		""name"": """",
		""desc"": ""Un enorme prédateur apex s'approche..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""SandSharkText3"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The desert sand shifts intensely!"",
		""name"": """",
		""desc"": ""Le sable du désert fluctue intensément!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""CryogenBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Cryogen is derping out!"",
		""name"": """",
		""desc"": ""Cryogène part en vrille!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BloodMoonText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The Blood Moon is rising..."",
		""name"": """",
		""desc"": ""La lune sanglante se lève..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""DargonBossText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The dark sun awaits."",
		""name"": """",
		""desc"": ""Le sombresoleil attend."",
		""state"": ""Traduit""
	},
	{
		""id"": ""DargonBossText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""My dragon deems you an unworthy opponent. You must acquire the power of the dark sun to witness his true power."",
		""name"": """",
		""desc"": ""Mon dragon semble juger que tu n'es pas un adversaire digne. Tu dois acquérir le pouvoir du sombresoleil pour libérer son véritable pouvoir."",
		""state"": ""Traduit""
	},
	{
		""id"": ""RevengeText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Revengeance is active."",
		""name"": """",
		""desc"": ""La Revengeance est activée."",
		""state"": ""Traduit""
	},
	{
		""id"": ""RevengeText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Revengeance is not active."",
		""name"": """",
		""desc"": ""La Revengeance est désactivée."",
		""state"": ""Traduit""
	},
	{
		""id"": ""ArmageddonText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Bosses will now kill you instantly."",
		""name"": """",
		""desc"": ""Les boss vous tuerons en un coup."",
		""state"": ""Traduit""
	},
	{
		""id"": ""ArmageddonText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Bosses will no longer kill you instantly."",
		""name"": """",
		""desc"": ""Les boss ne vous tuerons plus en un coup."",
		""state"": ""Traduit""
	},
	{
		""id"": ""ChangingTheRules"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You cannot change the rules now."",
		""name"": """",
		""desc"": ""Tu ne peux pas changer les règles maintenant."",
		""state"": ""Traduit""
	},
	{
		""id"": ""FlameText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The air is getting warmer around you."",
		""name"": """",
		""desc"": ""L'air se réchauffe autour de toi."",
		""state"": ""Traduit""
	},
	{
		""id"": ""BossRushStartText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Hmm? Ah, another contender. Very well, may the ritual commence!"",
		""name"": """",
		""desc"": ""Hmm? Ah, un autre prétendant. Très bien, que le rituel commence!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BossRushTierOneEndText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Hmm? Oh, you're still alive. Unexpected, but don't get complacent just yet."",
		""name"": """",
		""desc"": ""Hmm? Oh, encore vivant. C'est innattendu, mais ne tombe pas déjà dans la complaisance."",
		""state"": ""Traduit""
	},
	{
		""id"": ""BossRushTierTwoEndText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Hmm? Persistent aren't you? Perhaps you have some hope of prosperity, unlike past challengers."",
		""name"": """",
		""desc"": ""Hmm? Persistant, on dirait. Peut-être que contrairement a tes prédécesseurs, il y a un peu d'espoir que tu prospères."",
		""state"": ""Traduit""
	},
	{
		""id"": ""BossRushTierThreeEndText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Hmm? Your perseverance is truly a trait to behold. You've come further than even the demigods in such a short time."",
		""name"": """",
		""desc"": ""Hmm? Ta persévérence est vraiment d'un caractère saisissant. Tu es allé plus loin que les demi dieux eux-mêmes en si peu de temps."",
		""state"": ""Traduit""
	},
	{
		""id"": ""BossRushTierThreeEndText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""May your skills remain sharp for the last challenges."",
		""name"": """",
		""desc"": ""Que tes talents restent à leur pinacle pour les dernières épreuves."",
		""state"": ""Traduit""
	},
	{
		""id"": ""BossRushTierFourEndText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Hmm? So you've made it to the final tier, a remarkable feat enviable by even the mightiest of the gods."",
		""name"": """",
		""desc"": ""Hmm? Alors tu as atteint le dernier niveau, Un fait remarquable, enviable par les plus puissants des dieux."",
		""state"": ""Traduit""
	},
	{
		""id"": ""BossRushTierFourEndText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Go forth and conquer 'til the ritual's end!"",
		""name"": """",
		""desc"": ""Va et conquiert jusqu'a la fin du rituel!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""BossRushTierFiveEndText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Hmm? You expected a reward beyond this mere pebble? Patience, the true reward will become apparent in time..."",
		""name"": """",
		""desc"": ""Hmm? Tu t'attendais à une récompense au-delà de ce simple caillou? Patience, la véritable récompense t'apparaîtra en temps voulu..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""MeleeLevelUp"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Melee weapon proficiency level up!"",
		""name"": """",
		""desc"": ""Compétence de mêlée augmentée!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MeleeLevelUpFinal"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Melee weapon proficiency maxed out!"",
		""name"": """",
		""desc"": ""Compétence de mêlée maximisée!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RangedLevelUp"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Ranged weapon proficiency level up!"",
		""name"": """",
		""desc"": ""Compétence de distance augmentée!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RangedLevelUpFinal"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Ranged weapon proficiency maxed out!"",
		""name"": """",
		""desc"": ""Compétence de distance maximisée!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MagicLevelUp"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Magic weapon proficiency level up!"",
		""name"": """",
		""desc"": ""Compétence magique augmentée!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""MagicLevelUpFinal"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Magic weapon proficiency maxed out!"",
		""name"": """",
		""desc"": ""Compétence magique maximisée!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SummonLevelUp"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Summoner weapon proficiency level up!"",
		""name"": """",
		""desc"": ""Compétence d'invocation augmentée!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""SummonLevelUpFinal"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Summoner weapon proficiency maxed out!"",
		""name"": """",
		""desc"": ""Compétence d'invocation maximisée!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RogueLevelUp"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Rogue weapon proficiency level up!"",
		""name"": """",
		""desc"": ""Compétence de voleur augmentée!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""RogueLevelUpFinal"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""Rogue weapon proficiency maxed out!"",
		""name"": """",
		""desc"": ""Compétence de voleur maximisée!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""OpenSunkenSea"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The depths of the underground desert are rumbling..."",
		""name"": """",
		""desc"": ""Les profondeurs du désert souterrain grondent..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""SandstormTrigger"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The desert wind is blowing furiously!"",
		""name"": """",
		""desc"": ""Le vent du désert souffle furieusement!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ThirdSageBlessingText"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""You have been blessed by the Third Sage!"",
		""name"": """",
		""desc"": ""Vous avez été béni par le Troisième Sage!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""ThirdSageBlessingText2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The Third Sage has rescinded its blessing..."",
		""name"": """",
		""desc"": ""Le Troisième Sage a révoqué sa bénédiction..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""AprilFools"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The LORDE is approaching..."",
		""name"": """",
		""desc"": ""Le LORDE approche..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""AprilFools2"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A boomer awaits..."",
		""name"": """",
		""desc"": ""Un Boomer attend..."",
		""state"": ""Traduit""
	},
	{
		""id"": ""AcidRainStart"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""A toxic downpour falls over the wasteland seas!"",
		""name"": """",
		""desc"": ""Un déluge toxique s'abat sur les mers dévastées!"",
		""state"": ""Traduit""
	},
	{
		""id"": ""AcidRainEnd"",
		""type"": ""TRANSLATION"",
		""englishName"": """",
		""englishDesc"": ""The sulphuric skies begin to clear..."",
		""name"": """",
		""desc"": ""Les cieux sulfuriques commencent à s'éclaircir..."",
		""state"": ""Traduit""
	}
]";
        }
    }
}
