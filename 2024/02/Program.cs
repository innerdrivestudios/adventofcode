﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string input = "25 26 29 30 32 35 37 35\r\n15 16 17 20 22 24 26 26\r\n80 81 83 85 89\r\n76 77 79 82 84 87 89 95\r\n73 75 78 81 83 84 81 84\r\n9 10 11 12 11 8\r\n27 28 30 33 35 34 37 37\r\n67 70 69 72 74 78\r\n65 66 69 72 75 72 74 79\r\n22 25 25 26 27 28\r\n47 50 53 53 51\r\n67 70 70 71 74 75 77 77\r\n68 69 71 74 74 78\r\n54 56 58 58 65\r\n19 21 24 28 30 32 34 36\r\n75 78 79 80 84 81\r\n13 16 19 20 23 25 29 29\r\n66 67 69 73 75 78 79 83\r\n41 42 46 49 56\r\n86 87 90 96 97 98 99\r\n67 68 74 76 78 76\r\n64 65 66 67 69 74 75 75\r\n55 58 61 68 72\r\n44 45 48 50 53 54 60 65\r\n41 38 40 42 44 47\r\n50 48 49 52 54 56 54\r\n62 59 61 64 65 66 66\r\n29 27 29 30 31 35\r\n32 29 31 34 40\r\n27 25 27 29 28 31 33 34\r\n68 66 67 65 66 68 70 67\r\n41 38 39 40 43 42 44 44\r\n82 79 81 84 82 86\r\n78 75 74 77 78 85\r\n89 88 91 93 94 97 97 99\r\n63 61 61 62 64 63\r\n44 43 43 45 46 46\r\n86 84 85 85 89\r\n19 18 21 24 24 29\r\n18 17 20 24 25 27 28\r\n15 14 15 17 21 24 22\r\n85 83 86 90 90\r\n28 26 30 32 34 37 41\r\n78 77 78 82 85 92\r\n73 71 77 80 83\r\n12 11 12 14 20 22 24 22\r\n48 47 54 56 56\r\n37 36 41 43 47\r\n83 80 81 83 90 95\r\n53 53 55 57 60\r\n31 31 32 33 36 35\r\n86 86 87 88 91 94 94\r\n82 82 84 86 88 92\r\n17 17 18 19 21 27\r\n29 29 31 28 30 33 36\r\n70 70 71 68 65\r\n1 1 2 1 1\r\n27 27 29 27 31\r\n38 38 41 43 45 48 45 52\r\n40 40 41 43 43 46 49\r\n7 7 7 9 11 14 13\r\n3 3 6 9 10 10 10\r\n20 20 21 21 25\r\n51 51 51 53 60\r\n40 40 41 45 48 49 52\r\n73 73 74 76 79 81 85 83\r\n8 8 12 13 13\r\n40 40 41 43 45 46 50 54\r\n72 72 73 74 78 85\r\n42 42 43 50 51 53\r\n62 62 63 66 69 75 73\r\n28 28 31 32 38 40 40\r\n48 48 51 56 58 59 63\r\n39 39 41 47 50 56\r\n29 33 35 37 38\r\n20 24 27 29 31 32 35 33\r\n55 59 60 62 62\r\n38 42 43 45 47 48 50 54\r\n9 13 15 18 20 23 24 29\r\n72 76 77 80 78 80 83\r\n57 61 64 65 68 67 68 67\r\n72 76 78 79 81 82 79 79\r\n12 16 19 22 25 28 25 29\r\n33 37 38 41 42 39 45\r\n36 40 41 44 44 46\r\n65 69 70 72 75 75 72\r\n9 13 13 15 15\r\n33 37 39 42 45 45 46 50\r\n69 73 76 77 80 80 86\r\n7 11 12 16 18 19\r\n30 34 35 36 40 38\r\n34 38 39 43 45 47 47\r\n2 6 8 12 13 16 20\r\n36 40 43 46 50 55\r\n76 80 85 86 88 91 92\r\n46 50 51 52 59 60 61 60\r\n1 5 7 12 12\r\n61 65 70 71 74 75 79\r\n28 32 35 36 37 44 46 52\r\n24 30 33 35 37\r\n75 82 83 84 87 90 91 88\r\n52 59 60 61 63 65 65\r\n54 59 62 63 65 66 70\r\n17 24 25 27 29 34\r\n57 64 67 70 67 68 70 73\r\n69 76 78 81 83 82 80\r\n13 19 20 18 20 20\r\n20 27 29 28 29 33\r\n10 16 18 15 16 21\r\n66 72 74 77 77 80\r\n62 68 70 73 75 75 72\r\n84 89 89 91 92 95 96 96\r\n21 27 28 28 32\r\n32 37 39 40 43 43 50\r\n18 25 26 29 33 36 37\r\n9 15 16 20 23 25 26 25\r\n49 54 58 61 61\r\n46 52 54 55 57 61 65\r\n21 27 29 30 34 35 36 42\r\n78 83 84 90 92 95\r\n54 61 63 65 66 67 74 72\r\n1 7 9 10 11 17 20 20\r\n39 46 52 55 56 60\r\n7 12 14 16 18 20 26 32\r\n89 87 84 83 84\r\n37 36 35 32 31 29 27 27\r\n48 45 42 41 40 37 34 30\r\n23 21 20 18 17 14 12 7\r\n69 67 65 63 60 63 62\r\n93 91 88 86 89 92\r\n10 8 6 7 7\r\n28 26 24 27 26 24 23 19\r\n54 51 52 51 50 44\r\n65 64 61 60 60 59\r\n18 16 13 10 8 5 5 8\r\n80 78 76 76 76\r\n89 87 84 82 82 79 77 73\r\n27 24 24 21 19 18 11\r\n44 43 39 38 36\r\n15 14 13 10 6 3 2 3\r\n76 73 69 67 64 64\r\n53 51 50 48 44 43 39\r\n20 19 17 15 11 6\r\n50 47 40 37 36\r\n98 96 93 87 84 82 84\r\n43 42 37 34 33 31 28 28\r\n32 30 29 27 20 17 14 10\r\n66 64 62 61 59 53 52 46\r\n17 19 17 14 11 10 7 5\r\n73 76 73 72 71 73\r\n78 80 79 76 75 72 72\r\n16 18 15 13 10 6\r\n93 96 93 91 89 87 84 79\r\n53 55 52 50 48 46 47 44\r\n57 60 57 56 53 52 54 57\r\n59 60 57 58 56 56\r\n61 64 62 59 62 58\r\n36 39 38 41 39 38 33\r\n13 14 14 13 12 11\r\n76 77 74 74 77\r\n8 10 10 9 6 6\r\n55 57 57 55 53 49\r\n51 53 52 52 50 47 40\r\n18 21 19 15 12\r\n83 84 82 78 76 75 73 76\r\n35 38 34 31 31\r\n57 60 58 54 51 48 44\r\n27 30 29 25 23 21 16\r\n12 15 9 7 6 5\r\n20 23 20 15 13 10 9 11\r\n21 22 20 17 12 10 8 8\r\n59 60 57 51 49 46 42\r\n22 24 22 16 14 12 5\r\n71 71 69 68 67 66 64\r\n90 90 88 86 85 87\r\n77 77 76 73 71 71\r\n9 9 7 6 2\r\n91 91 90 88 86 84 83 77\r\n27 27 24 26 25 24 22\r\n55 55 56 54 53 54\r\n84 84 81 83 81 78 75 75\r\n60 60 58 55 56 53 50 46\r\n61 61 63 60 57 56 51\r\n59 59 58 57 57 54\r\n34 34 32 31 31 29 30\r\n33 33 30 30 30\r\n62 62 59 56 56 52\r\n24 24 24 23 16\r\n14 14 13 9 8 6\r\n20 20 19 16 15 11 10 11\r\n96 96 92 91 90 89 89\r\n93 93 89 87 84 82 81 77\r\n62 62 60 56 50\r\n72 72 69 62 60\r\n76 76 69 66 65 68\r\n96 96 89 87 87\r\n65 65 63 56 55 51\r\n76 76 75 68 61\r\n63 59 56 53 52\r\n75 71 70 68 66 67\r\n79 75 72 70 70\r\n99 95 93 90 86\r\n70 66 65 63 60 54\r\n6 2 1 4 1\r\n30 26 28 27 28\r\n64 60 57 55 57 56 56\r\n65 61 60 59 58 57 58 54\r\n67 63 62 61 59 56 57 52\r\n93 89 88 85 85 82\r\n39 35 32 29 27 27 28\r\n96 92 92 89 88 85 85\r\n71 67 67 65 63 61 58 54\r\n46 42 41 40 37 37 32\r\n68 64 63 59 58 55\r\n41 37 34 30 33\r\n71 67 63 62 60 58 58\r\n45 41 39 35 34 31 27\r\n78 74 72 69 66 62 56\r\n62 58 57 55 52 47 45 42\r\n89 85 82 76 75 72 71 74\r\n69 65 64 61 56 53 51 51\r\n73 69 64 62 58\r\n32 28 21 20 19 18 16 9\r\n94 89 87 85 83 82 79 78\r\n91 84 82 81 84\r\n41 36 33 31 30 27 27\r\n56 51 48 46 44 41 38 34\r\n85 78 77 75 72 70 68 62\r\n85 80 79 80 78 76 75\r\n30 25 27 26 29\r\n37 32 35 33 33\r\n79 74 72 73 69\r\n80 75 72 71 72 70 69 64\r\n62 57 55 55 53 51 48 45\r\n53 47 45 44 44 41 40 42\r\n40 33 31 28 28 28\r\n90 85 84 83 82 82 78\r\n95 88 85 85 84 83 82 76\r\n37 30 28 24 23 20 19 17\r\n24 19 15 14 16\r\n24 19 16 14 11 7 7\r\n62 55 52 51 49 45 44 40\r\n49 43 39 38 33\r\n88 81 78 73 71\r\n64 59 56 51 49 51\r\n19 14 11 6 6\r\n41 34 29 28 24\r\n44 39 36 33 30 23 17\r\n40 41 44 47 48 50 51 48\r\n57 59 61 64 64\r\n58 60 61 62 66\r\n79 82 84 86 92\r\n7 9 7 8 9 10 11\r\n30 32 35 38 41 38 40 38\r\n39 40 41 43 42 42\r\n76 77 79 77 79 83\r\n16 19 17 19 25\r\n79 82 83 83 84 86 87 90\r\n21 24 24 26 29 31 32 30\r\n28 31 32 35 37 37 39 39\r\n58 61 61 63 66 67 71\r\n9 10 13 13 19\r\n51 53 57 59 60 61 64\r\n80 82 84 88 90 88\r\n86 89 93 95 96 98 98\r\n72 74 76 80 81 85\r\n76 79 83 85 88 90 96\r\n76 79 85 88 91 94 97\r\n79 80 87 89 91 92 89\r\n86 87 90 95 95\r\n37 39 41 47 51\r\n29 30 32 37 40 46\r\n57 54 57 58 59 61 63 66\r\n63 60 61 64 63\r\n62 59 60 61 64 64\r\n47 45 46 49 53\r\n6 4 6 7 8 9 14\r\n35 32 33 36 38 35 38\r\n7 4 5 7 8 9 7 5\r\n51 49 52 54 55 52 53 53\r\n48 47 49 50 49 52 56\r\n17 16 19 17 18 21 26\r\n93 92 92 93 95 96 97\r\n14 12 15 15 18 16\r\n11 10 10 13 13\r\n91 90 90 93 94 95 99\r\n72 71 72 72 73 78\r\n35 34 37 40 44 47 48\r\n26 24 27 28 31 32 36 33\r\n31 29 33 34 34\r\n79 76 80 82 86\r\n54 53 57 60 63 66 69 76\r\n76 74 79 82 83 86 88 89\r\n42 41 46 47 50 49\r\n20 18 21 23 24 27 33 33\r\n51 50 52 54 59 63\r\n11 9 12 15 20 23 24 29\r\n57 57 58 61 62 63\r\n53 53 56 58 60 61 58\r\n25 25 27 29 31 33 34 34\r\n70 70 71 72 74 76 79 83\r\n70 70 73 76 79 82 83 90\r\n6 6 8 7 8\r\n24 24 26 29 28 30 33 31\r\n66 66 67 66 67 67\r\n91 91 92 90 94\r\n92 92 95 92 94 99\r\n58 58 60 62 64 67 67 68\r\n86 86 89 89 86\r\n16 16 17 17 18 21 22 22\r\n46 46 47 48 48 52\r\n87 87 89 92 92 99\r\n1 1 4 7 10 11 15 17\r\n73 73 74 75 79 81 80\r\n84 84 87 91 91\r\n74 74 76 80 84\r\n50 50 53 57 59 65\r\n74 74 80 81 84\r\n11 11 13 15 21 20\r\n47 47 54 55 55\r\n57 57 58 60 62 68 69 73\r\n41 41 48 51 56\r\n16 20 21 24 27\r\n14 18 19 22 25 23\r\n84 88 89 90 93 93\r\n59 63 65 68 69 72 75 79\r\n19 23 26 29 32 37\r\n24 28 31 30 33 35\r\n70 74 76 79 77 75\r\n66 70 73 74 72 75 75\r\n56 60 61 59 62 63 67\r\n21 25 26 24 31\r\n27 31 33 33 34\r\n2 6 6 7 6\r\n83 87 88 88 90 93 93\r\n75 79 82 82 83 84 88\r\n34 38 40 40 43 46 52\r\n64 68 72 75 76\r\n72 76 80 81 78\r\n79 83 87 89 89\r\n12 16 20 22 23 24 26 30\r\n36 40 42 46 53\r\n24 28 35 38 40\r\n7 11 13 19 21 22 21\r\n35 39 41 43 50 50\r\n63 67 70 77 81\r\n66 70 71 77 79 85\r\n61 66 69 72 75\r\n71 77 78 81 80\r\n70 76 77 78 80 81 81\r\n25 32 33 35 36 40\r\n32 39 41 44 45 50\r\n36 41 42 39 42 43 44 46\r\n8 14 17 14 12\r\n79 85 86 84 85 85\r\n20 27 29 27 31\r\n60 66 64 67 73\r\n31 37 37 38 40 43\r\n27 33 34 36 36 37 36\r\n17 22 24 24 24\r\n76 83 84 84 88\r\n72 78 79 81 82 82 87\r\n10 16 18 22 24 27\r\n77 82 84 88 90 91 93 90\r\n33 39 41 45 47 49 52 52\r\n67 74 78 81 85\r\n25 32 36 38 41 43 49\r\n44 50 52 54 59 61\r\n13 20 23 26 29 31 37 35\r\n45 50 57 60 60\r\n66 72 73 80 84\r\n18 24 27 30 32 37 42\r\n81 79 76 75 78\r\n7 5 3 2 1 1\r\n55 54 51 50 49 45\r\n45 44 41 38 35 30\r\n79 76 73 72 74 71\r\n94 92 94 91 90 93\r\n30 28 27 26 29 26 26\r\n97 94 95 92 89 86 83 79\r\n21 20 22 19 13\r\n96 94 94 91 90\r\n81 78 76 76 74 76\r\n38 35 33 33 33\r\n58 56 56 53 52 48\r\n57 55 53 51 51 49 48 43\r\n76 74 73 70 68 64 61\r\n25 22 18 16 19\r\n17 14 10 7 5 3 3\r\n41 40 38 34 33 30 26\r\n99 97 96 95 94 91 87 82\r\n95 92 85 82 81 78 77 76\r\n69 67 61 58 56 59\r\n57 54 53 48 45 44 43 43\r\n86 85 82 79 73 72 68\r\n88 85 78 76 74 67\r\n69 71 68 66 65 62 60 58\r\n48 50 49 47 44 41 42\r\n17 20 17 14 11 10 9 9\r\n79 80 77 75 72 70 66\r\n16 18 17 15 13 12 10 3\r\n67 69 67 66 68 65 62 60\r\n69 71 68 67 68 70\r\n20 22 23 20 19 19\r\n32 34 33 35 31\r\n85 88 87 86 85 86 85 80\r\n14 15 15 13 12\r\n29 31 30 30 27 24 27\r\n68 69 69 67 64 64\r\n92 93 93 90 86\r\n56 57 54 54 51 46\r\n21 22 18 15 14\r\n30 31 30 27 25 21 22\r\n60 61 58 56 55 51 51\r\n27 28 24 23 20 18 14\r\n95 97 95 92 90 86 83 77\r\n67 70 63 62 60 57 55 52\r\n32 34 28 25 28\r\n31 32 26 25 25\r\n28 31 29 22 20 16\r\n13 15 14 9 3\r\n68 68 65 64 61 59 56\r\n39 39 36 33 35\r\n29 29 26 23 23\r\n72 72 70 69 65\r\n15 15 12 11 8 7 6 1\r\n43 43 41 42 39 38 35 34\r\n52 52 49 46 47 45 47\r\n39 39 41 40 40\r\n28 28 26 27 23\r\n36 36 35 33 32 35 28\r\n19 19 19 16 15\r\n20 20 19 17 15 15 16\r\n51 51 49 49 49\r\n65 65 63 60 60 56\r\n90 90 88 86 86 81\r\n68 68 65 61 58 55\r\n34 34 32 28 25 22 25\r\n88 88 85 81 79 78 78\r\n26 26 24 23 20 16 13 9\r\n98 98 95 91 88 85 82 77\r\n29 29 26 19 16 15 14\r\n96 96 94 93 87 88\r\n62 62 57 54 54\r\n72 72 66 63 59\r\n45 45 44 41 36 35 32 25\r\n38 34 33 30 27 25 22 21\r\n74 70 67 64 62 61 60 62\r\n51 47 46 43 43\r\n62 58 55 52 48\r\n20 16 13 10 5\r\n57 53 51 53 52 51\r\n99 95 93 90 92 91 94\r\n23 19 18 15 14 15 15\r\n62 58 59 58 55 51\r\n59 55 54 55 54 51 44\r\n95 91 89 87 87 86 85\r\n31 27 26 24 24 22 25\r\n27 23 22 19 19 18 16 16\r\n96 92 92 89 85\r\n26 22 22 20 18 13\r\n27 23 19 17 16 14\r\n90 86 83 82 80 76 77\r\n86 82 80 79 77 74 70 70\r\n20 16 12 11 10 6\r\n97 93 92 88 82\r\n75 71 68 66 65 64 57 54\r\n88 84 77 76 73 72 75\r\n37 33 32 30 25 25\r\n61 57 54 47 43\r\n65 61 59 54 53 46\r\n54 47 44 42 40 38\r\n88 81 79 78 81\r\n60 55 52 50 49 48 48\r\n86 81 79 76 73 71 68 64\r\n38 32 31 29 27 25 18\r\n80 75 73 76 75 73 71\r\n34 27 29 28 27 24 23 25\r\n97 92 89 92 92\r\n57 51 52 50 49 48 44\r\n27 22 20 18 21 18 12\r\n85 80 77 77 74 71 69 66\r\n26 20 18 16 16 19\r\n82 76 74 73 71 70 70 70\r\n93 87 85 84 82 81 81 77\r\n96 89 87 85 85 84 79\r\n34 27 23 21 19 17\r\n30 25 23 19 18 20\r\n57 51 50 46 43 42 42\r\n31 26 25 21 18 17 14 10\r\n51 45 41 40 39 36 30\r\n45 39 37 35 29 28 27\r\n78 72 70 67 65 60 61\r\n78 73 68 67 65 62 62\r\n95 89 86 84 78 74\r\n75 68 65 60 58 52\r\n71 71 74 72 74 77 79 84\r\n22 19 21 22 22 24 25 30\r\n10 7 8 8 7\r\n78 76 77 76 78 81\r\n44 42 44 46 49 47\r\n2 2 3 6 8 12 14 14\r\n12 12 14 16 22 25 28 25\r\n29 34 35 38 40 41 41 44\r\n28 25 23 21 18 17 19\r\n66 60 59 56 55 57 57\r\n55 55 52 51 51 49\r\n32 28 27 26 22\r\n81 79 76 73 71 71 67\r\n94 92 91 88 84 83 80 83\r\n86 84 82 81 80 79 76 76\r\n66 60 58 55 51 49 49\r\n91 95 96 96 97 96\r\n37 33 28 26 22\r\n26 25 24 23 20 16 15 15\r\n41 41 43 45 47 49 49\r\n55 57 56 54 50 47 44 40\r\n34 32 31 29 26 20 18 12\r\n39 38 41 44 46\r\n51 47 46 44 43 43\r\n64 70 73 77 80 83\r\n46 48 54 56 59 61 64 67\r\n20 23 20 22 25 29\r\n46 52 53 54 58 59 62 68\r\n14 21 21 23 25 25\r\n57 57 57 56 53 53\r\n34 27 25 22 17 15 12 15\r\n22 26 28 29 30 31 36\r\n76 80 82 84 88 92\r\n49 50 54 57 56\r\n27 28 35 37 41\r\n70 72 71 64 63\r\n13 13 12 11 11 10 5\r\n91 87 83 81 82\r\n21 19 20 21 24 26 26\r\n78 73 76 73 70\r\n33 29 25 22 21 17\r\n1 5 7 10 12 13 10\r\n2 5 6 5 5\r\n16 18 17 16 13 13\r\n62 66 69 71 69 69\r\n43 36 34 31 29 26 20 20\r\n83 79 77 74 71 71 67\r\n58 62 66 69 72 74\r\n64 60 58 56 49\r\n56 57 54 55 55\r\n31 31 35 36 38 41 44\r\n42 36 35 33 30 30 26\r\n44 45 42 40 34 30\r\n99 96 93 90 88 86 81 83\r\n18 22 25 27 29 30 32 36\r\n79 79 78 75 71 70 67 62\r\n36 39 36 38 40 47\r\n92 89 91 94 91 92 95 92\r\n16 21 23 30 28\r\n85 86 83 80 79 76 75 70\r\n84 83 85 86 87 91 90\r\n7 9 11 14 16 20 24\r\n40 44 47 51 56\r\n60 63 66 68 71 71 75\r\n31 35 38 36 33\r\n24 24 27 31 33 31\r\n16 12 11 9 9 9\r\n24 24 23 21 18 13\r\n64 58 56 55 52 48 44\r\n50 48 51 53 55 55 57 61\r\n34 37 35 33 33 30\r\n97 97 98 98 98\r\n48 48 44 43 42 40 39 36\r\n96 95 95 96 96\r\n7 11 14 15 15 16 16\r\n82 88 91 92 92\r\n31 32 35 34 36 37\r\n33 33 31 30 27 26 19 13\r\n13 15 17 18 25 30\r\n86 88 86 83 82 78 76 76\r\n49 49 48 46 40 38 39\r\n89 82 81 78 77 70\r\n58 61 59 56 54 56 53 56\r\n38 35 42 43 44\r\n22 27 28 34 37 37\r\n47 44 44 43 41 38 39\r\n45 43 46 52 50\r\n44 40 38 36 32 25\r\n99 99 96 94 91 90 87 83\r\n61 54 51 54 51 50 46\r\n75 82 83 84 85 88 90 97\r\n20 26 28 28 32\r\n6 6 11 12 15 21\r\n88 82 82 81 78\r\n69 66 64 64 63 60\r\n2 5 7 6 4\r\n69 64 62 60 60 62\r\n19 23 23 25 30\r\n12 18 19 21 23 27\r\n67 63 65 64 66\r\n45 52 55 58 60 65 68 71\r\n54 49 48 45 41\r\n80 80 83 82 84 88\r\n91 90 90 89 86 86\r\n54 57 61 64 67 74\r\n50 53 54 56 59 60 66\r\n16 20 22 28 35\r\n82 84 84 87 88\r\n19 15 12 9 12\r\n3 9 11 12 13 15\r\n55 53 57 60 60\r\n55 52 55 52 54 55 56 62\r\n66 63 66 69 72 74 76 83\r\n68 70 73 76 79 79\r\n74 76 77 78 80 82 79\r\n93 89 86 84 81 81 80 83\r\n18 18 17 15 8 6 2\r\n42 49 50 51 51 53 50\r\n1 5 6 3 5 8\r\n46 46 45 41 37\r\n54 54 55 56 61 65\r\n57 57 55 56 53\r\n28 28 26 24 26 23 25\r\n87 87 90 89 89\r\n67 71 71 73 74 78\r\n37 33 30 29 26 23 20\r\n69 65 63 58 57 54 52\r\n28 25 24 22 24 21 20 17\r\n72 75 73 72 72 72\r\n66 66 64 66 64 63 59\r\n94 95 93 91 93\r\n42 40 42 43 44 41 44 48\r\n38 44 47 48 51 55 55\r\n50 47 46 39 36 35 32 31\r\n70 72 70 69 66 64 62\r\n12 10 7 8 4\r\n73 68 65 64 58 56 55 53\r\n10 7 4 5 5\r\n58 56 55 52 49 45 43 36\r\n37 39 41 44 46 46 44\r\n11 10 11 13 14 18 21 25\r\n88 84 81 74 68\r\n81 74 73 73 72 71 64\r\n28 28 29 30 30 31 30\r\n77 78 75 72 70 70 71\r\n37 34 35 37 41 43 49\r\n43 44 47 51 52 52\r\n71 64 61 60 57 59\r\n22 23 25 27 29\r\n64 67 69 72 75 77 80 82\r\n85 87 90 91 93 94\r\n28 26 23 22 21 18 16\r\n68 71 73 74 76 79 81 83\r\n24 25 26 28 29\r\n22 23 25 28 29\r\n29 30 31 32 35 36 39\r\n3 5 6 8 9\r\n39 36 34 33 30 28 25\r\n54 52 49 47 44 43 41\r\n82 85 87 89 90 93 96 97\r\n18 21 24 27 28 30 32\r\n8 9 10 12 14\r\n54 53 52 51 49 46\r\n67 66 65 64 61 58\r\n58 57 54 51 49 47 44\r\n25 28 29 31 33\r\n7 8 9 10 11 14 15\r\n88 87 86 85 84\r\n51 52 53 55 58 60 63\r\n38 35 32 29 27 24 22\r\n81 82 83 84 85 87 90\r\n78 77 75 72 69\r\n81 83 84 87 88 90 91\r\n31 34 35 38 39\r\n52 51 50 47 44 41\r\n79 76 73 70 69 66 64\r\n94 93 90 89 88 85 82 81\r\n34 36 38 40 43 45\r\n58 57 55 52 49 47 45\r\n24 23 21 20 19\r\n89 90 91 93 94\r\n58 59 61 64 67 69 70 71\r\n50 52 55 56 58 60\r\n63 61 59 56 53 50\r\n43 46 49 52 54 55\r\n42 40 37 36 33 30 27 24\r\n26 27 28 31 32 33\r\n66 63 62 60 58 55\r\n11 14 15 18 19 22 24 27\r\n50 49 48 46 45\r\n80 83 84 87 88 91\r\n74 75 77 79 80 82\r\n66 67 70 72 74\r\n68 69 72 75 78 81 83 84\r\n63 61 60 59 57 54 51\r\n37 38 40 41 43\r\n44 43 40 39 36 34 33\r\n84 85 87 90 92 94 95\r\n78 80 81 82 85 88 90 91\r\n38 37 35 33 30 29 27\r\n61 63 65 68 70\r\n47 49 50 52 53\r\n39 36 34 32 31\r\n70 71 72 73 74 77 80\r\n41 39 37 34 33 31 28 25\r\n30 31 33 36 37 40 42\r\n18 21 24 26 27 30 33\r\n37 38 41 44 45\r\n10 13 14 15 18 20 22\r\n96 95 94 91 90 89\r\n46 47 48 50 53\r\n83 82 79 76 75\r\n38 39 41 44 47 48 51 53\r\n73 75 76 79 80\r\n81 84 87 88 89\r\n28 27 26 25 22 19 17 15\r\n54 55 57 59 60 62 65 66\r\n69 71 73 75 76 78\r\n43 45 46 49 51 54 57\r\n56 55 52 50 47 44 41 40\r\n36 37 40 41 42 44\r\n63 66 69 71 73 74\r\n40 43 44 47 48 50 53\r\n76 77 78 81 84 85\r\n68 65 63 60 58 56\r\n59 62 64 66 67 68\r\n24 23 20 19 16 14 11\r\n27 25 23 20 18 17 14 11\r\n11 13 15 18 21 24 25\r\n17 18 19 20 22\r\n52 55 58 60 63 66\r\n55 57 59 62 63 65 68\r\n7 8 11 14 17 20 21 22\r\n84 83 81 78 77\r\n24 21 19 17 16 14 11\r\n41 38 37 35 33 30 27\r\n74 77 78 79 82 85\r\n63 61 60 57 56 55 53\r\n27 30 33 34 36 39 41 43\r\n62 65 67 69 70 73 74 77\r\n51 49 48 47 44 42 41 38\r\n22 23 24 27 28\r\n49 50 53 56 59 62 65\r\n36 33 32 31 30\r\n5 8 10 13 14 17 19\r\n38 37 36 33 31 30 27 24\r\n55 56 57 59 62\r\n43 46 48 51 53 55 57\r\n37 39 42 43 46 49\r\n45 47 50 53 56\r\n6 7 9 11 13 16 18 19\r\n57 58 61 62 63 64 67 69\r\n13 12 11 10 7 6\r\n82 79 78 76 74 71 70 67\r\n16 14 11 8 5 3\r\n13 16 19 22 25 27 29 31\r\n35 32 31 28 27 25\r\n22 25 27 29 31 33 35\r\n67 70 73 76 78 80 82\r\n20 21 22 25 27 30 31 32\r\n66 63 62 60 57 56 55 54\r\n32 31 28 27 24 21 20 18\r\n13 15 16 17 18\r\n80 81 82 84 85 86 88 89\r\n49 47 46 45 43 41\r\n69 66 65 63 60 59 56\r\n76 74 71 68 66 65 64\r\n25 22 21 19 16 13 11 8\r\n44 46 49 51 52 53\r\n33 36 37 38 40\r\n65 62 59 57 54\r\n87 84 83 82 81\r\n58 59 60 63 65 68\r\n55 58 60 62 63 64 65 67\r\n77 79 80 82 85 86 88 90\r\n26 29 30 33 35 36\r\n83 84 87 90 92\r\n42 44 47 50 52 55\r\n76 73 72 71 70\r\n38 36 34 33 30 27 25 24\r\n72 73 76 79 80\r\n83 80 79 77 74 73\r\n2 5 7 9 11 12 15\r\n33 31 28 25 24 23 21\r\n81 82 84 87 88 91 93 94\r\n80 77 74 72 71 69 66\r\n68 66 64 63 60 57 55\r\n31 30 28 26 23\r\n35 34 31 28 27 26 25\r\n76 78 80 82 84\r\n85 84 83 81 80 79 78\r\n78 80 81 82 84\r\n17 16 13 11 10 8\r\n84 85 88 91 92 93\r\n83 86 89 91 93 96 98\r\n46 43 41 40 39 37\r\n77 78 80 83 85\r\n46 47 48 51 52 55\r\n88 86 84 81 80 77 75\r\n12 13 15 18 21 22 25\r\n29 28 27 24 23 20 17 14\r\n8 7 6 5 2\r\n88 87 85 82 79 77 75\r\n47 50 52 54 57\r\n78 80 83 84 85 88 90\r\n67 70 72 74 75 78\r\n10 11 14 16 19 21 22 25\r\n41 44 46 47 48\r\n37 35 33 30 27 24 23\r\n29 28 26 23 22 21\r\n24 27 30 31 33\r\n16 18 19 21 22 25 26 27\r\n97 94 92 91 88 87\r\n4 7 10 12 14 15 18 21\r\n1 4 7 9 11 13 16\r\n80 78 76 73 70 69\r\n59 57 56 54 52\r\n53 56 57 59 62 65\r\n47 44 43 41 38 36 33\r\n10 11 12 14 16 17 18\r\n94 91 90 87 86 83\r\n96 95 94 93 90 87 86\r\n27 30 32 35 38 41\r\n35 37 38 39 40 41\r\n88 89 92 94 96\r\n59 61 64 67 68 71 72 73\r\n2 5 6 8 9 12 15 17\r\n71 74 75 76 79 81 82\r\n40 41 44 47 48 51 53\r\n60 63 64 66 67\r\n21 24 27 29 31 33 36 39\r\n11 13 14 16 18\r\n74 75 76 79 82\r\n24 26 28 31 33\r\n59 56 53 51 50 49\r\n60 61 63 65 67 70 72 73\r\n94 92 90 87 84 82 80 79\r\n67 66 63 60 58\r\n25 22 21 20 18 16 15 13\r\n1 3 4 6 9 12 13 16\r\n38 37 35 34 32\r\n30 31 32 34 35 38 40\r\n64 65 66 68 70\r\n3 4 5 6 7 9\r\n85 84 81 79 78 76 74 71\r\n39 36 34 33 31 30 29 27\r\n70 67 65 64 61 58 56\r\n81 78 76 73 71 68 67\r\n13 15 18 21 22 25 27 28\r\n82 81 79 76 75 74 72\r\n42 44 47 49 52\r\n40 41 44 47 49 52 53\r\n73 76 79 80 82\r\n83 84 86 89 91\r\n45 42 41 38 37\r\n62 60 57 56 53 52\r\n25 27 29 31 34\r\n32 34 36 39 40 42 43\r\n41 38 36 35 32 29 26 23\r\n28 30 33 35 36 38 41 42\r\n37 38 41 42 44 45 46\r\n28 25 22 19 17 14 11\r\n74 72 69 67 66\r\n65 66 67 69 70\r\n21 22 24 27 28 29 31 34\r\n51 50 47 46 43 40 39\r\n27 28 30 33 34 37 38 39\r\n82 83 86 89 92 94 97 99\r\n98 97 94 92 91 90 89\r\n85 83 82 81 80 78\r\n87 85 84 82 81\r\n70 72 74 75 78 80 83 85\r\n18 19 22 23 24 27\r\n11 13 15 16 19 22 24 25\r\n55 58 59 61 64 66 68 70\r\n29 26 24 23 21 18 17 15\r\n50 51 52 53 56 57\r\n88 87 86 83 81 79\r\n35 38 39 42 45 47 48\r\n67 70 71 74 75\r\n91 90 89 88 86\r\n21 18 17 15 13\r\n37 36 34 31 30 27 25\r\n67 66 65 63 61 60 58\r\n76 73 70 68 67 65 64 63\r\n37 39 42 44 45\r\n6 7 10 11 13 14 16 18\r\n25 24 21 20 18 15 14 11\r\n84 83 80 79 77 76 74 72\r\n19 17 15 12 10\r\n83 85 86 89 91 92 93 94\r\n13 14 15 16 17 19\r\n97 95 92 91 90 88 87\r\n62 65 67 70 71 74 75 78\r\n19 17 14 11 9\r\n2 5 6 7 9 11 12 15\r\n30 32 34 35 38 40\r\n30 33 34 37 40\r\n76 77 80 83 86 87\r\n15 12 10 8 7\r\n22 20 18 15 13\r\n16 15 13 12 10 8 5 4\r\n36 38 41 43 44 46\r\n55 52 49 46 45 43\r\n15 12 9 7 5 4 3 2\r\n54 55 57 60 63 66\r\n64 61 59 56 54 53 50\r\n37 40 43 46 47 48 51\r\n70 69 66 64 61 60 59 57\r\n21 18 15 14 13 12 10\r\n49 47 46 43 41 39 36 33\r\n33 36 37 39 41 44\r\n87 89 90 93 95\r\n99 96 94 92 90\r\n59 56 54 53 50 48 46\r\n92 90 89 87 84 83 80\r\n2 4 7 9 11\r\n28 25 24 22 19 17\r\n99 96 95 92 89\r\n76 73 71 69 67 64\r\n88 90 92 95 97\r\n25 26 27 28 29 30 33\r\n37 34 33 31 30 29 27\r\n1 2 5 6 7 9 11 13\r\n26 24 22 21 20 18\r\n33 31 30 27 25 24 22 20\r\n68 69 71 73 76 77 80\r\n42 40 39 37 34 32 29 27\r\n67 66 63 62 61\r\n24 21 18 15 14\r\n67 64 61 59 57\r\n80 83 85 87 88 89 91 92\r\n29 32 35 38 40 43 46\r\n42 41 40 37 36\r\n68 69 71 74 75\r\n45 44 41 38 37 34 31 30\r\n59 58 56 54 51 48 47 46\r\n39 41 42 44 46 49 52\r\n67 65 63 61 58 57\r\n71 73 75 76 79 82 85\r\n93 92 91 88 86 84 81 79\r\n32 29 28 26 25 23\r\n52 55 57 58 60 62 64 66\r\n51 53 55 57 58 59 60\r\n35 32 30 29 27 24 21\r\n69 71 73 75 76\r\n26 28 30 33 34 36\r\n26 24 21 18 17 16 14 12\r\n57 59 62 64 66 67 69\r\n23 20 18 17 15\r\n33 34 37 38 39 40 42\r\n85 86 87 88 90 93 96 97\r\n43 41 40 37 36 34 32 29\r\n23 26 27 28 29 31 34 35\r\n26 23 20 18 17 16 15 12\r\n54 57 59 62 64 65 67 68\r\n88 85 84 82 81 79 77 76\r\n88 86 84 83 81 80 78\r\n94 91 88 85 84 81 78 77\r\n62 61 58 57 55 53 50\r\n47 45 43 42 40\r\n23 22 21 19 17 16 15\r\n34 36 38 41 42 45\r\n15 13 11 9 7\r\n41 44 45 47 48 50 52 53\r\n82 79 77 76 75 72 70 67\r\n71 72 74 77 79 80 81\r\n56 53 50 47 44\r\n33 34 37 39 40 42\r\n60 58 55 52 51 48\r\n67 64 62 60 57 55 53 50\r\n27 26 23 21 18 16 13 11\r\n72 69 68 66 63 62\r\n61 64 66 69 70 72 74\r\n9 12 14 16 18 21 22\r\n42 39 38 36 34 31 29\r\n77 76 73 71 68 66\r\n10 7 6 4 2\r\n39 37 35 32 29 28 27 26\r\n68 71 74 76 79 80 81\r\n45 47 48 51 54 56 59\r\n91 90 89 87 86 85 83 82\r\n42 44 47 49 51 52 53\r\n24 23 22 20 18 16 13\r\n14 12 11 8 6 3 2\r\n45 42 40 39 36\r\n32 34 36 39 42 43 44\r\n89 87 86 85 82 81 80\r\n10 12 15 16 19\r\n62 59 57 55 53 51 48\r\n99 98 96 93 90 87 86\r\n56 58 59 60 61 64 66 69\r\n49 50 53 56 59 62 64\r\n79 76 74 71 70 67\r\n66 63 61 59 57 55 54 52\r\n32 31 30 29 28 25 23\r\n88 91 94 96 97 99\r\n72 74 76 79 82\r\n14 16 18 19 22 23 26 29\r\n51 49 48 46 45 43 41\r\n58 59 61 63 66 68 70\r\n13 10 9 6 3 2\r\n77 75 73 70 68 67\r\n62 60 59 57 54 53 50\r\n";
string[] splitInput = input.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

int safe = 0;

for (int i = 0; i < splitInput.Length; i++)
{
	safe += IsSafe(splitInput[i]) ? 1 : 0;
}

bool IsSafe(string values)
{
	List<int> numbers = values.Split(' ').Select(x => int.Parse(x)).ToList();

	bool safe = IsSafeNumberList(numbers);

	//Try again with the dampener
	if (!safe)
	{
		for (int i = 0; i < numbers.Count; i++)
		{
			List<int> clone = new List<int>(numbers);
			clone.RemoveAt(i);
			safe = IsSafeNumberList(clone);
			if (safe) break;
		}
	}
	return safe;
}

bool IsSafeNumberList (List<int> numbers)
{
	int direction = 0;
	bool safe = true;

	for (int i = 0; i < numbers.Count - 1; i++)
	{
		int diff = (numbers[i + 1] - numbers[i]);
		int sign = Math.Sign(diff);
		int absdiff = Math.Abs(diff);

		if (direction == 0) { direction = sign; }
		else if (direction != sign) { safe = false; break; }

		if (absdiff < 1 || absdiff > 3) { safe = false; break; }
	}

	return safe;
}


Console.WriteLine(safe);