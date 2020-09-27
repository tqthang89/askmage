import { Component, OnInit } from '@angular/core';
declare var $: any;
@Component({
  selector: 'app-navigate-menu',
  templateUrl: './navigate-menu.component.html',
  styleUrls: ['./navigate-menu.component.css']
})
export class NavigateMenuComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  collapse() {
    $('.close-sidebar').on('click', function () {
      $('.sidebar').removeClass("open");
    });
  }

  toggle() {
    // this.isExpanded = !this.isExpanded;
    // alert(this.isExpanded);
    $('.navbar-item-toggler').on('click', function () {
      $('.sidebar').addClass("open");
    });
  }

  collapseSubMenu() {
    $('.panel-menu .accordion').on('show.bs.collapse', function (e) {
      $(e.target).prev('.card-header').addClass('active');
    });

    $('.panel-menu .accordion').on('hide.bs.collapse', function(e) {
      $(this).find('.card-header').not($(e.target)).removeClass('active');
    });
  }
}
