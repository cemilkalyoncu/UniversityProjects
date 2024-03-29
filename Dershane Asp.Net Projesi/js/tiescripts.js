﻿
//----------------------------------------------------------------
jQuery(document).ready(function () {

    //prettyPhoto Setup
    jQuery(".gallery-images .gallery-icon a").attr('rel', 'prettyPhoto[gallery]');
    jQuery("a[rel^='prettyPhoto']").prettyPhoto({ animation_speed: 'normal' });

    jQuery('#main-menu-mob, #top-menu-mob').bind('change', function () {
        var url = jQuery(this).val();
        if (url) {
            window.location = url;
        }
        return false;
    });

    //Scroll To top
    jQuery(window).scroll(function () {
        if (jQuery(this).scrollTop() > 100) {
            jQuery('#topcontrol').css({ bottom: "15px" });
        } else {
            jQuery('#topcontrol').css({ bottom: "-100px" });
        }
    });
    jQuery('#topcontrol').click(function () {
        jQuery('html, body').animate({ scrollTop: '0px' }, 800);
        return false;
    });

    //tooltip();
    jQuery('.ttip , .tooltip-n').tipsy({ fade: true, gravity: 's' });
    jQuery('.tooldown, .tooltip-s').tipsy({ fade: true, gravity: 'n' });

    jQuery('.tooltip-nw').tipsy({ fade: true, gravity: 'nw' });
    jQuery('.tooltip-ne').tipsy({ fade: true, gravity: 'ne' });
    jQuery('.tooltip-w').tipsy({ fade: true, gravity: 'w' });
    jQuery('.tooltip-e').tipsy({ fade: true, gravity: 'e' });
    jQuery('.tooltip-sw').tipsy({ fade: true, gravity: 'w' });
    jQuery('.tooltip-se').tipsy({ fade: true, gravity: 'e' });

    // Toggle Shortcode
    jQuery(".toggle-head-open").click(function () {
        jQuery(this).parent().find(".toggle-content").slideToggle("slow");
        jQuery(this).hide();
        jQuery(this).parent().find(".toggle-head-close").show();
    });
    jQuery(".toggle-head-close").click(function () {
        jQuery(this).parent().find(".toggle-content").slideToggle("slow");
        jQuery(this).hide();
        jQuery(this).parent().find(".toggle-head-open").show();
    });

    //Menus
    jQuery('#main-nav ul > li > ul, #main-nav ul > li > ul > li > ul, #main-nav ul > li > ul > li > ul> li > ul, .top-menu  ul > li > ul, .top-menu  ul > li > ul > li > ul, .top-menu  ul > li > ul > li > ul> li > ul ').parent('li').addClass('parent-list');
    jQuery('.parent-list').find("a:first").append(' <span class="sub-indicator">&raquo;</span>');

    jQuery("#main-nav li , .top-menu li").each(function () {
        var $sublist = jQuery(this).find('ul:first');
        jQuery(this).hover(function () {
            $sublist.stop().css({ overflow: "hidden", height: "auto", display: "none" }).slideDown(200, function () {
                jQuery(this).css({ overflow: "visible", height: "auto" });
            });
        },
		function () {
		    $sublist.stop().slideUp(200, function () {
		        jQuery(this).css({ overflow: "hidden", display: "none" });
		    });
		});
    });

    //tabbed Boxes
    jQuery(".cat-tabs-wrap").hide();
    jQuery(".cat-tabs-header ul li:first").addClass("active").show();
    jQuery(".cat-tabs-wrap:first").show();
    jQuery(".cat-tabs-header ul li").click(function () {
        jQuery(".cat-tabs-header ul li").removeClass("active");
        jQuery(this).addClass("active");
        jQuery(".cat-tabs-wrap").hide();
        var activeTab = jQuery(this).find("a").attr("href");
        jQuery(activeTab).slideDown();
        return false;
    });

    jQuery("#tabbed-widget .tabs-wrap").hide();
    jQuery("#tabbed-widget ul.posts-taps li:first").addClass("active").show();
    jQuery("#tabbed-widget .tabs-wrap:first").show();
    jQuery("#tabbed-widget  li.tabs").click(function () {
        jQuery("#tabbed-widget ul.posts-taps li").removeClass("active");
        jQuery(this).addClass("active");
        jQuery("#tabbed-widget .tabs-wrap").hide();
        var activeTab = jQuery(this).find("a").attr("href");
        jQuery(activeTab).slideDown();
        return false;
    });

    // jQuery Mobile Menu
    var topMenu = jQuery('.top-menu ul.menu');
    if (topMenu.length) { topMenu.mobileMenu({ defaultText: tievar.go_to, className: 'top-menu-mob' }); }

    var mainMenu = jQuery('#main-nav ul.menu');
    if (mainMenu.length) { mainMenu.mobileMenu({ defaultText: tievar.go_to, className: 'main-menu-mob' }); }

});

jQuery(window).load(function () {
    //Header
    var hedaerHeight = jQuery('#main-nav').offset().top;
    var main = jQuery('.fixed-enabled');
    jQuery(window).scroll(function () {
        HeaderScroll();
    });
    jQuery(window).load(function () {
        HeaderScroll();
    });
    function HeaderScroll() {
        var scrollY = jQuery(window).scrollTop();
        if (main.length > 0) {
            if (scrollY > hedaerHeight) {
                main.stop().addClass('fixed-nav');
            } else if (scrollY < hedaerHeight) {
                main.removeClass('fixed-nav');
            }
        }
    }
});


function createTicker() {
    var tickerLIs = jQuery(".breaking-news ul").children();
    tickerItems = new Array();
    tickerLIs.each(function (el) {
        tickerItems.push(jQuery(this).html());
    });
    i = 0;
    rotateTicker();
}
function rotateTicker() {
    if (i == tickerItems.length) {
        i = 0;
    }
    tickerText = tickerItems[i];
    c = 0;
    typetext();
    setTimeout("rotateTicker()", 5000);
    i++;
}
var isInTag = false;
function typetext() {
    var thisChar = tickerText.substr(c, 1);
    if (thisChar == '<') { isInTag = true; }
    if (thisChar == '>') { isInTag = false; }
    jQuery('.breaking-news ul').html(tickerText.substr(0, c++));
    if (c < tickerText.length + 1)
        if (isInTag) {
            typetext();
        } else {
            setTimeout("typetext()", 28);
        }
    else {
        c = 1;
        tickerText = "";
    }
}

// jQuery Easing v1.3 - http://gsgd.co.uk/sandbox/jquery/easing
jQuery.easing["jswing"] = jQuery.easing["swing"]; jQuery.extend(jQuery.easing, { def: "easeOutQuad", swing: function (a, b, c, d, e) { return jQuery.easing[jQuery.easing.def](a, b, c, d, e) }, easeInQuad: function (a, b, c, d, e) { return d * (b /= e) * b + c }, easeOutQuad: function (a, b, c, d, e) { return -d * (b /= e) * (b - 2) + c }, easeInOutQuad: function (a, b, c, d, e) { if ((b /= e / 2) < 1) return d / 2 * b * b + c; return -d / 2 * (--b * (b - 2) - 1) + c }, easeInCubic: function (a, b, c, d, e) { return d * (b /= e) * b * b + c }, easeOutCubic: function (a, b, c, d, e) { return d * ((b = b / e - 1) * b * b + 1) + c }, easeInOutCubic: function (a, b, c, d, e) { if ((b /= e / 2) < 1) return d / 2 * b * b * b + c; return d / 2 * ((b -= 2) * b * b + 2) + c }, easeInQuart: function (a, b, c, d, e) { return d * (b /= e) * b * b * b + c }, easeOutQuart: function (a, b, c, d, e) { return -d * ((b = b / e - 1) * b * b * b - 1) + c }, easeInOutQuart: function (a, b, c, d, e) { if ((b /= e / 2) < 1) return d / 2 * b * b * b * b + c; return -d / 2 * ((b -= 2) * b * b * b - 2) + c }, easeInQuint: function (a, b, c, d, e) { return d * (b /= e) * b * b * b * b + c }, easeOutQuint: function (a, b, c, d, e) { return d * ((b = b / e - 1) * b * b * b * b + 1) + c }, easeInOutQuint: function (a, b, c, d, e) { if ((b /= e / 2) < 1) return d / 2 * b * b * b * b * b + c; return d / 2 * ((b -= 2) * b * b * b * b + 2) + c }, easeInSine: function (a, b, c, d, e) { return -d * Math.cos(b / e * (Math.PI / 2)) + d + c }, easeOutSine: function (a, b, c, d, e) { return d * Math.sin(b / e * (Math.PI / 2)) + c }, easeInOutSine: function (a, b, c, d, e) { return -d / 2 * (Math.cos(Math.PI * b / e) - 1) + c }, easeInExpo: function (a, b, c, d, e) { return b == 0 ? c : d * Math.pow(2, 10 * (b / e - 1)) + c }, easeOutExpo: function (a, b, c, d, e) { return b == e ? c + d : d * (-Math.pow(2, -10 * b / e) + 1) + c }, easeInOutExpo: function (a, b, c, d, e) { if (b == 0) return c; if (b == e) return c + d; if ((b /= e / 2) < 1) return d / 2 * Math.pow(2, 10 * (b - 1)) + c; return d / 2 * (-Math.pow(2, -10 * --b) + 2) + c }, easeInCirc: function (a, b, c, d, e) { return -d * (Math.sqrt(1 - (b /= e) * b) - 1) + c }, easeOutCirc: function (a, b, c, d, e) { return d * Math.sqrt(1 - (b = b / e - 1) * b) + c }, easeInOutCirc: function (a, b, c, d, e) { if ((b /= e / 2) < 1) return -d / 2 * (Math.sqrt(1 - b * b) - 1) + c; return d / 2 * (Math.sqrt(1 - (b -= 2) * b) + 1) + c }, easeInElastic: function (a, b, c, d, e) { var f = 1.70158; var g = 0; var h = d; if (b == 0) return c; if ((b /= e) == 1) return c + d; if (!g) g = e * .3; if (h < Math.abs(d)) { h = d; var f = g / 4 } else var f = g / (2 * Math.PI) * Math.asin(d / h); return -(h * Math.pow(2, 10 * (b -= 1)) * Math.sin((b * e - f) * 2 * Math.PI / g)) + c }, easeOutElastic: function (a, b, c, d, e) { var f = 1.70158; var g = 0; var h = d; if (b == 0) return c; if ((b /= e) == 1) return c + d; if (!g) g = e * .3; if (h < Math.abs(d)) { h = d; var f = g / 4 } else var f = g / (2 * Math.PI) * Math.asin(d / h); return h * Math.pow(2, -10 * b) * Math.sin((b * e - f) * 2 * Math.PI / g) + d + c }, easeInOutElastic: function (a, b, c, d, e) { var f = 1.70158; var g = 0; var h = d; if (b == 0) return c; if ((b /= e / 2) == 2) return c + d; if (!g) g = e * .3 * 1.5; if (h < Math.abs(d)) { h = d; var f = g / 4 } else var f = g / (2 * Math.PI) * Math.asin(d / h); if (b < 1) return -.5 * h * Math.pow(2, 10 * (b -= 1)) * Math.sin((b * e - f) * 2 * Math.PI / g) + c; return h * Math.pow(2, -10 * (b -= 1)) * Math.sin((b * e - f) * 2 * Math.PI / g) * .5 + d + c }, easeInBack: function (a, b, c, d, e, f) { if (f == undefined) f = 1.70158; return d * (b /= e) * b * ((f + 1) * b - f) + c }, easeOutBack: function (a, b, c, d, e, f) { if (f == undefined) f = 1.70158; return d * ((b = b / e - 1) * b * ((f + 1) * b + f) + 1) + c }, easeInOutBack: function (a, b, c, d, e, f) { if (f == undefined) f = 1.70158; if ((b /= e / 2) < 1) return d / 2 * b * b * (((f *= 1.525) + 1) * b - f) + c; return d / 2 * ((b -= 2) * b * (((f *= 1.525) + 1) * b + f) + 2) + c }, easeInBounce: function (a, b, c, d, e) { return d - jQuery.easing.easeOutBounce(a, e - b, 0, d, e) + c }, easeOutBounce: function (a, b, c, d, e) { if ((b /= e) < 1 / 2.75) { return d * 7.5625 * b * b + c } else if (b < 2 / 2.75) { return d * (7.5625 * (b -= 1.5 / 2.75) * b + .75) + c } else if (b < 2.5 / 2.75) { return d * (7.5625 * (b -= 2.25 / 2.75) * b + .9375) + c } else { return d * (7.5625 * (b -= 2.625 / 2.75) * b + .984375) + c } }, easeInOutBounce: function (a, b, c, d, e) { if (b < e / 2) return jQuery.easing.easeInBounce(a, b * 2, 0, d, e) * .5 + c; return jQuery.easing.easeOutBounce(a, b * 2 - e, 0, d, e) * .5 + d * .5 + c } });

