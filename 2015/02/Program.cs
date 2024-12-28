﻿//Solution for https://adventofcode.com/2015/day/2 (Ctrl+Click in VS to follow link)

//Your input: a list of box dimensions
string myInput = "4x23x21\r\n22x29x19\r\n11x4x11\r\n8x10x5\r\n24x18x16\r\n11x25x22\r\n2x13x20\r\n24x15x14\r\n14x22x2\r\n30x7x3\r\n30x22x25\r\n29x9x9\r\n29x29x26\r\n14x3x16\r\n1x10x26\r\n29x2x30\r\n30x10x25\r\n10x26x20\r\n1x2x18\r\n25x18x5\r\n21x3x24\r\n2x5x7\r\n22x11x21\r\n11x8x8\r\n16x18x2\r\n13x3x8\r\n1x16x19\r\n19x16x12\r\n21x15x1\r\n29x9x4\r\n27x10x8\r\n2x7x27\r\n2x20x23\r\n24x11x5\r\n2x8x27\r\n10x28x10\r\n24x11x10\r\n19x2x12\r\n27x5x10\r\n1x14x25\r\n5x14x30\r\n15x26x12\r\n23x20x22\r\n5x12x1\r\n9x26x9\r\n23x25x5\r\n28x16x19\r\n17x23x17\r\n2x27x20\r\n18x27x13\r\n16x7x18\r\n22x7x29\r\n17x28x6\r\n9x22x17\r\n10x5x6\r\n14x2x12\r\n25x5x6\r\n26x9x10\r\n19x21x6\r\n19x4x27\r\n23x16x14\r\n21x17x29\r\n24x18x10\r\n7x19x6\r\n14x15x10\r\n9x10x19\r\n20x18x4\r\n11x14x8\r\n30x15x9\r\n25x12x24\r\n3x12x5\r\n12x21x28\r\n8x23x10\r\n18x26x8\r\n17x1x8\r\n2x29x15\r\n3x13x28\r\n23x20x11\r\n27x25x6\r\n19x21x3\r\n30x22x27\r\n28x24x4\r\n26x18x21\r\n11x7x16\r\n22x27x6\r\n27x5x26\r\n4x10x4\r\n4x2x27\r\n2x3x26\r\n26x29x19\r\n30x26x24\r\n8x25x12\r\n16x17x5\r\n13x2x3\r\n1x30x22\r\n20x9x1\r\n24x26x19\r\n26x18x1\r\n18x29x24\r\n1x6x9\r\n20x27x2\r\n3x22x21\r\n4x16x8\r\n29x18x16\r\n7x16x23\r\n13x8x14\r\n19x25x10\r\n23x29x6\r\n23x21x1\r\n22x26x10\r\n14x4x2\r\n18x29x17\r\n9x4x18\r\n7x22x9\r\n19x5x26\r\n27x29x19\r\n7x13x14\r\n19x10x1\r\n6x22x3\r\n12x21x5\r\n24x20x12\r\n28x2x11\r\n16x18x23\r\n2x13x25\r\n11x7x17\r\n27x21x4\r\n2x10x25\r\n22x16x17\r\n23x22x15\r\n17x13x13\r\n23x24x26\r\n27x18x24\r\n24x7x28\r\n30x12x15\r\n14x28x19\r\n2x15x29\r\n12x13x5\r\n17x22x21\r\n27x10x27\r\n17x6x25\r\n22x2x1\r\n1x10x9\r\n9x7x2\r\n30x28x3\r\n28x11x10\r\n8x23x15\r\n23x4x20\r\n12x5x4\r\n13x17x14\r\n28x11x2\r\n21x11x29\r\n10x23x22\r\n27x23x14\r\n7x15x23\r\n20x2x13\r\n8x21x4\r\n10x20x11\r\n23x28x11\r\n21x22x25\r\n23x11x17\r\n2x29x10\r\n28x16x5\r\n30x26x10\r\n17x24x16\r\n26x27x25\r\n14x13x25\r\n22x27x5\r\n24x15x12\r\n5x21x25\r\n4x27x1\r\n25x4x10\r\n15x13x1\r\n21x23x7\r\n8x3x4\r\n10x5x7\r\n9x13x30\r\n2x2x30\r\n26x4x29\r\n5x14x14\r\n2x27x9\r\n22x16x1\r\n4x23x5\r\n13x7x26\r\n2x12x10\r\n12x7x22\r\n26x30x26\r\n28x16x28\r\n15x19x11\r\n4x18x1\r\n20x14x24\r\n6x10x22\r\n9x20x3\r\n14x9x27\r\n26x17x9\r\n10x30x28\r\n6x3x29\r\n4x16x28\r\n8x24x11\r\n23x10x1\r\n11x7x7\r\n29x6x15\r\n13x25x12\r\n29x14x3\r\n26x22x21\r\n8x3x11\r\n27x13x25\r\n27x6x2\r\n8x11x7\r\n25x12x9\r\n24x30x12\r\n13x1x30\r\n25x23x16\r\n9x13x29\r\n29x26x16\r\n11x15x9\r\n11x23x6\r\n15x27x28\r\n27x24x21\r\n6x24x1\r\n25x25x5\r\n11x1x26\r\n21x4x24\r\n10x5x12\r\n4x30x13\r\n24x22x5\r\n26x7x21\r\n23x3x17\r\n22x18x2\r\n25x1x14\r\n23x25x30\r\n8x7x7\r\n30x19x8\r\n17x6x15\r\n2x11x20\r\n8x3x22\r\n23x14x26\r\n8x22x25\r\n27x1x2\r\n10x26x2\r\n28x30x7\r\n5x30x7\r\n27x16x30\r\n28x29x1\r\n8x25x18\r\n20x12x29\r\n9x19x9\r\n7x25x15\r\n25x18x18\r\n11x8x2\r\n4x20x6\r\n18x5x20\r\n2x3x29\r\n25x26x22\r\n18x25x26\r\n9x12x16\r\n18x7x27\r\n17x20x9\r\n6x29x26\r\n17x7x19\r\n21x7x5\r\n29x15x12\r\n22x4x1\r\n11x12x11\r\n26x30x4\r\n12x24x13\r\n13x8x3\r\n26x25x3\r\n21x26x10\r\n14x9x26\r\n20x1x7\r\n11x12x3\r\n12x11x4\r\n11x15x30\r\n17x6x25\r\n20x22x3\r\n1x16x17\r\n11x5x20\r\n12x12x7\r\n2x14x10\r\n14x27x3\r\n14x16x18\r\n21x28x24\r\n14x20x1\r\n29x14x1\r\n10x10x9\r\n25x23x4\r\n17x15x14\r\n9x20x26\r\n16x2x17\r\n13x28x25\r\n16x1x11\r\n19x16x8\r\n20x21x2\r\n27x9x22\r\n24x18x3\r\n23x30x6\r\n4x18x3\r\n30x15x8\r\n27x20x19\r\n28x29x26\r\n2x21x18\r\n1x23x30\r\n1x9x12\r\n4x11x30\r\n1x28x4\r\n17x10x10\r\n12x14x6\r\n8x9x24\r\n8x3x3\r\n29x8x20\r\n26x29x2\r\n29x25x25\r\n11x17x23\r\n6x30x21\r\n13x18x29\r\n2x10x8\r\n29x29x27\r\n27x15x15\r\n16x17x30\r\n3x3x22\r\n21x12x6\r\n22x1x5\r\n30x8x20\r\n6x28x13\r\n11x2x23\r\n14x18x27\r\n6x26x13\r\n10x24x24\r\n4x24x6\r\n20x8x3\r\n23x11x5\r\n29x5x24\r\n14x15x22\r\n21x17x13\r\n10x10x8\r\n1x11x23\r\n21x19x24\r\n19x9x13\r\n21x26x28\r\n25x11x28\r\n2x17x1\r\n18x9x8\r\n5x21x6\r\n12x5x2\r\n23x8x15\r\n30x16x24\r\n7x9x27\r\n16x30x7\r\n2x21x28\r\n5x10x6\r\n8x7x1\r\n28x13x5\r\n11x5x14\r\n26x22x29\r\n23x15x13\r\n14x2x16\r\n22x21x9\r\n4x20x3\r\n18x17x19\r\n12x7x9\r\n6x12x25\r\n3x30x27\r\n8x19x22\r\n1x9x27\r\n23x20x12\r\n14x7x29\r\n9x12x12\r\n30x2x6\r\n15x7x16\r\n19x13x18\r\n11x8x13\r\n16x5x3\r\n19x26x24\r\n26x8x21\r\n21x20x7\r\n15x1x25\r\n29x15x21\r\n22x17x7\r\n16x17x10\r\n6x12x24\r\n8x13x27\r\n30x25x14\r\n25x7x10\r\n15x2x2\r\n18x15x19\r\n18x13x24\r\n19x30x1\r\n17x1x3\r\n26x21x15\r\n10x10x18\r\n9x16x6\r\n29x7x30\r\n11x10x30\r\n6x11x2\r\n7x29x23\r\n13x2x30\r\n25x27x13\r\n5x15x21\r\n4x8x30\r\n15x27x11\r\n27x1x6\r\n2x24x11\r\n16x20x19\r\n25x28x20\r\n6x8x4\r\n27x16x11\r\n1x5x27\r\n12x19x26\r\n18x24x14\r\n4x25x17\r\n24x24x26\r\n28x3x18\r\n8x20x28\r\n22x7x21\r\n24x5x28\r\n23x30x29\r\n25x16x27\r\n28x10x30\r\n9x2x4\r\n30x2x23\r\n21x9x23\r\n27x4x26\r\n2x23x16\r\n24x26x30\r\n26x1x30\r\n10x4x28\r\n11x29x12\r\n28x13x30\r\n24x10x28\r\n8x12x12\r\n19x27x11\r\n11x28x7\r\n14x6x3\r\n6x27x5\r\n6x17x14\r\n24x24x17\r\n18x23x14\r\n17x5x7\r\n11x4x23\r\n5x1x17\r\n26x15x24\r\n3x9x24\r\n5x3x15\r\n5x20x19\r\n5x21x2\r\n13x5x30\r\n19x6x24\r\n19x17x6\r\n23x7x13\r\n28x23x13\r\n9x1x6\r\n15x12x16\r\n21x19x9\r\n25x5x5\r\n9x7x9\r\n6x5x8\r\n3x11x18\r\n23x25x11\r\n25x4x6\r\n4x27x1\r\n4x3x3\r\n30x11x5\r\n9x17x12\r\n15x6x24\r\n10x22x15\r\n29x27x9\r\n20x21x11\r\n18x10x5\r\n11x2x2\r\n9x8x8\r\n1x26x21\r\n11x11x16\r\n2x18x30\r\n29x27x24\r\n27x8x18\r\n19x3x17\r\n30x21x26\r\n25x13x25\r\n20x22x1\r\n10x1x12\r\n11x17x15\r\n29x11x30\r\n17x30x27\r\n21x22x17\r\n13x6x22\r\n22x16x12\r\n27x18x19\r\n4x13x6\r\n27x29x10\r\n3x23x10\r\n26x16x24\r\n18x26x20\r\n11x28x16\r\n21x6x15\r\n9x26x17\r\n8x15x8\r\n3x7x10\r\n2x28x8\r\n1x2x24\r\n7x8x9\r\n19x4x22\r\n11x20x9\r\n12x22x16\r\n26x8x19\r\n13x28x24\r\n4x10x16\r\n12x8x10\r\n14x24x24\r\n19x19x28\r\n29x1x15\r\n10x5x14\r\n20x19x23\r\n10x7x12\r\n1x7x13\r\n5x12x13\r\n25x21x8\r\n22x28x8\r\n7x9x4\r\n3x20x15\r\n15x27x19\r\n18x24x12\r\n16x10x16\r\n22x19x8\r\n15x4x3\r\n9x30x25\r\n1x1x6\r\n24x4x25\r\n13x18x29\r\n10x2x8\r\n21x1x17\r\n29x14x22\r\n17x29x11\r\n10x27x16\r\n25x16x15\r\n14x2x17\r\n12x27x3\r\n14x17x25\r\n24x4x1\r\n18x28x18\r\n9x14x26\r\n28x24x17\r\n1x26x12\r\n2x18x20\r\n12x19x22\r\n19x25x20\r\n5x17x27\r\n17x29x16\r\n29x19x11\r\n16x2x4\r\n23x24x1\r\n19x18x3\r\n28x14x6\r\n18x5x23\r\n9x24x12\r\n15x4x6\r\n15x7x24\r\n22x15x8\r\n22x1x22\r\n6x4x22\r\n26x1x30\r\n8x21x27\r\n7x1x11\r\n9x8x18\r\n20x27x12\r\n26x23x20\r\n26x22x30\r\n24x3x16\r\n8x24x28\r\n13x28x5\r\n4x29x23\r\n22x5x8\r\n20x22x3\r\n9x9x17\r\n28x3x30\r\n10x13x10\r\n10x25x13\r\n9x20x3\r\n1x21x25\r\n24x21x15\r\n21x5x14\r\n13x8x20\r\n29x17x3\r\n5x17x28\r\n16x12x7\r\n23x1x24\r\n4x24x29\r\n23x25x14\r\n8x27x2\r\n23x11x13\r\n13x4x5\r\n24x1x26\r\n21x1x23\r\n10x12x12\r\n21x29x25\r\n27x25x30\r\n24x23x4\r\n1x30x23\r\n29x28x14\r\n4x11x30\r\n9x25x10\r\n17x11x6\r\n14x29x30\r\n23x5x5\r\n25x18x21\r\n8x7x1\r\n27x11x3\r\n5x10x8\r\n11x1x11\r\n16x17x26\r\n15x22x19\r\n16x9x6\r\n18x13x27\r\n26x4x22\r\n1x20x21\r\n6x14x29\r\n11x7x6\r\n1x23x7\r\n12x19x13\r\n18x21x25\r\n15x17x20\r\n23x8x9\r\n15x9x26\r\n9x12x9\r\n12x13x14\r\n27x26x7\r\n11x19x22\r\n16x12x21\r\n10x30x28\r\n21x2x7\r\n12x9x18\r\n7x17x14\r\n13x17x17\r\n3x21x10\r\n30x9x15\r\n2x8x15\r\n15x12x10\r\n23x26x9\r\n29x30x10\r\n30x22x17\r\n17x26x30\r\n27x26x20\r\n17x28x17\r\n30x12x16\r\n7x23x15\r\n30x15x19\r\n13x19x10\r\n22x10x4\r\n17x23x10\r\n2x28x18\r\n27x21x28\r\n24x26x5\r\n6x23x25\r\n17x4x16\r\n14x1x13\r\n23x21x11\r\n14x15x30\r\n26x13x10\r\n30x19x25\r\n26x6x26\r\n9x16x29\r\n15x2x24\r\n13x3x20\r\n23x12x30\r\n22x23x23\r\n8x21x2\r\n18x28x5\r\n21x27x14\r\n29x28x23\r\n12x30x28\r\n17x16x3\r\n5x19x11\r\n28x22x22\r\n1x4x28\r\n10x10x14\r\n18x15x7\r\n18x11x1\r\n12x7x16\r\n10x22x24\r\n27x25x6\r\n19x29x25\r\n10x1x26\r\n26x27x30\r\n4x23x19\r\n24x19x4\r\n21x11x14\r\n4x13x27\r\n9x1x11\r\n16x20x8\r\n4x3x11\r\n1x16x12\r\n14x6x30\r\n8x1x10\r\n11x18x7\r\n29x28x30\r\n4x21x8\r\n3x21x4\r\n6x1x5\r\n26x18x3\r\n28x27x27\r\n17x3x12\r\n6x1x22\r\n23x12x28\r\n12x13x2\r\n11x2x13\r\n7x1x28\r\n27x6x25\r\n14x14x3\r\n14x11x20\r\n2x27x7\r\n22x24x23\r\n7x15x20\r\n30x6x17\r\n20x23x25\r\n18x16x27\r\n2x9x6\r\n9x18x19\r\n20x11x22\r\n11x16x19\r\n14x29x23\r\n14x9x20\r\n8x10x12\r\n18x17x6\r\n28x7x16\r\n12x19x28\r\n5x3x16\r\n1x25x10\r\n4x14x10\r\n9x6x3\r\n15x27x28\r\n13x26x14\r\n21x8x25\r\n29x10x20\r\n14x26x30\r\n25x13x28\r\n1x15x23\r\n6x20x21\r\n18x2x1\r\n22x25x16\r\n23x25x17\r\n2x14x21\r\n14x25x16\r\n12x17x6\r\n19x29x15\r\n25x9x6\r\n19x17x13\r\n24x22x5\r\n19x4x13\r\n10x18x6\r\n6x25x6\r\n23x24x20\r\n8x22x13\r\n25x10x29\r\n5x12x25\r\n20x5x11\r\n7x16x29\r\n29x24x22\r\n28x20x1\r\n10x27x10\r\n6x9x27\r\n26x15x30\r\n26x3x19\r\n20x11x3\r\n26x1x29\r\n6x23x4\r\n6x13x21\r\n9x23x25\r\n15x1x10\r\n29x12x13\r\n7x8x24\r\n29x30x27\r\n3x29x19\r\n14x16x17\r\n4x8x27\r\n26x17x8\r\n10x27x17\r\n11x28x17\r\n17x16x27\r\n1x8x22\r\n6x30x16\r\n7x30x22\r\n20x12x3\r\n18x10x2\r\n20x21x26\r\n11x1x17\r\n9x15x15\r\n19x14x30\r\n24x22x20\r\n11x26x23\r\n14x3x23\r\n1x28x29\r\n29x20x4\r\n1x4x20\r\n12x26x8\r\n14x11x14\r\n14x19x13\r\n15x13x24\r\n16x7x26\r\n11x20x11\r\n5x24x26\r\n24x25x7\r\n21x3x14\r\n24x29x20\r\n7x12x1\r\n16x17x4\r\n29x16x21\r\n28x8x17\r\n11x30x25\r\n1x26x23\r\n25x19x28\r\n30x24x5\r\n26x29x15\r\n4x25x23\r\n14x25x19\r\n29x10x7\r\n29x29x28\r\n19x13x24\r\n21x28x5\r\n8x15x24\r\n1x10x12\r\n2x26x6\r\n14x14x4\r\n10x16x27\r\n9x17x25\r\n25x8x7\r\n1x9x28\r\n10x8x17\r\n4x12x1\r\n17x26x29\r\n23x12x26\r\n2x21x22\r\n18x23x13\r\n1x14x5\r\n25x27x26\r\n4x30x30\r\n5x13x2\r\n17x9x6\r\n28x18x28\r\n7x30x2\r\n28x22x17\r\n14x15x14\r\n10x14x19\r\n6x15x22\r\n27x4x17\r\n28x21x6\r\n19x29x26\r\n6x17x17\r\n20x13x16\r\n25x4x1\r\n2x9x5\r\n30x3x1\r\n24x21x2\r\n14x19x12\r\n22x5x23\r\n14x4x21\r\n10x2x17\r\n3x14x10\r\n17x5x3\r\n22x17x13\r\n5x19x3\r\n29x22x6\r\n12x28x3\r\n9x21x25\r\n10x2x14\r\n13x26x7\r\n18x23x2\r\n9x14x17\r\n21x3x13\r\n13x23x9\r\n1x20x4\r\n11x4x1\r\n19x5x30\r\n9x9x29\r\n26x29x14\r\n1x4x10\r\n7x27x30\r\n8x3x23\r\n1x27x27\r\n7x27x27\r\n1x26x16\r\n29x16x14\r\n18x6x12\r\n24x24x24\r\n26x2x19\r\n15x17x4\r\n11x7x14\r\n14x19x10\r\n9x10x1\r\n14x17x9\r\n20x19x13\r\n25x20x8\r\n24x20x21\r\n26x30x2\r\n24x2x10\r\n28x4x13\r\n27x17x11\r\n15x3x8\r\n11x29x10\r\n26x15x16\r\n4x28x22\r\n7x5x22\r\n10x28x9\r\n6x28x13\r\n10x5x6\r\n20x12x6\r\n25x30x30\r\n17x16x14\r\n14x20x3\r\n16x10x8\r\n9x28x14\r\n16x12x12\r\n11x13x25\r\n21x16x28\r\n10x3x18\r\n5x9x20\r\n17x23x5\r\n3x13x16\r\n29x30x17\r\n2x2x8\r\n15x8x30\r\n20x1x16\r\n23x10x29\r\n4x5x4\r\n6x18x12\r\n26x10x22\r\n21x10x17\r\n26x12x29\r\n7x20x21\r\n18x9x15\r\n10x23x20\r\n20x1x27\r\n10x10x3\r\n25x12x23\r\n30x11x15\r\n16x22x3\r\n22x10x11\r\n15x10x20\r\n2x20x17\r\n20x20x1\r\n24x16x4\r\n23x27x7\r\n7x27x22\r\n24x16x8\r\n20x11x25\r\n30x28x11\r\n21x6x24\r\n15x2x9\r\n16x30x24\r\n21x27x9\r\n7x19x8\r\n24x13x28\r\n12x26x28\r\n16x21x11\r\n25x5x13\r\n23x3x17\r\n23x1x17\r\n4x17x18\r\n17x13x18\r\n25x12x19\r\n17x4x19\r\n4x21x26\r\n6x28x1\r\n23x22x15\r\n6x23x12\r\n21x17x9\r\n30x4x23\r\n2x19x21\r\n28x24x7\r\n19x24x14\r\n13x20x26\r\n19x24x29\r\n8x26x3\r\n16x12x14\r\n17x4x21\r\n8x4x20\r\n13x27x17\r\n9x21x1\r\n29x25x6\r\n7x9x26\r\n13x25x5\r\n6x9x21\r\n12x10x11\r\n30x28x21\r\n15x6x2\r\n8x18x19\r\n26x20x24\r\n26x17x14\r\n27x8x1\r\n19x19x18\r\n25x24x27\r\n14x29x15\r\n22x26x1\r\n14x17x9\r\n2x6x23\r\n29x7x5\r\n14x16x19\r\n14x21x18\r\n10x15x23\r\n21x29x14\r\n20x29x30\r\n23x11x5";

