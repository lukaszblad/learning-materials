<script setup>
    import { ref, onMounted } from 'vue';
    import JobListing from '@/components/JobListing.vue';
    import axios from 'axios';

    const jobs = ref([]);

    onMounted(async () => {
        try {
            const response = await axios.get('/api/jobs');
            jobs.value = response.data;
        }
        catch(error) {
            console.error("Error fetching jobs", error);
        }
    })
</script>

<template>
    <JobListing v-for="job in jobs" :key="job.id" :job="job" />
</template>
