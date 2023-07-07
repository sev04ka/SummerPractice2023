using System.Numerics;

namespace RSA
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        bool enableCalculateNbuttonP = false;
        bool enableCalculateNbuttonQ = false;

        private void inputP_TextChanged(object sender, EventArgs e)
        {
            bool validationP = BigInteger.TryParse(inputP.Text, out BigInteger P);
            BigInteger.TryParse(inputQ.Text, out BigInteger Q);
            BigInteger.TryParse(inputE.Text, out BigInteger E);
            if (!validationP || P < 2)
            {
                ValidPnotnum.Visible = true;
            }
            else
            {
                ValidPnotnum.Visible = false;
            }

            if (!RSAMethods.CommonNumberCheck(P))
            {
                ValidPnotcommonnum.Visible = true;
            }
            else
            {
                ValidPnotcommonnum.Visible = false;
            }

            if (validationP && P >= 2 && RSAMethods.CommonNumberCheck(P))
            {
                enableCalculateNbuttonP = true;
            }
            else
            {
                enableCalculateNbuttonP = false;
            }
            if (enableCalculateNbuttonP && enableCalculateNbuttonQ)
            {
                CalculateNbutton.Enabled = true;
            }
            else
            {
                CalculateNbutton.Enabled = false;
            }

            if (BigInteger.GreatestCommonDivisor((Q - 1) * (P - 1), E) != 1 || !(E > 2) || !(E < (Q - 1) * (P - 1)))
            {
                ValidMutualycommon.Visible = true;
                CalculateD.Enabled = false;
            }
            else
            {
                ValidMutualycommon.Visible = false;
                CalculateD.Enabled = true;
            }
        }

        private void inputQ_TextChanged(object sender, EventArgs e)
        {
            bool validationQ = BigInteger.TryParse(inputQ.Text, out BigInteger Q);
            BigInteger.TryParse(inputP.Text, out BigInteger P);
            BigInteger.TryParse(inputE.Text, out BigInteger E);
            if (!validationQ || Q < 2)
            {
                ValidQnotnum.Visible = true;
            }
            else
            {
                ValidQnotnum.Visible = false;
            }

            if (!RSAMethods.CommonNumberCheck(Q))
            {
                ValidQnotcommonnum.Visible = true;
            }
            else
            {
                ValidQnotcommonnum.Visible = false;
            }

            if (validationQ && Q >= 2 && RSAMethods.CommonNumberCheck(Q))
            {
                enableCalculateNbuttonQ = true;
            }
            else
            {
                enableCalculateNbuttonQ = false;
            }
            if (enableCalculateNbuttonQ && enableCalculateNbuttonP)
            {
                CalculateNbutton.Enabled = true;
            }
            else
            {
                CalculateNbutton.Enabled = false;
            }

            if (BigInteger.GreatestCommonDivisor((Q - 1) * (P - 1), E) != 1 || !(E > 2) || !(E < (Q - 1) * (P - 1)))
            {
                ValidMutualycommon.Visible = true;
                CalculateD.Enabled = false;
            }
            else
            {
                ValidMutualycommon.Visible = false;
                CalculateD.Enabled = true;
            }
        }

        private void inputD_TextChanged(object sender, EventArgs e)
        {
            bool validationD = BigInteger.TryParse(inputD.Text, out BigInteger D);
            bool validationN = BigInteger.TryParse(inputN.Text, out BigInteger N);
            if (!validationD || D < 2)
            {
                ValidDnotnum.Visible = true;
            }
            else
            {
                ValidDnotnum.Visible = false;
                if ((!validationN || N < 2) && (!validationD || D < 2))
                {
                    buttonDecrypt.Enabled = false;
                }
                else
                {
                    buttonDecrypt.Enabled = true;
                }
            }
        }

        private void inputN_TextChanged(object sender, EventArgs e)
        {
            bool validationN = BigInteger.TryParse(inputN.Text, out BigInteger N);
            bool validationD = BigInteger.TryParse(inputD.Text, out BigInteger D);
            bool validationE = BigInteger.TryParse(inputE.Text, out BigInteger E);
            if (!validationN || N < 2)
            {
                ValidNnotnum.Visible = true;
            }
            else
            {
                ValidNnotnum.Visible = false;
                if ((!validationN || N < 2) && (!validationE || E < 2))
                {
                    buttonEncrypt.Enabled = false;
                }
                else
                {
                    buttonEncrypt.Enabled = true;
                }
                if ((!validationN || N < 2) && (!validationD || D < 2))
                {
                    buttonDecrypt.Enabled = false;
                }
                else
                {
                    buttonDecrypt.Enabled = true;
                }
            }
        }

        private void inputE_TextChanged(object sender, EventArgs e)
        {
            bool validationE = BigInteger.TryParse(inputE.Text, out BigInteger E);
            bool validationN = BigInteger.TryParse(inputN.Text, out BigInteger N);
            BigInteger.TryParse(inputQ.Text, out BigInteger Q);
            BigInteger.TryParse(inputP.Text, out BigInteger P);
            if (!validationE || E < 2)
            {
                ValidEnotnum.Visible = true;
            }
            else
            {
                ValidEnotnum.Visible = false;
                if (BigInteger.GreatestCommonDivisor((Q - 1) * (P - 1), E) != 1 || !(E > 2) || !(E < (Q - 1) * (P - 1)))
                {
                    ValidMutualycommon.Visible = true;
                    CalculateD.Enabled = false;
                }
                else
                {
                    ValidMutualycommon.Visible = false;
                    CalculateD.Enabled = true;
                }
                if ((!validationN || N < 2) && (!validationE || E < 2))
                {
                    buttonEncrypt.Enabled = false;
                }
                else
                {
                    buttonEncrypt.Enabled = true;
                }
            }
        }

        private void CalculateNbutton_Click(object sender, EventArgs e)
        {
            BigInteger q = BigInteger.Parse(inputQ.Text);
            BigInteger p = BigInteger.Parse(inputP.Text);
            inputN.Text = RSAMethods.CalculateN(p, q).ToString();
        }

        private void GenerateRandom_Click(object sender, EventArgs e)
        {
            BigInteger Q;
            BigInteger P;
            BigInteger E;
            RSAMethods.RandomKeys(out Q, out P, out E);
            inputQ.Text = Q.ToString();
            inputP.Text = P.ToString();
            inputE.Text = E.ToString();
            inputN.Text = RSAMethods.CalculateN(P, Q).ToString();
            inputD.Text = RSAMethods.CalculateD(BigInteger.Parse(inputP.Text), BigInteger.Parse(inputQ.Text), BigInteger.Parse(inputE.Text)).ToString();
        }

        private void CalculateD_Click(object sender, EventArgs e)
        {
            inputD.Text = RSAMethods.CalculateD(BigInteger.Parse(inputP.Text), BigInteger.Parse(inputQ.Text), BigInteger.Parse(inputE.Text)).ToString();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            BigInteger N = BigInteger.Parse(inputN.Text);
            BigInteger E = BigInteger.Parse(inputE.Text);
            char[] textArray = TextInput.Text.ToCharArray();
            List<char> inputText = new List<char>(textArray);
            EncryptedText.Text = RSAMethods.EnCrypt(inputText, N, E);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            BigInteger D = BigInteger.Parse(inputD.Text);
            BigInteger N = BigInteger.Parse(inputN.Text);
            string[] inputCryptedTextArray = EncryptedText.Text.Split(" ");
            List<long> cryptedTextArray = new List<long>();
            foreach (string elem in inputCryptedTextArray)
            {
                long.TryParse(elem, out long parsedelem);
                cryptedTextArray.Add(parsedelem);
            }

            DecryptedText.Text = RSAMethods.DeCrypt(cryptedTextArray, N, D);
        }

        private void ValidPnotcommonnum_Click(object sender, EventArgs e)
        {

        }

        private void ValidMutualycommon_Click(object sender, EventArgs e)
        {

        }
    }
}