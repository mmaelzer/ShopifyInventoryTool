Shopify Inventory Tool
================

Backstory
---------------

While creating an ecommerce site using Shopify, we ran into the issue of having thousands of product images with usable information in the file names, but no way of easily turning that into useful Shopify data. Furthermore, we had no good way, other than the ever-faithful Microsoft Excel, of interacting with and modifying product.csv files provided by Shopify. This utility was born out of that need.


Overview
-----------

The Shopfiy Inventory Tool (henceforth known as SIT) is pretty straightforward in how it operates. After running the executable it compiles to, you get a basic Windows Forms GUI. SIT then allows you to either import from CSV or import from images. Importing from CSV assumes you're giving SIT a 'products.csv' exported from your shopify admin page. Once you import product data from shopify or from images, you will see a populated grid on the right, and various controls on the left for modifying values.


Importing from Images 
--------------------------------

Importing from images is really the primary utility of SIT. In our case, we went from hours to generate a hundred or so products down to just a handful of minutes using the import from images functionality of SIT.

SIT takes two sets of data into account when generating a Shopify `products.csv` file. The first piece of data is the images' filenames themselves which should contain useful information. The second piece of data is a `details.txt` file that lives in subfolders with associated images.

### Details.txt

Before you start importing images, you need to generate `details.txt` files that will live in each subfolder that contains images. When SIT starts its import from images, it will look for this `details.txt` file to better fill in the data for the `products.csv` you will eventually upload to Shopify. 

### How the details.txt file is structured

Take a look at the `sample-details.txt` in this repo to see what an example `details.txt` file looks like. You'll see that the file is a simple list of keys followed by values with colon separation. Newline characters tell the program to look for a new key and subsequent value.

Once SIT finds the `Desciption:` key in the `details.txt` file, it stops looking for new keys and reads the remaining text in as the product's description. 

### How to name image files

One other aspect to using the import from images functionality is that you need to properly name your image files so that they're read by SIT. 

Take the file `Concerto+RU-201-40+Roll-Up_Jelly_Roll.jpg` for example. The `+` characters designate splits between data. So we have 3 pieces of data in this image: `Concerto`, `RU-201-40`, and `Roll-Up Jelly Roll`. Notice that the `_` character is replaced by a space.

### Special characters inside of a details.txt file

When generating product descriptions, SIT lets you populate a description using bits from the product's image name by using curly braces around a number. The number corresponds to a place in the image's filename to look for the desired information.

Take the example image name listed above, `Concerto+RU-201-40+Roll-Up_Jelly_Roll.jpg` for the following `details.txt` file. 

	Vendor: somevendor
	Type: sometype
	Tags: atagofsomesort
	Price: 123.45
	Url: http://where-to-find-your-images
	Description:
	Title of Description Section
	First Thing: {1}
	Manufacturer: Some Vendor
	Second Thing: {3}

After SIT process the image filename and the `details.txt` file, the description would become:

	First Thing: Concerto
	Manufacturer: Some Vendor
	Second Thing: Roll-Up Jelly Roll
	
### Customizing the product description section

SIT automatically generates the proper HTML for a product description when you list out the description as I did in the example above. The first line after `Description:` would be wrapped in `h4` tags and remaining lines would be placed into an unsorted list or `ul`.

To override the default HTML layout, wrap your description in double curly braces, `{{ description }}` like so:

	Vendor: somevendor
	Type: sometype
	Tags: atagofsomesort
	Price: 123.45
	Url: http://where-to-find-your-images
	Description:
	{{
	<div>
	<table>
		<tr>
			<td>
				Foo
			</td>
		</tr>
	</table>
	</div>
	}}
	

### Organizing data for running SIT

SIT will glady go through a folder and all of the folder's subfolders, looking for image files and `details.txt` files. Using a system of folder naming with descriptive image file names will yield best results.
	
Epilogue
------------

I'm fully aware that I could generalize this utility even more. However, this implementation works very well for us, and I honestly don't know what generalizing the utility further would gain for people. That being said, I'd happy to be convinced that I'm wrong.

Credits
----------
Shopify Inventory Tool [icon source](http://browse.deviantart.com/customization/icons/dock/?order=9&offset=48#/d3c3t3x) - Variations 1 by GuillenDesign 