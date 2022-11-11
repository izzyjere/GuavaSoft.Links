GuavaSoft Blazor Anchor Navigation Tool built on top of <a target="blank" href="https://github.com/DevExpress/Blazor/tree/master/tools/DevExpress.Blazor.AnchorUtils">DevExpress Anchor</a> with no javascript require

The GuavaSoft Anchor Navigation tool automatically scrolls a page to an anchor in the following instances:

* When an end-user clicks a hyperlink with an anchor;
The tool also includes the Blazor **AnchorLink** component. Use this component to create in-page navigation links as needed:

```html
<AnchorLink class="nav-link py-3 px-4" href="#MySection1">My Section 1</AnchorLink>
```
    
When an end-user clicks the link, the page scrolls to the corresponding anchor:

```html
<h2 id="MySection1">Section 1</h2>
<p>Lorem ipsum dolor sit amet...</p>
<h2 id="MySection2">Section 2</h2>
<p>Quisque imperdiet risus quis nisl vulputate...</p>
```

## Usage

Follow the steps below to add the tool to your Blazor application.

1.  Adding it to your project with nuget

**Package Manager**

```sh
Install-Package Guavasoft.Links -Version 1.0.0
```

**.NET CLI**

```sh
dotnet add package Guavasoft.Links --version 1.0.0
```
**PackageReference**

```sh
<PackageReference Include="Guavasoft.Links" Version="1.0.0" />
```

2. Register the **GuavaSoft.Links** namespace in the _\_Imports.razor_ file:

```csharp
@using GuavaSoft.Links
```
   
3. Add the non-visual **AnchorLinkProvider** component to the _Shared/MainLayout.razor_ file:
(Optional)Provide the OffsetSelector parameter with your  pinned (non-scrollable) header css selector (like .top-row in the standard Blazor project)
```html
<div class="main">
    ...
    <div class="content px-4"> 
        @Body 
    </div> 
</div>
<AnchorLinkProvider OffsetSelector=".content" />
```