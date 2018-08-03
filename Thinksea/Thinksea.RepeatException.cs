﻿namespace Thinksea
{
	/// <summary>
	/// 指定记录已经存在时引发的异常。
	/// </summary>
	public class RepeatException: System.ApplicationException
	{
		/// <summary>
		/// 初始化RepeatException类的新实例。
		/// </summary>
		public RepeatException()
		{
		}
		/// <summary>
		/// 使用指定错误信息初始化RepeatException类的新实例。
		/// </summary>
		/// <param name="message">异常错误信息</param>
		public RepeatException(string message)
			: base(message)
		{
		}
		/// <summary>
		/// 使用指定错误信息和对导致此异常的内部异常的引用来初始化RepeatExceptionbv类的新实例。
		/// </summary>
		/// <param name="message">异常错误信息</param>
		/// <param name="inner">作为当前异常的原因的异常。</param>
		public RepeatException(string message, System.Exception inner)
			: base(message, inner)
		{
		}
	}

}
