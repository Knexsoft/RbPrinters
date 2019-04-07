import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'aside',
  templateUrl: './app-sidebar.component.html',
  styleUrls:['./app-sidebar.component.css']
})

export  class AppSidebarComponent implements OnInit {
  constructor()
    {

  }
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  ngOnInit() {

  }
}
