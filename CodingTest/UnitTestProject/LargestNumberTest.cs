﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CodingTest;

namespace UnitTestProject
{
    [TestClass]
    public class LargestNumberTest
    {
        [TestMethod]
        public void LargestNumber_should_return_7()
        {
            long[] numArray = new long[] { 7, 2, 6, 3 };
            var result = LargestNumber.Solution(numArray);
            Assert.AreEqual(result, 7);
        }
        [TestMethod]
        public void LargestNumber_should_return_4()
        {
            long[] numArray = new long[] { 1, 2, 4 };
            var result = LargestNumber.Solution(numArray);
            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void LargestNumber_should_return_5()
        {
            long[] numArray = new long[] { 5 };
            var result = LargestNumber.Solution(numArray);
            Assert.AreEqual(result, 5);
        }
        [TestMethod]
        public void LargestNumber_should_return_10()
        {
            long[] numArray = new long[] { -2, 0, 10, 1 };
            var result = LargestNumber.Solution(numArray);
            Assert.AreEqual(result, 10);
        }
        [TestMethod]
        public void LargestNumber_should_return_499()
        {
            long[] numArray = new long[] { 82, -208, -285, -344, 34, 279, 136, 475, 173, 272, 40, 340, -399, 203, 172, 278, 233, 74, -251, 106, 168, -439, -35, 473, -483, 336, -116, 296, -322, -161, -362, 222, 33, -383, 443, -264, -428, -237, 422, -247, -227, -392, 325, -301, 353, -32, -382, 377, 35, 467, -103, -93, -137, -422, -149, 458, -170, -294, -350, 160, -392, 149, 208, -345, -422, -361, 491, -21, -302, 490, -362, -305, 293, 268, 292, 435, -132, -220, -114, -361, -133, 362, 59, -497, -59, -109, -170, 78, 311, -30, 247, 378, 391, -242, 184, -146, -372, 466, 400, 238, -2, -118, -409, 86, -396, 177, -216, 28, -139, 219, 401, 180, 110, 347, 281, -405, -147, 253, -20, 416, 193, -418, -456, 337, 470, -207, -140, 97, 347, -38, 277, 220, -233, -177, -221, -490, 480, -67, -187, -269, -322, -8, -168, 53, 353, 411, 422, 117, 390, 382, 352, -146, 81, 115, -187, 336, -361, 417, 147, -11, 277, 335, -164, 355, -207, 214, 251, -344, 224, -106, 292, -416, -116, 261, -419, -39, -168, -77, 242, -235, 261, 392, 251, -463, -26, 44, 441, -70, 218, 74, -417, -123, -9, -203, -416, -403, 417, 51, -264, 64, -404, 221, -353, 13, 292, -225, -49, -369, -105, -237, 298, -324, -225, 295, -43, -72, 368, 136, -170, 66, 136, -75, 89, -103, -333, -19, 315, -41, -314, -284, -261, 421, 71, 493, 293, 15, 86, -486, -98, -67, 436, 218, -41, 393, -434, 429, 477, 61, -388, 369, 183, 450, -28, -8, -7, -162, -417, -100, 184, -18, -90, -237, -45, 26, 47, 402, 139, -213, -217, 165, -54, -384, -441, 458, -215, -293, -17, -469, -13, -286, 457, -143, 321, -417, 47, -63, 327, -135, -136, 296, 438, -198, 220, -329, 457, -339, 371, -52, -432, -230, -187, 404, 321, 399, -207, -446, -25, 133, -51, 38, -377, -217, 161, -403, 147, -337, -16, 422, 412, -169, 75, -311, -458, -24, 77, 243, -390, 194, -398, 217, 235, 365, -318, -223, -343, 110, 22, -146, -50, 496, 68, -231, 46, 33, 460, -280, 56, 167, -59, 42, 35, -1, -147, -92, -390, 475, 349, 297, 133, 433, 328, 308, 426, -354, 339, 368, -336, -487, 361, -343, -142, -123, -74, 178, 43, 402, 244, 498, -286, -256, -317, -357, 233, -99, -279, -249, 259, -95, -413, -31, -71, -45, -455, 497, 275, -340, 303, -279, 480, -55, -309, -226, 193, -209, 491, 421, -292, 448, 18, -208, -378, -498, -323, 281, -337, -244, -84, -252, 487, 429, -246, 119, 16, 158, 135, 179, -88, -171, -228, -273, 240, -485, -181, 434, -217, -96, 240, 219, -279, -379, 174, 464, -313, 371, -397, -475, 139, -235, -311, 238, -161, 284, 408, 495, 203, -280, -296, 174, -20, -143, -397, 394, 458, 370, 443, 497, 366, 456, -17, -93, 295, -356, -127, -203, 350, 128, 244, 49, -294, -88, 203, -427, -403, 313, -43, 289, 33, -21, 162, 357, 91, 61, 302, -401, -342, -218, 172, 137, -67, 301, -186, -198, -248, 124, 435, -44, -477, -160, -248, -444, 39, -439, 333, 78, -126, 226, 185, 375, -107, 303, 318, 197, -95, -139, -296, 84, -373, 333, 404, -414, -94, -497, -271, -153, -173, 256, -375, -459, 8, -475, -341, 147, 69, 315, -70, -416, 341, 496, 181, 470, 255, 383, -92, -188, 432, -334, -138, 85, 315, -395, -106, -170, 410, 282, 51, 22, -199, 335, 293, 264, -228, 226, 448, -231, 317, 443, 390, 276, -449, 34, -160, 96, -445, -409, 91, -391, -393, 278, 455, -104, -321, -350, 21, 461, -188, -478, 117, -203, 368, -358, -462, 341, 65, 375, 24, 143, 173, -16, 469, 406, -321, 187, 386, 409, -430, -207, 216, -179, -318, 244, 361, -15, -433, 45, -34, 362, -278, -355, 3, -278, -426, 66, -334, 301, 152, -45, -207, 353, 383, 58, 269, 213, -84, 215, 368, 306, -312, 107, -237, 22, -117, 66, 438, 62, 293, 36, -397, 13, 161, 113, -187, -406, 330, -498, -449, -405, -240, 132, -360, -167, -369, 195, -266, -192, 305, -209, -320, -419, -236, 439, 28, -288, 27, -248, 43, 315, -65, 400, -354, 393, -190, -382, -415, -97, -328, -199, 368, -205, -161, -297, -463, 23, 127, 106, 419, 310, 255, -45, 189, -148, -293, -201, 388, -124, 136, -371, 321, -335, 457, -344, 359, 1, -436, 162, 71, -33, -49, 21, 483, -289, -235, 113, -220, 394, 98, -280, -171, 404, -347, -127, -423, -107, -211, -480, 266, 474, -290, -170, 120, 65, -462, -68, 494, 460, 499, -79, 318, 452, -249, 491, -35, -112, 176, -484, -205, 22, 368, 52, 10, -310, 106, -449, -197, 382, 330, -462, -409, 13, -9, -157, -281, 298, -13, 465, 30, -449, 479, 234, 173, 359, 237, -118, 418, -323, -10, -371, -12, 420, -393, -325, 101, -285, -495, 383, 81, -250, 177, -417, -48, -37, 17, -89, -267, 314, -377, -121, 391, -478, 302, 328, -171, 137, 274, 492, -20, 80, -167, 104, -170, -221, 219, 176, 488, -270, -177, -481, 258, -283, 4, 365, 276, 450, -103, 206, -165, 250, 343, -9, -229, 46, -140, -354, -349, -249, 242, 10, -191, -405, 356, 394, -442, 360, -392, -54, 481, 137, -408, 91, 3, 45, 329, 291, -384, -492, -185, -120, -60, -286, 229, 399, -165, 31, 189, 198, 85, -35, -412, -373, 364, -451, 108, -74, 303, -212, -137, -54, 161, 212, -388, -125, -11, 319, -240, 465, -228, -490, 405, -248, 105, 344, -216, -329, 36, -142, 114, 13, -203, -292, 451, -4, -15, 98, -311, -337, 125, 38, 107, 229, 427, 469, 41, 79, 207 };
            var result = LargestNumber.Solution(numArray);
            Assert.AreEqual(result, 499);
        }
        [TestMethod]
        public void LargestNumber_should_also_return_499()
        {
            long[] numArray = new long[] { -366, 403, 106, -440, -389, 74, -399, 96, -423, -471, 499, -351, -44, -253, 388, 320, 127, -133, 70, 39, 93, -94, -352, -422, -314, 455, 241, -356, -497, 441, -154, -283, -469, -395, 407, -367, 282, 300, -213, 385, -456, -335, 31, -460, 393, 483, -280, -34, -486, 451, 432, 457, 228, -73, -230, -472, -282, 159, 167, -445, 230, -402, -139, -2, 249, -117, -151, -12, 270, -203, -331, 182, 158, -283, 353, -374, -393, -101, -290, 214, -283, -449, -452, 247, -207, 87, -64, 112, 492, 126, -367, -96, 62, 160, 29, 230, -330, -269, 337, -317, 192, 477, 415, -144, -407, -290, 437, 310, 10, -57, 0, -150, -274, 129, 144, -424, -336, -450, 494, 318, -415, 165, -202, -404, -5, -181, -199, 483, -2, -374, 179, -471, 467, -484, 487, -191, -120, -173, -110, 354, -458, 258, 70, -113, 434, -223, -393, -441, -476, -39, 347, -89, 134, -417, 323, 37, -271, 215, 197, -470, -351, 353, 21, 39, -274, 242, 87, 110, 312, 177, -429, 481, -250, -309, -88, -136, -310, 0, -148, 175, -12, -47, 58, 269, 302, 490, 341, 103, -20, -322, -473, -475, -297, 353, 219, -176, 389, -441, 379, 464, -384, 371, -260, 211, -227, 47, -337, -287, -236, 457, -293, -195, -90, -90, 201, -290, 328, 278, 408, 273, -79, 441, 446, -348, -24, -392, -215, 95, 155, -66, -31, -363, -488, 114, -51, 360, 138, -14, -304, 95, -240, 116, 161, 239, 272, 60, 436, -139, -29, 81, 143, 170, -148, -322, -455, 62, -240, -497, -214, -208, -122, 5, 348, -238, -419, -268, -111, -212, -411, -66, 222, -208, -486, -37, 493, 269, -356, 446, 19, 321, 97, 381, 445, -131, 149, 340, -231, -124, -327, 30, -7, 162, 431, 215, -259, -72, -404, 422, -181, 27, -58, 44, 102, 190, -3, 371, 60, 348, -41, -172, -84, -238, 332, -452, -330, -44, -231, 340, 157, 306, -190, -361, 42, -397, -139, 487, -266, -265, 338, -239, -82, -360, -478, 137, -279, 186, 115, -80, 358, 51, 335, 283, 169, -210, 363, -25, 127, 314, -4, 105, -285, -300, 300, 248, 258, -181, -492, -87, -112, -98, 429, 278, -42, 234, 235, 169, 467, 132, 380, 98, -10, -445, 252, 347, 403, -497, -29, 321, 401, 75, 144, 28, -84, 342, 401, 16, -143, -346, 416, 322, -17, 176, 469, -367, 332, 313, -465, 372, -158, 319, 464, 224, -83, 326, 17, -475, -390, 244, -470, 181, 275, 497, 439, 306, -269, -80, 152, -53, 241, -482, -26, -367, 360, -250, -57, -301, 87, 242, -361, -210, 172, 136, -419, 302, 383, 132, 334, -324, 436, 197, 337, -225, 49, -474, -104, 111, -382, -293, 486, -19, 4, -425, -73, 389, -247, 411, 155, 146, -190, -387, -112, 302, 483, -136, -79, -299, 398, 311, -248, 237, -392, 50, 342, -446, 235, 32, 207, 160, 287, -189, -322, -279, -262, -462, -68, 192, 115, 136, 411, 416, 343, 459, 473, -181, 462, -110, 216, 451, -199, 411, -40, -192, -289, 310, 364, -26, 382, -396, 168, 433, 285, 259, -465, -148, -391, -320, 349, 341, 294, -132, -398, -85, 335, -387, -246, -22, 426, -325, 245, -64, -131, -289, -396, -358, 7, 164, -225, -173, 7, -176, -375, 105, -119, 368, -152, -331, -469, 352, 51, -321, -315, 183, 219, -286, -304, -27, -40, 425, 266, -233, -398, -222, 26, 182, 284, 121, 299, -483, 57, -290, -267, 191, 382, -386, -394, -288, 347, -325, -382, 202, 116, 166, -107, -243, -198, 350, 91, -248, -245, -484, 134, 125, 155, 188, -112, 249, -131, -299, -119, 14, 165, 175, 200, 216, -375, 424, -339, -377, 49, 493, 495, 446, 250, 108, 409, 473, 284, -358, -461, 277, 190, -250, 179, -236, -119, -142, 205, -43, -309, 20, 239, 143, 423, -125, 344, -418, -24, 2, 228, -11, 417, -94, -134, -243, -216, 232, -173, 217, -248, 337, 452, -456, -137, 204, -431, 38, -186, 168, 456, 18, -414, 255, -204, -443, -125, 294, 395, 19, 461, -437, 341, 419, -424, -11, 98, 106, -95, 76, -443, -387, 76, -191, -496, -146, 406, 304, 433, -442, -451, -136, 204, -150, -150, 279, -76, 423, 360, 484, 78, 329, 37, 407, 401, 391, 477, 312, -484, -57, 385, 481, -476, 352, 390, -382, -459, -339, 63, -117, 152, -333, 358, 434, 438, -321, -210, 452, 190, -130, -401, -477, 272, -61, -457, -175, -191, -190, 95, -235, 360, 151, -426, 446, -455, 398, 176, -425, 392, -456, -281, 12, -405, 187, -333, 0, -177, -145, -98, -28, 40, 5, -86, 130, -60, -80, 301, 313, 39, -36, -393, 483, -457, 347, -332, -101, -233, -274, 415, -265, 44, -382, 405, 312, 283, 103, -457, -67, 252, 286, -454, 94, 109, 119, 284, -38, 69, 157, 315, 414, 36, -349, 395, 191, 326, 256, -385, -232, 445, -179, 136, 58, 366, -88, 172, 67, 242, -36, 410, 341, -216, 206, -195, -429, 309, 94, -262, -402, -382, 234, 471, 54, -58, -62, -191, 264, 204, -140, 22, -460, 484, 429, 289, 344, -381, -50, 127, -340, -422, 445, 79, -286, 437, -98, 194, -146, 6, 438, 47, -355, 201, 333, 287, -218, -310, 15, 340, 150, 117, -418, -195, -376, 277, -310, 111, 239, -263, -322, 137, 93, -306, 276, 206, -20, -280, -407, -317, 23, -447, 217, -277, -13, -205, 30, -7, -249, -409, 349, 303, 111, -154, -432, 190, 334, 228, -80, -484, -421, 58, -160, -283, -78, 481, 187, -229, 98, -286, 363, 15, -130, -405, -65, -305, -350, 401, 481, 384, 119, 468, -146, 381, -203, 281, 290, 239, 1 };
            var result = LargestNumber.Solution(numArray);
            Assert.AreEqual(result, 499);
        }
        [TestMethod]
        public void LargestNumber_should_return_500()
        {
            long[] numArray = new long[] { -206, 29, 305, -1, -369, 103, -388, 364, 149, 500, -468, 259, 414, 496, 485, -327, -409, 92, 297, -347, 466, 134, 51, 277, 256, 200, 265, 152, -412, -82, -43, 411, 416, 356, 325, 19, 203, 110, -330, 15, 100, 437, -203, 300, 60, -333, -131, 495, 420, -412, 300, 174, 158, -64, 75, 32, 100, -292, -358, 423, -154, 253, 114, -140, -57, -423, 267, 113, -84, 146, -367, -168, 168, -123, -172, -379, 242, 7, 474, -222, -277, 310, -108, -433, 129, -35, -457, 317, -89, -469, -202, 430, -58, -100, -105, 411, 337, -83, -249, 481, 108, 93, -368, 130, -411, -133, 22, -219, -173, -209, 428, -279, 472, -306, -252, 193, -46, -144, -128, 60, -491, -345, 323, 148, 131, -434, -245, 253, -277, 309, -25, 337, 319, 236, 107, 32, 149, -63, -455, -58, 427, -182, 388, -145, 363, -194, -327, -5, 175, 364, -309, -404, -264, 477, -44, 395, 238, 453, 295, -140, -376, 391, -55, 371, -338, -206, 178, -374, -166, 184, -339, 381, 112, -100, 439, -135, 102, -276, 426, -395, 183, -48, -207, -426, 411, -449, -69, -205, -176, -373, -386, 75, -382, -204, -449, 500, -226, -458, -381, -190, -17, -428, -425, -196, -432, 399, 341, 193, -229, 387, 300, -304, -297, 68, -230, 182, 41, 444, -254, -280, 252, -21, 208, 129, -364, 97, -100, 423, -90, -333, -221, 291, -434, 285, -235, -315, -365, 74, 244, -4, -205, -213, 462, 161, 16, 234, -107, -477, 424, -52, 88, -256, -89, -337, 297, -213, -162, 485, 237, -458, -353, 291, -3, -187, -292, -45, 265, 92, 196, -498, 237, -129, -83, 335, 374, -377, -97, -213, 47, -406, -100, -456, 265, 70, -173, -267, -201, 177, -315, 29, 400, -16, 408, -140, 315, 70, 6, -167, -121, -404, -351, 288, -325, 447, -132, -378, 129, 443, 127, 320, 246, 89, -191, 298, 251, -55, -41, -253, -34, 376, -461, -371, -429, -423, -315, -310, -128, 247, -255, 185, -180, -23, 368, 70, 305, 146, -127, -479, 497, -329, 401, -453, 473, -6, 212, -71, -70, -47, -247, -392, -227, -371, -454, 43, -408, 54, -146, -308, 155, 25, 377, -330, -59, -69, -367, 178, 399, -180, -10, -53, -357, 295, 83, 10, -196, 288, -401, 166, 101, 170, 252, -141, -364, 274, -20, -488, -280, -188, -46, 318, 223, -451, 220, -133, 264, -210, -48, 119, 324, 46, -57, 404, -37, -241, 243, 331, 313, -359, 301, 60, 397, -135, 26, -14, 425, 35, -165, -320, -479, -246, -361, 480, 480, 364, -100, 490, 167, 367, -196, 247, 487, -220, -391, -426, 65, 377, 99, 143, -431, 5, 414, -316, 491, -395, -320, 86, 398, 428, 402, -172, 329, 421, 164, -280, 118, -230, -460, -245, 105, 195, 257, -375, -268, -453, 31, 139, -171, 67, 108, 265, 107, 365, 143, -445, 436, -467, -73, -367, -401, -452, -269, -193, 444, 179, 80, 46, -360, -484, -435, -120, 405, 202, 426, -302, 426, 324, 117, -356, 452, -266, -429, -33, -230, -246, -79, 314, 427, 30, -54, -187, 249, -39, -99, 269, 340, -208, 225, 49, -282, 201, -242, 197, -190, 123, 150, -450, -250, 89, -89, -228, 370, 121, -97, -257, 16, -6, -433, -212, -260, 230, -131, 271, 119, -184, 238, 72, -463, 33, 192, 328, -68, -350, 415, -22, -61, 219, 447, -154, -18, 457, 214, 468, 272, 58, -76, -328, -249, -423, 148, -468, 478, 195, 94, -461, -184, -214, 78, -185, 362, -493, 28, 80, -156, 462, 206, 202, -172, -33, 212, 274, 260, 105, 250, 155, 486, -66, 21, -386, 479, -380, 2, -293, -296, 107, 301, -478, 149, 113, -498, -342, 62, 201, 331, 89, -448, 395, 489, 280, 247, 359, 48, 198, -87, 451, 481, -59, 299, 461, -167, 112, 300, 31, 280, -194, -224, 207, -339, -446, 96, 327, 423, -184, 336, -142, -294, -120, -208, -12, -330, -441, 134, -85, 377, 463, 8, -178, -290, 151, -170, -398, 435, 72, -329, 297, -335, -430, 486, 221, -217, 89, -235, 439, -211, -456, -349, -144, 365, -213, 19, 391, 15, -63, 446, 483, 459, 302, -53, 31, 183, -246, -365, -431, 465, 457, 187, 339, 434, 439, -73, 123, -72, 103, 134, -459, 367, 299, -66, -19, 156, -86, -433, -109, 474, 331, -80, -64, 376, -300, 355, -70, -317, -73, -202, -351, 169, 396, 40, 266, -415, -403, 186, -148, -23, 94, -251, 163, -251, 130, 211, 426, -13, 246, 26, -203, 23, -331, -128, -224, 29, 345, 492, 181, 492, -112, 148, -318, -184, -299, 253, 336, 406, -214, -25, 73, 353, -495, -234, 497, 84, -109, -55, -354, 139, 65, 176, -181, -132, -246, 421, 27, -273, -296, -378, -33, 186, 276, 485, -305, -484, -441, 298, -28, -8, -121, 414, 162, -342, 44, -24, -352, -372, -490, -309, -293, -121, -172, 21, -186, 484, 152, -205, -476, 469, -324, -189, -126, -200, 183, -306, -333, -282, 198, 344, -128, 355, 11, -258, 199, 87, -88, 33, -12, 464, -226, -133, 380, 362, -455, -108, -171, 228, -147, 65, 487, 496, -186, -164, 65, 473, 51, 344, -425, 149, 103, 321, -332, -474, -52, -30, 383, 457, -305, 228, -441, -2, -334, 1, 121, -316, 346, -333, -381, -309, -33, 290, 341, 1, 145, 243, 459, -180, 163, -99, 51, 417, 277, -179, -324, -290, 327, 16, -365, -92, -402, -60, -34, -367, -304, 232, 281, 490, -9, 115, 284, -312, 233, -358, 329, 389, -331, 14, -21, -297, 294, 206, -160, -415, 325, 298, -468, -40, 218, -83, 408, -54, 41, -417, 370, -202, 164, 418, -243, 184, 478 };
            var result = LargestNumber.Solution(numArray);
            Assert.AreEqual(result, 500);
        }
        [TestMethod]
        public void LargestNumber_should_also_return_500()
        {
            long[] numArray = new long[] { 132, -128, 289, -25, 179, -217, 240, 328, 220, 271, -246, 306, -87, -489, 391, -232, 17, -77, -177, -359, 120, 52, 38, -14, -231, -312, 410, -37, 95, 49, 215, 5, -405, -198, 22, -11, 136, -394, 390, -195, 395, -102, -132, 296, -121, -255, 308, 423, 345, -153, -498, -468, -242, -63, 419, -388, -298, -151, -181, 397, -17, -183, -290, 327, -85, -312, 16, 151, -194, -162, -118, -440, 159, 465, -395, 403, -74, -51, -177, 247, 70, 89, -177, 362, 255, 272, 115, -344, -305, 160, 134, 6, 470, 433, -158, 469, 126, -1, -441, -381, 47, 407, -318, 120, 2, 424, 419, 268, -269, -418, -63, 226, -295, -396, 97, 149, 121, 47, -304, 162, -57, -179, -368, 73, 133, 223, 294, 447, -25, -154, -240, -126, 375, -298, 420, -17, -270, -184, 239, -109, 500, 343, 430, -32, -369, 402, -247, -27, 251, 175, -300, 118, 16, -386, 280, -223, 198, -406, -424, 431, -370, 152, 118, -246, 324, -109, -332, -347, -428, 291, 445, -188, 104, -465, -161, -334, 448, 381, -295, 321, -244, -194, -151, 207, -205, -402, -107, 420, -226, -203, -176, -184, -369, -423, 311, -339, 382, 472, 494, 224, -94, 91, -36, -297, -380, 484, 84, 113, -252, 304, 269, 122, -205, -449, 334, 411, 251, -278, -355, -105, 28, 95, 236, 327, -378, 467, 111, 54, 366, -51, 453, 372, -223, -484, -355, 270, 384, 203, 264, 346, -351, 135, 364, 406, 131, 195, 103, -283, 444, 173, -253, -103, 226, 166, -112, -415, -366, 415, 220, 202, -250, 433, 455, 142, 331, 88, -196, -174, -18, 249, 232, -322, 94, -277, 151, -249, -107, 242, -398, 459, 92, 321, -260, 237, 382, 160, 306, -239, 273, 184, -235, -386, 124, -195, -357, 343, -29, -191, 444, -95, 194, 480, 442, -202, 107, 158, -8, -176, -139, 139, 482, -186, 296, -235, 67, 398, -22, 486, 217, 260, 443, -231, -328, 498, -422, 237, -146, 160, 372, -197, -268, -150, 231, 386, -499, 440, 382, -237, 446, 155, 69, 383, -369, -300, 456, 193, 161, 411, -153, -370, -404, -253, 17, 496, -455, -120, 174, 177, -493, -470, 194, -425, -19, -19, -171, 183, -492, -186, -2, 353, 33, 112, -52, 487, 371, -409, 31, 235, -69, 52, -82, -271, 114, -117, -48, 351, 222, -338, -459, -17, 113, 130, 170, 254, -96, -260, -431, -172, -85, -205, -123, 394, 153, 6, 190, -290, -17, 85, -301, -27, 188, 125, -162, 291, -1, -398, -410, 86, -205, -159, -140, 29, 464, -473, -437, 24, 199, 469, -204, -307, 29, 126, -423, -441, 203, -440, -370, -391, -369, 198, 71, 257, -443, 62, -37, -357, -49, -449, -63, 27, -403, 441, -117, -6, 70, -230, 229, 381, -189, 480, -297, 16, 345, -47, -383, -146, -369, 415, -347, 248, 268, 467, -98, 291, 473, -423, 159, 269, -405, 13, -161, 386, 456, -438, 372, 206, -332, 268, -95, -26, -357, -241, 20, 252, -415, 298, 251, -176, 390, -393, -365, -390, 435, 151, 298, -53, 298, 291, 16, -197, -81, 310, -221, 401, -493, 315, -403, 321, -241, -298, 80, -364, 216, -119, -425, -493, 457, -46, -138, 248, 11, 326, -247, 35, 20, -64, -178, -220, -28, 27, 423, 436, -21, 281, -110, -121, 413, -97, 101, -469, 489, -484, -423, -6, -10, -439, -491, -71, -300, -464, 26, -438, -165, -174, 141, 30, 107, -97, 282, -401, 74, -320, 308, -484, 454, -453, 465, 453, 393, 489, -1, 363, -11, 308, 449, 40, -334, 479, -1, 180, 232, -36, -237, -43, -207, 69, 44, -164, 135, -221, -370, -457, -420, 407, 173, 267, -209, -58, -83, 219, -205, 415, 56, -452, 387, -67, -45, -71, 79, 196, -14, -216, 223, -156, -425, 105, -487, -495, 428, 97, 98, -363, 368, -45, -372, 259, -73, -431, -346, -130, -215, -293, -15, 449, 118, -1, 258, 283, -455, 36, 339, -51, 465, -50, -421, -392, 451, -235, -249, -356, 24, -67, 211, 26, 50, 370, 35, -319, 54, 266, 174, -168, 398, -41, 20, -498, -57, -362, -201, -161, 431, -126, 19, 144, 254, 470, -220, 407, -25, -482, 78, -487, 252, 281, -249, 321, -55, -21, -339, -450, 31, 1, 186, -488, -185, 75, -350, 216, 31, 444, -191, 356, -124, 164, -376, 291, -437, -85, -417, 7, 0, -255, -140, 466, 298, 21, 376, 107, -305, -458, 447, -80, -313, -471, -388, -65, -348, -141, 466, 330, 499, 302, 472, -60, -471, 120, -350, -179, 308, -17, 438, -443, 187, 16, -327, 468, -41, -27, -442, -228, 213, 402, 29, 55, -392, 210, 21, -338, 429, -339, 116, -17, -111, -463, -229, 241, -94, 56, -272, 39, 243, -379, 265, 251, -293, -72, 128, -214, -344, 67, 250, -232, -400, 108, 114, 455, 104, -56, -256, 176, -277, -246, 160, -211, -171, -474, 44, 483, -71, -226, 336, -5, -221, -2, 472, 184, -12, 288, 426, -16, 24, 95, -276, -480, 295, -10, -347, 273, 290, -64, -30, 53, -391, 127, 394, 50, -276, -347, 81, -490, 391, -472, 304, 161, 185, -2, 137, 232, 300, -197, -398, 53, 317, 395, -274, -387, 147, 170, 440, 312, 419, 323, -132, 314, 266, -101, 488, 500, 46, 73, 278, 59, 470, 296, -184, -117, -232, 117, -343, -47, 121, 182, 34, -329, -350, 380, 244, -411, -463, -241, -423, 234, -422, 134, -413, -245, -41, 137, 44, -477, -382, 427, 80, 423, 15, -235, 63, -154, 423, 381, -51, -214, 441, -350, -127, 148, 182, -39, 10, 204, -381, -366, -331, -441, -349, 302, -259, 439, -215, 184, -115, -1, 336, -332, 388, 52, 75, -448, 23 };
            var result = LargestNumber.Solution(numArray);
            Assert.AreEqual(result, 500);
        }
        [TestMethod]
        public void LargestNumber_should_also_return_498()
        {
            long[] numArray = new long[] { 163, -95, 323, -91, -189, 471, -150, -280, -94, 42, -433, 25, -469, -251, -219, -468, -273, -264, -113, -392, 233, 334, -159, -166, -226, -424, 200, -127, 411, 5, 101, 460, 77, 264, -481, -101, -199, 329, -241, -486, 106, -217, 281, 383, -22, -15, -125, -226, 417, -16, 78, -40, -225, 105, -291, 464, -203, -184, -348, 102, -346, 380, -10, -307, -203, 321, 376, 106, 340, -259, 155, 265, -277, 448, -226, 85, 150, -219, 492, -135, -192, -328, 341, 367, -198, -423, -406, 393, -377, 480, -230, 180, 185, -271, 424, 435, -149, 416, 389, 208, -20, 382, 247, 433, 498, -63, 430, -11, 140, -174, -397, -223, -253, -489, 216, 380, 475, 222, 79, 230, -221, 349, -405, -135, 181, -236, -298, 83, 236, 338, -434, -123, 379, 484, -385, 103, 210, -21, -203, 457, 162, 285, 215, 450, -241, 196, -317, 221, 179, 207, 94, 50, -421, -487, 178, 278, 86, 378, -15, 412, -90, -469, -89, -493, -353, -359, 436, -242, 150, -470, -359, 386, 13, 259, 341, 53, 479, 55, 101, -397, -126, 386, 174, -373, -411, -350, 233, -449, 6, -338, 204, -329, 342, 313, 374, -154, -424, -333, 244, -485, 465, 185, -140, 123, 2, -41, 463, 308, 188, 214, 380, 148, -409, 229, 486, 309, 363, 373, 80, -123, 65, 74, -452, 461, 184, 32, -319, -43, -360, -248, -65, -426, -408, -270, -470, -27, -468, -292, -438, -120, 36, 58, 412, -361, -187, -146, 26, -82, -233, -416, -41, -456, -167, 273, -484, 7, 121, -308, -85, 308, -442, 317, 136, -268, 431, 274, 363, -416, -222, -180, -84, 447, 93, 182, -288, -414, -250, -234, -456, -193, -83, -342, 0, 228, -273, 63, 256, 84, -232, 78, -358, 374, 262, -73, 341, -316, 371, 448, 356, -277, 34, 302, -372, 318, -294, 132, -178, -426, -218, -289, 445, 99, -198, 32, -479, 177, 464, -24, -441, 155, 211, 69, -393, 91, -461, 175, 305, -106, -212, 427, 149, 272, 458, -141, -53, 203, 431, 152, 269, -467, 14, 342, 388, 371, -299, -294, 225, -417, 240, -497, -306, 448, -13, -265, 290, 292, 213, 117, -134, 167, -361, -411, -36, -447, 453, 214, 335, 463, -40, 147, 136, -317, 165, -32, 157, 258, 288, 209, 342, -26, -82, -193, 81, -482, -153, -196, 244, -245, -21, 133, -180, 343, -486, -281, 378, 181, -488, -214, 179, 97, -56, 390, 487, -280, 115, -172, 329, -224, 248, -238, 247, -359, 134, -293, 120, 474, 77, -385, -353, 224, 172, 169, -425, -454, 191, 377, 240, -323, 229, -152, -429, 457, 154, 176, -285, -479, 433, 57, 103, -82, 154, 173, -296, -80, 139, 457, 48, -454, -31, 379, 463, -177, 115, 331, 38, 301, 269, -386, -273, -418, -5, -449, 131, -406, 448, -405, 173, 44, 220, 78, -282, 144, 11, -142, -319, -102, -135, -483, 78, -187, -367, 389, 143, -267, -115, 112, -393, -325, 470, 42, 198, -182, 387, -275, 428, -362, 107, -22, -316, 305, -323, -477, -120, 259, -283, 457, -437, 445, 225, -320, 312, 425, -227, 87, 159, 361, 329, 16, -12, 450, -155, -157, -168, -419, 229, 371, -398, -171, -154, 76, -174, -245, 45, 349, 47, -383, -223, -127, 49, 26, -321, -329, 226, 256, 415, 150, -146, -375, -271, -477, -268, -312, 124, -316, 89, 340, 311, 307, 258, -179, 127, -151, -462, -476, 84, 428, 490, -240, 113, 497, -173, 243, -40, -435, -202, -265, -184, -352, 190, -183, 100, -246, 70, -290, -428, 353, 35, 5, 356, -419, -414, -398, 278, -102, 384, -419, -499, 293, 298, -403, -353, -395, -306, 304, -76, -475, 380, -310, 417, -2, 82, -76, 29, 218, 193, 434, -218, 32, -438, 2, 103, -389, -126, -42, 436, 348, 4, 55, -376, 175, -118, 45, -393, -48, -29, -73, -464, -290, 110, -473, -325, -88, 316, 259, 165, 234, -466, -388, -155, 308, 42, -394, 250, 419, 252, -24, -264, -399, 342, 204, 283, -2, -407, -357, 296, 491, 391, 338, -20, -337, 297, -432, -326, -222, -324, 24, 30, 111, 134, -251, 249, -373, -60, 114, 309, 282, -402, -147, 371, 245, -42, -132, -373, -4, -71, 350, -446, 30, -63, -429, 292, -112, 222, -270, 423, 37, 45, 174, 493, 180, 442, -214, 456, -101, 329, 153, 431, 196, -267, -39, -96, -418, -332, -251, -216, -328, 478, 311, -98, 277, 199, -351, 358, 430, -68, -146, 407, 1, 52, 94, 226, -100, -127, -147, 202, 461, -453, -233, -70, 6, 38, -212, -146, -15, 125, 271, 432, -241, -80, -418, -149, -116, 256, -369, -452, 415, -131, -403, 27, 133, -112, -465, 462, 335, -184, 64, -105, -246, 259, -29, -430, 65, 254, -368, -276, 58, 497, 404, -156, 60, 342, -142, -205, 378, 59, 2, -63, 286, 56, -409, -72, 385, 256, -259, -437, 496, -183, -422, -333, 452, -36, -408, 249, 200, 182, -318, 249, -111, 128, 238, 378, 466, 487, 249, -234, 335, 236, -56, 334, 378, 27, -264, 235, -208, -197, 389, 51, -457, -79, -103, -87, 427, 343, -7, -390, 82, 37, -68, 418, 343, -246, 493, -142, -373, 173, -189, 313, 274, -224, 238, -280, 167, -20, -391, 428, -36, 490, 476, -313, -426, 342, -444, -422, -102, -119, -71, -276, -324, -24, -46, 15, -454, -363, 173, 135, -333, -150, 248, 140, -189, 408, -414, 323, -290, -102, -453, 25, -351, -390, -304, 351, -147, -82, 285, -277, -472, 213, 334, -331, -424, -92, -296, -493, -481, 41, -336, -77, 160, 290, -128, -283, -428, 301, -321, 259, 4, -466, -303, 268, -310 };
            var result = LargestNumber.Solution(numArray);
            Assert.AreEqual(result, 498);
        }
    }
}