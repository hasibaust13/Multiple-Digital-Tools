using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Printing;
using System.Security.Permissions;

using Microsoft.VisualBasic;

using System.Diagnostics;

namespace Virtual_Keyboard
{
    public partial class Form1 : Form
    {
        private const int CS_DROPSHADOW = 0 * 00020000;

        public Form1()
        {
            InitializeComponent();
        }

        private void CHANGEPASSWORD3_Load(object sender, EventArgs e) 
        {

        }

        private void CALLBUTTON(Button BTN)
        {
            if (ShiftR.FlatStyle == FlatStyle.Flat)
            {
                textBox1.Text = textBox1.Text + BTN.Text;
                ShiftR.PerformClick();
            }
            textBox1.Text = textBox1.Text + BTN.Text;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CALLBUTTON(b1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CALLBUTTON(b0);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bo);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            CALLBUTTON(ba);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " ";
        }

        private void ShiftR_Click(object sender, EventArgs e)
        {
            if (ShiftR.FlatStyle == FlatStyle.Flat)
            {
                ShiftR.FlatStyle = FlatStyle.Standard;
                ShiftL.FlatStyle = FlatStyle.Standard;
                foreach (Control ctl in this.Controls)
                {
                    if ((ctl.Name.StartsWith("Button")))
                    {
                        Button btn = (Button)ctl;
                        btn.Text = btn.Text.ToLower();
                        b1.Text = "1";
                        b2.Text = "2";
                        b3.Text = "3";
                        b4.Text = "4";
                        b5.Text = "5";
                        b6.Text = "6";
                        b7.Text = "7";
                        b8.Text = "8";
                        b9.Text = "9";
                        b0.Text = "0";
                        bminus.Text = "-";
                        bequal.Text = "=";
                        button1.Text = "`";
                        brightslace.Text = "\\";
                        brightbracket.Text = "]";
                        bleftbracket.Text = "[";
                        bsingle.Text = "'";
                        bsemi.Text = ";";
                        bleftslace.Text = "/";
                        bdot.Text = ".";
                        bcoma.Text = ",";
                    }
                }
            }
            else if (ShiftR.FlatStyle == FlatStyle.Standard)
            {
                ShiftL.FlatStyle = FlatStyle.Flat;
                ShiftR.FlatStyle = FlatStyle.Flat;
                foreach (Control ctl in this.Controls)
                {
                    if ((ctl.Name.StartsWith("Button")))
                    {
                        Button btn = (Button)ctl;
                        btn.Text = btn.Text.ToUpper();
                        b1.Text = "!";
                        b2.Text = "@";
                        b3.Text = "#";
                        b4.Text = "$";
                        b5.Text = "%";
                        b6.Text = "^";
                        b7.Text = "&";
                        b8.Text = "*";
                        b9.Text = "(";
                        b0.Text = ")";
                        bminus.Text = "_";
                        bequal.Text = "+";
                        button1.Text = "~";
                        brightslace.Text = "|";
                        brightbracket.Text = "}";
                        bleftbracket.Text = "{";
                        bsemi.Text = ":";
                        bleftslace.Text = "?";
                        bdot.Text = ">";
                        bcoma.Text = "<";
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CALLBUTTON(b2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CALLBUTTON(b3);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CALLBUTTON(b4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CALLBUTTON(b5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CALLBUTTON(b6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CALLBUTTON(b7);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CALLBUTTON(b8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CALLBUTTON(b9);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bminus);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bequal);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " ")
                {
                    textBox1.Text = Strings.Mid(textBox1.Text, 1, Strings.Len(textBox1.Text) - 1 + 1);
                }
                else
                {
                    textBox1.Text = Strings.Mid(textBox1.Text, 1, Strings.Len(textBox1.Text) - 1);
                }
            }
            catch (Exception ERR) { }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Environment.NewLine;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bq);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bw);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            CALLBUTTON(be);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            CALLBUTTON(br);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bt);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CALLBUTTON(by);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bu);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bi);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bp);
        }

        private void bleftbracket_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bleftbracket);
        }

        private void brightbracket_Click(object sender, EventArgs e)
        {
            CALLBUTTON(brightbracket);
        }

        private void brightslace_Click(object sender, EventArgs e)
        {
            CALLBUTTON(brightslace);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bs);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bd);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bf);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bg);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bh);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bj);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bk);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bl);
        }

        private void bsemi_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bsemi);
        }

        private void bsingle_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bsingle);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bz);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bx);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bc);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bv);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bb);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bn);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bm);
        }

        private void bcoma_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bcoma);
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bdot);
        }

        private void bleftslace_Click(object sender, EventArgs e)
        {
            CALLBUTTON(bleftslace);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "     ";
        }


        private void ShiftL_Click(object sender, EventArgs e)
        {

        }

        private void Caps_Click(object sender, EventArgs e)
        {
            if (Caps.BackColor == Color.Red)
            {
                Caps.BackColor = Color.FromKnownColor(KnownColor.Control);

                b1.Text = "1";
                b2.Text = "2";
                b3.Text = "3";
                b4.Text = "4";
                b5.Text = "5";
                b6.Text = "6";
                b7.Text = "7";
                b8.Text = "8";
                b9.Text = "9";
                b0.Text = "0";
                bminus.Text = "-";
                bequal.Text = "=";
                button1.Text = "`";
                brightslace.Text = "\\";
                brightbracket.Text = "]";
                bleftbracket.Text = "[";
                bsingle.Text = "'";
                bsemi.Text = ";";
                bleftslace.Text = "/";
                bdot.Text = ".";
                bcoma.Text = ",";

                ba.Text = "a";
                bb.Text = "b";
                bc.Text = "c";
                bd.Text = "d";
                be.Text = "e";
                bf.Text = "f";
                bg.Text = "g";
                bh.Text = "h";
                bi.Text = "i";
                bj.Text = "j";
                bk.Text = "k";
                bl.Text = "l";
                bm.Text = "m";
                bn.Text = "n";
                bo.Text = "o";
                bp.Text = "p";
                bq.Text = "q";
                br.Text = "r";
                bs.Text = "s";
                bt.Text = "t";
                bu.Text = "u";
                bv.Text = "v";
                bw.Text = "w";
                bx.Text = "x";
                by.Text = "y";
                bz.Text = "z";
            }

            else
            {
                Caps.BackColor = Color.Red;

                        b1.Text = "!";
                        b2.Text = "@";
                        b3.Text = "#";
                        b4.Text = "$";
                        b5.Text = "%";
                        b6.Text = "^";
                        b7.Text = "&";
                        b8.Text = "*";
                        b9.Text = "(";
                        b0.Text = ")";
                        bminus.Text = "_";
                        bequal.Text = "+";
                        button1.Text = "~";
                        brightslace.Text = "|";
                        brightbracket.Text = "}";
                        bleftbracket.Text = "{";
                        bsemi.Text = ":";
                        bleftslace.Text = "?";
                        bdot.Text = ">";
                        bcoma.Text = "<";

                        ba.Text = "A";
                        bb.Text = "B";
                        bc.Text = "C";
                        bd.Text = "D";
                        be.Text = "E";
                        bf.Text = "F";
                        bg.Text = "G";
                        bh.Text = "H";
                        bi.Text = "I";
                        bj.Text = "J";
                        bk.Text = "K";
                        bl.Text = "L";
                        bm.Text = "M";
                        bn.Text = "N";
                        bo.Text = "O";
                        bp.Text = "P";
                        bq.Text = "Q";
                        br.Text = "R";
                        bs.Text = "S";
                        bt.Text = "T";
                        bu.Text = "U";
                        bv.Text = "V";
                        bw.Text = "W";
                        bx.Text = "X";
                        by.Text = "Y";
                        bz.Text = "Z";
                }
            }
        }
   }
