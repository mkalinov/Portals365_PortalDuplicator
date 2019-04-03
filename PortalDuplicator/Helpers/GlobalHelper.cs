using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace DMM365.Helper
{
    public static class GlobalHelper
    {

        public static bool isValidString(string source)
        {
            return !string.IsNullOrEmpty(source) && !string.IsNullOrWhiteSpace(source);
        }

        public static void copyObjectProperies<T>(T source, T target)
        {
            var sourceProperties = source.GetType().GetProperties();
            var targetProperties = target.GetType().GetProperties();

            foreach (var sourceProperty in sourceProperties)
            {
                foreach (var targetProperty in targetProperties)
                {
                    if (sourceProperty.Name == targetProperty.Name && sourceProperty.PropertyType == targetProperty.PropertyType)
                    {
                        targetProperty.SetValue(target, sourceProperty.GetValue(source));
                        break;
                    }
                }
            }
        }

        public static List<T> copyCollection<T>(List<T> source)
        {
            return new List<T>(source);
        }


        public static void setItemChecked(CheckedListBox cbxList, Array selected, bool isSelected)
        {
            foreach (var item in selected)
            {
                int index = cbxList.Items.IndexOf(item);
                if (index != -1) cbxList.SetItemChecked(index, isSelected);
            }
        }

        public static void clearCkeckedListBox(CheckedListBox cbxList)
        {
            foreach (int i in cbxList.CheckedIndices)
                cbxList.SetItemCheckState(i, CheckState.Unchecked);
        }

    }
}
