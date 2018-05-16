using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_QLTS
{
    public static class Extentions
    {
        public static bool Validate(this DataGridViewCell cell, Func<object, KeyValuePair<bool, string>> funcValidate)
        {
            var v = funcValidate(cell.FormattedValue);
            cell.ErrorText = v.Key ? "" : v.Value;
            return v.Key;
        }

        public static string GetPropertyName<T, Y>(this Expression<Func<T, Y>> expression)
        {
            if (expression.Body is MemberExpression member)
                return member.Member.Name;
            return ((expression.Body as UnaryExpression).Operand as MemberExpression).Member.Name;
        }

        public static ComboBox Create<T>(this ComboBox cmb,
            IList<T> DataSource,
            Expression<Func<T, object>> ValueMember,
            Expression<Func<T, object>> DisplayMember,
            object SelectedValue = null)
        {
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.DataSource = DataSource;
            cmb.DisplayMember = DisplayMember.GetPropertyName();
            cmb.ValueMember = ValueMember.GetPropertyName();
            if (SelectedValue != null) cmb.SelectedValue = SelectedValue;
            return cmb;
        }

        public static Binding Binding<TControl, T, YType>(this TControl control,
            Expression<Func<TControl, YType>> propertyName,
            T dataSource,
            Expression<Func<T, YType>> dataMember)
        {
            Binding binding = new Binding(propertyName.GetPropertyName(), dataSource, dataMember.GetPropertyName(), true);
            (control as Control).DataBindings.Add(binding);
            return binding;
        }

        public static void CopyValue<T>(this T target, T source)
        {
            foreach (var prop in target.GetType().GetProperties())
            {
                prop.SetValue(target, prop.GetValue(source));
            }
        }

        public static bool Validate<TControl>(this ErrorProvider errorProvider, TControl control, Func<TControl, KeyValuePair<bool, string>> funcValidate)
        {
            var r = funcValidate(control);
            if (r.Key == false)
                errorProvider.SetError(control as Control, r.Value);
            return r.Key;
        }
    }
}
