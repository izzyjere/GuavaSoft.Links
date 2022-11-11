export function scrollToAnchor(anchor, offsetSelector=null) {
    var selector = anchor || document.location.hash;
    if (selector && selector.length > 1) {
        var element = document.querySelector(selector);
        if (element) {
            var y = element.getBoundingClientRect().top + window.pageYOffset; 
            if (offsetSelector != null)
            {
                var node = document.querySelector(offsetSelector);
                if (node != null)
                {
                    y -= node.offsetHeight;
                }
            }
            window.scroll(0, y);
        }
    }
    else
        window.scroll(0, 0);
}
