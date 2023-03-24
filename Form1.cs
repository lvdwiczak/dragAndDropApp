using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jlDragAndDropApp
{
    public partial class dragDropApp : Form
    {
        public dragDropApp()
        {
            InitializeComponent();
        }
        object dragDropSource = null;

        private void DragDrop_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox dragDropSender = sender as ListBox;
            dragDropSource = dragDropSender;
            if (e.Button == MouseButtons.Left && (dragDropSender.SelectedIndices.Count > 0))
            {
                DragDropEffects dragDropAction = dragDropSender.DoDragDrop(dragDropSender.SelectedItems, DragDropEffects.Copy | DragDropEffects.Move);
                if (dragDropAction == DragDropEffects.Move)
                    for (int index = dragDropSender.SelectedItems.Count - 1; index >= 0; index--)
                        dragDropSender.Items.Remove(dragDropSender.SelectedItems[index]);
            }
            dragDropSource = null;
        }

        private void DragDrop_DragOver(object sender, DragEventArgs e)
        {
            if (sender == dragDropSource)
            {
                e.Effect = DragDropEffects.None;
            }
            else
               if ((e.KeyState & 8) == 8)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;
        }

        private void DragDrop_DragDrop(object sender, DragEventArgs e)
        {
            ListBox dragDropSender = sender as ListBox;
            ListBox dragDropSrc = dragDropSource as ListBox;
            int indexOfPoint = dragDropSender.IndexFromPoint(dragDropSender.PointToClient(new Point(e.X, e.Y)));
            if (indexOfPoint == -1) { indexOfPoint = dragDropSender.Items.Count; }
            //  listBox.Items.Insert(j,e.Data.GetData(DataFormats.Text).ToString());
            for (int index = dragDropSrc.SelectedItems.Count - 1; index >= 0; index--)
                dragDropSender.Items.Insert(indexOfPoint,
               dragDropSrc.Items[dragDropSrc.SelectedIndices[index]]);
        }
    }
}
