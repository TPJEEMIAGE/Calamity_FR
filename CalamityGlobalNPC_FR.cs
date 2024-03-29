﻿using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.World;
using CalamityMod.CalPlayer;
using CalamityMod;
using System.Collections.Generic;
using Terraria.GameContent.Bestiary;

public class CalamityGlobalNPC_FR : GlobalNPC
{
	public CalamityGlobalNPC_FR()
	{

	}

    public override void SetBestiary(NPC npc, BestiaryDatabase database, BestiaryEntry bestiaryEntry)
    {
		if (Calamity_FR.Calamity_FR.NPCBestiarys.ContainsKey(npc.type))
		{
			IBestiaryInfoElement desc = null;
			foreach (IBestiaryInfoElement entry in bestiaryEntry.Info)
			{
				if (entry.GetType() == typeof(FlavorTextBestiaryInfoElement))
				{
					desc = entry;
				}
			}
			if (desc != null)
			{
				bestiaryEntry.Info.Remove(desc);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(Calamity_FR.Calamity_FR.NPCBestiarys.GetValueOrDefault(npc.type)));
			}
		}
    }

    public override void OnChatButtonClicked(NPC npc, bool firstButton)
	{
		if (npc.type == ModContent.NPCType<FAP>() && !firstButton)
		{
			Main.npcChatText = "Tu es mort " + Main.player[Main.myPlayer].Calamity().deathCount + " fois.";
		}
		if (npc.type == ModContent.NPCType<THIEF>() && !firstButton)
		{
			int goblinIndex = NPC.FindFirstNPC(107);
			if (goblinIndex != -1)
			{
				NPC goblin = Main.npc[goblinIndex];
				Main.npcChatText = Main.npcChatText.Replace("Want in on a little secret? Since " + goblin.GivenName + " always gets so much cash from you, I've been stealing some of it as we go. I need you to keep quiet about it, so here.", "Tu veux savoir un petit secret? Vu que tu payes autant d'argent à " + goblin.GivenName + ", j'en ai volé un peu en passant. J'ai besoin que tu gardes le silence, alors prends ça.");
				Main.npcChatText = Main.npcChatText.Replace("Hey, if government officials can get tax, why can't I? The heck do you mean that these two things are nothing alike?", "Hey, si le gouvernement peut nous prélever des impôts, pourquoi je pourrais pas? Comment ça ce que je fais n'a rien à voir?");
			}
			Main.npcChatText = Main.npcChatText.Replace("Sorry, I got nothing. Perhaps you could reforge something and come back later...", "Désolée, j'ai rien. Peut être que si tu reforges quelque chose et que tu reviens plus tard...");
		}
		if (npc.type == ModContent.NPCType<SEAHOE>() && !firstButton)
		{
			string[][] seahoeQuotes = new string[][]
			{
				new string[2]{ "Draedon's style of confrontation is very...alien and hands-off. You may be more likely to fight any one of his mechs before taking him down.",
					"Le style de combat de Draedon et très...étrange et délégatif. Tu vas très probablement devoir combattre l'un de ses mechas avant de pouvoir l'abattre."},
				new string[2]{ "Lord Yharim possesses god-like strength. He may not even fight you at full power which is fortunate for you. His attacks may just kill you in one hit, so be careful.", 
					"Le seigneur Yharim possède une force égale comparable à celle des dieux. Il pourrait même te combattre sans employer sa pleine puissance, ce qui est une aubaine pour toi. Ses attaques pourraient bien te tuer en un coup, alors sois prudent."},
				new string[2]{ "Pockets of ore have appeared once more in the land. This will allow you to create the most powerful weaponry and armor imagined!", 
					"Des veines de minerai sont apparues à nouveau sous la terre. Cela te permettra de créer les plus puissants armements et armures imaginables!"},
				new string[2]{ "Ah, the dragon Yharon is fickle. You may find that he will refuse to use his full power unless you are strong enough to unleash the power of the Dark Sun.", 
					"Ah, le dragon Yharon est capricieux. Il pourrait bien refuser d'employer sa pleine puissance avant que tu ne sois suffisament fort pour libérer le pouvoir du Sombresoleil."},
				new string[2]{ "The Devourer of Gods is extremely powerful. However, he is young, foolhardy, and very lazy. Perhaps if he had been given time to develop he would have turned into quite the threat.", 
					"Le dévoreur de dieux est extrêmement puissant. Cependant, il est jeune, téméraire, et très feignant. Peut-être qui s'il avait eu le temps de se développer il serait devenu une sacrée menace."},
				new string[2]{ "With the cosmic steel you can fashion many of your weapons into much more powerful forms.", 
					"Grace à l'acier cosmique, tu peux faire évoluer beaucoup de tes armes dans des formes bien plus puissantes."},
				new string[2]{ "The Devourer of God's cosmic armor is unique in that it is capable of not only protecting his body from tearing itself apart when ripping through the fabric of space and time, but also allows him to control his powers.", 
					"L'armure cosmique du dévoreur de dieux est unique car elle est non seulement capable de protéger son corps quand il déchire l'espace-temps, mais également capable de lui permettre de contrôler ses pouvoirs."},
				new string[2]{ "Ah...I can sense a powerful change in the weather. You may want to venture to the Sulphurous Seas once more during the rain to experience it.", 
					"Ah...je sens un puissant changement dans le temps. Tu pourrais peut-être t'aventurer à nouveau dans les mers sulfurées durant la pluie pour en faire l'expérience."},
				new string[2]{ "The Abyss holds many secrets revealed with time. Checking it out again may not be a bad idea.", 
					"Les abysses contiennent de nombreux secrets révélés par le temps. L'explorer à nouveau n'est peut-être pas une mauvaise idée."},
				new string[2]{ "The Dungeon seems to be more active now. You may hear the faint whisperings of angry spirits who have not left to the Void...I would recommend searching there before taking on the Sentinels.", 
					"La donjon à l'air d'être plus actif maintenant. Tu peux entendre les faibles chuchotements des esprits en colère qui ne sont pas allé dans l'au-delà...Je recommenderai de fouiller de ce côté avant d'affronter les sentinelles."},
				new string[2]{ "Ironic, is it not, that Statis was defeated by the very Sentinel his people fashioned their art of stealth from. Fate so often weaves cruel tales.", 
					"C'est ironique, n'est-ce pas? Que Statis ait été vaincu par la même sentinelle que son peuple a imité pour créer leur art de la discrétion. Le destin écrit souvent des contes cruels."},
				new string[2]{ "The Rune of Kos holds a significant portion of Providence's brand of magic, easily distinguishable from all others. Activating it in certain places would have some...risky consequences.", 
					"La rune de Kos contient une partie significative de la magie de Providence, aisément différenciable de toutes les autres magies. L'utiliser à certains endroits pourrait avoir des conséquences...risquées"},
				new string[2]{ "The stories have it that when Providence faced and defeated Yharim and his forces she lost a lot of energy and reverted to a more skeletal form. She's merely a fraction of the power she was before.", 
					"Les histoires content que Providence a perdu une grande quantité d'énergie quand elle a affronté et vaincu Yharim et ses forces, ce qui l'a fait regresser en une forme plus primaire. Elle n'est qu'une fraction du pouvoir de ce qu'elle était autrefois."},
				new string[2]{ "Providence is as much the sun goddess as much as the Moon Lord is the moon god. They are two sides of the same coin, choosing to remain neutral amongst our petty squabbles.", 
					"Providence est la déesse du soleil tout comme le seigneur de la lune est le dieu de la lune. Ils sont les deux côtés d'une même pièce, choisissant de rester neutres au milieu de nos insignifiantes querelles."},
				new string[2]{ "Touching Providence's offerings is usually a death wish. Shame that Yharim didn't think to just mess with her things to get her out of hiding.", 
					"Toucher les offrandes de Providence équivaut habituellement à mourir. C'est bien dommage que Yharim n'ai pas pensé à simplement s'en prendre à ses affaires pour la faire sortir de sa cachette."},
				new string[2]{ "The Profaned Guardians will do anything to protect their goddess. Makes sense they would die for her since they can be revived just as quickly.", 
					"Les gardiens profanés feront tout pour protéger leur déesse. C'est assez logique qu'ils aillent jusqu'a mourir pour elle puisqu'ils peuvent revenir à la vie aussitôt"},
				new string[2]{ "Profaned creatures now lurk in the Hallow and in Hell. If you destroy enough and gather their essence together you shall be able to capture the attention of the Profaned Guardians.", 
					"Des créatures profanées rôdent maintenant dans le sacré et en enfer. Si tu en détruit suffisament et que tu récoltes leurs essences, tu devrais pouvoir attirer l'attention des gardiens profanés."},
				new string[2]{ "Your adventure focuses to the jungle it seems. The Dragonfolly and its swarming offspring should be eliminated before their numbers spiral out of control.", 
					"Tes aventures se focalisent sur la jungle, on dirait. La folie draconique et ses rejetons devraient être éliminés avec que leur nombre échappe à tout contrôle."},
				new string[2]{ "The plague was just one of the many experiments authorized by Yharim to raze towns to the ground. This is probably one of the few he shelved for being too terrible.", 
					"La peste n'est qu'une des nombreuses expériences autorisées par Yharin pour raser des villes. C'est probablement l'une des rares qu'il a jugé trop terrible pour être employée."},
				new string[2]{ "The Abyss has become far more active than before. You might be able to mine some of the volcanic rubble contained within.", 
					"Les abysses sont devenues beaucoup plus actives qu'avant. Tu devrais pouvoir miner quelques-uns des débris volcaniques qu'elles contiennent."},
				new string[2]{ "The men at the front of the dungeon are performing a ritual to keep the Moon Lord contained in his prison. In order to gain Yharim's attention, however, you may need to defeat them.", 
					"Les personnes devant le donjon accomplissent un rituel pour empêcher le seigneur de la lune de se libérer de sa prison. Mais pour attirer l'attention de Yharim, tu vas devoir les vaincre."},
				new string[2]{ "When exploring the jungle temple be careful. You may not wish to disturb the Lihzard's idol, the Golem. It's quite the destructive force.", 
					"Sois prudent en explorant le temple de la jungle. Tu ne devrais peut-être pas déranger l'idole des Lihzard, le golem. C'est une force de destruction considérable."},
				new string[2]{ "Be careful when defeating Plantera and the Golem. You might accidentally unleash a new threat in the jungle that needs to be quelled.", 
					"Sois prudent après avoir vaincu Platera et le golem. Tu libèreras peut-être une nouvelle menace dans la jungle qui devra être jugulée."},
				new string[2]{ "If you've gathered the souls used to power those automatons head once more to the jungle. You will find a powerful enemy to fight, which will unleash the full fervor of the jungle once defeated. Do not underestimate it!", 
					"Si tu as récolté les âmes utilisées pour alimenter ces automates, rends toi de nouveau à la jungle. Tu y trouveras un pussant ennemi à combattre, qui libèrera la pleine ferveur de la jungle une fois vaincu. Ne le sous-estime pas!"},
				new string[2]{ "The Brimstone Crags...Yharim despised that place, and did everything he could to raze it to the ground. It might explain a few things about him.", 
					"Les vestiges de soufre...Yharim détestait cet endroit, et a fait tout ce qu'il a pu pour le raser. Ca en dit peut-être long à son sujet."},
				new string[2]{ "If you take an idol down to the Brimstone Crags you might be able to see just what is lurking in the shadows.", 
					"Si tu amènes une idole jusqu'au vestiges de soufre, tu pourras peut-être voir ce qui se tapi dans les ombres."},
				new string[2]{ "Once those mechanical creations have been defeated you would do well to seek out the crippled clone of the witch, Calamitas. It might provide some useful weaponry.", 
					"Une fois ces créations mécaniques vaincus, tu devrais te mettre à la recherche du clone mutilé de la sorcière, Calamitas. Il pourrait fournir de l'armement utile."},
				new string[2]{ "I would recommend saving some of your old items. You never know if you can engineer them into stronger weapons in the future.", 
					"Je te recommande de conserver certains de tes vieux objets. Ils pourraient bien être améliorés et devenir plus puissants dans le futur."},
				new string[2]{ "Have you heard of the story of Archmage Permafrost? Rumor has it he's been locked away in an icy prison by Lord Yharim. Perhaps you would be able to free him if Cryogen was destroyed.", 
					"As-tu entendu l'histoire de l'archimage Permafrost? La rumeur dit qu'il a été enfermé dans une prison glaciale par le seigneru Yharim. Peut-être que tu pourrais le libérer si tu arrivais à détruire Cryogène."},
				new string[2]{ "You will find more ores have been unlocked due to the magic sealing them away being dispelled. Some of them may require more than just the ore itself to create.", 
					"Tu verras que de nouveaux minerais ont été libérés au vu du sort de sceau ayant été rompu. Certains d'entre eux nécessiterons peut-être plus que le minerai lui-même pour être transformé"},
				new string[2]{ "Throughout the world lie various structures left behind by Draedon. Archaic defenses may remain, but the goods inside may be worth your while.", 
					"De nombreuses structures laissées à l'abandon par Draedon jonchent ce monde. Des défenses archaïques peuvent subsister, mais le butin à l'intérieur peut valoir qu'on s'y attarde."},
				new string[2]{ "The Crimson used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.", 
					"Le carmin était facilement gérable et controlé par la nature. Cependant, les récentes guerres et la pollution ont penché la balance en sa faveur."},
				new string[2]{ "The Corruption used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.",
					"La corruption était facilement gérable et controlée par la nature. Cependant, les récentes guerres et la pollution ont penché la balance en sa faveur."},
				new string[2]{ "The dungeon is a dark place. None of us know of its true purpose, however, the ancient Eidolist cultists used it for worship before Lord Yharim took it over.", 
					"Le donjon est un sombre lieu. Aucun d'entre nous ne connait sa vraie nature, en revance, les anciens cultistes Eidolistes l'utilisaient comme lieu de culte avant que Yharim ne s'en empare."},
				new string[2]{ "I'm assuming you've heard the legends that speak of the ninja, Statis? There are some who say that if you were able to defeat the gods which his clan once worshipped you would be able to harness some of his powers.", 
					"Je suppose que tu n'as jamais entendu les légendes de Statis, le ninja? Certains racontent que si tu es capable de vaincre les dieux que son clan vénéraient autrefois, tu seras capable de maîtriser une partie de ses pouvoirs."},
				new string[2]{ "Scattered across the lands are shrines dedicated to the gods. You can take whatever is in them, but a few items you may not be able to use until much later.", 
					"Dispersés au travers des terres se trouvent des temples dédiés aux dieux. Tu peux prendre ce qu'ils contiennent, mais tu ne pourras utiliser certains objets que bien plus tard."},
				new string[2]{ "Be careful what you attack in the Crimson. You might just unveil a greater threat than what was there before.", 
					"Fait attention à ce que tu attaques dans le carmin. Tu pourrais révéler une menace plus grande que ce que tu auras affronté."},
				new string[2]{ "Be careful what you attack in the Corruption. You might just unveil a greater threat than what was there before.",
					"Fait attention à ce que tu attaques dans la corruption. Tu pourrais révéler une menace plus grande que ce que tu auras affronté."},
				new string[2]{ "The Sulphurous Seas were created long ago, when Yharim's dungeon could no longer hold as many corpses as it needed to. Many of the bodies were dumped into the ocean. This, along with severe pollution from the heydays of Draedon's experiments have turned a paradise into a wasteland.", 
					"Les mers sulfureuses ont été crées il y a longtems, quand le donjon ne Yharim ne pouvait plus contenir autant de corps qu'il lui était nécessaire. Beaucoup des corps furent jetés dans l'océan. Ca, avec la pollution sévère engendrée par l'apogée des expériences de Draedon ont tranformé un paradis en un désert"},
				new string[2]{ "The Sulphurous Seas are dangerous. The toxic waters will burn your skin, but if you can brave them you will be able to reach the Abyss, where there are powerful weapons and dangers aplenty.", 
					"Les mers sulfureuses sont dangeureuses. Les eaux toxiques brûleront ta peau, mais si tu peux les endurer tu pourras atteindre les abysses, ou de puissantes armes et une myriade de dangers t'attendent."},
				new string[2]{ "Ah yes, the Abyss. That trench is full of powerful creatures that could devour you in a heartbeat. I would explore the dungeon first.", 
					"Ah oui, les abysses. Cette fosse est pleine de créatures qui peuvent te dévorer en un claquement de doigts. J'explorerais le donjon avant de m'y rendre."},
				new string[2]{ "Have you heard of the Brimstone Crags? It was once a grand kingdom, not too different from my own. However, it also met a similar fate. I would not advise going down there, unless you seek a painful death.", 
					"As-tu entendu parler des vestiges de soufre? C'était autrefois un grand royaume, pas si différent du mien. Cependant, ils ont rencontré un destin similaire. Je te déconseille de te rendre là-bas, à moins que tu ne recherches une mort douleureuse."},
				new string[2]{ "There are rumors of ores that lay in latency. When you defeat certain bosses you will undo the ancient magic which conceals those materials.", 
					"Des rumeurs disent que des minerais existent à l'état latent. Quand tu vaincras certains boss, tu annuleras l'ancienne magie qui scelle ces matériaux."}
			};
			foreach(string[] chat in seahoeQuotes)
            {
				if (!chat[1].Equals(""))
				{
					Main.npcChatText = Main.npcChatText.Replace(chat[0], chat[1]);
				}
			}
		}
	}

	public override void GetChat(NPC npc, ref string chat)
	{
		int fapsol = NPC.FindFirstNPC(ModContent.NPCType<FAP>());
		int permadong = NPC.FindFirstNPC(ModContent.NPCType<DILF>());
		int seahorse = NPC.FindFirstNPC(ModContent.NPCType<SEAHOE>());
		int thief = NPC.FindFirstNPC(ModContent.NPCType<THIEF>());
		int dryad = NPC.FindFirstNPC(20);
		int angelstatue = NPC.FindFirstNPC(17);
		int armsDealerIndex = NPC.FindFirstNPC(19);
		int nurseIndex = NPC.FindFirstNPC(18);
		int tavernKeep = NPC.FindFirstNPC(550);
		int waifu = NPC.FindFirstNPC(353);
		int partyGirl = NPC.FindFirstNPC(208);
		int lilBitch = NPC.FindFirstNPC(369);
		int witch = NPC.FindFirstNPC(ModContent.NPCType<WITCH>());

		/*
			Setting NPC names to avoid AOOB when evaluated at -1
			Maybe write a dedicated function someday because this is dirty
			Indexes -
			nurse : 0
			armsDealer : 1
			fapsol : 2
			merchant : 3
			lilBitch (probably angler): 4
			partyGirl : 5
			waifu (probably stylist) : 6
			permafrost : 7
			tavernkeep : 8
			dryad : 9
			amidias : 10
			thief : 11
			witch : 12
		*/
		string[] givenNames = new string[13];
		for (int j = 0; j < givenNames.Length; j++) {
			givenNames[j] = "";
		}
		if (nurseIndex != -1) {
			givenNames[0] = Main.npc[nurseIndex].GivenName;
		}
		if (armsDealerIndex != -1)
		{
			givenNames[1] = Main.npc[armsDealerIndex].GivenName;
		}
		if (fapsol != -1)
		{
			givenNames[2] = Main.npc[fapsol].GivenName;
		}
		if (angelstatue != -1)
		{
			givenNames[3] = Main.npc[angelstatue].GivenName;
		}
		if (lilBitch != -1)
		{
			givenNames[4] = Main.npc[lilBitch].GivenName;
		}
		if (partyGirl != -1)
		{
			givenNames[5] = Main.npc[partyGirl].GivenName;
		}
		if (waifu != -1)
		{
			givenNames[6] = Main.npc[waifu].GivenName;
		}
		if (permadong != -1)
		{
			givenNames[7] = Main.npc[permadong].GivenName;
		}
		if (tavernKeep != -1)
		{
			givenNames[8] = Main.npc[tavernKeep].GivenName;
		}
		if (dryad != -1)
		{
			givenNames[9] = Main.npc[dryad].GivenName;
		}
		if (seahorse != -1)
		{
			givenNames[10] = Main.npc[seahorse].GivenName;
		}
		if (thief != -1)
		{
			givenNames[11] = Main.npc[thief].GivenName;
		}
		if (witch != -1)
		{
			givenNames[12] = Main.npc[witch].GivenName;
		}

		string fabSpecialQuote = "You're all pretty good! ...wait, who are you again?";
		string[][] translatedChat = new string[][] {
			new string[2]{
				"Could you be so kind as to, ah...check hell for me...? I left someone I kind of care about down there.",
				"Est-ce que tu pourrais je te prie...aller voir en enfer...? J'ai laissé quelqu'un à qui je tiens en quelque sorte là-bas."
			},
			new string[2]{
				"I have this sudden shiver up my spine, like a meteor just fell and thousands of innocent creatures turned into monsters from the stars.",
				"J'ai cette sensation tout à coup, comme si une météore venait de tomber et que des milliers d'innocentes créatures se sont transformées en monstres stellaires."
			},
			new string[2]{
				"The dungeon seems even more restless than usual, watch out for the powerful abominations stirring up in there.",
				"Le donjon a l'air d'être encore plus agité que d'habitude, fait attention aux puissantes abominations qui rôdent là-dessous."
			},
			new string[2]{
				"Seems like extinguishing that butterfly caused its life to seep into the hallowed areas, try taking a peek there and see what you can find!",
				"On dirait qu'éteindre ce papillon a répandu sa force vitale dans le sacré, Jettes-y un oeil et vois ce que tu peux trouver!"
			},
			new string[2]{
				"I've heard there is a portal of antimatter absorbing everything it can see in the dungeon, try using the Rune of Kos there!",
				"J'ai entendu dire qu'un portail d'antimatière absorbe tout ce qu'il croise dans le donjon, essaie d'utiliser la Rune de Kos là-bas!"
			},
			new string[2]{
				"I don't feel very safe; I think there's pigs following me around and it frightens me.",
				"Je ne me sens pas en sécurité; Je pense qu'il y a des cochons qui me suivent et ça m'effraie."
			},
			new string[2]{
				"Sometimes, " + givenNames[2] + " just looks at me funny and I'm not sure how I feel about that.",
				"Des fois, " + givenNames[2] + " me regarde bizarrement et je sais pas comment je dois le prendre."
			},
			new string[2]{
				"Someone tell " + givenNames[10] + " to quit trying to throw me out of town, it's not going to work.",
				"Que quelqu'un dise à " + givenNames[10] + " d'arrêter d'essayer de me faire partir de la ville, ça ne marchera pas."
			},
			new string[2]{
				"Tell " + givenNames[2] + " I'll take up her offer and meet with her at the back of " + givenNames[3] + "'s house.",
				"Dis à " + givenNames[2] + " que j'accepte son offre et que je la retrouve derrière la maison de " + givenNames[3]
			},
			new string[2]{
				"What'dya buyin'?",
				"Qu-est ce t'achètes?"
			},
			new string[2]{
				"My home here has an extensive history and a mysterious past. You'll find out quickly just how extensive it is...",
				"Mon foyer a une histoire considérable et un passé mystérieux. Tu vas rapidement comprendre à quel point..."
			},
			new string[2]{
				"I have unique items if you show me that you have bested the guardian of this jungle.",
				"J'ai des articles exclusifs si tu me prouves que tu as vaincu le gardien de cette jungle."
			},
			new string[2]{
				"This is as good a time as any to pick up the best ingredients for potions.",
				"C'est un moment comme un autre pour récupérer les meileurs ingrédients pour potions."
			},
			new string[2]{
				"I have a feeling we're going to have absolutely fantastic parties with " + givenNames[2] + " around!",
				"J'ai comme l'impression qu'on va avoir des fêtes absolument fantastiques avec " + givenNames[2] + " dans les environs!"
			},
			new string[2]{
				"I think my light display is turning into an accidental bug zapper. At least the monsters are enjoying it.",
				"Je pense que mes lumières sont en train de devenir un piège à insectes. Au moins, ça à l'air de plaire aux monstres."
			},
			new string[2]{
				"Ooh! I love parties where everyone wears a scary costume!",
				"Ooh! J'adore les fêtes ou tout le monde porte un costume effrayant!"
			},
			new string[2]{
				"A little sickness isn't going to stop me from doing my work as an artist!",
				"C'est pas une petite maladie qui m'empêchera de faire mon travail d'artiste!"
			},
			new string[2]{
				"There's a surprising art to this area. A sort of horrifying, eldritch feeling. It inspires me!",
				"Il y a un ressenti artistique surprenant de cet endroit. Une sorte de ressenti horrible, eldritchien. Ca m'inspire!"
			},
			new string[2]{
				"Think " + givenNames[7] + " would let me paint him like one of his French girls?!",
				"Tu penses que " + givenNames[7] + " me laisserai le peindre comme une de ses françaises?!"
			},
			new string[2]{
				"I'm not exactly suited for this cold weather. Still looks pretty, though.",
				"Je suis pas exactement fait pour le climat froid. C'est plutôt joli, par contre."
			},
			new string[2]{
				"I hate sand. It's coarse, and rough and gets in my paint.",
				"Je n'aime pas le sable. Il est grossier, agressif, irritant et s'insinue partout sur mes peintures"
			},
			new string[2]{
				"Do you think unicorn blood could be used as a good pigment or resin? No I'm not going to find out myself.",
				"Tu penses que le sang de licorne peut servir de pigment ou de résine? Non, je ne vais pas chercher à savoir par moi-même."
			},
			new string[2]{
				"I can't work in this environment. All of my paint just floats off.",
				"Je peux pas travailler ici. Ma peinture n'arrête pas de s'envoler."
			},
			new string[2]{
				"Painting the tortoises in a still life isn't going so well.",
				"Mon projet de peindre des tortues en nature morte ne se passe pas très bien."
			},
			new string[2]{
				"I can't paint a still life if the fruit grows legs and walks away.",
				"Je ne peux pas peindre une nature morte si le fruit a des jambes et s'en va."
			},
			new string[2]{
				"On the canvas, things get heated around here all the time. Like the environment!",
				"On se chauffe sans arrêt sur les canvas par ici. Comme la température!"
			},
			new string[2]{
				"Sorry, I'm all out of watercolors. They keep evaporating.",
				"Désolé, j'ai plus de peinture à eau. Tout c'est évaporé."
			},
			new string[2]{
				"Roses, really? That's such an overrated thing to paint.",
				"Des roses, sérieusement? C'est tellement surcôté en peinture."
			},
			new string[2]{
				"Fun fact! Sulphur was used as pigment once upon a time! Or was it Cinnabar?",
				"Fait amusant! Le sulfure était autrefois utilisé comme pigment! Ou c'était le cinabre?"
			},
			new string[2]{
				"Easiest landscape I've ever painted in my life.",
				"Le paysage le plus simple à peindre de ma vie."
			},
			new string[2]{
				"I'd let " + givenNames[7] + " coldheart MY icicle.",
				"Je laisserai " + givenNames[7] + " givrer MON glaçon."
			},
			new string[2]{
				"Space just got way too close for comfort.",
				"L'espace vient juste de se rapprocher suffisament pour que je me sente mal."
			},
			new string[2]{
				"There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful...hmm...what power was Yharon holding back?",
				"Une énergie solaire sombre émane des mites cette fois. Ah, les mites deviennent de plus en plus puissante au fur et à mesure...hmm...quel genre de pouvoir Yharon retenait?"
			},
			new string[2]{
				"That starborne illness sits upon this land like a blister. Do even more vile forces of corruption exist in worlds beyond?",
				"Cette maladie stellaire gît sur cette terre comme une pustule. Y a t-il encore plus de forces dénaturantes dans les mondes lointains?"
			},
			new string[2]{
				givenNames[2] + " put me up to this.",
				"C'est" + givenNames[2] + " qui m'a dit de faire ça."
			},
			new string[2]{
				"My ancestor was lost here long ago. I must pay my respects to her.",
				"Mon ancêtre a disparu ici il y a longtemps. Je dois lui présenter mes respects."
			},
			new string[2]{
				"\u0093I'm not here for any reason! Just picking up mushrooms for uh, later use.",
				"\u0093Je suis pas ici pour une raison particulière! Je ramasse juste des champignons pour, euh, un usage ultérieur."
			},
			new string[2]{
				"Please don't catch space lice. Or " + "Crimson" + " lice. Or just lice in general.",
				"S'il te plaît, n'attrape pas de poux de l'espace. Or des poux carmins. Ou des poux tout court en fait."
			},
			new string[2]{
				"Please don't catch space lice. Or " + "Corruption" + " lice. Or just lice in general.",
				"S'il te plaît, n'attrape pas de poux de l'espace. Or des poux corrompus. Ou des poux tout court en fait."
			},
			new string[2]{
				"Sometimes I catch " + givenNames[2] + " sneaking up from behind me.",
				"Des fois, j'attrape " + givenNames[2] + " en train de se faufiler derrière moi."
			},
			new string[2]{
				givenNames[2] + " is always trying to brighten my mood...even if, deep down, I know she's sad.",
				givenNames[2] + " essaie toujours de me remonter le moral...même si au fond, je sens bien qu'elle est triste."
			},
			new string[2]{
				"They look so cute and yet, I can feel their immense power just by being near them. What are you?",
				"Ils sont si mignons et pourtant, je peux sentir leur immense pouvoir juste en me tenant à côté. Qu'est-ce que tu es?"
			},
			new string[2]{
				"I hate to break it to you, but you don't have hair to cut or style, hun.",
				"Je suis désolé te dire ça, mais t'as pas de cheveux à couper, chéri."
			},
			new string[2]{
				"Aww, they're so cute, do they have names?",
				"Oww, ils sont trop mignons, tu leur a donné des noms?"
			},
			new string[2]{
				"Hey, is it just me or have my pockets gotten lighter ever since " + givenNames[11] + " arrived?",
				"Hé, c'est moi ou mes poches sont plus légères depuis que " + givenNames[11] + " est arrivée?"
			},
			new string[2]{
				"You know...we haven't had an invasion in a while...",
				"Tu sais...ça fait un moment qu'on ne s'est pas fait envahir..."
			},
			new string[2]{
				"That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down.",
				"C'est la plus grosse mite que j'ai jamais vu, ça c'est sure. Tu vas avoir besoin d'un bon gros flingue pour abattre un truc pareil."
			},
			new string[2]{
				"Is it me or are your weapons getting bigger and bigger?",
				"C'est moi ou tes armes sont de plus en plus grosses?"
			},
			new string[2]{
				"Each night seems only more foreboding than the last. I feel unthinkable terrors are watching your every move.",
				"Chaque nuit semble plus inquiétante que la précédente. J'ai l'impression que des terreurs impensables observent tes moindres gestes."
			},
			new string[2]{
				"Are you daft?! Turn off those lamps!",
				"T'es bête?! Éteins cette lampe!"
			},
			new string[2]{
				"If this acid rain keeps up, there'll be a shortage of Dirt Blocks soon enough!",
				"Si cette pluie acide continue, il va pas tarder à y avoir une pénurie de blocs de terre!"
			},
			new string[2]{
				"I happen to have several Angel Statues at the moment, a truely rare commodity. Want one?",
				"Il se trouve que j'ai plusieurs Statues d'Ange sur moi, des pièces vraiment rares. T'en veux une?"
			},
			new string[2]{
				"The caverns have become increasingly dark as of late, so I stocked up on some special torches if you have the funds.",
				"Les grottes sont de plus en plus sombres récemment, du coup j'ai fait le stock de torches spéciales si tu as les fonds."
			},
			new string[2]{
				"What do you mean your traps aren't making the cut? Don't look at me!",
				"Qu'est-ce que tu veux dire 'Mes pièges sont dépassés'? C'est pas ma faute!"
			},
			new string[2]{
				"Um...should my nightlight be on?",
				"Hum...est-ce que je dois allumer ma veilleuse?"
			},
			new string[2]{
				"Well, I like " + givenNames[2] + ", but I, ah...I have my eyes on someone else.",
				"Et bien, j'aime bien " + givenNames[2] + ", mais je, euhhh...J'ai des vues sur quelqu'un d'autre."
			},
			new string[2]{
				"Maybe I should've waterproofed my gadgets... They're starting to corrode.",
				"Peut-être que j'aurais du rendre mes gadgets étanches... Ils commencent à rouiller."
			},
			new string[2]{
				"Care for a little Moonshine?",
				"Un peu d'alcool de contrebande?"
			},
			new string[2]{
				"Sheesh, " + givenNames[2] + " is a little cruel, isn't she? I never claimed to be an expert on anything but ale!",
				"Fiouuu, " + givenNames[2] + " est un peu cruelle, non? J'ai jamais prétendu être un expert en quoi ce soit à part la bière!"
			},
			new string[2]{
				"Aye, I've heard of a mythical creature in the oceans, singing with an alluring voice. Careful when yer fishin out there.",
				"Aye, j'ai entendu parler d'une créature mythique dans les océans, qui chante d'une voix séduisante. Fait attention quand tu pêches là-bas."
			},
			new string[2]{
				"I have to thank ye again for takin' care of that sea serpent. Or was that another one...",
				"Merci encore pour t'être occupé de ce serpent de mer. Ou c'en était peut être un autre..."
			},
			new string[2]{
				"I remember legends about that " + givenNames[10] + ". He ain't quite how the stories make him out to be though.",
				"Je me rapelle des légendes sur " + givenNames[10] + ". Il est pas exactement comme les histoires le décrivent par contre."
			},
			new string[2]{
				"Twenty-nine bottles of beer on the wall...",
				"29 bouteilles de bières sur le mur..."
			},
			new string[2]{
				"Now this is a scene that I can admire any time! I feel like something is watching me though.",
				"Ah ça c'est un paysage que je peux admirer jour et nuit! Par contre, j'ai l'impression que quelque chose me regarde."
			},
			new string[2]{
				"It ain't much of a sight, but there's still life living in these waters.",
				"C'est pas vraiment impressionant, mais y a encore de la vie sous ces eaux."
			},
			new string[2]{
				"Me ship might just sink from the acid alone.",
				"Mon bateau risque de couler juste à cause de l'acide."
			},
			new string[2]{
				"All these moments will be lost in time. Like tears...in the rain.",
				"Tous ces instants seront perdus dans le flot du temps. Comme des larmes...dans la pluie."
			},
			new string[2]{
				"Always shoot for the moon! It has clearly worked before.",
				"Vise toujours la lune! Ca a bien marché avant."
			},
			new string[2]{
				"Draedon? He's...a little 'high octane' if you know what I mean.",
				"Draedon? Il est un peu...'surchargé', si tu vois ce que je veux dire."
			},
			new string[2]{
				"Those oversized bugs terrorizing the jungle... Surely you of all people could shut them down!",
				"Ces insectes surdimensionnés terrorisent la jungle... Je suis sur que toi, tu peux t'en occuper!"
			},
			new string[2]{
				"Who you gonna call?",
				"Qui allez-vous appeler?"
			},
			new string[2]{
				"Those screams...I'm not sure why, but I feel like a nameless fear has awoken in my heart.",
				"Ces cris...je ne sais pas pourquoi, mais je me sens comme si une peur innommable était apparu dans mon coeur."
			},
			new string[2]{
				"I can faintly hear ghostly shrieks from the dungeon...and not ones I'm familiar with at all. Just what is going on in there?",
				"Je peux entendre de faibles cris épouvantables depuis le donjon...et c'est pas ceux dont j'ai l'habitude. Qu'est-ce qui se passe la dedans?"
			},
			new string[2]{
				"Whatever that thing was, I'm glad it's gone now.",
				"Peu importe ce que c'était, je suis content que ce soit mort."
			},
			new string[2]{
				"Houston, we've had a problem.",
				"Houston, on a un problème."
			},
			new string[2]{
				"Just what is that contraption? It makes my Teleporters look like child's play!",
				"Mais c'est quoi cet engin? Ca fait passer mes téléporteurs pour des jouets!"
			},
			new string[2]{
				"Yep! I'm also considering being a space pirate now.",
				"Yep! Je réfléchis aussi à devenir une pirate de l'espace maintenant."
			},
			new string[2]{
				"Some of my machines are starting to go haywire thanks to this Astral Infection. I probably shouldn't have built them here",
				"Certaines de mes machines ont commencé à dysfonctionner à cause de cette infection astrale. J'aurais peut-être pas du les construire là-bas"
			},
			new string[2]{
				"I'm sorry I really don't have any Unicorn proof tech here, you're on your own.",
				"Je suis désolée, je n'ai pas vraiment de technologie résistante aux licornes sur moi, tu te débrouilles."
			},
			new string[2]{
				"Have you seen those gemstone creatures in the caverns? Their colors are simply breathtaking!",
				"Tu as vu ces créatures de gemme dans les grottes? Leurs couleurs me coupent le souffle!"
			},
			new string[2]{
				"Do you think " + givenNames[7] + " knows how to 'let it go?'",
				"Est-ce que tu penses que " + givenNames[7] + "sait comment se 'Libérer, Délivrer'?"
			},
			new string[2]{
				"BAH! Doesn't seem like I'll ever be able to quarrel with the debts of the town again!",
				"BAH! On dirait que je ne pourrais plus jamais profiter des dettes de cette ville!"
			},
			new string[2]{
				"Where and how are you getting all of this money?",
				"Où et quand t'as récupéré tout cet argent?"
			},
			new string[2]{
				"Perhaps with all that time you've got you could check those old ruins? Certainly something of value in it for you!",
				"Peut-être qu'avec tout le temps libre que tu as, tu pourrais aller fouiller ces vieilles ruines? Y a certainement un truc qui va t'intéresser là bas!"
			},
			new string[2]{
				"Devourer of what, you said? Devourer of Funds, if its payroll is anything to go by!",
				"Le Dévoreur de quoi? Le Dévoreur de fonds, si on se fie à son salaire!"
			},
			new string[2]{
				"Goodness! That cane has swagger!",
				"Bonté divine! Cette canne est vraiment chic !"
			},
			new string[2]{
				"I deeply appreciate you rescuing me from being trapped within my frozen castle... It's been many, many years...",
				"J'apprécie enormément que tu m'aies libéré du piège de mon chateau gelé... Ca fait vraiment, vraiment longtemps..."
			},
			new string[2]{
				"Thank you for saving me...though now I admit I am without a home since mine got destroyed.",
				"Merci de m'avoir sauvé...mais je dois admettre que je suis à la rue vu que mon foyer a été détruit"
			},
			new string[2]{
				"I must admit...I am not quite used to this weather. It's too warm for my taste...",
				"Je dois l'admettre... je ne suis pas habitué à ce climat. Il faut trop chaud à mon goût..."
			},
			new string[2]{
				"My dear! What is it you would like to talk about today?",
				"Très cher! De quoi veux-tu qu'on parle aujourd'hui?"
			},
			new string[2]{
				"Why...I don't have to worry about any time of the day! If it is hot...then I can use my ice magic to cool down!",
				"Eh bien...Tu n'as pas à t'inquièter à propos du temps! S'il fait chaud...je peux utiliser ma magie de glace pour nous rafraichir"
			},
			new string[2]{
				"I do usually prefer a spot of humidity for my ice magic. It likes to come out as steam when it's too hot and dry...",
				"Je préfère un endroit humide pour ma magie de glace. Ca finit souvent en buée quand il fait trop chaud et sec..."
			},
			new string[2]{
				"Magic is a skill that must be learned and practiced! You seem to have an inherent talent for it at your age. I have spent all of my life honing it...",
				"La magie est un art qu'il faut apprendre et pratiquer! On dirait que tu as un talent inné pour la magie à ton age. J'ai passé presque ma vie a affiner mon art..."
			},
			new string[2]{
				"Why ice magic, you ask? Well, my parents were both pyromaniacs...",
				"Pourquoi la magie de glace? Eh bien, mes deux parents étaient des pyromanes..."
			},
			new string[2]{
				"There be monsters lurking in the darkness. Most...unnatural monsters.",
				"Il y a des monstres qui se tapissent dans les ténèbres. Des monstres... contre nature"
			},
			new string[2]{
				"You could break the icy stillness in the air tonight.",
				"On pourrait briser la glace dans l'air ce soir"
			},
			new string[2]{
				"Hmm...some would say that an unforeseen outside force is the root of the blood moon...",
				"Hmm...certains diraient qu'une force extérieure innatendue est à la racine de la lune de sang..."
			},
			new string[2]{
				"I was once the greatest Archmage of ice that ever hailed the lands. Whether or not that is still applicable, I am not sure...",
				"J'etais autrefois le plus grand archimage de glace à avoir jamais foulé ces terres. Que cela soit encore vrai, je n'en suis pas certain..."
			},
			new string[2]{
				"There used to be other Archmages of other elements. I wonder where they are now...if they are also alive...",
				"Il y a des archimages pour les autres éléments. Je me demande ou ils sont...Enfin, si il sont encore vivants..."
			},
			new string[2]{
				"Oh...I wish I could tell you all about my life and the lessons I have learned, but it appears you have a great many things to do...",
				"Oh... J'adorerais te raconter ma vie et te faire part des leçons qu'elle m'a appris, mais on dirait que tu as de beaucoup à faire..."
			},
			new string[2]{
				"I assure you, I will do my best to act as the cool grandfather figure you always wanted.",
				"Je te l'assure, je ferai de mon mieux pour être le grand-père cool que tu as toujours voulu"
			},
			new string[2]{
				"Sometimes...I feel like all I'm good for during these events is making ice cubes and slushies.",
				"Des fois... j'ai l'impression que je ne suis bon qu'a faire des glaçons et des barbotines pendant les fêtes. "
			},
			new string[2]{
				"Tread carefully, my friend... Now that the Moon Lord has been defeated, many powerful creatures will crawl out to challenge you...",
				"Prudence, mon ami... Maintenant que le Seigneur de la Lune a été vaincu, de nombreuses créatures puissantes vont surgir pour te défier..."
			},
			new string[2]{
				"I feel the balance of nature tilting farther than ever before. Is it due to you, or because of the events leading to now...?",
				"Je sens l'équilibre de la nature qui penche plus que jamais. Est-ce de ton fait, ou du fait des évènements qui nous ont mené jusqu'ici...?"
			},
			new string[2]{
				"I felt a sudden chill down my spine. I sense something dangerous stirring in the Abyss...",
				"J'ai senti un frisson dans mon dos. Je sens que quelque chose de dangereux remuer dans les abysses..."
			},
			new string[2]{
				"...Where is Lord Yharim? He must be up to something...",
				"...Ou est le seigneur Yharim? Il doit préparer un mauvais coup..."
			},
			new string[2]{
				"Yes, I am older than " + givenNames[9] + ". You can stop asking now...",
				"Oui, je suis plus vieux que "+ givenNames[9] + ". Tu peux arrêter de me le demander maintenant..."
			},
			new string[2]{
				"What an adorable tiny companion you have! Where in the world did you find such a...creature...? Actually, I'd rather not know.",
				"Quel adorable petit compagnon tu as là! Mais où as-tu bien pu trouvé une telle...créature...? En fait, je préfère ne pas savoir."
			},
			new string[2]{
				Main.player[Main.myPlayer].name + "...just between us, I think I forgot my soul in the ice castle. If you see it, please do let me know.",
				Main.player[Main.myPlayer].name + "...juste entre nous, je pense que j'ai oublié mon âme dans le chateau de glace. Si tu la voies, dit moi le s'il te plaît"
			},
			new string[2]{
				"It wouldn't be the first time something unknown and powerful dropped from the heavens...I would tread carefully if I were you...",
				"Ce n'est pas la première fois que quelque chose d'inconnu et de puissant est tombé des cieux...Je serais prudent si j'étais toi..."
			},
			new string[2]{
				"Why are you talking to me right now? Either way, I expect you to turn in a perfect performance!",
				"Pourquoi t'es en train de me parler là? Quoi qu'il arrive, j'attends de toi une performance parfaite!"
			},
			new string[2]{
				"I could smell my vodka from MILES away!",
				"J'ai senti ma vodka à des KILOMÈTRES!"
			},
			new string[2]{
				"Have any spare rooms available? Preferably candle-lit with a hefty supply of booze.",
				"Tu as des chambres de libre? Éclairée à la bougie de préférence, avec un stock massif d'alcool."
			},
			new string[2]{
				"Hey, nice night! I'm gonna make some Bloody Marys, celery included. Want one?",
				"Hey, belle nuit! Je vais me faire des Bloody Marys, avec du céleri. T'en veux un?"
			},
			new string[2]{
				"More blood for the blood gods!",
				"Plus de sang pour les dieux du sang!"
			},
			new string[2]{
				"Everyone else is so rude tonight. If they don't get over it soon, I'll break down their doors and make them!",
				"Tout le monde est tellement grossier ce soir. Ils ont intérêt à se calmer, sinon je vais me charger de leurs cas!"
			},
			new string[2]{
				"Being drunk, I have no moral compass atm.",
				"Je suis bourrée, j'ai aucun sens moral là"
			},
			new string[2]{
				"Nothard/10, if I fight bosses I wanna feel like screaming 'OH YES DADDY!' while I die repeatedly.",
				"pasdur/20, si je combats des boss je veux me sentir comme si je criais 'PLUS FORT, PAPA' tout en mourant en boucle"
			},
			new string[2]{
				"Like I always say, when you're drunk you can tolerate annoying people a lot more easily...",
				"Comme je l'ai toujours dit, c'est beaucoup plus facile de supporter les gens irritants quand on est bourré..."
			},
			new string[2]{
				"I'm literally balls drunk off my sass right now.",
				"Je suis tellement bourrée que je me sens aimable."
			},
			new string[2]{
				"I'm either laughing because I'm drunk or because I've lost my mind. Probably both.",
				"Je rigole soit parce que je suis bourrée, soit parce que je suis devenue folle. Probablement les deux."
			},
			new string[2]{
				"When I'm drunk I'm way happier...at least until the talking worms start to appear.",
				"Je suis tellement plus heureuse quand je suis ivre...enfin, jusqu'a ce que les vers qui parlent commencent à se ramener."
			},
			new string[2]{
				"I should reprogram the whole game while drunk and send it back to the testers.",
				"Je devrais reprogrammer tout le jeu en étant bourrée et le renvoyer au testeurs."
			},
			new string[2]{
				"What a great day, might just drink so much that I get poisoned again.",
				"Quelle belle journée, j'ai presque encore envie de boire jusqu'au coma éthyllique"
			},
			new string[2]{
				"A perfect night...for alcohol! First drinks are on me!",
				"Un nuit parfaite...pour de l'alcool! La première tournée est pour moi!"
			},
			new string[2]{
				"Here's a challenge...take a drink whenever you get hit. Oh wait, you'd die.",
				"J'ai un défi pour toi... prends un verre à chaque fois que tu te fais toucher. Non attends, tu vas mourir."
			},
			new string[2]{
				"Well I was planning to light some candles in order to relax...ah well, time to code while drunk.",
				"Bon, j'allais allumer quelques bougies pour me relaxer...tant pis, codons bourrée."
			},
			new string[2]{
				"Yes, everyone knows the mechworm is buggy. Well, not so much anymore, but still.",
				"Oui, tout le monde sait que le ver mécanique est bugué. Enfin, plus tant que ça, mais quand même."
			},
			new string[2]{
				"That's west, " + Main.player[Main.myPlayer].name + ". You're fired again.",
				"Ca c'est l'ouest, " + Main.player[Main.myPlayer].name + ". T'es viré. Encore."
			},
			new string[2]{
				"Are you sure you're 21? ...alright, fine, but don't tell anyone I sold you this.",
				"T'es sur d'être majeur? ... ok, ok, mais ne dis à personne que je t'ai vendu ça."
			},
			new string[2]{
				"Drink something that turns you into a magical flying unicorn so you can be super gay.",
				"Bois quelque chose qui te transforme en licorne magique volante, comme ça tu seras super gay."
			},
			new string[2]{
				"Did anyone ever tell you that large assets cause back pain? Well, they were right.",
				"Quelqu'un t'as déjà dit que de gros arguments causent des maux de dos? Et bien, ils ont raison."
			},
			new string[2]{
				"You'll always find me at parties where booze is involved...well, you'll always find booze where I'm involved.",
				"Tu me trouveras toujours aux fêtes où il y a de l'alcool...en fait, tu me trouveras partout où il y a de l'alcool."
			},
			new string[2]{
				"Shoot down the space invaders! Sexy time will be postponed if we are invaded by UFOs!",
				"Descends les envahisseurs de l'espace! Le moment coquin sera reporté si on est envahi par les OVNIs!"
			},
			new string[2]{
				"God I can't wait to beat on some ice again!",
				"Mon dieu, j'ai hâte d'astiquer de la glace à nouveau!"
			},
			new string[2]{
				"The only things I'm attracted to are fish women, women, men who look like women and that's it.",
				"La seule chose qui m'attire c'est les femmes-poissons, les femmes, les hommes qui ressemblent à des femmes et c'est tout."
			},
			new string[2]{
				"I'll always be watching.",
				"Je t'observerais toujours."
			},
			new string[2]{
				"Why did that weird monster need that many tentacles? ...actually, don't answer that.",
				"Pourquoi ce monstre bizarre à besoin d'autant de tentacules? ...en fait non, ne réponds pas."
			},
			new string[2]{
				"There's chemicals in the water...and they're turning the frogs gay!",
				"Il a des produits chimiques dans l'eau...et ils rendent les grenouilles gay!"
			},
			new string[2]{
				"I saw a ghost down by the old train tracks once, flailing wildly at the lily pads, those were the days.",
				"J'ai vu un fantôme sur des vieux rails de train une fois, qui battait sauvagement les nénuphars, c'était le bon temps."
			},
			new string[2]{
				"I hear it's amazing when the famous purple-stuffed worm out in flap-jaw space, with the tuning fork, does a raw blink on Hara-kiri rock. I need scissors! 61!",
				"J'ai entendu dire que c'est genial quand le célèbre ver fourré de violet dans l'espace de battement-machoire, avec la fourchette tuning, fait un clignement cru sur un rocher Harakiri. J'ai besoin de ciseaux! 61!"
			},
			new string[2]{
				"Tell " + givenNames[8] + " to stop calling me. He's not wanted.",
				"Dis à " + givenNames[8] + " d'arrêter de m'appeler. J'en veux pas."
			},
			new string[2]{
				"My booze will always be better than " + givenNames[8] + "'s, and nobody can convince me otherwise.",
				"Mon alcool sera toujours meilleur que celui de " + givenNames[8] + ", et personne ne pourra me convaincre du contraire."
			},
			new string[2]{
				"I never realized how well-endowed " + givenNames[7] + " was. It had to be the largest icicle I had ever seen.",
				"J'avais jamais réalisé à quel point " + givenNames[7] + " était bien muni. Ca doit être le plus gros stalagtite que j'ai jamais vu."
			},
			new string[2]{
				"You still can't stop me from trying to move in with " + givenNames[6] + ".",
				"Tu ne peux toujours pas m'empêcher d'essayer d'emmenager avec " + givenNames[6] + "."
			},
			new string[2]{
				"I love it when " + givenNames[6] + "'s hands get sticky from all that...wax.",
				"J'adore quand les mains de " + givenNames[6] + " sont toutes collantes à cause de tout ce... cette cire."
			},
			new string[2]{
				givenNames[6] + " works wonders for my hair...among other things.",
				givenNames[6] + " fait des merveilles avec mes cheveux...entre autres choses."
			},
			new string[2]{
				"Ever since " + givenNames[6] + " moved in I haven't been drinking as much...it's a weird feeling.",
				"Depuis que " + givenNames[6] + " est arrivée, je ne bois plus autant...c'est un sentiment bizarre."
			},
			new string[2]{
				"Is that a toy? Looks like something I'd carry around if I was 5 years old.",
				"C'est un jouet? On dirait un truc que je me trimballerais si j'avais 5 ans."
			},
			new string[2]{
				"Nice scales...did it get hot in here?",
				"Jolies écailles...Il a fait chaud là-dedans?"
			},
			new string[2]{
				"Oh yeah, now you're drinking the good stuff! Do you like it? I created the recipe by mixing fairy dust, crystals and other magical crap.",
				"Oh oui, mainteant tu bois de la bonne! T'aimes ça? J'ai crée la recette en mélangeant de la poussière de fée, des cristaux et d'autres merdes magiques."
			},
			new string[2]{
				"So...you're riding me, huh? That's not weird at all.",
				"Alors... tu me chevauches, hein? C'est pas bizarre du tout."
			},
			new string[2]{
				"Are you coming on to me?",
				"Est-ce que tu viens sur moi?"
			},
			new string[2]{
				"If I was a magical horse, I'd be out in space, swirling cocktails, as I watch space worms battle for my enjoyment.",
				"Si j'étais un cheval magique, je serais dans l'espace, sirotant des cocktails en regardant des vers de l'espace se battre pour mon petit plaisir."
			},
			new string[2]{
				"Is this...what the world is like now? It seems so much more lifeless than when I saw it before I disappeared.",
				"C'est ça... le monde maintenant? Ca à l'air tellement plus mort que la dernière fois que je suis venue."
			},
			new string[2]{
				"Thank you for your service, my child, but I am afraid I am without a home now.",
				"Merci pour ton aide, mon enfant, mais j'ai bien peur d'être sans foyer maintenant."
			},
			new string[2]{
				"My homeland may have dried up but the memories of my people still remain. I will not let them be in vain.",
				"Ma patrie s'est peut-être évaporée, mais les souvenirs de mon peuple perdurent. Je ne les laisserai pas être vains."
			},
			new string[2]{
				"There is a lot that you do not know about this world, specifically regarding the past. Much of it has been lost to history due to the many wars that plagued it.",
				"Il y a énormément de choses que tu ignores de ce monde, en particulier du passé. Beaucoup de ces choses ont été oubliées à cause des nombreuses guerres qui ont proliférées sur ce monde."
			},
			new string[2]{
				"How can I survive on land? Ah, that is a secret. No, actually...I can breathe air like you!",
				"Comment je peux survivre hors de l'eau? Ah ça, c'est un secret. Non, en fait... je peux respirer de l'air comme toi!"
			},
			new string[2]{
				"Why do you ask if it's the males that carry the young? Don't your males carry their young?",
				"Pourquoi tu me demandes si les males portent leurs enfants? Vos males ne portent pas leur enfants?"
			},
			new string[2]{
				"There be monsters lurking in the darkness. Most...unnatural monsters.",
				"Il y a des monstres qui rôdent dans les ténèbres. Des monstres... contre nature."
			},
			new string[2]{
				"Most creatures look up at the moon and admire it. I look up and fear it.",
				"La plupart des créatures regardent et admirent la lune. Moi, je la regarde et je la crains."
			},
			new string[2]{
				"Oh, me? I don't sleep, it's part of my nature.",
				"Oh, moi? je ne dors pas, ça fait partie de ma nature."
			},
			new string[2]{
				givenNames[5] + " asked if my nose could be used as a vuvuzela. What is a vuvuzela?",
				givenNames[5] + " m'a demandé si mon nez peut servir de vivizela. C'est quoi un vuvuzela?"
			},
			new string[2]{
				"Meet me at " + givenNames[4] + "'s house at night. We're going to throw him to the Trashers.",
				"Retrouve moi chez "+ givenNames[4] + " la nuit. On va le jeter aux crocodiles."
			},
			new string[2]{
				"Not sure how " + givenNames[4] + " has not been roasted and digested by now, hanging around the sulphuric seas for so long. Perhaps it got to his head.",
				"Pas sur de comprendre comment " + givenNames[4] + " n'a pas été cuit et digéré, surtout vu qu'il traîne dans les mers de sulfure depuis si longtemps. Peut-être que ça lui a attaqué le cerveau."
			},
			new string[2]{
				"Rumor has it " + givenNames[2] + " drinks to forget her troubled past.",
				"Les rumeurs disent que "+ givenNames[2] + " boit pour oublier son passé tortueux"
			},
			new string[2]{
				"I'm never keen on these nights. They're so violent.",
				"Je n'ai jamais apprécié ces nuits. Elles sont si violentes."
			},
			new string[2]{
				"Ah, nice duds, my child!",
				"Ah, jolies fresques, mon enfant!"
			},
			new string[2]{
				"Shouldn't you be wearing a clam bra?",
				"Tu ne devrais pas porter un soutien-gorge en coquillage?"
			},
			new string[2]{
				"The balance between light and dark is tipping. Stay strong, my child.",
				"L'equilibre entre la lumière et les ténèbres change. Reste fort, mon enfant."
			},
			new string[2]{
				"Ah, you are starting to realize just how complicated this world is now. You are learning the story of what became of him.",
				"Ah, tu commences a réaliser a quel point ce monde est compliqué maintenant. Tu apprends l'histoire de ce qu'il est devenu."
			},
			new string[2]{
				"Do you ever get the feeling that something out there is watching you very carefully? Whatever it is, it's very small and sly, I think.",
				"N'as-tu pas parfois la sensation que quelque chose t'observe très attentivement? Quoi que ce soit, je pense que c'est petit et mesquin."
			},
			new string[2]{
				"I must admit, I am quite shaken up now. Never would I have imagined that I would see one of the dark gods again. Not in this lifetime anyhow.",
				"Je dois l'admettre, je suis plutôt décontenancé. Jamais je n'aurais cru que je reverrais l'un des dieux des ténèbres. Pas dans cette vie, en tout cas."
			},
			new string[2]{
				"Times like this I wish my home was still in one piece instead of evaporated away. I don't blame the witch for anything, it's just...oh, never mind.",
				"C'est dans des moments comme ça ou je souhaiterais que mon foyer soit encore intact au lieu de s'être évaporé. Je ne rejette pas la faute sur la sorcière, c'est juste que...oh, oublie ça."
			},
			new string[2]{
				"I suppose that witch was mistaken. Defeating the Ceaseless Void and the Devourer has not caused our world to collapse... but I would not lower my guard if I were you.",
				"Je suppose que cette sorcière s'est trompée. Défaire le Néant Incessant et le Dévoreur n'as pas causé l'effondrement de notre monde...mais je resterai sur mes gardes si j'étais toi."
			},
			new string[2]{
				"Oy, watch where you're going or I might just use you for dart practice.",
				"Oy, regarde où tu vas ou tu vas finir en cible d'entrainement"
			},
			new string[2]{
				"Bet you'd look good as a pincushion, amiright?",
				"J'parie qu'être une pelote à épingles t'iraît à merveille, non?"
			},
			new string[2]{
				"Zombies don't dodge very well. Maybe you'll do a bit better.",
				"Les zombies n'esquivent pas très bien. Peut-être que tu seras un peu mieux."
			},
			new string[2]{
				"Hey, careful over there. I've rigged the place. One wrong step and you're going to get a knife in your forehead.",
				"Hey, fait gaffe. J'ai piégé l'endroit. Un pas de travers et tu finiras avec un couteau entre les deux yeux."
			},
			new string[2]{
				"You know what's really cool? Watching the glint of throwing stars as they reflect the moon.",
				"Tu sais ce qui est vraiment cool? Regardez le reflet des shurikens quand ils reflètent la lune."
			},
			new string[2]{
				"You think those stars that fall occasionally would make good throwing weapons?",
				"Tu pense que ces étoiles qui tombent de temps en temps feraient de bonnes armes de lancer?"
			},
			new string[2]{
				"Statis' clan's got nothing on me. Mostly cause they're all dead.",
				"Le clan de Statis m'arrive pas à la cheville. Principalement parce qu'ils sont tous morts."
			},
			new string[2]{
				"Where is my party hat? Well, I stole it of course.",
				"Ou est mon chapeau de fête? Ben, je l'ai volé, évidemment."
			},
			new string[2]{
				"The nice thing about maps is I can track anything that has fallen.",
				"Le truc bien avec les cartes c'est que je peux traquer tout ce qui est tombé"
			},
			new string[2]{
				"Imagine how fast you could throw if you just had more hands.",
				"Imagine la vitesse de lancer que tu pourrais avoir si tu avais plus de mains."
			},
			new string[2]{
				"I also take food for currency.",
				"Je prends aussi la nourriture comme paiement."
			},
			new string[2]{
				"Usually I only think of animals as food or target practice, but dragons are an exception.",
				"Normalement je considère les animaux comme de la nourriture ou comme une cible d'entrainenement, mais pour les dragons, je fais une exception."
			},
			new string[2]{
				"Anything is a weapon if you throw it hard enough.",
				"Tout est une arme si tu le jettes suffisament fort."
			},
			new string[2]{
				"That's your chucking arm? You need to work out more.",
				"C'est ça ton bras? Tu dois plus t'entrainer."
			},
			new string[2]{
				"Listen here. It's all in the wrist, the wrist! Oh, forget it.",
				"Écoute moi. Tout est dans le poignet, le poignet! Oh, oublie ça."
			},
			new string[2]{
				"I don't think Mom and Dad are proud of the job I have right now.",
				"Je pense pas que Papa et Maman soient fiers de mon boulot actuellement."
			},
			new string[2]{
				"Eh you know how it goes; steal from the rich, give to the poor. Of course, for a price.",
				"Ah tu sais comment ça marche; voler aux riches pour donner aux pauvres. A un tarif raisonnable, bien sur."
			},
			new string[2]{
				"Want to hear about this one time I was stuck in a room with a rabid dog and a dead guy?",
				"Je t'ai raconté cette histoire ou je me suis retrouvée coincée dans une salle avec un chien enragé et un type mort?"
			},
			new string[2]{
				"Argh snakes. For some reason it's always snakes.",
				"Ah des serpents. Pourquoi est-ce que c'est toujours des serpents?"
			},
			new string[2]{
				"Maybe I'm bitter. It's been a long time, so whatever. Just do a good job out there.",
				"Peut-être que je suis amer. Bah, ça fait longtemps, alors on oublie. Contente toi de faire du bon travail."
			},
			new string[2]{
				"It's not stealing! I'm just borrowing it until I die!",
				"C'est pas du vol! C'est un emprunt à vie!"
			},
			new string[2]{
				"Wouldn't be the first time I used my friends' remains as weapons.",
				"Ce sera pas la première fois que j'utilise ce qui reste de mes amis comme arme."
			},
			new string[2]{
				"With all of this new stuff cropping up, looks like we got some easy loot and new items to craft up, eh? Well, YOU craft them, I'll steal em.",
				"Avec tous ces trucs qui sortent de nulle part, y a du butin facile et des nouveaux objets à fabriquer, hein? Enfin, Tu fabriques,et moi je les vole."
			},
			new string[2]{
				"Draedon thinks he can build awesome machines, but he doesn't know how much crap I've stolen from him and sold by dismantling his drones.",
				"Draedon pense qu'il peut construire des machines géniales, mais il sait pas la quantité de merde que je lui ai volé et revendu en démantelant ses drones."
			},
			new string[2]{
				"Gramma always said never to invade ancient temples or you'll be cursed and die. Let's say both of us attest that is untrue. We're still alive. Somewhat.",
				"Mamy disait toujours de ne pas s'introduire dans les temples anciens ou je serais maudite et je mourrais. On dirait qu'on peut tous les deux attester que c'est faux. On est encore vivant. En quelque sorte."
			},
			new string[2]{
				"I heard that there's some really neat and awesome rogue items you can get. Show em to me if you ever get the time.",
				"J'ai entendu dire qu'il y a des objets de voleur vraiment cool et géniaux que tu peux avoir. Montre moi les si t'as le temps un de ces quatre."
			},
			new string[2]{
				"Providence HATES it when you take her stuff. I learned that the hard way.",
				"Providence DÉTESTE quand on lui prends ses affaires. Je l'ai appris à la dure."
			},
			new string[2]{
				"You think I can get away with looting from ghosts? It ain't like they can pick things up.",
				"Tu penses que je peux m'en sortir en dévalisant des fantômes? C'est pas comme si ils peuvent ramasser des trucs."
			},
			new string[2]{
				"Oh man, did you rip that off a shark!? Now that's a weapon!",
				"Woah, t'as arraché ça d'un requin? Ca c'est une arme!"
			},
			new string[2]{
				"I tried looting Storm Weaver's armor once. Before I could get a chunk of the stuff... well let's just say the bigger, fatter cosmic worm arrived and it didn't end well.",
				"J'ai essayé de subtiliser l'armure du Tisse-Tempête une fois. Avant que j'ai pu en récupérer un morceau... et bien disons juste que le plus gros ver s'est ramené et que ça s'est mal fini."
			},
			new string[2]{
				"I'd rather not be here. This place has bad vibes, y'know? It brings back some unpleasant memories.",
				"Je préfèrerai pas être ici. Cette endroit dégage de mauvaises ondes, t'sais? Ca me rappelle des mauvais souvenirs."
			},
			new string[2]{
				"Don't tell " + givenNames[3] + ", but I took some of his stuff and replaced it with Angel Statues.",
				"Le dis pas à " + givenNames[3] + ", mais j'ai pris certaines de ses affaires et je les ai remplacés par des statues d'anges."
			},
			new string[2]{
				"I learned never to steal " + givenNames[2] + "'s drinks. She doesn't appreciate me right now so I'll go back to hiding.",
				"J'ai appris qu'il ne fallait jamais voler l'alcool de "+ givenNames[2] + ". Elle peut plus me supporter maintenant donc je vais retourner me planquer."
			},
			new string[2]{
				"Don't tell " + givenNames[0] + " that I was responsible for " + givenNames[1] + "'s injuries.",
				"Ne dis pas à " + givenNames[0] + " que c'est moi qui suis responsable des blessures de " + givenNames[1]
			},
			new string[2]{
				"God Slayer Dynamite? Boy do I like the sound of that!",
				"De la dynamite déicide? Oh ça, ça sonne bien!"
			},
			new string[2]{
				"I'm considering moving back to that old cave of mine.",
				"Je suis en train de considérer à réemménager dans ma vieille cave."
			},
			new string[2]{
				"I certainly can't return to the Tyrant's old dwellings now, have you got any places to stay?",
				"Je ne peux certainement pas retourner au repère du vieux tyran maintenant, t'as un endroit ou je peux m'installer ?"
			},
			new string[2]{
				"I can't pay rent, but if you've got any dead relative you want me to try and... what? You don't?",
				"Je peux pas payer le loyer, mais si tu as de la famille morte que tu veux que j'essaie de... quoi ? t'en as pas ?"
			},
			new string[2]{
				"One of these days, I was thinking of starting a garden with the flowers from the old capitol of hell. I love the smell of brimstone in the morning.",
				"Un de ces jours, je ferai peut-être un jardin avec des fleurs dans la vieille capitale des enfers. J'adore l'odeur du soufre de bon matin."
			},
			new string[2]{
				"I think I've settled comfortably, thank you very much.",
				"Je pense que je suis bien installée, merci beaucoup."
			},
			new string[2]{
				"Many seasons have gone by since I first met with the Tyrant, and only now did I break free. I wish I'd been stronger...",
				"Tant de saisons ont passée depuis que j'ai rencontré le tyran pour la première fois, et je ne me suis libérée que maintenant. J'aurais aimé être plus forte..."
			},
			new string[2]{
				"If you've got any curses you want dispelled... well I'm not your person.",
				"Si t'as des malédictions à dissiper... bah tu frappes pas a la bonne porte."
			},
			new string[2]{
				"Such an unnatural shade of red. Nothing like my brimstone flames.",
				"Une teinte de rouge aussi anormale. Rien a voir avec mes flammes soufrées.,"
			},
			new string[2]{
				"I can't work with nights like these. The stars seem to have shrunk away in fear.",
				"Je peux pas travailler durant des nuits comme celles la. Les étoiles semblent disparaître d'effroi."
			},
			new string[2]{
				"These undead are horrific, I can't stand to look at them. How could anyone be satisfied with such amateur work?",
				"Ces morts-vivants sont horribles, je ne peux pas supporter de les voir. Comment quiquonque pourrait-être satisfait d'un travail aussi amateur?"
			},
			new string[2]{
				"I don't think it's a stretch to say that astrology is utter nonsense... but it was a hobby of mine once.",
				"Je pense pas exagéré en disant que l'astrologie n'a aucun sens... mais c'était mon hobby autrefois."
			},
			new string[2]{
				"If another person asks me if I can dance or not, I will light their hat on fire.",
				"Si quelqu'un d'autre me demande si je veux dancer ou non, je mets le feu a son chapeau."
			},
			new string[2]{
				"I cannot understand the Sea King. He does not seem to want me dead. That amount of compassion I just can't understand.",
				"Je ne comprends pas le roi des mers. Il ne veux pas me voir morte. Je ne peux juste pas comprendre ce niveau de compassion."
			},
			new string[2]{
				"That frosty old man... even if you ignore our brands of magic and our old alliances, I doubt I'd ever get along with him.",
				"Ce vieil homme givré... même en mettant de côté nos magies respectives et nos vieilles allégeances, je ne pense pas que je m'entendrais bien avec lui un jour."
			},
			new string[2]{
				"I wonder if " + givenNames[2] + " ever feels cold given how revealing her dress is. Perhaps she should cover up a bit more.",
				"Je me demande si ça arrive à " + givenNames[2] + " d'avoir froid vu sa robe. Peut-être qu'elle devrait se couvrir un peu plus."
			},
			new string[2]{
				"Mrrp is cringe.",
				"Mrrp est cringe."
			},
			new string[2]{
				"Hey, hey, has Calamitas seriously moved in here with us? Why???",
				"Hey, hey, Calamitas a sérieusement emménagé avec nous? Mais pourquoi???"
			},
			new string[2]{
				"I must admit, the Witch's presence is unsettling to me. But so many years have passed, and she too has suffered much.",
				"Je dois l'admettre, la présence de la sorcière me dérange. Mais tant d'années ont passé, et elle n'a que trop souffert."
			},
			new string[2]{
				"The abuse " + givenNames[12] + " went through is something I can hardly comprehend. I'd offer her a drink, but I don't think she'd enjoy it.",
				"Le martyr que " + givenNames[12] + " a souffert est quelque chose que je ne peux pas comprendre. Je lui offrirai bien un verre, mais je doute qu'elle puisse l'apprécier."
			}
		};
		bool found = false;
		int i = 0;
		if (chat.EndsWith(fabSpecialQuote)) {
			chat = chat.Replace(" and ", " et ").Replace(fabSpecialQuote, "Vous avez l'air plutôt bien! ...Attendez, vous êtes qui déjà?");
			found = true;
		}
		while (i < translatedChat.Length && !found)
		{
			if (chat.Equals(translatedChat[i][0]) && !translatedChat[i][1].Equals(""))
			{
				chat = translatedChat[i][1];
				found = true;
			}
			i++;
		}
		
	}
}