//ELASTIC IMAGE SLIDESHOW
(function (a, b, c) { var d = b.event, e; d.special.smartresize = { setup: function () { b(this).bind("resize", d.special.smartresize.handler) }, teardown: function () { b(this).unbind("resize", d.special.smartresize.handler) }, handler: function (a, b) { var c = this, d = arguments; a.type = "smartresize"; if (e) { clearTimeout(e) } e = setTimeout(function () { jQuery.event.handle.apply(c, d) }, b === "execAsap" ? 0 : 100) } }; b.fn.smartresize = function (a) { return a ? this.bind("smartresize", a) : this.trigger("smartresize", ["execAsap"]) }; b.Slideshow = function (a, c) { this.$el = b(c); this.$list = this.$el.find("ul.ei-slider-large"); this.$imgItems = this.$list.children("li"); this.itemsCount = this.$imgItems.length; this.$images = this.$imgItems.find("img:first"); this.$sliderthumbs = this.$el.find("ul.ei-slider-thumbs").hide(); this.$sliderElems = this.$sliderthumbs.children("li"); this.$sliderElem = this.$sliderthumbs.children("li.ei-slider-element"); this.$thumbs = this.$sliderElems.not(".ei-slider-element"); this._init(a) }; b.Slideshow.defaults = { animation: "sides", autoplay: false, slideshow_interval: 3e3, speed: 800, easing: "", titlesFactor: .6, titlespeed: 800, titleeasing: "", thumbMaxWidth: 150 }; b.Slideshow.prototype = { _init: function (a) { this.options = b.extend(true, {}, b.Slideshow.defaults, a); this.$imgItems.css("opacity", 0); this.$imgItems.find("div.ei-title > *").css("opacity", 0); this.current = 0; var c = this; this.$loading = b('<div class="ei-slider-loading">Loading</div>').prependTo(c.$el); b.when(this._preloadImages()).done(function () { c.$loading.hide(); c._setImagesSize(); c._initThumbs(); c.$imgItems.eq(c.current).css({ opacity: 1, "z-index": 10 }).show().find("div.ei-title > *").css("opacity", 1); if (c.options.autoplay) { c._startSlideshow() } c._initEvents() }) }, _preloadImages: function () { var a = this, c = 0; return b.Deferred(function (d) { a.$images.each(function (e) { b("<img/>").load(function () { if (++c === a.itemsCount) { d.resolve() } }).attr("src", b(this).attr("src")) }) }).promise() }, _setImagesSize: function () { this.elWidth = this.$el.width(); var a = this; this.$images.each(function (c) { var d = b(this); imgDim = a._getImageDim(d.attr("src")); d.css({ width: imgDim.width, height: imgDim.height, marginLeft: imgDim.left, marginTop: imgDim.top }) }) }, _getImageDim: function (a) { var b = new Image; b.src = a; var c = this.elWidth, d = this.$el.height(), e = d / c, f = b.width, g = b.height, h = g / f, i, j, k, l; if (e > h) { j = d; i = d / h } else { j = c * h; i = c } return { width: i, height: j, left: (c - i) / 2, top: (d - j) / 2} }, _initThumbs: function () { this.$sliderElems.css({ "max-width": this.options.thumbMaxWidth + "%", width: 100 / this.itemsCount + "%" }); this.$sliderthumbs.css("max-width", this.options.thumbMaxWidth * this.itemsCount + "%").show() }, _startSlideshow: function () { var a = this; this.slideshow = setTimeout(function () { var b; a.current === a.itemsCount - 1 ? b = 0 : b = a.current + 1; a._slideTo(b); if (a.options.autoplay) { a._startSlideshow() } }, this.options.slideshow_interval) }, _slideTo: function (a) { if (a === this.current || this.isAnimating) return false; this.isAnimating = true; var c = this.$imgItems.eq(this.current), d = this.$imgItems.eq(a), e = this, f = { zIndex: 10 }, g = { opacity: 1 }; if (this.options.animation === "sides") { f.left = a > this.current ? -1 * this.elWidth : this.elWidth; g.left = 0 } d.find("div.ei-title > h2").css("margin-right", 50 + "px").stop().delay(this.options.speed * this.options.titlesFactor).animate({ marginRight: 0 + "px", opacity: 1 }, this.options.titlespeed, this.options.titleeasing).end().find("div.ei-title > h3").css("margin-right", -50 + "px").stop().delay(this.options.speed * this.options.titlesFactor).animate({ marginRight: 0 + "px", opacity: 1 }, this.options.titlespeed, this.options.titleeasing); b.when(c.css("z-index", 1).find("div.ei-title > *").stop().fadeOut(this.options.speed / 2, function () { b(this).show().css("opacity", 0) }), d.css(f).stop().animate(g, this.options.speed, this.options.easing), this.$sliderElem.stop().animate({ left: this.$thumbs.eq(a).position().left }, this.options.speed)).done(function () { c.css("opacity", 0).find("div.ei-title > *").css("opacity", 0); e.current = a; e.isAnimating = false }) }, _initEvents: function () { var c = this; b(a).on("smartresize.eislideshow", function (a) { c._setImagesSize(); c.$sliderElem.css("left", c.$thumbs.eq(c.current).position().left) }); this.$thumbs.on("click.eislideshow", function (a) { if (c.options.autoplay) { clearTimeout(c.slideshow); c.options.autoplay = false } var d = b(this), e = d.index() - 1; c._slideTo(e); return false }) } }; var f = function (a) { if (this.console) { console.error(a) } }; b.fn.eislideshow = function (a) { if (typeof a === "string") { var c = Array.prototype.slice.call(arguments, 1); this.each(function () { var d = b.data(this, "eislideshow"); if (!d) { f("cannot call methods on eislideshow prior to initialization; " + "attempted to call method '" + a + "'"); return } if (!b.isFunction(d[a]) || a.charAt(0) === "_") { f("no such method '" + a + "' for eislideshow instance"); return } d[a].apply(d, c) }) } else { this.each(function () { var c = b.data(this, "eislideshow"); if (!c) { b.data(this, "eislideshow", new b.Slideshow(a, this)) } }) } return this } })(window, jQuery);

