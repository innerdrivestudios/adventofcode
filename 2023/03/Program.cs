﻿// Solution for https://adventofcode.com/2023/day/3 (Ctrl+Click in VS to follow link)

// Your input: a grid with numbers and not numbers

using System.Text.RegularExpressions;

string testInput = "467..114..\r\n...*......\r\n..35..633.\r\n......#...\r\n617*......\r\n.....+.58.\r\n..592.....\r\n......755.\r\n...$.*....\r\n.664.598..";
string myInput = "....401.............425.......323......791......697...............963............................................420........................\r\n...*..................................%......#.....*....290.........................492.............656...@953.....................+830.....\r\n..159...........823...33.717.....572.......806...896......-.....335....834......815.............791....*..............776...................\r\n.........-.....#........*.........*..................715..........*.....*........*.....................5...*.....................688........\r\n....=..=..573..............212.......553.632....622....*.......260....29.........692.129....727...........290.........%32.....%...*..441....\r\n.791..998..............................*............531.......................84.......*..../.......506%......=............240..831..*......\r\n.....................321.586........447...&.-276.21......@..........12.......&.......-..333...................619..94................982....\r\n..........@...........#..*..............525.......*...183............*............407.......23.........%............&......846..............\r\n....97..686.............89.....................-..494..............875....*607.............*.......239.407..................%.......529.....\r\n.....+.........815..703............208.=555.856...........@............133........................*..........672...501........898#...*......\r\n...............*.......*...659.......*....................183..............528.......614.......4....................................39......\r\n...602..........804..313....*.......480..............602.............354......*877................832@.....140...$...........707.......222..\r\n...*....999.................23.264..............516.....*.......-....*....................................*.....722......24....*........*...\r\n436....+................./......./..........765*......37.....843....218..........852*68....290............410...........*.....539....896....\r\n.........../...#........907............587...............&................149...............*.......*..............#780..707................\r\n........349....603.598....................-....203.....178.......431......./...............152......571....926.750.............127..........\r\n.............@........*176.283...................*...%......642......../......20..............................*.........@.............534...\r\n...749..../.194..............*.......337.395*....682.429.=...#..........186.....*.........682..../......498..........%.8.............*......\r\n....*..324..........893*...878......*........659..........65....671.189.......641...........+.859.........$.......149....648........53.+....\r\n...776......$.....................667.................432...........*..............697............282.901...................*889........471.\r\n............103............../........-..................-...748&.257.............&...........739*....*......491*543................997.....\r\n.........2.........813*.....278..316.333.....296.142.+...................673.%....../.....+.........490...................790........*......\r\n......@.*.......................*...............*....643.464............*....25....108..807..179.........931.......289..........365...522...\r\n....367.250.927../.............754.........14...............*.+..........23...................*......&.....*..%..........323................\r\n................939...644..............791..*.551....35...937..806...............&.............536.930...703...565......*...............*640\r\n534$.................*.........$..448.....=......*...................707*658.....33....920..74.....................844................36....\r\n.......572....672...875......770.+................380.............52......................*.......-....251............%........*909......677\r\n.......*.......=........................658.889.........882.....=......................534..*..291...%....*.................289.............\r\n.212......993..............438./..........*....@..532......*586.163....213...307...........167.....981.700..................................\r\n....*.....*..................-..12...611...196.......*309.....................+.......*685............................403....243..+385......\r\n59...428..14...22.747....990............*........575...............................247.....985....&..................*.......*..............\r\n.................*........%...539.......416.712.....*2..408.......%....................999.......275......738.....715......670..............\r\n..357........653..............*....374..........285................785.........384......*.............277*........................765.137...\r\n...@..........*..@632......361.......=..............35.........329..............................=858..............798.................*.....\r\n......................216*.......459..................*..........&........479.....255......302......................*.530.........269..453..\r\n............./.573........153.....*........#.......462...%..........45......+.122*............*672....545........157.....*862.....*.........\r\n820....%...977.+...................726...790.199.........631....308..................755..............*...460..................643....#237..\r\n.......229.............727..425............../..........................228........#..$...............385....&...........695................\r\n...................978.*....*....................700....*.........256..@.........625......311.170...+................642*...................\r\n.492.....983.........-.577.743..................*....267.521........%....479.......................696.980......................*...........\r\n....*820.#....................................236.................*......*...856.............137...........489......409........177..450.....\r\n974.........479.$......182..456......./.............*755..617..333.849.........*...............*..........*..........=...-...........*......\r\n...+..........*..83.#....@.=...........893.......610.........*.................727....6*..488.839...449..541../97......560.........449......\r\n............208......168......971..........................547..........559............................=...........237...................641\r\n.......336...................*....563..993.911.=......853................*...............391...@572.................*.......*......614..*...\r\n........$...........579.....810....-......*....480....*......649.138..410..201..604........*..............450#.....485...124.841..*......790\r\n..399...........928.............67..................#..295......*............*...#....333...83...#111.............................635.......\r\n...=........./.....*..807...529..*......642#......603......704.........@....599......&.................=....................................\r\n..............233.618..../........114........566......100..*.....423.26...............................168................555$..........#625.\r\n.....608*372..................543..........*.*............4.....*.......+374.......436*...................680.135....................*......\r\n.................................@...385.309..111......69....991..127........693#......985....25..856*96.+.......*860..........%..278.160...\r\n.......351.......495=.772..............*...............*...........*...........................@............569...............905...........\r\n........................*.$402........640.*.............366.........350...623&...250.............446*341.....=.........................292..\r\n....#..*...595.289...347..........75.......844......307..........................*....585.....*..................766+...................*...\r\n.148..906.....*..........232.449...*...........................................326..$...-..102.595.....406............-...........650....682\r\n..........619...23........$...*.....138.893.......890...79....53.........118........966................+..............233............*......\r\n.........*......../..........62..........*........*....*.............@..*....................245...........-....806.........98........318...\r\n....534+.264..993...420.................675..77..659..263..........615.405...............=..*......%..75...614.*..................4.........\r\n...............*..............421.........................834*287.......................813..651.902...*........134.....$...........334.....\r\n....631....=..443........................352..........941...............317.......*286...............562.855............690....387.....*....\r\n.27...$.430......................89....-....*90...&......%..........155.......899.......%59....*986.................775..............25.....\r\n...*....................-.....+...*...952.........62.........478...........&...../..........694.........775.....640..$......................\r\n....102..........+197....109.270.453.....................................641.......123..........573....*.......=............880.403+........\r\n.........87.186..........................709.+219........224.726...882.............*...868..203*....732............928*607..*...............\r\n..819....*..*.............*....81........*....................-../..%...+..........700.=.......................149............*....438..=...\r\n....#.875..223.106.........646......%.....519...579.............38.....883.626@....................149..........=..........205.272./....480.\r\n.......................965.........332.........*......221.292...........................594..945......*931..365....814*214..................\r\n..228*....29............*....79...........+.....811.....*..*..592..........681.............*....#.427........*................170..58.......\r\n......563...*........817..93*...+60..507...898........796.942...*..=335.......@...490....488.......-......974....817...........*....+.......\r\n...........519..&...................*..........948.............454......184.........*.........=.......................409......947..........\r\n...............272..........257....712............+.@.....338..............*381...824..923..756.............971*181....=....+......430......\r\n....228.............709.......&......................685.....*..597....135......+.....*..........+......471..................452..*......923\r\n....*..................#...........271.....................167.*.........*.......325.935..........224......*.....749&...-..........587......\r\n..464.../199..$..........50...........*..794..........36.......733....................................@....414...........605................\r\n...............765.%.......=.215*717........*715....................210......845.......................643........66...........*908.........\r\n.........215........761............................544....781...390*.....576..*....869..781....517................*.....356.664.......=.....\r\n..............316...........235/...............715*.....-....*.............*..130..........*..@..........&.........564.*...............89...\r\n...................................&....169...........353....390....57.71.847...........716.........466..516..651......447..................\r\n.......459..................101.379.....*......324...................#.#............943..............*...........%.........$625.../...586...\r\n........*.....173...................198..306...*....313........51............629...*..........-958..228.178.......................967.......\r\n......714...@.........206.......934*.........109...........*.........../......*....832...................*........934.....921..........897..\r\n...........487............700......................*507..415....349%...179...961................437.......489.......*............../...*....\r\n.................*440.952*................667...533.....................................359.618....*927.........................968...412...\r\n...........-..778..................667.....@..........764..401.........279.......#.748.....*................534*.....444....................\r\n...835..779......../.....443.........*.........................53/......=......774......=....784...204..385.....929..........+...861........\r\n......%..........74..947*.....187&.874..........&.........................545........752.......$....$...*..................308.....*..284...\r\n........#.................190...........445$..784...51*226...................*............*245..........435.......=...200..........88.*.....\r\n640.....310...&...........*......296..........................................107......943..........244...........662......=..440+....302...\r\n...*..........67........381..............856....349...........790*...911........................901...*......733........844.................\r\n.327..............885........169.....419........*.....62..........70..@..664...........=...422%...*....617.....*....................230*....\r\n...........916...@.............................95....@.....+.........................355.........104...........149......................569.\r\n.............*.........................230.../..............350..............................432.....710............=.........=.............\r\n..925..545..634.....@..297*933...........*....839...33...........34.....162.......577..248.....#...........814...524..........790......9/...\r\n...*...............66....................421............606+..*../.......&.........*....&..129..............=......................529......\r\n659..........253...........$504.......*......................379....&........./..860......+..............&...............%.....658*....310..\r\n........208...*........................354..........................647......326...............911.....503.......11.......293...............\r\n....*.....&.617..511.........885.906......................166/......................589..........*..........749....*931..........915........\r\n.852.908........................*................../........................297.470*........#628..269...613......#................*.........\r\n.........................716.................689...460...737*502...510.............../...........................778.......373..734.....+...\r\n..520=.........../.....*....*226........326.....+.................+............971...362........800$..904.303.........*874..........=..548..\r\n............554.889.720.854......808.....*..258............284*........639/...*...........................*........603.............839......\r\n...........*........................*690.71..*.........314.....795.86.........53.................786%...134...................890*..........\r\n663.....225...%........513...................951..........*........*...............275.995...764.....................=............30........\r\n...*...........353....*...........%......................468.....87..225........31..=.....%.=......../.......886.....84.....................\r\n..694......166........243........380...275..287..............261.....@.....888....*............162...278.......&..........351.534........197\r\n........$.......209.-......261...........*.......876.....15.....*.........*........712.....870...*.......897.....46...........#.............\r\n......450.........%..463.....%.679....119.....=.*....@...@.........871...408..995*...........*...922.+..........*...66.466..................\r\n..............803.........................$.250...493...............&.............356.519.552........737.......153....*.............+.......\r\n......982........*.....................540...................641.......................*......&....................................851../...\r\n..............638..............=.306....................+938..@................*520....511.174......*..........-......*503...832.........219\r\n.292..239...................775..*......334..../582...................173...859..................238.678......117..429.......%...708.534....\r\n........*........240....491.....546...................+................*.............%....498.............................55........*.....74\r\n.816.....406.......*...&..............181...........765.......776....+..636...&337...264..*............*716..$908...........*...............\r\n...................860....................980...................$..323....................163.......851............*.......396......501.....\r\n...-..20*197................722..........*...............................&.....408..............109.......794*155..590........./....$.......\r\n.482...........257..........*............999./850.........482..........933........*.*982...../.....*..........................826.......908.\r\n.......%597......@..345.329..172.....295...........349....*.....=527........174.727........645...167......@..........*......................\r\n.....................*.....+..........$.............*....725...............*............$............+.447..723...346.759............967....\r\n............638..............................589.....................................=..312..+....951..........=..........809*..........#...\r\n.............@............325..........322.........&......................508......359......768........8..&.........992.....................\r\n.783.32...................*............*.........656.............98*178.....%.....................74*.....2...410&....@............+........\r\n...*...*..54*525...112..720...66......641.+280.......................................................467.......................580..348.....\r\n..699.673......................................491..869............#......171..............98............473......%..............$..........\r\n........................%.....214.......303$......#..%.......191.852..560*.......835..550...$.150.........#........291.......240............\r\n.......579...982.........713....*...536.......................+...................*....#........$..840.......43................*............\r\n......$.........*....*.......606......+....48...........993.......838*744.880....969........@........*......*....*726..........168...&......\r\n...............395.579............340......*........386.=...420..............*........833..835........257...842....................810...635\r\n......#......................%...........983...632.@........*........-...%..157...193*...........................@..137....209..............\r\n.....819.....................278..377........................578...195..230........................$......586.985...............263.417.....\r\n................592....../............*......../.............................922.......350........138.156*............698...78*.........$571\r\n....................405/..573.764....257.@940...34.977$..441....304.............*.....*................................*.......93..600......\r\n...643....675...262..........................................................993.....556...........314........278.258.322............*......\r\n...*.........*.....&................/.....................222.........959................@..121.......*...930.......#.......170*462.....588.\r\n384....+..19.863..............407=.283.........972...340....#....427*....*737...........558...%.....91......*...........................=...\r\n.....812...@.........298..563....................*......*............506..........845......................634...&............624+...&......\r\n.....................*.....=.....*.............492.563...950..827*...............+....................968......652..................49......\r\n.730.........498..382.........399.......824.........&...................390.630........248...........*.......-......448......-..............\r\n................*......333..........832*.....#...............$...565.....*...............*............701..564.........*.115..718.......313.\r\n.960...*965....993......*.....*..............604..........730...*..................234&..662.....+..............=69.930...*.......967*......\r\n.....30..............355...978...........67.........419........239..........732...............645..........................484........664...\r\n";

