﻿// ***********************************************************************
// Assembly         : FCS.Lib.Common
// Author          : fhdk
// Created          : 2023 01 19 11:41
// 
// Last Modified By: fhdk
// Last Modified On : 2023 03 14 09:16
// ***********************************************************************
// <copyright file="LifeCycle.cs" company="FCS">
//     Copyright (C) 2023-2023 FCS Frede's Computer Services.
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

namespace FCS.Lib.Common;

/// <summary>
/// Class LifeCycle
/// </summary>
public class LifeCycle
{
    /// <summary>
    /// Cycle last updated
    /// </summary>
    public string LastUpdate { get; set; } = "";

    /// <summary>
    /// Time Frame for life cycle
    /// </summary>
    /// <see cref="TimeFrame"/>
    public TimeFrame TimeFrame { get; set; } = new();
}