// tipsy, version 1.0.0a
// (c) 2008-2010 jason frame [jason@onehackoranother.com]
// released under the MIT license
(function (a) { function b(a, b) { return typeof a == "function" ? a.call(b) : a } function c(a) { while (a = a.parentNode) { if (a == document) return true } return false } function d(b, c) { this.$element = a(b); this.options = c; this.enabled = true; this.fixTitle() } d.prototype = { show: function () { var c = this.getTitle(); if (c && this.enabled) { var d = this.tip(); d.find(".tipsy-inner")[this.options.html ? "html" : "text"](c); d[0].className = "tipsy"; d.remove().css({ top: 0, left: 0, visibility: "hidden", display: "block" }).prependTo(document.body); var e = a.extend({}, this.$element.offset(), { width: this.$element[0].offsetWidth, height: this.$element[0].offsetHeight }); var f = d[0].offsetWidth, g = d[0].offsetHeight, h = b(this.options.gravity, this.$element[0]); var i; switch (h.charAt(0)) { case "n": i = { top: e.top + e.height + this.options.offset, left: e.left + e.width / 2 - f / 2 }; break; case "s": i = { top: e.top - g - this.options.offset, left: e.left + e.width / 2 - f / 2 }; break; case "e": i = { top: e.top + e.height / 2 - g / 2, left: e.left - f - this.options.offset }; break; case "w": i = { top: e.top + e.height / 2 - g / 2, left: e.left + e.width + this.options.offset }; break } if (h.length == 2) { if (h.charAt(1) == "w") { i.left = e.left + e.width / 2 - 15 } else { i.left = e.left + e.width / 2 - f + 15 } } d.css(i).addClass("tipsy-" + h); d.find(".tipsy-arrow")[0].className = "tipsy-arrow tipsy-arrow-" + h.charAt(0); if (this.options.className) { d.addClass(b(this.options.className, this.$element[0])) } if (this.options.fade) { d.stop().css({ opacity: 0, display: "block", visibility: "visible" }).animate({ opacity: this.options.opacity }) } else { d.css({ visibility: "visible", opacity: this.options.opacity }) } } }, hide: function () { if (this.options.fade) { this.tip().stop().fadeOut(function () { a(this).remove() }) } else { this.tip().remove() } }, fixTitle: function () { var a = this.$element; if (a.attr("title") || typeof a.attr("original-title") != "string") { a.attr("original-title", a.attr("title") || "").removeAttr("title") } }, getTitle: function () { var a, b = this.$element, c = this.options; this.fixTitle(); var a, c = this.options; if (typeof c.title == "string") { a = b.attr(c.title == "title" ? "original-title" : c.title) } else if (typeof c.title == "function") { a = c.title.call(b[0]) } a = ("" + a).replace(/(^\s*|\s*$)/, ""); return a || c.fallback }, tip: function () { if (!this.$tip) { this.$tip = a('<div class="tipsy"></div>').html('<div class="tipsy-arrow"></div><div class="tipsy-inner"></div>'); this.$tip.data("tipsy-pointee", this.$element[0]) } return this.$tip }, validate: function () { if (!this.$element[0].parentNode) { this.hide(); this.$element = null; this.options = null } }, enable: function () { this.enabled = true }, disable: function () { this.enabled = false }, toggleEnabled: function () { this.enabled = !this.enabled } }; a.fn.tipsy = function (b) { function e(c) { var e = a.data(c, "tipsy"); if (!e) { e = new d(c, a.fn.tipsy.elementOptions(c, b)); a.data(c, "tipsy", e) } return e } function f() { var a = e(this); a.hoverState = "in"; if (b.delayIn == 0) { a.show() } else { a.fixTitle(); setTimeout(function () { if (a.hoverState == "in") a.show() }, b.delayIn) } } function g() { var a = e(this); a.hoverState = "out"; if (b.delayOut == 0) { a.hide() } else { setTimeout(function () { if (a.hoverState == "out") a.hide() }, b.delayOut) } } if (b === true) { return this.data("tipsy") } else if (typeof b == "string") { var c = this.data("tipsy"); if (c) c[b](); return this } b = a.extend({}, a.fn.tipsy.defaults, b); if (!b.live) this.each(function () { e(this) }); if (b.trigger != "manual") { var h = b.live ? "live" : "bind", i = b.trigger == "hover" ? "mouseenter" : "focus", j = b.trigger == "hover" ? "mouseleave" : "blur"; this[h](i, f)[h](j, g) } return this }; a.fn.tipsy.defaults = { className: null, delayIn: 0, delayOut: 0, fade: false, fallback: "", gravity: "n", html: false, live: false, offset: 0, opacity: .8, title: "title", trigger: "hover" }; a.fn.tipsy.revalidate = function () { a(".tipsy").each(function () { var b = a.data(this, "tipsy-pointee"); if (!b || !c(b)) { a(this).remove() } }) }; a.fn.tipsy.elementOptions = function (b, c) { return a.metadata ? a.extend({}, c, a(b).metadata()) : c }; a.fn.tipsy.autoNS = function () { return a(this).offset().top > a(document).scrollTop() + a(window).height() / 2 ? "s" : "n" }; a.fn.tipsy.autoWE = function () { return a(this).offset().left > a(document).scrollLeft() + a(window).width() / 2 ? "e" : "w" }; a.fn.tipsy.autoBounds = function (b, c) { return function () { var d = { ns: c[0], ew: c.length > 1 ? c[1] : false }, e = a(document).scrollTop() + b, f = a(document).scrollLeft() + b, g = a(this); if (g.offset().top < e) d.ns = "n"; if (g.offset().left < f) d.ew = "w"; if (a(window).width() + a(document).scrollLeft() - g.offset().left < b) d.ew = "e"; if (a(window).height() + a(document).scrollTop() - g.offset().top < b) d.ns = "s"; return d.ns + (d.ew ? d.ew : "") } } })(jQuery);

//innerfade
function removeFilter(a) { if (a.style.removeAttribute) { a.style.removeAttribute("filter") } } (function (a) { a.fn.innerfade = function (b) { return this.each(function () { a.innerfade(this, b) }) }; a.innerfade = function (b, c) { var d = { animationtype: "fade", speed: "normal", type: "sequence", timeout: 2e3, containerheight: "auto", runningclass: "innerfade", children: null }; if (c) a.extend(d, c); if (d.children === null) var e = a(b).children(); else var e = a(b).children(d.children); if (e.length > 1) { a(b).css("position", "relative").css("height", d.containerheight).addClass(d.runningclass); for (var f = 0; f < e.length; f++) { a(e[f]).css("z-index", String(e.length - f)).css("position", "absolute").hide() } if (d.type == "sequence") { setTimeout(function () { a.innerfade.next(e, d, 1, 0) }, d.timeout); a(e[0]).show() } else if (d.type == "random") { var g = Math.floor(Math.random() * e.length); setTimeout(function () { do { h = Math.floor(Math.random() * e.length) } while (g == h); a.innerfade.next(e, d, h, g) }, d.timeout); a(e[g]).show() } else if (d.type == "random_start") { d.type = "sequence"; var h = Math.floor(Math.random() * e.length); setTimeout(function () { a.innerfade.next(e, d, (h + 1) % e.length, h) }, d.timeout); a(e[h]).show() } else { alert("Innerfade-Type must either be 'sequence', 'random' or 'random_start'") } } }; a.innerfade.next = function (b, c, d, e) { if (c.animationtype == "slide") { a(b[e]).slideUp(c.speed); a(b[d]).slideDown(c.speed) } else if (c.animationtype == "fade") { a(b[e]).fadeOut(c.speed); a(b[d]).fadeIn(c.speed, function () { removeFilter(a(this)[0]) }) } else alert("Innerfade-animationtype must either be 'slide' or 'fade'"); if (c.type == "sequence") { if (d + 1 < b.length) { d = d + 1; e = d - 1 } else { d = 0; e = b.length - 1 } } else if (c.type == "random") { e = d; while (d == e) d = Math.floor(Math.random() * b.length) } else alert("Innerfade-Type must either be 'sequence', 'random' or 'random_start'"); setTimeout(function () { a.innerfade.next(b, c, d, e) }, c.timeout) } })(jQuery);

// jQuery Mobile Menu 
(function ($) { $.fn.mobileMenu = function (options) { var defaults = { defaultText: 'Navigate to...', className: 'select-menu', subMenuClass: 'sub-menu', subMenuDash: '&nbsp; &nbsp; &ndash;' }, settings = $.extend(defaults, options), el = $(this); this.each(function () { el.find('ul').addClass(settings.subMenuClass); $('<select />', { 'id': settings.className }).insertAfter(el); $('<option />', { "value": '#', "text": settings.defaultText }).appendTo('#' + settings.className); el.find('a').each(function () { var $this = $(this), optText = '&nbsp;' + $this.text(), optSub = $this.parents('.' + settings.subMenuClass), len = optSub.length, dash; if ($this.parents('ul').hasClass(settings.subMenuClass)) { dash = Array(len + 1).join(settings.subMenuDash); optText = dash + optText; } $('<option />', { "value": this.href, "html": optText, "selected": (this.href == window.location.href) }).appendTo('#' + settings.className); }); $('#' + settings.className).change(function () { var locations = $(this).val(); if (locations !== '#') { window.location.href = $(this).val(); }; }); }); return this; }; })(jQuery);

