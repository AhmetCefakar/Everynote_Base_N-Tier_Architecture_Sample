﻿
namespace Everynote.Entities.Enums
{
	public enum ErrorMessageCode
	{
		UserNameAlreadyExist = 101,
		EmailAlreadyExist = 102,
		UserIsNotActive = 151,
		UserNameOrPasswordWrong = 152,
		CheckYourEmail = 153,
		UserAlreadyActive = 154,
		ActivateIdDoesNotExist = 155,
		UserNotFound = 156
	}

	public enum Gender
	{
		Man = 0,
		Woman = 1
	}
}