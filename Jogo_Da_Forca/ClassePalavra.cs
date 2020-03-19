using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Da_Forca
{
    class ClassePalavra
    {
        public string PalavraAleatoria(int tema, string palavra)
        {
            switch (tema)
            {
                case 0:
                    palavra = Animais(palavra);
                    break;
                case 1:
                    palavra = Comidas(palavra);
                    break;
                case 2:
                    palavra = Paises(palavra);
                    break;
            }
            return palavra;
        }

        public string Animais(string palavra)
        {
            string[] words = new string[117];
            Random rdn = new Random();
            int numero = 0;

            words[0] = "ANIMAIS";
            words[1] = "ARANHA";words[2] = "ABELHA";words[3] = "ÁGUIA";words[4] = "ANDORINHA";words[5] = "ANTA";words[6] = "ANTÍLOPE";words[7] = "AVESTRUZ";words[8] = "BABUÍNO";words[9] = "BALEIA";words[10] = "BARATA";
            words[11] = "BOI";words[12] = "BORBOLETA";words[13] = "BÚFALO";words[14] = "BURRO";words[15] = "CABRA";words[16] = "CAMELO";words[17] = "CANGURU";words[18] = "CÃO";words[19] = "CARACOL";words[20] = "CARANGUEJO";
            words[21] = "CARNEIRO"; words[22] = "CASTOR"; words[23] = "CAVALO"; words[24] = "CHIMPANZÉ"; words[25] = "CISNE"; words[26] = "COBRA"; words[27] = "COELHO"; words[28] = "COIOTE"; words[29] = "CORUJA"; words[30] = "CORVO";
            words[31] = "CROCODILO"; words[32] = "DRAGÃO-DE-KOMODO"; words[33] = "ELEFANTE"; words[34] = "ENGUIA"; words[35] = "ESQUILO"; words[36] = "ESTRELA-DO-MAR"; words[37] = "FALCÃO"; words[38] = "FOCA"; words[39] = "FORMIGA"; words[40] = "FRANGO";
            words[41] = "FUINHA"; words[42] = "FURÃO"; words[43] = "GAIVOTA"; words[44] = "GANSO"; words[45] = "GARÇA"; words[46] = "GATO"; words[47] = "GAZELA"; words[48] = "GIRAFA"; words[49] = "GOLFINHO"; words[50] = "GORILA";
            words[51] = "GUAXINIM"; words[52] = "HAMSTER"; words[53] = "HIENA"; words[54] = "HIPOPÓTAMO"; words[55] = "IGUANA"; words[56] = "JACARÉ"; words[57] = "JAGUAR"; words[58] = "JAVALI"; words[59] = "LAGARTA"; words[60] = "LAGOSTA";
            words[61] = "LEÃO"; words[62] = "LEÃO-DO-MAR"; words[63] = "LEBRE"; words[64] = "LÊMURE"; words[65] = "LEOPARDO"; words[66] = "LHAMA"; words[67] = "LIBÉLULA"; words[68] = "LOBO"; words[69] = "LONTRA"; words[70] = "LULA";
            words[71] = "MACACO"; words[72] = "MORCEGO"; words[73] = "MOSCA"; words[74] = "MOSQUITO"; words[75] = "MULA"; words[76] = "OSTRA"; words[77] = "OURIÇO"; words[78] = "OVELHA"; words[79] = "PANDA"; words[80] = "PANTERA";
            words[81] = "PATO"; words[82] = "PAVÃO"; words[83] = "PEIXE-BOI"; words[84] = "PEIXE"; words[85] = "PELICANO"; words[86] = "PERDIZ"; words[87] = "PERÚ"; words[88] = "POMBA"; words[89] = "PÔNEI"; words[90] = "PORCO";
            words[91] = "PORCO-ESPINHO"; words[92] = "PORQUINHO-DA-ÍNDIA"; words[93] = "PUMA"; words[94] = "RAPOSA"; words[95] = "RATAZANA"; words[96] = "RATO"; words[97] = "RENA"; words[98] = "RINOCERONTE"; words[99] = "SALAMANDRA"; words[100] = "SAPO";
            words[101] = "SERPENTE"; words[102] = "SURICATA"; words[103] = "TARTARUGA"; words[104] = "TATU"; words[105] = "TEXUGO"; words[106] = "TIGRE"; words[107] = "TOUPEIRA"; words[108] = "TUBARÃO"; words[109] = "URSO"; words[110] = "VEADO";
            words[111] = "VESPA"; words[112] = "ZEBRA"; words[113] = "COALA"; words[114] = "PANDA"; words[115] = "URSO"; words[116] = "BICHO-PREGUIÇA";

            numero = rdn.Next(116);
            palavra = words[numero];

            return palavra;
        }

        public string Comidas(string palavra)
        {
            string[] words = new string[85];
            Random rdn = new Random();
            int numero = 0;

            words[0] = "COMIDAS";
            words[1] = "ABACATE"; words[2] = "ABACAXI"; words[3] = "AÇAÍ"; words[4] = "ACEROLA"; words[5] = "AMORA"; words[6] = "ARATICUM"; words[7] = "BACABA"; words[8] = "BANANA"; words[9] = "BIRIBÁ"; words[10] = "CACAU";
            words[11] = "CAJÁ"; words[12] = "CAQUI"; words[13] = "CARAMBOLA"; words[14] = "CEREJA"; words[15] = "CIDRA"; words[16] = "COCO"; words[17] = "CUPUAÇU"; words[18] = "FIGO"; words[19] = "FRAMBOESA"; words[20] = "GOIABA";
            words[21] = "GROSELHA"; words[22] = "INGÁ"; words[23] = "JABUTICABA"; words[24] = "JACA"; words[25] = "JAMBO"; words[26] = "JENIPAPO"; words[27] = "KIWI"; words[28] = "LARANJA"; words[29] = "BERGAMOTA"; words[30] = "LIMÃO";
            words[31] = "MAÇÃ"; words[32] = "MAMÃO"; words[33] = "MANGA"; words[34] = "MANGABA"; words[35] = "MARACUJÁ"; words[36] = "MELANCIA"; words[37] = "MELÃO"; words[38] = "MORANGO"; words[39] = "PEQUI"; words[40] = "PÊRA";
            words[41] = "PÊSSEGO"; words[42] = "PITANGA"; words[43] = "PITAYA"; words[44] = "PUPUNHA"; words[45] = "ROMÃ"; words[46] = "SIRIGUELA"; words[47] = "TÂMARA"; words[48] = "TAMARINDO"; words[49] = "TANGERINA"; words[50] = "TUCUMÃ";
            words[51] = "UVA"; words[52] = "MARMELO"; words[53] = "FRAMBOESA"; words[54] = "JUJUBA"; words[55] = "AZEITONA"; words[56] = "ROMÃ"; words[57] = "CIDRA"; words[58] = "LIMA"; words[58] = "CHIRIMÓIA"; words[59] = "NOZ"; words[60] = "AJURU";
            words[61] = "AMEIXA"; words[62] = "AMÊNDOA"; words[63] = "AMENDOIM"; words[64] = "ARAÇÁ"; words[65] = "ARATICUM"; words[66] = "CACAU"; words[67] = "CAJU"; words[68] = "CASTANHA"; words[69] = "CAMBOATÃ"; words[70] = "CANA";
            words[71] = "DAMASCO"; words[72] = "DENDÊ"; words[73] = "GRAVIOLA"; words[74] = "JABUTICABA"; words[75] = "GUABIJU"; words[76] = "LARANJINHA"; words[77] = "MANGABA"; words[78] = "MARAJÁ"; words[79] = "MARULA"; words[80] = "MELÃO";
            words[81] = "PEPINO"; words[82] = "PINHÃO"; words[83] = "PITAYA"; words[84] = "CHUCHU";

            numero = rdn.Next(84);
            palavra = words[numero];

            return palavra;
        }

        public string Paises(string palavra)
        {
            string[] words = new string[245];
            Random rdn = new Random();
            int numero = 0;

            words[0] = "PAÍSES";
            words[1] = "ABECÁSIA"; words[2] = "AFEGANISTÃO"; words[3] = "ÁFRICA DO SUL"; words[4] = "ALBÂNIA"; words[5] = "ALEMANHA"; words[6] = "ANDORRA"; words[7] = "ANGOLA"; words[8] = "ANTIGA E BARBUDA"; words[9] = "ARÁBIA SAUDITA"; words[10] = "ARGÉLIA";
            words[11] = "ARGENTINA"; words[12] = "ARMÉNIA"; words[13] = "ARMÊNIA"; words[14] = "ARTSAQUE"; words[15] = "AUSTRÁLIA"; words[16] = "ÁUSTRIA"; words[17] = "AZERBAIJÃO"; words[18] = "BAHAMAS"; words[19] = "BANGLADESH"; words[20] = "BARBADOS";
            words[21] = "BAHRAIN"; words[22] = "BÉLGICA"; words[23] = "BELIZE"; words[24] = "BENIM"; words[25] = "BERMUDAS"; words[26] = "BIELORRÚSSIA"; words[27] = "BOLÍVIA"; words[28] = "BONAIRE"; words[29] = "BÓSNIA"; words[30] = "BOTSUANA";
            words[31] = "BRASIL"; words[32] = "BRUNEI"; words[33] = "BULGÁRIA"; words[34] = "BURQUINA FASSO"; words[35] = "BURÚNDI"; words[36] = "BUTÃO"; words[37] = "CABO VERDE"; words[38] = "ILHAS CAYMAN"; words[39] = "CAMARÕES"; words[40] = "CAMBOJA";
            words[41] = "CANADÁ"; words[42] = "CATAR"; words[43] = "CAZAQUISTÃO"; words[44] = "REPÚPLICA CENTRO-AFRICANA"; words[45] = "CHADE"; words[46] = "REPÚPLICA TCHECA"; words[47] = "TAIWAN"; words[48] = "CHINA"; words[49] = "CHIPRE"; words[50] = "REPÚPLICA TURCA DE CHIPRE DO NORTE";
            words[51] = "ILHAS COCOS"; words[52] = "COLÔMBIA"; words[53] = "COMORES"; words[54] = "REPÚPLICA DO CONGO"; words[55] = "REPÚBLICA DEMOCRÁTICA DO CONGO"; words[56] = "ILHAS COOK"; words[57] = "COREIA DO NORTE"; words[58] = "COREIA DO SUL"; words[59] = "KOSOVO"; words[60] = "COSTA DO MARFIM";
            words[61] = "COSTA RICA"; words[62] = "CROÁCIA"; words[63] = "KUWAIT"; words[64] = "CUBA"; words[65] = "CURAÇÃO"; words[66] = "DINAMARCA"; words[67] = "DOMINICA"; words[68] = "REPÚBLICA DOMINICANA"; words[69] = "EGITO"; words[70] = "EMIRADOS ÁRABES UNIDOS";
            words[71] = "EQUADOR"; words[72] = "ERITREIA"; words[73] = "ESLOVÁQUIA"; words[74] = "ESLOVÊNIA"; words[75] = "ESPANHA"; words[76] = "ESTADOS UNIDOS DA AMÉRICA"; words[77] = "ESTÔNIA"; words[78] = "ESVALBARDA"; words[79] = "ETIÓPIA"; words[80] = "ILHAS FÉROE";
            words[81] = "FIJI"; words[82] = "FILIPINAS"; words[83] = "FINLÂNDIA"; words[84] = "FRANÇA"; words[85] = "GABÃO"; words[86] = "GÂMBIA"; words[87] = "GANA"; words[88] = "GEÓRGIA"; words[89] = "GIBRALTAR"; words[90] = "GRANADA";
            words[91] = "GRÉCIA"; words[92] = "GROENLÂNDIA"; words[93] = "GUADALUPE"; words[94] = "GUAME"; words[95] = "GUATEMALA"; words[96] = "GUERNESEI"; words[97] = "GUIANA"; words[98] = "GUIANA FRANCESA"; words[99] = "GUINÉ"; words[100] = "GUINÉ-BISSAU";
            words[101] = "GUINÉ EQUATORIAL"; words[102] = "HAITI"; words[103] = "HONDURAS"; words[104] = "HUNGRIA"; words[105] = "IÊMEN"; words[106] = "ÍNDIA"; words[107] = "INDONÉSIA"; words[108] = "IRÁ"; words[109] = "IRAQUE"; words[110] = "IRLANDA";
            words[111] = "ISLÂNDIA"; words[112] = "ISRAEL"; words[113] = "ITÁLIA"; words[114] = "JAMAICA"; words[115] = "JAPÃO"; words[116] = "JÉRSIA"; words[117] = "JORDÂNIA"; words[118] = "LAUS"; words[119] = "LESOTO"; words[120] = "LETÔNIA";
            words[121] = "LÍBANO"; words[122] = "LIBÉRIA"; words[123] = "LÍBIA"; words[124] = "LISTENSTAINE"; words[125] = "LITUÂNIA"; words[126] = "LUXEMBURGO"; words[127] = "MACAU"; words[128] = "MACEDÓNIA DO NORTE"; words[129] = "MADAGASCAR"; words[130] = "MAIOTE";
            words[131] = "MALÁSIA"; words[132] = "MALÁUI"; words[133] = "MALDIVAS"; words[134] = "MALI"; words[135] = "MALTA"; words[136] = "ILHAS MALVINAS"; words[137] = "ILHAS DE MAN"; words[138] = "ILHAS MARSHALL"; words[139] = "ILHAS MARIANAS DO NORTE"; words[140] = "MARROCOS";
            words[141] = "MARTINICA"; words[142] = "MAURÍCIA"; words[143] = "MAURITÂNIA"; words[144] = "MÉXICO"; words[145] = "MIANMAR"; words[146] = "ESTADOS FEDERADOS DA MICRONÉSIA"; words[147] = "MOÇAMBIQUE"; words[148] = "MOLDÁVIA"; words[149] = "MÔNACO"; words[150] = "MONGÓLIA";
            words[151] = "MONSERRATE"; words[152] = "MONTENEGRO"; words[153] = "NAMÍBIA"; words[154] = "NAURU"; words[155] = "NEPAL"; words[156] = "NICARÁGUA"; words[157] = "NÍGER"; words[158] = "NIGÉRIA"; words[159] = "NIUE"; words[160] = "ILHA NORFOLK";
            words[161] = "NORUEGA"; words[162] = "NOVA CALEDÓNIA"; words[163] = "NOVA ZELÂNDIA"; words[164] = "OMÃ"; words[165] = "OSSÉTIA DO SUL"; words[166] = "PAÍSES BAIXOS"; words[167] = "PALAU"; words[168] = "PALESTINA"; words[169] = "PANAMÁ"; words[170] = "PAPUA NOVA GUINÉ";
            words[171] = "PAQUISTÃO"; words[172] = "PARAGUAI"; words[173] = "PERU"; words[174] = "ILHAS PITCAIRN"; words[175] = "POLINÉSIA FRANCESA"; words[176] = "POLÔNIA"; words[177] = "PORTO RICO"; words[178] = "PORTUGAL"; words[179] = "QUÊNIA"; words[180] = "QUIRGUISTÃO";
            words[181] = "QUIRIBÁTI"; words[182] = "REINO UNIDO"; words[183] = "REUNIÃO"; words[184] = "ROMÊNIA"; words[185] = "RUANDA"; words[186] = "RÚSSIA"; words[187] = "REPÚBLICA ÁRABE SAARIANA DEMOCRÁTICA"; words[188] = "SABA"; words[189] = "ILHAS SALOMÃO"; words[190] = "SALVADOR";
            words[191] = "SALVADOR"; words[192] = "SAMOA"; words[193] = "SAMOA AMERICANA"; words[194] = "SANTA LÚCIA"; words[195] = "SANTO EUSTÁQUIO"; words[196] = "SÃO BARTOLOMEU"; words[197] = "SÃO CRISTÓVÃO E NEVES"; words[198] = "SÃO MARINHO"; words[199] = "SÃO MARTINHO"; words[200] = "SÃO PEDRO E MIQUELÃO";
            words[201] = "SÃO TOMÉ E PRÍNCIPE"; words[202] = "SEICHELES"; words[203] = "SENEGAL"; words[204] = "SERRA LEOA"; words[205] = "SÉRVIA"; words[206] = "SINGAPURA"; words[207] = "SÍRIA"; words[208] = "SOMÁLIA"; words[209] = "SOMALILÂNDIA"; words[210] = "SRI LANCA";
            words[211] = "SUAZILÂNDIA"; words[212] = "SUDÃO"; words[213] = "SUDÃO DO SUL"; words[214] = "SUÉCIA"; words[215] = "SUÍÇA"; words[216] = "SURINAME"; words[217] = "TAILÂNDIA"; words[218] = "TAJIQUISTÃO"; words[219] = "TANZÂNIA"; words[220] = "TIMOR-LESTE";
            words[221] = "TOGO"; words[222] = "TONGA"; words[223] = "TOQUELAU"; words[224] = "TRANSDNIÉSTRIA"; words[225] = ""; words[226] = "TRINDADE E TOBAGO"; words[227] = "TUNÍSIA"; words[228] = "ILHAS TURCAS E CAICOS"; words[229] = "TURCOMENISTÃO"; words[230] = "TURQUIA";
            words[231] = "TUVALU"; words[232] = "UCRÂNIA"; words[233] = "UGANDA"; words[234] = "URUGUAI"; words[235] = "USBEQUISTÃO"; words[236] = "VANUATU"; words[237] = "CIDADE DO VATICANO"; words[238] = "VENEZUELA"; words[239] = "VIETNÃ"; words[240] = "ILHAS VIRGENS BRITÂNICAS";
            words[241] = "ILHAS VIRGENS DOS ESTADOS UNIDOS"; words[242] = "WALLIS E FUTUNA"; words[243] = "ZÂMBIA"; words[244] = "ZIMBÁBUE";

            numero = rdn.Next(244);
            palavra = words[numero];

            return palavra;
        }
    }
}
