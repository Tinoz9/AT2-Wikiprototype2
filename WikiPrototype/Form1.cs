namespace WikiPrototype
{
    using System.Text.RegularExpressions;

    public partial class Form1 : Form
    {
        //create two dimensional array, index, and filename global variables
        List<Information> wiki = new List<Information>();

        //static String[,] dataInfo = new String[12,4];
        static int index;
        String fileName;

        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            index = 0;
        }

        //reads text boxes and adds them to the array then clears the textboxes and calls the display method.

        private void add()
        {
            
            if (nameBox.Text.Length != 0 & cataBox.Text.Length != 0 & strucBox.Text.Length != 0)
            {
                if (binSearch(nameBox.Text) == -1)
                {
                    Information info1 = new Information(spechar(nameBox.Text), spechar(cataBox.Text), spechar(strucBox.Text), spechar(defBox.Text));

                    index++;
                    clearText();
                    display();
                }
                else
                {
                    statStrip.Text = "data already exists";
                }
            }
            else
            {
                statStripLabel.Text = "data is empty";
            }
            statStripLabel.Text = "item added";
        }

        public String spechar(String unfiltered)
        {
            String filtered = Regex.Replace(unfiltered, @"[^0-9a-zA-Z]+", ""); ;
            return filtered;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            add();
        }

        //clears all of the text boxes
        private void clearText()
        {
            nameBox.Clear();
            cataBox.Clear();
            strucBox.Clear();
            defBox.Clear();
        }

        //sorts all of the items, then displays them in the list view box.
        private void display()
        {
            sort();
            viewBox.Items.Clear();
            int x = wiki.Count;
            try
            {
                for (int i = 0; i < x; i++)
                {
                    if (!string.IsNullOrEmpty(wiki[i].name))
                    {
                        ListViewItem listview = new ListViewItem(wiki[i].name);
                        listview.SubItems.Add(wiki[i].category);
                        viewBox.Items.Add(listview);

                    } else
                    {
                        break;
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void edit() //edits an existing records from the array from the input in the textboxes then calls the display method.
        {
             
            if (viewBox.SelectedIndices.Count != 0)
            {
                int temp = viewBox.SelectedIndices[0];
                if (!String.IsNullOrEmpty(nameBox.Text))
                {
                    wiki[temp].name = nameBox.Text;
                    
                };
                if (!String.IsNullOrEmpty(cataBox.Text))
                {
                    wiki[temp].name = cataBox.Text;
                }
                if (!String.IsNullOrEmpty(strucBox.Text))
                {
                    wiki[temp].name = strucBox.Text;
                }
                if (!String.IsNullOrEmpty(defBox.Text))
                {
                    wiki[temp].name = defBox.Text;
                }
            }
            display();
        }

        private void sort() //sorts the two dimensional array by comparing then names in alphabetical order. when it determines the alphabetical order it will call the swap method to swap the records.
        {
            bool sorted;
            do
            {
                sorted = true;
                for (int i = 0; i < wiki.Count - 1; i++)
                {
                    int j = i + 1;
                    if (!string.IsNullOrEmpty(wiki[j].name))
                    {
                        if (wiki[i].name.CompareTo(wiki[j].name) > 0)
                        {
                            swap(i, j);
                            sorted = false;
                        }
                    } else
                    { 
                        break;
                    }
                }
            } while (sorted == false);
        } 


        private void swap(int i, int j) //receives the two variables too swap then swapps the positions of x and y.
        {
            string temp;
            temp = wiki[i].name;
            wiki[i].name = wiki[j].name;
            wiki[j].name = temp;
            temp = wiki[i].category;
            wiki[i].category = wiki[j].category;
            wiki[j].category = temp;
            temp = wiki[i].structure;
            wiki[i].structure = wiki[j].structure;
            wiki[j].structure = temp;
            temp = wiki[i].definition;
            wiki[i].definition = wiki[j].definition;
            wiki[j].definition = temp;

        }

        //(String.Compare(i, j, StringComparison.OrdinalIgnoreCase) < 0)

        private int binSearch(String Target) //sorts the array then performs a binary search. if the item is found it will call the select method 
        {
            int bin = -1;
            sort();

            int high = index - 1;
            int low = 0;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (String.Compare(wiki[mid].name, Target, StringComparison.OrdinalIgnoreCase) == 0)
                {

                    bin = mid;
                    return bin;
                }
                else if (String.Compare(wiki[mid].name, Target, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

            }
            return bin;

        }

        private void Open() //open creats a file open dialog. if successful then it will open the selected file and read the contents into the array. it will also update the index
        {
            int xindex = 0;
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Data File|*.dat;"
            };
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                fileName = ofd.FileName;
                var fileStream = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite);
                BinaryReader binFileRead = new BinaryReader(fileStream);
                try
                {
                    for (int i = 0; i < fileStream.Length; i++)
                    {
                        if (i % 4 == 0 && i != 0)
                        {
                            xindex++;
                        }
                        if (fileStream.CanRead)
                        {
                            wiki[xindex].name = binFileRead.ReadString();
                            wiki[xindex].category = binFileRead.ReadString();
                            wiki[xindex].structure = binFileRead.ReadString();
                            wiki[xindex].definition = binFileRead.ReadString();
                        }

                    }
                    index = xindex;
                    fileStream.Close();
                    binFileRead.Close();
                    
                } catch (System.IO.EndOfStreamException e)
                {
                    MessageBox.Show("successfully opened");
                } finally
                {
                    index = xindex;
                    fileStream.Close();
                    binFileRead.Close();
                }

            } else if (dr == DialogResult.Cancel)
            {
                statBox.Text = "open cancelled";
            }
            display();
        }

        private void save() //creates savefile dialog and then call the write method.
        {
            //fileName = "definitiions.dat";
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                write(sfd.FileName + ".dat");
            } else
            {
                write("Definitions.dat");
            }

        }

        private void write(String f) //receives the file name then it will create or update the file by writing the new data on top of it.
        {


            var fileStream = File.Open(f, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter binFileWrite = new BinaryWriter(fileStream);
            {
                try
                {
                    for (int i = 0; i < wiki.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(wiki[i].name))
                        {
                            binFileWrite.Write(wiki[i].name);
                            binFileWrite.Write(wiki[i].category);
                            binFileWrite.Write(wiki[i].structure);
                            binFileWrite.Write(wiki[i].definition);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                } finally
                {
                    fileStream.Close();
                    binFileWrite.Close();
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            save();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void ediBtn_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void viewBox_SelectedIndexChanged(object sender, EventArgs e) //when an item from the listview box is selected it will call the select method.
        {
            if (viewBox.SelectedIndices.Count != 0)
            {
                select();

            }
        }

        private void select() //gets the data at the selected index and then reads the data into the text boxes.
        {
            int nselect = viewBox.SelectedIndices[0];
            nameBox.Text = wiki[nselect].name;
            cataBox.Text = wiki[nselect].category;
            strucBox.Text = wiki[nselect].structure;
            defBox.Text = wiki[nselect].definition;
        }

        private void seaBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < wiki.Count; i++)
            {
                //statStripLabel.Text = wiki.BinarySearch(wiki[i].name, seaBox.Text);
            }
            
            int result = binSearch(seaBox.Text);
            if (result != -1)
            {
                viewBox.Items[result].Selected = true;
                select();
            }

        }
        private void clear() //clears the text boxes.
        {
            nameBox.Text = "";
            cataBox.Text = "";
            strucBox.Text = "";
            defBox.Text = "";
        }
        private void nameDClick(object sender, EventArgs e)
        {
            clear();
        }

        private void delete() //swap record to end then set to null. finally it displays.
        {

            if (viewBox.SelectedItems.Count > 0)
            {
                int index = viewBox.SelectedIndices[0];
                for (int i = viewBox.SelectedIndices[0]; i < wiki.Count - 1; i++)
                {
                    int j = i + 1;
                    if (!string.IsNullOrEmpty(wiki[j].name) || !string.IsNullOrEmpty(wiki[i].name))
                    {
                        swap(i, j);
                        index++;
                    }
                }

                wiki[index].name = null;
                wiki[index].category = null;
                wiki[index].structure = null;
                wiki[index].definition = null;

                display();
            } else
            {
                statStrip.Text = "please select and item";
            }

        }



        private void delBtn_Click(object sender, EventArgs e) //dialog prompt for delete then calls delete method.
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                delete();
            }
            
        }

        private void test()
        {
            //okay asdasdasd
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //okay dookaye
        }
    }
}