//Your task: to calculate the required wrapping paper and ribbon length according to the challenge specs

//Processed input: an array of int arrays representing the sorted dimensions of each box 
int[][] dimensions = myInput
    .Split("\r\n", StringSplitOptions.RemoveEmptyEntries)                       //Get each separate box dimension specification
    .Select(
        line => line.Split('x').Select(int.Parse).OrderBy(n => n).ToArray()     //Take each separate line and convert it into a sorted int[]
     )
    .ToArray();														            // Convert the whole list of int[] to int[][]

//Execute both parts
Part1_CalculateTheRequiredAmountOfWrappingPaper(dimensions);  
Part2_CalculateTheRequiredAmountOfRibbon(dimensions);
Console.ReadKey();

void Part1_CalculateTheRequiredAmountOfWrappingPaper(int[][] pDimensionsArray)
{
    int totalWrappingPaper = 0;
    
    foreach (int[] dimensions in pDimensionsArray)
    {
        //Required wrapping paper is 2*l*w + 2*w*h + 2*h*l ...
        totalWrappingPaper += 2 * (dimensions[0] * dimensions[1] + dimensions[1] * dimensions[2] + dimensions[0] * dimensions[2]);
        //PLUS the AREA of the SMALLEST side for extra paper
        totalWrappingPaper += dimensions[0] * dimensions[1];
    }

    Console.WriteLine("Part 1 (Required amount of wrapping paper):" + totalWrappingPaper);
}

void Part2_CalculateTheRequiredAmountOfRibbon(int[][] pDimensionsArray)
{
    int totalRibbon = 0;

    foreach (int[] dimensions in pDimensionsArray)
    {
        //Required ribbon is 2 times the smallest side...
        totalRibbon += 2 * (dimensions[0] + dimensions[1]);
        //PLUS the l*w*h (according to specs)
        totalRibbon += dimensions[0] * dimensions[1] * dimensions[2];
    }

    Console.WriteLine("Part 2 (Required amount of ribbon):" + totalRibbon);
}