/* jQuery FlexSlider v2.0
* Copyright 2012 WooThemes
* Contributing Author: Tyler Smith
*/
; (function (d) {
    d.flexslider = function (h, k) {
        var a = d(h), c = d.extend({}, d.flexslider.defaults, k), e = c.namespace, o = "ontouchstart" in window || window.DocumentTouch && document instanceof DocumentTouch, s = o ? "touchend" : "click", l = "vertical" === c.direction, m = c.reverse, i = 0 < c.itemWidth, p = "fade" === c.animation, r = "" !== c.asNavFor, f = {}; d.data(h, "flexslider", a); f = { init: function () {
            a.animating = !1; a.currentSlide = c.startAt; a.animatingTo = a.currentSlide; a.atEnd = 0 === a.currentSlide || a.currentSlide === a.last; a.containerSelector = c.selector.substr(0,
c.selector.search(" ")); a.slides = d(c.selector, a); a.container = d(a.containerSelector, a); a.count = a.slides.length; a.syncExists = 0 < d(c.sync).length; "slide" === c.animation && (c.animation = "swing"); a.prop = l ? "top" : "marginLeft"; a.args = {}; a.manualPause = !1; a.transitions = !c.video && !p && c.useCSS && function () {
    var b = document.createElement("div"), c = ["perspectiveProperty", "WebkitPerspective", "MozPerspective", "OPerspective", "msPerspective"], d; for (d in c) if (b.style[c[d]] !== void 0) {
        a.pfx = c[d].replace("Perspective", "").toLowerCase();
        a.prop = "-" + a.pfx + "-transform"; return true
    } return false
} (); "" !== c.controlsContainer && (a.controlsContainer = 0 < d(c.controlsContainer).length && d(c.controlsContainer)); "" !== c.manualControls && (a.manualControls = 0 < d(c.manualControls).length && d(c.manualControls)); c.randomize && (a.slides.sort(function () { return Math.round(Math.random()) - 0.5 }), a.container.empty().append(a.slides)); a.doMath(); r && f.asNav.setup(); a.setup("init"); c.controlNav && f.controlNav.setup(); c.directionNav && f.directionNav.setup(); c.keyboard &&
(1 === d(a.containerSelector).length || c.multipleKeyboard) && d(document).bind("keyup", function (b) { b = b.keyCode; if (!a.animating && (b === 39 || b === 37)) { b = b === 39 ? a.getTarget("next") : b === 37 ? a.getTarget("prev") : false; a.flexAnimate(b, c.pauseOnAction) } }); c.mousewheel && a.bind("mousewheel", function (b, g) { b.preventDefault(); var d = g < 0 ? a.getTarget("next") : a.getTarget("prev"); a.flexAnimate(d, c.pauseOnAction) }); c.pausePlay && f.pausePlay.setup(); c.slideshow && (c.pauseOnHover && a.hover(function () { a.pause() }, function () {
    a.manualPause ||
a.play()
}), 0 < c.initDelay ? setTimeout(a.play, c.initDelay) : a.play()); o && c.touch && f.touch(); (!p || p && c.smoothHeight) && d(window).bind("resize focus", f.resize); setTimeout(function () { c.start(a) }, 200)
        }, asNav: { setup: function () {
            a.asNav = !0; a.animatingTo = Math.floor(a.currentSlide / a.move); a.currentItem = a.currentSlide; a.slides.removeClass(e + "active-slide").eq(a.currentItem).addClass(e + "active-slide"); a.slides.click(function (b) {
                b.preventDefault(); var b = d(this), g = b.index(); !d(c.asNavFor).data("flexslider").animating &&
!b.hasClass("active") && (a.direction = a.currentItem < g ? "next" : "prev", a.flexAnimate(g, c.pauseOnAction, !1, !0, !0))
            })
        } 
        }, controlNav: { setup: function () { a.manualControls ? f.controlNav.setupManual() : f.controlNav.setupPaging() }, setupPaging: function () {
            var b = 1, g; a.controlNavScaffold = d('<ol class="' + e + "control-nav " + e + ("thumbnails" === c.controlNav ? "control-thumbs" : "control-paging") + '"></ol>'); if (1 < a.pagingCount) for (var q = 0; q < a.pagingCount; q++) g = "thumbnails" === c.controlNav ? '<img src="' + a.slides.eq(q).attr("data-thumb") +
'"/>' : "<a>" + b + "</a>", a.controlNavScaffold.append("<li>" + g + "</li>"), b++; a.controlsContainer ? d(a.controlsContainer).append(a.controlNavScaffold) : a.append(a.controlNavScaffold); f.controlNav.set(); f.controlNav.active(); a.controlNavScaffold.delegate("a, img", s, function (b) { b.preventDefault(); var b = d(this), g = a.controlNav.index(b); b.hasClass(e + "active") || (a.direction = g > a.currentSlide ? "next" : "prev", a.flexAnimate(g, c.pauseOnAction)) }); o && a.controlNavScaffold.delegate("a", "click touchstart", function (a) { a.preventDefault() })
        },
            setupManual: function () { a.controlNav = a.manualControls; f.controlNav.active(); a.controlNav.live(s, function (b) { b.preventDefault(); var b = d(this), g = a.controlNav.index(b); b.hasClass(e + "active") || (g > a.currentSlide ? a.direction = "next" : a.direction = "prev", a.flexAnimate(g, c.pauseOnAction)) }); o && a.controlNav.live("click touchstart", function (a) { a.preventDefault() }) }, set: function () { a.controlNav = d("." + e + "control-nav li " + ("thumbnails" === c.controlNav ? "img" : "a"), a.controlsContainer ? a.controlsContainer : a) }, active: function () {
                a.controlNav.removeClass(e +
"active").eq(a.animatingTo).addClass(e + "active")
            }, update: function (b, c) { 1 < a.pagingCount && "add" === b ? a.controlNavScaffold.append(d("<li><a>" + a.count + "</a></li>")) : 1 === a.pagingCount ? a.controlNavScaffold.find("li").remove() : a.controlNav.eq(c).closest("li").remove(); f.controlNav.set(); 1 < a.pagingCount && a.pagingCount !== a.controlNav.length ? a.update(c, b) : f.controlNav.active() } 
        }, directionNav: { setup: function () {
            var b = d('<ul class="' + e + 'direction-nav"><li><a class="' + e + 'prev" href="#">' + c.prevText + '</a></li><li><a class="' +
e + 'next" href="#">' + c.nextText + "</a></li></ul>"); a.controlsContainer ? (d(a.controlsContainer).append(b), a.directionNav = d("." + e + "direction-nav li a", a.controlsContainer)) : (a.append(b), a.directionNav = d("." + e + "direction-nav li a", a)); f.directionNav.update(); a.directionNav.bind(s, function (b) { b.preventDefault(); b = d(this).hasClass(e + "next") ? a.getTarget("next") : a.getTarget("prev"); a.flexAnimate(b, c.pauseOnAction) }); o && a.directionNav.bind("click touchstart", function (a) { a.preventDefault() })
        }, update: function () {
            var b =
e + "disabled"; c.animationLoop || (1 === a.pagingCount ? a.directionNav.addClass(b) : 0 === a.animatingTo ? a.directionNav.removeClass(b).filter("." + e + "prev").addClass(b) : a.animatingTo === a.last ? a.directionNav.removeClass(b).filter("." + e + "next").addClass(b) : a.directionNav.removeClass(b))
        } 
        }, pausePlay: { setup: function () {
            var b = d('<div class="' + e + 'pauseplay"><a></a></div>'); a.controlsContainer ? (a.controlsContainer.append(b), a.pausePlay = d("." + e + "pauseplay a", a.controlsContainer)) : (a.append(b), a.pausePlay = d("." + e + "pauseplay a",
a)); f.pausePlay.update(c.slideshow ? e + "pause" : e + "play"); a.pausePlay.bind(s, function (b) { b.preventDefault(); if (d(this).hasClass(e + "pause")) { a.pause(); a.manualPause = true } else { a.play(); a.manualPause = false } }); o && a.pausePlay.bind("click touchstart", function (a) { a.preventDefault() })
        }, update: function (b) { "play" === b ? a.pausePlay.removeClass(e + "pause").addClass(e + "play").text(c.playText) : a.pausePlay.removeClass(e + "play").addClass(e + "pause").text(c.pauseText) } 
        }, touch: function () {
            function b(b) {
                j = l ? d - b.touches[0].pageY :
d - b.touches[0].pageX; o = l ? Math.abs(j) < Math.abs(b.touches[0].pageX - e) : Math.abs(j) < Math.abs(b.touches[0].pageY - e); if (!o || 500 < Number(new Date) - k) b.preventDefault(), !p && a.transitions && (c.animationLoop || (j /= 0 === a.currentSlide && 0 > j || a.currentSlide === a.last && 0 < j ? Math.abs(j) / n + 2 : 1), a.setProps(f + j, "setTouch"))
            } function g() {
                if (a.animatingTo === a.currentSlide && !o && null !== j) {
                    var i = m ? -j : j, l = 0 < i ? a.getTarget("next") : a.getTarget("prev"); a.canAdvance(l) && (550 > Number(new Date) - k && 20 < Math.abs(i) || Math.abs(i) > n / 2) ? a.flexAnimate(l,
c.pauseOnAction) : a.flexAnimate(a.currentSlide, c.pauseOnAction, !0)
                } h.removeEventListener("touchmove", b, !1); h.removeEventListener("touchend", g, !1); f = j = e = d = null
            } var d, e, f, n, j, k, o = !1; h.addEventListener("touchstart", function (j) {
                a.animating ? j.preventDefault() : 1 === j.touches.length && (a.pause(), n = l ? a.h : a.w, k = Number(new Date), f = i && m && a.animatingTo === a.last ? 0 : i && m ? a.limit - (a.itemW + c.itemMargin) * a.move * a.animatingTo : i && a.currentSlide === a.last ? a.limit : i ? (a.itemW + c.itemMargin) * a.move * a.currentSlide : m ? (a.last - a.currentSlide +
a.cloneOffset) * n : (a.currentSlide + a.cloneOffset) * n, d = l ? j.touches[0].pageY : j.touches[0].pageX, e = l ? j.touches[0].pageX : j.touches[0].pageY, h.addEventListener("touchmove", b, !1), h.addEventListener("touchend", g, !1))
            }, !1)
        }, resize: function () {
            !a.animating && a.is(":visible") && (i || a.doMath(), p ? f.smoothHeight() : i ? (a.slides.width(a.computedW), a.update(a.pagingCount), a.setProps()) : l ? (a.viewport.height(a.h), a.setProps(a.h, "setTotal")) : (c.smoothHeight && f.smoothHeight(), a.newSlides.width(a.computedW), a.setProps(a.computedW,
"setTotal")))
        }, smoothHeight: function (b) { if (!l || p) { var c = p ? a : a.viewport; b ? c.animate({ height: a.slides.eq(a.animatingTo).height() }, b) : c.height(a.slides.eq(a.animatingTo).height()) } }, sync: function (b) { var g = d(c.sync).data("flexslider"), e = a.animatingTo; switch (b) { case "animate": g.flexAnimate(e, c.pauseOnAction, !1, !0); break; case "play": !g.playing && !g.asNav && g.play(); break; case "pause": g.pause() } } 
        }; a.flexAnimate = function (b, g, q, h, k) {
            if (!a.animating && (a.canAdvance(b) || q) && a.is(":visible")) {
                if (r && h) if (q = d(c.asNavFor).data("flexslider"),
a.atEnd = 0 === b || b === a.count - 1, q.flexAnimate(b, !0, !1, !0, k), a.direction = a.currentItem < b ? "next" : "prev", q.direction = a.direction, Math.ceil((b + 1) / a.visible) - 1 !== a.currentSlide && 0 !== b) a.currentItem = b, a.slides.removeClass(e + "active-slide").eq(b).addClass(e + "active-slide"), b = Math.floor(b / a.visible); else return a.currentItem = b, a.slides.removeClass(e + "active-slide").eq(b).addClass(e + "active-slide"), !1; a.animating = !0; a.animatingTo = b; c.before(a); g && a.pause(); a.syncExists && !k && f.sync("animate"); c.controlNav && f.controlNav.active();
                i || a.slides.removeClass(e + "active-slide").eq(b).addClass(e + "active-slide"); a.atEnd = 0 === b || b === a.last; c.directionNav && f.directionNav.update(); b === a.last && (c.end(a), c.animationLoop || a.pause()); if (p) a.slides.eq(a.currentSlide).fadeOut(c.animationSpeed, c.easing), a.slides.eq(b).fadeIn(c.animationSpeed, c.easing, a.wrapup); else {
                    var n = l ? a.slides.filter(":first").height() : a.computedW; i ? (b = c.itemWidth > a.w ? 2 * c.itemMargin : c.itemMargin, b = (a.itemW + b) * a.move * a.animatingTo, b = b > a.limit && 1 !== a.visible ? a.limit : b) : b =
0 === a.currentSlide && b === a.count - 1 && c.animationLoop && "next" !== a.direction ? m ? (a.count + a.cloneOffset) * n : 0 : a.currentSlide === a.last && 0 === b && c.animationLoop && "prev" !== a.direction ? m ? 0 : (a.count + 1) * n : m ? (a.count - 1 - b + a.cloneOffset) * n : (b + a.cloneOffset) * n; a.setProps(b, "", c.animationSpeed); if (a.transitions) { if (!c.animationLoop || !a.atEnd) a.animating = !1, a.currentSlide = a.animatingTo; a.container.unbind("webkitTransitionEnd transitionend"); a.container.bind("webkitTransitionEnd transitionend", function () { a.wrapup(n) }) } else a.container.animate(a.args,
c.animationSpeed, c.easing, function () { a.wrapup(n) })
                } c.smoothHeight && f.smoothHeight(c.animationSpeed)
            } 
        }; a.wrapup = function (b) { !p && !i && (0 === a.currentSlide && a.animatingTo === a.last && c.animationLoop ? a.setProps(b, "jumpEnd") : a.currentSlide === a.last && (0 === a.animatingTo && c.animationLoop) && a.setProps(b, "jumpStart")); a.animating = !1; a.currentSlide = a.animatingTo; c.after(a) }; a.animateSlides = function () { a.animating || a.flexAnimate(a.getTarget("next")) }; a.pause = function () {
            clearInterval(a.animatedSlides); a.playing = !1;
            c.pausePlay && f.pausePlay.update("play"); a.syncExists && f.sync("pause")
        }; a.play = function () { a.animatedSlides = setInterval(a.animateSlides, c.slideshowSpeed); a.playing = !0; c.pausePlay && f.pausePlay.update("pause"); a.syncExists && f.sync("play") }; a.canAdvance = function (b) {
            var d = r ? a.pagingCount - 1 : a.last; return r && 0 === a.currentItem && b === a.pagingCount - 1 && "next" !== a.direction ? !1 : b === a.currentSlide && !r ? !1 : c.animationLoop ? !0 : a.atEnd && 0 === a.currentSlide && b === d && "next" !== a.direction ? !1 : a.atEnd && a.currentSlide === d && 0 ===
b && "next" === a.direction ? !1 : !0
        }; a.getTarget = function (b) { a.direction = b; return "next" === b ? a.currentSlide === a.last ? 0 : a.currentSlide + 1 : 0 === a.currentSlide ? a.last : a.currentSlide - 1 }; a.setProps = function (b, d, e) {
            var f = function () {
                var e = b ? b : (a.itemW + c.itemMargin) * a.move * a.animatingTo; return -1 * function () {
                    if (i) return "setTouch" === d ? b : m && a.animatingTo === a.last ? 0 : m ? a.limit - (a.itemW + c.itemMargin) * a.move * a.animatingTo : a.animatingTo === a.last ? a.limit : e; switch (d) {
                        case "setTotal": return m ? (a.count - 1 - a.currentSlide + a.cloneOffset) *
                                b : (a.currentSlide + a.cloneOffset) * b; case "setTouch": return b; case "jumpEnd": return m ? b : a.count * b; case "jumpStart": return m ? a.count * b : b; default: return b
                    } 
                } () + "px"
            } (); a.transitions && (f = l ? "translate3d(0," + f + ",0)" : "translate3d(" + f + ",0,0)", e = void 0 !== e ? e / 1E3 + "s" : "0s", a.container.css("-" + a.pfx + "-transition-duration", e)); a.args[a.prop] = f; (a.transitions || void 0 === e) && a.container.css(a.args)
        }; a.setup = function (b) {
            if (p) a.slides.css({ width: "100%", "float": "left", marginRight: "-100%", position: "relative" }), "init" ===
b && a.slides.eq(a.currentSlide).fadeIn(c.animationSpeed, c.easing), c.smoothHeight && f.smoothHeight(); else {
                var g, h; "init" === b && (a.viewport = d('<div class="flex-viewport"></div>').css({ overflow: "hidden", position: "relative" }).appendTo(a).append(a.container), a.cloneCount = 0, a.cloneOffset = 0, m && (h = d.makeArray(a.slides).reverse(), a.slides = d(h), a.container.empty().append(a.slides))); c.animationLoop && !i && (a.cloneCount = 2, a.cloneOffset = 1, "init" !== b && a.container.find(".clone").remove(), a.container.append(a.slides.first().clone().addClass("clone")).prepend(a.slides.last().clone().addClass("clone")));
                a.newSlides = d(c.selector, a); g = m ? a.count - 1 - a.currentSlide + a.cloneOffset : a.currentSlide + a.cloneOffset; l && !i ? (a.container.height(200 * (a.count + a.cloneCount) + "%").css("position", "absolute").width("100%"), setTimeout(function () { a.newSlides.css({ display: "block" }); a.doMath(); a.viewport.height(a.h); a.setProps(g * a.h, "init") }, "init" === b ? 100 : 0)) : (a.container.width(200 * (a.count + a.cloneCount) + "%"), a.setProps(g * a.computedW, "init"), setTimeout(function () {
                    a.doMath(); a.newSlides.css({ width: a.computedW, "float": "left",
                        display: "block"
                    }); c.smoothHeight && f.smoothHeight()
                }, "init" === b ? 100 : 0))
            } i || a.slides.removeClass(e + "active-slide").eq(a.currentSlide).addClass(e + "active-slide")
        }; a.doMath = function () {
            var b = a.slides.first(), d = c.itemMargin, e = c.minItems, f = c.maxItems; a.w = a.width(); a.h = b.height(); a.boxPadding = b.outerWidth() - b.width(); i ? (a.itemT = c.itemWidth + d, a.minW = e ? e * a.itemT : a.w, a.maxW = f ? f * a.itemT : a.w, a.itemW = a.minW > a.w ? (a.w - d * e) / e : a.maxW < a.w ? (a.w - d * f) / f : c.itemWidth > a.w ? a.w : c.itemWidth, a.visible = Math.floor(a.w / (a.itemW +
d)), a.move = 0 < c.move && c.move < a.visible ? c.move : a.visible, a.pagingCount = Math.ceil((a.count - a.visible) / a.move + 1), a.last = a.pagingCount - 1, a.limit = 1 === a.pagingCount ? 0 : c.itemWidth > a.w ? (a.itemW + 2 * d) * a.count - a.w - d : (a.itemW + d) * a.count - a.w) : (a.itemW = a.w, a.pagingCount = a.count, a.last = a.count - 1); a.computedW = a.itemW - a.boxPadding
        }; a.update = function (b, d) {
            a.doMath(); i || (b < a.currentSlide ? a.currentSlide += 1 : b <= a.currentSlide && 0 !== b && (a.currentSlide -= 1), a.animatingTo = a.currentSlide); if (c.controlNav && !a.manualControls) if ("add" ===
d && !i || a.pagingCount > a.controlNav.length) f.controlNav.update("add"); else if ("remove" === d && !i || a.pagingCount < a.controlNav.length) i && a.currentSlide > a.last && (a.currentSlide -= 1, a.animatingTo -= 1), f.controlNav.update("remove", a.last); c.directionNav && f.directionNav.update()
        }; a.addSlide = function (b, e) {
            var f = d(b); a.count += 1; a.last = a.count - 1; l && m ? void 0 !== e ? a.slides.eq(a.count - e).after(f) : a.container.prepend(f) : void 0 !== e ? a.slides.eq(e).before(f) : a.container.append(f); a.update(e, "add"); a.slides = d(c.selector +
":not(.clone)", a); a.setup(); c.added(a)
        }; a.removeSlide = function (b) { var e = isNaN(b) ? a.slides.index(d(b)) : b; a.count -= 1; a.last = a.count - 1; isNaN(b) ? d(b, a.slides).remove() : l && m ? a.slides.eq(a.last).remove() : a.slides.eq(b).remove(); a.doMath(); a.update(e, "remove"); a.slides = d(c.selector + ":not(.clone)", a); a.setup(); c.removed(a) }; f.init()
    }; d.flexslider.defaults = { namespace: "flex-", selector: ".slides > li", animation: "fade", easing: "swing", direction: "horizontal", reverse: !1, animationLoop: !0, smoothHeight: !1, startAt: 0,
        slideshow: !0, slideshowSpeed: 7E3, animationSpeed: 600, initDelay: 0, randomize: !1, pauseOnAction: !0, pauseOnHover: !1, useCSS: !0, touch: !0, video: !1, controlNav: !0, directionNav: !0, prevText: "Previous", nextText: "Next", keyboard: !0, multipleKeyboard: !1, mousewheel: !1, pausePlay: !1, pauseText: "Pause", playText: "Play", controlsContainer: "", manualControls: "", sync: "", asNavFor: "", itemWidth: 0, itemMargin: 0, minItems: 0, maxItems: 0, move: 0, start: function () { }, before: function () { }, after: function () { }, end: function () { }, added: function () { },
        removed: function () { } 
    }; d.fn.flexslider = function (h) {
        h = h || {}; if ("object" === typeof h) return this.each(function () { var a = d(this), c = a.find(h.selector ? h.selector : ".slides > li"); 1 === c.length ? (c.fadeIn(400), h.start && h.start(a)) : void 0 === a.data("flexslider") && new d.flexslider(this, h) }); var k = d(this).data("flexslider"); switch (h) {
            case "play": k.play(); break; case "pause": k.pause(); break; case "next": k.flexAnimate(k.getTarget("next"), !0); break; case "prev": case "previous": k.flexAnimate(k.getTarget("prev"), !0); break;
            default: "number" === typeof h && k.flexAnimate(h, !0)
        } 
    } 
})(jQuery);


