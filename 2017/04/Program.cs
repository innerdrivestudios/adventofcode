﻿//Solution for https://adventofcode.com/2017/day/4 (Ctrl+Click in VS to follow link)

// Your input: a list of passphrases

string myInput = "nyot babgr babgr kqtu kqtu kzshonp ylyk psqk\r\niix ewj rojvbkk phrij iix zuajnk tadv givslju ewj bda\r\nisjur jppvano vctnpjp ngwzdq pxqfrk mnxxes zqwgnd giqh\r\nojufqke gpd olzirc jfao cjfh rcivvw pqqpudp\r\nilgomox extiffg ylbd nqxhk lsi isl nrho yom\r\nfeauv scstmie qgbod enpltx jrhlxet qps lejrtxh\r\nwlrxtdo tlwdxor ezg ztp uze xtmw neuga aojrixu zpt\r\nwchrl pzibt nvcae wceb\r\nrdwytj kxuyet bqnzlv nyntjan dyrpsn zhi kbxlj ivo\r\ndab mwiz bapjpz jbzppa\r\nhbcudl tsfvtc zlqgpuk xoxbuh whmo atsxt pzkivuo wsa gjoevr hbcudl\r\ngxhqamx dradmqo gxhqamx gxhqamx\r\nyvwykx uhto ten wkvxyy wdbw\r\nkzc ndzatgb rlxrk hfgorm qwgdky ndzatgb rhvyene qaa wxibe qwmku nmxkjqo\r\nqwx ubca dxudny oxagv wqrv lhzsl qmsgv dxs awbquc akelgma\r\nrrdlfpk ohoszz qiznasf awchv qnvse\r\nggsyj czcrdn oolj sibjzp ibzjps asp\r\nvbcs ypgzae xcvpsr ptvb leoxqlq zmpt fhawu yfi tvbp\r\nejkr qlmag nsz jwpurli nhsml asksnug mes\r\nkkgkjml kklmgjk kjgpx iquytbj eccceb mfv iuyqjbt ovv\r\nuoklkco zzey sdfhiyv ytdeg\r\nazr mjv raz arz rdfb\r\npir dafgsah dafgsah kndjbml estcz yjeoijp kkcws ebq puwno\r\niqymwc tac vlqc bmnkz xustm leqi\r\ngwdjed cfha axz xjuq\r\nabfjsg pahat qlj zan qsfn iozfys jnvu bis jakggq\r\nafwuejn zrbu zurb hrn lwvjb jnwixla aufejnw\r\nvkqn cuzf humhriz webnf uzfc zfuc\r\neznxd kgbfy jqyc net vzfege tprzyc\r\nmqnapzn vrgw ilzp vgw\r\naie zkkih fhpwu bbn fhpwu wvxxgmd\r\nksoasrn yll mvdjxdo wydymx dmodvjx drnjlm tcjpjhj xzakb wrsbuwl vaygdwf rsasonk\r\nqahbh tfhkl apdqqpm tfhkl nsox\r\nxkelwve mvdmesj xrto tgku gkb bpe\r\nnni nyylpu cyusxe zydeyok yokzdye xiscesy\r\nitwsfr eqwrx igqkvif whklwdb\r\nlpa hwci suwqfln xis sfht lzek ajecd\r\nsvpf eulute eya gvmsd app claria tjtk zjt agdyemi bixewo\r\ngmzglxi zlgouy bejg kte xlf giquj mjeq ivjkw ktbhaga hoffyrt\r\nwwjy dtf ftd agei yde xhbfo fyridy\r\ngexcy hetkz ufflrfi frifluf plb kqre etxo elg henqy fspm\r\nkhaemn buec ichau wxctsxg\r\ncgmv ujyvcuu jta yux ccx skrafkn cmyc yidqhv ltb ycnajry zitq\r\nybsahqn pio veeze vdztjz iedou pio sue ijbz gvqncl vpa ijbz\r\nhkfi xzrsyke hikf mxolx xlxmo ungfc tst xjzd\r\ntpx ioprco qixlv ipocro\r\noahmwrv homvraw vws ntmbdvx\r\nfxlg wnuz ogt bxgtul vmfh nwuz glfx tgxdq bxfv kajuh\r\nvrhqn nrqvh tgogb vya ragbro ulrz uava kexoi yav vkfe\r\nbxxy tyxgxd oabsud bauosd jlch bdmrqq wqhjwb ayblb hclj\r\nsfzsgsc sfzsgsc jbrvh sfzsgsc bdhy\r\nwixleal vhnqbfw qwfnhbv woco oowc\r\nexkkwz wekxzk krxbua nshxqgh\r\ngkn blxgui nkg gnk\r\notsa isqn otsa isqn\r\nude xedl ude xedl amkktp\r\nteroe yuvbd inf mpytuvz xiq xqi ovqetn\r\nzyq ybeifwx fvoqp vhoduy bcq wbxl\r\nzymiid vafcqv vjbmekf lgxkma bjti qfavcv iqp fnbu lakmgx\r\nrkaqvd vylkh jfdxh imxxg bbrt imxxg rkaqvd\r\nyajg qnhhs bzmb eyk hijcg tkij iwr jvwp dipzd jvwp\r\nbtzhw zttheyo ravsbz bmbba majoe ykrs tbxqf tai cgsvpu srbavz\r\nvsyczfs ymg vsyczfs wxlwaqb oouio owek wxlwaqb azvbqiq\r\nghrapd ghrapd wisq wisq\r\nznmleu aztnkbs wxc gycxd vqenhh geqyo rpjg\r\nkxbom gzz zzg zgz\r\ndfsesc okwb dfsesc okwb\r\negpwqbe djlk xpkxa hoo eepbqwg\r\nnxdfror yfhkhn zgea fkspva rjgg bnmq ddsf rjgg gkinm\r\nvdrxfom wbdwu dhkt xtvzc zjobo aqvgrt\r\nsvddsgz mhcrbcp wmpd mhcrbcp klim ddlnxv wrdftrc ddow wrdftrc\r\nobxr wscs new brxo wen epns cvjvxts ilnc\r\nrwezl vmbut kgblt xfg vnhlebq nzqdzxm ynh wokrezy zub nzzqxdm\r\nvephajp bzupele mltzglh sbgn vephajp lhve mltzglh\r\nslajp kyaf vlnvy srfietn ayfk inaufex fanuexi\r\nvazwg kjg qanzso ptuu vvlwq uupt kohhql jkg\r\nxmmmpky rbqimi slvxsf tlcwm pbf pks iucx rbmiqi\r\nirkup jvu tkeioz avdu suxamf\r\ntmgih ldca jswka dblzzt rap rgqyy gyrqsk nnnn pok\r\npdbjhrl gsvxbqr nqfkhtc ngn okbgzd pdbjhrl oostjtm okbgzd\r\nmzqfdat dujh aeplzqh acbguic vlzdt amyszu amyszu jqecky bhl hjqnimq xoy\r\ndszafr bqampg epozj sfrlpe dszafr wfurku sotjpg wagtnxy\r\njbmo jbmo plbfkvw bkc jbmo\r\nehelldu vrid unnf vrid xqiu tbibjyi bmbpsmq tpqyefx xqiu\r\nrpgm zzbj cjgfdyb bdjfgcy rzqecd miyvfbu aqlkagf hsuxwgl\r\ngvywzp phvnd ypwypbm yfelxx egbr lcfyz hecdhkj xxfley\r\ntsmebin tbsnmie mkijj ijjmk\r\ncghxrqs vzxle wrfghv skighgt zviteab plcrgv\r\nezdirp rxkw horcek qcgny inx nikb tigzp\r\neidk sactjci sre vkapava owvf eyds eyds\r\nvvjdm uye tjixj azklizl pnb\r\ntcrimv xye twii xye twii tad\r\nmtxcg lwjxdj zjudqu ekoujd ysf ajtfta dkj lwjxdj\r\naowhmvv kkic kjize fnohl ukx remfmii usbp\r\nwkossu limxmhp xnoeocb wkossu lnrlqf kjozfg xeulstx sjncsw ekaimuv xnoeocb sxjegcg\r\nlsfe zpewzlc yhjyiay lou ukhi lpwezzc slef zvtidgg kdeseq enka tfvgudr\r\novfsa vuv tbtorv tbtorv gmxn opspw lli mfzvkv zlyhr oznalr\r\nkugrpw sduq rdc ciaxwir ylnzwec kugrpw sduq\r\nobevuau thu jpyfvof rpawwo obevuau gsvoutr quiaei\r\nxpgua pbxa pxgau kdan\r\nohyzqk abxgg xozgai nib axozig bni fucgykm jpkswt\r\njrgu dmozts jrug ufpho\r\nqojzue uzeojq txuhj eqjzou\r\nwcvj qwlravl niyxf oiaptlk wlxnnzj jgdzap jgdzap lfgn bdt sfga adrypo\r\nylah eedu rvwdpmq eedu ylah\r\nquages kmla yjqua dzxcfam srjag wujmcv qujya ssaol uzdwi\r\ngdsppz yqxlish yfkjbbf ecnzu ejvtv cdjwre\r\nslsls pcmrq zax btrc kliv ntho gymkk kkq pcrmq mvnw sjfegpx\r\nryz jfw eki wvibww qdzylg whbagp ffrfjg wdhnqpm hcrz\r\ntcjqfh tmvzp mpztv vpmzt\r\nxood xutgof teqov fqyyub oakm rzaheiq\r\naxagoq jawbz sexucp sexucp atenr edekcwn edekcwn agl ecj gbje gipivfq\r\npoqv qopv bos flhghs gshlfh\r\nrxd dzphnb bwmna vxd rxd sbk kuor\r\nkqeelq jqbyh xczqzqe jbkmx kelqeq xqcfqn\r\njdfy qzjyz xvqyo jdfy xvqyo\r\nvyoqyd pwayqag eygmdt smakwc veftikz fzeikvt\r\naozgkne mpd mktgoew eepp zlwycr eepp hswbxcx nmi ddnfr eepp\r\ndgpfp cfhhqdx vjrb uyimbm byx hfdhxqc\r\nfxq jcouwfy uhuao zsab xjao\r\nnoudveu egxyuqw hmnnv vovt wmqkx syatiac whkd\r\ngxyzk opgb kjxp delavq hsnvk kfn irkcfq lvc aadcwy opgb\r\nexuiupk ddiiyvm nsggpj ddiiyvm nsggpj\r\nhhjby rfejzp akxzs nconlt rynivtq voloj qwhhll ubvx yxuacz miuwxh ppe\r\nuspqvx supvxq cekv niddfuw\r\noptzcag sra ajs ozacptg yxkludq jjpvldz mxo mox\r\ndko qyec iuxbrbj dlz jxribub\r\nywlyz vipfh amsfr fwiozi tahjov tap rsea zwlyy oqdyfbo\r\nxeqml jwy eguc bvzvh\r\ncrp mxsihvo wwtg gsypx mxsihvo qpfw looca gewvy zjqki tdkuxo crp\r\nmqlnzm yihsvrl hhtwcv kigymqu yswki hksk vbiujq xeqz irzcq cpnz\r\nzxhfsw uuyhwid nzabem mmfk wszfhx shxzwf hqnrvsq\r\nhfjajdl qwmk hjdalfj mwkq gqbku dsszk\r\nfbiy pujq htgaqqq yro ztpe yiufb fnpi ggchdgz\r\nsixq jsboan eoie msdrwzw sixq njsrc sixq yimqoi\r\npbxgv kqmi hjuk bbtrlta bqwm bgehofj ainqhm qoypsil manhiq ogebhfj lvmuo\r\nwnax aen fthpcke tcz yadjmva mydavaj rcfkc krfcc\r\nlkatiw zxliii usdj oopxl yylv bkjfy gtlyjv usdj muqazdb\r\nyqonaxv wqnvoo hfpll oyxnlfs fgajc khhtzr hfpll gsvvipz wbjxsnp dcdikt hqw\r\nvvuv kspmnz zvmryqd egvuz eazkhz kspmnz\r\nxgq dziwiym gsl nbzmsta ccbzn yalof dbbugq aar ywmbvk yofla dcwb\r\nqrtyhhw xeyo vlym ulzzbl hrxyb qeyu jqdkewk oxye evaxz kybc bssyt\r\neqrf cfyy kwhohw ozg jsc egz jsc\r\nvct cet ixxvmz ibhvndq eks dpi jzfwdqv saeh jqzdfwv vwfdqjz\r\nvus vus kitvvgq wpi alfncf gzj oxcy fith oxcy ecbsr\r\nuacculk guwhwdp cankcv yswy bmby sve dvonm nran\r\nydftm wszgaex rgbw otd dbet lhsxndd jqfyx\r\nvhawg hwagv uagy fveik nrsew zujw hawvg dzfmt agzgw\r\nuqdj talb uqdj aizyuqm\r\npbbejee szdtohv tycfow xwne qzlqy dxcwejz pqdqrc wfyotc gdqt uxaeug wtldm\r\nhmzmd oyp pyo opy\r\nqwdh kwpll kwpll zsbez uxg klr uxg\r\nmyqr zza kqpcos adsql eumunrv qlaeumx\r\nacyye xvdewe nwkhuz bzcmx asw ostiwk mfzu nwkhuz\r\nmemq uqadd kfj dses lrxb hxygp dsse bxbr hgpxy uavrar\r\nmjmk lsdttuz qjkg yfthmkn pram\r\npctfq aly usim shihap uims xkfgp ksrbn ifvsyl\r\ncdma nnnu hdm dhm\r\nkpt upgsm ohvrrqf qwps wjcbve ohvrrqf\r\nwowphgb nteme otizypb eumgvb puoctli opicult wbohwpg\r\nfppz ftkql sbut lkqtf svif viqhlnn buts lljhbd\r\noqk uinby rqy vbjhf oul hzfo coca glpy brjy yglp qnvhvei\r\nsbbwr dnyrux gpikv nsx aawyeq uhtucwq rhxzy jgx bdgdrl dnyrux lgfgi\r\nagn mljz hgmglem popu jtapub agn\r\nehfpgr bnobvg bnobvg bnobvg\r\nozgzedn godezzn art atr\r\nurz rzu xzyc rjhwi kgiodi doiigk layr dwbxu\r\nrkcbav pnp bpsmm ifivfe csouqpw fyswzbd csouqpw bnjt rnnoxed\r\nhpjgtcc ctcpgjh cchjtgp lxn\r\ncinokbx uyaz uyaz uyaz\r\nbphfwad bphfwad bphfwad yml izlhlb dvjvo jeropar\r\nocgftcl wshjk zbinw fcotlgc xdj nwibz\r\nzbze hllno rmq invd gupoxr gwumc vnzj fcvvhjo dnn sfsxw\r\noqlhkz hgf yxiahks vhzvl ayshkxi irmwkmq\r\napeqic ahwu abxjrd tuwrd pynnil eohmlgo lafx ybpofe wbznxv swuafas\r\ncpg jpsfo jposf rer ixeydpz\r\nrhqrwvn wrhqnrv xptms jhc rnqvhwr\r\nzfpl tukxzda lifkqtd ynfuno cttx ctxt tlqdkfi ueswv wbipfbe\r\neblw bwbjg fuu qqm qtv qtv isbl denfcb\r\nick yqwcffk pvcchd apkjyc ouu uyfe nplid ick caqscs sddkx\r\nrtzh idn snnw xmlou idn kdhenl rtzh ujwttl pkynkhe\r\ndnwha fpv dnwha iqi xggepo dnwha\r\nyjvk saay enxqhw wigoah dzasyr nnt artl iqwia jpp xmfr hwigao\r\nryt heenuai ytr gqew hyb byh wdurx kmd adgjz\r\nypdqeji sfkkfhn stms cdmyh nqllx utiphia gxbx zflhtgo yurztx eni\r\npwlhlt lhlwpt rfkvlgr tucajej ckujc ntcyae xestygt eshmggk\r\ngtfb codwc vjtli ffmjwx ruoekt cylrm ktroue dfaxzvs kkgejzi ewucgu jyatrum\r\nersbag cod xssha aqzbe kxu bzghhqk pbs bizvqk bhbbd bps\r\nvhci ypxf bxzor unngl xilpzpk civh nykora vchi\r\ncyb cceu negnld nbcfs pxsjgh xah nbcfs nbcfs jabpxg wtanv qhztvr\r\ncljgzkn lrdeina hrjoz kdgpn vqkmpal nivk scvnu vzuausp\r\nnif fin uxjbip xxztsn yyo opueh zxs qnso paedey hsd fttvqdn\r\ngbnkmpr afo aof ryyudy gbmpnrk\r\nuaa npb dkit npb buadan esv npb hwrj\r\nhws dfgq fcyty qszhu chyxxl ytmpb azxl jrsn boqrx\r\nhkzlnkd fkilvog xbubu fbgbp\r\nfgi inmay uliytc vgkcw qsoe uliytc isjhix oyir ocaq\r\nqrzkpm dpzetbr zommsxo cixg nwjyvp bet wyjpvn cgxi tsncd\r\nuvlf lufv ulfv cigl\r\nuwwf thr kdq fhjmty bvxue vcwwmk kdq nzajq bxkf\r\nqcwduju idxaja qcwduju idxaja\r\nfnarz pstzfne nco qzf kcevoo qwx csvsxga pstzfne\r\ntwug xrwy uoctfl bkh yxrw\r\nunpdnbe apf cvm bpullu fyels tjpri jyw unpdnbe xfyekay vhk zpyb\r\nrbv psirdv psirdv mnjrp qpwc vicismd qpwc\r\nzjj zjj kesyhow eqcfqy vqy\r\nzazpd gmea aobl dcs mage hqjdpwc bvxr srw\r\nrhcdb nzsa jgcgc rhcdb wxs vsvvptn zvckqo wxs\r\nunyet prchn fiwter wvgknes dvzbxfs ufet neuyt fczlrx bpocdci vdsfzbx\r\nznfev fwrdarx knqkv ojiv ojiv fwrdarx\r\ntbtlo hdashg kyspxm ypmkxs nmrk\r\nfzr zqxaszt frz xzrre\r\nshueb iraetk uhsv duvah uhsv zstysc nrfllbc emrknka\r\nvzkrmp mgtkjnw njr bwjgp jdwyyhv yudha wbvmx ewu urhiioq\r\nyjq xxr swvm aipdj apjid tfsq gfqg izrvhev\r\niljuqt fpo fxadit iljuqt iljuqt\r\nzrj poewso vsje bsprbmc vsje yfwf ybu dmkqib ybu hlrpdi ymh\r\napxaeq bgdm mqty whyay mnuzfgk awm bgdm mwwi ekw bgdm\r\ndpdbfkm crrg mkph kphm grcr ukbk\r\nilqm wroz mqil qlim\r\npnlx nwadw uabelu rueamxr wjer uwge jwer ywagrx\r\nakuil nkh oitq werli werli\r\nfkmhcr ieoj xfsa xfacoeb tcg poomcme vck zmpc djcqgkf kft\r\ncsyk qni hqfrye zyyxz ggynzad pjpokmu bigqa qie\r\nlkpenw zyllii qtbvdq zqnu ichftg xazped agl irhlbiy snlwfe twliar\r\nacsrba dzz ivylbl rfcdd rfcdd qcg\r\nzbui fomvpx zjhmgl sivtffu xuhswzt fzeid tgj mzok mozk afbhuje tzswxuh\r\nnupjiat fdxkbn tuatp jhdfnub yitdk yghqw nupjiat ibi edfv tuixw auwjm\r\nfocht mnprh tljj ayp\r\npjdnl uaoworh iqm gic dqlu spn heuymio\r\nkvg ferrvhp unvzsd qdcpd rji zpch\r\nnhvay chuzg pyhdd hnmrnq zeidhf pyhdd ohy hnmrnq\r\nboa sau gxh grx\r\ngwo utwpd zcsrx gow bnm\r\nxoqniyd hmithl xoqniyd hmithl\r\nyqqsbzo stca zcsjnqf skbueeu tlbkef mvqbg igzr wujuz yqqsbzo kkfe\r\nwgzuepu wge fkrxuag csenx tkngoz wge azueyxs\r\nget xiryxs xiryxs xiryxs\r\nwammvx edy hahetl xmvawm dye\r\nlscxxgi anmax quo cqprwn imocarq gnbfhe rcnqpw\r\nznpmid yaluvzn ydm ckh uhso rrk wbby lwxsu\r\natppk byf dzz uift nqejgm njgeqm\r\ndtqmy iog ahub habu\r\nhkthdwt pfxlwsu hkthdwt hkthdwt\r\ntsuiue tsuiue yais tsuiue\r\nswooqmp rqrcs ngr vujrq inuu rqrcs\r\ndhu zxdfiyv xuz xuz mgaty mgaty\r\nkiiiz zco qdv vfgkj rders zco\r\ntrszp havbm redpeqk gktp ifvzvwl yfoxnm tzg avzd otiouso eks lqlutwb\r\ncfiru lpdy kpeas mdc lxnjjqz nqyyb xkjsug rcifu dln\r\njga ijgkjo qhbnupb ofzqn iokjjg gaj lrh pkynrcr jgatk\r\nbexwc tat tat otsngaa\r\nfeh mjxbs ehf cyfhlv vvdgdu hef\r\nnjlvq ojwaes awsejo ktyvxd qeyeze bpoaj ulgngn zyeqee kqc bsdzzvq\r\nhbfp vnhs vnhs pko pxnxgm\r\nbmy bzpn bzpn bcfep\r\ncju nqjy yjqn bbrj esgzw swgl bjrb\r\ncxvrshm rbglkyv kqwzcyd azqr ckwbbew fhgqv nfk lactzh ssqpwbr wbewbck\r\nptcb gqkb apcc okl jbbgk qni bqu slydyo qhh dqd osv\r\nzbisefn bmxcljk bmxcljk arkamus vpq uxuwvb\r\nksik xbzk lahh ctfur sxh rduokr xqou zwbgqsp skik\r\nhwhmfk hwhmfk bjpxzg qqftmu ijyv igvayf bjpxzg\r\naskxqew tibx pqaczy fhzyec echzfy cezfhy\r\nomzyy mbzfvsn kkoff qgqn crnnkn krx oqp jhn anb qte qxt\r\njypnwn vjbnbsl axf pldxbq pdoy rmxcvig cpad yhah rzqewkg nmzkkr erjo\r\nvisidzp bujlfn xuomjj mjnqn wgflg skb\r\noer oer lfi zyqnem lfi guljz\r\nfannhwu wafma gcje cvcia qwyh ugtbpa geufqg\r\nkwtjib pqwai tdmjj kuxr euzl rxuk\r\novi splc hflutgw hflutgw\r\ngvel gelv aeiygth elvg twwr kivxrrj jkmqa\r\nbas ylxbdgn yliv pytkhq haujsyf fggrnbc wsgree rfnppcx key gvdzgfy evdtrrz\r\noblab wpgm bpyy xuroy qhb adqko\r\nhneb law uzms fhhk yjymdx wjla ixfh yblh\r\nqlvsd bxsq hjaq fuwspzu hyshq idbabc rqcih ilixp wft rglf lmqm\r\nqdskj two ckd qdt hzjvd woo fmmuw\r\nkumc zywzq srafcbb ihfu kfvav\r\nqlkkrq qlkkrq qlkkrq qsc\r\nhob bpecik zqtrfz iqizeu plrer epm zqtrfz xrekeql xrekeql\r\nwarszd sxyyorh sxyyorh eztjf warszd kszp\r\nhjbrax liumjue liumjue liumjue\r\nrfnqd folmiu dlicln pdyk uqd rfnqd\r\nmjdu lytfvya xomdujn leaqiyc lgemz lihfnhv zgeml koukz luqda\r\nyqsz zedjmwn aep qwbhd yqsz\r\netg rmovps abizj yqr kib\r\nyznxec sfqkd ofkzep njr hmeym nsh xdq\r\nryoyq heoo zuo udvfev ehoo axcnbpu oeho mfenmd shrebzy\r\nuaeh jwllsjp frkhqsy uaeh\r\ngiofw hwceb euikqp ldmb kqpkxwv namazcg hqyyzgs cglsqux\r\nqledbd qledbd kbwo wgfmgp\r\nolbsca muxw nxs locsba\r\ngbxxgj xlzm gws pkpwy ofkxb sykhdo nbhrv\r\nnajr bfk tbqkm hxabe nvr mdi dmuujr bfil nyripr zcydzy\r\nkiczhcn dfgylw yzkwk nytijj pceu yukj ekaol xpb uep\r\nacyyxn rwczsud acyyxn payiek inusyb rwczsud\r\nmzssokx bshs bshs ocrvlug nzsgvch riejkrd jkj mpmdgsp kvixdfq msmmx\r\nuaxy wpvhf uaaq ranp vfhwp iik kii nvh\r\nshecxef nqpx jly dzm qvmpu kxg hdg\r\nxembm yzevult ljrllc yrlskyk zas wstnz yrlskyk vasra\r\nyoaxppi kzax hvxfezf mek teo cbtlrfa ncxac yee\r\ndzfpbi cynov dje vxypba wcwww cwnu cqtp cnuw wwwcw rkzas\r\nxzwdt jcwv anb xzwdt\r\nfodgjem fmmrsfl eovsneo etzutda paw fmmrsfl jcqql\r\nyfztt alcw nwdmd afgknu njxkj zykz cvv jbnl han iatmruu trqls\r\nyas hpulrmf dzts sltg qsbw fjj rjymnnx dkkv\r\nhwjtgd abmb cfw xoumxn xnoumx cxo xnxmuo alb\r\nhnl zgdiip lrddhl fyw mporhtp waedf dltdfmc lyipoth ubmg hnl\r\nwxard wxard cibp nzquvb muuslvw igvewfh mika wxard\r\ncjqjhva rrhzy qpdc nqnyd enbdee ewrhp cqdp xekgjai\r\naxtmxb axtmxb phl urdqaar urdqaar\r\numce jult bkart dgdvdwc kqzlzn nqkzlz umlxx cmue xvehqag wxifal\r\nlwsuc ski ubo ksi sik qwcudv\r\nhusdv tssr gfp bfzbrp jtmk svvdpb uvshd zbnpdmj svpdvb\r\nnnbvf xbb dobqk xwloqca uxvqti blcwxpu kubwu nognin goywn\r\nxhe dhddftc ggltd dhddftc wspf\r\njodq cgvnk lpl wkwwlqd prfby bpyfr tbgyqm\r\nbdebxj cuvow jdwdxw kuzh dvxmsyb dyvcxo psf kjnoe odfwgfa\r\nxpfb knzgfsi thmsnbi ymjxn bevohy xpfb\r\nhphcu fjodpdt mfsp jkvvp jvypar nlud lfv uftupcr nul dunl\r\nolz ihyhw qntr lwcbohv qntr wzralwl\r\nkfz pkjhidy msnmwz exox xexo uakipj mmznws zbbji ozispqb\r\ngfi kwdhx qqo kdxwh fig\r\nehh rfozwr caoisw qntlk pkv zulc kpv hrqz\r\nexmlrj aacc rzb qie rzb\r\nmxyqe cuqz feyd meqyx gdvpu rqyjtvw dmoo vugdp emem\r\nadvj xmnad uvh ufnbi xmnad xmnad zzwjksx chbrjas hrbp ruvyg\r\nnasrghk pmol ryko ofgakhd korf vpy nakrsgh\r\nmylyqg aeizp rnk krlwchk aaqg\r\nedxursp sosyv zesgnpx zlo sly alurdc ypmez qib aqtt lmxd\r\nihm hwzhd jhiw raocjk nlxce yzuzu nhudri tvygl tmclg mdkz\r\npsubdis qrmxebg kdac xvl raxwfx vlx sxme\r\ntci tphdy tggam vqqiyjz sgfvdri sxhztz fhsmxx yaj ncxcxq tic\r\nxkljs cuhrm fdjqwd fuzyzh dzuzgjd lzpye lzpey\r\njriwl ypkcxd fxrg eit okzzzsc yaykarm qzuv jurgek dzfbbfl\r\nworkf rrw absfl gxluw qprdsz absfl qwqbmi amepvz oiqmy workf\r\ndxyyb brnerbx lykd oqmz ursl zqom\r\ncqtuzva aih uhaswd auhwds ktyvc hufogcg\r\njre fhlgrse svedc prfspaj ghm qcjzfc nsd\r\nfow xyo vlvg sgg jgzvff rjxh eovre xtupnz\r\npekj pgiecc igxd zbiqoob ovv\r\nxofxmz rdzdiq yruoqkh arfunx yruoqkh ucm bxov\r\nctogwj lpv ivtoxkf faj ctogwj xfzluad ctogwj vvw\r\nrmc vjxj strgo tykifpp\r\nulivozu bczond ywnmt shakc yknr psr\r\nbfx alwedh jfomlf pzj tely alwedh vccsoer rgwftcl vccsoer\r\nfrkwbv uudwt qsfg onuhiml jrd usu\r\nbgdx deybefo gdj dgbx luu cbuwawd wqqtq dqmwy gin mhtfgy\r\nohjp ykemg nrs leayrh brtipx jhop phoj\r\nutaep ywsy utaep ywsy\r\nqow dxagjwb qbki bqik\r\nlarkpq bdgw mly vvwgv\r\njuar zaerof qekpe hhgd eygru epekq dhgh\r\nxpblz xksc lzue xksc yid nnve trlndn gjczngs cifqoaf\r\nfpv ekz eknldf uqjgeu awwnwxu eknldf eknldf txhxv\r\nmzvk wqtbda ovdbh vnes uiuuc uicuu bpwwtm aaat cygej nio gnl\r\nrkdkzp bjaxqif xuwx bjaxqif hgtz slkqw rkdkzp ztp xfvgk ycvg\r\nzpwr wvxzfcd opgcrfc ytxeboe rcqa ehrga lmgm\r\nbrsdnk nqgkjab nbjkaqg gho zqe\r\nszbysu oqrtbp wjpuv oqrtbp oqrtbp gjmqq\r\nuoyi ctscw uoyi ggn ija\r\nfop lxa cgwpw lyvrxbe tit fop fop kfigqnu\r\nldqmk rxo ajhrbc ahrcjb xqdk kdxq\r\nith vdrl kvaxktm grkzmon ith ywbz kmnoiz\r\nzdoo omjo fbz dveiipw fbz\r\nivj mcnu tkijlq xkq lrkyit cumn sfkrk numc ezxeeoi\r\nlcwzdi sbsdgdy olvc olvc bimubzf bimubzf\r\ncdjd umhwh djdc cddj oxheq veazlm\r\ngxszn zsgxn azy yaz\r\nbyvmj mjybv jvxkuy akas uxyjvk\r\nwhmkttq whgzm gwmzh pkvtljw zgmhw jasudeq\r\nyyjri fxsj xffmna vbal ftff rwq uszym bznil rfuctp ejndv wqr\r\ngnwzjbw dezfvq gzkhzkl ivrdvxx wfah xvivrxd qzdvfe\r\nxnfo zqzn iaod zlcclsd onxf lpskrfk nzqz kqzr kffpwak eky\r\nmuc tafbzp nra gvzc xiu gvzc\r\ngfnbnyj nyjbfgn eoosw yjzf\r\nqwwls sqwwl mxph swwql\r\ntwor uzjftq twro orwt\r\nqomjuob bqaim zvfqww cvqzm wwipc zsywb bsqkp aoj fus\r\nnlyd gtbgox tajlzgs bgtgxo pqt\r\npjtmgz ulblj ussh gngagba hhtexq bjbj obe xctciay osriw obe shxri\r\nagc ejjdtak jgq moj agc iua syhxih znavmrc iih qubj\r\nzxwzwhm lipkqhz bbv birxsj gzg iefrjh mprsfs ofpltbl gbo srpmsf hirm\r\nrbpgqoe kymrf uzsut gkbtd xctpg qul hirtfl\r\nwfvg pnqhuv jayjm ftqt mbrotl aydmoc lfwlxk vpvcsi svbn bnsv\r\njxjxza ysl kls vmt fvgunx hketl oshgie\r\ndfeyxv akx qagwayp qrs lnulrle rqs gbvd bvdg\r\naac ndptml oke edwrg aac xechxz\r\nmpx yrb oervzb ydvkw avlt oervzb bxdqbo hzwls\r\ndsynfk dsynfk epexzjd epexzjd zofb\r\nvhe zxfolqk lkh fxt flzkxqo lztwkmo khl\r\nizlthi wtokkuz ousbpxp pvr uuxueq lvbeff mfk syjq fwgnfmg yytqesm gdd\r\nkjcg slt khz atzw twpspdx kgyk wgq hjat ntf xvhxol msvdjs\r\nymm arrggw mmmbvrs ist arrggw nbvvc cwyacp\r\nkuzglex iemp iemp jsko iemp oqs dheqypr\r\ntzztq dsxqbow qgaeo kqn dsxqbow qqzpv\r\nysr fctpiyn psgb gatavv zsfxoxq nynfoh qaimoj zotjk nxug syr\r\nxvm qvr hdxyhpf cbo xmv lfv wltyjlx\r\nhjq pohc xgqit tducggu zdqmnc xqgit tqxgi srfyzu vdikqx\r\nmsiqte ewvp bzrv cmuy gse qqayvb bzrv qehy\r\nwatdvu ametrc etlduhh vcc luehdth udavtw\r\njktj mkq jktj mkq\r\nuekth ufjkmdi qzhge wzwcwk nvrodcc vrcdocn bhcvd\r\nxumywk zwofh kuxmyw acgzsjj hfowz njnz bnklyi\r\nhmm fexu fexu hmm\r\nzeuoarc yoa ggff jazzd mjein yhj qwo qwo\r\nrolkwf fcyat lwm wqqm juwkt wqqm udj tex xgps nyy pdbkkhb\r\ngld ksl gld bnsuhqc gld rwmybj\r\ntvyxk xgmk cri pef epf unsl yktxv\r\nmuiql ejq taetjkf ejq xzmo wmv qbtmrh hkfbch taetjkf sut\r\npqg icvv gpq tufd iixd duft\r\nzekx ybbb gzml vrbwcl opfb fkrv tto cbipr\r\nmoh stkkf ynrtdf jlgb kstfk ksktf\r\nnvysvf mdtdoq bqqvr bqqvr\r\ndqyz mzoqtp gzhdgd symsq iwh bpwox\r\npkqi jgzsrah yfjxx kdp xjaf lbj gkpixnj tyvzzso qmjbo skg nlchzbk\r\nculxfx jarwu eiwriu vwvg gvwv sgnasz\r\nkyfsn dwc sbnoe xwpgjh nbmvec dwc qjdh mpw gefimue fvqjwt kkor\r\nhcdcgxs fof flc hfpjy lii fihcao pxg xywei jwsq yxr\r\noxrcv pda oxrcv gdvojsz kmlga mixlmp hdcabsn qvoa fwt\r\npoe joylchz humrjy cyxbqfm lyk ybrfmp qmtpqyk vtpr lyk vtpr\r\nffswqs yxbuj tfzkmc yxbuj giog ckubbfy rtigw rtigw rpitxd\r\nkcvrn eejyftw ejytfew rnckv\r\nlvk lkv cooumh vlk\r\nloypv ukowl loypv nyoyfl vehnm uff\r\ntst sei zovy itdwibj mcbtst wcf rzp xvbtax ffzp xieenuy aegkj\r\nzkhi hvsbgza xbwtdns wypfngy lvabd pybhcd crczm buikdpo vqgon pynfwyg phbcdy\r\nihy irxrj entmc yxfhbta xsdv xsdv\r\nezrcv kfgm pjneez puccy gzpxdlf gkfm yucpc mli xezfug\r\numjppkq idkiri wmnbhi unl nteyw wmnbhi zyv idkiri shhcrau\r\ndzj zveqwae ljnikvb baavr dhsohp zveqwae goq zveqwae\r\nxhc xch bmttdr snd jakd\r\njmgnvda bdpzfw dfwpzb pimpv blqtbyo lzdzo bgrlfy anmjvdg\r\nlwvu ksg gqbtibd ksg lwvu ohfzlt foajo apyrcwj uaro\r\nvel qksrwp zei ipnvd hdua rkspqw bujf\r\niozkiu upa knmcug zidypn yswb zswkvx naqsu\r\ntjktoe dqpt pbqi dqpt\r\nlcl tui uoizm xrdpmwi fbsuuqq tgeac hpajm tegac nczlic\r\nntmm mskzb arem ntmm jayzfe wyurgsh eqwcqt edhska asxhjv jayzfe\r\njyq juifidx fokzxh cgo xofhzk nhro xyccuq ioa nwk nqaxpfw\r\ncvag bpk cuo ocu buehhq tartafi ifs qwh cveurg\r\nbwut xpfni qzg cmp cid jftawv twiszmo\r\nzgxc sui kypkd vpam ymxicrw jcfbutd fgx jcfbutd\r\ntkxn rjqzljh tkxn mdwcho\r\nqbv zneocv zneocv zneocv\r\ntywf soncr lyepx qzj xdsr pdqv swt\r\nulu rdk iomqu dgouoba icax\r\nddsc oxilqpd ddsc atbekg ouzmxf oxilqpd kwtzz yhmyd otvi\r\nvtj llnfrpc vfighju urosrsz vurtse llnfrpc qeuo vfighju nnn smsnp tfom\r\nupdfjmz ngtgi zaitq rqqhcyn ladzx zaitq fbaphyz hipe\r\nrii fpos atl tal qhubqdv lat\r\nwhxzwdj yznkngr eefbmub wnxitd tnwxid zja ziewilm xylwn ihhsha lrptuyf\r\nfhmzaxv mdn udl gyv pqw qlrz flm rqtji\r\nbgn clnm cnml qyh hhf qqnur sgvigvm\r\nqjtbysc ycbqjts gbgvlz vgzlgb dgxks qbvp grji dcc\r\nwmduuq qayymzo zvh ylbipw sin ybwpli ilypwb\r\nqsvzktt qsvzktt dasmg knh gcgep qai\r\njxukj qlgr cjssj aavqv\r\nxpxa glsdfxq ngxwon ytuue pizqu\r\nfxl vegoed tct luwm ulwm eeovdg\r\nntmpe auasx vkwgi cryuiix dmiufo fcb ldl jauncf gyouym asjcryc\r\nlgwdcs eoxm hcrpnuf pcfnhru vlye fpurcnh uquukv vjc\r\nlfns riwpdh phwxvew hhu jfptvv ofxd hkotgfq\r\nqvuwnq wnpvs xdivrfz yaenqr fipwgl\r\nvhcexfd bishqsc gsbruxm yzccyot yjloa aptg vbr gsbruxm ihqhyz yzccyot\r\nknfst zhihi swhhq zhihi\r\nqfto abhjx abhjx bpnijn ogmqxn rclqag dmeb rdogx emfriui hyvp ogmqxn\r\nivaemm wlsc dvjv aivemm xvf shfonv\r\nvowhosr vptlu ucrut rdynh ttqvhg rdynh abtja pnvdy puxfmf dyhd\r\nuvrenol ycuhvy ygm fjsxiwo oftstid ygm\r\nfix qrqeg dfgvlun fix iraxgtt lhgqdo eqkgshd jwmrm qrsbzba\r\nmxdj icjqzqw fvew gtvlhm mxdj\r\ncyjtkm crb pmg jwo iluc brc ttnd\r\ndasmgp ool ool opc\r\nubi pmz mtkh ibu hlx ipcvjki sydw zpm eewfdeu oga\r\navex yjaoghv yjaoghv lwwx\r\nkwkdst iuokd nmpw onayet zlavwnd wwvbr jtrkyku wfxx dumydgh gnd zgi\r\nahyjnc rjakp bhabq tsmfi ahyjnc tsmfi yitqgi uwnywil shnkbn\r\nkrr sbbfjtm yvunas hwppsjf ntuuzw ngyvdmt ynk nfq mfrb pyw hngr\r\neeecesf phoo ijmx sjp kgmtg sjp wyz\r\nqwixmou oximqwu ixu lsmf\r\ndyrzq lbstdjv ldvowml qjf fqj zpabc dwmvoll jnq\r\npdtlu hgcfvz mnwjyq ymi cvcp kmx mkx ooffp uiwg opoff uevqt\r\nhflomt fhlmto gutdbyp xyi zpggxc wqe\r\njpsr wwex yjgdj fqah wrmmw nyrnw hcomcgv teajmu emw zrraid\r\ntvgsca bzgzkga ypsxsk dqz exmu tvgsca dqz qnd\r\narzn hojpi bznw ejuupe bznw hojpi\r\nrids dule qaefaon sspit mtzgdls cfujw xldhimi igdoy dule\r\nnefsys plea obksngc zxqee avsi obksngc vnsxdrl gspadob avsi owmzpeh tcj\r\noweq fkr krf rfk ztwjdry shzcmew jhna\r\nhdjizhg dfclic usds luz mcwyj luz qvomls mren otax\r\npmzzfj pmzzfj wfxyq mqv hyp lhf\r\ndxeaw ckkey ccvawo keaf izlh oacvcw lgcpgeh kdiky\r\nxkwe xekw kwex tzfyx\r\ndmmyt mtdnqw pdw vdav ofrtsk\r\nklz zlk snxnihg snhigxn zkynpd\r\nijzce xobf uojezxi xiuojez\r\nztepv zvpet nije aditjlg natkkk dtitg jprgia\r\nfesuh wadrhc bayf kktfaf nxvhq smbdaop gqx ioez fkjufb abyf\r\nhej sta pztkcd pesabzz szp iada iada cdae hej sqst luf\r\nxlnuhn oljaf fljao ascxez fojal\r\ndprclb fzn wgauz rxewtp cjrlgz zfn\r\nfidwoa mvoqy afian ntzokap mkplgy jfukgjv cyfsz\r\nhbvqnnt giinuzq uezugy qooxjc zsxr rnihg ipbels\r\nqroi wtltjq suj tqit bxtc jidzhpe nizp wtltjq nadcdm wwyhjrg\r\nqtr fkbl bpptu baen awjpwsg vvqbxz animt uqbk zvbxvq\r\nnznq fdiul jbv umyrf yufrm hrl duilf\r\nbkvlfuw onkqzeo iwrg rifqzhj mgroul rnor qqqc sbfi hny zosfp kopxb\r\nnvifbx jbowbj fnyskt jbowbj xvun xvun\r\npiyl haajm stwzpp xvjg amjah\r\ngye efwwwiv kyv zmtcgmi ifwvwew\r\ndflx gdtb jyoj jyoj dflx aqhycgi xffnn\r\ninc mpys mzqmcwx vryz ibqrzc pmsy fat rojpxwy rcbqzi gjef\r\n";

// Part 1 - Count how many passphrases are valid.
// A passphrase is valid if it doesn't contain any duplicate words

int validPassphraseCount = 0;

string[] passphrases = myInput.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

foreach (string passphrase in passphrases)
{
    string[] passphraseParts = passphrase.Split(' ');
    if (passphraseParts.Length == passphraseParts.Distinct().Count()) validPassphraseCount++;
}

Console.WriteLine("Part 1 - Valid passphrase count: " + validPassphraseCount);

// Part 2 - Count how many passphrases are valid (again :))
// A passphrase is valid if it doesn't contain any duplicate sequence of chars in any order

validPassphraseCount = 0;

foreach (string passphrase in passphrases)
{
    string[] passphraseParts = passphrase.Split(' ');

    //preprocess all parts to sort all chars in a passphase, so anagrams are filtered out
    for (int i = 0; i < passphraseParts.Length; i++)
    {
        passphraseParts[i] = string.Concat (passphraseParts[i].Order());
    }

    if (passphraseParts.Length == passphraseParts.Distinct().Count()) validPassphraseCount++;
}

Console.WriteLine("Part 2 - Valid passphrase count: " + validPassphraseCount);

