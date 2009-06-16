/*******************************************************************************
 * Copyright (c) 2001, 2009 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Common Public License v1.0
 * which accompanies this distribution, and is available at
 * http://robocode.sourceforge.net/license/cpl-v10.html
 *
 * Contributors:
 * 		Joshua Galecki
 * 		-Initial implementation
  *******************************************************************************/

package robocode;

/**
 * This robject allows robots to see and shoot over it, btu they cannot pass through it.
 * 
 * @author Joshua Galecki (original)
 *
 */
public class Trench extends Robject{

	public Trench(String type, int x, int y, int width, int height) {
		super(type, x, y, width, height, true, false, false,
				true, true);
	}

	@Override
	public boolean shouldDraw() {
		return true;
	}
}