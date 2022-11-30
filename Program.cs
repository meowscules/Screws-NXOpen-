using NXOpen;
using NXOpen.UF;
using System.Collections;

namespace Screws
{
    public class Program
    {
        private static Session theSession;
        private static UI theUI;
        private static UFSession theUFSession;
        public static Program theProgram;
        public static bool isDisposeCalled;

        public Program()
        {
            try
            {
                theSession = Session.GetSession();
                theUI = UI.GetUI();
                theUFSession = UFSession.GetUFSession();
                isDisposeCalled = false;
            }
            catch (NXOpen.NXException ex)
            {
                UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Error, ex.Message);
            }
        }
        public static int Main(string[] args)
        {
            int retValue = 0;

            try
            {
                theProgram = new Program();
                Form1 window1 = new Form1();
                try
                {
                    window1.ShowDialog();
                }
                catch (NXOpen.NXException ex)
                {

                    UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Information, "Something went wrong");
                    UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Error, ex.Message);
                }
                theProgram.Dispose();
            }
            catch (NXOpen.NXException ex)
            {
                UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Information, "Something went wrong");
                UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Error, ex.Message);
            }
            return retValue;
        }

        public void Dispose()
        {
            try
            {
                if (isDisposeCalled == false)
                {
                    //TODO: Add your application code here 
                }
                isDisposeCalled = true;
            }
            catch (NXOpen.NXException ex)
            {
                UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Error, ex.Message);
            }
        }

        public static int GetUnloadOption(string arg)
        {
            return System.Convert.ToInt32(Session.LibraryUnloadOption.Immediately);
        }
        public static void CreateScrewGost147758(double[,] Cylinder_pts, double[,] Cut_pts, double[,] Chamfer_pts, string title)
        {
            Tag UFPart1;
            string name1 = title;
            int units1 = 1;
            theUFSession.Part.New(name1, units1, out UFPart1);
          
            UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Information, "Cylinder");
            double[] l1_endpt1 = { Cylinder_pts[0, 0], Cylinder_pts[0, 1], Cylinder_pts[0, 2] };
            double[] l1_endpt2 = { Cylinder_pts[1, 0], Cylinder_pts[1, 1], Cylinder_pts[1, 2] };
            double[] l2_endpt1 = { Cylinder_pts[2, 0], Cylinder_pts[2, 1], Cylinder_pts[2, 2] };
            double[] l2_endpt2 = { Cylinder_pts[3, 0], Cylinder_pts[3, 1], Cylinder_pts[3, 2] };
            double[] l3_endpt1 = { Cylinder_pts[4, 0], Cylinder_pts[4, 1], Cylinder_pts[4, 2] };
            double[] l3_endpt2 = { Cylinder_pts[5, 0], Cylinder_pts[5, 1], Cylinder_pts[5, 2] };
            double[] l4_endpt1 = { Cylinder_pts[6, 0], Cylinder_pts[6, 1], Cylinder_pts[6, 2] };
            double[] l4_endpt2 = { Cylinder_pts[7, 0], Cylinder_pts[7, 1], Cylinder_pts[7, 2] };
            double[] l5_endpt1 = { Cylinder_pts[8, 0], Cylinder_pts[8, 1], Cylinder_pts[8, 2] };
            double[] l5_endpt2 = { Cylinder_pts[9, 0], Cylinder_pts[9, 1], Cylinder_pts[9, 2] };
            double[] l6_endpt1 = { Cylinder_pts[10, 0], Cylinder_pts[10, 1], Cylinder_pts[10, 2] };
            double[] l6_endpt2 = { Cylinder_pts[11, 0], Cylinder_pts[11, 1], Cylinder_pts[11, 2] };

            UFCurve.Line line1 = new UFCurve.Line();
            UFCurve.Line line2 = new UFCurve.Line();
            UFCurve.Line line3 = new UFCurve.Line();
            UFCurve.Line line4 = new UFCurve.Line();
            UFCurve.Line line5 = new UFCurve.Line();
            UFCurve.Line line6 = new UFCurve.Line();

            line1.start_point = new double[3];
            line1.start_point[0] = l1_endpt1[0];
            line1.start_point[1] = l1_endpt1[1];
            line1.start_point[2] = l1_endpt1[2];
            line1.end_point = new double[3];
            line1.end_point[0] = l1_endpt2[0];
            line1.end_point[1] = l1_endpt2[1];
            line1.end_point[2] = l1_endpt2[2];
            line2.start_point = new double[3];
            line2.start_point[0] = l2_endpt1[0];
            line2.start_point[1] = l2_endpt1[1];
            line2.start_point[2] = l2_endpt1[2];
            line2.end_point = new double[3];
            line2.end_point[0] = l2_endpt2[0];
            line2.end_point[1] = l2_endpt2[1];
            line2.end_point[2] = l2_endpt2[2];
            line3.start_point = new double[3];
            line3.start_point[0] = l3_endpt1[0];
            line3.start_point[1] = l3_endpt1[1];
            line3.start_point[2] = l3_endpt1[2];
            line3.end_point = new double[3];
            line3.end_point[0] = l3_endpt2[0];
            line3.end_point[1] = l3_endpt2[1];
            line3.end_point[2] = l3_endpt2[2];
            line4.start_point = new double[3];
            line4.start_point[0] = l4_endpt1[0];
            line4.start_point[1] = l4_endpt1[1];
            line4.start_point[2] = l4_endpt1[2];
            line4.end_point = new double[3];
            line4.end_point[0] = l4_endpt2[0];
            line4.end_point[1] = l4_endpt2[1];
            line4.end_point[2] = l4_endpt2[2];
            line5.start_point = new double[3];
            line5.start_point[0] = l5_endpt1[0];
            line5.start_point[1] = l5_endpt1[1];
            line5.start_point[2] = l5_endpt1[2];
            line5.end_point = new double[3];
            line5.end_point[0] = l5_endpt2[0];
            line5.end_point[1] = l5_endpt2[1];
            line5.end_point[2] = l5_endpt2[2];
            line6.start_point = new double[3];
            line6.start_point[0] = l6_endpt1[0];
            line6.start_point[1] = l6_endpt1[1];
            line6.start_point[2] = l6_endpt1[2];
            line6.end_point = new double[3];
            line6.end_point[0] = l6_endpt2[0];
            line6.end_point[1] = l6_endpt2[1];
            line6.end_point[2] = l6_endpt2[2];

            Tag[] objarray1 = new Tag[7];
            theUFSession.Curve.CreateLine(ref line1, out
                objarray1[0]);
            theUFSession.Curve.CreateLine(ref line2, out
                objarray1[1]);
            theUFSession.Curve.CreateLine(ref line3, out
                objarray1[2]);
            theUFSession.Curve.CreateLine(ref line4, out
                objarray1[3]);
            theUFSession.Curve.CreateLine(ref line5, out
                objarray1[4]);
            theUFSession.Curve.CreateLine(ref line6, out
                objarray1[5]);

            double[] ref_pt1 = new double[3];
            ref_pt1[0] = 0.00;
            ref_pt1[1] = 0.00;
            ref_pt1[2] = 0.00;
            double[] direction1 = { 1.00, 0.00, 0.00 };
            string[] limit1 = { "0", "360" };
            Tag[] features1;
            theUFSession.Modl.CreateRevolved(objarray1, limit1, ref_pt1, direction1, FeatureSigns.Nullsign, out features1);
   
            UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Information, "Cut");
            double[] direction4 = { 1.0, 0.0, 0.0 };
            double[] ref_pt4 = new double[3];
            ref_pt4[0] = 0.00;
            ref_pt4[1] = 0.00;
            ref_pt4[2] = 0.00;
            string taper_angle4 = "0.0";
            string[] limit4 = { "0", "2.5" };
    
            Tag[] objarray4 = new Tag[5];
            Tag[] features4;

            double[] l11_endpt1 = { Cut_pts[0, 0], Cut_pts[0, 1], Cut_pts[0, 2] };
            double[] l11_endpt2 = { Cut_pts[1, 0], Cut_pts[1, 1], Cut_pts[1, 2] };
            double[] l33_endpt1 = { Cut_pts[2, 0], Cut_pts[2, 1], Cut_pts[2, 2] };
            double[] l33_endpt2 = { Cut_pts[3, 0], Cut_pts[3, 1], Cut_pts[3, 2] };
            double[] l22_endpt1 = { Cut_pts[4, 0], Cut_pts[4, 1], Cut_pts[4, 2] };
            double[] l22_endpt2 = { Cut_pts[5, 0], Cut_pts[5, 1], Cut_pts[5, 2] };
            double[] l44_endpt1 = { Cut_pts[6, 0], Cut_pts[6, 1], Cut_pts[6, 2] };
            double[] l44_endpt2 = { Cut_pts[7, 0], Cut_pts[7, 1], Cut_pts[7, 2] };

            UFCurve.Line line11 = new UFCurve.Line();
            UFCurve.Line line22 = new UFCurve.Line();
            UFCurve.Line line33 = new UFCurve.Line();
            UFCurve.Line line44 = new UFCurve.Line();

            line11.start_point = new double[3];
            line11.start_point[0] = l11_endpt1[0];
            line11.start_point[1] = l11_endpt1[1];
            line11.start_point[2] = l11_endpt1[2];

            line11.end_point = new double[3];
            line11.end_point[0] = l11_endpt2[0];
            line11.end_point[1] = l11_endpt2[1];
            line11.end_point[2] = l11_endpt2[2];

            line22.start_point = new double[3];
            line22.start_point[0] = l22_endpt1[0];
            line22.start_point[1] = l22_endpt1[1];
            line22.start_point[2] = l22_endpt1[2];
    
            line22.end_point = new double[3];
            line22.end_point[0] = l22_endpt2[0];
            line22.end_point[1] = l22_endpt2[1];
            line22.end_point[2] = l22_endpt2[2];

            line33.start_point = new double[3];
            line33.start_point[0] = l33_endpt1[0];
            line33.start_point[1] = l33_endpt1[1];
            line33.start_point[2] = l33_endpt1[2];
            line33.end_point = new double[3];
            line33.end_point[0] = l33_endpt2[0];
            line33.end_point[1] = l33_endpt2[1];
            line33.end_point[2] = l33_endpt2[2];

            line44.start_point = new double[3];
            line44.start_point[0] = l44_endpt1[0];
            line44.start_point[1] = l44_endpt1[1];
            line44.start_point[2] = l44_endpt1[2];
            line44.end_point = new double[3];
            line44.end_point[0] = l44_endpt2[0];
            line44.end_point[1] = l44_endpt2[1];
            line44.end_point[2] = l44_endpt2[2];
            theUFSession.Curve.CreateLine(ref line11, out objarray4[0]);
            theUFSession.Curve.CreateLine(ref line33, out objarray4[1]);
            theUFSession.Curve.CreateLine(ref line22, out objarray4[2]);
            theUFSession.Curve.CreateLine(ref line44, out objarray4[3]);
            theUFSession.Modl.CreateExtruded(objarray4,
            taper_angle4,
            limit4,
            ref_pt4,
            direction4,
            FeatureSigns.Negative,
            out features4
            );
        
            UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Information, "Chamfer");
            double[] l111_endpt1 = { Chamfer_pts[0, 0], Chamfer_pts[0, 1], Chamfer_pts[0, 2] };
            double[] l111_endpt2 = { Chamfer_pts[1, 0], Chamfer_pts[1, 1], Chamfer_pts[1, 2] };
            double[] l222_endpt1 = { Chamfer_pts[2, 0], Chamfer_pts[2, 1], Chamfer_pts[2, 2] };
            double[] l222_endpt2 = { Chamfer_pts[3, 0], Chamfer_pts[3, 1], Chamfer_pts[3, 2] };
            double[] l333_endpt1 = { Chamfer_pts[4, 0], Chamfer_pts[4, 1], Chamfer_pts[4, 2] };
            double[] l333_endpt2 = { Chamfer_pts[5, 0], Chamfer_pts[5, 1], Chamfer_pts[5, 2] };
            double[] l444_endpt1 = { Chamfer_pts[6, 0], Chamfer_pts[6, 1], Chamfer_pts[6, 2] };
            double[] l444_endpt2 = { Chamfer_pts[7, 0], Chamfer_pts[7, 1], Chamfer_pts[7, 2] };
            double[] l555_endpt1 = { Chamfer_pts[8, 0], Chamfer_pts[8, 1], Chamfer_pts[8, 2] };
            double[] l555_endpt2 = { Chamfer_pts[9, 0], Chamfer_pts[9, 1], Chamfer_pts[9, 2] };
            double[] l666_endpt1 = { Chamfer_pts[10, 0], Chamfer_pts[10, 1], Chamfer_pts[10, 2] };
            double[] l666_endpt2 = { Chamfer_pts[11, 0], Chamfer_pts[11, 1], Chamfer_pts[11, 2] };

            UFCurve.Line line111 = new UFCurve.Line();
            UFCurve.Line line222 = new UFCurve.Line();
            UFCurve.Line line333 = new UFCurve.Line();
            UFCurve.Line line444 = new UFCurve.Line();
            UFCurve.Line line555 = new UFCurve.Line();
            UFCurve.Line line666 = new UFCurve.Line();

            line111.start_point = new double[3];
            line111.start_point[0] = l111_endpt1[0];
            line111.start_point[1] = l111_endpt1[1];
            line111.start_point[2] = l111_endpt1[2];
            line111.end_point = new double[3];
            line111.end_point[0] = l111_endpt2[0];
            line111.end_point[1] = l111_endpt2[1];
            line111.end_point[2] = l111_endpt2[2];
            line222.start_point = new double[3];
            line222.start_point[0] = l222_endpt1[0];
            line222.start_point[1] = l222_endpt1[1];
            line222.start_point[2] = l222_endpt1[2];
            line222.end_point = new double[3];
            line222.end_point[0] = l222_endpt2[0];
            line222.end_point[1] = l222_endpt2[1];
            line222.end_point[2] = l222_endpt2[2];
            line333.start_point = new double[3];
            line333.start_point[0] = l333_endpt1[0];
            line333.start_point[1] = l333_endpt1[1];
            line333.start_point[2] = l333_endpt1[2];
            line333.end_point = new double[3];
            line333.end_point[0] = l333_endpt2[0];
            line333.end_point[1] = l333_endpt2[1];
            line333.end_point[2] = l333_endpt2[2];
            line444.start_point = new double[3];
            line444.start_point[0] = l444_endpt1[0];
            line444.start_point[1] = l444_endpt1[1];
            line444.start_point[2] = l444_endpt1[2];
            line444.end_point = new double[3];
            line444.end_point[0] = l444_endpt2[0];
            line444.end_point[1] = l444_endpt2[1];
            line444.end_point[2] = l444_endpt2[2];
            line555.start_point = new double[3];
            line555.start_point[0] = l555_endpt1[0];
            line555.start_point[1] = l555_endpt1[1];
            line555.start_point[2] = l555_endpt1[2];
            line555.end_point = new double[3];
            line555.end_point[0] = l555_endpt2[0];
            line555.end_point[1] = l555_endpt2[1];
            line555.end_point[2] = l555_endpt2[2];
            line666.start_point = new double[3];
            line666.start_point[0] = l666_endpt1[0];
            line666.start_point[1] = l666_endpt1[1];
            line666.start_point[2] = l666_endpt1[2];
            line666.end_point = new double[3];
            line666.end_point[0] = l666_endpt2[0];
            line666.end_point[1] = l666_endpt2[1];
            line666.end_point[2] = l666_endpt2[2];

            Tag[] objarray5 = new Tag[4];
            Tag[] objarray6 = new Tag[4];

            theUFSession.Curve.CreateLine(ref line111, out
                objarray5[0]);
            theUFSession.Curve.CreateLine(ref line222, out
                objarray5[1]);
            theUFSession.Curve.CreateLine(ref line333, out
                objarray5[2]);
            theUFSession.Curve.CreateLine(ref line444, out
                objarray6[2]);
            theUFSession.Curve.CreateLine(ref line555, out
                objarray6[1]);
            theUFSession.Curve.CreateLine(ref line666, out
                objarray6[0]);

            double[] ref_pt5 = new double[3];
            ref_pt5[0] = 0.00;
            ref_pt5[1] = 0.00;
            ref_pt5[2] = 0.00;
            double[] direction5 = { 1.00, 0.00, 0.00 };
            string[] limit5 = { "0", "360" };
            Tag[] features5;
            Tag[] features6;
            theUFSession.Modl.CreateRevolved(objarray5, limit5, ref_pt5, direction5, FeatureSigns.Negative, out features5);
            theUFSession.Modl.CreateRevolved(objarray6, limit5, ref_pt5, direction5, FeatureSigns.Negative, out features6);
        }
    
        public static void CreateScrewGost149180(double[,] Cylinder_pts, double[,] Cut_pts, string title)
        {
            UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Information, "Learn");

            Tag UFPart1;
            string name1 = title;
            int units1 = 1;
            theUFSession.Part.New(name1, units1, out UFPart1);
            UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Information, "Cylinder");

            double[] line1StrPoint = { Cylinder_pts[0, 0], Cylinder_pts[0, 1], Cylinder_pts[0, 2] }; // 0, 0, 0
            double[] line1EndPoint = { Cylinder_pts[1, 0], Cylinder_pts[1, 1], Cylinder_pts[1, 2] }; // 0, 4, 0

            double[] line2StrPoint = { Cylinder_pts[1, 0], Cylinder_pts[1, 1], Cylinder_pts[1, 2] }; // 0, 4, 0
            double[] line2EndPoint = { Cylinder_pts[2, 0], Cylinder_pts[2, 1], Cylinder_pts[2, 2] }; // 12, 4, 0

            double[] line3StrPoint = { Cylinder_pts[2, 0], Cylinder_pts[2, 1], Cylinder_pts[2, 2] }; // 12, 4, 0
            double[] line3EndPoint = { Cylinder_pts[3, 0], Cylinder_pts[3, 1], Cylinder_pts[3, 2] }; // 12, 6.5, 0

            double[] line4StrPoint = { Cylinder_pts[3, 0], Cylinder_pts[3, 1], Cylinder_pts[3, 2] }; // 12, 6.5, 0
            double[] line4EndPoint = { Cylinder_pts[4, 0], Cylinder_pts[4, 1], Cylinder_pts[4, 2] }; // 17, 6.5, 0

            double[] line5StrPoint = { Cylinder_pts[4, 0], Cylinder_pts[4, 1], Cylinder_pts[4, 2] }; // 17, 6.5, 0
            double[] line5EndPoint = { Cylinder_pts[5, 0], Cylinder_pts[5, 1], Cylinder_pts[5, 2] }; // 17, 0, 0

            double[] line6StrPoint = { Cylinder_pts[5, 0], Cylinder_pts[5, 1], Cylinder_pts[5, 2] }; //17, 0, 0
            double[] line6EndPoint = { Cylinder_pts[0, 0], Cylinder_pts[0, 1], Cylinder_pts[0, 2] }; //0, 0, 0

            UFCurve.Line line1 = new UFCurve.Line();
            UFCurve.Line line2 = new UFCurve.Line();
            UFCurve.Line line3 = new UFCurve.Line();
            UFCurve.Line line4 = new UFCurve.Line();
            UFCurve.Line line5 = new UFCurve.Line();
            UFCurve.Line line6 = new UFCurve.Line();

            line1.start_point = new double[3];
            line1.start_point[0] = line1StrPoint[0]; // x
            line1.start_point[1] = line1StrPoint[1]; // y
            line1.start_point[2] = line1StrPoint[2]; // z
            line1.end_point = new double[3];
            line1.end_point[0] = line1EndPoint[0];
            line1.end_point[1] = line1EndPoint[1];
            line1.end_point[2] = line1EndPoint[2];
            line2.start_point = new double[3];
            line2.start_point[0] = line2StrPoint[0];
            line2.start_point[1] = line2StrPoint[1];
            line2.start_point[2] = line2StrPoint[2];
            line2.end_point = new double[3];
            line2.end_point[0] = line2EndPoint[0];
            line2.end_point[1] = line2EndPoint[1];
            line2.end_point[2] = line2EndPoint[2];
            line3.start_point = new double[3];
            line3.start_point[0] = line3StrPoint[0];
            line3.start_point[1] = line3StrPoint[1];
            line3.start_point[2] = line3StrPoint[2];
            line3.end_point = new double[3];
            line3.end_point[0] = line3EndPoint[0];
            line3.end_point[1] = line3EndPoint[1];
            line3.end_point[2] = line3EndPoint[2];
            line4.start_point = new double[3];
            line4.start_point[0] = line4StrPoint[0];
            line4.start_point[1] = line4StrPoint[1];
            line4.start_point[2] = line4StrPoint[2];
            line4.end_point = new double[3];
            line4.end_point[0] = line4EndPoint[0];
            line4.end_point[1] = line4EndPoint[1];
            line4.end_point[2] = line4EndPoint[2];
            line5.start_point = new double[3];
            line5.start_point[0] = line5StrPoint[0];
            line5.start_point[1] = line5StrPoint[1];
            line5.start_point[2] = line5StrPoint[2];
            line5.end_point = new double[3];
            line5.end_point[0] = line5EndPoint[0];
            line5.end_point[1] = line5EndPoint[1];
            line5.end_point[2] = line5EndPoint[2];
            line6.start_point = new double[3];
            line6.start_point[0] = line6StrPoint[0];
            line6.start_point[1] = line6StrPoint[1];
            line6.start_point[2] = line6StrPoint[2];
            line6.end_point = new double[3];
            line6.end_point[0] = line6EndPoint[0];
            line6.end_point[1] = line6EndPoint[1];
            line6.end_point[2] = line6EndPoint[2];

            Tag[] objarray1 = new Tag[7];
            theUFSession.Curve.CreateLine(ref line1, out
                objarray1[0]);
            theUFSession.Curve.CreateLine(ref line2, out
                objarray1[1]);
            theUFSession.Curve.CreateLine(ref line3, out
                objarray1[2]);
            theUFSession.Curve.CreateLine(ref line4, out
                objarray1[3]);
            theUFSession.Curve.CreateLine(ref line5, out
                objarray1[4]);
            theUFSession.Curve.CreateLine(ref line6, out
                objarray1[5]);

            UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Information, "Revolve");

            //Задание точки вращения
            double[] ref_pt1 = new double[3];
            ref_pt1[0] = 0.00;
            ref_pt1[1] = 0.00;
            ref_pt1[2] = 0.00;
            //Задание вектора кращения
            double[] direction1 = { 1.00, 0.00, 0.00 };
            //Ограничения вращения(полный оборот)
            string[] limit1 = { "0", "360" };
            Tag[] features1;
            //Выполнение операции вращения
            theUFSession.Modl.CreateRevolved(objarray1, limit1, ref_pt1, direction1, FeatureSigns.Nullsign, out features1);


            //вырез под отвертку
            UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Information, "Cut");
            //Переменная задающая значения направления выдавливания ось XC
            double[] direction4 = { -1.0, 0.0, 0.0 };
            double[] ref_pt4 = new double[3];
            ref_pt4[0] = 0.00;
            ref_pt4[1] = 0.00;
            ref_pt4[2] = 0.00;
            //Требуемая, но не используемая переменная
            string taper_angle4 = "0.0";
            //Переменная, определяющая значение уклона при выдавливании
            string[] limit4 = { "0", "2.5" };
            //Переменная, определяющая параметры начала и конца операции выдавливания
            Tag[] objarray4 = new Tag[5];
            // Массив объектов из n элементов. Заполняется указателями на элементы эскиза выдавливания при их построении (линии и дуги)
            Tag[] features4;
            //features4 – переменная для записи указателя на объект,получившийся в результате операции выдавливания

            //Определение переменных содержащих координаты начальной и конечной
            double[] line11StrPoint = { Cut_pts[0, 0], Cut_pts[0, 1], Cut_pts[0, 2] };
            double[] line11EndPoint = { Cut_pts[1, 0], Cut_pts[1, 1], Cut_pts[1, 2] };

            double[] line33StrPoint = { Cut_pts[1, 0], Cut_pts[1, 1], Cut_pts[1, 2] };
            double[] line33EndPoint = { Cut_pts[2, 0], Cut_pts[2, 1], Cut_pts[2, 2] };

            double[] line22StrPoint = { Cut_pts[2, 0], Cut_pts[2, 1], Cut_pts[2, 2] };
            double[] line22EndPoint = { Cut_pts[3, 0], Cut_pts[3, 1], Cut_pts[3, 2] };

            double[] line44StrPoint = { Cut_pts[3, 0], Cut_pts[3, 1], Cut_pts[3, 2] };
            double[] line44EndPoint = { Cut_pts[0, 0], Cut_pts[0, 1], Cut_pts[0, 2] };

            UFCurve.Line line11 = new UFCurve.Line();
            UFCurve.Line line22 = new UFCurve.Line();
            UFCurve.Line line33 = new UFCurve.Line();
            UFCurve.Line line44 = new UFCurve.Line();

            line11.start_point = new double[3];
            line11.start_point[0] = line11StrPoint[0];
            line11.start_point[1] = line11StrPoint[1];
            line11.start_point[2] = line11StrPoint[2];
            line11.end_point = new double[3];
            line11.end_point[0] = line11EndPoint[0];
            line11.end_point[1] = line11EndPoint[1];
            line11.end_point[2] = line11EndPoint[2];

            line22.start_point = new double[3];
            line22.start_point[0] = line22StrPoint[0];
            line22.start_point[1] = line22StrPoint[1];
            line22.start_point[2] = line22StrPoint[2];
            line22.end_point = new double[3];
            line22.end_point[0] = line22EndPoint[0];
            line22.end_point[1] = line22EndPoint[1];
            line22.end_point[2] = line22EndPoint[2];

            line33.start_point = new double[3];
            line33.start_point[0] = line33StrPoint[0];
            line33.start_point[1] = line33StrPoint[1];
            line33.start_point[2] = line33StrPoint[2];
            line33.end_point = new double[3];
            line33.end_point[0] = line33EndPoint[0];
            line33.end_point[1] = line33EndPoint[1];
            line33.end_point[2] = line33EndPoint[2];

            line44.start_point = new double[3];
            line44.start_point[0] = line44StrPoint[0];
            line44.start_point[1] = line44StrPoint[1];
            line44.start_point[2] = line44StrPoint[2];
            line44.end_point = new double[3];
            line44.end_point[0] = line44EndPoint[0];
            line44.end_point[1] = line44EndPoint[1];
            line44.end_point[2] = line44EndPoint[2];

            theUFSession.Curve.CreateLine(ref line11, out objarray4[0]);
            theUFSession.Curve.CreateLine(ref line33, out objarray4[1]);
            theUFSession.Curve.CreateLine(ref line22, out objarray4[2]);
            theUFSession.Curve.CreateLine(ref line44, out objarray4[3]);
            //Создание операции выдавливания
            theUFSession.Modl.CreateExtruded(objarray4/*Массив объектов выдавливания*/,
            taper_angle4/*Угол уклона*/,
            limit4/*Начало и конец выдавливания*/,
            ref_pt4 /*Пустой параметр*/,
            direction4/*Направление выдавливания*/,
            FeatureSigns.Negative/*Буревая операция (ВЫЧИТАНИЕ)*/,
            out features4/*Выходной параметр - указатель на результат операции*/);

            //Создание притупления
            //Переменная указывающая на тип притупления
            int subtype = 3;
            string offset1 = "2";
            string offset2 = "0";
            string angle = "45";

            Tag feat = features1[0];
            Tag cyl_tag, obj_id_camf;
            Tag[] Edge_array_cyl, list1;
            int ecount;
            theUFSession.Modl.AskFeatBody(feat, out cyl_tag);
            theUFSession.Modl.AskBodyEdges(cyl_tag, out Edge_array_cyl);
            theUFSession.Modl.AskListCount(Edge_array_cyl, out ecount);

            ArrayList arrList = new ArrayList();

            for (int i = 0; i < ecount; i++)
            {
                Tag edge;
                theUFSession.Modl.AskListItem(Edge_array_cyl, i, out edge);
                if (i == 6)
                {
                    arrList.Add(edge);
                }
            }
            list1 = (Tag[])arrList.ToArray(typeof(Tag));
            theUFSession.Modl.CreateChamfer(subtype, offset1, offset2, angle, list1, out obj_id_camf);
        }

    }
}
