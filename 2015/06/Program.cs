﻿//Solution for https://adventofcode.com/2015/day/6 (Ctrl+Click in VS to follow link)

using System.Drawing;
using System.Text.RegularExpressions;
//define Instruction typedef => instruction = "toggle|turn on|turn off" + bounds (and yes, enums would be better)
using Instruction = (string instruction, System.Drawing.Rectangle bounds);

//Your input: a bunch of instructions to change the state of certain lights in a 2D grid of lights
string myInput = "turn on 489,959 through 759,964\r\nturn off 820,516 through 871,914\r\nturn off 427,423 through 929,502\r\nturn on 774,14 through 977,877\r\nturn on 410,146 through 864,337\r\nturn on 931,331 through 939,812\r\nturn off 756,53 through 923,339\r\nturn off 313,787 through 545,979\r\nturn off 12,823 through 102,934\r\ntoggle 756,965 through 812,992\r\nturn off 743,684 through 789,958\r\ntoggle 120,314 through 745,489\r\ntoggle 692,845 through 866,994\r\nturn off 587,176 through 850,273\r\nturn off 674,321 through 793,388\r\ntoggle 749,672 through 973,965\r\nturn on 943,30 through 990,907\r\nturn on 296,50 through 729,664\r\nturn on 212,957 through 490,987\r\ntoggle 171,31 through 688,88\r\nturn off 991,989 through 994,998\r\nturn off 913,943 through 958,953\r\nturn off 278,258 through 367,386\r\ntoggle 275,796 through 493,971\r\nturn off 70,873 through 798,923\r\ntoggle 258,985 through 663,998\r\nturn on 601,259 through 831,486\r\nturn off 914,94 through 941,102\r\nturn off 558,161 through 994,647\r\nturn on 119,662 through 760,838\r\ntoggle 378,775 through 526,852\r\nturn off 384,670 through 674,972\r\nturn off 249,41 through 270,936\r\nturn on 614,742 through 769,780\r\nturn on 427,70 through 575,441\r\nturn on 410,478 through 985,753\r\nturn off 619,46 through 931,342\r\nturn on 284,55 through 768,922\r\nturn off 40,592 through 728,685\r\nturn on 825,291 through 956,950\r\nturn on 147,843 through 592,909\r\nturn off 218,675 through 972,911\r\ntoggle 249,291 through 350,960\r\nturn off 556,80 through 967,675\r\ntoggle 609,148 through 968,279\r\ntoggle 217,605 through 961,862\r\ntoggle 407,177 through 548,910\r\ntoggle 400,936 through 599,938\r\nturn off 721,101 through 925,455\r\nturn on 268,631 through 735,814\r\ntoggle 549,969 through 612,991\r\ntoggle 553,268 through 689,432\r\nturn off 817,668 through 889,897\r\ntoggle 801,544 through 858,556\r\ntoggle 615,729 through 832,951\r\nturn off 427,477 through 958,948\r\nturn on 164,49 through 852,946\r\nturn on 542,449 through 774,776\r\nturn off 923,196 through 980,446\r\ntoggle 90,310 through 718,846\r\nturn off 657,215 through 744,252\r\nturn off 800,239 through 811,712\r\nturn on 502,90 through 619,760\r\ntoggle 649,512 through 862,844\r\nturn off 334,903 through 823,935\r\nturn off 630,233 through 839,445\r\nturn on 713,67 through 839,865\r\nturn on 932,50 through 982,411\r\nturn off 480,729 through 984,910\r\nturn on 100,219 through 796,395\r\nturn on 758,108 through 850,950\r\nturn off 427,276 through 439,938\r\nturn on 178,284 through 670,536\r\ntoggle 540,27 through 625,102\r\nturn off 906,722 through 936,948\r\ntoggle 345,418 through 859,627\r\ntoggle 175,775 through 580,781\r\ntoggle 863,28 through 929,735\r\nturn off 824,858 through 905,973\r\ntoggle 752,312 through 863,425\r\nturn on 985,716 through 988,852\r\nturn off 68,504 through 763,745\r\ntoggle 76,209 through 810,720\r\nturn off 657,607 through 676,664\r\ntoggle 596,869 through 896,921\r\nturn off 915,411 through 968,945\r\nturn off 368,39 through 902,986\r\nturn on 11,549 through 393,597\r\nturn off 842,893 through 976,911\r\ntoggle 274,106 through 581,329\r\ntoggle 406,403 through 780,950\r\ntoggle 408,988 through 500,994\r\ntoggle 217,73 through 826,951\r\nturn on 917,872 through 961,911\r\ntoggle 394,34 through 510,572\r\ntoggle 424,603 through 583,626\r\ntoggle 106,159 through 755,738\r\nturn off 244,610 through 472,709\r\nturn on 350,265 through 884,690\r\nturn on 688,184 through 928,280\r\ntoggle 279,443 through 720,797\r\nturn off 615,493 through 888,610\r\ntoggle 118,413 through 736,632\r\nturn on 798,782 through 829,813\r\nturn off 250,934 through 442,972\r\nturn on 68,503 through 400,949\r\ntoggle 297,482 through 313,871\r\ntoggle 710,3 through 839,859\r\nturn on 125,300 through 546,888\r\ntoggle 482,39 through 584,159\r\nturn off 536,89 through 765,962\r\nturn on 530,518 through 843,676\r\nturn on 994,467 through 994,676\r\nturn on 623,628 through 744,927\r\ntoggle 704,912 through 837,983\r\nturn on 154,364 through 517,412\r\ntoggle 344,409 through 780,524\r\nturn off 578,740 through 725,879\r\nturn on 251,933 through 632,957\r\nturn on 827,705 through 971,789\r\ntoggle 191,282 through 470,929\r\ntoggle 324,525 through 446,867\r\ntoggle 534,343 through 874,971\r\ntoggle 550,650 through 633,980\r\ntoggle 837,404 through 881,915\r\ntoggle 338,881 through 845,905\r\nturn on 469,462 through 750,696\r\nturn on 741,703 through 892,870\r\nturn off 570,215 through 733,562\r\nturn on 445,576 through 870,775\r\nturn on 466,747 through 554,878\r\nturn off 820,453 through 868,712\r\nturn off 892,706 through 938,792\r\nturn off 300,238 through 894,746\r\nturn off 306,44 through 457,444\r\nturn off 912,569 through 967,963\r\ntoggle 109,756 through 297,867\r\nturn on 37,546 through 41,951\r\nturn on 321,637 through 790,910\r\ntoggle 66,50 through 579,301\r\ntoggle 933,221 through 933,791\r\nturn on 486,676 through 878,797\r\nturn on 417,231 through 556,317\r\ntoggle 904,468 through 981,873\r\nturn on 417,675 through 749,712\r\nturn on 692,371 through 821,842\r\ntoggle 324,73 through 830,543\r\nturn on 912,490 through 977,757\r\nturn off 634,872 through 902,949\r\ntoggle 266,779 through 870,798\r\nturn on 772,982 through 990,996\r\nturn off 607,46 through 798,559\r\nturn on 295,602 through 963,987\r\nturn on 657,86 through 944,742\r\nturn off 334,639 through 456,821\r\nturn off 997,667 through 997,670\r\nturn off 725,832 through 951,945\r\nturn off 30,120 through 952,984\r\nturn on 860,965 through 917,976\r\ntoggle 471,997 through 840,998\r\nturn off 319,307 through 928,504\r\ntoggle 823,631 through 940,908\r\ntoggle 969,984 through 981,993\r\nturn off 691,319 through 865,954\r\ntoggle 911,926 through 938,929\r\nturn on 953,937 through 968,991\r\ntoggle 914,643 through 975,840\r\nturn on 266,982 through 436,996\r\nturn off 101,896 through 321,932\r\nturn off 193,852 through 751,885\r\nturn off 576,532 through 863,684\r\nturn on 761,456 through 940,783\r\nturn on 20,290 through 398,933\r\nturn off 435,335 through 644,652\r\nturn on 830,569 through 905,770\r\nturn off 630,517 through 905,654\r\nturn on 664,53 through 886,976\r\ntoggle 275,416 through 408,719\r\nturn on 370,621 through 515,793\r\nturn on 483,373 through 654,749\r\nturn on 656,786 through 847,928\r\nturn off 532,752 through 945,974\r\ntoggle 301,150 through 880,792\r\nturn off 951,488 through 958,952\r\nturn on 207,729 through 882,828\r\ntoggle 694,532 through 973,961\r\ntoggle 676,639 through 891,802\r\nturn off 653,6 through 905,519\r\ntoggle 391,109 through 418,312\r\nturn on 877,423 through 957,932\r\nturn on 340,145 through 563,522\r\nturn off 978,467 through 988,895\r\nturn off 396,418 through 420,885\r\nturn off 31,308 through 816,316\r\nturn on 107,675 through 758,824\r\nturn on 61,82 through 789,876\r\nturn on 750,743 through 754,760\r\ntoggle 88,733 through 736,968\r\nturn off 754,349 through 849,897\r\ntoggle 157,50 through 975,781\r\nturn off 230,231 through 865,842\r\nturn off 516,317 through 630,329\r\nturn off 697,820 through 829,903\r\nturn on 218,250 through 271,732\r\ntoggle 56,167 through 404,431\r\ntoggle 626,891 through 680,927\r\ntoggle 370,207 through 791,514\r\ntoggle 860,74 through 949,888\r\nturn on 416,527 through 616,541\r\nturn off 745,449 through 786,908\r\nturn on 485,554 through 689,689\r\nturn on 586,62 through 693,141\r\ntoggle 506,759 through 768,829\r\nturn on 473,109 through 929,166\r\nturn on 760,617 through 773,789\r\ntoggle 595,683 through 618,789\r\nturn off 210,775 through 825,972\r\ntoggle 12,426 through 179,982\r\nturn on 774,539 through 778,786\r\nturn on 102,498 through 121,807\r\nturn off 706,897 through 834,965\r\nturn off 678,529 through 824,627\r\nturn on 7,765 through 615,870\r\nturn off 730,872 through 974,943\r\nturn off 595,626 through 836,711\r\nturn off 215,424 through 841,959\r\ntoggle 341,780 through 861,813\r\ntoggle 507,503 through 568,822\r\nturn on 252,603 through 349,655\r\ntoggle 93,521 through 154,834\r\nturn on 565,682 through 951,954\r\nturn on 544,318 through 703,418\r\ntoggle 756,953 through 891,964\r\nturn on 531,123 through 856,991\r\nturn on 148,315 through 776,559\r\nturn off 925,835 through 963,971\r\nturn on 895,944 through 967,964\r\nturn off 102,527 through 650,747\r\ntoggle 626,105 through 738,720\r\nturn off 160,75 through 384,922\r\ntoggle 813,724 through 903,941\r\nturn on 207,107 through 982,849\r\ntoggle 750,505 through 961,697\r\ntoggle 105,410 through 885,819\r\nturn on 226,104 through 298,283\r\nturn off 224,604 through 508,762\r\nturn on 477,368 through 523,506\r\nturn off 477,901 through 627,936\r\nturn off 887,131 through 889,670\r\nturn on 896,994 through 938,999\r\ntoggle 401,580 through 493,728\r\ntoggle 987,184 through 991,205\r\nturn on 821,643 through 882,674\r\ntoggle 784,940 through 968,959\r\nturn off 251,293 through 274,632\r\nturn off 339,840 through 341,844\r\nturn off 675,351 through 675,836\r\ntoggle 918,857 through 944,886\r\ntoggle 70,253 through 918,736\r\nturn off 612,604 through 772,680\r\nturn off 277,40 through 828,348\r\ntoggle 692,139 through 698,880\r\ntoggle 124,446 through 883,453\r\ntoggle 969,932 through 990,945\r\ntoggle 855,692 through 993,693\r\ntoggle 722,472 through 887,899\r\ntoggle 978,149 through 985,442\r\ntoggle 837,540 through 916,889\r\nturn off 612,2 through 835,82\r\ntoggle 560,767 through 878,856\r\nturn on 461,734 through 524,991\r\ntoggle 206,824 through 976,912\r\nturn on 826,610 through 879,892\r\nturn on 577,699 through 956,933\r\nturn off 9,250 through 50,529\r\nturn off 77,657 through 817,677\r\nturn on 68,419 through 86,426\r\nturn on 991,720 through 992,784\r\nturn on 668,20 through 935,470\r\nturn off 133,418 through 613,458\r\nturn off 487,286 through 540,328\r\ntoggle 247,874 through 840,955\r\ntoggle 301,808 through 754,970\r\nturn off 34,194 through 578,203\r\nturn off 451,49 through 492,921\r\nturn on 907,256 through 912,737\r\nturn off 479,305 through 702,587\r\nturn on 545,583 through 732,749\r\ntoggle 11,16 through 725,868\r\nturn on 965,343 through 986,908\r\nturn on 674,953 through 820,965\r\ntoggle 398,147 through 504,583\r\nturn off 778,194 through 898,298\r\nturn on 179,140 through 350,852\r\nturn off 241,118 through 530,832\r\nturn off 41,447 through 932,737\r\nturn off 820,663 through 832,982\r\nturn on 550,460 through 964,782\r\nturn on 31,760 through 655,892\r\ntoggle 628,958 through 811,992\r\n";

