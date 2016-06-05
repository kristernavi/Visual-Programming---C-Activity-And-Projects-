using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace Prefinal_Garcia
{
    public class DBConnection
    {
        private SqlCeConnection conn;
        public DBConnection()
        {
            //constructor
        }
        ~DBConnection()
        {
            //destructor
            conn = null;
        }
        public void Disconnect()
        {
            conn.Close();
        }
        public string ConnectToDatabase()
        {
            try
            {
                conn = new SqlCeConnection(@"Data Source=C:\Users\Sandra Suarez\Desktop\Prefinal_Garcia\Prefinal_Garcia\EnrollmentSystem.sdf");

                conn.Open();
                return "Connected";
            }
            catch (SqlCeException e)
            {
                conn = null;
                return e.Message;
            }
        }
        public DataTable getAllStudent()
        {
            try
            {
                string strCommand = "SELECT * FROM Student";
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(strCommand, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return null;
            }
        }
        public DataTable getAllStudentForEnroll()
        {
            try
            {
                string strCommand = "SELECT        stud_id, firstname, lastname, yrLevel, currentCredits, maxCredits FROM            Student";
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(strCommand, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return null;
            }
        }
        public Boolean userLogin(String user,String pass)
        {
            try
            {
                int num;
                string strCommand = "SELECT        username, password FROM Admin WHERE username = @User AND password = @Pass";
                SqlCeCommand cmdInsert = new SqlCeCommand();

                cmdInsert.Connection = conn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = strCommand;
                cmdInsert.Parameters.Add("@User", user);
                cmdInsert.Parameters.Add("@Pass",pass);
                num = cmdInsert.ExecuteNonQuery();
                MessageBox.Show(num.ToString());
                return true;
                
            }
            catch (SqlCeException e)
            {
                //MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return false;
            }
        }
        public DataTable getAllSubjectForEnroll()
        {
            try
            {
                string strCommand = "SELECT        Subject.Sub_ID, Subject.Sub_Name, SubjectOffer.section, SubjectOffer.currentCapacity, SubjectOffer.maxCapacity, Subject.Units, Professor.firstname + ' ' + Professor.lastname AS Handle,SubjectOffer.SubjectOffer_ID FROM            Professor INNER JOIN                         Subject ON Professor.Prof_Id = Subject.Prof_Id INNER JOIN                         SubjectOffer ON Subject.Sub_ID = SubjectOffer.Sub_Id WHERE        SubjectOffer.isOffer = 'true'";
               // string strCommand = "SELECT        section, isOffer, Sub_Id, currentCapacity, maxCapacity, SubjectOffer_ID FROM            SubjectOffer WHERE isOffer = 'true'";
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(strCommand, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return null;
            }
        }
        
        public DataTable getAllProfessor()
        {
            try
            {
                string strCommand = "SELECT Prof_Id,firstname + ', ' + lastname as Professor,contact,field  FROM Professor";
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(strCommand, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return null;
            }
        }
        public DataTable getAllSubject()
        {
            try
            {
                string strCommand = "SELECT        Subject.Sub_ID, Subject.Sub_Code, Subject.Sub_Name, Subject.Units, Subject.Description, Professor.firstname +', '+Professor.lastname as Handle FROM            Professor INNER JOIN  Subject ON Professor.Prof_Id = Subject.Prof_Id";
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(strCommand, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return null;
            }
        }
        public DataTable getAllSubjectEnroll()
        {
            try
            {
                string strCommand = "SELECT        Student.firstname+' '+ Student.lastname as StudentName, Subject.Sub_Name, SubjectOffer.section, Subject.Units, Professor.firstname +' '+ Professor.lastname AS Handle, SubjectEnroll.date_enroll  FROM            SubjectEnroll INNER JOIN                         SubjectOffer ON SubjectEnroll.SubjectOffer_ID = SubjectOffer.SubjectOffer_ID INNER JOIN                         Subject ON SubjectEnroll.Sub_Id = Subject.Sub_ID INNER JOIN                         Professor ON Subject.Prof_Id = Professor.Prof_Id INNER JOIN                         Student ON SubjectEnroll.Stud_Id = Student.stud_id";
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(strCommand, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return null;
            }
        }
        public DataTable getAllSubjectOffer()
        {
            try
            {
                string strCommand = "SELECT       SubjectOffer.SubjectOffer_ID, Subject.Sub_Name, SubjectOffer.section, SubjectOffer.currentCapacity, SubjectOffer.maxCapacity, SubjectOffer.isOffer FROM            Subject INNER JOIN                         SubjectOffer ON Subject.Sub_ID = SubjectOffer.Sub_Id";
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(strCommand, conn);
                da.Fill(dt);
                return dt;
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return null;
            }
        }
        public String studentInsert(Student student)
        {
            try
            {
                string strCommand = "INSERT INTO Student(firstname,lastname,age,yrLevel,currentCredits,maxCredits) VALUES(@Firstname,@Lastname,@Age,@YrLevel,@CurrentCredits,@MaxCredits)";
                SqlCeCommand cmdInsert = new SqlCeCommand();

                cmdInsert.Connection = conn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = strCommand;

                cmdInsert.Parameters.AddWithValue("@Firstname", student.Firstname);
                cmdInsert.Parameters.AddWithValue("@Lastname", student.Lastname);
                cmdInsert.Parameters.AddWithValue("@Age", student.Age);
                cmdInsert.Parameters.AddWithValue("@YrLevel", student.YrLevel);
                cmdInsert.Parameters.AddWithValue("@CurrentCredits", student.CurrentCredits);
                cmdInsert.Parameters.AddWithValue("@MaxCredits", student.MaxCredits);

                cmdInsert.ExecuteNonQuery();
                return "Successfull Added";
            }
            catch (SqlCeException e)
            {
                 MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "Fail to Add";
            }
        }
        public String studentUpdate(Student student)
        {
            try
            {
                string strCommand = "UPDATE       Student SET                firstname = @Firstname, lastname = @Lastname, age = @Age, yrLevel = @YrLevel, currentCredits = @CurrentCredits, maxCredits = @MaxCredits WHERE stud_id = @ID";
                SqlCeCommand cmdInsert = new SqlCeCommand();

                cmdInsert.Connection = conn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = strCommand;
                cmdInsert.Parameters.AddWithValue("@ID", student.ID);
                cmdInsert.Parameters.AddWithValue("@Firstname", student.Firstname);
                cmdInsert.Parameters.AddWithValue("@Lastname", student.Lastname);
                cmdInsert.Parameters.AddWithValue("@Age", student.Age);
                cmdInsert.Parameters.AddWithValue("@YrLevel", student.YrLevel);
                cmdInsert.Parameters.AddWithValue("@CurrentCredits", student.CurrentCredits);
                cmdInsert.Parameters.AddWithValue("@MaxCredits", student.MaxCredits);

                cmdInsert.ExecuteNonQuery();
                return "Successfull Added";
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "Fail to Add";
            }
        }
        public String subjecEnrollInsert(SubjectEnroll subjEnroll)
        {
            try
            {
                string strCommand = "INSERT INTO SubjectEnroll(Stud_Id,Sub_Id,date_enroll,SubjectOffer_ID) VALUES(@Stud_Id,@Sub_Id,@Date_enroll,@Subject_Offer_ID)";
                SqlCeCommand cmdInsert = new SqlCeCommand();

                cmdInsert.Connection = conn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = strCommand;

                cmdInsert.Parameters.AddWithValue("@Stud_Id", subjEnroll.StudentID);
                cmdInsert.Parameters.AddWithValue("@Sub_Id", subjEnroll.SubjectID);
                cmdInsert.Parameters.AddWithValue("@Date_enroll", subjEnroll.Date_Enroll);
                cmdInsert.Parameters.AddWithValue("@Subject_Offer_ID", subjEnroll.SubjectOfferID);
               

                cmdInsert.ExecuteNonQuery();
                return "Successfull Added";
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "Fail to Add";
            }
        }
        public String professorInsert(Professor professor)
        {
            try
            {
                string strCommand = "INSERT INTO Professor(firstname,lastname,field,contact) VALUES(@Firstname,@Lastname,@Field,@Contact)";
                SqlCeCommand cmdInsert = new SqlCeCommand();

                cmdInsert.Connection = conn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = strCommand;

                cmdInsert.Parameters.AddWithValue("@Firstname", professor.Firstname);
                cmdInsert.Parameters.AddWithValue("@Lastname", professor.Lastname);
                cmdInsert.Parameters.AddWithValue("@Field", professor.Field);
                cmdInsert.Parameters.AddWithValue("@Contact", professor.Contact);
                
                cmdInsert.ExecuteNonQuery();
                return "Successfull Added";
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "Fail to Add";
            }
        }
        public String professorUpdate(Professor professor)
        {
            try
            {
                string strCommand = "UPDATE       Professor SET               firstname = @Fistname, lastname = @Lastname, contact = @Contact, field = @Field WHERE Prof_Id = @ID";
                SqlCeCommand cmdInsert = new SqlCeCommand();

                cmdInsert.Connection = conn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = strCommand;
                cmdInsert.Parameters.AddWithValue("@ID", professor.ID);
                cmdInsert.Parameters.AddWithValue("@Firstname", professor.Firstname);
                cmdInsert.Parameters.AddWithValue("@Lastname", professor.Lastname);
                cmdInsert.Parameters.AddWithValue("@Field", professor.Field);
                cmdInsert.Parameters.AddWithValue("@Contact", professor.Contact);

                cmdInsert.ExecuteNonQuery();
                return "Successfull Added";
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "Fail to Add";
            }
        }
        public String subjectInsert(Subject subject)
        {
            try
            {
                string strCommand = "INSERT INTO Subject(Sub_Code,Sub_Name,Description,Units,Prof_Id) VALUES(@Sub_Code,@Sub_Name,@Description,@Units,@Prof_Id)";
                SqlCeCommand cmdInsert = new SqlCeCommand();

                cmdInsert.Connection = conn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = strCommand;

                cmdInsert.Parameters.AddWithValue("@Sub_Code", subject.Code);
                cmdInsert.Parameters.AddWithValue("@Sub_Name", subject.Name);
                cmdInsert.Parameters.AddWithValue("@Description", subject.Description);
                cmdInsert.Parameters.AddWithValue("@Units", subject.Units);
                cmdInsert.Parameters.AddWithValue("@Prof_Id", subject.Prof_ID);

                cmdInsert.ExecuteNonQuery();
                return "Successfull Added";
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "Fail to Add";
            }
        }
        public String subjectUpdate(Subject subject)
        {
            try
            {
                string strCommand = "UPDATE       Subject SET                Sub_Code = @Sub_Code, Sub_Name = @Sub_Name, Description = @Description, Units = @Units, Prof_Id = @Prof_Id WHERE Sub_ID = @ID";
                SqlCeCommand cmdInsert = new SqlCeCommand();

                cmdInsert.Connection = conn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = strCommand;
                cmdInsert.Parameters.AddWithValue("@ID", subject.ID);
                cmdInsert.Parameters.AddWithValue("@Sub_Code", subject.Code);
                cmdInsert.Parameters.AddWithValue("@Sub_Name", subject.Name);
                cmdInsert.Parameters.AddWithValue("@Description", subject.Description);
                cmdInsert.Parameters.AddWithValue("@Units", subject.Units);
                cmdInsert.Parameters.AddWithValue("@Prof_Id", subject.Prof_ID);

                cmdInsert.ExecuteNonQuery();
                return "Successfull Added";
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "Fail to Add";
            }
        }
        public String subjectOfferInsert(SubjectOffer subject)
        {
            try
            {
                string strCommand = "INSERT INTO SubjectOffer(section,isOffer,Sub_Id,currentCapacity,maxCapacity) VALUES(@Section,@IsOffer,@Sub_Id,@CurrentCapacity,@MaxCapacity)";
                SqlCeCommand cmdInsert = new SqlCeCommand();

                cmdInsert.Connection = conn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = strCommand;

                cmdInsert.Parameters.AddWithValue("@Section", subject.Section);
                cmdInsert.Parameters.AddWithValue("@IsOffer", subject.IsOffer);
                cmdInsert.Parameters.AddWithValue("@Sub_Id", subject.Sub_ID);
                cmdInsert.Parameters.AddWithValue("@CurrentCapacity", subject.CurrentCapacity);
                cmdInsert.Parameters.AddWithValue("@MaxCapacity", subject.MaxCapacity);

                cmdInsert.ExecuteNonQuery();
                return "Successfull Added";
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "Fail to Add";
            }
        }
        public String subjectOfferUpdate(SubjectOffer subject)
        {
            try
            {
                string strCommand = "UPDATE       SubjectOffer SET                section = @Section, Sub_Id = @Sub_Id, isOffer = @IsOffer, currentCapacity = @CurrentCapacity, maxCapacity = @MaxCapacity WHERE SubjectOffer_ID = @ID";
                SqlCeCommand cmdInsert = new SqlCeCommand();

                cmdInsert.Connection = conn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = strCommand;
                cmdInsert.Parameters.AddWithValue("@Section", subject.ID);
                cmdInsert.Parameters.AddWithValue("@Section", subject.Section);
                cmdInsert.Parameters.AddWithValue("@IsOffer", subject.IsOffer);
                cmdInsert.Parameters.AddWithValue("@Sub_Id", subject.Sub_ID);
                cmdInsert.Parameters.AddWithValue("@CurrentCapacity", subject.CurrentCapacity);
                cmdInsert.Parameters.AddWithValue("@MaxCapacity", subject.MaxCapacity);

                cmdInsert.ExecuteNonQuery();
                return "Successfull Added";
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return "Fail to Add";
            }
        }
        public int drugUpdate(string ID, string Name, DateTime expDate, string company, string type)
        {
            try
            {
                string strCommand = "Update Drugs Set Name=@Name,ExpiryDate=@ExpiryDate,Company=@Company,Type=@Type WHERE ID=" + ID;
                SqlCeCommand cmdUpdate = new SqlCeCommand();

                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;

                cmdUpdate.Parameters.AddWithValue("@ID", ID);
                cmdUpdate.Parameters.AddWithValue("@Name", Name);
                cmdUpdate.Parameters.AddWithValue("@ExpiryDate", expDate);
                cmdUpdate.Parameters.AddWithValue("@Company", company);
                cmdUpdate.Parameters.AddWithValue("@Type", type);

                return cmdUpdate.ExecuteNonQuery();
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return -1;
            }
        }
        public int updateStudentCurrentCredits(string id,int currentVal)
        {
            try
            {
                string strCommand = "Update Student Set currentCredits=@CurrentCredits WHERE stud_id=" + id;
                SqlCeCommand cmdUpdate = new SqlCeCommand();

                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;


                cmdUpdate.Parameters.AddWithValue("@CurrentCredits", currentVal);

                return cmdUpdate.ExecuteNonQuery();
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return -1;
            }
        }
        public int updateSubjectOfferCurrentCapacity(string id, int currentVal)
        {
            try
            {
                string strCommand = "Update SubjectOffer Set currentCapacity=@CurrentCapacity WHERE SubjectOffer_ID=" + id;
                SqlCeCommand cmdUpdate = new SqlCeCommand();

                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = strCommand;


                cmdUpdate.Parameters.AddWithValue("@CurrentCapacity", currentVal);

                return cmdUpdate.ExecuteNonQuery();
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return -1;
            }
        }

        public int itemDelete(string tableName,string idName,string ID)
        {
            try
            {
                string strCommand = "DELETE FROM "+tableName+" WHERE "+idName+"=" + ID;
                SqlCeCommand cmdDelete = new SqlCeCommand();

                cmdDelete.Connection = conn;
                cmdDelete.CommandType = CommandType.Text;
                cmdDelete.CommandText = strCommand;

                return cmdDelete.ExecuteNonQuery();
            }
            catch (SqlCeException e)
            {
                MessageBox.Show(e.Source + "\n" + e.Message + "\n" + e.StackTrace);
                return -1;
            }
        }
    }
}
