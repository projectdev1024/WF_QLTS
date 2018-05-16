using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_QLTS.Usercontrols.Core
{
    public interface IManager
    {
        /// <summary>
        /// Thêm hoặc sửa đối tượng
        /// </summary>
        /// <param name="dataBoundItem">Object giá trị</param>
        /// <returns></returns>
        bool Save(object dataBoundItem);

        /// <summary>
        /// Tiêu đề của danh sách
        /// </summary>
        /// <returns></returns>
        string Title();

        /// <summary>
        /// Khởi tạo các columns của gridview.
        /// Column[0] (đầu tiên là column Xóa).
        /// </summary>
        /// <returns></returns>
        DataGridViewColumn[] createColumns();

        /// <summary>
        /// Sử dụng BindingList<> để lấy data
        /// </summary>
        /// <returns></returns>
        object GetDataSource();

        /// <summary>
        /// Check Validate đối tượng
        /// </summary>
        /// <param name="dataBoundItem">giá trị Đối tượng</param>
        /// <param name="cells">Danh sách các cell</param>
        /// <returns></returns>
        bool Validate(object dataBoundItem, DataGridViewCellCollection cells);

        /// <summary>
        /// Xóa đối tượng
        /// </summary>
        /// <param name="dataBoundItem">giá trị Đối tượng</param>
        /// <returns></returns>
        bool Delete(object dataBoundItem);

        /// <summary>
        /// Tìm kiếm
        /// </summary>
        /// <param name="sKey"></param>
        /// <returns>BindingList<T></returns>
        object Search(string sKey);
    }
}