//Your task: to evaluate the status of the lights in the grid based on different interpretations of the given instructions

//Step 1: parse the given instruction list of instructions into an easier to handle format

Regex instructionParser = new Regex(@"(toggle|turn on|turn off) (\d+),(\d+) through (\d+),(\d+)\r\n");
MatchCollection matches = instructionParser.Matches(myInput);
List<Instruction> instructions = new List<Instruction>();

foreach (Match match in matches)
{
    Instruction instruction = new Instruction(
        match.Groups[1].Value, 						//toggle|turn on|turn off
        new Rectangle (
            int.Parse(match.Groups[2].Value),		//first number (\+d)
            int.Parse(match.Groups[3].Value),		//second number (\+d)
            int.Parse(match.Groups[4].Value),		//etc
            int.Parse(match.Groups[5].Value)        //etc
        )
    );

    instructions.Add(instruction);
}

//Step 2: run the challenges

int size = 1000;
int [,] lights = new int[size, size];
Rectangle lightsArea = new Rectangle(0, 0, size - 1, size - 1);

Part1();
Part2();

//Interpretes all instructions as is (on/off/toggle)
void Part1()
{
    foreach (Instruction instruction in instructions)
    {
        switch (instruction.instruction)
        {
            case "turn on":
                Loop(instruction.bounds, (x,y) => lights[x,y] = 1);
                break;
            case "turn off":
                Loop(instruction.bounds, (x, y) => lights[x, y] = 0);
                break;
            case "toggle":
                Loop(instruction.bounds, (x, y) => lights[x, y] = 1 - lights[x, y]);
                break;
            default:
                Console.WriteLine("Op not found");
                break;
        }
    }

    int totalOn = 0;
    Loop(lightsArea, (x, y) => totalOn += lights[x, y]);
    
    Console.WriteLine("Part 1:" + totalOn);
}

//Interpretes all instructions as changes in brightness
void Part2()
{
    //Reset lights
    Loop(lightsArea, (x, y) => lights[x, y] = 0);

    foreach (Instruction instruction in instructions)
    {
        switch (instruction.instruction)
        {
            case "turn on":
                Loop(instruction.bounds, (x, y) => lights[x, y] += 1);                                          //brightness + 1
                break;
            case "turn off":
                Loop(instruction.bounds, (x, y) => lights[x, y] = Math.Max (0, lights[x, y] - 1));              //brightness - 1 with a min of 0
                break;
            case "toggle":
                Loop(instruction.bounds, (x, y) => lights[x, y] += 2);                                          //brightness + 2
                break;
            default:
                Console.WriteLine("Op not found");
                break;
        }
    }

    int totalBrightness = 0;
    Loop(lightsArea, (x, y) => totalBrightness += lights[x, y]);

    Console.WriteLine("Part 2:" + totalBrightness);
}

void Loop(Rectangle pBounds, Action<int, int> pFunction)
{
    for (int x = pBounds.X; x <= pBounds.Width; x++)
    {
        for (int y = pBounds.Y; y <= pBounds.Height; y++)
        {
            pFunction(x, y);
        }
    }
}

