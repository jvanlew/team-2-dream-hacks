using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LevelUpGame.Library.Infrastructure
{
	public static class Extensions
	{
		public static T Clone<T>(this T obj) where T : class, new() {
			T newObj = new T();
			var props = obj.GetType().GetProperties();
			foreach (var prop in props) {
				prop.SetValue(newObj, prop.GetValue(obj));
			}

			return newObj;
		}
	}
}
