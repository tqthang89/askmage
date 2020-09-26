import { Component } from '@angular/core';
declare var $: any;
@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

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
