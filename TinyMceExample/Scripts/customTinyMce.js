﻿$(document).ready(function () {
    /// <summary>
    /// Inicializa um editor de texto WYSIWYG html usando a biblioteca TinyMce
    /// Para maiores informações, acesse https://www.tinymce.com/docs/get-started/first-steps/
    ///</summary>
    
    var selector = '#' + $("textarea[tiny-mce-editor]").attr("id");

    // Initialize your tinyMCE Editor with your preferred options
    tinyMCE.init({
        // General options
        selector: selector,
        theme: "modern",

        // plugins
        plugins: "textcolor link image",

        // Theme options
        // theme_advanced_buttons1: "save,newdocument,|,bold,italic,underline,strikethrough,|,justifyleft,justifycenter,justifyright,justifyfull,|,styleselect,formatselect,fontselect,fontsizeselect",
        // theme_advanced_buttons2: "cut,copy,paste,pastetext,pasteword,|,search,replace,|,bullist,numlist,|,outdent,indent,blockquote,|,undo,redo,|,link,unlink,anchor,image,cleanup,help,code,|,insertdate,inserttime,preview,|,forecolor,backcolor",
        // theme_advanced_buttons3: "tablecontrols,|,hr,removeformat,visualaid,|,sub,sup,|,charmap,emotions,iespell,media,advhr,|,print,|,ltr,rtl,|,fullscreen",
        // theme_advanced_buttons4: "insertlayer,moveforward,movebackward,absolute,|,styleprops,spellchecker,|,cite,abbr,acronym,del,ins,attribs,|,visualchars,nonbreaking,template,blockquote,pagebreak,|,insertfile,insertimage",
        // theme_advanced_toolbar_location: "top",
        // theme_advanced_toolbar_align: "left",
        // theme_advanced_statusbar_location: "bottom",
        menubar: false,
        toolbar: [
            'undo redo | styleselect | bold italic | link image | forecolor backcolor | fontselect fontsizeselect | cut copy paste | alignleft aligncenter alignright'
        ],
        theme_advanced_resizing: false

        // Example content CSS (should be your site CSS)
        // content_css: "css/example.css",
    });
});