Project status: This project is in active development, and will be rapidly updated.
# Spidio
A lightweight, easy to use, simplified web crawler written in C<sup>#</sup>. It will start at a user entered location and go through ever link on that site, doing the same thing to all of them. It allows you to choose how many sites it processes before stopping and can even remove all of the duplicate entries. It can be used to demonstrate the basic concept that search engines like Google and Bing operate on.
## Installation
Currently there are only official releases for Windows, but I am planning to make releases for Linux and MacOs in the future. I am doing the development mainly on a Windows machine, using Visual Studio 2019, so I have to find out how to build the project for other operating systems.
### Windows
Go to the releases tab, and install the latest release of Spidio. Then you just have to unzip the file, and run the `.exe` file contained within it.
## How it works
The crawler takes in the next address, then finds all of the links in `<a>` tags that are on that page. It will then add all of the links it found to a new file contained in the directory that the user sets when they start the program. Finally, it continues on to the next address in the current file. If there are no more, then it will move to the next file. It will repeat this process until it reaches the amount of iterations that the user sets when starting the program. If the user so chooses, then it will consolidate all of the output files into a single list. Once again, if the user so chooses, it can loop through that consolidated list and remove all of the duplicate entries.
