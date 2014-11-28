using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CountryLanguageCurrency
{
    #region Class CurrencyInfo

    /// <summary>
    /// Class representing a currency
    /// </summary>
    /// <remarks>
    /// 
    /// This is what <see cref="All"/> contains:
    /// 
    /// Code                 = Aed
    /// Name                 = AED
    /// EnglishName          = UAE Dirham
    /// NativeName           = درهم اماراتي
    /// Countries            = U.A.E.
    /// Country              = U.A.E.
    /// ISOCurrencySymbol    = AED
    /// Symbol               = د.إ.‏
    /// 
    /// Code                 = Afn
    /// Name                 = AFN
    /// EnglishName          = Afghani
    /// NativeName           = افغانى
    /// Countries            = Afghanistan
    /// Country              = Afghanistan
    /// ISOCurrencySymbol    = AFN
    /// Symbol               = ؋
    /// 
    /// Code                 = All
    /// Name                 = ALL
    /// EnglishName          = Albanian Lek
    /// NativeName           = Lek
    /// Countries            = Albania
    /// Country              = Albania
    /// ISOCurrencySymbol    = ALL
    /// Symbol               = Lek
    /// 
    /// Code                 = Amd
    /// Name                 = AMD
    /// EnglishName          = Armenian Dram
    /// NativeName           = դրամ
    /// Countries            = Armenia
    /// Country              = Armenia
    /// ISOCurrencySymbol    = AMD
    /// Symbol               = դր.
    /// 
    /// Code                 = Ars
    /// Name                 = ARS
    /// EnglishName          = Argentine Peso
    /// NativeName           = Peso
    /// Countries            = Argentina
    /// Country              = Argentina
    /// ISOCurrencySymbol    = ARS
    /// Symbol               = $
    /// 
    /// Code                 = Aud
    /// Name                 = AUD
    /// EnglishName          = Australian Dollar
    /// NativeName           = Australian Dollar
    /// Countries            = Australia
    /// Country              = Australia
    /// ISOCurrencySymbol    = AUD
    /// Symbol               = $
    /// 
    /// Code                 = Azn
    /// Name                 = AZN
    /// EnglishName          = Azerbaijanian Manat
    /// NativeName           = manat
    /// Countries            = Azerbaijan
    /// Country              = Azerbaijan
    /// ISOCurrencySymbol    = AZN
    /// Symbol               = man.
    /// 
    /// Code                 = Bam
    /// Name                 = BAM
    /// EnglishName          = Convertible Marks
    /// NativeName           = konvertibilna marka
    /// Countries            = Bosnia and Herzegovina
    /// Country              = Bosnia and Herzegovina
    /// ISOCurrencySymbol    = BAM
    /// Symbol               = KM
    /// 
    /// Code                 = Bdt
    /// Name                 = BDT
    /// EnglishName          = Bangladeshi Taka
    /// NativeName           = টাকা
    /// Countries            = Bangladesh
    /// Country              = Bangladesh
    /// ISOCurrencySymbol    = BDT
    /// Symbol               = ৳
    /// 
    /// Code                 = Bgn
    /// Name                 = BGN
    /// EnglishName          = Bulgarian Lev
    /// NativeName           = България лев
    /// Countries            = Bulgaria
    /// Country              = Bulgaria
    /// ISOCurrencySymbol    = BGN
    /// Symbol               = лв.
    /// 
    /// Code                 = Bhd
    /// Name                 = BHD
    /// EnglishName          = Bahraini Dinar
    /// NativeName           = دينار بحريني
    /// Countries            = Bahrain
    /// Country              = Bahrain
    /// ISOCurrencySymbol    = BHD
    /// Symbol               = د.ب.‏
    /// 
    /// Code                 = Bnd
    /// Name                 = BND
    /// EnglishName          = Brunei Dollar
    /// NativeName           = Ringgit
    /// Countries            = Brunei
    /// Country              = Brunei
    /// ISOCurrencySymbol    = BND
    /// Symbol               = $
    /// 
    /// Code                 = Bob
    /// Name                 = BOB
    /// EnglishName          = Boliviano
    /// NativeName           = Boliviano
    /// Countries            = Bolivia
    /// Country              = Bolivia
    /// ISOCurrencySymbol    = BOB
    /// Symbol               = $b
    /// 
    /// Code                 = Brl
    /// Name                 = BRL
    /// EnglishName          = Real
    /// NativeName           = Real
    /// Countries            = Brazil
    /// Country              = Brazil
    /// ISOCurrencySymbol    = BRL
    /// Symbol               = R$
    /// 
    /// Code                 = Byr
    /// Name                 = BYR
    /// EnglishName          = Belarusian Ruble
    /// NativeName           = рубль
    /// Countries            = Belarus
    /// Country              = Belarus
    /// ISOCurrencySymbol    = BYR
    /// Symbol               = р.
    /// 
    /// Code                 = Bzd
    /// Name                 = BZD
    /// EnglishName          = Belize Dollar
    /// NativeName           = Belize Dollar
    /// Countries            = Belize
    /// Country              = Belize
    /// ISOCurrencySymbol    = BZD
    /// Symbol               = BZ$
    /// 
    /// Code                 = Cad
    /// Name                 = CAD
    /// EnglishName          = Canadian Dollar
    /// NativeName           = Canadian Dollar
    /// Countries            = Canada
    /// Country              = Canada
    /// ISOCurrencySymbol    = CAD
    /// Symbol               = $
    /// 
    /// Code                 = Chf
    /// Name                 = CHF
    /// EnglishName          = Swiss Franc
    /// NativeName           = Schweizer Franken
    /// Countries            = Switzerland, Liechtenstein
    /// Country              = Switzerland
    /// ISOCurrencySymbol    = CHF
    /// Symbol               = Fr.
    /// 
    /// Code                 = Clp
    /// Name                 = CLP
    /// EnglishName          = Chilean Peso
    /// NativeName           = Peso
    /// Countries            = Chile
    /// Country              = Chile
    /// ISOCurrencySymbol    = CLP
    /// Symbol               = $
    /// 
    /// Code                 = Cny
    /// Name                 = CNY
    /// EnglishName          = PRC Yuan Renminbi
    /// NativeName           = 人民币
    /// Countries            = China
    /// Country              = China
    /// ISOCurrencySymbol    = CNY
    /// Symbol               = ¥
    /// 
    /// Code                 = Cop
    /// Name                 = COP
    /// EnglishName          = Colombian Peso
    /// NativeName           = Peso
    /// Countries            = Colombia
    /// Country              = Colombia
    /// ISOCurrencySymbol    = COP
    /// Symbol               = $
    /// 
    /// Code                 = Crc
    /// Name                 = CRC
    /// EnglishName          = Costa Rican Colon
    /// NativeName           = Colón
    /// Countries            = Costa Rica
    /// Country              = Costa Rica
    /// ISOCurrencySymbol    = CRC
    /// Symbol               = ₡
    /// 
    /// Code                 = Csd
    /// Name                 = CSD
    /// EnglishName          = Serbian Dinar
    /// NativeName           = dinar
    /// Countries            = Serbia and Montenegro
    /// Country              = Serbia and Montenegro
    /// ISOCurrencySymbol    = CSD
    /// Symbol               = Din.
    /// 
    /// Code                 = Czk
    /// Name                 = CZK
    /// EnglishName          = Czech Koruna
    /// NativeName           = Koruna Česká
    /// Countries            = Czech Republic
    /// Country              = Czech Republic
    /// ISOCurrencySymbol    = CZK
    /// Symbol               = Kč
    /// 
    /// Code                 = Dkk
    /// Name                 = DKK
    /// EnglishName          = Danish Krone
    /// NativeName           = Dansk krone
    /// Countries            = Denmark, Faroe Islands, Greenland
    /// Country              = Denmark
    /// ISOCurrencySymbol    = DKK
    /// Symbol               = kr.
    /// 
    /// Code                 = Dop
    /// Name                 = DOP
    /// EnglishName          = Dominican Peso
    /// NativeName           = Peso
    /// Countries            = Dominican Republic
    /// Country              = Dominican Republic
    /// ISOCurrencySymbol    = DOP
    /// Symbol               = RD$
    /// 
    /// Code                 = Dzd
    /// Name                 = DZD
    /// EnglishName          = Algerian Dinar
    /// NativeName           = دينار جزائري
    /// Countries            = Algeria
    /// Country              = Algeria
    /// ISOCurrencySymbol    = DZD
    /// Symbol               = د.ج.‏
    /// 
    /// Code                 = Egp
    /// Name                 = EGP
    /// EnglishName          = Egyptian Pound
    /// NativeName           = جنيه مصري
    /// Countries            = Egypt
    /// Country              = Egypt
    /// ISOCurrencySymbol    = EGP
    /// Symbol               = ج.م.‏
    /// 
    /// Code                 = Etb
    /// Name                 = ETB
    /// EnglishName          = Ethiopian Birr
    /// NativeName           = ብር
    /// Countries            = Ethiopia
    /// Country              = Ethiopia
    /// ISOCurrencySymbol    = ETB
    /// Symbol               = ETB
    /// 
    /// Code                 = Eur
    /// Name                 = EUR
    /// EnglishName          = Euro
    /// NativeName           = Euro
    /// Countries            = Austria, Belgium, Germany, Estonia, Spain, Finland, France, Greece, Ireland, Italy, Luxembourg, Latvia, Monaco, Montenegro, Malta, Netherlands, Portugal, Slovenia, Slovakia
    /// Country              = Austria
    /// ISOCurrencySymbol    = EUR
    /// Symbol               = €
    /// 
    /// Code                 = Gbp
    /// Name                 = GBP
    /// EnglishName          = UK Pound Sterling
    /// NativeName           = Pound Sterling
    /// Countries            = United Kingdom
    /// Country              = United Kingdom
    /// ISOCurrencySymbol    = GBP
    /// Symbol               = £
    /// 
    /// Code                 = Gel
    /// Name                 = GEL
    /// EnglishName          = Lari
    /// NativeName           = ლარი
    /// Countries            = Georgia
    /// Country              = Georgia
    /// ISOCurrencySymbol    = GEL
    /// Symbol               = Lari
    /// 
    /// Code                 = Gtq
    /// Name                 = GTQ
    /// EnglishName          = Guatemalan Quetzal
    /// NativeName           = Quetzal
    /// Countries            = Guatemala
    /// Country              = Guatemala
    /// ISOCurrencySymbol    = GTQ
    /// Symbol               = Q
    /// 
    /// Code                 = Hkd
    /// Name                 = HKD
    /// EnglishName          = Hong Kong Dollar
    /// NativeName           = 港幣
    /// Countries            = Hong Kong
    /// Country              = Hong Kong
    /// ISOCurrencySymbol    = HKD
    /// Symbol               = HK$
    /// 
    /// Code                 = Hnl
    /// Name                 = HNL
    /// EnglishName          = Honduran Lempira
    /// NativeName           = Lempira
    /// Countries            = Honduras
    /// Country              = Honduras
    /// ISOCurrencySymbol    = HNL
    /// Symbol               = L.
    /// 
    /// Code                 = Hrk
    /// Name                 = HRK
    /// EnglishName          = Croatian Kuna
    /// NativeName           = hrvatska kuna
    /// Countries            = Croatia
    /// Country              = Croatia
    /// ISOCurrencySymbol    = HRK
    /// Symbol               = kn
    /// 
    /// Code                 = Huf
    /// Name                 = HUF
    /// EnglishName          = Hungarian Forint
    /// NativeName           = forint
    /// Countries            = Hungary
    /// Country              = Hungary
    /// ISOCurrencySymbol    = HUF
    /// Symbol               = Ft
    /// 
    /// Code                 = Idr
    /// Name                 = IDR
    /// EnglishName          = Indonesian Rupiah
    /// NativeName           = Rupiah
    /// Countries            = Indonesia
    /// Country              = Indonesia
    /// ISOCurrencySymbol    = IDR
    /// Symbol               = Rp
    /// 
    /// Code                 = Ils
    /// Name                 = ILS
    /// EnglishName          = Israeli New Shekel
    /// NativeName           = שקל חדש
    /// Countries            = Israel
    /// Country              = Israel
    /// ISOCurrencySymbol    = ILS
    /// Symbol               = ₪
    /// 
    /// Code                 = Inr
    /// Name                 = INR
    /// EnglishName          = Indian Rupee
    /// NativeName           = रुपया
    /// Countries            = India
    /// Country              = India
    /// ISOCurrencySymbol    = INR
    /// Symbol               = ₹
    /// 
    /// Code                 = Iqd
    /// Name                 = IQD
    /// EnglishName          = Iraqi Dinar
    /// NativeName           = دينار عراقي
    /// Countries            = Iraq
    /// Country              = Iraq
    /// ISOCurrencySymbol    = IQD
    /// Symbol               = د.ع.‏
    /// 
    /// Code                 = Irr
    /// Name                 = IRR
    /// EnglishName          = Iranian Rial
    /// NativeName           = رىال
    /// Countries            = Iran
    /// Country              = Iran
    /// ISOCurrencySymbol    = IRR
    /// Symbol               = ريال
    /// 
    /// Code                 = Isk
    /// Name                 = ISK
    /// EnglishName          = Icelandic Krona
    /// NativeName           = Króna
    /// Countries            = Iceland
    /// Country              = Iceland
    /// ISOCurrencySymbol    = ISK
    /// Symbol               = kr.
    /// 
    /// Code                 = Jmd
    /// Name                 = JMD
    /// EnglishName          = Jamaican Dollar
    /// NativeName           = Jamaican Dollar
    /// Countries            = Jamaica
    /// Country              = Jamaica
    /// ISOCurrencySymbol    = JMD
    /// Symbol               = J$
    /// 
    /// Code                 = Jod
    /// Name                 = JOD
    /// EnglishName          = Jordanian Dinar
    /// NativeName           = دينار اردني
    /// Countries            = Jordan
    /// Country              = Jordan
    /// ISOCurrencySymbol    = JOD
    /// Symbol               = د.ا.‏
    /// 
    /// Code                 = Jpy
    /// Name                 = JPY
    /// EnglishName          = Japanese Yen
    /// NativeName           = 円
    /// Countries            = Japan
    /// Country              = Japan
    /// ISOCurrencySymbol    = JPY
    /// Symbol               = ¥
    /// 
    /// Code                 = Kes
    /// Name                 = KES
    /// EnglishName          = Kenyan Shilling
    /// NativeName           = Shilingi
    /// Countries            = Kenya
    /// Country              = Kenya
    /// ISOCurrencySymbol    = KES
    /// Symbol               = S
    /// 
    /// Code                 = Kgs
    /// Name                 = KGS
    /// EnglishName          = som
    /// NativeName           = сом
    /// Countries            = Kyrgyzstan
    /// Country              = Kyrgyzstan
    /// ISOCurrencySymbol    = KGS
    /// Symbol               = сом
    /// 
    /// Code                 = Khr
    /// Name                 = KHR
    /// EnglishName          = Riel
    /// NativeName           = x179Aៀល
    /// Countries            = Cambodia
    /// Country              = Cambodia
    /// ISOCurrencySymbol    = KHR
    /// Symbol               = ៛
    /// 
    /// Code                 = Krw
    /// Name                 = KRW
    /// EnglishName          = Korean Won
    /// NativeName           = 원
    /// Countries            = Korea
    /// Country              = Korea
    /// ISOCurrencySymbol    = KRW
    /// Symbol               = ₩
    /// 
    /// Code                 = Kwd
    /// Name                 = KWD
    /// EnglishName          = Kuwaiti Dinar
    /// NativeName           = دينار كويتي
    /// Countries            = Kuwait
    /// Country              = Kuwait
    /// ISOCurrencySymbol    = KWD
    /// Symbol               = د.ك.‏
    /// 
    /// Code                 = Kzt
    /// Name                 = KZT
    /// EnglishName          = Tenge
    /// NativeName           = Т
    /// Countries            = Kazakhstan
    /// Country              = Kazakhstan
    /// ISOCurrencySymbol    = KZT
    /// Symbol               = Т
    /// 
    /// Code                 = Lak
    /// Name                 = LAK
    /// EnglishName          = Kip
    /// NativeName           = ກີບ
    /// Countries            = Laos
    /// Country              = Laos
    /// ISOCurrencySymbol    = LAK
    /// Symbol               = ₭
    /// 
    /// Code                 = Lbp
    /// Name                 = LBP
    /// EnglishName          = Lebanese Pound
    /// NativeName           = ليرة لبناني
    /// Countries            = Lebanon
    /// Country              = Lebanon
    /// ISOCurrencySymbol    = LBP
    /// Symbol               = ل.ل.‏
    /// 
    /// Code                 = Lkr
    /// Name                 = LKR
    /// EnglishName          = Sri Lanka Rupee
    /// NativeName           = රුපියල්
    /// Countries            = Sri Lanka
    /// Country              = Sri Lanka
    /// ISOCurrencySymbol    = LKR
    /// Symbol               = රු.
    /// 
    /// Code                 = Ltl
    /// Name                 = LTL
    /// EnglishName          = Lithuanian Litas
    /// NativeName           = Litas
    /// Countries            = Lithuania
    /// Country              = Lithuania
    /// ISOCurrencySymbol    = LTL
    /// Symbol               = Lt
    /// 
    /// Code                 = Lyd
    /// Name                 = LYD
    /// EnglishName          = Libyan Dinar
    /// NativeName           = دينار ليبي
    /// Countries            = Libya
    /// Country              = Libya
    /// ISOCurrencySymbol    = LYD
    /// Symbol               = د.ل.‏
    /// 
    /// Code                 = Mad
    /// Name                 = MAD
    /// EnglishName          = Moroccan Dirham
    /// NativeName           = درهم مغربي
    /// Countries            = Morocco
    /// Country              = Morocco
    /// ISOCurrencySymbol    = MAD
    /// Symbol               = د.م.‏
    /// 
    /// Code                 = Mkd
    /// Name                 = MKD
    /// EnglishName          = Macedonian Denar
    /// NativeName           = денар
    /// Countries            = Macedonia
    /// Country              = Macedonia
    /// ISOCurrencySymbol    = MKD
    /// Symbol               = ден.
    /// 
    /// Code                 = Mnt
    /// Name                 = MNT
    /// EnglishName          = Tugrik
    /// NativeName           = Төгрөг
    /// Countries            = Mongolia
    /// Country              = Mongolia
    /// ISOCurrencySymbol    = MNT
    /// Symbol               = ₮
    /// 
    /// Code                 = Mop
    /// Name                 = MOP
    /// EnglishName          = Macao Pataca
    /// NativeName           = 澳門幣
    /// Countries            = Macao
    /// Country              = Macao
    /// ISOCurrencySymbol    = MOP
    /// Symbol               = MOP
    /// 
    /// Code                 = Mvr
    /// Name                 = MVR
    /// EnglishName          = Rufiyaa
    /// NativeName           = ރުފިޔާ
    /// Countries            = Maldives
    /// Country              = Maldives
    /// ISOCurrencySymbol    = MVR
    /// Symbol               = ރ.
    /// 
    /// Code                 = Mxn
    /// Name                 = MXN
    /// EnglishName          = Mexican Peso
    /// NativeName           = Peso
    /// Countries            = Mexico
    /// Country              = Mexico
    /// ISOCurrencySymbol    = MXN
    /// Symbol               = $
    /// 
    /// Code                 = Myr
    /// Name                 = MYR
    /// EnglishName          = Malaysian Ringgit
    /// NativeName           = Ringgit Malaysia
    /// Countries            = Malaysia
    /// Country              = Malaysia
    /// ISOCurrencySymbol    = MYR
    /// Symbol               = RM
    /// 
    /// Code                 = Nio
    /// Name                 = NIO
    /// EnglishName          = Nigerian Naira
    /// NativeName           = Naira
    /// Countries            = Nigeria, Nicaragua
    /// Country              = Nigeria
    /// ISOCurrencySymbol    = NIO
    /// Symbol               = N
    /// 
    /// Code                 = Nok
    /// Name                 = NOK
    /// EnglishName          = Norwegian Krone
    /// NativeName           = Norsk krone
    /// Countries            = Norway
    /// Country              = Norway
    /// ISOCurrencySymbol    = NOK
    /// Symbol               = kr
    /// 
    /// Code                 = Npr
    /// Name                 = NPR
    /// EnglishName          = Nepalese Rupees
    /// NativeName           = रुपैयाँ
    /// Countries            = Nepal
    /// Country              = Nepal
    /// ISOCurrencySymbol    = NPR
    /// Symbol               = रु
    /// 
    /// Code                 = Nzd
    /// Name                 = NZD
    /// EnglishName          = New Zealand Dollar
    /// NativeName           = New Zealand Dollar
    /// Countries            = New Zealand
    /// Country              = New Zealand
    /// ISOCurrencySymbol    = NZD
    /// Symbol               = $
    /// 
    /// Code                 = Omr
    /// Name                 = OMR
    /// EnglishName          = Omani Rial
    /// NativeName           = ريال عماني
    /// Countries            = Oman
    /// Country              = Oman
    /// ISOCurrencySymbol    = OMR
    /// Symbol               = ر.ع.‏
    /// 
    /// Code                 = Pab
    /// Name                 = PAB
    /// EnglishName          = Panamanian Balboa
    /// NativeName           = Balboa
    /// Countries            = Panama
    /// Country              = Panama
    /// ISOCurrencySymbol    = PAB
    /// Symbol               = B/.
    /// 
    /// Code                 = Pen
    /// Name                 = PEN
    /// EnglishName          = Peruvian Nuevo Sol
    /// NativeName           = Nuevo Sol
    /// Countries            = Peru
    /// Country              = Peru
    /// ISOCurrencySymbol    = PEN
    /// Symbol               = S/.
    /// 
    /// Code                 = Php
    /// Name                 = PHP
    /// EnglishName          = Philippine Peso
    /// NativeName           = Philippine Peso
    /// Countries            = Philippines
    /// Country              = Philippines
    /// ISOCurrencySymbol    = PHP
    /// Symbol               = PhP
    /// 
    /// Code                 = Pkr
    /// Name                 = PKR
    /// EnglishName          = Pakistan Rupee
    /// NativeName           = روپيه
    /// Countries            = Pakistan
    /// Country              = Pakistan
    /// ISOCurrencySymbol    = PKR
    /// Symbol               = Rs
    /// 
    /// Code                 = Pln
    /// Name                 = PLN
    /// EnglishName          = Polish Zloty
    /// NativeName           = Złoty
    /// Countries            = Poland
    /// Country              = Poland
    /// ISOCurrencySymbol    = PLN
    /// Symbol               = zł
    /// 
    /// Code                 = Pyg
    /// Name                 = PYG
    /// EnglishName          = Paraguay Guarani
    /// NativeName           = Guaraní
    /// Countries            = Paraguay
    /// Country              = Paraguay
    /// ISOCurrencySymbol    = PYG
    /// Symbol               = Gs
    /// 
    /// Code                 = Qar
    /// Name                 = QAR
    /// EnglishName          = Qatari Rial
    /// NativeName           = ريال قطري
    /// Countries            = Qatar
    /// Country              = Qatar
    /// ISOCurrencySymbol    = QAR
    /// Symbol               = ر.ق.‏
    /// 
    /// Code                 = Ron
    /// Name                 = RON
    /// EnglishName          = Romanian Leu
    /// NativeName           = Leu
    /// Countries            = Romania
    /// Country              = Romania
    /// ISOCurrencySymbol    = RON
    /// Symbol               = lei
    /// 
    /// Code                 = Rsd
    /// Name                 = RSD
    /// EnglishName          = Serbian Dinar
    /// NativeName           = dinar
    /// Countries            = Serbia
    /// Country              = Serbia
    /// ISOCurrencySymbol    = RSD
    /// Symbol               = Din.
    /// 
    /// Code                 = Rub
    /// Name                 = RUB
    /// EnglishName          = Russian Ruble
    /// NativeName           = рубль
    /// Countries            = Russia
    /// Country              = Russia
    /// ISOCurrencySymbol    = RUB
    /// Symbol               = р.
    /// 
    /// Code                 = Rwf
    /// Name                 = RWF
    /// EnglishName          = Rwandan Franc
    /// NativeName           = Ifaranga
    /// Countries            = Rwanda
    /// Country              = Rwanda
    /// ISOCurrencySymbol    = RWF
    /// Symbol               = RWF
    /// 
    /// Code                 = Sar
    /// Name                 = SAR
    /// EnglishName          = Saudi Riyal
    /// NativeName           = ريال سعودي
    /// Countries            = Saudi Arabia
    /// Country              = Saudi Arabia
    /// ISOCurrencySymbol    = SAR
    /// Symbol               = ر.س.‏
    /// 
    /// Code                 = Sek
    /// Name                 = SEK
    /// EnglishName          = Swedish Krona
    /// NativeName           = Svensk krona
    /// Countries            = Sweden
    /// Country              = Sweden
    /// ISOCurrencySymbol    = SEK
    /// Symbol               = kr
    /// 
    /// Code                 = Sgd
    /// Name                 = SGD
    /// EnglishName          = Singapore Dollar
    /// NativeName           = 新币
    /// Countries            = Singapore
    /// Country              = Singapore
    /// ISOCurrencySymbol    = SGD
    /// Symbol               = $
    /// 
    /// Code                 = Syp
    /// Name                 = SYP
    /// EnglishName          = Syrian Pound
    /// NativeName           = ليرة سوري
    /// Countries            = Syria
    /// Country              = Syria
    /// ISOCurrencySymbol    = SYP
    /// Symbol               = ل.س.‏
    /// 
    /// Code                 = Thb
    /// Name                 = THB
    /// EnglishName          = Thai Baht
    /// NativeName           = บาท
    /// Countries            = Thailand
    /// Country              = Thailand
    /// ISOCurrencySymbol    = THB
    /// Symbol               = ฿
    /// 
    /// Code                 = Tjs
    /// Name                 = TJS
    /// EnglishName          = Ruble
    /// NativeName           = рубл
    /// Countries            = Tajikistan
    /// Country              = Tajikistan
    /// ISOCurrencySymbol    = TJS
    /// Symbol               = т.р.
    /// 
    /// Code                 = Tmt
    /// Name                 = TMT
    /// EnglishName          = Turkmen manat
    /// NativeName           = manat
    /// Countries            = Turkmenistan
    /// Country              = Turkmenistan
    /// ISOCurrencySymbol    = TMT
    /// Symbol               = m.
    /// 
    /// Code                 = Tnd
    /// Name                 = TND
    /// EnglishName          = Tunisian Dinar
    /// NativeName           = دينار تونسي
    /// Countries            = Tunisia
    /// Country              = Tunisia
    /// ISOCurrencySymbol    = TND
    /// Symbol               = د.ت.‏
    /// 
    /// Code                 = Try
    /// Name                 = TRY
    /// EnglishName          = Turkish Lira
    /// NativeName           = Türk Lirası
    /// Countries            = Turkey
    /// Country              = Turkey
    /// ISOCurrencySymbol    = TRY
    /// Symbol               = ₺
    /// 
    /// Code                 = Ttd
    /// Name                 = TTD
    /// EnglishName          = Trinidad Dollar
    /// NativeName           = Trinidad Dollar
    /// Countries            = Trinidad and Tobago
    /// Country              = Trinidad and Tobago
    /// ISOCurrencySymbol    = TTD
    /// Symbol               = TT$
    /// 
    /// Code                 = Twd
    /// Name                 = TWD
    /// EnglishName          = New Taiwan Dollar
    /// NativeName           = 新台幣
    /// Countries            = Taiwan
    /// Country              = Taiwan
    /// ISOCurrencySymbol    = TWD
    /// Symbol               = NT$
    /// 
    /// Code                 = Uah
    /// Name                 = UAH
    /// EnglishName          = Ukrainian Grivna
    /// NativeName           = гривня
    /// Countries            = Ukraine
    /// Country              = Ukraine
    /// ISOCurrencySymbol    = UAH
    /// Symbol               = ₴
    /// 
    /// Code                 = Usd
    /// Name                 = USD
    /// EnglishName          = US Dollar
    /// NativeName           = US Dollar
    /// Countries            = Caribbean, Ecuador, Puerto Rico, El Salvador, United States
    /// Country              = United States
    /// ISOCurrencySymbol    = USD
    /// Symbol               = $
    /// 
    /// Code                 = Uyu
    /// Name                 = UYU
    /// EnglishName          = Peso Uruguayo
    /// NativeName           = Peso
    /// Countries            = Uruguay
    /// Country              = Uruguay
    /// ISOCurrencySymbol    = UYU
    /// Symbol               = $U
    /// 
    /// Code                 = Uzs
    /// Name                 = UZS
    /// EnglishName          = Uzbekistan Som
    /// NativeName           = so‘m
    /// Countries            = Uzbekistan
    /// Country              = Uzbekistan
    /// ISOCurrencySymbol    = UZS
    /// Symbol               = so'm
    /// 
    /// Code                 = Vef
    /// Name                 = VEF
    /// EnglishName          = Venezuelan Bolivar
    /// NativeName           = Bolívar
    /// Countries            = Venezuela
    /// Country              = Venezuela
    /// ISOCurrencySymbol    = VEF
    /// Symbol               = Bs. F.
    /// 
    /// Code                 = Vnd
    /// Name                 = VND
    /// EnglishName          = Vietnamese Dong
    /// NativeName           = Đồng
    /// Countries            = Vietnam
    /// Country              = Vietnam
    /// ISOCurrencySymbol    = VND
    /// Symbol               = ₫
    /// 
    /// Code                 = Xof
    /// Name                 = XOF
    /// EnglishName          = XOF Senegal
    /// NativeName           = XOF Senegal
    /// Countries            = Senegal
    /// Country              = Senegal
    /// ISOCurrencySymbol    = XOF
    /// Symbol               = XOF
    /// 
    /// Code                 = Yer
    /// Name                 = YER
    /// EnglishName          = Yemeni Rial
    /// NativeName           = ريال يمني
    /// Countries            = Yemen
    /// Country              = Yemen
    /// ISOCurrencySymbol    = YER
    /// Symbol               = ر.ي.‏
    /// 
    /// Code                 = Zar
    /// Name                 = ZAR
    /// EnglishName          = South African Rand
    /// NativeName           = Rand
    /// Countries            = South Africa
    /// Country              = South Africa
    /// ISOCurrencySymbol    = ZAR
    /// Symbol               = R
    /// 
    /// Code                 = Zwl
    /// Name                 = ZWL
    /// EnglishName          = Zimbabwe Dollar
    /// NativeName           = Zimbabwe Dollar
    /// Countries            = Zimbabwe
    /// Country              = Zimbabwe
    /// ISOCurrencySymbol    = ZWL
    /// Symbol               = Z$
    /// </remarks>
    public class CurrencyInfo
    {
        #region Fields

        /// <summary>
        /// Internal sorted dictionary with all available <see cref="CurrencyInfo"/>s.
        /// </summary>
        private static readonly SortedDictionary<CurrencyCode, CurrencyInfo> _all = new SortedDictionary<CurrencyCode, CurrencyInfo>();

        /// <summary>
        /// Countries using this currency.
        /// </summary>
        private readonly List<CountryInfo> _countries = new List<CountryInfo>();

        #endregion

        #region Properties

        /// <summary>
        /// The currency's <see cref="CurrencyCode"/>.
        /// </summary>
        public CurrencyCode Code
        {
            get;
            private set;
        }

        /// <summary>
        /// Currency's name, same as <see cref="ISOCurrencySymbol"/>.
        /// </summary>
        public string Name
        {
            get
            {
                return ISOCurrencySymbol;
            }
        }

        /// <summary>
        /// The currency's three-character ISO 4217 symbol, e.g. "EUR".
        /// </summary>
        public string ISOCurrencySymbol
        {
            get
            {
                return Country.ISOCurrencySymbol;
            }
        }

        /// <summary>
        /// The currency's symbol, e.g. "€" or "$".
        /// </summary>
        public string Symbol
        {
            get
            {
                return Country.CurrencySymbol;
            }
        }

        /// <summary>
        /// The currency's english name, e.g. "Euro" or "Dollar".
        /// </summary>
        public string EnglishName
        {
            get
            {
                return Country.CurrencyEnglishName;
            }
        }

        /// <summary>
        /// The currency's native name, e.g. "Svensk krona".
        /// </summary>
        public string NativeName
        {
            get
            {
                return Country.CurrencyNativeName;
            }
        }

        /// <summary>
        /// How to usually format this currency, i.e. in the (first) <see cref="Country"/> it is used.
        /// </summary>
        /// <remarks>
        /// This is not very reliable, because for example the Euro is used in many different countries with different number formats.
        /// </remarks>
        public NumberFormatInfo NumberFormat
        {
            get
            {
                return Country.Culture.NumberFormat;
            }
        }

        /// <summary>
        /// Countries using this currency.
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
        /// The country the currency comes from.
        /// </summary>
        /// <remarks>
        /// Is never null.
        /// </remarks>
        public CountryInfo Country
        {
            get;
            private set;
        }

        /// <summary>
        /// A dictionary with all supported <see cref="CurrencyInfo"/>s.
        /// </summary>
        /// <remarks>
        /// Returns a copy of the internal dictionary. For performance reasons, cache this locally.
        /// Also for performance reasons, do not use this property to get a specific <see cref="CountryInfo"/>.
        /// Use <see cref="GetCurrency(CurrencyCode)"/> instead.
        /// </remarks>
        public static SortedDictionary<CurrencyCode, CurrencyInfo> All
        {
            get
            {
                return new SortedDictionary<CurrencyCode, CurrencyInfo>(_all);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Static constructor
        /// </summary>
        static CurrencyInfo()
        {
            // Fill all available currencies list
            foreach(CountryInfo country in CountryInfo.All.Values)
            {
                // Do not access country.Currency here, because this would cause an endless loop.
                var currencyCode = country.CurrencyCode;
                if(!_all.ContainsKey(currencyCode))
                    _all.Add(currencyCode, new CurrencyInfo(currencyCode));
                _all[currencyCode]._countries.Add(country);
            }

            // Fill Country propery
            foreach(CurrencyInfo currencyInfo in _all.Values)
            {
                // Handle USD as an exception (would be "Caribbean" otherwise).
                currencyInfo.Country = currencyInfo.Code == CurrencyCode.Usd ? CountryInfo.GetCountry(CountryCode.Us) : currencyInfo._countries[0];
            }
        }

        /// <summary>
        /// Private constructor
        /// </summary>
        /// <param name="currencyCode">The currency's corresponding <see cref="CurrencyCode"/>.</param>
        private CurrencyInfo(CurrencyCode currencyCode)
        {
            Code = currencyCode;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get the <see cref="CurrencyInfo"/> instance for <paramref name="currencyCode"/>.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="currencyCode">The <see cref="CurrencyCode"/> to get the <see cref="CurrencyInfo"/> instance for.</param>
        /// <returns>The <see cref="CurrencyInfo"/> instance for <paramref name="currencyCode"/>.</returns>
        public static CurrencyInfo GetCurrency(CurrencyCode currencyCode)
        {
            return _all[currencyCode];
        }

        /// <summary>
        /// Gets a <see cref="CurrencyInfo"/> for the passed <see cref="CountryCode"/>.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="countryCode">The <see cref="CountryCode"/> to get the <see cref="CurrencyInfo"/> for.</param>
        /// <returns>The <see cref="CurrencyInfo"/> corresponding to <paramref name="countryCode"/>.</returns>
        /// <exception cref="ArgumentNullException">When <see cref="countryCode"/> is null.</exception>
        /// <exception cref="ArgumentException">When there is no region associated with <paramref name="countryCode"/>, i.e. when <paramref name="countryCode"/> is a neutral or the invariant culture.</exception>
        public static CurrencyInfo GetCurrency(CountryCode countryCode)
        {
            return CountryInfo.GetCountry(countryCode).Currency;
        }

        /// <summary>
        /// Dump some information about this <see cref="CurrencyInfo"/>.
        /// </summary>
        /// <remarks>
        /// This is for example:
        /// 
        /// Code                 = Usd
        /// Name                 = USD
        /// EnglishName          = US Dollar
        /// NativeName           = US Dollar
        /// Countries            = Caribbean, Ecuador, Puerto Rico, El Salvador, United States
        /// Country              = United States
        /// ISOCurrencySymbol    = USD
        /// Symbol               = $
        /// </remarks>
        /// <param name="prefix">Prefix to use for every line, e.g. "/// ". Defaults to the empty string.</param>
        /// <returns>A string with some information about this <see cref="CurrencyInfo"/></returns>
        public string Dump(string prefix = "")
        {
            const string format = "{0}{1, -20} = {2}";

            var sb = new StringBuilder();

            sb.AppendLine(string.Format(format, prefix, "Code", Code));
            sb.AppendLine(string.Format(format, prefix, "Name", Name));
            sb.AppendLine(string.Format(format, prefix, "EnglishName", EnglishName));
            sb.AppendLine(string.Format(format, prefix, "NativeName", NativeName));
            sb.AppendLine(string.Format(format, prefix, "Countries", string.Join(", ", Countries.Select(c => c.ShortEnglishName))));
            sb.AppendLine(string.Format(format, prefix, "Country", Country.ShortEnglishName));
            sb.AppendLine(string.Format(format, prefix, "ISOCurrencySymbol", ISOCurrencySymbol));
            sb.AppendLine(string.Format(format, prefix, "Symbol", Symbol));

            return sb.ToString();
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Human readable representation of this object.
        /// </summary>
        /// <returns><see cref="Name"/></returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Whether another object is considered to be the same as this one
        /// </summary>
        /// <param name="obj">The object to compare</param>
        /// <returns>True = the other object is considered to be the same as this one, false otherwise</returns>
        public override bool Equals(object obj)
        {
            var other = obj as CurrencyInfo;
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

    #region Enum CurrencyCode

    /// <summary>
    /// All currencies supported by the .Net framework.
    /// </summary>
    /// <remarks>
    /// Names are derived from <see cref="RegionInfo.ISOCurrencySymbol"/>.
    /// </remarks>
    public enum CurrencyCode
    {
        /// <summary>
        /// UAE Dirham
        /// </summary>
        Aed,

        /// <summary>
        /// Afghani
        /// </summary>
        Afn,

        /// <summary>
        /// Albanian Lek
        /// </summary>
        All,

        /// <summary>
        /// Armenian Dram
        /// </summary>
        Amd,

        /// <summary>
        /// Argentine Peso
        /// </summary>
        Ars,

        /// <summary>
        /// Australian Dollar
        /// </summary>
        Aud,

        /// <summary>
        /// Azerbaijanian Manat
        /// </summary>
        Azn,

        /// <summary>
        /// Convertible Marks
        /// </summary>
        Bam,

        /// <summary>
        /// Bangladeshi Taka
        /// </summary>
        Bdt,

        /// <summary>
        /// Bulgarian Lev
        /// </summary>
        Bgn,

        /// <summary>
        /// Bahraini Dinar
        /// </summary>
        Bhd,

        /// <summary>
        /// Brunei Dollar
        /// </summary>
        Bnd,

        /// <summary>
        /// Boliviano
        /// </summary>
        Bob,

        /// <summary>
        /// Real
        /// </summary>
        Brl,

        /// <summary>
        /// Belarusian Ruble
        /// </summary>
        Byr,

        /// <summary>
        /// Belize Dollar
        /// </summary>
        Bzd,

        /// <summary>
        /// Canadian Dollar
        /// </summary>
        Cad,

        /// <summary>
        /// Swiss Franc
        /// </summary>
        Chf,

        /// <summary>
        /// Chilean Peso
        /// </summary>
        Clp,

        /// <summary>
        /// PRC Renminbi
        /// </summary>
        Cny,

        /// <summary>
        /// Colombian Peso
        /// </summary>
        Cop,

        /// <summary>
        /// Costa Rican Colon
        /// </summary>
        Crc,

        /// <summary>
        /// Serbian Dinar
        /// </summary>
        Csd,

        /// <summary>
        /// Czech Koruna
        /// </summary>
        Czk,

        /// <summary>
        /// Danish Krone
        /// </summary>
        Dkk,

        /// <summary>
        /// Dominican Peso
        /// </summary>
        Dop,

        /// <summary>
        /// Algerian Dinar
        /// </summary>
        Dzd,

        /// <summary>
        /// Egyptian Pound
        /// </summary>
        Egp,

        /// <summary>
        /// Ethiopian Birr
        /// </summary>
        Etb,

        /// <summary>
        /// Euro
        /// </summary>
        Eur,

        /// <summary>
        /// UK Pound Sterling
        /// </summary>
        Gbp,

        /// <summary>
        /// Lari
        /// </summary>
        Gel,

        /// <summary>
        /// Guatemalan Quetzal
        /// </summary>
        Gtq,

        /// <summary>
        /// Hong Kong Dollar
        /// </summary>
        Hkd,

        /// <summary>
        /// Honduran Lempira
        /// </summary>
        Hnl,

        /// <summary>
        /// Croatian Kuna
        /// </summary>
        Hrk,

        /// <summary>
        /// Hungarian Forint
        /// </summary>
        Huf,

        /// <summary>
        /// Indonesian Rupiah
        /// </summary>
        Idr,

        /// <summary>
        /// Israeli New Shekel
        /// </summary>
        Ils,

        /// <summary>
        /// Indian Rupee
        /// </summary>
        Inr,

        /// <summary>
        /// Iraqi Dinar
        /// </summary>
        Iqd,

        /// <summary>
        /// Iranian Rial
        /// </summary>
        Irr,

        /// <summary>
        /// Icelandic Krona
        /// </summary>
        Isk,

        /// <summary>
        /// Jamaican Dollar
        /// </summary>
        Jmd,

        /// <summary>
        /// Jordanian Dinar
        /// </summary>
        Jod,

        /// <summary>
        /// Japanese Yen
        /// </summary>
        Jpy,

        /// <summary>
        /// Kenyan Shilling
        /// </summary>
        Kes,

        /// <summary>
        /// som
        /// </summary>
        Kgs,

        /// <summary>
        /// Riel
        /// </summary>
        Khr,

        /// <summary>
        /// Korean Won
        /// </summary>
        Krw,

        /// <summary>
        /// Kuwaiti Dinar
        /// </summary>
        Kwd,

        /// <summary>
        /// Tenge
        /// </summary>
        Kzt,

        /// <summary>
        /// Kip
        /// </summary>
        Lak,

        /// <summary>
        /// Lebanese Pound
        /// </summary>
        Lbp,

        /// <summary>
        /// Sri Lanka Rupee
        /// </summary>
        Lkr,

        /// <summary>
        /// Lithuanian Litas
        /// </summary>
        Ltl,

        /// <summary>
        /// Libyan Dinar
        /// </summary>
        Lyd,

        /// <summary>
        /// Moroccan Dirham
        /// </summary>
        Mad,

        /// <summary>
        /// Macedonian Denar
        /// </summary>
        Mkd,

        /// <summary>
        /// Tugrik
        /// </summary>
        Mnt,

        /// <summary>
        /// Macao Pataca
        /// </summary>
        Mop,

        /// <summary>
        /// Rufiyaa
        /// </summary>
        Mvr,

        /// <summary>
        /// Mexican Peso
        /// </summary>
        Mxn,

        /// <summary>
        /// Malaysian Ringgit
        /// </summary>
        Myr,

        /// <summary>
        /// Nigerian Naira
        /// </summary>
        Nio,

        /// <summary>
        /// Norwegian Krone
        /// </summary>
        Nok,

        /// <summary>
        /// Nepalese Rupees
        /// </summary>
        Npr,

        /// <summary>
        /// New Zealand Dollar
        /// </summary>
        Nzd,

        /// <summary>
        /// Omani Rial
        /// </summary>
        Omr,

        /// <summary>
        /// Panamanian Balboa
        /// </summary>
        Pab,

        /// <summary>
        /// Peruvian Nuevo Sol
        /// </summary>
        Pen,

        /// <summary>
        /// Philippine Peso
        /// </summary>
        Php,

        /// <summary>
        /// Pakistan Rupee
        /// </summary>
        Pkr,

        /// <summary>
        /// Polish Zloty
        /// </summary>
        Pln,

        /// <summary>
        /// Paraguay Guarani
        /// </summary>
        Pyg,

        /// <summary>
        /// Qatari Rial
        /// </summary>
        Qar,

        /// <summary>
        /// Romanian Leu
        /// </summary>
        Ron,

        /// <summary>
        /// Serbian Dinar
        /// </summary>
        Rsd,

        /// <summary>
        /// Russian Ruble
        /// </summary>
        Rub,

        /// <summary>
        /// Rwandan Franc
        /// </summary>
        Rwf,

        /// <summary>
        /// Saudi Riyal
        /// </summary>
        Sar,

        /// <summary>
        /// Swedish Krona
        /// </summary>
        Sek,

        /// <summary>
        /// Singapore Dollar
        /// </summary>
        Sgd,

        /// <summary>
        /// Syrian Pound
        /// </summary>
        Syp,

        /// <summary>
        /// Thai Baht
        /// </summary>
        Thb,

        /// <summary>
        /// Ruble
        /// </summary>
        Tjs,

        /// <summary>
        /// Turkmen manat
        /// </summary>
        Tmt,

        /// <summary>
        /// Tunisian Dinar
        /// </summary>
        Tnd,

        /// <summary>
        /// Turkish Lira
        /// </summary>
        Try,

        /// <summary>
        /// Trinidad Dollar
        /// </summary>
        Ttd,

        /// <summary>
        /// New Taiwan Dollar
        /// </summary>
        Twd,

        /// <summary>
        /// Ukrainian Grivna
        /// </summary>
        Uah,

        /// <summary>
        /// US Dollar
        /// </summary>
        Usd,

        /// <summary>
        /// Peso Uruguayo
        /// </summary>
        Uyu,

        /// <summary>
        /// Uzbekistan Som
        /// </summary>
        Uzs,

        /// <summary>
        /// Venezuelan Bolivar
        /// </summary>
        Vef,

        /// <summary>
        /// Vietnamese Dong
        /// </summary>
        Vnd,

        /// <summary>
        /// XOF Senegal
        /// </summary>
        Xof,

        /// <summary>
        /// Yemeni Rial
        /// </summary>
        Yer,

        /// <summary>
        /// South African Rand
        /// </summary>
        Zar,

        /// <summary>
        /// Zimbabwe Dollar
        /// </summary>
        Zwl
    }

    #endregion
}