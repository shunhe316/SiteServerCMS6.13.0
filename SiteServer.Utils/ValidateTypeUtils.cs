using System;
using System.Web.UI.WebControls;
using SiteServer.Plugin;

namespace SiteServer.Utils
{
	public static class ValidateTypeUtils
	{
        public static string GetText(ValidateType type)
        {
            if (type == ValidateType.None)
            {
                return "无";
            }
            if (type == ValidateType.Chinese)
            {
                return "中文";
            }
            if (type == ValidateType.English)
            {
                return "英文";
            }
            if (type == ValidateType.Email)
            {
                return "Email格式";
            }
            if (type == ValidateType.Url)
            {
                return "网址格式";
            }
            if (type == ValidateType.Phone)
            {
                return "电话号码";
            }
            if (type == ValidateType.Mobile)
            {
                return "手机号码";
            }
            if (type == ValidateType.Integer)
            {
                return "整数";
            }
            if (type == ValidateType.Currency)
            {
                return "货币格式";
            }
            if (type == ValidateType.Zip)
            {
                return "邮政编码";
            }
            if (type == ValidateType.IdCard)
            {
                return "身份证号码";
            }
            if (type == ValidateType.RegExp)
            {
                return "正则表达式验证";
            }
            throw new Exception();
        }

		public static ValidateType GetEnumType(string typeStr)
		{
			var retVal = ValidateType.None;

			if (Equals(ValidateType.None, typeStr))
			{
                retVal = ValidateType.None;
            }
            else if (Equals(ValidateType.Chinese, typeStr))
            {
                retVal = ValidateType.Chinese;
            }
            else if (Equals(ValidateType.Currency, typeStr))
            {
                retVal = ValidateType.Currency;
            }
			else if (Equals(ValidateType.RegExp, typeStr))
			{
                retVal = ValidateType.RegExp;
            }
            else if (Equals(ValidateType.Email, typeStr))
            {
                retVal = ValidateType.Email;
            }
            else if (Equals(ValidateType.English, typeStr))
            {
                retVal = ValidateType.English;
            }
            else if (Equals(ValidateType.IdCard, typeStr))
            {
                retVal = ValidateType.IdCard;
            }
            else if (Equals(ValidateType.Integer, typeStr))
            {
                retVal = ValidateType.Integer;
            }
            else if (Equals(ValidateType.Mobile, typeStr))
            {
                retVal = ValidateType.Mobile;
            }
            else if (Equals(ValidateType.Phone, typeStr))
            {
                retVal = ValidateType.Phone;
            }
            else if (Equals(ValidateType.Url, typeStr))
            {
                retVal = ValidateType.Url;
            }
            else if (Equals(ValidateType.Zip, typeStr))
            {
                retVal = ValidateType.Zip;
            }

			return retVal;
		}

		public static bool Equals(ValidateType type, string typeStr)
		{
			if (string.IsNullOrEmpty(typeStr)) return false;
			if (string.Equals(type.Value.ToLower(), typeStr.ToLower()))
			{
				return true;
			}
			return false;
		}

        public static bool Equals(string typeStr, ValidateType type)
        {
            return Equals(type, typeStr);
        }

		public static ListItem GetListItem(ValidateType type, bool selected)
		{
			var item = new ListItem(GetText(type), type.Value);
			if (selected)
			{
				item.Selected = true;
			}
			return item;
		}

        public static void AddListItems(ListControl listControl)
        {
            if (listControl != null)
            {
                listControl.Items.Add(GetListItem(ValidateType.None, false));
                listControl.Items.Add(GetListItem(ValidateType.Chinese, false));
                listControl.Items.Add(GetListItem(ValidateType.English, false));
                listControl.Items.Add(GetListItem(ValidateType.Email, false));
                listControl.Items.Add(GetListItem(ValidateType.Url, false));
                listControl.Items.Add(GetListItem(ValidateType.Phone, false));
                listControl.Items.Add(GetListItem(ValidateType.Mobile, false));
                listControl.Items.Add(GetListItem(ValidateType.Integer, false));
                listControl.Items.Add(GetListItem(ValidateType.Currency, false));
                listControl.Items.Add(GetListItem(ValidateType.Zip, false));
                listControl.Items.Add(GetListItem(ValidateType.IdCard, false));
                listControl.Items.Add(GetListItem(ValidateType.RegExp, false));
            }
        }
	}
}
