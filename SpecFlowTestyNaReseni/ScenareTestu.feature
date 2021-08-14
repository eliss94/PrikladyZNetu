Feature: ScenareTestu
	Test reseni ve tride Reseni

@mytag
Scenario: Vypocet obsahu trojuhelniku
	Given zakladna trojuhelniku je <zakladna>
	And vyska trojuhelniku je <vyska>
	When na nich spocitam obsah
	Then obsah trojuhelniku je <vysledek>

	Examples: 
			| zakladna | vyska | vysledek |
			| 3        | 2     | 3        |
			| 5        | 5     | 12       |
			| 4        | 3     | 6        |
	
Scenario: Vyber mensiho ze dvou cisel ve formatu string
	Given prvni cislo je <prvni cislo>
	And druhe cislo je <druhe cislo>
	When vyberu mensi z obou
	Then dostanu <vysledek>

	Examples: 
	| prvni cislo | druhe cislo | vysledek |
	| 1           | 9           | 1        |
	| 15          | 87          | 15       |
	
Scenario: Obraceni cisla a pridani puvodniho cisla
	Given zadane cislo je <cislo>
	When ho otocim a pridam puvodni cislo
	Then dostanu <vysledny string>
	Examples: 
	| cislo | vysledny string |
	| 123   | 321123          |
	| 2587  | 78522587        |

Scenario: Hexcode
	Given je zadany <kod>
	When otestuji je-li to hexcode
	Then vysledek je <bool>
	Examples: 
	| kod     | bool  |
	| #ab1256 | true  |
	| #tr9524 | false |

Scenario: Posouvani kelimku
	Given dostanu zadane <tahy>
	When aplikuju tahy na kelimky
	Then dostanu <kelimkem>
	
	Examples: 
	| tahy        | kelimkem |
	| AB AC       | C        |
	| AB          | A        |
	| CB CA AB BC | C        |
	
Scenario: Vymena promennych
	Given je dana promenna <a> a promenna <b>
	When je vymenim
	Then promenna a obsahuje <hodnota b> promenna b obsahuje <hodnota a>
	
	
	Examples:
	| a  | b | hodnota b | hodnota a |
	| 5  | 8 | 8         | 5         |
	| 15 | 4 | 4         | 15        |

Scenario: Vypocet faktorialu
	Given je zadane cislo <j>
	When na nem vypoctu faktorial
	Then vysledek vypoctu je <faktorial>

	Examples: 
	| j | faktorial |
	| 2 | 2         |
	| 4 | 24        |

Scenario: Vraceni nejmensi a nejvetsi hodnoty jako stringu ze zadaneho stringu (cisla jsou vzdy oddelena mezerou)
	Given mame zadany string cisel <zadani>
	When vybereme nejmensi a nejvetsi cislo
	Then dostanu <nejmensi a nejvetsi cislo>

	Examples: 
	| zadani        | nejmensi a nejvetsi cislo |
	| 12 15 48 6 89 | 6 89                      |
	| 5 8 12 69 74  | 5 74                      |
	| 15            | 15 15                     |

Scenario: Vypocet pole nasobku
	Given mame zadane <cislo> a <delku pole>
	When vypocteme pole nadobku
	Then dostaneme <pole nasobku>
	
	Examples:
	| cislo | delku pole | pole nasobku |
	| 3     | 3          | 3 6 9        |
	| 2     | 5          | 2 4 6 8 10   |

Scenario: Obraceni velikosti pismen
	Given string <zadani>
	When otocime velikost pismen
	Then dostanu <vysledek>
	
	Examples: 
	| zadani | vysledek |
	| Tom    | tOM      |
	| Happy  | hAPPY    |




	