﻿// // <copyright file="SettingsData.cs" company="PublicDomainWeekly.com">
// //     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
// //     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// // </copyright>
// // <auto-generated />

namespace PublicDomain
{
    // Directives
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;

    /// <summary>
    /// Urlister settings.
    /// </summary>
    public class SettingsData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:PublicDomain.SettingsData"/> class.
        /// </summary>
        public SettingsData()
        {
            // Parameterless constructor
        }

        /// <summary>
        /// The top most.
        /// </summary>
        public bool TopMost { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:PublicDomain.SettingsData"/> keep images.
        /// </summary>
        /// <value><c>true</c> if keep images; otherwise, <c>false</c>.</value>
        public bool KeepImages { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:PublicDomainWeekly.SettingsData"/> is control.
        /// </summary>
        /// <value><c>true</c> if control; otherwise, <c>false</c>.</value>
        public bool Control { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:PublicDomainWeekly.SettingsData"/> is alternate.
        /// </summary>
        /// <value><c>true</c> if alternate; otherwise, <c>false</c>.</value>
        public bool Alt { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:PublicDomainWeekly.SettingsData"/> is shift.
        /// </summary>
        /// <value><c>true</c> if shift; otherwise, <c>false</c>.</value>
        public bool Shift { get; set; } = true;

        /// <summary>
        /// Gets or sets the hotkey.
        /// </summary>
        /// <value>The hotkey.</value>
        public string Hotkey { get; set; } = "S";
    }
}