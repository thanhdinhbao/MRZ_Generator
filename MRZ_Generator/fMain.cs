//Code by ThanhDinhBao
//20/04/2024
//https://www.facebook.com/thanhdinhbao.k20
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MRZ_Generator
{
    public partial class Form1 : Form
    {
        List<Tuple<string, string>> provinces;
        public Form1()
        {
            InitializeComponent();
            provinces = new List<Tuple<string, string>>()
            {
                Tuple.Create("001","Hà Nội"),
                Tuple.Create("002","Hà Giang"),
                Tuple.Create("004","Cao Bằng"),
                Tuple.Create("006","Bắc Kạn"),
                Tuple.Create("008","Tuyên Quang"),
                Tuple.Create("010","Lào Cai"),
                Tuple.Create("011","Điện Biên"),
                Tuple.Create("012","Lai Châu"),
                Tuple.Create("014","Sơn La"),
                Tuple.Create("015","Yên Bái"),
                Tuple.Create("017","Hòa Bình"),
                Tuple.Create("019","Thái Nguyên"),
                Tuple.Create("020","Lạng Sơn"),
                Tuple.Create("022","Quảng Ninh"),
                Tuple.Create("024","Bắc Giang"),
                Tuple.Create("025","Phú Thọ"),
                Tuple.Create("026","Vĩnh Phúc"),
                Tuple.Create("027","Bắc Ninh"),
                Tuple.Create("030","Hải Dương"),
                Tuple.Create("031","Hải Phòng"),
                Tuple.Create("033","Hưng Yên"),
                Tuple.Create("034","Thái Bình"),
                Tuple.Create("035","Hà Nam"),
                Tuple.Create("036","Nam Định"),
                Tuple.Create("037","Ninh Bình"),
                Tuple.Create("038","Thanh Hóa"),
                Tuple.Create("040","Nghệ An"),
                Tuple.Create("042","Hà Tĩnh"),
                Tuple.Create("044","Quảng Bình"),
                Tuple.Create("045","Quảng Trị"),
                Tuple.Create("046","Thừa Thiên Huế"),
                Tuple.Create("048","Đà Nẵng"),
                Tuple.Create("049","Quảng Nam"),
                Tuple.Create("051","Quảng Ngãi"),
                Tuple.Create("052","Bình Định"),
                Tuple.Create("054","Phú Yên"),
                Tuple.Create("056","Khánh Hòa"),
                Tuple.Create("058","Ninh Thuận"),
                Tuple.Create("060","Bình Thuận"),
                Tuple.Create("062","Kon Tum"),
                Tuple.Create("064","Gia Lai"),
                Tuple.Create("066","Đắk Lắk"),
                Tuple.Create("067","Đắk Nông"),
                Tuple.Create("068","Lâm Đồng"),
                Tuple.Create("070","Bình Phước"),
                Tuple.Create("072","Tây Ninh"),
                Tuple.Create("074","Bình Dương"),
                Tuple.Create("075","Đồng Nai"),
                Tuple.Create("077","Bà Rịa - Vũng Tàu"),
                Tuple.Create("079","Hồ Chí Minh"),
                Tuple.Create("080","Long An"),
                Tuple.Create("082","Tiền Giang"),
                Tuple.Create("083","Bến Tre"),
                Tuple.Create("084","Trà Vinh"),
                Tuple.Create("086","Vĩnh Long"),
                Tuple.Create("087","Đồng Tháp"),
                Tuple.Create("089","An Giang"),
                Tuple.Create("091","Kiên Giang"),
                Tuple.Create("092","Cần Thơ"),
                Tuple.Create("093","Hậu Giang"),
                Tuple.Create("094","Sóc Trăng"),
                Tuple.Create("095","Bạc Liêu"),
                Tuple.Create("096","Cà Mau")
            };
            cbProvince.DataSource = provinces;
            cbProvince.ValueMember = "Item1";
            cbProvince.DisplayMember = "Item2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtNgayCap.CustomFormat = "dd/MM/yyyy";
            dtDOB.CustomFormat = "dd/MM/yyyy";
        }

        public string GetName()
        {
            string[] ten = txtLName.Text.Trim().ToUpper().Split(' ');
            return txtFName.Text.Trim().ToUpper() + "<<" + string.Join("<", ten);
        }

        public string GetProvinceCode()
        {
            return cbProvince.SelectedValue.ToString();
        }

        public string GetSex()
        {
            string sex;
            if (radMale.Checked)
            {
                sex = "M";
            }
            else
            {
                sex = "F";
            }

            return sex;

        }

        public string getDOB()
        {
            string date  = dtDOB.Value.ToString("yyMMdd");
            return date;
        }

        public string getExpDate()
        {
            string date = dtNgayCap.Value.ToString("yyMMdd");
            return date;
        }
        private static int GenDigit(string phrase)
        {
            int result = 0;
            int count = 0;
            int charValue = 0;

            Dictionary<char, int> mrzCheckDigitLookup = new Dictionary<char, int>();

            mrzCheckDigitLookup.Add('<', 0);
            mrzCheckDigitLookup.Add('A', 10);
            mrzCheckDigitLookup.Add('B', 11);
            mrzCheckDigitLookup.Add('C', 12);
            mrzCheckDigitLookup.Add('D', 13);
            mrzCheckDigitLookup.Add('E', 14);
            mrzCheckDigitLookup.Add('F', 15);
            mrzCheckDigitLookup.Add('G', 16);
            mrzCheckDigitLookup.Add('H', 17);
            mrzCheckDigitLookup.Add('I', 18);
            mrzCheckDigitLookup.Add('J', 19);
            mrzCheckDigitLookup.Add('K', 20);
            mrzCheckDigitLookup.Add('L', 21);
            mrzCheckDigitLookup.Add('M', 22);
            mrzCheckDigitLookup.Add('N', 23);
            mrzCheckDigitLookup.Add('O', 24);
            mrzCheckDigitLookup.Add('P', 25);
            mrzCheckDigitLookup.Add('Q', 26);
            mrzCheckDigitLookup.Add('R', 27);
            mrzCheckDigitLookup.Add('S', 28);
            mrzCheckDigitLookup.Add('T', 29);
            mrzCheckDigitLookup.Add('U', 30);
            mrzCheckDigitLookup.Add('V', 31);
            mrzCheckDigitLookup.Add('W', 32);
            mrzCheckDigitLookup.Add('X', 33);
            mrzCheckDigitLookup.Add('Y', 34);
            mrzCheckDigitLookup.Add('Z', 35);

            foreach (var letter in phrase.Replace(' ', '<').ToUpper().ToCharArray())
            {
                count++;

                if (Char.IsNumber(letter))
                {
                    charValue = (int)char.GetNumericValue(letter);
                }
                else if (mrzCheckDigitLookup.ContainsKey(letter))
                {
                    charValue = mrzCheckDigitLookup[letter];
                }
                else
                {
                    var ex = new Exception("Unknown character in MRZ :" + letter);
                    throw ex;
                }

                var weightedcharValue = WeightingMultiplier(count, charValue);
                result += weightedcharValue;
                var tmp = " " + letter + "[" + charValue + "] * " + WeightingMultiplier(count, 1) + " = " + weightedcharValue + " += " + result;
                if (count > 2)
                {
                    count = 0;
                }
                //tmp.Dump();
            }

            var remainder = result % 10;
            //(result+" % 10 = "+remainder+Environment.NewLine).Dump();

            return remainder;
        }

        private static int WeightingMultiplier(int count, int value)
        {
            switch (count)
            {
                case 1:
                    value *= 7;
                    break;
                case 2:
                    value *= 3;
                    break;
                case 3:
                    value *= 1;
                    break;
            }

            return value;
        }

        private Dictionary<string, string> ProvinceCode = new Dictionary<string, string>
    {
        {"Hà Nội","001"},
        {"Hà Giang","002"},
        {"Cao Bằng","004"},
        {"Bắc Kạn","006"},
        {"Tuyên Quang","008"},
        {"Lào Cai","010"},
        {"Điện Biên","011"},
        {"Lai Châu","012"},
        {"Sơn La","014"},
        {"Yên Bái","015"},
        {"Hòa Bình","017"},
        {"Thái Nguyên","019"},
        {"Lạng Sơn","020"},
        {"Quảng Ninh","022"},
        {"Bắc Giang","024"},
        {"Phú Thọ","025"},
        {"Vĩnh Phúc","026"},
        {"Bắc Ninh","027"},
        {"Hải Dương","030"},
        {"Hải Phòng","031"},
        {"Hưng Yên","033"},
        {"Thái Bình","034"},
        {"Hà Nam","035"},
        {"Nam Định","036"},
        {"Ninh Bình","037"},
        {"Thanh Hóa","038"},
        {"Nghệ An","040"},
        {"Hà Tĩnh","042"},
        {"Quảng Bình","044"},
        {"Quảng Trị","045"},
        {"Thừa Thiên Huế","046"},
        {"Đà Nẵng","048"},
        {"Quảng Nam","049"},
        {"Quảng Ngãi","051"},
        {"Bình Định","052"},
        {"Phú Yên","054"},
        {"Khánh Hòa","056"},
        {"Ninh Thuận","058"},
        {"Bình Thuận","060"},
        {"Kon Tum","062"},
        {"Gia Lai","064"},
        {"Đắk Lắk","066"},
        {"Đắk Nông","067"},
        {"Lâm Đồng","068"},
        {"Bình Phước","070"},
        {"Tây Ninh","072"},
        {"Bình Dương","074"},
        {"Đồng Nai","075"},
        {"Bà Rịa - Vũng Tàu","077"},
        {"Hồ Chí Minh","079"},
        {"Long An","080"},
        {"Tiền Giang","082"},
        {"Bến Tre","083"},
        {"Trà Vinh","084"},
        {"Vĩnh Long","086"},
        {"Đồng Tháp","087"},
        {"An Giang","089"},
        {"Kiên Giang","091"},
        {"Cần Thơ","092"},
        {"Hậu Giang","093"},
        {"Sóc Trăng","094"},
        {"Bạc Liêu","095"},
        {"Cà Mau","096"}
    };

        public class Utilities
        {
            public static void ResetAllControls(Control form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = null;
                    }

                    if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count > 0)
                            comboBox.SelectedIndex = 0;
                    }

                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.Checked = false;
                    }

                    if (control is ListBox)
                    {
                        ListBox listBox = (ListBox)control;
                        listBox.ClearSelected();
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            //Gen final Hash
            string f1 = txtID.Text + GenDigit(txtID.Text) + GetProvinceCode() + txtID.Text + "<<" + GenDigit(GetProvinceCode() + txtID.Text);
            string f2 = getDOB() + GenDigit(getDOB()) + getExpDate() + GenDigit(getExpDate()) + "<<<<<<<<<<";
            string fHash = GenDigit(f1 + f2).ToString();

            //Gen each line
            string line1 = "IDVNM" + txtID.Text + GenDigit(txtID.Text) + GetProvinceCode() + txtID.Text + "<<" + GenDigit(GetProvinceCode() + txtID.Text) + Environment.NewLine;
            string line2 = getDOB() + GenDigit(getDOB()) + GetSex() + getExpDate() + GenDigit(getExpDate()) + "VNM" + "<<<<<<<<<<<" + fHash + Environment.NewLine;
            int len = GetName().Length;
            string line3 = GetName() + string.Concat(Enumerable.Repeat("<", 30 - len));

            txtResult.Text = line1 + line2 + line3;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
