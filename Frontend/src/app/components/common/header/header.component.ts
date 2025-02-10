import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { Menubar } from 'primeng/menubar';
import { ButtonModule } from 'primeng/button';
import { AvatarModule } from 'primeng/avatar';
import { Ripple } from 'primeng/ripple';
@Component({
  selector: 'app-header',
  imports: [ButtonModule, CommonModule, AvatarModule, Menubar, Ripple],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss',
  standalone: true,
})
export class HeaderComponent {
  iconUrl: string = 'assets/ui/ic_ui_zenny.svg';
  settingIconUrl: string = 'assets/ui/ic_ui_settings.svg';

  constructor(private router: Router) {}
  items: MenuItem[] | undefined;
  ngOnInit() {
    this.items = [
      {
        label: 'Directories',
        icon: 'pi pi-palette',
        items: [
          {
            label: 'Monsters',
            command: () => {
              this.router.navigate(['/monsters']);
            },
          },
          {
            label: 'Equipment',
            command: () => {
              this.router.navigate(['/equipment']);
            },
          },
        ],
      },
      {
        label: 'Builder',
        icon: 'pi pi-link',
        command: () => {
          this.router.navigate(['/builder']);
        },
      },
    ];
  }
}
