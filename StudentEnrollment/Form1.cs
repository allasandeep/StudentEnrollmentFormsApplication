/*******************************************************************************************************************
 *                                                                                                                 *
 *  CSCI 473/504							Assignment 1								 Fall 2018                 *                                           
 *																										           *
 *  Programmer's: Sandeep Alla (z1821331) Gayathri Sanikommu (z1822939) Venkata SuryaVamsi Maddukuri (z1855404)    *  
 *																										           *
 *  Date Due  : September 13th, 2018			File :	Course.cs					     				           *                          
 *																										           *
 *  Purpose   : To write a program that allows user to Enroll into available Courses. This file contains           *
 *            	a class for Course.															                       *
 ******************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEnrollment
{
	public partial class Form1 : Form 
	{
		public String firstName = "", lastName ="" ,studentMajor ="", courseDept = "", sectionNumber = "", searchByZID = "", searchByDept = ""; //initializing the variables of type string
		public int ZID = 0, studentAcademicYear = 0, courseNumber = 0, capacity = 0; //initializing the variables to zero


		public Form1()
		{
			InitializeComponent();

			Program.studentPool.Sort(); //to sort studentpool
			Program.coursePool.Sort(); //to sort coursepool

			displayStudentData();//displays studentdata
			displayCourseData();//displays coursedata

			foreach (var majors in Program.availableMajors) //to iterate through lists
			{
				StudentMajorCB.Items.Add(majors);
			}

			foreach (var deptCode in Program.availableDeptCode)//to iterate through lists
			{
				DeptCodeCB.Items.Add(deptCode);
			}

			foreach (var academicYear in Enum.GetValues(typeof(AcademicYear)))//using enumerator to get the values to combo box
			{
				StudentAcadYearCB.Items.Add(academicYear);
			}

			
		}		

		private void displayStudentData()
		{
			studDisplay.Items.Clear();
			foreach (var sPool in Program.studentPool) //Loops through the studentPool list to display each an every student data
			{
				String studentDetails = "Z" + (Convert.ToString(sPool.ZID)) + " -- " + (sPool.FirstName) + "," + (sPool.LastName);
				studDisplay.Items.Add(studentDetails);
			}
		}

		private void displayCourseData()
		{
			courDisplay.Items.Clear();
			foreach (var cPool in Program.coursePool) //Loops through the coursePool list to display each an every Course details
			{
				String courseDetails = (Convert.ToString(cPool.DeptCode)) + " " + cPool.CourseNum + "-" + cPool.SectionNum + "  <" + cPool.NumOfStudentsCurrentlyEnrolled + "/" + cPool.MaxCapacityOfEnrollment + ">";
				courDisplay.Items.Add(courseDetails);
			}

		}

		private void printRoster_Click(object sender, EventArgs e)
		{
			outputDisplay.Clear(); //clear output display
			outputDisplay.Update();//update output display
			String selectedCourse = courDisplay.GetItemText(courDisplay.SelectedItem);
			String[] courseInput = selectedCourse.Split('<'); //split thr selected course
			List<String> courseRoster = new List<string>();
			if( selectedCourse == "")
			{
				outputDisplay.Text = "Please select a Course to display the Course Roster" + Environment.NewLine;
			}

			foreach (var cPool in Program.coursePool) //Loops through the coursePool list to display each an every Course details
			{
				String Course = Convert.ToString(cPool.DeptCode) + " " + Convert.ToString(cPool.CourseNum) + "-" + Convert.ToString(cPool.SectionNum);
				if ((Convert.ToString(Course).Replace(" ", String.Empty)).Equals((courseInput[0]).Replace(" ", String.Empty)))
				{
					courseRoster = cPool.PrintRoster(); // Calls the PrintRoster method from Course class					
					break;
				}
			}		

			foreach (var courseLines in courseRoster)
			{
				outputDisplay.Text += courseLines + Environment.NewLine;				
			}

			courDisplay.SelectedIndex = -1;
		}

		private void enrollStudent_Click(object sender, EventArgs e)
		{
			outputDisplay.Text = "";
			String selectedStudent = studDisplay.GetItemText(studDisplay.SelectedItem); 
			String[] studentInput = selectedStudent.Split(' ');//split selected student
			String selectedCourse = courDisplay.GetItemText(courDisplay.SelectedItem); 
			String[] courseInput = selectedCourse.Split('<'); //split selected course
			if ( selectedCourse == "" || selectedStudent == "")//if selected course and course
			{
				outputDisplay.Text = "Please select a Student and also the Course to which you want to Enroll him" + Environment.NewLine;
			}
			else
			{
				foreach (var sPool in Program.studentPool) // Loops through the studentPool
				{
					if (Convert.ToString("Z" + sPool.ZID).Equals(studentInput[0].Replace(" ", String.Empty))) // If the zID of the student exists in the file then
					{
						
						foreach (var cPool in Program.coursePool) // Loops through the coursePool
						{
							String Course = Convert.ToString(cPool.DeptCode) + " " + Convert.ToString(cPool.CourseNum) + "-" + Convert.ToString(cPool.SectionNum);
							if ((Convert.ToString(Course).Replace(" ", String.Empty)).Equals((courseInput[0]).Replace(" ", String.Empty))) // If the Course entered by the user exists in the course file then
							{
								int errorCode = sPool.Enroll(cPool); // Calling the Enroll Method from the Student class

								//Displaying messages based on the error code returned
								if (errorCode == 5)
									outputDisplay.Text = "Failed to Enroll the Student Z" + sPool.ZID + ", because the Capacity of the course " + Course + " has already reached Maximum";
								else if (errorCode == 10)
									outputDisplay.Text = "Failed to Enroll the Student Z" + sPool.ZID + ", because he is already enrolled into the course " + Course;
								else if (errorCode == 15)
									outputDisplay.Text = "Failed to Enroll the student Z" + sPool.ZID + ", because he is exceeding his maximium allowed credit hours";
								else if (errorCode == 0)
								{
									courDisplay.Items.Clear();									
									displayCourseData();//displays course data
									studDisplay.Items.Clear();									
									displayStudentData();//displays student data
									outputDisplay.Text = "The Student Z" + sPool.ZID + " has been successfully enrolled into the course " + Course + "\nTotal Credit Hours Erolled : " + sPool.CreditHoursEnrolled;
								}
								
								break;
							}

						}
					}
				}				
			}
			
		}

		private void dropStudent_Click(object sender, EventArgs e)
		{
			outputDisplay.Text = "";
			String selectedStudent = studDisplay.GetItemText(studDisplay.SelectedItem);
			String[] studentInput = selectedStudent.Split(' ');//split selected student
			String selectedCourse = courDisplay.GetItemText(courDisplay.SelectedItem);
			String[] courseInput = selectedCourse.Split('<');//split selected course
			if (selectedCourse == "" || selectedStudent == "")
			{
				outputDisplay.Text = "Please select a Student and also the Course from which you want drop him" + Environment.NewLine;
			}
			else
			{
				foreach (var sPool in Program.studentPool) // Loops through the studentPool
				{
					if (Convert.ToString("Z" + sPool.ZID).Equals(studentInput[0].Replace(" ", String.Empty))) // If the zID of the student exists in the file then
					{
						foreach (var cPool in Program.coursePool)//to iterate the coursepool
						{
							String Course = Convert.ToString(cPool.DeptCode) + " " + Convert.ToString(cPool.CourseNum) + "-" + Convert.ToString(cPool.SectionNum);
							if ((Convert.ToString(Course).Replace(" ", String.Empty)).Equals((courseInput[0]).Replace(" ", String.Empty))) // If the Course entered by the user exists in the course file then
							{
								int errorCode = sPool.Drop(cPool); // Calling the Drop method from the Student class
																   //Displaying messages based on the error code returned
								if (errorCode == 0)
								{
									courDisplay.Items.Clear();									
									displayCourseData();//dispays coursedata
									studDisplay.Items.Clear();									
									displayStudentData();//displays student data
									outputDisplay.Text = "The student Z" + sPool.ZID + "  has been successfully dropped from the course \nTotal Credit Hours Enrolled by Z" + sPool.ZID + " : " + sPool.CreditHoursEnrolled;
								}
								else if (errorCode == 20)
									outputDisplay.Text = "Failed to drop the student Z" + sPool.ZID + ", because he isn't currently enrolled into the course " + Course;

								
								break;
							}

						}
					}
				}
			}			

		}

		//Method that takes the input from searchByDept and searchByZID textboxes and 
		private void applySearchCriteria_Click(object sender, EventArgs e)
		{						
			outputDisplay.Text = "";
			int f = 0,c = 0;
			bool isZidFound = false, isDeptFound = false;			
			List<String> zidResult = new List<string>();
			List<String> courseResult = new List<string>();
			String s2 = searchByZID;
			String d2 = searchByDept;

			//If the searchByZid field is not empty then do
			if (s2 != null)
			{
				//Internal logic to perform search operations
				foreach (var sPool in Program.studentPool)
				{
					String s1 = Convert.ToString(sPool.ZID);

					char[] c1 = s1.ToCharArray();
					char[] c2 = s2.ToCharArray();

					//Checking character by character and if it equals then increment f
					for (int i = 1; i < c2.Length; i++)
					{
						if (c2[i] == c1[i])
						{
							f++;

						}
					}


					if (c2.Length != 1 && f == c2.Length - 1)
					{
						zidResult.Add("Z" + (Convert.ToString(sPool.ZID)) + " -- " + (sPool.FirstName) + "," + (sPool.LastName));
						isZidFound = true;
					}

					if (c2.Length == 1)
						c = 1;

					f = 0;
				}

				//If the Zid is found then display the found details
				if (isZidFound)
				{
					studDisplay.Items.Clear();
					foreach (var zid in zidResult)
					{
						studDisplay.Items.Add(zid);
					}
				}
			}
			else
			{
				//If it is empty then i will display all the students
				displayStudentData();
			}

			//if search by Dept field is not empty then do
 			if (d2 != null)
			{
				//Iterating through the coursePool list
				foreach (var cPool in Program.coursePool)
				{
					if ((cPool.DeptCode).ToLower().Equals(d2.ToLower()))
					{
						courseResult.Add((Convert.ToString(cPool.DeptCode)) + " " + cPool.CourseNum + "-" + cPool.SectionNum + "  <" + cPool.NumOfStudentsCurrentlyEnrolled + "/" + cPool.MaxCapacityOfEnrollment + ">");
						isDeptFound = true;
					}
				}

				//If the dept is found then i will display all the matching courses
				if (isDeptFound)
				{
					courDisplay.Items.Clear();
					foreach (var course in courseResult)
					{
						courDisplay.Items.Add(course);
					}
				}				
			}
			else
			{
				//If it is empty then i will display all the courses available
				displayCourseData();
			}


			if (c == 1)
				outputDisplay.Text = "";
			else if (isZidFound != true && isDeptFound != true)
			{
				outputDisplay.Text = "Nothing was a match for your filtering criteria, Please Enter something in the search text boxes";
			}


		}

		// When the text in the searchByZid field is changed we will take that text and put it in a variable
		private void searchStudentByZid_TextChanged(object sender, EventArgs e)
		{
			try
			{
				//Taking the input text in to a local variable
				String input = searchStudentByZid.Text;
				if (input[0] == 'Z' || input[0] == 'z')
				{
					searchByZID = input.Substring(1, input.Length - 1);
				}
			}
			catch(Exception)
			{
				searchByZID = null;
			}
		}

		// When the text in the searchByDept field is changed we will take that text and put it in a variable
		private void searchCourseByDept_TextChanged(object sender, EventArgs e)
		{
			try
			{
				searchByDept = searchCourseByDept.Text;
				if (searchByDept[0] != ' ' )
				{
					
				}
			}
			catch(Exception)
			{
				searchByDept = null;
			}
		}

		// When the text in the studentName field is changed we will take that text and put it in a variable
		private void studentNameTB_TextChanged(object sender, EventArgs e)
		{
			try
			{
				String[] result;
				String studentName = studentNameTB.Text;
				result = studentName.Split(',');
				if (result.Length != 2 || result.Length > 2)//if result of length is not 2 and result is greater than 2
				{
					outputDisplay.Text = "Enter the Name with First Name and Last Name seperated  by a comma";//display output
				}
				else
				{
					outputDisplay.Text = "";
					lastName = result[0]; //else display lastname 
					firstName = result[1];//firstname
				}
			}
			catch(Exception)
			{

			}

		}

		//when text in the student zid is changed we will place it in another variable
		private void studentZidTB_TextChanged(object sender, EventArgs e)
		{
			try
			{
				String input = "";
				if (studentZidTB.Text.Length > 8)//if zid text length is greater than 8
					outputDisplay.Text = "The Z-ID cannot be more than 8 characters";//display the output
				else if (studentZidTB.Text.Length == 8)//if zid length is equal to 8
				{
					outputDisplay.Text = "";
					input = studentZidTB.Text;
					if (input[0] == 'Z' || input[0] == 'z')//if input is capital or small z
					{
						try
						{
							ZID = Convert.ToInt32(input.Substring(1, input.Length - 1));//convert from string to integer
							outputDisplay.Text = "";
						}
						catch (Exception)
						{
							outputDisplay.Text = "You Entered an incorrect Z-ID";//display the output
						}
					}
					else
						outputDisplay.Text += "You Entered an incorrect Z-ID";
				}
				else if (studentZidTB.Text.Length == 7)//if zid text length is equal to 7
				{
					input = studentZidTB.Text;
					if (input[0] == 'Z' || input[0] == 'z')//if input is capital or small z
						outputDisplay.Text = "You Entered an incorrect Z-ID";//display this text
					else
					{
						try
						{
							ZID = Convert.ToInt32(input);
							outputDisplay.Text = "";
						}
						catch (Exception)
						{
							outputDisplay.Text = "You Entered an incorrect Z-ID";
						}
					}
				}
				else
				{
					outputDisplay.Text = "Enter a valid Z-ID";
				}
			}
			catch (Exception)
			{

			}
		}

		//Getting the selected value from the studentsmajor combo box
		private void StudentMajorCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				//Getting the current selected value from the combo box
				string selected = StudentMajorCB.SelectedItem.ToString();
				studentMajor = selected;
				outputDisplay.Text = "";
			}
			catch(Exception)
			{

			}
		}

		//Getting the selected value from the studentsacademicyear combo box
		private void StudentAcadYearCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				//Getting the current selected value from the combo box
				int selected = StudentAcadYearCB.SelectedIndex;
				studentAcademicYear = selected;
				outputDisplay.Text = "";
			}
			catch(Exception)
			{

			}
		}

		//Getting the selected value from the Department code combo box
		private void DeptCodeCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				String selected = DeptCodeCB.SelectedItem.ToString();
				courseDept = selected;
				outputDisplay.Text = "";
			}
			catch(Exception)
			{

			}
		}

		//Getting the selected item from the student display
		private void studDisplay_SelectedIndexChanged(object sender, EventArgs e)
		{
			String text = studDisplay.GetItemText(studDisplay.SelectedItem);

			outputDisplay.Text = "";
			String input, Z = "";
			String selection = text;
			String[] selectionZID = selection.Split(' ');
			input = selectionZID[0];
			if (input.Length > 0)
			{
				Z = input.Substring(1, input.Length - 1);
			}

			//Printing the selected student details along with the courses he is enrolled into
			foreach (var sPool in Program.studentPool)
			{
				if (Convert.ToString(sPool.ZID).Equals(Z))
				{
					outputDisplay.Text += "Z" + (Convert.ToString(sPool.ZID)) + " --" + (sPool.FirstName).PadLeft(10) + "," + (sPool.LastName).PadRight(10) + "[" + Convert.ToString((sPool.CurrentAcademicYear)).PadLeft(10) + "] " + " <" + (sPool.Major) + "> " + " | " + Convert.ToString((sPool.GPA).ToString(".000")).PadRight(5) + " |" + Environment.NewLine;
					outputDisplay.Text += "-------------------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

					foreach (var cPool in Program.coursePool)
					{
						foreach (var ZID in cPool.zID)
						{
							if (Convert.ToString(ZID).Equals(Z))
							{
								outputDisplay.Text += cPool.DeptCode + " " + cPool.CourseNum + "-" + cPool.SectionNum + "(" + cPool.NumOfStudentsCurrentlyEnrolled + "/" + cPool.MaxCapacityOfEnrollment + ")" + Environment.NewLine;
							}
						}
					}
				}
			}
		}

		private void courDisplay_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		//Getting the number from the course number text box when the user inputs text
		private void courseNumTB_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int input = 0;
				//Checking that the course number always contain only 3 digits
				Regex regex = new Regex(@"^\d{3}$");
				bool isNumerical = int.TryParse(courseNumTB.Text, out input);
				bool isDigits = regex.IsMatch(Convert.ToString(input));
				//If the input field is not empty
				if (courseNumTB.Text != "")
				{
					if (isNumerical == true && isDigits)
					{
						courseNumber = input;
						outputDisplay.Text = "";
					}
					else
					{
						//Displaying error messages
						if (isDigits != true)
							outputDisplay.Text = "Course Number must be of 3 Digits";
						if (isNumerical != true)
							outputDisplay.Text = "Please enter only numbers, Course Number cannot have alphabetical characters";
					}
				}
				else
					outputDisplay.Text = "";
			}
			catch(Exception)
			{

			}

		}

		//Getting the number from the section number text box when the user inputs text
		private void sectionNumTB_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (sectionNumTB.Text.Length == 4)
				{
					//Changing all the characters to upper case
					sectionNumber = (sectionNumTB.Text).ToUpper();
					outputDisplay.Text = "";
				}
				else
				{
					outputDisplay.Text = "The Section Number length must be exactly 4";
				}
			}
			catch(Exception)
			{

			}
		}		

		//Functionality of the add student button
		private void addStudent_Click(object sender, EventArgs e)
		{
			bool addStudent = true;

			//Checking the ZID is not equal to Zero
			if( ZID != 0)
			{
				foreach ( var sPool in Program.studentPool)
				{
					//If the user entered ZID already exists then showing an error message
					if (Convert.ToString(ZID).Equals(Convert.ToString(sPool.ZID)))
					{
						outputDisplay.Text = "A student with that ZID already exists, Please try again with a different Z-ID";
						addStudent = false;
					}
				}
			}

			//Checking is the addstudent is not false
			if (addStudent != false)
			{
				//Checking conditions for firtname, lastname,ZID, StudentMajor, studentacademicyear not equal to null
				if (firstName == "" || lastName == "")
					outputDisplay.Text = "Please enter the student name";
				else if (ZID == 0)
					outputDisplay.Text = "Please enter a Z-ID";
				else if (StudentMajorCB.SelectedIndex == -1)
					outputDisplay.Text = "Please Select a Major";
				else if (StudentAcadYearCB.SelectedIndex == -1)
					outputDisplay.Text = "Please Select an Academic Year";
				else
				{
					//Formatting all the data and adding to the file
					String studentDetails = ZID + "," + lastName + "," + firstName + "," + studentMajor + "," + studentAcademicYear + "," + 0.0;
					File.AppendAllText(Directory.GetCurrentDirectory() + "\\2188_a2_input01.txt", studentDetails + Environment.NewLine);
					//Refreshing the student display and course display
					studDisplay.Items.Clear();					
					Program.read();
					Program.studentPool.Sort();
					displayStudentData();
					studentNameTB.Clear();
					studentNameTB.Update();
					studentZidTB.Clear();
					studentZidTB.Clear();
					StudentMajorCB.SelectedIndex = -1;
					StudentAcadYearCB.SelectedIndex = -1;
					outputDisplay.Text = "Student has been successfully added";
				}
			}
		}

		//Functionality of the add course button
		private void addCourse_Click(object sender, EventArgs e)
		{
			//Checking if DeptCode, course number, section number, capacity not equal to null
			if ( DeptCodeCB.SelectedIndex == -1)
				outputDisplay.Text = "Please Select a Deptarment";
			else if (courseNumber == 0)
				outputDisplay.Text = "Please enter the Course Number";
			else if (sectionNumber == "")
				outputDisplay.Text = "Please enter the Section Number";
			else if (capacity == 0)
				outputDisplay.Text = "Please specify the capacity, it cannot be Zero";
			else
			{
				//Formatting all the course data and adding it to the file
				String courseDetails = courseDept + "," + courseNumber + "," + sectionNumber + "," + "3" + "," + capacity;
				File.AppendAllText(Directory.GetCurrentDirectory() + "\\2188_a2_input02.txt", courseDetails + Environment.NewLine);
				//Refreshing the course display and displaying it with new file
				courDisplay.Items.Clear();
				Program.read();
				Program.coursePool.Sort();
				displayCourseData();
				DeptCodeCB.SelectedIndex = -1;
				courseNumTB.Clear();
				courseNumTB.Update();
				sectionNumTB.Clear();
				sectionNumTB.Update();
				courseCapacity.Value = 0;
				outputDisplay.Text = "Course has been successfully added";
			}
		}

		private void outputDisplay_TextChanged(object sender, EventArgs e)
		{

		}

		//Getting the capacity of the course entered byt the user
		private void courseCapacity_ValueChanged(object sender, EventArgs e)
		{
			if(courseCapacity.Value != 0)
			{
				capacity = Convert.ToInt32(courseCapacity.Value);
				outputDisplay.Text = "";
			}			
		}

		/*private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
		{
			File.WriteAllText(Directory.GetCurrentDirectory() + "\\studentDetails.txt", string.Empty);
			File.WriteAllText(Directory.GetCurrentDirectory() + "\\courseDetails.txt", string.Empty);
		}*/

		private void Form1_Load(object sender, EventArgs e)
		{
			//this.FormClosed += new FormClosedEventHandler(Form1_FormClosed_1);
		}
	}
}