/*	Class: prettyPhoto
Use: Lightbox clone for jQuery
Author: Stephane Caron (http://www.no-margin-for-errors.com)
Version: 3.1.4 */
(function ($) {
    $.prettyPhoto = { version: '3.1.4' }; $.fn.prettyPhoto = function (pp_settings) {
        pp_settings = jQuery.extend({ hook: 'rel', animation_speed: 'fast', ajaxcallback: function () { }, slideshow: 5000, autoplay_slideshow: false, opacity: 0.80, show_title: true, allow_resize: true, allow_expand: true, default_width: 500, default_height: 344, counter_separator_label: '/', theme: 'pp_default', horizontal_padding: 20, hideflash: false, wmode: 'opaque', autoplay: true, modal: false, deeplinking: true, overlay_gallery: true, overlay_gallery_max: 30, keyboard_shortcuts: true, changepicturecallback: function () { }, callback: function () { }, ie6_fallback: true, markup: '<div class="pp_pic_holder"> \
      <div class="ppt">&nbsp;</div> \
      <div class="pp_top"> \
       <div class="pp_left"></div> \
       <div class="pp_middle"></div> \
       <div class="pp_right"></div> \
      </div> \
      <div class="pp_content_container"> \
       <div class="pp_left"> \
       <div class="pp_right"> \
        <div class="pp_content"> \
         <div class="pp_loaderIcon"></div> \
         <div class="pp_fade"> \
          <a href="#" class="pp_expand" title="Expand the image">Expand</a> \
          <div class="pp_hoverContainer"> \
           <a class="pp_next" href="#">next</a> \
           <a class="pp_previous" href="#">previous</a> \
          </div> \
          <div id="pp_full_res"></div> \
          <div class="pp_details"> \
           <div class="pp_nav"> \
            <a href="#" class="pp_arrow_previous">Previous</a> \
            <p class="currentTextHolder">0/0</p> \
            <a href="#" class="pp_arrow_next">Next</a> \
           </div> \
           <p class="pp_description"></p> \
           <a class="pp_close" href="#">Close</a> \
          </div> \
         </div> \
        </div> \
       </div> \
       </div> \
      </div> \
      <div class="pp_bottom"> \
       <div class="pp_left"></div> \
       <div class="pp_middle"></div> \
       <div class="pp_right"></div> \
      </div> \
     </div> \
     <div class="pp_overlay"></div>', gallery_markup: '<div class="pp_gallery"> \
        <a href="#" class="pp_arrow_previous">Previous</a> \
        <div> \
         <ul> \
          {gallery} \
         </ul> \
        </div> \
        <a href="#" class="pp_arrow_next">Next</a> \
       </div>', image_markup: '<img id="fullResImage" src="{path}" />', flash_markup: '<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="{width}" height="{height}"><param name="wmode" value="{wmode}" /><param name="allowfullscreen" value="true" /><param name="allowscriptaccess" value="always" /><param name="movie" value="{path}" /><embed src="{path}" type="application/x-shockwave-flash" allowfullscreen="true" allowscriptaccess="always" width="{width}" height="{height}" wmode="{wmode}"></embed></object>', quicktime_markup: '<object classid="clsid:02BF25D5-8C17-4B23-BC80-D3488ABDDC6B" codebase="http://www.apple.com/qtactivex/qtplugin.cab" height="{height}" width="{width}"><param name="src" value="{path}"><param name="autoplay" value="{autoplay}"><param name="type" value="video/quicktime"><embed src="{path}" height="{height}" width="{width}" autoplay="{autoplay}" type="video/quicktime" pluginspage="http://www.apple.com/quicktime/download/"></embed></object>', iframe_markup: '<iframe src ="{path}" width="{width}" height="{height}" frameborder="no"></iframe>', inline_markup: '<div class="pp_inline">{content}</div>', custom_markup: '', social_tools: '<div class="twitter"><a href="http://twitter.com/share" class="twitter-share-button" data-count="none">Tweet</a><script type="text/javascript" src="http://platform.twitter.com/widgets.js"></script></div><div class="facebook"><iframe src="//www.facebook.com/plugins/like.php?locale=en_US&href={location_href}&amp;layout=button_count&amp;show_faces=true&amp;width=500&amp;action=like&amp;font&amp;colorscheme=light&amp;height=23" scrolling="no" frameborder="0" style="border:none; overflow:hidden; width:500px; height:23px;" allowTransparency="true"></iframe></div>'
        }, pp_settings); var matchedObjects = this, percentBased = false, pp_dimensions, pp_open, pp_contentHeight, pp_contentWidth, pp_containerHeight, pp_containerWidth, windowHeight = $(window).height(), windowWidth = $(window).width(), pp_slideshow; doresize = true, scroll_pos = _get_scroll(); $(window).unbind('resize.prettyphoto').bind('resize.prettyphoto', function () { _center_overlay(); _resize_overlay(); }); if (pp_settings.keyboard_shortcuts) {
            $(document).unbind('keydown.prettyphoto').bind('keydown.prettyphoto', function (e) {
                if (typeof $pp_pic_holder != 'undefined') {
                    if ($pp_pic_holder.is(':visible')) {
                        switch (e.keyCode) {
                            case 37: $.prettyPhoto.changePage('previous'); e.preventDefault(); break; case 39: $.prettyPhoto.changePage('next'); e.preventDefault(); break; case 27: if (!settings.modal)
                                $.prettyPhoto.close(); e.preventDefault(); break;
                        };
                    };
                };
            });
        }; $.prettyPhoto.initialize = function () {
            settings = pp_settings; if (settings.theme == 'pp_default') settings.horizontal_padding = 16; if (settings.ie6_fallback && $.browser.msie && parseInt($.browser.version) == 6) settings.theme = "light_square"; theRel = $(this).attr(settings.hook); galleryRegExp = /\[(?:.*)\]/; isSet = (galleryRegExp.exec(theRel)) ? true : false; pp_images = (isSet) ? jQuery.map(matchedObjects, function (n, i) { if ($(n).attr(settings.hook).indexOf(theRel) != -1) return $(n).attr('href'); }) : $.makeArray($(this).attr('href')); pp_titles = (isSet) ? jQuery.map(matchedObjects, function (n, i) { if ($(n).attr(settings.hook).indexOf(theRel) != -1) return ($(n).find('img').attr('alt')) ? $(n).find('img').attr('alt') : ""; }) : $.makeArray($(this).find('img').attr('alt')); pp_descriptions = (isSet) ? jQuery.map(matchedObjects, function (n, i) { if ($(n).attr(settings.hook).indexOf(theRel) != -1) return ($(n).attr('title')) ? $(n).attr('title') : ""; }) : $.makeArray($(this).attr('title')); if (pp_images.length > settings.overlay_gallery_max) settings.overlay_gallery = false; set_position = jQuery.inArray($(this).attr('href'), pp_images); rel_index = (isSet) ? set_position : $("a[" + settings.hook + "^='" + theRel + "']").index($(this)); _build_overlay(this); if (settings.allow_resize)
                $(window).bind('scroll.prettyphoto', function () { _center_overlay(); }); $.prettyPhoto.open(); return false;
        }
        $.prettyPhoto.open = function (event) {
            if (typeof settings == "undefined") { settings = pp_settings; if ($.browser.msie && $.browser.version == 6) settings.theme = "light_square"; pp_images = $.makeArray(arguments[0]); pp_titles = (arguments[1]) ? $.makeArray(arguments[1]) : $.makeArray(""); pp_descriptions = (arguments[2]) ? $.makeArray(arguments[2]) : $.makeArray(""); isSet = (pp_images.length > 1) ? true : false; set_position = (arguments[3]) ? arguments[3] : 0; _build_overlay(event.target); }
            if ($.browser.msie && $.browser.version == 6) $('select').css('visibility', 'hidden'); if (settings.hideflash) $('object,embed,iframe[src*=youtube],iframe[src*=vimeo]').css('visibility', 'hidden'); _checkPosition($(pp_images).size()); $('.pp_loaderIcon').show(); if (settings.deeplinking)
                setHashtag(); if (settings.social_tools) { facebook_like_link = settings.social_tools.replace('{location_href}', encodeURIComponent(location.href)); $pp_pic_holder.find('.pp_social').html(facebook_like_link); }
            if ($ppt.is(':hidden')) $ppt.css('opacity', 0).show(); $pp_overlay.show().fadeTo(settings.animation_speed, settings.opacity); $pp_pic_holder.find('.currentTextHolder').text((set_position + 1) + settings.counter_separator_label + $(pp_images).size()); if (typeof pp_descriptions[set_position] != 'undefined' && pp_descriptions[set_position] != "") { $pp_pic_holder.find('.pp_description').show().html(unescape(pp_descriptions[set_position])); } else { $pp_pic_holder.find('.pp_description').hide(); }
            movie_width = (parseFloat(getParam('width', pp_images[set_position]))) ? getParam('width', pp_images[set_position]) : settings.default_width.toString(); movie_height = (parseFloat(getParam('height', pp_images[set_position]))) ? getParam('height', pp_images[set_position]) : settings.default_height.toString(); percentBased = false; if (movie_height.indexOf('%') != -1) { movie_height = parseFloat(($(window).height() * parseFloat(movie_height) / 100) - 150); percentBased = true; }
            if (movie_width.indexOf('%') != -1) { movie_width = parseFloat(($(window).width() * parseFloat(movie_width) / 100) - 150); percentBased = true; }
            $pp_pic_holder.fadeIn(function () {
                (settings.show_title && pp_titles[set_position] != "" && typeof pp_titles[set_position] != "undefined") ? $ppt.html(unescape(pp_titles[set_position])) : $ppt.html('&nbsp;'); imgPreloader = ""; skipInjection = false; switch (_getFileType(pp_images[set_position])) {
                    case 'image': imgPreloader = new Image(); nextImage = new Image(); if (isSet && set_position < $(pp_images).size() - 1) nextImage.src = pp_images[set_position + 1]; prevImage = new Image(); if (isSet && pp_images[set_position - 1]) prevImage.src = pp_images[set_position - 1]; $pp_pic_holder.find('#pp_full_res')[0].innerHTML = settings.image_markup.replace(/{path}/g, pp_images[set_position]); imgPreloader.onload = function () { pp_dimensions = _fitToViewport(imgPreloader.width, imgPreloader.height); _showContent(); }; imgPreloader.onerror = function () { alert('Image cannot be loaded. Make sure the path is correct and image exist.'); $.prettyPhoto.close(); }; imgPreloader.src = pp_images[set_position]; break; case 'youtube': pp_dimensions = _fitToViewport(movie_width, movie_height); movie_id = getParam('v', pp_images[set_position]); if (movie_id == "") {
                        movie_id = pp_images[set_position].split('youtu.be/'); movie_id = movie_id[1]; if (movie_id.indexOf('?') > 0)
                            movie_id = movie_id.substr(0, movie_id.indexOf('?')); if (movie_id.indexOf('&') > 0)
                                movie_id = movie_id.substr(0, movie_id.indexOf('&'));
                    }
                        movie = 'http://www.youtube.com/embed/' + movie_id; (getParam('rel', pp_images[set_position])) ? movie += "?rel=" + getParam('rel', pp_images[set_position]) : movie += "?rel=1"; if (settings.autoplay) movie += "&autoplay=1"; toInject = settings.iframe_markup.replace(/{width}/g, pp_dimensions['width']).replace(/{height}/g, pp_dimensions['height']).replace(/{wmode}/g, settings.wmode).replace(/{path}/g, movie); break; case 'vimeo': pp_dimensions = _fitToViewport(movie_width, movie_height); movie_id = pp_images[set_position]; var regExp = /http:\/\/(www\.)?vimeo.com\/(\d+)/; var match = movie_id.match(regExp); movie = 'http://player.vimeo.com/video/' + match[2] + '?title=0&amp;byline=0&amp;portrait=0'; if (settings.autoplay) movie += "&autoplay=1;"; vimeo_width = pp_dimensions['width'] + '/embed/?moog_width=' + pp_dimensions['width']; toInject = settings.iframe_markup.replace(/{width}/g, vimeo_width).replace(/{height}/g, pp_dimensions['height']).replace(/{path}/g, movie); break; case 'quicktime': pp_dimensions = _fitToViewport(movie_width, movie_height); pp_dimensions['height'] += 15; pp_dimensions['contentHeight'] += 15; pp_dimensions['containerHeight'] += 15; toInject = settings.quicktime_markup.replace(/{width}/g, pp_dimensions['width']).replace(/{height}/g, pp_dimensions['height']).replace(/{wmode}/g, settings.wmode).replace(/{path}/g, pp_images[set_position]).replace(/{autoplay}/g, settings.autoplay); break; case 'flash': pp_dimensions = _fitToViewport(movie_width, movie_height); flash_vars = pp_images[set_position]; flash_vars = flash_vars.substring(pp_images[set_position].indexOf('flashvars') + 10, pp_images[set_position].length); filename = pp_images[set_position]; filename = filename.substring(0, filename.indexOf('?')); toInject = settings.flash_markup.replace(/{width}/g, pp_dimensions['width']).replace(/{height}/g, pp_dimensions['height']).replace(/{wmode}/g, settings.wmode).replace(/{path}/g, filename + '?' + flash_vars); break; case 'iframe': pp_dimensions = _fitToViewport(movie_width, movie_height); frame_url = pp_images[set_position]; frame_url = frame_url.substr(0, frame_url.indexOf('iframe') - 1); toInject = settings.iframe_markup.replace(/{width}/g, pp_dimensions['width']).replace(/{height}/g, pp_dimensions['height']).replace(/{path}/g, frame_url); break; case 'ajax': doresize = false; pp_dimensions = _fitToViewport(movie_width, movie_height); doresize = true; skipInjection = true; $.get(pp_images[set_position], function (responseHTML) { toInject = settings.inline_markup.replace(/{content}/g, responseHTML); $pp_pic_holder.find('#pp_full_res')[0].innerHTML = toInject; _showContent(); }); break; case 'custom': pp_dimensions = _fitToViewport(movie_width, movie_height); toInject = settings.custom_markup; break; case 'inline': myClone = $(pp_images[set_position]).clone().append('<br clear="all" />').css({ 'width': settings.default_width }).wrapInner('<div id="pp_full_res"><div class="pp_inline"></div></div>').appendTo($('body')).show(); doresize = false; pp_dimensions = _fitToViewport($(myClone).width(), $(myClone).height()); doresize = true; $(myClone).remove(); toInject = settings.inline_markup.replace(/{content}/g, $(pp_images[set_position]).html()); break;
                }; if (!imgPreloader && !skipInjection) { $pp_pic_holder.find('#pp_full_res')[0].innerHTML = toInject; _showContent(); };
            }); return false;
        }; $.prettyPhoto.changePage = function (direction) {
            currentGalleryPage = 0; if (direction == 'previous') { set_position--; if (set_position < 0) set_position = $(pp_images).size() - 1; } else if (direction == 'next') { set_position++; if (set_position > $(pp_images).size() - 1) set_position = 0; } else { set_position = direction; }; rel_index = set_position; if (!doresize) doresize = true; if (settings.allow_expand) { $('.pp_contract').removeClass('pp_contract').addClass('pp_expand'); }
            _hideContent(function () { $.prettyPhoto.open(); });
        }; $.prettyPhoto.changeGalleryPage = function (direction) { if (direction == 'next') { currentGalleryPage++; if (currentGalleryPage > totalPage) currentGalleryPage = 0; } else if (direction == 'previous') { currentGalleryPage--; if (currentGalleryPage < 0) currentGalleryPage = totalPage; } else { currentGalleryPage = direction; }; slide_speed = (direction == 'next' || direction == 'previous') ? settings.animation_speed : 0; slide_to = currentGalleryPage * (itemsPerPage * itemWidth); $pp_gallery.find('ul').animate({ left: -slide_to }, slide_speed); }; $.prettyPhoto.startSlideshow = function () { if (typeof pp_slideshow == 'undefined') { $pp_pic_holder.find('.pp_play').unbind('click').removeClass('pp_play').addClass('pp_pause').click(function () { $.prettyPhoto.stopSlideshow(); return false; }); pp_slideshow = setInterval($.prettyPhoto.startSlideshow, settings.slideshow); } else { $.prettyPhoto.changePage('next'); }; }
        $.prettyPhoto.stopSlideshow = function () { $pp_pic_holder.find('.pp_pause').unbind('click').removeClass('pp_pause').addClass('pp_play').click(function () { $.prettyPhoto.startSlideshow(); return false; }); clearInterval(pp_slideshow); pp_slideshow = undefined; }
        $.prettyPhoto.close = function () { if ($pp_overlay.is(":animated")) return; $.prettyPhoto.stopSlideshow(); $pp_pic_holder.stop().find('object,embed').css('visibility', 'hidden'); $('div.pp_pic_holder,div.ppt,.pp_fade').fadeOut(settings.animation_speed, function () { $(this).remove(); }); $pp_overlay.fadeOut(settings.animation_speed, function () { if ($.browser.msie && $.browser.version == 6) $('select').css('visibility', 'visible'); if (settings.hideflash) $('object,embed,iframe[src*=youtube],iframe[src*=vimeo]').css('visibility', 'visible'); $(this).remove(); $(window).unbind('scroll.prettyphoto'); clearHashtag(); settings.callback(); doresize = true; pp_open = false; delete settings; }); }; function _showContent() {
            $('.pp_loaderIcon').hide(); projectedTop = scroll_pos['scrollTop'] + ((windowHeight / 2) - (pp_dimensions['containerHeight'] / 2)); if (projectedTop < 0) projectedTop = 0; $ppt.fadeTo(settings.animation_speed, 1); $pp_pic_holder.find('.pp_content').animate({ height: pp_dimensions['contentHeight'], width: pp_dimensions['contentWidth'] }, settings.animation_speed); $pp_pic_holder.animate({ 'top': projectedTop, 'left': ((windowWidth / 2) - (pp_dimensions['containerWidth'] / 2) < 0) ? 0 : (windowWidth / 2) - (pp_dimensions['containerWidth'] / 2), width: pp_dimensions['containerWidth'] }, settings.animation_speed, function () {
                $pp_pic_holder.find('.pp_hoverContainer,#fullResImage').height(pp_dimensions['height']).width(pp_dimensions['width']); $pp_pic_holder.find('.pp_fade').fadeIn(settings.animation_speed); if (isSet && _getFileType(pp_images[set_position]) == "image") { $pp_pic_holder.find('.pp_hoverContainer').show(); } else { $pp_pic_holder.find('.pp_hoverContainer').hide(); }
                if (settings.allow_expand) { if (pp_dimensions['resized']) { $('a.pp_expand,a.pp_contract').show(); } else { $('a.pp_expand').hide(); } }
                if (settings.autoplay_slideshow && !pp_slideshow && !pp_open) $.prettyPhoto.startSlideshow(); settings.changepicturecallback(); pp_open = true;
            }); _insert_gallery(); pp_settings.ajaxcallback();
        }; function _hideContent(callback) { $pp_pic_holder.find('#pp_full_res object,#pp_full_res embed').css('visibility', 'hidden'); $pp_pic_holder.find('.pp_fade').fadeOut(settings.animation_speed, function () { $('.pp_loaderIcon').show(); callback(); }); }; function _checkPosition(setCount) { (setCount > 1) ? $('.pp_nav').show() : $('.pp_nav').hide(); }; function _fitToViewport(width, height) { resized = false; _getDimensions(width, height); imageWidth = width, imageHeight = height; if (((pp_containerWidth > windowWidth) || (pp_containerHeight > windowHeight)) && doresize && settings.allow_resize && !percentBased) { resized = true, fitting = false; while (!fitting) { if ((pp_containerWidth > windowWidth)) { imageWidth = (windowWidth - 200); imageHeight = (height / width) * imageWidth; } else if ((pp_containerHeight > windowHeight)) { imageHeight = (windowHeight - 200); imageWidth = (width / height) * imageHeight; } else { fitting = true; }; pp_containerHeight = imageHeight, pp_containerWidth = imageWidth; }; _getDimensions(imageWidth, imageHeight); if ((pp_containerWidth > windowWidth) || (pp_containerHeight > windowHeight)) { _fitToViewport(pp_containerWidth, pp_containerHeight) }; }; return { width: Math.floor(imageWidth), height: Math.floor(imageHeight), containerHeight: Math.floor(pp_containerHeight), containerWidth: Math.floor(pp_containerWidth) + (settings.horizontal_padding * 2), contentHeight: Math.floor(pp_contentHeight), contentWidth: Math.floor(pp_contentWidth), resized: resized }; }; function _getDimensions(width, height) { width = parseFloat(width); height = parseFloat(height); $pp_details = $pp_pic_holder.find('.pp_details'); $pp_details.width(width); detailsHeight = parseFloat($pp_details.css('marginTop')) + parseFloat($pp_details.css('marginBottom')); $pp_details = $pp_details.clone().addClass(settings.theme).width(width).appendTo($('body')).css({ 'position': 'absolute', 'top': -10000 }); detailsHeight += $pp_details.height(); detailsHeight = (detailsHeight <= 34) ? 36 : detailsHeight; if ($.browser.msie && $.browser.version == 7) detailsHeight += 8; $pp_details.remove(); $pp_title = $pp_pic_holder.find('.ppt'); $pp_title.width(width); titleHeight = parseFloat($pp_title.css('marginTop')) + parseFloat($pp_title.css('marginBottom')); $pp_title = $pp_title.clone().appendTo($('body')).css({ 'position': 'absolute', 'top': -10000 }); titleHeight += $pp_title.height(); $pp_title.remove(); pp_contentHeight = height + detailsHeight; pp_contentWidth = width; pp_containerHeight = pp_contentHeight + titleHeight + $pp_pic_holder.find('.pp_top').height() + $pp_pic_holder.find('.pp_bottom').height(); pp_containerWidth = width; }
        function _getFileType(itemSrc) { if (itemSrc.match(/youtube\.com\/watch/i) || itemSrc.match(/youtu\.be/i)) { return 'youtube'; } else if (itemSrc.match(/vimeo\.com/i)) { return 'vimeo'; } else if (itemSrc.match(/\b.mov\b/i)) { return 'quicktime'; } else if (itemSrc.match(/\b.swf\b/i)) { return 'flash'; } else if (itemSrc.match(/\biframe=true\b/i)) { return 'iframe'; } else if (itemSrc.match(/\bajax=true\b/i)) { return 'ajax'; } else if (itemSrc.match(/\bcustom=true\b/i)) { return 'custom'; } else if (itemSrc.substr(0, 1) == '#') { return 'inline'; } else { return 'image'; }; }; function _center_overlay() {
            if (doresize && typeof $pp_pic_holder != 'undefined') {
                scroll_pos = _get_scroll(); contentHeight = $pp_pic_holder.height(), contentwidth = $pp_pic_holder.width(); projectedTop = (windowHeight / 2) + scroll_pos['scrollTop'] - (contentHeight / 2); if (projectedTop < 0) projectedTop = 0; if (contentHeight > windowHeight)
                    return; $pp_pic_holder.css({ 'top': projectedTop, 'left': (windowWidth / 2) + scroll_pos['scrollLeft'] - (contentwidth / 2) });
            };
        }; function _get_scroll() { if (self.pageYOffset) { return { scrollTop: self.pageYOffset, scrollLeft: self.pageXOffset }; } else if (document.documentElement && document.documentElement.scrollTop) { return { scrollTop: document.documentElement.scrollTop, scrollLeft: document.documentElement.scrollLeft }; } else if (document.body) { return { scrollTop: document.body.scrollTop, scrollLeft: document.body.scrollLeft }; }; }; function _resize_overlay() { windowHeight = $(window).height(), windowWidth = $(window).width(); if (typeof $pp_overlay != "undefined") $pp_overlay.height($(document).height()).width(windowWidth); }; function _insert_gallery() { if (isSet && settings.overlay_gallery && _getFileType(pp_images[set_position]) == "image" && (settings.ie6_fallback && !($.browser.msie && parseInt($.browser.version) == 6))) { itemWidth = 52 + 5; navWidth = (settings.theme == "facebook" || settings.theme == "pp_default") ? 50 : 30; itemsPerPage = Math.floor((pp_dimensions['containerWidth'] - 100 - navWidth) / itemWidth); itemsPerPage = (itemsPerPage < pp_images.length) ? itemsPerPage : pp_images.length; totalPage = Math.ceil(pp_images.length / itemsPerPage) - 1; if (totalPage == 0) { navWidth = 0; $pp_gallery.find('.pp_arrow_next,.pp_arrow_previous').hide(); } else { $pp_gallery.find('.pp_arrow_next,.pp_arrow_previous').show(); }; galleryWidth = itemsPerPage * itemWidth; fullGalleryWidth = pp_images.length * itemWidth; $pp_gallery.css('margin-left', -((galleryWidth / 2) + (navWidth / 2))).find('div:first').width(galleryWidth + 5).find('ul').width(fullGalleryWidth).find('li.selected').removeClass('selected'); goToPage = (Math.floor(set_position / itemsPerPage) < totalPage) ? Math.floor(set_position / itemsPerPage) : totalPage; $.prettyPhoto.changeGalleryPage(goToPage); $pp_gallery_li.filter(':eq(' + set_position + ')').addClass('selected'); } else { $pp_pic_holder.find('.pp_content').unbind('mouseenter mouseleave'); } }
        function _build_overlay(caller) {
            if (settings.social_tools)
                facebook_like_link = settings.social_tools.replace('{location_href}', encodeURIComponent(location.href)); settings.markup = settings.markup.replace('{pp_social}', ''); $('body').append(settings.markup); $pp_pic_holder = $('.pp_pic_holder'), $ppt = $('.ppt'), $pp_overlay = $('div.pp_overlay'); if (isSet && settings.overlay_gallery) {
                    currentGalleryPage = 0; toInject = ""; for (var i = 0; i < pp_images.length; i++) {
                        if (!pp_images[i].match(/\b(jpg|jpeg|png|gif)\b/gi)) { classname = 'default'; img_src = ''; } else { classname = ''; img_src = pp_images[i]; }
                        toInject += "<li class='" + classname + "'><a href='#'><img src='" + img_src + "' width='50' alt='' /></a></li>";
                    }; toInject = settings.gallery_markup.replace(/{gallery}/g, toInject); $pp_pic_holder.find('#pp_full_res').after(toInject); $pp_gallery = $('.pp_pic_holder .pp_gallery'), $pp_gallery_li = $pp_gallery.find('li'); $pp_gallery.find('.pp_arrow_next').click(function () { $.prettyPhoto.changeGalleryPage('next'); $.prettyPhoto.stopSlideshow(); return false; }); $pp_gallery.find('.pp_arrow_previous').click(function () { $.prettyPhoto.changeGalleryPage('previous'); $.prettyPhoto.stopSlideshow(); return false; }); $pp_pic_holder.find('.pp_content').hover(function () { $pp_pic_holder.find('.pp_gallery:not(.disabled)').fadeIn(); }, function () { $pp_pic_holder.find('.pp_gallery:not(.disabled)').fadeOut(); }); itemWidth = 52 + 5; $pp_gallery_li.each(function (i) { $(this).find('a').click(function () { $.prettyPhoto.changePage(i); $.prettyPhoto.stopSlideshow(); return false; }); });
                }; if (settings.slideshow) {
                    $pp_pic_holder.find('.pp_nav').prepend('<a href="#" class="pp_play">Play</a>')
                    $pp_pic_holder.find('.pp_nav .pp_play').click(function () { $.prettyPhoto.startSlideshow(); return false; });
                }
            $pp_pic_holder.attr('class', 'pp_pic_holder ' + settings.theme); $pp_overlay.css({ 'opacity': 0, 'height': $(document).height(), 'width': $(window).width() }).bind('click', function () { if (!settings.modal) $.prettyPhoto.close(); }); $('a.pp_close').bind('click', function () { $.prettyPhoto.close(); return false; }); if (settings.allow_expand) { $('a.pp_expand').bind('click', function (e) { if ($(this).hasClass('pp_expand')) { $(this).removeClass('pp_expand').addClass('pp_contract'); doresize = false; } else { $(this).removeClass('pp_contract').addClass('pp_expand'); doresize = true; }; _hideContent(function () { $.prettyPhoto.open(); }); return false; }); }
            $pp_pic_holder.find('.pp_previous, .pp_nav .pp_arrow_previous').bind('click', function () { $.prettyPhoto.changePage('previous'); $.prettyPhoto.stopSlideshow(); return false; }); $pp_pic_holder.find('.pp_next, .pp_nav .pp_arrow_next').bind('click', function () { $.prettyPhoto.changePage('next'); $.prettyPhoto.stopSlideshow(); return false; }); _center_overlay();
        }; if (!pp_alreadyInitialized && getHashtag()) { pp_alreadyInitialized = true; hashIndex = getHashtag(); hashRel = hashIndex; hashIndex = hashIndex.substring(hashIndex.indexOf('/') + 1, hashIndex.length - 1); hashRel = hashRel.substring(0, hashRel.indexOf('/')); setTimeout(function () { $("a[" + pp_settings.hook + "^='" + hashRel + "']:eq(" + hashIndex + ")").trigger('click'); }, 50); }
        return this.unbind('click.prettyphoto').bind('click.prettyphoto', $.prettyPhoto.initialize);
    }; function getHashtag() { url = location.href; hashtag = (url.indexOf('#prettyPhoto') !== -1) ? decodeURI(url.substring(url.indexOf('#prettyPhoto') + 1, url.length)) : false; return hashtag; }; function setHashtag() { if (typeof theRel == 'undefined') return; location.hash = theRel + '/' + rel_index + '/'; }; function clearHashtag() { if (location.href.indexOf('#prettyPhoto') !== -1) location.hash = "prettyPhoto"; }
    function getParam(name, url) { name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]"); var regexS = "[\\?&]" + name + "=([^&#]*)"; var regex = new RegExp(regexS); var results = regex.exec(url); return (results == null) ? "" : results[1]; } 
})(jQuery); var pp_alreadyInitialized = false;