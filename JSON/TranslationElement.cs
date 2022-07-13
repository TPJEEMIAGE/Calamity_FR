﻿using System;
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
		""id"": ""GastricBelcherBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Gastric Aberration"",
		""englishDesc"": ""The aquatic aberration will protect you"",
		""name"": ""Aberration Gastrique"",
		""desc"": ""Les abérrations aquatiques vous protégeront""
	},
	{
		""id"": ""Afflicted"",
		""type"": ""BUFF"",
		""englishName"": ""Afflicted"",
		""englishDesc"": ""Empowered by otherworldly spirits"",
		""name"": ""Affligé"",
		""desc"": ""Renforcé par les esprits d'un autre monde""
	},
	{
		""id"": ""DraconicSurgeBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Draconic Surge"",
		""englishDesc"": ""The power of a dragon courses through your veins"",
		""name"": ""Afflux Draconique"",
		""desc"": ""Le pouvoir d'un dragon circule dans vos veines""
	},
	{
		""id"": ""DraconicSurgeCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Draconic Surge Cooldown"",
		""englishDesc"": ""A mysterious force prevents the absorption of draconic energy"",
		""name"": ""Afflux Draconique (Recharge)"",
		""desc"": ""Une force mystérieuse empêche l'absorption de l'énergie draconique""
	},
	{
		""id"": ""AkatoYharonBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Akato"",
		""englishDesc"": ""Looks like you'll have to take care of it now"",
		""name"": ""Akato"",
		""desc"": ""On dirait que tu vas devoir t'en occuper maintenant""
	},
	{
		""id"": ""AlicornBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Alicorn"",
		""englishDesc"": ""You beat DoG while drunk, you are truly fabulous!"",
		""name"": ""Alicorn"",
		""desc"": ""Vous avez battu le Dévoreur de Dieux en étant ivre, vous êtes vraiment fabuleux!""
	},
	{
		""id"": ""FungalClumpBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Fungal Clump"",
		""englishDesc"": ""The fungal clump will protect you"",
		""name"": ""Amas Fongique"",
		""desc"": ""L'amas fongique vous protégera""
	},
	{
		""id"": ""PolarisBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Polaris Boost"",
		""englishDesc"": ""The Northern Star empowers your weapon"",
		""name"": ""Amélioration Polaris"",
		""desc"": ""L'étoile du nord renforce votre arme""
	},
	{
		""id"": ""EvasionScarfBoost"",
		""type"": ""BUFF"",
		""englishName"": ""Evasion Scarf Boost"",
		""englishDesc"": ""10% increased damage, 10% increased crit chance, and 15% increased melee speed"",
		""name"": ""Amélioration de l'Écharpe d'Évasion"",
		""desc"": ""+10% de dégâts, de chances de coup critique et +15% de vitesse de mêlée""
	},
	{
		""id"": ""WaterWaifu"",
		""type"": ""BUFF"",
		""englishName"": ""Anahita"",
		""englishDesc"": ""Anahita will protect you"",
		""name"": ""Anahita"",
		""desc"": ""Anahita vous protègera""
	},
	{
		""id"": ""AndromedaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Andromeda"",
		""englishDesc"": ""You're controlling a piece of history"",
		""name"": ""Andromeda"",
		""desc"": ""Vous controlez un morceau de l'histoire""
	},
	{
		""id"": ""AndromedaSmallBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Andromeda"",
		""englishDesc"": ""You're controlling a small piece of history"",
		""name"": ""Andromède"",
		""desc"": ""Vous controlez un petit morceau de l'histoire""
	},
	{
		""id"": ""DaawnlightSpiritOriginBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Archer of Lunamoon"",
		""englishDesc"": ""You have a personal spotter"",
		""name"": ""Archer de Lunamoon"",
		""desc"": ""Vous avez un guetteur personnel""
	},
	{
		""id"": ""AbyssalWeapon"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Weapon"",
		""englishDesc"": ""Melee and rogue weapons inflict abyssal flames, 5% increased movement speed"",
		""name"": ""Arme Abyssale"",
		""desc"": ""Les armes de mêlée infligent les flammes abyssales, +5% de vitesse de mouvement""
	},
	{
		""id"": ""ArmorCrunch"",
		""type"": ""BUFF"",
		""englishName"": ""Armor Crunch"",
		""englishDesc"": ""Your armor is shredded"",
		""name"": ""Armure Broyée"",
		""desc"": ""Votre armure est broyée""
	},
	{
		""id"": ""AstrophageBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Astrophage"",
		""englishDesc"": ""Little astral buggy"",
		""name"": ""Astrophage"",
		""desc"": ""Petit compagnon astral""
	},
	{
		""id"": ""ScarfMeleeBoost"",
		""type"": ""BUFF"",
		""englishName"": ""Scarf Boost"",
		""englishDesc"": ""10% increased damage, 5% increased crit chance, and 5% increased melee speed"",
		""name"": ""Augmentation d'Écharpe"",
		""desc"": ""+10% de dégâts, +5% de chances de coup critique et +5% de vitesse en mêlée""
	},
	{
		""id"": ""BloodfinBoost"",
		""type"": ""BUFF"",
		""englishName"": ""Bloodfin Boost"",
		""englishDesc"": ""Don't let the blood get to your head"",
		""name"": ""Augmentation de Nageoire de Sang"",
		""desc"": ""Ne laisse pas le sang te monter à la tête""
	},
	{
		""id"": ""ShellBoost"",
		""type"": ""BUFF"",
		""englishName"": ""Shell Speed Boost"",
		""englishDesc"": ""Speed is boosted"",
		""name"": ""Augmentation de Vitesse de Carapace"",
		""desc"": ""La vitesse est augmentée""
	},
	{
		""id"": ""PearlAura"",
		""type"": ""BUFF"",
		""englishName"": ""Pearl Aura"",
		""englishDesc"": ""Slowed down"",
		""name"": ""Aura de Perle"",
		""desc"": ""Ralenti""
	},
	{
		""id"": ""StarSwallowerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Star Swallower"",
		""englishDesc"": ""Mmmm myes"",
		""name"": ""Avaleur d'Étoiles"",
		""desc"": ""Mmmm moui""
	},
	{
		""id"": ""AvertorBonus"",
		""type"": ""BUFF"",
		""englishName"": ""Avertor Bonus"",
		""englishDesc"": ""Boosted damage and life regeneration"",
		""name"": ""Bonus d'Avertor"",
		""desc"": ""Dégâts et régénration de vie augmentés""
	},
	{
		""id"": ""AtaxiaSummonSetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Hydrothermic Vent"",
		""englishDesc"": ""The hydrothermic vent will protect you"",
		""name"": ""Aération Hydrothermique"",
		""desc"": ""L'aération hydrothermique vous protègera""
	},
	{
		""id"": ""BaguetteBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Baguette"",
		""englishDesc"": ""If only I knew... ~Cirrus"",
		""name"": ""Baguette"",
		""desc"": ""Si seulement j'avais subi... ~Cirrus""
	},
	{
		""id"": ""BanishingFire"",
		""type"": ""BUFF"",
		""englishName"": ""Banishing Fire"",
		""englishDesc"": ""You shall not be forgiven for your sins"",
		""name"": ""Feu Banisseur"",
		""desc"": ""Vous ne serez pas absous de vos péchés""
	},
	{
		""id"": ""GrapeBeerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Grape Beer"",
		""englishDesc"": ""Defense and movement speed reduced"",
		""name"": ""Bière au Raisin"",
		""desc"": ""Défense et vitesse de mouvement réduites""
	},
	{
		""id"": ""BloodyMaryBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Bloody Mary"",
		""englishDesc"": ""Damage, critical strike chance, movement speed, and melee speed boosted during a Blood Moon, life regen and defense reduced"",
		""name"": ""Bloody Mary"",
		""desc"": ""Dégâts, chances de coup critique, vitesse de déplacement et vitesse de corps à corps augmentée pendant une lune de sang, régénération de vie et défense réduite""
	},
	{
		""id"": ""InkBombCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Ink Bomb Cooldown"",
		""englishDesc"": ""Your Ink Bomb is recharging"",
		""name"": ""Bombe d'Encre (Recharge)"",
		""desc"": ""Votre bombe d'encre se recharge""
	},
	{
		""id"": ""BloodyBoost"",
		""type"": ""BUFF"",
		""englishName"": ""Bloody Boost"",
		""englishDesc"": ""Increased offensive and defensive stats\\nHealing potions grant more health"",
		""name"": ""Boost Sanguin"",
		""desc"": ""Augmente les statistiques d'attaque et de défense\\nLes potions de vie rendent plus de vie""
	},
	{
		""id"": ""GraxDefense"",
		""type"": ""BUFF"",
		""englishName"": ""Grax Boost"",
		""englishDesc"": ""Your defenses and muscles are strong"",
		""name"": ""Boost de Grax"",
		""desc"": ""Votre défense et vos muscles sont puissants !""
	},
	{
		""id"": ""IceShieldBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Ice Shield"",
		""englishDesc"": ""Absorbs 20% damage from the next hit you take, then shatters"",
		""name"": ""Bouclier de Glace"",
		""desc"": ""Absorbe 20% des dégats de la prochaine attaque, puis se brise""
	},
	{
		""id"": ""IceShieldBrokenBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Ice Shield Cooldown"",
		""englishDesc"": ""The shield is regenerating"",
		""name"": ""Bouclier de Glace (Recharge)"",
		""desc"": ""Le bouclier se recharge""
	},
	{
		""id"": ""TranquilityCandleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tranquility Candle"",
		""englishDesc"": ""Spawn rates around the candle are reduced!"",
		""name"": ""Bougie de Tranquillité"",
		""desc"": ""Le taux d'apparition des ennemis est réduit près de la bougie!""
	},
	{
		""id"": ""ChaosCandleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Chaos Candle"",
		""englishDesc"": ""Spawn rates around the candle are boosted!"",
		""name"": ""Bougie du Chaos"",
		""desc"": ""Le taux d'apparition des ennemis près de la bougie est augmenté!""
	},
	{
		""id"": ""BendyBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Dreamfog"",
		""englishDesc"": ""Xi believes in Yuu"",
		""name"": ""Brouillard de Rêve"",
		""desc"": ""Ji crois en Vuu""
	},
	{
		""id"": ""BumbledogeMount"",
		""type"": ""BUFF"",
		""englishName"": ""Bumbledoge"",
		""englishDesc"": ""Wait a second. That's not right..."",
		""name"": ""Bumbledoge"",
		""desc"": ""Attends une seconde. Y a un truc qui cloche...""
	},
	{
		""id"": ""BabyGhostBellBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Baby Ghost Bell"",
		""englishDesc"": ""Be careful not to pop the bubble"",
		""name"": ""Bébé Cloche Fantôme"",
		""desc"": ""Attention de ne pas éclater la bulle""
	},
	{
		""id"": ""PlaguebringerBabBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Plaguebringer Bab"",
		""englishDesc"": ""The baby plaguebringer sees you as the queen"",
		""name"": ""Bébé Colporte-Peste"",
		""desc"": ""Le bébé colporte-peste vous considère comme sa mère""
	},
	{
		""id"": ""StormjawBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Baby Stormlion"",
		""englishDesc"": ""The baby stormlion will protect you"",
		""name"": ""Bébé Fourmi-Tonnerre"",
		""desc"": ""Le bébé fourmi-tonnerre vous protègera""
	},
	{
		""id"": ""ScabRipperBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Baby Blood Crawler"",
		""englishDesc"": ""The baby blood crawler will protect you"",
		""name"": ""Bébé Rampant Sanglant"",
		""desc"": ""Le bébé rampant sanglant vous protègera""
	},
	{
		""id"": ""AmidiasBlessing"",
		""type"": ""BUFF"",
		""englishName"": ""Amidias' Blessing"",
		""englishDesc"": ""You are blessed by Amidias\\nLets you breathe underwater, even in the Abyss!\\nJust don't get hit..."",
		""name"": ""Bénédiction d'Amidias"",
		""desc"": ""Vous êtes béni par Amidias\\nVous permet de respirer sous l'eau, même dans les abysses!\\nEvite juste de te faire toucher...""
	},
	{
		""id"": ""SirenWaterSpeed"",
		""type"": ""BUFF"",
		""englishName"": ""Ocean's Blessing"",
		""englishDesc"": ""15% increased max speed and acceleration"",
		""name"": ""Bénédiction de l'Océan"",
		""desc"": ""+15% de vitesse et d'accélération""
	},
	{
		""id"": ""Cadence"",
		""type"": ""BUFF"",
		""englishName"": ""Cadance"",
		""englishDesc"": ""Your heart is pure"",
		""name"": ""Cadence"",
		""desc"": ""Votre coeur est pur""
	},
	{
		""id"": ""BloodClot"",
		""type"": ""BUFF"",
		""englishName"": ""Blood Clot"",
		""englishDesc"": ""The blood clot will protect you"",
		""name"": ""Caillot Sanguin"",
		""desc"": ""Le caillot sanguin vous protègera""
	},
	{
		""id"": ""Calamari"",
		""type"": ""BUFF"",
		""englishName"": ""Calamari"",
		""englishDesc"": ""The squid will protect you"",
		""name"": ""Calamari"",
		""desc"": ""Le calamar vous protègera""
	},
	{
		""id"": ""SCalPetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Supreme Calamitas"",
		""englishDesc"": ""Watching over you with supreme calamitous energy... how adorable"",
		""name"": ""Calamitas Suprême"",
		""desc"": ""Elle te surveille d'une énergie calamiteuse suprême... c'est adorable""
	},
	{
		""id"": ""CalciumBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Calcium"",
		""englishDesc"": ""You are immune to fall damage"",
		""name"": ""Calcium"",
		""desc"": ""Vous êtes immunisé aux dégâts de chute""
	},
	{
		""id"": ""SandCloakCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Sand Cloak Cooldown"",
		""englishDesc"": ""Your Sand Cloak is recharging"",
		""name"": ""Cape de Sable (Recharge)"",
		""desc"": ""Votre cape de sable se recharge""
	},
	{
		""id"": ""EnergyShellCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Energy Shell Cooldown"",
		""englishDesc"": ""Your energy shell is recharging"",
		""name"": ""Carapace d'Énergie (Recharge)"",
		""desc"": ""Votre carapace d'énergie se recharge""
	},
	{
		""id"": ""MagicHatBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Magic Hat"",
		""englishDesc"": ""The hat carries your soul, bound by a contract"",
		""name"": ""Chapeau Magique"",
		""desc"": ""Le chapeau transporte votre âme, lié par un contrat""
	},
	{
		""id"": ""DormantBrimseekerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Brimseeker"",
		""englishDesc"": ""Does it want something from you?"",
		""name"": ""Cherche-soufre"",
		""desc"": ""Il veut quelque chose de vous?""
	},
	{
		""id"": ""ChiBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Chi"",
		""englishDesc"": ""Your next attack is boosted and you are more resilient"",
		""name"": ""Chi"",
		""desc"": ""Votre prochaine attaque est renforcée et vous êtes plus résilient""
	},
	{
		""id"": ""TundraLeashBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Angry Dog"",
		""englishDesc"": ""You are riding an angry dog"",
		""name"": ""Chien en Colère"",
		""desc"": ""Vous chevauchez un chien en colère""
	},
	{
		""id"": ""Clamity"",
		""type"": ""BUFF"",
		""englishName"": ""Clamity"",
		""englishDesc"": ""The clams have been angered!"",
		""name"": ""Clamité"",
		""desc"": ""Les palourdes ont été provoquées!""
	},
	{
		""id"": ""SnapClamDebuff"",
		""type"": ""BUFF"",
		""englishName"": ""Clammed"",
		""englishDesc"": ""Clam clap"",
		""name"": ""Clammé"",
		""desc"": ""Clap de Palourde""
	},
	{
		""id"": ""IceClasper"",
		""type"": ""BUFF"",
		""englishName"": ""Ice Clasper"",
		""name"": ""Clasper de Glace"",
		""desc"": ""Le clasper de glace vous protègera""
	},
	{
		""id"": ""HowlTrio"",
		""type"": ""BUFF"",
		""englishName"": ""Howl's Heart"",
		""englishDesc"": ""Howl protects you, Calcifer lights your way, Turnip-Head stalks you"",
		""name"": ""Coeur de Howl"",
		""desc"": ""Howl vous protège, Calcifer illumine la voir et tête de navet vous traque""
	},
	{
		""id"": ""HotE"",
		""type"": ""BUFF"",
		""englishName"": ""Heart of the Elements"",
		""englishDesc"": ""All elementals will protect you"",
		""name"": ""Coeur des Éléments"",
		""desc"": ""Tous les élémentaires vous protégerons""
	},
	{
		""id"": ""XerocWrath"",
		""type"": ""BUFF"",
		""englishName"": ""Empyrean Wrath"",
		""englishDesc"": ""Wrath of the cosmos"",
		""name"": ""Colère Empyréene"",
		""desc"": ""Colère du cosmos""
	},
	{
		""id"": ""AbyssalDivingSuitBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Diving Suit"",
		""englishDesc"": ""You are made of metal"",
		""name"": ""Combinaison de Plongée Abyssale"",
		""desc"": ""Vous êtes fait de métal""
	},
	{
		""id"": ""VoidConcentrationBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Concentrated Void"",
		""englishDesc"": ""The infinite void yearns for more..."",
		""name"": ""Concentrated Void"",
		""desc"": ""Le vide infini en désire plus...""
	},
	{
		""id"": ""GlacialState"",
		""type"": ""BUFF"",
		""englishName"": ""Glacial State"",
		""englishDesc"": ""Cannot move"",
		""name"": ""Congelé"",
		""desc"": ""Vous ne pouvez pas bouger""
	},
	{
		""id"": ""BurntOut"",
		""type"": ""BUFF"",
		""englishName"": ""Burnt Out"",
		""englishDesc"": ""You've been burnt out and your guardians are less effective"",
		""name"": ""Consumé"",
		""desc"": ""Vous avez été consumé et vos gardiens sont moins efficaces""
	},
	{
		""id"": ""CorvidHarbringerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Raven"",
		""englishDesc"": ""The powerful raven will protect you"",
		""name"": ""Corbeau"",
		""desc"": ""Un puissant corbeau vous protègera""
	},
	{
		""id"": ""Corroslime"",
		""type"": ""BUFF"",
		""englishName"": ""Corroslime"",
		""englishDesc"": ""The corroslime will protect you"",
		""name"": ""Corrogelée"",
		""desc"": ""La corrogelée vous protègera""
	},
	{
		""id"": ""TeslaFreeze"",
		""type"": ""BUFF"",
		""englishName"": ""Galvanic Corrosion"",
		""englishDesc"": ""Your limbs have begun to corrode"",
		""name"": ""Corrosion Galvanique"",
		""desc"": ""Vous membres ont commencé à rouiller""
	},
	{
		""id"": ""CosmilampBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Cosmilamp"",
		""englishDesc"": ""The cosmilamp will protect you"",
		""name"": ""Cosmolampe"",
		""desc"": ""La cosmolampe vous protègera""
	},
	{
		""id"": ""DeathModeHot"",
		""type"": ""BUFF"",
		""englishName"": ""Heat Exhaustion"",
		""englishDesc"": ""The overwhelming heat weakens your bodily functions. You need to look for equipment to protect you from the heat."",
		""name"": ""Coup de Chaleur"",
		""desc"": ""La chaleur insupportable affaiblit votre corps. Vous devez chercher de l'équipement pour vous protéger de la chaleur.""
	},
	{
		""id"": ""HermitCrab"",
		""type"": ""BUFF"",
		""englishName"": ""Hermit Crab"",
		""englishDesc"": ""The hermit crab will protect you"",
		""name"": ""Crabe Hermite"",
		""desc"": ""Le crabe hermite vous protègera""
	},
	{
		""id"": ""Crimslime"",
		""type"": ""BUFF"",
		""englishName"": ""Crimslime"",
		""englishDesc"": ""The crimslime will protect you"",
		""name"": ""Crimslime"",
		""desc"": ""La Gelée Carmine vous protègera""
	},
	{
		""id"": ""SilvaSummonSetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Silva Crystal"",
		""englishDesc"": ""The crystal will protect you"",
		""name"": ""Cristal Silva"",
		""desc"": ""Le cristal vous protègera""
	},
	{
		""id"": ""DaedalusSummonSetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Daedalus Crystal"",
		""englishDesc"": ""The daedalus crystal will protect you"",
		""name"": ""Cristal de Dédale"",
		""desc"": ""Le Cristal de Dédale vous protègera""
	},
	{
		""id"": ""ShellfishBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Shellfish"",
		""englishDesc"": ""The shellfish will protect you"",
		""name"": ""Crustacé"",
		""desc"": ""Le crustacé vous protègera""
	},
	{
		""id"": ""ShellfishEating"",
		""type"": ""BUFF"",
		""englishName"": ""Shellfish Claps"",
		""englishDesc"": ""Clamfest"",
		""name"": ""Crustacé"",
		""desc"": ""La fête du crustacé""
	},
	{
		""id"": ""DaedalusGolemBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Daedalus Golem"",
		""englishDesc"": ""A crystal golem is following you"",
		""name"": ""Golem de Dédale"",
		""desc"": ""Un golem de cristal vous suit""
	},
	{
		""id"": ""DannyDevito"",
		""type"": ""BUFF"",
		""englishName"": ""Danny Devito"",
		""englishDesc"": ""The trash man is following you."",
		""name"": ""Danny Devito"",
		""desc"": ""Le responsable des poubelles vous suit.""
	},
	{
		""id"": ""DoGCartBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Devourer Cart"",
		""englishDesc"": ""Riding a cosmic terror"",
		""name"": ""Chariot Dévoreur"",
		""desc"": ""Monté dans une terreur cosmique""
	},
	{
		""id"": ""DemonshadeSetDevilBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Red Devil"",
		""englishDesc"": ""The red devil will protect you"",
		""name"": ""Diable Rouge"",
		""desc"": ""Le diable rouge vous protègera""
	},
	{
		""id"": ""Warped"",
		""type"": ""BUFF"",
		""englishName"": ""Warped"",
		""englishDesc"": ""Movement is being warped"",
		""name"": ""Distordu"",
		""desc"": ""Les mouvements sont distordus""
	},
	{
		""id"": ""TimeSlow"",
		""type"": ""BUFF"",
		""englishName"": ""Time Distortion"",
		""englishDesc"": ""Time is slowed"",
		""name"": ""Distortion Temporelle"",
		""desc"": ""Le temps est ralenti""
	},
	{
		""id"": ""DivineBless"",
		""type"": ""BUFF"",
		""englishName"": ""Divine Bless"",
		""englishDesc"": ""Increased health regen and minions inflict Banishing Fire"",
		""name"": ""Bénédiction Divine"",
		""desc"": ""Régénération de vie augmentée et les sbires infligent le feu bannissant""
	},
	{
		""id"": ""DivineBlessCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Divine Recharge"",
		""englishDesc"": ""Your divine powers are recharging"",
		""name"": ""Recharge Divine"",
		""desc"": ""Vos pouvoirs divins se rechargent""
	},
	{
		""id"": ""ColdDivinityBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Cold Divinity"",
		""englishDesc"": ""The magic of the ancient ice castle will aid you"",
		""name"": ""Divinité Froide"",
		""desc"": ""La magie de l'ancien château de glace vous aidera""
	},
	{
		""id"": ""YharonKindleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Fiery Draconid"",
		""englishDesc"": ""The fiery draconid will protect you"",
		""name"": ""Draconide Ardent"",
		""desc"": ""Le draconique ardent vous protègera""
	},
	{
		""id"": ""CausticStaffBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Caustic Dragon"",
		""englishDesc"": ""A mini jungle dragon is following you"",
		""name"": ""Dragon Caustique"",
		""desc"": ""Un dragon de la jungle miniature vous suit""
	},
	{
		""id"": ""BloodDragonsBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Skeletal Dragons"",
		""englishDesc"": ""Big happy family"",
		""name"": ""Dragons Squelette"",
		""desc"": ""Une grande et heureuse famille""
	},
	{
		""id"": ""RustyDroneBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Rusty Drone"",
		""englishDesc"": ""A pitifully fragile drone is observing you"",
		""name"": ""Drone Rouillé"",
		""desc"": ""Un drône pitoyablement fragile vous observe""
	},
	{
		""id"": ""WulfrumDroidBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Wulfrum Droid"",
		""englishDesc"": ""The wulfrum droid will protect you"",
		""name"": ""Droïde Wulfrum"",
		""desc"": ""Le droïde wulfrum vous protègera""
	},
	{
		""id"": ""FurtasticDuoBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Furtastic Duo"",
		""englishDesc"": ""They just did! The Furtastic Duo will accompany you!"",
		""name"": ""Duo Furmidable"",
		""desc"": ""Ils l'ont fait! Le duo furmidable vous accompagnera!""
	},
	{
		""id"": ""Shred"",
		""type"": ""BUFF"",
		""englishName"": ""Shred"",
		""englishDesc"": ""Someone built ten Tri-Tip Daggers..."",
		""name"": ""Déchiré"",
		""desc"": ""Quelqu'un a fabriqué 10 dagues a trois pointes...""
	},
	{
		""id"": ""HallowedRuneDefBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Hallowed Defense"",
		""englishDesc"": ""Defense boosted by 8 and damage reduction boosted by 4%"",
		""name"": ""Défense Sacrée"",
		""desc"": ""Défense augmentée de 8 et réduction des dégâts augmentée de 4%""
	},
	{
		""id"": ""SpiritGeneratorDefBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Spirit Defense"",
		""englishDesc"": ""Defense boosted by 6 and damage reduction boosted by 3%"",
		""name"": ""Défense des Esprits"",
		""desc"": ""+6 défense et réduction des dégâts augmenté de 3%""
	},
	{
		""id"": ""PoleWarperBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Pole Warper"",
		""englishDesc"": ""Sentient magnets are attracted to you"",
		""name"": ""Déformeur de Pôles"",
		""desc"": ""Vous attirez des aimants conscients""
	},
	{
		""id"": ""GodSlayerCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""God Slayer Cooldown"",
		""englishDesc"": ""God Slayer dash is recharging"",
		""name"": ""Déicide (Recharge)"",
		""desc"": ""La charge déicide se recharge""
	},
	{
		""id"": ""YellowDamageCandle"",
		""type"": ""BUFF"",
		""englishName"": ""Spite"",
		""englishDesc"": ""Its hateful glow flickers with ire"",
		""name"": ""Dépit"",
		""desc"": ""Sa lueur haïneuse chancelle d'îre""
	},
	{
		""id"": ""ChibiiBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Chibii Devourer"",
		""englishDesc"": ""What? Were you expecting someone else?"",
		""name"": ""Dévoreur Chibii"",
		""desc"": ""Quoi? Tu t'attendais à quelqu'un d'autre?""
	},
	{
		""id"": ""ProfanedCrystalBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Devotion"",
		""englishDesc"": """",
		""name"": ""Dévotion"",
		""desc"": ""L'âme profanée contenue a été corrompue par la puissante magie d'une sorcière suprême""
	},
	{
		""id"": ""TitanScale"",
		""type"": ""BUFF"",
		""englishName"": ""Titan Scale"",
		""englishDesc"": ""You feel tanky"",
		""name"": ""Ecaille de Titan"",
		""desc"": ""Vous vous sentez résistant""
	},
	{
		""id"": ""BossZen"",
		""type"": ""BUFF"",
		""englishName"": ""Boss Effects"",
		""englishDesc"": ""This tooltip is edited in the function below"",
		""name"": ""Effets de Boss"",
		""desc"": ""This tooltip is edited in the function below""
	},
	{
		""id"": ""CrimsonEffigyBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Crimson Effigy"",
		""englishDesc"": ""The crimson empowers you"",
		""name"": ""Effigie de Carmin"",
		""desc"": ""Le carmin vous renforce""
	},
	{
		""id"": ""CorruptionEffigyBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Corruption Effigy"",
		""englishDesc"": ""The corruption empowers you"",
		""name"": ""Effigie de Corruption"",
		""desc"": ""La corruption vous renforce""
	},
	{
		""id"": ""EffigyOfDecayBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Effigy of Decay"",
		""englishDesc"": ""The sulphuric waters empower you"",
		""name"": ""Effigy of Décomposition"",
		""desc"": ""Les eaux sulfuriques vous renforcent""
	},
	{
		""id"": ""ArmorCrumbling"",
		""type"": ""BUFF"",
		""englishName"": ""Armor Crumbling"",
		""englishDesc"": ""Melee and rogue attacks break enemy armor"",
		""name"": ""Effritement d'Armure"",
		""desc"": ""Les attaques de mêlée et de voleur brisent l'armure""
	},
	{
		""id"": ""SulphuricPoisoning"",
		""type"": ""BUFF"",
		""englishName"": ""Sulphuric Poisoning"",
		""englishDesc"": ""The acidic water burns away your flesh"",
		""name"": ""Empoisonnement Sulfurique"",
		""desc"": ""L'eau acide dissout votre chair""
	},
	{
		""id"": ""Encased"",
		""type"": ""BUFF"",
		""englishName"": ""Encased"",
		""englishDesc"": ""30 defense and +30% damage reduction, but..."",
		""name"": ""Encastré"",
		""desc"": ""+30 défense et +30% de réduction de dégats, mais...""
	},
	{
		""id"": ""EndoCooperBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Endo Cooper"",
		""englishDesc"": ""The ascened Cooper will protect you"",
		""name"": ""Endo Cooper"",
		""desc"": ""Le Cooper ascendé vous protègera""
	},
	{
		""id"": ""EndoHydraBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Endo Hydra"",
		""englishDesc"": ""The endo hydra will protect you... for some reason"",
		""name"": ""Endo Hydre"",
		""desc"": ""L'endo hydre vous protègera... pour une raison ou une autre""
	},
	{
		""id"": ""GodSlayerInferno"",
		""type"": ""BUFF"",
		""englishName"": ""God Slayer Inferno"",
		""englishDesc"": ""Your flesh is burning off"",
		""name"": ""Enfer Déicide"",
		""desc"": ""Votre chair brûle""
	},
	{
		""id"": ""HolyInferno"",
		""type"": ""BUFF"",
		""englishName"": ""Holy Inferno"",
		""englishDesc"": ""You've gone too far from the Profaned Goddess!"",
		""name"": ""Enfer Sacré"",
		""desc"": ""Vous vous êtes trop éloigné de la déesse profanée!""
	},
	{
		""id"": ""Enraged"",
		""type"": ""BUFF"",
		""englishName"": ""Enraged"",
		""englishDesc"": ""All damage taken is increased by 25%"",
		""name"": ""Enragé"",
		""desc"": ""Tous les dégâts subis sont augmentés de 25%""
	},
	{
		""id"": ""Soaring"",
		""type"": ""BUFF"",
		""englishName"": ""Soaring"",
		""englishDesc"": ""Increased wing flight time and speed\\nTrue melee hits restore wing flight time"",
		""name"": ""Envol"",
		""desc"": ""Temps et vitesse de vol augmentés\\nLes attaques de vraie mêlée rendent du temps de vol""
	},
	{
		""id"": ""SolarSpirit"",
		""type"": ""BUFF"",
		""englishName"": ""Solar Spirit"",
		""englishDesc"": ""The solar spirit will protect you"",
		""name"": ""Esprit Solaire"",
		""desc"": ""L'esprit solaire vous protègera""
	},
	{
		""id"": ""BelladonnaSpiritBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Belladonna Spirit"",
		""englishDesc"": ""A cute forest spirit is following you"",
		""name"": ""Esprit de Belladonne"",
		""desc"": ""Un esprit mignon de la forêt vous suit""
	},
	{
		""id"": ""SirenLightPetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Ocean Spirit"",
		""englishDesc"": ""Small and cute"",
		""name"": ""Esprit de l'Océan"",
		""desc"": ""Petit et mignon""
	},
	{
		""id"": ""SolarSpiritGod"",
		""type"": ""BUFF"",
		""englishName"": ""Solar God Spirit"",
		""englishDesc"": ""The solar god spirit will protect you"",
		""name"": ""Esprit du Dieu Soleil"",
		""desc"": ""L'esprit du dieu soleil vous protègera""
	},
	{
		""id"": ""AbyssalMirrorCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Evade Cooldown"",
		""englishDesc"": ""Your Abyssal Mirror's dodge is recharging"",
		""name"": ""Esquive Abyssale (Recharge)"",
		""desc"": ""Votre esquive abyssale se recharge""
	},
	{
		""id"": ""TarraLifeRegen"",
		""type"": ""BUFF"",
		""englishName"": ""Tarra Life"",
		""englishDesc"": ""Rapid healing"",
		""name"": ""Estra-Vie"",
		""desc"": ""Guérison rapide""
	},
	{
		""id"": ""Eutrophication"",
		""type"": ""BUFF"",
		""englishName"": ""Eutrophication"",
		""englishDesc"": ""Excessive nutrients restrict your movement"",
		""name"": ""Eutrophisation"",
		""desc"": ""L'excès de nutriment restreint vos mouvements""
	},
	{
		""id"": ""EverclearBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Everclear"",
		""englishDesc"": ""Damage boosted, life regen and defense reduced"",
		""name"": ""Everclear"",
		""desc"": ""Dégâts augmentés, régénération de vie et défense réduite""
	},
	{
		""id"": ""OnyxExcavatorBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Onyx Excavator"",
		""englishDesc"": ""Drill"",
		""name"": ""Excavateur Onyx"",
		""desc"": ""Foreuse""
	},
	{
		""id"": ""DraedonGamerChairBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Exo Chair"",
		""englishDesc"": ""Riding a physics defying gamer chair"",
		""name"": ""Exo Chaise"",
		""desc"": ""Assis sur une chaise de gamer defiant la physique""
	},
	{
		""id"": ""ExoFreeze"",
		""type"": ""BUFF"",
		""englishName"": ""Exo Freeze"",
		""englishDesc"": ""Cannot move"",
		""name"": ""Exo Gel"",
		""desc"": ""Mouvement Impossible""
	},
	{
		""id"": ""PlagueBlackoutCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Plague Blackout Cooldown"",
		""englishDesc"": ""Your plague blackout ability is recharging"",
		""name"": ""Extinction Pestiférée (Recharge)"",
		""desc"": ""Votre extinction pestiférée se recharge""
	},
	{
		""id"": ""EyeOfNightBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Eye of Night"",
		""englishDesc"": ""It eerily watches"",
		""name"": ""Oeil de Nuit"",
		""desc"": ""Il vous observe de manière inquiétante""
	},
	{
		""id"": ""FabsolVodkaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Fab"",
		""englishDesc"": ""You feel fabulous"",
		""name"": ""Fab"",
		""desc"": ""Tu te sens Fabuleux""
	},
	{
		""id"": ""WeakPetrification"",
		""type"": ""BUFF"",
		""englishName"": ""Weak Petrification"",
		""englishDesc"": ""Your vertical movement is weakened"",
		""name"": ""Faible Pétrification"",
		""desc"": ""Votre mouvement vertical est affaibli""
	},
	{
		""id"": ""ProfanedWeakness"",
		""type"": ""BUFF"",
		""englishName"": ""Profaned Weakness"",
		""englishDesc"": ""You do less damage"",
		""name"": ""Faiblesse Profanée"",
		""desc"": ""Vous faîtes moins de dégâts""
	},
	{
		""id"": ""CeaselessHunger"",
		""type"": ""BUFF"",
		""englishName"": ""Ceaseless Hunger"",
		""englishDesc"": ""You are sucking up all the items"",
		""name"": ""Faim Incessante"",
		""desc"": ""Vous attirez tous les objets""
	},
	{
		""id"": ""Phantom"",
		""type"": ""BUFF"",
		""englishName"": ""Phantom"",
		""englishDesc"": ""The phantom will protect you"",
		""name"": ""Fantôme"",
		""desc"": ""Le fantôme vous protègera""
	},
	{
		""id"": ""BlackHawkBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Black Hawk"",
		""englishDesc"": ""The fighter jet will protect you"",
		""name"": ""Faucon Noir"",
		""desc"": ""Le jet de combat vous protègera""
	},
	{
		""id"": ""RotomBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Electric Troublemaker"",
		""englishDesc"": ""Lightning never strikes the same place twice"",
		""name"": ""Fauteur de Trouble Électrique"",
		""desc"": ""La foudre ne frappe jamais deux fois au même endroit""
	},
	{
		""id"": ""WarCleave"",
		""type"": ""BUFF"",
		""englishName"": ""War Cleave"",
		""englishDesc"": ""Defense and protection reduced"",
		""name"": ""Fente de Guerre"",
		""desc"": ""Défense et protection réduite""
	},
	{
		""id"": ""LethalLavaBurn"",
		""type"": ""BUFF"",
		""englishName"": ""Dragon Fire"",
		""englishDesc"": ""Losing life, reduced movement speed"",
		""name"": ""Feu Draconique"",
		""desc"": ""Perte de vie, Vitesse de mouvement réduite""
	},
	{
		""id"": ""FireballBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Fireball"",
		""englishDesc"": ""Fire debuff damage boosted, life regen reduced"",
		""name"": ""Fireball"",
		""desc"": ""Dégâts des altérations de feu augmentés, régénération de vie réduite""
	},
	{
		""id"": ""AbyssalFlames"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Flames"",
		""englishDesc"": ""Your soul is being consumed"",
		""name"": ""Flamme abyssales"",
		""desc"": ""Votre âme se consume""
	},
	{
		""id"": ""DemonFlames"",
		""type"": ""BUFF"",
		""englishName"": ""Demon Flames"",
		""englishDesc"": ""Another burning debuff"",
		""name"": ""Flammes Démoniaques"",
		""desc"": ""Une autre brûlure""
	},
	{
		""id"": ""BrimstoneFlames"",
		""type"": ""BUFF"",
		""englishName"": ""Brimstone Flames"",
		""englishDesc"": ""Rapid health loss"",
		""name"": ""Flammes de soufre"",
		""desc"": ""Perte de vie rapide""
	},
	{
		""id"": ""HolyFlames"",
		""type"": ""BUFF"",
		""englishName"": ""Holy Flames"",
		""englishDesc"": ""Dissolving from holy light"",
		""name"": ""Flammes sacrées"",
		""desc"": ""Dissolution par les flammes sacrées""
	},
	{
		""id"": ""FleshOfInfidelityBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Flesh Ball"",
		""englishDesc"": ""Why is it following you?"",
		""name"": ""Balle de Chair"",
		""desc"": ""Pourquoi est-ce qu'elle te suit ?""
	},
	{
		""id"": ""Nightwither"",
		""type"": ""BUFF"",
		""englishName"": ""Nightwither"",
		""englishDesc"": ""Incinerated by lunar rays"",
		""name"": ""Fletrinuit"",
		""desc"": ""Incinéré par les rayons lunaires""
	},
	{
		""id"": ""CinderBlossomBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Cinder Blossom"",
		""englishDesc"": ""A hot, searing flower is floating uncomfortably close to you"",
		""name"": ""Floraison de Cendre"",
		""desc"": ""Une chaude et brûlante fleur flotte inconfortablement près de vous""
	},
	{
		""id"": ""TundraFlameBlossomsBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tundra Flame Blossom"",
		""englishDesc"": ""A perfect unison of balance and beauty"",
		""name"": ""Floraison de Feu de la Toundra"",
		""desc"": ""L'unisson parfait entre l'équilibre et la beauté""
	},
	{
		""id"": ""FlowersOfMortalityBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Flowers of Mortality"",
		""englishDesc"": ""Celestial blossoms surround you"",
		""name"": ""Fleur de Mortalité"",
		""desc"": ""Des floraisons célestes vous entourent""
	},
	{
		""id"": ""AbyssalMadness"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Madness"",
		""englishDesc"": ""Increased damage, critical strike chance, and tentacle aggression/range"",
		""name"": ""Folie Abyssale"",
		""desc"": ""Dégâts, chances de coup critique et aggression/portée des tentacules augmentés""
	},
	{
		""id"": ""AbyssalMadnessCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Madness Cooldown"",
		""englishDesc"": ""Your abyssal madness is recharging"",
		""name"": ""Folie Abyssale (Recharge)"",
		""desc"": ""Votre folie abyssale se recharge""
	},
	{
		""id"": ""ExtremeGravity"",
		""type"": ""BUFF"",
		""englishName"": ""Icarus' Folly"",
		""englishDesc"": ""Your wing time is reduced by 33%, infinite flight is disabled"",
		""name"": ""Folie d'Icare"",
		""desc"": ""Votre temps de vol est réduit de 33%, le vol infini est désactivé""
	},
	{
		""id"": ""ArmorShattering"",
		""type"": ""BUFF"",
		""englishName"": ""Armor Shattering"",
		""englishDesc"": ""Melee and rogue attacks break enemy armor"",
		""name"": ""Fracassement d'Armure"",
		""desc"": ""Les attaques de mêlée et de voleur brisent l'armure""
	},
	{
		""id"": ""HolyWrathBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Holy Wrath"",
		""englishDesc"": ""Increased damage and all attacks inflict holy fire"",
		""name"": ""Fureur Divine"",
		""desc"": ""Dégâts augmentés et toutes les attaques infligent le feu sacré""
	},
	{
		""id"": ""BrimflameFrenzyCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Brimflame Frenzy Cooldown"",
		""englishDesc"": ""Your use of brimstone magic has left you exhausted"",
		""name"": ""Fureur Flamesoufre (Recharge)"",
		""desc"": ""Votre utilisation de la magie de soufre vous a épuisé""
	},
	{
		""id"": ""BrimflameFrenzyBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Brimflame Frenzy"",
		""englishDesc"": ""Dark magic empowers your attacks at the cost of your life"",
		""name"": ""Fureur Flammesoufre"",
		""desc"": ""La magie sombre vous renforce au prix de votre vie""
	},
	{
		""id"": ""BloodflareBloodFrenzy"",
		""type"": ""BUFF"",
		""englishName"": ""Blood Frenzy"",
		""englishDesc"": ""Contact damage is reduced and melee stats are greatly increased"",
		""name"": ""Fureur de Sang"",
		""desc"": ""Les dégâts de contact sont réduits et les caractéristiques de mêlée sont grandement augmentées""
	},
	{
		""id"": ""BloodflareBloodFrenzyCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Blood Frenzy Cooldown"",
		""englishDesc"": ""Your blood frenzy is recharging"",
		""name"": ""Fureur de Sang (Recharge)"",
		""desc"": ""Votre fureur de sang se recharge""
	},
	{
		""id"": ""TyrantsFury"",
		""type"": ""BUFF"",
		""englishName"": ""Tyrant's Fury"",
		""englishDesc"": ""30% increased melee damage and 10% increased melee crit chance"",
		""name"": ""Fureur du Tyran"",
		""desc"": ""+30% de dégâts de mêlée et +10% dez chances de coup critique en mêlée""
	},
	{
		""id"": ""Molten"",
		""type"": ""BUFF"",
		""englishName"": ""Molten"",
		""englishDesc"": ""Resistant to cold effects"",
		""name"": ""Fusion"",
		""desc"": ""Résistant au froid""
	},
	{
		""id"": ""ElysianGuard"",
		""type"": ""BUFF"",
		""englishName"": ""Elysian Guard"",
		""englishDesc"": ""Movement speed reduced, other stats buffed"",
		""name"": ""Garde Élysienne"",
		""desc"": ""Vitesse de mouvement réduite, les autres statistiques sont renforcées""
	},
	{
		""id"": ""CosmicFreeze"",
		""type"": ""BUFF"",
		""englishName"": ""Cosmic Freeze"",
		""englishDesc"": ""You feel as cold as the empty expanse of outer space"",
		""name"": ""Gel Cosmique"",
		""desc"": ""Vous vous sentez froid comme l'expansion du vide de l'espace lointain""
	},
	{
		""id"": ""AstrageldonBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Astral Jelly"",
		""englishDesc"": ""The mini astrageldon slime will protect you"",
		""name"": ""Gelée Astrale"",
		""desc"": ""La gelée astrageldon miniature vous protègera""
	},
	{
		""id"": ""EvergreenGinBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Evergreen Gin"",
		""englishDesc"": ""Sickness and water debuff damage and damage reduction boosted, life regen reduced"",
		""name"": ""Gin Evergreen"",
		""desc"": ""La maladie, dégats et réduction des dégâts de l'altération d'eau augmentés et régénération de vie réduite""
	},
	{
		""id"": ""CinnamonRollBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Cinnamon Roll"",
		""englishDesc"": ""Mana regen rate and fire debuff damage boosted, defense reduced"",
		""name"": ""Goldschläger"",
		""desc"": ""Régénération du mana et dégâts de l'altération de feu augmentés, défense réduite""
	},
	{
		""id"": ""ExtremeGrav"",
		""type"": ""BUFF"",
		""englishName"": ""Extreme Gravity"",
		""englishDesc"": ""Your wing time is reduced by 25%, infinite flight is disabled"",
		""name"": ""Gravité Extrême"",
		""desc"": ""Votre temps de vol est réduit de 25%, le vol infini est désactivé""
	},
	{
		""id"": ""GravityNormalizerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Gravity Normalizer"",
		""englishDesc"": ""Gravity is now normal in space, immunity to distorted"",
		""name"": ""Gravité Normalisé"",
		""desc"": ""La gravité est maintenant normale dans l'espace. Immunité à la distortion.""
	},
	{
		""id"": ""KamiDebuff"",
		""type"": ""BUFF"",
		""englishName"": ""Kami Flu"",
		""englishDesc"": ""Defenseless and dying"",
		""name"": ""Grippe Kami"",
		""desc"": ""Sans défense et mourant""
	},
	{
		""id"": ""ElementalAxeBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Elemental Axe"",
		""englishDesc"": ""The elemental axe will protect you"",
		""name"": ""Hache des Éléments"",
		""desc"": ""La hache des éléments vous protègera""
	},
	{
		""id"": ""AndromedaCripple"",
		""type"": ""BUFF"",
		""englishName"": ""Andromeda Cripple"",
		""englishDesc"": ""You're slow"",
		""name"": ""Handicap d'Andromède"",
		""desc"": ""Vous êtes lent""
	},
	{
		""id"": ""Herring"",
		""type"": ""BUFF"",
		""englishName"": ""Herring"",
		""englishDesc"": ""The herring will protect you"",
		""name"": ""Harang"",
		""desc"": ""Le harang vous protègera""
	},
	{
		""id"": ""SquishyBeanBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Squishy Bean"",
		""englishDesc"": ""BEAN MAN. BEAN DO T H E  B EA N IS HER E"",
		""name"": ""Haricot Spongieux"",
		""desc"": ""HARICOT MAN. HARICOT FAIT L E  HAR ICO T EST L A""
	},
	{
		""id"": ""FlakPetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Flak Hermit"",
		""englishDesc"": ""Little acid buggy"",
		""name"": ""Hermite Flak"",
		""desc"": ""Petit insecte acide""
	},
	{
		""id"": ""GammaHeadBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Gamma Hydra"",
		""englishDesc"": ""..."",
		""name"": ""Hydre Gamma"",
		""desc"": ""...""
	},
	{
		""id"": ""IceClasperBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Ice Clasper"",
		""englishDesc"": ""The ice clasper will protect you"",
		""name"": ""Claspeur de Glace"",
		""desc"": ""Le claspeur de glace vous protègera""
	},
	{
		""id"": ""SilvaStun"",
		""type"": ""BUFF"",
		""englishName"": ""Silva Stun"",
		""englishDesc"": ""Can't move"",
		""name"": ""Immobilité Silva"",
		""desc"": ""Vous ne pouvez pas bouger""
	},
	{
		""id"": ""SilvaRevival"",
		""type"": ""BUFF"",
		""englishName"": ""Silva Immunity"",
		""englishDesc"": ""You are unkillable and immune to most debuffs"",
		""name"": ""Immunité Sylva"",
		""desc"": ""Vous êtes immortel et immunisé à la plupart des débuffs""
	},
	{
		""id"": ""TarragonImmunity"",
		""type"": ""BUFF"",
		""englishName"": ""Tarragon Immunity"",
		""englishDesc"": ""You are immune"",
		""name"": ""Immunité d'Estragon"",
		""desc"": ""Vous êtes invulnérable""
	},
	{
		""id"": ""TarragonImmunityCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Tarragon Immunity Cooldown"",
		""englishDesc"": ""Your immunity is recharging"",
		""name"": ""Immunité d'Estragon (Recharge)"",
		""desc"": ""Votre immunité se recharge""
	},
	{
		""id"": ""AstralInfectionDebuff"",
		""type"": ""BUFF"",
		""englishName"": ""Astral Infection"",
		""englishDesc"": ""Your flesh is melting off"",
		""name"": ""Infection Astrale"",
		""desc"": ""Votre chair fond""
	},
	{
		""id"": ""AstralInjectionBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Astral Injection"",
		""englishDesc"": ""Extreme mana recovery"",
		""name"": ""Injection Astrale"",
		""desc"": ""Récupération de mana extrême""
	},
	{
		""id"": ""KamiBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Kami Injection"",
		""englishDesc"": ""Increased max movement speed, acceleration and damage"",
		""name"": ""Injection Kami"",
		""desc"": ""Augmentation des dégâts et de la vitesse d'accélération et de mouvement maximale""
	},
	{
		""id"": ""AlcoholPoisoning"",
		""type"": ""BUFF"",
		""englishName"": ""Alcohol Poisoning"",
		""englishDesc"": ""You drank too much and you are now dying"",
		""name"": ""Intoxication alcoolique"",
		""desc"": ""Tu as trop bu et maintenant tu es mourant""
	},
	{
		""id"": ""Invincible"",
		""type"": ""BUFF"",
		""englishName"": ""Invincible"",
		""englishDesc"": ""Immune to damage and most debuffs"",
		""name"": ""Invincible"",
		""desc"": ""Immunisé aux dégâts et à la plupart des altérations d'état""
	},
	{
		""id"": ""Irradiated"",
		""type"": ""BUFF"",
		""englishName"": ""Irradiated"",
		""englishDesc"": ""Your skin is burning off"",
		""name"": ""Irradié"",
		""desc"": ""Votre peau se détache""
	},
	{
		""id"": ""Kendra"",
		""type"": ""BUFF"",
		""englishName"": ""Kendra"",
		""englishDesc"": ""A loyal friend accompanies you."",
		""name"": ""Kendra"",
		""desc"": ""Un ami fidèle vous accompagne""
	},
	{
		""id"": ""ProfanedBabs"",
		""type"": ""BUFF"",
		""englishName"": ""The Profaned Soul"",
		""englishDesc"": ""The healer will heal your wounds!"",
		""name"": ""L'Âme Profanée"",
		""desc"": ""Le soigneur guérira vos blessures!""
	},
	{
		""id"": ""IgneousExaltationBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Igneous Blade"",
		""englishDesc"": ""A blade is orbiting you"",
		""name"": ""Lame Ignée"",
		""desc"": ""Une lame orbite autour de vous""
	},
	{
		""id"": ""CragsLava"",
		""type"": ""BUFF"",
		""englishName"": ""Searing Lava"",
		""englishDesc"": ""The brimstone lava sears your flesh"",
		""name"": ""Lave Brûlante"",
		""desc"": ""La lave de soufre brûle votre peau""
	},
	{
		""id"": ""LadBuff"",
		""type"": ""BUFF"",
		""englishName"": ""The Father"",
		""englishDesc"": ""A father of many floats around you"",
		""name"": ""Le Père"",
		""desc"": ""Le père d'une multitude flotte autour de vous""
	},
	{
		""id"": ""LeviBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Levi"",
		""englishDesc"": ""Small and cute"",
		""name"": ""Levi"",
		""desc"": ""Petit et Mignon""
	},
	{
		""id"": ""BloodBound"",
		""type"": ""BUFF"",
		""englishName"": ""Blood Bound"",
		""englishDesc"": ""You must be desperate for company"",
		""name"": ""Lien de Sang"",
		""desc"": ""Vous devez vraiment être désespéré""
	},
	{
		""id"": ""LittleLightBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Little Light"",
		""englishDesc"": ""Endearing"",
		""name"": ""Petite Lumière"",
		""desc"": ""Attachant""
	},
	{
		""id"": ""VulnerabilityHex"",
		""type"": ""BUFF"",
		""englishName"": ""Vulnerability Hex"",
		""englishDesc"": ""You are weak"",
		""name"": ""Malédiction de Vulnérabilité"",
		""desc"": ""Vous êtes faible""
	},
	{
		""id"": ""ManaBurn"",
		""type"": ""BUFF"",
		""englishName"": ""Mana Burn"",
		""englishDesc"": ""The excess of mana sears your body and mind"",
		""name"": ""Brûlure de Mana"",
		""desc"": ""L'excès de mana brûle votre corps et votre esprit""
	},
	{
		""id"": ""MargaritaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Margarita"",
		""englishDesc"": ""Reduced duration to most debuffs, defense and life regen reduced"",
		""name"": ""Margarita"",
		""desc"": ""Réduit la durée de la plupart des altérations d'état, défense et régénération de vie réduite""
	},
	{
		""id"": ""MarkedforDeath"",
		""type"": ""BUFF"",
		""englishName"": ""Marked"",
		""englishDesc"": ""Damage reduction reduced"",
		""name"": ""Marqué"",
		""desc"": ""Réduction de dégâts réduite""
	},
	{
		""id"": ""FuelCellBundleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Mini Plaguebringer"",
		""englishDesc"": ""A small plague bee is following you"",
		""name"": ""Mini Colporte-Peste"",
		""desc"": ""Une petite abeille de peste vous suit.""
	},
	{
		""id"": ""StatigelSummonSetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Baby Slime God"",
		""englishDesc"": ""The slime god will protect you"",
		""name"": ""Mini Dieu des Gelées"",
		""desc"": ""Le Dieu des Gelées vous protègera""
	},
	{
		""id"": ""HiveMindPet"",
		""type"": ""BUFF"",
		""englishName"": ""Mini Mind"",
		""englishDesc"": ""It knows everything"",
		""name"": ""Mini Mind"",
		""desc"": ""It knows everything TOTRANSLATE""
	},
	{
		""id"": ""MutatedTruffleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Mini Old Duke"",
		""englishDesc"": ""The young duke will protect you"",
		""name"": ""Mini Vieux Duc"",
		""desc"": ""Le jeune duc vous protègera""
	},
	{
		""id"": ""DeathstareBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Miniature Eye of Cthulhu"",
		""englishDesc"": ""It's watching you"",
		""name"": ""Oeil de Cthulu Miniature"",
		""desc"": ""Il vous regarde""
	},
	{
		""id"": ""AdrenalineMode"",
		""type"": ""BUFF"",
		""englishName"": ""Adrenaline Mode"",
		""englishDesc"": ""200% damage boost. Can be boosted by other items up to 245%."",
		""name"": ""Mode Adrenaline"",
		""desc"": ""+200% de dégâts. Peut être augmenté jusqu'a 245% grace à d'autres objets.""
	},
	{
		""id"": ""BrimstoneMount"",
		""type"": ""BUFF"",
		""englishName"": ""Brimrose Mount"",
		""englishDesc"": ""The seat is toasty.  That is all"",
		""name"": ""Monture de soufrerose"",
		""desc"": ""Le siège est chaud.  C'est tout""
	},
	{
		""id"": ""MoonshineBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Moonshine"",
		""englishDesc"": ""Defense and damage reduction boosted, life regen reduced"",
		""name"": ""Moonshine"",
		""desc"": ""Défense et réduction des dégâts augmentées, régénération de vie réduite""
	},
	{
		""id"": ""WhisperingDeath"",
		""type"": ""BUFF"",
		""englishName"": ""Whispering Death"",
		""englishDesc"": ""Death approaches; movement speed, attack power and life regen reduced"",
		""name"": ""Mort Susurrante"",
		""desc"": ""La mort approche; vitesse de mouvement, puissance d'attaque et régénération de vie réduite""
	},
	{
		""id"": ""TacticalPlagueEngineBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tactical Plague Engine"",
		""englishDesc"": ""A giant plague jet is following you"",
		""name"": ""Moteur Tactique de Peste"",
		""desc"": ""Un jet géant de peste vous suit""
	},
	{
		""id"": ""Mushy"",
		""type"": ""BUFF"",
		""englishName"": ""Mushy"",
		""englishDesc"": ""Increased defense and life regen"",
		""name"": ""Mousseux"",
		""desc"": ""Défense et régénération de vie augmentée""
	},
	{
		""id"": ""MoscowMuleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Moscow Mule"",
		""englishDesc"": ""Damage, critical strike chance, and knockback boosted, life regen reduced"",
		""name"": ""Mule de Moscou"",
		""desc"": ""Dégâts, chances de coup critique et recul augmentés, régénération de vie réduite""
	},
	{
		""id"": ""Mechworm"",
		""type"": ""BUFF"",
		""englishName"": ""Mechworm"",
		""englishDesc"": ""The mechworm will protect you"",
		""name"": ""Mécaver"",
		""desc"": ""Le Mécaver vous protègera""
	},
	{
		""id"": ""MidnightSunBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Midnight Sun UFO"",
		""englishDesc"": ""A strange UFO is observing you, and it's making you very uncomfortable"",
		""name"": ""OVNI du Soleil de Minuit"",
		""desc"": ""Un étrange OVNI vous observe, et ça vous gène énormément""
	},
	{
		""id"": ""Shadowflame"",
		""type"": ""BUFF"",
		""englishName"": ""Shadowflame"",
		""englishDesc"": ""Losing life"",
		""name"": ""Ombreflamme"",
		""desc"": ""Votre vie diminue""
	},
	{
		""id"": ""Omniscience"",
		""type"": ""BUFF"",
		""englishName"": ""Omniscience"",
		""englishDesc"": ""You can see everything"",
		""name"": ""Omniscience"",
		""desc"": ""Vous pouvez tout voir""
	},
	{
		""id"": ""ReaverSummonSetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Reaver Orb"",
		""englishDesc"": ""The reaver orb will protect you"",
		""name"": ""Orbe de Saccageur"",
		""desc"": ""L'orbe de Saccageur vous protègera""
	},
	{
		""id"": ""BearBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Bear"",
		""englishDesc"": ""A guardian angel is following you."",
		""name"": ""Ours"",
		""desc"": ""Un ange gardien vous suit.""
	},
	{
		""id"": ""VictideSummonSetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Urchin"",
		""englishDesc"": ""The urchin will protect you"",
		""name"": ""Oursin"",
		""desc"": ""L'oursin vous protègera""
	},
	{
		""id"": ""ResurrectionButterflyBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Resurrection Butterfly"",
		""englishDesc"": ""Sleep beneath the Cherry Blossoms, Red-White Butterfly"",
		""name"": ""Papillon de Résurrection"",
		""desc"": ""Dors sous les fleurs de cerisier, papillon blanc-rouge""
	},
	{
		""id"": ""SulphurskinBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Sulphurskin"",
		""englishDesc"": ""The sulphuric waters have a lesser effect on you"",
		""name"": ""Peau Sulfurique"",
		""desc"": ""Les eaux sulfuriques ont moins d'effet sur vous""
	},
	{
		""id"": ""PerditionBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Perdition"",
		""englishDesc"": ""How unfortunate"",
		""name"": ""Perdition"",
		""desc"": ""C'est malencontreux""
	},
	{
		""id"": ""Plague"",
		""type"": ""BUFF"",
		""englishName"": ""Plague"",
		""englishDesc"": ""Rotting from the inside"",
		""name"": ""Peste"",
		""desc"": ""Vous pourrissez de l'intérieur""
	},
	{
		""id"": ""StaffOfNecrosteocytesBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Small Skeleton"",
		""englishDesc"": ""A skeleton is observing you"",
		""name"": ""Petit Squelette"",
		""desc"": ""Un petit squelette vous observe""
	},
	{
		""id"": ""PhantomicEmpowermentBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Phantomic Empowerment"",
		""englishDesc"": ""Empowering minion damage by 10%"",
		""name"": ""Renforcement Fantômatique"",
		""desc"": ""Augmente les dégâts des sbires de 10%""
	},
	{
		""id"": ""PhantomicRestorationBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Phantomic Regen"",
		""englishDesc"": ""Regenerating life"",
		""name"": ""Régénération Fantômatique"",
		""desc"": ""Régénère de la vie""
	},
	{
		""id"": ""PhantomicArmourBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Phantomic Shield"",
		""englishDesc"": ""Defense boosted by 10 and damage reduction boosted by 5%\\nAn ephemeral bulwark protects you"",
		""name"": ""Bouclier Fantômatique"",
		""desc"": ""Défense augmentée de 10 et réduction de dégâts augmentée de 5%\\nUn rempant ephémère vous protège""
	},
	{
		""id"": ""PhotosynthesisBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Photosynthesis"",
		""englishDesc"": ""Life regen boosted, more during daytime, and hearts heal more HP"",
		""name"": ""Photosynthèse"",
		""desc"": ""Régénération de vie augmentée, plus encore la journée, et les coeurs rendent plus de vie""
	},
	{
		""id"": ""PineappleBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Pineapple"",
		""englishDesc"": ""It smells like pizza..."",
		""name"": ""Ananas"",
		""desc"": ""Ca sens la pizza...""
	},
	{
		""id"": ""PlantationBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Plantation"",
		""englishDesc"": ""The miniature plantera will protect you"",
		""name"": ""Plantation"",
		""desc"": ""Une Plantera miniature vous protègera""
	},
	{
		""id"": ""AbyssalDivingSuitPlatesBroken"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Diving Suit Plates Broken"",
		""englishDesc"": ""The plates are regenerating"",
		""name"": ""Plaques Abyssales Brisées"",
		""desc"": ""Les plaques se rechargent""
	},
	{
		""id"": ""AbyssalDivingSuitPlates"",
		""type"": ""BUFF"",
		""englishName"": ""Abyssal Diving Suit Plates"",
		""englishDesc"": ""The plates will absorb 15% damage"",
		""name"": ""Plaques de la Combinaison Abyssale"",
		""desc"": ""Les plaques absorberons 15% des dégâts""
	},
	{
		""id"": ""HauntedDishesBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Haunted Dishes"",
		""englishDesc"": ""The haunted dishes will protect you"",
		""name"": ""Plâts Hantés"",
		""desc"": ""Les plâts hantés vous protégerons""
	},
	{
		""id"": ""DazzlingStabberBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Dazzling Stabber"",
		""englishDesc"": ""En garde"",
		""name"": ""Poignard Éblouissant"",
		""desc"": ""En garde""
	},
	{
		""id"": ""FishAlert"",
		""type"": ""BUFF"",
		""englishName"": ""Fish Alert"",
		""englishDesc"": ""The abyssal creatures have spotted you!"",
		""name"": ""Poissons Alertés"",
		""desc"": ""Les créatures abyssales vous ont repérés!""
	},
	{
		""id"": ""PopoBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Popo"",
		""englishDesc"": ""You are a snowman now!"",
		""name"": ""Popo"",
		""desc"": ""Tu es un bonhomme de neige maintenant!""
	},
	{
		""id"": ""PopoNoselessBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Noseless Popo"",
		""englishDesc"": ""Your nose has been stolen!"",
		""name"": ""Popo sans nez"",
		""desc"": ""On t'as volé ton nez!""
	},
	{
		""id"": ""RadiantResolutionBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Saros Possession"",
		""englishDesc"": ""A radiant aura protects you"",
		""name"": ""Possession de Saros"",
		""desc"": ""Une aura radieuse vous protège""
	},
	{
		""id"": ""FrozenLungs"",
		""type"": ""BUFF"",
		""englishName"": ""Frozen Lungs"",
		""englishDesc"": ""The icy waters restrict your breathing"",
		""name"": ""Poumons Gelés"",
		""desc"": ""Les eaux glacées restraignent votre respiration""
	},
	{
		""id"": ""HallowedRuneAtkBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Hallowed Power"",
		""englishDesc"": ""Minion damage boosted by 10%"",
		""name"": ""Pouvoir Sacré"",
		""desc"": ""Dégâts des sbires augmentés de 10%""
	},
	{
		""id"": ""YharimPower"",
		""type"": ""BUFF"",
		""englishName"": ""Yharim's Power"",
		""englishDesc"": ""You feel like you can break the world in two... with your bare hands!"",
		""name"": ""Pouvoir de Yharim"",
		""desc"": ""Tu te sens comme si tu pouvais casser le monde en deux... a mains nues!""
	},
	{
		""id"": ""SpiritGeneratorAtkBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Spirit Power"",
		""englishDesc"": ""Minion damage boosted by 10%"",
		""name"": ""Pouvoir de l'Esprit"",
		""desc"": ""+10% de dégats des sbires""
	},
	{
		""id"": ""PlaguebringerSummonBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Lil' Plaguebringer"",
		""englishDesc"": ""The plaguebringer will protect you"",
		""name"": ""Ptit Colporte-Peste"",
		""desc"": ""Le colporte-peste te protègera""
	},
	{
		""id"": ""PenumbraBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Penumbra"",
		""englishDesc"": ""Stealth regenerates 15% faster while moving\\nAt night, stealth additionally regenerates 15% faster while standing still\\nBoth boosts increase to 20% during a solar eclipse"",
		""name"": ""Pénombre"",
		""desc"": ""La furtivité se régénère 15% plus vite quand vous bougez\\nLa nuit, +15% de génération de furtivité si vous êtes immobile\\nLes deux bonus sont portés à 20% lors d'une éclipse""
	},
	{
		""id"": ""RadiatorBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Radiator"",
		""englishDesc"": ""Radioactive but adorable"",
		""name"": ""Radiateur Radioactif"",
		""desc"": ""Radioactif mais adorable""
	},
	{
		""id"": ""AbsoluteRage"",
		""type"": ""BUFF"",
		""englishName"": ""Absolute Rage"",
		""englishDesc"": ""Anger hardens the heart. Boosts max life by 5%."",
		""name"": ""Rage Absolue"",
		""desc"": ""La colère renforce le coeur. Augmente la vie maximum de 5%.""
	},
	{
		""id"": ""XerocRage"",
		""type"": ""BUFF"",
		""englishName"": ""Empyrean Rage"",
		""englishDesc"": ""Rage of the cosmos"",
		""name"": ""Rage Empyréene"",
		""desc"": ""Rage du Cosmos""
	},
	{
		""id"": ""RageMode"",
		""type"": ""BUFF"",
		""englishName"": ""Rage Mode"",
		""englishDesc"": ""35% damage boost."",
		""name"": ""Rage Mode"",
		""desc"": ""+35% de dégâts.""
	},
	{
		""id"": ""ProfanedRageBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Profaned Rage"",
		""englishDesc"": ""Increased critical strike chance"",
		""name"": ""Rage Profanée"",
		""desc"": ""Chances de coup critique augmentées""
	},
	{
		""id"": ""ReaverRage"",
		""type"": ""BUFF"",
		""englishName"": ""Reaver Rage"",
		""englishDesc"": ""You are angry"",
		""name"": ""Rage du Saccageur"",
		""desc"": ""Vous êtes en colère""
	},
	{
		""id"": ""DankCreeperBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Dank Creeper"",
		""englishDesc"": ""The dank creeper will protect you"",
		""name"": ""Rampant Humide"",
		""desc"": ""Le rampant humide vous protègera""
	},
	{
		""id"": ""RancorBurn"",
		""type"": ""BUFF"",
		""englishName"": ""Rancor Burn"",
		""englishDesc"": ""Burning"",
		""name"": ""Brûlure de Rancoeur"",
		""desc"": ""Vous brûlez""
	},
	{
		""id"": ""ReaverOrbBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Reaver Orb"",
		""englishDesc"": ""The reaver orb will light your way"",
		""name"": ""Orbe de Saccage"",
		""desc"": ""L'orbe de saccage éclairera votre voie""
	},
	{
		""id"": ""BoundingBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Bounding"",
		""englishDesc"": ""Increased jump height, jump speed, and fall damage resistance"",
		""name"": ""Rebondissant"",
		""desc"": ""Hauteur de saut, vitesse de saut et résistance aux dégâts de chute augmentés""
	},
	{
		""id"": ""PrismaticCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Prismatic Cooldown"",
		""englishDesc"": ""Your laser attack is recharging"",
		""name"": ""Recharge Prismatique"",
		""desc"": ""Votre attaque laser se recharge""
	},
	{
		""id"": ""ScarfCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Scarf Cooldown"",
		""englishDesc"": ""Your dodge is recharging"",
		""name"": ""Recharge d'Écharpe"",
		""desc"": ""Votre esquive se recharge""
	},
	{
		""id"": ""ConcoctionCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Concoction Cooldown"",
		""englishDesc"": ""Revive is recharging"",
		""name"": ""Recharge de Concoction"",
		""desc"": ""La revitalisation se recharge""
	},
	{
		""id"": ""GazeOfCrysthamyrBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Gaze of Crysthamyr"",
		""englishDesc"": ""You are riding a shadow dragon"",
		""name"": ""Regard de Crysthamyr"",
		""desc"": ""Vous chevauchez un ombredragon""
	},
	{
		""id"": ""Fox"",
		""type"": ""BUFF"",
		""englishName"": ""Fox Pet"",
		""englishDesc"": ""Fox Pet? FOX PET"",
		""name"": ""Renard Apprivoisé"",
		""desc"": ""Un renard apprivoisé? UN RENARD APPRIVOISÉ""
	},
	{
		""id"": ""ApexSharkBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Ancient Mineral Shark"",
		""englishDesc"": ""Ancient yet so dangerous"",
		""name"": ""Requin Minéral Ancien"",
		""desc"": ""Si ancien, et pourtant si dangereux...""
	},
	{
		""id"": ""Revivify"",
		""type"": ""BUFF"",
		""englishName"": ""Revivify"",
		""englishDesc"": ""You are healed by a fraction of the damage you take"",
		""name"": ""Revivifié"",
		""desc"": ""Vous êtes soigné d'une fraction des dégâts que vous subissez""
	},
	{
		""id"": ""AnechoicCoatingBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Anechoic Coating"",
		""englishDesc"": ""Abyssal creatures' detection radius reduced"",
		""name"": ""Revêtement Anechoïque"",
		""desc"": ""Rayon de détection des créatures des abysses réduit""
	},
	{
		""id"": ""RumBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Rum"",
		""englishDesc"": ""Movement speed and life regen boosted, defense reduced"",
		""name"": ""Rhum"",
		""desc"": ""Vitesse de mouvement et régénération de vie augmentées, défense réduite""
	},
	{
		""id"": ""CaribbeanRumBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Caribbean Rum"",
		""englishDesc"": ""Life regen, movement speed, and wing flight time boosted, you are floaty and defense is reduced"",
		""name"": ""Rhum des Caraïbes"",
		""desc"": ""Régénération de vie, vitesse de déplacement et temps de vol augmentés, vous êtes flottant et votre défense est réduite""
	},
	{
		""id"": ""HallowedRuneRegenBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Hallowed Regen"",
		""englishDesc"": ""Regenerating life"",
		""name"": ""Régénération Sacrée"",
		""desc"": ""Votre vie se régénére""
	},
	{
		""id"": ""SpiritGeneratorRegenBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Spirit Regen"",
		""englishDesc"": ""Regenerating life"",
		""name"": ""Régénération Spirituelle"",
		""desc"": ""Vous régénérez de la vie""
	},
	{
		""id"": ""PurpleDefenseCandle"",
		""type"": ""BUFF"",
		""englishName"": ""Resilience"",
		""englishDesc"": ""Neither rain nor wind can snuff its undying flame"",
		""name"": ""Résilience"",
		""desc"": ""Ni la pluie, ni le vent ne peut souffler sa flamme immortelle""
	},
	{
		""id"": ""ResilienceCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Resilience Cooldown"",
		""englishDesc"": ""You cannot re-summon a relic of resilience"",
		""name"": ""Résilience (Recharge)"",
		""desc"": ""Vous ne pouvez pas ré-invoquer une relique de résilience""
	},
	{
		""id"": ""Sandnado"",
		""type"": ""BUFF"",
		""englishName"": ""Sandnado"",
		""englishDesc"": ""The sandnado will protect you"",
		""name"": ""Sablenade"",
		""desc"": ""La sablenade te protègera""
	},
	{
		""id"": ""SagePoison"",
		""type"": ""BUFF"",
		""englishName"": ""Sage Poison"",
		""englishDesc"": ""Poisoned"",
		""name"": ""Poison de Sauge"",
		""desc"": ""Empoisonné""
	},
	{
		""id"": ""SageSpiritBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Sage Spirit"",
		""englishDesc"": ""It's uncomfortably close"",
		""name"": ""Esprit de Sauge"",
		""desc"": ""Il est un peu trop près""
	},
	{
		""id"": ""HeavyBleeding"",
		""type"": ""BUFF"",
		""englishName"": ""Heavy Bleeding"",
		""englishDesc"": ""You're losing a lot of blood"",
		""name"": ""Saignement Lourd"",
		""desc"": ""Vous perdez beaucoup de sang""
	},
	{
		""id"": ""BurningBlood"",
		""type"": ""BUFF"",
		""englishName"": ""Burning Blood"",
		""englishDesc"": ""Your blood is on fire"",
		""name"": ""Sang Bouillonnant"",
		""desc"": ""Votre sang est en ébullition""
	},
	{
		""id"": ""MountedScannerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Mounted Scanner"",
		""englishDesc"": ""Powerful machinery surrounds you"",
		""name"": ""Scanner Monté"",
		""desc"": ""Une machinerie puissante vous entoure""
	},
	{
		""id"": ""ScrewdriverBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Screwdriver"",
		""englishDesc"": ""Piercing projectile damage boosted, life regen reduced"",
		""name"": ""Screwdriver"",
		""desc"": ""Dégâts des projectiles percants augmentés, régénération de vie réduite""
	},
	{
		""id"": ""SepulcherMinionBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Sepulcher"",
		""englishDesc"": ""It is not benevolent"",
		""name"": ""Sépulcre"",
		""desc"": ""Il n'est pas bienveillant""
	},
	{
		""id"": ""ShadowBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Shadow"",
		""englishDesc"": ""You're invisible, certain rogue weapons give and gain buffs, and stealth generation is boosted."",
		""name"": ""Ombre"",
		""desc"": ""Vous êtes invisible, certaines armes de voleurs sont améliorées et vous renforcent, et la génération de furtivité est augmentée.""
	},
	{
		""id"": ""SiriusBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Sirius"",
		""englishDesc"": ""A bit too bright, but it helps you"",
		""name"": ""Sirius"",
		""desc"": ""Un peu trop brillante, mais cela vous aide""
	},
	{
		""id"": ""YharonSonBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Son of Yharon"",
		""englishDesc"": ""You better not eat his dinner"",
		""name"": ""Fils de Yharon"",
		""desc"": ""T'as intêret à pas manger son diner""
	},
	{
		""id"": ""AstralProbeBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Astral Probe"",
		""englishDesc"": ""The astral probe will protect you"",
		""name"": ""Sonde Astrale"",
		""desc"": ""La sonde astrale vous protègera""
	},
	{
		""id"": ""BrimlingBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Brimling"",
		""englishDesc"": ""Protect her or suffer in agony"",
		""name"": ""Soufrelin"",
		""desc"": ""Protège la ou souffre dans l'agonie""
	},
	{
		""id"": ""SoulSeekerBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Soul Seeker"",
		""englishDesc"": ""It definitely wants something from you"",
		""name"": ""Cherche-Âme"",
		""desc"": ""Il veut définitivement quelque chose de vous""
	},
	{
		""id"": ""BlueSpeedCandle"",
		""type"": ""BUFF"",
		""englishName"": ""Limber"",
		""englishDesc"": ""The floating flame seems to uplift your very spirit"",
		""name"": ""Souplesse"",
		""desc"": ""La flamme flottante semble soulever jusqu'à votre esprit""
	},
	{
		""id"": ""SparksBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Sparks"",
		""englishDesc"": ""Eats butterflies"",
		""name"": ""Sparks"",
		""desc"": ""Manges les papillions""
	},
	{
		""id"": ""StarBeamRyeBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Star Beam Rye"",
		""englishDesc"": ""Max mana and magic damage increased. Defense, mana usage, and life regen reduced"",
		""name"": ""Star Beam Rye"",
		""desc"": ""Mana maximum et dégâts magiques augmentés. Défense, coût en mana et régénération de vie réduites""
	},
	{
		""id"": ""DeathModeCold"",
		""type"": ""BUFF"",
		""englishName"": ""Freezing Weather"",
		""englishDesc"": ""The weather slows your movement as you freeze to death. You need to look for equipment to protect you from the cold."",
		""name"": ""Temps Glacial"",
		""desc"": ""Le temps ralentira vos mouvements et vous gèlera jusqu'a votre mort. Vous devez chercher de l'equipement pour vous protéger du froid.""
	},
	{
		""id"": ""TequilaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tequila"",
		""englishDesc"": ""Damage, critical strike chance, damage reduction, defense, and knockback boosted during daytime, life regen reduced"",
		""name"": ""Tequila"",
		""desc"": ""Dégâts, chances de coup critique, réduction des dégâts, défense et recul augmentés la journée, régénération de vie réduite""
	},
	{
		""id"": ""TequilaSunriseBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tequila Sunrise"",
		""englishDesc"": ""Damage, critical strike chance, damage reduction, defense, and knockback boosted during daytime, life regen reduced"",
		""name"": ""Tequila Sunrise"",
		""desc"": ""Dégâts, chances de coup critique, réduction des dégâts, défense et recul augmenté durant la journée, régénération de vie réduite""
	},
	{
		""id"": ""FleshTotemCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Flesh Totem Cooldown"",
		""englishDesc"": ""The Flesh Totem effect is recharging"",
		""name"": ""Totem de Chair (Recharge)"",
		""desc"": ""L'effet du totem de chair se recharge""
	},
	{
		""id"": ""TriumphBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Triumph"",
		""englishDesc"": ""Enemy contact damage is reduced, the lower their health the greater the reduction"",
		""name"": ""Triomphe"",
		""desc"": ""Les dégâts de contact des ennemis sont réduits, plus leur vie est faible, plus la réduction est grande""
	},
	{
		""id"": ""Trippy"",
		""type"": ""BUFF"",
		""englishName"": ""Trippy"",
		""englishDesc"": ""You see the world for what it truly is... and you also have a 50% increase to all damage"",
		""name"": ""Trippant"",
		""desc"": ""Vous voyez le monde pour ce qu'il est vraiment... et vous avez aussi +50% à tous vos dégâts""
	},
	{
		""id"": ""TemporalSadness"",
		""type"": ""BUFF"",
		""englishName"": ""Temporal Sadness"",
		""englishDesc"": ""You are crying"",
		""name"": ""Tristesse Temporaire"",
		""desc"": ""Vous pleurez""
	},
	{
		""id"": ""ThirdSageBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Third Sage"",
		""englishDesc"": ""Eh? No way it's an oni."",
		""name"": ""Troisième Sage"",
		""desc"": ""Hein? Aucune chance que ce soit un oni.""
	},
	{
		""id"": ""UniverseSplitterCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Universe Splitter Cooldown"",
		""englishDesc"": ""You cannot use the Universe Splitter"",
		""name"": ""Recharge du Séparateur d'Univers"",
		""desc"": ""Vous ne pouvez pas utiliser le séparateur d'univers""
	},
	{
		""id"": ""AerospecSummonSetBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Valkyrie"",
		""englishDesc"": ""The valkyrie will protect you"",
		""name"": ""Valkyrie"",
		""desc"": ""La Valkyrie vous protège""
	},
	{
		""id"": ""Vaporfied"",
		""type"": ""BUFF"",
		""englishName"": ""Vaporfied"",
		""englishDesc"": ""Vape"",
		""name"": ""Vapoté"",
		""desc"": ""Vapote""
	},
	{
		""id"": ""PinkHealthCandle"",
		""type"": ""BUFF"",
		""englishName"": ""Vigor"",
		""englishDesc"": ""Its brilliant light suffuses those nearby with hope"",
		""name"": ""Vigueur"",
		""desc"": ""Sa lueur brilliante imprègne d'espoir ceux qui sont proches""
	},
	{
		""id"": ""VileFeederBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Vile Feeder"",
		""englishDesc"": ""The baby eater of souls will protect you"",
		""name"": ""Vil Dévoreur"",
		""desc"": ""Le bébé dévoreur d'âmes vous protègera""
	},
	{
		""id"": ""WhiteWineBuff"",
		""type"": ""BUFF"",
		""englishName"": ""White Wine"",
		""englishDesc"": ""Magic damage boosted, life regen and defense reduced"",
		""name"": ""Vin Blanc"",
		""desc"": ""Dégâts magiques augmentés, régénération de vie et défense réduite""
	},
	{
		""id"": ""RedWineBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Red Wine"",
		""englishDesc"": ""Life regen reduced"",
		""name"": ""Vin Rouge"",
		""desc"": ""Régénération de vie réduite""
	},
	{
		""id"": ""CosmicViperEngineBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Cosmic Viper"",
		""englishDesc"": ""The cosmic gunship will protect you"",
		""name"": ""Vipère Cosmique"",
		""desc"": ""Le vaisseau de combat cosmique vous protègera""
	},
	{
		""id"": ""ViridVanguardBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Virid Vanguard"",
		""englishDesc"": ""A perfect act of unity surrounds you"",
		""name"": ""Avant-Garde Viride"",
		""desc"": ""Une parfaite unisson vous entoure""
	},
	{
		""id"": ""PlaguePrincessBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Virili"",
		""englishDesc"": ""It’s a shame you can’t hug her"",
		""name"": ""Virili"",
		""desc"": ""C'est dommage que vous ne puissiez pas l'enlacer""
	},
	{
		""id"": ""VodkaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Vodka"",
		""englishDesc"": ""Damage and critical stike chance boosted, defense and life regen reduced"",
		""name"": ""Vodka"",
		""desc"": ""Dégâts et chances de coup critique augmentés, défense et régénération de vie réduites""
	},
	{
		""id"": ""TarragonCloak"",
		""type"": ""BUFF"",
		""englishName"": ""Tarragon Cloak"",
		""englishDesc"": ""Contact damage is reduced"",
		""name"": ""Voile d'Estragon"",
		""desc"": ""Les dégâts de contact sont réduits""
	},
	{
		""id"": ""TarragonCloakCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Tarragon Cloak Cooldown"",
		""englishDesc"": ""Your cloak is recharging"",
		""name"": ""Voile d'Estragon (Recharge)"",
		""desc"": ""Votre voile se recharge""
	},
	{
		""id"": ""WeakBrimstoneFlames"",
		""type"": ""BUFF"",
		""englishName"": ""Weak Brimstone Flames"",
		""englishDesc"": ""Health loss"",
		""name"": ""Faible Brûlure Soufrée"",
		""desc"": ""Perte de vie""
	},
	{
		""id"": ""WhiskeyBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Whiskey"",
		""englishDesc"": ""Damage, critical strike chance, and knockback boosted, defense reduced"",
		""name"": ""Whisky"",
		""desc"": ""Dégâts, chances de coup critique et recul augmentés, défense réduite""
	},
	{
		""id"": ""WitherDebuff"",
		""type"": ""BUFF"",
		""englishName"": ""Wither"",
		""englishDesc"": ""Withered...\\nDefense reduced by 20"",
		""name"": ""Flétrissement"",
		""desc"": ""Flétri...\\nDéfense reduite de 20""
	},
	{
		""id"": ""WitherBlossomsBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Wither Blossoms"",
		""englishDesc"": ""Pestilence surrounds you"",
		""name"": ""Floraisons Flétries"",
		""desc"": ""La pestilence vous entoure""
	},
	{
		""id"": ""Withered"",
		""type"": ""BUFF"",
		""englishName"": ""Withered"",
		""englishDesc"": ""Holding withered weapons causes you to suffer but makes your weapons strong"",
		""name"": ""Flétri"",
		""desc"": ""Tenir des armes flétries vous fait souffrir mais renforce vous armes""
	},
	{
		""id"": ""CalamitasEyes"",
		""type"": ""BUFF"",
		""englishName"": ""Blighted Eyes"",
		""englishDesc"": ""Calamitas and her brothers will protect you"",
		""name"": ""Yeux Troubles"",
		""desc"": ""Calamitas et ses frères vous protégerons""
	},
	{
		""id"": ""SnakeEyesBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Snake Eyes"",
		""englishDesc"": ""Always watching..."",
		""name"": ""Yeux de Serpent"",
		""desc"": ""Toujours à l'affut...""
	},
	{
		""id"": ""Zen"",
		""type"": ""BUFF"",
		""englishName"": ""Zen"",
		""englishDesc"": ""Spawn rates are reduced"",
		""name"": ""Zen"",
		""desc"": ""Le taux d'apparition des ennemis est réduit""
	},
	{
		""id"": ""Zerg"",
		""type"": ""BUFF"",
		""englishName"": ""Zerg"",
		""englishDesc"": ""Spawn rates are boosted"",
		""name"": ""Zerg"",
		""desc"": ""Le taux d'apparition des ennemis est augmenté""
	},
	{
		""id"": ""BloodflareSoulCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Bloodflare Soul Cooldown"",
		""englishDesc"": ""Your souls are recharging"",
		""name"": ""Âme Brûlesang (Recharge)"",
		""desc"": ""Votre âme se recharge""
	},
	{
		""id"": ""EvasionScarfCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Evasion Scarf Cooldown"",
		""englishDesc"": ""Your dodge is recharging"",
		""name"": ""Écharpe d'Évasion (Recharge)"",
		""desc"": ""Votre esquive se recharge""
	},
	{
		""id"": ""FrostBlossomBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Frost Blossom"",
		""englishDesc"": ""A cold, prickly flower is floating uncomfortably close to you"",
		""name"": ""Éclosion de Givre"",
		""desc"": ""Une froide, épineuse fleur flotte un peu trop près de vous""
	},
	{
		""id"": ""CrushDepth"",
		""type"": ""BUFF"",
		""englishName"": ""Crush Depth"",
		""englishDesc"": ""Aquatic pressure"",
		""name"": ""Écrasement des Profondeurs"",
		""desc"": ""Pression aquatique""
	},
	{
		""id"": ""SquirrelSquireBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Squirrel Squire"",
		""englishDesc"": ""The squirrel squire will protect you"",
		""name"": ""Écureuil Écuyer"",
		""desc"": ""L'écureuil écuyer vous protègera""
	},
	{
		""id"": ""TeslaBuff"",
		""type"": ""BUFF"",
		""englishName"": ""Tesla's Electricity"",
		""englishDesc"": ""Summons an aura of electricity"",
		""name"": ""Électricité de Tesla"",
		""desc"": ""Invoque une aura d'électricité""
	},
	{
		""id"": ""SirenBobs"",
		""type"": ""BUFF"",
		""englishName"": ""Water Elemental"",
		""englishDesc"": ""You are a water elemental now"",
		""name"": ""Élémentaire d'Eau"",
		""desc"": ""Tu es un élémentaire d'eau maintenant""
	},
	{
		""id"": ""CloudyWaifu"",
		""type"": ""BUFF"",
		""englishName"": ""Cloud Elemental"",
		""englishDesc"": ""The cloud elemental will protect you"",
		""name"": ""Élémentaire de Nuage"",
		""desc"": ""L'élémentaire de nuage vous protègera""
	},
	{
		""id"": ""SandyWaifu"",
		""type"": ""BUFF"",
		""englishName"": ""Sand Elemental"",
		""englishDesc"": ""The sand elemental will protect you"",
		""name"": ""Élémentaire de Sable"",
		""desc"": ""L'élémentaire de sable te protègera""
	},
	{
		""id"": ""SandyHealingWaifu"",
		""type"": ""BUFF"",
		""englishName"": ""Rare Sand Elemental"",
		""englishDesc"": ""The sand elemental will heal you"",
		""name"": ""Élémentaire de Sable Précieux"",
		""desc"": ""L'élémentaire de sable vous soignera""
	},
	{
		""id"": ""BrimstoneWaifu"",
		""type"": ""BUFF"",
		""englishName"": ""Brimstone Elemental"",
		""englishDesc"": ""The brimstone elemental will protect you"",
		""name"": ""Élémentaire de soufre"",
		""desc"": ""L'élémentaire du soufre vous protègera""
	},
	{
		""id"": ""CosmicEnergy"",
		""type"": ""BUFF"",
		""englishName"": ""Cosmic Energy"",
		""englishDesc"": ""The cosmic energy will protect you"",
		""name"": ""Énergie Cosmique"",
		""desc"": ""L'énergie cosmique vous protègera""
	},
	{
		""id"": ""GladiatorSwords"",
		""type"": ""BUFF"",
		""englishName"": ""Gladiator Swords"",
		""englishDesc"": ""The gladiator swords will protect you"",
		""name"": ""Épées de Gladiateur"",
		""desc"": ""Les épées de gladiateur vous protègerons""
	},
	{
		""id"": ""AquaticStar"",
		""type"": ""BUFF"",
		""englishName"": ""Aquatic Star"",
		""englishDesc"": ""The aquatic star will protect you"",
		""name"": ""Étoile Aquatique"",
		""desc"": ""L'étoile aquatique vous protège""
	},
	{
		""id"": ""BrittleStar"",
		""type"": ""BUFF"",
		""englishName"": ""Brittle Star"",
		""englishDesc"": ""The brittle star will protect you"",
		""name"": ""Étoile Fragile"",
		""desc"": ""L'étoile fragile vous protègera""
	},
	{
		""id"": ""EclipseMirrorCooldown"",
		""type"": ""BUFF"",
		""englishName"": ""Eclipse Evade Cooldown"",
		""englishDesc"": ""Your Eclipse Mirror's dodge is recharging"",
		""name"": ""Évasion d'Éclipse (Recharge)"",
		""desc"": ""L'esquive de votre miroir d'éclipse se recharge""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ParaseaBanner"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Parasea""
		],
		""name"": ""Bannière de Paramer"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Paramer""
		]
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
		]
	},
	{
		""id"": ""DiamondCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Bannière du Rampant de Diamant"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Diamond Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Rampant de Diamant""
		]
	},
	{
		""id"": ""TrilobiteBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Trilobite Banner"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Trilobite""
		],
		""name"": ""Bannière du Rampant de Diamant"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Trilobite""
		]
	},
	{
		""id"": ""AquaticUrchinBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Urchin""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Urchin""
		]
	},
	{
		""id"": ""PhantomSpiritBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Phantom Spirit""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Phantom Spirit""
		]
	},
	{
		""id"": ""LuminousCorvinaBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Luminous Corvina""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Luminous Corvina""
		]
	},
	{
		""id"": ""AstralSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astral Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astral Slime""
		]
	},
	{
		""id"": ""EbonianBlightSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ebonian Blight Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ebonian Blight Slime""
		]
	},
	{
		""id"": ""ShockstormShuttleBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Shockstorm Shuttle""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Shockstorm Shuttle""
		]
	},
	{
		""id"": ""AtlasBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Atlas Banner""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Atlas Banner""
		]
	},
	{
		""id"": ""WulfrumRoverBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Rover""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Rover""
		]
	},
	{
		""id"": ""ScryllarBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Scryllar""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Scryllar""
		]
	},
	{
		""id"": ""IrradiatedSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Irradiated Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Irradiated Slime""
		]
	},
	{
		""id"": ""OarfishBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Oarfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Oarfish""
		]
	},
	{
		""id"": ""BelchingCoralBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Belching Coral""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Belching Coral""
		]
	},
	{
		""id"": ""CrystalCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Crystal Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Crystal Crawler""
		]
	},
	{
		""id"": ""SandTortoiseBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}SandTortoiseBanner""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}SandTortoiseBanner""
		]
	},
	{
		""id"": ""BlightedEyeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Blighted Eye""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Blighted Eye""
		]
	},
	{
		""id"": ""PlagueChargerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plague Charger""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plague Charger""
		]
	},
	{
		""id"": ""FearlessGoldfishWarriorBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Fearless Goldfish Warrior""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Fearless Goldfish Warrior""
		]
	},
	{
		""id"": ""SeaUrchinBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Urchin""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Urchin""
		]
	},
	{
		""id"": ""ClamBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Clam""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Clam""
		]
	},
	{
		""id"": ""WulfrumSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""A decorative banner themed after an extinct slime species""
		],
		""name"": """",
		""tooltip"": [
			""A decorative banner themed after an extinct slime species""
		]
	},
	{
		""id"": ""NuclearToadBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Nuclear Toad""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Nuclear Toad""
		]
	},
	{
		""id"": ""DespairStoneBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Despair Stone""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Despair Stone""
		]
	},
	{
		""id"": ""AquaticSeekerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Seeker""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Seeker""
		]
	},
	{
		""id"": ""ViperfishBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Viperfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Viperfish""
		]
	},
	{
		""id"": ""ArmoredDiggerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Armored Digger""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Armored Digger""
		]
	},
	{
		""id"": ""ExoSink"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""Counts as a water, honey, and lava source""
		],
		""name"": """",
		""tooltip"": [
			""Counts as a water, honey, and lava source""
		]
	},
	{
		""id"": ""FlakCrabBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Flak Crab""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Flak Crab""
		]
	},
	{
		""id"": ""ImpiousImmolatorBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Impious Immolator""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Impious Immolator""
		]
	},
	{
		""id"": ""ToxicMinnowBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Toxic Minnow""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Toxic Minnow""
		]
	},
	{
		""id"": ""CrimulanBlightSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Crimulan Blight Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Crimulan Blight Slime""
		]
	},
	{
		""id"": ""AcidEelBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Acid Eel""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Acid Eel""
		]
	},
	{
		""id"": ""AstralProbeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astral Probe""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astral Probe""
		]
	},
	{
		""id"": ""TopazCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Topaz Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Topaz Crawler""
		]
	},
	{
		""id"": ""CryonBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cryon""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cryon""
		]
	},
	{
		""id"": ""MorayEelBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Moray Eel""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Moray Eel""
		]
	},
	{
		""id"": ""StormlionBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Stormlion""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Stormlion""
		]
	},
	{
		""id"": ""AngryDogBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Angry Dog""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Angry Dog""
		]
	},
	{
		""id"": ""AeroSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aero Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aero Slime""
		]
	},
	{
		""id"": ""GiantSquidBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Giant Squid""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Giant Squid""
		]
	},
	{
		""id"": ""PiggyBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Piggy""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Piggy""
		]
	},
	{
		""id"": ""LaserfishBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Laserfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Laserfish""
		]
	},
	{
		""id"": ""MantisShrimpBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mantis Shrimp""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mantis Shrimp""
		]
	},
	{
		""id"": ""GulperEelBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gulper Eel""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gulper Eel""
		]
	},
	{
		""id"": ""SoulSlurperBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Soul Slurper""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Soul Slurper""
		]
	},
	{
		""id"": ""BlindedAnglerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Blinded Angler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Blinded Angler""
		]
	},
	{
		""id"": ""EidolistBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Eidolist""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Eidolist""
		]
	},
	{
		""id"": ""MelterBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Melter""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Melter""
		]
	},
	{
		""id"": ""ScornEaterBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Scorn Eater""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Scorn Eater""
		]
	},
	{
		""id"": ""BobbitWormBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bobbit Worm""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bobbit Worm""
		]
	},
	{
		""id"": ""PlaguebringerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plaguebringer""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plaguebringer""
		]
	},
	{
		""id"": ""EutrophicRayBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Eutrophic Ray""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Eutrophic Ray""
		]
	},
	{
		""id"": ""WaterLeechBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Water Leech""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Water Leech""
		]
	},
	{
		""id"": ""AstralachneaBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astralachnea""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Astralachnea""
		]
	},
	{
		""id"": ""PlagueshellBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plagueshell""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Plagueshell""
		]
	},
	{
		""id"": ""FlounderBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Flounder""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Flounder""
		]
	},
	{
		""id"": ""OrthoceraBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Orthocera""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Orthocera""
		]
	},
	{
		""id"": ""SunskaterBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sunskater""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sunskater""
		]
	},
	{
		""id"": ""MirageJellyBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mirage Jelly""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mirage Jelly""
		]
	},
	{
		""id"": ""CultistAssassinBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cultist Assassin""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cultist Assassin""
		]
	},
	{
		""id"": ""CharredSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Charred Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Charred Slime""
		]
	},
	{
		""id"": ""MantisBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mantis""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mantis""
		]
	},
	{
		""id"": ""SeaMinnowBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Minnow""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Minnow""
		]
	},
	{
		""id"": ""RadiatorBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Radiator""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Radiator""
		]
	},
	{
		""id"": ""PestilentSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Pestilent Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Pestilent Slime""
		]
	},
	{
		""id"": ""SmallSightseerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Small Sightseer""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Small Sightseer""
		]
	},
	{
		""id"": ""CloudElementalBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cloud Elemental""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cloud Elemental""
		]
	},
	{
		""id"": ""SeaFloatyBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Floaty""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Floaty""
		]
	},
	{
		""id"": ""StellarCulexBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Stellar Culex""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Stellar Culex""
		]
	},
	{
		""id"": ""BigSightseerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Big Sightseer""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Big Sightseer""
		]
	},
	{
		""id"": ""GreatSandSharkBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Great Sand Shark""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Great Sand Shark""
		]
	},
	{
		""id"": ""AmethystCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus} Amethyst Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus} Amethyst Crawler""
		]
	},
	{
		""id"": ""TrasherBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Trasher""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Trasher""
		]
	},
	{
		""id"": ""HiveBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Hive""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Hive""
		]
	},
	{
		""id"": ""WulfrumGyratorBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Gyrator""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Gyrator""
		]
	},
	{
		""id"": ""ReaperSharkBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Reaper Shark""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Reaper Shark""
		]
	},
	{
		""id"": ""BloatfishBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bloatfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bloatfish""
		]
	},
	{
		""id"": ""VirulingBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Viruling""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Viruling""
		]
	},
	{
		""id"": ""SunBatBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sun Bat""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sun Bat""
		]
	},
	{
		""id"": ""ProfanedEnergyBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Profaned Energy""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Profaned Energy""
		]
	},
	{
		""id"": ""CalamityEyeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Calamity Eye""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Calamity Eye""
		]
	},
	{
		""id"": ""GammaSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gamma Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gamma Slime""
		]
	},
	{
		""id"": ""CatfishBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Catfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Catfish""
		]
	},
	{
		""id"": ""CryoSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cryo Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cryo Slime""
		]
	},
	{
		""id"": ""AquaticAberrationBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Aberration""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Aberration""
		]
	},
	{
		""id"": ""CosmicElementalBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cosmic Elemental""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cosmic Elemental""
		]
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
		]
	},
	{
		""id"": ""EarthElementalBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Earth Elemental""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Earth Elemental""
		]
	},
	{
		""id"": ""CnidrionBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cnidrion""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cnidrion""
		]
	},
	{
		""id"": ""BoxJellyfishBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Box Jellyfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Box Jellyfish""
		]
	},
	{
		""id"": ""EmeraldCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Emerald Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Emerald Crawler""
		]
	},
	{
		""id"": ""GnasherBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gnasher""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Gnasher""
		]
	},
	{
		""id"": ""AriesBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aries""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aries""
		]
	},
	{
		""id"": ""ChaoticPufferBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Chaotic Puffer""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Chaotic Puffer""
		]
	},
	{
		""id"": ""WulfrumDroneBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Drone""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Drone""
		]
	},
	{
		""id"": ""WulfrumHovercraftBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Hovercraft""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Hovercraft""
		]
	},
	{
		""id"": ""ColossalSquidBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Colossal Squid""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Colossal Squid""
		]
	},
	{
		""id"": ""FrogfishBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Frogfish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Frogfish""
		]
	},
	{
		""id"": ""SapphireCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sapphire Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sapphire Crawler""
		]
	},
	{
		""id"": ""MaulerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mauler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Mauler""
		]
	},
	{
		""id"": ""AnthozoanCrabBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Anthozoan Crab""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Anthozoan Crab""
		]
	},
	{
		""id"": ""OverloadedSoldierBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Overloaded Soldier""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Overloaded Soldier""
		]
	},
	{
		""id"": ""FusionFeederBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Fusion Feeder""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Fusion Feeder""
		]
	},
	{
		""id"": ""NovaBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Nova""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Nova""
		]
	},
	{
		""id"": ""EidolonWyrmJuvenileBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Juvenile Eidolon Wyrm""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Juvenile Eidolon Wyrm""
		]
	},
	{
		""id"": ""WulfrumPylonBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Pylon""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Wulfrum Pylon""
		]
	},
	{
		""id"": ""IceClasperBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ice Clasper""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ice Clasper""
		]
	},
	{
		""id"": ""PerennialSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Perennial Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Perennial Slime""
		]
	},
	{
		""id"": ""HeatSpiritBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Heat Spirit""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Heat Spirit""
		]
	},
	{
		""id"": ""PhantomDebrisBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Phantom Debris""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Phantom Debris""
		]
	},
	{
		""id"": ""RubyCrawlerBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ruby Crawler""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Ruby Crawler""
		]
	},
	{
		""id"": ""SeaSerpentBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Serpent""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sea Serpent""
		]
	},
	{
		""id"": ""GiantClamBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Giant Clam""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Giant Clam""
		]
	},
	{
		""id"": ""SkyfinBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Skyfin""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Skyfin""
		]
	},
	{
		""id"": ""CuttlefishBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cuttlefish""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Cuttlefish""
		]
	},
	{
		""id"": ""AquaticParasiteBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Parasite""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Aquatic Parasite""
		]
	},
	{
		""id"": ""BloomSlimeBanner"",
		""type"": ""ITEM"",
		""englishName"": "" TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bloom Slime""
		],
		""name"": """",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bloom Slime""
		]
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
		]
	},
	{
		""id"": ""PlaguedPlateBasin"",
		""type"": ""ITEM"",
		""englishName"": ""Broken Plagued 'Bed'"",
		""name"": ""'Lit' Pestiféré Cassé""
	},
	{
		""id"": ""Abaddon"",
		""type"": ""ITEM"",
		""englishName"": ""Abaddon"",
		""englishTooltip"": [
			""Reduces the damage caused by the Brimstone Flames debuff and provides immunity to Searing Lava""
		],
		""name"": ""Abaddon"",
		""tooltip"": [
			""Réduit les dégâts infligés par les brûlures de soufre et immunise contre la lave brûlante""
		]
	},
	{
		""id"": ""Abomination"",
		""type"": ""ITEM"",
		""englishName"": ""Abombination"",
		""englishTooltip"": [
			""Calls in the airborne abomination"",
			""Summons the Plaguebringer Goliath when used in the jungle"",
			""Not consumable""
		],
		""name"": ""Abombination"",
		""tooltip"": [
			""Appelle l'abomination aérienne"",
			""Invoque le Goliath Colporte-Peste quand utilisé dans la jungle"",
			""Non consommable""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AerialiteDye"",
		""type"": ""ITEM"",
		""englishName"": ""Aerialite Dye"",
		""name"": ""Teinture d'Aerialite""
	},
	{
		""id"": ""Aeries"",
		""type"": ""ITEM"",
		""englishName"": ""Aeries"",
		""englishTooltip"": [
			""Converts musket balls into shockblast rounds that steal enemy life""
		],
		""name"": ""Aeries"",
		""tooltip"": [
			""Convertit les balles de mousquet en balles explo-électriques qui volent la vie des ennemis""
		]
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
		]
	},
	{
		""id"": ""LaboratoryDisplayItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Display"",
		""name"": ""Affichage de Laboratoire""
	},
	{
		""id"": ""Affliction"",
		""type"": ""ITEM"",
		""englishName"": ""Affliction"",
		""englishTooltip"": [
			""Gives you and all other players on your team +1 life regen,"",
			""+10% max life, 7% damage reduction, 13 defense, and 10% increased damage""
		],
		""name"": ""Affliction"",
		""tooltip"": [
			""Donne à vous et à votre équipe +1 régénération de vie,"",
			""+10% de vie maximum, 7% de réduction des dégâts, 13 défense, et 10% de dégâts supplémentaires""
		]
	},
	{
		""id"": ""AstralClay"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Clay"",
		""name"": ""Agile Astrale""
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
		]
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
		]
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
			""Flight time: 120"",
			""10% increased movement and jump speed while wearing the Astral Armor""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""XerocWings"",
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
		""name"": ""Ailes d'Exode"",
		""tooltip"": [
			""Bat d'une pulsation venue d'ailleurs"",
			""Vitesse Horizontale: 9"",
			""Multiplicateur d'accélération: 2.5"",
			""Bonne vitesse verticale"",
			""Temps de vol: 180"",
			""+5% de dégâts et de chance de critique de voleur si vous portez l'armure Empyréene""
		]
	},
	{
		""id"": ""SkylineWings"",
		""type"": ""ITEM"",
		""englishName"": ""Skyline Wings"",
		""englishTooltip"": [
			""Horizontal speed: 6.25"",
			""Acceleration multiplier: 1.0"",
			""Average vertical speed"",
			""Flight time: 80"",
			""10% increased jump speed while wearing the Aerospec armor""
		],
		""name"": ""Ailes d'Horizon"",
		""tooltip"": [
			""Vitesse Horizontale: 6.25"",
			""Multiplicateur d'accélération: 1"",
			""Average vitesse verticale"",
			""Temps de vol: 80"",
			""+10% de vitesse de saut quand vous portez l'armure Aérospec""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BarofLife"",
		""type"": ""ITEM"",
		""englishName"": ""Life Alloy"",
		""name"": ""Alliage Vital""
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
		]
	},
	{
		""id"": ""SCalAltarItem"",
		""type"": ""ITEM"",
		""englishName"": ""Altar of the Accursed"",
		""englishTooltip"": [
			""Offer Ashes of Calamity at this altar to summon the Witch"",
			""Doing so will create a square arena of blocks, with the altar at its center"",
			""During the battle, heart pickups only heal for half as much""
		],
		""name"": ""Autel des Maudits"",
		""tooltip"": [
			""Offrez les Cendres de Calamité a cet autel pour invoquer la Sorcière"",
			""Le faire créera une arène carrée faites de blocs, avec l'autel en son centre"",
			""Pendant le combat, les coeurs vous soignent pour moitié moins""
		]
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
		]
	},
	{
		""id"": ""MonolithCrafting"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": ""Amalgame Monolithique"",
		""tooltip"": [
			""Utilisé pour l'artisanat spécial""
		]
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
		]
	},
	{
		""id"": ""ExodiumClusterOre"",
		""type"": ""ITEM"",
		""englishName"": ""Exodium Cluster"",
		""englishTooltip"": [
			""A cold cluster from the great unknown.""
		],
		""name"": ""Amas d'Exodium"",
		""tooltip"": [
			""Un âmas froid provenant du grand inconnu.""
		]
	},
	{
		""id"": ""MeldBlob"",
		""type"": ""ITEM"",
		""englishName"": ""Meld Blob"",
		""name"": ""Amas de Fusion""
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
		]
	},
	{
		""id"": ""AmbrosialAmpoule"",
		""type"": ""ITEM"",
		""englishName"": ""Ambrosial Ampoule"",
		""englishTooltip"": [
			""You emit light"",
			""7% increased damage reduction and increased life regen"",
			""Freeze, chill and frostburn immunity""
		],
		""name"": ""Ampoule d'ambrosie"",
		""tooltip"": [
			""YVous émettez de la lumière"",
			""7% de réduction des dégâts et régénération de vie augmentée"",
			""Immunité au gel, au froid et au brûlegivre""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PsychoticAmulet"",
		""type"": ""ITEM"",
		""englishName"": ""Psychotic Amulet"",
		""englishTooltip"": [
			""Boosts rogue and ranged damage and critical strike chance by 5%"",
			""Grants a massive boost to these stats if you aren't moving""
		],
		""name"": ""Amulette Psychotique"",
		""tooltip"": [
			""Augmente les dégâts et les chances de coup critique de voleur de 5%"",
			""Donne une amélioration massive de ces statistiques si vous ne bougez pas""
		]
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
		]
	},
	{
		""id"": ""ChaosAmulet"",
		""type"": ""ITEM"",
		""englishName"": ""Spelunker's Amulet"",
		""englishTooltip"": [
			""Spelunker effect and 15% increased mining speed""
		],
		""name"": ""Amulette du Spéléologue"",
		""tooltip"": [
			""Effet du spéléologue et vitesse de minage +15%""
		]
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
		]
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
		]
	},
	{
		""id"": ""AncientGodSlayerLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient God Slayer Leggings"",
		""name"": ""Ancien Pantalon du Déicide""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Animus"",
		""type"": ""ITEM"",
		""englishName"": ""Animus"",
		""englishTooltip"": [
			""Randomizes its damage on enemy hits""
		],
		""name"": ""Animus"",
		""tooltip"": [
			""Randomise ses dégâts quand vous touchez""
		]
	},
	{
		""id"": ""PrototypeAndromechaRing"",
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
			""\"" + CalamityUtils.ColorMessage(\""Now, make them pay.\"", new Color(135, 206, 235))""
		],
		""name"": ""Anneau de Flammetalon"",
		""tooltip"": [
			""Invoque un mécha colossal contrôlable"",
			""Clic droit pour afficher le panneau de contrôle"",
			""Ce panneau à trois configurations, selectionnable en cliquant sur les bords de l'interface"",
			""Chaque configuration alimente 2 des 3 fonctionnalités disponibles, représentées par les icônes circulaires."",
			""L'icône en bas à gauche miniaturise le mécha à la taille du joueur, mais affaiblit ses armes."",
			""L'icône en bas à droite est un puissant booster qui augmente grandement le mouvement."",
			""L'icône au sommet représente les armes du mécha. Elle doit être alimentée pour pouvoir attaquer."",
			""Cliquez sur cette dernière icône pour alterner entre Régicide, une énorme lame d'énergie, et un puissant fusil de Gauss."",
			""Sortir du mécha alors qu'un boss est en vie gênera temporairement vos mouvements"",
			""CalamityUtils.ColorMessage(\""Maintenant, faîtes les payer.\"", new Color(135, 206, 235))""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ApolloMask"",
		""type"": ""ITEM"",
		""englishName"": ""Apollo Mask"",
		""name"": ""Masque d'Apollo""
	},
	{
		""id"": ""ApolloTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Apollo Trophy"",
		""name"": ""Trophée d'Apollo""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""GreatbowofTurmoil"",
		""type"": ""ITEM"",
		""englishName"": ""Continental Greatbow"",
		""englishTooltip"": [
			""Wooden arrows are set alight with fire"",
			""Fires 3 arrows at once"",
			""Fires 2 additional cursed, hellfire, or ichor arrows""
		],
		""name"": ""Arc Long Continental"",
		""tooltip"": [
			""Les flèches de feu sont enflammées"",
			""Tire 3 flèches à la fois"",
			""Tire deux flèches maudites, de feu infernal ou d'ichor additionnelles""
		]
	},
	{
		""id"": ""NettlelineGreatbow"",
		""type"": ""ITEM"",
		""englishName"": ""Nettlevine Greatbow"",
		""englishTooltip"": [
			""Shoots 4 arrows at once"",
			""Fires 2 additional venom or chlorophyte arrows""
		],
		""name"": ""Arc Long d'Ortilierre"",
		""tooltip"": [
			""Tire 4 flèches à la fois"",
			""Tire 2 flèches de venin ou de chlorophyte supplémentaires""
		]
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
		]
	},
	{
		""id"": ""MandibleBow"",
		""type"": ""ITEM"",
		""englishName"": ""Mandible Bow"",
		""name"": ""Arc Mandibule""
	},
	{
		""id"": ""Seabow"",
		""type"": ""ITEM"",
		""englishName"": ""Seabow"",
		""englishTooltip"": [
			""Fires slow-moving water blasts""
		],
		""name"": ""Arc Marin"",
		""tooltip"": [
			""Tire de lentes décharges d'eau""
		]
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
		]
	},
	{
		""id"": ""WulfrumBow"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Bow"",
		""name"": ""Arc Wulfrum""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ArcanumoftheVoid"",
		""type"": ""ITEM"",
		""englishName"": ""Arcanum of the Void"",
		""englishTooltip"": [
			""You reflect projectiles when they hit you"",
			""Reflected projectiles deal no damage to you"",
			""This reflect has a 90 second cooldown which is shared with all other dodges and reflects""
		],
		""name"": ""Arcanum du néant"",
		""tooltip"": [
			""Vous renvoyez les projectiles qui vous touchent"",
			""Les projectiles renvoyés ne vous infligent pas de dégâts"",
			""Cet effet a un temps de recharge de 90s, qui se partage avec tous les autres effets d'esquive et de renvoi""
		]
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
		]
	},
	{
		""id"": ""ArkoftheAncients"",
		""type"": ""ITEM"",
		""englishName"": ""Fractured Ark"",
		""englishTooltip"": [
			""This line gets set in ModifyTooltips"",
			""A worn down and rusty blade once wielded against the evil of this world, ready to be of use once more""
		],
		""name"": ""Arche fracturée"",
		""tooltip"": [
			""This line gets set in ModifyTooltips"",
			""Une lame rouillé et usée autrefois brandie contre le mal de ce monde, prête à être brandie de nouveau""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AresMask"",
		""type"": ""ITEM"",
		""englishName"": ""Ares Mask"",
		""name"": ""Masque d'Arès""
	},
	{
		""id"": ""AresTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Ares Trophy"",
		""name"": ""Trophée d'Arès""
	},
	{
		""id"": ""Armageddon"",
		""type"": ""ITEM"",
		""englishName"": ""Armageddon"",
		""englishTooltip"": [
			""Enables/disables Armageddon, can be used in any difficulty mode"",
			""While active, any hit while a boss is alive will instantly kill you"",
			""If you defeat a boss for the first time with this mode active, they will drop 5 extra treasure bags"",
			""These extra bags will drop even if you are not in Expert Mode"",
			""Right click with this item to toggle whether your dodges are disabled"",
			""Dodges can be disabled independently of whether or not Armageddon is not enabled""
		],
		""name"": ""Armageddon"",
		""tooltip"": [
			""Tous les coups vous tuent instantanément quand un boss est en vie"",
			""Peut être activé ou désactivé"",
			""Si un boss est tué pour la première fois avec cet effet activé, il lâchera 5 sac à trésors supplémentaire"",
			""Ces sacs supplémentaires apparaissent même si vous ne jouez pas en mode expert"",
			""Clic droit sur cet objet pour désactiver ou réactiver vos esquives"",
			""Les esquives peuvent être désactivé indépendamment du mode Armageddon""
		]
	},
	{
		""id"": ""AtaxiaArmor"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Armor"",
		""englishTooltip"": [
			""+20 max life"",
			""8% increased damage and 4% increased critical strike chance""
		],
		""name"": ""Armure Hydrothermique"",
		""tooltip"": [
			""+20 vie maximum"",
			""+8% de dégâts supplémentaires et +4% de chances de coup critique""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SirensSong"",
		""type"": ""ITEM"",
		""englishName"": ""Anahita's Arpeggio"",
		""englishTooltip"": [
			""Casts slow-moving treble clefs that confuse enemies""
		],
		""name"": ""Arpège d'Anahita"",
		""tooltip"": [
			""Convoque de lentes clés de sol qui rendent les ennemis confus""
		]
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
		]
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
		]
	},
	{
		""id"": ""EldritchSoulArtifact"",
		""type"": ""ITEM"",
		""englishName"": ""Eldritch Soul Artifact"",
		""englishTooltip"": [
			""Knowledge"",
			""Boosts melee speed by 10%, ranged velocity by 25%, rogue damage by 15%, max minions by 2, and reduces mana cost by 15%""
		],
		""name"": ""Artefact d'Âme d'Eldritch"",
		""tooltip"": [
			""Connaissance"",
			""Augmente la vitesse de corps à corps de 10%, la vitesse des projectiles à distance de 25%, les dégâts de voleurs de 15%, les emplacements de sbires max de 2 et réduit les coûts en mana de 15%""
		]
	},
	{
		""id"": ""ArtemisMask"",
		""type"": ""ITEM"",
		""englishName"": ""Artemis Mask"",
		""name"": ""Masque d'Artemis""
	},
	{
		""id"": ""ArtemisTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Artemis Trophy"",
		""name"": ""Trophée d'Artemis""
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AshenHorns"",
		""type"": ""ITEM"",
		""englishName"": ""Ashen Horns"",
		""name"": ""Cornes Cendrées""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AuricDye"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Dye"",
		""name"": ""Teinture Aurique""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AeroDynamite"",
		""type"": ""ITEM"",
		""englishName"": ""Skynamite"",
		""englishTooltip"": [
			""You don't need an aerodynamics major to use this"",
			""Throws a floaty explosive that defies gravity""
		],
		""name"": ""Celestynamite"",
		""tooltip"": [
			""Pas besoin d'un diplôme en aérodynamique pour s'en servir"",
			""Lance un explosif flottant qui défie la gravité""
		]
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
		]
	},
	{
		""id"": ""FlakBabyBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Flak Crab Banner"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Baby Flak Crab""
		],
		""name"": ""Bannière de Bébé Crabe Flak"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bébé Crabe Flak""
		]
	},
	{
		""id"": ""GhostBellSmallBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Ghost Bell Banner"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Baby Ghost Bell""
		],
		""name"": ""Bannière de Bébé Cloche Fantôme"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Bébé Cloche Fantôme""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""NuclearRod"",
		""type"": ""ITEM"",
		""englishName"": ""Nuclear Rod"",
		""englishTooltip"": [
			""Minions release an irradiated aura on enemy hits"",
			""+1 max minion""
		],
		""name"": ""Baguette Nucléaire"",
		""tooltip"": [
			""Les sbires produisent une aura irradiante lorsqu'ils touchent les ennemis"",
			""+1 sbire max""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PlaguedPlateBathtub"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Bathtub"",
		""name"": ""Baignoire Pestiférée""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""FlashBullet"",
		""type"": ""ITEM"",
		""englishName"": ""Flash Round"",
		""englishTooltip"": [
			""Gives off a concussive blast that confuses enemies in a large area for a short time""
		],
		""name"": ""Balle Flash"",
		""tooltip"": [
			""Émet une déflagration concussive qui rends les ennemis confus pour un court moment dans une large zone""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AccelerationBullet"",
		""type"": ""ITEM"",
		""englishName"": ""Acceleration Round"",
		""englishTooltip"": [
			""Gains speed over time""
		],
		""name"": ""Balle Véloce"",
		""tooltip"": [
			""Gagne en vitesse au fur et à mesure""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""FrostsparkBullet"",
		""type"": ""ITEM"",
		""englishName"": ""Frostspark Bullet"",
		""englishTooltip"": [
			""Has a chance to freeze enemies and explode into electricity"",
			""Enemies that are immune to being frozen take more damage from these bullets""
		],
		""name"": ""Balle de Givrétincelle"",
		""tooltip"": [
			""A une chance de geler les ennemis et de provoquer une explosion électrique"",
			""Les ennemis immunisés au gel subissent plus de dégâts""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BOHLDOHRBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Bohldohr Banner"",
		""name"": ""Bannière de Bohldohr""
	},
	{
		""id"": ""SamuraiBadge"",
		""type"": ""ITEM"",
		""englishName"": ""Warbanner of the Sun"",
		""englishTooltip"": [
			""Increases melee damage, true melee damage and melee speed the closer you are to enemies"",
			""Max boost is 20% increased melee damage, true melee damage and melee speed""
		],
		""name"": ""Bannière de guerre du soleil"",
		""tooltip"": [
			""Augmente les dégâts, la vitesse de corps à corps et les dégâts de vraie mêlée en fonction de votre proximité avec les ennemis"",
			""L'augmentation maximum est de 20%""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ProfanedBasin"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": ""Bassin Profané"",
		""tooltip"": [
			""Utilisé pour l'artisanat spécial""
		]
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
		]
	},
	{
		""id"": ""CosmiliteBasin"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmilite Basin"",
		""name"": ""Bassin en Cosmilite""
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
		]
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
		]
	},
	{
		""id"": ""MarniteRifleSpear"",
		""type"": ""ITEM"",
		""englishName"": ""Marnite Bayonet"",
		""englishTooltip"": [
			""The gun damages enemies that touch it""
		],
		""name"": ""Bayonette de Marnite"",
		""tooltip"": [
			""L'arme endommage les ennemis au contact""
		]
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
		]
	},
	{
		""id"": ""BouncingBetty"",
		""type"": ""ITEM"",
		""englishName"": ""Bouncing Betty"",
		""englishTooltip"": [
			""Throws a grenade which bounces after exploding"",
			""Stealth strikes explode into a violent blast of fire and shrapnel when it bounces""
		],
		""name"": ""Betty la Sauteuse"",
		""tooltip"": [
			""Lance une grenade qui rebondit après explosion"",
			""Les attaques furtives explosent en une violente déflagration de feu et d'éclats quand elles rebondissent""
		]
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
		]
	},
	{
		""id"": ""PlaguedPlateBookcase"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Bookcase"",
		""name"": ""Bibliothèque Pestiférée""
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
		]
	},
	{
		""id"": ""GammaFusillade"",
		""type"": ""ITEM"",
		""englishName"": ""Biofusillade"",
		""englishTooltip"": [
			""Unleashes a concentrated beam of life energy""
		],
		""name"": ""Biofusillade"",
		""tooltip"": [
			""Relâche un rayon concentré d'énergie vitale""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PaintballBlaster"",
		""type"": ""ITEM"",
		""englishName"": ""Speed Blaster"",
		""englishTooltip"": [
			""Shoots a string of paint blasts""
		],
		""name"": ""Blaster Rapide"",
		""tooltip"": [
			""Tire une rafale de balles de peinture""
		]
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
		]
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
		]
	},
	{
		""id"": ""ChargedDartRifle"",
		""type"": ""ITEM"",
		""englishName"": ""Charged Dart Blaster"",
		""englishTooltip"": [
			""Fires a shotgun spread of darts and a splitting energy blast"",
			""Right click to fire a more powerful exploding energy blast that bounces""
		],
		""name"": ""Blaster de Fléchettes Chargées"",
		""tooltip"": [
			""Tire une volée de fléchettes et une décharge d'énergie qui se divise"",
			""Clic droit pour tirer une décharge d'énergie plus puissante qui rebondit""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Slurpfish"",
		""type"": ""ITEM"",
		""englishName"": ""Slurpfish"",
		""name"": ""Bleuvageon""
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
		]
	},
	{
		""id"": ""LivingGodSlayerFireBlock"",
		""type"": ""ITEM"",
		""englishName"": ""Living God Slayer Fire Block"",
		""name"": ""Bloc de Feu Déicide Vivant""
	},
	{
		""id"": ""LivingHolyFireBlock"",
		""type"": ""ITEM"",
		""englishName"": ""Living Holy Fire Block"",
		""name"": ""Bloc de Feu Sacré Vivant""
	},
	{
		""id"": ""LivingBrimstoneFireBlock"",
		""type"": ""ITEM"",
		""englishName"": ""Living Brimstone Fire Block"",
		""name"": ""Bloc de Feu de Soufre Vivant""
	},
	{
		""id"": ""BloodflareDye"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Dye"",
		""name"": ""Teinture de Brûlesang""
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
		]
	},
	{
		""id"": ""BlueCosmicFlameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Blue Cosmic Flame Dye"",
		""name"": ""Teinture de Feu Cosmique Bleu""
	},
	{
		""id"": ""BlueStatigelDye"",
		""type"": ""ITEM"",
		""englishName"": ""Blue Statigel Dye"",
		""name"": ""Teinture de Gel Statique Bleue""
	},
	{
		""id"": ""BobbitHook"",
		""type"": ""ITEM"",
		""englishName"": ""Bobbit Hook"",
		""englishTooltip"": [
			""Retracts upon attaching to a tile with extreme speeds"",
			""Reach: {40f}"",
			""Launch Velocity: {25f}"",
			""Reelback Velocity: {28f}"",
			""Pull Velocity: {24f}""
		],
		""name"": ""Bobbit Hook"",
		""tooltip"": [
			""Se rétracte extrêmement rapidement quand il s'attache à une tuile"",
			""Portée: 40"",
			""Vitesse de Lancer: 25"",
			""Vitesse de Rétractation: 28"",
			""Vitesse de Traction: 24""
		]
	},
	{
		""id"": ""Acidwood"",
		""type"": ""ITEM"",
		""englishName"": ""Acidwood"",
		""name"": ""Bois Acide""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SeashellBoomerang"",
		""type"": ""ITEM"",
		""englishName"": ""Seashell Boomerang"",
		""name"": ""Boomerang Coquillage""
	},
	{
		""id"": ""SeashellBoomerangMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Seashell Boomerang"",
		""name"": ""Boomerang Coquillage""
	},
	{
		""id"": ""AureateWings"",
		""type"": ""ITEM"",
		""englishName"": ""Aureate Booster"",
		""englishTooltip"": [
			""Mach speed with style!"",
			""Horizontal speed: 8.00"",
			""Acceleration multiplier: 1.5"",
			""Good vertical speed"",
			""Flight time: 80"",
			""10% increased movement speed while wearing the Reaver Armor""
		],
		""name"": ""Booster Aureate"",
		""tooltip"": [
			""Mach 1 avec classe!"",
			""Vitesse horizontale : 8"",
			""Multiplicateur d'accélération: 1.5"",
			""Bonne vitesse verticale"",
			""Temps de vol : 80"",
			""+10% de vitesse de mouvement en portant l'armure de saccageur""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""OrnateShield"",
		""type"": ""ITEM"",
		""englishName"": ""Ornate Shield"",
		""englishTooltip"": [
			""Boosted damage reduction and health while wearing the Daedalus armor"",
			""Grants a frost dash""
		],
		""name"": ""Bouclier Orné"",
		""tooltip"": [
			""Augmente la réduction des dégâts et votre vie maximum quand vous portez l'armure de Dédale"",
			""Accorde une ruée gelée""
		]
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
		]
	},
	{
		""id"": ""MurkySludge"",
		""type"": ""ITEM"",
		""englishName"": ""Murky Sludge"",
		""name"": ""Boue Trouble""
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
		]
	},
	{
		""id"": ""PlaguedPlateCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Candle"",
		""name"": ""Bougie Pestiférée""
	},
	{
		""id"": ""PurpleCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Resilient Candle"",
		""englishTooltip"": [
			""When placed, nearby players' defense blocks 5% more damage"",
			""'Neither rain nor wind can snuff its undying flame'""
		],
		""name"": ""Bougie Résiliente"",
		""tooltip"": [
			""Quand elle est placée, la défense des joueurs proches bloque 5% de dégâts supplémentaires"",
			""'Ni la pluie, ni le vent ne peut souffler sa flamme immortelle'""
		]
	},
	{
		""id"": ""PinkCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Vigorous Candle"",
		""englishTooltip"": [
			""When placed, nearby players regenerate 0.4% of their maximum health per second"",
			""This regeneration is at full power even while moving and bypasses Revengeance Mode caps"",
			""'Its brilliant light suffuses those nearby with hope'""
		],
		""name"": ""Bougie Vigoureuse"",
		""tooltip"": [
			""Quand elle est posée, les joueurs à portée régénèrent 0,4% de leur vie maximum par seconde"",
			""Cette régénératon est à pleine puissance même quand vous bougez et outrepasse la limitation du mode Revengeance"",
			""'Sa lueur brillante imprègne d'espoir ceux qui en sont proches'""
		]
	},
	{
		""id"": ""BlueCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Weightless Candle"",
		""englishTooltip"": [
			""When placed, nearby players gain 10% movement speed, 10% wing time and 5% acceleration"",
			""'The floating flame seems to uplift your very spirit'""
		],
		""name"": ""Bougie d'Apesanteur"",
		""tooltip"": [
			""Quand elle est placée, les joueurs proches gagnent 10% de vitesse de mouvement, 10% de temps de vol et 5% d'accélération"",
			""'Cette flamme flottante semble élever jusqu'a votre esprit'""
		]
	},
	{
		""id"": ""YellowCandle"",
		""type"": ""ITEM"",
		""englishName"": ""Spiteful Candle"",
		""englishTooltip"": [
			""When placed, nearby enemies take 5% more damage."",
			""This extra damage bypasses enemy damage reduction and defense"",
			""'Its hateful glow flickers with ire'""
		],
		""name"": ""Bougie de Rancune"",
		""tooltip"": [
			""Quand elle est posée, les ennemis prochent subissent 5% de dégâts supplémentaires."",
			""Ces dégâts ignorent la réduction des dégâts et la défense des ennemis"",
			""'Sa lueur haîneuse vacille d'ire'""
		]
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
		]
	},
	{
		""id"": ""PlantyMush"",
		""type"": ""ITEM"",
		""englishName"": ""Planty Mush"",
		""name"": ""Bouillie Végétale""
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
		]
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
		]
	},
	{
		""id"": ""BouncySpikyBall"",
		""type"": ""ITEM"",
		""englishName"": ""Bouncy Spiky Ball"",
		""englishTooltip"": [
			""Throws a very bouncy ball that richochets off walls and enemies"",
			""Receives a small boost in damage and velocity after bouncing off an enemy"",
			""Stealth strikes provide a bigger boost after richocheting""
		],
		""name"": ""Boule à Piques Rebondissante"",
		""tooltip"": [
			""Lance une boule rebondissante qui ricoche sur les murs et les ennemis"",
			""Gagne un petit bonus aux dégâts et en vitesse quand elle rebondit sur un ennemi"",
			""Les attaques furtives augmentent le bonus de ricochet""
		]
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
		]
	},
	{
		""id"": ""HeavenlyGale"",
		""type"": ""ITEM"",
		""englishName"": ""Heavenly Gale"",
		""englishTooltip"": [
			""Converts wooden arrows into barrages of 5 random exo arrows"",
			""Green exo arrows erupt into swirling tornadoes"",
			""Blue exo arrows burst into barrages of following arrows"",
			""Orange exo arrows explode into flames"",
			""Teal exo arrows pierce infinitely and ignore immunity frames"",
			""\"" + $\""Any non-wooden arrows used will deal {1.25f}x damage"",
			""\"" + \""66% chance to not consume ammo""
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
		]
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
		]
	},
	{
		""id"": ""LaboratoryContainmentBoxItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Containment Box"",
		""name"": ""Boîte de Confinement de Laboratoire""
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
		]
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
		]
	},
	{
		""id"": ""BrimflameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Brimflame Dye"",
		""name"": ""Teinture de Flammesoufre""
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
		]
	},
	{
		""id"": ""StratusBricks"",
		""type"": ""ITEM"",
		""englishName"": ""Stratus Brick"",
		""name"": ""Brique Stratus""
	},
	{
		""id"": ""PlaguedPlate"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Containment Brick"",
		""name"": ""Brique de Confinement Pestiférée""
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
		]
	},
	{
		""id"": ""GoldBurdenBreaker"",
		""type"": ""ITEM"",
		""englishName"": ""Burden Breaker"",
		""englishTooltip"": [
			""The good time"",
			""Go fast"",
			""WARNING: May have disastrous results"",
			""Increases horizontal movement speed beyond comprehension"",
			""Does not work while a boss is alive""
		],
		""name"": ""Brise Fardeau"",
		""tooltip"": [
			""Le bon moment"",
			""Allez vite"",
			""AVERTISSEMENT: peut occasionner des résultats désastreux"",
			""Augmente la vitesse de déplacement horizontale au-delà de la compréhension"",
			""Ne fonctionne pas quand un boss est en vie""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BurdenBreaker"",
		""type"": ""ITEM"",
		""englishName"": ""Determination Breaker"",
		""englishTooltip"": [
			""The bad time"",
			""Removes immunity frames"",
			""If you want a crazy challenge, equip this"",
			""Touching lava kills you instantly""
		],
		""name"": ""Briseur de Détermination"",
		""tooltip"": [
			""Le mauvais moment"",
			""Vous prive d'invincibilité"",
			""Si vous voulez un défi délirant, équipez ça"",
			""Toucher la lave vous tue instantanément""
		]
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
		]
	},
	{
		""id"": ""Skullmasher"",
		""type"": ""ITEM"",
		""englishName"": ""Skullmasher"",
		""englishTooltip"": [
			""Makes their brain hurt"",
			""Fires a spread of 4 high velocity bullets that split into additional bullets upon hitting an enemy""
		],
		""name"": ""Broyeur de Crâne"",
		""tooltip"": [
			""Faites leur mal au cerveau"",
			""Tire une volée de 4 balles à haute vélocité qui se divisent en balles supplémentaires en touchant un ennemi""
		]
	},
	{
		""id"": ""TrapperBulb"",
		""type"": ""ITEM"",
		""englishName"": ""Trapper Bulb"",
		""name"": ""Bulbe de Trappeur""
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""StardustStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Eidolon Staff"",
		""englishTooltip"": [
			""The power of an ancient cultist resonates within this staff"",
			""Fires a spread of ancient light and has a chance to fire a spinning ice cluster""
		],
		""name"": ""Bâton Eidolon"",
		""tooltip"": [
			""Le pouvoir d'un cultiste ancien résonne au sein de ce bâton"",
			""Tire une étendue de lumière ancienne et a une chance de tirer un amas de glace tournoyant""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AngryChickenStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Yharon's Kindle Staff"",
		""englishTooltip"": [
			""Summons a fiery draconid to fight for you"",
			""Requires 5 minion slots to use""
		],
		""name"": ""Bâton d'Attisement de Yharon"",
		""tooltip"": [
			""Invoque un draconide ardent pour combattre à vos côtés"",
			""Occupe 5 emplacements de sbires""
		]
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
		]
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
		]
	},
	{
		""id"": ""ShadowdropStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Shadowdrop Staff"",
		""englishTooltip"": [
			""Summons dark aura rain from the sky""
		],
		""name"": ""Bâton d'Ombrechute"",
		""tooltip"": [
			""Fait pleuvoir une pluie d'aura noire""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BlushieStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Staff of Blushie"",
		""englishTooltip"": [
			""Hold your mouse, wait, wait, wait, and put your trust in the power of blue magic""
		],
		""name"": ""Bâton de Blushie"",
		""tooltip"": [
			""Reste appuyé sur la souris, attends, attends, attends et fait confiance au pouvoir de la magie bleue""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""CrystalFlareStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Crystal Flare Staff"",
		""englishTooltip"": [
			""Fires blue frost flames that explode""
		],
		""name"": ""Bâton de Déflagration Cristalline"",
		""tooltip"": [
			""Tire des flammes givrées bleues qui explosent""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BittercoldStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Bittercold Staff"",
		""englishTooltip"": [
			""Fires a spread of homing ice spikes""
		],
		""name"": ""Bâton de Froid Mordant"",
		""tooltip"": [
			""Tire une étendue de piques de glace à tête chercheuse""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BabyGhostBellItem"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Ghost Bell"",
		""name"": ""Bébé Cloche Fantôme""
	},
	{
		""id"": ""BabyGhostBellJar"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Ghost Bell Jar"",
		""name"": ""Bébé Cloche Fantôme en Pot""
	},
	{
		""id"": ""BabyFlakHermit"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Flak Crab"",
		""name"": ""Bébé Crabe Flak""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""YharimsGift"",
		""type"": ""ITEM"",
		""englishName"": ""Yharim's Gift"",
		""englishTooltip"": [
			""The power of a god pulses from within this artifact"",
			""Flaming meteors rain down while invincibility is active"",
			""Exploding dragon dust is left behind as you move"",
			""Damage and movement speed increased by 15%""
		],
		""name"": ""Cadeau de Yharim"",
		""tooltip"": [
			""Le pouvoir d'un dieu parcours cet artéfact"",
			""Des météores enflammés pleuvent durant vos périodes d'invulnérabilité"",
			""Vous laissez de la poussière draconique explosive dans votre sillage"",
			""+15% de vitesse de déplacement et de dégâts infligés""
		]
	},
	{
		""id"": ""BabyFlakHermitCage"",
		""type"": ""ITEM"",
		""englishName"": ""Baby Flak Hermit Cage"",
		""name"": ""Cage de Bébé Flak Hermite""
	},
	{
		""id"": ""PiggyCage"",
		""type"": ""ITEM"",
		""englishName"": ""Piggy Cage"",
		""name"": ""Cage à Piggy""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ReinforcedCrateItem"",
		""type"": ""ITEM"",
		""englishName"": ""Reinforced Crate"",
		""name"": ""Caisse Renforcée""
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
		]
	},
	{
		""id"": ""PlagueCellCluster"",
		""type"": ""ITEM"",
		""englishName"": ""Plague Cell Canister"",
		""name"": ""Caisson de peste""
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
		]
	},
	{
		""id"": ""SCalBoots"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitous Boots"",
		""name"": ""Bottes Calamiteuses""
	},
	{
		""id"": ""CalamitousDye"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitous Dye"",
		""name"": ""Teinture Calamiteuse""
	},
	{
		""id"": ""SCalMask"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitous Hood"",
		""name"": ""Capuche Calamiteuse""
	},
	{
		""id"": ""SCalRobes"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitous Robes"",
		""name"": ""Robe Calamiteuse""
	},
	{
		""id"": ""Calamity"",
		""type"": ""ITEM"",
		""englishName"": ""Calamity"",
		""englishTooltip"": [
			""Lights your cursor ablaze with the Witch's flames, summoning a burning sigil around it"",
			""Enemies touching the sigil take immense damage and are inflicted with Vulnerability Hex"",
			""Equip in a vanity slot to change the cursor without dealing damage""
		],
		""name"": ""Calamité"",
		""tooltip"": [
			""Enflamme votre curseur avec les flammes de la sorcière, invoquant une sigle brûlant autour"",
			""Les ennemis qui touchent le sigle prennent d'immenses dégâts et subissent la malédiction de vulnérabilité"",
			""Equipez dans une emplacement de vanité change la couleur du curseur sans infliger de dégâts""
		]
	},
	{
		""id"": ""AtaxiaSubligar"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Subligar"",
		""englishTooltip"": [
			""5% increased critical strike chance"",
			""10% increased movement speed""
		],
		""name"": ""Caleçon Hydrothermique"",
		""tooltip"": [
			""+5% de chances de coup critique"",
			""+10% de vitesse de mouvement""
		]
	},
	{
		""id"": ""PlaguedPlateSofa"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Sofa"",
		""name"": ""Canapé Pestiféré""
	},
	{
		""id"": ""PlaguedPlateCandelabra"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Candelabra"",
		""name"": ""Candélabre Pestiféré""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""T1000"",
		""type"": ""ITEM"",
		""englishName"": ""Aetherflux Cannon"",
		""englishTooltip"": [
			""Fires a barrage of phased god rays that pass through terrain""
		],
		""name"": ""Canon d'Etherflux"",
		""tooltip"": [
			""Tire une étendue de lasers divins phasés qui traversent les murs""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""TitaniumRailgun"",
		""type"": ""ITEM"",
		""englishName"": ""Titanium Railgun"",
		""englishTooltip"": [
			""Fires a laser""
		],
		""name"": ""Canon à Rail en Titane"",
		""tooltip"": [
			""Tire un laser""
		]
	},
	{
		""id"": ""StarCannonEX"",
		""type"": ""ITEM"",
		""englishName"": ""Star Cannon EX"",
		""englishTooltip"": [
			""Fires a mix of normal, starfury, and astral stars""
		],
		""name"": ""Canon à Étoiles EX"",
		""tooltip"": [
			""Tire un mélange d'étoiles normales, astrales et de furie étoilée""
		]
	},
	{
		""id"": ""XerocPlateMail"",
		""type"": ""ITEM"",
		""englishName"": ""Empyrean Cloak"",
		""englishTooltip"": [
			""Armor of the cosmos"",
			""+20 max life"",
			""7% increased rogue damage and critical strike chance""
		],
		""name"": ""Cape Empyréene"",
		""tooltip"": [
			""Armure du cosmos"",
			""+20 vie maximum"",
			""+7% de dégâts et de chances de coup critique de voleur""
		]
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
		]
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
		]
	},
	{
		""id"": ""SilvaHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Horned Hood"",
		""englishTooltip"": [
			""10% increased minion damage""
		],
		""name"": ""Capuche Cornée Silva"",
		""tooltip"": [
			""+10% de dégâts des sbires""
		]
	},
	{
		""id"": ""AtaxiaHood"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Hood"",
		""englishTooltip"": [
			""12% increased rogue damage and 10% increased rogue critical strike chance"",
			""50% chance to not consume rogue items and 5% increased movement speed"",
			""Temporary immunity to lava and immunity to fire damage""
		],
		""name"": ""Capuche Hydrothermique"",
		""tooltip"": [
			""+12% de dégâts de voleur et +10% de chances de coup critique de voleur"",
			""50% de ne pas consommer les armes de lancer et +5% de vitesse de mouvement"",
			""Immunité temporaire à la lave et immunité aux dégâts de feu""
		]
	},
	{
		""id"": ""StatigelHood"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Hood"",
		""englishTooltip"": [
			""Increased minion knockback""
		],
		""name"": ""Capuche Statigel"",
		""tooltip"": [
			""Augmente le recul des sbires""
		]
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
		]
	},
	{
		""id"": ""DaedalusHat"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Hood"",
		""englishTooltip"": [
			""13% increased magic damage and 7% increased magic critical strike chance"",
			""10% decreased mana usage and +60 max mana""
		],
		""name"": ""Capuche de Dédale"",
		""tooltip"": [
			""+13% de dégâts magiques et +7% de chances de coup critique magique"",
			""10% de réduction de coût en mana et +60 mana maximum""
		]
	},
	{
		""id"": ""ArmoredShell"",
		""type"": ""ITEM"",
		""englishName"": ""Armored Shell"",
		""name"": ""Carapace Blindée""
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
		]
	},
	{
		""id"": ""GiantShell"",
		""type"": ""ITEM"",
		""englishName"": ""Giant Shell"",
		""englishTooltip"": [
			""15% reduced movement speed and 5% increased damage reduction"",
			""Taking a hit will make you move very fast for a short time""
		],
		""name"": ""Carapace Géante"",
		""tooltip"": [
			""Vitesse de mouvement réduite de 15% et +5% de réduction de dégâts"",
			""Subir des dégâts vous fera vous déplacer très vite durant un court moment""
		]
	},
	{
		""id"": ""FabledTortoiseShell"",
		""type"": ""ITEM"",
		""englishName"": ""Flame-Licked Shell"",
		""englishTooltip"": [
			""35% decreased movement speed"",
			""Enemies take damage when they hit you"",
			""You move faster and lose 18 defense for 3 seconds if you take damage"",
			""Temporary immunity to lava""
		],
		""name"": ""Carapace Lèche-Flamme"",
		""tooltip"": [
			""35% de réduction du mouvement"",
			""Les ennemis subissent des dégâts quand ils vous touchent"",
			""Vous vous déplacez rapidement et perdez 18 défense pendant 3 secondes après avoir subi des dégâts"",
			""Immunité temporaire à la lave""
		]
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
		]
	},
	{
		""id"": ""CrawCarapace"",
		""type"": ""ITEM"",
		""englishName"": ""Craw Carapace"",
		""englishTooltip"": [
			""5% increased damage reduction"",
			""Enemies take damage when they touch you""
		],
		""name"": ""Carapace de Jabot"",
		""tooltip"": [
			""5% de réduction de dégâts"",
			""Les ennemis subissent des dégâts quand ils vous touchent""
		]
	},
	{
		""id"": ""GiantTortoiseShell"",
		""type"": ""ITEM"",
		""englishName"": ""Giant Tortoise Shell"",
		""englishTooltip"": [
			""10% decreased movement speed"",
			""Enemies take damage when they hit you""
		],
		""name"": ""Carapace de Tortue Géante"",
		""tooltip"": [
			""Vitesse de mouvement réduite de 10%"",
			""Les ennemis subissent des dégâts lorsqu'ils vous touchent""
		]
	},
	{
		""id"": ""PlaguebringerCarapace"",
		""type"": ""ITEM"",
		""englishName"": ""Plaguebringer Carapace"",
		""englishTooltip"": [
			""Reduces the damage caused to you by the plague"",
			""12% increased minion damage"",
			""Friendly bees inflict the plague""
		],
		""name"": ""Carapace du Colporte-Peste"",
		""tooltip"": [
			""Réduit les dégâts que la peste vous inflige"",
			""+12% de dégâts des sbires"",
			""Les abeilles alliées infligent la peste""
		]
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
		]
	},
	{
		""id"": ""ElementalQuiver"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Quiver"",
		""englishTooltip"": [
			""15% increased ranged damage, 5% increased ranged critical strike chance, and 20% reduced ammo usage"",
			""5 increased defense, 2 increased life regen, and 15% increased pick speed"",
			""Greatly increases arrow speed and grants a 20% chance to not consume arrows""
		],
		""name"": ""Carquois des Eléments"",
		""tooltip"": [
			""+15% de dégâts à distance, +5% de critique à distance, et -20% de consommation de munitions"",
			""+5 défense, +2 régénération de vie et +15% de vitesse de minage"",
			""Augmente beaucoup la vitesse des flèches et donne 20% de chances de ne pas consommer de flèches""
		]
	},
	{
		""id"": ""AcidBullet"",
		""type"": ""ITEM"",
		""englishName"": ""Acid Round"",
		""englishTooltip"": [
			""Explodes into acid that inflicts the plague"",
			""Does more damage the higher the target's defense""
		],
		""name"": ""Cartouche Acide"",
		""tooltip"": [
			""Explose en acide qui inflige la peste"",
			""Au plus la défense de l'ennemi est importante, au plus les dégâts sont élevés""
		]
	},
	{
		""id"": ""ExplosiveShells"",
		""type"": ""ITEM"",
		""englishName"": ""Explosive Shotgun Shell"",
		""name"": ""Cartouche de Fusil Explosive""
	},
	{
		""id"": ""GrenadeRounds"",
		""type"": ""ITEM"",
		""englishName"": ""Grenade Shell"",
		""name"": ""Cartouche de Grenade""
	},
	{
		""id"": ""MagnumRounds"",
		""type"": ""ITEM"",
		""englishName"": ""Magnum Round"",
		""name"": ""Cartouche de Magnum""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SilvaHornedHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Horned Helm"",
		""name"": ""Casque Cornu Silva"",
		""tooltip"": [
			""+13% de dégâts et de chances de coup critique à distance""
		]
	},
	{
		""id"": ""BloodflareHornedHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Horned Helm"",
		""englishTooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""10% increased ranged damage and critical strike chance""
		],
		""name"": ""Casque Cornu de Brûlesang"",
		""tooltip"": [
			""Vous pouvez vous déplacer librement dans les liquides et immunité temporaire à la lave"",
			""+10% de dégâts et de chances de coup critique à distance""
		]
	},
	{
		""id"": ""AtaxiaHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Helmet"",
		""englishTooltip"": [
			""5% increased minion damage and increased minion knockback"",
			""Temporary immunity to lava and immunity to fire damage""
		],
		""name"": ""Casque Hydrothermique"",
		""tooltip"": [
			""+5% de dégâts des sbires et recul des sbires augmenté"",
			""Immunité temporaire à la lave et immunité aux dégâts de feu""
		]
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
		]
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
		]
	},
	{
		""id"": ""AuricTeslaHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Royal Helm"",
		""englishTooltip"": [
			""20% increased melee damage and critical strike chance"",
			""Not moving boosts all damage and critical strike chance""
		],
		""name"": ""Casque Royal Tesla Aurique"",
		""tooltip"": [
			""+20% de dégâts et de chances de coup critique en mêlée"",
			""Rester immobile augmente les dégâts et les chances de coup critique""
		]
	},
	{
		""id"": ""AuricTeslaSpaceHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Space Helmet"",
		""englishTooltip"": [
			""15% increased minion damage"",
			""Not moving boosts all damage and critical strike chance""
		],
		""name"": ""Casque Spatial en Tesla Aurique"",
		""tooltip"": [
			""+15% de dégâts des sbires"",
			""Rester immobile augmente les dégâts et les chances de coup critique""
		]
	},
	{
		""id"": ""SulfurHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Helmet"",
		""englishTooltip"": [
			""4% increased rogue damage"",
			""2% increased rogue critical strike chance"",
			""Grants underwater breathing""
		],
		""name"": ""Casque Sulfureux"",
		""tooltip"": [
			""+4% de dégâts de voleur"",
			""+2% de chances de coup critique de voleur"",
			""Permet de respirer sous l'eau""
		]
	},
	{
		""id"": ""VictideHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Helmet"",
		""englishTooltip"": [
			""10% increased minion damage""
		],
		""name"": ""Casque Victide"",
		""tooltip"": [
			""+10% de dégâts des sbires""
		]
	},
	{
		""id"": ""WulfrumHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Helm"",
		""englishTooltip"": [
			""10% increased melee damage""
		],
		""name"": ""Casque Wulfrum"",
		""tooltip"": [
			""+10% de dégâts de mêlée""
		]
	},
	{
		""id"": ""TarragonHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Helmet"",
		""englishTooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids, 5% increased movement speed"",
			""10% increased rogue damage and critical strike chance"",
			""5% increased damage reduction""
		],
		""name"": ""Casque d'Estragon"",
		""tooltip"": [
			""Immunité temporaire à la lave"",
			""Vous pouvez vous déplacer librement dans les liquides et +5% de vitesse de mouvement"",
			""+10% de dégâts et de chances de coup critique de voleur"",
			""+5% de réduction des dégâts""
		]
	},
	{
		""id"": ""ReaverHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Helmet"",
		""englishTooltip"": [
			""5% increased minion damage, +2 max minions, and increased minion knockback"",
			""10% increased movement speed and can move freely through liquids""
		],
		""name"": ""Casque du Saccageur"",
		""tooltip"": [
			""+5% de dégâts des sbires, +2 sbires max, et recul des sbires augmenté"",
			""+10% de vitesse de mouvement et vous pouvez vous déplacer librement dans les liquides""
		]
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
		]
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
		]
	},
	{
		""id"": ""KelvinCatalystMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Kelvin Catalyst"",
		""englishTooltip"": [
			""Throws an icy blade that splits into multiple ice stars on enemy hits""
		],
		""name"": ""Catalyste Kelvin"",
		""tooltip"": [
			""Jette une lame glacée qui se divise en de multiples étoiles de glace en touchant""
		]
	},
	{
		""id"": ""StatisNinjaBelt"",
		""type"": ""ITEM"",
		""englishName"": ""Statis' Ninja Belt"",
		""englishTooltip"": [
			""6% increased jump speed and allows constant jumping"",
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
		]
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
		]
	},
	{
		""id"": ""PowerCell"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon Power Cell"",
		""englishTooltip"": [
			""Used to charge Draedon's weaponry at a Charging Station"",
			""Also can be processed by the Extractinator for spare parts""
		],
		""name"": ""Cellule d'Alimentation de Draedon"",
		""tooltip"": [
			""Utilisée pour charger l'armement de Draedon à une Station de Charge"",
			""Peut aussi être convertie par l'Extratinateur pour obtenir des pièces détachées""
		]
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
		]
	},
	{
		""id"": ""AstralJelly"",
		""type"": ""ITEM"",
		""englishName"": ""Aureus Cell"",
		""englishTooltip"": [
			""Grants increased mana regeneration and magic power""
		],
		""name"": ""Cellule d'Aureus"",
		""tooltip"": [
			""Accorde une régénération de mana et des pouvoirs magiques accrus""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""CalamitousEssence"",
		""type"": ""ITEM"",
		""englishName"": ""Ashes of Annihilation"",
		""name"": ""Cendres d'annihilation""
	},
	{
		""id"": ""CalamityDust"",
		""type"": ""ITEM"",
		""englishName"": ""Ashes of Calamity"",
		""name"": ""Cendres de Calamité""
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
		]
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
		]
	},
	{
		""id"": ""PlaguedPlateChair"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Chair"",
		""name"": ""Chaise Pestiférée""
	},
	{
		""id"": ""MangroveChakram"",
		""type"": ""ITEM"",
		""englishName"": ""Mangrove Chakram"",
		""name"": ""Chakram de la Mangrove""
	},
	{
		""id"": ""MangroveChakramMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Mangrove Chakram"",
		""name"": ""Chakran de la Mangrove""
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
		]
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
		]
	},
	{
		""id"": ""Shroomerang"",
		""type"": ""ITEM"",
		""englishName"": ""Shroomerang"",
		""englishTooltip"": [
			""Fires a slow, long-ranged boomerang"",
			""Stealth strikes grant the Mushy buff to the user on enemy hits and summon homing spores""
		],
		""name"": ""Champirang"",
		""tooltip"": [
			""Jette un lent boomerang à longue portée"",
			""Les attaques furtives octroient l'amélioration mousseux à l'utilisateur quand elles touchent et invoquent des spores à tête chercheuse""
		]
	},
	{
		""id"": ""PlaguedPlateChandelier"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Chandelier"",
		""name"": ""Chandelier Pestiféré""
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
		]
	},
	{
		""id"": ""SilvaMaskedCap"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Masked Cap"",
		""englishTooltip"": [
			""23% increased magic damage and 13% increased magic critical strike chance"",
			""+100 max mana and 19% reduced mana usage""
		],
		""name"": ""Chapeau Masqué Silva"",
		""tooltip"": [
			""+23% de dégâts et +13% de chances de coup critique magique"",
			""+100 mana maximum et 19% de réduction des coûts en mana""
		]
	},
	{
		""id"": ""StatigelCap"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Cap"",
		""englishTooltip"": [
			""10% increased magic damage and 10% decreased mana cost"",
			""7% increased magic critical strike chance and +30 max mana""
		],
		""name"": ""Chapeau Statigel"",
		""tooltip"": [
			""+10% de dégâts magiques et 10% de réduction du coût en mana"",
			""+7% de chances de coup critique magique et +30 mana maximum""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""CindersOfLament"",
		""type"": ""ITEM"",
		""englishName"": ""Cinders of Lament"",
		""englishTooltip"": [
			""Summons either Cataclysm or Catastrophe at the mouse position"",
			""They will look at you for a moment before charging at you"",
			""They can do damage to both you and enemies"",
			""\"" + CalamityUtils.ColorMessage(\""The Witch, a sinner of her own making\"", CalamityGlobalItem.ExhumedTooltipColor)"",
			""Within her mind her demon lies, ever patient, until the end of time.""
		],
		""name"": ""Cendres de Lamentation"",
		""tooltip"": [
			""Invoque soit Catastrophe soit Cataclysme a l'emplacement du curseur"",
			""Ils vous regarderons pendant un moment avant de vous charger"",
			""Ils infligent des dégâts au joueur comme aux ennemis"",
			""\"" + CalamityUtils.ColorMessage(\""La sorcière, une pécheresse de sa création\"", CalamityGlobalItem.ExhumedTooltipColor)"",
			""Dans son esprit repose un démon, patient comme toujours, attendant la fin du temps.""
		]
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
		]
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
		]
	},
	{
		""id"": ""MysteriousCircuitry"",
		""type"": ""ITEM"",
		""englishName"": ""Mysterious Circuitry"",
		""name"": ""Circuits mystérieux""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""XerocsGreatsword"",
		""type"": ""ITEM"",
		""englishName"": ""Entropic Claymore"",
		""englishTooltip"": [
			""Fires a spread of homing plasma balls""
		],
		""name"": ""Claymore Entropique"",
		""tooltip"": [
			""Tire une volée de boules de plasma à tête chercheuse""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Climax"",
		""type"": ""ITEM"",
		""englishName"": ""Voltaic Climax"",
		""englishTooltip"": [
			""Conjures an octagon of supercharged magnet spheres around the cursor""
		],
		""name"": ""Climax Voltaïque"",
		""tooltip"": [
			""Tire une octagone d'orbes magnétiques superchargées autour du curseur""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BrimstoneKey"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Opens locked ashen chests""
		],
		""name"": ""Clé de Soufre"",
		""tooltip"": [
			""Ouvre les coffres de cendre""
		]
	},
	{
		""id"": ""Cnidarian"",
		""type"": ""ITEM"",
		""englishName"": ""Cnidarian"",
		""englishTooltip"": [
			""Fires a seashell when enemies are near"",
			""A very agile yoyo""
		],
		""name"": ""Cnidarien"",
		""tooltip"": [
			""Tire un coquillage quand des ennemis sont près"",
			""Un yoyo très agile""
		]
	},
	{
		""id"": ""CodebreakerBase"",
		""type"": ""ITEM"",
		""englishName"": ""Codebreaker Base"",
		""name"": ""Base du Décodeur""
	},
	{
		""id"": ""SirensHeart"",
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
		""name"": ""Coeur Aquatique"",
		""tooltip"": [
			""Transforme le porteur en élémentaire d'eau"",
			""Aller sous l'eau vous donne une amélioration"",
			""Réduit grandement la perte de respiration et donne une petite quantité de lumière dans les abysses"",
			""Les ennemis gèlent lorsqu'ils vous touchent"",
			""Vous avez une couche de glace autour de vous qui absorbe 20% des dégâts, qui se brise quand vous subissez des dégâts"",
			""Le bouclier se régénère après 30s"",
			""Wouah! Tu peux nager maintenant !"",
			""La plupart de ces effets ne sont actifs qu'après avoir vaincu Skeletron""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""UnholyCore"",
		""type"": ""ITEM"",
		""englishName"": ""Unholy Core"",
		""name"": ""Coeur Profane""
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
		]
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
		]
	},
	{
		""id"": ""DraedonsHeart"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon's Heart"",
		""englishTooltip"": [
			""Reduces the amount of defense damage you take by 50%"",
			""Standing still regenerates your life quickly, reduces your damage by 50% and boosts your defense by 75%"",
			""Nanomachines, son""
		],
		""name"": ""Coeur de Draedon"",
		""tooltip"": [
			""Réduit les dégâts que vous subissez de 50%"",
			""Rester immobile régénére rapidement votre vie, réduit vos dégâts de 50% et augmente votre défense de 75%"",
			""Les nanomachines, mon grand""
		]
	},
	{
		""id"": ""IronHeart"",
		""type"": ""ITEM"",
		""englishName"": ""Iron Heart"",
		""englishTooltip"": [
			""Healing with potions and all positive life regen is disabled."",
			""Enemy damage scales with your max health."",
			""Can be toggled on and off.""
		],
		""name"": ""Coeur de Fer"",
		""tooltip"": [
			""Les potions de soins et la régénération de vie ne fonctionnent plus."",
			""Les dégâts des ennemis augmentent en fonction de votre vie maximale."",
			""Peut être activé et désactivé à volonté.""
		]
	},
	{
		""id"": ""BloodstoneCore"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodstone Core"",
		""name"": ""Coeur de Sang""
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
		]
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
		]
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
			""Invouqe tous les élémentaires pour vous protéger""
		]
	},
	{
		""id"": ""PlaguedPlateChest"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Chest"",
		""name"": ""Coffre Pestiféré""
	},
	{
		""id"": ""SecurityChest"",
		""type"": ""ITEM"",
		""englishName"": ""Security Chest"",
		""name"": ""Coffre Sécurisé""
	},
	{
		""id"": ""DaedalusHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Headgear"",
		""englishTooltip"": [
			""13% increased ranged damage and 7% increased ranged critical strike chance"",
			""Reduces ammo usage by 20%""
		],
		""name"": ""Coiffe de Dédale"",
		""tooltip"": [
			""+13% de dégâts à distance et +7% de chances de coup critique à distance"",
			""Réduit la consommation de munitions de 20%""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AdrenalineHairDye"",
		""type"": ""ITEM"",
		""englishName"": ""Adrenaline Hair Dye"",
		""name"": ""Coloration d'Adrénaline""
	},
	{
		""id"": ""StealthHairDye"",
		""type"": ""ITEM"",
		""englishName"": ""Stealth Hair Dye"",
		""name"": ""Coloration de Furtivité""
	},
	{
		""id"": ""RageHairDye"",
		""type"": ""ITEM"",
		""englishName"": ""Rage Hair Dye"",
		""name"": ""Coloration de Rage""
	},
	{
		""id"": ""WingTimeHairDye"",
		""type"": ""ITEM"",
		""englishName"": ""Wing Time Hair Dye"",
		""name"": ""Coloration de Temps de Vol""
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
		]
	},
	{
		""id"": ""PlaguedPlateDresser"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Dresser"",
		""name"": ""Commode Pestiférée""
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
		]
	},
	{
		""id"": ""CalamitasBrew"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitas' Brew"",
		""englishTooltip"": [
			""Adds abyssal flames to your melee and rogue projectiles and melee attacks"",
			""Increases your movement speed by 5%""
		],
		""name"": ""Concoction de Calamitas"",
		""tooltip"": [
			""Ajoute des flammes abyssales à vos attaques et projectiles de mêlée"",
			""Augmente votre vitesse de mouvement de 5%""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PurifiedJam"",
		""type"": ""ITEM"",
		""englishName"": ""Purified Jam"",
		""englishTooltip"": [
			""Makes you immune to all damage and most debuffs for 10 seconds"",
			""Causes potion sickness when consumed"",
			""Cannot be consumed while potion sickness is active""
		],
		""name"": ""Confiture Purifiée"",
		""tooltip"": [
			""Vous immunise contre tous les dégâts et la plupart des altérations d'état pendant 10 secondes"",
			""Provoque l'altération d'état potion affaiblie quand utilisé"",
			""Ne peut pas être utilisé si l'altération d'état potion affaiblie est active""
		]
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
		]
	},
	{
		""id"": ""TrueConferenceCall"",
		""type"": ""ITEM"",
		""englishName"": ""Conference Call"",
		""englishTooltip"": [
			""@everyone"",
			""50% chance to not consume ammo""
		],
		""name"": ""Conférence Virtuelle"",
		""tooltip"": [
			""@everyone"",
			""50% de chances de ne pas consommer de munitions""
		]
	},
	{
		""id"": ""LaboratoryConsoleItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Console"",
		""name"": ""Console de Laboratoire""
	},
	{
		""id"": ""MeldiateBar"",
		""type"": ""ITEM"",
		""englishName"": ""Meld Construct"",
		""name"": ""Construction de Fusion""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SeaShell"",
		""type"": ""ITEM"",
		""englishName"": ""Sea Shell"",
		""englishTooltip"": [
			""Increased defense and damage reduction when submerged in liquid"",
			""Increased movement speed when submerged in liquid""
		],
		""name"": ""Coquillage de Mer"",
		""tooltip"": [
			""Défense et réduction de dégâts augmentés quand vous êtes immergé"",
			""Augmente votre vitesse de déplacement lorsque vous êtes immergé""
		]
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
		]
	},
	{
		""id"": ""CorpusAvertorMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Corpus Avertor"",
		""englishTooltip"": [
			""Seems like it has worn down over time"",
			""Attacks grant lifesteal based on damage dealt"",
			""The lower your HP the more damage this weapon does and heals the player on enemy hits""
		],
		""name"": ""Corpus Avertor"",
		""tooltip"": [
			""On dirait qu'il s'est abimé avec le temps"",
			""Les attaques volent de la vie en fonction des dégâts effectués"",
			""Au plus il vous manque de la vie, au plus cette arme inflige des dégâts et soigne le joueur""
		]
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
		]
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
		]
	},
	{
		""id"": ""CosmiliteDye"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmilite Dye"",
		""name"": ""Cosmilite Dye TOTRANSLATE""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""StatisBeltOfCurses"",
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
		""name"": ""Courroie du Néant de Statis"",
		""tooltip"": [
			""+12% de vitesse de saut et permet le saut automatique"",
			""Immunise contre la chute"",
			""Vous pouvez monter les murs, foncer et esquiver les attaques"",
			""L'esquive a un temps de recharge de 90s"",
			""Ce temps de recharge est partagé avec tous les autres effets de reflets et d'esquive"",
			""Foncer laisse des faux à tête chercheuse dans votre sillage""
		]
	},
	{
		""id"": ""StellarKnife"",
		""type"": ""ITEM"",
		""englishName"": ""Stellar Knife"",
		""englishTooltip"": [
			""Throws knives that stop middair and then home into enemies"",
			""Stealth strikes throw a volley of \"" + knifeCount + \"" knives in a spread"",
			""Za Warudo""
		],
		""name"": ""Couteau Stellaire"",
		""tooltip"": [
			""Jette des couteaux qui s'arrêtent en l'air puis qui foncent sur les ennemis"",
			""Les attaques furtives jettent une étendue de couteaux"",
			""Za Warudo""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SporeKnife"",
		""type"": ""ITEM"",
		""englishName"": ""Spore Knife"",
		""englishTooltip"": [
			""Enemies release spore clouds on hit""
		],
		""name"": ""Couteau à spores"",
		""tooltip"": [
			""Les ennemis relâchent des nuages de spores quand ils sont touchés""
		]
	},
	{
		""id"": ""EmpyreanKnivesThrown"",
		""type"": ""ITEM"",
		""englishName"": ""Empyrean Knives"",
		""englishTooltip"": [
			""Throws a flurry of bouncing knives that can heal the user""
		],
		""name"": ""Couteaux Empyréens"",
		""tooltip"": [
			""Lance une myriade de couteaux rebondissants qui soignent l'utilisateur""
		]
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
		]
	},
	{
		""id"": ""RoyalKnives"",
		""type"": ""ITEM"",
		""englishName"": ""Illustrious Knives"",
		""englishTooltip"": [
			""Throws a flurry of homing knives that can heal the user""
		],
		""name"": ""Couteaux Illustres"",
		""tooltip"": [
			""Lance une myriade de couteaux qui pourchassent les ennemis et soignent l'utilisateur""
		]
	},
	{
		""id"": ""RoyalKnivesMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Illustrious Knives"",
		""englishTooltip"": [
			""Throws a flurry of homing knives that can heal the user""
		],
		""name"": ""Couteaux Illustres"",
		""tooltip"": [
			""Lance une myriade de couteaux qui pourchassent les ennemis et soignent l'utilisateur""
		]
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
		]
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
		]
	},
	{
		""id"": ""AtaxiaHeadgear"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Headgear"",
		""englishTooltip"": [
			""12% increased ranged damage and 10% increased ranged critical strike chance"",
			""Reduces ammo usage by 25%, temporary immunity to lava, and immunity to fire damage""
		],
		""name"": ""Couvre-chef Hydrothermique"",
		""tooltip"": [
			""+12% de dégâts à distance et +10% de chances de coup critique à distance"",
			""Réduit la consommation de munitions de 25%, immunité temporaire à la lave, et immunité aux dégâts de feu""
		]
	},
	{
		""id"": ""StatigelHeadgear"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Headgear"",
		""englishTooltip"": [
			""10% increased ranged damage"",
			""7% increased ranged critical strike chance""
		],
		""name"": ""Couvre-chef Statigel"",
		""tooltip"": [
			""+10% de dégâts à distance"",
			""+7% de chances de coup critique à distance""
		]
	},
	{
		""id"": ""VictideHeadgear"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Headgear"",
		""englishTooltip"": [
			""5% increased rogue damage""
		],
		""name"": ""Couvre-chef Victide"",
		""tooltip"": [
			""+5% dégâts de voleur""
		]
	},
	{
		""id"": ""WulfrumHeadgear"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Headgear"",
		""englishTooltip"": [
			""10% increased ranged damage""
		],
		""name"": ""Couvre-chef Wulfrum"",
		""tooltip"": [
			""+10% de dégâts à distance""
		]
	},
	{
		""id"": ""WulfrumHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Helmet"",
		""englishTooltip"": [
			""10% increased minion damage""
		],
		""name"": ""Couvre-chef Wulfrum"",
		""tooltip"": [
			""+10% de dégâts des sbires""
		]
	},
	{
		""id"": ""ReaverCap"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Headgear"",
		""englishTooltip"": [
			""15% increased rogue damage, 5% increased rogue velocity and critical strike chance"",
			""20% increased movement speed and can move freely through liquids""
		],
		""name"": ""Couvre-chef du Saccageur"",
		""tooltip"": [
			""+15% de dégats de voleur, +5% de chances de coup critiques et de vélocité"",
			""+20% de vitesse de déplacement, vous pouvez vous deplacer librement dans les liquides""
		]
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
		]
	},
	{
		""id"": ""BrimstoneFlameblaster"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Flameblaster"",
		""englishTooltip"": [
			""Fires bouncing brimstone fireballs""
		],
		""name"": ""Cracheflamme de soufre"",
		""tooltip"": [
			""Tire des boules de feu souffrées rebondissantes""
		]
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
		]
	},
	{
		""id"": ""MepheticSprayer"",
		""type"": ""ITEM"",
		""englishName"": ""Blight Spewer"",
		""name"": ""Cracheur de Troubles""
	},
	{
		""id"": ""ProcyonidPrawn"",
		""type"": ""ITEM"",
		""englishName"": ""Procyonid Prawn"",
		""name"": ""Crevette Procyonide""
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
		]
	},
	{
		""id"": ""ProfanedSoulCrystal"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Soul Crystal"",
		""englishTooltip"": [
			""Transforms you into an emissary of the profaned goddess"",
			""Requires 10 minion slots to use in order to grant the following effects"",
			""All non-summon weapons are converted into powerful summon variations"",
			""Falling below 50% life will empower these attacks"",
			""[c/f05a5a:Transforms Melee attacks into a barrage of spears]"",
			""[c/3a83e4:Transforms Magic attacks into a powerful splitting fireball]"",
			""[c/85e092:Transforms Ranged attacks into a flurry of fireballs and meteors]"",
			""[c/e97451:Transforms Rogue attacks into a deadly crystalline spiral]"",
			""Summons and empowers the profaned babs to fight alongside you"",
			""You are no longer affected by burn out when hit"",
			""Provides buffs depending on the time of day"",
			""Thinking back, it was a boring life"",
			""[c/FFBF49:And so we burn it all in the name of purity]""
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""CryonicDye"",
		""type"": ""ITEM"",
		""englishName"": ""Cryonic Dye"",
		""name"": ""Cryonic Dye TOTRANSLATE""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BloodflareBodyArmor"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Body Armor"",
		""englishTooltip"": [
			""12% increased damage and 8% increased critical strike chance"",
			""You regenerate life quickly and gain +30 defense while in lava"",
			""+40 max life""
		],
		""name"": ""Cuirasse de Brûlesang"",
		""tooltip"": [
			""+12% de dégâts et +8% de chances de coup critique"",
			""Vous régénérez rapidement de la vie et gagnez 30 défense quand vous êtes dans la lave"",
			""+40 vie maximum""
		]
	},
	{
		""id"": ""XerocCuisses"",
		""type"": ""ITEM"",
		""englishName"": ""Empyrean Cuisses"",
		""englishTooltip"": [
			""Speed of the cosmos"",
			""5% increased rogue damage and critical strike chance"",
			""15% increased movement speed""
		],
		""name"": ""Cuissarde Empyréene"",
		""tooltip"": [
			""Vitesse du Cosmos"",
			""+5% de dégâts et de chances de coup critique de voleur"",
			""+15% de vitesse de mouvement""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""LeechingDagger"",
		""type"": ""ITEM"",
		""englishName"": ""Leeching Dagger"",
		""englishTooltip"": [
			""Enemies release homing leech orbs on hit""
		],
		""name"": ""Dague Sangsue"",
		""tooltip"": [
			""Les ennemis relâchent des orbes de sangsues quand ils sont touchés""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BloodyWormTooth"",
		""type"": ""ITEM"",
		""englishName"": ""Bloody Worm Tooth"",
		""englishTooltip"": [
			""5% increased damage reduction and increased melee stats"",
			""10% increased damage reduction and melee stats when below 50% life""
		],
		""name"": ""Dent de Ver Sanglante"",
		""tooltip"": [
			""5% de réduction de dégâts et d'augmentation des statistiques de corps à corps"",
			""10% de réduction de dégâts et d'augmentation des statistiques de corps à corps si vous avez moins de la moitié de vos points de vie""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AccretionDisk"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Disk"",
		""englishTooltip"": [
			""Throws a disk that has a chance to generate several disks if enemies are near it"",
			""Stealth strikes fly slower but travel farther, pierce through enemies, and spawn extra disks more frequently""
		],
		""name"": ""Disque des Éléments"",
		""tooltip"": [
			""Lance un disque qui a une chance de générer plusieurs disques si les ennemis en sont proches"",
			""Les attaques furtives voyagent plus lentement mais plus loin, transpercent les ennemis et ont plus de chances de générer des disques additionnels""
		]
	},
	{
		""id"": ""AccretionDiskMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Disk"",
		""englishTooltip"": [
			""Throws a disk that has a chance to generate several disks if enemies are near it""
		],
		""name"": ""Disque des Éléments"",
		""tooltip"": [
			""Jette un disque qui a une chance de générer plusieurs disques si les ennemis en sont proches""
		]
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
		]
	},
	{
		""id"": ""Interfacer"",
		""type"": ""ITEM"",
		""englishName"": ""Disseminator"",
		""englishTooltip"": [
			""@everyone"",
			""50% chance to not consume ammo""
		],
		""name"": ""Disseminateur"",
		""tooltip"": [
			""@everyone"",
			""50% de chances de ne pas consommer de munitions""
		]
	},
	{
		""id"": ""AquaticDissolution"",
		""type"": ""ITEM"",
		""englishName"": ""Aquatic Dissolution"",
		""englishTooltip"": [
			""Fires whaling spears from the sky that bounce off tiles""
		],
		""name"": ""Dissolution Aquatique"",
		""tooltip"": [
			""Tire des harpons à baleines depuis les ciels qui rebondissent sur les tuiles""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""DraedonMask"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon Mask"",
		""name"": ""Draedon Mask TOTRANSLATE""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Megafleet"",
		""type"": ""ITEM"",
		""englishName"": ""Voidragon"",
		""englishTooltip"": [
			""75% chance to not consume ammo"",
			""Fires void blasts that explode every other shot"",
			""Shoots demon flame tentacles alongside every shot""
		],
		""name"": ""Dragonéant"",
		""tooltip"": [
			""75% de chances de ne pas consommer de munitions"",
			""Tire des décharges de néant qui explosent tous les tirs pairs"",
			""Tire des tentacules de flammes démoniaques suivant chaque tir""
		]
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
		]
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
		]
	},
	{
		""id"": ""Dualpoon"",
		""type"": ""ITEM"",
		""englishName"": ""Dualpoon"",
		""englishTooltip"": [
			""Launches two harpoons""
		],
		""name"": ""Duopoon"",
		""tooltip"": [
			""Lance deux harpons""
		]
	},
	{
		""id"": ""CoralSpout"",
		""type"": ""ITEM"",
		""englishName"": ""Coral Spout"",
		""englishTooltip"": [
			""Casts coral water spouts that lay on the ground and damage enemies""
		],
		""name"": ""Débiteur de Corail"",
		""tooltip"": [
			""Convoque des éclats de corail qui se posent au sol et endommagent les ennemis""
		]
	},
	{
		""id"": ""DukesDecapitator"",
		""type"": ""ITEM"",
		""englishName"": ""Duke's Decapitator"",
		""englishTooltip"": [
			""Throws a hydro axe which shreds enemies when it comes into contact with them"",
			""The faster it’s spinning, the more times it hits before disappearing"",
			""Stealth Strikes make it emit short-ranged bubbles.""
		],
		""name"": ""Décapitateur du Duc"",
		""tooltip"": [
			""Lance une hydro-hache qui déchire les ennemis quand elle rentre en contact avec eux"",
			""Au plus elle tourne vite, au plus elle peut frapper avant de disparaître"",
			""Les attaques furtives émettent des bulles à courte portées.""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""HellBurst"",
		""type"": ""ITEM"",
		""englishName"": ""Hell Burst"",
		""englishTooltip"": [
			""Casts a beam of flame""
		],
		""name"": ""Décharge Infernale"",
		""tooltip"": [
			""Convoque un rayon de flamme""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PrideHuntersPlanarRipper"",
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
		""name"": ""Déchireur Planaire du Chasseur Orgueuilleux"",
		""tooltip"": [
			""Inflige 135% de dégâts tous les quatre tirs"",
			""Convertit les balles de mousquet en éclairs"",
			""Les éclairs sont extrêmement rapides et explosent quand ils tuent un ennemi"",
			""De plus, les coups critiques des éclairs augmentent la vitesse du joueur"",
			""Cet effet se cumule jusqu'a 20% de vitesse de déplacement et d'accélération supplémentaire"",
			""Cet effet s'annule si le joueur tient un autre objet"",
			""33% de chances de ne pas consommer de munitions""
		]
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
		]
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
		]
	},
	{
		""id"": ""FlameScytheMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Subduction Slicer"",
		""englishTooltip"": [
			""Throws a scythe that explodes on enemy hits""
		],
		""name"": ""Découpeur de Subduction"",
		""tooltip"": [
			""Lance une faux qui explose quand vous touchez""
		]
	},
	{
		""id"": ""FlameScythe"",
		""type"": ""ITEM"",
		""englishName"": ""Subduction Slicer"",
		""englishTooltip"": [
			""Throws a scythe that explodes on enemy hits"",
			""Stealth strikes also summon an orange pillar of fire on enemy hits""
		],
		""name"": ""Découpeur de Subduction"",
		""tooltip"": [
			""Lance une faux qui explose quand elle touche les ennemis"",
			""Les attaques furtives invoquent également un pilier de feu orange quand elles touchent les ennemis""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""DukeScales"",
		""type"": ""ITEM"",
		""englishName"": ""Old Duke's Scales"",
		""englishTooltip"": [
			""While under the effects of a damaging debuff, you gain 10% increased damage and 5% crit"",
			""For every 25% of lost life, you gain 6% increased damage and 3% crit"",
			""This will max out at 18% increased damage and 9% crit when under 25% life"",
			""Provides immunity to poisoned, venom, and sulphuric poisoning""
		],
		""name"": ""Ecailles du Vieux Duc"",
		""tooltip"": [
			""Quand vous subissez des dégâts sur la durée, vos dégâts augmentent de 10% et vos chances de coup critique de 5%"",
			""Pour chaque quart de vie manquant, vous gagnez 6% de dégâts et 3% de critique additionnel"",
			""Pour un maximum de 18% de dégâts et de 9% de chances de coup critique lorsqu'il vous reste moins d'un quart de votre vie"",
			""Immunise au poison, au venin et à l'empoisonnement sulfurique""
		]
	},
	{
		""id"": ""BloodSample"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Sample"",
		""name"": ""Echantillon de Sang""
	},
	{
		""id"": ""EvasionScarf"",
		""type"": ""ITEM"",
		""englishName"": ""Evasion Scarf"",
		""englishTooltip"": [
			""True melee strikes deal 15% more damage"",
			""Grants the ability to dash; dashing into an attack will cause you to dodge it"",
			""After a successful dodge you must wait 13 seconds before you can dodge again"",
			""This cooldown will be 50 percent longer if you have Chaos State"",
			""While on cooldown, Chaos State will be 50 percent longer""
		],
		""name"": ""Echarpe d'Evasion"",
		""tooltip"": [
			""Les attaques de vraie mêlée font 15% de dégâts supplémentaires"",
			""Donne la possibilité de foncer, foncer dans une attaque vous permettra de l'esquiver"",
			""Après une esquive réussie, vous devez attendre 13s avant de pouvoir esquiver de nouveau"",
			""Ce temps de recharge est doublé si vous subissez le Chaos"",
			""Durant le temps de recharge, le Chaos dure 50% plus longtemps""
		]
	},
	{
		""id"": ""CounterScarf"",
		""type"": ""ITEM"",
		""englishName"": ""Counter Scarf"",
		""englishTooltip"": [
			""True melee strikes deal 10% more damage"",
			""Grants the ability to dash; dashing into an attack will cause you to dodge it"",
			""After a successful dodge you must wait 15 seconds before you can dodge again"",
			""This cooldown will be twice as long if you have Chaos State"",
			""While on cooldown, Chaos State will last twice as long""
		],
		""name"": ""Echarpe de Contre"",
		""tooltip"": [
			""Les attaques de vraie mêlée font 10% de dégâts supplémentaires"",
			""Donne la possibilité de foncer, foncer dans une attaque vous permettra de l'esquiver"",
			""Après une esquive réussie, vous devez attendre 15s avant de pouvoir esquiver de nouveau"",
			""Ce temps de recharge est doublé si vous subissez le Chaos"",
			""Durant le temps de recharge, le Chaos dure deux fois plus longtemps""
		]
	},
	{
		""id"": ""BloodyWormScarf"",
		""type"": ""ITEM"",
		""englishName"": ""Bloody Worm Scarf"",
		""englishTooltip"": [
			""10% increased damage reduction and increased melee stats""
		],
		""name"": ""Echarpe de Ver Sanglant"",
		""tooltip"": [
			""10% de réduction de dégâts et d'augmentation des statistiques de corps à corps""
		]
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
		]
	},
	{
		""id"": ""HadopelagicEcho"",
		""type"": ""ITEM"",
		""englishName"": ""Hadopelagic Echo"",
		""englishTooltip"": [
			""Fires a string of bouncing sound waves that become stronger as they travel"",
			""Sound waves echo additional sound waves on enemy hits""
		],
		""name"": ""Echo Hadopélagique"",
		""tooltip"": [
			""Tire une chaine de vagues sonores rebondissantes"",
			""Les vagues tirées plus tard dans la chaine font plus de dégâts"",
			""Les vagues provoquent des vagues additionnelles quand elles touchent""
		]
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
		]
	},
	{
		""id"": ""Ectoblood"",
		""type"": ""ITEM"",
		""englishName"": ""Ectoblood"",
		""name"": ""Ectosang""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ElysianAegis"",
		""type"": ""ITEM"",
		""englishName"": ""Elysian Aegis"",
		""englishTooltip"": [
			""Blessed by the Profaned Flame"",
			""Grants immunity to knockback, and the Burning, On Fire!, and Holy Flames debuffs"",
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""DaedalusEmblem"",
		""type"": ""ITEM"",
		""englishName"": ""Artemis Emblem"",
		""englishTooltip"": [
			""10% increased ranged damage, 5% increased ranged critical strike chance, and 20% reduced ammo usage"",
			""5 increased defense, 2 increased life regen, and 15% increased pick speed""
		],
		""name"": ""Emblème d'Artémis"",
		""tooltip"": [
			""10% de dégâts à distance et 5% de critique à distance supplémentaires, et 20% de réduction de la consommation des munitions"",
			""+5 défense, +2 régénération de vie et +15% de vitesse de minage""
		]
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
		]
	},
	{
		""id"": ""Impaler"",
		""type"": ""ITEM"",
		""englishName"": ""Impaler"",
		""englishTooltip"": [
			""Fires explosive and flaming stakes"",
			""Instantly kills vampires and vampire bats""
		],
		""name"": ""Empaleur"",
		""tooltip"": [
			""Tires des pieux enflammés explosifs"",
			""Tue instantanément les vampires""
		]
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
		]
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
		]
	},
	{
		""id"": ""DeathValley"",
		""type"": ""ITEM"",
		""englishName"": ""Death Valley Duster"",
		""englishTooltip"": [
			""Casts a large blast of dust""
		],
		""name"": ""Empoussièrage de la Vallée de la Mort "",
		""tooltip"": [
			""Convoque une large déflagration de poussière""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""FlameburstShortsword"",
		""type"": ""ITEM"",
		""englishName"": ""Flameburst Shortsword"",
		""englishTooltip"": [
			""Enemies explode on hit""
		],
		""name"": ""Epée Courte d'Exploflamme"",
		""tooltip"": [
			""Explose en touchant les ennemis""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""EssenceofCinder"",
		""type"": ""ITEM"",
		""englishName"": ""Essence of Sunlight"",
		""englishTooltip"": [
			""The essence of sky, light, and storm creatures""
		],
		""name"": ""Essence de Soleil"",
		""tooltip"": [
			""L'essence des créatures célestes, lumineuses et de tempête""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""EutrophicSandWallSafe"",
		""type"": ""ITEM"",
		""englishName"": ""Eutrophic Sand Wall"",
		""name"": ""Mur de Sable Eutrophique""
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
		]
	},
	{
		""id"": ""EvergreenGin"",
		""type"": ""ITEM"",
		""englishName"": ""Evergreen Gin"",
		""englishTooltip"": [
			""It tastes like a Christmas tree, if you can imagine that"",
			""Multiplies all sickness and water-related debuff damage by 1.5 and increases damage reduction by 5%"",
			""Reduces life regen by 1""
		],
		""name"": ""Evergreen Gin"",
		""tooltip"": [
			""Ca a un goût de sapin de Noël, si tu arrives à imaginer quel goût ça a"",
			""Augmente les dégâts des altérations d'état liées à l'eau et à la maladie de 50% et la réduction des dégâts de 5%"",
			""Réduit la régénération de la vie de 1""
		]
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
		]
	},
	{
		""id"": ""ExcaliburShortsword"",
		""type"": ""ITEM"",
		""englishName"": ""Excalibur Shortsword"",
		""englishTooltip"": [
			""Don't underestimate the power of shortswords""
		],
		""name"": ""Excalibur Courte"",
		""tooltip"": [
			""Ne sous-estimer pas les épées courtes""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ExoConsole"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Console TOTRANSLATE"",
		""name"": ""Exo Console""
	},
	{
		""id"": ""ExoDisplay"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Display TOTRANSLATE"",
		""name"": ""Exo Display""
	},
	{
		""id"": ""ExoDye"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Dye"",
		""name"": ""Exo Dye TOTRANSLATE""
	},
	{
		""id"": ""ExoGladius"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Gladius"",
		""englishTooltip"": [
			""Do not underestimate the power of Exoblade's younger brother"",
			""Striking an enemy with the blade makes you immune for a short time and summons comets from the sky"",
			""Fires a rainbow orb that summons sword beams on hit""
		],
		""name"": ""Exo Gladius"",
		""tooltip"": [
			""Ne sous-estimez pas le pouvoir du petit frère de l'exolame"",
			""Frapper un ennemi avec la lame vous immunisera une court moment et invoquera des comètes depuis le ciel"",
			""Tire une orbe arc-en-ciel qui invoque des rayons d'épée quand elle touche""
		]
	},
	{
		""id"": ""ExoPlatingWallItem"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Plating Wall TOTRANSLATE"",
		""name"": ""Exo Plating Wall""
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
		]
	},
	{
		""id"": ""ExoPrismPanelWallItem"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Prism Panel Wall TOTRANSLATE"",
		""name"": ""Exo Prism Panel Wall""
	},
	{
		""id"": ""ExoScreen"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Screen TOTRANSLATE"",
		""name"": ""Exo Screen""
	},
	{
		""id"": ""ExoServer"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Server TOTRANSLATE"",
		""name"": ""Exo Server""
	},
	{
		""id"": ""ExoTerminal"",
		""type"": ""ITEM"",
		""englishName"": ""Exo Terminal TOTRANSLATE"",
		""name"": ""Exo Terminal""
	},
	{
		""id"": ""DraedonsExoblade"",
		""type"": ""ITEM"",
		""englishName"": ""Exoblade"",
		""englishTooltip"": [
			""Ancient blade of Yharim's weapons and armors expert, Draedon"",
			""Fires an exo beam that homes in on the player and explodes"",
			""Striking an enemy with the blade causes several comets to fire"",
			""All attacks briefly freeze enemies hit"",
			""Enemies hit at very low HP explode into frost energy and freeze nearby enemies""
		],
		""name"": ""Exolame"",
		""tooltip"": [
			""Ancienne lame de Draedon, l'expert en armements et armures de Yharim."",
			""Tire un exo rayon qui pourchasse le joueur avant d'exploser"",
			""Frapper un ennemi avec la lame provoque l'apparition de plusieurs comètes"",
			""Toutes les attaques gèlent brièvement les ennemis"",
			""Les ennemis qui ont une vie très faible explosent en énergie givrée et gèlent les ennemis proches""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""NanoblackReaperMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Nanoblack Reaper"",
		""englishTooltip"": [
			""Unleashes a storm of nanoblack energy blades"",
			""Blades target bosses whenever possible"",
			""'She smothered them in Her hatred'""
		],
		""name"": ""Faucheur Nano-noir"",
		""tooltip"": [
			""Libère une tempête de lames d'énergie nano-noire"",
			""Les lames visent les boss quand c'est possible"",
			""'Elle les a étouffés dans Sa haine'""
		]
	},
	{
		""id"": ""NanoblackReaperRogue"",
		""type"": ""ITEM"",
		""englishName"": ""Nanoblack Reaper"",
		""englishTooltip"": [
			""Unleashes a storm of nanoblack energy blades"",
			""Blades target bosses whenever possible"",
			""Stealth strikes cause the scythe to create a large amount of homing afterimages instead of energy blades"",
			""'She smothered them in Her hatred'""
		],
		""name"": ""Faucheur Nano-noir"",
		""tooltip"": [
			""Libère une tempête de lames d'énergie nano-noire"",
			""Les lames visent les boss quand c'est possible"",
			""Les attaques furtives créent un gand nombre d'images rémanentes à tête chercheuse à la place des lames d'énergie"",
			""'Elle les a étouffés dans Sa haine'""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""WulfrumShard"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Metal Scrap"",
		""name"": ""Ferraille de Wulfrum""
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
		]
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
		]
	},
	{
		""id"": ""Fireball"",
		""type"": ""ITEM"",
		""englishName"": ""Fireball"",
		""englishTooltip"": [
			""A great-tasting cinnamon whiskey"",
			""Multiplies all fire-based debuff damage by 1.5"",
			""Reduces life regen by 1""
		],
		""name"": ""Fireball"",
		""tooltip"": [
			""Un excellent whisky à la canelle"",
			""Augmente les dégâts des altérations liées au feu de 50%"",
			""Réduit la régénération de vie de 1""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""CrimsonFlask"",
		""type"": ""ITEM"",
		""englishName"": ""Crimson Flask"",
		""englishTooltip"": [
			""7% increased damage reduction and +3 defense while in the crimson""
		],
		""name"": ""Flasque Carmin"",
		""tooltip"": [
			""7% de réduction des dégâts et +3 défense quand vous êtes dans le carmin""
		]
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
		]
	},
	{
		""id"": ""AlchemicalFlask"",
		""type"": ""ITEM"",
		""englishName"": ""Alchemical Flask"",
		""englishTooltip"": [
			""All attacks inflict the Plague debuff"",
			""Projectiles spawn plague seekers on enemy hits""
		],
		""name"": ""Flasque alchémique"",
		""tooltip"": [
			""Toutes les attaques infligent la peste"",
			""Les projectiles génèrent des chercheurs de peste lorsque qu'ils touchent un ennemi""
		]
	},
	{
		""id"": ""CorruptFlask"",
		""type"": ""ITEM"",
		""englishName"": ""Corrupt Flask"",
		""englishTooltip"": [
			""7% increased damage reduction and +3 defense while in the corruption""
		],
		""name"": ""Flasque corrompue"",
		""tooltip"": [
			""7% de réduction des dégâts et +3 défense quand vous êtes dans la corruption""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ScourgeoftheCosmosThrown"",
		""type"": ""ITEM"",
		""englishName"": ""Scourge of the Cosmos"",
		""englishTooltip"": [
			""Throws a bouncing cosmic scourge that emits tiny homing cosmic scourges on death and tile hits""
		],
		""name"": ""Fléau du Cosmos"",
		""tooltip"": [
			""Lance un fléau cosmique rebondissant qui émet des petits fléaux cosmiques quand il touche un mur ou disparaît""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AbyssFountainItem"",
		""type"": ""ITEM"",
		""englishName"": ""Abyss Water Fountain"",
		""name"": ""Fontaine d'Eau Abyssale""
	},
	{
		""id"": ""AstralFountainItem"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Water Fountain"",
		""name"": ""Fontaine d'Eau Astrale""
	},
	{
		""id"": ""SunkenSeaFountain"",
		""type"": ""ITEM"",
		""englishName"": ""Sunken Water Fountain"",
		""name"": ""Fontaine d'Eau Coulée""
	},
	{
		""id"": ""SulphurousFountainItem"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphuric Water Fountain"",
		""name"": ""Fontaine d'Eau Sulfurique""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""DemonicPitchfork"",
		""type"": ""ITEM"",
		""englishName"": ""Demonic Pitchfork"",
		""englishTooltip"": [
			""Fires a demonic pitchfork""
		],
		""name"": ""Fourche Démoniaque"",
		""tooltip"": [
			""Tire une fourche démoniaque""
		]
	},
	{
		""id"": ""DivineHatchet"",
		""type"": ""ITEM"",
		""englishName"": ""Seeking Scorcher"",
		""englishTooltip"": [
			""May your enemies burn in hell for the sins they have committed"",
			""Throws a holy boomerang that seeks out up to three enemies before returning to the player""
		],
		""name"": ""Fournaise Chercheuse"",
		""tooltip"": [
			""Puisse vos ennemis brûler en enfer pour les péchés qu'ils ont commis"",
			""Jete un boomerang sacré qui frappe jusqu'à 3 ennemis avant de revenir""
		]
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
		]
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
		]
	},
	{
		""id"": ""BrimlashBuster"",
		""type"": ""ITEM"",
		""englishName"": ""Brimlash Buster"",
		""englishTooltip"": [
			""50% chance to do triple damage on enemy hits"",
			""Fires a brimstone bolt that explodes into more bolts on death""
		],
		""name"": ""Fracasseur Fouette-Soufre"",
		""tooltip"": [
			""50% de chances de tripler les dégâts quand vous touchez"",
			""Tire une décharge de soufre qui explose en plus de décharges quand elle disparaît""
		]
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
		]
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
		]
	},
	{
		""id"": ""VictoryShard"",
		""type"": ""ITEM"",
		""englishName"": ""Victory Shard"",
		""name"": ""Fragment de Victoire""
	},
	{
		""id"": ""LivingShard"",
		""type"": ""ITEM"",
		""englishName"": ""Living Shard"",
		""name"": ""Fragment vivant""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AMR"",
		""type"": ""ITEM"",
		""englishName"": ""Anti-materiel Rifle"",
		""englishTooltip"": [
			""Converts musket balls into .50 caliber sniper rounds that rip apart enemy defense and DR"",
			""If you crit the target a second swarm of bullets will fire""
		],
		""name"": ""Fusil Anti-matériel"",
		""tooltip"": [
			""Convertit les balles de mousquet en une cartouche sniper de calibre 50 qui déchire la défense et la réduction de dégâts ennemie"",
			""En cas de coup critique, une volée de balles sera tirée près de la cible""
		]
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
		]
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
		]
	},
	{
		""id"": ""LaserRifle"",
		""type"": ""ITEM"",
		""englishName"": ""Heavy Laser Rifle"",
		""englishTooltip"": [
			""Laser weapon used by heavy infantry units in Yharim's army""
		],
		""name"": ""Fusil Laser Lourd"",
		""tooltip"": [
			""Fusil laser utilisé par les unités d'infanterie lourde dans l'armée de Yharim""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""CalamitasInferno"",
		""type"": ""ITEM"",
		""englishName"": ""Lashes of Chaos"",
		""englishTooltip"": [
			""Watch the world burn...""
		],
		""name"": ""Fustigation du Chaos"",
		""tooltip"": [
			""Regarde le monde brûler...""
		]
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
		]
	},
	{
		""id"": ""AstralSilt"",
		""type"": ""ITEM"",
		""englishName"": ""Novae Slag"",
		""name"": ""Gadoue Novae""
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
		]
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
		]
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
		]
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
		]
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
		]
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
			""Increased melee knockback""
		],
		""name"": ""Gant des Eléments"",
		""tooltip"": [
			""Les attaques et projectiles de corps à corps infligent la brûlure, le brûlegivre et les flammes sacrées"",
			""+15% de vitesse et de dégâts de corps à corps et +5% de chances de coup critique au corps à corps"",
			""+20% de dégâts de vraie mêlée"",
			""Immunité temporaire à la lave"",
			""Recul des attaques de corps à corps augmenté""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""EbonianGel"",
		""type"": ""ITEM"",
		""englishName"": ""Blighted Gel"",
		""name"": ""Gel Pourri""
	},
	{
		""id"": ""PurifiedGel"",
		""type"": ""ITEM"",
		""englishName"": ""Purified Gel"",
		""name"": ""Gel Purifié""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""GemTechBodyArmor"",
		""type"": ""ITEM"",
		""englishName"": ""Gem Tech Body Armor TOTRANSLATE"",
		""englishTooltip"": [
			""You sunk low enough for me to reach.""
		],
		""name"": ""Gem Tech Body Armor"",
		""tooltip"": [
			""You sunk low enough for me to reach.""
		]
	},
	{
		""id"": ""GemTechHeadgear"",
		""type"": ""ITEM"",
		""englishName"": ""Gem Tech Headgear TOTRANSLATE"",
		""englishTooltip"": [
			""The Devil said: Revel in your victory; You've earned your damning. Pack your things and leave.""
		],
		""name"": ""Gem Tech Headgear"",
		""tooltip"": [
			""The Devil said: Revel in your victory; You've earned your damning. Pack your things and leave.""
		]
	},
	{
		""id"": ""GemTechSchynbaulds"",
		""type"": ""ITEM"",
		""englishName"": ""Gem Tech Schynbaulds TOTRANSLATE"",
		""englishTooltip"": [
			""If they hurt you, kick them down.""
		],
		""name"": ""Gem Tech Schynbaulds"",
		""tooltip"": [
			""If they hurt you, kick them down.""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AstralIce"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Ice"",
		""name"": ""Glace Astrale""
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""RaidersGlory"",
		""type"": ""ITEM"",
		""englishName"": ""Raider's Glory"",
		""englishTooltip"": [
			""Fires ichor arrows with increased velocity"",
			""These arrows also cause enemies to drop more money""
		],
		""name"": ""Gloire du Pilleur de Tombes"",
		""tooltip"": [
			""Tire des flèches d'ichor avec une vélocité améliorée"",
			""Ces flèches font également tomber plus d'argent aux ennemis""
		]
	},
	{
		""id"": ""GloriousEnd"",
		""type"": ""ITEM"",
		""englishName"": ""Glorious End TOTRANSLATE"",
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
		]
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
		]
	},
	{
		""id"": ""SpiritGenerator"",
		""type"": ""ITEM"",
		""englishName"": ""Spirit Glyph"",
		""englishTooltip"": [
			""Whenever your minions hit an enemy you will gain a random buff"",
			""These buffs will either boost your defense, summon damage, or life regen for a while""
		],
		""name"": ""Glyphe Spirituel"",
		""tooltip"": [
			""Quand vos sbires touchent un ennemi, vous obtenez une amélioration aléatoire"",
			""Ces améliorations augmenteront vos dégâts d'invocation, votre défense ou votre régénération de vie durant un moment""
		]
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
		]
	},
	{
		""id"": ""StreamGouge"",
		""type"": ""ITEM"",
		""englishName"": ""Stream Gouge"",
		""englishTooltip"": [
			""Fires an essence spear clone"",
			""Ignores immunity frames""
		],
		""name"": ""Gouge Torrentielle"",
		""tooltip"": [
			""Tire un clone de lance d'essence"",
			""Ignore la période d'invulnérabilité""
		]
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
		]
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
		]
	},
	{
		""id"": ""GodSlayerHelm"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Horned Greathelm"",
		""englishTooltip"": [
			""14% increased melee damage and critical strike chance""
		],
		""name"": ""Grand Heaume Cornu du Déicide"",
		""tooltip"": [
			""+14% de dégâts et de chances de coup critique en mêlée""
		]
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
		]
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
		]
	},
	{
		""id"": ""AbyssGravel"",
		""type"": ""ITEM"",
		""englishName"": ""Abyss Gravel"",
		""name"": ""Gravier Abyssal""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""MandibleClaws"",
		""type"": ""ITEM"",
		""englishName"": ""Mandible Claws"",
		""name"": ""Griffes Mandibulaires""
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
		]
	},
	{
		""id"": ""MycelialClaws"",
		""type"": ""ITEM"",
		""englishName"": ""Mycelial Claws"",
		""name"": ""Griffes Mycéllaires""
	},
	{
		""id"": ""GruesomeEminence"",
		""type"": ""ITEM"",
		""englishName"": ""Gruesome Eminence"",
		""englishTooltip"": [
			""Summons a gaseous conglomeration of spirits near the cursor"",
			""At first, the spirits will fly wildly. This can hurt enemies and players"",
			""However, over time they will begin to accumulate to create a single, controllable monstrosity"",
			""\"" + CalamityUtils.ColorMessage(\""The spirits of the amalgam could never pass on to their desired afterlife\"", CalamityGlobalItem.ExhumedTooltipColor)"",
			""Tainted and melded by rage as they were.""
		],
		""name"": ""Gruesome Eminence"",
		""tooltip"": [
			""Summons a gaseous conglomeration of spirits near the cursor TOTRANSLATE"",
			""At first, the spirits will fly wildly. This can hurt enemies and players"",
			""However, over time they will begin to accumulate to create a single, controllable monstrosity"",
			""\"" + CalamityUtils.ColorMessage(\""The spirits of the amalgam could never pass on to their desired afterlife\"", CalamityGlobalItem.ExhumedTooltipColor)"",
			""Tainted and melded by rage as they were.""
		]
	},
	{
		""id"": ""AstralSandstone"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Sandstone"",
		""name"": ""Grès Astral""
	},
	{
		""id"": ""SulphurousSandstone"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Sandstone"",
		""name"": ""Grès Sulfureux""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""StarTaintedGenerator"",
		""type"": ""ITEM"",
		""englishName"": ""Star-Tainted Generator"",
		""englishTooltip"": [
			""+2 max minions, does not stack with downgrades"",
			""7% increased minion damage"",
			""Minion attacks spawn astral explosions and inflict several debuffs""
		],
		""name"": ""Générateur Infecté par les Astres"",
		""tooltip"": [
			""+2 sbires max, ne se cumule pas avec ses matériaux"",
			""+7% de dégâts des sbires"",
			""Les attaques des sbires génèrent des explosions astrales et infligent plusieurs altérations d'état""
		]
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
		]
	},
	{
		""id"": ""FleshyGeodeT1"",
		""type"": ""ITEM"",
		""englishName"": ""Fleshy Geode"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Géode Charnue"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
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
		]
	},
	{
		""id"": ""FleshyGeodeT2"",
		""type"": ""ITEM"",
		""englishName"": ""Necromantic Geode"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Géode Nécromantique"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
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
		]
	},
	{
		""id"": ""WulfrumAxe"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Axe"",
		""name"": ""Hache Wulfrum""
	},
	{
		""id"": ""Waraxe"",
		""type"": ""ITEM"",
		""englishName"": ""Waraxe"",
		""englishTooltip"": [
			""Critical hits cleave enemy armor, reducing their defense by 15 and protection by 25%""
		],
		""name"": ""Hache de Guerre"",
		""tooltip"": [
			""Les coups critiques fendent l'armure, reduisant la défense de 15 et la protection de 25%""
		]
	},
	{
		""id"": ""BerserkerWaraxe"",
		""type"": ""ITEM"",
		""englishName"": ""Berserker Waraxe"",
		""name"": ""Hache de Guerre du Berserker""
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
		]
	},
	{
		""id"": ""PurityAxe"",
		""type"": ""ITEM"",
		""englishName"": ""Axe of Purity"",
		""englishTooltip"": [
			""Left click to use as a tool"",
			""Right click to cleanse evil""
		],
		""name"": ""Hache de Pureté"",
		""tooltip"": [
			""Clic gauche pour l'utiliser comme outil"",
			""Clic droit pour purifier le mal""
		]
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
		]
	},
	{
		""id"": ""FulgurationHalberd"",
		""type"": ""ITEM"",
		""englishName"": ""Fulguration Halberd"",
		""englishTooltip"": [
			""Inflicts burning blood on enemy hits"",
			""Right click to use as a spear""
		],
		""name"": ""Hallebarde de Fulguration"",
		""tooltip"": [
			""Inflige le sang bouillonnant"",
			""Clic droit pour l'utiliser comme une lance""
		]
	},
	{
		""id"": ""HolidayHalberd"",
		""type"": ""ITEM"",
		""englishName"": ""Holiday Halberd"",
		""englishTooltip"": [
			""idk I'm miserable with names"",
			""- The General"",
			""Fires red and green bouncing gift bags that emit clouds as they travel""
		],
		""name"": ""Hallebarde des Fêtes"",
		""tooltip"": [
			""jsp je suis nul avec les noms"",
			""- Le Général"",
			""Tire des sacs surprises rouges et verts qui émettent des nuages sur leur trajet""
		]
	},
	{
		""id"": ""HallowedOre"",
		""type"": ""ITEM"",
		""englishName"": ""Hallowed Ore"",
		""name"": ""Hallowed Ore TOTRANSLATE""
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
		]
	},
	{
		""id"": ""SquishyBeanMount"",
		""type"": ""ITEM"",
		""englishName"": ""Suspicious Looking Jelly Bean"",
		""englishTooltip"": [
			""JELLY BEAN""
		],
		""name"": ""Haricot de Gelée à l'Apparence Suspecte"",
		""tooltip"": [
			""HARICOT DE GELÉE""
		]
	},
	{
		""id"": ""TarragonHornedHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Horned Helm"",
		""englishTooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""5% increased damage reduction and minion damage""
		],
		""name"": ""Heaume Cornu d'Estragon"",
		""tooltip"": [
			""Immunité temporaire à la lave"",
			""Vous pouvez vous déplacer librement dans les liquides"",
			""+5% de réduction de dégâts et d'augmentation de dégâts des sbires""
		]
	},
	{
		""id"": ""GodSlayerHornedHelm"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Horned Helm"",
		""name"": ""Heaume Cornu du Déicide"",
		""tooltip"": [
			""+3 sbires max""
		]
	},
	{
		""id"": ""AtaxiaHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Helm"",
		""englishTooltip"": [
			""12% increased melee damage and 10% increased melee critical strike chance"",
			""18% increased melee speed"",
			""Melee attacks and melee projectiles inflict on fire"",
			""Temporary immunity to lava and immunity to fire damage""
		],
		""name"": ""Heaume Hydrothermique"",
		""tooltip"": [
			""+12% de dégâts de mêlée et +10% de chances de coup critique de mêlée"",
			""+18% de vitesse de mêlée"",
			""Les attaques et les projectiles de mêlée enflamment les ennemis"",
			""Immunité temporaire à la lave et immunité au feu""
		]
	},
	{
		""id"": ""SilvaHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Helm"",
		""name"": ""Heaume Silva"",
		""tooltip"": [
			""+13% de dégâts et de chances de coup critique de mêlée""
		]
	},
	{
		""id"": ""StatigelHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Helm"",
		""englishTooltip"": [
			""10% increased melee damage and melee speed"",
			""7% increased melee critical strike chance""
		],
		""name"": ""Heaume Statigel"",
		""tooltip"": [
			""+10% de dégâts et de vitesse de mêlée"",
			""+7% de chances de coup critique de mêlée""
		]
	},
	{
		""id"": ""VictideHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Helm"",
		""englishTooltip"": [
			""5% increased melee damage""
		],
		""name"": ""Heaume Victide"",
		""tooltip"": [
			""+5% de dégâts de mêlée""
		]
	},
	{
		""id"": ""TarragonHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Helm"",
		""englishTooltip"": [
			""Helm of the disciple of ancients"",
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""5% increased damage reduction"",
			""10% increased melee damage and critical strike chance""
		],
		""name"": ""Heaume d'Estragon"",
		""tooltip"": [
			""Heaume du disciple des anciens"",
			""Immunité temporaire à la lave"",
			""Peut se déplacer librement dans les liquides"",
			""+5% de réduction des dégâts"",
			""+10% de dégâts et de chances de coup critique de mêlée""
		]
	},
	{
		""id"": ""BloodflareHornedMask"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Hydra Hood"",
		""englishTooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""20% increased magic damage, 10% increased magic critical strike chance, +100 max mana and 17% reduced mana usage""
		],
		""name"": ""Heaume d'Hydre Brûlesang"",
		""tooltip"": [
			""Vous pouvez vous déplacer librement dans les liquides et immunité temporaire à la lave"",
			""+20% de dégâts magiques, +10% de chances de coup critique magique, +100 mana maximum et 17% de réduction du coût de mana""
		]
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
		]
	},
	{
		""id"": ""DaedalusHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Helm"",
		""englishTooltip"": [
			""10% increased melee damage and critical strike chance"",
			""15% increased melee speed""
		],
		""name"": ""Heaume de Dédale"",
		""tooltip"": [
			""+10% de dégâts de de chances de coup critique de mêlée"",
			""+15% de vitesse de mêlée""
		]
	},
	{
		""id"": ""BloodflareHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Wyvern Helm"",
		""englishTooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""5% increased minion damage""
		],
		""name"": ""Heaume de Wyverne Brûlesang"",
		""tooltip"": [
			""Vous pouvez vous déplacer librement dans les liquides et immunité temporaire à la lave"",
			""+5% de dégâts des sbires""
		]
	},
	{
		""id"": ""AncientGodSlayerHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient God Slayer Helm"",
		""name"": ""Heaume de l'Ancien Déicide""
	},
	{
		""id"": ""GodSlayerHelmet"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Helmet"",
		""englishTooltip"": [
			""14% increased ranged damage and critical strike chance""
		],
		""name"": ""Heaume du Déicide"",
		""tooltip"": [
			""+14% de dégâts et de chances de coup critique à distance""
		]
	},
	{
		""id"": ""ReaverHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Helm"",
		""englishTooltip"": [
			""15% increased damage reduction but 30% decreased damage"",
			""+50 max life"",
			""Passively regenerates one health point every second""
		],
		""name"": ""Heaume du Saccageur"",
		""tooltip"": [
			""+15% de réduction de dégâts mais réduit vos dégâts de 30%"",
			""+50 vie maximum"",
			""Régénère un point de vie par seconde""
		]
	},
	{
		""id"": ""AuricTeslaPlumedHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Plumed Helm"",
		""englishTooltip"": [
			""20% increased rogue damage, critical strike chance and 5% increased movement speed"",
			""Not moving boosts all damage and critical strike chance""
		],
		""name"": ""Heaume à Plumes Tesla Aurique"",
		""tooltip"": [
			""+20% aux dégâts et aux chances de coup critique de voleur, +5% à la vitesse de mouvement"",
			""Rester immobile augmente tous les dégâts et les chances de coup critique""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""CalamityHood"",
		""type"": ""ITEM"",
		""englishName"": ""Hood of Calamity TOTRANSLATE"",
		""name"": ""Hood of Calamity""
	},
	{
		""id"": ""PlaguedPlateClock"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Clock"",
		""name"": ""Horloge Pestiférée""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ProfanedTrident"",
		""type"": ""ITEM"",
		""englishName"": ""Wrathwing"",
		""englishTooltip"": [
			""Throws an agile, homing winged spear that constantly spits fire"",
			""Stealth strikes create an eruption of cinders on hit""
		],
		""name"": ""Infernaile"",
		""tooltip"": [
			""Lance une lance ailée agile à tête chercheuse qui crache constamment du feu"",
			""Les attaques furtives invoquent une éruption de cendres quand elles touchent""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SeaMinnowJar"",
		""type"": ""ITEM"",
		""englishName"": ""Sea Minnow Jar"",
		""name"": ""Jarre du Vairon de Mer""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BeetleJuice"",
		""type"": ""ITEM"",
		""englishName"": ""Beetle Juice"",
		""name"": ""Jus de Scarabée""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""TheAbsorber"",
		""type"": ""ITEM"",
		""englishName"": ""The Absorber"",
		""englishTooltip"": [
			""5% increased movement and jump speed"",
			""+20 max life and mana"",
			""Standing still boosts life and mana regen"",
			""Increased defense, movement speed and damage reduction while submerged in liquid"",
			""Enemies take damage when they hit you"",
			""You emit a cloud of mushroom spores when you are hit"",
			""10% increased damage reduction"",
			""5% of the damage from enemy attacks is absorbed and converted into healing""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Sponge"",
		""type"": ""ITEM"",
		""englishName"": ""The Sponge"",
		""englishTooltip"": [
			""15% increased damage reduction"",
			""+30 max life and mana"",
			""5% increased movement and jump speed"",
			""Standing still boosts life and mana regen"",
			""Increased defense, movement speed and damage reduction while submerged in liquid"",
			""Enemies take damage when they hit you"",
			""You emit a cloud of mushroom spores when you are hit"",
			""6.25% of the damage from enemy attacks is absorbed and converted into healing""
		],
		""name"": ""L'Eponge"",
		""tooltip"": [
			""+15% de réduction des dégâts"",
			""+30 vie et mana maximum"",
			""+5% de vitesse de mouvement et de saut"",
			""Rester immobile augmente la régénération de vie et de mana"",
			""Augmente la défense, la vitesse de mouvement et la réduction des dégâts lorsque vous êtes immergé"",
			""Les ennemis prennent des dégâts quand ils vous touchent"",
			""Vous émettez une explosion de spores quand vous êtes touché"",
			""6,25% des dégâts infligés par les ennemis seront absorbés et rendus sous forme de points de vie""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""IbarakiBox"",
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
		""name"": ""La Boite de l'Ermite aux Cent Médicaments"",
		""tooltip"": [
			""Alors que la glace fond au printemps"",
			""et que les vagues lavent les cheveux de la vieille mousse..."",
			""Merci, Au revoir."",
			""Invoque le troisième sage"",
			""Utilisez avec le clic droit depuis la barre des raccourcis pour activer ou désactiver la bénédiction du troisième sage."",
			""Avec cette bénédiction, le joueur réapparaîtra avec sa vie pleine plutôt qu'avec la moitié.""
		]
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
		]
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
		]
	},
	{
		""id"": ""Judgement"",
		""type"": ""ITEM"",
		""englishName"": ""The Dance of Light"",
		""englishTooltip"": [
			""Barrages enemies with a hailstorm of Light Blades"",
			""'And in a flash of light, nothing remains'""
		],
		""name"": ""La Danse de Lumière"",
		""tooltip"": [
			""Bombarde les ennemis avec une tempête de lames de lumière"",
			""'Et en un éclair de lumière, il ne resta rien'""
		]
	},
	{
		""id"": ""KnowledgeBumblebirb"",
		""type"": ""ITEM"",
		""englishName"": ""The Dragonfolly"",
		""englishTooltip"": [
			""A failure of twisted scientific ambition; it appears our faulted arrogance over life has shown once more in the results."",
			""Originally intended to be a clone of the Jungle Dragon, these were left to roam about the jungle, attacking anything in their path.""
		],
		""name"": ""La Folie Draconique"",
		""tooltip"": [
			""L'echec d'une ambition scientifique pervertie; On dirait que notre arrogance mal placée envers la vie transparaît à nouveau dans ces résultats."",
			""Crées à l'origine pour être des clones du dragon de jungle, ils ont été relachés dans la jungle et attaquent tout ce qui croise leur chemin.""
		]
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
		]
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
		]
	},
	{
		""id"": ""TheFirstShadowflame"",
		""type"": ""ITEM"",
		""englishName"": ""The First Shadowflame"",
		""englishTooltip"": [
			""It is said that in the past, Prometheus descended from the heavens to grant man fire."",
			""If that were true, then it is surely the demons of hell that would have risen from below to do the same."",
			""Increases max minions by 1 and minions inflict the Shadowflame debuff on enemies.""
		],
		""name"": ""La Première Flamme d'Ombre"",
		""tooltip"": [
			""Il est dit que dans le passé, Prometheus descendit des cieux pour donner le feu aux hommes."",
			""Si c'était vrai, alors les démons de l'enfer en aurait probablement surgi pour en faire de même."",
			""+1 sbire maximum"",
			""Les sbires infligent la flamme d'ombre quand ils touchent.""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""TundraLeash"",
		""type"": ""ITEM"",
		""englishName"": ""Tundra Leash"",
		""englishTooltip"": [
			""Summons an angry dog mount""
		],
		""name"": ""Laisse de la Toundra"",
		""tooltip"": [
			""Invoque un chien en colère en tant que monture""
		]
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
		]
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
		]
	},
	{
		""id"": ""CrimsonCrusherBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Crimson Crusher Blade"",
		""englishTooltip"": [
			""Inflicts ichor and critical hits lower enemy contact damage""
		],
		""name"": ""Lame Broyeuse Carmin"",
		""tooltip"": [
			""Inflige l'ichor et les coups critique réduisent les dégâts de contact des ennemis""
		]
	},
	{
		""id"": ""GalacticaBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Galactus Blade"",
		""englishTooltip"": [
			""Forged with the fury of nuclear chaos"",
			""Launches a barrage of comets from the sky""
		],
		""name"": ""Lame Galactus"",
		""tooltip"": [
			""Forgée avec la furie du chaos nucléaire"",
			""Lance un barrage de comètes depuis le ciel""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""WulfrumBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Blade"",
		""name"": ""Lame Wulfrum""
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
		]
	},
	{
		""id"": ""BladeofEnmity"",
		""type"": ""ITEM"",
		""englishName"": ""Blade of Enmity"",
		""name"": ""Lame d'Inimitié""
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
		]
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
		]
	},
	{
		""id"": ""BiomeBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Broken Biome Blade"",
		""englishTooltip"": [
			""FUNCTION_DESC"",
			""Hold down RMB while standing still on flat ground to attune the weapon to the powers of the surrounding biome"",
			""Using RMB otherwise switches between the current attunement and an extra stored one"",
			""Main Attunement : [None]"",
			""Secondary Attunement: [None]""
		],
		""name"": ""Lame de Biome Brisée"",
		""tooltip"": [
			""FUNCTION_DESC"",
			""Maintenir le clic droit sans bouger sur une surface plate dans un biome aligne l'arme avec le biome environnant"",
			""Clic droit pour interchanger vos alignements actif et passif"",
			""Alignement actif : Aucun"",
			""Alignement passif : Aucun""
		]
	},
	{
		""id"": ""CrystalBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Crystal Blade"",
		""englishTooltip"": [
			""Fires slow-moving clouds of crystal dust""
		],
		""name"": ""Lame de Cristal"",
		""tooltip"": [
			""Tire de lents nuages de poussière de cristal""
		]
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
		]
	},
	{
		""id"": ""Warblade"",
		""type"": ""ITEM"",
		""englishName"": ""Warblade"",
		""englishTooltip"": [
			""Critical hits cleave enemy armor, reducing their defense by 15 and protection by 25%""
		],
		""name"": ""Lame de Guerre"",
		""tooltip"": [
			""Les coups critiques fendent l'armure ennemie, reduisant leur défense de 15 et leur protection de 25%""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""CorruptedCrusherBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Corrupted Crusher Blade"",
		""englishTooltip"": [
			""Inflicts cursed inferno and critical hits reduce enemy defense by 10""
		],
		""name"": ""Lame Écrasante Corrompue"",
		""tooltip"": [
			""Inflige les flammes maudites et les coups critiques réduisent la défense ennemie de 10""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PlaguedPlateLamp"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Lamp"",
		""name"": ""Lampe Pestiférée""
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
		]
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
		]
	},
	{
		""id"": ""UrchinSpear"",
		""type"": ""ITEM"",
		""englishName"": ""Urchin Spear"",
		""englishTooltip"": [
			""Poisons enemies and fires short-range stingers""
		],
		""name"": ""Lance d'Oursin"",
		""tooltip"": [
			""Empoisonne les ennemis et tire des épines à courte portée""
		]
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
		]
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
		]
	},
	{
		""id"": ""ExsanguinationLance"",
		""type"": ""ITEM"",
		""englishName"": ""Vulcanite Lance"",
		""englishTooltip"": [
			""Explodes on enemy hits and summons homing flares on critical hits""
		],
		""name"": ""Lance de Vulcanite"",
		""tooltip"": [
			""Explose en touchant les ennemis et invoque des décharges à tête chercheuse en cas de coup critique""
		]
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
		]
	},
	{
		""id"": ""SpatialLance"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Lance"",
		""englishTooltip"": [
			""Rend the cosmos asunder!"",
			""Fires a lance beam that splits multiple times as it travels""
		],
		""name"": ""Lance des Élements"",
		""tooltip"": [
			""Déchirez le cosmos en lambeaux!"",
			""Tire un rayon de lance qui se divisent plusieurs fois sur leur trajectoires""
		]
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
		]
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
		]
	},
	{
		""id"": ""MarniteSpear"",
		""type"": ""ITEM"",
		""englishName"": ""Marnite Spear"",
		""name"": ""Lance en Marnite""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PlaguedPlateLantern"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Lantern"",
		""name"": ""Lanterne Pestiférée""
	},
	{
		""id"": ""LanternoftheSoul"",
		""type"": ""ITEM"",
		""englishName"": ""Guidelight of Oblivion"",
		""englishTooltip"": [
			""Shadows dream of endless fire, flames devour and embers swoop"",
			""Summons a lantern turret to fight for you""
		],
		""name"": ""Lanterne de l'Oubli"",
		""tooltip"": [
			""Les ombres rêvent d'un feu sans fin, ou les flammes dévorent et les braises pleuvent"",
			""Invoque une lanterne tourelle qui combat à vos côtés""
		]
	},
	{
		""id"": ""CausticTearNonConsumable"",
		""type"": ""ITEM"",
		""englishName"": ""Caustic Tear"",
		""englishTooltip"": [
			""Toggles the acid rain in the Sulphurous Sea""
		],
		""name"": ""Larme Caustique"",
		""tooltip"": [
			""Active ou désactive le déluge toxique dans la mer de sulfure""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Zapper"",
		""type"": ""ITEM"",
		""englishName"": ""Lazinator"",
		""englishTooltip"": [
			""Zap""
		],
		""name"": ""Lazinator"",
		""tooltip"": [
			""Zap TOTRANSLATE""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""GrandDad"",
		""type"": ""ITEM"",
		""englishName"": ""Grand Dad"",
		""englishTooltip"": [
			""Lowers enemy defense to 0 when they are struck"",
			""Yeets enemies across space and time"",
			""7""
		],
		""name"": ""Le Grand-Père"",
		""tooltip"": [
			""Réduit la défense des ennemis à 0 lorsqu'ils sont touchés"",
			""Projette les ennemis à travers l'espace-temps"",
			""7""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BlightedLens"",
		""type"": ""ITEM"",
		""englishName"": ""Blighted Lens"",
		""name"": ""Lentille Obscurcie""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""KnowledgeLeviathanandSiren"",
		""type"": ""ITEM"",
		""englishName"": ""Leviathan and Anahita"",
		""englishTooltip"": [
			""An odd pair of creatures; one seeking companionship and the other seeking sustenance."",
			""Perhaps two genetic misfits outcast from their homes that found comfort in assisting one another.""
		],
		""name"": ""Leviathan et Anahita"",
		""tooltip"": [
			""Une paire de créature bien étrange; l'une cherchant de la compagnie et l'autre cherchant à se nourrir"",
			""Peut-être que ces deux anomalies géntiques exilées de leurs habitats ont trouvé du réconfort en s'aidant mutuellement.""
		]
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
		]
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
		]
	},
	{
		""id"": ""Chaotrix"",
		""type"": ""ITEM"",
		""englishName"": ""Fault Line"",
		""englishTooltip"": [
			""Explodes on enemy hits"",
			""A very agile yoyo""
		],
		""name"": ""Ligne Fautive"",
		""tooltip"": [
			""Explose en touchant les ennemis"",
			""Un yoyo très agile""
		]
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
		]
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
		]
	},
	{
		""id"": ""AstralBar"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Bar"",
		""name"": ""Lingot Astral""
	},
	{
		""id"": ""VerstaltiteBar"",
		""type"": ""ITEM"",
		""englishName"": ""Cryonic Bar"",
		""name"": ""Lingot Cryonique""
	},
	{
		""id"": ""CryoBar"",
		""type"": ""ITEM"",
		""englishName"": ""Frigid Bar"",
		""englishTooltip"": [
			""Cold to the touch""
		],
		""name"": ""Lingot Frigide"",
		""tooltip"": [
			""Froid au toucher""
		]
	},
	{
		""id"": ""DraedonBar"",
		""type"": ""ITEM"",
		""englishName"": ""Perennial Bar"",
		""name"": ""Lingot Vivace""
	},
	{
		""id"": ""AerialiteBar"",
		""type"": ""ITEM"",
		""englishName"": ""Aerialite Bar"",
		""name"": ""Lingot d'Aérialite""
	},
	{
		""id"": ""ShadowspecBar"",
		""type"": ""ITEM"",
		""englishName"": ""Shadowspec Bar"",
		""name"": ""Lingot d'Ombrespec""
	},
	{
		""id"": ""UeliaceBar"",
		""type"": ""ITEM"",
		""englishName"": ""Uelibloom Bar"",
		""name"": ""Lingot d'Ueliclosion""
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
		]
	},
	{
		""id"": ""CruptixBar"",
		""type"": ""ITEM"",
		""englishName"": ""Scoria Bar"",
		""englishTooltip"": [
			""The smoke feels warm""
		],
		""name"": ""Lingot de Scorie"",
		""tooltip"": [
			""La fumée semble chaude""
		]
	},
	{
		""id"": ""VictideBar"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Bar"",
		""name"": ""Lingot de Victide""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Lumenite"",
		""type"": ""ITEM"",
		""englishName"": ""Lumenyl"",
		""englishTooltip"": [
			""A shard of lumenous energy""
		],
		""name"": ""Lumenyl"",
		""tooltip"": [
			""Un fragment d'énergie lumineuse""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""LeadWizard"",
		""type"": ""ITEM"",
		""englishName"": ""Lead Wizard"",
		""englishTooltip"": [
			""Something's not right..."",
			""33% chance to not consume ammo""
		],
		""name"": ""Magicien de Plomb"",
		""tooltip"": [
			""Quelque chose cloche..."",
			""33% de chances de ne pas consommer de munitions""
		]
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
		]
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
		]
	},
	{
		""id"": ""MarkedMagnum"",
		""type"": ""ITEM"",
		""englishName"": ""Marked Magnum"",
		""englishTooltip"": [
			""Shots reduce enemy protection"",
			""This weapon scales with all your damage stats at once""
		],
		""name"": ""Magnum Marqué"",
		""tooltip"": [
			""Les tirs réduisent la protection des ennemis"",
			""Cette arme profite de toutes vos statistiques à la fois""
		]
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
		]
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
		]
	},
	{
		""id"": ""Malice"",
		""type"": ""ITEM"",
		""englishName"": ""Malice"",
		""englishTooltip"": [
			""Enables/disables Malice Mode, can only be used in Death Mode."",
			""[c/c01818:This mode is subjective, play how you want, don't expect to live.]"",
			""All effects from Death Mode are enabled, including the following:"",
			""Nerfs the effectiveness of life steal a bit more."",
			""Enrages all bosses and gives them far more aggressive AI."",
			""Bosses and their projectiles deal 25% more damage."",
			""Increases the velocity of most boss projectiles by 25%.""
		],
		""name"": ""Malice"",
		""tooltip"": [
			""Active/Désactive le mode Malice, utilisable uniquement en mode Mort."",
			""[c/c01818:Ce mode est subjectif, jouez comme vous voulez, ne vous attendez pas à y survivre.]"",
			""Tous les effets du mode Mort sont actifs, avec en plus:"",
			""Réduit l'efficacité de vol de vie encore un peu plus."",
			""Enrage tous les boss et les rends beaucoup plus agressifs."",
			""Les boss et leurs projectiles infligent 25% de dégâts en plus."",
			""Augmente la vitesse de la plupart des projectiles de boss de 25%.""
		]
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
		]
	},
	{
		""id"": ""StatisCurse"",
		""type"": ""ITEM"",
		""englishName"": ""Statis' Curse"",
		""englishTooltip"": [
			""Increases max minions by 3, does not stack with downgrades"",
			""10% increased minion damage"",
			""Increased minion knockback"",
			""Minions inflict holy flames and shadowflames on hit""
		],
		""name"": ""Malédiction de Statis"",
		""tooltip"": [
			""+3 sbires max et +10% dégâts d'invocation, ne se cumule pas avec les accessoires le composant"",
			""+10% de dégâts des sbires"",
			""Recul des sbires augmenté"",
			""Les sbires infligent les flammes d'ombres et sacrées quand ils touchent""
		]
	},
	{
		""id"": ""StormlionMandible"",
		""type"": ""ITEM"",
		""englishName"": ""Stormlion Mandible"",
		""name"": ""Mandibule de Fourmillon Tempête""
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
		]
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
		]
	},
	{
		""id"": ""DiscordianWings"",
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
		""name"": ""Manteau Hadal"",
		""tooltip"": [
			""Nourri par la fureur des profondeurs"",
			""Vitesse Horizontale: 7.75"",
			""Multiplicateur d'accélération: 1.5"",
			""Vitesse verticale moyenne"",
			""Temps de vol: 180"",
			""+5% de dégâts supplémentaires quand vous portez l'armure hydrothermique""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Mariana"",
		""type"": ""ITEM"",
		""englishName"": ""Mariana"",
		""englishTooltip"": [
			""Tropical and deadly"",
			""Enemies explode into water orbs on hit""
		],
		""name"": ""Mariana"",
		""tooltip"": [
			""Tropicale et mortelle"",
			""Les ennemis explosent en orbe d'eau quand ils sont touchés""
		]
	},
	{
		""id"": ""FlamebeakHampick"",
		""type"": ""ITEM"",
		""englishName"": ""Seismic Hampick"",
		""englishTooltip"": [
			""Capable of mining Lihzahrd Bricks"",
			""Left click to use as a pickaxe"",
			""Right click to use as a hammer""
		],
		""name"": ""Marpioche Sismique"",
		""tooltip"": [
			""Peut extraire les briques Lizhard"",
			""Clic gauche pour utiliser comme pioche"",
			""Clic droit pour utiliser comme marteau""
		]
	},
	{
		""id"": ""AstralHamaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Hamaxe"",
		""name"": ""Martache Astrale""
	},
	{
		""id"": ""AerialHamaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Aerial Hamaxe"",
		""name"": ""Martache Aérienne""
	},
	{
		""id"": ""ReefclawHamaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Reefclaw Hamaxe"",
		""name"": ""Martache de Récigriffe""
	},
	{
		""id"": ""WulfrumHammer"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Hammer"",
		""name"": ""Marteau Wulfrum""
	},
	{
		""id"": ""AbyssalWarhammer"",
		""type"": ""ITEM"",
		""englishName"": ""Abyssal Warhammer"",
		""name"": ""Marteau de Guerre Abyssal""
	},
	{
		""id"": ""PwnagehammerMelee"",
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
		]
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
		]
	},
	{
		""id"": ""TruePaladinsHammer"",
		""type"": ""ITEM"",
		""englishName"": ""Fallen Paladin's Hammer"",
		""englishTooltip"": [
			""Explodes on enemy hits""
		],
		""name"": ""Marteau du Paladin Déchu"",
		""tooltip"": [
			""Explose en touchant les ennemis""
		]
	},
	{
		""id"": ""TruePaladinsHammerMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Fallen Paladin's Hammer"",
		""englishTooltip"": [
			""Explodes on enemy hits""
		],
		""name"": ""Marteau du Paladin Déchu"",
		""tooltip"": [
			""Explose quand vous touchez les ennemis""
		]
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
		]
	},
	{
		""id"": ""BloodflareMask"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Ram Mask"",
		""englishTooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""10% increased melee damage and critical strike chance""
		],
		""name"": ""Masque Brûlesang de Ruée"",
		""tooltip"": [
			""Vous pouvez vous déplacer librement dans les liquides et immunité temporaire à la lave"",
			""+10% de dégâts et de chances de coup critique de mêlée""
		]
	},
	{
		""id"": ""XerocMask"",
		""type"": ""ITEM"",
		""englishName"": ""Empyrean Mask"",
		""englishTooltip"": [
			""Wrath of the cosmos"",
			""11% increased rogue damage and critical strike chance, 5% increased movement speed"",
			""Temporary immunity to lava""
		],
		""name"": ""Masque Empyréen"",
		""tooltip"": [
			""Îre du cosmos"",
			""+11% de dégâts et de chances de coup critique de voleur, +5% de vitesse de mouvement"",
			""Immunité temporaire à la lave""
		]
	},
	{
		""id"": ""AuricTeslaHoodedFacemask"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Hooded Facemask"",
		""englishTooltip"": [
			""30% increased ranged damage and critical strike chance"",
			""Not moving boosts all damage and critical strike chance""
		],
		""name"": ""Masque Facial Voilé Tesla Aurique"",
		""tooltip"": [
			""+30% de dégâts et de chances de coup critique à distance"",
			""Rester immobile augmente tous les dégâts et les chances de coup critique""
		]
	},
	{
		""id"": ""AtaxiaMask"",
		""type"": ""ITEM"",
		""englishName"": ""Hydrothermic Mask"",
		""englishTooltip"": [
			""12% increased magic damage, +100 max mana, and 10% increased magic critical strike chance"",
			""Temporary immunity to lava, and immunity to fire damage""
		],
		""name"": ""Masque Hydrothermique"",
		""tooltip"": [
			""+12% de dégâts magiques et +10% de chances de coup critique magique"",
			""+100 mana maximum, immunité temporaire à la lave, et immunité aux dégâts de feu""
		]
	},
	{
		""id"": ""StatigelMask"",
		""type"": ""ITEM"",
		""englishName"": ""Statigel Mask"",
		""englishTooltip"": [
			""10% increased rogue damage and 34% chance to not consume rogue items"",
			""7% increased rogue critical strike chance and 5% increased movement speed""
		],
		""name"": ""Masque Statigel"",
		""tooltip"": [
			""+10% de dégâts de voleur et 34% de chances de ne pas consommer les armes de voleur"",
			""+7% de chances de coup critique de voleur et +5% de vitesse de mouvement""
		]
	},
	{
		""id"": ""VictideMask"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Mask"",
		""englishTooltip"": [
			""5% increased magic damage""
		],
		""name"": ""Masque Victide"",
		""tooltip"": [
			""+5% de dégâts magiques""
		]
	},
	{
		""id"": ""WulfrumMask"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Mask"",
		""englishTooltip"": [
			""10% increased rogue damage""
		],
		""name"": ""Masque Wulfrum"",
		""tooltip"": [
			""+10% dégâts de voleur""
		]
	},
	{
		""id"": ""AnahitaMask"",
		""type"": ""ITEM"",
		""englishName"": ""Anahita Mask"",
		""name"": ""Masque d'Anahita""
	},
	{
		""id"": ""AureusMask"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Aureus Mask"",
		""name"": ""Masque d'Astrum Aureus""
	},
	{
		""id"": ""AstrumDeusMask"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Deus Mask"",
		""name"": ""Masque d'Astrum Deus""
	},
	{
		""id"": ""TarragonMask"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Mask"",
		""englishTooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""20% increased magic damage and 10% increased magic critical strike chance"",
			""5% increased damage reduction, +100 max mana, and 15% reduced mana usage""
		],
		""name"": ""Masque d'Estragon"",
		""tooltip"": [
			""Immunité temporaire à la lave"",
			""Vous pouvez vous déplacer librement dans les liquides"",
			""+20% de dégâts magiques et +10% de chances de coup critique magique"",
			""+5% de réduction de dégâts, +100 mana maximum et 15% de réduction du coût en mana""
		]
	},
	{
		""id"": ""BrimstoneWaifuMask"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Elemental Mask"",
		""name"": ""Masque d'Élementaire de Soufre""
	},
	{
		""id"": ""CalamitasMask"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitas Mask"",
		""name"": ""Masque de Calamitas""
	},
	{
		""id"": ""CrabulonMask"",
		""type"": ""ITEM"",
		""englishName"": ""Crabulon Mask"",
		""name"": ""Masque de Crabulon""
	},
	{
		""id"": ""CryogenMask"",
		""type"": ""ITEM"",
		""englishName"": ""Cryogen Mask"",
		""name"": ""Masque de Cryogène""
	},
	{
		""id"": ""BloodflareHelm"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodflare Imp Mask"",
		""englishTooltip"": [
			""You can move freely through liquids and have temporary immunity to lava"",
			""10% increased rogue damage and critical strike chance, 5% increased movement speed""
		],
		""name"": ""Masque de Diablotin Brûlesang"",
		""tooltip"": [
			""Vous pouvez vous déplacer librement dans les liquides et immunité temporaire à la lave"",
			""+10% de dégâts et de chances de coup critique de voleur et +5% de vitesse de mouvement""
		]
	},
	{
		""id"": ""DaedalusHeadgear"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Mask"",
		""englishTooltip"": [
			""5% increased minion damage""
		],
		""name"": ""Masque de Dédale"",
		""tooltip"": [
			""+5% de dégâts des sbires""
		]
	},
	{
		""id"": ""AquaticScourgeMask"",
		""type"": ""ITEM"",
		""englishName"": ""Aquatic Scourge Mask"",
		""name"": ""Masque de Fléau Aquatique""
	},
	{
		""id"": ""ProvidenceMask"",
		""type"": ""ITEM"",
		""englishName"": ""Providence Mask"",
		""name"": ""Masque de Providence""
	},
	{
		""id"": ""SignusMask"",
		""type"": ""ITEM"",
		""englishName"": ""Signus Mask"",
		""name"": ""Masque de Signus""
	},
	{
		""id"": ""DaedalusVisor"",
		""type"": ""ITEM"",
		""englishName"": ""Daedalus Facemask"",
		""englishTooltip"": [
			""13% increased rogue damage and 7% increased rogue critical strike chance, increases rogue velocity by 15%"",
			""5% increased movement speed""
		],
		""name"": ""Masque de Visage de Dédale"",
		""tooltip"": [
			""+13% de dégâts de voleur et +7% de chances de coup critique de voleur, +15% de vitesse des projectiles de voleur"",
			""+5% de vitesse de mouvement""
		]
	},
	{
		""id"": ""YharonMask"",
		""type"": ""ITEM"",
		""englishName"": ""Yharon Mask"",
		""name"": ""Masque de Yharon""
	},
	{
		""id"": ""HiveMindMask"",
		""type"": ""ITEM"",
		""englishName"": ""Hive Mind Mask"",
		""name"": ""Masque de l'Esprit de Ruche""
	},
	{
		""id"": ""PolterghastMask"",
		""type"": ""ITEM"",
		""englishName"": ""Polterghast Mask"",
		""name"": ""Masque de l'Épouvantôme""
	},
	{
		""id"": ""BumblefuckMask"",
		""type"": ""ITEM"",
		""englishName"": ""Dragonfolly Mask"",
		""name"": ""Masque de la Dracofolie""
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
		]
	},
	{
		""id"": ""SlimeGodMask"",
		""type"": ""ITEM"",
		""englishName"": ""Slime God Mask"",
		""name"": ""Masque du Dieu des Gelées""
	},
	{
		""id"": ""SlimeGodMask2"",
		""type"": ""ITEM"",
		""englishName"": ""Slime God Mask"",
		""name"": ""Masque du Dieu des Gelées""
	},
	{
		""id"": ""GodSlayerMask"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Mask"",
		""englishTooltip"": [
			""14% increased rogue damage and critical strike chance, 5% increased movement speed""
		],
		""name"": ""Masque du Déicide"",
		""tooltip"": [
			""+14% de dégâts et de chances de coup critique de voleur, +5% de vitesse de mouvement""
		]
	},
	{
		""id"": ""DevourerofGodsMask"",
		""type"": ""ITEM"",
		""englishName"": ""Devourer of Gods Mask"",
		""name"": ""Masque du Dévoreur de Dieux""
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
		]
	},
	{
		""id"": ""DesertScourgeMask"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Scourge Mask"",
		""name"": ""Masque du Fléau du Désert""
	},
	{
		""id"": ""ProfanedGuardianMask"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Guardian Mask"",
		""name"": ""Masque du Gardien Profané""
	},
	{
		""id"": ""PlaguebringerGoliathMask"",
		""type"": ""ITEM"",
		""englishName"": ""Plaguebringer Goliath Mask"",
		""name"": ""Masque du Goliath Colporte-Peste""
	},
	{
		""id"": ""LeviathanMask"",
		""type"": ""ITEM"",
		""englishName"": ""Leviathan Mask"",
		""name"": ""Masque du Leviathan""
	},
	{
		""id"": ""CeaselessVoidMask"",
		""type"": ""ITEM"",
		""englishName"": ""Ceaseless Void Mask"",
		""name"": ""Masque du Néant Incessant""
	},
	{
		""id"": ""PerforatorMask"",
		""type"": ""ITEM"",
		""englishName"": ""Perforator Mask"",
		""name"": ""Masque du Perforateur""
	},
	{
		""id"": ""RavagerMask"",
		""type"": ""ITEM"",
		""englishName"": ""Ravager Mask"",
		""name"": ""Masque du Ravageur""
	},
	{
		""id"": ""ReaverMask"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Mask"",
		""englishTooltip"": [
			""15% increased magic damage, 12% reduced mana cost, and 5% increased magic critical strike chance"",
			""10% increased movement speed, can move freely through liquids, and +80 max mana""
		],
		""name"": ""Masque du Saccageur"",
		""tooltip"": [
			""+15% de dégâts magiques, 12% de réduction du coût en mana et +5% de chances de coup critique magique"",
			""+10% de vitesse de mouvement, +80 de mana maximum, et vous pouvez vous déplacer librement dans les liquides""
		]
	},
	{
		""id"": ""StormWeaverMask"",
		""type"": ""ITEM"",
		""englishName"": ""Storm Weaver Mask"",
		""name"": ""Masque du Tisse-Tempête""
	},
	{
		""id"": ""OldDukeMask"",
		""type"": ""ITEM"",
		""englishName"": ""Old Duke Mask"",
		""name"": ""Masque du Vieux Dic""
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
		]
	},
	{
		""id"": ""TrueShadowScale"",
		""type"": ""ITEM"",
		""englishName"": ""Rotten Matter"",
		""name"": ""Matière pourrie""
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
		]
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
		]
	},
	{
		""id"": ""McNuggets"",
		""type"": ""ITEM"",
		""englishName"": ""McNuggets TOTRANSLATE"",
		""englishTooltip"": [
			""These chicken nuggets aren't for you to eat!""
		],
		""name"": ""McNuggets"",
		""tooltip"": [
			""These chicken nuggets aren't for you to eat!""
		]
	},
	{
		""id"": ""HadarianMembrane"",
		""type"": ""ITEM"",
		""englishName"": ""Hadarian Membrane"",
		""englishTooltip"": [
			""The membrane of an astral creature's wings""
		],
		""name"": ""Membrane Hadarienne"",
		""tooltip"": [
			""La membrane des ailes d'une créature astrale""
		]
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
		]
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
			""\"" + CalamityUtils.ColorMessage(\""A contemplated possible future of the cosmic serpent\"", CalamityGlobalItem.ExhumedTooltipColor)"",
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
		]
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
		]
	},
	{
		""id"": ""LatcherMine"",
		""type"": ""ITEM"",
		""englishName"": ""Latcher Mine"",
		""englishTooltip"": [
			""Sticks to enemies on hit and detonates after 3 seconds."",
			""Breaks upon hitting blocks"",
			""Stealth Strike Effect: On explosion, fire and shrapnel are released"",
			""Stealth strike mines can stick to the ground and last much longer when doing so""
		],
		""name"": ""Mine à Crochets"",
		""tooltip"": [
			""Se fixe aux ennemis et explose après trois secondes."",
			""Se brise au contact des tuiles"",
			""Effet d'attaque furtive: A l'explosion, des éclats et des flammes sont libérés"",
			""Les mines furtives peuvent également se fixer au sol et durent bien plus longtemps""
		]
	},
	{
		""id"": ""AstralOre"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Ore"",
		""name"": ""Minerai Astral""
	},
	{
		""id"": ""AuricOre"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Ore"",
		""name"": ""Minerai Aurique""
	},
	{
		""id"": ""CharredOre"",
		""type"": ""ITEM"",
		""englishName"": ""Charred Ore"",
		""name"": ""Minerai Calciné""
	},
	{
		""id"": ""CryonicOre"",
		""type"": ""ITEM"",
		""englishName"": ""Cryonic Ore"",
		""name"": ""Minerai Cryonique""
	},
	{
		""id"": ""UelibloomOre"",
		""type"": ""ITEM"",
		""englishName"": ""Uelibloom Ore"",
		""name"": ""Minerai D'Ueliclosion""
	},
	{
		""id"": ""PerennialOre"",
		""type"": ""ITEM"",
		""englishName"": ""Perennial Ore"",
		""name"": ""Minerai Vivace""
	},
	{
		""id"": ""AerialiteOre"",
		""type"": ""ITEM"",
		""englishName"": ""Aerialite Ore"",
		""name"": ""Minerai d'Aérialite""
	},
	{
		""id"": ""ChaoticOre"",
		""type"": ""ITEM"",
		""englishName"": ""Scoria Ore"",
		""name"": ""Minerai de Scories""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Moonshine"",
		""type"": ""ITEM"",
		""englishName"": ""Moonshine"",
		""englishTooltip"": [
			""This stuff is pretty strong but I'm sure you can handle it"",
			""Increases defense by 10 and damage reduction by 5%"",
			""Reduces life regen by 1""
		],
		""name"": ""Moonshine"",
		""tooltip"": [
			""Ce truc est plutôt fort mais je suis sûr que tu peux l'encaisser"",
			""Augmente la défense de 10 et la réduction de dégâts de 5%"",
			""Réduit la régénération de vie de 1""
		]
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
		]
	},
	{
		""id"": ""SerpentsBite"",
		""type"": ""ITEM"",
		""englishName"": ""Serpent's Bite"",
		""englishTooltip"": [
			""Reach: {28.125f}"",
			""Launch Velocity: {18f}"",
			""Reelback Velocity: {14f}"",
			""Pull Velocity: {12f}""
		],
		""name"": ""Morsure du Serpent"",
		""tooltip"": [
			""Portée: 28.125"",
			""Vitesse de Lancer: 18"",
			""Vitesse de Rétractation: 14"",
			""Vitesse de Traction 12""
		]
	},
	{
		""id"": ""Death"",
		""type"": ""ITEM"",
		""englishName"": ""Death"",
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
		""name"": ""Mort"",
		""tooltip"": [
			""Active/désactive le mode Mort, ne peut être utilisé qu'en monde Revengeance"",
			""Tous les effets du mode Revengeance sont actifs, en plus des effets suivants:"",
			""Augmente les dégâts de certains projectiles et ennemis (hors boss) de 6% à 15%."",
			""Augmente énormement le nombres d'ennemis durant une lune sanglante."",
			""Réduit un peu plus l'efficacité du vol de vie."",
			""Rends les abysses plus perfides à explorer."",
			""L'infirmière ne vous soignera pas si un boss est actif."",
			""Augmente les dégâts de plusieurs altérations d'état de 50% et de tous les alcools qui réduisent la régénération de vie."",
			""Change le comportement de tous les boss et de certains ennemis."",
			""Augmente un peu plus les dégâts des boss.""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ChaoticSpreadRod"",
		""type"": ""ITEM"",
		""englishName"": ""Rift Reeler"",
		""englishTooltip"": [
			""Fires three to five lines at once. Can fish in lava."",
			""The battlefield is a scene of constant chaos."",
			""The winner will be the one who controls that chaos, both the pole and the fish.""
		],
		""name"": ""Moulinet de Faille"",
		""tooltip"": [
			""Lance 3 à 5 lignes à la fois. Vous pouvez pêcher dans la lave."",
			""Le champ de bataille est une scene de chaos constant."",
			""Le gagnant sera celui qui contrôle ce chaos, à la fois la canne et le poisson.""
		]
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
		]
	},
	{
		""id"": ""MoscowMule"",
		""type"": ""ITEM"",
		""englishName"": ""Moscow Mule"",
		""englishTooltip"": [
			""I once heard the copper mug can be toxic and I told 'em 'listen dummy, I'm already poisoning myself'"",
			""Boosts damage and knockback by 9% and critical strike chance by 3%"",
			""Reduces life regen by 2""
		],
		""name"": ""Mule de Moscou"",
		""tooltip"": [
			""Un jour, on m'a dit que le mug en cuivre était peut-être toxique, et je lui ai répondu 'Écoute l'andouille, je suis déjà en train de m'empoisonner'"",
			""Augmente les dégâts et le recul de 9% et les chances de coup critique de 3%"",
			""Réduit la régénération de vie de 2""
		]
	},
	{
		""id"": ""AstralGrassWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Grass Wall"",
		""name"": ""Mur d'Herbe Astrale""
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
		]
	},
	{
		""id"": ""PlaguedPlateWall"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Containment Wall"",
		""name"": ""Mur de Confinement Pestiféré""
	},
	{
		""id"": ""AbyssGravelWallItem"",
		""type"": ""ITEM"",
		""englishName"": ""Abyss Gravel Wall"",
		""name"": ""Mur de Gravier des Abysses""
	},
	{
		""id"": ""AstralSandstoneWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Sandstone Wall"",
		""name"": ""Mur de Grès Astral""
	},
	{
		""id"": ""SulphurousSandstoneWall"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Sandstone Wall"",
		""name"": ""Mur de Grès Sulfureux""
	},
	{
		""id"": ""AstralSnowWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Snow Wall"",
		""name"": ""Mur de Neige Astrale""
	},
	{
		""id"": ""AstralStoneWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Stone Wall"",
		""name"": ""Mur de Pierre Astrale""
	},
	{
		""id"": ""PlagueContainmentCellsWall"",
		""type"": ""ITEM"",
		""englishName"": ""Plagueplate Wall"",
		""name"": ""Mur de Plaque Pestiférée""
	},
	{
		""id"": ""AstralFossilWall"",
		""type"": ""ITEM"",
		""englishName"": ""Celestial Remains Wall"",
		""name"": ""Mur de Restes Célestes""
	},
	{
		""id"": ""HardenedAstralSandWall"",
		""type"": ""ITEM"",
		""englishName"": ""Hardened Astral Sand Wall"",
		""name"": ""Mur de Sable Astral Durci""
	},
	{
		""id"": ""SulphurousSandWall"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Sand Wall"",
		""name"": ""Mur de Sable Sulfureux""
	},
	{
		""id"": ""HardenedSulphurousSandstoneWall"",
		""type"": ""ITEM"",
		""englishName"": ""Hardened Sulphurous Sandstone Wall"",
		""name"": ""Mur de Sable Sulfureux Durci""
	},
	{
		""id"": ""AstralDirtWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Dirt Wall"",
		""name"": ""Mur de Terre Astral""
	},
	{
		""id"": ""AstralIceWall"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Ice Wall"",
		""name"": ""Mur de glace astrale""
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
		]
	},
	{
		""id"": ""AethersWhisper"",
		""type"": ""ITEM"",
		""englishName"": ""Aether's Whisper"",
		""englishTooltip"": [
			""Inflicts long-lasting shadowflame and splits on tile hits"",
			""Projectiles gain damage as they travel"",
			""Right click to change from magic to ranged damage"",
			""Right click consumes no mana""
		],
		""name"": ""Murmure d'Aether"",
		""tooltip"": [
			""Inflige la flamme sombre sur une longue période et se divise au contact des tuiles"",
			""Les dégâts des projectiles augmentent en fonction de la distance parcourue"",
			""Clic droit pour effectuer une attaque à distance au lieu d'une attaque magique"",
			""Le clic droit ne consomme pas de mana""
		]
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
		]
	},
	{
		""id"": ""MysteriousMechanism"",
		""type"": ""ITEM"",
		""englishName"": ""Lab Seeking Mechanism"",
		""englishTooltip"": [
			""A receptacle for technology which pinpoints the power cores of Draedon's Labs""
		],
		""name"": ""Mécanisme Chercheur de Laboratoire"",
		""tooltip"": [
			""Un receptacle de technologie qui localise les noyaux d'alimentation des laboratoires de Draedon""
		]
	},
	{
		""id"": ""BrimstoneSlag"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Slag"",
		""name"": ""Mâchefer de soufre""
	},
	{
		""id"": ""RustyMedallion"",
		""type"": ""ITEM"",
		""englishName"": ""Rusty Medallion"",
		""englishTooltip"": [
			""Causes most ranged weapons to sometimes release acid droplets from the sky""
		],
		""name"": ""Médaillon Rouillé"",
		""tooltip"": [
			""La plupart des armes à distance feront parfois pleuvoir de l'acide""
		]
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
		]
	},
	{
		""id"": ""DriedSeafood"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Medallion"",
		""englishTooltip"": [
			""Summons the Desert Scourge when used in the desert"",
			""Not consumable""
		],
		""name"": ""Médaillon du Desert"",
		""tooltip"": [
			""Invoque le Fléau du Désert quand utilisé dans le désert"",
			""Non consommable""
		]
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
		]
	},
	{
		""id"": ""StellarContemptRogue"",
		""type"": ""ITEM"",
		""englishName"": ""Stellar Contempt"",
		""englishTooltip"": [
			""Lunar flares rain down on enemy hits""
		],
		""name"": ""Mépris Stellaire"",
		""tooltip"": [
			""Des lueurs lunaires pleuvent quand vous touchez les ennemis""
		]
	},
	{
		""id"": ""StellarContemptMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Stellar Contempt"",
		""englishTooltip"": [
			""Lunar flares rain down on enemy hits""
		],
		""name"": ""Mépris Stellaire"",
		""tooltip"": [
			""Fait pleuvoir des lueurs lunaires quand vous touchez les ennemis""
		]
	},
	{
		""id"": ""EnchantedMetal"",
		""type"": ""ITEM"",
		""englishName"": ""Enchanted Metal"",
		""name"": ""Métal Enchanté""
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
		]
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
		]
	},
	{
		""id"": ""Purge"",
		""type"": ""ITEM"",
		""englishName"": ""Nano Purge"",
		""englishTooltip"": [
			""Fires a barrage of nano lasers""
		],
		""name"": ""Nano Purge"",
		""tooltip"": [
			""Tire un barrage de nano lasers""
		]
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
		]
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
		]
	},
	{
		""id"": ""NavystoneWallSafe"",
		""type"": ""ITEM"",
		""englishName"": ""Navystone Wall"",
		""name"": ""Navystone Wall TOTRANSLATE""
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
		]
	},
	{
		""id"": ""AstralSnow"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Snow"",
		""name"": ""Neige Astrale""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Norfleet"",
		""type"": ""ITEM"",
		""englishName"": ""Norfleet"",
		""name"": ""Norfleet TOTRANSLATE""
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
		]
	},
	{
		""id"": ""BirdSeed"",
		""type"": ""ITEM"",
		""englishName"": ""Folly Feed"",
		""englishTooltip"": [
			""Summons a monstrosity""
		],
		""name"": ""Nourriture pour Folies"",
		""tooltip"": [
			""Invoque une monstruosité""
		]
	},
	{
		""id"": ""BlazingCore"",
		""type"": ""ITEM"",
		""englishName"": ""Blazing Core"",
		""englishTooltip"": [
			""The searing core of the profaned goddess"",
			""10% damage reduction"",
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
		]
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
		]
	},
	{
		""id"": ""ProfanedCore"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Core"",
		""englishTooltip"": [
			""The core of the unholy flame"",
			""Summons Providence"",
			""Should be used during daytime""
		],
		""name"": ""Noyau Profané"",
		""tooltip"": [
			""Le noyau de la flamme impie"",
			""Invoque Providence"",
			""Devrait-être utilisé la journée""
		]
	},
	{
		""id"": ""ProfanedCoreUnlimited"",
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
			""Invoque Providence quand utilisé dans le sacré ou en enfer"",
			""Devrait-être utilisé la journée"",
			""Ne se consomme pas""
		]
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
		]
	},
	{
		""id"": ""CoreofEleum"",
		""type"": ""ITEM"",
		""englishName"": ""Core of Eleum"",
		""name"": ""Noyau d'Eleum""
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
		]
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
		]
	},
	{
		""id"": ""CoreofCalamity"",
		""type"": ""ITEM"",
		""englishName"": ""Core of Calamity"",
		""name"": ""Noyau de Calamité""
	},
	{
		""id"": ""CoreofChaos"",
		""type"": ""ITEM"",
		""englishName"": ""Core of Chaos"",
		""name"": ""Noyau de Chaos""
	},
	{
		""id"": ""LeadCore"",
		""type"": ""ITEM"",
		""englishName"": ""Lead Core"",
		""englishTooltip"": [
			""Grants immunity to the irradiated debuff""
		],
		""name"": ""Noyau de Plomb"",
		""tooltip"": [
			""Immunité à l'irradiation""
		]
	},
	{
		""id"": ""CoreofCinder"",
		""type"": ""ITEM"",
		""englishName"": ""Core of Sunlight"",
		""name"": ""Noyau de Soleil""
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
		]
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
		]
	},
	{
		""id"": ""CoreOfTheBloodGod"",
		""type"": ""ITEM"",
		""englishName"": ""Core of the Blood God"",
		""englishTooltip"": [
			""8% increased damage and damage reduction"",
			""Boosts your max HP by 10%"",
			""Healing Potions are 15% more effective"",
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
		]
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
		]
	},
	{
		""id"": ""Nucleogenesis"",
		""type"": ""ITEM"",
		""englishName"": ""Nucleogenesis"",
		""englishTooltip"": [
			""Increases max minions by 4, does not stack with downgrades"",
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
		]
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
		]
	},
	{
		""id"": ""TwistingNether"",
		""type"": ""ITEM"",
		""englishName"": ""Twisting Nether"",
		""name"": ""Néant Tournoyant""
	},
	{
		""id"": ""VoidofExtinction"",
		""type"": ""ITEM"",
		""englishName"": ""Void of Extinction"",
		""englishTooltip"": [
			""No longer cursed"",
			""Drops brimstone fireballs from the sky occasionally"",
			""15% increase to all damage"",
			""Brimstone fire rains down while invincibility is active"",
			""Temporary immunity to lava, greatly reduces lava burn damage, and 25% increased damage while in lava""
		],
		""name"": ""Néant de l'Extinction"",
		""tooltip"": [
			""La malédiction est levée"",
			""Fait tomber des boules de feu de soufre occasionnellement"",
			""+15% à tous les dégâts"",
			""Du feu de soufre pleut durant vos périodes d'invincibilité"",
			""Immunité temporaire à la lave, réduit grandement les dégâts de la brûlure de lave et augmente les dégâts de 25% quand vous êtes dans la lave""
		]
	},
	{
		""id"": ""CalamityRing"",
		""type"": ""ITEM"",
		""englishName"": ""Void of Calamity"",
		""englishTooltip"": [
			""Cursed? Reduces damage reduction by 10%"",
			""15% increase to all damage"",
			""Brimstone fire rains down while invincibility is active""
		],
		""name"": ""Néant de la Calamité"",
		""tooltip"": [
			""Maudit ? Diminue la réduction des dégâts de 10%"",
			""15% de dégâts supplémentaires"",
			""Il pleut du feu de soufre durant vos périodes d'invincibilité""
		]
	},
	{
		""id"": ""MarniteObliterator"",
		""type"": ""ITEM"",
		""englishName"": ""Marnite Obliterator"",
		""name"": ""Oblitérateur de Marnite""
	},
	{
		""id"": ""TheEyeofCalamitas"",
		""type"": ""ITEM"",
		""englishName"": ""Oblivion"",
		""englishTooltip"": [
			""Fires brimstone lasers when enemies are near"",
			""A very agile yoyo""
		],
		""name"": ""Oblivion"",
		""tooltip"": [
			""Tire des lasers de soufre quand les ennemis en sont proches"",
			""Un yoyo très agile""
		]
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
		]
	},
	{
		""id"": ""OccultSkullCrown"",
		""type"": ""ITEM"",
		""englishName"": ""Occult Skull Crown TOTRANSLATE"",
		""englishTooltip"": [
			""Only a fool would ever wear this..."",
			""You constantly gain rage over time and rage does not fade away when out of combat"",
			""Converts certain debuffs into buffs and extends their durations"",
			""Debuffs affected: Darkness, Blackout, Confused, Slow, Weak, Broken Armor,"",
			""Armor Crunch, War Cleave, Chilled, Ichor and Obstructed"",
			""Getting hit causes you to only lose half of your max adrenaline rather than all of it"",
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
			""Getting hit causes you to only lose half of your max adrenaline rather than all of it"",
			""Increases your max movement speed and acceleration by 5%"",
			""Can also be worn as a helmet"",
			""Revengeance item""
		]
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
		]
	},
	{
		""id"": ""BlightedEyeball"",
		""type"": ""ITEM"",
		""englishName"": ""Eye of Desolation"",
		""englishTooltip"": [
			""Tonight is going to be a horrific night..."",
			""Summons Calamitas when used during nighttime"",
			""Not consumable""
		],
		""name"": ""Oeil de Désolation"",
		""tooltip"": [
			""Cette nuit va être horrifique..."",
			""Invoque Calamitas quand utilisé la nuit"",
			""Ne se consomme pas""
		]
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
		]
	},
	{
		""id"": ""BearEye"",
		""type"": ""ITEM"",
		""englishName"": ""Bear's Eye"",
		""englishTooltip"": [
			""Summons a pet guardian angel""
		],
		""name"": ""Oeil de l'Ours"",
		""tooltip"": [
			""Invoque un comapgnon ange gardien""
		]
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
		]
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
		]
	},
	{
		""id"": ""ChickenEgg"",
		""type"": ""ITEM"",
		""englishName"": ""Jungle Dragon Egg"",
		""englishTooltip"": [
			""An imitation of the egg that bore the loyal guardian of the tyrant king"",
			""Summons Jungle Dragon, Yharon when used in the jungle"",
			""Not consumable""
		],
		""name"": ""Oeuf de Dragon de Jungle"",
		""tooltip"": [
			""Une imitation de l'oeuf ayant porté le loyal gardien du roi tyrannique"",
			""Invoque le Dragon de Jungle, Yharon quand utilisé dans la jungle"",
			""Ne se consomme pas""
		]
	},
	{
		""id"": ""MLGRune2"",
		""type"": ""ITEM"",
		""englishName"": ""Celestial Onion"",
		""englishTooltip"": [
			""Alien power pulses inside its layers"",
			""Consuming it does something that cannot be reversed""
		],
		""name"": ""Oignon Céleste"",
		""tooltip"": [
			""Un pouvoir alien bat dans ses couches"",
			""Le consommer fait quelque chose qui ne peut pas être défait""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BloodOrb"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Orb"",
		""name"": ""Orbe de Sang""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SurfClam"",
		""type"": ""ITEM"",
		""englishName"": ""Surf Clam"",
		""name"": ""Palourde de Surf""
	},
	{
		""id"": ""ThePlaguebringer"",
		""type"": ""ITEM"",
		""englishName"": ""Pandemic"",
		""englishTooltip"": [
			""Fires plague seekers when enemies are near"",
			""A very agile yoyo""
		],
		""name"": ""Pandémie"",
		""tooltip"": [
			""Tire des cherche-peste quand des ennemis sont proches"",
			""Un yoyo très agile""
		]
	},
	{
		""id"": ""LaboratoryElectricPanelItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Electric Panel"",
		""name"": ""Panneau Électrique de Laboratoire""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SulfurLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Leggings"",
		""englishTooltip"": [
			""Movement speed increased by 10%"",
			""Movement speed increased by 35% while submerged in liquid""
		],
		""name"": ""Pantalon Sulfureux"",
		""tooltip"": [
			""+10% de vitesse de mouvement"",
			""+35% de vitesse de mouvement quand vous êtes immergé""
		]
	},
	{
		""id"": ""VictideLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Leggings"",
		""englishTooltip"": [
			""Movement speed increased by 8%"",
			""Movement speed increased by 30% while submerged in liquid""
		],
		""name"": ""Pantalon Victide"",
		""tooltip"": [
			""+8% de vitesse de mouvement"",
			""+30% de vitesse de mouvement quand vous êtes immergé""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SparksSummon"",
		""type"": ""ITEM"",
		""englishName"": ""Enchanted Butterfly"",
		""englishTooltip"": [
			""Feed him butterflies to keep him strong!"",
			""Summons a mysterious dragonfly light pet"",
			""Provides a small amount of light in the abyss""
		],
		""name"": ""Papillon Enchanté"",
		""tooltip"": [
			""Nourrissez-le de papillons pour le garder en forme!"",
			""Invoque une mystérieuse libellule lumineuse"",
			""Émet une petite quantité de lumière dans les abysses""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BensUmbrella"",
		""type"": ""ITEM"",
		""englishName"": ""Temporal Umbrella"",
		""englishTooltip"": [
			""Surprisingly sturdy, I reckon this could defeat the Mafia in a single blow"",
			""Summons a magic hat to hover above your head"",
			""The hat will release a variety of objects to assault your foes"",
			""Requires 5 minion slots to use and there can only be one hat""
		],
		""name"": ""Parapluie Temporel"",
		""tooltip"": [
			""Surprenamment solide, je pense qu'on pourrait battre la Mafia d'un seul coup avec ça"",
			""Invoque un chapeau magique qui flotte au dessus de votre tête"",
			""Le chapeau relâchera une variété d'objets pour assaillir vos ennemis"",
			""Occupe 5 emplacements de sbires"",
			""Il ne peut y avoir qu'un seul chapeau""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""LureofEnthrallment"",
		""type"": ""ITEM"",
		""englishName"": ""Pearl of Enthrallment"",
		""englishTooltip"": [
			""Summons a water elemental to fight for you"",
			""The elemental stays above you, shooting water spears, ice mist, and treble clefs at nearby enemies""
		],
		""name"": ""Perle de Subjugation"",
		""tooltip"": [
			""Invoque un élémentaire d'eau pour combattre à vos côtés"",
			""L'élémentaire reste au dessus de vous, tire des lances aquatiques, du brouillard de givre, et des clés de sol sur les ennemis""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PhantoplasmDye"",
		""type"": ""ITEM"",
		""englishName"": ""Phantoplasm Dye"",
		""name"": ""Phantoplasm Dye TOTRANSLATE""
	},
	{
		""id"": ""Phantoplasm"",
		""type"": ""ITEM"",
		""englishName"": ""Phantoplasm"",
		""name"": ""Phantoplasme""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BirbPheromones"",
		""type"": ""ITEM"",
		""englishName"": ""Exotic Pheromones"",
		""englishTooltip"": [
			""Attracts the failed draconic experiment"",
			""Summons The Dragonfolly when used in the jungle"",
			""Not consumable""
		],
		""name"": ""Phéromones Exotiques"",
		""tooltip"": [
			""Attire l'expérience draconique ratée"",
			""Invoque la folie draconique quand utilisée dans la jungle"",
			""Non consommable""
		]
	},
	{
		""id"": ""PlaguedPlatePiano"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Piano"",
		""name"": ""Piano Pestiféré""
	},
	{
		""id"": ""AstralStone"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Stone"",
		""name"": ""Pierre Astrale""
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
		]
	},
	{
		""id"": ""Navystone"",
		""type"": ""ITEM"",
		""englishName"": ""Navystone"",
		""name"": ""Pierre Marine""
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
		]
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
		]
	},
	{
		""id"": ""Bloodstone"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodstone"",
		""name"": ""Pierre de Sang""
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
		]
	},
	{
		""id"": ""PiggyItem"",
		""type"": ""ITEM"",
		""englishName"": ""Piggy"",
		""name"": ""Piggy TOTRANSLATE""
	},
	{
		""id"": ""StressPills"",
		""type"": ""ITEM"",
		""englishName"": ""Stress Pills"",
		""englishTooltip"": [
			""Boosts your defense by 4 and max movement speed and acceleration by 5%"",
			""Receiving a hit causes you to only lose half of your max adrenaline rather than all of it"",
			""Revengeance drop""
		],
		""name"": ""Pillules Anti-Stress"",
		""tooltip"": [
			""+4 défense et +5% de vitesse de mouvement et d'accélération"",
			""Recevoir un coup ne vous fait perdre que la moitié de votre adrénaline au lieu de la totalité"",
			""Revengeance""
		]
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
		]
	},
	{
		""id"": ""PinkCosmicFlameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Pink Cosmic Flame Dye"",
		""name"": ""Pink Cosmic Flame Dye TOTRANSLATE""
	},
	{
		""id"": ""PinkStatigelDye"",
		""type"": ""ITEM"",
		""englishName"": ""Pink Statigel Dye"",
		""name"": ""Pink Statigel Dye TOTRANSLATE""
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
		]
	},
	{
		""id"": ""GallantPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Genesis Pickaxe"",
		""englishTooltip"": [
			""Can mine Uelibloom Ore""
		],
		""name"": ""Piochache de Génèse"",
		""tooltip"": [
			""Peut extraire le minerai d'Ueliclosion""
		]
	},
	{
		""id"": ""AstralPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Pickaxe"",
		""name"": ""Pioche Astrale""
	},
	{
		""id"": ""WulfrumPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Pickaxe"",
		""name"": ""Pioche Wulfrum""
	},
	{
		""id"": ""ShardlightPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Shardlight Pickaxe"",
		""name"": ""Pioche d'ÉclatLueur""
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
		]
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
		]
	},
	{
		""id"": ""Gelpick"",
		""type"": ""ITEM"",
		""englishName"": ""Gelpick"",
		""name"": ""Pioche-Gelée""
	},
	{
		""id"": ""BeastialPickaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Beastial Pickaxe"",
		""name"": ""Pioche-hache Bestiale""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ProporsePistol"",
		""type"": ""ITEM"",
		""englishName"": ""Proporse Pistol"",
		""englishTooltip"": [
			""Fires a blue energy blast that bounces""
		],
		""name"": ""Pistolet Marsrouin"",
		""tooltip"": [
			""Tire une décharge d'énergie bleue qui rebondit""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""DubiousPlating"",
		""type"": ""ITEM"",
		""englishName"": ""Dubious Plating"",
		""name"": ""Plaquage Douteux""
	},
	{
		""id"": ""InfectedArmorPlating"",
		""type"": ""ITEM"",
		""englishName"": ""Infected Armor Plating"",
		""name"": ""Plaquage d'Armure Infecté""
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
		]
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
		]
	},
	{
		""id"": ""PlagueContainmentCells"",
		""type"": ""ITEM"",
		""englishName"": ""Plagueplate"",
		""englishTooltip"": [
			""It resonates with otherworldly energy.""
		],
		""name"": ""Plaque Pestiférée"",
		""tooltip"": [
			""Elle résonne d'une énergie d'un autre monde.""
		]
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
		]
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
		]
	},
	{
		""id"": ""DarkPlasma"",
		""type"": ""ITEM"",
		""englishName"": ""Dark Plasma"",
		""name"": ""Plasma Sombre""
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SulfurBreastplate"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Breastplate"",
		""englishTooltip"": [
			""8% increased rogue damage and 5% increased rogue critical strike chance""
		],
		""name"": ""Plastron Sulfureux"",
		""tooltip"": [
			""+8% des dégâts de voleur et +5% chances de coup critique""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AncientGodSlayerChestplate"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient God Slayer Chestplate"",
		""name"": ""Plastron de l'Ancien Déicide""
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
		]
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
		]
	},
	{
		""id"": ""PlaguedPlatePlatform"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Shelf"",
		""name"": ""Plateforme Pestiférée""
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
		]
	},
	{
		""id"": ""DefiledRune"",
		""type"": ""ITEM"",
		""englishName"": ""Defiled Feather"",
		""englishTooltip"": [
			""It's a long way down from a mountain..."",
			""Favorite this item to disable wings.""
		],
		""name"": ""Plume Impure"",
		""tooltip"": [
			""C'est une longue chute depuis une montagne..."",
			""Favorisez cet objet pour désactiver les ailes""
		]
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
		]
	},
	{
		""id"": ""DesertFeather"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Feather"",
		""name"": ""Plumes du Désert""
	},
	{
		""id"": ""NightsStabber"",
		""type"": ""ITEM"",
		""englishName"": ""Night's Stabber"",
		""englishTooltip"": [
			""Don't underestimate the power of stabby knives"",
			""Enemies release homing dark energy on hit""
		],
		""name"": ""Poignard de la Nuit"",
		""tooltip"": [
			""Ne sous-estime pas le pouvoir des poignards poignardant"",
			""Les ennemis relâchent de l'énergie noire à tête chercheuse lorsqu'ils sont touchés""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PolarisParrotfish"",
		""type"": ""ITEM"",
		""englishName"": ""Polaris Parrotfish"",
		""englishTooltip"": [
			""It carries the mark of the Northern Star"",
			""Projectile hits grant buffs to the weapon and the player"",
			""Buffs are removed on hit""
		],
		""name"": ""Poisson-Perroquet Polaris"",
		""tooltip"": [
			""Il porte la marque de l'étoile du nord"",
			""Les projectiles qui touchent améliorent le joueur et l'arme"",
			""Les améliorations s'annulent si vous êtes touché""
		]
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
		]
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
		]
	},
	{
		""id"": ""EutrophicSandfish"",
		""type"": ""ITEM"",
		""englishName"": ""Eutrophic Sandfish"",
		""name"": ""Poisson-sable Eutrophique""
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
		]
	},
	{
		""id"": ""ManaOverloader"",
		""type"": ""ITEM"",
		""englishName"": ""Mana Polarizer"",
		""englishTooltip"": [
			""Increases max mana by 50 and magic damage by 6%"",
			""Life regen lowered by 3 if mana is above 50% of its maximum"",
			""Grants spectre healing, the amount healed scales with your mana"",
			""The healing only works while holding a magic weapon"",
			""The more mana you have, the more you heal""
		],
		""name"": ""Polarisateur de Mana"",
		""tooltip"": [
			""Augmente le mana maximum de 50 et les dégâts magiques de 6%"",
			""La régénération de vie est réduite de 3 si vous avez plus de la moitié de votre mana"",
			""Accorde le soin spectral, la quantité de vie rendue dépend de votre mana"",
			""Le soin ne fonctionne que si vous tenez une arme magique"",
			""Au plus vous avez de mana, au plus le soin est élevé""
		]
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
		]
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
		]
	},
	{
		""id"": ""BulbofDoom"",
		""type"": ""ITEM"",
		""englishName"": ""Portabulb"",
		""englishTooltip"": [
			""Summons Plantera when used in the jungle"",
			""Not consumable""
		],
		""name"": ""Portabulbe"",
		""tooltip"": [
			""Invoque Plantera quand utilisé dans la jungle"",
			""Non consommable""
		]
	},
	{
		""id"": ""PlaguedPlateDoor"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Door"",
		""name"": ""Porte Pestiférée""
	},
	{
		""id"": ""LaboratoryDoorItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Door"",
		""name"": ""Porte de Laboratoire""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""TitanScalePotion"",
		""type"": ""ITEM"",
		""englishName"": ""Titan Scale Potion"",
		""englishTooltip"": [
			""Increases knockback, defense by 5 and damage reduction by 5%"",
			""Increases defense by 25 and damage reduction by 10% for a few seconds after a true melee strike""
		],
		""name"": ""Potion d'Écaille de Titan"",
		""tooltip"": [
			""Augmente le recul, la défense de 5 et la réduction des dégâts de 5%"",
			""Augmente la défense de 25 et la réduction des dégâts de 10% pendant quelques secondes après un coup de vraie mêlée""
		]
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
		]
	},
	{
		""id"": ""CadencePotion"",
		""type"": ""ITEM"",
		""englishName"": ""Cadance Potion"",
		""englishTooltip"": [
			""Gives the cadance buff which increases life regeneration and heart pickup range"",
			""Increases max life by 25%"",
			""While this potion's buff is active, Regeneration Potion and Lifeforce Potion buffs are disabled""
		],
		""name"": ""Potion de Cadence"",
		""tooltip"": [
			""Donne l'amélioration de Cadence qui réduit l'aggressivité ennemie"",
			""Augmente la régénération de la vie et augmente la vie maximum de 25%"",
			""Augmente la portée de collecte des coeurs de vie"",
			""Quand l'effet de cette potion est actif, les effets des potions de régénération et de longuevie sont désactivés""
		]
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
		]
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
		]
	},
	{
		""id"": ""SupremeManaPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Supreme Mana Potion"",
		""name"": ""Potion de Mana Suprême""
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""RevivifyPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Revivify Potion"",
		""englishTooltip"": [
			""Causes enemy attacks to heal you for a fraction of their damage""
		],
		""name"": ""Potion de Revivification"",
		""tooltip"": [
			""Les attaques ennemies vous soignent pour une fraction de leurs dégâts""
		]
	},
	{
		""id"": ""OmegaHealingPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Omega Healing Potion"",
		""name"": ""Potion de Soin Omega""
	},
	{
		""id"": ""SupremeHealingPotion"",
		""type"": ""ITEM"",
		""englishName"": ""Supreme Healing Potion"",
		""name"": ""Potion de Soin Suprême""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AstralDirt"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Dirt"",
		""name"": ""Poussière Astrale""
	},
	{
		""id"": ""AncientBoneDust"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient Bone Dust"",
		""name"": ""Poussière d'Os Ancienne""
	},
	{
		""id"": ""DemonicBoneAsh"",
		""type"": ""ITEM"",
		""englishName"": ""Demonic Bone Ash"",
		""name"": ""Poussière d'Os Démoniaque""
	},
	{
		""id"": ""Stardust"",
		""type"": ""ITEM"",
		""englishName"": ""Stardust"",
		""name"": ""Poussière d'Étoile""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PrismTurtleBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Prism-Back Banner TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Prism-Back""
		],
		""name"": ""Prism-Back Banner"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Prism-Back""
		]
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
		]
	},
	{
		""id"": ""UnstablePrism"",
		""type"": ""ITEM"",
		""englishName"": ""Unstable Granite Core"",
		""englishTooltip"": [
			""Three sparks are released on critical hits""
		],
		""name"": ""Noyau de Granite Instable"",
		""tooltip"": [
			""3 étincelles sont émises en cas de coup critique""
		]
	},
	{
		""id"": ""SeaPrism"",
		""type"": ""ITEM"",
		""englishName"": ""Sea Prism"",
		""name"": ""Prisme Marin""
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
		]
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
		]
	},
	{
		""id"": ""LabHologramProjectorItem"",
		""type"": ""ITEM"",
		""englishName"": ""Lab Hologram Projector"",
		""name"": ""Projecteur d'Hologramme de Labo""
	},
	{
		""id"": ""PlasmaDriveCore"",
		""type"": ""ITEM"",
		""englishName"": ""Prototype Plasma Drive Core TOTRANSLATE"",
		""englishTooltip"": [
			""Despite all the time it spent in storage, its furnace still burns strong""
		],
		""name"": ""Prototype Plasma Drive Core"",
		""tooltip"": [
			""Despite all the time it spent in storage, its furnace still burns strong""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""MurkyPaste"",
		""type"": ""ITEM"",
		""englishName"": ""Murky Paste"",
		""name"": ""Pâte Trouble""
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
		]
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
		]
	},
	{
		""id"": ""Quasar"",
		""type"": ""ITEM"",
		""englishName"": ""Quasar"",
		""englishTooltip"": [
			""Succ"",
			""Stealth strikes spawn more explosions""
		],
		""name"": ""Quasar"",
		""tooltip"": [
			""Succ"",
			""Les attaques furtives créent plus d'explosions""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SunkenStew"",
		""type"": ""ITEM"",
		""englishName"": ""Hadal Stew"",
		""englishTooltip"": [
			""Only gives 50 seconds of Potion Sickness"",
			""Grants Well Fed"",
			""60 minute duration""
		],
		""name"": ""Ragoût Hadal"",
		""tooltip"": [
			""Provoque seulement 50s de potion affaiblie"",
			""Accorde Bien Nourri"",
			""Dure 60 minutes""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Rancor"",
		""type"": ""ITEM"",
		""englishName"": ""Rancor"",
		""englishTooltip"": [
			""Casts a magic circle that charges energy and eventually releases a powerful laser burst of controlled maleficent magic"",
			""The laser causes arms and searing lava to appear on surfaces it touches which harm both you and enemies"",
			""\"" + CalamityUtils.ColorMessage(\""Forgiveness can only heal so much\"", CalamityGlobalItem.ExhumedTooltipColor)"",
			""If the recipient has not yet forgiven themselves.""
		],
		""name"": ""Rancor"",
		""tooltip"": [
			""Casts a magic circle that charges energy and eventually releases a powerful laser burst of controlled maleficent magic TOTRANSLATE"",
			""The laser causes arms and searing lava to appear on surfaces it touches which harm both you and enemies"",
			""\"" + CalamityUtils.ColorMessage(\""Forgiveness can only heal so much\"", CalamityGlobalItem.ExhumedTooltipColor)"",
			""If the recipient has not yet forgiven themselves.""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Whirlpool"",
		""type"": ""ITEM"",
		""englishName"": ""Riptide"",
		""englishTooltip"": [
			""Sprays a spiral of aqua streams in random directions"",
			""A very agile yoyo""
		],
		""name"": ""Raz de Marée"",
		""tooltip"": [
			""Répand une spirale de jets aquatiques dans des directions aléatoires"",
			""Un yoyo très agile""
		]
	},
	{
		""id"": ""ReaverHeadgear"",
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""RelicOfResilience"",
		""type"": ""ITEM"",
		""englishName"": ""Relic of Resilience"",
		""englishTooltip"": [
			""Summons a bulwark at the mouse position"",
			""The bulwark is killed by enemies and all projectiles."",
			""On death, the bulwark explodes into a rotating burst of shards"",
			""If an enemy is in the area of the shards, its next attack is much weaker. This effect has a cooldown"",
			""After a bit of time, the shards come together to reform the original bulwark."",
			""\"" + $\""This reformation can only happen {3} times."",
			""\"" + \""You gain a small cooldown when summoning a new bulwark."",
			""If a bulwark already exists, using this item will relocate it""
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
		]
	},
	{
		""id"": ""BloodIdol"",
		""type"": ""ITEM"",
		""englishName"": ""Blood Relic"",
		""englishTooltip"": [
			""Summons a blood moon"",
			""Not consumable""
		],
		""name"": ""Relique de Sang"",
		""tooltip"": [
			""Invoque une lune de sang"",
			""Ne se consomme pas""
		]
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
		]
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
		]
	},
	{
		""id"": ""AstralBulwark"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Bulwark"",
		""englishTooltip"": [
			""Taking damage drops astral stars from the sky"",
			""Provides immunity to the astral infection debuff""
		],
		""name"": ""Rempart Astral"",
		""tooltip"": [
			""Subir des dégâts fait tomber des étoiles astrales"",
			""Immunise à l'infection astrale""
		]
	},
	{
		""id"": ""FrigidBulwark"",
		""type"": ""ITEM"",
		""englishName"": ""Frigid Bulwark"",
		""englishTooltip"": [
			""Absorbs 25% of damage done to players on your team"",
			""Only active above 25% life"",
			""Grants immunity to knockback"",
			""Puts a shell around the owner when below 50% life that reduces damage"",
			""The shell becomes more powerful when below 15% life and reduces damage even further""
		],
		""name"": ""Rempart Frigide"",
		""tooltip"": [
			""Absorbe 25% des dégâts infligés à votre équipe"",
			""Actif uniquement si vous avez plus d'un quart de votre vie"",
			""Immunité au recul"",
			""Crée une carapace qui réduit les dégâts autour de l'utilisateur quand il a moins de 50% de sa vie"",
			""La carapace se renforce en dessous de 15% de vie et réduit encore plus les dégâts""
		]
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
			""Puts a shell around the owner when below 50% life that reduces damage"",
			""The shell becomes more powerful when below 15% life and reduces damage even further""
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
		]
	},
	{
		""id"": ""HandheldTank"",
		""type"": ""ITEM"",
		""englishName"": ""Handheld Tank"",
		""name"": ""Reservoir Portable""
	},
	{
		""id"": ""AstralFossil"",
		""type"": ""ITEM"",
		""englishName"": ""Celestial Remains"",
		""name"": ""Restes Céleste""
	},
	{
		""id"": ""Revenge"",
		""type"": ""ITEM"",
		""englishName"": ""Revengeance"",
		""englishTooltip"": [
			""Enables/disables Revengeance Mode, can only be used in Expert Mode."",
			""RAGE TOOLTIP LINE HERE"",
			""You gain Rage when in proximity of enemies or by using special items."",
			""ADRENALINE TOOLTIP LINE HERE"",
			""You gain Adrenaline whenever a boss is alive. Getting hit drops Adrenaline back to 0."",
			""All enemies drop 50% more coins and spawn 15% more frequently."",
			""Certain non-boss enemies and projectiles deal between 10% and 25% more damage."",
			""Makes certain enemies block life steal and nerfs the effectiveness of life steal."",
			""Nerfs the effectiveness of the Titanium Armor set bonus."",
			""All boss minions no longer drop hearts."",
			""Changes all boss AIs and some enemy AIs."",
			""Increases the health and damage of all bosses.""
		],
		""name"": ""Revengeance"",
		""tooltip"": [
			""Active/désactive le mode Revengeance, uniquement disponible en mode Expert."",
			""RAGE TOOLTIP LINE HERE"",
			""Vous gagnez de la rage quand vous êtes à proximité des ennemis ou en utilisant certains objets."",
			""ADRENALINE TOOLTIP LINE HERE"",
			""Vous gagnez de l'adrénaline quand un boss est en vie. Être touché vide votre jauge d'adrénaline."",
			""Tous les ennemis lâchent 50% plus d'argent et apparaissent 15% plus souvent."",
			""Certains ennemis et projectiles font entre 10% et 25% plus de dégâts."",
			""Immunise certains ennemis au vol de vie et réduit son efficacité."",
			""Réduit l'efficacité du bonus d'ensemble de l'armure de titane."",
			""Les sbires des boss ne lâchent plus de coeurs de vie"",
			""Augmente la vie et les dégâts de tous les boss."",
			""Modifie les IA des boss et certaines des IA des ennemis communs.""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BrimflameRobes"",
		""type"": ""ITEM"",
		""englishName"": ""Brimflame Robes"",
		""englishTooltip"": [
			""5% increased magic damage and critical strike chance"",
			""Grants obsidian rose effects""
		],
		""name"": ""Robes de Flammesoufre"",
		""tooltip"": [
			""+5% de dégâts et de chances de coup critique magique"",
			""Effet de la rose d'obsidienne""
		]
	},
	{
		""id"": ""CalamityRobes"",
		""type"": ""ITEM"",
		""englishName"": ""Robes of Calamity TOTRANSLATE"",
		""name"": ""Robes of Calamity""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""HoneyDew"",
		""type"": ""ITEM"",
		""englishName"": ""Honey Dew"",
		""englishTooltip"": [
			""5% increased damage reduction, plus 9 defense and increased life regen while in the Jungle"",
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
		]
	},
	{
		""id"": ""PitbullBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Rotdog Banner TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Rotdog""
		],
		""name"": ""Rotdog Banner"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Rotdog""
		]
	},
	{
		""id"": ""RottenDogtooth"",
		""type"": ""ITEM"",
		""englishName"": ""Rotten Dogtooth"",
		""englishTooltip"": [
			""Makes Stealth strikes inflict Armor Crunch, deal {10}% more damage and cost 1 less unit of stealth.""
		],
		""name"": ""Rotten Dogtooth"",
		""tooltip"": [
			""Makes Stealth strikes inflict Armor Crunch, deal {10}% more damage and cost 1 less unit of stealth. TOTRANSLATE""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PlagueHive"",
		""type"": ""ITEM"",
		""englishName"": ""Plague Hive"",
		""englishTooltip"": [
			""All attacks inflict the Plague debuff"",
			""Releases bees when damaged that inflict the Plague"",
			""Projectiles spawn plague seekers on enemy hits""
		],
		""name"": ""Ruche de Peste"",
		""tooltip"": [
			""Relâche des abeilles qui infligent lorsque vous êtes endommagé"",
			""Toutes vos attaques infligent la peste"",
			""Les projectiles créent des cherche-peste lorsqu'ils touchent""
		]
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
		]
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
		]
	},
	{
		""id"": ""RuneofCos"",
		""type"": ""ITEM"",
		""englishName"": ""Rune of Kos"",
		""englishTooltip"": [
			""A relic of the profaned flame"",
			""Contains the power hunted relentlessly by the sentinels of the cosmic devourer"",
			""When used in certain areas of the world, it will unleash them"",
			""Not consumable""
		],
		""name"": ""Rune de Kos"",
		""tooltip"": [
			""Une relique de la flamme profanée"",
			""Contient le pouvoir traqué sans relâche par les sentinelles du dévoreur cosmique"",
			""Utilisé dans certaines zones, cette relique les attirera"",
			""Ne se consomme pas""
		]
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
		]
	},
	{
		""id"": ""BloodyRupture"",
		""type"": ""ITEM"",
		""englishName"": ""Bloody Rupture"",
		""englishTooltip"": [
			""Enemies release homing blood orbs on hit""
		],
		""name"": ""Rupture Sanglante"",
		""tooltip"": [
			""Les ennemis relâchent des orbes de sang à tête chercheuse quand ils sont touchés""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AstralSand"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Sand"",
		""name"": ""Sable Astral""
	},
	{
		""id"": ""HardenedAstralSand"",
		""type"": ""ITEM"",
		""englishName"": ""Hardened Astral Sand"",
		""name"": ""Sable Astral Durci""
	},
	{
		""id"": ""EutrophicSand"",
		""type"": ""ITEM"",
		""englishName"": ""Eutrophic Sand"",
		""name"": ""Sable Eutrophique""
	},
	{
		""id"": ""SulphurousSand"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Sand"",
		""name"": ""Sable Sulfureux""
	},
	{
		""id"": ""HardenedSulphurousSandstone"",
		""type"": ""ITEM"",
		""englishName"": ""Hardened Sulphurous Sandstone"",
		""name"": ""Sable Sulfureux Durci""
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AstrumDeusBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""HiveMindBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""SlimeGodBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""YharonBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""RavagerBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""DesertScourgeBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""CryogenBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""PlaguebringerGoliathBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""ProvidenceBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""BrimstoneWaifuBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""DevourerofGodsBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""PerforatorBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""PolterghastBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""AquaticScourgeBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""CrabulonBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""OldDukeBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""CalamitasBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""LeviathanBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""BumblebirbBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
	},
	{
		""id"": ""AstrageldonBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Sac à Trésors"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""DuneHopper"",
		""type"": ""ITEM"",
		""englishName"": ""Wave Skipper"",
		""englishTooltip"": [
			""Throws a spear that bounces a lot"",
			""Stealth strikes throw three high speed spears""
		],
		""name"": ""Ricocheur"",
		""tooltip"": [
			""Lance une lance qui rebondit énormément"",
			""Les attaques furtives lancent 3 lances ultra rapides""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""EncryptedSchematic"",
		""type"": ""ITEM"",
		""englishName"": ""Encrypted Schematic"",
		""englishTooltip"": [
			""It's impossible to decipher""
		],
		""name"": ""Schéma Crypté"",
		""tooltip"": [
			""Impossible à déchiffrer""
		]
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
		]
	},
	{
		""id"": ""TwinklerItem"",
		""type"": ""ITEM"",
		""englishName"": ""Twinkler"",
		""name"": ""Scintilleur""
	},
	{
		""id"": ""ScorchedEarth"",
		""type"": ""ITEM"",
		""englishName"": ""Scorched Earth TOTRANSLATE"",
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
		]
	},
	{
		""id"": ""Scorpion"",
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
			""Clic droit pour tirer un missile atomique"",
			""Les missiles détruirons les tuiles en utilisant les munitions adaptées""
		]
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
		]
	},
	{
		""id"": ""SearedPan"",
		""type"": ""ITEM"",
		""englishName"": ""Seared Pan TOTRANSLATE"",
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Seraphim"",
		""type"": ""ITEM"",
		""englishName"": ""Seraphim TOTRANSLATE"",
		""englishTooltip"": [
			""Throws an extraordinarily fast dagger which slows down exponentially and dissipates into light"",
			""\"" + $\""Once dissipation has ended, {6} fast, splitting blades that aim at and slice nearby targets are released, along"",
			""\"" + \""with a large laserbeam"",
			""\"" + $\""Stealth strikes release a volley of {7} lights which explode into smaller laser beams along with the dagger""
		],
		""name"": ""Seraphim"",
		""tooltip"": [
			""Throws an extraordinarily fast dagger which slows down exponentially and dissipates into light"",
			""\"" + $\""Once dissipation has ended, {6} fast, splitting blades that aim at and slice nearby targets are released, along"",
			""\"" + \""with a large laserbeam"",
			""\"" + $\""Stealth strikes release a volley of {7} lights which explode into smaller laser beams along with the dagger""
		]
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
		]
	},
	{
		""id"": ""Serpentuna"",
		""type"": ""ITEM"",
		""englishName"": ""Serpentuna"",
		""name"": ""Serpenthon""
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
		]
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
		]
	},
	{
		""id"": ""LaboratoryServerItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Server"",
		""name"": ""Serveur de Laboratoire""
	},
	{
		""id"": ""AgedLaboratoryServerItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Server"",
		""name"": ""Serveur de Laboratoire Vieilli""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AncientMedallion"",
		""type"": ""ITEM"",
		""englishName"": ""Death Whistle"",
		""englishTooltip"": [
			""A very old temple whistle"",
			""Summons the Ravager"",
			""Not consumable""
		],
		""name"": ""Sifflet de Mort"",
		""tooltip"": [
			""Un très vieux sifflet du temple"",
			""Invoque le Ravageur"",
			""Non consommable""
		]
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
		]
	},
	{
		""id"": ""SilvaMask"",
		""type"": ""ITEM"",
		""englishName"": ""Silva Mask TOTRANSLATE"",
		""name"": ""Silva Mask""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SlimeGodDye"",
		""type"": ""ITEM"",
		""englishName"": ""Slime God Dye"",
		""name"": ""Slime God Dye TOTRANSLATE""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""BrimstoneFlamesprayer"",
		""type"": ""ITEM"",
		""englishName"": ""Havoc's Breath"",
		""name"": ""Souffle de la Dévastation""
	},
	{
		""id"": ""TheEmpyrean"",
		""type"": ""ITEM"",
		""englishName"": ""God's Bellows"",
		""englishTooltip"": [
			""70% chance to not consume gel""
		],
		""name"": ""Soufflets de Dieu"",
		""tooltip"": [
			""70% de chances de ne pas consommer de gel""
		]
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
		]
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
		]
	},
	{
		""id"": ""Brimlish"",
		""type"": ""ITEM"",
		""englishName"": ""Brimlish"",
		""name"": ""Soufresson""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ColdheartIcicle"",
		""type"": ""ITEM"",
		""englishName"": ""Coldheart Icicle"",
		""englishTooltip"": [
			""Drains a percentage of enemy health on hit"",
			""Cannot inflict critical hits""
		],
		""name"": ""Stalagtite de Coeur Froid"",
		""tooltip"": [
			""Draine un pourcentage de vie des adversaires quand vous les touchez"",
			""Ne peut pas infliger de coup critique""
		]
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
		]
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
		]
	},
	{
		""id"": ""StarfleetMK2"",
		""type"": ""ITEM"",
		""englishName"": ""Starmada"",
		""englishTooltip"": [
			""Fires a barrage of stars and plasma blasts""
		],
		""name"": ""Starmada"",
		""tooltip"": [
			""Tire un barrage d'étoiles et de décharges de plasma""
		]
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
		]
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
		]
	},
	{
		""id"": ""YharimsStimulants"",
		""type"": ""ITEM"",
		""englishName"": ""Yharim's Stimulants"",
		""englishTooltip"": [
			""Gives decent buffs to ALL offensive and defensive stats""
		],
		""name"": ""Stimulants de Yharim"",
		""tooltip"": [
			""Donne des améliorations décentes à TOUTES les statistiques offensives et défensives""
		]
	},
	{
		""id"": ""StratusSphere"",
		""type"": ""ITEM"",
		""englishName"": ""Stratus Sphere"",
		""englishTooltip"": [
			""Fires an energy orb containing the essence of our stratosphere"",
			""Up to six of these can be active at a time""
		],
		""name"": ""Stratosphère"",
		""tooltip"": [
			""Tire une orbe d'énergie qui contient l'essence de notre stratosphère"",
			""Jusqu'a 6 orbes peuvent être actives en même temps""
		]
	},
	{
		""id"": ""StratusStarPlatformItem"",
		""type"": ""ITEM"",
		""englishName"": ""Stratus Star Platform"",
		""name"": ""Stratus Star Platform TOTRANSLATE""
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
		]
	},
	{
		""id"": ""SulfurousSkaterBanner"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphurous Skater Banner TOTRANSLATE"",
		""englishTooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sulphurous Skater""
		],
		""name"": ""Sulphurous Skater Banner"",
		""tooltip"": [
			""{$CommonItemTooltip.BannerBonus}Sulphurous Skater""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SupremeCataclysmTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Supreme Cataclysm Trophy"",
		""name"": ""Supreme Cataclysm Trophy TOTRANSLATE""
	},
	{
		""id"": ""SupremeCatastropheTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Supreme Catastrophe Trophy"",
		""name"": ""Supreme Catastrophe Trophy TOTRANSLATE""
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
		]
	},
	{
		""id"": ""AncientShiv"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient Shiv"",
		""englishTooltip"": [
			""Enemies release a blue aura cloud on hit""
		],
		""name"": ""Surin Ancien"",
		""tooltip"": [
			""Les ennemis libèrent un nuage d'aura bleue quand ils sont touchés""
		]
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
		]
	},
	{
		""id"": ""EutrophicShank"",
		""type"": ""ITEM"",
		""englishName"": ""Eutrophic Shank"",
		""englishTooltip"": [
			""Shoots electric sparks""
		],
		""name"": ""Surin Eutrophique"",
		""tooltip"": [
			""Tire des étincelles électriques""
		]
	},
	{
		""id"": ""TerraShiv"",
		""type"": ""ITEM"",
		""englishName"": ""Terra Shiv"",
		""englishTooltip"": [
			""Don't underestimate the power of shivs""
		],
		""name"": ""Surin Terra"",
		""tooltip"": [
			""Ne sous-estimez pas le pouvoir des surins""
		]
	},
	{
		""id"": ""ElementalShortsword"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Shiv"",
		""englishTooltip"": [
			""Don't underestimate the power of shivs"",
			""Shoots a rainbow shiv that spawns additional shivs on hit""
		],
		""name"": ""Surin des Élements"",
		""tooltip"": [
			""Ne sous-estimez pas le pouvoir des surins"",
			""Tire un surin arc-en-ciel qui crée d'autres surins quand vous touchez""
		]
	},
	{
		""id"": ""SuspiciousScrap"",
		""type"": ""ITEM"",
		""englishName"": ""Suspicious Scrap TOTRANSLATE"",
		""englishTooltip"": [
			""Looks like it may be part of a greater whole...""
		],
		""name"": ""Suspicious Scrap"",
		""tooltip"": [
			""Looks like it may be part of a greater whole...""
		]
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
		]
	},
	{
		""id"": ""SwirlingCosmicFlameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Swirling Cosmic Flame Dye"",
		""name"": ""Swirling Cosmic Flame Dye TOTRANSLATE""
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
		]
	},
	{
		""id"": ""PlaguedPlateTable"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Table"",
		""name"": ""Table Pestiférée""
	},
	{
		""id"": ""EidolonTablet"",
		""type"": ""ITEM"",
		""englishName"": ""Eidolon Tablet"",
		""name"": ""Tablette Eidolon""
	},
	{
		""id"": ""ApronOfAffection"",
		""type"": ""ITEM"",
		""englishName"": ""Ace's Apron of Affection"",
		""englishTooltip"": [
			""Great for hugging people""
		],
		""name"": ""Tablier de l'Affection de Ace"",
		""tooltip"": [
			""Parfait pour enlacer les gens""
		]
	},
	{
		""id"": ""TacticiansTrumpCard"",
		""type"": ""ITEM"",
		""englishName"": ""Tactician's Trump Card TOTRANSLATE"",
		""englishTooltip"": [
			""Faint memories of a Princess from the future cross your mind..."",
			""Fires a sword beam that electrifies enemies on hit""
		],
		""name"": ""Tactician's Trump Card"",
		""tooltip"": [
			""Faint memories of a Princess from the future cross your mind..."",
			""Fires a sword beam that electrifies enemies on hit""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""AstralBlueDye"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Blue Dye"",
		""name"": ""Teinture Astrale Bleue""
	},
	{
		""id"": ""AstralOrangeDye"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Orange Dye"",
		""name"": ""Teinture Astrale Orange""
	},
	{
		""id"": ""NightmareDye"",
		""type"": ""ITEM"",
		""englishName"": ""Nightmare Dye"",
		""name"": ""Teinture Cauchemardesque""
	},
	{
		""id"": ""EndothermicDye"",
		""type"": ""ITEM"",
		""englishName"": ""Endothermic Dye"",
		""name"": ""Teinture Endothermique""
	},
	{
		""id"": ""CeaselessDye"",
		""type"": ""ITEM"",
		""englishName"": ""Ceaseless Dye"",
		""name"": ""Teinture Incessante""
	},
	{
		""id"": ""ShadowspecDye"",
		""type"": ""ITEM"",
		""englishName"": ""Shadowspec Dye"",
		""name"": ""Teinture Ombrespec""
	},
	{
		""id"": ""DragonSoulDye"",
		""type"": ""ITEM"",
		""englishName"": ""Dragon Soul Dye"",
		""name"": ""Teinture d'Âme Draconique""
	},
	{
		""id"": ""AstralDye"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Flesh Dye"",
		""name"": ""Teinture de Chair Astrale""
	},
	{
		""id"": ""DefiledFlameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Defiled Flame Dye"",
		""name"": ""Teinture de Flamme Corrompue""
	},
	{
		""id"": ""ProfanedMoonlightDye"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Moonlight Dye"",
		""name"": ""Teinture de Lueur Sélène Profanée""
	},
	{
		""id"": ""StratusDye"",
		""type"": ""ITEM"",
		""englishName"": ""Stratus Dye"",
		""name"": ""Teinture de Strate""
	},
	{
		""id"": ""AstralSwirlDye"",
		""type"": ""ITEM"",
		""englishName"": ""Astral Swirl Dye"",
		""name"": ""Teinture de Tourbillon Astral""
	},
	{
		""id"": ""ProfanedFlameDye"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Flame Dye"",
		""name"": ""Teinture de flamme profanée""
	},
	{
		""id"": ""ElementalDye"",
		""type"": ""ITEM"",
		""englishName"": ""Elemental Dye"",
		""name"": ""Teinture des Éléments""
	},
	{
		""id"": ""ReaverDye"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Dye"",
		""name"": ""Teinture du Saccageur""
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""OmegaBlueLeggings"",
		""type"": ""ITEM"",
		""englishName"": ""Omega Blue Tentacles"",
		""englishTooltip"": [
			""12% increased movement speed"",
			""12% increased damage and critical strike chance""
		],
		""name"": ""Tentacule Bleue Omega"",
		""tooltip"": [
			""+12% de vitesse de mouvement"",
			""+12% de dégâts et de chances de coup critique""
		]
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
		]
	},
	{
		""id"": ""Tequila"",
		""type"": ""ITEM"",
		""englishName"": ""Tequila"",
		""englishTooltip"": [
			""Great for mixing up daytime drinks"",
			""Boosts damage, damage reduction, and knockback by 3%, crit chance by 2%, and defense by 5 during daytime"",
			""Reduces life regen by 1""
		],
		""name"": ""Tequila"",
		""tooltip"": [
			""Parfait pour les cocktails en journée"",
			""Augmente les dégâts, le recul et la réduction des dégâts de 3%, les chances de coup critiques de 2%, et la défense de 5 la journée"",
			""Réduit la régénération de la vie de 1""
		]
	},
	{
		""id"": ""TequilaSunrise"",
		""type"": ""ITEM"",
		""englishName"": ""Tequila Sunrise"",
		""englishTooltip"": [
			""The greatest daytime drink I've ever had"",
			""Boosts damage, damage reduction, and knockback by 7%, crit chance by 3%, and defense by 10 during daytime"",
			""Reduces life regen by 1""
		],
		""name"": ""Tequila Sunrise"",
		""tooltip"": [
			""Le meilleur alcool de jour que j'ai jamais bu"",
			""Augmente les dégâts, la réduction des dégâts et le recul de 7%, les chances de coup critique de 3% et la défense de 10 durant la journée"",
			""Réduit la régénération de vie de 1""
		]
	},
	{
		""id"": ""LaboratoryTerminalItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Terminal"",
		""name"": ""Terminal de Laboratoire""
	},
	{
		""id"": ""BossRush"",
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
			""Une artéfact rituel, supposé avoir provoqué la Fin il y a des millénaires"",
			""Scellé dans les abysses, loin de ceux qui cherchent à l'utiliser à mauvais escient"",
			""Active le Boss Rush, l'utiliser à nouveau désactivera le Boss Rush"",
			""Pendant le Boss Rush, tous les fils et les engins qui fonctionnent avec des fils seront désactivés""
		]
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
		]
	},
	{
		""id"": ""TerraDiskMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Terra Disk"",
		""englishTooltip"": [
			""Throws a disk that has a chance to generate several disks if enemies are near it"",
			""A max of three disks can be active at a time""
		],
		""name"": ""Terra Disque"",
		""tooltip"": [
			""Lance un disque qui a une chance de génerer plusieurs disques si des ennemis en sont proches"",
			""Un maximum de trois disques peuvent être actifs en même temps""
		]
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
		]
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
		]
	},
	{
		""id"": ""Terracotta"",
		""type"": ""ITEM"",
		""englishName"": ""Terra-cotta"",
		""englishTooltip"": [
			""Causes enemies to erupt into healing projectiles on death"",
			""Enemies explode on hit""
		],
		""name"": ""Terra-cotta"",
		""tooltip"": [
			""Les ennemis explosent en projectiles de soins quand ils meurent"",
			""Les ennemis explosent quand ils sont touchés""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ThanatosMask"",
		""type"": ""ITEM"",
		""englishName"": ""Thanatos Mask"",
		""name"": ""Thanatos Mask TOTRANSLATE""
	},
	{
		""id"": ""ThanatosTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Thanatos Trophy"",
		""name"": ""Thanatos Trophy TOTRANSLATE""
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
		]
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
		]
	},
	{
		""id"": ""DoGCart"",
		""type"": ""ITEM"",
		""englishName"": ""The Cart of Gods"",
		""name"": ""The Cart of Gods TOTRANSLATE""
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
		]
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
		]
	},
	{
		""id"": ""ThePrince"",
		""type"": ""ITEM"",
		""englishName"": ""The Prince TOTRANSLATE"",
		""englishTooltip"": [
			""Casts a holy fireball that explodes into {6} flames"",
			""\"" + \""So you're telling me that the prince exploded, and then turned into a flower?"",
			""-Dain, the sailor druid""
		],
		""name"": ""The Prince"",
		""tooltip"": [
			""Casts a holy fireball that explodes into {6} flames"",
			""\"" + \""So you're telling me that the prince exploded, and then turned into a flower?"",
			""-Dain, the sailor druid""
		]
	},
	{
		""id"": ""ConferenceCall"",
		""type"": ""ITEM"",
		""englishName"": ""Conclave Crossfire"",
		""englishTooltip"": [
			""50% chance to not consume ammo"",
			""Fires two spreads of bullets, one from the gun and one from the sky""
		],
		""name"": ""Tir Croisé du Conclave"",
		""tooltip"": [
			""50% de chances de ne pas consommer de munitions"",
			""Tire deux volées de balles, une depuis l'arme et l'autre depuis le ciel""
		]
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
		]
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
		]
	},
	{
		""id"": ""AuricToilet"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Toilet"",
		""englishTooltip"": [
			""This was used by the gods""
		],
		""name"": ""Toilette Aurique"",
		""tooltip"": [
			""A été utilisé par les dieux""
		]
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
		]
	},
	{
		""id"": ""FellerofEvergreens"",
		""type"": ""ITEM"",
		""englishName"": ""Feller of Evergreens"",
		""name"": ""Tombeur des Verdures""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Toxibow"",
		""type"": ""ITEM"",
		""englishName"": ""Toxibow"",
		""englishTooltip"": [
			""Converts wooden arrows into slow arrows that occasionally inflict sulfuric poisoning""
		],
		""name"": ""Toxiarc"",
		""tooltip"": [
			""Convertit les flèches en bois en flèches lentes qui infligent parfois l'empoisonnement sulfurique""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""InfinityBoots"",
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
		""name"": ""Traceurs Séraphins"",
		""tooltip"": [
			""Vitesse absurde!"",
			""Compte comme des ailes"",
			""Vitesse Horizontale: 9"",
			""Multiplicateur d'accélération: 2.5"",
			""Bonne vitesse verticale"",
			""Temps de vol: 140"",
			""+24% d'accélération en course"",
			""Meilleure mobilité sur la glace"",
			""Vous pouvez marcher sur les liquides"",
			""Immunité temporaire à la lave et à la brûlure""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SylvanSlasher"",
		""type"": ""ITEM"",
		""englishName"": ""Sylvan Slasher"",
		""englishTooltip"": [
			""Summons a slash attack at the cursor's position"",
			""Enemy hits build stealth and cause sword waves to fire from the player in the opposite direction"",
			""Does not consume stealth and cannot stealth strike""
		],
		""name"": ""Trancheur Sylvan"",
		""tooltip"": [
			""Invoque une attaque tranchante à la position du curseur"",
			""Les coups des ennemis augmentent la furtivité et crée des vagues d'épée qui partent depuis le joueur dans la direction opposée"",
			""Ne consomme pas la furtivité et ne peut pas effectuer d'attaque furtive""
		]
	},
	{
		""id"": ""DynamoStemCells"",
		""type"": ""ITEM"",
		""englishName"": ""Dynamo Stem Cells"",
		""englishTooltip"": [
			""10% increased movement speed"",
			""Ranged weapons have a chance to fire mini swarmers""
		],
		""name"": ""Transformateur de Cellules Souches"",
		""tooltip"": [
			""+10% de vitesse de mouvement"",
			""Les armes à distance ont une chance de tirer des petits essaimeurs""
		]
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
		]
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
		]
	},
	{
		""id"": ""SignusBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Bag"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen} TOTRANSLATE""
		]
	},
	{
		""id"": ""CeaselessVoidBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Bag"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen} TOTRANSLATE""
		]
	},
	{
		""id"": ""StormWeaverBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Bag"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen} TOTRANSLATE""
		]
	},
	{
		""id"": ""DraedonTreasureBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Bag"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Bag"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen} TOTRANSLATE""
		]
	},
	{
		""id"": ""SCalBag"",
		""type"": ""ITEM"",
		""englishName"": ""Treasure Coffer"",
		""englishTooltip"": [
			""{$CommonItemTooltip.RightClickToOpen}""
		],
		""name"": ""Treasure Coffer"",
		""tooltip"": [
			""{$CommonItemTooltip.RightClickToOpen} TOTRANSLATE""
		]
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
		]
	},
	{
		""id"": ""TriactisTruePaladinianMageHammerofMight"",
		""type"": ""ITEM"",
		""englishName"": ""Triactis' True Paladinian Mage-Hammer of Might"",
		""englishTooltip"": [
			""Explodes on enemy hits""
		],
		""name"": ""Triactis, le Marteau-Mage de Puissance du Vrai Paladinien"",
		""tooltip"": [
			""Explose en touchant les ennemis""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Trinity"",
		""type"": ""ITEM"",
		""englishName"": ""Trinity"",
		""englishTooltip"": [
			""Fires a spread of energy bolts""
		],
		""name"": ""Trinité"",
		""tooltip"": [
			""Tire une étendue de rayons d'énergie""
		]
	},
	{
		""id"": ""Triploon"",
		""type"": ""ITEM"",
		""englishName"": ""Triploon"",
		""englishTooltip"": [
			""Launches three harpoons""
		],
		""name"": ""Tripoon"",
		""tooltip"": [
			""Lance trois harpons""
		]
	},
	{
		""id"": ""ChaoswarpedSlashaxe"",
		""type"": ""ITEM"",
		""englishName"": ""Tectonic Truncator"",
		""name"": ""Troncateur Tectonique""
	},
	{
		""id"": ""MLGRune"",
		""type"": ""ITEM"",
		""englishName"": ""Demon Trophy"",
		""englishTooltip"": [
			""Boosts spawn rate by 1.25 times"",
			""Effects cannot be reversed""
		],
		""name"": ""Trophée Démoniaque"",
		""tooltip"": [
			""Augmente le taux d'apparition des ennemis de 25%"",
			""Son effet est irréversible""
		]
	},
	{
		""id"": ""AnahitaTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Anahita Trophy"",
		""name"": ""Trophée d'Anahita""
	},
	{
		""id"": ""AstrageldonTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Aureus Trophy"",
		""name"": ""Trophée d'Astrum Aureus""
	},
	{
		""id"": ""AstrumDeusTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Astrum Deus Trophy"",
		""name"": ""Trophée d'Astrum Deus""
	},
	{
		""id"": ""BrimstoneElementalTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Elemental Trophy"",
		""name"": ""Trophée d'Élémentaire de Soufre""
	},
	{
		""id"": ""CalamitasTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Calamitas Trophy"",
		""name"": ""Trophée de Calamitas""
	},
	{
		""id"": ""SupremeCalamitasTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Supreme Calamitas Trophy"",
		""name"": ""Trophée de Calamitas Suprême""
	},
	{
		""id"": ""CataclysmTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Cataclysm Trophy"",
		""name"": ""Trophée de Cataclysme""
	},
	{
		""id"": ""CatastropheTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Catastrophe Trophy"",
		""name"": ""Trophée de Catastrophe""
	},
	{
		""id"": ""CrabulonTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Crabulon Trophy"",
		""name"": ""Trophée de Crabulon""
	},
	{
		""id"": ""CryogenTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Cryogen Trophy"",
		""name"": ""Trophée de Cryogène""
	},
	{
		""id"": ""ProvidenceTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Providence Trophy"",
		""name"": ""Trophée de Providence""
	},
	{
		""id"": ""RavagerTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Ravager Trophy"",
		""name"": ""Trophée de Ravageur""
	},
	{
		""id"": ""SignusTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Signus Trophy"",
		""name"": ""Trophée de Signus""
	},
	{
		""id"": ""YharonTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Yharon Trophy"",
		""name"": ""Trophée de Yharon""
	},
	{
		""id"": ""HiveMindTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Hive Mind Trophy"",
		""name"": ""Trophée de l'Esprit de Ruche""
	},
	{
		""id"": ""PolterghastTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Polterghast Trophy"",
		""name"": ""Trophée de l'Épouvantôme""
	},
	{
		""id"": ""BumblebirbTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Dragonfolly Trophy"",
		""name"": ""Trophée de la Dracofolie""
	},
	{
		""id"": ""SlimeGodTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Slime God Trophy"",
		""name"": ""Trophée du Dieu des Gelées""
	},
	{
		""id"": ""DevourerofGodsTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Devourer of Gods Trophy"",
		""name"": ""Trophée du Dévoreur de Dieux""
	},
	{
		""id"": ""AquaticScourgeTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Aquatic Scourge Trophy"",
		""name"": ""Trophée du Fléau Aquatique""
	},
	{
		""id"": ""DesertScourgeTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Desert Scourge Trophy"",
		""name"": ""Trophée du Fléau du Désert""
	},
	{
		""id"": ""ProfanedGuardianTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Profaned Guardian Trophy"",
		""name"": ""Trophée du Gardien Profané""
	},
	{
		""id"": ""PlaguebringerGoliathTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Plaguebringer Goliath Trophy"",
		""name"": ""Trophée du Goliath Colporte-Peste""
	},
	{
		""id"": ""LeviathanTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Leviathan Trophy"",
		""name"": ""Trophée du Leviathan""
	},
	{
		""id"": ""CeaselessVoidTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Ceaseless Void Trophy"",
		""name"": ""Trophée du Néant Incessant""
	},
	{
		""id"": ""PerforatorTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Perforator Trophy"",
		""name"": ""Trophée du Perforateur""
	},
	{
		""id"": ""WeaverTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Storm Weaver Trophy"",
		""name"": ""Trophée du Tisse-Tempête""
	},
	{
		""id"": ""OldDukeTrophy"",
		""type"": ""ITEM"",
		""englishName"": ""Old Duke Trophy"",
		""name"": ""Trophée du Vieux Duc""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""DraedonsRemote"",
		""type"": ""ITEM"",
		""englishName"": ""Draedon's Remote"",
		""englishTooltip"": [
			""Mayhem..."",
			""Not consumable""
		],
		""name"": ""Télécommande de Draedon"",
		""tooltip"": [
			""Chaos..."",
			""Non consommable""
		]
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
		]
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
		]
	},
	{
		""id"": ""Tenebris"",
		""type"": ""ITEM"",
		""englishName"": ""Tenebris"",
		""name"": ""Ténebris""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""UniversalGenesis"",
		""type"": ""ITEM"",
		""englishName"": ""Universal Genesis TOTRANSLATE"",
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
		]
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
		]
	},
	{
		""id"": ""EutrophicSandWall"",
		""type"": ""ITEM"",
		""englishName"": ""Unsafe Eutrophic Sand Wall"",
		""name"": ""Unsafe Eutrophic Sand Wall TOTRANSLATE""
	},
	{
		""id"": ""NavystoneWall"",
		""type"": ""ITEM"",
		""englishName"": ""Unsafe Navystone Wall"",
		""name"": ""Unsafe Navystone Wall TOTRANSLATE""
	},
	{
		""id"": ""EyeofExtinction"",
		""type"": ""ITEM"",
		""englishName"": ""Ceremonial Urn"",
		""englishTooltip"": [
			""Use at the Altar of the Accursed to summon Supreme Calamitas"",
			""Not consumable""
		],
		""name"": ""Urne cérémoniale"",
		""tooltip"": [
			""Utilisez la à l'autel des maudits pour invoquer Calamitas suprême"",
			""Ne se consomme pas""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SeaMinnowItem"",
		""type"": ""ITEM"",
		""englishName"": ""Sea Minnow"",
		""name"": ""Vairon de Mer""
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
		]
	},
	{
		""id"": ""AsgardsValor"",
		""type"": ""ITEM"",
		""englishName"": ""Asgard's Valor"",
		""englishTooltip"": [
			""Grants immunity to knockback"",
			""Immune to most debuffs and reduces the damage caused by the Brimstone Flames debuff"",
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
		]
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
		]
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
		]
	},
	{
		""id"": ""CosmicWorm"",
		""type"": ""ITEM"",
		""englishName"": ""Cosmic Worm"",
		""englishTooltip"": [
			""Summons the Devourer of Gods"",
			""SENTINEL WARNING TOOLTIP LINE HERE"",
			""Not consumable""
		],
		""name"": ""Ver Cosmique"",
		""tooltip"": [
			""Invoque le dévoreur de dieux"",
			""SENTINEL WARNING TOOLTIP LINE HERE"",
			""Ne se consomme pas""
		]
	},
	{
		""id"": ""BloodwormItem"",
		""type"": ""ITEM"",
		""englishName"": ""Bloodworm"",
		""name"": ""Ver de Sang""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PlagueReaperVest"",
		""type"": ""ITEM"",
		""englishName"": ""Plague Reaper Vest"",
		""englishTooltip"": [
			""Reduces the damage caused to you by the plague"",
			""15% increased ranged damage and 5% increased ranged critical strike chance""
		],
		""name"": ""Veste du Faucheur de Peste"",
		""tooltip"": [
			""Réduit les dégâts que vous inflige la peste"",
			""+15% de dégâts à distance et +5% de chances de coup critique""
		]
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
		]
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
		]
	},
	{
		""id"": ""DeliciousMeat"",
		""type"": ""ITEM"",
		""englishName"": ""Delicious Meat"",
		""englishTooltip"": [
			""{$CommonItemTooltip.MinorStats}"",
			""'So very delicious'""
		],
		""name"": ""Viande Délicieuse"",
		""tooltip"": [
			""Petite amélioration à toutes les statistiques"",
			""'Tellement bon'""
		]
	},
	{
		""id"": ""AgedLaboratoryDisplayItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Display"",
		""name"": ""Vieil Affichage de Laboratoire""
	},
	{
		""id"": ""AgedLaboratoryScreenItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Screen"",
		""name"": ""Vieil Écran de Laboratoire""
	},
	{
		""id"": ""AgedLaboratoryContainmentBoxItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Containment Box"",
		""name"": ""Vieille Boîte de Confinement de Laboratoire""
	},
	{
		""id"": ""AgedReinforcedCrateItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Reinforced Crate"",
		""name"": ""Vieille Caisse Renforcée""
	},
	{
		""id"": ""AgedLaboratoryConsoleItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Console"",
		""name"": ""Vieille Console de Laboratoire""
	},
	{
		""id"": ""AgedLaboratoryDoorItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Door"",
		""name"": ""Vieille Porte de Laboratoire""
	},
	{
		""id"": ""AgedSecurityChest"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Security Chest"",
		""name"": ""Vieux Coffre Sécurisé""
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
		]
	},
	{
		""id"": ""OldDie"",
		""type"": ""ITEM"",
		""englishName"": ""Old Die"",
		""englishTooltip"": [
			""Lucky for you, the curse doesn't affect you. Mostly."",
			""Increases the randomness of attack damage""
		],
		""name"": ""Vieux Dé"",
		""tooltip"": [
			""Vous avez de la veine, sa malédiction ne vous atteint pas, enfin presque."",
			""Rends les dégâts des attaques plus aléatoires""
		]
	},
	{
		""id"": ""AgedLaboratoryElectricPanelItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Electric Panel"",
		""name"": ""Vieux Panneau Électrique de Laboratoire""
	},
	{
		""id"": ""AgedLaboratoryTerminalItem"",
		""type"": ""ITEM"",
		""englishName"": ""Aged Laboratory Terminal"",
		""name"": ""Vieux Terminal de Laboratoire""
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
		]
	},
	{
		""id"": ""BlightedEyeStaff"",
		""type"": ""ITEM"",
		""englishName"": ""Entropy's Vigil"",
		""englishTooltip"": [
			""Summons Calamitas and her brothers to protect you"",
			""One minion trio takes two minion slots""
		],
		""name"": ""Vigile d'Entropie"",
		""tooltip"": [
			""Invoque Calamitas et ses frères pour vous protéger"",
			""Occupe deux emplacements de sbires par trio""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""ViridVanguard"",
		""type"": ""ITEM"",
		""englishName"": ""Virid Vanguard"",
		""englishTooltip"": [
			""Summons 2 blades that rotate around you"",
			""Each pair of blades take up three minion slots"",
			""Right clicking prompts all blades to fly upward and redirect towards the mouse""
		],
		""name"": ""Avant-Garde Viride"",
		""tooltip"": [
			""Invoque deux lames qui tournent autour de vous"",
			""Chaque paire de lame occupe trois emplacements de sbires"",
			""Clic droit pour ordonner aux lames de se diriger vers la souris""
		]
	},
	{
		""id"": ""VirulentKatana"",
		""type"": ""ITEM"",
		""englishName"": ""Virulence"",
		""englishTooltip"": [
			""Fires a plague cloud""
		],
		""name"": ""Virulence"",
		""tooltip"": [
			""Tire un nuage de peste""
		]
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
		]
	},
	{
		""id"": ""GodSlayerVisage"",
		""type"": ""ITEM"",
		""englishName"": ""God Slayer Visage"",
		""name"": ""Visage Déicide"",
		""tooltip"": [
			""+14% de dégâts et de chances de coup critique magique"",
			""+100 mana maximum et 17% de réduction du coût en mana""
		]
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
		]
	},
	{
		""id"": ""AuricTeslaWireHemmedVisage"",
		""type"": ""ITEM"",
		""englishName"": ""Auric Tesla Wire-Hemmed Visage"",
		""englishTooltip"": [
			""30% increased magic damage, 20% increased magic critical strike chance, +100 max mana and 20% reduced mana usage"",
			""Not moving boosts all damage and critical strike chance""
		],
		""name"": ""Visage Ourlé de Fils Tesla Aurique"",
		""tooltip"": [
			""+30% de dégâts magiques et +20% de chances de coup critique magique, +100 mana maximum et 20% de réduction des coûts en mana"",
			""Rester immobile augmente les dégâts et les chances de coup critique""
		]
	},
	{
		""id"": ""VictideVisage"",
		""type"": ""ITEM"",
		""englishName"": ""Victide Visage"",
		""englishTooltip"": [
			""5% increased ranged damage""
		],
		""name"": ""Visage Victide"",
		""tooltip"": [
			""+5% de dégâts à distance""
		]
	},
	{
		""id"": ""WulfrumHood"",
		""type"": ""ITEM"",
		""englishName"": ""Wulfrum Visage"",
		""englishTooltip"": [
			""10% increased magic damage""
		],
		""name"": ""Visage Wulfrum"",
		""tooltip"": [
			""+10% de dégâts magiques""
		]
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
		]
	},
	{
		""id"": ""TarragonVisage"",
		""type"": ""ITEM"",
		""englishName"": ""Tarragon Visage"",
		""englishTooltip"": [
			""Temporary immunity to lava"",
			""Can move freely through liquids"",
			""10% increased ranged damage and critical strike chance"",
			""5% increased damage reduction""
		],
		""name"": ""Visage d'Estragon"",
		""tooltip"": [
			""Immunité temporaire à la lave"",
			""Vous pouvez vous déplacer librement dans les liquides"",
			""+10% de dégâts et de chances de coup critique à distance"",
			""+5% de réduction des dégâts""
		]
	},
	{
		""id"": ""ReaverVisage"",
		""type"": ""ITEM"",
		""englishName"": ""Reaver Visage"",
		""englishTooltip"": [
			""10% increased jump speed and 15% increased movement speed""
		],
		""name"": ""Visage de Saccageur"",
		""tooltip"": [
			""+10% de vitesse de saut et +15% de vitesse de mouvement""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Vehemenc"",
		""type"": ""ITEM"",
		""englishName"": ""Vehemence"",
		""englishTooltip"": [
			""Casts intense bolts of hellish power that explode into skulls"",
			""Direct hits inflict Demon Flames for an extended period of time""
		],
		""name"": ""Véhémence"",
		""tooltip"": [
			""Conjure d'intenses éclairs de pouvoir infernal qui explosent en crânes"",
			""Les coups directs infligent les flammes démoniaques sur une longue période""
		]
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
		]
	},
	{
		""id"": ""TrueExcaliburShortsword"",
		""type"": ""ITEM"",
		""englishName"": ""True Excalibur Shortsword"",
		""englishTooltip"": [
			""Don't underestimate the power of shortswords""
		],
		""name"": ""Véritable Excalibur Courte"",
		""tooltip"": [
			""Ne sous-estimez pas la puissance des épées courtes""
		]
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
		]
	},
	{
		""id"": ""TrueNightsStabber"",
		""type"": ""ITEM"",
		""englishName"": ""True Night's Stabber"",
		""englishTooltip"": [
			""Don't underestimate the power of stabby knives""
		],
		""name"": ""Véritable Poignard de la Nuit"",
		""tooltip"": [
			""Ne sous-estimez pas le pouvoir des poignards""
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Whiskey"",
		""type"": ""ITEM"",
		""englishName"": ""Whiskey"",
		""englishTooltip"": [
			""The burning sensation makes it tastier"",
			""Boosts damage and knockback by 4% and critical strike chance by 2%"",
			""Reduces defense by 5%""
		],
		""name"": ""Whisky"",
		""tooltip"": [
			""La sensation brûlante le rend plus goûtu"",
			""Augmente les dégâts et le recul de 4% et les chances de coup critique de 2%"",
			""Réduit la défense de 5%""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""CheatTestThing"",
		""type"": ""ITEM"",
		""englishName"": ""lul"",
		""name"": ""lul TOTRANSLATE""
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
		]
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
		]
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
		]
	},
	{
		""id"": ""SulfuricScale"",
		""type"": ""ITEM"",
		""englishName"": ""Sulphuric Scale"",
		""name"": ""Écaille Sulphurique""
	},
	{
		""id"": ""DragonScales"",
		""type"": ""ITEM"",
		""englishName"": ""Dragon Scales"",
		""englishTooltip"": [
			""Only a living dragon holds true treasure"",
			""Rogue projectiles create slow fireballs as they travel"",
			""Stealth strikes create infernados on death"",
			""+10% max run speed and acceleration""
		],
		""name"": ""Écailles de Dragon"",
		""tooltip"": [
			""Seul un dragon vivant possède un véritable trésor"",
			""Les projectiles de voleur créent de lentes boules de feu sur leur trajet"",
			""Les attaques furtives créent une infernade à la disparition du projectile"",
			""+10% à votre accélération et votre vitesse de mouvement""
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""XerocPitchfork"",
		""type"": ""ITEM"",
		""englishName"": ""Shard of Antumbra"",
		""englishTooltip"": [
			""Stealth strikes leave homing stars in their wake""
		],
		""name"": ""Éclat d'Antumbra"",
		""tooltip"": [
			""Les attaques furtives laissent des étoiles à tête chercheuse dans leur sillage""
		]
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
		]
	},
	{
		""id"": ""PrismShard"",
		""type"": ""ITEM"",
		""englishName"": ""Prism Shard"",
		""name"": ""Éclat de Prisme""
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""LaboratoryScreenItem"",
		""type"": ""ITEM"",
		""englishName"": ""Laboratory Screen"",
		""name"": ""Écran de Laboratoire""
	},
	{
		""id"": ""AncientCrusher"",
		""type"": ""ITEM"",
		""englishName"": ""Ancient Crusher"",
		""englishTooltip"": [
			""Summons fossil spikes on enemy hits""
		],
		""name"": ""Écraseur Ancien"",
		""tooltip"": [
			""Invoque des piques fossiles quand vous touchez les ennemis""
		]
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
		]
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
		]
	},
	{
		""id"": ""GlacialCrusher"",
		""type"": ""ITEM"",
		""englishName"": ""Glacial Crusher"",
		""englishTooltip"": [
			""Fires slow frost projectiles that freeze enemies"",
			""True melee strikes cause tremendous damage to frozen enemies""
		],
		""name"": ""Écraseur Glacial"",
		""tooltip"": [
			""Tire de très lents projectiles de givre qui gèlent les ennemis"",
			""Les attaques de vraie mêlée infligent des dégâts considérables sur les ennemis gelés""
		]
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
		]
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
		]
	},
	{
		""id"": ""GalaxySmasherMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Galaxy Smasher"",
		""englishTooltip"": [
			""Explodes and summons death lasers on enemy hits""
		],
		""name"": ""Écraseur de Galaxie"",
		""tooltip"": [
			""Explose et génère des lasers mortels quand il touche""
		]
	},
	{
		""id"": ""GalaxySmasherRogue"",
		""type"": ""ITEM"",
		""englishName"": ""Galaxy Smasher"",
		""englishTooltip"": [
			""Explodes and summons death lasers on enemy hits""
		],
		""name"": ""Écraseur de Galaxie"",
		""tooltip"": [
			""Explose et génère des lasers mortels quand il touche""
		]
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
		]
	},
	{
		""id"": ""DepthBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Depth Crusher"",
		""englishTooltip"": [
			""Hitting enemies will inflict the crush depth debuff"",
			""The lower the enemies' defense, the more damage they take from this debuff"",
			""Right click to use without hammering down walls""
		],
		""name"": ""Écraseur des Profondeurs"",
		""tooltip"": [
			""Toucher les ennemis inflige l'écrasement des profondeurs"",
			""Plus la défense des ennemis est faible, plus ils prennent de dégâts de l'écrasement"",
			""Clic droit pour utiliser sans détruire les murs""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""PhoenixBlade"",
		""type"": ""ITEM"",
		""englishName"": ""Phoenix Blade"",
		""englishTooltip"": [
			""Enemies explode and emit healing flames on death""
		],
		""name"": ""Épée Phénix"",
		""tooltip"": [
			""Les ennemis explosent et émettent des flammes régénératrices quand vous les tuez""
		]
	},
	{
		""id"": ""RedtideSword"",
		""type"": ""ITEM"",
		""englishName"": ""Redtide Sword"",
		""englishTooltip"": [
			""Throws short-range whirlpools""
		],
		""name"": ""Épée Vaguerouge"",
		""tooltip"": [
			""Lance des tourbillons à courte portée""
		]
	},
	{
		""id"": ""TemporalFloeSword"",
		""type"": ""ITEM"",
		""englishName"": ""Temporal Floe Sword"",
		""englishTooltip"": [
			""The iceman cometh..."",
			""Fires a frozen sword beam that splits into two more beams"",
			""The direction of the beams depends on in game time""
		],
		""name"": ""Épée de la Banquise Temporelle"",
		""tooltip"": [
			""L'homme des glaces arrive..."",
			""Tire un rayon d'épée gelée qui se divise en deux autres rayons"",
			""La direction des rayons dépend de l'heure en jeu""
		]
	},
	{
		""id"": ""ProfanedSword"",
		""type"": ""ITEM"",
		""englishName"": ""Brimstone Sword"",
		""englishTooltip"": [
			""Summons brimstone geysers on hit"",
			""Right click to throw like a javelin that explodes on hit""
		],
		""name"": ""Épée de soufre"",
		""tooltip"": [
			""Invoque des geysers de soufre quand vous touchez"",
			""Clic droit pour lancer un javelot qui explose quand il touche""
		]
	},
	{
		""id"": ""OldLordOathsword"",
		""type"": ""ITEM"",
		""englishName"": ""Old Lord Oathsword"",
		""englishTooltip"": [
			""A relic of the ancient underworld"",
			""Critical hits cause lava explosions""
		],
		""name"": ""Épée du Serment du Vieux Seigneur"",
		""tooltip"": [
			""Une relique de l'ancien enfer"",
			""Les coups critiques causent des explosions de lave""
		]
	},
	{
		""id"": ""BladecrestOathsword"",
		""type"": ""ITEM"",
		""englishName"": ""Bladecrest Oathsword"",
		""englishTooltip"": [
			""Sword of an ancient demon lord"",
			""Fires a blood scythe""
		],
		""name"": ""Épée-Serment du Blason-Lame"",
		""tooltip"": [
			""Épée d'un ancien roi-démon"",
			""Tire une faux de sang""
		]
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
		]
	},
	{
		""id"": ""EradicatorMelee"",
		""type"": ""ITEM"",
		""englishName"": ""Eradicator"",
		""englishTooltip"": [
			""Throws a disk that fires lasers at nearby enemies""
		],
		""name"": ""Éradicateur"",
		""tooltip"": [
			""Jette un disque qui tire des lasers sur les ennemis proches""
		]
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
		]
	},
	{
		""id"": ""EutrophicCrafting"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Used for special crafting""
		],
		""name"": ""Établi Eutrophique"",
		""tooltip"": [
			""Utilisé pour l'artisanat spécial""
		]
	},
	{
		""id"": ""PlaguedPlateWorkbench"",
		""type"": ""ITEM"",
		""englishName"": ""Plagued Work Bench"",
		""name"": ""Établi Pestiféré""
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
		]
	},
	{
		""id"": ""TwinklerInABottle"",
		""type"": ""ITEM"",
		""englishName"": ""Twinkler in a Bottle"",
		""name"": ""Étincelle en Bouteille""
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""RotomRemote"",
		""type"": ""ITEM"",
		""englishName"": ""Triboluminescent Etomer"",
		""englishTooltip"": [
			""Summons an electric troublemaker"",
			""A little note is attached:"",
			""Thank you, Aloe! Very much appreciated from Ben""
		],
		""name"": ""Étomère Triboluminescent"",
		""tooltip"": [
			""Invoque un fauteur de troubles éléctrique"",
			""Un petit mot est attaché:"",
			""Merci Aloé! J'apprécie vraiment beaucoup, Ben""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""OccultSink"",
		""type"": ""ITEM"",
		""englishName"": """",
		""englishTooltip"": [
			""Counts as a water source""
		],
		""name"": ""Évier Occulte"",
		""tooltip"": [
			""Source d'eau""
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
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
		]
	},
	{
		""id"": ""Eviscerator"",
		""type"": ""ITEM"",
		""englishName"": ""Eviscerator"",
		""englishTooltip"": [
			""Converts musket balls into slow-moving blood clots""
		],
		""name"": ""Éviscerateur"",
		""tooltip"": [
			""Convertit les balles de mousquet en lents caillots sanguins""
		]
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
		]
	},
	{
		""id"": ""ClothiersWrath"",
		""type"": ""ITEM"",
		""englishName"": ""Clothier's Wrath"",
		""name"": ""Îre du Tailleur""
	},
	{
		""id"": ""LeviathanStart"",
		""type"": ""NPC"",
		""englishName"": ""???"",
		""name"": ""??? TOTRANSLATE""
	},
	{
		""id"": ""DesertNuisanceBody"",
		""type"": ""NPC"",
		""englishName"": ""A Desert Nuisance"",
		""name"": ""A Desert Nuisance TOTRANSLATE""
	},
	{
		""id"": ""DesertNuisanceHead"",
		""type"": ""NPC"",
		""englishName"": ""A Desert Nuisance"",
		""name"": ""A Desert Nuisance TOTRANSLATE""
	},
	{
		""id"": ""DesertNuisanceTail"",
		""type"": ""NPC"",
		""englishName"": ""A Desert Nuisance"",
		""name"": ""A Desert Nuisance TOTRANSLATE""
	},
	{
		""id"": ""AquaticAberration"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Aberration"",
		""name"": ""Abérattion Aquatique""
	},
	{
		""id"": ""MicrobialCluster"",
		""type"": ""NPC"",
		""englishName"": ""Microbial Cluster"",
		""name"": ""Amas Microbien""
	},
	{
		""id"": ""Siren"",
		""type"": ""NPC"",
		""englishName"": ""Anahita"",
		""name"": ""Anahita TOTRANSLATE""
	},
	{
		""id"": ""AcidEel"",
		""type"": ""NPC"",
		""englishName"": ""Acid Eel"",
		""name"": ""Anguille Acide""
	},
	{
		""id"": ""GulperEelTail"",
		""type"": ""NPC"",
		""englishName"": ""Gulper Eel"",
		""name"": ""Anguille Engloutisseuse""
	},
	{
		""id"": ""GulperEelBody"",
		""type"": ""NPC"",
		""englishName"": ""Gulper Eel"",
		""name"": ""Anguille Engloutisseuse""
	},
	{
		""id"": ""GulperEelBodyAlt"",
		""type"": ""NPC"",
		""englishName"": ""Gulper Eel"",
		""name"": ""Anguille Engloutisseuse""
	},
	{
		""id"": ""GulperEelHead"",
		""type"": ""NPC"",
		""englishName"": ""Gulper Eel"",
		""name"": ""Anguille Engloutisseuse""
	},
	{
		""id"": ""AstralachneaWall"",
		""type"": ""NPC"",
		""englishName"": ""Astralachnea"",
		""name"": ""Arachnée Astrale""
	},
	{
		""id"": ""AstralachneaGround"",
		""type"": ""NPC"",
		""englishName"": ""Astralachnea"",
		""name"": ""Arachnée Astrale""
	},
	{
		""id"": ""DILF"",
		""type"": ""NPC"",
		""englishName"": ""Archmage"",
		""name"": ""Archimage""
	},
	{
		""id"": ""Aries"",
		""type"": ""NPC"",
		""englishName"": ""Aries"",
		""name"": ""Aries TOTRANSLATE""
	},
	{
		""id"": ""SoulSlurper"",
		""type"": ""NPC"",
		""englishName"": ""Soul Slurper"",
		""name"": ""Aspire-Âme""
	},
	{
		""id"": ""CultistAssassin"",
		""type"": ""NPC"",
		""englishName"": ""Cultist Assassin"",
		""name"": ""Assassin Cultiste""
	},
	{
		""id"": ""AstrumAureus"",
		""type"": ""NPC"",
		""englishName"": ""Astrum Aureus"",
		""name"": ""Astrum Aureus TOTRANSLATE""
	},
	{
		""id"": ""AstrumDeusHeadSpectral"",
		""type"": ""NPC"",
		""englishName"": ""Astrum Deus"",
		""name"": ""Astrum Deus TOTRANSLATE""
	},
	{
		""id"": ""AstrumDeusTailSpectral"",
		""type"": ""NPC"",
		""englishName"": ""Astrum Deus"",
		""name"": ""Astrum Deus TOTRANSLATE""
	},
	{
		""id"": ""AstrumDeusBodySpectral"",
		""type"": ""NPC"",
		""englishName"": ""Astrum Deus"",
		""name"": ""Astrum Deus TOTRANSLATE""
	},
	{
		""id"": ""Atlas"",
		""type"": ""NPC"",
		""englishName"": ""Atlas"",
		""name"": ""Atlas TOTRANSLATE""
	},
	{
		""id"": ""WulfrumHovercraft"",
		""type"": ""NPC"",
		""englishName"": ""Wulfrum Hovercraft"",
		""name"": ""Aéroglisseur Wulfrum""
	},
	{
		""id"": ""OldDukeToothBall"",
		""type"": ""NPC"",
		""englishName"": ""Tooth Ball"",
		""name"": ""Balle Dentée""
	},
	{
		""id"": ""THIEF"",
		""type"": ""NPC"",
		""englishName"": ""Bandit"",
		""name"": ""Bandit TOTRANSLATE""
	},
	{
		""id"": ""BlindedAngler"",
		""type"": ""NPC"",
		""englishName"": ""Blinded Angler"",
		""name"": ""Baudroie Aveuglée""
	},
	{
		""id"": ""Bohldohr"",
		""type"": ""NPC"",
		""englishName"": ""Bohldohr"",
		""name"": ""Bohldohr TOTRANSLATE""
	},
	{
		""id"": ""CryogenIce"",
		""type"": ""NPC"",
		""englishName"": ""Cryogen's Shield"",
		""name"": ""Bouclier de Cryogène""
	},
	{
		""id"": ""SirenIce"",
		""type"": ""NPC"",
		""englishName"": ""Ice Shield"",
		""name"": ""Bouclier de Glace""
	},
	{
		""id"": ""BrimstoneHeart"",
		""type"": ""NPC"",
		""englishName"": ""Brimstone Heart"",
		""name"": ""Brimstone Heart TOTRANSLATE""
	},
	{
		""id"": ""WITCH"",
		""type"": ""NPC"",
		""englishName"": ""Brimstone Witch"",
		""name"": ""Brimstone Witch TOTRANSLATE""
	},
	{
		""id"": ""GhostBellSmall"",
		""type"": ""NPC"",
		""englishName"": ""Baby Ghost Bell"",
		""name"": ""Bébé Cloche Fantôme""
	},
	{
		""id"": ""FlakBaby"",
		""type"": ""NPC"",
		""englishName"": ""Baby Flak Crab"",
		""name"": ""Bébé Crabe Flak""
	},
	{
		""id"": ""ColossalSquid"",
		""type"": ""NPC"",
		""englishName"": ""Colossal Squid"",
		""name"": ""Calamar Colossal""
	},
	{
		""id"": ""GiantSquid"",
		""type"": ""NPC"",
		""englishName"": ""Giant Squid"",
		""name"": ""Calamar Géant""
	},
	{
		""id"": ""SupremeCalamitas"",
		""type"": ""NPC"",
		""englishName"": ""Supreme Calamitas"",
		""name"": ""Calamitas Suprême""
	},
	{
		""id"": ""CalamitasRun3"",
		""type"": ""NPC"",
		""englishName"": ""Calamitas"",
		""name"": ""Calamitas TOTRANSLATE""
	},
	{
		""id"": ""Calamitas"",
		""type"": ""NPC"",
		""englishName"": ""Calamitas"",
		""name"": ""Calamitas TOTRANSLATE""
	},
	{
		""id"": ""PlaguedTortoise"",
		""type"": ""NPC"",
		""englishName"": ""Plagueshell"",
		""name"": ""Carapeste""
	},
	{
		""id"": ""SupremeCataclysm"",
		""type"": ""NPC"",
		""englishName"": ""Cataclysm"",
		""name"": ""Cataclysme""
	},
	{
		""id"": ""CalamitasRun"",
		""type"": ""NPC"",
		""englishName"": ""Cataclysm"",
		""name"": ""Cataclysme""
	},
	{
		""id"": ""CalamitasRun2"",
		""type"": ""NPC"",
		""englishName"": ""Catastrophe"",
		""name"": ""Catastrophe TOTRANSLATE""
	},
	{
		""id"": ""SupremeCatastrophe"",
		""type"": ""NPC"",
		""englishName"": ""Catastrophe"",
		""name"": ""Catastrophe TOTRANSLATE""
	},
	{
		""id"": ""CrabShroom"",
		""type"": ""NPC"",
		""englishName"": ""Crab Shroom"",
		""name"": ""Champicrabe""
	},
	{
		""id"": ""PlagueBeeLargeG"",
		""type"": ""NPC"",
		""englishName"": ""Plague Charger"",
		""name"": ""Chargeur Pestiférée""
	},
	{
		""id"": ""PlagueBeeG"",
		""type"": ""NPC"",
		""englishName"": ""Plague Charger"",
		""name"": ""Chargeur de Peste""
	},
	{
		""id"": ""PlagueBeeLarge"",
		""type"": ""NPC"",
		""englishName"": ""Plague Charger"",
		""name"": ""Chargeur de Peste""
	},
	{
		""id"": ""PlagueBee"",
		""type"": ""NPC"",
		""englishName"": ""Plague Charger"",
		""name"": ""Chargeur de Peste""
	},
	{
		""id"": ""SunBat"",
		""type"": ""NPC"",
		""englishName"": ""Sun Bat"",
		""name"": ""Chauve-souris Solaire""
	},
	{
		""id"": ""LifeSeeker"",
		""type"": ""NPC"",
		""englishName"": ""Life Seeker"",
		""name"": ""Cherche-Vie""
	},
	{
		""id"": ""SoulSeeker"",
		""type"": ""NPC"",
		""englishName"": ""Soul Seeker"",
		""name"": ""Cherche-Âme""
	},
	{
		""id"": ""SoulSeekerSupreme"",
		""type"": ""NPC"",
		""englishName"": ""Soul Seeker"",
		""name"": ""Cherche-âme""
	},
	{
		""id"": ""AquaticSeekerTail"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Seeker"",
		""name"": ""Chercheur Aquatique""
	},
	{
		""id"": ""AquaticSeekerBody"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Seeker"",
		""name"": ""Chercheur Aquatique""
	},
	{
		""id"": ""AquaticSeekerHead"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Seeker"",
		""name"": ""Chercheur Aquatique""
	},
	{
		""id"": ""DriedSeekerTail"",
		""type"": ""NPC"",
		""englishName"": ""Dried Seeker"",
		""name"": ""Chercheur Desséché""
	},
	{
		""id"": ""DriedSeekerBody"",
		""type"": ""NPC"",
		""englishName"": ""Dried Seeker"",
		""name"": ""Chercheur Desséché""
	},
	{
		""id"": ""DriedSeekerHead"",
		""type"": ""NPC"",
		""englishName"": ""Dried Seeker"",
		""name"": ""Chercheur Désseché""
	},
	{
		""id"": ""AngryDog"",
		""type"": ""NPC"",
		""englishName"": ""Angry Dog"",
		""name"": ""Chien en Colère""
	},
	{
		""id"": ""GhostBell"",
		""type"": ""NPC"",
		""englishName"": ""Ghost Bell"",
		""name"": ""Cloche Fantôme""
	},
	{
		""id"": ""Cnidrion"",
		""type"": ""NPC"",
		""englishName"": ""Cnidrion"",
		""name"": ""Cnidrion TOTRANSLATE""
	},
	{
		""id"": ""SCalWormHeart"",
		""type"": ""NPC"",
		""englishName"": ""Brimstone Heart"",
		""name"": ""Coeur de soufre""
	},
	{
		""id"": ""SCalWormBodyWeak"",
		""type"": ""NPC"",
		""englishName"": ""Brimstone Heart"",
		""name"": ""Coeur de soufreflamme""
	},
	{
		""id"": ""DarkHeart"",
		""type"": ""NPC"",
		""englishName"": ""Dark Heart"",
		""name"": ""Coeur des Ténèbres""
	},
	{
		""id"": ""PlaguebringerShade"",
		""type"": ""NPC"",
		""englishName"": ""Plaguebringer"",
		""name"": ""Colporte-Peste""
	},
	{
		""id"": ""BelchingCoral"",
		""type"": ""NPC"",
		""englishName"": ""Belching Coral"",
		""name"": ""Corail Cracheur""
	},
	{
		""id"": ""LuminousCorvina"",
		""type"": ""NPC"",
		""englishName"": ""Luminous Corvina"",
		""name"": ""Corvina Lumineuse""
	},
	{
		""id"": ""AnthozoanCrab"",
		""type"": ""NPC"",
		""englishName"": ""Anthozoan Crab"",
		""name"": ""Crabe Anthozoaire""
	},
	{
		""id"": ""FlakCrab"",
		""type"": ""NPC"",
		""englishName"": ""Flak Crab"",
		""name"": ""Crabe Flak""
	},
	{
		""id"": ""CrabulonIdle"",
		""type"": ""NPC"",
		""englishName"": ""Crabulon"",
		""name"": ""Crabulon TOTRANSLATE""
	},
	{
		""id"": ""AstralSeekerSpit"",
		""type"": ""NPC"",
		""englishName"": ""Seeker Spit"",
		""name"": ""Crachat de Chercheur""
	},
	{
		""id"": ""NuclearToad"",
		""type"": ""NPC"",
		""englishName"": ""Nuclear Toad"",
		""name"": ""Crapaud Nucléaire""
	},
	{
		""id"": ""ArmoredDiggerBody"",
		""type"": ""NPC"",
		""englishName"": ""Armored Digger"",
		""name"": ""Creuseur Blindé""
	},
	{
		""id"": ""ArmoredDiggerHead"",
		""type"": ""NPC"",
		""englishName"": ""Armored Digger"",
		""name"": ""Creuseur Blindé""
	},
	{
		""id"": ""ArmoredDiggerTail"",
		""type"": ""NPC"",
		""englishName"": ""Armored Digger"",
		""name"": ""Creuseur Blindé""
	},
	{
		""id"": ""PolterghastHook"",
		""type"": ""NPC"",
		""englishName"": ""Polterghast Hook"",
		""name"": ""Crochet d'Épouvantôme""
	},
	{
		""id"": ""Cryocore"",
		""type"": ""NPC"",
		""englishName"": ""Cryocore"",
		""name"": ""Cryocoeur""
	},
	{
		""id"": ""Cryocore2"",
		""type"": ""NPC"",
		""englishName"": ""Cryocore"",
		""name"": ""Cryocoeur""
	},
	{
		""id"": ""Cryogen"",
		""type"": ""NPC"",
		""englishName"": ""Cryogen"",
		""name"": ""Cryogène""
	},
	{
		""id"": ""Cryon"",
		""type"": ""NPC"",
		""englishName"": ""Cryon"",
		""name"": ""Cryon TOTRANSLATE""
	},
	{
		""id"": ""StellarCulex"",
		""type"": ""NPC"",
		""englishName"": ""Stellar Culex"",
		""name"": ""Culex Stellaire""
	},
	{
		""id"": ""CalamitasEnchantDemon"",
		""type"": ""NPC"",
		""englishName"": ""Demon"",
		""name"": ""Demon TOTRANSLATE""
	},
	{
		""id"": ""SlimeGodRunSplit"",
		""type"": ""NPC"",
		""englishName"": ""Crimulan Slime God"",
		""name"": ""Dieu des Gelées Carmin""
	},
	{
		""id"": ""SlimeGodRun"",
		""type"": ""NPC"",
		""englishName"": ""Crimulan Slime God"",
		""name"": ""Dieu des Gelées Carmine""
	},
	{
		""id"": ""SlimeGod"",
		""type"": ""NPC"",
		""englishName"": ""Ebonian Slime God"",
		""name"": ""Dieu des Gelées d'Ébène""
	},
	{
		""id"": ""SlimeGodSplit"",
		""type"": ""NPC"",
		""englishName"": ""Ebonian Slime God"",
		""name"": ""Dieu des Gelées d'Ébène""
	},
	{
		""id"": ""PrismTurtle"",
		""type"": ""NPC"",
		""englishName"": ""Prism-Back"",
		""name"": ""Dos-Prisme""
	},
	{
		""id"": ""WildBumblefuck"",
		""type"": ""NPC"",
		""englishName"": ""Draconic Swarmer TOTRANSLATE"",
		""name"": ""Draconic Swarmer""
	},
	{
		""id"": ""Draedon"",
		""type"": ""NPC"",
		""englishName"": ""Draedon"",
		""name"": ""Draedon TOTRANSLATE""
	},
	{
		""id"": ""Yharon"",
		""type"": ""NPC"",
		""englishName"": ""Jungle Dragon, Yharon"",
		""name"": ""Dragon de la Jungle, Yharon""
	},
	{
		""id"": ""OldDukeSharkron"",
		""type"": ""NPC"",
		""englishName"": ""Sulphurous Sharkron"",
		""name"": ""Draquin Sulfureux""
	},
	{
		""id"": ""WulfrumDrone"",
		""type"": ""NPC"",
		""englishName"": ""Wulfrum Drone"",
		""name"": ""Drone Wulfrum""
	},
	{
		""id"": ""PhantomDebris"",
		""type"": ""NPC"",
		""englishName"": ""Phantom Debris"",
		""name"": ""Débris Fantôme""
	},
	{
		""id"": ""Trasher"",
		""type"": ""NPC"",
		""englishName"": ""Trasher"",
		""name"": ""Déchiqueteur""
	},
	{
		""id"": ""FusionFeeder"",
		""type"": ""NPC"",
		""englishName"": ""Fusion Feeder"",
		""name"": ""Dévoreur de Fusion""
	},
	{
		""id"": ""ScornEater"",
		""type"": ""NPC"",
		""englishName"": ""Scorn Eater"",
		""name"": ""Dévoreur de Mépris""
	},
	{
		""id"": ""Eidolist"",
		""type"": ""NPC"",
		""englishName"": ""Eidolist"",
		""name"": ""Eidoliste""
	},
	{
		""id"": ""PhantomSpiritS"",
		""type"": ""NPC"",
		""englishName"": ""Phantom Spirit"",
		""name"": ""Esprit Fantôme""
	},
	{
		""id"": ""PhantomSpiritL"",
		""type"": ""NPC"",
		""englishName"": ""Phantom Spirit"",
		""name"": ""Esprit Fantôme""
	},
	{
		""id"": ""PhantomSpiritM"",
		""type"": ""NPC"",
		""englishName"": ""Phantom Spirit"",
		""name"": ""Esprit Fantôme""
	},
	{
		""id"": ""PhantomSpirit"",
		""type"": ""NPC"",
		""englishName"": ""Phantom Spirit"",
		""name"": ""Esprit Fantôme""
	},
	{
		""id"": ""IceMass"",
		""type"": ""NPC"",
		""englishName"": ""Aurora Spirit"",
		""name"": ""Esprit d'Aurore""
	},
	{
		""id"": ""HeatSpirit"",
		""type"": ""NPC"",
		""englishName"": ""Heat Spirit"",
		""name"": ""Esprit de Chaleur""
	},
	{
		""id"": ""HiveMindP2"",
		""type"": ""NPC"",
		""englishName"": ""The Hive Mind"",
		""name"": ""Esprit de Ruche""
	},
	{
		""id"": ""HiveMind"",
		""type"": ""NPC"",
		""englishName"": ""The Hive Mind"",
		""name"": ""Esprit de Ruche""
	},
	{
		""id"": ""Bumblefuck2"",
		""type"": ""NPC"",
		""englishName"": ""Draconic Swarmer"",
		""name"": ""Essaimeur Draconique""
	},
	{
		""id"": ""ExhumedHeart"",
		""type"": ""NPC"",
		""englishName"": ""Exhumed Brimstone Heart"",
		""name"": ""Exhumed Brimstone Heart TOTRANSLATE""
	},
	{
		""id"": ""PhantomFuckYou"",
		""type"": ""NPC"",
		""englishName"": ""Phantom"",
		""name"": ""Fantôme""
	},
	{
		""id"": ""DetonatingFlare2"",
		""type"": ""NPC"",
		""englishName"": ""Detonating Flame"",
		""name"": ""Flame Détonnante""
	},
	{
		""id"": ""DetonatingFlare"",
		""type"": ""NPC"",
		""englishName"": ""Detonating Flame"",
		""name"": ""Flame Détonnante""
	},
	{
		""id"": ""SeaFloaty"",
		""type"": ""NPC"",
		""englishName"": ""Sea Floaty"",
		""name"": ""Flotteur des Mers""
	},
	{
		""id"": ""AquaticScourgeBody"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Scourge"",
		""name"": ""Fléau Aquatique""
	},
	{
		""id"": ""AquaticScourgeBodyAlt"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Scourge"",
		""name"": ""Fléau Aquatique""
	},
	{
		""id"": ""AquaticScourgeHead"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Scourge"",
		""name"": ""Fléau Aquatique""
	},
	{
		""id"": ""AquaticScourgeTail"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Scourge"",
		""name"": ""Fléau Aquatique""
	},
	{
		""id"": ""DesertScourgeTail"",
		""type"": ""NPC"",
		""englishName"": ""Desert Scourge"",
		""name"": ""Fléau du Désert""
	},
	{
		""id"": ""DesertScourgeTailSmall"",
		""type"": ""NPC"",
		""englishName"": ""Desert Scourge"",
		""name"": ""Fléau du Désert""
	},
	{
		""id"": ""DesertScourgeBodySmall"",
		""type"": ""NPC"",
		""englishName"": ""Desert Scourge"",
		""name"": ""Fléau du Désert""
	},
	{
		""id"": ""DesertScourgeHead"",
		""type"": ""NPC"",
		""englishName"": ""Desert Scourge"",
		""name"": ""Fléau du Désert""
	},
	{
		""id"": ""DesertScourgeHeadSmall"",
		""type"": ""NPC"",
		""englishName"": ""Desert Scourge"",
		""name"": ""Fléau du Désert""
	},
	{
		""id"": ""DesertScourgeBody"",
		""type"": ""NPC"",
		""englishName"": ""Desert Scourge"",
		""name"": ""Fléau du Désert""
	},
	{
		""id"": ""PlaguedFlyingFox"",
		""type"": ""NPC"",
		""englishName"": ""Melter"",
		""name"": ""Fondeur""
	},
	{
		""id"": ""StormlionCharger"",
		""type"": ""NPC"",
		""englishName"": ""Stormlion"",
		""name"": ""Fourmi-Tonnerre""
	},
	{
		""id"": ""ToxicMinnow"",
		""type"": ""NPC"",
		""englishName"": ""Toxic Minnow"",
		""name"": ""Fretin Toxique""
	},
	{
		""id"": ""DevourerofGodsHead2"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Guardian"",
		""name"": ""Gardien Cosmique""
	},
	{
		""id"": ""DevourerofGodsTail2"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Guardian"",
		""name"": ""Gardien Cosmique""
	},
	{
		""id"": ""DevourerofGodsBody2"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Guardian"",
		""name"": ""Gardien Cosmique""
	},
	{
		""id"": ""ProfanedGuardianBoss3"",
		""type"": ""NPC"",
		""englishName"": ""Guardian Healer"",
		""name"": ""Gardien Soigneur""
	},
	{
		""id"": ""ProfanedGuardianBoss2"",
		""type"": ""NPC"",
		""englishName"": ""Guardian Defender"",
		""name"": ""Gardien Défenseur""
	},
	{
		""id"": ""ProfanedGuardianBoss"",
		""type"": ""NPC"",
		""englishName"": ""Guardian Commander"",
		""name"": ""Gardien Commandant""
	},
	{
		""id"": ""AstralSlime"",
		""type"": ""NPC"",
		""englishName"": ""Astral Slime"",
		""name"": ""Gelée Astrale""
	},
	{
		""id"": ""AeroSlime"",
		""type"": ""NPC"",
		""englishName"": ""Aero Slime"",
		""name"": ""Gelée Aérienne""
	},
	{
		""id"": ""CharredSlime"",
		""type"": ""NPC"",
		""englishName"": ""Charred Slime"",
		""name"": ""Gelée Calcinée""
	},
	{
		""id"": ""CrimulanBlightSlime"",
		""type"": ""NPC"",
		""englishName"": ""Crimulan Blight Slime"",
		""name"": ""Gelée Carminée Trouble""
	},
	{
		""id"": ""CryoSlime"",
		""type"": ""NPC"",
		""englishName"": ""Cryo Slime"",
		""name"": ""Gelée Cryo""
	},
	{
		""id"": ""GammaSlime"",
		""type"": ""NPC"",
		""englishName"": ""Gamma Slime"",
		""name"": ""Gelée Gamma""
	},
	{
		""id"": ""IrradiatedSlime"",
		""type"": ""NPC"",
		""englishName"": ""Irradiated Slime"",
		""name"": ""Gelée Irradiée""
	},
	{
		""id"": ""MirageJelly"",
		""type"": ""NPC"",
		""englishName"": ""Mirage Jelly"",
		""name"": ""Gelée Mirage""
	},
	{
		""id"": ""PlaguedJungleSlime"",
		""type"": ""NPC"",
		""englishName"": ""Pestilent Slime"",
		""name"": ""Gelée Pestilentielle""
	},
	{
		""id"": ""PerennialSlime"",
		""type"": ""NPC"",
		""englishName"": ""Perennial Slime"",
		""name"": ""Gelée Vivace""
	},
	{
		""id"": ""WulfrumSlime"",
		""type"": ""NPC"",
		""englishName"": ""Wulfrum Slime"",
		""name"": ""Gelée Wulfrum""
	},
	{
		""id"": ""BloomSlime"",
		""type"": ""NPC"",
		""englishName"": ""Bloom Slime"",
		""name"": ""Gelée de Floraison""
	},
	{
		""id"": ""EbonianBlightSlime"",
		""type"": ""NPC"",
		""englishName"": ""Ebonian Blight Slime"",
		""name"": ""Gelée de Fléau d'Ébène""
	},
	{
		""id"": ""Sunskater"",
		""type"": ""NPC"",
		""englishName"": ""Sunskater"",
		""name"": ""Glisse-Soleil""
	},
	{
		""id"": ""HiveBlob"",
		""type"": ""NPC"",
		""englishName"": ""Hive Blob"",
		""name"": ""Goutte de Ruche""
	},
	{
		""id"": ""HiveBlob2"",
		""type"": ""NPC"",
		""englishName"": ""Hive Blob"",
		""name"": ""Goutte de Ruche""
	},
	{
		""id"": ""GreatSandShark"",
		""type"": ""NPC"",
		""englishName"": ""Great Sand Shark"",
		""name"": ""Grand Requin des Sables""
	},
	{
		""id"": ""Gnasher"",
		""type"": ""NPC"",
		""englishName"": ""Gnasher"",
		""name"": ""Grinceur""
	},
	{
		""id"": ""BigSightseer"",
		""type"": ""NPC"",
		""englishName"": ""Big Sightseer"",
		""name"": ""Gros Cherchevue""
	},
	{
		""id"": ""FearlessGoldfishWarrior"",
		""type"": ""NPC"",
		""englishName"": ""Fearless Goldfish Warrior"",
		""name"": ""Guerrier Poisson Doré Sans Peur""
	},
	{
		""id"": ""WulfrumGyrator"",
		""type"": ""NPC"",
		""englishName"": ""Wulfrum Gyrator"",
		""name"": ""Gyrateur Wulfrum""
	},
	{
		""id"": ""Hadarian"",
		""type"": ""NPC"",
		""englishName"": ""Hadarian"",
		""name"": ""Hadarien""
	},
	{
		""id"": ""ImpiousImmolator"",
		""type"": ""NPC"",
		""englishName"": ""Impious Immolator"",
		""name"": ""Immolateur Impie""
	},
	{
		""id"": ""SlimeSpawnCrimson"",
		""type"": ""NPC"",
		""englishName"": ""Crimson Slime Spawn"",
		""name"": ""Invocation de Gelée Carmin""
	},
	{
		""id"": ""KingSlimeJewel"",
		""type"": ""NPC"",
		""englishName"": ""Crown Jewel"",
		""name"": ""Joyau de la Couronne""
	},
	{
		""id"": ""PerforatorCyst"",
		""type"": ""NPC"",
		""englishName"": ""Perforator Cyst"",
		""name"": ""Kyste de Perforateur""
	},
	{
		""id"": ""HiveCyst"",
		""type"": ""NPC"",
		""englishName"": ""Hive Cyst"",
		""name"": ""Kyste de Ruche""
	},
	{
		""id"": ""Bumblefuck"",
		""type"": ""NPC"",
		""englishName"": ""The Dragonfolly"",
		""name"": ""La Folie Draconique""
	},
	{
		""id"": ""PerforatorHive"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator Hive"",
		""name"": ""La Ruche du Perforateur""
	},
	{
		""id"": ""CosmicLantern"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Lantern"",
		""name"": ""Lanterne Cosmique""
	},
	{
		""id"": ""SlimeGodCore"",
		""type"": ""NPC"",
		""englishName"": ""The Slime God"",
		""name"": ""Le Dieu des Gelées""
	},
	{
		""id"": ""DevourerofGodsHeadS"",
		""type"": ""NPC"",
		""englishName"": ""The Devourer of Gods"",
		""name"": ""Le Dévoreur de Dieux""
	},
	{
		""id"": ""DevourerofGodsTail"",
		""type"": ""NPC"",
		""englishName"": ""The Devourer of Gods"",
		""name"": ""Le Dévoreur de Dieux""
	},
	{
		""id"": ""DevourerofGodsBody"",
		""type"": ""NPC"",
		""englishName"": ""The Devourer of Gods"",
		""name"": ""Le Dévoreur de Dieux""
	},
	{
		""id"": ""DevourerofGodsTailS"",
		""type"": ""NPC"",
		""englishName"": ""The Devourer of Gods"",
		""name"": ""Le Dévoreur de Dieux""
	},
	{
		""id"": ""DevourerofGodsHead"",
		""type"": ""NPC"",
		""englishName"": ""The Devourer of Gods"",
		""name"": ""Le Dévoreur de Dieux""
	},
	{
		""id"": ""DevourerofGodsBodyS"",
		""type"": ""NPC"",
		""englishName"": ""The Devourer of Gods"",
		""name"": ""Le Dévoreur de Dieux""
	},
	{
		""id"": ""PlaguebringerGoliath"",
		""type"": ""NPC"",
		""englishName"": ""The Plaguebringer Goliath"",
		""name"": ""Le Goliath Colporte-Peste""
	},
	{
		""id"": ""Leviathan"",
		""type"": ""NPC"",
		""englishName"": ""The Leviathan"",
		""name"": ""Le Leviathan""
	},
	{
		""id"": ""PerforatorBodyLarge"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur""
	},
	{
		""id"": ""PerforatorTailMedium"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur""
	},
	{
		""id"": ""PerforatorTailSmall"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur""
	},
	{
		""id"": ""PerforatorBodySmall"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur""
	},
	{
		""id"": ""PerforatorHeadLarge"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur""
	},
	{
		""id"": ""PerforatorHeadMedium"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur""
	},
	{
		""id"": ""PerforatorBodyMedium"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur""
	},
	{
		""id"": ""PerforatorHeadSmall"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur""
	},
	{
		""id"": ""PerforatorTailLarge"",
		""type"": ""NPC"",
		""englishName"": ""The Perforator"",
		""name"": ""Le Perforateur""
	},
	{
		""id"": ""OldDuke"",
		""type"": ""NPC"",
		""englishName"": ""The Old Duke"",
		""name"": ""Le Vieux Duc""
	},
	{
		""id"": ""LecherousOrb"",
		""type"": ""NPC"",
		""englishName"": ""Lecherous Orb"",
		""name"": ""Lecherous Orb TOTRANSLATE""
	},
	{
		""id"": ""CragmawMire"",
		""type"": ""NPC"",
		""englishName"": ""Cragmaw Mire"",
		""name"": ""Machoire Rochefange""
	},
	{
		""id"": ""Mantis"",
		""type"": ""NPC"",
		""englishName"": ""Mantis"",
		""name"": ""Mante""
	},
	{
		""id"": ""MantisShrimp"",
		""type"": ""NPC"",
		""englishName"": ""Mantis Shrimp"",
		""name"": ""Mante Crevette""
	},
	{
		""id"": ""SignusBomb"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Mine"",
		""name"": ""Mine Cosmique""
	},
	{
		""id"": ""PlagueMine"",
		""type"": ""NPC"",
		""englishName"": ""Plague Mine"",
		""name"": ""Mine de Peste""
	},
	{
		""id"": ""PlagueHomingMissile"",
		""type"": ""NPC"",
		""englishName"": ""Plague Homing Missile"",
		""name"": ""Missile de Peste à Tête Chercheuse""
	},
	{
		""id"": ""MorayEel"",
		""type"": ""NPC"",
		""englishName"": ""Moray Eel"",
		""name"": ""Murène""
	},
	{
		""id"": ""Mauler"",
		""type"": ""NPC"",
		""englishName"": ""Mauler"",
		""name"": ""Mutilateur""
	},
	{
		""id"": ""DemonPortal"",
		""type"": ""NPC"",
		""englishName"": ""Mysterious Portal"",
		""name"": ""Mysterious Portal TOTRANSLATE""
	},
	{
		""id"": ""BoxJellyfish"",
		""type"": ""NPC"",
		""englishName"": ""Box Jellyfish"",
		""name"": ""Méduse-Boîte""
	},
	{
		""id"": ""Skyfin"",
		""type"": ""NPC"",
		""englishName"": ""Skyfin"",
		""name"": ""Nageoire Céleste""
	},
	{
		""id"": ""ShockstormShuttle"",
		""type"": ""NPC"",
		""englishName"": ""Shockstorm Shuttle"",
		""name"": ""Navette de Tempête de Choc""
	},
	{
		""id"": ""Nova"",
		""type"": ""NPC"",
		""englishName"": ""Nova"",
		""name"": ""Nova TOTRANSLATE""
	},
	{
		""id"": ""CeaselessVoid"",
		""type"": ""NPC"",
		""englishName"": ""Ceaseless Void"",
		""name"": ""Néant Incessant""
	},
	{
		""id"": ""BlightedEye"",
		""type"": ""NPC"",
		""englishName"": ""Blighted Eye"",
		""name"": ""Oeil Troublé""
	},
	{
		""id"": ""CalamityEye"",
		""type"": ""NPC"",
		""englishName"": ""Calamity Eye"",
		""name"": ""Oeil de Calamity""
	},
	{
		""id"": ""Orthocera"",
		""type"": ""NPC"",
		""englishName"": ""Orthocera"",
		""name"": ""Orthocera TOTRANSLATE""
	},
	{
		""id"": ""AquaticUrchin"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Urchin"",
		""name"": ""Oursin Aquatique""
	},
	{
		""id"": ""SeaUrchin"",
		""type"": ""NPC"",
		""englishName"": ""Sea Urchin"",
		""name"": ""Oursin de Mer""
	},
	{
		""id"": ""Clam"",
		""type"": ""NPC"",
		""englishName"": ""Clam"",
		""name"": ""Palourde""
	},
	{
		""id"": ""GiantClam"",
		""type"": ""NPC"",
		""englishName"": ""Giant Clam"",
		""name"": ""Palourde Géante""
	},
	{
		""id"": ""Parasea"",
		""type"": ""NPC"",
		""englishName"": ""Parasea"",
		""name"": ""Paramer""
	},
	{
		""id"": ""AquaticParasite"",
		""type"": ""NPC"",
		""englishName"": ""Aquatic Parasite"",
		""name"": ""Parasite Aquatique""
	},
	{
		""id"": ""SulfurousSkater"",
		""type"": ""NPC"",
		""englishName"": ""Sulphurous Skater"",
		""name"": ""Patineur Sulfureux""
	},
	{
		""id"": ""Piggy"",
		""type"": ""NPC"",
		""englishName"": ""Piggy"",
		""name"": ""Peggy""
	},
	{
		""id"": ""Hiveling"",
		""type"": ""NPC"",
		""englishName"": ""Hiveling"",
		""name"": ""Pestelin""
	},
	{
		""id"": ""SmallSightseer"",
		""type"": ""NPC"",
		""englishName"": ""Small Sightseer"",
		""name"": ""Petit Cherchevue""
	},
	{
		""id"": ""DespairStone"",
		""type"": ""NPC"",
		""englishName"": ""Despair Stone"",
		""name"": ""Pierre de Désespoir""
	},
	{
		""id"": ""FlamePillar"",
		""type"": ""NPC"",
		""englishName"": ""Flame Pillar"",
		""name"": ""Pilier de Flamme""
	},
	{
		""id"": ""RockPillar"",
		""type"": ""NPC"",
		""englishName"": ""Rock Pillar"",
		""name"": ""Pillier de Roche""
	},
	{
		""id"": ""Pitbull"",
		""type"": ""NPC"",
		""englishName"": ""Pitbull"",
		""name"": ""Pitbull TOTRANSLATE""
	},
	{
		""id"": ""Bloatfish"",
		""type"": ""NPC"",
		""englishName"": ""Bloatfish"",
		""name"": ""Poisson Bouffi""
	},
	{
		""id"": ""Catfish"",
		""type"": ""NPC"",
		""englishName"": ""Catfish"",
		""name"": ""Poisson-Chat""
	},
	{
		""id"": ""DevilFish"",
		""type"": ""NPC"",
		""englishName"": ""Devil Fish"",
		""name"": ""Poisson-Diable""
	},
	{
		""id"": ""DevilFishAlt"",
		""type"": ""NPC"",
		""englishName"": ""Devil Fish"",
		""name"": ""Poisson-Diable""
	},
	{
		""id"": ""Frogfish"",
		""type"": ""NPC"",
		""englishName"": ""Frogfish"",
		""name"": ""Poisson-Grenouille""
	},
	{
		""id"": ""Laserfish"",
		""type"": ""NPC"",
		""englishName"": ""Laserfish"",
		""name"": ""Poisson-Laser""
	},
	{
		""id"": ""OarfishBody"",
		""type"": ""NPC"",
		""englishName"": ""Oarfish"",
		""name"": ""Poisson-Ruban""
	},
	{
		""id"": ""OarfishHead"",
		""type"": ""NPC"",
		""englishName"": ""Oarfish"",
		""name"": ""Poisson-Ruban""
	},
	{
		""id"": ""OarfishTail"",
		""type"": ""NPC"",
		""englishName"": ""Oarfish"",
		""name"": ""Poisson-Ruban""
	},
	{
		""id"": ""Viperfish"",
		""type"": ""NPC"",
		""englishName"": ""Viperfish"",
		""name"": ""Poisson-Vipère""
	},
	{
		""id"": ""ChaoticPuffer"",
		""type"": ""NPC"",
		""englishName"": ""Chaotic Puffer"",
		""name"": ""Poisson-globe Chaotique""
	},
	{
		""id"": ""FAP"",
		""type"": ""NPC"",
		""englishName"": ""Drunk Princess"",
		""name"": ""Princesse Ivre""
	},
	{
		""id"": ""Providence"",
		""type"": ""NPC"",
		""englishName"": ""Providence, the Profaned Goddess"",
		""name"": ""Providence, la Déesse Profanée""
	},
	{
		""id"": ""WulfrumPylon"",
		""type"": ""NPC"",
		""englishName"": ""Wulfrum Pylon"",
		""name"": ""Pylône Wulfrum""
	},
	{
		""id"": ""Radiator"",
		""type"": ""NPC"",
		""englishName"": ""Radiator"",
		""name"": ""Radiateur""
	},
	{
		""id"": ""EutrophicRay"",
		""type"": ""NPC"",
		""englishName"": ""Eutrophic Ray"",
		""name"": ""Raie Eutrophique""
	},
	{
		""id"": ""CrawlerAmber"",
		""type"": ""NPC"",
		""englishName"": ""Amber Crawler"",
		""name"": ""Rampant d'Ambre""
	},
	{
		""id"": ""CrawlerAmethyst"",
		""type"": ""NPC"",
		""englishName"": ""Amethyst Crawler"",
		""name"": ""Rampant d'Améthyste""
	},
	{
		""id"": ""CrawlerEmerald"",
		""type"": ""NPC"",
		""englishName"": ""Emerald Crawler"",
		""name"": ""Rampant d'Émeraude""
	},
	{
		""id"": ""CrawlerCrystal"",
		""type"": ""NPC"",
		""englishName"": ""Crystal Crawler"",
		""name"": ""Rampant de Cristal""
	},
	{
		""id"": ""CrawlerDiamond"",
		""type"": ""NPC"",
		""englishName"": ""Diamond Crawler"",
		""name"": ""Rampant de Diamant""
	},
	{
		""id"": ""CrawlerRuby"",
		""type"": ""NPC"",
		""englishName"": ""Ruby Crawler"",
		""name"": ""Rampant de Rubis""
	},
	{
		""id"": ""CrawlerSapphire"",
		""type"": ""NPC"",
		""englishName"": ""Sapphire Crawler"",
		""name"": ""Rampant de Saphir""
	},
	{
		""id"": ""CrawlerTopaz"",
		""type"": ""NPC"",
		""englishName"": ""Topaz Crawler"",
		""name"": ""Rampant de Topaze""
	},
	{
		""id"": ""EnchantedNightcrawler"",
		""type"": ""NPC"",
		""englishName"": ""Enchanted Nightcrawler"",
		""name"": ""Rampenuit Enchanté""
	},
	{
		""id"": ""RavagerHead"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur""
	},
	{
		""id"": ""RavagerHead2"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur""
	},
	{
		""id"": ""RavagerLegLeft"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur""
	},
	{
		""id"": ""RavagerClawLeft"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur""
	},
	{
		""id"": ""RavagerClawRight"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur""
	},
	{
		""id"": ""RavagerBody"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur""
	},
	{
		""id"": ""RavagerLegRight"",
		""type"": ""NPC"",
		""englishName"": ""Ravager"",
		""name"": ""Ravageur""
	},
	{
		""id"": ""SlimeSpawnCrimson2"",
		""type"": ""NPC"",
		""englishName"": ""Crimson Slime Spawn"",
		""name"": ""Rejeton de Gelée Carmin""
	},
	{
		""id"": ""SlimeSpawnCorrupt2"",
		""type"": ""NPC"",
		""englishName"": ""Corrupt Slime Spawn"",
		""name"": ""Rejeton de Gelée Corrompue""
	},
	{
		""id"": ""SlimeSpawnCorrupt"",
		""type"": ""NPC"",
		""englishName"": ""Corrupt Slime Spawn"",
		""name"": ""Rejeton de Gelée Corrompue""
	},
	{
		""id"": ""RepairUnitCritter"",
		""type"": ""NPC"",
		""englishName"": ""Repair Unit"",
		""name"": ""Repair Unit TOTRANSLATE""
	},
	{
		""id"": ""Reaper"",
		""type"": ""NPC"",
		""englishName"": ""Reaper Shark"",
		""name"": ""Requin Faucheur""
	},
	{
		""id"": ""SEAHOE"",
		""type"": ""NPC"",
		""englishName"": ""Sea King"",
		""name"": ""Roi des mers""
	},
	{
		""id"": ""Rotdog"",
		""type"": ""NPC"",
		""englishName"": ""Rotdog TOTRANSLATE"",
		""name"": ""Rotdog""
	},
	{
		""id"": ""Hive"",
		""type"": ""NPC"",
		""englishName"": ""Hive"",
		""name"": ""Ruche""
	},
	{
		""id"": ""AureusSpawn"",
		""type"": ""NPC"",
		""englishName"": ""Aureus Spawn"",
		""name"": ""Réjeton d'Aureus""
	},
	{
		""id"": ""DankCreeper"",
		""type"": ""NPC"",
		""englishName"": ""Dank Creeper"",
		""name"": ""Rôdeur Humide""
	},
	{
		""id"": ""WaterLeech"",
		""type"": ""NPC"",
		""englishName"": ""Water Leech"",
		""name"": ""Sangsue d'Eau""
	},
	{
		""id"": ""Twinkler"",
		""type"": ""NPC"",
		""englishName"": ""Twinkler"",
		""name"": ""Scintilleur""
	},
	{
		""id"": ""ScryllarRage"",
		""type"": ""NPC"",
		""englishName"": ""Scryllar"",
		""name"": ""Scryllar TOTRANSLATE""
	},
	{
		""id"": ""Scryllar"",
		""type"": ""NPC"",
		""englishName"": ""Scryllar"",
		""name"": ""Scryllar TOTRANSLATE""
	},
	{
		""id"": ""Cuttlefish"",
		""type"": ""NPC"",
		""englishName"": ""Cuttlefish"",
		""name"": ""Seiche""
	},
	{
		""id"": ""SCalWormArm"",
		""type"": ""NPC"",
		""englishName"": ""Sepulcher"",
		""name"": ""Sepulcher TOTRANSLATE""
	},
	{
		""id"": ""SeaSerpent2"",
		""type"": ""NPC"",
		""englishName"": ""Sea Serpent"",
		""name"": ""Serpent de Mer""
	},
	{
		""id"": ""SeaSerpent3"",
		""type"": ""NPC"",
		""englishName"": ""Sea Serpent"",
		""name"": ""Serpent de Mer""
	},
	{
		""id"": ""SeaSerpent1"",
		""type"": ""NPC"",
		""englishName"": ""Sea Serpent"",
		""name"": ""Serpent de Mer""
	},
	{
		""id"": ""SeaSerpent4"",
		""type"": ""NPC"",
		""englishName"": ""Sea Serpent"",
		""name"": ""Serpent de Mer""
	},
	{
		""id"": ""SeaSerpent5"",
		""type"": ""NPC"",
		""englishName"": ""Sea Serpent"",
		""name"": ""Serpent de Mer""
	},
	{
		""id"": ""Signus"",
		""type"": ""NPC"",
		""englishName"": ""Signus, Envoy of the Devourer"",
		""name"": ""Signus, Émissaire du Dévoreur""
	},
	{
		""id"": ""OverloadedSoldier"",
		""type"": ""NPC"",
		""englishName"": ""Overloaded Soldier"",
		""name"": ""Soldat Surchargé""
	},
	{
		""id"": ""Flounder"",
		""type"": ""NPC"",
		""englishName"": ""Flounder"",
		""name"": ""Sole""
	},
	{
		""id"": ""AstralProbe"",
		""type"": ""NPC"",
		""englishName"": ""Astral Probe"",
		""name"": ""Sonde Astrale""
	},
	{
		""id"": ""SuperDummyNPC"",
		""type"": ""NPC"",
		""englishName"": ""Super Dummy"",
		""name"": ""Super Mannequin""
	},
	{
		""id"": ""SCalWormTail"",
		""type"": ""NPC"",
		""englishName"": ""Sepulcher"",
		""name"": ""Sépulcre""
	},
	{
		""id"": ""SCalWormBody"",
		""type"": ""NPC"",
		""englishName"": ""Sepulcher"",
		""name"": ""Sépulcre""
	},
	{
		""id"": ""SCalWormHead"",
		""type"": ""NPC"",
		""englishName"": ""Sepulcher"",
		""name"": ""Sépulcre""
	},
	{
		""id"": ""NuclearTerror"",
		""type"": ""NPC"",
		""englishName"": ""Nuclear Terror"",
		""name"": ""Terreur Nucléaire""
	},
	{
		""id"": ""StormWeaverTailNaked"",
		""type"": ""NPC"",
		""englishName"": ""Storm Weaver"",
		""name"": ""Tisse-Tempête""
	},
	{
		""id"": ""StormWeaverHead"",
		""type"": ""NPC"",
		""englishName"": ""Storm Weaver"",
		""name"": ""Tisse-Tempête""
	},
	{
		""id"": ""StormWeaverBodyNaked"",
		""type"": ""NPC"",
		""englishName"": ""Storm Weaver"",
		""name"": ""Tisse-Tempête""
	},
	{
		""id"": ""StormWeaverHeadNaked"",
		""type"": ""NPC"",
		""englishName"": ""Storm Weaver"",
		""name"": ""Tisse-Tempête""
	},
	{
		""id"": ""StormWeaverBody"",
		""type"": ""NPC"",
		""englishName"": ""Storm Weaver"",
		""name"": ""Tisse-Tempête""
	},
	{
		""id"": ""StormWeaverTail"",
		""type"": ""NPC"",
		""englishName"": ""Storm Weaver"",
		""name"": ""Tisse-Tempête""
	},
	{
		""id"": ""SandTortoise"",
		""type"": ""NPC"",
		""englishName"": ""Sand Tortoise"",
		""name"": ""Tortue des Sables""
	},
	{
		""id"": ""Trilobite"",
		""type"": ""NPC"",
		""englishName"": ""Trilobite"",
		""name"": ""Trilobite TOTRANSLATE""
	},
	{
		""id"": ""ProvSpawnHealer"",
		""type"": ""NPC"",
		""englishName"": ""Providence Healer"",
		""name"": ""Soigneur de Providence""
	},
	{
		""id"": ""ProvSpawnOffense"",
		""type"": ""NPC"",
		""englishName"": ""Providence Offense"",
		""name"": ""Attaquant de Providence""
	},
	{
		""id"": ""ProvSpawnDefense"",
		""type"": ""NPC"",
		""englishName"": ""Providence Defender"",
		""name"": ""Defenseur de Providence""
	},
	{
		""id"": ""WulfrumRover"",
		""type"": ""NPC"",
		""englishName"": ""Wulfrum Rover"",
		""name"": ""Vadrouilleur Wulfrum""
	},
	{
		""id"": ""SeaMinnow"",
		""type"": ""NPC"",
		""englishName"": ""Sea Minnow"",
		""name"": ""Vairon de Mer""
	},
	{
		""id"": ""BobbitWormSegment"",
		""type"": ""NPC"",
		""englishName"": ""Bobbit Worm"",
		""name"": ""Ver Bobbit""
	},
	{
		""id"": ""BobbitWormHead"",
		""type"": ""NPC"",
		""englishName"": ""Bobbit Worm"",
		""name"": ""Ver Bobbit""
	},
	{
		""id"": ""BloodwormNormal"",
		""type"": ""NPC"",
		""englishName"": ""Bloodworm"",
		""name"": ""Ver de Sang""
	},
	{
		""id"": ""BloodwormFleeing"",
		""type"": ""NPC"",
		""englishName"": ""Bloodworm"",
		""name"": ""Ver de Sang""
	},
	{
		""id"": ""PlaguedDerpling"",
		""type"": ""NPC"",
		""englishName"": ""Viruling"",
		""name"": ""Virulant""
	},
	{
		""id"": ""EidolonWyrmBody"",
		""type"": ""NPC"",
		""englishName"": ""Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon""
	},
	{
		""id"": ""EidolonWyrmTail"",
		""type"": ""NPC"",
		""englishName"": ""Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon""
	},
	{
		""id"": ""EidolonWyrmBodyAlt"",
		""type"": ""NPC"",
		""englishName"": ""Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon""
	},
	{
		""id"": ""EidolonWyrmHead"",
		""type"": ""NPC"",
		""englishName"": ""Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon""
	},
	{
		""id"": ""EidolonWyrmTailHuge"",
		""type"": ""NPC"",
		""englishName"": ""Adult Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon Adulte""
	},
	{
		""id"": ""EidolonWyrmBodyHuge"",
		""type"": ""NPC"",
		""englishName"": ""Adult Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon Adulte""
	},
	{
		""id"": ""EidolonWyrmBodyAltHuge"",
		""type"": ""NPC"",
		""englishName"": ""Adult Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon Adulte""
	},
	{
		""id"": ""EidolonWyrmHeadHuge"",
		""type"": ""NPC"",
		""englishName"": ""Adult Eidolon Wyrm"",
		""name"": ""Wyrm Eidolon Adulte""
	},
	{
		""id"": ""AresGaussNuke"",
		""type"": ""NPC"",
		""englishName"": ""XF-09 Ares Gauss Nuke"",
		""name"": ""XF-09 Ares Gauss Nuke TOTRANSLATE""
	},
	{
		""id"": ""AresLaserCannon"",
		""type"": ""NPC"",
		""englishName"": ""XF-09 Ares Laser Cannon"",
		""name"": ""XF-09 Ares Laser Cannon TOTRANSLATE""
	},
	{
		""id"": ""AresPlasmaFlamethrower"",
		""type"": ""NPC"",
		""englishName"": ""XF-09 Ares Plasma Cannon"",
		""name"": ""XF-09 Ares Plasma Cannon TOTRANSLATE""
	},
	{
		""id"": ""AresBody"",
		""type"": ""NPC"",
		""englishName"": ""XF-09 Ares"",
		""name"": ""XF-09 Ares TOTRANSLATE""
	},
	{
		""id"": ""AresTeslaCannon"",
		""type"": ""NPC"",
		""englishName"": ""XF-09 Ares Tesla Cannon"",
		""name"": ""XF-09 Ares Tesla Cannon TOTRANSLATE""
	},
	{
		""id"": ""ThanatosHead"",
		""type"": ""NPC"",
		""englishName"": ""XM-05 Thanatos"",
		""name"": ""XM-05 Thanatos TOTRANSLATE""
	},
	{
		""id"": ""ThanatosBody2"",
		""type"": ""NPC"",
		""englishName"": ""XM-05 Thanatos"",
		""name"": ""XM-05 Thanatos TOTRANSLATE""
	},
	{
		""id"": ""ThanatosBody1"",
		""type"": ""NPC"",
		""englishName"": ""XM-05 Thanatos"",
		""name"": ""XM-05 Thanatos TOTRANSLATE""
	},
	{
		""id"": ""ThanatosTail"",
		""type"": ""NPC"",
		""englishName"": ""XM-05 Thanatos"",
		""name"": ""XM-05 Thanatos TOTRANSLATE""
	},
	{
		""id"": ""Artemis"",
		""type"": ""NPC"",
		""englishName"": ""XS-01 Artemis"",
		""name"": ""XS-01 Artemis TOTRANSLATE""
	},
	{
		""id"": ""Apollo"",
		""type"": ""NPC"",
		""englishName"": ""XS-03 Apollo"",
		""name"": ""XS-03 Apollo TOTRANSLATE""
	},
	{
		""id"": ""Brimling"",
		""type"": ""NPC"",
		""englishName"": ""Brimling"",
		""name"": ""soufrelin""
	},
	{
		""id"": ""CosmicElemental"",
		""type"": ""NPC"",
		""englishName"": ""Cosmic Elemental"",
		""name"": ""Élementaire Cosmique""
	},
	{
		""id"": ""ThiccWaifu"",
		""type"": ""NPC"",
		""englishName"": ""Cloud Elemental"",
		""name"": ""Élémentaire de Nuage""
	},
	{
		""id"": ""Horse"",
		""type"": ""NPC"",
		""englishName"": ""Earth Elemental"",
		""name"": ""Élémentaire de Terre""
	},
	{
		""id"": ""BrimstoneElemental"",
		""type"": ""NPC"",
		""englishName"": ""Brimstone Elemental"",
		""name"": ""Élémentaire de soufre""
	},
	{
		""id"": ""DarkEnergy"",
		""type"": ""NPC"",
		""englishName"": ""Dark Energy"",
		""name"": ""Énergie Noire""
	},
	{
		""id"": ""DarkEnergy2"",
		""type"": ""NPC"",
		""englishName"": ""Dark Energy"",
		""name"": ""Énergie Noire""
	},
	{
		""id"": ""DarkEnergy3"",
		""type"": ""NPC"",
		""englishName"": ""Dark Energy"",
		""name"": ""Énergie Noire""
	},
	{
		""id"": ""ProfanedEnergyLantern"",
		""type"": ""NPC"",
		""englishName"": ""Profaned Energy"",
		""name"": ""Énergie Profanée""
	},
	{
		""id"": ""ProfanedEnergyBody"",
		""type"": ""NPC"",
		""englishName"": ""Profaned Energy"",
		""name"": ""Énergie Profanée""
	},
	{
		""id"": ""Polterghast"",
		""type"": ""NPC"",
		""englishName"": ""Polterghast"",
		""name"": ""Épouvantôme""
	},
	{
		""id"": ""PolterPhantom"",
		""type"": ""NPC"",
		""englishName"": ""Polterghast"",
		""name"": ""Épouvantôme""
	},
	{
		""id"": ""SkyOreText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The ground is glittering with cyan light."",
		""name"": """",
		""desc"": ""Le sol brille d'une lumière cyan.""
	},
	{
		""id"": ""IceOreText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The ice caves are crackling with frigid energy."",
		""name"": """",
		""desc"": ""Les cavernes de glace crépitent d'énergie frigide.""
	},
	{
		""id"": ""PlantOreText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Energized plant matter has formed in the underground."",
		""name"": """",
		""desc"": ""De la matière végétale énergisée s'est formée dans les souterrains.""
	},
	{
		""id"": ""TreeOreText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Fossilized tree bark is bursting through the jungle's mud."",
		""name"": """",
		""desc"": ""De l'écorce d'arbre fossilisée surgit de la boue de la jungle.""
	},
	{
		""id"": ""AuricOreText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A godly aura has blessed the world's caverns."",
		""name"": """",
		""desc"": ""Une aura divine a béni les cavernes du monde.""
	},
	{
		""id"": ""FutureOreText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A cold and dark energy has materialized in space."",
		""name"": """",
		""desc"": ""Une énergie froide et sombre s'est matérialisée dans l'espace.""
	},
	{
		""id"": ""UglyBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The Sunken Sea trembles..."",
		""name"": """",
		""desc"": ""La Mer Ensevelie tremble...""
	},
	{
		""id"": ""SteelSkullBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A blood red inferno lingers in the night..."",
		""name"": """",
		""desc"": ""Un enfer rouge sang subsiste la nuit...""
	},
	{
		""id"": ""BrimmyBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A protective spell has been lifted from the crags! You can now mine Charred Ore."",
		""name"": """",
		""desc"": ""Un sort protecteur des vestiges a été levé! Vous pouvez maintenant miner le Minerai Calciné.""
	},
	{
		""id"": ""WetWormBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The sulphuric sky darkens..."",
		""name"": """",
		""desc"": ""Le ciel sulfurique s'assombrit...""
	},
	{
		""id"": ""PlantBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The ocean depths are trembling."",
		""name"": """",
		""desc"": ""Les profondeurs de l'océan tremblent.""
	},
	{
		""id"": ""BabyBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A plague has befallen the Jungle."",
		""name"": """",
		""desc"": ""Une peste s'est répandue dans la jungle.""
	},
	{
		""id"": ""MoonBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The profaned flame blazes fiercely!"",
		""name"": """",
		""desc"": ""La flame profanée flamboie férocement!""
	},
	{
		""id"": ""MoonBossText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Cosmic terrors are watching..."",
		""name"": """",
		""desc"": ""Les terreurs cosmiques vous observent...""
	},
	{
		""id"": ""MoonBossText3"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The bloody moon beckons..."",
		""name"": """",
		""desc"": ""La lune sanglante appelle...""
	},
	{
		""id"": ""PlagueBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""PLAGUE NUKE BARRAGE ARMED, PREPARING FOR LAUNCH!!!"",
		""name"": """",
		""desc"": ""BARRAGE CHIRURGICAL DE PESTE ARMÉ, PRÉPARATION AU LANCEMENT!!!""
	},
	{
		""id"": ""PlagueBossText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""MISSILES LAUNCHED, TARGETING ROUTINE INITIATED!!!"",
		""name"": """",
		""desc"": ""MISSILES LANCÉS, ROUTINE DE CIBLAGE INITIÉE!!!""
	},
	{
		""id"": ""ProfanedBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The air is burning..."",
		""name"": """",
		""desc"": ""L'air s'embrase...""
	},
	{
		""id"": ""ProfanedBossText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Shrieks are echoing from the dungeon."",
		""name"": """",
		""desc"": ""Des hurlements font écho depuis le donjon.""
	},
	{
		""id"": ""ProfanedBossText3"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The calamitous beings have been inundated with bloodstone."",
		""name"": """",
		""desc"": ""Les êtres calamiteux ont été inondés de pierre de sang.""
	},
	{
		""id"": ""ProfanedBossText4"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The Profaned Goddess has recognised your devotion to purity!"",
		""name"": """",
		""desc"": ""La Déesse Profanée a reconnu votre dévotion à la pureté!""
	},
	{
		""id"": ""GhostBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The abyssal spirits have been disturbed."",
		""name"": """",
		""desc"": ""Les esprits abyssaux ont été dérangés.""
	},
	{
		""id"": ""GhostBossText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Wails echo through the dilapidated dungeon halls..."",
		""name"": """",
		""desc"": ""Des échos de gémissents traversent les salles dilapidés du donjon...""
	},
	{
		""id"": ""GhostBossText3"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Long-dead prisoners seek their zealous revenge..."",
		""name"": """",
		""desc"": ""Des prisonniers mort depuis longtemps réclament fervemment leur vengeance...""
	},
	{
		""id"": ""GhostBossText4"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The souls released stir the acidic storms..."",
		""name"": """",
		""desc"": ""Les âmes relâchées agitent les tempêtes acides...""
	},
	{
		""id"": ""SupremeBossText3"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Alright, let's get started. Not sure why you're bothering."",
		""name"": """",
		""desc"": ""Très bien, commencons. Je ne suis pas sure de savoir pourquoi tu t'embêtes.""
	},
	{
		""id"": ""SupremeBossText4"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""You seem so confident, even though you are painfully ignorant of what has yet to transpire."",
		""name"": """",
		""desc"": ""Tu as l'air si confiant, quand bien même tu es douleureusement ignorant de ce qu'il se trame.""
	},
	{
		""id"": ""SupremeBossText5"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Everything was going well until you came along."",
		""name"": """",
		""desc"": ""Tout allait bien avant que tu apparaisses.""
	},
	{
		""id"": ""SupremeBossText6"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Brothers, could you assist me for a moment? This ordeal is growing tiresome."",
		""name"": """",
		""desc"": ""Mes frères, pouvez-vous m'assister un instant? Ce calvaire commence à me fatiguer.""
	},
	{
		""id"": ""SupremeBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Don't worry, I still have plenty of tricks left."",
		""name"": """",
		""desc"": ""Ne t'inquiètes pas, j'ai encore plein de tours dans mon sac.""
	},
	{
		""id"": ""SupremeBossText7"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Hmm...perhaps I should let the little ones out to play for a while."",
		""name"": """",
		""desc"": ""Hmm...peut-être que je devrais laisser les petits sortir jouer un moment.""
	},
	{
		""id"": ""SupremeBossText8"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Impressive...but still not good enough!"",
		""name"": """",
		""desc"": ""Impressionnant... mais toujours insuffisant!""
	},
	{
		""id"": ""SupremeBossText9"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""I'm just getting started!"",
		""name"": """",
		""desc"": ""Je ne fais que m'echauffer!""
	},
	{
		""id"": ""SupremeBossText20"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""How are you still alive!?"",
		""name"": """",
		""desc"": ""Comment es-tu encore en vie!?""
	},
	{
		""id"": ""SupremeBossText21"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Just stop!"",
		""name"": """",
		""desc"": ""Arrêtez!""
	},
	{
		""id"": ""SupremeBossText22"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Even if you defeat me you would still have the lord to contend with!"",
		""name"": """",
		""desc"": ""Même si tu me terrasses, il te faudra encore battre le seigneur!""
	},
	{
		""id"": ""SupremeBossText23"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""He has never lost a battle!"",
		""name"": """",
		""desc"": ""Il n'a jamais perdu un combat!""
	},
	{
		""id"": ""SupremeBossText24"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Not even I could defeat him! What hope do you have!?"",
		""name"": """",
		""desc"": ""Même moi je n'ai pu le vaincre! Quelles chances as-tu!?""
	},
	{
		""id"": ""SupremeBossText25"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""He has grown far stronger since we last fought...you stand no chance."",
		""name"": """",
		""desc"": ""Il est encore plus fort depuis notre dernier combat...tu n'as aucune chance.""
	},
	{
		""id"": ""SupremeBossText26"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Well...I suppose this is the end..."",
		""name"": """",
		""desc"": ""Et bien...Je suppose que c'est fini...""
	},
	{
		""id"": ""SupremeBossText27"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Perhaps one of these times I'll change my mind..."",
		""name"": """",
		""desc"": ""Peut-être qu'un de ces jours je changerai d'avis...""
	},
	{
		""id"": ""SupremeBossText28"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""You aren't hurting as much as I'd like...are you cheating?"",
		""name"": """",
		""desc"": ""Tu n'as pas aussi mal que ce à quoi je m'attendais...tu ne tricherais pas, par hasard?""
	},
	{
		""id"": ""SupremeBossText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Go to hell."",
		""name"": """",
		""desc"": ""Va en enfer.""
	},
	{
		""id"": ""SupremeBossText10"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""At long last I am free...for a time. I'll keep coming back, just like you. Until we meet again, farewell."",
		""name"": """",
		""desc"": ""Enfin je suis libre...pour un temps. Je continuerai à revenir, tout comme toi. Je te dis adieu, jusqu'à notre prochaine rencontre.""
	},
	{
		""id"": ""SupremeBossText11"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Do you enjoy going through hell?"",
		""name"": """",
		""desc"": ""Ca t'amuses de subir l'enfer sur terre?""
	},
	{
		""id"": ""SupremeBossText12"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Don't get me wrong, I like pain too, but you're just ridiculous."",
		""name"": """",
		""desc"": ""Ne te méprends pas, moi aussi j'aime souffrir, mais tu es juste aberrant.""
	},
	{
		""id"": ""SupremeBossText13"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""You must enjoy dying more than most people, huh?"",
		""name"": """",
		""desc"": ""Tu dois aimer mourir plus que la moyenne, hein?""
	},
	{
		""id"": ""SupremeBossText14"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Do you have a fetish for getting killed or something?"",
		""name"": """",
		""desc"": ""Ca t'excites de te faire tuer ou quoi?""
	},
	{
		""id"": ""SupremeBossText15"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Alright, I'm done counting. You probably died this much just to see what I'd say."",
		""name"": """",
		""desc"": ""Très bien, j'arrête de compter. tu es probablement mort autant de fois juste pour voir ce que j'allais dire.""
	},
	{
		""id"": ""SupremeBossText16"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""You didn't die at all huh? Welp, you probably cheated. Do it again, for real this time...but here's your reward I guess."",
		""name"": """",
		""desc"": ""Pas mort une seule fois hein? Bah, tu as du tricher. Refait le, à la loyale cette fois...mais bon, tu mérites ta récompense, je suppose.""
	},
	{
		""id"": ""SupremeBossText17"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""One death? That's it? ...I guess you earned this then."",
		""name"": """",
		""desc"": ""Une mort? C'est tout? ...Je suppose que tu mérites ça alors.""
	},
	{
		""id"": ""SupremeBossText18"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Two deaths, nice job. Here's your reward."",
		""name"": """",
		""desc"": ""Deux morts, beau boulot. Voici ta récompense.""
	},
	{
		""id"": ""SupremeBossText19"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Third time's the charm. Here's a special reward."",
		""name"": """",
		""desc"": ""La troisième c'est la bonne. Voici une récompense spéciale.""
	},
	{
		""id"": ""EdgyBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Don't get cocky, kid!"",
		""name"": """",
		""desc"": ""Reste à ta place, gamin!""
	},
	{
		""id"": ""EdgyBossText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""You think...you can butcher...ME!?"",
		""name"": """",
		""desc"": ""Tu penses...que tu peux me charcuter...MOI!?""
	},
	{
		""id"": ""EdgyBossText3"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A fatal mistake!"",
		""name"": """",
		""desc"": ""Une erreur fatale!""
	},
	{
		""id"": ""EdgyBossText4"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Good luck recovering from that!"",
		""name"": """",
		""desc"": ""Bonne chance pour récupérer de ça!""
	},
	{
		""id"": ""EdgyBossText5"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Delicious..."",
		""name"": """",
		""desc"": ""Délicieux...""
	},
	{
		""id"": ""EdgyBossText6"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Did that hurt?"",
		""name"": """",
		""desc"": ""Ca t'a fait mal?""
	},
	{
		""id"": ""EdgyBossText7"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Nothing personal, kid."",
		""name"": """",
		""desc"": ""Rien de personnel, gamin.""
	},
	{
		""id"": ""EdgyBossText8"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Are you honestly that bad at dodging?"",
		""name"": """",
		""desc"": ""T'es vraiment aussi mauvais à l'esquive?""
	},
	{
		""id"": ""EdgyBossText9"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Of all my segments to get hit by..."",
		""name"": """",
		""desc"": ""De toutes mes parties, tu te fais toucher par celle-la...""
	},
	{
		""id"": ""EdgyBossText10"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""It's not over yet, kid!"",
		""name"": """",
		""desc"": ""C'est pas terminé, gamin!""
	},
	{
		""id"": ""EdgyBossText11"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A GOD DOES NOT FEAR DEATH!"",
		""name"": """",
		""desc"": ""UN DIEU NE CRAINT PAS LA MORT!""
	},
	{
		""id"": ""EdgyBossText12"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""You are no god...but I shall feast upon your essence regardless!"",
		""name"": """",
		""desc"": ""Tu n'es pas un dieu...mais peu importe, je devorerais ton essence!""
	},
	{
		""id"": ""DoGBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The frigid moon shimmers brightly."",
		""name"": """",
		""desc"": ""La lune frigide scintille brillament.""
	},
	{
		""id"": ""DoGBossText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The harvest moon glows eerily."",
		""name"": """",
		""desc"": ""La lune des moissons brille de manière inquiétante.""
	},
	{
		""id"": ""AstralText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A star has fallen from the heavens!"",
		""name"": """",
		""desc"": ""Une étoile est tombée des cieux!""
	},
	{
		""id"": ""AureusBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The astral enemies have been empowered!"",
		""name"": """",
		""desc"": ""Les ennemis astraux ont été renforcés!""
	},
	{
		""id"": ""AureusBossText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A faint ethereal click can be heard from the dungeon."",
		""name"": """",
		""desc"": ""Un discret cliquetis éthéré peut-être entendu depuis le donjon.""
	},
	{
		""id"": ""AstralBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The seal of the stars has been broken! You can now mine Astral Ore."",
		""name"": """",
		""desc"": ""Le sceau stellaire a été brisée! Vous pouvez miner le Minerai Astral.""
	},
	{
		""id"": ""DeusText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A star-spawned horror tunnels through the astral infection."",
		""name"": """",
		""desc"": ""Une horreur née des étoiles creusent au travers de l'infection astrale.""
	},
	{
		""id"": ""DeusAltarRejectNightText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The god of the stars rejects your offering. The ritual can only be performed at night."",
		""name"": """",
		""desc"": ""Le dieu stellaire rejette ton offrande. Le rituel ne peut être accompli que la nuit.""
	},
	{
		""id"": ""CalamitasBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""You underestimate my power..."",
		""name"": """",
		""desc"": ""Tu sous-estimes mes pouvoirs...""
	},
	{
		""id"": ""CalamitasBossText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The brothers have been reborn!"",
		""name"": """",
		""desc"": ""Les frères ont été ramenés à la vie!""
	},
	{
		""id"": ""CalamitasBossText3"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Impressive child, most impressive..."",
		""name"": """",
		""desc"": ""Impressionnant mon enfant, très impressionnant...""
	},
	{
		""id"": ""SandSharkText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Something stirs in the warm desert sands..."",
		""name"": """",
		""desc"": ""Quelque chose s'agite dans les sables chauds du désert...""
	},
	{
		""id"": ""SandSharkText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""An enormous apex predator approaches..."",
		""name"": """",
		""desc"": ""Un enorme prédateur apex s'approche...""
	},
	{
		""id"": ""SandSharkText3"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The desert sand shifts intensely!"",
		""name"": """",
		""desc"": ""Le sable du désert fluctue intensément!""
	},
	{
		""id"": ""CryogenBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Cryogen is derping out!"",
		""name"": """",
		""desc"": ""Cryogène part en vrille!""
	},
	{
		""id"": ""BloodMoonText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The Blood Moon is rising..."",
		""name"": """",
		""desc"": ""La lune sanglante se lève...""
	},
	{
		""id"": ""DargonBossText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The dark sun awaits."",
		""name"": """",
		""desc"": ""Le sombresoleil attend.""
	},
	{
		""id"": ""DargonBossText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""My dragon deems you an unworthy opponent. You must acquire the power of the dark sun to witness his true power."",
		""name"": """",
		""desc"": ""Mon dragon semble juger que tu n'es pas un adversaire digne. Tu dois acquérir le pouvoir du sombresoleil pour libérer son véritable pouvoir.""
	},
	{
		""id"": ""RevengeText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Revengeance is active."",
		""name"": """",
		""desc"": ""La Revengeance est activée.""
	},
	{
		""id"": ""RevengeText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Revengeance is not active."",
		""name"": """",
		""desc"": ""La Revengeance est désactivée.""
	},
	{
		""id"": ""DeathText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Death is active, enjoy the fun."",
		""name"": """",
		""desc"": ""La Mort est activée, profites bien du fun.""
	},
	{
		""id"": ""DeathText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Death is not active, not fun enough for you?"",
		""name"": """",
		""desc"": ""La Mort est désactivée, pas assez fun pour toi?""
	},
	{
		""id"": ""ArmageddonText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Bosses will now kill you instantly."",
		""name"": """",
		""desc"": ""Les boss vous tuerons en un coup.""
	},
	{
		""id"": ""ArmageddonText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Bosses will no longer kill you instantly."",
		""name"": """",
		""desc"": ""Les boss ne vous tuerons plus en un coup.""
	},
	{
		""id"": ""DefiledText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Your soul is mine..."",
		""name"": """",
		""desc"": ""Ton âme est à moi...""
	},
	{
		""id"": ""DefiledText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Your soul is yours once more..."",
		""name"": """",
		""desc"": ""Votre âme vous appartient à nouveau...""
	},
	{
		""id"": ""IronHeartText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Iron Heart is active, healing is disabled."",
		""name"": """",
		""desc"": ""Le coeur de fer est activé, les soins sont désactivés.""
	},
	{
		""id"": ""IronHeartText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Iron Heart is not active, healing is restored."",
		""name"": """",
		""desc"": ""Le coeur de fer est désactivé, les soins sont de nouveau possible.""
	},
	{
		""id"": ""ChangingTheRules"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""You cannot change the rules now."",
		""name"": """",
		""desc"": ""Tu ne peux pas changer les règles maintenant.""
	},
	{
		""id"": ""FlameText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The air is getting warmer around you."",
		""name"": """",
		""desc"": ""L'air se réchauffe autour de toi.""
	},
	{
		""id"": ""BossRushStartText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Hmm? Ah, another contender. Very well, may the ritual commence!"",
		""name"": """",
		""desc"": ""Hmm? Ah, un autre prétendant. Très bien, que le rituel commence!""
	},
	{
		""id"": ""BossRushTierOneEndText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Hmm? Oh, you're still alive. Unexpected, but don't get complacent just yet."",
		""name"": """",
		""desc"": ""Hmm? Oh, encore vivant. C'est innattendu, mais ne tombe pas déjà dans la complaisance.""
	},
	{
		""id"": ""BossRushTierTwoEndText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Hmm? Persistent aren't you? Perhaps you have some hope of prosperity, unlike past challengers."",
		""name"": """",
		""desc"": ""Hmm? Persistant, on dirait. Peut-être que contrairement a tes prédécesseurs, il y a un peu d'espoir que tu prospères.""
	},
	{
		""id"": ""BossRushTierThreeEndText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Hmm? Your perseverance is truly a trait to behold. You've come further than even the demigods in such a short time."",
		""name"": """",
		""desc"": ""Hmm? Ta persévérence est vraiment d'un caractère saisissant. Tu es allé plus loin que les demi dieux eux-mêmes en si peu de temps.""
	},
	{
		""id"": ""BossRushTierThreeEndText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""May your skills remain sharp for the last challenges."",
		""name"": """",
		""desc"": ""Que tes talents restent à leur pinacle pour les dernières épreuves.""
	},
	{
		""id"": ""BossRushTierFourEndText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Hmm? So you've made it to the final tier, a remarkable feat enviable by even the mightiest of the gods."",
		""name"": """",
		""desc"": ""Hmm? Alors tu as atteint le dernier niveau, Un fait remarquable, enviable par les plus puissants des dieux.""
	},
	{
		""id"": ""BossRushTierFourEndText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Go forth and conquer 'til the ritual's end!"",
		""name"": """",
		""desc"": ""Va et conquiert jusqu'a la fin du rituel!""
	},
	{
		""id"": ""BossRushTierFiveEndText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Hmm? You expected a reward beyond this mere pebble? Patience, the true reward will become apparent in time..."",
		""name"": """",
		""desc"": ""Hmm? Tu t'attendais à une récompense au-delà de ce simple caillou? Patience, la véritable récompense t'apparaîtra en temps voulu...""
	},
	{
		""id"": ""BossSpawnText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Something is approaching..."",
		""name"": """",
		""desc"": ""Quelque chose approche...""
	},
	{
		""id"": ""MeleeLevelUp"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Melee weapon proficiency level up!"",
		""name"": """",
		""desc"": ""Compétence de mêlée augmentée!""
	},
	{
		""id"": ""MeleeLevelUpFinal"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Melee weapon proficiency maxed out!"",
		""name"": """",
		""desc"": ""Compétence de mêlée maximisée!""
	},
	{
		""id"": ""RangedLevelUp"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Ranged weapon proficiency level up!"",
		""name"": """",
		""desc"": ""Compétence de distance augmentée!""
	},
	{
		""id"": ""RangedLevelUpFinal"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Ranged weapon proficiency maxed out!"",
		""name"": """",
		""desc"": ""Compétence de distance maximisée!""
	},
	{
		""id"": ""MagicLevelUp"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Magic weapon proficiency level up!"",
		""name"": """",
		""desc"": ""Compétence magique augmentée!""
	},
	{
		""id"": ""MagicLevelUpFinal"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Magic weapon proficiency maxed out!"",
		""name"": """",
		""desc"": ""Compétence magique maximisée!""
	},
	{
		""id"": ""SummonLevelUp"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Summoner weapon proficiency level up!"",
		""name"": """",
		""desc"": ""Compétence d'invocation augmentée!""
	},
	{
		""id"": ""SummonLevelUpFinal"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Summoner weapon proficiency maxed out!"",
		""name"": """",
		""desc"": ""Compétence d'invocation maximisée!""
	},
	{
		""id"": ""RogueLevelUp"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Rogue weapon proficiency level up!"",
		""name"": """",
		""desc"": ""Compétence de voleur augmentée!""
	},
	{
		""id"": ""RogueLevelUpFinal"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""Rogue weapon proficiency maxed out!"",
		""name"": """",
		""desc"": ""Compétence de voleur maximisée!""
	},
	{
		""id"": ""OpenSunkenSea"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The depths of the underground desert are rumbling..."",
		""name"": """",
		""desc"": ""Les profondeurs du désert souterrain grondent...""
	},
	{
		""id"": ""SandstormTrigger"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The desert wind is blowing furiously!"",
		""name"": """",
		""desc"": ""Le vent du désert souffle furieusement!""
	},
	{
		""id"": ""ThirdSageBlessingText"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""You have been blessed by the Third Sage!"",
		""name"": """",
		""desc"": ""Vous avez été béni par le Troisième Sage!""
	},
	{
		""id"": ""ThirdSageBlessingText2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The Third Sage has rescinded its blessing..."",
		""name"": """",
		""desc"": ""Le Troisième Sage a révoqué sa bénédiction...""
	},
	{
		""id"": ""AprilFools"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The LORDE is approaching..."",
		""name"": """",
		""desc"": ""Le LORDE approche...""
	},
	{
		""id"": ""AprilFools2"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A boomer awaits..."",
		""name"": """",
		""desc"": ""Un Boomer attend...""
	},
	{
		""id"": ""AcidRainStart"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""A toxic downpour falls over the wasteland seas!"",
		""name"": """",
		""desc"": ""Un déluge toxique s'abat sur les mers dévastées!""
	},
	{
		""id"": ""AcidRainEnd"",
		""type"": ""TRANSLATION"",
		""englishDesc"": ""The sulphuric skies begin to clear..."",
		""name"": """",
		""desc"": ""Les cieux sulfuriques commencent à s'éclaircir...""
	}
	]";
        }
    }
}
