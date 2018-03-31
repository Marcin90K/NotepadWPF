using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace NotepadWPF
{
    class Editor  : INotifyPropertyChanged
    {
         private int _LineNumber;
         private int _ColumnNumber;

        /* public int LineNumber
         {
             get { return _LineNumber;  }
             set
             {
                 _LineNumber = value;
                 OnPropertyChanged("LineNumber");
             }
         }

         public int ColumnNumber
         {
             get { return _ColumnNumber; }
             set
             {
                 _ColumnNumber = value;
                 OnPropertyChanged("ColumnNumber");
             }
         }

         public void OnPropertyChanged(string parameter)
         {
             if (PropertyChanged != null)
             {
                 PropertyChanged(this, new PropertyChangedEventArgs(parameter));
             }
         }

         public event PropertyChangedEventHandler PropertyChanged;  */

         public Editor(object control)
         {
               richTbxObject = control; 
               tp1 = (richTbxObject as System.Windows.Controls.RichTextBox).Selection.Start.GetLineStartPosition(0);
               tp2 = (richTbxObject as System.Windows.Controls.RichTextBox).Selection.Start;
               _ColumnNumber = tp1.GetOffsetToPosition(tp2);
               (richTbxObject as System.Windows.Controls.RichTextBox).Selection.Start.GetLineStartPosition(a, out lineMoved);
               _LineNumber = -lineMoved;


         }
         
        public static TextPointer tp1, tp2;
        private static object richTbxObject;
        //public System.Windows.Controls.RichTextBox richTextBox = richTbxObject as System.Windows.Controls.RichTextBox;
          /* public void CreateTextPointers(object control)
           {
               TextPointer tp1 = (control as System.Windows.Controls.RichTextBox).Selection.Start.GetLineStartPosition(0);
               TextPointer tp2 =  (control as System.Windows.Controls.RichTextBox).Selection.Start;
           }*/
           //TextPointer tp1 =  
        int column;  // = tp1.GetOffsetToPosition(tp2);

        int a;  // = 100000;
        int lineMoved, currentLineNumber;
        //richTextBox                 // = richTbxObject as System.Windows.Controls.RichTextBox


           public int LineNumber
           {
               get { return _LineNumber; }
               set
               {
                   _LineNumber = value;
                   OnPropertyChanged("LineNumber");
               }
           }

           public int ColumnNumber
           {
               get { return _ColumnNumber; }
               set
               {
                   _ColumnNumber = value;
                   OnPropertyChanged("ColumnNumber");
               }
           }

           public void OnPropertyChanged(string parameter)
           {
               if (PropertyChanged != null)
               {
                   PropertyChanged(this, new PropertyChangedEventArgs(parameter));
               }
           }

           public event PropertyChangedEventHandler PropertyChanged;

           

       }

       
    }