string[] lines = myInput
    .Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

// Part 1 - Locate all numbers next to a symbol and sum them

// First locate all numbers and record enough data to do a collision check later

List<(int x, int y, int w, int number)> numbers = new();
List<(int x, int y, char symbol)> symbols = new();   

for (int i = 0; i < lines.Length; i++)
{
    Regex numberParser = new Regex(@"\d+");
    Regex symbolParser = new Regex(@"[^.0-9]");

    foreach (Match match in numberParser.Matches(lines[i]))
    {
        numbers.Add ( (match.Index, i, match.Length, int.Parse(match.Value)));
    }

    foreach (Match match in symbolParser.Matches(lines[i]))
    {
        symbols.Add((match.Index, i, match.Value[0]));
    }
}

// Now that we have all number info and symbol info, we can run a double collision loop removing any number not next to a symbol
// Make sure to loop backwards so we can remove numbers as we go

for (int i = numbers.Count - 1; i >= 0; i--)
{
    bool nextToSymbol = false;
    for (int j = 0; j < symbols.Count; j++)
    {
        var number = numbers[i];
        var symbol = symbols[j];

        if (
              (
                //sneaky bit, when we know the x, the width is always at least 1, so we don't add the extra + 1
                symbol.x >= number.x - 1 && symbol.x <= number.x + number.w &&
                symbol.y >= number.y - 1 && symbol.y <= number.y + 1
              )
        )
        {
            nextToSymbol = true;
            break;
        }
    }

    if (!nextToSymbol) numbers.RemoveAt(i);
}

Console.WriteLine("Part 1 - Sum of all numbers next to a symbol: " + numbers.Sum(x => x.number));

// Part 2 - Very similar to part 1, but now we need to find all * symbols next to at least to numbers, 
// get its gear ratio (the two numbers in question multiplied together) and add all those ratio's
// In other words, we need to flip the loops and gather all numbers for specific symbols

int gearRatioSum = 0;
List<int> adjacents = new List<int>();

for (int j = 0; j < symbols.Count; j++)
{
    if (symbols[j].symbol != '*') continue;
    adjacents.Clear();

    for (int i = 0; i < numbers.Count; i++)
    {
        var number = numbers[i];
        var symbol = symbols[j];

        if (
            //sneaky bit, when we know the x, the width is always at least 1, so we don't add the extra + 1
            symbol.x >= number.x - 1 && symbol.x <= number.x + number.w &&
            symbol.y >= number.y - 1 && symbol.y <= number.y + 1
        )
        adjacents.Add(number.number);
        if (adjacents.Count > 2) break;
    }

    if (adjacents.Count == 2)
    {
        gearRatioSum += adjacents[0] * adjacents[1];
    }
}

Console.WriteLine("Part 2 - Gear ratio sum: " + gearRatioSum);
