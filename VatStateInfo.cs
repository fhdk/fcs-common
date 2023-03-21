﻿// ***********************************************************************
// Assembly         : FCS.Lib.Common
// Author          : fhdk
// Created          : 2022 12 17 13:33
// 
// Last Modified By: fhdk
// Last Modified On : 2023 03 14 09:16
// ***********************************************************************
// <copyright file="VatStateInfo.cs" company="FCS">
//     Copyright (C) 2022-2023 FCS Frede's Computer Services.
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as
//     published by the Free Software Foundation, either version 3 of the
//     License, or (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
// 
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see [https://www.gnu.org/licenses]
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace FCS.Lib.Common;

/// <summary>
/// Class VatStateInfo
/// </summary>
public class VatStateInfo
{
    /// <summary>
    /// Business entity name
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Business entity vat number
    /// </summary>
    public string VatNumber { get; set; } = "";

    /// <summary>
    /// Flag indicating valid format
    /// </summary>
    public bool VatNumberValid { get; set; }

    /// <summary>
    /// Flag indicating if entity is out of business
    /// </summary>
    public bool HasFolded { get; set; }

    /// <summary>
    /// Request date
    /// </summary>
    public DateTime RequestDate { get; set; }
}