﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MISA.AssetManage.ApplicationCore.Interfaces
{
    public interface IBaseRepository<MISAEntity>
    {
        /// <summary>
        /// Lấy tất cả dữ liệu
        /// </summary>
        /// <typeparam name="MISAEntity">Type</typeparam>
        /// <returns></returns>
        IEnumerable<MISAEntity> GetAll();
        /// <summary>
        /// Lấy dữ liệu theo ID
        /// </summary>
        /// <typeparam name="MISAEntity">type</typeparam>
        /// <param name="entityID">ID</param>
        /// <returns></returns>
        IEnumerable<MISAEntity> GetAllById(Guid entityID);
        /// <summary>
        /// Thêm dữ liệu
        /// </summary>
        /// <typeparam name="MISAEntity">type</typeparam>
        /// <param name="entity">object</param>
        /// <returns></returns>
        int Insert(MISAEntity entity);
        /// <summary>
        /// Sửa dữ liệu theo ID
        /// </summary>
        /// <param name="entity">Cần sửa những gì thì gửi lên đối tượng dạng JSON</param>
        /// <returns></returns>
        public int UpdateByID(MISAEntity entity);

        /// <summary>
        /// Xoá object trong database
        /// </summary>
        /// <returns>Số object xoá thành công</returns>
        public int DeleteObject(string[] ids);

        /// <summary>
        /// Tìm kiểm dữ liệu theo tên ,mã phòng ban,loại
        /// </summary>
        /// <param name="contentFilter">nội dung tìm kiếm</param>
        /// <returns></returns>
        public IEnumerable<MISAEntity> Fillter(string contentFilter);



        MISAEntity GetEntityByProperty(MISAEntity entity, PropertyInfo propertyInfo);

    }
}
