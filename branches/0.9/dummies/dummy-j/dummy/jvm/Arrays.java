/* Copyright (C) 2012 by Pavel Savara
This file is part of of jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

package dummy.jvm;

import java.util.Comparator;

public class Arrays {
    public static boolean[][] boolean11_l1() {
        return new boolean[10][];
    }

    public static boolean[][] boolean11_l2() {
        boolean[][] bs = new boolean[10][10];
        bs[1][0] = true;
        bs[9][8] = true;
        return bs;
    }

    public static boolean[][] boolean11_lj() {
        boolean[][] bs = new boolean[10][];
        bs[0] = new boolean[0];
        bs[1] = new boolean[1];
        bs[2] = new boolean[2];
        bs[3] = new boolean[3];
        bs[4] = new boolean[4];
        bs[5] = new boolean[5];
        bs[6] = new boolean[6];
        bs[7] = new boolean[7];
        bs[8] = new boolean[8];
        bs[9] = new boolean[9];

        bs[1][0] = true;
        bs[9][8] = true;
        return bs;
    }


    public static byte[][] byte11_l1() {
        return new byte[10][];
    }

    public static byte[][] byte11_l2() {
        byte[][] bs = new byte[10][10];
        bs[1][0] = 1;
        bs[9][8] = 1;
        return bs;
    }

    public static byte[][] byte11_lj() {
        byte[][] bs = new byte[10][];
        bs[0] = new byte[0];
        bs[1] = new byte[1];
        bs[2] = new byte[2];
        bs[3] = new byte[3];
        bs[4] = new byte[4];
        bs[5] = new byte[5];
        bs[6] = new byte[6];
        bs[7] = new byte[7];
        bs[8] = new byte[8];
        bs[9] = new byte[9];
        return bs;
    }

    public static char[][] char11_l1() {
        return new char[10][];
    }

    public static char[][] char11_l2() {
        char[][] bs = new char[10][10];
        bs[1][0] = 'a';
        bs[9][8] = 'a';
        return bs;
    }

    public static char[][] char11_lj() {
        char[][] bs = new char[10][];
        bs[0] = new char[0];
        bs[1] = new char[1];
        bs[2] = new char[2];
        bs[3] = new char[3];
        bs[4] = new char[4];
        bs[5] = new char[5];
        bs[6] = new char[6];
        bs[7] = new char[7];
        bs[8] = new char[8];
        bs[9] = new char[9];
        return bs;
    }


    public static short[][] short11_l1() {
        return new short[10][];
    }

    public static short[][] short11_l2() {
        short[][] bs = new short[10][10];
        bs[1][0] = 1;
        bs[9][8] = 1;
        return bs;
    }

    public static short[][] short11_lj() {
        short[][] bs = new short[10][];
        bs[0] = new short[0];
        bs[1] = new short[1];
        bs[2] = new short[2];
        bs[3] = new short[3];
        bs[4] = new short[4];
        bs[5] = new short[5];
        bs[6] = new short[6];
        bs[7] = new short[7];
        bs[8] = new short[8];
        bs[9] = new short[9];
        return bs;
    }

    public static int[][] int11_l1() {
        return new int[10][];
    }

    public static int[][] int11_l2() {
        int[][] bs = new int[10][10];
        bs[1][0] = 1;
        bs[9][8] = 1;
        return bs;
    }

    public static int[][] int11_lj() {
        int[][] bs = new int[10][];
        bs[0] = new int[0];
        bs[1] = new int[1];
        bs[2] = new int[2];
        bs[3] = new int[3];
        bs[4] = new int[4];
        bs[5] = new int[5];
        bs[6] = new int[6];
        bs[7] = new int[7];
        bs[8] = new int[8];
        bs[9] = new int[9];
        return bs;
    }

    public static long[][] long11_l1() {
        return new long[10][];
    }

    public static long[][] long11_l2() {
        long[][] bs = new long[10][10];
        bs[1][0] = 1;
        bs[9][8] = 1;
        return bs;
    }

    public static long[][] long11_lj() {
        long[][] bs = new long[10][];
        bs[0] = new long[0];
        bs[1] = new long[1];
        bs[2] = new long[2];
        bs[3] = new long[3];
        bs[4] = new long[4];
        bs[5] = new long[5];
        bs[6] = new long[6];
        bs[7] = new long[7];
        bs[8] = new long[8];
        bs[9] = new long[9];
        return bs;
    }

    public static float[][] float11_l1() {
        return new float[10][];
    }

    public static float[][] float11_l2() {
        float[][] bs = new float[10][10];
        bs[1][0] = 1;
        bs[9][8] = 1;
        return bs;
    }

    public static float[][] float11_lj() {
        float[][] bs = new float[10][];
        bs[0] = new float[0];
        bs[1] = new float[1];
        bs[2] = new float[2];
        bs[3] = new float[3];
        bs[4] = new float[4];
        bs[5] = new float[5];
        bs[6] = new float[6];
        bs[7] = new float[7];
        bs[8] = new float[8];
        bs[9] = new float[9];
        return bs;
    }

    public static double[][] double11_l1() {
        return new double[10][];
    }

    public static double[][] double11_l2() {
        double[][] bs = new double[10][10];
        bs[1][0] = 1;
        bs[9][8] = 1;
        return bs;
    }

    public static double[][] double11_lj() {
        double[][] bs = new double[10][];
        bs[0] = new double[0];
        bs[1] = new double[1];
        bs[2] = new double[2];
        bs[3] = new double[3];
        bs[4] = new double[4];
        bs[5] = new double[5];
        bs[6] = new double[6];
        bs[7] = new double[7];
        bs[8] = new double[8];
        bs[9] = new double[9];
        return bs;
    }

    public static String[][] string11_l1() {
        return new String[10][];
    }

    public static String[][] string11_l2() {
        String[][] bs = new String[10][10];
        bs[1][0] = "1";
        bs[9][8] = "1";
        return bs;
    }

    public static String[][] string11_lj() {
        String[][] bs = new String[10][];
        bs[0] = new String[0];
        bs[1] = new String[1];
        bs[2] = new String[2];
        bs[3] = new String[3];
        bs[4] = new String[4];
        bs[5] = new String[5];
        bs[6] = new String[6];
        bs[7] = new String[7];
        bs[8] = new String[8];
        bs[9] = new String[9];
        return bs;
    }

    public static Class[][] class11_l1() {
        return new Class[10][];
    }

    public static Class[][] class11_l2() {
        Class[][] bs = new Class[10][10];
        bs[1][0] = Class.class;
        bs[9][8] = Class.class;
        return bs;
    }

    public static Class[][] class11_lj() {
        Class[][] bs = new Class[10][];
        bs[0] = new Class[0];
        bs[1] = new Class[1];
        bs[2] = new Class[2];
        bs[3] = new Class[3];
        bs[4] = new Class[4];
        bs[5] = new Class[5];
        bs[6] = new Class[6];
        bs[7] = new Class[7];
        bs[8] = new Class[8];
        bs[9] = new Class[9];
        return bs;
    }

    public static Comparator[] interface1() {
        Comparator[] comparators = new Comparator[10];
        comparators[0]=String.CASE_INSENSITIVE_ORDER;
        return comparators;
    }

    public static Comparator[][] interface11_l1() {
        return new Comparator[10][];
    }

    public static Comparator[][] interface11_l2() {
        Comparator[][] bs = new Comparator[10][10];
        bs[1][0] = String.CASE_INSENSITIVE_ORDER;
        bs[9][8] = String.CASE_INSENSITIVE_ORDER;
        return bs;
    }

    public static Comparator[][] interface11_lj() {
        Comparator[][] bs = new Comparator[10][];
        bs[0] = new Comparator[0];
        bs[1] = new Comparator[1];
        bs[2] = new Comparator[2];
        bs[3] = new Comparator[3];
        bs[4] = new Comparator[4];
        bs[5] = new Comparator[5];
        bs[6] = new Comparator[6];
        bs[7] = new Comparator[7];
        bs[8] = new Comparator[8];
        bs[9] = new Comparator[9];
        return bs;
    }

    public static boolean equals(Object a, Object b){
        return a.equals(b);
    }
}
