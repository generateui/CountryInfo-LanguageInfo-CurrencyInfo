using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CountryLanguageCurrency
{
    #region Class LanguageInfo

    /// <summary>
    /// Class representing a language
    /// </summary>
    /// <remarks>
    /// 
    /// This is what <see cref="All"/> contains:
    /// 
    /// Code                 = Af
    /// Name                 = af
    /// EnglishName          = Afrikaans
    /// NativeName           = Afrikaans
    /// Cultures             = af-ZA
    /// Countries            = South Africa
    /// Country              = South Africa
    /// 
    /// Code                 = Am
    /// Name                 = am
    /// EnglishName          = Amharic
    /// NativeName           = አማርኛ
    /// Cultures             = am-ET
    /// Countries            = Ethiopia
    /// Country              = Ethiopia
    /// 
    /// Code                 = Ar
    /// Name                 = ar
    /// EnglishName          = Arabic
    /// NativeName           = العربية
    /// Cultures             = ar-SA, ar-IQ, ar-EG, ar-LY, ar-DZ, ar-MA, ar-TN, ar-OM, ar-YE, ar-SY, ar-JO, ar-LB, ar-KW, ar-AE, ar-BH, ar-QA
    /// Countries            = Saudi Arabia, Iraq, Egypt, Libya, Algeria, Morocco, Tunisia, Oman, Yemen, Syria, Jordan, Lebanon, Kuwait, U.A.E., Bahrain, Qatar
    /// Country              = Saudi Arabia
    /// 
    /// Code                 = Arn
    /// Name                 = arn
    /// EnglishName          = Mapudungun
    /// NativeName           = Mapudungun
    /// Cultures             = arn-CL
    /// Countries            = Chile
    /// Country              = Chile
    /// 
    /// Code                 = As
    /// Name                 = as
    /// EnglishName          = Assamese
    /// NativeName           = অসমীয়া
    /// Cultures             = as-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Az
    /// Name                 = az
    /// EnglishName          = Azeri
    /// NativeName           = Azərbaycan­ılı
    /// Cultures             = az-Latn-AZ, az-Cyrl-AZ
    /// Countries            = Azerbaijan
    /// Country              = Azerbaijan
    /// 
    /// Code                 = Ba
    /// Name                 = ba
    /// EnglishName          = Bashkir
    /// NativeName           = Башҡорт
    /// Cultures             = ba-RU
    /// Countries            = Russia
    /// Country              = Russia
    /// 
    /// Code                 = Be
    /// Name                 = be
    /// EnglishName          = Belarusian
    /// NativeName           = Беларускі
    /// Cultures             = be-BY
    /// Countries            = Belarus
    /// Country              = Belarus
    /// 
    /// Code                 = Bg
    /// Name                 = bg
    /// EnglishName          = Bulgarian
    /// NativeName           = български
    /// Cultures             = bg-BG
    /// Countries            = Bulgaria
    /// Country              = Bulgaria
    /// 
    /// Code                 = Bn
    /// Name                 = bn
    /// EnglishName          = Bengali
    /// NativeName           = বাংলা
    /// Cultures             = bn-IN, bn-BD
    /// Countries            = India, Bangladesh
    /// Country              = India
    /// 
    /// Code                 = Bo
    /// Name                 = bo
    /// EnglishName          = Tibetan
    /// NativeName           = བོད་ཡིག
    /// Cultures             = bo-CN
    /// Countries            = China
    /// Country              = China
    /// 
    /// Code                 = Br
    /// Name                 = br
    /// EnglishName          = Breton
    /// NativeName           = brezhoneg
    /// Cultures             = br-FR
    /// Countries            = France
    /// Country              = France
    /// 
    /// Code                 = Bs
    /// Name                 = bs
    /// EnglishName          = Bosnian
    /// NativeName           = bosanski
    /// Cultures             = bs-Latn-BA, bs-Cyrl-BA
    /// Countries            = Bosnia and Herzegovina
    /// Country              = Bosnia and Herzegovina
    /// 
    /// Code                 = Ca
    /// Name                 = ca
    /// EnglishName          = Catalan
    /// NativeName           = català
    /// Cultures             = ca-ES
    /// Countries            = Spain
    /// Country              = Spain
    /// 
    /// Code                 = Co
    /// Name                 = co
    /// EnglishName          = Corsican
    /// NativeName           = Corsu
    /// Cultures             = co-FR
    /// Countries            = France
    /// Country              = France
    /// 
    /// Code                 = Cs
    /// Name                 = cs
    /// EnglishName          = Czech
    /// NativeName           = čeština
    /// Cultures             = cs-CZ
    /// Countries            = Czech Republic
    /// Country              = Czech Republic
    /// 
    /// Code                 = Cy
    /// Name                 = cy
    /// EnglishName          = Welsh
    /// NativeName           = Cymraeg
    /// Cultures             = cy-GB
    /// Countries            = United Kingdom
    /// Country              = United Kingdom
    /// 
    /// Code                 = Da
    /// Name                 = da
    /// EnglishName          = Danish
    /// NativeName           = dansk
    /// Cultures             = da-DK
    /// Countries            = Denmark
    /// Country              = Denmark
    /// 
    /// Code                 = De
    /// Name                 = de
    /// EnglishName          = German
    /// NativeName           = Deutsch
    /// Cultures             = de-DE, de-CH, de-AT, de-LU, de-LI
    /// Countries            = Germany, Switzerland, Austria, Luxembourg, Liechtenstein
    /// Country              = Germany
    /// 
    /// Code                 = Dv
    /// Name                 = dv
    /// EnglishName          = Divehi
    /// NativeName           = ދިވެހިބަސް
    /// Cultures             = dv-MV
    /// Countries            = Maldives
    /// Country              = Maldives
    /// 
    /// Code                 = El
    /// Name                 = el
    /// EnglishName          = Greek
    /// NativeName           = Ελληνικά
    /// Cultures             = el-GR
    /// Countries            = Greece
    /// Country              = Greece
    /// 
    /// Code                 = En
    /// Name                 = en
    /// EnglishName          = English
    /// NativeName           = English
    /// Cultures             = en-US, en-GB, en-AU, en-CA, en-NZ, en-IE, en-ZA, en-JM, en-029, en-BZ, en-TT, en-ZW, en-PH, en-IN, en-MY, en-SG
    /// Countries            = United States, United Kingdom, Australia, Canada, New Zealand, Ireland, South Africa, Jamaica, Caribbean, Belize, Trinidad and Tobago, Zimbabwe, Philippines, India, Malaysia, Singapore
    /// Country              = United Kingdom
    /// 
    /// Code                 = Es
    /// Name                 = es
    /// EnglishName          = Spanish
    /// NativeName           = español
    /// Cultures             = es-MX, es-ES, es-GT, es-CR, es-PA, es-DO, es-VE, es-CO, es-PE, es-AR, es-EC, es-CL, es-UY, es-PY, es-BO, es-SV, es-HN, es-NI, es-PR, es-US
    /// Countries            = Mexico, Spain, Guatemala, Costa Rica, Panama, Dominican Republic, Venezuela, Colombia, Peru, Argentina, Ecuador, Chile, Uruguay, Paraguay, Bolivia, El Salvador, Honduras, Nicaragua, Puerto Rico, United States
    /// Country              = Spain
    /// 
    /// Code                 = Et
    /// Name                 = et
    /// EnglishName          = Estonian
    /// NativeName           = eesti
    /// Cultures             = et-EE
    /// Countries            = Estonia
    /// Country              = Estonia
    /// 
    /// Code                 = Eu
    /// Name                 = eu
    /// EnglishName          = Basque
    /// NativeName           = euskara
    /// Cultures             = eu-ES
    /// Countries            = Spain
    /// Country              = Spain
    /// 
    /// Code                 = Fa
    /// Name                 = fa
    /// EnglishName          = Persian
    /// NativeName           = فارسى
    /// Cultures             = fa-IR
    /// Countries            = Iran
    /// Country              = Iran
    /// 
    /// Code                 = Fi
    /// Name                 = fi
    /// EnglishName          = Finnish
    /// NativeName           = suomi
    /// Cultures             = fi-FI
    /// Countries            = Finland
    /// Country              = Finland
    /// 
    /// Code                 = Fil
    /// Name                 = fil
    /// EnglishName          = Filipino
    /// NativeName           = Filipino
    /// Cultures             = fil-PH
    /// Countries            = Philippines
    /// Country              = Philippines
    /// 
    /// Code                 = Fo
    /// Name                 = fo
    /// EnglishName          = Faroese
    /// NativeName           = føroyskt
    /// Cultures             = fo-FO
    /// Countries            = Faroe Islands
    /// Country              = Faroe Islands
    /// 
    /// Code                 = Fr
    /// Name                 = fr
    /// EnglishName          = French
    /// NativeName           = français
    /// Cultures             = fr-FR, fr-BE, fr-CA, fr-CH, fr-LU, fr-MC
    /// Countries            = France, Belgium, Canada, Switzerland, Luxembourg, Monaco
    /// Country              = France
    /// 
    /// Code                 = Fy
    /// Name                 = fy
    /// EnglishName          = Frisian
    /// NativeName           = Frysk
    /// Cultures             = fy-NL
    /// Countries            = Netherlands
    /// Country              = Netherlands
    /// 
    /// Code                 = Ga
    /// Name                 = ga
    /// EnglishName          = Irish
    /// NativeName           = Gaeilge
    /// Cultures             = ga-IE
    /// Countries            = Ireland
    /// Country              = Ireland
    /// 
    /// Code                 = Gd
    /// Name                 = gd
    /// EnglishName          = Scottish Gaelic
    /// NativeName           = Gàidhlig
    /// Cultures             = gd-GB
    /// Countries            = United Kingdom
    /// Country              = United Kingdom
    /// 
    /// Code                 = Gl
    /// Name                 = gl
    /// EnglishName          = Galician
    /// NativeName           = galego
    /// Cultures             = gl-ES
    /// Countries            = Spain
    /// Country              = Spain
    /// 
    /// Code                 = Gsw
    /// Name                 = gsw
    /// EnglishName          = Alsatian
    /// NativeName           = Elsässisch
    /// Cultures             = gsw-FR
    /// Countries            = France
    /// Country              = France
    /// 
    /// Code                 = Gu
    /// Name                 = gu
    /// EnglishName          = Gujarati
    /// NativeName           = ગુજરાતી
    /// Cultures             = gu-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Ha
    /// Name                 = ha
    /// EnglishName          = Hausa
    /// NativeName           = Hausa
    /// Cultures             = ha-Latn-NG
    /// Countries            = Nigeria
    /// Country              = Nigeria
    /// 
    /// Code                 = He
    /// Name                 = he
    /// EnglishName          = Hebrew
    /// NativeName           = עברית
    /// Cultures             = he-IL
    /// Countries            = Israel
    /// Country              = Israel
    /// 
    /// Code                 = Hi
    /// Name                 = hi
    /// EnglishName          = Hindi
    /// NativeName           = हिंदी
    /// Cultures             = hi-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Hr
    /// Name                 = hr
    /// EnglishName          = Croatian
    /// NativeName           = hrvatski
    /// Cultures             = hr-HR, hr-BA
    /// Countries            = Croatia, Bosnia and Herzegovina
    /// Country              = Croatia
    /// 
    /// Code                 = Hsb
    /// Name                 = hsb
    /// EnglishName          = Upper Sorbian
    /// NativeName           = hornjoserbšćina
    /// Cultures             = hsb-DE, dsb-DE
    /// Countries            = Germany
    /// Country              = Germany
    /// 
    /// Code                 = Hu
    /// Name                 = hu
    /// EnglishName          = Hungarian
    /// NativeName           = magyar
    /// Cultures             = hu-HU
    /// Countries            = Hungary
    /// Country              = Hungary
    /// 
    /// Code                 = Hy
    /// Name                 = hy
    /// EnglishName          = Armenian
    /// NativeName           = Հայերեն
    /// Cultures             = hy-AM
    /// Countries            = Armenia
    /// Country              = Armenia
    /// 
    /// Code                 = Id
    /// Name                 = id
    /// EnglishName          = Indonesian
    /// NativeName           = Bahasa Indonesia
    /// Cultures             = id-ID
    /// Countries            = Indonesia
    /// Country              = Indonesia
    /// 
    /// Code                 = Ig
    /// Name                 = ig
    /// EnglishName          = Igbo
    /// NativeName           = Igbo
    /// Cultures             = ig-NG
    /// Countries            = Nigeria
    /// Country              = Nigeria
    /// 
    /// Code                 = Ii
    /// Name                 = ii
    /// EnglishName          = Yi
    /// NativeName           = ꆈꌠꁱꂷ
    /// Cultures             = ii-CN
    /// Countries            = China
    /// Country              = China
    /// 
    /// Code                 = Is
    /// Name                 = is
    /// EnglishName          = Icelandic
    /// NativeName           = íslenska
    /// Cultures             = is-IS
    /// Countries            = Iceland
    /// Country              = Iceland
    /// 
    /// Code                 = It
    /// Name                 = it
    /// EnglishName          = Italian
    /// NativeName           = italiano
    /// Cultures             = it-IT, it-CH
    /// Countries            = Italy, Switzerland
    /// Country              = Italy
    /// 
    /// Code                 = Iu
    /// Name                 = iu
    /// EnglishName          = Inuktitut
    /// NativeName           = Inuktitut
    /// Cultures             = iu-Cans-CA, iu-Latn-CA
    /// Countries            = Canada
    /// Country              = Canada
    /// 
    /// Code                 = Iv
    /// Name                 = 
    /// EnglishName          = Invariant Language (Invariant Country)
    /// NativeName           = Invariant Language (Invariant Country)
    /// Cultures             = 
    /// Countries            = 
    /// Country              = 
    /// 
    /// Code                 = Ja
    /// Name                 = ja
    /// EnglishName          = Japanese
    /// NativeName           = 日本語
    /// Cultures             = ja-JP
    /// Countries            = Japan
    /// Country              = Japan
    /// 
    /// Code                 = Ka
    /// Name                 = ka
    /// EnglishName          = Georgian
    /// NativeName           = ქართული
    /// Cultures             = ka-GE
    /// Countries            = Georgia
    /// Country              = Georgia
    /// 
    /// Code                 = Kk
    /// Name                 = kk
    /// EnglishName          = Kazakh
    /// NativeName           = Қазақ
    /// Cultures             = kk-KZ
    /// Countries            = Kazakhstan
    /// Country              = Kazakhstan
    /// 
    /// Code                 = Kl
    /// Name                 = kl
    /// EnglishName          = Greenlandic
    /// NativeName           = kalaallisut
    /// Cultures             = kl-GL
    /// Countries            = Greenland
    /// Country              = Greenland
    /// 
    /// Code                 = Km
    /// Name                 = km
    /// EnglishName          = Khmer
    /// NativeName           = ខ្មែរ
    /// Cultures             = km-KH
    /// Countries            = Cambodia
    /// Country              = Cambodia
    /// 
    /// Code                 = Kn
    /// Name                 = kn
    /// EnglishName          = Kannada
    /// NativeName           = ಕನ್ನಡ
    /// Cultures             = kn-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Ko
    /// Name                 = ko
    /// EnglishName          = Korean
    /// NativeName           = 한국어
    /// Cultures             = ko-KR
    /// Countries            = Korea
    /// Country              = Korea
    /// 
    /// Code                 = Kok
    /// Name                 = kok
    /// EnglishName          = Konkani
    /// NativeName           = कोंकणी
    /// Cultures             = kok-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Ky
    /// Name                 = ky
    /// EnglishName          = Kyrgyz
    /// NativeName           = Кыргыз
    /// Cultures             = ky-KG
    /// Countries            = Kyrgyzstan
    /// Country              = Kyrgyzstan
    /// 
    /// Code                 = Lb
    /// Name                 = lb
    /// EnglishName          = Luxembourgish
    /// NativeName           = Lëtzebuergesch
    /// Cultures             = lb-LU
    /// Countries            = Luxembourg
    /// Country              = Luxembourg
    /// 
    /// Code                 = Lo
    /// Name                 = lo
    /// EnglishName          = Lao
    /// NativeName           = ລາວ
    /// Cultures             = lo-LA
    /// Countries            = Laos
    /// Country              = Laos
    /// 
    /// Code                 = Lt
    /// Name                 = lt
    /// EnglishName          = Lithuanian
    /// NativeName           = lietuvių
    /// Cultures             = lt-LT
    /// Countries            = Lithuania
    /// Country              = Lithuania
    /// 
    /// Code                 = Lv
    /// Name                 = lv
    /// EnglishName          = Latvian
    /// NativeName           = latviešu
    /// Cultures             = lv-LV
    /// Countries            = Latvia
    /// Country              = Latvia
    /// 
    /// Code                 = Mi
    /// Name                 = mi
    /// EnglishName          = Maori
    /// NativeName           = Reo Māori
    /// Cultures             = mi-NZ
    /// Countries            = New Zealand
    /// Country              = New Zealand
    /// 
    /// Code                 = Mk
    /// Name                 = mk
    /// EnglishName          = Macedonian (FYROM)
    /// NativeName           = македонски јазик
    /// Cultures             = mk-MK
    /// Countries            = Macedonia
    /// Country              = Macedonia
    /// 
    /// Code                 = Ml
    /// Name                 = ml
    /// EnglishName          = Malayalam
    /// NativeName           = മലയാളം
    /// Cultures             = ml-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Mn
    /// Name                 = mn
    /// EnglishName          = Mongolian
    /// NativeName           = Монгол хэл
    /// Cultures             = mn-MN, mn-Mong-CN
    /// Countries            = Mongolia, China
    /// Country              = Mongolia
    /// 
    /// Code                 = Moh
    /// Name                 = moh
    /// EnglishName          = Mohawk
    /// NativeName           = Kanien'kéha
    /// Cultures             = moh-CA
    /// Countries            = Canada
    /// Country              = Canada
    /// 
    /// Code                 = Mr
    /// Name                 = mr
    /// EnglishName          = Marathi
    /// NativeName           = मराठी
    /// Cultures             = mr-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Ms
    /// Name                 = ms
    /// EnglishName          = Malay
    /// NativeName           = Bahasa Melayu
    /// Cultures             = ms-MY, ms-BN
    /// Countries            = Malaysia, Brunei
    /// Country              = Malaysia
    /// 
    /// Code                 = Mt
    /// Name                 = mt
    /// EnglishName          = Maltese
    /// NativeName           = Malti
    /// Cultures             = mt-MT
    /// Countries            = Malta
    /// Country              = Malta
    /// 
    /// Code                 = Nb
    /// Name                 = no
    /// EnglishName          = Norwegian
    /// NativeName           = norsk
    /// Cultures             = nb-NO, nn-NO
    /// Countries            = Norway
    /// Country              = Norway
    /// 
    /// Code                 = Ne
    /// Name                 = ne
    /// EnglishName          = Nepali
    /// NativeName           = नेपाली
    /// Cultures             = ne-NP
    /// Countries            = Nepal
    /// Country              = Nepal
    /// 
    /// Code                 = Nl
    /// Name                 = nl
    /// EnglishName          = Dutch
    /// NativeName           = Nederlands
    /// Cultures             = nl-NL, nl-BE
    /// Countries            = Netherlands, Belgium
    /// Country              = Netherlands
    /// 
    /// Code                 = Nso
    /// Name                 = nso
    /// EnglishName          = Sesotho sa Leboa
    /// NativeName           = Sesotho sa Leboa
    /// Cultures             = nso-ZA
    /// Countries            = South Africa
    /// Country              = South Africa
    /// 
    /// Code                 = Oc
    /// Name                 = oc
    /// EnglishName          = Occitan
    /// NativeName           = Occitan
    /// Cultures             = oc-FR
    /// Countries            = France
    /// Country              = France
    /// 
    /// Code                 = Or
    /// Name                 = or
    /// EnglishName          = Oriya
    /// NativeName           = ଓଡ଼ିଆ
    /// Cultures             = or-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Pa
    /// Name                 = pa
    /// EnglishName          = Punjabi
    /// NativeName           = ਪੰਜਾਬੀ
    /// Cultures             = pa-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Pl
    /// Name                 = pl
    /// EnglishName          = Polish
    /// NativeName           = polski
    /// Cultures             = pl-PL
    /// Countries            = Poland
    /// Country              = Poland
    /// 
    /// Code                 = Prs
    /// Name                 = prs
    /// EnglishName          = Dari
    /// NativeName           = درى
    /// Cultures             = prs-AF
    /// Countries            = Afghanistan
    /// Country              = Afghanistan
    /// 
    /// Code                 = Ps
    /// Name                 = ps
    /// EnglishName          = Pashto
    /// NativeName           = پښتو
    /// Cultures             = ps-AF
    /// Countries            = Afghanistan
    /// Country              = Afghanistan
    /// 
    /// Code                 = Pt
    /// Name                 = pt
    /// EnglishName          = Portuguese
    /// NativeName           = Português
    /// Cultures             = pt-BR, pt-PT
    /// Countries            = Brazil, Portugal
    /// Country              = Portugal
    /// 
    /// Code                 = Qut
    /// Name                 = qut
    /// EnglishName          = K'iche
    /// NativeName           = K'iche
    /// Cultures             = qut-GT
    /// Countries            = Guatemala
    /// Country              = Guatemala
    /// 
    /// Code                 = Quz
    /// Name                 = quz
    /// EnglishName          = Quechua
    /// NativeName           = runasimi
    /// Cultures             = quz-BO, quz-EC, quz-PE
    /// Countries            = Bolivia, Ecuador, Peru
    /// Country              = Bolivia
    /// 
    /// Code                 = Rm
    /// Name                 = rm
    /// EnglishName          = Romansh
    /// NativeName           = Rumantsch
    /// Cultures             = rm-CH
    /// Countries            = Switzerland
    /// Country              = Switzerland
    /// 
    /// Code                 = Ro
    /// Name                 = ro
    /// EnglishName          = Romanian
    /// NativeName           = română
    /// Cultures             = ro-RO
    /// Countries            = Romania
    /// Country              = Romania
    /// 
    /// Code                 = Ru
    /// Name                 = ru
    /// EnglishName          = Russian
    /// NativeName           = русский
    /// Cultures             = ru-RU
    /// Countries            = Russia
    /// Country              = Russia
    /// 
    /// Code                 = Rw
    /// Name                 = rw
    /// EnglishName          = Kinyarwanda
    /// NativeName           = Kinyarwanda
    /// Cultures             = rw-RW
    /// Countries            = Rwanda
    /// Country              = Rwanda
    /// 
    /// Code                 = Sa
    /// Name                 = sa
    /// EnglishName          = Sanskrit
    /// NativeName           = संस्कृत
    /// Cultures             = sa-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Sah
    /// Name                 = sah
    /// EnglishName          = Yakut
    /// NativeName           = саха
    /// Cultures             = sah-RU
    /// Countries            = Russia
    /// Country              = Russia
    /// 
    /// Code                 = Se
    /// Name                 = se
    /// EnglishName          = Sami (Northern)
    /// NativeName           = davvisámegiella
    /// Cultures             = se-NO, se-SE, se-FI, smj-NO, smj-SE, sma-NO, sma-SE, sms-FI, smn-FI
    /// Countries            = Norway, Sweden, Finland
    /// Country              = Sweden
    /// 
    /// Code                 = Si
    /// Name                 = si
    /// EnglishName          = Sinhala
    /// NativeName           = සිංහල
    /// Cultures             = si-LK
    /// Countries            = Sri Lanka
    /// Country              = Sri Lanka
    /// 
    /// Code                 = Sk
    /// Name                 = sk
    /// EnglishName          = Slovak
    /// NativeName           = slovenčina
    /// Cultures             = sk-SK
    /// Countries            = Slovakia
    /// Country              = Slovakia
    /// 
    /// Code                 = Sl
    /// Name                 = sl
    /// EnglishName          = Slovenian
    /// NativeName           = slovenski
    /// Cultures             = sl-SI
    /// Countries            = Slovenia
    /// Country              = Slovenia
    /// 
    /// Code                 = Sq
    /// Name                 = sq
    /// EnglishName          = Albanian
    /// NativeName           = shqipe
    /// Cultures             = sq-AL
    /// Countries            = Albania
    /// Country              = Albania
    /// 
    /// Code                 = Sr
    /// Name                 = sr
    /// EnglishName          = Serbian
    /// NativeName           = srpski
    /// Cultures             = sr-Latn-CS, sr-Cyrl-CS, sr-Latn-BA, sr-Cyrl-BA, sr-Latn-RS, sr-Cyrl-RS, sr-Latn-ME, sr-Cyrl-ME
    /// Countries            = Serbia and Montenegro, Bosnia and Herzegovina, Serbia, Montenegro
    /// Country              = Serbia
    /// 
    /// Code                 = Sv
    /// Name                 = sv
    /// EnglishName          = Swedish
    /// NativeName           = svenska
    /// Cultures             = sv-SE, sv-FI
    /// Countries            = Sweden, Finland
    /// Country              = Sweden
    /// 
    /// Code                 = Sw
    /// Name                 = sw
    /// EnglishName          = Kiswahili
    /// NativeName           = Kiswahili
    /// Cultures             = sw-KE
    /// Countries            = Kenya
    /// Country              = Kenya
    /// 
    /// Code                 = Syr
    /// Name                 = syr
    /// EnglishName          = Syriac
    /// NativeName           = ܣܘܪܝܝܐ
    /// Cultures             = syr-SY
    /// Countries            = Syria
    /// Country              = Syria
    /// 
    /// Code                 = Ta
    /// Name                 = ta
    /// EnglishName          = Tamil
    /// NativeName           = தமிழ்
    /// Cultures             = ta-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Te
    /// Name                 = te
    /// EnglishName          = Telugu
    /// NativeName           = తెలుగు
    /// Cultures             = te-IN
    /// Countries            = India
    /// Country              = India
    /// 
    /// Code                 = Tg
    /// Name                 = tg
    /// EnglishName          = Tajik
    /// NativeName           = Тоҷикӣ
    /// Cultures             = tg-Cyrl-TJ
    /// Countries            = Tajikistan
    /// Country              = Tajikistan
    /// 
    /// Code                 = Th
    /// Name                 = th
    /// EnglishName          = Thai
    /// NativeName           = ไทย
    /// Cultures             = th-TH
    /// Countries            = Thailand
    /// Country              = Thailand
    /// 
    /// Code                 = Tk
    /// Name                 = tk
    /// EnglishName          = Turkmen
    /// NativeName           = türkmençe
    /// Cultures             = tk-TM
    /// Countries            = Turkmenistan
    /// Country              = Turkmenistan
    /// 
    /// Code                 = Tn
    /// Name                 = tn
    /// EnglishName          = Setswana
    /// NativeName           = Setswana
    /// Cultures             = tn-ZA
    /// Countries            = South Africa
    /// Country              = South Africa
    /// 
    /// Code                 = Tr
    /// Name                 = tr
    /// EnglishName          = Turkish
    /// NativeName           = Türkçe
    /// Cultures             = tr-TR
    /// Countries            = Turkey
    /// Country              = Turkey
    /// 
    /// Code                 = Tt
    /// Name                 = tt
    /// EnglishName          = Tatar
    /// NativeName           = Татар
    /// Cultures             = tt-RU
    /// Countries            = Russia
    /// Country              = Russia
    /// 
    /// Code                 = Tzm
    /// Name                 = tzm
    /// EnglishName          = Tamazight
    /// NativeName           = Tamazight
    /// Cultures             = tzm-Latn-DZ
    /// Countries            = Algeria
    /// Country              = Algeria
    /// 
    /// Code                 = Ug
    /// Name                 = ug
    /// EnglishName          = Uyghur
    /// NativeName           = ئۇيغۇرچە
    /// Cultures             = ug-CN
    /// Countries            = China
    /// Country              = China
    /// 
    /// Code                 = Uk
    /// Name                 = uk
    /// EnglishName          = Ukrainian
    /// NativeName           = українська
    /// Cultures             = uk-UA
    /// Countries            = Ukraine
    /// Country              = Ukraine
    /// 
    /// Code                 = Ur
    /// Name                 = ur
    /// EnglishName          = Urdu
    /// NativeName           = اُردو
    /// Cultures             = ur-PK
    /// Countries            = Pakistan
    /// Country              = Pakistan
    /// 
    /// Code                 = Uz
    /// Name                 = uz
    /// EnglishName          = Uzbek
    /// NativeName           = U'zbek
    /// Cultures             = uz-Latn-UZ, uz-Cyrl-UZ
    /// Countries            = Uzbekistan
    /// Country              = Uzbekistan
    /// 
    /// Code                 = Vi
    /// Name                 = vi
    /// EnglishName          = Vietnamese
    /// NativeName           = Tiếng Việt
    /// Cultures             = vi-VN
    /// Countries            = Vietnam
    /// Country              = Vietnam
    /// 
    /// Code                 = Wo
    /// Name                 = wo
    /// EnglishName          = Wolof
    /// NativeName           = Wolof
    /// Cultures             = wo-SN
    /// Countries            = Senegal
    /// Country              = Senegal
    /// 
    /// Code                 = Xh
    /// Name                 = xh
    /// EnglishName          = isiXhosa
    /// NativeName           = isiXhosa
    /// Cultures             = xh-ZA
    /// Countries            = South Africa
    /// Country              = South Africa
    /// 
    /// Code                 = Yo
    /// Name                 = yo
    /// EnglishName          = Yoruba
    /// NativeName           = Yoruba
    /// Cultures             = yo-NG
    /// Countries            = Nigeria
    /// Country              = Nigeria
    /// 
    /// Code                 = Zh
    /// Name                 = zh
    /// EnglishName          = Chinese
    /// NativeName           = 中文
    /// Cultures             = zh-TW, zh-CN, zh-HK, zh-SG, zh-MO
    /// Countries            = Taiwan, China, Hong Kong, Singapore, Macao
    /// Country              = China
    /// 
    /// Code                 = Zu
    /// Name                 = zu
    /// EnglishName          = isiZulu
    /// NativeName           = isiZulu
    /// Cultures             = zu-ZA
    /// Countries            = South Africa
    /// Country              = South Africa
    /// </remarks>
    public class LanguageInfo : CultureInfo
    {
        #region Fields

        /// <summary>
        /// Internal sorted dictionary with all available <see cref="LanguageInfo"/>s.
        /// </summary>
        private static readonly SortedDictionary<LanguageCode, LanguageInfo> _all = new SortedDictionary<LanguageCode, LanguageInfo>();

        /// <summary>
        /// Backing field for <see cref="Cultures"/>.
        /// </summary>
        private readonly List<CultureInfo> _cultures = new List<CultureInfo>();

        /// <summary>
        /// Backing field for <see cref="Countries"/>.
        /// </summary>
        private readonly List<CountryInfo> _countries = new List<CountryInfo>();

        #endregion

        #region Properties

        /// <summary>
        /// The language's <see cref="LanguageCode"/>.
        /// </summary>
        public LanguageCode Code
        {
            get;
            private set;
        }

        /// <summary>
        /// The language's origin, e.g. "France" for "French".
        /// </summary>
        /// <remarks>
        /// Is null for the invariant language (only). Is not null in all other cases, but may be incorrect. See <see cref="GetCountryForLanguage"/> for details.
        /// </remarks>
        public CountryInfo Country
        {
            get;
            private set;
        }

        /// <summary>
        /// Cultures using this language.
        /// </summary>
        /// <remarks>
        /// Returns a copy of the internal <see cref="CultureInfo"/> list. For performance reasons, cache this locally.
        /// </remarks>
        public List<CultureInfo> Cultures
        {
            get
            {
                return new List<CultureInfo>(_cultures);
            }
        }

        /// <summary>
        /// Countries where this language is spoken.
        /// </summary>
        /// <remarks>
        /// Returns a copy of the internal <see cref="CountryInfo"/> list. For performance reasons, cache this locally.
        /// </remarks>
        public List<CountryInfo> Countries
        {
            get
            {
                return new List<CountryInfo>(_countries);
            }
        }

        /// <summary>
        /// A sorted dictionary with all supported <see cref="LanguageInfo"/>s.
        /// </summary>
        /// <remarks>
        /// Returns a copy of the internal dictionary. For performance reasons, cache this locally.
        /// Also for performance reasons, do not use this property to get a specific <see cref="LanguageInfo"/>.
        /// Use <see cref="GetLanguage(LanguageCode)"/> instead.
        /// </remarks>
        public static SortedDictionary<LanguageCode, LanguageInfo> All
        {
            get
            {
                return new SortedDictionary<LanguageCode, LanguageInfo>(_all);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Static constructor
        /// </summary>
        static LanguageInfo()
        {
            // Fill all available languages
            foreach(CultureInfo cultureInfo in GetCultures(CultureTypes.NeutralCultures))
            {
                // Get root language, e.g. for chinese.
                CultureInfo culture = cultureInfo.GetRootCulture();
                LanguageCode languageCode = culture.GetLanguageCode();

                if(!_all.ContainsKey(languageCode))
                    _all.Add(languageCode, new LanguageInfo(culture.LCID, languageCode));
            }

            // Fill cultures and countries list
            foreach(CultureInfo cultureInfo in GetCultures(CultureTypes.SpecificCultures))
            {
                LanguageInfo languageInfo = cultureInfo.GetLanguage();
                languageInfo._cultures.Add(cultureInfo);

                CountryInfo countryInfo = cultureInfo.GetCountry();
                if(!languageInfo._countries.Contains(countryInfo))
                    languageInfo._countries.Add(countryInfo);

                // Find the country with the same name, e.g. "fr" for France and French.
                if(languageInfo.TwoLetterISOLanguageName.ToUpperInvariant() == countryInfo.TwoLetterISORegionName.ToUpperInvariant())
                    languageInfo.Country = countryInfo;
            }

            // Fill remaining Country properties with just the first country in the Countries list
            foreach(LanguageInfo languageInfo in _all.Values)
            {
                // Aleady filled before (see above).
                if(languageInfo.Country != null)
                    continue;

                // Handle ambiguities manually.
                CountryInfo country = GetCountryForLanguage(languageInfo.Code);
                if(country != null && languageInfo.Countries.Contains(country))
                {
                    languageInfo.Country = country;
                    continue;
                }

                // Not handled manually? Just take the first one, if present.
                if(languageInfo.Countries.Count > 0)
                    languageInfo.Country = languageInfo.Countries[0];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageInfo"/> class based on the language/region or specific culture, specified by identifier.
        /// </summary>
        /// <param name="culture">The culture identifier, <see cref="CultureInfo.LCID"/>.</param>
        /// <param name="languageCode">This language's corresponding <see cref="LanguageCode"/>.</param>
        private LanguageInfo(int culture, LanguageCode languageCode)
            : base(culture)
        {
            Code = languageCode;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets a <see cref="LanguageInfo"/> by its <paramref name="languageCode"/>.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="languageCode">The <see cref="LanguageCode"/> to get the <see cref="LanguageInfo"/> for.</param>
        /// <returns>The <see cref="LanguageInfo"/> corresponding to <paramref name="languageCode"/>.</returns>
        public static LanguageInfo GetLanguage(LanguageCode languageCode)
        {
            return _all[languageCode];
        }

        /// <summary>
        /// Dump some information about this <see cref="LanguageInfo"/>.
        /// </summary>
        /// <remarks>
        /// This is for example:
        /// 
        /// Code                 = Fr
        /// Name                 = fr
        /// EnglishName          = French
        /// NativeName           = français
        /// Cultures             = fr-FR, fr-BE, fr-CA, fr-CH, fr-LU, fr-MC
        /// Countries            = France, Belgium, Canada, Switzerland, Luxembourg, Monaco
        /// Country              = France
        /// </remarks>
        /// <param name="prefix">Prefix to use for every line, e.g. "/// ". Defaults to the empty string.</param>
        /// <returns>A string with some information about this <see cref="LanguageInfo"/></returns>
        public string Dump(string prefix = "")
        {
            const string format = "{0}{1, -20} = {2}";

            var sb = new StringBuilder();

            sb.AppendLine(string.Format(format, prefix, "Code", Code));
            sb.AppendLine(string.Format(format, prefix, "Name", Name));
            sb.AppendLine(string.Format(format, prefix, "EnglishName", EnglishName));
            sb.AppendLine(string.Format(format, prefix, "NativeName", NativeName));
            sb.AppendLine(string.Format(format, prefix, "Cultures", string.Join(", ", Cultures.Select(c => c.Name))));
            sb.AppendLine(string.Format(format, prefix, "Countries", string.Join(", ", Countries.Select(c => c.ShortEnglishName))));
            sb.AppendLine(string.Format(format, prefix, "Country", Country == null ? string.Empty : Country.ShortEnglishName));

            return sb.ToString();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Get the country where a language comes from.
        /// </summary>
        /// <remarks>
        /// For example for Englisch (<see cref="LanguageCode.En"/>) this is United Kingdom (<see cref="CountryCode.Gb"/>).
        /// In ambiguous cases, there was done some research, but it still may be incorrect.
        /// </remarks>
        /// <param name="languageCode">The <see cref="LanguageCode"/> to get the <see cref="CountryInfo"/> of the country where the language comes from.</param>
        /// <returns>The country where a language comes from or null when this is not handled here.</returns>
        private static CountryInfo GetCountryForLanguage(LanguageCode languageCode)
        {
            switch(languageCode)
            {
                // Arabic -> Saudi Arabia
                case LanguageCode.Ar:
                    return CountryInfo.GetCountry(CountryCode.Sa);

                // Bengali -> Bangladesh
                case LanguageCode.Bg:
                    return CountryInfo.GetCountry(CountryCode.Bd);

                // English -> United Kingdom
                case LanguageCode.En:
                    return CountryInfo.GetCountry(CountryCode.Gb);

                // Malay -> Malaysia
                case LanguageCode.Ms:
                    return CountryInfo.GetCountry(CountryCode.My);

                // Serbian -> Serbia
                case LanguageCode.Sr:
                    return CountryInfo.GetCountry(CountryCode.Rs);

                // Chinese -> China
                case LanguageCode.Zh:
                    return CountryInfo.GetCountry(CountryCode.Cn);
            }

            return null;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Whether another object is considered to be the same as this one
        /// </summary>
        /// <param name="obj">The object to compare</param>
        /// <returns>True = the other object is considered to be the same as this one, false otherwise</returns>
        public override bool Equals(object obj)
        {
            var other = obj as LanguageInfo;
            return other != null && other.Code == Code;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        /// <remarks>
        /// When overriding Equals (see above) GetHashCode has to be overridden ACCORDINGLY. From MSDN:
        /// 
        /// A hash function must have the following properties: 
        /// 
        /// a) If two objects compare as equal, the GetHashCode method for each object must return the same value. 
        /// However, if two objects do not compare as equal, the GetHashCode methods for the two object do not 
        /// have to return different values.
        /// 
        /// b) The GetHashCode method for an object must consistently return the same hash code as long as there 
        /// is no modification to the object state that determines the return value of the object's Equals 
        /// method. This is true only for the current execution of an application, and that a different 
        /// hash code can be returned if the application is run again.
        /// 
        /// Background is that hashtables use GetHashCode as the key. Roughly speaking, when Equals and GetHashCode do not 
        /// return consistent values, this can result in unpredictable behavior. See MSDN or internet for details.
        /// </remarks>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        #endregion
    }

    #endregion

    #region Enum LanguageCode

    /// <summary>
    /// All (parent) languages supported by the .Net framework.
    /// </summary>
    /// <remarks>
    /// Names are derived from <see cref="CultureInfo.TwoLetterISOLanguageName"/>, 
    /// which is the same as <see cref="CultureInfo.Name"/>.
    /// 
    /// For simplification, neither the way how they are written (e.g. latin or cyrillic) 
    /// nor regional dialects (e.g. northern sami, southern sami) are taken into account here. 
    /// Sub-cultures / sub-languages are mapped to their parents. 
    /// </remarks>
    public enum LanguageCode
    {
        /// <summary>
        /// Afrikaans
        /// </summary>
        Af,

        /// <summary>
        /// Amharic
        /// </summary>
        Am,

        /// <summary>
        /// Arabic
        /// </summary>
        Ar,

        /// <summary>
        /// Mapudungun
        /// </summary>
        Arn,

        /// <summary>
        /// Assamese
        /// </summary>
        As,

        /// <summary>
        /// Azeri
        /// </summary>
        Az,

        /// <summary>
        /// Bashkir
        /// </summary>
        Ba,

        /// <summary>
        /// Belarusian
        /// </summary>
        Be,

        /// <summary>
        /// Bulgarian
        /// </summary>
        Bg,

        /// <summary>
        /// Bengali
        /// </summary>
        Bn,

        /// <summary>
        /// Tibetan
        /// </summary>
        Bo,

        /// <summary>
        /// Breton
        /// </summary>
        Br,

        /// <summary>
        /// Bosnian
        /// </summary>
        Bs,

        /// <summary>
        /// Catalan
        /// </summary>
        Ca,

        /// <summary>
        /// Corsican
        /// </summary>
        Co,

        /// <summary>
        /// Czech
        /// </summary>
        Cs,

        /// <summary>
        /// Welsh
        /// </summary>
        Cy,

        /// <summary>
        /// Danish
        /// </summary>
        Da,

        /// <summary>
        /// German
        /// </summary>
        De,

        /// <summary>
        /// Divehi
        /// </summary>
        Dv,

        /// <summary>
        /// Greek
        /// </summary>
        El,

        /// <summary>
        /// English
        /// </summary>
        En,

        /// <summary>
        /// Spanish
        /// </summary>
        Es,

        /// <summary>
        /// Estonian
        /// </summary>
        Et,

        /// <summary>
        /// Basque
        /// </summary>
        Eu,

        /// <summary>
        /// Persian
        /// </summary>
        Fa,

        /// <summary>
        /// Finnish
        /// </summary>
        Fi,

        /// <summary>
        /// Filipino
        /// </summary>
        Fil,

        /// <summary>
        /// Faroese
        /// </summary>
        Fo,

        /// <summary>
        /// French
        /// </summary>
        Fr,

        /// <summary>
        /// Frisian
        /// </summary>
        Fy,

        /// <summary>
        /// Irish
        /// </summary>
        Ga,

        /// <summary>
        /// Scottish Gaelic
        /// </summary>
        Gd,

        /// <summary>
        /// Galician
        /// </summary>
        Gl,

        /// <summary>
        /// Alsatian
        /// </summary>
        Gsw,

        /// <summary>
        /// Gujarati
        /// </summary>
        Gu,

        /// <summary>
        /// Hausa
        /// </summary>
        Ha,

        /// <summary>
        /// Hebrew
        /// </summary>
        He,

        /// <summary>
        /// Hindi
        /// </summary>
        Hi,

        /// <summary>
        /// Croatian
        /// </summary>
        Hr,

        /// <summary>
        /// Upper Sorbian
        /// </summary>
        Hsb,

        /// <summary>
        /// Hungarian
        /// </summary>
        Hu,

        /// <summary>
        /// Armenian
        /// </summary>
        Hy,

        /// <summary>
        /// Indonesian
        /// </summary>
        Id,

        /// <summary>
        /// Igbo
        /// </summary>
        Ig,

        /// <summary>
        /// Yi
        /// </summary>
        Ii,

        /// <summary>
        /// Icelandic
        /// </summary>
        Is,

        /// <summary>
        /// Italian
        /// </summary>
        It,

        /// <summary>
        /// Inuktitut
        /// </summary>
        Iu,

        /// <summary>
        /// Invariant Language (Invariant Country)
        /// </summary>
        Iv,

        /// <summary>
        /// Japanese
        /// </summary>
        Ja,

        /// <summary>
        /// Georgian
        /// </summary>
        Ka,

        /// <summary>
        /// Kazakh
        /// </summary>
        Kk,

        /// <summary>
        /// Greenlandic
        /// </summary>
        Kl,

        /// <summary>
        /// Khmer
        /// </summary>
        Km,

        /// <summary>
        /// Kannada
        /// </summary>
        Kn,

        /// <summary>
        /// Korean
        /// </summary>
        Ko,

        /// <summary>
        /// Konkani
        /// </summary>
        Kok,

        /// <summary>
        /// Kyrgyz
        /// </summary>
        Ky,

        /// <summary>
        /// Luxembourgish
        /// </summary>
        Lb,

        /// <summary>
        /// Lao
        /// </summary>
        Lo,

        /// <summary>
        /// Lithuanian
        /// </summary>
        Lt,

        /// <summary>
        /// Latvian
        /// </summary>
        Lv,

        /// <summary>
        /// Maori
        /// </summary>
        Mi,

        /// <summary>
        /// Macedonian (FYROM)
        /// </summary>
        Mk,

        /// <summary>
        /// Malayalam
        /// </summary>
        Ml,

        /// <summary>
        /// Mongolian
        /// </summary>
        Mn,

        /// <summary>
        /// Mohawk
        /// </summary>
        Moh,

        /// <summary>
        /// Marathi
        /// </summary>
        Mr,

        /// <summary>
        /// Malay
        /// </summary>
        Ms,

        /// <summary>
        /// Maltese
        /// </summary>
        Mt,

        /// <summary>
        /// Norwegian
        /// </summary>
        Nb,

        /// <summary>
        /// Nepali
        /// </summary>
        Ne,

        /// <summary>
        /// Dutch
        /// </summary>
        Nl,

        /// <summary>
        /// Sesotho sa Leboa
        /// </summary>
        Nso,

        /// <summary>
        /// Occitan
        /// </summary>
        Oc,

        /// <summary>
        /// Oriya
        /// </summary>
        Or,

        /// <summary>
        /// Punjabi
        /// </summary>
        Pa,

        /// <summary>
        /// Polish
        /// </summary>
        Pl,

        /// <summary>
        /// Dari
        /// </summary>
        Prs,

        /// <summary>
        /// Pashto
        /// </summary>
        Ps,

        /// <summary>
        /// Portuguese
        /// </summary>
        Pt,

        /// <summary>
        /// K'iche
        /// </summary>
        Qut,

        /// <summary>
        /// Quechua
        /// </summary>
        Quz,

        /// <summary>
        /// Romansh
        /// </summary>
        Rm,

        /// <summary>
        /// Romanian
        /// </summary>
        Ro,

        /// <summary>
        /// Russian
        /// </summary>
        Ru,

        /// <summary>
        /// Kinyarwanda
        /// </summary>
        Rw,

        /// <summary>
        /// Sanskrit
        /// </summary>
        Sa,

        /// <summary>
        /// Yakut
        /// </summary>
        Sah,

        /// <summary>
        /// Sami (Northern)
        /// </summary>
        Se,

        /// <summary>
        /// Sinhala
        /// </summary>
        Si,

        /// <summary>
        /// Slovak
        /// </summary>
        Sk,

        /// <summary>
        /// Slovenian
        /// </summary>
        Sl,

        /// <summary>
        /// Albanian
        /// </summary>
        Sq,

        /// <summary>
        /// Serbian
        /// </summary>
        Sr,

        /// <summary>
        /// Swedish
        /// </summary>
        Sv,

        /// <summary>
        /// Kiswahili
        /// </summary>
        Sw,

        /// <summary>
        /// Syriac
        /// </summary>
        Syr,

        /// <summary>
        /// Tamil
        /// </summary>
        Ta,

        /// <summary>
        /// Telugu
        /// </summary>
        Te,

        /// <summary>
        /// Tajik
        /// </summary>
        Tg,

        /// <summary>
        /// Thai
        /// </summary>
        Th,

        /// <summary>
        /// Turkmen
        /// </summary>
        Tk,

        /// <summary>
        /// Setswana
        /// </summary>
        Tn,

        /// <summary>
        /// Turkish
        /// </summary>
        Tr,

        /// <summary>
        /// Tatar
        /// </summary>
        Tt,

        /// <summary>
        /// Tamazight
        /// </summary>
        Tzm,

        /// <summary>
        /// Uyghur
        /// </summary>
        Ug,

        /// <summary>
        /// Ukrainian
        /// </summary>
        Uk,

        /// <summary>
        /// Urdu
        /// </summary>
        Ur,

        /// <summary>
        /// Uzbek
        /// </summary>
        Uz,

        /// <summary>
        /// Vietnamese
        /// </summary>
        Vi,

        /// <summary>
        /// Wolof
        /// </summary>
        Wo,

        /// <summary>
        /// isiXhosa
        /// </summary>
        Xh,

        /// <summary>
        /// Yoruba
        /// </summary>
        Yo,

        /// <summary>
        /// Chinese
        /// </summary>
        Zh,

        /// <summary>
        /// isiZulu
        /// </summary>
        Zu,
    }

    #endregion
}