GuavaSoft Blazor Anchor Navigation Tool built on top of <a href="https://github.com/DevExpress/Blazor/tree/master/tools/DevExpress.Blazor.AnchorUtils">DevExpress Anchor</a>

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

1. Download and add the **GuavaSoft.Links** package project to your Blazor solution.

2. Register the **GuavaSoft.Links** namespace in the _\_Imports.razor_ file:

```
@using GuavaSoft.Links
```
   
3. Add the non-visual **AnchorLinkProvider** component to the _Shared/MainLayout.razor_ file:

```html
<div class="main">
    ...
    <div class="content px-4"> 
        @Body 
    </div> 
</div>
<AnchorLinkProvider />
```