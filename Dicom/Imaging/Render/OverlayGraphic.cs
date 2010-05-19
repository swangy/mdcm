// mDCM: A C# DICOM library
//
// Copyright (c) 2006-2009  Colby Dillion
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
// Author:
//    Colby Dillion (colby.dillion@gmail.com)

using System;

using Dicom.Imaging.Render;

namespace Dicom.Imaging.Display {
	public class OverlayGraphic : ImageGraphic {
		#region Public Constructors
		public OverlayGraphic(IPixelData pixelData, int offsetx, int offsety) {
			_originalData = pixelData;
			_offsetX = offsetx;
			_offsetY = offsety;
			_zorder = 128;
			_applyLut = false;
			Scale(1.0f);
		}
		#endregion
	}
}
