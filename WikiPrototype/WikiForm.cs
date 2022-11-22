namespace WikiPrototype
{
    using System.Text.RegularExpressions;

    public partial class WikiForm : Form
    {
        //create two dimensional array, index, and filename global variables
        List<Information> wiki = new List<Information>(12);

        //static String[,] dataInfo = new String[12,4];
        static int index;
        String fileName;

        public WikiForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) //on load set index to 0 and call comboboxpopulate()
        {
            index = 0;
            comboBoxPopulate();
        }
        private void comboBoxPopulate() //populate combobox with the string feilds in catagories.txt
        {
            String directory = Directory.GetCurrentDirectory();
            CataCCombo.Items.AddRange(File.ReadAllLines(directory + "\\Catagories.txt"));
        }

        

        private void add() //reads the input feilds and adds them to the wiki list. will also call spechar() and linnolin() in constructor.
        {
            if (nameBox.Text.Length != 0 & String.IsNullOrEmpty(CataCCombo.Text))
            {

                if (ValidName(nameBox.Text) == true)
                {

                    wiki.Add(new Information(spechar(nameBox.Text), CataCCombo.Text, linnolin(), spechar(defBox.Text)));

                    index++;
                    clearText();
                    display();
                    statStripLabel.Text = "item added";
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

        }

        public bool ValidName(String name) //valid name checks to see if the name exiists inside the list and returns a boolean based on the result
        {

            return wiki.Exists(x =>x.name == name);
            
        }

        public String spechar(String unfiltered) //method replaces the string if there are any special characters with "" effectively filtering them.
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
            CataCCombo.Items.Clear();
            LinBtn.Checked = false;
            NLinBtn.Checked = false;
            defBox.Clear();
        }

        //sorts all of the items, then displays them in the list view box.
        private void display() // uses new compareto from information with wiki.sort to sort list then display the data
        {
            wiki.Sort();
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
                if (!String.IsNullOrEmpty(CataCCombo.Text))
                {
                    wiki[temp].name = CataCCombo.Text;
                }
                if (LinBtn.Checked == true)
                {
                    wiki[temp].name = "Linear";
                }
                else
                {
                    wiki[temp].name = "Non Linear";
                }
                if (!String.IsNullOrEmpty(defBox.Text))
                {
                    wiki[temp].name = defBox.Text;
                }
            }
            display();
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

        private int binSearch2(String target)  //new binary search method uses inbuilt binary search method and returns the index of the search.
        {
            if (wiki.BinarySearch(new Information(target)) > 0)
            {
                int index = wiki.BinarySearch(new Information(target));
                return index;
            } else
            {
                return -1;
            }

        }

       

        private void Open() //open creats a file open dialog. if successful then it will open the selected file and read the contents into the object list. it will also update the index
        {
            wiki.Clear();
            index = 0;
            int xindex = 0;
            String wikiname = "";
            String wikicata = "";
            String wikistru = "";
            String wikidefi = "";

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
                            wikiname = binFileRead.ReadString();
                            wikicata = binFileRead.ReadString();
                            wikistru = binFileRead.ReadString();
                            wikidefi = binFileRead.ReadString();
                            wiki.Add(new Information(wikiname, wikicata, wikistru, wikidefi));
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

        private void select() //gets the data at the selected index and then reads the data into the text boxes. calls highlin method
        {
            int nselect = viewBox.SelectedIndices[0];
            nameBox.Text = wiki[nselect].name;
            CataCCombo.SelectedItem = wiki[nselect].category;
            if (wiki[nselect].structure == "Linear")
            {
                highlin(0);
            }
            else if (wiki[nselect].structure == "Non Linear")
            {
                highlin(1);
            } else
            {
                highlin(2);
            }
            defBox.Text = wiki[nselect].definition;
        }

        private String linnolin() //returns text of radio button
        {
            String lin = "Linear";
            foreach (RadioButton r in groupBox.Controls)
            {
                if (r.Checked)
                {
                    lin =  r.Text;
                } 
            }
            return lin;
        }

        private void highlin(int index) //recieves index then selects according radio button checked
        {
            if (index == 0)
            {
                LinBtn.Checked = true;
                NLinBtn.Checked = false;
            } else if (index == 1)
            {
                LinBtn.Checked = false;
                NLinBtn.Checked = true;
            } else
            {
                LinBtn.Checked = false;
                NLinBtn.Checked = false;
            }
        }

        private void seaBtn_Click(object sender, EventArgs e) //searches with inbuilt binary search method then selects
        {
            int result = binSearch2(seaBox.Text);
            if (result != -1)
            {
                viewBox.Items[result].Selected = true;
                select();
            }

        }
        private void clear() //clears the text boxes and radio buttons.
        {
            nameBox.Text = "";
            CataCCombo.Text = "";
            LinBtn.Checked = false;
            NLinBtn.Checked = false;
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
            //okay dookay
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NLinBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WikiForm_FormClosing(object sender, FormClosingEventArgs e) //calls save method on close.
        {
            save();
        }
    }
}