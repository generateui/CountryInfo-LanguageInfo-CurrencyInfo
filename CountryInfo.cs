using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CountryLanguageCurrency
{
    #region Class CountryInfo

    /// <summary>
    /// Class representing a country
    /// </summary>
    /// <remarks>
    /// 
    /// This is what <see cref="All"/> contains:
    /// 
    /// Code                 = Ae
    /// Name                 = AE
    /// EnglishName          = U.A.E.
    /// ShortEnglishName     = U.A.E.
    /// NativeName           = الإمارات العربية المتحدة
    /// Cultures             = ar-AE
    /// Culture              = ar-AE
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = UAE Dirham
    /// 
    /// Code                 = Af
    /// Name                 = AF
    /// EnglishName          = Afghanistan
    /// ShortEnglishName     = Afghanistan
    /// NativeName           = افغانستان
    /// Cultures             = ps-AF, prs-AF
    /// Culture              = ps-AF
    /// Languages            = Pashto, Dari
    /// Language             = Pashto
    /// Currency             = Afghani
    /// 
    /// Code                 = Al
    /// Name                 = AL
    /// EnglishName          = Albania
    /// ShortEnglishName     = Albania
    /// NativeName           = Shqipëria
    /// Cultures             = sq-AL
    /// Culture              = sq-AL
    /// Languages            = Albanian
    /// Language             = Albanian
    /// Currency             = Albanian Lek
    /// 
    /// Code                 = Am
    /// Name                 = AM
    /// EnglishName          = Armenia
    /// ShortEnglishName     = Armenia
    /// NativeName           = Հայաստան
    /// Cultures             = hy-AM
    /// Culture              = hy-AM
    /// Languages            = Armenian
    /// Language             = Armenian
    /// Currency             = Armenian Dram
    /// 
    /// Code                 = Ar
    /// Name                 = AR
    /// EnglishName          = Argentina
    /// ShortEnglishName     = Argentina
    /// NativeName           = Argentina
    /// Cultures             = es-AR
    /// Culture              = es-AR
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Argentine Peso
    /// 
    /// Code                 = At
    /// Name                 = AT
    /// EnglishName          = Austria
    /// ShortEnglishName     = Austria
    /// NativeName           = Österreich
    /// Cultures             = de-AT
    /// Culture              = de-AT
    /// Languages            = German
    /// Language             = German
    /// Currency             = Euro
    /// 
    /// Code                 = Au
    /// Name                 = AU
    /// EnglishName          = Australia
    /// ShortEnglishName     = Australia
    /// NativeName           = Australia
    /// Cultures             = en-AU
    /// Culture              = en-AU
    /// Languages            = English
    /// Language             = English
    /// Currency             = Australian Dollar
    /// 
    /// Code                 = Az
    /// Name                 = AZ
    /// EnglishName          = Azerbaijan
    /// ShortEnglishName     = Azerbaijan
    /// NativeName           = Azərbaycan
    /// Cultures             = az-Latn-AZ, az-Cyrl-AZ
    /// Culture              = az-Latn-AZ
    /// Languages            = Azeri
    /// Language             = Azeri
    /// Currency             = Azerbaijanian Manat
    /// 
    /// Code                 = Ba
    /// Name                 = BA
    /// EnglishName          = Bosnia and Herzegovina
    /// ShortEnglishName     = Bosnia and Herzegovina
    /// NativeName           = Bosna i Hercegovina
    /// Cultures             = hr-BA, bs-Latn-BA, sr-Latn-BA, sr-Cyrl-BA, bs-Cyrl-BA
    /// Culture              = hr-BA
    /// Languages            = Croatian, Bosnian, Serbian
    /// Language             = Croatian
    /// Currency             = Convertible Marks
    /// 
    /// Code                 = Bd
    /// Name                 = BD
    /// EnglishName          = Bangladesh
    /// ShortEnglishName     = Bangladesh
    /// NativeName           = বাংলাদেশ
    /// Cultures             = bn-BD
    /// Culture              = bn-BD
    /// Languages            = Bengali
    /// Language             = Bengali
    /// Currency             = Bangladeshi Taka
    /// 
    /// Code                 = Be
    /// Name                 = BE
    /// EnglishName          = Belgium
    /// ShortEnglishName     = Belgium
    /// NativeName           = Belgique
    /// Cultures             = fr-BE, nl-BE
    /// Culture              = fr-BE
    /// Languages            = French, Dutch
    /// Language             = French
    /// Currency             = Euro
    /// 
    /// Code                 = Bg
    /// Name                 = BG
    /// EnglishName          = Bulgaria
    /// ShortEnglishName     = Bulgaria
    /// NativeName           = България
    /// Cultures             = bg-BG
    /// Culture              = bg-BG
    /// Languages            = Bulgarian
    /// Language             = Bulgarian
    /// Currency             = Bulgarian Lev
    /// 
    /// Code                 = Bh
    /// Name                 = BH
    /// EnglishName          = Bahrain
    /// ShortEnglishName     = Bahrain
    /// NativeName           = البحرين
    /// Cultures             = ar-BH
    /// Culture              = ar-BH
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Bahraini Dinar
    /// 
    /// Code                 = Bn
    /// Name                 = BN
    /// EnglishName          = Brunei Darussalam
    /// ShortEnglishName     = Brunei
    /// NativeName           = Brunei Darussalam
    /// Cultures             = ms-BN
    /// Culture              = ms-BN
    /// Languages            = Malay
    /// Language             = Malay
    /// Currency             = Brunei Dollar
    /// 
    /// Code                 = Bo
    /// Name                 = BO
    /// EnglishName          = Bolivia
    /// ShortEnglishName     = Bolivia
    /// NativeName           = Bolivia
    /// Cultures             = es-BO
    /// Culture              = es-BO
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Boliviano
    /// 
    /// Code                 = Br
    /// Name                 = BR
    /// EnglishName          = Brazil
    /// ShortEnglishName     = Brazil
    /// NativeName           = Brasil
    /// Cultures             = pt-BR
    /// Culture              = pt-BR
    /// Languages            = Portuguese
    /// Language             = Portuguese
    /// Currency             = Real
    /// 
    /// Code                 = By
    /// Name                 = BY
    /// EnglishName          = Belarus
    /// ShortEnglishName     = Belarus
    /// NativeName           = Беларусь
    /// Cultures             = be-BY
    /// Culture              = be-BY
    /// Languages            = Belarusian
    /// Language             = Belarusian
    /// Currency             = Belarusian Ruble
    /// 
    /// Code                 = Bz
    /// Name                 = BZ
    /// EnglishName          = Belize
    /// ShortEnglishName     = Belize
    /// NativeName           = Belize
    /// Cultures             = en-BZ
    /// Culture              = en-BZ
    /// Languages            = English
    /// Language             = English
    /// Currency             = Belize Dollar
    /// 
    /// Code                 = Ca
    /// Name                 = CA
    /// EnglishName          = Canada
    /// ShortEnglishName     = Canada
    /// NativeName           = Canada
    /// Cultures             = en-CA, moh-CA, iu-Latn-CA, fr-CA
    /// Culture              = en-CA
    /// Languages            = English, Mohawk, Inuktitut, French
    /// Language             = English
    /// Currency             = Canadian Dollar
    /// 
    /// Code                 = Cb
    /// Name                 = 029
    /// EnglishName          = Caribbean
    /// ShortEnglishName     = Caribbean
    /// NativeName           = Caribbean
    /// Cultures             = en-029
    /// Culture              = en-029
    /// Languages            = English
    /// Language             = English
    /// Currency             = US Dollar
    /// 
    /// Code                 = Ch
    /// Name                 = CH
    /// EnglishName          = Switzerland
    /// ShortEnglishName     = Switzerland
    /// NativeName           = Schweiz
    /// Cultures             = de-CH, it-CH, fr-CH
    /// Culture              = de-CH
    /// Languages            = German, Italian, French
    /// Language             = German
    /// Currency             = Swiss Franc
    /// 
    /// Code                 = Cl
    /// Name                 = CL
    /// EnglishName          = Chile
    /// ShortEnglishName     = Chile
    /// NativeName           = Chile
    /// Cultures             = es-CL
    /// Culture              = es-CL
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Chilean Peso
    /// 
    /// Code                 = Cn
    /// Name                 = CN
    /// EnglishName          = People's Republic of China
    /// ShortEnglishName     = China
    /// NativeName           = 中华人民共和国
    /// Cultures             = zh-CN, ii-CN, ug-CN, mn-Mong-CN
    /// Culture              = zh-CN
    /// Languages            = Chinese, Yi, Uyghur, Mongolian
    /// Language             = Chinese
    /// Currency             = PRC Yuan Renminbi
    /// 
    /// Code                 = Co
    /// Name                 = CO
    /// EnglishName          = Colombia
    /// ShortEnglishName     = Colombia
    /// NativeName           = Colombia
    /// Cultures             = es-CO
    /// Culture              = es-CO
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Colombian Peso
    /// 
    /// Code                 = Cr
    /// Name                 = CR
    /// EnglishName          = Costa Rica
    /// ShortEnglishName     = Costa Rica
    /// NativeName           = Costa Rica
    /// Cultures             = es-CR
    /// Culture              = es-CR
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Costa Rican Colon
    /// 
    /// Code                 = Cs
    /// Name                 = CS
    /// EnglishName          = Serbia and Montenegro (Former)
    /// ShortEnglishName     = Serbia and Montenegro
    /// NativeName           = Srbija i Crna Gora (Prethodno)
    /// Cultures             = sr-Latn-CS, sr-Cyrl-CS
    /// Culture              = sr-Latn-CS
    /// Languages            = Serbian
    /// Language             = Serbian
    /// Currency             = Serbian Dinar
    /// 
    /// Code                 = Cz
    /// Name                 = CZ
    /// EnglishName          = Czech Republic
    /// ShortEnglishName     = Czech Republic
    /// NativeName           = Česká republika
    /// Cultures             = cs-CZ
    /// Culture              = cs-CZ
    /// Languages            = Czech
    /// Language             = Czech
    /// Currency             = Czech Koruna
    /// 
    /// Code                 = De
    /// Name                 = DE
    /// EnglishName          = Germany
    /// ShortEnglishName     = Germany
    /// NativeName           = Deutschland
    /// Cultures             = de-DE, hsb-DE, dsb-DE
    /// Culture              = de-DE
    /// Languages            = German, Upper Sorbian
    /// Language             = German
    /// Currency             = Euro
    /// 
    /// Code                 = Dk
    /// Name                 = DK
    /// EnglishName          = Denmark
    /// ShortEnglishName     = Denmark
    /// NativeName           = Danmark
    /// Cultures             = da-DK
    /// Culture              = da-DK
    /// Languages            = Danish
    /// Language             = Danish
    /// Currency             = Danish Krone
    /// 
    /// Code                 = Do
    /// Name                 = DO
    /// EnglishName          = Dominican Republic
    /// ShortEnglishName     = Dominican Republic
    /// NativeName           = República Dominicana
    /// Cultures             = es-DO
    /// Culture              = es-DO
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Dominican Peso
    /// 
    /// Code                 = Dz
    /// Name                 = DZ
    /// EnglishName          = Algeria
    /// ShortEnglishName     = Algeria
    /// NativeName           = الجزائر
    /// Cultures             = ar-DZ
    /// Culture              = ar-DZ
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Algerian Dinar
    /// 
    /// Code                 = Ec
    /// Name                 = EC
    /// EnglishName          = Ecuador
    /// ShortEnglishName     = Ecuador
    /// NativeName           = Ecuador
    /// Cultures             = es-EC
    /// Culture              = es-EC
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = US Dollar
    /// 
    /// Code                 = Ee
    /// Name                 = EE
    /// EnglishName          = Estonia
    /// ShortEnglishName     = Estonia
    /// NativeName           = Eesti
    /// Cultures             = et-EE
    /// Culture              = et-EE
    /// Languages            = Estonian
    /// Language             = Estonian
    /// Currency             = Euro
    /// 
    /// Code                 = Eg
    /// Name                 = EG
    /// EnglishName          = Egypt
    /// ShortEnglishName     = Egypt
    /// NativeName           = مصر
    /// Cultures             = ar-EG
    /// Culture              = ar-EG
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Egyptian Pound
    /// 
    /// Code                 = Es
    /// Name                 = ES
    /// EnglishName          = Spain
    /// ShortEnglishName     = Spain
    /// NativeName           = España
    /// Cultures             = es-ES, eu-ES, gl-ES
    /// Culture              = es-ES
    /// Languages            = Spanish, Basque, Galician
    /// Language             = Spanish
    /// Currency             = Euro
    /// 
    /// Code                 = Et
    /// Name                 = ET
    /// EnglishName          = Ethiopia
    /// ShortEnglishName     = Ethiopia
    /// NativeName           = ኢትዮጵያ
    /// Cultures             = am-ET
    /// Culture              = am-ET
    /// Languages            = Amharic
    /// Language             = Amharic
    /// Currency             = Ethiopian Birr
    /// 
    /// Code                 = Fi
    /// Name                 = FI
    /// EnglishName          = Finland
    /// ShortEnglishName     = Finland
    /// NativeName           = Suomi
    /// Cultures             = fi-FI, sv-FI, se-FI, sms-FI, smn-FI
    /// Culture              = fi-FI
    /// Languages            = Finnish, Swedish, Sami (Northern)
    /// Language             = Finnish
    /// Currency             = Euro
    /// 
    /// Code                 = Fo
    /// Name                 = FO
    /// EnglishName          = Faroe Islands
    /// ShortEnglishName     = Faroe Islands
    /// NativeName           = Føroyar
    /// Cultures             = fo-FO
    /// Culture              = fo-FO
    /// Languages            = Faroese
    /// Language             = Faroese
    /// Currency             = Danish Krone
    /// 
    /// Code                 = Fr
    /// Name                 = FR
    /// EnglishName          = France
    /// ShortEnglishName     = France
    /// NativeName           = France
    /// Cultures             = fr-FR, br-FR, oc-FR, co-FR, gsw-FR
    /// Culture              = fr-FR
    /// Languages            = French, Breton, Occitan, Corsican, Alsatian
    /// Language             = French
    /// Currency             = Euro
    /// 
    /// Code                 = Gb
    /// Name                 = GB
    /// EnglishName          = United Kingdom
    /// ShortEnglishName     = United Kingdom
    /// NativeName           = United Kingdom
    /// Cultures             = en-GB, gd-GB
    /// Culture              = en-GB
    /// Languages            = English, Scottish Gaelic
    /// Language             = English
    /// Currency             = UK Pound Sterling
    /// 
    /// Code                 = Ge
    /// Name                 = GE
    /// EnglishName          = Georgia
    /// ShortEnglishName     = Georgia
    /// NativeName           = საქართველო
    /// Cultures             = ka-GE
    /// Culture              = ka-GE
    /// Languages            = Georgian
    /// Language             = Georgian
    /// Currency             = Lari
    /// 
    /// Code                 = Gl
    /// Name                 = GL
    /// EnglishName          = Greenland
    /// ShortEnglishName     = Greenland
    /// NativeName           = Kalaallit Nunaat
    /// Cultures             = kl-GL
    /// Culture              = kl-GL
    /// Languages            = Greenlandic
    /// Language             = Greenlandic
    /// Currency             = Danish Krone
    /// 
    /// Code                 = Gr
    /// Name                 = GR
    /// EnglishName          = Greece
    /// ShortEnglishName     = Greece
    /// NativeName           = Ελλάδα
    /// Cultures             = el-GR
    /// Culture              = el-GR
    /// Languages            = Greek
    /// Language             = Greek
    /// Currency             = Euro
    /// 
    /// Code                 = Gt
    /// Name                 = GT
    /// EnglishName          = Guatemala
    /// ShortEnglishName     = Guatemala
    /// NativeName           = Guatemala
    /// Cultures             = es-GT
    /// Culture              = es-GT
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Guatemalan Quetzal
    /// 
    /// Code                 = Hk
    /// Name                 = HK
    /// EnglishName          = Hong Kong S.A.R.
    /// ShortEnglishName     = Hong Kong
    /// NativeName           = 香港特別行政區
    /// Cultures             = zh-HK
    /// Culture              = zh-HK
    /// Languages            = Chinese
    /// Language             = Chinese
    /// Currency             = Hong Kong Dollar
    /// 
    /// Code                 = Hn
    /// Name                 = HN
    /// EnglishName          = Honduras
    /// ShortEnglishName     = Honduras
    /// NativeName           = Honduras
    /// Cultures             = es-HN
    /// Culture              = es-HN
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Honduran Lempira
    /// 
    /// Code                 = Hr
    /// Name                 = HR
    /// EnglishName          = Croatia
    /// ShortEnglishName     = Croatia
    /// NativeName           = Hrvatska
    /// Cultures             = hr-HR
    /// Culture              = hr-HR
    /// Languages            = Croatian
    /// Language             = Croatian
    /// Currency             = Croatian Kuna
    /// 
    /// Code                 = Hu
    /// Name                 = HU
    /// EnglishName          = Hungary
    /// ShortEnglishName     = Hungary
    /// NativeName           = Magyarország
    /// Cultures             = hu-HU
    /// Culture              = hu-HU
    /// Languages            = Hungarian
    /// Language             = Hungarian
    /// Currency             = Hungarian Forint
    /// 
    /// Code                 = Id
    /// Name                 = ID
    /// EnglishName          = Indonesia
    /// ShortEnglishName     = Indonesia
    /// NativeName           = Indonesia
    /// Cultures             = id-ID
    /// Culture              = id-ID
    /// Languages            = Indonesian
    /// Language             = Indonesian
    /// Currency             = Indonesian Rupiah
    /// 
    /// Code                 = Ie
    /// Name                 = IE
    /// EnglishName          = Ireland
    /// ShortEnglishName     = Ireland
    /// NativeName           = Éire
    /// Cultures             = ga-IE, en-IE
    /// Culture              = ga-IE
    /// Languages            = Irish, English
    /// Language             = Irish
    /// Currency             = Euro
    /// 
    /// Code                 = Il
    /// Name                 = IL
    /// EnglishName          = Israel
    /// ShortEnglishName     = Israel
    /// NativeName           = ישראל
    /// Cultures             = he-IL
    /// Culture              = he-IL
    /// Languages            = Hebrew
    /// Language             = Hebrew
    /// Currency             = Israeli New Shekel
    /// 
    /// Code                 = In
    /// Name                 = IN
    /// EnglishName          = India
    /// ShortEnglishName     = India
    /// NativeName           = भारत
    /// Cultures             = hi-IN, bn-IN, pa-IN, gu-IN, or-IN, ta-IN, te-IN, kn-IN, ml-IN, as-IN, mr-IN, sa-IN, kok-IN, en-IN
    /// Culture              = hi-IN
    /// Languages            = Hindi, Bengali, Punjabi, Gujarati, Oriya, Tamil, Telugu, Kannada, Malayalam, Assamese, Marathi, Sanskrit, Konkani, English
    /// Language             = Hindi
    /// Currency             = Indian Rupee
    /// 
    /// Code                 = Iq
    /// Name                 = IQ
    /// EnglishName          = Iraq
    /// ShortEnglishName     = Iraq
    /// NativeName           = العراق
    /// Cultures             = ar-IQ
    /// Culture              = ar-IQ
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Iraqi Dinar
    /// 
    /// Code                 = Ir
    /// Name                 = IR
    /// EnglishName          = Iran
    /// ShortEnglishName     = Iran
    /// NativeName           = ایران
    /// Cultures             = fa-IR
    /// Culture              = fa-IR
    /// Languages            = Persian
    /// Language             = Persian
    /// Currency             = Iranian Rial
    /// 
    /// Code                 = Is
    /// Name                 = IS
    /// EnglishName          = Iceland
    /// ShortEnglishName     = Iceland
    /// NativeName           = Ísland
    /// Cultures             = is-IS
    /// Culture              = is-IS
    /// Languages            = Icelandic
    /// Language             = Icelandic
    /// Currency             = Icelandic Krona
    /// 
    /// Code                 = It
    /// Name                 = IT
    /// EnglishName          = Italy
    /// ShortEnglishName     = Italy
    /// NativeName           = Italia
    /// Cultures             = it-IT
    /// Culture              = it-IT
    /// Languages            = Italian
    /// Language             = Italian
    /// Currency             = Euro
    /// 
    /// Code                 = Jm
    /// Name                 = JM
    /// EnglishName          = Jamaica
    /// ShortEnglishName     = Jamaica
    /// NativeName           = Jamaica
    /// Cultures             = en-JM
    /// Culture              = en-JM
    /// Languages            = English
    /// Language             = English
    /// Currency             = Jamaican Dollar
    /// 
    /// Code                 = Jo
    /// Name                 = JO
    /// EnglishName          = Jordan
    /// ShortEnglishName     = Jordan
    /// NativeName           = الأردن
    /// Cultures             = ar-JO
    /// Culture              = ar-JO
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Jordanian Dinar
    /// 
    /// Code                 = Jp
    /// Name                 = JP
    /// EnglishName          = Japan
    /// ShortEnglishName     = Japan
    /// NativeName           = 日本
    /// Cultures             = ja-JP
    /// Culture              = ja-JP
    /// Languages            = Japanese
    /// Language             = Japanese
    /// Currency             = Japanese Yen
    /// 
    /// Code                 = Ke
    /// Name                 = KE
    /// EnglishName          = Kenya
    /// ShortEnglishName     = Kenya
    /// NativeName           = Kenya
    /// Cultures             = sw-KE
    /// Culture              = sw-KE
    /// Languages            = Kiswahili
    /// Language             = Kiswahili
    /// Currency             = Kenyan Shilling
    /// 
    /// Code                 = Kg
    /// Name                 = KG
    /// EnglishName          = Kyrgyzstan
    /// ShortEnglishName     = Kyrgyzstan
    /// NativeName           = Кыргызстан
    /// Cultures             = ky-KG
    /// Culture              = ky-KG
    /// Languages            = Kyrgyz
    /// Language             = Kyrgyz
    /// Currency             = som
    /// 
    /// Code                 = Kh
    /// Name                 = KH
    /// EnglishName          = Cambodia
    /// ShortEnglishName     = Cambodia
    /// NativeName           = កម្ពុជា
    /// Cultures             = km-KH
    /// Culture              = km-KH
    /// Languages            = Khmer
    /// Language             = Khmer
    /// Currency             = Riel
    /// 
    /// Code                 = Kr
    /// Name                 = KR
    /// EnglishName          = Korea
    /// ShortEnglishName     = Korea
    /// NativeName           = 대한민국
    /// Cultures             = ko-KR
    /// Culture              = ko-KR
    /// Languages            = Korean
    /// Language             = Korean
    /// Currency             = Korean Won
    /// 
    /// Code                 = Kw
    /// Name                 = KW
    /// EnglishName          = Kuwait
    /// ShortEnglishName     = Kuwait
    /// NativeName           = الكويت
    /// Cultures             = ar-KW
    /// Culture              = ar-KW
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Kuwaiti Dinar
    /// 
    /// Code                 = Kz
    /// Name                 = KZ
    /// EnglishName          = Kazakhstan
    /// ShortEnglishName     = Kazakhstan
    /// NativeName           = Қазақстан
    /// Cultures             = kk-KZ
    /// Culture              = kk-KZ
    /// Languages            = Kazakh
    /// Language             = Kazakh
    /// Currency             = Tenge
    /// 
    /// Code                 = La
    /// Name                 = LA
    /// EnglishName          = Lao P.D.R.
    /// ShortEnglishName     = Laos
    /// NativeName           = ສ.ປ.ປ. ລາວ
    /// Cultures             = lo-LA
    /// Culture              = lo-LA
    /// Languages            = Lao
    /// Language             = Lao
    /// Currency             = Kip
    /// 
    /// Code                 = Lb
    /// Name                 = LB
    /// EnglishName          = Lebanon
    /// ShortEnglishName     = Lebanon
    /// NativeName           = لبنان
    /// Cultures             = ar-LB
    /// Culture              = ar-LB
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Lebanese Pound
    /// 
    /// Code                 = Li
    /// Name                 = LI
    /// EnglishName          = Liechtenstein
    /// ShortEnglishName     = Liechtenstein
    /// NativeName           = Liechtenstein
    /// Cultures             = de-LI
    /// Culture              = de-LI
    /// Languages            = German
    /// Language             = German
    /// Currency             = Swiss Franc
    /// 
    /// Code                 = Lk
    /// Name                 = LK
    /// EnglishName          = Sri Lanka
    /// ShortEnglishName     = Sri Lanka
    /// NativeName           = ශ්‍රී ලංකා
    /// Cultures             = si-LK
    /// Culture              = si-LK
    /// Languages            = Sinhala
    /// Language             = Sinhala
    /// Currency             = Sri Lanka Rupee
    /// 
    /// Code                 = Lt
    /// Name                 = LT
    /// EnglishName          = Lithuania
    /// ShortEnglishName     = Lithuania
    /// NativeName           = Lietuva
    /// Cultures             = lt-LT
    /// Culture              = lt-LT
    /// Languages            = Lithuanian
    /// Language             = Lithuanian
    /// Currency             = Lithuanian Litas
    /// 
    /// Code                 = Lu
    /// Name                 = LU
    /// EnglishName          = Luxembourg
    /// ShortEnglishName     = Luxembourg
    /// NativeName           = Luxembourg
    /// Cultures             = lb-LU, de-LU, fr-LU
    /// Culture              = lb-LU
    /// Languages            = Luxembourgish, German, French
    /// Language             = Luxembourgish
    /// Currency             = Euro
    /// 
    /// Code                 = Lv
    /// Name                 = LV
    /// EnglishName          = Latvia
    /// ShortEnglishName     = Latvia
    /// NativeName           = Latvija
    /// Cultures             = lv-LV
    /// Culture              = lv-LV
    /// Languages            = Latvian
    /// Language             = Latvian
    /// Currency             = Euro
    /// 
    /// Code                 = Ly
    /// Name                 = LY
    /// EnglishName          = Libya
    /// ShortEnglishName     = Libya
    /// NativeName           = ليبيا
    /// Cultures             = ar-LY
    /// Culture              = ar-LY
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Libyan Dinar
    /// 
    /// Code                 = Ma
    /// Name                 = MA
    /// EnglishName          = Morocco
    /// ShortEnglishName     = Morocco
    /// NativeName           = المملكة المغربية
    /// Cultures             = ar-MA
    /// Culture              = ar-MA
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Moroccan Dirham
    /// 
    /// Code                 = Mc
    /// Name                 = MC
    /// EnglishName          = Principality of Monaco
    /// ShortEnglishName     = Monaco
    /// NativeName           = Principauté de Monaco
    /// Cultures             = fr-MC
    /// Culture              = fr-MC
    /// Languages            = French
    /// Language             = French
    /// Currency             = Euro
    /// 
    /// Code                 = Me
    /// Name                 = ME
    /// EnglishName          = Montenegro
    /// ShortEnglishName     = Montenegro
    /// NativeName           = Crna Gora
    /// Cultures             = sr-Latn-ME, sr-Cyrl-ME
    /// Culture              = sr-Latn-ME
    /// Languages            = Serbian
    /// Language             = Serbian
    /// Currency             = Euro
    /// 
    /// Code                 = Mk
    /// Name                 = MK
    /// EnglishName          = Macedonia (FYROM)
    /// ShortEnglishName     = Macedonia
    /// NativeName           = Македонија
    /// Cultures             = mk-MK
    /// Culture              = mk-MK
    /// Languages            = Macedonian (FYROM)
    /// Language             = Macedonian (FYROM)
    /// Currency             = Macedonian Denar
    /// 
    /// Code                 = Mn
    /// Name                 = MN
    /// EnglishName          = Mongolia
    /// ShortEnglishName     = Mongolia
    /// NativeName           = Монгол улс
    /// Cultures             = mn-MN
    /// Culture              = mn-MN
    /// Languages            = Mongolian
    /// Language             = Mongolian
    /// Currency             = Tugrik
    /// 
    /// Code                 = Mo
    /// Name                 = MO
    /// EnglishName          = Macao S.A.R.
    /// ShortEnglishName     = Macao
    /// NativeName           = 澳門特別行政區
    /// Cultures             = zh-MO
    /// Culture              = zh-MO
    /// Languages            = Chinese
    /// Language             = Chinese
    /// Currency             = Macao Pataca
    /// 
    /// Code                 = Mt
    /// Name                 = MT
    /// EnglishName          = Malta
    /// ShortEnglishName     = Malta
    /// NativeName           = Malta
    /// Cultures             = mt-MT
    /// Culture              = mt-MT
    /// Languages            = Maltese
    /// Language             = Maltese
    /// Currency             = Euro
    /// 
    /// Code                 = Mv
    /// Name                 = MV
    /// EnglishName          = Maldives
    /// ShortEnglishName     = Maldives
    /// NativeName           = ދިވެހި ރާއްޖެ
    /// Cultures             = dv-MV
    /// Culture              = dv-MV
    /// Languages            = Divehi
    /// Language             = Divehi
    /// Currency             = Rufiyaa
    /// 
    /// Code                 = Mx
    /// Name                 = MX
    /// EnglishName          = Mexico
    /// ShortEnglishName     = Mexico
    /// NativeName           = México
    /// Cultures             = es-MX
    /// Culture              = es-MX
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Mexican Peso
    /// 
    /// Code                 = My
    /// Name                 = MY
    /// EnglishName          = Malaysia
    /// ShortEnglishName     = Malaysia
    /// NativeName           = Malaysia
    /// Cultures             = ms-MY, en-MY
    /// Culture              = ms-MY
    /// Languages            = Malay, English
    /// Language             = Malay
    /// Currency             = Malaysian Ringgit
    /// 
    /// Code                 = Ng
    /// Name                 = NG
    /// EnglishName          = Nigeria
    /// ShortEnglishName     = Nigeria
    /// NativeName           = Nigeria
    /// Cultures             = ha-Latn-NG, yo-NG, ig-NG
    /// Culture              = ha-Latn-NG
    /// Languages            = Hausa, Yoruba, Igbo
    /// Language             = Hausa
    /// Currency             = Nigerian Naira
    /// 
    /// Code                 = Ni
    /// Name                 = NI
    /// EnglishName          = Nicaragua
    /// ShortEnglishName     = Nicaragua
    /// NativeName           = Nicaragua
    /// Cultures             = es-NI
    /// Culture              = es-NI
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Nigerian Naira
    /// 
    /// Code                 = Nl
    /// Name                 = NL
    /// EnglishName          = Netherlands
    /// ShortEnglishName     = Netherlands
    /// NativeName           = Nederland
    /// Cultures             = nl-NL, fy-NL
    /// Culture              = nl-NL
    /// Languages            = Dutch, Frisian
    /// Language             = Dutch
    /// Currency             = Euro
    /// 
    /// Code                 = No
    /// Name                 = NO
    /// EnglishName          = Norway
    /// ShortEnglishName     = Norway
    /// NativeName           = Norge
    /// Cultures             = nb-NO, se-NO, nn-NO, smj-NO, sma-NO
    /// Culture              = nb-NO
    /// Languages            = Norwegian, Sami (Northern)
    /// Language             = Norwegian
    /// Currency             = Norwegian Krone
    /// 
    /// Code                 = Np
    /// Name                 = NP
    /// EnglishName          = Nepal
    /// ShortEnglishName     = Nepal
    /// NativeName           = नेपाल
    /// Cultures             = ne-NP
    /// Culture              = ne-NP
    /// Languages            = Nepali
    /// Language             = Nepali
    /// Currency             = Nepalese Rupees
    /// 
    /// Code                 = Nz
    /// Name                 = NZ
    /// EnglishName          = New Zealand
    /// ShortEnglishName     = New Zealand
    /// NativeName           = New Zealand
    /// Cultures             = en-NZ
    /// Culture              = en-NZ
    /// Languages            = English
    /// Language             = English
    /// Currency             = New Zealand Dollar
    /// 
    /// Code                 = Om
    /// Name                 = OM
    /// EnglishName          = Oman
    /// ShortEnglishName     = Oman
    /// NativeName           = عمان
    /// Cultures             = ar-OM
    /// Culture              = ar-OM
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Omani Rial
    /// 
    /// Code                 = Pa
    /// Name                 = PA
    /// EnglishName          = Panama
    /// ShortEnglishName     = Panama
    /// NativeName           = Panamá
    /// Cultures             = es-PA
    /// Culture              = es-PA
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Panamanian Balboa
    /// 
    /// Code                 = Pe
    /// Name                 = PE
    /// EnglishName          = Peru
    /// ShortEnglishName     = Peru
    /// NativeName           = Perú
    /// Cultures             = es-PE
    /// Culture              = es-PE
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Peruvian Nuevo Sol
    /// 
    /// Code                 = Ph
    /// Name                 = PH
    /// EnglishName          = Philippines
    /// ShortEnglishName     = Philippines
    /// NativeName           = Pilipinas
    /// Cultures             = fil-PH, en-PH
    /// Culture              = fil-PH
    /// Languages            = Filipino, English
    /// Language             = Filipino
    /// Currency             = Philippine Peso
    /// 
    /// Code                 = Pk
    /// Name                 = PK
    /// EnglishName          = Islamic Republic of Pakistan
    /// ShortEnglishName     = Pakistan
    /// NativeName           = پاکستان
    /// Cultures             = ur-PK
    /// Culture              = ur-PK
    /// Languages            = Urdu
    /// Language             = Urdu
    /// Currency             = Pakistan Rupee
    /// 
    /// Code                 = Pl
    /// Name                 = PL
    /// EnglishName          = Poland
    /// ShortEnglishName     = Poland
    /// NativeName           = Polska
    /// Cultures             = pl-PL
    /// Culture              = pl-PL
    /// Languages            = Polish
    /// Language             = Polish
    /// Currency             = Polish Zloty
    /// 
    /// Code                 = Pr
    /// Name                 = PR
    /// EnglishName          = Puerto Rico
    /// ShortEnglishName     = Puerto Rico
    /// NativeName           = Puerto Rico
    /// Cultures             = es-PR
    /// Culture              = es-PR
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = US Dollar
    /// 
    /// Code                 = Pt
    /// Name                 = PT
    /// EnglishName          = Portugal
    /// ShortEnglishName     = Portugal
    /// NativeName           = Portugal
    /// Cultures             = pt-PT
    /// Culture              = pt-PT
    /// Languages            = Portuguese
    /// Language             = Portuguese
    /// Currency             = Euro
    /// 
    /// Code                 = Py
    /// Name                 = PY
    /// EnglishName          = Paraguay
    /// ShortEnglishName     = Paraguay
    /// NativeName           = Paraguay
    /// Cultures             = es-PY
    /// Culture              = es-PY
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Paraguay Guarani
    /// 
    /// Code                 = Qa
    /// Name                 = QA
    /// EnglishName          = Qatar
    /// ShortEnglishName     = Qatar
    /// NativeName           = قطر
    /// Cultures             = ar-QA
    /// Culture              = ar-QA
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Qatari Rial
    /// 
    /// Code                 = Ro
    /// Name                 = RO
    /// EnglishName          = Romania
    /// ShortEnglishName     = Romania
    /// NativeName           = România
    /// Cultures             = ro-RO
    /// Culture              = ro-RO
    /// Languages            = Romanian
    /// Language             = Romanian
    /// Currency             = Romanian Leu
    /// 
    /// Code                 = Rs
    /// Name                 = RS
    /// EnglishName          = Serbia
    /// ShortEnglishName     = Serbia
    /// NativeName           = Srbija
    /// Cultures             = sr-Latn-RS, sr-Cyrl-RS
    /// Culture              = sr-Latn-RS
    /// Languages            = Serbian
    /// Language             = Serbian
    /// Currency             = Serbian Dinar
    /// 
    /// Code                 = Ru
    /// Name                 = RU
    /// EnglishName          = Russia
    /// ShortEnglishName     = Russia
    /// NativeName           = Россия
    /// Cultures             = ru-RU, tt-RU, ba-RU, sah-RU
    /// Culture              = ru-RU
    /// Languages            = Russian, Tatar, Bashkir, Yakut
    /// Language             = Russian
    /// Currency             = Russian Ruble
    /// 
    /// Code                 = Rw
    /// Name                 = RW
    /// EnglishName          = Rwanda
    /// ShortEnglishName     = Rwanda
    /// NativeName           = Rwanda
    /// Cultures             = rw-RW
    /// Culture              = rw-RW
    /// Languages            = Kinyarwanda
    /// Language             = Kinyarwanda
    /// Currency             = Rwandan Franc
    /// 
    /// Code                 = Sa
    /// Name                 = SA
    /// EnglishName          = Saudi Arabia
    /// ShortEnglishName     = Saudi Arabia
    /// NativeName           = المملكة العربية السعودية
    /// Cultures             = ar-SA
    /// Culture              = ar-SA
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Saudi Riyal
    /// 
    /// Code                 = Se
    /// Name                 = SE
    /// EnglishName          = Sweden
    /// ShortEnglishName     = Sweden
    /// NativeName           = Sverige
    /// Cultures             = sv-SE, se-SE, smj-SE, sma-SE
    /// Culture              = sv-SE
    /// Languages            = Swedish, Sami (Northern)
    /// Language             = Swedish
    /// Currency             = Swedish Krona
    /// 
    /// Code                 = Sg
    /// Name                 = SG
    /// EnglishName          = Singapore
    /// ShortEnglishName     = Singapore
    /// NativeName           = 新加坡
    /// Cultures             = zh-SG, en-SG
    /// Culture              = zh-SG
    /// Languages            = Chinese, English
    /// Language             = Chinese
    /// Currency             = Singapore Dollar
    /// 
    /// Code                 = Si
    /// Name                 = SI
    /// EnglishName          = Slovenia
    /// ShortEnglishName     = Slovenia
    /// NativeName           = Slovenija
    /// Cultures             = sl-SI
    /// Culture              = sl-SI
    /// Languages            = Slovenian
    /// Language             = Slovenian
    /// Currency             = Euro
    /// 
    /// Code                 = Sk
    /// Name                 = SK
    /// EnglishName          = Slovakia
    /// ShortEnglishName     = Slovakia
    /// NativeName           = Slovenská republika
    /// Cultures             = sk-SK
    /// Culture              = sk-SK
    /// Languages            = Slovak
    /// Language             = Slovak
    /// Currency             = Euro
    /// 
    /// Code                 = Sn
    /// Name                 = SN
    /// EnglishName          = Senegal
    /// ShortEnglishName     = Senegal
    /// NativeName           = Sénégal
    /// Cultures             = wo-SN
    /// Culture              = wo-SN
    /// Languages            = Wolof
    /// Language             = Wolof
    /// Currency             = XOF Senegal
    /// 
    /// Code                 = Sv
    /// Name                 = SV
    /// EnglishName          = El Salvador
    /// ShortEnglishName     = El Salvador
    /// NativeName           = El Salvador
    /// Cultures             = es-SV
    /// Culture              = es-SV
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = US Dollar
    /// 
    /// Code                 = Sy
    /// Name                 = SY
    /// EnglishName          = Syria
    /// ShortEnglishName     = Syria
    /// NativeName           = سوريا
    /// Cultures             = ar-SY
    /// Culture              = ar-SY
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Syrian Pound
    /// 
    /// Code                 = Th
    /// Name                 = TH
    /// EnglishName          = Thailand
    /// ShortEnglishName     = Thailand
    /// NativeName           = ไทย
    /// Cultures             = th-TH
    /// Culture              = th-TH
    /// Languages            = Thai
    /// Language             = Thai
    /// Currency             = Thai Baht
    /// 
    /// Code                 = Tj
    /// Name                 = TJ
    /// EnglishName          = Tajikistan
    /// ShortEnglishName     = Tajikistan
    /// NativeName           = Тоҷикистон
    /// Cultures             = tg-Cyrl-TJ
    /// Culture              = tg-Cyrl-TJ
    /// Languages            = Tajik
    /// Language             = Tajik
    /// Currency             = Ruble
    /// 
    /// Code                 = Tm
    /// Name                 = TM
    /// EnglishName          = Turkmenistan
    /// ShortEnglishName     = Turkmenistan
    /// NativeName           = Türkmenistan
    /// Cultures             = tk-TM
    /// Culture              = tk-TM
    /// Languages            = Turkmen
    /// Language             = Turkmen
    /// Currency             = Turkmen manat
    /// 
    /// Code                 = Tn
    /// Name                 = TN
    /// EnglishName          = Tunisia
    /// ShortEnglishName     = Tunisia
    /// NativeName           = تونس
    /// Cultures             = ar-TN
    /// Culture              = ar-TN
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Tunisian Dinar
    /// 
    /// Code                 = Tr
    /// Name                 = TR
    /// EnglishName          = Turkey
    /// ShortEnglishName     = Turkey
    /// NativeName           = Türkiye
    /// Cultures             = tr-TR
    /// Culture              = tr-TR
    /// Languages            = Turkish
    /// Language             = Turkish
    /// Currency             = Turkish Lira
    /// 
    /// Code                 = Tt
    /// Name                 = TT
    /// EnglishName          = Trinidad and Tobago
    /// ShortEnglishName     = Trinidad and Tobago
    /// NativeName           = Trinidad y Tobago
    /// Cultures             = en-TT
    /// Culture              = en-TT
    /// Languages            = English
    /// Language             = English
    /// Currency             = Trinidad Dollar
    /// 
    /// Code                 = Tw
    /// Name                 = TW
    /// EnglishName          = Taiwan
    /// ShortEnglishName     = Taiwan
    /// NativeName           = 台灣
    /// Cultures             = zh-TW
    /// Culture              = zh-TW
    /// Languages            = Chinese
    /// Language             = Chinese
    /// Currency             = New Taiwan Dollar
    /// 
    /// Code                 = Ua
    /// Name                 = UA
    /// EnglishName          = Ukraine
    /// ShortEnglishName     = Ukraine
    /// NativeName           = Україна
    /// Cultures             = uk-UA
    /// Culture              = uk-UA
    /// Languages            = Ukrainian
    /// Language             = Ukrainian
    /// Currency             = Ukrainian Grivna
    /// 
    /// Code                 = Us
    /// Name                 = US
    /// EnglishName          = United States
    /// ShortEnglishName     = United States
    /// NativeName           = United States
    /// Cultures             = en-US, es-US
    /// Culture              = en-US
    /// Languages            = English, Spanish
    /// Language             = English
    /// Currency             = US Dollar
    /// 
    /// Code                 = Uy
    /// Name                 = UY
    /// EnglishName          = Uruguay
    /// ShortEnglishName     = Uruguay
    /// NativeName           = Uruguay
    /// Cultures             = es-UY
    /// Culture              = es-UY
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Peso Uruguayo
    /// 
    /// Code                 = Uz
    /// Name                 = UZ
    /// EnglishName          = Uzbekistan
    /// ShortEnglishName     = Uzbekistan
    /// NativeName           = U'zbekiston Respublikasi
    /// Cultures             = uz-Latn-UZ, uz-Cyrl-UZ
    /// Culture              = uz-Latn-UZ
    /// Languages            = Uzbek
    /// Language             = Uzbek
    /// Currency             = Uzbekistan Som
    /// 
    /// Code                 = Ve
    /// Name                 = VE
    /// EnglishName          = Bolivarian Republic of Venezuela
    /// ShortEnglishName     = Venezuela
    /// NativeName           = Republica Bolivariana de Venezuela
    /// Cultures             = es-VE
    /// Culture              = es-VE
    /// Languages            = Spanish
    /// Language             = Spanish
    /// Currency             = Venezuelan Bolivar
    /// 
    /// Code                 = Vn
    /// Name                 = VN
    /// EnglishName          = Vietnam
    /// ShortEnglishName     = Vietnam
    /// NativeName           = Việt Nam
    /// Cultures             = vi-VN
    /// Culture              = vi-VN
    /// Languages            = Vietnamese
    /// Language             = Vietnamese
    /// Currency             = Vietnamese Dong
    /// 
    /// Code                 = Ye
    /// Name                 = YE
    /// EnglishName          = Yemen
    /// ShortEnglishName     = Yemen
    /// NativeName           = اليمن
    /// Cultures             = ar-YE
    /// Culture              = ar-YE
    /// Languages            = Arabic
    /// Language             = Arabic
    /// Currency             = Yemeni Rial
    /// 
    /// Code                 = Za
    /// Name                 = ZA
    /// EnglishName          = South Africa
    /// ShortEnglishName     = South Africa
    /// NativeName           = South Africa
    /// Cultures             = en-ZA, xh-ZA, zu-ZA, af-ZA, nso-ZA
    /// Culture              = en-ZA
    /// Languages            = English, isiXhosa, isiZulu, Afrikaans, Sesotho sa Leboa
    /// Language             = English
    /// Currency             = South African Rand
    /// 
    /// Code                 = Zw
    /// Name                 = ZW
    /// EnglishName          = Zimbabwe
    /// ShortEnglishName     = Zimbabwe
    /// NativeName           = Zimbabwe
    /// Cultures             = en-ZW
    /// Culture              = en-ZW
    /// Languages            = English
    /// Language             = English
    /// Currency             = Zimbabwe Dollar
    /// </remarks>
    public class CountryInfo : RegionInfo
    {
        #region Fields

        /// <summary>
        /// Internal sorted dictionary with all available <see cref="CountryInfo"/>s.
        /// </summary>
        private static readonly SortedDictionary<CountryCode, CountryInfo> _all = new SortedDictionary<CountryCode, CountryInfo>();

        /// <summary>
        /// Backing field for <see cref="ShortEnglishName"/>.
        /// </summary>
        private string _shortEnglishName;

        /// <summary>
        /// Cultures existing in this country.
        /// </summary>
        private readonly List<CultureInfo> _cultures = new List<CultureInfo>();

        /// <summary>
        /// Backing field for <see cref="CurrencyCode"/>.
        /// </summary>
        private CurrencyCode? _currencyCode;

        /// <summary>
        /// Backing field for <see cref="Languages"/>.
        /// </summary>
        private volatile List<LanguageInfo> _languages;

        /// <summary>
        /// Backing field for <see cref="Language"/>.
        /// </summary>
        private LanguageInfo _language;

        /// <summary>
        /// Sync root for <see cref="Languages"/>.
        /// </summary>
        private static readonly object _languagesSync = new object();

        #endregion

        #region Properties

        /// <summary>
        /// The country's <see cref="CountryCode"/>.
        /// </summary>
        public CountryCode Code
        {
            get;
            private set;
        }

        /// <summary>
        /// This is e.g. "Venezuela" for "Bolivarian Republic of Venezuela".
        /// </summary>
        public string ShortEnglishName
        {
            get
            {
                return _shortEnglishName ?? EnglishName;
            }
            private set
            {
                if(value != null)
                    _shortEnglishName = value;
            }
        }

        /// <summary>
        /// Name in German
        /// </summary>
        public string GermanName
        {
            get;
            private set;
        }

        /// <summary>
        /// Vehicle registration code, e.g. "D" for Germany, "F" for France or "US" for USA.
        /// </summary>
        public string VehicleRegistrationCode
        {
            get;
            private set;
        }

        /// <summary>
        /// The country's <see cref="CurrencyCode"/>.
        /// </summary>
        public CurrencyCode CurrencyCode
        {
            get
            {
                if(_currencyCode == null)
                    _currencyCode = (CurrencyCode)Enum.Parse(typeof(CurrencyCode), ISOCurrencySymbol.ToLowerInvariant().FirstLetterUpperCase());

                return _currencyCode.Value;
            }
        }

        /// <summary>
        /// This country's currency.
        /// </summary>
        public CurrencyInfo Currency
        {
            get
            {
                return CurrencyInfo.GetCurrency(CurrencyCode);
            }
        }

        /// <summary>
        /// Cultures existing in this country.
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
        /// Culture with the most spoken or official language in this country.
        /// </summary>
        /// <remarks>
        /// Is never null. May be incorrect in some cases, see <see cref="GetMostSpokenLanguageCultureString"/>.
        /// </remarks>
        public CultureInfo Culture
        {
            get
            {
                return _cultures[0];
            }
        }

        /// <summary>
        /// Languages spoken in this country.
        /// </summary>
        /// <remarks>
        /// Returns a copy of the internal <see cref="LanguageInfo"/> list. For performance reasons, cache this locally.
        /// <see cref="Cultures"/> are converted to <see cref="LanguageInfo"/>s on the fly. This cannot be done in the static constructor, 
        /// because the <see cref="LanguageInfo"/>'s static constructor already triggers the <see cref="CountryInfo"/>'s static constructor.  
        /// </remarks>
        public List<LanguageInfo> Languages
        {
            get
            {
                if(_languages == null)
                {
                    // Though this is an instance variable, the whole object is used in a static context and only created once.
                    // I.e. two threads could access this object at once and use this property concurrently. Thus, locking is necessary.
                    lock(_languagesSync)
                    {
                        if(_languages == null)
                        {
                            var tmp = new List<LanguageInfo>();
                            foreach(LanguageInfo languageInfo in _cultures.Select(cultureInfo => cultureInfo.GetLanguage()).Where(languageInfo => !tmp.Contains(languageInfo)))
                            {
                                tmp.Add(languageInfo);
                            }
                            _languages = tmp;
                        }
                    }
                }
                return new List<LanguageInfo>(_languages);
            }
        }

        /// <summary>
        /// Most spoken or official language in this country.
        /// </summary>
        /// <remarks>
        /// Is never null. May be incorrect in some cases, see <see cref="GetMostSpokenLanguageCultureString"/>.
        /// </remarks>
        public LanguageInfo Language
        {
            get
            {
                return _language ?? (_language = Culture.GetLanguage());
            }
        }

        /// <summary>
        /// A sorted dictionary with all supported <see cref="CountryInfo"/>s.
        /// </summary>
        /// <remarks>
        /// Returns a copy of the internal dictionary. For performance reasons, cache this locally.
        /// Also for performance reasons, do not use this property to get a specific <see cref="CountryInfo"/>.
        /// Use <see cref="GetCountry(CountryCode)"/> instead.
        /// </remarks>
        public static SortedDictionary<CountryCode, CountryInfo> All
        {
            get
            {
                return new SortedDictionary<CountryCode, CountryInfo>(_all);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Static constructor
        /// </summary>
        static CountryInfo()
        {
            // Fill all available countries.
            foreach(CultureInfo cultureInfo in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                CountryCode? nullableCountryCode = cultureInfo.GetCountryCode();
                if(nullableCountryCode == null)
                    continue;

                CountryCode countryCode = nullableCountryCode.Value;
                CultureInfo culture = cultureInfo;

                if(!_all.ContainsKey(countryCode))
                {
                    // Get the most important culture (language) to add it first.
                    string cultureString = GetMostSpokenLanguageCultureString(countryCode.ToString().ToUpperInvariant());
                    if(cultureString != null)
                        culture = new CultureInfo(cultureString);
                    _all.Add(countryCode, new CountryInfo(culture.LCID, countryCode));
                }

                if(!_all[countryCode]._cultures.Contains(culture))
                    _all[countryCode]._cultures.Add(culture);
            }

            // Fill ShortEnglishName.
            foreach(CountryInfo countryInfo in _all.Values)
            {
                countryInfo.ShortEnglishName = GetShortEnglishName(countryInfo);
            }

            // Fill VehicleRegistrationCode and GermanName.
            AddVehicleRegistrationCodesAndGermanNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryInfo"/> class based on the country/region or specific culture, specified by identifier.
        /// </summary>
        /// <param name="culture">The culture identifier, <see cref="CultureInfo.LCID"/>.</param>
        /// <param name="countryCode">This country's corresponding <see cref="CountryCode"/></param>
        private CountryInfo(int culture, CountryCode countryCode)
            : base(culture)
        {
            Code = countryCode;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the <see cref="CountryCode"/> for the passed <see cref="RegionInfo.TwoLetterISORegionName"/>.
        /// </summary>
        /// <remarks>
        /// <see cref="RegionInfo.TwoLetterISORegionName"/> is the same as <see cref="RegionInfo.Name"/> and reflects ISO 3166-2 region code.
        /// </remarks>
        /// <param name="twoLetterISORegionName">The <see cref="RegionInfo.TwoLetterISORegionName"/> to get the <see cref="CountryCode"/> for.</param>
        /// <returns>The <see cref="CountryCode"/> corresponding to <paramref name="twoLetterISORegionName"/> or null when not existing.</returns>
        public static CountryCode? GetCountryCode(string twoLetterISORegionName)
        {
            if(string.IsNullOrWhiteSpace(twoLetterISORegionName))
                return null;

            // Special handling for region "Caribbean" ("029").
            if(twoLetterISORegionName == "029")
                return CountryCode.Cb;

            CountryCode countryCode;
            return Enum.TryParse(twoLetterISORegionName, true, out countryCode) ? countryCode : (CountryCode?)null;
        }

        /// <summary>
        /// Gets a <see cref="CountryInfo"/> by its <paramref name="countryCode"/>.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="countryCode">The <see cref="CountryCode"/> to get the <see cref="CountryInfo"/> for.</param>
        /// <returns>The <see cref="CountryInfo"/> corresponding to <paramref name="countryCode"/>.</returns>
        public static CountryInfo GetCountry(CountryCode countryCode)
        {
            return _all[countryCode];
        }

        /// <summary>
        /// Gets a <see cref="CountryInfo"/> by its <see cref="RegionInfo.TwoLetterISORegionName"/>.
        /// </summary>
        /// <remarks>
        /// <see cref="RegionInfo.TwoLetterISORegionName"/> is the same as <see cref="RegionInfo.Name"/>.
        /// </remarks>
        /// <param name="twoLetterISORegionName">The <see cref="RegionInfo.TwoLetterISORegionName"/> to get the <see cref="CountryInfo"/> for.</param>
        /// <returns>The <see cref="CountryInfo"/> corresponding to <paramref name="twoLetterISORegionName"/> or null when not existing.</returns>
        public static CountryInfo GetCountry(string twoLetterISORegionName)
        {
            CountryCode? countryCode = GetCountryCode(twoLetterISORegionName);
            return countryCode == null ? null : _all[countryCode.Value];
        }

        /// <summary>
        /// Gets a <see cref="CountryInfo"/> by its <see cref="VehicleRegistrationCode"/>.
        /// </summary>
        /// <remarks>
        /// <paramref name="vehicleRegistrationCode"/> can be passed case-insensitive.
        /// </remarks>
        /// <param name="vehicleRegistrationCode">The <see cref="VehicleRegistrationCode"/> to get the <see cref="CountryInfo"/> for.</param>
        /// <returns>The <see cref="CountryInfo"/> corresponding to <paramref name="vehicleRegistrationCode"/> or null when not found.</returns>
        public static CountryInfo GetCountryByVehicleRegistrationCode(string vehicleRegistrationCode)
        {
            return string.IsNullOrEmpty(vehicleRegistrationCode) ? null : _all.Values.FirstOrDefault(c => c.VehicleRegistrationCode == vehicleRegistrationCode.ToUpperInvariant());
        }

        /// <summary>
        /// Dump some information about this <see cref="CountryInfo"/>.
        /// </summary>
        /// <remarks>
        /// This is for example:
        /// 
        /// Code                      = Ch
        /// Name                      = CH
        /// EnglishName               = Switzerland
        /// ShortEnglishName          = Switzerland
        /// GermanName                = Schweiz
        /// NativeName                = Schweiz
        /// Cultures                  = de-CH, it-CH, fr-CH
        /// Culture                   = de-CH
        /// Languages                 = German, Italian, French
        /// Language                  = German
        /// Currency                  = Swiss Franc
        /// VehicleRegistrationCode   = CH
        /// </remarks>
        /// <param name="prefix">Prefix to use for every line, e.g. "/// ". Defaults to the empty string.</param>
        /// <returns>A string with some information about this <see cref="CountryInfo"/></returns>
        public string Dump(string prefix = "")
        {
            const string format = "{0}{1, -25} = {2}";

            var sb = new StringBuilder();

            sb.AppendLine(string.Format(format, prefix, "Code", Code));
            sb.AppendLine(string.Format(format, prefix, "Name", Name));
            sb.AppendLine(string.Format(format, prefix, "EnglishName", EnglishName));
            sb.AppendLine(string.Format(format, prefix, "ShortEnglishName", ShortEnglishName));
            sb.AppendLine(string.Format(format, prefix, "GermanName", GermanName));
            sb.AppendLine(string.Format(format, prefix, "NativeName", NativeName));
            sb.AppendLine(string.Format(format, prefix, "Cultures", string.Join(", ", Cultures.Select(c => c.Name))));
            sb.AppendLine(string.Format(format, prefix, "Culture", Culture.Name));
            sb.AppendLine(string.Format(format, prefix, "Languages", string.Join(", ", Languages.Select(c => c.EnglishName))));
            sb.AppendLine(string.Format(format, prefix, "Language", Language.EnglishName));
            sb.AppendLine(string.Format(format, prefix, "Currency", Currency.EnglishName));
            sb.AppendLine(string.Format(format, prefix, "VehicleRegistrationCode", VehicleRegistrationCode));

            return sb.ToString();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Get a shorter, more common name for the <see cref="CountryInfo.EnglishName"/> of the passed <see cref="CountryInfo"/>.
        /// </summary>
        /// <param name="countryInfo">The <see cref="CountryInfo"/> to get a shorter english name for.</param>
        /// <returns>The shorter english name or null, if nothing has to be changed.</returns>
        private static string GetShortEnglishName(CountryInfo countryInfo)
        {
            switch(countryInfo.EnglishName)
            {
                case "Brunei Darussalam":
                    return "Brunei";

                case "People's Republic of China":
                    return "China";

                case "Serbia and Montenegro (Former)":
                    return "Serbia and Montenegro";

                case "Hong Kong S.A.R.":
                    return "Hong Kong";

                case "Lao P.D.R.":
                    return "Laos";

                case "Principality of Monaco":
                    return "Monaco";

                case "Macedonia (FYROM)":
                    return "Macedonia";

                case "Macao S.A.R.":
                    return "Macao";

                case "Islamic Republic of Pakistan":
                    return "Pakistan";

                case "Bolivarian Republic of Venezuela":
                    return "Venezuela";
            }

            return null;
        }

        /// <summary>
        /// Get the culture with the most spoken or official language in the passed country.
        /// </summary>
        /// <remarks>
        /// Despite research, this may be incorrect.
        /// </remarks>
        /// <param name="regionName">The region's name, e.g. "US" to get the culture for.</param>
        /// <returns>The culture with the most spoken language in the passed country</returns>
        private static string GetMostSpokenLanguageCultureString(string regionName)
        {
            switch(regionName)
            {
                case "BO":
                    return "es-BO";

                case "CA":
                    return "en-CA";

                case "CH":
                    return "de-CH";

                case "CL":
                    return "es-CL";

                case "CN":
                    return "zh-CN";

                case "DZ":
                    return "ar-DZ";

                case "EC":
                    return "es-EC";

                case "ES":
                    return "es-ES";

                case "GB":
                    return "en-GB";

                case "GT":
                    return "es-GT";

                case "NZ":
                    return "en-NZ";

                case "PE":
                    return "es-PE";

                case "SY":
                    return "ar-SY";

                case "ZA":
                    return "en-ZA";
            }

            return null;
        }

        /// <summary>
        /// Add <see cref="VehicleRegistrationCode"/>s and <see cref="GermanName"/>s.
        /// </summary>
        /// <remarks>
        /// List is taken from http://de.wikipedia.org/wiki/Liste_der_Kfz-Nationalitätszeichen.
        /// 
        /// It contains many more countries than the .NET framework supports.
        /// They are left in the list for future use.
        /// 
        /// However, there are also some countries missing in the list. For completeness and consistency, 
        /// partially artificial vehicle registartion codes and German country names were added for these countries:
        /// 
        /// 029 (Caribbean) => "Karibik" => "CB"
        /// CS (Serbia and Montenegro (Former)) => "Serbien und Montenegro (ehemals)" => "SCG"
        /// MO (Macao S.A.R.)  => "Macao" => "MO" (not "CHN" to keep a 1:1 relationship between <see cref="VehicleRegistrationCode"/> and <see cref="RegionInfo.Name"/>).
        /// </remarks>
        private static void AddVehicleRegistrationCodesAndGermanNames()
        {
            AddVehicleRegistrationCodeAndGermanName("A", "Österreich", "AT");
            AddVehicleRegistrationCodeAndGermanName("AFG", "Afghanistan", "AF");
            AddVehicleRegistrationCodeAndGermanName("AG", "Antigua und Barbuda", "AG");
            AddVehicleRegistrationCodeAndGermanName("AL", "Albanien", "AL");
            AddVehicleRegistrationCodeAndGermanName("AND", "Andorra", "AD");
            AddVehicleRegistrationCodeAndGermanName("ANG", "Angola", "AO");
            AddVehicleRegistrationCodeAndGermanName("AM", "Armenien", "AM");
            AddVehicleRegistrationCodeAndGermanName("ARU", "Aruba", "AW");
            AddVehicleRegistrationCodeAndGermanName("AUS", "Australien", "AU");
            AddVehicleRegistrationCodeAndGermanName("AUT", "Palästinensische Autonomiegebiete/Gazastreifen", "PS");
            AddVehicleRegistrationCodeAndGermanName("AX", "Åland", "AX");
            AddVehicleRegistrationCodeAndGermanName("AXA", "Anguilla", "AI");
            AddVehicleRegistrationCodeAndGermanName("AZ", "Aserbaidschan", "AZ");
            AddVehicleRegistrationCodeAndGermanName("B", "Belgien", "BE");
            AddVehicleRegistrationCodeAndGermanName("BD", "Bangladesch", "BD");
            AddVehicleRegistrationCodeAndGermanName("BDS", "Barbados", "BB");
            AddVehicleRegistrationCodeAndGermanName("BF", "Burkina Faso", "BF");
            AddVehicleRegistrationCodeAndGermanName("BG", "Bulgarien", "BG");
            AddVehicleRegistrationCodeAndGermanName("BHT", "Bhutan", "BT");
            AddVehicleRegistrationCodeAndGermanName("BIH", "Bosnien und Herzegowina", "BA");
            AddVehicleRegistrationCodeAndGermanName("BJ", "Benin", "BJ");
            AddVehicleRegistrationCodeAndGermanName("BOL", "Bolivien", "BO");
            AddVehicleRegistrationCodeAndGermanName("BR", "Brasilien", "BR");
            AddVehicleRegistrationCodeAndGermanName("BRN", "Bahrain", "BH");
            AddVehicleRegistrationCodeAndGermanName("BRU", "Brunei", "BN");
            AddVehicleRegistrationCodeAndGermanName("BS", "Bahamas", "BS");
            AddVehicleRegistrationCodeAndGermanName("BW", "Botswana", "BW");
            AddVehicleRegistrationCodeAndGermanName("BY", "Weißrussland", "BY");
            AddVehicleRegistrationCodeAndGermanName("BZ", "Belize", "BZ");
            AddVehicleRegistrationCodeAndGermanName("C", "Kuba", "CU");
            AddVehicleRegistrationCodeAndGermanName("CAM", "Kamerun", "CM");
            AddVehicleRegistrationCodeAndGermanName("CDN", "Kanada", "CA");
            AddVehicleRegistrationCodeAndGermanName("CGO", "Demokratische Republik Kongo", "CD");
            AddVehicleRegistrationCodeAndGermanName("CH", "Schweiz", "CH");
            AddVehicleRegistrationCodeAndGermanName("CHN", "Volksrepublik China", "CN");
            AddVehicleRegistrationCodeAndGermanName("CI", "Elfenbeinküste", "CI");
            AddVehicleRegistrationCodeAndGermanName("CL", "Sri Lanka", "LK");
            AddVehicleRegistrationCodeAndGermanName("CO", "Kolumbien", "CO");
            AddVehicleRegistrationCodeAndGermanName("COM", "Komoren", "KM");
            AddVehicleRegistrationCodeAndGermanName("CR", "Costa Rica", "CR");
            AddVehicleRegistrationCodeAndGermanName("CV", "Kap Verde", "CV");
            AddVehicleRegistrationCodeAndGermanName("CY", "Zypern", "CY");
            AddVehicleRegistrationCodeAndGermanName("CZ", "Tschechien", "CZ");
            AddVehicleRegistrationCodeAndGermanName("D", "Deutschland", "DE");
            AddVehicleRegistrationCodeAndGermanName("DJI", "Dschibuti", "DJ");
            AddVehicleRegistrationCodeAndGermanName("DK", "Dänemark", "DK");
            AddVehicleRegistrationCodeAndGermanName("DOM", "Dominikanische Republik", "DO");
            AddVehicleRegistrationCodeAndGermanName("DZ", "Algerien", "DZ");
            AddVehicleRegistrationCodeAndGermanName("E", "Spanien", "ES");
            AddVehicleRegistrationCodeAndGermanName("EAK", "Kenia", "KE");
            AddVehicleRegistrationCodeAndGermanName("EAT", "Tansania", "TZ");
            AddVehicleRegistrationCodeAndGermanName("EAU", "Uganda", "UG");
            AddVehicleRegistrationCodeAndGermanName("EC", "Ecuador", "EC");
            AddVehicleRegistrationCodeAndGermanName("ER", "Eritrea", "ER");
            AddVehicleRegistrationCodeAndGermanName("ES", "El Salvador", "SV");
            AddVehicleRegistrationCodeAndGermanName("EST", "Estland", "EE");
            AddVehicleRegistrationCodeAndGermanName("ET", "Ägypten", "EG");
            AddVehicleRegistrationCodeAndGermanName("TH", "Äthiopien", "ET");
            AddVehicleRegistrationCodeAndGermanName("F", "Frankreich", "FR");
            AddVehicleRegistrationCodeAndGermanName("FIN", "Finnland", "FI");
            AddVehicleRegistrationCodeAndGermanName("FJI", "Fidschi", "FJ");
            AddVehicleRegistrationCodeAndGermanName("FL", "Liechtenstein", "LI");
            AddVehicleRegistrationCodeAndGermanName("FO", "Färöer", "FO");
            AddVehicleRegistrationCodeAndGermanName("FSM", "Mikronesien", "FM");
            AddVehicleRegistrationCodeAndGermanName("G", "Gabun", "GA");
            AddVehicleRegistrationCodeAndGermanName("GB", "Vereinigtes Königreich", "GB");
            AddVehicleRegistrationCodeAndGermanName("GBG", "Guernsey", "GG");
            AddVehicleRegistrationCodeAndGermanName("GBJ", "Jersey", "JE");
            AddVehicleRegistrationCodeAndGermanName("GBM", "Isle of Man", "GB");
            AddVehicleRegistrationCodeAndGermanName("GBZ", "Gibraltar", "GI");
            AddVehicleRegistrationCodeAndGermanName("GCA", "Guatemala", "GT");
            AddVehicleRegistrationCodeAndGermanName("GE", "Georgien", "GE");
            AddVehicleRegistrationCodeAndGermanName("GH", "Ghana", "GH");
            AddVehicleRegistrationCodeAndGermanName("GQ", "Äquatorialguinea", "GQ");
            AddVehicleRegistrationCodeAndGermanName("GR", "Griechenland", "GR");
            AddVehicleRegistrationCodeAndGermanName("GUB", "Guinea-Bissau", "GW");
            AddVehicleRegistrationCodeAndGermanName("GUI", "Guinea", "GN");
            AddVehicleRegistrationCodeAndGermanName("GUY", "Guyana", "GY");
            AddVehicleRegistrationCodeAndGermanName("H", "Ungarn", "HU");
            AddVehicleRegistrationCodeAndGermanName("HK", "Hongkong", "HK");
            AddVehicleRegistrationCodeAndGermanName("HN", "Honduras", "HN");
            AddVehicleRegistrationCodeAndGermanName("HR", "Kroatien", "HR");
            AddVehicleRegistrationCodeAndGermanName("I", "Italien", "IT");
            AddVehicleRegistrationCodeAndGermanName("IL", "Israel", "IL");
            AddVehicleRegistrationCodeAndGermanName("IND", "Indien", "IN");
            AddVehicleRegistrationCodeAndGermanName("IR", "Iran", "IR");
            AddVehicleRegistrationCodeAndGermanName("IRL", "Irland", "IE");
            AddVehicleRegistrationCodeAndGermanName("IRQ", "Irak", "IQ");
            AddVehicleRegistrationCodeAndGermanName("IS", "Island", "IS");
            AddVehicleRegistrationCodeAndGermanName("J", "Japan", "JP");
            AddVehicleRegistrationCodeAndGermanName("JA", "Jamaika", "JM");
            AddVehicleRegistrationCodeAndGermanName("JOR", "Jordanien", "JO");
            AddVehicleRegistrationCodeAndGermanName("K", "Kambodscha", "KH");
            AddVehicleRegistrationCodeAndGermanName("KAN", "St. Kitts und Nevis", "KN");
            AddVehicleRegistrationCodeAndGermanName("KIR", "Kiribati", "KI");
            AddVehicleRegistrationCodeAndGermanName("KN", "Grönland", "GL");
            AddVehicleRegistrationCodeAndGermanName("KP", "Nordkorea", "KP");
            AddVehicleRegistrationCodeAndGermanName("KS", "Kirgisistan", "KG");
            AddVehicleRegistrationCodeAndGermanName("KSA", "Saudi-Arabien", "SA");
            AddVehicleRegistrationCodeAndGermanName("KWT", "Kuwait", "KW");
            AddVehicleRegistrationCodeAndGermanName("KZ", "Kasachstan", "KZ");
            AddVehicleRegistrationCodeAndGermanName("L", "Luxemburg", "LU");
            AddVehicleRegistrationCodeAndGermanName("LAO", "Laos", "LA");
            AddVehicleRegistrationCodeAndGermanName("LAR", "Libyen", "LY");
            AddVehicleRegistrationCodeAndGermanName("LB", "Liberia", "LR");
            AddVehicleRegistrationCodeAndGermanName("LS", "Lesotho", "LS");
            AddVehicleRegistrationCodeAndGermanName("LT", "Litauen", "LT");
            AddVehicleRegistrationCodeAndGermanName("LV", "Lettland", "LV");
            AddVehicleRegistrationCodeAndGermanName("M", "Malta", "MT");
            AddVehicleRegistrationCodeAndGermanName("MA", "Marokko", "MA");
            AddVehicleRegistrationCodeAndGermanName("MAL", "Malaysia", "MY");
            AddVehicleRegistrationCodeAndGermanName("MC", "Monaco", "MC");
            AddVehicleRegistrationCodeAndGermanName("MD", "Moldawien", "MD");
            AddVehicleRegistrationCodeAndGermanName("MEX", "Mexiko", "MX");
            AddVehicleRegistrationCodeAndGermanName("MGL", "Mongolei", "MN");
            AddVehicleRegistrationCodeAndGermanName("MH", "Marshallinseln", "MH");
            AddVehicleRegistrationCodeAndGermanName("MK", "Mazedonien", "MK");
            AddVehicleRegistrationCodeAndGermanName("MNE", "Montenegro", "ME");
            AddVehicleRegistrationCodeAndGermanName("OC", "Mosambik", "MZ");
            AddVehicleRegistrationCodeAndGermanName("MS", "Mauritius", "MU");
            AddVehicleRegistrationCodeAndGermanName("MV", "Malediven", "MV");
            AddVehicleRegistrationCodeAndGermanName("MW", "Malawi", "MW");
            AddVehicleRegistrationCodeAndGermanName("MYA", "Myanmar", "MM");
            AddVehicleRegistrationCodeAndGermanName("N", "Norwegen", "NO");
            AddVehicleRegistrationCodeAndGermanName("NA", "Niederländische Antillen", "AN");
            AddVehicleRegistrationCodeAndGermanName("NAM", "Namibia", "NA");
            AddVehicleRegistrationCodeAndGermanName("NAU", "Nauru", "NR");
            AddVehicleRegistrationCodeAndGermanName("NCL", "Neukaledonien", "NC");
            AddVehicleRegistrationCodeAndGermanName("NEP", "Nepal", "NP");
            AddVehicleRegistrationCodeAndGermanName("NGR", "Nigeria", "NG");
            AddVehicleRegistrationCodeAndGermanName("NIC", "Nicaragua", "NI");
            AddVehicleRegistrationCodeAndGermanName("NL", "Niederlande", "NL");
            AddVehicleRegistrationCodeAndGermanName("NZ", "Neuseeland", "NZ");
            AddVehicleRegistrationCodeAndGermanName("OM", "Oman", "OM");
            AddVehicleRegistrationCodeAndGermanName("P", "Portugal", "PT");
            AddVehicleRegistrationCodeAndGermanName("PA", "Panama", "PA");
            AddVehicleRegistrationCodeAndGermanName("PAL", "Palau", "PW");
            AddVehicleRegistrationCodeAndGermanName("PE", "Peru", "PE");
            AddVehicleRegistrationCodeAndGermanName("PK", "Pakistan", "PK");
            AddVehicleRegistrationCodeAndGermanName("PL", "Polen", "PL");
            AddVehicleRegistrationCodeAndGermanName("PNG", "Papua-Neuguinea", "PG");
            AddVehicleRegistrationCodeAndGermanName("PRI", "Puerto Rico", "PR");
            AddVehicleRegistrationCodeAndGermanName("PY", "Paraguay", "PY");
            AddVehicleRegistrationCodeAndGermanName("Q", "Katar", "QA");
            AddVehicleRegistrationCodeAndGermanName("RA", "Argentinien", "AR");
            AddVehicleRegistrationCodeAndGermanName("RB", "Botswana", "BW");
            AddVehicleRegistrationCodeAndGermanName("RC", "Republik China (Taiwan)", "TW");
            AddVehicleRegistrationCodeAndGermanName("RCA", "Zentralafrikanische Republik", "CF");
            AddVehicleRegistrationCodeAndGermanName("RCB", "Republik Kongo", "CG");
            AddVehicleRegistrationCodeAndGermanName("RCH", "Chile", "CL");
            AddVehicleRegistrationCodeAndGermanName("RG", "Guinea", "GN");
            AddVehicleRegistrationCodeAndGermanName("RH", "Haiti", "HT");
            AddVehicleRegistrationCodeAndGermanName("RI", "Indonesien", "ID");
            AddVehicleRegistrationCodeAndGermanName("RIM", "Mauretanien", "MR");
            AddVehicleRegistrationCodeAndGermanName("RKS", "Kosovo", "XK");
            AddVehicleRegistrationCodeAndGermanName("RL", "Libanon", "LB");
            AddVehicleRegistrationCodeAndGermanName("RM", "Madagaskar", "MG");
            AddVehicleRegistrationCodeAndGermanName("RMM", "Mali", "ML");
            AddVehicleRegistrationCodeAndGermanName("RN", "Niger", "NE");
            AddVehicleRegistrationCodeAndGermanName("RO", "Rumänien", "RO");
            AddVehicleRegistrationCodeAndGermanName("ROK", "Südkorea", "KR");
            AddVehicleRegistrationCodeAndGermanName("RUM", "Rumänien", "RO");
            AddVehicleRegistrationCodeAndGermanName("ROU", "Uruguay", "UY");
            AddVehicleRegistrationCodeAndGermanName("RP", "Philippinen", "PH");
            AddVehicleRegistrationCodeAndGermanName("RS", "Bosnisch-Serbische Republik", "RS");
            AddVehicleRegistrationCodeAndGermanName("RSM", "San Marino", "SM");
            AddVehicleRegistrationCodeAndGermanName("RT", "Togo", "TG");
            AddVehicleRegistrationCodeAndGermanName("RU", "Burundi", "BI");
            AddVehicleRegistrationCodeAndGermanName("RUS", "Russland", "RU");
            AddVehicleRegistrationCodeAndGermanName("RWA", "Ruanda", "RW");
            AddVehicleRegistrationCodeAndGermanName("S", "Schweden", "SE");
            AddVehicleRegistrationCodeAndGermanName("SD", "Swasiland", "SZ");
            AddVehicleRegistrationCodeAndGermanName("SGP", "Singapur", "SG");
            AddVehicleRegistrationCodeAndGermanName("SK", "Slowakei", "SK");
            AddVehicleRegistrationCodeAndGermanName("LE", "Sierra Leone", "SL");
            AddVehicleRegistrationCodeAndGermanName("SLO", "Slowenien", "SI");
            AddVehicleRegistrationCodeAndGermanName("SME", "Suriname", "SR");
            AddVehicleRegistrationCodeAndGermanName("S.M.O.M.", "Malteserorden", "MT");
            AddVehicleRegistrationCodeAndGermanName("SN", "Senegal", "SN");
            AddVehicleRegistrationCodeAndGermanName("SO", "Somalia", "SO");
            AddVehicleRegistrationCodeAndGermanName("SOL", "Salomonen", "SB");
            AddVehicleRegistrationCodeAndGermanName("SRB", "Serbien", "RS");
            AddVehicleRegistrationCodeAndGermanName("SSD", "Südsudan", "SS");
            AddVehicleRegistrationCodeAndGermanName("STP", "São Tomé und Príncipe", "ST");
            AddVehicleRegistrationCodeAndGermanName("SUD", "Sudan", "SD");
            AddVehicleRegistrationCodeAndGermanName("SY", "Seychellen", "SC");
            AddVehicleRegistrationCodeAndGermanName("SYR", "Syrien", "SY");
            AddVehicleRegistrationCodeAndGermanName("T", "Thailand", "TH");
            AddVehicleRegistrationCodeAndGermanName("TD", "Tschad", "TD");
            AddVehicleRegistrationCodeAndGermanName("TG", "Togo", "TG");
            AddVehicleRegistrationCodeAndGermanName("TJ", "Tadschikistan", "TJ");
            AddVehicleRegistrationCodeAndGermanName("TL", "Osttimor", "TL");
            AddVehicleRegistrationCodeAndGermanName("TM", "Turkmenistan", "TM");
            AddVehicleRegistrationCodeAndGermanName("TN", "Tunesien", "TN");
            AddVehicleRegistrationCodeAndGermanName("TON", "Tonga", "TO");
            AddVehicleRegistrationCodeAndGermanName("TR", "Türkei", "TR");
            AddVehicleRegistrationCodeAndGermanName("TT", "Trinidad und Tobago", "TT");
            AddVehicleRegistrationCodeAndGermanName("TUV", "Tuvalu", "TV");
            AddVehicleRegistrationCodeAndGermanName("UA", "Ukraine", "UA");
            AddVehicleRegistrationCodeAndGermanName("UAE", "Vereinigte Arabische Emirate", "AE");
            AddVehicleRegistrationCodeAndGermanName("USA", "Vereinigte Staaten von Amerika", "US");
            AddVehicleRegistrationCodeAndGermanName("UZ", "Usbekistan", "UZ");
            AddVehicleRegistrationCodeAndGermanName("V", "Vatikanstaat", "VA");
            AddVehicleRegistrationCodeAndGermanName("VAN", "Vanuatu", "VU");
            AddVehicleRegistrationCodeAndGermanName("VN", "Vietnam", "VN");
            AddVehicleRegistrationCodeAndGermanName("WAG", "Gambia", "GM");
            AddVehicleRegistrationCodeAndGermanName("WAL", "Sierra Leone", "SL");
            AddVehicleRegistrationCodeAndGermanName("WB", "Westjordanland", "PS");
            AddVehicleRegistrationCodeAndGermanName("WD", "Dominica", "DM");
            AddVehicleRegistrationCodeAndGermanName("WG", "Grenada", "GD");
            AddVehicleRegistrationCodeAndGermanName("WL", "St. Lucia", "LC");
            AddVehicleRegistrationCodeAndGermanName("WS", "Samoa", "WS");
            AddVehicleRegistrationCodeAndGermanName("WSA", "Demokratische Arabische Republik Sahara", "EH");
            AddVehicleRegistrationCodeAndGermanName("WV", "St. Vincent und die Grenadinen", "VC");
            AddVehicleRegistrationCodeAndGermanName("YEM", "Jemen", "YE");
            AddVehicleRegistrationCodeAndGermanName("YV", "Venezuela", "VE");
            AddVehicleRegistrationCodeAndGermanName("Z", "Sambia", "ZM");
            AddVehicleRegistrationCodeAndGermanName("ZA", "Südafrika", "ZA");
            AddVehicleRegistrationCodeAndGermanName("ZW", "Simbabwe", "ZW");

            // Add values for countries not in the list
            //
            // 029 (Caribbean) => "Karibik" => "CB"
            // CS (Serbia and Montenegro (Former)) => "Serbien und Montenegro (ehemals)" => "CS"
            // MO (Macao S.A.R.)  => "Macao" => "MO"

            AddVehicleRegistrationCodeAndGermanName("029", "Karibik", "CB");
            AddVehicleRegistrationCodeAndGermanName("CS", "Serbien und Montenegro (ehemals)", "CS");
            AddVehicleRegistrationCodeAndGermanName("MO", "Macao", "MO");
        }

        /// <summary>
        /// Add <see cref="VehicleRegistrationCode"/>s and <see cref="GermanName"/>s.
        /// </summary>
        /// <param name="vehicleRegistrationCode">Vehicle registration code, e.g. "D" for Germany, "F" for France or "US" for USA.</param>
        /// <param name="germanName">Country name in German</param>
        /// <param name="twoLetterISORegionName">ISO 3166-2 region code, i.e. <see cref="RegionInfo.TwoLetterISORegionName"/>.</param>
        /// <exception cref="ArgumentNullException">When <paramref name="vehicleRegistrationCode"/>, <paramref name="germanName"/> or <paramref name="twoLetterISORegionName"/> is null.</exception>
        private static void AddVehicleRegistrationCodeAndGermanName(string vehicleRegistrationCode, string germanName, string twoLetterISORegionName)
        {
            if(vehicleRegistrationCode == null)
                throw new ArgumentNullException("vehicleRegistrationCode");

            if(germanName == null)
                throw new ArgumentNullException("germanName");

            if(twoLetterISORegionName == null)
                throw new ArgumentNullException("twoLetterISORegionName");

            CountryInfo countryInfo = GetCountry(twoLetterISORegionName);
            if(countryInfo == null)
                return;

            countryInfo.VehicleRegistrationCode = vehicleRegistrationCode.ToUpperInvariant();
            countryInfo.GermanName = germanName;
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
            var other = obj as CountryInfo;
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

    #region Enum CountryCode

    /// <summary>
    /// All countries supported by the .Net framework.
    /// </summary>
    /// <remarks>
    /// Enum names are derived from <see cref="RegionInfo.TwoLetterISORegionName"/>, which is the same as <see cref="RegionInfo.Name"/>.
    /// The region "Caribbean" is an exception. It does not represent a single country and has TwoLetterISORegionName "029", which cannot be converted to an enum. 
    /// Here, <see cref="CountryCode.Cb"/> is used as a workaround. Country code "CB" is officially unassigned (see https://www.iso.org/obp/ui/#search).
    /// </remarks>
    public enum CountryCode
    {
        /// <summary>
        /// U.A.E.
        /// </summary>
        Ae,

        /// <summary>
        /// Afghanistan
        /// </summary>
        Af,

        /// <summary>
        /// Albania
        /// </summary>
        Al,

        /// <summary>
        /// Armenia
        /// </summary>
        Am,

        /// <summary>
        /// Argentina
        /// </summary>
        Ar,

        /// <summary>
        /// Austria
        /// </summary>
        At,

        /// <summary>
        /// Australia
        /// </summary>
        Au,

        /// <summary>
        /// Azerbaijan
        /// </summary>
        Az,

        /// <summary>
        /// Bosnia and Herzegovina
        /// </summary>
        Ba,

        /// <summary>
        /// Bangladesh
        /// </summary>
        Bd,

        /// <summary>
        /// Belgium
        /// </summary>
        Be,

        /// <summary>
        /// Bulgaria
        /// </summary>
        Bg,

        /// <summary>
        /// Bahrain
        /// </summary>
        Bh,

        /// <summary>
        /// Brunei Darussalam
        /// </summary>
        Bn,

        /// <summary>
        /// Bolivia
        /// </summary>
        Bo,

        /// <summary>
        /// Brazil
        /// </summary>
        Br,

        /// <summary>
        /// Belarus
        /// </summary>
        By,

        /// <summary>
        /// Belize
        /// </summary>
        Bz,

        /// <summary>
        /// Canada
        /// </summary>
        Ca,

        /// <summary>
        /// Caribbean (workaround enum value for TwoLetterISORegionName "029")
        /// </summary>
        Cb,

        /// <summary>
        /// Switzerland
        /// </summary>
        Ch,

        /// <summary>
        /// Chile
        /// </summary>
        Cl,

        /// <summary>
        /// People's Republic of China
        /// </summary>
        Cn,

        /// <summary>
        /// Colombia
        /// </summary>
        Co,

        /// <summary>
        /// Costa Rica
        /// </summary>
        Cr,

        /// <summary>
        /// Serbia and Montenegro (Former)
        /// </summary>
        Cs,

        /// <summary>
        /// Czech Republic
        /// </summary>
        Cz,

        /// <summary>
        /// Germany
        /// </summary>
        De,

        /// <summary>
        /// Denmark
        /// </summary>
        Dk,

        /// <summary>
        /// Dominican Republic
        /// </summary>
        Do,

        /// <summary>
        /// Algeria
        /// </summary>
        Dz,

        /// <summary>
        /// Ecuador
        /// </summary>
        Ec,

        /// <summary>
        /// Estonia
        /// </summary>
        Ee,

        /// <summary>
        /// Egypt
        /// </summary>
        Eg,

        /// <summary>
        /// Spain
        /// </summary>
        Es,

        /// <summary>
        /// Ethiopia
        /// </summary>
        Et,

        /// <summary>
        /// Finland
        /// </summary>
        Fi,

        /// <summary>
        /// Faroe Islands
        /// </summary>
        Fo,

        /// <summary>
        /// France
        /// </summary>
        Fr,

        /// <summary>
        /// United Kingdom
        /// </summary>
        Gb,

        /// <summary>
        /// Georgia
        /// </summary>
        Ge,

        /// <summary>
        /// Greenland
        /// </summary>
        Gl,

        /// <summary>
        /// Greece
        /// </summary>
        Gr,

        /// <summary>
        /// Guatemala
        /// </summary>
        Gt,

        /// <summary>
        /// Hong Kong S.A.R.
        /// </summary>
        Hk,

        /// <summary>
        /// Honduras
        /// </summary>
        Hn,

        /// <summary>
        /// Croatia
        /// </summary>
        Hr,

        /// <summary>
        /// Hungary
        /// </summary>
        Hu,

        /// <summary>
        /// Indonesia
        /// </summary>
        Id,

        /// <summary>
        /// Ireland
        /// </summary>
        Ie,

        /// <summary>
        /// Israel
        /// </summary>
        Il,

        /// <summary>
        /// India
        /// </summary>
        In,

        /// <summary>
        /// Iraq
        /// </summary>
        Iq,

        /// <summary>
        /// Iran
        /// </summary>
        Ir,

        /// <summary>
        /// Iceland
        /// </summary>
        Is,

        /// <summary>
        /// Italy
        /// </summary>
        It,

        /// <summary>
        /// Jamaica
        /// </summary>
        Jm,

        /// <summary>
        /// Jordan
        /// </summary>
        Jo,

        /// <summary>
        /// Japan
        /// </summary>
        Jp,

        /// <summary>
        /// Kenya
        /// </summary>
        Ke,

        /// <summary>
        /// Kyrgyzstan
        /// </summary>
        Kg,

        /// <summary>
        /// Cambodia
        /// </summary>
        Kh,

        /// <summary>
        /// Korea
        /// </summary>
        Kr,

        /// <summary>
        /// Kuwait
        /// </summary>
        Kw,

        /// <summary>
        /// Kazakhstan
        /// </summary>
        Kz,

        /// <summary>
        /// Lao P.D.R.
        /// </summary>
        La,

        /// <summary>
        /// Lebanon
        /// </summary>
        Lb,

        /// <summary>
        /// Liechtenstein
        /// </summary>
        Li,

        /// <summary>
        /// Sri Lanka
        /// </summary>
        Lk,

        /// <summary>
        /// Lithuania
        /// </summary>
        Lt,

        /// <summary>
        /// Luxembourg
        /// </summary>
        Lu,

        /// <summary>
        /// Latvia
        /// </summary>
        Lv,

        /// <summary>
        /// Libya
        /// </summary>
        Ly,

        /// <summary>
        /// Morocco
        /// </summary>
        Ma,

        /// <summary>
        /// Principality of Monaco
        /// </summary>
        Mc,

        /// <summary>
        /// Montenegro
        /// </summary>
        Me,

        /// <summary>
        /// Macedonia (FYROM)
        /// </summary>
        Mk,

        /// <summary>
        /// Mongolia
        /// </summary>
        Mn,

        /// <summary>
        /// Macao S.A.R.
        /// </summary>
        Mo,

        /// <summary>
        /// Malta
        /// </summary>
        Mt,

        /// <summary>
        /// Maldives
        /// </summary>
        Mv,

        /// <summary>
        /// Mexico
        /// </summary>
        Mx,

        /// <summary>
        /// Malaysia
        /// </summary>
        My,

        /// <summary>
        /// Nigeria
        /// </summary>
        Ng,

        /// <summary>
        /// Nicaragua
        /// </summary>
        Ni,

        /// <summary>
        /// Netherlands
        /// </summary>
        Nl,

        /// <summary>
        /// Norway
        /// </summary>
        No,

        /// <summary>
        /// Nepal
        /// </summary>
        Np,

        /// <summary>
        /// New Zealand
        /// </summary>
        Nz,

        /// <summary>
        /// Oman
        /// </summary>
        Om,

        /// <summary>
        /// Panama
        /// </summary>
        Pa,

        /// <summary>
        /// Peru
        /// </summary>
        Pe,

        /// <summary>
        /// Philippines
        /// </summary>
        Ph,

        /// <summary>
        /// Islamic Republic of Pakistan
        /// </summary>
        Pk,

        /// <summary>
        /// Poland
        /// </summary>
        Pl,

        /// <summary>
        /// Puerto Rico
        /// </summary>
        Pr,

        /// <summary>
        /// Portugal
        /// </summary>
        Pt,

        /// <summary>
        /// Paraguay
        /// </summary>
        Py,

        /// <summary>
        /// Qatar
        /// </summary>
        Qa,

        /// <summary>
        /// Romania
        /// </summary>
        Ro,

        /// <summary>
        /// Serbia
        /// </summary>
        Rs,

        /// <summary>
        /// Russia
        /// </summary>
        Ru,

        /// <summary>
        /// Rwanda
        /// </summary>
        Rw,

        /// <summary>
        /// Saudi Arabia
        /// </summary>
        Sa,

        /// <summary>
        /// Sweden
        /// </summary>
        Se,

        /// <summary>
        /// Singapore
        /// </summary>
        Sg,

        /// <summary>
        /// Slovenia
        /// </summary>
        Si,

        /// <summary>
        /// Slovakia
        /// </summary>
        Sk,

        /// <summary>
        /// Senegal
        /// </summary>
        Sn,

        /// <summary>
        /// El Salvador
        /// </summary>
        Sv,

        /// <summary>
        /// Syria
        /// </summary>
        Sy,

        /// <summary>
        /// Thailand
        /// </summary>
        Th,

        /// <summary>
        /// Tajikistan
        /// </summary>
        Tj,

        /// <summary>
        /// Turkmenistan
        /// </summary>
        Tm,

        /// <summary>
        /// Tunisia
        /// </summary>
        Tn,

        /// <summary>
        /// Turkey
        /// </summary>
        Tr,

        /// <summary>
        /// Trinidad and Tobago
        /// </summary>
        Tt,

        /// <summary>
        /// Taiwan
        /// </summary>
        Tw,

        /// <summary>
        /// Ukraine
        /// </summary>
        Ua,

        /// <summary>
        /// United States
        /// </summary>
        Us,

        /// <summary>
        /// Uruguay
        /// </summary>
        Uy,

        /// <summary>
        /// Uzbekistan
        /// </summary>
        Uz,

        /// <summary>
        /// Bolivarian Republic of Venezuela
        /// </summary>
        Ve,

        /// <summary>
        /// Vietnam
        /// </summary>
        Vn,

        /// <summary>
        /// Yemen
        /// </summary>
        Ye,

        /// <summary>
        /// South Africa
        /// </summary>
        Za,

        /// <summary>
        /// Zimbabwe
        /// </summary>
        Zw
    }

    #endregion
}