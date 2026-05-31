import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApiService } from '../../core/services/api.service';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [CommonModule],
  template: `
    <div class="dashboard">
      <h2>Dashboard</h2>
      <div class="content">
        <p>Welcome to RPG Gym!</p>
      </div>
    </div>
  `,
  styles: [`
    .dashboard {
      padding: 1rem;
    }

    h2 {
      color: #333;
      margin-bottom: 1rem;
    }

    .content {
      background-color: #f5f5f5;
      padding: 1rem;
      border-radius: 4px;
    }
  `]
})
export class DashboardComponent implements OnInit {
  constructor(private apiService: ApiService) {}

  ngOnInit(): void {
    // Initialize dashboard data
  }
}
